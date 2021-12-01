using System;

namespace task42
{
    // порушено 4 принцип SOLID (для інтерфейсу)
    interface IItem
    {
        void ApplyDiscount(String discount);
        void ApplyPromocode(String promocode);
        void SetColor(byte color);
        void SetSize(byte size); 
         void SetPrice(double price);
    }
}
