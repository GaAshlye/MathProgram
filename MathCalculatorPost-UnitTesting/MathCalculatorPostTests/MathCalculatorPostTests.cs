using System;
using Xunit;
using MathCalculatorPost.Controllers; 
using MathCalculatorPost.Models;
using Microsoft.AspNetCore.Mvc; 

namespace MathCalculatorPostTests
{
    public class MathCalculatorPostTests
    {
        private MathController controller = new MathController();
        //private MathController controller = new MathController();
        [Fact]
        public void TestAddition()
        {
            //Arrange
            Calculations op = new Calculations();
            op.leftOperand = 30;
            op.rightOperand = 30;
            op.Operator = "+";
            op.result = 0;
           
            //Act       
            ViewResult vr = (ViewResult)controller.DoCalculation(op);
            Calculations model = (Calculations)vr.Model;

            //Assert            
           Assert.Equal(60, model.result);
           

        }
         [Fact]
        public void TestSubtraction()
        {
            //Arrange
            Calculations op = new Calculations();
            op.leftOperand = 35;
            op.rightOperand = 30;
            op.Operator = "-" ;
            op.result = 0;

            //Act
            ViewResult vr = (ViewResult)controller.DoCalculation(op);
            Calculations model = (Calculations)vr.Model;

            //Assert
            Assert.Equal(5, model.result);

        }
         [Fact]
        public void TestMultiplication()
        {
            //Arrange
            Calculations op = new Calculations();
            op.leftOperand = 5;
            op.rightOperand = 6;
            op.Operator = "*" ;
            op.result = 0;

            //Act
            ViewResult vr = (ViewResult)controller.DoCalculation(op);
            Calculations model = (Calculations)vr.Model;

            //Assert
            Assert.Equal(30, model.result);

        }
                [Fact]
        public void TestDivision()
        {
            //Arrange
            Calculations op = new Calculations();
            op.leftOperand = 60;
            op.rightOperand = 25;
            op.Operator = "/" ;
            op.result = 0;

            //Act
            ViewResult vr = (ViewResult)controller.DoCalculation(op);
            Calculations model = (Calculations)vr.Model;

            //Assert
            Assert.Equal(2.4, Math.Round(model.result, 1)); //60/25 equals 2.4

        }
           [Fact]
        public void TestModulus()
        {
            //Arrange
            Calculations op = new Calculations();
            op.leftOperand = 9;
            op.rightOperand = 6;
            op.Operator = "%" ;
            op.result = 0;

            //Act
            ViewResult vr = (ViewResult)controller.DoCalculation(op);
            Calculations model = (Calculations)vr.Model;

            //Assert
            Assert.Equal(3, model.result); //60/25 equals 2.4

        }
        [Fact]
        public void TestRound()
        {
            //Arrange
            Calculations op = new Calculations();
            op.leftOperand = 5.76;
            //op.rightOperand = 6;
            op.Operator = "round" ;
            op.result = 0;

            //Act
            ViewResult vr = (ViewResult)controller.DoCalculation(op);
            Calculations model = (Calculations)vr.Model;

            //Assert
           // Assert.Equal(model.result, 1);
            Assert.Equal(5.8, Math.Round(model.result, 1)); 
        }
         [Fact]
        public void TestCeiling()
        {
            //Arrange
            Calculations op = new Calculations();
            op.leftOperand = 5.76;
            //op.rightOperand = 6;
            op.Operator = "ceiling" ;
            op.result = 0;

            //Act
            ViewResult vr = (ViewResult)controller.DoCalculation(op);
            Calculations model = (Calculations)vr.Model;

            //Assert
            Assert.Equal(6, model.result);

        }
         [Fact]
        public void TestFloor()
        {
            //Arrange
            Calculations op = new Calculations();
            op.leftOperand = 5.76;
            //op.rightOperand = 6;
            op.Operator = "floor" ;
            op.result = 0;

            //Act
            ViewResult vr = (ViewResult)controller.DoCalculation(op);
            Calculations model = (Calculations)vr.Model;

            //Assert
            Assert.Equal(5, model.result);

        }

    }
}
