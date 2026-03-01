//17. Contar cuántos números positivos ingresa el usuario.
int numero = 1;
int total = 0;

while (numero != 0)
{
    Console.WriteLine("Ingrese número positivos (presione 0 para salir)");
    numero = int.Parse(Console.ReadLine());

    if (numero > 0)
    {
        total++;
    }

}
Console.WriteLine("El total de números ingresados es en total: " + total);