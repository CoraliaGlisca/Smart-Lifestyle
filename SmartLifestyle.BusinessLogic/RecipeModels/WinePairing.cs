using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLifestyle.BusinessLogic.RecipeModels
{
    public class WinePairing
    {
        public List<string> pairedWines { get; set; }
        public string pairingText { get; set; }
        public List<ProductMatch> productMatches { get; set; }
    }
}
