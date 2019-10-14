using CCApp.Data;
using System.Linq;
using System.Data.SQLite.EF6;

namespace CCApp.ViewModels
{
    public class CompanyViewModel
    {
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyOwner { get; set; }


        public CompanyViewModel()
        {
            CompanyName = GetCompanyName();
            CompanyAddress = GetCompanyAddress();
            CompanyEmail = GetCompanyEmail();
            CompanyPhone = GetCompanyPhone();
            CompanyOwner = GetCompanyOwner();
        }

        public string GetCompanyName()
        {
            var company = new Company();
            using (var context = new CCAppEntities())
            {
                // open database
                try
                {
                    context.Database.Connection.Open();
                }
                catch (System.Exception)
                {

                    throw;
                }
                
                company = context.Company.FirstOrDefault<Company>();
            }

            return company.CompanyName;
        }
        public string GetCompanyAddress()
        {
            var company = new Company();
            using (var context = new CCAppEntities())
            {
                // open database
                context.Database.Connection.Open();
                company = context.Company.FirstOrDefault<Company>();
            }

            return company.CompanyAddress;
        }
        public string GetCompanyEmail()
        {
            var company = new Company();
            using (var context = new CCAppEntities())
            {
                // open database
                context.Database.Connection.Open();
                company = context.Company.FirstOrDefault<Company>();
            }

            return company.CompanyEmail;
        }
        public string GetCompanyPhone()
        {
            var company = new Company();
            using (var context = new CCAppEntities())
            {
                // open database
                context.Database.Connection.Open();
                company = context.Company.FirstOrDefault<Company>();
            }

            return company.CompanyPhone;
        }

        public string GetCompanyOwner()
        {
            var company = new Company();
            using (var context = new CCAppEntities())
            {
                // open database
                context.Database.Connection.Open();
                company = context.Company.FirstOrDefault<Company>();
            }

            return company.CompanyOwner;
        }

        public void SaveCompanyInfo()
        {
            //open database and get company object
            var company = new Company();
            using (var context = new CCAppEntities())
            {
                context.Database.Connection.Open();
                company = context.Company.FirstOrDefault<Company>();

                company.CompanyAddress = CompanyAddress;
                company.CompanyEmail = CompanyEmail;
                company.CompanyName = CompanyName;
                company.CompanyOwner = CompanyOwner;
                company.CompanyPhone = CompanyPhone;

                int saveCode = context.SaveChanges();
            }
        }

        public void Save()
        {
            SaveCompanyInfo();
        }
    }
}
