﻿namespace MyGymWeb.Models.Home
{
    /// <summary>
    /// 
    /// </summary>
    public class GymsViewModel
    {
        
        public int Id { get; set; }

       
        public string Name { get; set; } = null!;

        
        public string Type { get; set; } = null!;

       
        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

    }
}
