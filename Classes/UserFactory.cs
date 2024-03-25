using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Project.Classes
{

    // abstract class 
    public abstract class UserFactory
    {
        public abstract int getUser(string uname, string pass);
    }
}
