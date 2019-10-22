using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCApp.Utils
{
    public class DBDataProcessor : IDBDataProcessor
    {
        void IDBDataProcessor.GetInfoByFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public string GetFirstNameFromFull(string fullName)
        {
            // Truncate the first space
            var firstName = fullName.TrimEnd();

            return firstName;
        }
    }

    public interface IDBDataProcessor
    {
       void GetInfoByFirstName(string firstName);
    }
}
