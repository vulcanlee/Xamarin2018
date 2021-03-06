﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFVisualTree.Models
{
    public class ProductItem : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool ShowBindingContext { get; set; } = false;
    }
}
