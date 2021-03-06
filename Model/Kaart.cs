﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Kaart
    {
       private int Id;

       public bool IsKeuken { get; set; }
       public string Naam { get; set; }
       public List<Category> Categorieën { get; set; }

       public Kaart(int id, bool isKeuken, string naam)
       {
           Id = id;
           IsKeuken = isKeuken;
           Naam = naam;
       }
    }
}
