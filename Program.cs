int idade = 18;
double valorIngresso = 30.00;

bool clienteVIP = true;
bool ehEstudante = true;


if (clienteVIP)
{
    valorIngresso *= 0.4;
}

else if (idade <= 7 || idade >= 60 || ehEstudante)
{
    valorIngresso = valorIngresso * 0.5;
} 
Console.WriteLine($"o valor a pagar é: {valorIngresso}"); 