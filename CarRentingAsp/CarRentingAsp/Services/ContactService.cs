using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentingAsp.Repositories.Interfaces;
using CarRentingAsp.Models;
using System.Linq.Expressions;

namespace CarRentingAsp.Services
{
    public class ContactService : BaseService
    {
        public ContactService(IRepositoryWrapper repositoryWrapper)
            : base(repositoryWrapper)
        { }

        public List<Contact> GetContact()
        {
            return repositoryWrapper.ContactRepository.FindAll().ToList();
        }

        public List<Contact> GetContactByCondition(Expression<Func<Contact, bool>> expression)
        {
            return repositoryWrapper.ContactRepository.FindByCondition(expression).ToList();
        }

        public void AddContact(Contact contact)
        {
            repositoryWrapper.ContactRepository.Create(contact);
        }

        public void UpdateContact(Contact contact)
        {
            repositoryWrapper.ContactRepository.Update(contact);
        }

        public void DeleteContact(Contact contact)
        {
            repositoryWrapper.ContactRepository.Delete(contact);
        }
    }
}