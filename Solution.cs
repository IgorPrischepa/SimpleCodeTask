
namespace SimpleCodeTask
{
    public class Solution
    {
        public static int[] TaskSolution(string[] hosts, string[] forbiddenHosts)
        {
            HashSet<string> forbiddenHostsHashSet = new HashSet<string>(forbiddenHosts);
            List<int> allowedHostsIndices = new List<int>();

            for (int i = 0; i < hosts.Length; i++)
            {
                string host = hosts[i];
                bool isAllowed = true;

                while (isAllowed && host.Contains('.'))
                {
                    if (forbiddenHostsHashSet.Contains(host))
                    {
                        isAllowed = false;
                    }
                    else
                    {
                        int firstDotIndex = host.IndexOf('.');
                        host = host.Substring(firstDotIndex + 1);
                    }
                }

                if (isAllowed)
                {
                    allowedHostsIndices.Add(i);
                }
            }

            return allowedHostsIndices.ToArray();
        }
    }
}