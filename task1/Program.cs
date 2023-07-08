Console.WriteLine("Entrer is numbers: ");
int n = Convert.ToInt32(Console.ReadLine());

void NumbersToN (int n){
    if (n>1) NumbersToN (n-1);
    Console.Write (n + " ");

}
NumbersToN(n);