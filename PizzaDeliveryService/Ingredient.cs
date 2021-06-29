using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace PizzaDeliveryService
{
    class Ingredient : INotifyPropertyChanged
    {
        //##############################################################################################################################
        //### Instance Variables ###
        /// <summary>
        /// Ingredient Name
        /// </summary>
        private string _name;
        /// <summary>
        /// Standard serving size for ingrediant
        /// </summary>
        private double _standardServingSize;
        /// <summary>
        /// Energy value of ingrediant
        /// </summary>
        private double _energyValue;
        /// <summary>
        /// Purchase price of ingrediant
        /// </summary>
        private decimal _purchasePrice;
        /// <summary>
        /// Is or is not vegerterian
        /// </summary>
        private bool _vegeterian;



        //##################################################################################################################################
        //#### Constructor  #####
        public Ingredient()
            : this("", 0, 0, 0, false)
        {
        }

        public Ingredient (string name, double standardServingSize, double energyValue, decimal purchasePrice, bool vegeterian)
        {
            _name = name;
            _standardServingSize = standardServingSize;
            _energyValue = energyValue;
            _purchasePrice = purchasePrice;
            _vegeterian = vegeterian;
        }
        //###############################################
        //### Public Methods ###
     /* public override string ToString()
        {
            /*return _name + "(" + String.Format("{0:D8", _standardServingSize) + ")"
                + _energyValue + "(" + String.Format("{0:C", _purchasePrice) + ")" + _vegeterian;00           //return String.Format("{0} {1}g {2}kj ${3} {4}", _name, _standardServingSize, _energyValue, _purchasePrice, _vegeterian);

        } */

        //###############################################
        //### Properties ###
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    FirePropertyChanged("Name");

                }

            }
        }

        public double StandardServingSize
        {
            get { return _standardServingSize; }
            set 
            {
                if (_standardServingSize != value)
                {
                    _standardServingSize = value;
                    FirePropertyChanged("StandardServingSize"); 
                }

            }
        }

        public double EnergyValue
        {
            get { return _energyValue; }
            set
            {
                if (_energyValue != value)
                {
                    _energyValue = value;
                    FirePropertyChanged("EnergyValue");
                    
                }

            }
        }

        public decimal PurchasePrice
        {
            get { return _purchasePrice; }
            set
            {
                if (_purchasePrice != value)
                {
                    _purchasePrice = value;
                    FirePropertyChanged("PurchasePrice");

                }

            }
        }

        public bool Vegeterian
        {
            get { return _vegeterian; }
            set
            {
                if (_vegeterian != value)
                {
                    _vegeterian = value;
                    FirePropertyChanged("Vegeterian");

                }

            }
        }

        //####################################3
        // ### Event Handlers ###
        public event PropertyChangedEventHandler PropertyChanged;
        
        private void FirePropertyChanged(string prop)
        {
            // if there are registered listeners
            if (PropertyChanged != null)
            {
                // send the notification
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
            
        }
        
    }
}
