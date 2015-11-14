using System.Timers;

namespace Uwarcraft.Units
{
    public class AbstractBuilder
    {
        protected Timer timer;
        private int timeToBuild;
        private IBuildable objectToBeBuilt;

        public int TimeToBuild
        {
            get
            {
                return timeToBuild;
            }

            set
            {
                timeToBuild = value;
                timer.Interval = value;
            }
        }

        public virtual void StartBuilding(IBuildable objectToBeBuilt)
        {
            this.objectToBeBuilt = objectToBeBuilt;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            objectToBeBuilt.Ready(100);
        }
    }
}
