Console.WriteLine(" pida números al usuario hasta ingresar 0 y al final muestre suma, cantidad y promedio ");
int suma = 0;
int numero;
int contador = 0;

do
{
    Console.WriteLine("Ingrese número");
    numero = int.Parse(Console.ReadLine());

    if (numero != 0)
    {
        suma += numero;
        contador++;
    }

}
while (numero != 0);
double promedio = contador < 0 ? (double)suma / contador : 0;
Console.WriteLine("suma" + suma);
Console.WriteLine("Cantidad: "+contador);
Console.WriteLine("Promedio: "+promedio);