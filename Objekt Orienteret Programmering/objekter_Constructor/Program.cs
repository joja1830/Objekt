using System;

namespace objekter_Constructor
{
    public class Cakes

    {
        public string cakeName = "Birthday Cake";
        public int cakePieces = 20;
        public string cakeButterType = "Vanilla Butter";
        public int cakeCandls = 25;

        public Cakes(string cakeName, int cakePieces, string cakeButterType, int cakeCandls)
        {
            this.cakeName = cakeName;
            this.cakePieces = cakePieces;
            this.cakeButterType = cakeButterType;
            this.cakeCandls = cakeCandls;
        } //cake mycake = new cake("Birthday cake", 20, "Vanilla Butter", 25); 
    }
}
//vi definere vores variabler uden at fylde data i, Det er fordi vores data bliver givet i constructoren når vi opretter objektet.