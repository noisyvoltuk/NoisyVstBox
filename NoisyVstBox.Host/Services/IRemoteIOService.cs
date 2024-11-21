using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoisyVstBox.Host.Services
{
    public  interface IRemoteIOService
    {
        public void SendMessageToLCD(string msg);
    }
}
