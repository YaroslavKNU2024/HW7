﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._1100
{

    // в данній програмі порушено Single responsibility principle
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList;
        internal List<Item> ItemList
        {
            get{return itemList;}
            set{itemList = value;}
        }
        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }


}
