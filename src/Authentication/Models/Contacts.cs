namespace Authentication.Models
{
    public class Contacts
    {        
        public Contacts()
        {
            
        }
        public Contacts(string FirstName,string LastName,string IsFamilyMember,string Company,string JobTitle,string Email,string MobilePhone)
        {
            this.FirstName=FirstName;
            this.LastName=LastName;
            this.IsFamilyMember=true;
            this.Company=Company;
            this.JobTitle=JobTitle;
            this.Email=Email;
            this.MobilePhone=MobilePhone;            
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsFamilyMember { get; set; }        
        public string Company { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }        
    }
}