using System.Collections.Generic;
using System.Threading.Tasks;

namespace SamsAppV7.Data
{
    public class IFlightBookinsService
    {
        Task<List<FlightBookingsData>> GetAll();
        Task<bool> FlightBookingsInsert(FlightBookingsData FlightBookings);
        Task<int> GetFlightData();
        Task<bool> FlightBookingsUpdate(FlightBookingsData FlightBookings);
        Task<bool> FlightBookingsDelete(FlightBookingsData FlightBookings);
    }
}
