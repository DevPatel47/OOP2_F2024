using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ClassExercise02
{
    /// <summary>
    /// Class Containing Tshirt object
    /// </summary>
    internal class Tshirt
    {

        #region Class Scope Variable
        
        // for autonumbering tshirt ID
        private static int tshirtIdCounter = 1;
        // Defaults
        private const string DEFAULT_SIZE = "M";
        private Color DEFAULT_COLOR = Color.White;        
        private const string DEFAULT_MATERIAL = "Cotton";
        private const string DEFAULT_DESIGN = "Polo";
        private const double DEFAULT_PRICE = 0.00;
        private const bool DEFAULT_ISINSTOCK = false;
        private const string DEFAULT_DESCRIPTION = "";
        private const int DEFAULT_QUANTITY_IN_STOCK = 1;
        // Stores Tshirts
        public static List<Tshirt> tshirts = new List<Tshirt>();

        #endregion

        #region Properties

        /// <summary>
        /// Represents a property TshirtID including its getter and setter
        /// </summary>
        public int TshirtID{ get; set; }
        private string _size;
        /// <summary>
        /// Represents a property Size including its getter and setter
        /// </summary>
        public string Size 
        { 
            get 
            {
                return _size;
            }
            set 
            {
                if (value == "S" || value == "M" || value == "L" || value == "XL" || value == "XXL")
                { 
                    _size = value;
                }
            }         
        }
        /// <summary>
        /// Represents a property Color including its getter and setter
        /// </summary>
        public Color Color { get; set; }
        /// <summary>
        /// Represents a property Material including its getter and setter
        /// </summary>
        public string Material { get; set; }
        /// <summary>
        /// Represents a property Design including its getter and setter
        /// </summary>
        public string Design { get; set; }
        private double _price;
        /// <summary>
        /// Represents a property Price including its getter and setter
        /// </summary>
        public double Price 
        {
            get
            {
                return _price;
            }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
            }
        }
        /// <summary>
        /// Represents a property IsInStock including its getter and setter
        /// </summary>
        public bool IsInStock { get; set; }
        /// <summary>
        /// Represents a property Description including its getter and setter
        /// </summary>
        public string Description { get; set; }
        private int _quantityInStock;
        /// <summary>
        /// Represents a property QuantityInStock including its getter and setter
        /// </summary>
        public int QuantityInStock 
        {
            get
            {
                return _quantityInStock;
            }
            set
            {
                if (value >= 0)
                {
                    _quantityInStock = value;
                    IsInStock = true;
                    if (value == 0) IsInStock = false;
                }
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default Tshirt Constructor
        /// </summary>
        public Tshirt() 
        {
            TshirtID = tshirtIdCounter++;
            SetDefault();
        }
        /// <summary>
        /// Parameterized Tshirt Constructor
        /// </summary>
        /// <param name="size"></param>
        /// <param name="color"></param>
        /// <param name="material"></param>
        /// <param name="design"></param>
        /// <param name="price"></param>
        /// <param name="isInStock"></param>
        /// <param name="description"></param>
        /// <param name="quantityInStock"></param>
        public Tshirt(string size, Color color, string material, string design, double price, bool isInStock, string description, int quantityInStock) 
        {
            TshirtID = tshirtIdCounter++;
            Size = size;
            Color = color;
            Material = material;
            Design = design;
            Price = price;
            IsInStock = isInStock;
            Description = description;
            QuantityInStock = quantityInStock;
        }

        #endregion

        #region Non-static methods
        
        /// <summary>
        /// Non-static method to update Tshirt design
        /// </summary>
        /// <param name="size"></param>
        /// <param name="color"></param>
        /// <param name="material"></param>
        /// <param name="design"></param>
        /// <param name="description"></param>
        public void UpdateTshirtDesign(string size, Color color, string material, string design, string description) 
        {
            Size = size;
            Color = color;
            Material = material;
            Design = design;
            Description = description;
        }
        /// <summary>
        /// Non-static method to update stock
        /// </summary>
        /// <param name="newQuantity"></param>
        public void UpdateStock(int newQuantity)
        {
            if (newQuantity > 0) QuantityInStock = newQuantity;                              
            else if (newQuantity == 0)
            {
                QuantityInStock = newQuantity;
                IsInStock = false;
            }
        }

        #endregion

        #region Non-static method to set the default values using constants

        /// <summary>
        /// Non-Static Method to Set default values
        /// </summary>
        public void SetDefault()
        {
            Size = DEFAULT_SIZE;
            Color = DEFAULT_COLOR;
            Material = DEFAULT_MATERIAL;
            Design = DEFAULT_DESIGN;
            Price = DEFAULT_PRICE;
            IsInStock = DEFAULT_ISINSTOCK;
            Description = DEFAULT_DESCRIPTION;
            QuantityInStock = DEFAULT_QUANTITY_IN_STOCK;
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Static method to find Tshirt from Tshirts list using its ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Tshirt FindTshirtById(int id)
        {
            foreach (Tshirt tshirt in tshirts)
            {
                if (tshirt.TshirtID == id) return tshirt;                
            }
            return null;
        }
        /// <summary>
        /// Static method to calculate total stock value
        /// </summary>
        /// <returns></returns>
        public static double GetTotalStockValue()
        {
            double totalValue = 0;
            foreach (Tshirt tshirt in tshirts)
            {
                totalValue += tshirt.Price * tshirt.QuantityInStock;
            }
            return totalValue;
        }

        #endregion
    }
}
