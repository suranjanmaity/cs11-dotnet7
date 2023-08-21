using static System.Console;
namespace SelectionStatement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Animal?[] animals = new Animal?[]
            {
                new Cat{Name= "Karen", Born=new (year:2022,month:8,day:23),Legs=4,IsDomestic=true},
                null,
                new Cat{Name= "Mufasa", Born=new(year:1996,month:2, day:29)},
                new Spider{ Name="Parkhi", Born= DateTime.Now, IsPoisonous=true},
                new Spider{ Name= "Captain Shivendra", Born = DateTime.Today}
            };

            foreach (Animal? animal in animals)
            {
                string message;
                //switch (animal)
                //{
                //    case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
                //        message = $"The cat named {fourLeggedCat.Name} has four legs.";
                //        break;
                //    case Cat wildCat when wildCat.IsDomestic == false:
                //        message = $"The non domestic cat named {wildCat.Name}.";
                //        break;
                //    default:
                //        message = $"The animal named {animal.Name} is a {animal.GetType().Name}";
                //        break;
                //    case Spider spider when spider.IsPoisonous:
                //        message = $"The spider named {spider.Name} is poisonous, Run!";
                //        break;
                //    case null:
                //        message = "The animal is null";
                //        break;
                //}

                // We can use simplefied switch statement with switch expression
                message = animal switch
                {
                    Cat fourLeggedCat when fourLeggedCat.Legs == 4
                        => $"The cat named {fourLeggedCat.Name} has four legs.",
                    Cat wildCat when wildCat.IsDomestic == false
                        => $"The non domestic cat named {wildCat.Name}.",
                    Spider spider when spider.IsPoisonous
                        => $"The spider named {spider.Name} is poisonous, Run!",
                    null
                        => "The animal is null",
                    _
                        => $"The animal named {animal.Name} is a {animal.GetType().Name}",
                };

                WriteLine($"switch statement : {message}");

            }            
        }
    }
}