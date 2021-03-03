using System.Linq;
using Framework.Core.Extensions;

namespace HackerRank.Problems.Arrays
{
    public static class LeftRotation
    {
        public static int[] Execute(int[] a, int d)
        {
            ArrayExtension.Split(a, d, out int[] firstArrayPart, out int[] secondArrayPart);

            var result = secondArrayPart.Concat(firstArrayPart).ToArray();

            return result;
        }
    }
}
