using CCApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCApp.ViewModels
{
    public class CompanyViewModel
    {
        public string CompanyName { get; set; }

        public CompanyViewModel()
        {
            CompanyName = GetCompanyInfo();
        }

        public string GetCompanyInfo()
        {
            Company company = new Company();
            using (var context = new CCAppEntities())
            {
                context.Database.Connection.Open();
                company = context.Company.FirstOrDefault<Company>();
            }

            return company.CompanyName;
        }
    }
}
