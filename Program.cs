namespace askerlikswitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Okuyor musunuz? (evet/hayir) ");
            string okul = Console.ReadLine().ToLower();

            switch(okul)
            {
                case "evet":
                    Console.WriteLine("Askerlige gidemezsiniz");
                    break;
                case "hayir":
                    Console.WriteLine("kac yasindasiniz? ");
                    int yas = Convert.ToInt32(Console.ReadLine());
                    if (yas >= 18)
                    {
                        Console.WriteLine("Askerlige gidebilirsiniz.");
                    }
                    else
                    {
                        Console.WriteLine("Askerlige gidemezsiniz");
                    }
                    break;
                default:
                    Console.WriteLine("Hatali yazim");
                    break;




            }
                


        }
    }
}