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
        //Fields
        List<Task> carsBeingWashed = new List<Task>();

        //Constructor
        public CarWash()
        {

        }

        /// <summary>
        /// Starts a new task and addes that task to a list of tasks
        /// </summary>
        /// <param name="t"></param>
        public void WashNewCar(Ticket t)
        {
            var task = new Task(() => WashCar(t));
            carsBeingWashed.Add(task);
            task.Start();
        }

        //Contents for new task
        private void WashCar(Ticket t)
        {
            Console.SetCursorPosition(0, 15);
            Console.WriteLine($"Vehicle on parking spot ID: {t.SpotID} is being washed and will be done in 10 min");
            Thread.Sleep(600000); //Wait 10 min
            Console.WriteLine($"Vehicle on parking spot ID: {t.SpotID} has been washed");
        }
    }
}