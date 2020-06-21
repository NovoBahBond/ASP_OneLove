using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ASP_OneLove.Models
{
    public abstract class Building {
        [Key]
        public int ID { get; set; }
        //Адрес
        public Address Address { get; set; }
        
        //Кол-во этажей
        public int Floors { get; set; }
        
        //Заб
        public bool IsBooked => Apartments.All(a => a.IsBooked);
        
        //Квартиры / дома (Если многоквартирный дом то будет колеекция а если бронируем вилу/дом то один элемент)
        public ICollection<Apartment> Apartments { get; set; }
    }
}
