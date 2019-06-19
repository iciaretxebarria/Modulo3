﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoclubWebApp.Models
{
    public class UserFilm
    {
        public int Id { get; set; }
        public DateTime DateRental { get; set; }
        public DateTime ReturnDate { get; set; }

        public int UserId { get; set; }
        public Film Film { get; set; }
        public int FilmId { get; set; }
        public User User { get; set; }

    }
}
