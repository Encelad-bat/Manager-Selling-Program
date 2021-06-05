using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Manager_Selling_Program.Model
{
    class Car
    {
        //-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲

        int id;
        public int Id { get { return id; } set { id = value; } }

        //-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲

        string name;
        public string Name { get { return name; } set { name = value; } }

        //-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲

        string color;
        public string Color { get { return color; } set { color = value; } }

        //-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲

        int year;
        public int Year { get { return year; } set { year = value; } }

        //-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲-̲

    }
}
