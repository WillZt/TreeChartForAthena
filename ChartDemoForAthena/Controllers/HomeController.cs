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
            dynamic dynObj = JsonConvert.DeserializeObject("{\"address\":\"0x13321e02091dde0684578d9b9482f3f908229c8a\",\"id\":\"7337271602E848F69F5F2977C0F22E1F\",\"blockNumber\":123737,\"mtime\":1517386598,\"ctime\":1517385648,\"QZH\":[{\"time\":1517385658,\"value\":\"zzz-2\",\"deleted\":false}],\"DH\":[{\"time\":1517385658,\"value\":\"00sync2\",\"deleted\":false}],\"XH\":[{\"time\":1517385658,\"value\":\"\",\"deleted\":false}],\"ND\":[{\"time\":1517385658,\"value\":\"\",\"deleted\":false}],\"WJBT\":[{\"time\":1517385658,\"value\":\"\",\"deleted\":false}],\"ZTC\":[{\"time\":1517385658,\"value\":\"\",\"deleted\":false}],\"BGQX\":[{\"time\":1517385658,\"value\":\"无纸质\",\"deleted\":false}],\"FLH\":[{\"time\":1517385658,\"value\":\"\",\"deleted\":false}],\"YS\":[{\"time\":1517386583,\"value\":\"1\",\"deleted\":false},{\"time\":1517385658,\"value\":\"\",\"deleted\":false}],\"MJ\":[{\"time\":1517385658,\"value\":\"机密\",\"deleted\":false}],\"WH\":[{\"time\":1517385658,\"value\":\"\",\"deleted\":false}],\"BZ\":[{\"time\":1517385658,\"value\":\"\",\"deleted\":false}],\"HH\":[{\"time\":1517385658,\"value\":\"\",\"deleted\":false}],\"ZRZ\":[{\"time\":1517385658,\"value\":\"\",\"deleted\":false}],\"CWRQ\":[{\"time\":1517385663,\"value\":\"\",\"deleted\":false}],\"ZLRQ\":[{\"time\":1517385663,\"value\":\"\",\"deleted\":false}],\"HNSM\":[{\"time\":1517385663,\"value\":\"\",\"deleted\":false}],\"BM\":[{\"time\":1517385683,\"value\":\"\",\"deleted\":false}],\"DC7B3646759944D18261BEF7382A7901.jpg:FileHash\":[{\"time\":1517385683,\"value\":\"8db5264b8f041151567e1445e60325181ba10664\",\"deleted\":false}],\"DC7B3646759944D18261BEF7382A7901.jpg:FileName\":[{\"time\":1517385683,\"value\":\"DC7B3646759944D18261BEF7382A7901.jpg\",\"deleted\":false}],\"DC7B3646759944D18261BEF7382A7901.jpg:FileTitle\":[{\"time\":1517385688,\"value\":\"dddddd\",\"deleted\":false}],\"DC7B3646759944D18261BEF7382A7901.jpg:FileType\":[{\"time\":1517385688,\"value\":\"正文\",\"deleted\":false}],\"DC7B3646759944D18261BEF7382A7901.jpg:FileNote\":[{\"time\":1517385688,\"value\":\"222\",\"deleted\":false}],\"changeLog\":[{\"time\":1517386598,\"action\":\"update\",\"value\":{\"YS\":\"1\"}},{\"time\":1517385688,\"action\":\"update\",\"value\":{\"DC7B3646759944D18261BEF7382A7901.jpg:IpfsAddr\":\"QmWJeMMAzMJ2GysDTRY8Mdf73n6HKyHiqsVgzZTxhm99ZD\",\"DC7B3646759944D18261BEF7382A7901.jpg:FileHash\":\"8db5264b8f041151567e1445e60325181ba10664\",\"DC7B3646759944D18261BEF7382A7901.jpg:FileName\":\"DC7B3646759944D18261BEF7382A7901.jpg\",\"DC7B3646759944D18261BEF7382A7901.jpg:FileTitle\":\"dddddd\",\"DC7B3646759944D18261BEF7382A7901.jpg:FileType\":\"正文\",\"DC7B3646759944D18261BEF7382A7901.jpg:FileNote\":\"222\"}}]}");
            //dynamic dynObj = JsonConvert.DeserializeObject("{\"address\":\"0x2880928ec8a714d67273b7e761e475a19072ee04\",\"id\":\"Z109-WS·2011-Y-BGS-0001\",\"blockNumber\":38736,\"mtime\":[{\"time\":1516845664,\"value\":\"\"}],\"ctime\":0,\"title\":[{\"time\":1516847249,\"value\":\"招标说明、预算、投标报价说明、中标通知书、工程决算审核报告、工程质量验收监督（综合）表、开工报告、施工组织设计、产品检验报告、合格证、砂浆、混凝土配合比\"},{\"time\":1516845664,\"value\":\"招标说明、预算、投标报价说明、中标通知书、工程决算审核报告、工程质量验收监督（综合）表、开工报告、施工组织设计、产品检验报告、合格证、砂浆、混凝土配合比\"}],\"projectTitle\":[{\"time\":1516845664,\"value\":\"安光所汽车库改造及扩建工程\"}],\"startDate\":[{\"time\":1516847254,\"value\":\"2003-03-27 16:00:00.000Z\"},{\"time\":1516845664,\"value\":\"2003-03-27 16:00:00.000Z\"}],\"endDate\":[{\"time\":1516845664,\"value\":\"2004-11-18 18:00:00.000Z\"}],\"responsible\":[{\"time\":1516845664,\"value\":\"合肥研究院合肥大杨建安公司\"}],\"contractAddr\":[{\"time\":1516845664,\"value\":\"0x2880928ec8a714d67273b7e761e475a19072ee04\"}],\"ID\":[{\"time\":1516845664,\"value\":\"Z109-WS·2011-Y-BGS-0001\"}],\"author\":[{\"time\":1516845734,\"value\":\"naruto\"}],\"AAAA:FileHash\":[{\"time\":1516846564,\"value\":\"821b5f8e54e80821d69a55e49a7da69774da9608\"}],\"BBBB:FileHash\":[{\"time\":1516846564,\"value\":\"40ede9054b10ded75742f64ce738c2e5595b03bc\"}],\"AAAA:FileName\":[{\"time\":1516846564,\"value\":\"AAAA\"}],\"BBBB:FileName\":[{\"time\":1516846564,\"value\":\"BBBB\"}],\"AAAA:FileTitle\":[{\"time\":1516846564,\"value\":\"比特猫\"}],\"BBBB:FileTitle\":[{\"time\":1516846569,\"value\":\"IPFS白皮书\"}],\"AAAA:FileType\":[{\"time\":1516846569,\"value\":\"保密\"}],\"BBBB:FileType\":[{\"time\":1516846569,\"value\":\"绝密\"}],\"AAAA:FileNote\":[{\"time\":1516846569,\"value\":\"\"}],\"BBBB:FileNote\":[{\"time\":1516846569,\"value\":\"\"}],\"blockchain-cat.pdf:FileHash\":[{\"time\":1516940969,\"value\":\"9cdca30bb059539696f6db02e405545e536f85ef\"},{\"time\":1516940449,\"value\":\"821b5f8e54e80821d69a55e49a7da69774da9608\"}],\"blockchain-cat.pdf:FileName\":[{\"time\":1516940454,\"value\":\"blockchain-cat.pdf\"}],\"blockchain-cat.pdf:FileTitle\":[{\"time\":1516940454,\"value\":\"比特猫\"}],\"blockchain-cat.pdf:FileType\":[{\"time\":1516940454,\"value\":\"保密\"}],\"blockchain-cat.pdf:FileNote\":[{\"time\":1516940969,\"value\":\"\"},{\"time\":1516940454,\"value\":\"\"}],\"198750-105.jpg:FileHash\":[{\"time\":1516961588,\"value\":\"b8b24c6af8a1d4ca15e26c12c8c4d44892ffc121\"}],\"198750-105.jpg:FileName\":[{\"time\":1516961588,\"value\":\"198750-105.jpg\"}],\"198750-105.jpg:FileTitle\":[{\"time\":1516961588,\"value\":\"比特猫\"}],\"198750-105.jpg:FileType\":[{\"time\":1516961588,\"value\":\"保密\"}],\"198750-105.jpg:FileNote\":[{\"time\":1516961593,\"value\":\"\"}],\"changeLog\":[{\"time\":1516961593,\"action\":\"update\",\"value\":{\"198750-105.jpg:IpfsAddr\":\"QmY1pZS71P9LW9PAxf8qrBmJSX8eD2RaitAeDAiHS2SsgC\",\"198750-105.jpg:FileHash\":\"b8b24c6af8a1d4ca15e26c12c8c4d44892ffc121\",\"198750-105.jpg:FileName\":\"198750-105.jpg\",\"198750-105.jpg:FileTitle\":\"比特猫\",\"198750-105.jpg:FileType\":\"保密\",\"198750-105.jpg:FileNote\":\"\"}},{\"time\":1516940969,\"action\":\"update\",\"value\":{\"blockchain-cat.pdf:IpfsAddr\":\"QmPiMUXGTuq3czkYecHsZCi8WExNY7yT7Myf99e9DDCmyX\",\"blockchain-cat.pdf:FileHash\":\"9cdca30bb059539696f6db02e405545e536f85ef\",\"blockchain-cat.pdf:FileNote\":\"\"}},{\"time\":1516940454,\"action\":\"update\",\"value\":{\"blockchain-cat.pdf:IpfsAddr\":\"QmdsiNfRvaiajtaEHuwHZpTUCSprojGexYBMJsQC2aVhqk\",\"blockchain-cat.pdf:FileHash\":\"821b5f8e54e80821d69a55e49a7da69774da9608\",\"blockchain-cat.pdf:FileName\":\"blockchain-cat.pdf\",\"blockchain-cat.pdf:FileTitle\":\"比特猫\",\"blockchain-cat.pdf:FileType\":\"保密\",\"blockchain-cat.pdf:FileNote\":\"\"}},{\"time\":1516847254,\"action\":\"update\",\"value\":{\"title\":\"招标说明、预算、投标报价说明、中标通知书、工程决算审核报告、工程质量验收监督（综合）表、开工报告、施工组织设计、产品检验报告、合格证、砂浆、混凝土配合比\",\"startDate\":\"2003-03-27 16:00:00.000Z\"}},{\"time\":1516846569,\"action\":\"update\",\"value\":{\"AAAA:IpfsAddr\":\"QmdsiNfRvaiajtaEHuwHZpTUCSprojGexYBMJsQC2aVhqk\",\"AAAA:FileHash\":\"821b5f8e54e80821d69a55e49a7da69774da9608\",\"BBBB:IpfsAddr\":\"QmV9tSDx9UiPeWExXEeH6aoDvmihvx6jD5eLb4jbTaKGps\",\"BBBB:FileHash\":\"40ede9054b10ded75742f64ce738c2e5595b03bc\",\"AAAA:FileName\":\"AAAA\",\"BBBB:FileName\":\"BBBB\",\"AAAA:FileTitle\":\"比特猫\",\"BBBB:FileTitle\":\"IPFS白皮书\",\"AAAA:FileType\":\"保密\",\"BBBB:FileType\":\"绝密\",\"AAAA:FileNote\":\"\",\"BBBB:FileNote\":\"\"}},{\"time\":1516845789,\"action\":\"delete\",\"value\":[\"title\",\"startDate\"]},{\"time\":1516845734,\"action\":\"update\",\"value\":{\"author\":\"naruto\"}}]}");
            //dynamic dynObj = JsonConvert.DeserializeObject("{\"address\":\"0x2214ac3e4a030eebf0ded7c2043fec9997671860\",\"id\":\"Z109-WS·2011-Y-BGS-0001\",\"blockNumber\":67575,\"mtime\":1517105788,\"ctime\":1517105673,\"title\":[{\"time\":1517105788,\"value\":\"招标说明、预算、投标报价说明、中标通知书、工程决算审核报告、工程质量验收监督（综合）表、开工报告、施工组织设计、产品检验报告、合格证、砂浆、混凝土配合比\",\"deleted\":false},{\"time\":1517105683,\"value\":\"招标说明、预算、投标报价说明、中标通知书、工程决算审核报告、工程质量验收监督（综合）表、开工报告、施工组织设计、产品检验报告、合格证、砂浆、混凝土配合比\",\"deleted\":true}],\"projectTitle\":[{\"time\":1517105683,\"value\":\"安光所汽车库改造及扩建工程\",\"deleted\":false}],\"startDate\":[{\"time\":1517105788,\"value\":\"2003-03-27 16:00:00.000Z\",\"deleted\":false},{\"time\":1517105683,\"value\":\"2003-03-27 16:00:00.000Z\",\"deleted\":true}],\"endDate\":[{\"time\":1517105683,\"value\":\"2004-11-18 18:00:00.000Z\",\"deleted\":false}],\"responsible\":[{\"time\":1517105683,\"value\":\"合肥研究院合肥大杨建安公司\",\"deleted\":false}],\"author\":[{\"time\":1517105683,\"value\":\"naruto\",\"deleted\":false}],\"changeLog\":[{\"time\":1517105788,\"action\":\"update\",\"value\":{\"title\":\"招标说明、预算、投标报价说明、中标通知书、工程决算审核报告、工程质量验收监督（综合）表、开工报告、施工组织设计、产品检验报告、合格证、砂浆、混凝土配合比\",\"startDate\":\"2003-03-27 16:00:00.000Z\"}},{\"time\":1517105703,\"action\":\"delete\",\"value\":[\"title\",\"startDate\"]}]}");
            var jObj = (JObject)dynObj;
            var root = new NodeEntity
            {
                id = "0",
                name = Tools.Tools.SplitString(archieveId),
                data = new TipsEntity{value = archieveId },
                children = new List<NodeEntity>()
            };
            var filenode = new NodeEntity
            {
                id = "1000",
                name = "File",
                data = new TipsEntity{value = "File" },
                children = new List<NodeEntity>()
            };
            root.children.Add(filenode);
            var count = 1;
            foreach (var token in jObj.Children())
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
                                name = Tools.Tools.SplitString(prop.Name.ToString()),
                                children = new List<NodeEntity>(),
                                data = new TipsEntity { value = prop.Name.ToString() }
                            };

                            // 著录项追踪记录
                            if (prop.Value.HasValues)
                            {
                                int num = 1;
                                foreach (var item in prop.Value.Children())
                                {
                                    var nodeEntity = new NodeEntity
                                    {
                                        id = count + "" + num,
                                        name = Tools.Tools.ConvertTime(Convert.ToDouble(item["time"].ToString()))
                                    };
                                    nodeEntity.data = !Convert.ToBoolean(item["deleted"]) ? new TipsEntity { value = "Update: " + item["value"].ToString() } : new TipsEntity { value = "Detele: " + item["value"].ToString() };
                                    node.children.Add(nodeEntity);      
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
                            var fileChildernNode = new NodeEntity
                            {
                                id = 1000 + "2" + count,
                                name = Tools.Tools.SplitString(prop.Name.ToString().Split(':')[1]),
                                data = new TipsEntity { value = prop.Name.ToString().Split(':')[1] },
                                children = new List<NodeEntity>()
                            };
                            var fileChildernHistoryNode = new NodeEntity();
                            if (prop.Value.HasValues)
                            {             
                                int num = 1;
                                foreach (JToken item in prop.Value.Children())
                                {
                                    fileChildernHistoryNode.id = 1000 + "3" +count+ num;
                                    fileChildernHistoryNode.name = Tools.Tools.ConvertTime(Convert.ToDouble(item["time"].ToString()));
                                    fileChildernHistoryNode.data = new TipsEntity { value = "Update: " + item["value"].ToString() };
                                    num++;
                                    fileChildernNode.children.Add(fileChildernHistoryNode);
                                }
                            }

                            var node = new NodeEntity();
                            if (filenode.children.Count(c => c.value == prop.Name.ToString().Split(':')[0]) == 0)
                            {
                                // 新文件信息
                                node.id = 1000 + "1" + count;
                                node.value = prop.Name.ToString().Split(':')[0];
                                node.name = Tools.Tools.SplitString(prop.Name.ToString().Split(':')[0]);
                                node.data = new TipsEntity { value = prop.Name.ToString().Split(':')[0], link = "http://www.baidu.com", isUrlShow = true};
                                node.children = new List<NodeEntity>();                               
                                node.children.Add(fileChildernNode);
                                root.children.Find(c => c.name == "File").children.Add(node);
                            }
                            else
                            {
                                filenode.children.Find(c => c.value == prop.Name.ToString().Split(':')[0]).children.Add(fileChildernNode);
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