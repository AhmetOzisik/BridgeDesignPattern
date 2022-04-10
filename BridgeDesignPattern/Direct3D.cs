using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class Direct3D : IVideoMod
    {
        public void Oynat()
        {
            Console.WriteLine("Direct3D");
        }
    }
}
