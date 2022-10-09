using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    internal class Book
    {
        private Title title;
        private Author author;
        private Content content;
        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }
        public Title Title { get { return title; } }
        public Author Author { get { return author; } }
        public Content Content { get { return content; } }
    }
}
