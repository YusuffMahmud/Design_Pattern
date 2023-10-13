using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment;

public class Builder
{
    public string Water{get;set;}
    public string Cement{get;set;}
    public string Sand{get;set;}

    
}

// Builder Interface
public interface IBuilder
{
    void GetWater();
    void GetCement();
    void GetSand();
    Builder Build();
    
}

// Concrete builder
public class MouldStructure : IBuilder
{
    private Builder builder = new Builder();


    public void GetCement()
    {
        builder.Cement = "Dangote";
    }

    public void GetSand()
    {
       builder.Sand = "Sandy soil";
    }

    public void GetWater()
    {
        builder.Water = "H2O";
    }
    public Builder Build()
    {
        return builder;
    }
}

public class BuilderDirector
{
    public Builder BuildHouse(IBuilder builder)
    {
        builder.GetWater();
        builder.GetCement();
        builder.GetSand();
        return builder.Build();
    }
}