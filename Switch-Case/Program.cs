int month = DateTime.Now.Month;

// Expression
switch (month)
{
    case 1:
        Console.WriteLine("ocak ayındasınız!");
        break;
    case 2:
        Console.WriteLine("şubat ayındasınız!");
        break; 
    case 3:
        Console.WriteLine("mart ayındasınız!");
        break;
    case 4:
        Console.WriteLine("nisan ayındasınız!");
        break;


    default:
        Console.WriteLine("Yanlış veri girilidi!");
    break;
}

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış Ayındasınız!");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlk bahardasınız");
        break;
    case 9:
        case 10:
        case 11:
        Console.WriteLine("Yaz ayındasınız");
        break;
    default:
        break;





}