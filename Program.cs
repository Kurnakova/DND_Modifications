Console.WriteLine("Введите в консоль данные о персонаже.");
Console.Write("Имя: ");
string name = CreateName();
Console.WriteLine("Введите значения характеристик.");
Console.Write("Сила: ");
int strength = Convert.ToInt32(Console.ReadLine());
Console.Write("Ловкость: ");
int dexterity = Convert.ToInt32(Console.ReadLine());
Console.Write("Телосложение: ");
int constitution = Convert.ToInt32(Console.ReadLine());
Console.Write("Интеллект: ");
int intelligence = Convert.ToInt32(Console.ReadLine());
Console.Write("Мудрость: ");
int wisdom = Convert.ToInt32(Console.ReadLine());
Console.Write("Харизма: ");
int charisma = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выберите расу (введите её номер в консоль): \n1. Эльф (+2 к ловкости, +1 к мудрости) \n2. Дварф (+2 к телосложению, +1 к силе) \n3. Гном (+2 к интеллекту, +1 к ловкости)");
Ancestry ancestry = GetAncestry(); 

Person person = new Person (name, ancestry, strength, dexterity, constitution, intelligence, wisdom, charisma);
person.GetInfo();

// Методы
string CreateName()
{
    string? name;
    while (true)
    {
        name = Console.ReadLine();
        if(String.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Имя должно содержать символы. \nВведите новое имя:");
        }
        else
            break;
    }
    return name;
}
Ancestry GetAncestry()
{
    AncestryType type = AncestryType.Dwarf;
    for (bool InvalidOption = true; InvalidOption;  )
    {

       int ancestryOption = Convert.ToInt32(Console.ReadLine());
       type = (AncestryType)ancestryOption;
       InvalidOption = ancestryOption < 1 || ancestryOption > 3;
       if (InvalidOption)
            Console.WriteLine("Неверное число. Введите число из списка.");
    }
    return new Ancestry(type);
}