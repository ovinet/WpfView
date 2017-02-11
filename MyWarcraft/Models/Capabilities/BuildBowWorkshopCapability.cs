using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWarcraft.Models.Buildings;

namespace MyWarcraft.Models.Capabilities
{
    class BuildBowWorkshopCapability : AbstractBuildCapability
    {
        public override AbstractBuilding Build(AbstractBuilding building)
        {
            return new BowWorkshop(0, 0, 0);
        }
    }
}
