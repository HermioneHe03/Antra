﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace Application_Core.Entities
{
    public class MovieGenre
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
    }
}