using System;

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GoldMemberShip ship = new GoldMemberShip();
            ship.Add();
            MemberShip ship2 = new MemberShip();
            ship2.Add();
            //TrialMemberShip trial = new TrialMemberShip();
            //trial.Add();
        }

        public class MemberShip : IMemberShip, ITraining
        {
            public int MemberShipType { get; set; }
            public virtual void Add()
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

        public class TrialMemberShip : ITraining
        {
            public int GetTraining()
            {
                return 1;
            }
        }

        public interface IMemberShip
        {
            void Add();
        }

        public interface ITraining
        {
            int GetTraining();
        }

    }
}
