using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TrainRideDemo.Data;
using TrainRideDemo.Domain.Service;
using Microsoft.EntityFrameworkCore;

namespace TrainDemo.Domain.Service
{
    public interface ILiveTrainsService
    {
        List<LiveTrainsViewModel> GetAllDeparturesForStopByDay(int stopId, DateTime workingDay);
        LiveTrainsViewModel Get(int Id);
        List<Stop> GetAllStops();


    }

    public interface ICalculator
    {
        int Add(int a, int b);
        string Mode { get; set; }
            event EventHandler PoweringUp;
    }

    public class LiveTrainsService : IBaseService<SetOffTime>, ILiveTrainsService
    {
        private readonly IScheduleDbContext _scheduleDbContext;
        public LiveTrainsService(IScheduleDbContext scheduleDbContext)
        {
            _scheduleDbContext = scheduleDbContext;
        }
        private List<LiveTrainsViewModel> liveTrains = new List<LiveTrainsViewModel>();

        public LiveTrainsViewModel Get(int Id)
        {
            return liveTrains.FirstOrDefault(x => x.Id == Id); ;
        }

        SetOffTime IBaseService<SetOffTime>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<SetOffTime> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<SetOffTime> GetAll(Expression<Func<SetOffTime, bool>> whereClause)
        {
            throw new NotImplementedException();
        }

        public ResponseObject Update(SetOffTime arg)
        {
            throw new NotImplementedException();
        }

        public ResponseObject Insert(SetOffTime arg)
        {
            throw new NotImplementedException();
        }

        public ResponseObject Delete(int id)
        {
            throw new NotImplementedException();
        }


        public void GetWith_Stop(int id)
        {
            var dbData = _scheduleDbContext.SetOffTimes
                .Include(t => t.Route)
                .Include(t => t.Route.StopPositionOnRoutes)
                .ToList();

            

            foreach (var item in dbData)
            {
               liveTrains.Add(new LiveTrainsViewModel { RouteName = item.Route.Name });
            }         
        }

        public List<LiveTrainsViewModel> GetAllDeparturesForStopByDay(int stopId, DateTime workingDay)
        {
            var dbReturn = _scheduleDbContext.StopPositionOnRoutes
                .Include(spr => spr.Route)
                .Include(spr => spr.StopProximity.Stop);

            IQueryable<StopPositionOnRoute> routesQuery = dbReturn;
            List<LiveTrainsViewModel> liveTrainsGridDTOQuery = routesQuery.Select(lt => new LiveTrainsViewModel
            {
                Id = lt.PositionIndex,
                Station = lt.StopProximity.Stop.Name,
                ArrivalTime = lt.ExpectedRelativeArrivalTime,
                RouteName = lt.Route.Name
            })
            .OrderBy(lt => lt.Id).ToList();
            return liveTrainsGridDTOQuery;



        }


        //Select r.Name, spr.ExpectedRelativeArrivalTime, s.Name from routes r
        //inner join StopPositionOnRoutes spr on r.Id = spr.RouteId
        //inner join StopProximities sp on spr.StopProximityId = sp.Id
        //inner join Stops s on sp.StopId = s.Id
        //order by PositionIndex

        public List<Stop> GetAllStops()
        {
            return _scheduleDbContext.Stops.ToList();
        }
    }
}