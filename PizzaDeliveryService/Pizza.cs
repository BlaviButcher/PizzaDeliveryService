using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace PizzaDeliveryService
{
    class Pizza : INotifyPropertyChanged
    {
        //############################################
        // ### Instance Variables ###
        // Pizza name
        private string _name;
        // Cost of pizza decided by company
        private decimal _purchasePrice;
        // List of ingredients added to pizza
        private BindingList<Ingredient> _addedIngredients;
        //Energy total
        private double _energy;
        
        private bool _vegeterian;
        //cost of pizza ingredient total
        private decimal _retailPrice;

        

        //############################################
        //### Constructor ###
        /// <summary>
        /// Default constructor
        /// </summary>
        public Pizza()
            : this("", 0, 0, true, 0)
        {

        }
        /// <summary>
        /// Creates Pizza
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pruchasePrice"></param>
        public Pizza(string name, decimal purchasePrice, double energy, bool vegeterian, decimal retailPrice)
        {
            // Initialise variables
            _name = name;
            _purchasePrice = purchasePrice;
            _vegeterian = vegeterian;
            _retailPrice = retailPrice;
            _energy = energy;
            // Creates empty list of ingredients
            _addedIngredients = new BindingList<Ingredient>();
            // Register a list changed event handler on the added ingredients list

            //  #### Used this line from Robi. Still struggle to understand how it works. Will ask him next time I see him. ######
           _addedIngredients.ListChanged += new ListChangedEventHandler(AddedIngredientsListChanged);

        }
        //############################################
        // ### Public Methods ###

        /// <summary>
        /// Add ingredient to pizza
        /// </summary>
        /// <param name="ingredient"></param>
        public void AddIngredient(Ingredient ingredient)
        {
            _addedIngredients.Add(ingredient);
        }

        // Displays the list of added ingrediants to the given data grid
        public void Bind(DataGridView grid)
        {
            grid.DataSource = _addedIngredients;

        }
        /// <summary>
        /// Loop through all ingredintes in pizza to compare to ingredient removed in ingredient list (All).
        /// If on pizza, then also delete from pizza.
        /// </summary>
        /// <param name="ingredient"></param>
        /// <param name="p"></param>
        public void CompareIngredients(Ingredient ingredient, Pizza p)
        {
            
            for (int i = p._addedIngredients.Count - 1; i != -1; i--)
            {
                if (p._addedIngredients[i] == ingredient)
                {
                    Ingredient location = p._addedIngredients[i];
                    _addedIngredients.Remove(location);
                    
                }
            }
            
        }
        /// <summary>
        /// Adds up the retail price of the ingredients in the pizza and add to overall price
        /// </summary>
        public void RefreshPurchasePrice()
        {
            _purchasePrice = 0;
            Ingredient ingredient;
            for (int i = 0; i < _addedIngredients.Count; i++)
            {
                ingredient = _addedIngredients[i];
                _purchasePrice += ingredient.PurchasePrice;
            }
            _purchasePrice = Decimal.Round(_purchasePrice, 2);
           
        }
        /// <summary>
        /// Adds up the retail price of the ingredients in pizza
        /// Loops through all ingredients on pizza and adds to _energy
        /// </summary>
        public void RefreshEnergyValue()
        {
            _energy = 0;
            Ingredient ingredient;
            for (int i = 0; i < _addedIngredients.Count; i++)
            {
                ingredient = _addedIngredients[i];
                _energy += ingredient.EnergyValue;
                
                
            }
            _energy = Math.Round(_energy, 2);
        }
        /// <summary>
        /// Calculates whether the overall make up of a pizza will be vegeterian or not.
        /// </summary>
        //
        public void CheckVego()
        {
            bool vegeterian = true;
            foreach (Ingredient i in _addedIngredients)
            {
                if (i.Vegeterian is false)
                {
                    vegeterian = false;
                }
            }
            if (vegeterian == true)
            {
                _vegeterian = true;
            }
            else
            {
                _vegeterian = false;
            }
        }




        //############################################
        // ### Properties ###
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
        public decimal PurchasePrice
        {
            get { return _purchasePrice; }
            set 
            { 
                if (_purchasePrice != value)
                {
                    _purchasePrice = value;
                    FirePropertyChanged("RetailPrice");
                }
                    
            }
        }
        public double Energy
        {
            get { return _energy; }
            set
            {
                if (_energy != value)
                {
                    _energy = value;
                    FirePropertyChanged("Energy");
                }
            }
        }
        public int IngredientsCount
        {
            get { return _addedIngredients.Count; }
            
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
        public decimal RetailPrice
        {
            get { return _retailPrice; }
            set
            {
                if (_retailPrice != value)
                {
                    _retailPrice = value;
                    FirePropertyChanged("RetailPrice");
                }
            }
        }
        // ###########################################
        // ### Event Handlers ###
        // The property changed event
        public event PropertyChangedEventHandler PropertyChanged;

        private void AddedIngredientsListChanged(object sender, ListChangedEventArgs e)
        {
            FirePropertyChanged("IngredientsCount");
        }
        /// <summary>
        /// method to send a property change event.
        /// </summary>
        /// <param name="prop">The name of the property that has changed.</param>
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
