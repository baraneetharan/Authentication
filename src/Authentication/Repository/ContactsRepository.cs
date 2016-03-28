using Authentication.Models;
using System.Collections.Generic;
using System.Linq;

namespace Authentication.Repository
{
    public class ContactsRepository : IContactsRepository
    {
        static List<Contacts> ContactsList = new List<Contacts>();
 public ContactsRepository()
        {
            if (ContactsList.Count == 0)
            {
               
               ContactsList.Add(new Contacts("baraneetharan","r","true","KGfSL","qa","br@live.com","0000001234"));
               ContactsList.Add(new Contacts("narayanasamy","k","true","KGfSL","dev","nk@live.com","0000001235"));
               ContactsList.Add(new Contacts("reka","v","true","KGfSL","dev","rv@live.com","0000001236"));
               ContactsList.Add(new Contacts("aravind","m","true","KGfSL","designer","am@live.com","0000001237"));
               ContactsList.Add(new Contacts("somasundaram","s","true","KGfSL","android dev","ss@live.com","0000001238"));
            }
        }
        public void Add(Contacts item)
        {
            ContactsList.Add(item);
        }
 
        public Contacts Find(string key)
        {
            return ContactsList
                .Where(e => e.MobilePhone.Equals(key))
                .SingleOrDefault();
        }
 
        public IEnumerable<Contacts> GetAll()
        {
            //ContactsList.Add(new Contacts("Baraneetharan","Ramasamy","true","KGfSL","Architect","baraneetharan@live.com","9790597065"));
            
            return ContactsList;
        }
 
        public void Remove(string Id)
        {
            var itemToRemove = ContactsList.SingleOrDefault(r => r.MobilePhone == Id);
            if (itemToRemove != null)
                ContactsList.Remove(itemToRemove);            
        }
 
        public void Update(Contacts item)
        {
            var itemToUpdate = ContactsList.SingleOrDefault(r => r.MobilePhone == item.MobilePhone);
            if (itemToUpdate != null)
            {
                itemToUpdate.FirstName = item.FirstName;
                itemToUpdate.LastName = item.LastName;
                itemToUpdate.IsFamilyMember = item.IsFamilyMember;
                itemToUpdate.Company = item.Company;
                itemToUpdate.JobTitle = item.JobTitle;
                itemToUpdate.Email = item.Email;
                itemToUpdate.MobilePhone = item.MobilePhone;
            }
        }
    }
}