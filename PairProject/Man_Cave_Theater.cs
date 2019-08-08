using System;
using System.Collections.Generic;
using System.Text;

namespace PairProject
{
    class Man_Cave_Theater : IBig_Screen
    {
        public string ChangeChannel(Channel channel)
        {
            string channelSelection= $"Now changing to: {channel}";

            return channelSelection;
        }
        
    }
}
