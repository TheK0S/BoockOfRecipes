using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoockOfRecipes.Model
{
    class Recipes
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public string? RecipeType { get; set; }
        public string? ManualName { get; set; }
        public List<string>? Manual { get; set; }
    }
}
