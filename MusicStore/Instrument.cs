using System;

namespace MusicStore;

public abstract  class Instrument
{
     public string Name { get; set; }
        public int Year { get; set; }

        public Instrument(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public abstract void Play();

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Tên nhạc cụ: {Name}, Năm sản xuất: {Year}");
        }
}
