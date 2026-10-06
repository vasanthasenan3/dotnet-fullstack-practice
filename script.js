let display = document.getElementById("display");

let firstnumber = "";
let secondnumber = "";
let operator = "";

 function addValue(value) 
 {
   if(value == "+" || value == "-" || value == "*" || value == "/")
   {
    firstnumber = display.value;
    operator = value;
    display.value = "";
   }
   else
   {
    display.value = display.value + value;
   }
 }   
function calculate()
{
    secondnumber = display.value;
    let num1 = Number(firstnumber);
    let num2 = Number(secondnumber);
    let result;
    if(operator == "+")
    {
        result = num1+num2;
    }
    else if(operator == "-")
    {
        result = num1-num2;
    }
    else if(operator == "*")
    {
        result = num1*num2;
    }
    else if(operator == "/")
    {
        result = num1/num2;
    }
    display.value = result;
}
function clearDisplay() 
{

    display.value = "";

    firstNumber = "";
    operator = "";
    secondNumber = "";

}