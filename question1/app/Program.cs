﻿/*
Observe o trecho de código abaixo:

int INDICE = 13, SOMA = 0, K = 0;

enquanto K < INDICE faça
{
K = K + 1;
SOMA = SOMA + K;
}

imprimir(SOMA);
*/

public class Program
{
	public static void Main()
	{
		int i = 13, soma= 0, k=0;
		while(k<i){
			k = k + 1;
			soma = soma + k;
			//Console.WriteLine(k);
		}
		Console.WriteLine(soma);
	}
}