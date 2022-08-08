using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_9
{
    public partial class Form1 : Form
    {
        static Random Random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        //Enrique Sanchezmurillo
        //CST-150 
        //Activity 9
        //07 AUG 2022
        private void StartButton_Click(object sender, EventArgs e)
        {
            //Displays Sum
            ShowSum(4, 18);
            //Takes 5 doubles and returns average
            double dubAvg = ShowAverage(12.3, 33.1, 45.1, 55.1, 99.1);
            //returns sum of random ints
            int randSum = ShowRanSum();
            //Takes 3 ints and returns true if average is divisible by 3
            Boolean divByThree = ShowSumDivThree(4, 19, 77);
            //Takes 2 strings and displays the shortest
            ShowShortStr("Short", "Longest");
            //Takes array of doubles and returns largest value
            double[] arrayExample = { 33.1, 44.6, 92.1 };
            double largestArrayValue = LargestValue(arrayExample);
            //Creates array of 50 ints
            CreateArray();
            //Takes two booleans and returns true of both are the same
            ShowMatchingBool(true, false);
            //Takes int and double, then displays product
            double product = ShowProduct(4, 5.8);
            //Takes 2D array and returns average of all entries
            int[,] intArray = { { 1, 2, 3 }, { 4, 5, 6 } };
            int avgVal = ReturnArrayAverage(intArray);
            MessageBox.Show(avgVal.ToString());
        }
        //Below we do a basic sum equation
        private void ShowSum(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            MessageBox.Show(sum.ToString());
        }
        //Below we calculate abg
        private double ShowAverage(double numOne, double numTwo, double numThree, double numFour, double numFive)
        {
            double avg = (numOne + numTwo + numThree + numFour + numFive) / 5;
            return avg;
        }
        //Below we create random #'s and calculate the sum
        private int ShowRanSum()
        {
            int randNumOne = Random.Next();
            int randNumTwo = Random.Next();
            int sum = (randNumOne + randNumTwo);
            return sum;
        }
        //Below we take the sum of the three values and use modulus of 3 to check if it is divisible by 3
        private Boolean ShowSumDivThree(int numOne, int numTwo, int numThree)
        {
            int sum = numOne + numTwo + numThree;
            if (sum % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Here we compare the length of both values
        private void ShowShortStr(String strOne, String strTwo)
        {
            String shortestWord;
            if (strOne.Length < strTwo.Length)
            {
                shortestWord = strOne;
            }
            else if (strOne.Length == strTwo.Length)
            {
                shortestWord = strOne + " and " + strTwo + " are both the same length";
            }
            else
            {
                shortestWord = strTwo;
            }
            MessageBox.Show(shortestWord + " is the shortest word.");
        }

        private double LargestValue(double[] dubArray)
        {
            double largestValue = dubArray[0];
            for (int i = 1; i < dubArray.Length; i++)
            {
                if (dubArray[i] > dubArray[i - 1])
                {
                    largestValue = dubArray[i];
                }
            }
            return largestValue;
        }

        private Array CreateArray()
        {
            int[] fiftyArray = new int[50];

            for (int i = 0; i < 50; i++)
            {
                fiftyArray[i] = Random.Next();

            }
            return fiftyArray;
        }

        private Boolean ShowMatchingBool(Boolean valOne, Boolean valTwo)
        {
            if (valOne == valTwo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private double ShowProduct(int valOne, double valTwo)
        {
            double product;
            product = valOne * valTwo;
            return product;
        }

        private int ReturnArrayAverage(int[,] intArray)
        {
            int currVal = 0;

            for (int row = 0; row < intArray.GetLength(0); row++)
            {
                for (int col = 0; col < intArray.GetLength(1); col++)
                {
                    currVal += intArray[row, col];
                }
            }
            int avgVal = currVal / (intArray.GetLength(0) + intArray.GetLength(1));
            return currVal;

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

