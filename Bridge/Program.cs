using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Manuscript> documents = new List<Manuscript>();
            IFormatter standard = new FancyFormatter();
            var faq = new Faq(standard);
            documents.Add(faq);

            var book = new Book(standard);
            book.Title = "Book 1";
            documents.Add(book);

            var paper = new TermPaper(standard);
            documents.Add(paper);

            foreach (var doc in documents)
            {
                doc.Print();
            }
        }
    }
}
