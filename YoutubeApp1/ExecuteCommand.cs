using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApp1
{
    internal class ExecuteCommand
    {
        public async Task ExecuteCommandAsync(ICommand command)
        {
            await command.ExecuteAsync();
        }
    }
}
