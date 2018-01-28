using ChartDemoForAthena.Container;
using ChartDemoForAthena.Entities;
using ChartDemoForAthena.Tools;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChartDemoForAthena.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public JsonResult TraceArchieveHistory(string archieveId)
        {
            dynamic dynObj = JsonConvert.DeserializeObject("{\"address\":\"0x2214ac3e4a030eebf0ded7c2043fec9997671860\",\"id\":\"Z109-WS·2011-Y-BGS-0001\",\"blockNumber\":67575,\"mtime\":1517105788,\"ctime\":1517105673,\"title\":[{\"time\":1517105788,\"value\":\"招标说明、预算、投标报价说明、中标通知书、工程决算审核报告、工程质量验收监督（综合）表、开工报告、施工组织设计、产品检验报告、合格证、砂浆、混凝土配合比\",\"deleted\":false},{\"time\":1517105683,\"value\":\"招标说明、预算、投标报价说明、中标通知书、工程决算审核报告、工程质量验收监督（综合）表、开工报告、施工组织设计、产品检验报告、合格证、砂浆、混凝土配合比\",\"deleted\":true}],\"projectTitle\":[{\"time\":1517105683,\"value\":\"安光所汽车库改造及扩建工程\",\"deleted\":false}],\"startDate\":[{\"time\":1517105788,\"value\":\"2003-03-27 16:00:00.000Z\",\"deleted\":false},{\"time\":1517105683,\"value\":\"2003-03-27 16:00:00.000Z\",\"deleted\":true}],\"endDate\":[{\"time\":1517105683,\"value\":\"2004-11-18 18:00:00.000Z\",\"deleted\":false}],\"responsible\":[{\"time\":1517105683,\"value\":\"合肥研究院合肥大杨建安公司\",\"deleted\":false}],\"author\":[{\"time\":1517105683,\"value\":\"naruto\",\"deleted\":false}],\"changeLog\":[{\"time\":1517105788,\"action\":\"update\",\"value\":{\"title\":\"招标说明、预算、投标报价说明、中标通知书、工程决算审核报告、工程质量验收监督（综合）表、开工报告、施工组织设计、产品检验报告、合格证、砂浆、混凝土配合比\",\"startDate\":\"2003-03-27 16:00:00.000Z\"}},{\"time\":1517105703,\"action\":\"delete\",\"value\":[\"title\",\"startDate\"]}]}");
            var jObj = (JObject)dynObj;
            var root = new NodeEntity
            {
                id = "0",
                name = archieveId,
                data = new TipsEntity
                {
                    value = "id of archieve"
                },
                children = new List<NodeEntity>()
            };
            var filenode = new NodeEntity
            {
                id = "1000",
                name = "File",
                data = new TipsEntity
                {
                    value = "file of archieve"
                },
                children = new List<NodeEntity>()
            };
            root.children.Add(filenode);
            int count = 1;
            foreach (JToken token in jObj.Children())
            {
                if (token is JProperty)
                {
                    var prop = token as JProperty;
                    if (!prop.Name.ToString().Equals("address") &&
                        !prop.Name.ToString().Equals("id") &&
                        !prop.Name.ToString().Equals("blockNumber") &&
                        !prop.Name.ToString().Equals("mtime") &&
                        !prop.Name.ToString().Equals("ctime") &&
                        !prop.Name.ToString().Equals("changeLog"))
                    {
                        if (!prop.Name.ToString().Contains(':'))// 判断是文件还是著录项
                        {
                            // 著录项
                            var node = new NodeEntity
                            {
                                id = count.ToString(),
                                name = prop.Name.ToString(),
                                children = new List<NodeEntity>(),
                                data = new TipsEntity { value = "attribute of archieve" }
                            };

                            if (prop.Value.HasValues)
                            {
                                int num = 1;
                                foreach (JToken item in prop.Value.Children())
                                {
                                    var node_entity = new NodeEntity
                                    {
                                        id = count + "" + num,
                                        name = Tools.Tools.ConvertTime(Convert.ToDouble(item["time"].ToString()))
                                    };
                                    if (!Convert.ToBoolean(item["deleted"]))
                                    {
                                        node_entity.data = new TipsEntity { value = "Update: " + item["value"].ToString() };
                                    }
                                    else
                                    {
                                        node_entity.data = new TipsEntity { value = "Detele: " + item["value"].ToString() };
                                    }
                                    node.children.Add(node_entity);
                                   
                                    num++;
                                }
                            }
                            else
                            {
                                node.data = prop.Value.ToString();
                            }
                            root.children.Add(node);
                        }
                        else
                        {
                            //文件
                            var file_childern_node = new NodeEntity
                            {
                                id = 1000 + "2" + count,
                                name = prop.Name.ToString().Split(':')[1],
                                data = new TipsEntity { value = "attribute of file" },
                                children = new List<NodeEntity>()
                            };
                            var file_childern_history_node = new NodeEntity();
                            if (prop.Value.HasValues)
                            {             
                                int num = 1;
                                foreach (JToken item in prop.Value.Children())
                                {
                                    file_childern_history_node.id = 1000 + "3" +count+ num;
                                    file_childern_history_node.name = Tools.Tools.ConvertTime(Convert.ToDouble(item["time"].ToString()));
                                    file_childern_history_node.data = new TipsEntity { value = "Update: " + item["value"].ToString() };
                                    num++;
                                    file_childern_node.children.Add(file_childern_history_node);
                                }
                            }

                            var node = new NodeEntity();
                            if (filenode.children.Where(c => c.name == prop.Name.ToString().Split(':')[0]).Count() == 0)
                            {
                                // 新文件信息
                                node.id = 1000 + "1" + count;
                                node.name = prop.Name.ToString().Split(':')[0];
                                node.data = new TipsEntity { value = "name of file" };
                                node.children = new List<NodeEntity>();                               
                                node.children.Add(file_childern_node);
                                root.children.Find(c => c.name == "File").children.Add(node);
                            }
                            else
                            {
                                filenode.children.Find(c => c.name == prop.Name.ToString().Split(':')[0]).children.Add(file_childern_node);
                            }
                        }
                    }
                    count++;
                }
            }
            
            return JsonReturnResult.json(1, "success", root);
        }
    }
}