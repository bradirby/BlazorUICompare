using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;

namespace Client.Shared.SelectBoxDemos
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<City> Cities { get; set; } = new List<City>();

        public State(int id, string name)
        {
            Id = id;
            Name = $"{name} ({id})";
        }

        public static List<State> GetList()
        {
            var stateNum = 100;
            var cityNum = 1;
            var lst = new List<State>();
            var st = new State(stateNum++, "California");
            st.Cities.Add(new City(cityNum++, "San Francisco"));
            st.Cities.Add(new City(cityNum++, "Los Angeles"));
            st.Cities.Add(new City(cityNum++, "Cupertino"));
            lst.Add(st);

            st = new State(stateNum++, "Florida");
            st.Cities.Add(new City(cityNum++, "Miami"));
            st.Cities.Add(new City(cityNum++, "Orlando"));
            st.Cities.Add(new City(cityNum++, "Ft. Lauderdale"));
            lst.Add(st);

            st = new State(stateNum++, "North Carolina");
            st.Cities.Add(new City(cityNum++, "Greensboro"));
            st.Cities.Add(new City(cityNum++, "Raleigh"));
            st.Cities.Add(new City(cityNum++, "Durham"));
            st.Cities.Add(new City(cityNum++, "Chapel Hill"));
            lst.Add(st);

            return lst;
        }
    }

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public City(int id, string name)
        {
            Id = id;
            Name = $"{name} ({id})";
        }
    }
}
