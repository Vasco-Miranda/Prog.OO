string[] nomes = ["Pão", "Leite", "Sabotentes"];
decimal[] precos = [0.8m, 0.65m, 1.2m];

decimal total = 0.0m;

for(int i = 0;  i < nomes.Length; i++)
{
    Console.WriteLine($"{nomes[i],-10} {precos[i]}");
    total += precos[i];
}

Console.WriteLine($"Subtotal: {total:C2}");

const decimal Iva = 0.23m;
decimal comIva = total *  (Iva + 1);
decimal aPagar = comIva > 50m ? comIva * 0.95m : comIva;

Pagamento p = Pagamento.MBWay;
string msg = p switch                                // Decidir
{
    Pagamento.Dinheiro => "Troco em euros",
    Pagamento.MBWay => "Confirme no telemóvel",
    _ => "Insira o cartão"
};
Console.WriteLine($"Total: {aPagar:C2} — {msg}");

enum Pagamento
{
    Dinheiro,
    MBWay
}
