//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurants
{
    using System;
    using System.Collections.Generic;
    
    public partial class Restaurant
    {
        public System.Guid RestaurantID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public System.Guid RestaurantNetworkID { get; set; }
        public System.Guid CityID { get; set; }
    
        public virtual City City { get; set; }
        public virtual RestaurantNetwork RestaurantNetwork { get; set; }
    }
}