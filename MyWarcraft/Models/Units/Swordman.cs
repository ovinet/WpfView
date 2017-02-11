using System;
using MyWarcraft.Models.Builders;

namespace MyWarcraft.Models.Units
{
    public class Swordman : AbstractUnit
    {
        public Swordman()
        {
            Name = "Swordman";
            State = State.UNDER_CONSTRUCTION;
            builder = new SimpleBuilder();
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void Move(Point destination)
        {
            throw new NotImplementedException();
        }
    }
}