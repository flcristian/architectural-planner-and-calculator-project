using architectural_planner_and_calculator_project.color.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architectural_planner_and_calculator_project.material.model
{
    public class Material
    {
        private Int32 _id;
        private String _name;
        private String _textureType;
        private String _finishType;
        private Color _color;
        private Double _basePrice;

        // Constructors

        public Material(Int32 id, String name, String textureType, String finishType, Color color, Double basePrice)
        {
            _id = id;
            _name = name;
            _textureType = textureType;
            _finishType = finishType;
            _color = color;
            _basePrice = basePrice;
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

        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public String TextureType
        {
            get { return _textureType; }
            set
            {
                _textureType = value;
            }
        }

        public String FinishType
        {
            get { return _finishType; }
            set
            {
                _finishType = value;
            }
        }

        public Color Color
        {
            get { return _color; }
            set
            {
                _color = value;
            }
        }

        public Double BasePrice
        {
            get { return _basePrice; }
            set
            {
               _basePrice = value;
            }
        }

        // Methods

        public override Boolean Equals(object? obj)
        {
            return (obj as Material)._id == _id && (obj as Material)._name == _name && (obj as Material)._textureType == _textureType && (obj as Material)._finishType == _finishType && (obj as Material)._color == _color && (obj as Material)._basePrice == _basePrice;
        }

        public override String ToString()
        {
            String desc = "";

            desc += $"Id : {_id}\n";
            desc += $"Name : {_name}\n";
            desc += $"Texture Type : {_textureType}\n";
            desc += $"Finish Type : {_finishType}\n";
            desc += $"Color Name : {_color.Name}\n";
            desc += $"Color Hex Code : {_color.Hex}\n";
            desc += $"Color Price Additive : {_color.PriceAdditive}\n";
            desc += $"Base Price : {_basePrice}\n";

            return desc;
        }

        public Double CalculatePrice()
        {
            return _basePrice + _color.PriceAdditive;
        }

        public Double CalculatePrice(Double surfaceArea)
        {
            return (_basePrice + _color.PriceAdditive) * surfaceArea;
        }
    }
}
