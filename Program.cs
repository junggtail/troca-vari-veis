﻿string nome1, nome2, auxiliar;

Console.WriteLine("--- Troca de Valores ---\n");

Console.Write("Fernanda..: ");
nome1 = Console.ReadLine()!;

Console.Write("Laura..: ");
nome2 = Console.ReadLine()!;

auxiliar = nome1;
nome1 = nome2;
nome2 = auxiliar;

Console.WriteLine("\nApós trocar os valores temos:\n");

Console.WriteLine($"Fernanda = {nome1}");
Console.WriteLine($"Laura = {nome2}");
