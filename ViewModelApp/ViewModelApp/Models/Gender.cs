﻿using ViewModelApp.Models;

namespace ViewModel.Models
{
    public class Gender
    {
        public int GenderID { get; set; }

        public string GenderName { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}