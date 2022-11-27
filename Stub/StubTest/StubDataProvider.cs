using System;
using System.Collections.Generic;
using System.Text;

namespace FakeTest
{
    // faking the functionality and output the hardcoded logic/result
    public class StubDataProvider : IDataProvider
    {
        public string GetUserName(int userid)
        {
            return "ashok";
        }
    }
}
