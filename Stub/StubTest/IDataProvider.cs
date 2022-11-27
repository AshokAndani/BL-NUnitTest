using System;
using System.Collections.Generic;
using System.Text;

namespace FakeTest
{
    public interface IDataProvider
    {
        string GetUserName(int userid);
    }
}
