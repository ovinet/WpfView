using MyWarcraft.Models.Events;

namespace MyWarcraft.Models
{ 
    public interface ICommandReader
    {
        event PushCommand PushCommandEvent;
        void ReadCommands();
    }
}