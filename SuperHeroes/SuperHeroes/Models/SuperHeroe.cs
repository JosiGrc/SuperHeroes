using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperHeroes.Models
{
    public class SuperHeroe
    {
        //Variables
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public string PrimarySuperHeroAbility { get; set; }
        public string SeocondarySuperHeroeAbility { get; set; }
        public string Catchphrase { get; set; }
        //Ctor

        //Methods
    }
}