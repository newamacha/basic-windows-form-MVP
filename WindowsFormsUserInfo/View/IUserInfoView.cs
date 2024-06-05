using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsUserInfo.Presenter;

namespace WindowsFormsUserInfo.View
{
    public interface IUserInfoView
    {
        IList<string> Users { get; set;  }
        int SelectedUser { get; set; }
        string Name { get; set; }
        string UserName { get; set; }
        string Address { get; set; }
        string Phone {  get; set; }
        //string Gender { get; set; }
        UserInfoPresenter Presenter { get; set; }
    }
}
