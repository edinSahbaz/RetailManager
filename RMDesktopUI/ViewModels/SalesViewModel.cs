using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private BindingList<string> _products;
        private string _itemQuantity;
        private BindingList<string> _cart;

        public BindingList<string> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        public BindingList<string> Cart
        {
            get { return _cart; }
            set
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        public string ItemQuantity
        {
            get { return _itemQuantity; }
            set
            {
                _itemQuantity = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        public string SubTotal
        {
            get
            {
                //Add calculation logic
                return "$0.00";
            }
        }

        public string Tax
        {
            get
            {
                //Add calculation logic
                return "$0.00";
            }
        }

        public string Total
        {
            get
            {
                //Add calculation logic
                return "$0.00";
            }
        }

        public bool CanAddToCart
        {
            get
            {
                bool output = false;
                
                //Selection check


                //Quantity check


                return output;
            }
        }

        public void AddToCart()
        {

        }

        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;

                //Selection check


                return output;
            }
        }

        public void RemoveFromCart()
        {

        }

        public bool CanCheckOut
        {
            get
            {
                bool output = false;

                //Selection check from cart

                return output;
            }
        }

        public void CheckOut()
        {

        }
    }
}