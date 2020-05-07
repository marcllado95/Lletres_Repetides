var llista = ['A','P','O','L','O',13];

for (var i=0; i < llista.length; i++){

    if(typeof llista[i] === "number"){
        console.log(llista[i] + " Els noms de persones no contenen numeros!");
    }
    else {
        if(llista[i] == 'A' || llista[i] == 'E' || llista[i] == 'I' || llista[i] == 'O' || llista[i] == 'U'){
            console.log(llista[i] + "  vocal");
        }
        else{
            console.log(llista[i] + "  consonant")
        }
    }

}

