using NLog;

namespace MyWarcraft.Models
{
    public class Pawn
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private Point location;

        public Point Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        /// <summary>
        /// Event used to gather a resource
        /// </summary>
        public event GatherEvent GatherEvent;

        public void MoveToLocation(Point argLocation)
        {
            logger.Info("moving to location {0}", argLocation);
            Location = argLocation;
        }

        /// <summary>
        /// GatherEvent invoker
        /// </summary>
        public void GatherResources()
        {
            GatherEvent?.Invoke();
        }
    }
}
