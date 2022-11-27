using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestTypes
{
     public class UserProfileBuilder
    {
        public int userId;
        public string username;
        public IDataProvider dataProvider;
        public UserProfileBuilder(int userid, IDataProvider dataProvider)
        {
            this.userId = userid;
            this.dataProvider = dataProvider;
        }
        public string SetUserName()
        {
            this.username = this.dataProvider.GetUserName(this.userId);
            return username;
        }
    }
}
