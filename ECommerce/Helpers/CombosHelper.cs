﻿using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.Helpers
{
    public class CombosHelper :IDisposable
    {
        private static ECommerceContext db = new ECommerceContext();
        public static List<Department> GetDepartments()
        {
            var departments = db.Departments.OrderBy(d => d.Name).ToList();
            departments.Add(new Department
            {
                DepartmentId = 0,
                Name = "[Seleccione un departamento...]"
            });
            return departments.OrderBy(d => d.Name).ToList();
        }

        public static List<City> GetCities()
        {
            var cities = db.Cities.OrderBy(d => d.Name).ToList();
            cities.Add(new City
            {
                CityId = 0,
                Name = "[Seleccione un ciudad...]"
            });
            return cities.OrderBy(d => d.Name).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}