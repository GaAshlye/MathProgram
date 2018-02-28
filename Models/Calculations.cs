using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MathCalculatorPost.Models;
namespace MathCalculatorPost.Models
{
    public class Calculations 
    {
        public double leftOperand {get; set;}
        public double rightOperand {get; set;}
        public double result{get; set;}
        public string Operator{get; set;}

        // public float Result
        // {
        //     get{
        //         if(Result > 10){
        //             return this.Result;

        //         }else{
        //             return 0; 
        //         }
        //     }
        //     set{
        //          this.Result = value;
        //         }
            
        // }
        
    }
}