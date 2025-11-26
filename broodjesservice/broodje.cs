using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace broodjesservice
{
    internal class broodje
    {
        public string name { get; set; }

		private string _type;

		public string type
		{
			get { return _type; }
			set {
                if (_allowedTypes.Contains(value))
                {
                    _type = value;
                }
                else
                {
                    throw new ArgumentException("(type) ongeldige invoer"); 
                }
            }
		}

        public decimal price { get; set; }

        private static readonly string[] _allowedTypes = { "warm", "koud", "veggie", "speciaal" };

        public broodje(string name, string type, decimal price)
        {
            name = name;
            type = type;   
            price = price;
        }

    }
}
