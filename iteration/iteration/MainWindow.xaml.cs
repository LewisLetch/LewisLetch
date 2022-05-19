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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace iteration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {

            int X = 0;
            int A = 0;
            //Resets X and A



            bool isANumber = int.TryParse(InputA.Text, out int n);
            bool isXNumber = int.TryParse(InputX.Text, out int t);

            if (isANumber == true && isXNumber == true)
                //checks if the text entered is numeric
            {
                if (string.IsNullOrEmpty(InputA.Text) || string.IsNullOrEmpty(InputX.Text))
                    //checks if the boxes are empty will say true if they are 
                {
                    MessageBox.Show("All boxes need to be filled");
                    //shows the user the message
                }
                else
                {
                    A = Int32.Parse(InputA.Text);
                    X = Int32.Parse(InputX.Text);
                    if (A < X && A>-X)
                    {
                        int counter = 1;
                        //sets the counter
                        do
                        {

                            A = A * counter;

                            counter++;
                        } while (A < X);
                        //loops untill A * counter is bigger than or equal too X


                        int twoX = X * 2;
                        //Times the X by 2


                        counter = 1;
                        //resets the counter
                        do
                        {

                            A = (A * counter) + 1;

                            counter++;
                        } while (A < twoX);
                        //loops untill A * counter + 1 is bigger than twoX 


                        int threeX = X * 3;
                        //Times the X by 3 and stores it in threeX


                        counter = 1;
                        //resets the counter
                        do
                        {

                            A = (A * counter) + 2;

                        } while (A < threeX);
                        //loops untill A * counter + 2 is bigger than threeX 

                    }
                    else
                    {
                        MessageBox.Show("A must be smaller than X");
                        //shows the user the message
                    }
                }
            }
            else
            {
                MessageBox.Show("Must be numeric");
                //shows the user the message
            }

            //I have assumed that A and X need to be assigned numbers and I have assumed A carries through the number from the previous loop

        }
    }
}
