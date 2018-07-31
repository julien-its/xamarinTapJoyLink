using System;

namespace Com.Tapjoy
{
    public partial class ITJVideoListenerErrorEventArgs
    {
        public void JITSVideoListenerErrorEventArgs(int p0)
        {
            this.p0 = p0;
        }

        int p0;
        public int P0
        {
            get { return p0; }
        }
    }
}

