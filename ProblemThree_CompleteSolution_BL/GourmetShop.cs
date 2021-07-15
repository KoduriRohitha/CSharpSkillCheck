using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {          
        public int itemCode{get; set;}
        public string itemName{get; set}
        private Dictionary<int,double> itemPrice{get; set;}
       
        public abstract double PayPerPiece(int quantity);
        public abstract double PayPerWeight(int weight);

    }
}
