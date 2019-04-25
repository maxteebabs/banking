using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using udemy.Context;
using udemy.DTOs;
using udemy.Models;


namespace udemy.Controllers.API
{
    public class CustomersController : ApiController
    {
        private BankContext _db;

        public CustomersController()
        {
            _db = new BankContext();
        }
        // GET /api/customers/get
        public IEnumerable<CustomerDto> GetCustomers(string query = null)
        {
            var customersQuery = _db.Customers
                .Include(customer => customer.Account);

            if (!String.IsNullOrEmpty(query))
            {
                customersQuery = customersQuery.Where( customer => customer.Firstname.Contains(query));
            }
            return customersQuery
                .ToList().Select(Mapper.Map<Customer, CustomerDto>);
        }
        // GET /api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _db.Customers.Find(id);
            if(customer == null)
            {
                return NotFound();
            }
            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }
        // POST /api/customers
        [HttpPost]
        public IHttpActionResult createCustomer(CustomerDto customerDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
                //throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _db.Customers.Add(customer);
            _db.SaveChanges ();
            customerDto.ID = customer.ID;
            return Created(new Uri(Request.RequestUri + "/" + customer.ID), customerDto);
        }
        // PUT /api/customers/1
        [HttpPut]
        public CustomerDto updateCustomer(int id, CustomerDto data)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var customer = _db.Customers.SingleOrDefault(c => c.ID == id);
            if(customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map<CustomerDto, Customer>(data, customer);
            //customer.Lastname = data.Lastname;
            //customer.Gender = data.Gender;
            //customer.Firstname = data.Firstname;
            //customer.Occupation = data.Occupation;
            //customer.Dob = data.Dob;
            //customer.Address = data.Address;
            _db.SaveChanges();
            return data;
        }
        // Delete /api/customers/1
        [HttpDelete]
        public void deleteCustomer(int id)
        {
            var customer = _db.Customers.SingleOrDefault(c => c.ID == id);
            if (customer == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _db.Customers.Remove(customer);
            _db.SaveChanges();
        }

        public IHttpActionResult Open()
        {
            int[] accountIDS = new int[] { 1, 2, 3, 4, 5 };
            var accounts = _db.Accounts.Where(account => accountIDS.Contains(account.ID)).ToList();
            if (accounts.Count() != accountIDS.Count())
                return BadRequest("one or more ids are invalid");

            foreach (Account account in accounts)
            {
                var newAccount = new Account
                {
                    Name = "name",
                    Balance = 0,
                    AccountType = "Savings"
                };
                _db.Accounts.Add(newAccount);

            }
            _db.SaveChanges();
            return Ok();
        }
    }
}
