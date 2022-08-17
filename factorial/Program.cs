//factorial

//Multiplying a number repeatedly by reducing it by 1 is factorial.
//For example, 5 factorial is 5! Displayed as 5! It is calculated as = 5 * 4 * 3 * 2 * 1.

//ALGORITHM

//1.1 Start.
//1.2 A one-time positive integer is received from the user.
//1.3 The factorial of the number entered by the user is calculated and printed on the screen.


//faktoriyel 

//Bir sayının sürekli 1 azaltılarak arka arkaya yapılan çarpım faktoriyeldir.
//Örneğin 5 faktoriyel 5! şeklinde gösterilir ve 5! = 5 * 4 * 3 * 2 * 1 olarak hesaplanır.

//Algoritma

//1.1 Başla.
//1.2 Kullanıcıdan tek seferlik pozitif bir tam sayı alınır.
//1.3 Kullanıcının girdiği sayının faktoriyeli hesaplanarak ekrana yazdırılır.



using factorial;

Logo.WriteLogo();

Console.Write("Enter a number(Exit: 0): ");
int number = int.Parse(Console.ReadLine());

while (number != 0) //Another method(Diğer Yöntem) => if(number != "0")
{
    int result = 1;

    if (number > 0)
    {
        #region How to do it without using methods
        //for (int i = number; i > 1; i--)
        //{
        //    result = result * i;
        //}
        //Console.WriteLine("Sonuç: " + result);
        #endregion

        #region Made using the method
        result = CalculateFactorial(number);
        Console.WriteLine("Result: " + result);
        #endregion
    }
    else
    {
        Console.Write("The number you enter must be greater than 0!: ");
        number = int.Parse(Console.ReadLine());
    }

    Console.Write("Enter a number: ");
    number = int.Parse(Console.ReadLine());
}

static int CalculateFactorial(int number)
{
    int result = 1;
    for (int i = number; i > 1; i--)
    {
        result = result * i;
    }
    return result;
}