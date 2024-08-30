Console.WriteLine("Digite seu nome");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua altura");
double altura = Double.Parse(Console.ReadLine());

Console.WriteLine("Digite seu peso");
double peso = Double.Parse(Console.ReadLine());

double imc = peso / (altura * altura);

Console.WriteLine(nome + "você pesa " + peso + " Quilos e tem " + altura + " de altura. Seu IMC é:" + imc);

if(imc < 18)
{
    Console.WriteLine("Você está magro");
}else if(imc > 18 && imc < 25)
{
    Console.WriteLine("Você está co o peso IDEAL!!");
}else if (imc >= 25 && imc < 30)
{
    Console.WriteLine("Você está com sobrepeso, tome cuidado");
}else if(imc >= 30 && imc < 40)
{
    Console.WriteLine("Você está com obesidade");
}else
{
    Console.WriteLine("Você está com OBESIDADE GRAVE");
}
