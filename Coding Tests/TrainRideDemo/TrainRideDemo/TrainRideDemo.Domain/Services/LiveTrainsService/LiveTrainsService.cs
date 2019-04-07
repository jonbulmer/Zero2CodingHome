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
        List<LiveTrainsViewModel> GetAllLiveTrains();
        LiveTrainsViewModel Add(LiveTrainsViewModel Item);
        LiveTrainsViewModel Get(int Id);

    }

    public interface ICalculator
    {
        int Add(int a, int b);
        string Mode { get; set; }
            event EventHandler PoweringUp;
    }

    public class LiveTrainsService : IBaseService<SetOffTime>, ILiveTrainsService
    {

        private List<LiveTrainsViewModel> liveTrains = new List<LiveTrainsViewModel>();

        public TrainRideDemoContext tctx = new TrainRideDemoContext(); 

        private int Id = 1;

        public LiveTrainsService()
        {
            Add(new LiveTrainsViewModel { TrainName = "HaintonStar", RouteName = "ABNKGX" });
        }

        public List<LiveTrainsViewModel> GetAllLiveTrains()
        {
            GetWith_Stop(3);

            return liveTrains;
        }

        public LiveTrainsViewModel Add(LiveTrainsViewModel Item)
        {
            if (Item == null)
            {
                throw new ArgumentException("item");
            }

            Item.Id += Id;
            liveTrains.Add(Item);
            return Item;
        }

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
            var dbData = tctx.SetOffTimes
                .Include(t => t.Route)
                .Include(t => t.Route.StopPositionOnRoutes)
                .ToList();

            

            foreach (var item in dbData)
            {
               liveTrains.Add(new LiveTrainsViewModel { RouteName = item.Route.Name });
            }         
        }

    }
}

 //.Include(t => t.Route)
                //.Include(t => t.Route.StopMaxtrixs)
                //.ThenInclude(sm => sm.ArrivalTimes)