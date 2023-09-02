// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tipo de fruta a transportar" +
    "\n 1: Naranja" +
    "\n 2: Fresa" +
    "\n 3: Mango");

int fruta =int.Parse(Console.ReadLine());
Console.WriteLine("Cual fue la distancia que recorrio en km: ");
float km=float.Parse(Console.ReadLine());

switch (fruta)
{
    case 1:
        if (km < 30)
        {
            fruta = 2;

        }
        else {
            fruta = 4; 
        }
        break;

    case 2:
        if (km < 30)
        {
            fruta = 6;

        }
        else
        {
            fruta = 9;
        }
        break;

    case 3:
        if (km < 30)
        {
            fruta = 3;

        }
        else
        {
            fruta = 5;
        }
        break;


    default:
        Console.WriteLine("Escoge una de las opciones de las frutas.");
        break;
}
Console.WriteLine("El total a pagar es "+fruta);

