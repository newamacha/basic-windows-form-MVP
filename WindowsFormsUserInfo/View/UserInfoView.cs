using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUserInfo.Model;
using WindowsFormsUserInfo.Presenter;

namespace WindowsFormsUserInfo.View
{
    public partial class UserInfoView : Form, IUserInfoView
    {
        public UserInfoView()
        {
            InitializeComponent();
            Presenter = new UserInfoPresenter(this, new UserInfoRepo());
        }

        public int SelectedUser { get; set; }
        public UserInfoPresenter Presenter { get; set; }
        public IList<string> Users { get => (IList<string>)this.listUsers.DataSource; set => this.listUsers.DataSource = value; }
        public string UserName { get => this.utxtUsername.Text; set => this.utxtUsername.Text = value; }
        public new string Name { get => this.utxtName.Text; set => this.utxtName.Text = value; }
        public string Address { get => this.utxtAddress.Text; set => this.utxtAddress.Text = value; }
        public string Phone { get => this.utxtPhone.Text; set => this.utxtPhone.Text = value; }
        //public string Gender { get => this.rbtnMale.Checked ? "Male" : "Female"; set => value == "Male" ? rbtnMale.Checked : rbtnFemale.Checked; }

        private void listUsers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Presenter.GetSelectedUser(listUsers.SelectedItem.ToString());
        }
        

        private void ubtnInsert_Click(object sender, EventArgs e)
        {
            Presenter.SaveUser();
            
        }

        private void ubtnReset_Click(object sender, EventArgs e)
        {
            utxtName.Clear();
            utxtUsername.Clear();
            utxtAddress.Clear();
            utxtPhone.Clear();
        }

        private void ubtnUpdate_Click(object sender, EventArgs e)
        {
            Presenter.UpdateUser();
            MessageBox.Show("User has been updated successfully.", "MVP Demo", MessageBoxButtons.OK);
        }

        private void ubtnDelete_Click(object sender, EventArgs e)
        {
            Presenter.DeleteUser();
            MessageBox.Show("User has been deleted successfully.", "MVP Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ubtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
