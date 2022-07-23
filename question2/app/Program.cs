/*
2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores
(exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE:
Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
*/


static bool isFibo(int n)
{
    int a=0, b=1;
    if(a==n || b==n) return true;
    int c = a + b;
    while(a<n)
    {
        if(c==n) return true;
        a = b;
        b = c;
        c = a + b;
    }
    return false;
}

int input = 22;
Console.WriteLine(isFibo(input) ? "Faz parte da sequencia" : "Nao faz Parte");
