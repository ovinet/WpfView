using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWarcraft.Models.Buildings;

namespace MyWarcraft.Models.Capabilities
{
    class BuildBarrackCapability : AbstractBuildCapability
    {
        public override AbstractBuilding Build(AbstractBuilding building)
        {
            return new Barrack(0, 0, 0);
        }
    }
}
