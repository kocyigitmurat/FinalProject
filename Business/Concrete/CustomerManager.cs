using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
