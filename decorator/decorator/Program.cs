// See https://aka.ms/new-console-template for more information
using decorator;
using mediator;
using state;

KrajowaIzbaRozliczeniowa kir = new KrajowaIzbaRozliczeniowa();

Bank a = new Bank("BankA", kir);
Bank b = new Bank("BankB", kir);

a.dodajRachunek(new RachunekDebetowy("Agnieszka", 100.0f));
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

    Kwota = 150.0f
});

a.pokazOdsetkiRachunkow();
b.pokazOdsetkiRachunkow();

a.stworzTransakcje(new Transakcja
{
    RachunekNadawczy = "Agnieszka",

    BankOdbiorczy = "BankB",
    RachunekOdbiorczy = "Anna",

    Kwota = 350.0f
});

a.pokazOdsetkiRachunkow();
b.pokazOdsetkiRachunkow();

b.stworzTransakcje(new Transakcja
{
    RachunekNadawczy = "Anna",

    BankOdbiorczy = "BankA",
    RachunekOdbiorczy = "Agnieszka",

    Kwota = 1000.0f
}) ;

a.pokazOdsetkiRachunkow();
b.pokazOdsetkiRachunkow();

a.stworzTransakcje(new Transakcja
{
    RachunekNadawczy = "Agnieszka",

    BankOdbiorczy = "BankB",
    RachunekOdbiorczy = "Anna",

    Kwota = 150.0f
});

a.pokazOdsetkiRachunkow();
b.pokazOdsetkiRachunkow();