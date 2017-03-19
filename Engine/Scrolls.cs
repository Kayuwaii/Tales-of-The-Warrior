using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Scroll : Item
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int SAPRequired { get; set; }

        public Scroll(int id, string name, string namePlural, int minimumDamage, int maximumDamage, int sapRequired) : base(id, name, namePlural)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            SAPRequired = sapRequired;
        }

        private bool isUsable()
        {
            return true;
        }
    }
}