namespace Uwarcraft.Units
{
    public abstract class AbstractBuildable: IBuildable
    {
        protected AbstractBuilder builder;

        private int percentageBuilt;

        public int PercentageBuilt
        {
            get
            {
                return percentageBuilt;
            }

            set
            {
                percentageBuilt = value;
            }
        }

        public event BuildingComplete BuildingComplete;

        public virtual void Ready(int percentage)
        {
            if (BuildingComplete!=null)
            {
                BuildingComplete.Invoke(this, new BuildingCompleteEventArgs());
            }
        }

        public virtual void StartBuilding()
        {
            builder.StartBuilding(this);
        }
    }
}
