using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChartDemoForAthena.Container
{
    public class JsonReturnResult
    {
        public static JsonResult json(int returnCode, string msg = null, Object data = null)
        {
            ReturnResult ret = new ReturnResult(returnCode, msg, data);
            return new JsonResult
            {
                Data = ret,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

    }
}