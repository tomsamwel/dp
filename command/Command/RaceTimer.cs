using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;

namespace Command
{
    internal class RaceTimer : INotifyPropertyChanged
    {
        private int number = 0;
        Timer timer;
        public RaceTimer()
        {
            timer = new Timer()
            {
                Interval = 1000
            };
            timer.Elapsed += OnTimerEvent;
            timer.Enabled = true;
            timer.AutoReset = true;
        }
        

        private void OnTimerEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Number++;
        }
        public int Number
        {
            get { return number; }
            set
            { number = value; OnPropertyChanged(); }
        }
        public void IncreaseAmount()
        {
            Console.WriteLine("Adding 1 to the total");
            Number++;
        }
        public void DecreaseAmount()
        {
            Console.WriteLine("Removing 1 to the total");
            Number--;
        }
        public void SetAmount(int x)
        {
            Console.WriteLine("Setting number to " + x);
            Number = x;
        }
        public void AddAmount(int x)
        {
            Console.WriteLine("Adding " + x + " to the total");
            Number = x + number;
        }
        public void RemoveAmount( int x)
        {
            Console.WriteLine("Removing " + x + " to the total");
            Number = number - x;
        }
        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
        #endregion
    }
}
