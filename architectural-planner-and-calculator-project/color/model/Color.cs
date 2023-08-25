using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architectural_planner_and_calculator_project.color.model
{
    public class Color
    {
        private Int32 _id;
        private Double _priceAdditive;
        private String _name;
        private String _hex;

        // Constructors

        public Color(Int32 id, Double priceAdditive, String name, String hex)
        {
            _id = id;
            _priceAdditive = priceAdditive;
            _name = name;
            _hex = hex;
        }

        // Accessors

        public Int32 Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public Double PriceAdditive
        {
            get { return _priceAdditive; }
            set
            {
                _priceAdditive = value;
            }
        }

        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public String Hex
        {
            get { return _hex; }
            set
            {
                _hex = value;
            }
        }

        // Methods

        public override Boolean Equals(object? obj)
        {
            return (obj as Color)._id == _id && (obj as Color)._priceAdditive == _priceAdditive && (obj as Color)._name == _name && (obj as Color)._hex == _hex;
        }

        public override String ToString()
        {
            String desc = "";

            desc += $"Id : {_id}\n";
            desc += $"Price Additive : {_priceAdditive}\n";
            desc += $"Name : {_name}\n";
            desc += $"Hex Code : {_hex}\n";

            return desc;
        }
    }
}
