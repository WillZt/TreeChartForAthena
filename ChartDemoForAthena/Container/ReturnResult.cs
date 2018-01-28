using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChartDemoForAthena.Container
{
    public class ReturnResult
    {
        public int _returncode;
        public string _msg;
        public Object _data;

        public ReturnResult(int code, string msg, Object data)
        {
            _returncode = code;
            _msg = msg;
            _data = data;
        }

    }
}