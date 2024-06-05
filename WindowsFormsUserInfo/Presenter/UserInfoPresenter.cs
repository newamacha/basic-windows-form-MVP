using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsUserInfo.Model;
using WindowsFormsUserInfo.View;

namespace WindowsFormsUserInfo.Presenter
{
    public class UserInfoPresenter
    {
        private readonly IUserInfoView _userInfoView;
        private readonly IUserInfoRepo _userInfoRepo;
        public UserInfoPresenter(IUserInfoView userInfoView, IUserInfoRepo userInfoRepo)
        {
            _userInfoView = userInfoView;
            userInfoView.Presenter = this;
            _userInfoRepo = userInfoRepo;
            UpdateUserList();
        }

        public void GetSelectedUser(string selectedUser)
        {
            UserInfo user = _userInfoRepo.GetUserInfo(selectedUser);
            if(user != null)
            {
                _userInfoView.Name = user.Name;
                _userInfoView.UserName = user.UserName;
                _userInfoView.Address = user.Address;
                _userInfoView.Phone = user.Phone;
                //_userInfoView.Gender = user.Gender;
            }
        }
        private void UpdateUserList()
        {
            var userNames = _userInfoRepo.GetAllUserInfo().Select(x => x.UserName);
            int selectedUser = _userInfoView.SelectedUser >= 0 ? _userInfoView.SelectedUser : 0;
            _userInfoView.SelectedUser = selectedUser;
            _userInfoView.Users = userNames.ToList();
        }
        public void SaveUser()
        {
            UserInfo userInfo = new UserInfo
            {
                UserName = _userInfoView.UserName,
                Address = _userInfoView.Address,
                Name = _userInfoView.Name,
                Phone = _userInfoView.Phone,
                //Gender = _userInfoView.Gender
            };
            _userInfoRepo.SaveUser(userInfo);
            UpdateUserList();
        }

        public void UpdateUser()
        {
            UserInfo userInfo = new UserInfo
            {
                UserName = _userInfoView.UserName,
                Address = _userInfoView.Address,
                Name = _userInfoView.Name,
                Phone = _userInfoView.Phone,
                //Gender = _userInfoView.Gender
            };
            _userInfoRepo.UpdateUser(userInfo);
            UpdateUserList();
        }

        public void DeleteUser()
        {
            UserInfo userInfo = new UserInfo
            {
                UserName = _userInfoView.UserName,
                Address = _userInfoView.Address,
                Name = _userInfoView.Name,
                Phone = _userInfoView.Phone,
                //Gender = _userInfoView.Gender
            };
            _userInfoRepo.DeleteUser(userInfo);
            UpdateUserList();
        }
    }
}
