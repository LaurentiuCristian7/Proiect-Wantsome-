﻿using DonutsGo.DataAccess.Entities;

namespace DonutsGo.DataAccess
{
    public static class Storage
    {
        public static List<Product> Products { get; set; } = new List<Product>();

        public static List<User> Users { get; set; } = new List<User>();
    }
}
