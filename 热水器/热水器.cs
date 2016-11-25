using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第五次作业
{
    class HotWaterQi
    {
        public int waterHot;
        public delegate void aWeituo(object sender,EventArgs e);
        public event aWeituo waterBecomeHot;
        protected void wwterBecomeHot(EventArgs e)
        {
            if(waterBecomeHot!=null)
            {
                waterBecomeHot(this,e);
            }
        }
        public void Boilwater()
        {
            int i;
            for (i=0;i<=100 ;i++)
            {
                waterHot = i;
                Console.WriteLine("水温{0}°C", waterHot);
                System.Threading.Thread.Sleep(1000);
                if (waterHot>80)
            {
                Console.WriteLine("警告\a");
                wwterBecomeHot(EventArgs.Empty);
            }
            }
            
        }
        
    }
}
