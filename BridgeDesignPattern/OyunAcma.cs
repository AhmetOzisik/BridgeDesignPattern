using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public abstract class OyunAcma
    {

        protected IVideoMod videoMod;
        public OyunAcma(IVideoMod _videoMod)
        {
            videoMod = _videoMod;
        }
        public virtual void OyunAc()
        {
            videoMod.Oynat();

        }
    }
}
