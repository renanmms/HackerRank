// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;

var a = new List<int>{1, 2, 3, 4, 3, 2, 1};


static List<int> lonelyInteger(List<int> a){
   
    var uniqueValues = a.Distinct().ToList();
    return uniqueValues;
}
