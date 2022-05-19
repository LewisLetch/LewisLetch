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
    /// Interaction logic for Enter_detailss.xaml
    /// </summary>
    public partial class Enter_detailss : Window
    {
        public Enter_detailss()
        {
            InitializeComponent();

            car.carName[0] = "Toyota IQ";
            car.carName[1] = "Mini Cooper S";
            car.carName[2] = "VW Polo";
            car.carName[3] = "Audi TT";
            car.carName[4] = "Mercedes A 220";
            car.carName[5] = "Range Rover Evoque";
            car.carName[6] = "Jaguar XJ";



            car.Location[0] = "Edinburgh Airport";
            car.Location[1] = "Glasgow Airport";
            car.Location[2] = "Prestwick Airport";
            car.Location[3] = "Edinburgh City Centre";
            car.Location[4] = "Glasgow City Centre";
            car.Location[5] = "Livingston";
            int i = 0;
            int o = 0;

            

            do
            {
                carList.Items.Add(car.carName[i]);
                i++;
            } while (i < 7);

            do
            {
                locationList.Items.Add(car.Location[o]);
                o++;
            } while (o < 6);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow addWindow = new MainWindow();
            addWindow.Show();
            this.Close();
        }

        private void book_Click(object sender, RoutedEventArgs e)
        {
            bool isNumberdays = int.TryParse(daysInput.Text, out int n);
            bool isNumberage = int.TryParse(ageInput.Text, out int t);

            if (string.IsNullOrEmpty(ageInput.Text) || string.IsNullOrEmpty(daysInput.Text) || carList.SelectedIndex == -1 || locationList.SelectedIndex == -1)
            {

                MessageBox.Show("Every box must be filled");

            } 
            else 
            {
                if (isNumberdays == true)
                {
                    car.days = Int32.Parse(daysInput.Text);

                    if (isNumberage == true)
                    {
                    car.age = Int32.Parse(ageInput.Text);

                        if (Int32.Parse(ageInput.Text) >= 17){
                            car.carArrayNumber = carList.SelectedIndex;
                            car.locationArrayNumber = locationList.SelectedIndex;



                            car.overallPrice = (car.carPrice[car.carArrayNumber] * car.days);

                            if (Int32.Parse(ageInput.Text) <= 25)
                            {
                                car.overallPrice = car.overallPrice + 20;
                            }

                            Output addWindow = new Output();
                            addWindow.Show();
                            this.Close();
                        }
                        else 
                        {
                            MessageBox.Show("You are to young to drive");
                        }
                    }
                    else
                    {

                        MessageBox.Show("The age must be entered numerically");

                    }
                }
                else 
                {

                    MessageBox.Show("The days must be entered numerically");

                }

            }
        }

        private void carList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
   }
