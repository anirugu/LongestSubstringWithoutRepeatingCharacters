class Solution
{
    public int lengthOfLongestSubstring(String s)
    {
       HashSet<char> vs = new HashSet<char>();
        HashSet<int> v2 = new HashSet<int>();

        for(int i = 0; i < s.Length; i++)
        {
           if(vs.Contains(s[i]))
                v2.Add(i);
            else
            {
                vs.Add(s[i]);
            }
        }
        return v2.Count;
    }
}