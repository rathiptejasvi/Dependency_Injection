﻿using System;
using System.Collections.Generic;

using DAL;

namespace Services
{
    public class CustomerService:ICustomerService
    {
        private ICustomerRepository _iCustomerRepository;


        public CustomerService(ICustomerRepository iCustomerRepository)
        {
            _iCustomerRepository = iCustomerRepository;
        }
        public virtual List<Customer> GetCustomers()
        {
            return _iCustomerRepository.GetCustomers();
        }
    }
}


