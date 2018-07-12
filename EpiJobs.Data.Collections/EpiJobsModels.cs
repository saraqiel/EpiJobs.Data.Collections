using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiJobs.Data.Collections
{
    public class Opportunity 
    {
        public long OpportunityId { get; set; }
        public string CompanyName { get; set; }
        public string Summary { get; set; }
        public string Title { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Responsibilities { get; set; }
        public string Experience { get; set; }
        public string Skills { get; set; }
        public Applicants OppportunityApplicants { get; set; }
    }
    public class Applicant {
        public long ApplicantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public byte[] Resume { get; set; }
        public byte[] ProfileImage { get; set; }
    }

    public class Address {
        public long AddressId { get; set; }
        public string StreetAddr1 { get; set; }
        public string StreetAddr2 { get; set; }
        public string StreetAddr3 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }

    public class Opportunities : List<Opportunity> { }

    public class Applicants : List<Applicant> { }

    public class OpportunitySearchParams {
        public string Keyword { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Category { get; set; }
    }

    public class PasswordResetParams {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class ApplyParams {
        public int CandidateId { get; set; }
        public int OpportunityId { get; set; }
    }
}
