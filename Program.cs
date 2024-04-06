double percentualDeBonus, percentualDeRetorno;
double pontosATransferir, PontosAReduzir, pontosAAcrescentar;
 
Console.Clear();
Console.WriteLine("--- Milhas Bumerangue ---\n");
 
Console.Write("Percentual de bônus.....: ");
percentualDeBonus = Convert.ToDouble(Console.ReadLine());
 
Console.Write("Percentual de retorno.....: ");
percentualDeRetorno = Convert.ToDouble(Console.ReadLine());
 
Console.Write("Percentual a transferir.....: ");
pontosATransferir = Convert.ToDouble(Console.ReadLine());
 
PontosAReduzir = pontosATransferir - (pontosATransferir * percentualDeRetorno) / 100;
pontosAAcrescentar = pontosATransferir + (pontosATransferir * percentualDeBonus) / 100;
 
Console.WriteLine();
Console.WriteLine($"Pontos a reduzir na origem........: {PontosAReduzir}");
Console.WriteLine($"Pontos a acrescentar no destino...: {pontosAAcrescentar}");
