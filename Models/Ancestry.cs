class Ancestry
{
    public string _name { get; } = "undefined ancestry";
    public int _strengthBonus { get; }
    public int _dexterityBonus { get; }
    public int _constitutionBonus { get; }
    public int _intelligenceBonus { get; }
    public int _wisdomBonus { get; }
    public int _charismaBonus { get; }
    CreatureSize size;

    public Ancestry (int type)
    {
        if (type == 1)
        {
            _name = "Эльф";
            _dexterityBonus = 2;
            _wisdomBonus = 1;
            size = CreatureSize.Medium;
        }
        else if (type == 2)
        {
            _name = "Дварф";
            _strengthBonus = 1;
            _constitutionBonus = 2;
            size = CreatureSize.Medium;
        }
        else if (type == 3)
        {
            _name = "Гном";
            _dexterityBonus = 1;
            _intelligenceBonus = 2;
            size = CreatureSize.Small;
        }
    }
}