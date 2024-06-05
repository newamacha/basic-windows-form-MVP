using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUserInfo.Model
{
    public class UserInfoRepo : IUserInfoRepo
    {
        private List<UserInfo> _users;
        public UserInfoRepo() 
        {
            _users = CreateUsers();
        }

        private List<UserInfo> CreateUsers()
        {
            _users = new List<UserInfo> 
            {
                new UserInfo{Name="Sanam", UserName="hello", Address="thecho", Phone = "987644"}
            };
            return _users;
        }

        public List<UserInfo> GetAllUserInfo()
        {
            return _users;
        }

        public UserInfo GetUserInfo(string userName) 
        {
            return _users.Where(u => u.UserName == userName).FirstOrDefault();
        }

        public void SaveUser(UserInfo userInfo)
        {
            UserInfo user = GetUserInfo(userInfo.UserName);
            if (user != null && user.UserName == userInfo.UserName)
            {
                MessageBox.Show("Username already exists. Please select another one.");
            }
            else
            {
                _users.Add(userInfo);
                MessageBox.Show("User has been added to list successfully.", "MVP Demo", MessageBoxButtons.OK);
            }
        }

        public void UpdateUser(UserInfo userInfo)
        {
            UserInfo user = GetUserInfo(userInfo.UserName);
            if (user != null && user.UserName == userInfo.UserName)
            {
                _users.Remove(user);
                _users.Add(userInfo);
            }
        }

        public void DeleteUser(UserInfo userInfo)
        {
            UserInfo user = GetUserInfo(userInfo.UserName);
            if (user != null && user.UserName == userInfo.UserName)
            {
                _users.Remove(user);
            }
        }
    }
}
