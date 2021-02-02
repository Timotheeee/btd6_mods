using Assets.Scripts.Models;
using Il2CppSystem.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnhollowerBaseLib;

namespace bloonchipper
{
    static class Extensions
    {
		public static Il2CppReferenceArray<T> Add<T>(this Il2CppReferenceArray<T> reference, T newPart) where T : Model
		{
			List<T> list = new List<T>();
			foreach (T item in reference)
			{
				list.Add(item);
			}
			list.Add(newPart);
			return new Il2CppReferenceArray<T>(list.ToArray());
		}

		public static Il2CppReferenceArray<T> Add<T>(this Il2CppReferenceArray<T> reference, List<T> newPart) where T : Model
		{
			List<T> list = new List<T>();
			foreach (T item in reference)
			{
				list.Add(item);
			}
			foreach (T item2 in newPart)
			{
				list.Add(item2);
			}
			return new Il2CppReferenceArray<T>(list.ToArray());
		}
	}
}
