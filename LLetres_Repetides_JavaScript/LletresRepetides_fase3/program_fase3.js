var llistalletres = "MARC LLADO MALDONADO";
var diccionari = new Map();

for (var i=0; i < llistalletres.length; i++){

    if(!diccionari.has(llistalletres[i])){

        diccionari.set(llistalletres[i],1);
    }

    else {

        diccionari.set(llistalletres[i], diccionari.get(llistalletres[i]) + 1);
        
    }

}

console.log(diccionari);




