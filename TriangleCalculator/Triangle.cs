using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalculator
{
    class Triangle
    {
        private int sideA;
        private int sideB;
        private int sideC;
        private double angleA;
        private double angleB;
        private double angleC;
        private bool isValid;

        public Triangle(int sideA, int sideB, int sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;

            this.isValid = checkIsValid();

        }

        public bool getIsValid()
        {
            return this.isValid;
        }

        private bool checkIsValid()
        {
            if(this.sideA + this.sideB > this.sideC && this.sideA + this.sideC > this.sideB && this.sideB + this.sideC > this.sideA)
            {
                //if valid, lets calculate
                this.calculateAngles();
                return true;
            }

            return false;
        }

        public string getSideClass()
        {
            if(this.sideA == this.sideB && this.sideB == this.sideC)
            {
                return "equilateral";
            }else if (this.sideA == this.sideB || this.sideB == this.sideC || this.sideA == this.sideC)
            {
                return "isosceles";
            }else
            {
                return "scalene";
            }
        }

        public string getAngleClass()
        {
            if(this.angleA == 90 || this.angleB == 90 || this.angleC == 90)
            {
                return "right";
            }else if(this.angleA < 90 && this.angleB < 90 && this.angleC < 90)
            {
                return "acute";
            }else if (this.angleA > 90 || this.angleB > 90 || this.angleC > 90)
            {
                return "obtuse";
            }
            return "";
        }

        private void calculateAngles()
        {
            this.angleA = calculateAngleHelper(this.sideA, this.sideB, this.sideC);
            this.angleB = calculateAngleHelper(this.sideB, this.sideA, this.sideC);
            this.angleC = 180 - this.angleA - this.angleB; //For Tanner :)
        }

        private double calculateAngleHelper(int sideA, int sideB, int sideC)
        {
            double angle = Math.Acos((Math.Pow(sideB,2) + Math.Pow(sideC,2) - Math.Pow(sideA,2)) / (2*sideB*sideC));

            return Math.Round(angle * 57.2958,2);
        }

        public double getAngleA()
        {
            return this.angleA;
        }

        public double getAngleB()
        {
            return this.angleB;
        }

        public double getAngleC()
        {
            return this.angleC;
        }
    }
}
