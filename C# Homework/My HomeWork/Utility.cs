using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_HomeWork
{
    class Utility
    {

    }
    internal enum Job
    { Tester, Manager, Engineer }
    internal struct Employee
    {
        internal string name;
        internal int age;
        internal DateTime HireDate;
        internal Job JobType;

    }
    internal struct Scores
    {
        internal string name;
        internal int eng;
        internal int mat;
        internal int chi;
    }
    class MyScore
    {
        internal static int SUM(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        internal static int AVG(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }
        internal static int MAX(params int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (max < nums[i])
                { max = nums[i]; }
            }
            return max;
        }
        internal static int MIN(params int[] nums)
        {
            int min = nums[0];
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (min > nums[i])
                { min = nums[i]; }
            }
            return min;
        }
    }
    class photox : System.Windows.Forms.PictureBox
    {
        internal int px;
    }




}
