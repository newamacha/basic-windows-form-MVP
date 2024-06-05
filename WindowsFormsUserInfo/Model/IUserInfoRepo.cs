using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsUserInfo.Model
{
    public interface IUserInfoRepo
    {
        UserInfo GetUserInfo(string userName);
        List<UserInfo> GetAllUserInfo();
        void SaveUser(UserInfo userInfo);
        void UpdateUser(UserInfo userInfo);
        void DeleteUser(UserInfo userInfo);
    }
}
