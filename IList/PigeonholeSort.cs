using System;
using System.Collections.Generic;
using System.Linq;

namespace miunet.Extensions.IList
{
	public static partial class IListExtensions
    {
		public static void PigeonholeSort<TItem, TKey>( this IList<TItem> me, Func<TItem, TKey> keySelector )
			where TKey : IEquatable<TKey>, IComparable<TKey>
		{
			var pigeonholes = new Dictionary<TKey, List<TItem>>();

			foreach( var item in me )
			{
				var key = keySelector( item );

				List<TItem> hole;
				if( !pigeonholes.TryGetValue( key, out hole ) )
				{
					hole = new List<TItem>();
					pigeonholes.Add( key, hole );
				}

				hole.Add( item );
			}

			var sortedItems = pigeonholes
				.OrderBy( x => x.Key )
				.SelectMany( x => x.Value, ( parentHole, childItem ) => childItem );

			var resultPushIndex = 0;
			foreach( var item in sortedItems )
			{
				me[resultPushIndex++] = item;
			}
		}
    }
}
