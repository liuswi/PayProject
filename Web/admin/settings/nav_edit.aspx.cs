using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;
using System.Data;

namespace Web.admin.settings
{
    public partial class nav_edit : Common.ManagePage
    {
        private string action = DTEnums.ActionEnum.Add.ToString(); //操作类型
        private int id = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TreeBind(DTEnums.NavigationEnum.System.ToString());
                ActionTypeBind();
                if (action == DTEnums.ActionEnum.Edit.ToString())
                {
                    ShowInfo(this.id);
                }
            }
        }


        #region 绑定权限类型
        private void ActionTypeBind()
        {
            cblActionType.Items.Clear();
            foreach (KeyValuePair<string, string> kvp in Utils.ActionType())
            {
                cblActionType.Items.Add(new ListItem(kvp.Value + "(" + kvp.Key + ")", kvp.Key));
            }
        } 
        #endregion


        #region 绑定导航菜单
        private void TreeBind(string nav_type)
        {
            BLL.tb_navigation navbll = new BLL.tb_navigation();
            DataTable dt = navbll.GetList(0, nav_type);
            this.ddlParentId.Items.Clear();
            this.ddlParentId.Items.Add(new ListItem("无父级导航", "0"));
            foreach (DataRow dr in dt.Rows)
            {
                string Id = dr["id"].ToString();
                int ClassLayer = int.Parse(dr["class_layer"].ToString());
                string Title = dr["title"].ToString().Trim();
                if (ClassLayer == 1)
                {
                    this.ddlParentId.Items.Add(new ListItem(Title, Id));
                }
                else
                {
                    Title = "|- " + Title;
                    Title = Utils.StringOfChar(ClassLayer - 1, " ") + Title;
                    this.ddlParentId.Items.Add(new ListItem(Title, Id));
                }
            }
        } 
        #endregion

        #region 修改-绑定信息
        private void ShowInfo(int id)
        {
            BLL.tb_navigation navbll = new BLL.tb_navigation();
            Model.tb_navigation navmodel = navbll.GetModel(id);
            ddlParentId.SelectedValue = navmodel.parent_id.ToString();
            txtSortId.Text = navmodel.sort_id.ToString();
            if (navmodel.is_lock == 1)
            {
                cbIsLock.Checked = true;
            }
            txtName.Text = navmodel.name;
            txtName.Attributes.Add("ajaxurl", "admin_ajax.ashx?action=navigation_validate&old_name=" + Utils.UrlEncode(navmodel.name));//检测用户名是否可用
            txtName.Focus();//获取焦点
            if (navmodel.is_sys == 1)//判断是否为系统字段
            {
                ddlParentId.Enabled = false;
                txtName.ReadOnly = true;
            }
            txtTitle.Text = navmodel.title;
            txtSubTitle.Text = navmodel.sub_title;
            txtLinkUrl.Text = navmodel.link_url;
            txtRemark.Text = navmodel.remark;

            //权限
            string[] actionTypeArr = navmodel.action_type.Split(',');
            for (int i = 0; i < cblActionType.Items.Count; i++)
            {
                for (int j = 0; j < actionTypeArr.Length; j++)
                {
                    if (actionTypeArr[j].ToLower() == cblActionType.Items[i].Value.ToLower())
                    {
                        cblActionType.Items[i].Selected = true;
                    }
                }
            }
        } 
        #endregion

        private bool DoAdd()
        {
            try
            {
                Model.tb_navigation navmodel = new Model.tb_navigation();
                BLL.tb_navigation navbll = new BLL.tb_navigation();

                navmodel.nav_type = DTEnums.NavigationEnum.System.ToString();
                navmodel.name = txtName.Text.Trim();
                navmodel.title = txtTitle.Text.Trim();
                navmodel.sub_title = txtSubTitle.Text.Trim();
                navmodel.link_url = txtLinkUrl.Text.Trim();
                navmodel.sort_id = int.Parse(txtSortId.Text.Trim());
                navmodel.is_lock = 0;
                if (cbIsLock.Checked == true)
                {
                    navmodel.is_lock = 1;
                }
                navmodel.remark = txtRemark.Text.Trim();
                navmodel.parent_id = int.Parse(ddlParentId.SelectedValue);

                //权限
                string action_type_str = string.Empty;
                for (int i = 0; i < cblActionType.Items.Count; i++)
                {
                    if (cblActionType.Items[i].Selected && Utils.ActionType().ContainsKey(cblActionType.Items[i].Value))
                    {
                        action_type_str += cblActionType.Items[i].Value + ",";
                    }
                }
                navmodel.action_type = Utils.DelLastComma(action_type_str);
                if (navbll.Add(navmodel) > 0)
                {
                    return true;
                }
            }
            catch 
            {
                return false;
            }
            return false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (action == DTEnums.ActionEnum.Edit.ToString())
            {

            }
            else
            {
                if (!DoAdd())
                {
                    JscriptMsg("保存过程中发生错误！", "", "Error");
                    return;
                }
                JscriptMsg("添加导航菜单成功！", "nav_list.aspx", "Success", "parent.loadMenuTree");
            }
        }
    }
}