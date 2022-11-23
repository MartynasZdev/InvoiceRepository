using InvoiceingSystem.Entities;
using InvoiceingSystem.Repositories;

InvoiceRepository InvoiceRepo = new InvoiceRepository();
MealRepository MealRepo = new MealRepository();

while (true)
{
    Console.WriteLine("\n///////////////////////////////////////////\n");
    Console.WriteLine("Sveiki atvykę į sąskaitų generavimo sistemą\n");
    Console.WriteLine("Pasirinkite jums tinkantį punktą iš meniu.\n\nĮrašykite: \n");
    Console.WriteLine("1 - rodyti visas sąskaitas");
    Console.WriteLine("2 - rodyti pasirinktą sąskaitą");
    //Console.WriteLine("3, kad išsaugoti visų sąskaitų ataskaitą");
    //Console.WriteLine("4, kad išsaugoti pasirinktą skaitą");
    Console.WriteLine("0 - uždaryti programą\n");
    Console.WriteLine("Spauskite ENTER - išvalyti duomenis\n");
    Console.WriteLine("///////////////////////////////////////////\n");


    string command = Console.ReadLine();

    switch (command)
    {
        case "1":
            GetAllInvoice(InvoiceRepo, MealRepo);
            break;
        case "2":
            GetOneInvoice(InvoiceRepo, MealRepo);
            break;
        case "x":
            return;
        default:
            Console.Clear();
            break;
    }
}

static void GetAllInvoice(InvoiceRepository InvoiceRepo, MealRepository MealRepo)
{
    decimal allInvoicesTotalPrice = 0;

    foreach (Invoice Invoice in InvoiceRepo.Invoices)
    {
        Console.WriteLine("\n\nSąskaitos ID - " + Invoice.Id);
        Invoice.TotalPrice = 0;
        for (int i = 0; i < Invoice.Meal.Count; i++)
        {
            Console.WriteLine(MealRepo.Meals[Invoice.Meal[i]].Name + " " + MealRepo.Meals[Invoice.Meal[i]].Price + " " + MealRepo.Meals[Invoice.Meal[i]].Currency);
            Invoice.TotalPrice += MealRepo.Meals[Invoice.Meal[i]].Price;
        }

        Console.WriteLine("Iš viso: " + Invoice.TotalPrice + " Eur");
        allInvoicesTotalPrice += Invoice.TotalPrice;
    }
    Console.WriteLine("\nIŠ VISO SĄSKAITŲ SUMA: " + allInvoicesTotalPrice + " Eur");


}

static void GetOneInvoice(InvoiceRepository InvoiceRepo, MealRepository MealRepo)
{
    Console.WriteLine("\nĮrašykite sąskaitos ID\n");

    if (int.TryParse(Console.ReadLine(), out int InvoiceId))
    {
        if (InvoiceId <= InvoiceRepo.Invoices.Count)
        {
            var Invoice = InvoiceRepo.Invoices[InvoiceId - 1];

            Console.WriteLine("\nSąskaitos ID:" + Invoice.Id);

            Invoice.TotalPrice = 0;
            for (int i = 0; i < Invoice.Meal.Count; i++)
            {
                Console.WriteLine(MealRepo.Meals[Invoice.Meal[i]].Name + " " + MealRepo.Meals[Invoice.Meal[i]].Price + " " + MealRepo.Meals[Invoice.Meal[i]].Currency);
                Invoice.TotalPrice += MealRepo.Meals[Invoice.Meal[i]].Price;
            }

            Console.WriteLine("\nIš viso suma " + Invoice.TotalPrice + " Eur" + "\n");


        }
        else
        {
            Console.Clear();
            Console.WriteLine("\n!!!!! Sąskaita nerasta, bandykite dar kartą !!!!!\n");
        }
    }
}