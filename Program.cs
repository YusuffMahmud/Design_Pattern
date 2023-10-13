// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Assignment;
// Singleton
Singleton singleton = Singleton.Company;
singleton.GetFood("snacks");

Singleton singleton1 = Singleton.Company;
singleton1.GetFood("drinks");

// Builder
var mould = new MouldStructure();
var director = new BuilderDirector();
var mouldes = director.BuildHouse(mould);

// Factory
FactoryGoods goods = new FactoryGoods();
Factory drinks =goods.GetDrinks("drinks");
Factory snacks = goods.GetDrinks("snacks");
