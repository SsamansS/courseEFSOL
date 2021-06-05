using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;

namespace prof_lesson2_2
{
    class Customers
    {
        NameValueCollection CustomersAndCategories = new NameValueCollection();
        public string this[int index]
        {
            get { return CustomersAndCategories[index]; }
        }
        public string this[string index]
        {
            get { return CustomersAndCategories[index]; }
            set { CustomersAndCategories[index] = value; }
        }
        public void Add(string category, string customer)
        {
            this.CustomersAndCategories.Add(category, customer);
        }
        public string[] GetCustomers(string category)
        {
            return this.CustomersAndCategories.GetValues(category);
        }
        public List<string> GetCategories(string customer)
        {
            List<string> categories = new List<string>();
            for(int i = 0; i < CustomersAndCategories.Count; i++)
            {
                foreach(var item in CustomersAndCategories[i].Split(','))
                {
                    if(item == customer && !categories.Contains(CustomersAndCategories.GetKey(i)))
                    {
                        categories.Add(CustomersAndCategories.GetKey(i));
                    }
                }
            }
            return categories;
        }
    }
}
