using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenter.Data
{
    public class Repository
    {
        private class DataSet
        {
            public List<Employee> Employees { get; set; }
            public List<Department> Departments { get; set; }
            public List<Item> Items { get; set; }
            public List<Brand> Brands { get; set; }
            public Journal Journal { get; set; }

            public DataSet()
            {
                Employees = new List<Employee>();
                Departments = new List<Department>();
                Items = new List<Item>();
                Brands = new List<Brand>();
            }

        }

        DataSet _dataset;

        public List<Employee> Employees
        {
            get
            {
                return _dataset.Employees;
            }
            set
            {
                _dataset.Employees = value;
            }
        }

        public List<Department> Departments
        {
            get
            {
                return _dataset.Departments;
            }
            set
            {
                _dataset.Departments = value;
            }
        }

        public List<Item> Items
        {
            get
            {
                return _dataset.Items;
            }
            set
            {
                _dataset.Items = value;
            }
        }

        public List<Brand> Brands
        {
            get
            {
                return _dataset.Brands;
            }
            set
            {
                _dataset.Brands = value;
            }
        }

        public Journal Journal
        {
            get
            {
                return _dataset.Journal;
            }
            set
            {
                _dataset.Journal = value;
            }
        }

        public Repository()
        {
            _dataset = new DataSet();
        }

        public void AddMethod(object item)
        {

        }
    }
}
