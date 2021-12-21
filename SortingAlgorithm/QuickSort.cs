using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public class QuickSort
    {
        public int[] SortArray(int[] nums)
        {
            return Sort(nums, 0, nums.Length - 1);
        }

        public static int[] Sort(int[] array, int start, int end)
        {
            if (array.Length < 1 || start < 0 || end >= array.Length || start > end)
                return null;

            int zoneIndex = Partition(array, start, end);
            if (zoneIndex > start)
                Sort(array, start, zoneIndex - 1);
            if (zoneIndex < end)
                Sort(array, zoneIndex + 1, end);

            return array;
        }

        
        public static int Partition(int[] array, int start, int end)
        {
            if (start == end)
                return start;

            Random rd = new Random();
            int pivot = (int)(start + rd.Next(end - start + 1));
            int zoneIndex = start - 1;//分区指示器
            Swap(array, pivot, end);
            for (int i = start; i <= end; i++)
            {
                if (array[i] <= array[end])//如果当前元素小于等于基准数时，分区指示器右移一位
                {
                    zoneIndex++;

                    if (i > zoneIndex)//如果当前元素下标大于分区指示器下标，当前元素和分区指示器所指元素交换
                        Swap(array, i, zoneIndex);
                }
            }
            return zoneIndex;
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
