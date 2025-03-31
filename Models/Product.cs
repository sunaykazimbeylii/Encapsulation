using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EncapsulationAndRecord.Models
{
    internal class Product
    {
        private string _id;
        private string _brandname;
        private string _model;
        private decimal _price;
        private decimal _cost;
        private decimal _income;
        private int _count;

        public string Id
        {
            get
            {
                return _id;
            }
           
        }
        public string Brandname
        {
            get {
                return _brandname;
            }
            set {
                value=value.Trim();
                if (value.Length>=2) 
                {
                _brandname = value;
                }
                else
                {
                    Console.WriteLine("Ad formati duzgun deyil");
                }
            }
        }

        public string Model
        {
            get {
                return _model;
            }
            set
            {
                value = value.Trim();
                if (value.Length >= 2)
                {
                    _model = value;
                }
                else
                {
                    Console.WriteLine("Ad formati duzgun deyil");
                }
            }
        }

        public decimal Price
        {
            get {
                return _price; 
                }
            set 
            {
                if (value>0)
                {
                    _price = value;
                }
            }
        }

        public decimal Cost
        {
            get { 
                return _cost;
            }
            set {
                if (value>0)
                {
                    _cost = value;
                }
            }
        }

        public decimal Income
        {
            get { return _income ; }
        }

        public int Count
        {
            get { return _count; }
            set {
                if (value>=0)
                {
                    _count = value;
                }

            }
        }
        public Product( string brandname, string model, decimal price , decimal cost , int count)
        {
            Brandname=brandname;
            Model=model;       
            Price=price;
            Cost=cost;
            Count=count;
        
            _id = string.Concat(Brandname.Substring(0, 2), Model.Substring(0, 2));
             
            if (count-->0)
            {
                _income = 0;
                _income += _price;
                
            }
            else if (count==0)
            {
                _income = 0;
            }

        }
        public void GetInfo()
        {
            Console.WriteLine($"Id :{_id} BrandName: {_brandname} Model:{_model} Price:{_price} Cost:{_cost} Income:{_income} Count:{Count}");
        }
        public void Sale()
        {
            if (_count>0)
            {    _income = 0;
                _income += _price - _cost;
                _count--;
                Console.WriteLine($"satis heyata kecirilidi Income:{_income} Count:{_count}");
            }
            else
            {
                Console.WriteLine("mehsul bitib");
            }
        }

    }
}
