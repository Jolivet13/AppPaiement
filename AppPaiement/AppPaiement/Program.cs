namespace AppPaiement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var achat_jolivet = new CarteCredit(150.00m , " Achat de vêtements ",123456789);
            var achat_steve = new CarteCredit(250.00m, " Achat de livres ", 234567890);
            var achat_fon = new CarteCredit(300.00m, " Achat de nourritures ", 345678901);
            List<CarteCredit> achats = new List<CarteCredit> { achat_jolivet, achat_steve, achat_fon };

            foreach (var achat in achats)
            {
                achat.AfficherDetails();
                Console.WriteLine();


            }
        }
    }
}
