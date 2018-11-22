using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public static class Chapter6
    {
        public static void Chapter6_Main()
        {
            var books = new List<Book>
            {
                new Book { Title = "태평천하", Price = 400, Pages = 378 },
                new Book { Title = "운수 좋은 날", Price = 281, Pages = 212 },
                new Book { Title = "만세전", Price = 389, Pages = 201 },
                new Book { Title = "삼대", Price = 637, Pages = 464 },
                new Book { Title = "상록수", Price = 411, Pages = 276 },
                new Book { Title = "혈의 누", Price = 961, Pages = 666 },
                new Book { Title = "금수회의록", Price = 514, Pages = 268 },
            };

            var numbers = Enumerable.Repeat(-1, 20)
                                    .ToList();

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            var strings = Enumerable.Repeat("(unknown)", 12)
                                    .ToArray();
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }

            var array = Enumerable.Range(1, 20)
                                    .ToArray();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(array.Sum());
            Console.WriteLine(array.Average());

            var sum = books.Sum(x => x.Price);
            var count = books.Count();
            var average = books.Average(x => x.Price);
            Console.WriteLine("{0}, {1}, {2}", sum, count, average);

            //최소값
            Console.WriteLine("===============최소값====================");
            var numbers2 = new List<int> { 9, 7, -5, 4, 2, 5, 4, 2, -4, 8, -1, 6, 4 };
            var min = numbers2.Where(n => n > 0)
                            .Min();
            Console.WriteLine(min);

            Console.WriteLine("===========조건에 일치하는 요소==========");
            var numbers3 = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
            var count3 = numbers3.Count(n => n == 0);
            Console.WriteLine(count3);

            var count4 = books.Count(x => x.Title.Contains("운수"));
            Console.WriteLine(count4);

            Console.WriteLine("==============컬렉션 판정==============");
            var rd = new Random();
            var 컬렉션판정 = Enumerable.Repeat(rd.Next(1, 100), 10);
            //var 컬렉션판정 = new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 11, 30, 24 };
            bool 있는지 = 컬렉션판정.Any(n => n % 7 == 0);
            Console.WriteLine(컬렉션판정.ToString());
            Console.WriteLine(있는지);

            Console.WriteLine("===========단일 요소를 구한다");
            var text = "The quick brown fox jumps over the lazy dog";
            var words = text.Split(' ');
            var word = words.FirstOrDefault(x => x.Length == 4);
            Console.WriteLine(word);
        }


        private static void NewMethod2()
        {
            int number = 12345678;
            var s4 = number.ToString("#,0");
            Console.WriteLine(s4);
        }

        private static void NewMethod1()
        {
            var str = "C#프로그래밍";
            foreach (var c in str)
            {
                Console.WriteLine("[{0}]", c);
            }
            Console.WriteLine();
        }

        private static void NewMethod()
        {
            ICollection<Song> songs = new List<Song>();
            songs.Add(new Song("기다리다", "조용필", 300));
            songs.Add(new Song("이등병의 편지", "김광석", 350));
            songs.Add(new Song("하늘 아래서", "김민종", 200));

            foreach (var item in songs)
            {
                Console.WriteLine(string.Format("{0}의 {1} 연주시간: {2}:{3}", item.ArtistName, item.Title, item.Length / 60, item.Length % 60));
            }
            Console.Read();
        }
    }
}
