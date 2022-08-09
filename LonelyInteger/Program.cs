// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;

var a = new List<int>{4, 9, 95, 93, 57, 4 ,57 ,93 ,9};
var a1 = a.Distinct();

Console.WriteLine(lonelyInteger(a));

static int lonelyInteger(List<int> a){
    var aDictionary = new Dictionary<int, int>();
    var uniqueValues = a.Distinct().ToList();
    var uniqueElement = -1;
    
    aDictionary = initiliazeDictionary(aDictionary, uniqueValues);
    countValues(aDictionary, a);
    uniqueElement = findUniqueValue(aDictionary);

    return uniqueElement;
}

static Dictionary<int, int> initiliazeDictionary(Dictionary<int, int> dict, List<int> uniqueValues){
    foreach(var i in uniqueValues){
        dict.Add(i, 0);
    }
    return dict;
}

static void countValues(Dictionary<int, int> dict, List<int> arr){
    foreach(var i in arr){
        dict[i]++;
    }
}

static int findUniqueValue(Dictionary<int, int> dict){
    int uniqueElement = -1;

    foreach(var i in dict.Keys){
        if(dict[i] == 1){
            uniqueElement = i;
        }
    }

    return uniqueElement;
}