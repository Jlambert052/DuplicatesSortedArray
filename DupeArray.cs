namespace Leetcode {
    public class DuplicateArray {
        public int RemoveDupe(int[] nums) {
            int ArrayNum = 0;
            int prevNum = nums[0];
            List<int> ArrayList = new List<int> {};
            ArrayList.AddRange(nums);
            foreach(int i in nums) {
                if(ArrayNum == 0) {
                    ArrayNum ++;
                    continue;
                } else
                if(i == prevNum) {
                    ArrayList.Remove(i);
                }
                prevNum = i;
                ArrayNum++;
            }
            nums = ArrayList.ToArray();
            int ArrayLength = nums.Count();
            System.Console.WriteLine($"{ArrayLength}");
            return ArrayLength;
        }
    }
}