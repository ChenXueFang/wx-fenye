﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Object.Class
{
    public class BaseLoginUserHandler : BaseLoginHandler
    {

        protected override bool HasPermission()
        {
            bool result = true;
            JsonResult jr = new JsonResult();
            if (Context.Session[ConfigureClass.SessionUserString] == null)
            {
                result = false;
                jr.msg = "请先登录！";
                jr.success = false;
                jr.url = "login.aspx";
                jr.ToJson();      
            }
            return result;
        }
    }
}