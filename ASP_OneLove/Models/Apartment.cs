using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_OneLove.Models
{
    public class Apartment : Building {
        //Тип (Дом или квартира)
        public ApartmentType Type { get; set; }
        
        //Этаж
        public int Floor { get; set; }
        
        //Номер 
        public int Number { get; set; }
        
        //К-во комнат
        public uint RoomCount { get; set; }
        
        //К-во кроватей
        public uint BedCount { get; set; }
        
        //К-во ванных
        public uint BathCount { get; set; }
        
        //Звезды
        public ushort Stars { get; set; }
        
        //Цена
        public double Price { get; set; }
        
        //Забронировано?
        public bool IsBooked { get; set; } = false;
        
        //Особые удобства
        public ICollection<string> SpecialFacilities { get; set; }
    }
}
