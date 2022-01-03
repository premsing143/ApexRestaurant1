using System;

namespace ApexRestaurant.Repository.Domain
{
    public class MenuItem
    {
        public int Menu_Item_Id { get; set; }

        public String Menu_Item_Title { get; set; }
        
        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        
    }
}