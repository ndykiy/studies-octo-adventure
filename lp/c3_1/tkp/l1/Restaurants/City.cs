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
    
    public partial class City
    {
        public City()
        {
            this.Restaurants = new HashSet<Restaurant>();
        }
    
        public System.Guid CityID { get; set; }
        public string Name { get; set; }
        public System.Guid CountryID { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}