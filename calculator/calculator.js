var ingredients = []

function AddIngredient() {
    
    if (ingredients.length > 10) {
        return;
    } 

    var ingredient_name = document.querySelector("#ingredient-name").value
    var amount = document.querySelector("#amount").value
    var cals = document.querySelector("#calories").value

    var ingr_list = document.querySelector("#ingredients-list")

    if (!(ingredient_name && amount && cals)) {
        return;
    }

    var calculation = Calculate(amount, cals)
    ingredients.push(calculation)

    const node = document.createElement('li')
    const textNode = document.createTextNode(ingredient_name + ", " + amount + " g's or ml's, " + cals + " calories per 100 g or ml") 
    node.appendChild(textNode)
    ingr_list.appendChild(node)
}

function CalculateCalories() {
    var totalCals = 0
    
    for (const i of ingredients) {
        totalCals += i;
    }

    var commend;

    if (totalCals <= 100) {
        commend = 'Very healthy!';
      } else if (totalCals <= 200) {
        commend = 'Healthy!';
      } else if (totalCals <= 300) {
        commend = 'It is good to stay away!';
      } else {
        commend = 'Stay away!';
      }

    const total = document.createElement('h2')
    const textTotal = document.createTextNode("Cals: " + totalCals.toFixed(2))
    total.appendChild(textTotal)


    const commendMessage = document.createElement('p')
    const messageText = document.createTextNode(commend)
    commendMessage.appendChild(messageText)

    var result = document.querySelector("#results")
    result.appendChild(total)
    result.appendChild(commendMessage)
}

function Calculate(amount, kcal) {
    return (kcal / 100 * amount)
}