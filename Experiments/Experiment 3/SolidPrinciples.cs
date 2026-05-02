using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Experiments
{
    internal class SolidPrinciples
    {
        //Single responsibility principle
        public int sum(int a, int b) {
            return a + b;
        }

    }
    //Open- close principle
    public interface IShape
    {
        double calculateArea();
    }
    public class Rectangle : IShape {
        double length;
        double breadth;
        public Rectangle(double l,double b)
        {
             length= l;
             breadth = b;
        }
        public double calculateArea() {
            return length * breadth;
        }
    }
    //how to connect .net with adio.net
    //Liskov's Substitution Principle
    class Rect
    {
        protected int width;
        protected int height;

        public Rect(int w, int h)
        {
            width = w;
            height = h;
        }

        public virtual int Width //property
        {
            get { return width; }
            set { width = value; }
        }

        public virtual int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int area()
        {
            return height * width;
        }


    }
    class Square : Rect
    {
        public Square(int size) : base(size, size)
        {

        }

        public override int Width
        {
            get { return base.width; }
            set { base.width = value; }
        }

        public override int Height
        {
            get { return base.height; }
            set { base.height = value; }
        }


    }
    //Interface segregation principle
    interface IVegMenu
    {
        List<String> getVegItems();
    }
    interface INonVegMenu
    {
        List<String> getNonVegItems();
    }
    class VegMenu : IVegMenu
    {
        public List<String> getVegItems()
        {
            return new List<String> { "vegetable curry", "Kaju masala", "Salad" };
        }
    }
    class NonVegMenu : INonVegMenu
    {
        public List<String> getNonVegItems()
        {
            return new List<String> { "Chiken curry ", "Fish curry", "Chilly Chiken" };
        }
    }

    //dependancy inversion principle
    interface IVersionControl
    {
        void commit(string message);
        void push();
        void pull();
    }
    class GitVersionControl : IVersionControl
    {
        public void commit(string message)
        {
            Console.WriteLine("Commiting changes with message: " + message);
        }

        public void push()
        {
            Console.WriteLine("Pushing changes to remote git repository");
        }

        public void pull()
        {
            Console.WriteLine("Pulling changes from remote git repository");
        }
    }

    class DevelopmentTeam
    {
        private IVersionControl vc;

        public DevelopmentTeam(IVersionControl vc1)
        {
            vc = vc1;
        }

        public void makeCommit(string message)
        {
            vc.commit(message);
        }

        public void performPush()
        {
            vc.push();
        }

        public void performPull()
        {
            vc.pull();
        }
    }

}
