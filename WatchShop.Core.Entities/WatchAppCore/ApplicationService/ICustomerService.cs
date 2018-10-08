using System;
using System.Collections.Generic;
using System.Text;
using WatchShop.Core.Entity;

namespace WatchAppCore.ApplicationService
{
    public interface ICustomerService
    {
        Customers GetCustomerInstance();

        List<Customers> GetCustomers();

        Customers AddCustomer(Customers owner);

        void DeleteCustomer(int id);

        List<Customers> FindCustomersName();

        Customers FindCustomersById(int id);

        Customers FindCustomersByIdIncludePets(int id);

        Customers UpdateCustomers(Customers ownerUpdate);
    }
}

