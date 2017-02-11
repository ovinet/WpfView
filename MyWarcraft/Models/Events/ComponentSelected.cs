using MyWarcraft.ViewModels;
using System;

namespace MyWarcraft.Models.Events
{
    public delegate void ComponentSelected(object sender, ComponentSelectedEventArgs e);
   
    public class ComponentSelectedEventArgs : EventArgs
    {
        public PawnViewModel ComponentVM { get; set; }
    }
}
