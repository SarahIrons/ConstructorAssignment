using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorAssignment
{
    public class CustomerShipping
    
    { 
        public const int WarehouseNumber= 459; //used const as the location of warehouse where items are shipped from because const variable cannot be changed. 
        public string ShippingStatus;//this variable gives info to the customer about status of shipment (recieved/delivered/etc)

        public CustomerShipping() : this("Your order was received and we are preparing shipment!")
        {
            
        }

        public CustomerShipping(string ShippingStatus)
        {//below I used the var for the update message so that it could be used in different places n(ex, email/text possibly) and to make it easier to read.
            var customerUpdateMessage = "Shipping from Warehouse Number: {0} Shipping Status: {1}";
            this.ShippingStatus = ShippingStatus; //this code passes through info into the message to the customer. this is part of chaining the constructor.
           Console.WriteLine(customerUpdateMessage, WarehouseNumber, ShippingStatus);

        }
    }
}
