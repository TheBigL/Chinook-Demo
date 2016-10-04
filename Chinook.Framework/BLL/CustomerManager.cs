using Chinook.Framework.DAL;
using Chinook.Framework.Entities.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Framework.BLL
{
    public class CustomerManager
    {
        public CustomerProfile GetProfile(int customerID)
        {
            using (var context = new ChinookContext())
            {
                var profile = from person in context.Customers
                              where person.CustomerId == customerID
                              select new CustomerProfile
                              {
                                  FirstName = person.FirstName,
                                  LastName = person.LastName,
                                  CompanyName = person.CompanyName,
                                  StreetAddress = person.Address,
                                  City = person.City,
                                  State = person.State,
                                  Country = person.Country,
                                  PostalCode = person.PostalCode



                              };
                return profile.Single();
            }


        }


    }
}
