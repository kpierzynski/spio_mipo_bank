// See https://aka.ms/new-console-template for more information
using mediator;
using state;

Console.WriteLine("Hello, World!");

KrajowaIzbaRozliczeniowa kir = new KrajowaIzbaRozliczeniowa();

Bank a = new Bank("BankA", kir);
Bank b = new Bank("BankB", kir);

a.dodajRachunek(new Rachunek("Agnieszka", 100.0f));
b.dodajRachunek(new Rachunek("Anna", 2000.0f));

kir.zarejestrujBank(a);
kir.zarejestrujBank(b);

a.pokazOdsetkiRachunkow();
b.pokazOdsetkiRachunkow();

a.stworzTransakcje(new Transakcja
{
    RachunekNadawczy = "Agnieszka",

    BankOdbiorczy = "BankB",
    RachunekOdbiorczy = "Anna",

    Kwota = 50.0f
});

a.pokazOdsetkiRachunkow();
b.pokazOdsetkiRachunkow();

a.stworzTransakcje(new Transakcja
{
    RachunekNadawczy = "Agnieszka",

    BankOdbiorczy = "BankB",
    RachunekOdbiorczy = "NOTEXIST",

    Kwota = 50.0f
});

a.pokazOdsetkiRachunkow();
b.pokazOdsetkiRachunkow();

a.stworzTransakcje(new Transakcja
{
    RachunekNadawczy = "Agnieszka",

    BankOdbiorczy = "NOTEXIST",
    RachunekOdbiorczy = "NOTEXIST",

    Kwota = 50.0f
});

a.pokazOdsetkiRachunkow();
b.pokazOdsetkiRachunkow();

a.stworzTransakcje(new Transakcja
{
    RachunekNadawczy = "NOTEXIST",

    BankOdbiorczy = "NOTEXIST",
    RachunekOdbiorczy = "NOTEXIST",

    Kwota = 50.0f
});

a.pokazOdsetkiRachunkow();
b.pokazOdsetkiRachunkow();