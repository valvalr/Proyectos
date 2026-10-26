string respuesta;
Console.WriteLine("Ingrese un número entero:");
int numero = Console.ReadLine();
do {

    if(numero == 0.0){
        Console.WriteLine("Error: Debe ingresar número entero");
    }

    if(numero <0){
        Console.WriteLine("Error:Debe ingresar un numero positivo");
    }

int factorial;
for(int factorial=0; factorial<=0; factorial++){
    Console.WriteLine("El factorial es: " + factorial);
}
do{
    Console.WriteLine("Desea calcular otro factorial (Si/No):");
    respuesta= Console.ReadLine().ToLower();

    if(respuesta!="Si" && respuesta!="No"){
        Console.WriteLine("Respuesta inválida");

    }
}while(respuesta !="Si" && respuesta!="No");
}while (respuesta =="Si");



