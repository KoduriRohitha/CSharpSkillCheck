using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public class GourmetOrganicShop : GourmetShop,ITaxCompute
    {
        public double TotalBillValue{get;set;}
        
        public double PayPerPiece(int quantity){
        
        }
        public double PayPerWeight(int weight){
        
        }
        public double TaxOnTotal(){
        }
    }
}
