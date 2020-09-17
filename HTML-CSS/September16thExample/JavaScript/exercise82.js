function ValidateInput()
{
    var itemName = document.getElementById("foodName");
    var itemPrice = document.getElementById("price");
    var validName = ValidateFoodName(itemName);
    var validPrice = ValidatePrice(itemPrice);
    if (validName === false || validPrice === false)
    {
        alert("Either food name or price is invalid");
    }
    else
    {
        alert("You've entered valid info");
    }    
}


function ValidateFoodName(itemName)
{
    if(itemName.length < 2)
    {
        return false;
    }
    else
    {
        return true;
    }
}

function ValidatePrice(foodPrice)
{
    var regex = /^[1-9]\d*(?:\.\d{0,2})?$/;
    return regex.test(foodPrice);
}