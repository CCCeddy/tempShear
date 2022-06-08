using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SamsAppV7.Data
{
    public class FlightBookingsData
    {
            public Int64  Id { get; set; }
            public String Gender { get; set; }
            public String LastName { get; set; }
            public String FirstName { get; set; }
            public Int32 BirthDay { get; set; }
            public Int32 BirthMonth { get; set; }
            public Int32 BirthYr { get; set; }
            public String Nationality{ get; set; }
            public String PassportNo{ get; set; }
            public String IssuingCountry{ get; set; }
            public Int32 PassportExpiryDay { get; set; }
            public Int32 PassportExpiryMonth { get; set; }
            public Int32 PassportExpiryYr { get; set; }
            public String Email{ get; set; }
            public String EmailConfirm{ get; set; }
            public String PhoneCountryCode{ get; set; }
            public String Phone{ get; set; }
            public Int32 FromID { get; set; }
            public Int32 ToID { get; set; }
            public DateTime Depart { get; set; }
            public DateTime Arrive { get; set; }
            public TimeSpan /*time*/ BookingTime { get; set; }
            public String Amount{ get; set; }
            public Boolean Paid { get; set; }
            public Boolean Confirmed { get; set; }
            public Boolean Cancelled { get; set; }
            public Int32 TenantID { get; set; } 
    }
}
