using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PizzaDeliveryService
{
    public partial class PizzaDesigner : Form
    {
        //#####################################################333
        // ### Instance Variables ###
        /// The list of every ingredient. Is the data source of _ingredientGrid
        private BindingList<Ingredient> _ingredient;
        /// <summary>
        /// The list of every pizza. Is the data source of _pizzaGrid
        /// </summary>
        private BindingList<Pizza> _pizza;

        //########################################################
        //### Constructor ###
        public PizzaDesigner()
        {
            InitializeComponent();
            // Create pizza list and adds some pizzas
            _pizza = new BindingList<Pizza>();
            _pizza.Add(new Pizza("Hawaiian", (decimal)2.0, 0, false, (decimal)8.0));
            _pizza.Add(new Pizza("Beef and Onion", (decimal)2.0, 0, false, (decimal)10.0));
            _pizza.Add(new Pizza("Anchovie", (decimal)2.0, 0, false, (decimal)9.0));
            // Make _pizza the data source of _pizzaGrid
            _pizzaGrid.DataSource = _pizza;


            //Creates ingredient list
            _ingredient = new BindingList<Ingredient>();
            // Read ingredients from file and add to ingredient list
            StreamReader inputFile;
            inputFile = File.OpenText("ingredients.csv");
            inputFile.ReadLine();
            // While file isn't at the end
            while (!inputFile.EndOfStream)
            {
                //Read line to string
                string line = inputFile.ReadLine();
                // Split line at "," into array
                char[] delim = { ',' };
                string[] tokens = line.Split(delim);
                // Add ingredients from array to ingredient list
                _ingredient.Add(new Ingredient(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2]), decimal.Parse(tokens[3]), bool.Parse(tokens[4])));
                // Makes list
                _ingredientsGrid.DataSource = _ingredient;
            }
            // Close file
            inputFile.Close();

            // Add ingredients to Hawaiian pizza
            Pizza Hawaiian = _pizza[0];
            //Add thin base
            Ingredient ingredient = _ingredient[17];
            Hawaiian.AddIngredient(ingredient);
            // Add tomato sauce
            ingredient = _ingredient[18];
            Hawaiian.AddIngredient(ingredient);
            // Add Pineapple
            ingredient = _ingredient[12];
            Hawaiian.AddIngredient(ingredient);
            // Add Ham
            ingredient = _ingredient[7];
            Hawaiian.AddIngredient(ingredient);
            // Add Mozzarella
            ingredient = _ingredient[8];
            Hawaiian.AddIngredient(ingredient);


            // Add ingredients to Beef and Onion pizza
            Pizza mushroomAndOnion = _pizza[1];
            //Add thick base
            ingredient = _ingredient[16];
            mushroomAndOnion.AddIngredient(ingredient);
            // Add onion
            ingredient = _ingredient[11];
            mushroomAndOnion.AddIngredient(ingredient);
            // Add Mushroom
            ingredient = _ingredient[9];
            mushroomAndOnion.AddIngredient(ingredient);


            // Add ingredients to Anchovies pizza
            Pizza Anchovie = _pizza[2];
            //Add thick base
            ingredient = _ingredient[16];
            Anchovie.AddIngredient(ingredient);
            // Add anchovies
            ingredient = _ingredient[0];
            Anchovie.AddIngredient(ingredient);
            // Add feta cheese
            ingredient = _ingredient[6];
            Anchovie.AddIngredient(ingredient);
            // Add Spinach
            ingredient = _ingredient[15];
            Anchovie.AddIngredient(ingredient);

            //Updates vegeterian, energy, and price of all pizzas
            foreach (Pizza p in _pizza)
            {
                p.RefreshEnergyValue();
                p.RefreshPurchasePrice();
                p.CheckVego();
            }

        }
        //#######################################
        // ### Private Methods ###
        /// <summary>
        /// Get index of currently selected pizza
        /// </summary>
        /// <returns></returns>
        private Pizza GetSelectedPizza()
        {
            Pizza pizza = null;
            foreach (DataGridViewCell cell in _pizzaGrid.SelectedCells)
            {
                if (cell.Value == null)
                {
                    MessageBox.Show("Please select a pizza.");
                }
                else
                {
                    DataGridViewCell pizzaCell = _pizzaGrid.CurrentCell;
                    int pizzaIndex = pizzaCell.RowIndex;
                    pizza = _pizza[pizzaIndex];
                }
            }
            return pizza;
        }
        public void RefreshPizza()
        {

        }
        /// <summary>
        /// This allows you to get the object of the ingredient that you have currently selected.
        /// </summary>
        /// <returns></returns>
        private Ingredient GetSelectedIngredient()
        {
            // Object set to null so if there is an error it will pass back null for easy differentiation between error and non error
            Ingredient ingredient = null;
            // Loops through cells selected. If the sell is empty, then will show error and return null
            // If not then will get the current cells row index and give that index to the list in which it will
            // give the object of the same index to the object variable we have created and return it.
            foreach (DataGridViewCell cell in _ingredientsGrid.SelectedCells)
            {
                if (cell.Value != null)
                {
                    DataGridViewCell ingredientCell = _ingredientsGrid.CurrentCell;
                    int ingredientIndex = ingredientCell.RowIndex;
                    ingredient = _ingredient[ingredientIndex];
                }
            }
            return ingredient;
        }

        //######################################
        // ### Event Handler ###
        /// <summary>
        /// Adds ingredient if pizza and ingredient are selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            //Get selected pizza
            Pizza pizza = GetSelectedPizza();
            //Get selected ingredient
            Ingredient ingredient = GetSelectedIngredient();
            // Add ingredient to pizza
            if (ingredient != null && pizza != null)
            {
                pizza.AddIngredient(ingredient);
                pizza.CheckVego();
                pizza.RefreshPurchasePrice();
                pizza.RefreshEnergyValue();
            }
            RefreshGrids();


        }
        /// <summary>
        /// Removes pizza if pizza is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removePizzaButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in _pizzaGrid.SelectedCells)
            {
                if (cell.Value == null)
                {
                    MessageBox.Show("Please Select a pizza.");
                    return;
                }
                _pizzaGrid.Rows.RemoveAt(cell.RowIndex);
            }
            RefreshGrids();

        }
        /// <summary>
        /// remove ingredient Event-Handler
        /// Gets selected ingredient and removes at row index if no errors are found.
        /// Then loops through all pizzas in pizza list and sends arguments ingredient and p to be compared againist _addedIngredients list.
        /// So that it will then remove that same ingredient form pizza topping.
        /// Then updates to reflect vegeterian, price, and energy change of pizza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeIngredientButton_Click(object sender, EventArgs e)
        {
            //store selected ingredient
            Ingredient ingredient = GetSelectedIngredient();
            //loop through selected cells
            foreach (DataGridViewCell cell in _ingredientsGrid.SelectedCells)
            {
                //if cell is empty, throw error and return
                if (cell.Value == null)
                {
                    MessageBox.Show("Please select an ingredient.");
                    return;
                }
                // else removes ingredient
                _ingredientsGrid.Rows.RemoveAt(cell.RowIndex);
            }
            // loop through pizzas in _pizza list
            foreach (Pizza p in _pizza)
            {
                p.CompareIngredients(ingredient, p);
                p.CheckVego();
                p.RefreshEnergyValue();
                p.RefreshPurchasePrice();
            }
            RefreshGrids();


        }
        /// <summary>
        /// Removes Ingredient of pizza when clicked.
        /// Makes sure pizza is selected firstly.
        /// Then once delete updates vegeterian, price, and energy of pizza to reflect change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _removePizzaIngredientbutton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in _addedIngredientsGrid.SelectedCells)
            {
                if (cell.Value == null)
                {
                    MessageBox.Show("Please select a pizza ingredient.");
                    return;

                }
                _addedIngredientsGrid.Rows.RemoveAt(cell.RowIndex);

                //Get currently selected pizza
                Pizza pizza = GetSelectedPizza();
                //Reflect changed retail pricing
                pizza.RefreshPurchasePrice();
                pizza.RefreshEnergyValue();
                pizza.CheckVego();


            }
            RefreshGrids();
        }
        /// <summary>
        /// Refresh all grids
        /// </summary>
        private void RefreshGrids()
        {
            _pizzaGrid.Refresh();
            _ingredientsGrid.Refresh();
            _addedIngredientsGrid.Refresh();

        }
        /// <summary>
        /// Selection change handler of _pizzaGrid
        /// Displays current ingredients of selected pizza in the Current Ingredients Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _pizzaGrid_SelectionChanged_1(object sender, EventArgs e)
        {

            // Find the selected paper
            DataGridViewCell cell = _pizzaGrid.CurrentCell;
            if (cell != null)
            {
                int pizzaIndex = cell.RowIndex;
                Pizza pizza = _pizza[pizzaIndex];
                // Call the Bind() method, to change the data source of the enrolments
                // data grid view (the argument) to the paper's list of enrolled students
                pizza.Bind(_addedIngredientsGrid);

            }
        }
        /// <summary>
        /// If any ingredient attributes are updated. Then reflect calculation changes in other datagridviews
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ingredientsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            {
                //Stops crashing initially
                if (_pizza != null)
                {
                    foreach (Pizza p in _pizza)
                    {
                        p.RefreshPurchasePrice();
                        p.RefreshEnergyValue();
                        p.CheckVego();
                    }
                }

                RefreshGrids();
            }

        }
        /// <summary>
        /// Event handler for panel that holds all buttons (controls)
        /// When resized will move buttons in a uniform fashion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Resize(object sender, EventArgs e)
        {
            int yLocation;
            yLocation = panel1.Height / 100;

            _addIngredientButton.Location = new Point(_addIngredientButton.Location.X, yLocation);
            _removePizzaIngredientbutton.Location = new Point(_removePizzaIngredientbutton.Location.X, (yLocation * 33));
            _removeIngredientButton.Location = new Point(_removeIngredientButton.Location.X, (yLocation * 66));
            _removePizzaButton.Location = new Point(_removePizzaButton.Location.X, (yLocation * 99));

        }
        /// <summary>
        /// Format ingredients grid. Rest of formatting is within DataGrid settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ingredientsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _ingredientsGrid.Columns[2].DefaultCellStyle.Format = "##.## Kj";
            _ingredientsGrid.Columns[1].DefaultCellStyle.Format = "##.## g";
        }
        /// <summary>
        /// Format pizza grid. Rest of formatting is within DataGrid settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _pizzaGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _pizzaGrid.Columns[2].DefaultCellStyle.Format = "##.## Kj";
        }
        /// <summary>
        /// Format ingredientsAdded (Toppings) Grid. Rest of formatting is within DataGrid settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _addedIngredientsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _addedIngredientsGrid.Columns[1].DefaultCellStyle.Format = "##.## g";
            _addedIngredientsGrid.Columns[2].DefaultCellStyle.Format = "##.## Kj";
        }
    }
}
