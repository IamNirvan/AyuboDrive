using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive.Utility
{
    static class UserNameChecker
    {
        private static QueryHandler _queryHandler = new QueryHandler();

        public static bool CheckIfUserNameExists(string userName)
        {
            return _queryHandler.SelectQueryHandler("SELECT * FROM userAccount WHERE userName = '"
                + userName + "'") != null;
        }
    }
}
