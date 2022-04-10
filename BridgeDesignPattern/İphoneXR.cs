using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
   public class İphoneXR:OyunAcma
    {
        public İphoneXR(IVideoMod videoMod) : base(videoMod) { }
        public override void OyunAc()
        {
            Console.WriteLine("İphoneXR da acildi.");
            base.OyunAc();
        }
    }
}
