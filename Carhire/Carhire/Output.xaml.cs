using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Carhire
{
    /// <summary>
    /// Interaction logic for Output.xaml
    /// </summary>
    public partial class Output : Window
    {
        public Output()
        {
            InitializeComponent();

            selectedCar.Text = "You selected a " + car.carName[car.carArrayNumber];
            outputDays.Text = "For " +  car.days + " days";
            outputAirport.Text = "From " + car.Location[car.locationArrayNumber];
            outputAge.Text = "You are " + car.age + " years old";
            totalCost.Text = "Total hire cost will be £" + car.overallPrice;

        }

        private void finishButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow addWindow = new MainWindow();
            addWindow.Show();
            this.Close();
        }
    }
}
