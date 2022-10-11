using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GymApp
{
    public class Member
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int MembershipNumber { get; set; }
        public string? MemberType { get; set; }
        public DateTime RenewalDate { get; set; }
        public DateTime CurrentDate { get; set; }
        public string? HouseNumber { get; set; }
        public string? StreetName { get; set; }
        public string? TownCity { get; set; }
        public string? County { get; set; }
        public string? PostCode { get; set; }

        public string? FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string? FullAddress()
        {
            return $"{HouseNumber} {StreetName},\n\t\t\t{TownCity},\n\t\t\tCounty {County},\n\t\t\t{PostCode}";
        }

        /*public string ShortRenewalDate()
        {
            var renewalDateShort = RenewalDate.ToShortDateString();
            return $"{renewalDateShort}";
        }*/

        /*public TimeSpan DaysRemaining()
        {
            DateTime currentDate = DateTime.Today;
            DateTime memberRenewalDate = RenewalDate;
            TimeSpan remainingDays = memberRenewalDate.Subtract(currentDate);
            return remainingDays.TotalDays;
        }*/
    }
}
