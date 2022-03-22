using BusReservationSystem.BusinessAccessLayer;
using BusReservationSystem.DataAccessLayer;
using BusReservationSystem.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;

namespace BusReservationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusScheduleController : Controller
    {
        private IBusScheduleDao _scheduleDao;
        private BustravelContext _bustravelContext;
        public BusScheduleController(IBusScheduleDao scheduleDao, BustravelContext bustravelContext)
        {
            this._scheduleDao = scheduleDao;
            this._bustravelContext = bustravelContext;
        }

        [HttpGet]
        [Route("allDetails")]

        public IActionResult FetchAllData()
        {
            try
            {
                return this.Ok(_scheduleDao.FetchAllDetails());
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("fetchbyid")]
        public IActionResult FetchDataById(int id)
        {
            try
            {
                return this.Ok(_scheduleDao.FetchDetailsById(id));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }



        [HttpPost]
        [Route("InsertData")]
        public IActionResult InsertBusScheduleInfo(BusScheduleModel Schedule)
        {
            var result = _scheduleDao.InsertBusScheduleInfo(Schedule);
            return this.CreatedAtAction(
            "InsertBusScheduleInfo",
            new
            {
                StatusCode = 201,
                Response = result,
                Data = Schedule
            }
            );
        }
        [HttpPost("search")]
        public IActionResult SearchBus(BusSearchDto busSearchDto)
        {
            var result = _bustravelContext.BusSchedule.Join(_bustravelContext.BusFare,
                c => c.FareId, o => o.FareId, (c, o) => new
                {
                    c.DriverName,
                    c.DepartureDate,
                    c.ArrivalDate,
                    c.AvailableSeats,
                    o.FareAmount,
                    c.RouteId
                }).Join(_bustravelContext.RouteDetails,
                a => a.RouteId, b => b.RouteId, (a, b) => new
                {
                    a.DriverName,
                    a.DepartureDate,
                    a.ArrivalDate,
                    a.AvailableSeats,
                    a.FareAmount,
                    b.DepartureStation,
                    b.DestinationStation,
                    b.Duration
                }).Where(a => a.DestinationStation == busSearchDto.To && a.DepartureStation == busSearchDto.From
                && a.DepartureDate == busSearchDto.DateOfJourney).ToList();
            

            //foreach (var item in result)
            //{
            //    if (item.DepartureStation == busSearchDto.From
            //        && item.DestinationStation == busSearchDto.To
            //        && item.DepartureDate == busSearchDto.DateOfJourney)
            //    {
                    
            //    }
            //}
            return Ok(result);
        }
    }
}


