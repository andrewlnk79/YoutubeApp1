using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApp1
{
    internal interface ICommand
    {
        Task ExecuteAsync();
    }
}
