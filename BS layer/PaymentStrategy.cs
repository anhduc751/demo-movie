using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TungMovie
{
    class PaymentStrategy
    {

        public interface IPaymentStrategy
        {
            void ExecutePayment(string username, string moviename, DateTime bookingdate, int usernumber, int price);
        }


        public class MoMoPaymentStrategy : IPaymentStrategy
        {
            public void ExecutePayment(string username, string moviename, DateTime bookingdate, int usernumber, int price)
            {
                MessageBox.Show("Book ticket Successful with MoMo\n" + "User: " +username +"\nMovie: " +moviename
                    + "\nDate: " +bookingdate.ToString() + "\nYour number: "+usernumber + "\nPrice: " + price, "Book Ticket", MessageBoxButtons.OK);
            }
        }

        public class ZaloPayPaymentStrategy : IPaymentStrategy
        {
            public void ExecutePayment(string username, string moviename, DateTime bookingdate, int usernumber, int price)
            {
                MessageBox.Show("Book ticket Successful with ZaloPay\n" + "User: " + username + "\nMovie: " + moviename
                     + "\nDate: " + bookingdate.ToString() + "\nYour number: " + usernumber + "\nPrice: " + price, "Book Ticket", MessageBoxButtons.OK);
            }
        }

        public class ViettelPayPaymentStrategy : IPaymentStrategy
        {
            public void ExecutePayment(string username, string moviename, DateTime bookingdate, int usernumber, int price)
            {
                MessageBox.Show("Book ticket Successful with ViettelPay\n" + "User: " + username + "\nMovie: " + moviename
                     + "\nDate: " + bookingdate.ToString() + "\nYour number: " + usernumber + "\nPrice: " + price, "Book Ticket", MessageBoxButtons.OK);
            }
        }


        public class PaymentContext
        {
            private IPaymentStrategy PaymentStrategy;

            public void SetPaymentStrategy(IPaymentStrategy strategy)
            {
                this.PaymentStrategy = strategy;
            }

            public void ExecutePayment(string username, string moviename, DateTime bookingdate, int usernumber, int price)
            {
                PaymentStrategy.ExecutePayment( username,  moviename,  bookingdate,  usernumber,  price);
            }
        }
    }
}

