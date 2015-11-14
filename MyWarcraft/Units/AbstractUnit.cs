using NLog;

namespace Uwarcraft.Units
{
    public abstract class AbstractUnit: AbstractBuildable
    {
        protected Logger Log;

        public AbstractUnit()
        {
            Log = LogManager.GetLogger(GetType().FullName);
        }
    }
}
