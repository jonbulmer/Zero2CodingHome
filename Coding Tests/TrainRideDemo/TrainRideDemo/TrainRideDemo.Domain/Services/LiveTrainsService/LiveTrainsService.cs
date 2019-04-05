﻿using System;
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

    public class LiveTrainsService : IBaseService<TimeTable>, ILiveTrainsService
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

        TimeTable IBaseService<TimeTable>.Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<TimeTable> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<TimeTable> GetAll(Expression<Func<TimeTable, bool>> whereClause)
        {
            throw new NotImplementedException();
        }

        public ResponseObject Update(TimeTable arg)
        {
            throw new NotImplementedException();
        }

        public ResponseObject Insert(TimeTable arg)
        {
            throw new NotImplementedException();
        }

        public ResponseObject Delete(int id)
        {
            throw new NotImplementedException();
        }


        public void GetWith_Stop(int id)
        {
            var dbData = tctx.TimeTables
                .Include(t => t.Route)
                .Include(t => t.Route.StopMaxtrixs)
                .ThenInclude(sm => sm.ArrivalTimes)
                .ToList();

            foreach (var item in dbData)
            {
                liveTrains.Add(new LiveTrainsViewModel { RouteName = item.Route.Name, StopMaxtrix = item.Route.StopMaxtrixs.ToList() });
            }         
        }

    }
}