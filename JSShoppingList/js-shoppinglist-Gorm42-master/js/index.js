//Write your Javascript code here
//19.03.25 Exercise shopping list DOM and JS
//19.03.25 Exercise shoppingList Extended
//https://www.w3schools.com/jsref/dom_obj_all.asp
//https://developer.mozilla.org/en-US/docs/Learn_web_development/Core/Scripting/Functions
//https://developer.mozilla.org/en-US/docs/Learn_web_development/Core/Scripting/Conditionals
//https://www.w3schools.com/js/js_loop_forin.asp
// https://zealanddk-my.sharepoint.com/:p:/g/personal/mark_zealand_dk/EexTfHedYDNBodmRUrEzcLQBCKIfMcqsEi-xCIPJdbrRgw?e=1GZiK3

console.log("Shoppinglist")

//Task 1 Method to create a new list element, with three parameters.
function createNewLiElement(id, attribute, text)
{
    let li = document.createElement("li");
    li.setAttribute(id);
    li.setAttribute(attribute);
    li.createTExtNode(text);
    return li;
}

//FFS. Append - why don't they just call it add. 
//Task 2 - create a new function 
function addListItem(oldId, newId) {
    let list = document.getElementById(oldId);
    //We will check 
    if (!list) {
        console.error("List not found!");
        return;
    }

    //We create a new <li> element - but why?
    let newListItem =  document.createElement("li");
    newListItem.textContent = listItemText;

    //Append the <li> to the list
    list.appendChild(newListItem);

}




let shoppingList = [
    {name: "Milk", quantity: 1},
    {name: "Bread", quantity: 2},  
];