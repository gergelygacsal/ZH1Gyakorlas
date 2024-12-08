namespace Common
{
    public class Ingredient
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public string Unit { get; set; }

        public Ingredient(string name, int count, string unit)
        {
            Name = name;
            Count = count;
            Unit = unit;
        }

        public static Ingredient GetRandom()
        {
            var random = new Random();
            var names = new[] { "Liszt", "Cukor", "Tojás", "Só", "Olaj" };
            var units = new[] { "gramm", "csomag", "darab", "liter", "csipet" };

            string randomName = names[random.Next(names.Length)];
            string randomUnit = units[random.Next(units.Length)];
            int randomCount = random.Next(1, 101); // 1-100 között

            return new Ingredient(randomName, randomCount, randomUnit);
        }

        public override string ToString()
        {
            return $"{Name}, {Count} {Unit}";
        }
    }
}
