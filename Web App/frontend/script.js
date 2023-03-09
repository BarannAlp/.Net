function test(){
    const xhttp = new XMLHttpRequest();
    var sayi1 = document.getElementById("sayi").value;
    console.log(sayi1);
    xhttp.open("GET", "http://localhost:5141/api/Deneme/SqrtResponseDto?sayi="+ sayi1, true);
    
    xhttp.onload = function() {
        if (xhttp.status==200) {
       let cikti = JSON.parse(this.response) 
       console.log(cikti)
       document.getElementById("goster").innerHTML=(cikti.result)
       document.getElementById("mesaj").innerHTML=(cikti.message)
        }
    };
   
    xhttp.send();
    
}

function factoriel(){
    const xhttp = new XMLHttpRequest();
    var sayi1 = document.getElementById("sayi").value;
    console.log(sayi1);
    xhttp.open("GET", "http://localhost:5141/api/Deneme/FctrResponseDto?sayi2="+ sayi1, true);
    
    xhttp.onload = function() {
        if (xhttp.status==200) {
       let cikti = JSON.parse(this.response) 
       console.log(cikti)
       document.getElementById("goster").innerHTML=(cikti.result)
       document.getElementById("mesaj").innerHTML=(cikti.message)
        }
    };
   
    xhttp.send();
    
}


function reset(){
    document.getElementById("goster").innerHTML="0";
    document.getElementById("mesaj").innerHTML="Temizlendi";
   let mv=1;
    console.log((1==mv?3==mv:1==mv));
    
}




