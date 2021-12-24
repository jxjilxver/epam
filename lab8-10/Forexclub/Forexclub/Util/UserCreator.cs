using Forexclub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forexclub.Service
{
    class UserCreator
    {
        public static string email = TestDataReader.GetTestsSettings().user.Email;
        public static string password = TestDataReader.GetTestsSettings().user.Password;

        public static User WithCredentialsFromProperty()
        {
            return new User(email, password);
        }

        public static User WithEmptyEmail()
        {
            return new User("", password);
        }

        public static User WithEmptyPassword()
        {
            return new User(email, "");
        }
    }
}
