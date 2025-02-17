﻿namespace Masa.Docs.Shared.Examples.components.data_tables;

public class Usage : Masa.Docs.Shared.Components.Usage
{
    public Usage() : base(typeof(MDataTable<Dessert>))
    {
    }

    protected override Dictionary<string, object>? GenAdditionalParameters()
    {
        return new Dictionary<string, object>()
        {
            { nameof(MDataTable<Dessert>.Headers), _headers },
            { nameof(MDataTable<Dessert>.Items), _desserts },
            { nameof(MDataTable<Dessert>.ItemsPerPage), 5 },
            { nameof(MDataTable<Dessert>.Class), "elevation-1" },
        };
    }

    public class Dessert
    {
        public string Name { get; set; }

        public int Calories { get; set; }

        public double Fat { get; set; }

        public int Carbs { get; set; }

        public double Protein { get; set; }

        public int Sodium { get; set; }

        public string Calcium { get; set; }

        public string Iron { get; set; }
    }

    private List<DataTableHeader<Dessert>> _headers = new List<DataTableHeader<Dessert>>
        {
           new ()
           {
            Text= "Dessert (100g serving)",
            Align= DataTableHeaderAlign.Start,
            Sortable= false,
            Value= nameof(Dessert.Name)
          },
          new (){ Text= "Calories", Value= nameof(Dessert.Calories)},
          new (){ Text= "Fat (g)", Value= nameof(Dessert.Fat)},
          new (){ Text= "Carbs (g)", Value= nameof(Dessert.Carbs)},
          new (){ Text= "Protein (g)", Value= nameof(Dessert.Protein)},
          new (){ Text= "Iron (%)", Value= nameof(Dessert.Iron) }
        };

    private List<Dessert> _desserts = new List<Dessert>
        {
           new Dessert
           {
              Name= "Frozen Yogurt",
              Calories= 159,
              Fat= 6.0,
              Carbs= 24,
              Protein= 4.0,
              Iron= "1%",
            },
            new Dessert
            {
              Name= "Ice cream sandwich",
              Calories= 237,
              Fat= 9.0,
              Carbs= 37,
              Protein= 4.3,
              Iron= "1%",
            },
            new Dessert
            {
              Name= "Eclair",
              Calories= 262,
              Fat= 16.0,
              Carbs= 23,
              Protein= 6.0,
              Iron= "7%",
            },
            new Dessert
            {
              Name= "Cupcake",
              Calories= 305,
              Fat= 3.7,
              Carbs= 67,
              Protein= 4.3,
              Iron= "8%",
            },
            new Dessert
            {
                Name= "Gingerbread",
                Calories= 356,
                Fat= 16.0,
                Carbs= 49,
                Protein= 3.9,
                Iron= "16%"
            },
            new Dessert
            {
                Name= "Jelly bean",
                Calories= 375,
                Fat= 0.0,
                Carbs= 94,
                Protein= 0.0,
                Iron= "0%",
            },
            new Dessert
            {
                Name= "Lollipop",
                Calories= 392,
                Fat= 0.2,
                Carbs= 98,
                Protein= 0,
                Iron= "2%",
            },
            new Dessert
            {
                Name= "Honeycomb",
                Calories= 408,
                Fat= 3.2,
                Carbs= 87,
                Protein= 6.5,
                Iron= "45%",
            },
            new Dessert
            {
                Name= "Donut",
                Calories= 452,
                Fat= 25.0,
                Carbs= 51,
                Protein= 4.9,
                Iron= "22%",
            },
            new Dessert
            {
                Name= "KitKat",
                Calories= 518,
                Fat= 26.0,
                Carbs= 65,
                Protein= 7,
                Iron= "6%",
            }
        };

}