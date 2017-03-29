using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionRecording
{
    class TransactionEntry
    {
        private int ID;
        private String department;
        private String brand;
        private String description;
        private String quantity;
        private String price;
        private String date;

        public void setID(int _ID)
        {
            ID = _ID;
        }

        public void setDepartment(String _department)
        {
            department = _department;
        }

        public void setBrand(String _brand)
        {
            brand = _brand;
        }

        public void setDescription(String _description)
        {
            description = _description;
        }

        public void setQuantity(String _quantity)
        {
            quantity = _quantity;
        }

        public void setPrice(String _price)
        {
            price = _price;
        }

        public void setDate(String _date)
        {
            date = _date;
        }

        public int getID()
        {
            return ID;
        }

        public String getDepartment()
        {
            return department;
        }

        public String getBrand()
        {
            return brand;
        }

        public String getDescription()
        {
            return description;
        }

        public String getQuantity()
        {
            return quantity;
        }

        public String getPrice()
        {
            return price;
        }

        public String getDate()
        {
            return date;
        }
    }
}
