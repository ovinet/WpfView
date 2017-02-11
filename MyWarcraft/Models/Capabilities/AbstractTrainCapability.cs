using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWarcraft.Models.Units;

namespace MyWarcraft.Models.Capabilities
{
    public abstract class AbstractTrainCapability
    {
        public abstract AbstractUnit Train(AbstractUnit unit = null);

    }
}
