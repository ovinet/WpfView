﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWarcraft.Models.Commands
{
    public delegate void ExecutionUnit();

    class PlayerCommand : ICommand
    {
        private ExecutionUnit executionUnit;
        public PlayerCommand(ExecutionUnit executionUnit)
        {
            this.executionUnit = executionUnit;
        }

        public void Execute()
        {
            if (executionUnit != null)
            {
                executionUnit();
            }
        }
    }
}
