using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;

namespace Web.user
{
    public partial class register : Common.ManagePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim() == Session[DTKeys.SESSION_CODE].ToString())
            {
                Model.tb_user usermdl = new Model.tb_user();
                BLL.tb_user userbll = new BLL.tb_user();

                usermdl.USERNAME = txtUserName.Text.Trim();
                usermdl.USERPWD = DESEncrypt.Encrypt(txtPassword.Text);
                usermdl.USERREALNAME = txtRealName.Text.Trim();
                usermdl.USERSEX = rblSex.SelectedValue;
                usermdl.USERCARD = txtCard.Text.Trim();
                usermdl.USERADDRESS = txtAddress.Text.Trim();
                usermdl.USERPHONE = txtMobile.Text.Trim();
                usermdl.USEREMALL = txtEmail.Text.Trim();
                usermdl.USERQUESTION = ddlQuestion.SelectedValue;
                usermdl.USERANSWER = txtAnswer.Text;
                usermdl.USERSTATUS = 0;
                usermdl.USERTYPE = 0;
                if (userbll.Add(usermdl) > 0)
                {
                    JscriptMsg("添加用户成功！", "", "Success");
                    foreach (Control control in Controls)
                    {
                        if (control is TextBox)
                        {
                            (control as TextBox).Text = "";
                        }
                    }
                }
                else
                {
                    JscriptMsg("注册失败！", "", "Error");
                }
            }
            else
            {
                JscriptMsg("验证码不正确！", "", "Error");
            }
        }
    }
}