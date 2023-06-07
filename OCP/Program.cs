using System;

namespace OCP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GoldMemberShip goldMemberShip = new GoldMemberShip();
            Console.WriteLine(goldMemberShip.GetTraining());
        }

        public class MemberShip
        {
            public int MemberShipType { get; set; }
            public void Add()
            {
               //todo
            }

            //Gold - 1, Silver - 2, Platinum - 3

            public virtual int GetTraining()
            {
                return 0;

            }

            //methid give cert..
        }

        public class GoldMemberShip : MemberShip
        {
            public override int GetTraining()
            {
                return 5;
            }
        }

        public class SilverMemberShip : MemberShip
        {
            public override int GetTraining()
            {
                return 2;
            }
        }

        public class PlatinumMemberShip : MemberShip
        {
            public override int GetTraining()
            {
                return 10;
            }
        }
    }
}
