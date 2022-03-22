using System;

namespace BusReservationSystem.Repository
{
    public class BusSearchDto
    {
        public string From { get; set; }
        public string To { get; set; }
        public DateTime DateOfJourney { get; set; }
        public DateTime DateOfreturn { get; set; }
    }
}
