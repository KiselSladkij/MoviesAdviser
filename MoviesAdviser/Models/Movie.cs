﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MoviesAdviser.Models
{
    class Movie
    {       
        //Название
        public string Title { get; set; }

        //Постер фильма - картинка. Как её хранить - пока неизвестно. Побудет string
        public string Poster { get; set; } 

        //Страна
        public string Country { get; set; }

        //Год выпуска
        public int Year { get; set; }

        //Средний рейтинг (будет получен от Analyzer, в конструкторе не инициализируется)
        public  double Rating { get; set; }

        //Список комментариев и рецензий к фильму (в конструкторе не инициализируется, будет заполняться браузерами сайтов
        public List<Comment> comments { get; set; }

        public Movie (string title, string country, int year)
        {
            Title = title;
            Country = country;
            Year = year;
        }

        //Вложенный класс комментария к фильму
        public class Comment
        {
            public string Author { get; set; }
            public string Message { get; set; }
        }
    }
}
