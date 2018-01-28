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
            //dynamic dynObj = JsonConvert.DeserializeObject("{\"address\":\"0x2880928ec8a714d67273b7e761e475a19072ee04\",\"id\":\"Z109-WS·2011-Y-BGS-0001\",\"blockNumber\":38736,\"mtime\":[{\"time\":1516845664,\"value\":\"\"}],\"ctime\":0,\"title\":[{\"time\":1516847249,\"value\":\"招标说明、预算、投标报价说明、中标通知书、工程决算审核报告、工程质量验收监督（综合）表、开工报告、施工组织设计、产品检验报告、合格证、砂浆、混凝土配合比\"},{\"time\":1516845664,\"value\":\"招标说明、预算、投标报价说明、中标通知书、工程决算审核报告、工程质量验收监督（综合）表、开工报告、施工组织设计、产品检验报告、合格证、砂浆、混凝土配合比\"}],\"projectTitle\":[{\"time\":1516845664,\"value\":\"安光所汽车库改造及扩建工程\"}],\"startDate\":[{\"time\":1516847254,\"value\":\"2003-03-27 16:00:00.000Z\"},{\"time\":1516845664,\"value\":\"2003-03-27 16:00:00.000Z\"}],\"endDate\":[{\"time\":1516845664,\"value\":\"2004-11-18 18:00:00.000Z\"}],\"responsible\":[{\"time\":1516845664,\"value\":\"合肥研究院合肥大杨建安公司\"}],\"contractAddr\":[{\"time\":1516845664,\"value\":\"0x2880928ec8a714d67273b7e761e475a19072ee04\"}],\"ID\":[{\"time\":1516845664,\"value\":\"Z109-WS·2011-Y-BGS-0001\"}],\"author\":[{\"time\":1516845734,\"value\":\"naruto\"}],\"AAAA:FileHash\":[{\"time\":1516846564,\"value\":\"821b5f8e54e80821d69a55e49a7da69774da9608\"}],\"BBBB:FileHash\":[{\"time\":1516846564,\"value\":\"40ede9054b10ded75742f64ce738c2e5595b03bc\"}],\"AAAA:FileName\":[{\"time\":1516846564,\"value\":\"AAAA\"}],\"BBBB:FileName\":[{\"time\":1516846564,\"value\":\"BBBB\"}],\"AAAA:FileTitle\":[{\"time\":1516846564,\"value\":\"比特猫\"}],\"BBBB:FileTitle\":[{\"time\":1516846569,\"value\":\"IPFS白皮书\"}],\"AAAA:FileType\":[{\"time\":1516846569,\"value\":\"保密\"}],\"BBBB:FileType\":[{\"time\":1516846569,\"value\":\"绝密\"}],\"AAAA:FileNote\":[{\"time\":1516846569,\"value\":\"\"}],\"BBBB:FileNote\":[{\"time\":1516846569,\"value\":\"\"}],\"blockchain-cat.pdf:FileHash\":[{\"time\":1516940969,\"value\":\"9cdca30bb059539696f6db02e405545e536f85ef\"},{\"time\":1516940449,\"value\":\"821b5f8e54e80821d69a55e49a7da69774da9608\"}],\"blockchain-cat.pdf:FileName\":[{\"time\":1516940454,\"value\":\"blockchain-cat.pdf\"}],\"blockchain-cat.pdf:FileTitle\":[{\"time\":1516940454,\"value\":\"比特猫\"}],\"blockchain-cat.pdf:FileType\":[{\"time\":1516940454,\"value\":\"保密\"}],\"blockchain-cat.pdf:FileNote\":[{\"time\":1516940969,\"value\":\"\"},{\"time\":1516940454,\"value\":\"\"}],\"198750-105.jpg:FileHash\":[{\"time\":1516961588,\"value\":\"b8b24c6af8a1d4ca15e26c12c8c4d44892ffc121\"}],\"198750-105.jpg:FileName\":[{\"time\":1516961588,\"value\":\"198750-105.jpg\"}],\"198750-105.jpg:FileTitle\":[{\"time\":1516961588,\"value\":\"比特猫\"}],\"198750-105.jpg:FileType\":[{\"time\":1516961588,\"value\":\"保密\"}],\"198750-105.jpg:FileNote\":[{\"time\":1516961593,\"value\":\"\"}],\"changeLog\":[{\"time\":1516961593,\"action\":\"update\",\"value\":{\"198750-105.jpg:IpfsAddr\":\"QmY1pZS71P9LW9PAxf8qrBmJSX8eD2RaitAeDAiHS2SsgC\",\"198750-105.jpg:FileHash\":\"b8b24c6af8a1d4ca15e26c12c8c4d44892ffc121\",\"198750-105.jpg:FileName\":\"198750-105.jpg\",\"198750-105.jpg:FileTitle\":\"比特猫\",\"198750-105.jpg:FileType\":\"保密\",\"198750-105.jpg:FileNote\":\"\"}},{\"time\":1516940969,\"action\":\"update\",\"value\":{\"blockchain-cat.pdf:IpfsAddr\":\"QmPiMUXGTuq3czkYecHsZCi8WExNY7yT7Myf99e9DDCmyX\",\"blockchain-cat.pdf:FileHash\":\"9cdca30bb059539696f6db02e405545e536f85ef\",\"blockchain-cat.pdf:FileNote\":\"\"}},{\"time\":1516940454,\"action\":\"update\",\"value\":{\"blockchain-cat.pdf:IpfsAddr\":\"QmdsiNfRvaiajtaEHuwHZpTUCSprojGexYBMJsQC2aVhqk\",\"blockchain-cat.pdf:FileHash\":\"821b5f8e54e80821d69a55e49a7da69774da9608\",\"blockchain-cat.pdf:FileName\":\"blockchain-cat.pdf\",\"blockchain-cat.pdf:FileTitle\":\"比特猫\",\"blockchain-cat.pdf:FileType\":\"保密\",\"blockchain-cat.pdf:FileNote\":\"\"}},{\"time\":1516847254,\"action\":\"update\",\"value\":{\"title\":\"招标说明、预算、投标报价说明、中标通知书、工程决算审核报告、工程质量验收监督（综合）表、开工报告、施工组织设计、产品检验报告、合格证、砂浆、混凝土配合比\",\"startDate\":\"2003-03-27 16:00:00.000Z\"}},{\"time\":1516846569,\"action\":\"update\",\"value\":{\"AAAA:IpfsAddr\":\"QmdsiNfRvaiajtaEHuwHZpTUCSprojGexYBMJsQC2aVhqk\",\"AAAA:FileHash\":\"821b5f8e54e80821d69a55e49a7da69774da9608\",\"BBBB:IpfsAddr\":\"QmV9tSDx9UiPeWExXEeH6aoDvmihvx6jD5eLb4jbTaKGps\",\"BBBB:FileHash\":\"40ede9054b10ded75742f64ce738c2e5595b03bc\",\"AAAA:FileName\":\"AAAA\",\"BBBB:FileName\":\"BBBB\",\"AAAA:FileTitle\":\"比特猫\",\"BBBB:FileTitle\":\"IPFS白皮书\",\"AAAA:FileType\":\"保密\",\"BBBB:FileType\":\"绝密\",\"AAAA:FileNote\":\"\",\"BBBB:FileNote\":\"\"}},{\"time\":1516845789,\"action\":\"delete\",\"value\":[\"title\",\"startDate\"]},{\"time\":1516845734,\"action\":\"update\",\"value\":{\"author\":\"naruto\"}}]}");
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