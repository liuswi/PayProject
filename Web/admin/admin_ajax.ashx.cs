using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;

namespace Web.admin
{
    /// <summary>
    /// admin_ajax 的摘要说明
    /// </summary>
    public class admin_ajax : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            string action = DTRequest.GetQueryString("action");
            switch (action)
            { 
                case "navigation_validate"://验证导航菜单ID是否重复
                    navigation_validate(context);
                    break;
            }
        }

        private void navigation_validate(HttpContext context)
        {
            string navname = DTRequest.GetString("param");
            string old_name = DTRequest.GetString("old_name");
            if (string.IsNullOrEmpty(navname))
            {
                context.Response.Write("{ \"info\":\"该导航菜单ID不可为空！\", \"status\":\"n\" }");
                return;
            }
            if (navname.ToLower() == old_name.ToLower())
            {
                context.Response.Write("{ \"info\":\"该导航菜单ID可使用\", \"status\":\"y\" }");
                return;
            }

            BLL.tb_navigation navbll = new BLL.tb_navigation();
            if (navbll.Exists(navname))
            {
                context.Response.Write("{ \"info\":\"该导航菜单ID已被占用，请更换！\", \"status\":\"n\" }");
                return;
            }
            context.Response.Write("{ \"info\":\"该导航菜单ID可使用\", \"status\":\"y\" }");
            return;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}