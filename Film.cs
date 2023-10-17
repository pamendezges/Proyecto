﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MendezPablo_Proyecto
{
    class Film : Content
    {
        private String producer;
        private String director;
        private String mainActor;

        public Film(int id, string title, string category) :
               this(id, title, category, String.Empty, String.Empty, String.Empty)
        { }

        public Film(int id, string title, string category, string producer, string director, string mainActor) : base(id, title, category)
        {
            this.producer = producer;
            this.director = director;
            this.mainActor = mainActor;
        }


        public string Producer { get => producer; set => producer = value; }
        public string Director { get => director; set => director = value; }
        public string MainActor { get => mainActor; set => mainActor = value; }



    }
}
