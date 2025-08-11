using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.EventAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public required Video Video { get; set; }
    }
}
