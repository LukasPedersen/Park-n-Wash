using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Park_n_Wash.Common;

namespace Park_n_Wash
{
    public class CarWash
    {
        List<Task> carsBeingWashed = new List<Task>();
        public CarWash()
        {

        }
        public void WashNewCar(Ticket t)
        {
            var task = new Task(() => WashCar(t));
            carsBeingWashed.Add(task);
            task.Start();
        }
        private void WashCar(Ticket t)
        {
            Console.SetCursorPosition(0, 15);
            Console.WriteLine($"Vehicle on parking spot ID: {t.SpotID} is being washed and will be done in 10 min");
            Thread.Sleep(600000);
            Console.WriteLine($"Vehicle on parking spot ID: {t.SpotID} has been washed");
        }
    }
}