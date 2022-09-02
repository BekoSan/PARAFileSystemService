using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PARAFileSystemService
{
    public class ParaService
    {

        private readonly Timer _timer;

        public ParaService()
        {
            _timer = new Timer(1000) { AutoReset = true  };
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            //TODO: Wirte PARA Method.
        }

        public void Start()
        {
            _timer.Start(); 
        }

        public void Stop()
        {
            _timer.Stop();
        }

    }
}
