using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Command
{
    /// <summary>
    /// Interaction logic for RaceGame.xaml
    /// </summary>
    public partial class RaceGame : Window
    {
        public RaceGame()
        {
            InitializeComponent();
            DataContext = _raceTimer;
        }
        private Invoker_Queue invoker = new Invoker_Queue();
        private RaceTimer _raceTimer = new RaceTimer();
                
        #region Button_Handlers
        private void Button_Click_Increase(object sender, RoutedEventArgs e)
        {
            invoker.addCommand(new IncreaseCommand(_raceTimer));
        }
        private void Button_Click_Decrease(object sender, RoutedEventArgs e)
        {
            invoker.addCommand(new DecreaseCommand(_raceTimer));
        }
        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            int result;
            if(int.TryParse(Input.Text, out result))
            {
                invoker.addCommand(new AddCommand(_raceTimer, result));
            }
            else
            {
                Console.WriteLine("Input a valid number.");
            }
        }
        private void Button_Click_Remove(object sender, RoutedEventArgs e)
        {
            int result;
            if (int.TryParse(Input.Text, out result))
            {
                invoker.addCommand(new SubtractCommand(_raceTimer, result));
            }
            else
            {
                Console.WriteLine("Input a valid number.");
            }
        }
        private void Button_Click_Set(object sender, RoutedEventArgs e)
        {
            int result;
            if (int.TryParse(Input.Text, out result))
            {
                invoker.addCommand(new SetCommand(_raceTimer, result));
            }
            else
            {
                Console.WriteLine("Input a valid number.");
            }
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            invoker.ExecuteCommands();
        }
        #endregion
    }
}
