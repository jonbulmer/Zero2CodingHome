using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrainRideDemo.Data;
using TrainRideDemo.Domain;

namespace TrainDemo.MVC.Models
{
    public interface ITrainDashboardDisplay
    {
        List<LiveTrainsViewModel> GetAllLiveTrains();
        LiveTrainsViewModel Add(LiveTrainsViewModel Item);
        LiveTrainsViewModel Get(int Id);

    }

    public class TrainDashboardDisplay : ITrainDashboardDisplay
    {

        private List<LiveTrainsViewModel> liveTrains = new List<LiveTrainsViewModel>();

        public TrainRideDemoContext tctx = new TrainRideDemoContext(); 

        private int Id = 1;

        public TrainDashboardDisplay()
        {
            Add(new LiveTrainsViewModel { TrainName = "HaintonStar", RouteName = "ABNKGX" });
        }

        public List<LiveTrainsViewModel> GetAllLiveTrains()
        {
            return tctx.Stop
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
    }
}