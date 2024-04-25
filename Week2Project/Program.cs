namespace Week2Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            State state = new State();
            Inventory inventory  = new Inventory();
            Shop shop = new Shop();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n" );

                Console.WriteLine("1.상태보기 / 2.인벤토리 / 3.상점\n");

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.WriteLine(">>");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        state.PlayerState();
                        break;
                    case "2":
                        inventory.PlayerInven();
                        break;
                    case "3":
                        shop.PlayerShop();
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다. 1, 2, 3을 입력해주세요");
                        break;

                }


                
            }
        }
    }
}
