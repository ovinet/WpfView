using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWarcraft.Models.Units;

namespace MyWarcraft.Models.Capabilities
{
    public class TrainFarmerCapability : AbstractTrainCapability
    {
        public override AbstractUnit Train(AbstractUnit unit)
        {
            var farmer = new Farmer(0, 0, 100);
            return farmer;
        }
    }
}
