using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeScript
{
	public static class HashFunctions
	{
		public static int NumberHashFn(int key)
		{
			var c2 = 668265261;
			key = (key ^ 61) ^ (key >> 16);
			key = key + (key << 3);
			key = key ^ (key >> 4);
			key = key * c2;
			key = key ^ (key >> 15);
			return key;
		}
		public static int CombineHashes(int key1, int key2)
		{
			return (int)(key2 ^ ((key1 >> 5) + key1));
		}
	}
}
