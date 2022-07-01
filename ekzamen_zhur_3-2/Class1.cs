using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekzamen_zhur_3_2
{
    public class Client
    {
        // строка, содержащая имя 
        private string _name;
        private int _num;
        private List<RealEstate> _realEstate;

        // конструктор класса (вызывается при создании нового экземпляра класса)
        public Client(int num, string name)
        {
            _name = name;
            _num = num;

            _realEstate = new List<RealEstate>();
        }

        public string getName
        {
            get { return _name; }
        }

        public int getNum
        {
            get { return _num; }
        }

        public void addRealEstate(string type, string adress, int price)
        {
            RealEstate realEstate;
            realEstate.type = type;
            realEstate.adress = adress;
            realEstate.price = price;

            _realEstate.Add(realEstate);
        }

        public int realEstatePrice
        {
            get
            {
                int price = 0;

                if (_realEstate.Count == 0)
                {
                    return price;
                }

                foreach (RealEstate realEstate in _realEstate)
                {
                    price += realEstate.price;
                }

                return price;
            }
        }

        public string Info()
        {
            string realEstateInfo = "";

            if (_realEstate.Count == 0)
            {
                realEstateInfo = "отсутствует";
            }
            else
            {
                foreach (RealEstate realEstate in _realEstate)
                {
                    realEstateInfo += $"\nТип: {realEstate.type}; Адрес: {realEstate.adress}; Цена: {realEstate.price} $";
                }
            }

            return $"Имя: {_name}\nНедвижимость:\n {realEstateInfo}";
        }

    }

}
