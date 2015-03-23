using System;
using System.Collections.Generic;
using System.Linq;


namespace miunet.Extensions.Enumerable
{
	public static partial class EnumerableExtensions
	{
		public static decimal MinOrDefault( this IEnumerable<decimal> source, decimal defaultValue = default( decimal ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Min();
		}


		public static decimal? MinOrDefault( this IEnumerable<decimal?> source, decimal? defaultValue = default( decimal? ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Min();
		}


		public static double MinOrDefault( this IEnumerable<double> source, double defaultValue = default( double ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Min();
		}


		public static double? MinOrDefault( this IEnumerable<double?> source, double? defaultValue = default( double? ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Min();
		}


		public static TSource MinOrDefault<TSource>( this IEnumerable<TSource> source, TSource defaultValue = default( TSource ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Min();
		}


		public static int MinOrDefault( this IEnumerable<int> source, int defaultValue = default( int ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Min();
		}


		public static int? MinOrDefault( this IEnumerable<int?> source, int? defaultValue = default( int? ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Min();
		}


		public static long MinOrDefault( this IEnumerable<long> source, long defaultValue = default( long ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Min();
		}


		public static long? MinOrDefault( this IEnumerable<long?> source, long? defaultValue = default( long? ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Min();
		}


		public static float MinOrDefault( this IEnumerable<float> source, float defaultValue = default( float ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Min();
		}


		public static float? MinOrDefault( this IEnumerable<float?> source, float? defaultValue = default( float? ) )
		{
			return source.DefaultIfEmpty( defaultValue ).Min();
		}


		public static decimal MinOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, decimal> selector, decimal defaultValue = default( decimal ) )
		{
			return source.Any() ? source.Min( selector ) : defaultValue;
		}


		public static double MinOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, double> selector, double defaultValue = default( double ) )
		{
			return source.Any() ? source.Min( selector ) : defaultValue;
		}


		public static int MinOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, int> selector, int defaultValue = default( int ) )
		{
			return source.Any() ? source.Min( selector ) : defaultValue;
		}


		public static long MinOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, long> selector, long defaultValue = default( long ) )
		{
			return source.Any() ? source.Min( selector ) : defaultValue;
		}


		public static decimal? MinOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, decimal?> selector, decimal? defaultValue = default( decimal? ) )
		{
			return source.Any() ? source.Min( selector ) : defaultValue;
		}


		public static double? MinOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, double?> selector, double? defaultValue = default( double? ) )
		{
			return source.Any() ? source.Min( selector ) : defaultValue;
		}


		public static int? MinOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, int?> selector, int? defaultValue = default( int? ) )
		{
			return source.Any() ? source.Min( selector ) : defaultValue;
		}


		public static long? MinOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, long?> selector, long? defaultValue = default( long? ) )
		{
			return source.Any() ? source.Min( selector ) : defaultValue;
		}


		public static float? MinOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, float?> selector, float? defaultValue = default( float? ) )
		{
			return source.Any() ? source.Min( selector ) : defaultValue;
		}


		public static float MinOrDefault<TSource>( this IEnumerable<TSource> source, Func<TSource, float> selector, float defaultValue = default( float ) )
		{
			return source.Any() ? source.Min( selector ) : defaultValue;
		}


		public static TResult MinOrDefault<TSource, TResult>( this IEnumerable<TSource> source, Func<TSource, TResult> selector, TResult defaultValue = default( TResult ) )
		{
			return source.Any() ? source.Min( selector ) : defaultValue;
		}
	}
}
