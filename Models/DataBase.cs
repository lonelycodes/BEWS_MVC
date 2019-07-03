using System;
using System.Collections.Generic;
using System.Linq;

namespace NickNames.Models
{
    public class DataBase
    {
        private static Dictionary<string, HashSet<string>> Persons = new Dictionary<string, HashSet<string>>();

        public DataBase() 
        {
        }

        public void AddNickName(string realName, string nickName)
        {
            // TODOWS
            // if realName exists, append nickname
            // if not, create & append nickname

        }

        public HashSet<string> GetNickNames(string realName)
        {
            // TODOWS
            // return nickNames for given realName

            return new HashSet<string>();
        }
    }
}
