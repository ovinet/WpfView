namespace MyWarcraft.Models.Builders
{
    public class SimpleBuilder : AbstractBuilder
    {
        public SimpleBuilder()
        {
            TimeForEachStep = 200;
            PercentageBuiltAtEachStep = 5;
        }
    }
}
