using System;

namespace MusicStore;

public class Piano :Instrument
{
        public int NumberOfKeys { get; set; }

        public Piano(string name, int year, int numberOfKeys) : base(name, year)
        {
            NumberOfKeys = numberOfKeys;
        }

        public override void Play()
        {
            Console.WriteLine($"{Name} đang chơi nhạc với {NumberOfKeys} phím.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Số phím: {NumberOfKeys}");
        }
}
