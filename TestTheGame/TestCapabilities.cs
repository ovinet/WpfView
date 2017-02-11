using MyWarcraft.Models;
using MyWarcraft.ViewModels;
using NUnit.Framework;

namespace TestTheGame
{
    [TestFixture]
    public class TestCapabilities
    {
        private PlayerViewModel PlayerBaseVM;

        [SetUp]
        public void SetUp()
        {
            var p = new Player();
            PlayerBaseVM = new PlayerViewModel(p);
        }

        [Test]
        public void TestPlayerBaseComponents()
        {
            Assert.AreEqual(2, PlayerBaseVM.Player.Components.Count);
        }

        [Test]
        public void TestBuildildingAFarm()
        {
            PlayerBaseVM.BoardVM.SelectedComponent = PlayerBaseVM.BoardVM.PawnVMs[0];
            Assert.AreEqual(2, PlayerBaseVM.BoardVM.PawnVMs.Count, "There should be only two components at startup!");
            PlayerBaseVM.BoardVM.PawnVMs[0].Click.Execute(null);
            Assert.NotNull(PlayerBaseVM.BoardVM.SelectedComponent);
            PlayerBaseVM.BoardVM.SelectedComponent.UnitsCapabilitiesVMs[0].StartBuilding.Execute(null);
            Assert.AreEqual(3, PlayerBaseVM.BoardVM.PawnVMs.Count, "There should be 3 components now!");
        }
    }
}
