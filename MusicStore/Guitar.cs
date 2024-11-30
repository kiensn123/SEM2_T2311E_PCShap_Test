using System;

namespace MusicStore;

public class Guitar: Instrument
{
        public int NumberOfStrings { get; set; }

        public Guitar(string name, int year, int numberOfStrings) : base(name, year)
        {
            NumberOfStrings = numberOfStrings;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} đang chơi nhạc với {NumberOfStrings} dây.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Số dây: {NumberOfStrings}");
        }
}
