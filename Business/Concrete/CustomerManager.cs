using Business.Abstract;
using Business.Concrete.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<Customer>> Add(Customer customer)
        {
            return new SuccessDataResult<List<Customer>>( Messages.CustomerAdded);
        }

        public IDataResult<List<Customer>> Delete(Customer customer)
        {
            return new SuccessDataResult<List<Customer>>( Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<List<Customer>> Update(Customer customer)
        {
            return new SuccessDataResult<List<Customer>>(  Messages.CustomerUpdate);
        }
    }

}
