﻿using System;
using System.Collections.Generic;

namespace DemoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EFCoreDemoContext())
            {
                var author = new Author
                {
                    FirstName = "William",
                    LastName = "Shakespeare",
                    Books = new List<Book>
                    {
                        new Book { Title = "Hamlet"},
                        new Book { Title = "Othello" },
                        new Book { Title = "MacBeth" }
                    }
                };
                context.Add(author);
                context.SaveChanges();
            }
            Console.WriteLine("Fim");
            Console.ReadLine();
        }
    }
}
