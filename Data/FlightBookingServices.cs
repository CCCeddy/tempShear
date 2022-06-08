using Dapper;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
namespace SamsAppV7.Data
{
    public class FlightBookingServices : IFlightBookinsService
    {
        private readonly SamsConfiguration _configuration;

        public FlightBookingServices(SamsConfiguration samsConfiguration)
        {
            _configuration = samsConfiguration;
        }

        public async Task<List<FlightBookingsData>> GetAll()
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const String sql = @"SELECT * FROM FlightBookingsData";   //change to stored procedure

                List<FlightBookingsData> result = (List<FlightBookingsData>)await conn.QueryAsync<FlightBookingsData>(sql);
                return result.ToList();
            }
        }

        public async Task<int> GetFlightBookingsCountAsync()
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const String sql = @"SELECT count(*) FROM GetFlightDataSp";    //change to stored procedure
                int result = await conn.ExecuteScalarAsync<int>(sql);
                return result;
            }
        }

        public async Task<bool> FlightBookingsInsert(FlightBookingsData flightbookings)
        {
            var sql = "FlightBookingsInsertSp";

            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("FlightBookingId", FlightBookings.FlightBookingId, DbType.Int64);
                parameters.Add("Gender", FlightBookings.Gender, DbType.String);
                parameters.Add("LastName", FlightBookings.LastName, DbType.String);
                parameters.Add("FirstName", FlightBookings.FirstName, DbType.String);
                parameters.Add("BirthDay", FlightBookings.BirthDay, DbType.Int32);
                parameters.Add("BirthMonth", FlightBookings.BirthMonth, DbType.Int32);
                parameters.Add("BirthYr", FlightBookings.BirthYr, DbType.Int32);
                parameters.Add("Nationality", FlightBookings.Nationality, DbType.String);
                parameters.Add("PassportNo", FlightBookings.PassportNo, DbType.String);
                parameters.Add("IssuingCountry", FlightBookings.IssuingCountry, DbType.String);
                parameters.Add("PassportExpiryDay", FlightBookings.PassportExpiryDay, DbType.Int32);
                parameters.Add("PassportExpiryMonth", FlightBookings.PassportExpiryMonth, DbType.Int32);
                parameters.Add("PassportExpiryYr", FlightBookings.PassportExpiryYr, DbType.Int32);
                parameters.Add("PassportLastName", FlightBookings.PassportLastName, DbType.String);
                parameters.Add("PassportFirstName", FlightBookings.PassportFirstName, DbType.String);
                parameters.Add("Email", FlightBookings.Email, DbType.String);
                parameters.Add("EmailConfirm", FlightBookings.EmailConfirm, DbType.String);
                parameters.Add("PhoneCountryCode", FlightBookings.PhoneCountryCode, DbType.String);
                parameters.Add("Phone", FlightBookings.Phone, DbType.String);
                parameters.Add("FlightDate", FlightBookings.FlightDate, DbType.DateTime);
                parameters.Add("FromID", FlightBookings.FromID, DbType.Int32);
                parameters.Add("ToID", FlightBookings.ToID, DbType.Int32);
                parameters.Add("Depart", FlightBookings.Depart, DbType.DateTime);
                parameters.Add("Arrive", FlightBookings.Arrive, DbType.DateTime);
                parameters.Add("BookingTime", FlightBookings.BookingTime, DbType.Time);
                parameters.Add("Amount", FlightBookings.Amount, DbType.String);
                parameters.Add("Paid", FlightBookings.Paid, DbType.Boolean);
                parameters.Add("Confirmed", FlightBookings.Confirmed, DbType.Boolean);
                parameters.Add("Cancelled", FlightBookings.Cancelled, DbType.Boolean);
                parameters.Add("TenantID", FlightBookings.TenantID, DbType.Int32);

                await conn.ExecuteAsync(sql, parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
        }

        public async Task<bool> FlightBookingsUpdate(FlightBookingsData flightbookings)

        {
            var sql = "FlightBookingsUpdateSp";

            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("FlightBookingId", FlightBookings.FlightBookingId, DbType.Int64);
                parameters.Add("Gender", FlightBookings.Gender, DbType.String);
                parameters.Add("LastName", FlightBookings.LastName, DbType.String);
                parameters.Add("FirstName", FlightBookings.FirstName, DbType.String);
                parameters.Add("BirthDay", FlightBookings.BirthDay, DbType.Int32);
                parameters.Add("BirthMonth", FlightBookings.BirthMonth, DbType.Int32);
                parameters.Add("BirthYr", FlightBookings.BirthYr, DbType.Int32);
                parameters.Add("Nationality", FlightBookings.Nationality, DbType.String);
                parameters.Add("PassportNo", FlightBookings.PassportNo, DbType.String);
                parameters.Add("IssuingCountry", FlightBookings.IssuingCountry, DbType.String);
                parameters.Add("PassportExpiryDay", FlightBookings.PassportExpiryDay, DbType.Int32);
                parameters.Add("PassportExpiryMonth", FlightBookings.PassportExpiryMonth, DbType.Int32);
                parameters.Add("PassportExpiryYr", FlightBookings.PassportExpiryYr, DbType.Int32);
                parameters.Add("PassportLastName", FlightBookings.PassportLastName, DbType.String);
                parameters.Add("PassportFirstName", FlightBookings.PassportFirstName, DbType.String);
                parameters.Add("Email", FlightBookings.Email, DbType.String);
                parameters.Add("EmailConfirm", FlightBookings.EmailConfirm, DbType.String);
                parameters.Add("PhoneCountryCode", FlightBookings.PhoneCountryCode, DbType.String);
                parameters.Add("Phone", FlightBookings.Phone, DbType.String);
                parameters.Add("FlightDate", FlightBookings.FlightDate, DbType.DateTime);
                parameters.Add("FromID", FlightBookings.FromID, DbType.Int32);
                parameters.Add("ToID", FlightBookings.ToID, DbType.Int32);
                parameters.Add("Depart", FlightBookings.Depart, DbType.DateTime);
                parameters.Add("Arrive", FlightBookings.Arrive, DbType.DateTime);
                parameters.Add("BookingTime", FlightBookings.BookingTime, DbType.Time);
                parameters.Add("Amount", FlightBookings.Amount, DbType.String);
                parameters.Add("Paid", FlightBookings.Paid, DbType.Boolean);
                parameters.Add("Confirmed", FlightBookings.Confirmed, DbType.Boolean);
                parameters.Add("Cancelled", FlightBookings.Cancelled, DbType.Boolean);
                parameters.Add("TenantID", FlightBookings.TenantID, DbType.Int32);


                await conn.ExecuteAsync(sql, parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
        }

        public async Task<bool> FlightBookingsDelete(FlightBookingsData flightbookings)
        {
            var sql = "FlightBookingsDeleteSp";

            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("FlightBookingId", FlightBookings.FlightBookingId, DbType.Int64);

                await conn.ExecuteAsync(sql, parameters, commandType: CommandType.StoredProcedure);
                return true;
            }
        }


    }
}


