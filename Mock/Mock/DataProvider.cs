using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestTypes
{
    public class DataProvider : IDataProvider
    {
        public string GetUserName(int id)
        {
            // this will make a db call and bring the data
            throw new NotImplementedException();
        }
    }
}
