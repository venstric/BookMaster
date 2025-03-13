﻿using BookMaster.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BookMaster
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Контекст данных, который хранит в себе все таблицы БД.
        public static Entities context = new Entities();
    }
}
