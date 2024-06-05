using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsUserInfo.Model;
using WindowsFormsUserInfo.Presenter;
using WindowsFormsUserInfo.View;

namespace WindowsFormsUserInfo
{
    public partial class formUserInfo : Form, IUserInfoView
    {
        public formUserInfo()
        {
            InitializeComponent();
            Presenter = new UserInfoPresenter(this, new UserInfoRepo());
        }

        public int SelectedUser { get; set; }
        public UserInfoPresenter Presenter { get; set; }
        public IList<string> Users { get => (IList<string>)this.listUser; set; }

        private void formUserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
