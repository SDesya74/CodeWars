
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars {
	class Kata {
		public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) {
			return iterable.Where((e, i) => i == 0 || !iterable.ElementAt(i - 1).Equals(e));
		}

		public static int Find(int[] integers) {
			return integers.GroupBy(e => e % 2).OrderBy(g => g.Count()).First().First();
		}

		public static ulong[] productFib(ulong prod) {
			ulong f1 = 0, f2 = 1;
			while (f1 * f2 < prod) (f1, f2) = (f2, f1 + f2);
			return new ulong[] { f1, f2, f1 * f2 == prod ? 1ul : 0ul };
		}
	}
}
