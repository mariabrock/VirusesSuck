﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirusesSuck
{
    class Virus
    {
        public string Name { get; set;  }
        public List<string> Symptoms { get; set; }
        public int NumOfDeathsWorldwide { get; set; }
        public int IncubationDays { get; set; }

        public Virus(string name, int incubationDays)
        {
            Name = name;
            IncubationDays = incubationDays;
            Symptoms = new List<string>();
        }

    }
}
