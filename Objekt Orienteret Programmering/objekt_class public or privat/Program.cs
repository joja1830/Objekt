using System;
using System.Runtime.CompilerServices;

namespace objekt_class_public_or_privat
{
    class Program
    {
        static void Main(string[] args)
        {
            Cake pices = new Cake();
            Console.WriteLine("I have mad a " + pices.cakeName);
            Console.WriteLine("the cake is mad with " + pices.cakeButterType + "on top");
            //Console.WriteLine("there is" + pices.cakePicesLeft + " on");
            Console.WriteLine("there are " + pices.cakeCandls + " candls on the cake");
        }   
    }
    public class Cake
    {
        public string cakeName = "Birthday Cake";
        private int cakePieces = 20;
        public string cakeButterType = "Vanilla Butter";
        public int cakeCandls = 25;

        public string cakePicesLeft()
        {
            this.cakePieces = cakePieces - 1;
            return string.Format("there is now {0} pieces left\n", cakePieces);
            
        }
     
    }
}
