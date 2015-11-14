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
                var arg = new BuildingCompleteEventArgs();
                arg.Capabilities = new System.Collections.ObjectModel.ObservableCollection<AbstractBuildBuildingCapability>();
                BuildingComplete.Invoke(this, arg);
            }
        }

        public virtual void StartBuilding()
        {
            builder.StartBuilding(this);
        }
    }
}
