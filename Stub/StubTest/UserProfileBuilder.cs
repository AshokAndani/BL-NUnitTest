using System;
using System.Collections.Generic;
using System.Text;

namespace FakeTest
{
    public class UserProfileBuilder
    {
        public int userid;
        public string username;
        public IDataProvider provider;
        public UserProfileBuilder(int userid, IDataProvider provider)
        {
            this.userid = userid;
            this.provider = provider;
        }
        public string SetUsername()
        {
            this.username = this.provider.GetUserName(this.userid);
            return this.username;
        }
    }
}
