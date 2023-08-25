using architectural_planner_and_calculator_project.material.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace architectural_planner_and_calculator_project.furniture.model
{
    public class Furniture
    {
        private Int32 _id;
        private String _name;
        private Double _scale;
        private Double _width;
        private Double _length;
        private Double _height;
        private Material _material;
        private Double _price;

        // Constructors
        public Furniture(Int32 id, Double scale, String name, Double width, Double length, Double height, Material material, Double price)
        {
            _id = id;
            _name = name;
            _scale = scale;
            _width = width;
            _length = length;
            _height = height;
            _material = material;
            _price = price;
        }

        public Furniture(Int32 id, String name, Double width, Double length, Double height, Material material, Double price)
        {
            _id = id;
            _name = name;
            _scale = 1;
            _width = width;
            _length = length;
            _height = height;
            _material = material;
            _price = price;
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

        public Double Scale
        {
            get { return _scale; }
            set
            {
                _scale = value;
            }
        }

        public Double Width
        {
            get { return _width; }
            set
            {
                _width = value;
            }
        }

        public Double Length
        {
            get { return _length; }
            set
            {
                _length = value;
            }
        }

        public Double Height
        {
            get { return _height; }
            set
            {
                _height = value;
            }
        }

        public Material Material
        {
            get { return _material; }
            set
            {
                _material = value;
            }
        }

        public Double Price
        {
            get { return _price; }
            set
            {
                _price = value;
            }
        }

        // Methods

        public override Boolean Equals(object? obj)
        {
            return (obj as Furniture)._id == _id && (obj as Furniture)._name == _name && (obj as Furniture)._scale == _scale && (obj as Furniture)._width == _width && (obj as Furniture)._length == _length && (obj as Furniture)._height == _height && (obj as Furniture)._material == _material && (obj as Furniture)._price == _price;
        }

        public override String ToString()
        {
            String desc = "";

            desc += $"Id : {_id}\n";
            desc += $"Name : {_name}\n";
            desc += $"Scale : {_scale}\n";
            desc += $"Width : {_width}\n";
            desc += $"Length : {_length}\n";
            desc += $"Height : {_height}\n";
            desc += $"Material : {_material.Name}\n";
            desc += $"Base Price : {_price}\n";
            desc += $"Complete Price (Modified by scale) : {CompletePrice()}\n";

            return desc;
        }

        public Double CompletePrice()
        {
            return _price * _scale;
        }
    }
}
