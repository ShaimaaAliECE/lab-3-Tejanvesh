using System;
using System.Collections.Generic;

namespace Lab3App
{
	internal class Coin : Treasure
	{
		private string name;
		private int score, Value;

		public Coin(string name, int score, int value){
			this.name = name;
			this.score = score;
			this.Value = value;
		}

        public override void AddMe(List<Collectable> list)
        {
            Console.WriteLine(name+" collected, Congrats!!!!");
            list.Add(this);
            UpdateTotalScore();
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + name + " is displayed");
        }

        public override void UpdateTotalScore()
        {
            CollectionBoard.TotalScore += score;
            Console.WriteLine("Total Score is updated to: " + CollectionBoard.TotalScore);
        }

        public void UpdateTotalValue()
		{
            CollectionBoard.TotalValue += Value;
            Console.WriteLine("Total Value is updated to: " + CollectionBoard.TotalValue);
        }
	}
}

