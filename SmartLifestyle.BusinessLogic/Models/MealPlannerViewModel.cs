using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartLifestyle.Models.Model;

namespace SmartLifestyle.BusinessLogic.Models
{
    public class MealPlannerViewModel
    {
        public int MealPlanId { get; set; }

        public int UserId { get; set; }

        public int UserDetailsForMealId { get; set; }

       
        public IList<string> SelectedAllergens { get; set; }

        public List<SelectListItem> Allergens { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Dairy",       Text = "Dairy"      },
            new SelectListItem { Value = "Egg",         Text = "Egg"        },
            new SelectListItem { Value = "Gluten",      Text = "Gluten"     },
            new SelectListItem { Value = "Grains",      Text = "Grains"     },
            new SelectListItem { Value = "Peanut",      Text = "Peanut"     },
            new SelectListItem { Value = "Seafood",     Text = "Seafood"    },
            new SelectListItem { Value = "Sesame",      Text = "Sesame"     },
            new SelectListItem { Value = "Shellfish",   Text = "Shellfish"  },
            new SelectListItem { Value = "Soy",         Text = "Soy"        },
            new SelectListItem { Value = "TreeNut",     Text = "Tree Nut"   },
            new SelectListItem { Value = "Wheat",       Text = "Wheat"      },
            new SelectListItem { Value = "Corn",        Text = "Corn"       }                 
        };

        public IList<string> SelectedDiets { get; set; }
        public List<SelectListItem> Diets { get; set; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "NoDiet",                   Text = "No Diet"           },
            new SelectListItem { Value = "LactoVegetarian",          Text = "LactoVegetarian"   },
            new SelectListItem { Value = "OvoVegetarian",            Text = "OvoVegetarian"     },
            new SelectListItem { Value = "Paleo",                    Text = "Paleo"             },
            new SelectListItem { Value = "Primal",                   Text = "Primal"            },
            new SelectListItem { Value = "Pescetarian",              Text = "Pescetarian"       },
            new SelectListItem { Value = "Vegan",                    Text = "Vegan"             },
            new SelectListItem { Value = "Vegetarian",               Text = "Vegetarian"        },
            new SelectListItem { Value = "Whole 30",                 Text = "Whole 30"          }

        };

        public string ExcludedIngredients { get; set; }

        [Required]
        public int TargetCalories { get; set; }

        [Required]
        public string StartEvent { get; set; }

    }
}
