using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common;

namespace Web.user
{
    /// <summary>
    /// submit_ajax 的摘要说明
    /// </summary>
    public class submit_ajax : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            string action = context.Request.QueryString["action"];
            switch (action)
            {
                case "validate_username"://验证会员用户名是否重复
                    validate_username(context);
                    break;
            }
        }

        #region 验证用户名是否可用==============================
        private void validate_username(HttpContext context)
        {
            string user_name = DTRequest.GetString("param");
            //如果为Null，退出
            if (string.IsNullOrEmpty(user_name))
            {
                context.Response.Write("{ \"info\":\"请输入用户名\", \"status\":\"n\" }");
                return;
            }
            //Model.userconfig userConfig = new BLL.userconfig().loadConfig();
            ////过滤注册用户名字符
            //string[] strArray = userConfig.regkeywords.Split(',');
            //foreach (string s in strArray)
            //{
            //    if (s.ToLower() == user_name.ToLower())
            //    {
            //        context.Response.Write("{ \"info\":\"用户名不可用\", \"status\":\"n\" }");
            //        return;
            //    }
            //}
            BLL.tb_user blluser = new BLL.tb_user();
            //查询数据库
            if (blluser.Exists(user_name.Trim()))
            {
                context.Response.Write("{ \"info\":\"用户名已重复\", \"status\":\"n\" }");
                return;
            }
            context.Response.Write("{ \"info\":\"用户名可用\", \"status\":\"y\" }");
            return;
        }
        #endregion


        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}