using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace PetProject
{//may stay serializable if it is required
    public class Line 
    {
        public string SaleNumber { get; set; }
        public string SaleDate { get; set; }
        public string SaleItemCode { get; set; }
        public string SaleQuantity { get; set; }
        public string SalePrice { get; set; }


        public Line()
        { 

        }

        public Line(string SaleNumber, string SaleDate, string SaleItemCode,
           string SaleQuantity, string SalePrice)
        {
            this.SaleNumber = SaleNumber;
            this.SaleDate = SaleDate;
            this.SaleItemCode = SaleItemCode;
            this.SaleQuantity = SaleQuantity;
            this.SalePrice = SalePrice; 
            
        }
    }





}
