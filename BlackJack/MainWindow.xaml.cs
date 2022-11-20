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

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            TxtPlayerResult.Content = "0";
            TxtBankResult.Content = "0";
            BtnHit.IsEnabled = false;
            BtnStand.IsEnabled = false;



       
    }
        string suit = "";
        string value = "";
        int cardSuit = 0;
        int cardValue = 0;
        /*int teller = 0*/
        Random ranSuit = new Random();
        Random ranValue = new Random();
        private void BtnDeal_Click(object sender, RoutedEventArgs e)
        {
            GiveCards();
            Evaluetion(ref value);
        }

        private void GiveCards()
        {

            cardSuit = ranSuit.Next(1, 5);
            cardValue = ranValue.Next(1, 14);
            StringBuilder sb = new StringBuilder(cardSuit, cardValue);

            if (cardSuit == 1)
            {
                suit = Convert.ToString("Ruiten");
            }
            if (cardSuit == 2)
            {
                suit = Convert.ToString("Klaveren");
            }
            if (cardSuit == 3)
            {
                suit = Convert.ToString("Shoppen");
            }
            if (cardSuit == 4)
            {
                suit = Convert.ToString("Harten");
            }

            if (cardValue == 1)
            {
                value = Convert.ToString("Ass");
            }
            if (cardValue == 11)
            {
                value = Convert.ToString("Boer");
            }
            if (cardValue == 12)
            {
                value = Convert.ToString("Vrouw");
            }
            if (cardValue == 13)
            {
                value = Convert.ToString("Koning");
            }
            if (cardValue == 2 || cardValue == 3 || cardValue == 4 || cardValue == 5
                || cardValue == 6 || cardValue == 7 || cardValue == 8
                || cardValue == 9 || cardValue == 10)
            {
                value = Convert.ToString(cardValue);
            }
            sb.AppendLine(value);
            // Berekenen(ref value);
            //LstSpeler.Items.Add(suit);
            LstSpeler.Items.Add(value);

            //bool isSpeler = false;
            //if (ValidationStap(ref isSpeler))
            //{
            //    teller++;
            //    for (int teller = 0; teller < 2; teller++)
            //    {
            //        cardValue = random.Next(1, 14);
            //        if (teller > 1)
            //        {
            //            LstSpeler.Items.Add(cardValue);

            //        }
            //        else if(teller > 2)
            //        {
            //            LstSpeler.Items.Add(cardValue);
            //        }
            //    }
            //}






        }
        private void Evaluetion(ref string cardValue)
        {
            int value = 0;
            int result = 0;
            //StringBuilder sb = new StringBuilder(value);
            int cardHand = LstSpeler.Items.Count;
            foreach (object obj in LstSpeler.Items)
            {

                if (cardValue == "10" || cardValue == "Boer" || cardValue == "Vrouw"
                       || cardValue == "Koning")
                {
                    value = 10;
                }
                else if (cardValue == "2" || cardValue == "3" || cardValue == "4" ||
                  cardValue == "5" || cardValue == "6" || cardValue == "7"
                || cardValue == "8" || cardValue == "9")

                {
                    value = Convert.ToInt32(cardValue);
                }
                else if (cardValue == "Ass")
                {
                    value = 1;
                }
                //value = (int)obj;
                result += value;

                //sb.AppendLine(Convert.ToString(result));

                TxtPlayerResult.Content = result.ToString();
            }
        }
        private bool ValidationStap(ref bool isPlayer)
        {
            isPlayer = false;

            return isPlayer;
        }


        /*int handValue = 0;
             int teller = 0;
             string cardValue = "A";
             for(int i = 1; i <= handCards; i++)
             {
                 int value = 0;
                 if(cardValue == "10"|| cardValue == "Boer" || cardValue == "Vrouw" 
                            || cardValue == "Koning")
                 {
                     value = 10;
                 }
                 else if (cardValue == "2" || cardValue == "3" || cardValue == "4" || 
                     cardValue == "5" || cardValue == "6" || cardValue == "7" 
                   || cardValue == "8" || cardValue == "9")
                     
                 {
                     value = Convert.ToInt32(cardValue);
                 }
                 else if(cardValue == "Ass")
                 {
                     value = 1;
                 }
                 handValue += value;

             }*/

        //cardSuit Ruiten, Klaveren, Schoppen, Harten
    }
}
