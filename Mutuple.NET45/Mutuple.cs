using System;
using System.Collections;
using System.Collections.Generic;

namespace Mutuples {
	public static class Mutuple
	{
		public static Mutuple<T1> Create<T1>(T1 item1) => new Mutuple<T1>(item1);
		public static Mutuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2) => new Mutuple<T1, T2>(item1, item2);
		public static Mutuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3) => new Mutuple<T1, T2, T3>(item1, item2, item3);
		public static Mutuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4) => new Mutuple<T1, T2, T3, T4>(item1, item2, item3, item4);
		public static Mutuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) => new Mutuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
		public static Mutuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) => new Mutuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) => new Mutuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8>(item1, item2, item3, item4, item5, item6, item7, item8);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(item1, item2, item3, item4, item5, item6, item7, item8, item9);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20, item21);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20, item21, item22);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20, item21, item22, item23);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20, item21, item22, item23, item24);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20, item21, item22, item23, item24, item25);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20, item21, item22, item23, item24, item25, item26);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20, item21, item22, item23, item24, item25, item26, item27);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20, item21, item22, item23, item24, item25, item26, item27, item28);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28, T29 item29) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20, item21, item22, item23, item24, item25, item26, item27, item28, item29);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28, T29 item29, T30 item30) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20, item21, item22, item23, item24, item25, item26, item27, item28, item29, item30);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28, T29 item29, T30 item30, T31 item31) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20, item21, item22, item23, item24, item25, item26, item27, item28, item29, item30, item31);
		public static Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28, T29 item29, T30 item30, T31 item31, T32 item32) => new Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>(item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12, item13, item14, item15, item16, item17, item18, item19, item20, item21, item22, item23, item24, item25, item26, item27, item28, item29, item30, item31, item32);
	}

	public class Mutuple<T1>
	: IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1) { Item1 = item1; }
		public override String ToString() => $"({Item1})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2>
	: Mutuple<T1>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T2 Item2 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2) { Item1 = item1; Item2 = item2; }
		public override String ToString() => $"({Item1}, {Item2})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3>
	: Mutuple<T1, T2>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T3 Item3 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3) { Item1 = item1; Item2 = item2; Item3 = item3; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4>
	: Mutuple<T1, T2, T3>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T4 Item4 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5>
	: Mutuple<T1, T2, T3, T4>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T5 Item5 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6>
	: Mutuple<T1, T2, T3, T4, T5>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T6 Item6 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7>
	: Mutuple<T1, T2, T3, T4, T5, T6>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T7 Item7 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T8 Item8 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T9 Item9 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T10 Item10 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T11 Item11 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T12 Item12 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T13 Item13 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T14 Item14 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T15 Item15 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T16 Item16 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T17 Item17 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T18 Item18 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T19 Item19 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			num = comparer.Compare(Item19, mutuple.Item19);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			if (!comparer.Equals(Item19, mutuple.Item19))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
				if (TypeCache<T19>.IsValueType || !Item19.Equals(null))
					hash = (hash * -1521134295) + Item19.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T20 Item20 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			num = comparer.Compare(Item19, mutuple.Item19);
			if (num != 0)
				return num;
			num = comparer.Compare(Item20, mutuple.Item20);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			if (!comparer.Equals(Item19, mutuple.Item19))
				return false;
			if (!comparer.Equals(Item20, mutuple.Item20))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
				if (TypeCache<T19>.IsValueType || !Item19.Equals(null))
					hash = (hash * -1521134295) + Item19.GetHashCode();
				if (TypeCache<T20>.IsValueType || !Item20.Equals(null))
					hash = (hash * -1521134295) + Item20.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T21 Item21 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			num = comparer.Compare(Item19, mutuple.Item19);
			if (num != 0)
				return num;
			num = comparer.Compare(Item20, mutuple.Item20);
			if (num != 0)
				return num;
			num = comparer.Compare(Item21, mutuple.Item21);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			if (!comparer.Equals(Item19, mutuple.Item19))
				return false;
			if (!comparer.Equals(Item20, mutuple.Item20))
				return false;
			if (!comparer.Equals(Item21, mutuple.Item21))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
				if (TypeCache<T19>.IsValueType || !Item19.Equals(null))
					hash = (hash * -1521134295) + Item19.GetHashCode();
				if (TypeCache<T20>.IsValueType || !Item20.Equals(null))
					hash = (hash * -1521134295) + Item20.GetHashCode();
				if (TypeCache<T21>.IsValueType || !Item21.Equals(null))
					hash = (hash * -1521134295) + Item21.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T22 Item22 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			num = comparer.Compare(Item19, mutuple.Item19);
			if (num != 0)
				return num;
			num = comparer.Compare(Item20, mutuple.Item20);
			if (num != 0)
				return num;
			num = comparer.Compare(Item21, mutuple.Item21);
			if (num != 0)
				return num;
			num = comparer.Compare(Item22, mutuple.Item22);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			if (!comparer.Equals(Item19, mutuple.Item19))
				return false;
			if (!comparer.Equals(Item20, mutuple.Item20))
				return false;
			if (!comparer.Equals(Item21, mutuple.Item21))
				return false;
			if (!comparer.Equals(Item22, mutuple.Item22))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
				if (TypeCache<T19>.IsValueType || !Item19.Equals(null))
					hash = (hash * -1521134295) + Item19.GetHashCode();
				if (TypeCache<T20>.IsValueType || !Item20.Equals(null))
					hash = (hash * -1521134295) + Item20.GetHashCode();
				if (TypeCache<T21>.IsValueType || !Item21.Equals(null))
					hash = (hash * -1521134295) + Item21.GetHashCode();
				if (TypeCache<T22>.IsValueType || !Item22.Equals(null))
					hash = (hash * -1521134295) + Item22.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T23 Item23 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			num = comparer.Compare(Item19, mutuple.Item19);
			if (num != 0)
				return num;
			num = comparer.Compare(Item20, mutuple.Item20);
			if (num != 0)
				return num;
			num = comparer.Compare(Item21, mutuple.Item21);
			if (num != 0)
				return num;
			num = comparer.Compare(Item22, mutuple.Item22);
			if (num != 0)
				return num;
			num = comparer.Compare(Item23, mutuple.Item23);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			if (!comparer.Equals(Item19, mutuple.Item19))
				return false;
			if (!comparer.Equals(Item20, mutuple.Item20))
				return false;
			if (!comparer.Equals(Item21, mutuple.Item21))
				return false;
			if (!comparer.Equals(Item22, mutuple.Item22))
				return false;
			if (!comparer.Equals(Item23, mutuple.Item23))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
				if (TypeCache<T19>.IsValueType || !Item19.Equals(null))
					hash = (hash * -1521134295) + Item19.GetHashCode();
				if (TypeCache<T20>.IsValueType || !Item20.Equals(null))
					hash = (hash * -1521134295) + Item20.GetHashCode();
				if (TypeCache<T21>.IsValueType || !Item21.Equals(null))
					hash = (hash * -1521134295) + Item21.GetHashCode();
				if (TypeCache<T22>.IsValueType || !Item22.Equals(null))
					hash = (hash * -1521134295) + Item22.GetHashCode();
				if (TypeCache<T23>.IsValueType || !Item23.Equals(null))
					hash = (hash * -1521134295) + Item23.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T24 Item24 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			num = comparer.Compare(Item19, mutuple.Item19);
			if (num != 0)
				return num;
			num = comparer.Compare(Item20, mutuple.Item20);
			if (num != 0)
				return num;
			num = comparer.Compare(Item21, mutuple.Item21);
			if (num != 0)
				return num;
			num = comparer.Compare(Item22, mutuple.Item22);
			if (num != 0)
				return num;
			num = comparer.Compare(Item23, mutuple.Item23);
			if (num != 0)
				return num;
			num = comparer.Compare(Item24, mutuple.Item24);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			if (!comparer.Equals(Item19, mutuple.Item19))
				return false;
			if (!comparer.Equals(Item20, mutuple.Item20))
				return false;
			if (!comparer.Equals(Item21, mutuple.Item21))
				return false;
			if (!comparer.Equals(Item22, mutuple.Item22))
				return false;
			if (!comparer.Equals(Item23, mutuple.Item23))
				return false;
			if (!comparer.Equals(Item24, mutuple.Item24))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
				if (TypeCache<T19>.IsValueType || !Item19.Equals(null))
					hash = (hash * -1521134295) + Item19.GetHashCode();
				if (TypeCache<T20>.IsValueType || !Item20.Equals(null))
					hash = (hash * -1521134295) + Item20.GetHashCode();
				if (TypeCache<T21>.IsValueType || !Item21.Equals(null))
					hash = (hash * -1521134295) + Item21.GetHashCode();
				if (TypeCache<T22>.IsValueType || !Item22.Equals(null))
					hash = (hash * -1521134295) + Item22.GetHashCode();
				if (TypeCache<T23>.IsValueType || !Item23.Equals(null))
					hash = (hash * -1521134295) + Item23.GetHashCode();
				if (TypeCache<T24>.IsValueType || !Item24.Equals(null))
					hash = (hash * -1521134295) + Item24.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T25 Item25 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			num = comparer.Compare(Item19, mutuple.Item19);
			if (num != 0)
				return num;
			num = comparer.Compare(Item20, mutuple.Item20);
			if (num != 0)
				return num;
			num = comparer.Compare(Item21, mutuple.Item21);
			if (num != 0)
				return num;
			num = comparer.Compare(Item22, mutuple.Item22);
			if (num != 0)
				return num;
			num = comparer.Compare(Item23, mutuple.Item23);
			if (num != 0)
				return num;
			num = comparer.Compare(Item24, mutuple.Item24);
			if (num != 0)
				return num;
			num = comparer.Compare(Item25, mutuple.Item25);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			if (!comparer.Equals(Item19, mutuple.Item19))
				return false;
			if (!comparer.Equals(Item20, mutuple.Item20))
				return false;
			if (!comparer.Equals(Item21, mutuple.Item21))
				return false;
			if (!comparer.Equals(Item22, mutuple.Item22))
				return false;
			if (!comparer.Equals(Item23, mutuple.Item23))
				return false;
			if (!comparer.Equals(Item24, mutuple.Item24))
				return false;
			if (!comparer.Equals(Item25, mutuple.Item25))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
				if (TypeCache<T19>.IsValueType || !Item19.Equals(null))
					hash = (hash * -1521134295) + Item19.GetHashCode();
				if (TypeCache<T20>.IsValueType || !Item20.Equals(null))
					hash = (hash * -1521134295) + Item20.GetHashCode();
				if (TypeCache<T21>.IsValueType || !Item21.Equals(null))
					hash = (hash * -1521134295) + Item21.GetHashCode();
				if (TypeCache<T22>.IsValueType || !Item22.Equals(null))
					hash = (hash * -1521134295) + Item22.GetHashCode();
				if (TypeCache<T23>.IsValueType || !Item23.Equals(null))
					hash = (hash * -1521134295) + Item23.GetHashCode();
				if (TypeCache<T24>.IsValueType || !Item24.Equals(null))
					hash = (hash * -1521134295) + Item24.GetHashCode();
				if (TypeCache<T25>.IsValueType || !Item25.Equals(null))
					hash = (hash * -1521134295) + Item25.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T26 Item26 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; Item26 = item26; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25}, {Item26})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			num = comparer.Compare(Item19, mutuple.Item19);
			if (num != 0)
				return num;
			num = comparer.Compare(Item20, mutuple.Item20);
			if (num != 0)
				return num;
			num = comparer.Compare(Item21, mutuple.Item21);
			if (num != 0)
				return num;
			num = comparer.Compare(Item22, mutuple.Item22);
			if (num != 0)
				return num;
			num = comparer.Compare(Item23, mutuple.Item23);
			if (num != 0)
				return num;
			num = comparer.Compare(Item24, mutuple.Item24);
			if (num != 0)
				return num;
			num = comparer.Compare(Item25, mutuple.Item25);
			if (num != 0)
				return num;
			num = comparer.Compare(Item26, mutuple.Item26);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			if (!comparer.Equals(Item19, mutuple.Item19))
				return false;
			if (!comparer.Equals(Item20, mutuple.Item20))
				return false;
			if (!comparer.Equals(Item21, mutuple.Item21))
				return false;
			if (!comparer.Equals(Item22, mutuple.Item22))
				return false;
			if (!comparer.Equals(Item23, mutuple.Item23))
				return false;
			if (!comparer.Equals(Item24, mutuple.Item24))
				return false;
			if (!comparer.Equals(Item25, mutuple.Item25))
				return false;
			if (!comparer.Equals(Item26, mutuple.Item26))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
				if (TypeCache<T19>.IsValueType || !Item19.Equals(null))
					hash = (hash * -1521134295) + Item19.GetHashCode();
				if (TypeCache<T20>.IsValueType || !Item20.Equals(null))
					hash = (hash * -1521134295) + Item20.GetHashCode();
				if (TypeCache<T21>.IsValueType || !Item21.Equals(null))
					hash = (hash * -1521134295) + Item21.GetHashCode();
				if (TypeCache<T22>.IsValueType || !Item22.Equals(null))
					hash = (hash * -1521134295) + Item22.GetHashCode();
				if (TypeCache<T23>.IsValueType || !Item23.Equals(null))
					hash = (hash * -1521134295) + Item23.GetHashCode();
				if (TypeCache<T24>.IsValueType || !Item24.Equals(null))
					hash = (hash * -1521134295) + Item24.GetHashCode();
				if (TypeCache<T25>.IsValueType || !Item25.Equals(null))
					hash = (hash * -1521134295) + Item25.GetHashCode();
				if (TypeCache<T26>.IsValueType || !Item26.Equals(null))
					hash = (hash * -1521134295) + Item26.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T27 Item27 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; Item26 = item26; Item27 = item27; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25}, {Item26}, {Item27})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			num = comparer.Compare(Item19, mutuple.Item19);
			if (num != 0)
				return num;
			num = comparer.Compare(Item20, mutuple.Item20);
			if (num != 0)
				return num;
			num = comparer.Compare(Item21, mutuple.Item21);
			if (num != 0)
				return num;
			num = comparer.Compare(Item22, mutuple.Item22);
			if (num != 0)
				return num;
			num = comparer.Compare(Item23, mutuple.Item23);
			if (num != 0)
				return num;
			num = comparer.Compare(Item24, mutuple.Item24);
			if (num != 0)
				return num;
			num = comparer.Compare(Item25, mutuple.Item25);
			if (num != 0)
				return num;
			num = comparer.Compare(Item26, mutuple.Item26);
			if (num != 0)
				return num;
			num = comparer.Compare(Item27, mutuple.Item27);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			if (!comparer.Equals(Item19, mutuple.Item19))
				return false;
			if (!comparer.Equals(Item20, mutuple.Item20))
				return false;
			if (!comparer.Equals(Item21, mutuple.Item21))
				return false;
			if (!comparer.Equals(Item22, mutuple.Item22))
				return false;
			if (!comparer.Equals(Item23, mutuple.Item23))
				return false;
			if (!comparer.Equals(Item24, mutuple.Item24))
				return false;
			if (!comparer.Equals(Item25, mutuple.Item25))
				return false;
			if (!comparer.Equals(Item26, mutuple.Item26))
				return false;
			if (!comparer.Equals(Item27, mutuple.Item27))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
				if (TypeCache<T19>.IsValueType || !Item19.Equals(null))
					hash = (hash * -1521134295) + Item19.GetHashCode();
				if (TypeCache<T20>.IsValueType || !Item20.Equals(null))
					hash = (hash * -1521134295) + Item20.GetHashCode();
				if (TypeCache<T21>.IsValueType || !Item21.Equals(null))
					hash = (hash * -1521134295) + Item21.GetHashCode();
				if (TypeCache<T22>.IsValueType || !Item22.Equals(null))
					hash = (hash * -1521134295) + Item22.GetHashCode();
				if (TypeCache<T23>.IsValueType || !Item23.Equals(null))
					hash = (hash * -1521134295) + Item23.GetHashCode();
				if (TypeCache<T24>.IsValueType || !Item24.Equals(null))
					hash = (hash * -1521134295) + Item24.GetHashCode();
				if (TypeCache<T25>.IsValueType || !Item25.Equals(null))
					hash = (hash * -1521134295) + Item25.GetHashCode();
				if (TypeCache<T26>.IsValueType || !Item26.Equals(null))
					hash = (hash * -1521134295) + Item26.GetHashCode();
				if (TypeCache<T27>.IsValueType || !Item27.Equals(null))
					hash = (hash * -1521134295) + Item27.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T28 Item28 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; Item26 = item26; Item27 = item27; Item28 = item28; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25}, {Item26}, {Item27}, {Item28})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			num = comparer.Compare(Item19, mutuple.Item19);
			if (num != 0)
				return num;
			num = comparer.Compare(Item20, mutuple.Item20);
			if (num != 0)
				return num;
			num = comparer.Compare(Item21, mutuple.Item21);
			if (num != 0)
				return num;
			num = comparer.Compare(Item22, mutuple.Item22);
			if (num != 0)
				return num;
			num = comparer.Compare(Item23, mutuple.Item23);
			if (num != 0)
				return num;
			num = comparer.Compare(Item24, mutuple.Item24);
			if (num != 0)
				return num;
			num = comparer.Compare(Item25, mutuple.Item25);
			if (num != 0)
				return num;
			num = comparer.Compare(Item26, mutuple.Item26);
			if (num != 0)
				return num;
			num = comparer.Compare(Item27, mutuple.Item27);
			if (num != 0)
				return num;
			num = comparer.Compare(Item28, mutuple.Item28);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			if (!comparer.Equals(Item19, mutuple.Item19))
				return false;
			if (!comparer.Equals(Item20, mutuple.Item20))
				return false;
			if (!comparer.Equals(Item21, mutuple.Item21))
				return false;
			if (!comparer.Equals(Item22, mutuple.Item22))
				return false;
			if (!comparer.Equals(Item23, mutuple.Item23))
				return false;
			if (!comparer.Equals(Item24, mutuple.Item24))
				return false;
			if (!comparer.Equals(Item25, mutuple.Item25))
				return false;
			if (!comparer.Equals(Item26, mutuple.Item26))
				return false;
			if (!comparer.Equals(Item27, mutuple.Item27))
				return false;
			if (!comparer.Equals(Item28, mutuple.Item28))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
				if (TypeCache<T19>.IsValueType || !Item19.Equals(null))
					hash = (hash * -1521134295) + Item19.GetHashCode();
				if (TypeCache<T20>.IsValueType || !Item20.Equals(null))
					hash = (hash * -1521134295) + Item20.GetHashCode();
				if (TypeCache<T21>.IsValueType || !Item21.Equals(null))
					hash = (hash * -1521134295) + Item21.GetHashCode();
				if (TypeCache<T22>.IsValueType || !Item22.Equals(null))
					hash = (hash * -1521134295) + Item22.GetHashCode();
				if (TypeCache<T23>.IsValueType || !Item23.Equals(null))
					hash = (hash * -1521134295) + Item23.GetHashCode();
				if (TypeCache<T24>.IsValueType || !Item24.Equals(null))
					hash = (hash * -1521134295) + Item24.GetHashCode();
				if (TypeCache<T25>.IsValueType || !Item25.Equals(null))
					hash = (hash * -1521134295) + Item25.GetHashCode();
				if (TypeCache<T26>.IsValueType || !Item26.Equals(null))
					hash = (hash * -1521134295) + Item26.GetHashCode();
				if (TypeCache<T27>.IsValueType || !Item27.Equals(null))
					hash = (hash * -1521134295) + Item27.GetHashCode();
				if (TypeCache<T28>.IsValueType || !Item28.Equals(null))
					hash = (hash * -1521134295) + Item28.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T29 Item29 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28, T29 item29) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; Item26 = item26; Item27 = item27; Item28 = item28; Item29 = item29; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25}, {Item26}, {Item27}, {Item28}, {Item29})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			num = comparer.Compare(Item19, mutuple.Item19);
			if (num != 0)
				return num;
			num = comparer.Compare(Item20, mutuple.Item20);
			if (num != 0)
				return num;
			num = comparer.Compare(Item21, mutuple.Item21);
			if (num != 0)
				return num;
			num = comparer.Compare(Item22, mutuple.Item22);
			if (num != 0)
				return num;
			num = comparer.Compare(Item23, mutuple.Item23);
			if (num != 0)
				return num;
			num = comparer.Compare(Item24, mutuple.Item24);
			if (num != 0)
				return num;
			num = comparer.Compare(Item25, mutuple.Item25);
			if (num != 0)
				return num;
			num = comparer.Compare(Item26, mutuple.Item26);
			if (num != 0)
				return num;
			num = comparer.Compare(Item27, mutuple.Item27);
			if (num != 0)
				return num;
			num = comparer.Compare(Item28, mutuple.Item28);
			if (num != 0)
				return num;
			num = comparer.Compare(Item29, mutuple.Item29);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			if (!comparer.Equals(Item19, mutuple.Item19))
				return false;
			if (!comparer.Equals(Item20, mutuple.Item20))
				return false;
			if (!comparer.Equals(Item21, mutuple.Item21))
				return false;
			if (!comparer.Equals(Item22, mutuple.Item22))
				return false;
			if (!comparer.Equals(Item23, mutuple.Item23))
				return false;
			if (!comparer.Equals(Item24, mutuple.Item24))
				return false;
			if (!comparer.Equals(Item25, mutuple.Item25))
				return false;
			if (!comparer.Equals(Item26, mutuple.Item26))
				return false;
			if (!comparer.Equals(Item27, mutuple.Item27))
				return false;
			if (!comparer.Equals(Item28, mutuple.Item28))
				return false;
			if (!comparer.Equals(Item29, mutuple.Item29))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
				if (TypeCache<T19>.IsValueType || !Item19.Equals(null))
					hash = (hash * -1521134295) + Item19.GetHashCode();
				if (TypeCache<T20>.IsValueType || !Item20.Equals(null))
					hash = (hash * -1521134295) + Item20.GetHashCode();
				if (TypeCache<T21>.IsValueType || !Item21.Equals(null))
					hash = (hash * -1521134295) + Item21.GetHashCode();
				if (TypeCache<T22>.IsValueType || !Item22.Equals(null))
					hash = (hash * -1521134295) + Item22.GetHashCode();
				if (TypeCache<T23>.IsValueType || !Item23.Equals(null))
					hash = (hash * -1521134295) + Item23.GetHashCode();
				if (TypeCache<T24>.IsValueType || !Item24.Equals(null))
					hash = (hash * -1521134295) + Item24.GetHashCode();
				if (TypeCache<T25>.IsValueType || !Item25.Equals(null))
					hash = (hash * -1521134295) + Item25.GetHashCode();
				if (TypeCache<T26>.IsValueType || !Item26.Equals(null))
					hash = (hash * -1521134295) + Item26.GetHashCode();
				if (TypeCache<T27>.IsValueType || !Item27.Equals(null))
					hash = (hash * -1521134295) + Item27.GetHashCode();
				if (TypeCache<T28>.IsValueType || !Item28.Equals(null))
					hash = (hash * -1521134295) + Item28.GetHashCode();
				if (TypeCache<T29>.IsValueType || !Item29.Equals(null))
					hash = (hash * -1521134295) + Item29.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T30 Item30 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28, T29 item29, T30 item30) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; Item26 = item26; Item27 = item27; Item28 = item28; Item29 = item29; Item30 = item30; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25}, {Item26}, {Item27}, {Item28}, {Item29}, {Item30})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			num = comparer.Compare(Item19, mutuple.Item19);
			if (num != 0)
				return num;
			num = comparer.Compare(Item20, mutuple.Item20);
			if (num != 0)
				return num;
			num = comparer.Compare(Item21, mutuple.Item21);
			if (num != 0)
				return num;
			num = comparer.Compare(Item22, mutuple.Item22);
			if (num != 0)
				return num;
			num = comparer.Compare(Item23, mutuple.Item23);
			if (num != 0)
				return num;
			num = comparer.Compare(Item24, mutuple.Item24);
			if (num != 0)
				return num;
			num = comparer.Compare(Item25, mutuple.Item25);
			if (num != 0)
				return num;
			num = comparer.Compare(Item26, mutuple.Item26);
			if (num != 0)
				return num;
			num = comparer.Compare(Item27, mutuple.Item27);
			if (num != 0)
				return num;
			num = comparer.Compare(Item28, mutuple.Item28);
			if (num != 0)
				return num;
			num = comparer.Compare(Item29, mutuple.Item29);
			if (num != 0)
				return num;
			num = comparer.Compare(Item30, mutuple.Item30);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			if (!comparer.Equals(Item19, mutuple.Item19))
				return false;
			if (!comparer.Equals(Item20, mutuple.Item20))
				return false;
			if (!comparer.Equals(Item21, mutuple.Item21))
				return false;
			if (!comparer.Equals(Item22, mutuple.Item22))
				return false;
			if (!comparer.Equals(Item23, mutuple.Item23))
				return false;
			if (!comparer.Equals(Item24, mutuple.Item24))
				return false;
			if (!comparer.Equals(Item25, mutuple.Item25))
				return false;
			if (!comparer.Equals(Item26, mutuple.Item26))
				return false;
			if (!comparer.Equals(Item27, mutuple.Item27))
				return false;
			if (!comparer.Equals(Item28, mutuple.Item28))
				return false;
			if (!comparer.Equals(Item29, mutuple.Item29))
				return false;
			if (!comparer.Equals(Item30, mutuple.Item30))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
				if (TypeCache<T19>.IsValueType || !Item19.Equals(null))
					hash = (hash * -1521134295) + Item19.GetHashCode();
				if (TypeCache<T20>.IsValueType || !Item20.Equals(null))
					hash = (hash * -1521134295) + Item20.GetHashCode();
				if (TypeCache<T21>.IsValueType || !Item21.Equals(null))
					hash = (hash * -1521134295) + Item21.GetHashCode();
				if (TypeCache<T22>.IsValueType || !Item22.Equals(null))
					hash = (hash * -1521134295) + Item22.GetHashCode();
				if (TypeCache<T23>.IsValueType || !Item23.Equals(null))
					hash = (hash * -1521134295) + Item23.GetHashCode();
				if (TypeCache<T24>.IsValueType || !Item24.Equals(null))
					hash = (hash * -1521134295) + Item24.GetHashCode();
				if (TypeCache<T25>.IsValueType || !Item25.Equals(null))
					hash = (hash * -1521134295) + Item25.GetHashCode();
				if (TypeCache<T26>.IsValueType || !Item26.Equals(null))
					hash = (hash * -1521134295) + Item26.GetHashCode();
				if (TypeCache<T27>.IsValueType || !Item27.Equals(null))
					hash = (hash * -1521134295) + Item27.GetHashCode();
				if (TypeCache<T28>.IsValueType || !Item28.Equals(null))
					hash = (hash * -1521134295) + Item28.GetHashCode();
				if (TypeCache<T29>.IsValueType || !Item29.Equals(null))
					hash = (hash * -1521134295) + Item29.GetHashCode();
				if (TypeCache<T30>.IsValueType || !Item30.Equals(null))
					hash = (hash * -1521134295) + Item30.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T31 Item31 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28, T29 item29, T30 item30, T31 item31) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; Item26 = item26; Item27 = item27; Item28 = item28; Item29 = item29; Item30 = item30; Item31 = item31; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25}, {Item26}, {Item27}, {Item28}, {Item29}, {Item30}, {Item31})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			num = comparer.Compare(Item19, mutuple.Item19);
			if (num != 0)
				return num;
			num = comparer.Compare(Item20, mutuple.Item20);
			if (num != 0)
				return num;
			num = comparer.Compare(Item21, mutuple.Item21);
			if (num != 0)
				return num;
			num = comparer.Compare(Item22, mutuple.Item22);
			if (num != 0)
				return num;
			num = comparer.Compare(Item23, mutuple.Item23);
			if (num != 0)
				return num;
			num = comparer.Compare(Item24, mutuple.Item24);
			if (num != 0)
				return num;
			num = comparer.Compare(Item25, mutuple.Item25);
			if (num != 0)
				return num;
			num = comparer.Compare(Item26, mutuple.Item26);
			if (num != 0)
				return num;
			num = comparer.Compare(Item27, mutuple.Item27);
			if (num != 0)
				return num;
			num = comparer.Compare(Item28, mutuple.Item28);
			if (num != 0)
				return num;
			num = comparer.Compare(Item29, mutuple.Item29);
			if (num != 0)
				return num;
			num = comparer.Compare(Item30, mutuple.Item30);
			if (num != 0)
				return num;
			num = comparer.Compare(Item31, mutuple.Item31);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			if (!comparer.Equals(Item19, mutuple.Item19))
				return false;
			if (!comparer.Equals(Item20, mutuple.Item20))
				return false;
			if (!comparer.Equals(Item21, mutuple.Item21))
				return false;
			if (!comparer.Equals(Item22, mutuple.Item22))
				return false;
			if (!comparer.Equals(Item23, mutuple.Item23))
				return false;
			if (!comparer.Equals(Item24, mutuple.Item24))
				return false;
			if (!comparer.Equals(Item25, mutuple.Item25))
				return false;
			if (!comparer.Equals(Item26, mutuple.Item26))
				return false;
			if (!comparer.Equals(Item27, mutuple.Item27))
				return false;
			if (!comparer.Equals(Item28, mutuple.Item28))
				return false;
			if (!comparer.Equals(Item29, mutuple.Item29))
				return false;
			if (!comparer.Equals(Item30, mutuple.Item30))
				return false;
			if (!comparer.Equals(Item31, mutuple.Item31))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
				if (TypeCache<T19>.IsValueType || !Item19.Equals(null))
					hash = (hash * -1521134295) + Item19.GetHashCode();
				if (TypeCache<T20>.IsValueType || !Item20.Equals(null))
					hash = (hash * -1521134295) + Item20.GetHashCode();
				if (TypeCache<T21>.IsValueType || !Item21.Equals(null))
					hash = (hash * -1521134295) + Item21.GetHashCode();
				if (TypeCache<T22>.IsValueType || !Item22.Equals(null))
					hash = (hash * -1521134295) + Item22.GetHashCode();
				if (TypeCache<T23>.IsValueType || !Item23.Equals(null))
					hash = (hash * -1521134295) + Item23.GetHashCode();
				if (TypeCache<T24>.IsValueType || !Item24.Equals(null))
					hash = (hash * -1521134295) + Item24.GetHashCode();
				if (TypeCache<T25>.IsValueType || !Item25.Equals(null))
					hash = (hash * -1521134295) + Item25.GetHashCode();
				if (TypeCache<T26>.IsValueType || !Item26.Equals(null))
					hash = (hash * -1521134295) + Item26.GetHashCode();
				if (TypeCache<T27>.IsValueType || !Item27.Equals(null))
					hash = (hash * -1521134295) + Item27.GetHashCode();
				if (TypeCache<T28>.IsValueType || !Item28.Equals(null))
					hash = (hash * -1521134295) + Item28.GetHashCode();
				if (TypeCache<T29>.IsValueType || !Item29.Equals(null))
					hash = (hash * -1521134295) + Item29.GetHashCode();
				if (TypeCache<T30>.IsValueType || !Item30.Equals(null))
					hash = (hash * -1521134295) + Item30.GetHashCode();
				if (TypeCache<T31>.IsValueType || !Item31.Equals(null))
					hash = (hash * -1521134295) + Item31.GetHashCode();
			}
			return hash;
		}
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>
	: Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T32 Item32 { get; set; }
		protected Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28, T29 item29, T30 item30, T31 item31, T32 item32) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; Item26 = item26; Item27 = item27; Item28 = item28; Item29 = item29; Item30 = item30; Item31 = item31; Item32 = item32; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25}, {Item26}, {Item27}, {Item28}, {Item29}, {Item30}, {Item31}, {Item32})";

		public override Boolean Equals(Object obj) => ((IStructuralEquatable) this).Equals(obj, EqualityComparer<Object>.Default);
		public override Int32 GetHashCode() => ((IStructuralEquatable) this).GetHashCode(EqualityComparer<Object>.Default);
		
		Int32 IComparable.CompareTo(Object obj) => ((IStructuralComparable) this).CompareTo(obj, Comparer<Object>.Default);
		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>;
			if (mutuple == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>`", nameof(other));
			Int32 num;
			num = comparer.Compare(Item1, mutuple.Item1);
			if (num != 0)
				return num;
			num = comparer.Compare(Item2, mutuple.Item2);
			if (num != 0)
				return num;
			num = comparer.Compare(Item3, mutuple.Item3);
			if (num != 0)
				return num;
			num = comparer.Compare(Item4, mutuple.Item4);
			if (num != 0)
				return num;
			num = comparer.Compare(Item5, mutuple.Item5);
			if (num != 0)
				return num;
			num = comparer.Compare(Item6, mutuple.Item6);
			if (num != 0)
				return num;
			num = comparer.Compare(Item7, mutuple.Item7);
			if (num != 0)
				return num;
			num = comparer.Compare(Item8, mutuple.Item8);
			if (num != 0)
				return num;
			num = comparer.Compare(Item9, mutuple.Item9);
			if (num != 0)
				return num;
			num = comparer.Compare(Item10, mutuple.Item10);
			if (num != 0)
				return num;
			num = comparer.Compare(Item11, mutuple.Item11);
			if (num != 0)
				return num;
			num = comparer.Compare(Item12, mutuple.Item12);
			if (num != 0)
				return num;
			num = comparer.Compare(Item13, mutuple.Item13);
			if (num != 0)
				return num;
			num = comparer.Compare(Item14, mutuple.Item14);
			if (num != 0)
				return num;
			num = comparer.Compare(Item15, mutuple.Item15);
			if (num != 0)
				return num;
			num = comparer.Compare(Item16, mutuple.Item16);
			if (num != 0)
				return num;
			num = comparer.Compare(Item17, mutuple.Item17);
			if (num != 0)
				return num;
			num = comparer.Compare(Item18, mutuple.Item18);
			if (num != 0)
				return num;
			num = comparer.Compare(Item19, mutuple.Item19);
			if (num != 0)
				return num;
			num = comparer.Compare(Item20, mutuple.Item20);
			if (num != 0)
				return num;
			num = comparer.Compare(Item21, mutuple.Item21);
			if (num != 0)
				return num;
			num = comparer.Compare(Item22, mutuple.Item22);
			if (num != 0)
				return num;
			num = comparer.Compare(Item23, mutuple.Item23);
			if (num != 0)
				return num;
			num = comparer.Compare(Item24, mutuple.Item24);
			if (num != 0)
				return num;
			num = comparer.Compare(Item25, mutuple.Item25);
			if (num != 0)
				return num;
			num = comparer.Compare(Item26, mutuple.Item26);
			if (num != 0)
				return num;
			num = comparer.Compare(Item27, mutuple.Item27);
			if (num != 0)
				return num;
			num = comparer.Compare(Item28, mutuple.Item28);
			if (num != 0)
				return num;
			num = comparer.Compare(Item29, mutuple.Item29);
			if (num != 0)
				return num;
			num = comparer.Compare(Item30, mutuple.Item30);
			if (num != 0)
				return num;
			num = comparer.Compare(Item31, mutuple.Item31);
			if (num != 0)
				return num;
			num = comparer.Compare(Item32, mutuple.Item32);
			if (num != 0)
				return num;
			return num;
		}
		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return false;
			var mutuple = other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>;
			if (mutuple == null)
				return false;
			if (!comparer.Equals(Item1, mutuple.Item1))
				return false;
			if (!comparer.Equals(Item2, mutuple.Item2))
				return false;
			if (!comparer.Equals(Item3, mutuple.Item3))
				return false;
			if (!comparer.Equals(Item4, mutuple.Item4))
				return false;
			if (!comparer.Equals(Item5, mutuple.Item5))
				return false;
			if (!comparer.Equals(Item6, mutuple.Item6))
				return false;
			if (!comparer.Equals(Item7, mutuple.Item7))
				return false;
			if (!comparer.Equals(Item8, mutuple.Item8))
				return false;
			if (!comparer.Equals(Item9, mutuple.Item9))
				return false;
			if (!comparer.Equals(Item10, mutuple.Item10))
				return false;
			if (!comparer.Equals(Item11, mutuple.Item11))
				return false;
			if (!comparer.Equals(Item12, mutuple.Item12))
				return false;
			if (!comparer.Equals(Item13, mutuple.Item13))
				return false;
			if (!comparer.Equals(Item14, mutuple.Item14))
				return false;
			if (!comparer.Equals(Item15, mutuple.Item15))
				return false;
			if (!comparer.Equals(Item16, mutuple.Item16))
				return false;
			if (!comparer.Equals(Item17, mutuple.Item17))
				return false;
			if (!comparer.Equals(Item18, mutuple.Item18))
				return false;
			if (!comparer.Equals(Item19, mutuple.Item19))
				return false;
			if (!comparer.Equals(Item20, mutuple.Item20))
				return false;
			if (!comparer.Equals(Item21, mutuple.Item21))
				return false;
			if (!comparer.Equals(Item22, mutuple.Item22))
				return false;
			if (!comparer.Equals(Item23, mutuple.Item23))
				return false;
			if (!comparer.Equals(Item24, mutuple.Item24))
				return false;
			if (!comparer.Equals(Item25, mutuple.Item25))
				return false;
			if (!comparer.Equals(Item26, mutuple.Item26))
				return false;
			if (!comparer.Equals(Item27, mutuple.Item27))
				return false;
			if (!comparer.Equals(Item28, mutuple.Item28))
				return false;
			if (!comparer.Equals(Item29, mutuple.Item29))
				return false;
			if (!comparer.Equals(Item30, mutuple.Item30))
				return false;
			if (!comparer.Equals(Item31, mutuple.Item31))
				return false;
			if (!comparer.Equals(Item32, mutuple.Item32))
				return false;
			return true;
		}
		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !Item1.Equals(null))
					hash = (hash * -1521134295) + Item1.GetHashCode();
				if (TypeCache<T2>.IsValueType || !Item2.Equals(null))
					hash = (hash * -1521134295) + Item2.GetHashCode();
				if (TypeCache<T3>.IsValueType || !Item3.Equals(null))
					hash = (hash * -1521134295) + Item3.GetHashCode();
				if (TypeCache<T4>.IsValueType || !Item4.Equals(null))
					hash = (hash * -1521134295) + Item4.GetHashCode();
				if (TypeCache<T5>.IsValueType || !Item5.Equals(null))
					hash = (hash * -1521134295) + Item5.GetHashCode();
				if (TypeCache<T6>.IsValueType || !Item6.Equals(null))
					hash = (hash * -1521134295) + Item6.GetHashCode();
				if (TypeCache<T7>.IsValueType || !Item7.Equals(null))
					hash = (hash * -1521134295) + Item7.GetHashCode();
				if (TypeCache<T8>.IsValueType || !Item8.Equals(null))
					hash = (hash * -1521134295) + Item8.GetHashCode();
				if (TypeCache<T9>.IsValueType || !Item9.Equals(null))
					hash = (hash * -1521134295) + Item9.GetHashCode();
				if (TypeCache<T10>.IsValueType || !Item10.Equals(null))
					hash = (hash * -1521134295) + Item10.GetHashCode();
				if (TypeCache<T11>.IsValueType || !Item11.Equals(null))
					hash = (hash * -1521134295) + Item11.GetHashCode();
				if (TypeCache<T12>.IsValueType || !Item12.Equals(null))
					hash = (hash * -1521134295) + Item12.GetHashCode();
				if (TypeCache<T13>.IsValueType || !Item13.Equals(null))
					hash = (hash * -1521134295) + Item13.GetHashCode();
				if (TypeCache<T14>.IsValueType || !Item14.Equals(null))
					hash = (hash * -1521134295) + Item14.GetHashCode();
				if (TypeCache<T15>.IsValueType || !Item15.Equals(null))
					hash = (hash * -1521134295) + Item15.GetHashCode();
				if (TypeCache<T16>.IsValueType || !Item16.Equals(null))
					hash = (hash * -1521134295) + Item16.GetHashCode();
				if (TypeCache<T17>.IsValueType || !Item17.Equals(null))
					hash = (hash * -1521134295) + Item17.GetHashCode();
				if (TypeCache<T18>.IsValueType || !Item18.Equals(null))
					hash = (hash * -1521134295) + Item18.GetHashCode();
				if (TypeCache<T19>.IsValueType || !Item19.Equals(null))
					hash = (hash * -1521134295) + Item19.GetHashCode();
				if (TypeCache<T20>.IsValueType || !Item20.Equals(null))
					hash = (hash * -1521134295) + Item20.GetHashCode();
				if (TypeCache<T21>.IsValueType || !Item21.Equals(null))
					hash = (hash * -1521134295) + Item21.GetHashCode();
				if (TypeCache<T22>.IsValueType || !Item22.Equals(null))
					hash = (hash * -1521134295) + Item22.GetHashCode();
				if (TypeCache<T23>.IsValueType || !Item23.Equals(null))
					hash = (hash * -1521134295) + Item23.GetHashCode();
				if (TypeCache<T24>.IsValueType || !Item24.Equals(null))
					hash = (hash * -1521134295) + Item24.GetHashCode();
				if (TypeCache<T25>.IsValueType || !Item25.Equals(null))
					hash = (hash * -1521134295) + Item25.GetHashCode();
				if (TypeCache<T26>.IsValueType || !Item26.Equals(null))
					hash = (hash * -1521134295) + Item26.GetHashCode();
				if (TypeCache<T27>.IsValueType || !Item27.Equals(null))
					hash = (hash * -1521134295) + Item27.GetHashCode();
				if (TypeCache<T28>.IsValueType || !Item28.Equals(null))
					hash = (hash * -1521134295) + Item28.GetHashCode();
				if (TypeCache<T29>.IsValueType || !Item29.Equals(null))
					hash = (hash * -1521134295) + Item29.GetHashCode();
				if (TypeCache<T30>.IsValueType || !Item30.Equals(null))
					hash = (hash * -1521134295) + Item30.GetHashCode();
				if (TypeCache<T31>.IsValueType || !Item31.Equals(null))
					hash = (hash * -1521134295) + Item31.GetHashCode();
				if (TypeCache<T32>.IsValueType || !Item32.Equals(null))
					hash = (hash * -1521134295) + Item32.GetHashCode();
			}
			return hash;
		}
	}

}