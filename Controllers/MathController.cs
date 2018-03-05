using Microsoft.AspNetCore.Mvc; 
//using Microsoft.AspNetCore.Builder; 
using MathCalculatorPost.Models; 
using System; 

namespace MathCalculatorPost.Controllers
{
     public class MathController : Controller
    {
        [HttpGet]//assumed to be get unless otherwise specified 
        public IActionResult Calculator()  //going to be the same as input 
        {
           // Calculations operation = new Calculations();
           // return View(operation); 
           return View(); 
        }
        [HttpPost]
        public IActionResult DoCalculation(Calculations operation)
        {
            if(operation == null)
            {
                return View("Error");
            }
            switch(operation.Operator)
            {
                case "+":
                        operation.result = operation.leftOperand + operation.rightOperand;
                        break;
                case "-":
                        operation.result = operation.leftOperand - operation.rightOperand; 
                        break;
                case "*":
                        operation.result = operation.leftOperand * operation.rightOperand; 
                        break;
                case "/":
                        if (operation.rightOperand == 0)
                        {
                            ViewData["Message"] = @"You can't divide by zero";
                        }
                        else
                        {
                            operation.result = operation.leftOperand / operation.rightOperand; 
                        }           
                        break;
                case "%":
                        operation.result = operation.leftOperand % operation.rightOperand; 
                        break;
                case "round":
                        operation.result = Math.Round(operation.leftOperand, 1);                        
                        //Math.Round(operation.rightOperand, 2);
                        break;
                case "ceiling":
                        operation.result = Math.Ceiling(operation.leftOperand);
                       // Math.Ceiling(operation.rightOperand);
                        break;
                case "floor":
                        operation.result = Math.Floor(operation.leftOperand);
                        //Math.Floor(operation.rightOperand);
                        break;
                case "default":
                        operation = new Calculations();
                        operation.leftOperand = 1000;
                        operation.rightOperand = 1000;
                        operation.Operator = "Add";
                        operation.result = 0;                       
                         break; 

            }
            return View(operation);
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(); 
        }    
        public IActionResult Error()
        {
            return View(); 
        }
        
      
    }
}