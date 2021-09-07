using System;
using System.Collections.Generic;
using System.Text;

namespace EmailInboxXamarin.Models
{
    public class Mail
    {
        public Mail(string from, string title, string description, string date, string content)
        {
            From = from;
            Title = title;
            Description = description;
            Date = date;
            Content = content;
        }

        public string From { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
        
    }
}
