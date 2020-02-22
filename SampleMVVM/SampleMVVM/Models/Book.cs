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
        public string InputText { get; set; }
        public int Count { get; set; }

        public Book(string InputText, string OutputText, int count)
        {
            this.OutputText = InputText;
            this.InputText =OutputText;
            this.Count = count;
        }

    }
}
