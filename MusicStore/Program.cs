using System;

namespace MusicStore;
class Program
{
    static void Main(string[] args)
    {
            List<Instrument> instruments = new List<Instrument>
            {
                new Guitar("Guitar Classic", 2020, 6),
                new Guitar("Guitar Electric", 2021, 7),
                new Piano("Grand Piano", 2019, 88),
                new Piano("Upright Piano", 2018, 76),
                new Guitar("Bass Guitar", 2022, 4)
            };

            Console.WriteLine("Danh sách nhạc cụ trong cửa hàng:");
            foreach (var instrument in instruments)
            {
                instrument.ShowInfo();
                instrument.Play();
                Console.WriteLine();
            }
        
    }
}