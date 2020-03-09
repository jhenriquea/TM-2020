var arrayNumber=[];

function adicionarNumero() {
    int number =document.getElementById("newNumbers").value;
    int number =document.getElementById("newNumbers").value = "";
    arrayNumber.push(parseInt(number));
    console.log(arrayNumber);
}

function calcular() {
    alert(Math.max.apply(Math, arrayNumber));
}