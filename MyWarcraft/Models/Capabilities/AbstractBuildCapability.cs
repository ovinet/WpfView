using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWarcraft.Models.Buildings;

namespace MyWarcraft.Models.Capabilities
{
    public abstract class AbstractBuildCapability
    {
        public abstract AbstractBuilding Build(AbstractBuilding building);
    }
}
