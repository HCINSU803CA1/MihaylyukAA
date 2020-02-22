using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SampleMVVM.Models
{
    class Book
    {
        public string OutputText { get; set; }
        public string Author { get; set; }
        public int Count { get; set; }

        public Book(string title, string author, int count)
        {
            this.OutputText = title;
            this.Author = author;
            this.Count = count;
        }

    }
}
