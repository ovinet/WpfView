using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWarcraft.Models.Buildings;

namespace MyWarcraft.Models.Capabilities
{
    class UpgradeBarrackCapability : AbstractBuildCapability
    {

        #region Public Methods

        public override AbstractBuilding Build(AbstractBuilding building)
        {
            DecoratorBuilding upgradedBarrack;

            if (building.GetType() == typeof(Barrack))
            {
                upgradedBarrack = new BarrackLevel1(building as Barrack);
            }
            else if (building.GetType() == typeof(BarrackLevel1))
            {
                upgradedBarrack = new BarrackLevel2(building as BarrackLevel1);
            }
            else
            {
                // throw new InvalidOperationException(String.Format("Building of type {0} doesn't exist.", building.GetType().Name));
                throw new InvalidOperationException(String.Format("Reached maximum upgrade level for building [{0}] {1}.", building.Id, building.GetType().Name));
            }

            return upgradedBarrack;
        }

        #endregion

    }
}
