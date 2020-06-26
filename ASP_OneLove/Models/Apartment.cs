using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_OneLove.Models
{
    public class Apartment {
        [Key]
        public int ApartmentId { get; set; }

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
        public ICollection<SpecialFacilities> SpecialFacilities { get; set; }
    }
}
