using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment;

public abstract class Factory
{
    public abstract string CreateFactory();

}

public class Drinks : Factory
{
    public override string CreateFactory()
    {
      return "drinks available";
    }
}

public class Snacks : Factory
{
    public override string CreateFactory()
    {
        return "snacks available";
    }
}

public class FactoryGoods
{
  public Factory GetDrinks(string fanta)
  {
    if (fanta == "drinks")
    {
        return new Drinks();
    }
    else  if (fanta == "snacks")
    {
        return new Snacks();
    }
    return null;
  }
}