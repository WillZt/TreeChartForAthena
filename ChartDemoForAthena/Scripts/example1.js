var labelType, useGradients, nativeTextSupport, animate;

var Log = {
  elem: false,
  write: function(text){
    if (!this.elem) 
      this.elem = document.getElementById('log');
    this.elem.innerHTML = text;
    this.elem.style.left = (500 - this.elem.offsetWidth / 2) + 'px';
  }
};

function init(){
    //init data
    var json;
    $.ajax({
        type: "GET",
        url: "/home/TraceArchieveHistory",
        data: { archieveId: 'Z109 - WS·2011-Y - BGS - 0001'},
        dataType: "json",
        async: false,
        success: function (data) {
            if (data._returncode === 1) {
                json = data._data;
            }
            console.log(data);
        }
    });

    var st = new $jit.ST({
        injectInto: 'infovis',
        constrained: true,
        duration: 800,
        transition: $jit.Trans.Quart.easeInOut,
        levelDistance: 100,
        offsetX: 150,

        Navigation: {
          enable:true,
          panning:true
        },

        Tips: {
            enable: true,
            onShow: function (tip, node) {
                tip.style.width = 'auto';
                tip.innerHTML = node.data.value;
            }
        },

        Node: {
            height: 40,
            width: 200,
            type: 'rectangle',
            color: '#8DEEEE',
            overridable: true,
            textAlign: "center"
        },
 
        Edge: {
            type: 'bezier',
            color: '#FFA07A',
            overridable: true
        },
        
        onBeforeCompute: function(node){
            Log.write("加载 " + node.data.value);
        },
        
        onAfterCompute: function(){
            Log.write("加载完成!");
        },
        
        onCreateLabel: function(label, node){
            label.id = node.id;
            if (node.data.isUrlShow) {
                label.innerHTML = '<a href=' + node.data.link + '>' + node.name + '</a>';
            } else {
                label.innerHTML = node.name;
            }
           
            label.onclick = function(){
				st.onClick(node.id);
            };
            label.herf = "dd";
            //set label styles
            var style = label.style;
            style.width = 200 + 'px';
            style.height = 40 + 'px';            
            style.cursor = 'pointer';
            style.color = '#eee';
            style.fontSize = '1.2em';
            style.textAlign = 'center';
            style.paddingTop = '5px';
        },
        
        onBeforePlotNode: function (node) {
            //alert(node.id);
            if (node.selected) {
                node.data.$color = "#8DEEEE";
            }
            else {
                delete node.data.$color;
                if(!node.anySubnode("exist")) {
                    var count = 0;
                    node.eachSubnode(function(n) { count++; });
                    node.data.$color = ['#aaa', '#baa', '#caa', '#daa', '#eaa', '#faa'][count];                    
                }
            }
        },
        
        onBeforePlotLine: function(adj){
            if (adj.nodeFrom.selected && adj.nodeTo.selected) {
                adj.data.$color = "#FF8000";
                adj.data.$lineWidth = 3;
            }
            else {
                delete adj.data.$color;
                delete adj.data.$lineWidth;
            }
        }
    });
    st.loadJSON(json);
    st.compute();
    st.geom.translate(new $jit.Complex(-200, 0), "current");
    st.onClick(st.root);  
}
