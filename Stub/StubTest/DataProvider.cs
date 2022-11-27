using System;
using System.Collections.Generic;
using System.Text;

namespace FakeTest
{
    internal class DataProvider : IDataProvider
    {
        public string GetUserName(int userid)
        {
            // this makes a db call and get the data from DB
            throw new NotImplementedException();
        }
    }
}
