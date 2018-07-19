using System.Collections.Generic;

namespace Launch
{
    public enum Meat{
        Chicken,
        Beef,
        Turkey
    }

    public enum Bread{
        Wholewheat,
        Normal
    }

    public enum Condiments{
        BBQ,
        Ketchap,
        Mayonnaise
    }

    public class Hamburger
    {
        public Bread bread;
        public bool isToasted;
        public List<Condiments> condiments;
        public Meat meat;

        public Hamburger(Bread bread, bool isToasted, List<Condiments> condiments, Meat meat){
            this.bread = bread;
            this.isToasted = isToasted;
            this.condiments = condiments;
            this.meat = meat;
        }
    }

    public class HamburgerBuilder{
        private Bread bread;
        private bool isToasted;
        private List<Condiments> condiments = new List<Condiments>();
        private Meat meat;

        public HamburgerBuilder Bread(Bread bread){
            this.bread = bread;   
            return this;
        }

        public HamburgerBuilder Meat(Meat meat){
            this.meat = meat;   
            return this;
        }

        public HamburgerBuilder Toasted(bool isToasted){
            this.isToasted = isToasted;
            return this;
        }

        public HamburgerBuilder AddCondiment(Condiments condiment){
            this.condiments.Add(condiment);
            return this;
        }

        public Hamburger Build()
        {
            return new Hamburger(bread, isToasted, condiments, meat);
        }

    }
}

