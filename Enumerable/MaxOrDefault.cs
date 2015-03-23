using System;
using System.Collections.Generic;
using System.Linq;


namespace miunet.Extensions.Enumerable
{
	public static partial class EnumerableExtensions
	{
		public static decimal MaxOrDefault( this IEnumerable<decimal> source, decimal defaultValue = default( decimal ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Max();
		}


		public static decimal? MaxOrDefault( this IEnumerable<decimal?> source, decimal? defaultValue = default( decimal? ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Max();
		}


		public static double MaxOrDefault( this IEnumerable<double> source, double defaultValue = default( double ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Max();
		}


		public static double? MaxOrDefault( this IEnumerable<double?> source, double? defaultValue = default( double? ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Max();
		}


		public static TSource MaxOrDefault<TSource>( this IEnumerable<TSource> source, TSource defaultValue = default( TSource ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Max();
		}


		public static int MaxOrDefault( this IEnumerable<int> source, int defaultValue = default( int ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Max();
		}


		public static int? MaxOrDefault( this IEnumerable<int?> source, int? defaultValue = default( int? ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Max();
		}


		public static long MaxOrDefault( this IEnumerable<long> source, long defaultValue = default( long ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Max();
		}


		public static long? MaxOrDefault( this IEnumerable<long?> source, long? defaultValue = default( long? ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Max();
		}


		public static float MaxOrDefault( this IEnumerable<float> source, float defaultValue = default( float ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Max();
		}


		public static float? MaxOrDefault( this IEnumerable<float?> source, float? defaultValue = default( float? ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Max();
		}


		public static decimal MaxOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, decimal> selector, decimal defaultValue = default( decimal ) )
		{
			return source.Any() ? source.Max( selector ) : defaultValue;
		}


		public static double MaxOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, double> selector, double defaultValue = default( double ) )
		{
			return source.Any() ? source.Max( selector ) : defaultValue;
		}


		public static int MaxOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, int> selector, int defaultValue = default( int ) )
		{
			return source.Any() ? source.Max( selector ) : defaultValue;
		}


		public static long MaxOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, long> selector, long defaultValue = default( long ) )
		{
			return source.Any() ? source.Max( selector ) : defaultValue;
		}


		public static decimal? MaxOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, decimal?> selector, decimal? defaultValue = default( decimal? ) )
		{
			return source.Any() ? source.Max( selector ) : defaultValue;
		}


		public static double? MaxOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, double?> selector, double? defaultValue = default( double? ) )
		{
			return source.Any() ? source.Max( selector ) : defaultValue;
		}


		public static int? MaxOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, int?> selector, int? defaultValue = default( int? ) )
		{
			return source.Any() ? source.Max( selector ) : defaultValue;
		}


		public static long? MaxOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, long?> selector, long? defaultValue = default( long? ) )
		{
			return source.Any() ? source.Max( selector ) : defaultValue;
		}


		public static float? MaxOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, float?> selector, float? defaultValue = default( float? ) )
		{
			return source.Any() ? source.Max( selector ) : defaultValue;
		}


		public static float MaxOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, float> selector, float defaultValue = default( float ) )
		{
			return source.Any() ? source.Max( selector ) : defaultValue;
		}


		public static TResult MaxOrDefault<TSource, TResult>( this IEnumerable<TSource> source, Func<TSource, TResult> selector, TResult defaultValue = default( TResult ) )
		{
			return source.Any() ? source.Max( selector ) : defaultValue;
		}
	}
}
