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

	public class Mutuple<T1> : IEquatable<Mutuple<T1>>, IComparable<Mutuple<T1>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1) { Item1 = item1; }
		public override String ToString() => $"({Item1})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1>);

		public Boolean Equals(Mutuple<T1> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1>, comparer);
		}

		private Boolean Equals(Mutuple<T1> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1>, null);
		}

		Int32 IComparable<Mutuple<T1>>.CompareTo(Mutuple<T1> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2> : IEquatable<Mutuple<T1, T2>>, IComparable<Mutuple<T1, T2>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2) { Item1 = item1; Item2 = item2; }
		public override String ToString() => $"({Item1}, {Item2})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2>);

		public Boolean Equals(Mutuple<T1, T2> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2>, null);
		}

		Int32 IComparable<Mutuple<T1, T2>>.CompareTo(Mutuple<T1, T2> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3> : IEquatable<Mutuple<T1, T2, T3>>, IComparable<Mutuple<T1, T2, T3>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3) { Item1 = item1; Item2 = item2; Item3 = item3; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3>);

		public Boolean Equals(Mutuple<T1, T2, T3> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3>>.CompareTo(Mutuple<T1, T2, T3> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4> : IEquatable<Mutuple<T1, T2, T3, T4>>, IComparable<Mutuple<T1, T2, T3, T4>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4>>.CompareTo(Mutuple<T1, T2, T3, T4> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5> : IEquatable<Mutuple<T1, T2, T3, T4, T5>>, IComparable<Mutuple<T1, T2, T3, T4, T5>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5>>.CompareTo(Mutuple<T1, T2, T3, T4, T5> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
				if (TypeCache<T19>.IsValueType || !ReferenceEquals(Item19, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item19) ?? EqualityComparer<T19>.Default.GetHashCode(Item19));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			if (!(comparer?.Equals(Item19, other.Item19) ?? EqualityComparer<T19>.Default.Equals(Item19, other.Item19)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item19, other.Item19) ?? Comparer<T19>.Default.Compare(Item19, other.Item19);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
				if (TypeCache<T19>.IsValueType || !ReferenceEquals(Item19, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item19) ?? EqualityComparer<T19>.Default.GetHashCode(Item19));
				if (TypeCache<T20>.IsValueType || !ReferenceEquals(Item20, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item20) ?? EqualityComparer<T20>.Default.GetHashCode(Item20));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			if (!(comparer?.Equals(Item19, other.Item19) ?? EqualityComparer<T19>.Default.Equals(Item19, other.Item19)))
				return false;
			if (!(comparer?.Equals(Item20, other.Item20) ?? EqualityComparer<T20>.Default.Equals(Item20, other.Item20)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item19, other.Item19) ?? Comparer<T19>.Default.Compare(Item19, other.Item19);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item20, other.Item20) ?? Comparer<T20>.Default.Compare(Item20, other.Item20);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
				if (TypeCache<T19>.IsValueType || !ReferenceEquals(Item19, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item19) ?? EqualityComparer<T19>.Default.GetHashCode(Item19));
				if (TypeCache<T20>.IsValueType || !ReferenceEquals(Item20, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item20) ?? EqualityComparer<T20>.Default.GetHashCode(Item20));
				if (TypeCache<T21>.IsValueType || !ReferenceEquals(Item21, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item21) ?? EqualityComparer<T21>.Default.GetHashCode(Item21));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			if (!(comparer?.Equals(Item19, other.Item19) ?? EqualityComparer<T19>.Default.Equals(Item19, other.Item19)))
				return false;
			if (!(comparer?.Equals(Item20, other.Item20) ?? EqualityComparer<T20>.Default.Equals(Item20, other.Item20)))
				return false;
			if (!(comparer?.Equals(Item21, other.Item21) ?? EqualityComparer<T21>.Default.Equals(Item21, other.Item21)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item19, other.Item19) ?? Comparer<T19>.Default.Compare(Item19, other.Item19);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item20, other.Item20) ?? Comparer<T20>.Default.Compare(Item20, other.Item20);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item21, other.Item21) ?? Comparer<T21>.Default.Compare(Item21, other.Item21);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
				if (TypeCache<T19>.IsValueType || !ReferenceEquals(Item19, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item19) ?? EqualityComparer<T19>.Default.GetHashCode(Item19));
				if (TypeCache<T20>.IsValueType || !ReferenceEquals(Item20, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item20) ?? EqualityComparer<T20>.Default.GetHashCode(Item20));
				if (TypeCache<T21>.IsValueType || !ReferenceEquals(Item21, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item21) ?? EqualityComparer<T21>.Default.GetHashCode(Item21));
				if (TypeCache<T22>.IsValueType || !ReferenceEquals(Item22, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item22) ?? EqualityComparer<T22>.Default.GetHashCode(Item22));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			if (!(comparer?.Equals(Item19, other.Item19) ?? EqualityComparer<T19>.Default.Equals(Item19, other.Item19)))
				return false;
			if (!(comparer?.Equals(Item20, other.Item20) ?? EqualityComparer<T20>.Default.Equals(Item20, other.Item20)))
				return false;
			if (!(comparer?.Equals(Item21, other.Item21) ?? EqualityComparer<T21>.Default.Equals(Item21, other.Item21)))
				return false;
			if (!(comparer?.Equals(Item22, other.Item22) ?? EqualityComparer<T22>.Default.Equals(Item22, other.Item22)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item19, other.Item19) ?? Comparer<T19>.Default.Compare(Item19, other.Item19);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item20, other.Item20) ?? Comparer<T20>.Default.Compare(Item20, other.Item20);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item21, other.Item21) ?? Comparer<T21>.Default.Compare(Item21, other.Item21);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item22, other.Item22) ?? Comparer<T22>.Default.Compare(Item22, other.Item22);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
				if (TypeCache<T19>.IsValueType || !ReferenceEquals(Item19, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item19) ?? EqualityComparer<T19>.Default.GetHashCode(Item19));
				if (TypeCache<T20>.IsValueType || !ReferenceEquals(Item20, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item20) ?? EqualityComparer<T20>.Default.GetHashCode(Item20));
				if (TypeCache<T21>.IsValueType || !ReferenceEquals(Item21, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item21) ?? EqualityComparer<T21>.Default.GetHashCode(Item21));
				if (TypeCache<T22>.IsValueType || !ReferenceEquals(Item22, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item22) ?? EqualityComparer<T22>.Default.GetHashCode(Item22));
				if (TypeCache<T23>.IsValueType || !ReferenceEquals(Item23, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item23) ?? EqualityComparer<T23>.Default.GetHashCode(Item23));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			if (!(comparer?.Equals(Item19, other.Item19) ?? EqualityComparer<T19>.Default.Equals(Item19, other.Item19)))
				return false;
			if (!(comparer?.Equals(Item20, other.Item20) ?? EqualityComparer<T20>.Default.Equals(Item20, other.Item20)))
				return false;
			if (!(comparer?.Equals(Item21, other.Item21) ?? EqualityComparer<T21>.Default.Equals(Item21, other.Item21)))
				return false;
			if (!(comparer?.Equals(Item22, other.Item22) ?? EqualityComparer<T22>.Default.Equals(Item22, other.Item22)))
				return false;
			if (!(comparer?.Equals(Item23, other.Item23) ?? EqualityComparer<T23>.Default.Equals(Item23, other.Item23)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item19, other.Item19) ?? Comparer<T19>.Default.Compare(Item19, other.Item19);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item20, other.Item20) ?? Comparer<T20>.Default.Compare(Item20, other.Item20);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item21, other.Item21) ?? Comparer<T21>.Default.Compare(Item21, other.Item21);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item22, other.Item22) ?? Comparer<T22>.Default.Compare(Item22, other.Item22);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item23, other.Item23) ?? Comparer<T23>.Default.Compare(Item23, other.Item23);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
				if (TypeCache<T19>.IsValueType || !ReferenceEquals(Item19, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item19) ?? EqualityComparer<T19>.Default.GetHashCode(Item19));
				if (TypeCache<T20>.IsValueType || !ReferenceEquals(Item20, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item20) ?? EqualityComparer<T20>.Default.GetHashCode(Item20));
				if (TypeCache<T21>.IsValueType || !ReferenceEquals(Item21, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item21) ?? EqualityComparer<T21>.Default.GetHashCode(Item21));
				if (TypeCache<T22>.IsValueType || !ReferenceEquals(Item22, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item22) ?? EqualityComparer<T22>.Default.GetHashCode(Item22));
				if (TypeCache<T23>.IsValueType || !ReferenceEquals(Item23, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item23) ?? EqualityComparer<T23>.Default.GetHashCode(Item23));
				if (TypeCache<T24>.IsValueType || !ReferenceEquals(Item24, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item24) ?? EqualityComparer<T24>.Default.GetHashCode(Item24));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			if (!(comparer?.Equals(Item19, other.Item19) ?? EqualityComparer<T19>.Default.Equals(Item19, other.Item19)))
				return false;
			if (!(comparer?.Equals(Item20, other.Item20) ?? EqualityComparer<T20>.Default.Equals(Item20, other.Item20)))
				return false;
			if (!(comparer?.Equals(Item21, other.Item21) ?? EqualityComparer<T21>.Default.Equals(Item21, other.Item21)))
				return false;
			if (!(comparer?.Equals(Item22, other.Item22) ?? EqualityComparer<T22>.Default.Equals(Item22, other.Item22)))
				return false;
			if (!(comparer?.Equals(Item23, other.Item23) ?? EqualityComparer<T23>.Default.Equals(Item23, other.Item23)))
				return false;
			if (!(comparer?.Equals(Item24, other.Item24) ?? EqualityComparer<T24>.Default.Equals(Item24, other.Item24)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item19, other.Item19) ?? Comparer<T19>.Default.Compare(Item19, other.Item19);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item20, other.Item20) ?? Comparer<T20>.Default.Compare(Item20, other.Item20);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item21, other.Item21) ?? Comparer<T21>.Default.Compare(Item21, other.Item21);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item22, other.Item22) ?? Comparer<T22>.Default.Compare(Item22, other.Item22);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item23, other.Item23) ?? Comparer<T23>.Default.Compare(Item23, other.Item23);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item24, other.Item24) ?? Comparer<T24>.Default.Compare(Item24, other.Item24);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
				if (TypeCache<T19>.IsValueType || !ReferenceEquals(Item19, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item19) ?? EqualityComparer<T19>.Default.GetHashCode(Item19));
				if (TypeCache<T20>.IsValueType || !ReferenceEquals(Item20, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item20) ?? EqualityComparer<T20>.Default.GetHashCode(Item20));
				if (TypeCache<T21>.IsValueType || !ReferenceEquals(Item21, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item21) ?? EqualityComparer<T21>.Default.GetHashCode(Item21));
				if (TypeCache<T22>.IsValueType || !ReferenceEquals(Item22, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item22) ?? EqualityComparer<T22>.Default.GetHashCode(Item22));
				if (TypeCache<T23>.IsValueType || !ReferenceEquals(Item23, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item23) ?? EqualityComparer<T23>.Default.GetHashCode(Item23));
				if (TypeCache<T24>.IsValueType || !ReferenceEquals(Item24, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item24) ?? EqualityComparer<T24>.Default.GetHashCode(Item24));
				if (TypeCache<T25>.IsValueType || !ReferenceEquals(Item25, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item25) ?? EqualityComparer<T25>.Default.GetHashCode(Item25));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			if (!(comparer?.Equals(Item19, other.Item19) ?? EqualityComparer<T19>.Default.Equals(Item19, other.Item19)))
				return false;
			if (!(comparer?.Equals(Item20, other.Item20) ?? EqualityComparer<T20>.Default.Equals(Item20, other.Item20)))
				return false;
			if (!(comparer?.Equals(Item21, other.Item21) ?? EqualityComparer<T21>.Default.Equals(Item21, other.Item21)))
				return false;
			if (!(comparer?.Equals(Item22, other.Item22) ?? EqualityComparer<T22>.Default.Equals(Item22, other.Item22)))
				return false;
			if (!(comparer?.Equals(Item23, other.Item23) ?? EqualityComparer<T23>.Default.Equals(Item23, other.Item23)))
				return false;
			if (!(comparer?.Equals(Item24, other.Item24) ?? EqualityComparer<T24>.Default.Equals(Item24, other.Item24)))
				return false;
			if (!(comparer?.Equals(Item25, other.Item25) ?? EqualityComparer<T25>.Default.Equals(Item25, other.Item25)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item19, other.Item19) ?? Comparer<T19>.Default.Compare(Item19, other.Item19);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item20, other.Item20) ?? Comparer<T20>.Default.Compare(Item20, other.Item20);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item21, other.Item21) ?? Comparer<T21>.Default.Compare(Item21, other.Item21);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item22, other.Item22) ?? Comparer<T22>.Default.Compare(Item22, other.Item22);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item23, other.Item23) ?? Comparer<T23>.Default.Compare(Item23, other.Item23);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item24, other.Item24) ?? Comparer<T24>.Default.Compare(Item24, other.Item24);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item25, other.Item25) ?? Comparer<T25>.Default.Compare(Item25, other.Item25);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; Item26 = item26; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25}, {Item26})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
				if (TypeCache<T19>.IsValueType || !ReferenceEquals(Item19, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item19) ?? EqualityComparer<T19>.Default.GetHashCode(Item19));
				if (TypeCache<T20>.IsValueType || !ReferenceEquals(Item20, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item20) ?? EqualityComparer<T20>.Default.GetHashCode(Item20));
				if (TypeCache<T21>.IsValueType || !ReferenceEquals(Item21, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item21) ?? EqualityComparer<T21>.Default.GetHashCode(Item21));
				if (TypeCache<T22>.IsValueType || !ReferenceEquals(Item22, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item22) ?? EqualityComparer<T22>.Default.GetHashCode(Item22));
				if (TypeCache<T23>.IsValueType || !ReferenceEquals(Item23, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item23) ?? EqualityComparer<T23>.Default.GetHashCode(Item23));
				if (TypeCache<T24>.IsValueType || !ReferenceEquals(Item24, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item24) ?? EqualityComparer<T24>.Default.GetHashCode(Item24));
				if (TypeCache<T25>.IsValueType || !ReferenceEquals(Item25, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item25) ?? EqualityComparer<T25>.Default.GetHashCode(Item25));
				if (TypeCache<T26>.IsValueType || !ReferenceEquals(Item26, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item26) ?? EqualityComparer<T26>.Default.GetHashCode(Item26));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			if (!(comparer?.Equals(Item19, other.Item19) ?? EqualityComparer<T19>.Default.Equals(Item19, other.Item19)))
				return false;
			if (!(comparer?.Equals(Item20, other.Item20) ?? EqualityComparer<T20>.Default.Equals(Item20, other.Item20)))
				return false;
			if (!(comparer?.Equals(Item21, other.Item21) ?? EqualityComparer<T21>.Default.Equals(Item21, other.Item21)))
				return false;
			if (!(comparer?.Equals(Item22, other.Item22) ?? EqualityComparer<T22>.Default.Equals(Item22, other.Item22)))
				return false;
			if (!(comparer?.Equals(Item23, other.Item23) ?? EqualityComparer<T23>.Default.Equals(Item23, other.Item23)))
				return false;
			if (!(comparer?.Equals(Item24, other.Item24) ?? EqualityComparer<T24>.Default.Equals(Item24, other.Item24)))
				return false;
			if (!(comparer?.Equals(Item25, other.Item25) ?? EqualityComparer<T25>.Default.Equals(Item25, other.Item25)))
				return false;
			if (!(comparer?.Equals(Item26, other.Item26) ?? EqualityComparer<T26>.Default.Equals(Item26, other.Item26)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item19, other.Item19) ?? Comparer<T19>.Default.Compare(Item19, other.Item19);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item20, other.Item20) ?? Comparer<T20>.Default.Compare(Item20, other.Item20);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item21, other.Item21) ?? Comparer<T21>.Default.Compare(Item21, other.Item21);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item22, other.Item22) ?? Comparer<T22>.Default.Compare(Item22, other.Item22);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item23, other.Item23) ?? Comparer<T23>.Default.Compare(Item23, other.Item23);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item24, other.Item24) ?? Comparer<T24>.Default.Compare(Item24, other.Item24);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item25, other.Item25) ?? Comparer<T25>.Default.Compare(Item25, other.Item25);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item26, other.Item26) ?? Comparer<T26>.Default.Compare(Item26, other.Item26);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; Item26 = item26; Item27 = item27; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25}, {Item26}, {Item27})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
				if (TypeCache<T19>.IsValueType || !ReferenceEquals(Item19, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item19) ?? EqualityComparer<T19>.Default.GetHashCode(Item19));
				if (TypeCache<T20>.IsValueType || !ReferenceEquals(Item20, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item20) ?? EqualityComparer<T20>.Default.GetHashCode(Item20));
				if (TypeCache<T21>.IsValueType || !ReferenceEquals(Item21, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item21) ?? EqualityComparer<T21>.Default.GetHashCode(Item21));
				if (TypeCache<T22>.IsValueType || !ReferenceEquals(Item22, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item22) ?? EqualityComparer<T22>.Default.GetHashCode(Item22));
				if (TypeCache<T23>.IsValueType || !ReferenceEquals(Item23, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item23) ?? EqualityComparer<T23>.Default.GetHashCode(Item23));
				if (TypeCache<T24>.IsValueType || !ReferenceEquals(Item24, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item24) ?? EqualityComparer<T24>.Default.GetHashCode(Item24));
				if (TypeCache<T25>.IsValueType || !ReferenceEquals(Item25, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item25) ?? EqualityComparer<T25>.Default.GetHashCode(Item25));
				if (TypeCache<T26>.IsValueType || !ReferenceEquals(Item26, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item26) ?? EqualityComparer<T26>.Default.GetHashCode(Item26));
				if (TypeCache<T27>.IsValueType || !ReferenceEquals(Item27, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item27) ?? EqualityComparer<T27>.Default.GetHashCode(Item27));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			if (!(comparer?.Equals(Item19, other.Item19) ?? EqualityComparer<T19>.Default.Equals(Item19, other.Item19)))
				return false;
			if (!(comparer?.Equals(Item20, other.Item20) ?? EqualityComparer<T20>.Default.Equals(Item20, other.Item20)))
				return false;
			if (!(comparer?.Equals(Item21, other.Item21) ?? EqualityComparer<T21>.Default.Equals(Item21, other.Item21)))
				return false;
			if (!(comparer?.Equals(Item22, other.Item22) ?? EqualityComparer<T22>.Default.Equals(Item22, other.Item22)))
				return false;
			if (!(comparer?.Equals(Item23, other.Item23) ?? EqualityComparer<T23>.Default.Equals(Item23, other.Item23)))
				return false;
			if (!(comparer?.Equals(Item24, other.Item24) ?? EqualityComparer<T24>.Default.Equals(Item24, other.Item24)))
				return false;
			if (!(comparer?.Equals(Item25, other.Item25) ?? EqualityComparer<T25>.Default.Equals(Item25, other.Item25)))
				return false;
			if (!(comparer?.Equals(Item26, other.Item26) ?? EqualityComparer<T26>.Default.Equals(Item26, other.Item26)))
				return false;
			if (!(comparer?.Equals(Item27, other.Item27) ?? EqualityComparer<T27>.Default.Equals(Item27, other.Item27)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item19, other.Item19) ?? Comparer<T19>.Default.Compare(Item19, other.Item19);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item20, other.Item20) ?? Comparer<T20>.Default.Compare(Item20, other.Item20);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item21, other.Item21) ?? Comparer<T21>.Default.Compare(Item21, other.Item21);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item22, other.Item22) ?? Comparer<T22>.Default.Compare(Item22, other.Item22);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item23, other.Item23) ?? Comparer<T23>.Default.Compare(Item23, other.Item23);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item24, other.Item24) ?? Comparer<T24>.Default.Compare(Item24, other.Item24);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item25, other.Item25) ?? Comparer<T25>.Default.Compare(Item25, other.Item25);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item26, other.Item26) ?? Comparer<T26>.Default.Compare(Item26, other.Item26);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item27, other.Item27) ?? Comparer<T27>.Default.Compare(Item27, other.Item27);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; Item26 = item26; Item27 = item27; Item28 = item28; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25}, {Item26}, {Item27}, {Item28})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
				if (TypeCache<T19>.IsValueType || !ReferenceEquals(Item19, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item19) ?? EqualityComparer<T19>.Default.GetHashCode(Item19));
				if (TypeCache<T20>.IsValueType || !ReferenceEquals(Item20, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item20) ?? EqualityComparer<T20>.Default.GetHashCode(Item20));
				if (TypeCache<T21>.IsValueType || !ReferenceEquals(Item21, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item21) ?? EqualityComparer<T21>.Default.GetHashCode(Item21));
				if (TypeCache<T22>.IsValueType || !ReferenceEquals(Item22, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item22) ?? EqualityComparer<T22>.Default.GetHashCode(Item22));
				if (TypeCache<T23>.IsValueType || !ReferenceEquals(Item23, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item23) ?? EqualityComparer<T23>.Default.GetHashCode(Item23));
				if (TypeCache<T24>.IsValueType || !ReferenceEquals(Item24, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item24) ?? EqualityComparer<T24>.Default.GetHashCode(Item24));
				if (TypeCache<T25>.IsValueType || !ReferenceEquals(Item25, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item25) ?? EqualityComparer<T25>.Default.GetHashCode(Item25));
				if (TypeCache<T26>.IsValueType || !ReferenceEquals(Item26, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item26) ?? EqualityComparer<T26>.Default.GetHashCode(Item26));
				if (TypeCache<T27>.IsValueType || !ReferenceEquals(Item27, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item27) ?? EqualityComparer<T27>.Default.GetHashCode(Item27));
				if (TypeCache<T28>.IsValueType || !ReferenceEquals(Item28, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item28) ?? EqualityComparer<T28>.Default.GetHashCode(Item28));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			if (!(comparer?.Equals(Item19, other.Item19) ?? EqualityComparer<T19>.Default.Equals(Item19, other.Item19)))
				return false;
			if (!(comparer?.Equals(Item20, other.Item20) ?? EqualityComparer<T20>.Default.Equals(Item20, other.Item20)))
				return false;
			if (!(comparer?.Equals(Item21, other.Item21) ?? EqualityComparer<T21>.Default.Equals(Item21, other.Item21)))
				return false;
			if (!(comparer?.Equals(Item22, other.Item22) ?? EqualityComparer<T22>.Default.Equals(Item22, other.Item22)))
				return false;
			if (!(comparer?.Equals(Item23, other.Item23) ?? EqualityComparer<T23>.Default.Equals(Item23, other.Item23)))
				return false;
			if (!(comparer?.Equals(Item24, other.Item24) ?? EqualityComparer<T24>.Default.Equals(Item24, other.Item24)))
				return false;
			if (!(comparer?.Equals(Item25, other.Item25) ?? EqualityComparer<T25>.Default.Equals(Item25, other.Item25)))
				return false;
			if (!(comparer?.Equals(Item26, other.Item26) ?? EqualityComparer<T26>.Default.Equals(Item26, other.Item26)))
				return false;
			if (!(comparer?.Equals(Item27, other.Item27) ?? EqualityComparer<T27>.Default.Equals(Item27, other.Item27)))
				return false;
			if (!(comparer?.Equals(Item28, other.Item28) ?? EqualityComparer<T28>.Default.Equals(Item28, other.Item28)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item19, other.Item19) ?? Comparer<T19>.Default.Compare(Item19, other.Item19);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item20, other.Item20) ?? Comparer<T20>.Default.Compare(Item20, other.Item20);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item21, other.Item21) ?? Comparer<T21>.Default.Compare(Item21, other.Item21);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item22, other.Item22) ?? Comparer<T22>.Default.Compare(Item22, other.Item22);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item23, other.Item23) ?? Comparer<T23>.Default.Compare(Item23, other.Item23);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item24, other.Item24) ?? Comparer<T24>.Default.Compare(Item24, other.Item24);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item25, other.Item25) ?? Comparer<T25>.Default.Compare(Item25, other.Item25);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item26, other.Item26) ?? Comparer<T26>.Default.Compare(Item26, other.Item26);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item27, other.Item27) ?? Comparer<T27>.Default.Compare(Item27, other.Item27);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item28, other.Item28) ?? Comparer<T28>.Default.Compare(Item28, other.Item28);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28, T29 item29) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; Item26 = item26; Item27 = item27; Item28 = item28; Item29 = item29; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25}, {Item26}, {Item27}, {Item28}, {Item29})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
				if (TypeCache<T19>.IsValueType || !ReferenceEquals(Item19, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item19) ?? EqualityComparer<T19>.Default.GetHashCode(Item19));
				if (TypeCache<T20>.IsValueType || !ReferenceEquals(Item20, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item20) ?? EqualityComparer<T20>.Default.GetHashCode(Item20));
				if (TypeCache<T21>.IsValueType || !ReferenceEquals(Item21, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item21) ?? EqualityComparer<T21>.Default.GetHashCode(Item21));
				if (TypeCache<T22>.IsValueType || !ReferenceEquals(Item22, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item22) ?? EqualityComparer<T22>.Default.GetHashCode(Item22));
				if (TypeCache<T23>.IsValueType || !ReferenceEquals(Item23, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item23) ?? EqualityComparer<T23>.Default.GetHashCode(Item23));
				if (TypeCache<T24>.IsValueType || !ReferenceEquals(Item24, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item24) ?? EqualityComparer<T24>.Default.GetHashCode(Item24));
				if (TypeCache<T25>.IsValueType || !ReferenceEquals(Item25, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item25) ?? EqualityComparer<T25>.Default.GetHashCode(Item25));
				if (TypeCache<T26>.IsValueType || !ReferenceEquals(Item26, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item26) ?? EqualityComparer<T26>.Default.GetHashCode(Item26));
				if (TypeCache<T27>.IsValueType || !ReferenceEquals(Item27, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item27) ?? EqualityComparer<T27>.Default.GetHashCode(Item27));
				if (TypeCache<T28>.IsValueType || !ReferenceEquals(Item28, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item28) ?? EqualityComparer<T28>.Default.GetHashCode(Item28));
				if (TypeCache<T29>.IsValueType || !ReferenceEquals(Item29, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item29) ?? EqualityComparer<T29>.Default.GetHashCode(Item29));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			if (!(comparer?.Equals(Item19, other.Item19) ?? EqualityComparer<T19>.Default.Equals(Item19, other.Item19)))
				return false;
			if (!(comparer?.Equals(Item20, other.Item20) ?? EqualityComparer<T20>.Default.Equals(Item20, other.Item20)))
				return false;
			if (!(comparer?.Equals(Item21, other.Item21) ?? EqualityComparer<T21>.Default.Equals(Item21, other.Item21)))
				return false;
			if (!(comparer?.Equals(Item22, other.Item22) ?? EqualityComparer<T22>.Default.Equals(Item22, other.Item22)))
				return false;
			if (!(comparer?.Equals(Item23, other.Item23) ?? EqualityComparer<T23>.Default.Equals(Item23, other.Item23)))
				return false;
			if (!(comparer?.Equals(Item24, other.Item24) ?? EqualityComparer<T24>.Default.Equals(Item24, other.Item24)))
				return false;
			if (!(comparer?.Equals(Item25, other.Item25) ?? EqualityComparer<T25>.Default.Equals(Item25, other.Item25)))
				return false;
			if (!(comparer?.Equals(Item26, other.Item26) ?? EqualityComparer<T26>.Default.Equals(Item26, other.Item26)))
				return false;
			if (!(comparer?.Equals(Item27, other.Item27) ?? EqualityComparer<T27>.Default.Equals(Item27, other.Item27)))
				return false;
			if (!(comparer?.Equals(Item28, other.Item28) ?? EqualityComparer<T28>.Default.Equals(Item28, other.Item28)))
				return false;
			if (!(comparer?.Equals(Item29, other.Item29) ?? EqualityComparer<T29>.Default.Equals(Item29, other.Item29)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item19, other.Item19) ?? Comparer<T19>.Default.Compare(Item19, other.Item19);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item20, other.Item20) ?? Comparer<T20>.Default.Compare(Item20, other.Item20);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item21, other.Item21) ?? Comparer<T21>.Default.Compare(Item21, other.Item21);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item22, other.Item22) ?? Comparer<T22>.Default.Compare(Item22, other.Item22);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item23, other.Item23) ?? Comparer<T23>.Default.Compare(Item23, other.Item23);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item24, other.Item24) ?? Comparer<T24>.Default.Compare(Item24, other.Item24);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item25, other.Item25) ?? Comparer<T25>.Default.Compare(Item25, other.Item25);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item26, other.Item26) ?? Comparer<T26>.Default.Compare(Item26, other.Item26);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item27, other.Item27) ?? Comparer<T27>.Default.Compare(Item27, other.Item27);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item28, other.Item28) ?? Comparer<T28>.Default.Compare(Item28, other.Item28);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item29, other.Item29) ?? Comparer<T29>.Default.Compare(Item29, other.Item29);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28, T29 item29, T30 item30) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; Item26 = item26; Item27 = item27; Item28 = item28; Item29 = item29; Item30 = item30; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25}, {Item26}, {Item27}, {Item28}, {Item29}, {Item30})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
				if (TypeCache<T19>.IsValueType || !ReferenceEquals(Item19, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item19) ?? EqualityComparer<T19>.Default.GetHashCode(Item19));
				if (TypeCache<T20>.IsValueType || !ReferenceEquals(Item20, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item20) ?? EqualityComparer<T20>.Default.GetHashCode(Item20));
				if (TypeCache<T21>.IsValueType || !ReferenceEquals(Item21, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item21) ?? EqualityComparer<T21>.Default.GetHashCode(Item21));
				if (TypeCache<T22>.IsValueType || !ReferenceEquals(Item22, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item22) ?? EqualityComparer<T22>.Default.GetHashCode(Item22));
				if (TypeCache<T23>.IsValueType || !ReferenceEquals(Item23, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item23) ?? EqualityComparer<T23>.Default.GetHashCode(Item23));
				if (TypeCache<T24>.IsValueType || !ReferenceEquals(Item24, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item24) ?? EqualityComparer<T24>.Default.GetHashCode(Item24));
				if (TypeCache<T25>.IsValueType || !ReferenceEquals(Item25, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item25) ?? EqualityComparer<T25>.Default.GetHashCode(Item25));
				if (TypeCache<T26>.IsValueType || !ReferenceEquals(Item26, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item26) ?? EqualityComparer<T26>.Default.GetHashCode(Item26));
				if (TypeCache<T27>.IsValueType || !ReferenceEquals(Item27, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item27) ?? EqualityComparer<T27>.Default.GetHashCode(Item27));
				if (TypeCache<T28>.IsValueType || !ReferenceEquals(Item28, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item28) ?? EqualityComparer<T28>.Default.GetHashCode(Item28));
				if (TypeCache<T29>.IsValueType || !ReferenceEquals(Item29, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item29) ?? EqualityComparer<T29>.Default.GetHashCode(Item29));
				if (TypeCache<T30>.IsValueType || !ReferenceEquals(Item30, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item30) ?? EqualityComparer<T30>.Default.GetHashCode(Item30));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			if (!(comparer?.Equals(Item19, other.Item19) ?? EqualityComparer<T19>.Default.Equals(Item19, other.Item19)))
				return false;
			if (!(comparer?.Equals(Item20, other.Item20) ?? EqualityComparer<T20>.Default.Equals(Item20, other.Item20)))
				return false;
			if (!(comparer?.Equals(Item21, other.Item21) ?? EqualityComparer<T21>.Default.Equals(Item21, other.Item21)))
				return false;
			if (!(comparer?.Equals(Item22, other.Item22) ?? EqualityComparer<T22>.Default.Equals(Item22, other.Item22)))
				return false;
			if (!(comparer?.Equals(Item23, other.Item23) ?? EqualityComparer<T23>.Default.Equals(Item23, other.Item23)))
				return false;
			if (!(comparer?.Equals(Item24, other.Item24) ?? EqualityComparer<T24>.Default.Equals(Item24, other.Item24)))
				return false;
			if (!(comparer?.Equals(Item25, other.Item25) ?? EqualityComparer<T25>.Default.Equals(Item25, other.Item25)))
				return false;
			if (!(comparer?.Equals(Item26, other.Item26) ?? EqualityComparer<T26>.Default.Equals(Item26, other.Item26)))
				return false;
			if (!(comparer?.Equals(Item27, other.Item27) ?? EqualityComparer<T27>.Default.Equals(Item27, other.Item27)))
				return false;
			if (!(comparer?.Equals(Item28, other.Item28) ?? EqualityComparer<T28>.Default.Equals(Item28, other.Item28)))
				return false;
			if (!(comparer?.Equals(Item29, other.Item29) ?? EqualityComparer<T29>.Default.Equals(Item29, other.Item29)))
				return false;
			if (!(comparer?.Equals(Item30, other.Item30) ?? EqualityComparer<T30>.Default.Equals(Item30, other.Item30)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item19, other.Item19) ?? Comparer<T19>.Default.Compare(Item19, other.Item19);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item20, other.Item20) ?? Comparer<T20>.Default.Compare(Item20, other.Item20);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item21, other.Item21) ?? Comparer<T21>.Default.Compare(Item21, other.Item21);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item22, other.Item22) ?? Comparer<T22>.Default.Compare(Item22, other.Item22);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item23, other.Item23) ?? Comparer<T23>.Default.Compare(Item23, other.Item23);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item24, other.Item24) ?? Comparer<T24>.Default.Compare(Item24, other.Item24);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item25, other.Item25) ?? Comparer<T25>.Default.Compare(Item25, other.Item25);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item26, other.Item26) ?? Comparer<T26>.Default.Compare(Item26, other.Item26);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item27, other.Item27) ?? Comparer<T27>.Default.Compare(Item27, other.Item27);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item28, other.Item28) ?? Comparer<T28>.Default.Compare(Item28, other.Item28);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item29, other.Item29) ?? Comparer<T29>.Default.Compare(Item29, other.Item29);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item30, other.Item30) ?? Comparer<T30>.Default.Compare(Item30, other.Item30);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28, T29 item29, T30 item30, T31 item31) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; Item26 = item26; Item27 = item27; Item28 = item28; Item29 = item29; Item30 = item30; Item31 = item31; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25}, {Item26}, {Item27}, {Item28}, {Item29}, {Item30}, {Item31})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
				if (TypeCache<T19>.IsValueType || !ReferenceEquals(Item19, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item19) ?? EqualityComparer<T19>.Default.GetHashCode(Item19));
				if (TypeCache<T20>.IsValueType || !ReferenceEquals(Item20, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item20) ?? EqualityComparer<T20>.Default.GetHashCode(Item20));
				if (TypeCache<T21>.IsValueType || !ReferenceEquals(Item21, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item21) ?? EqualityComparer<T21>.Default.GetHashCode(Item21));
				if (TypeCache<T22>.IsValueType || !ReferenceEquals(Item22, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item22) ?? EqualityComparer<T22>.Default.GetHashCode(Item22));
				if (TypeCache<T23>.IsValueType || !ReferenceEquals(Item23, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item23) ?? EqualityComparer<T23>.Default.GetHashCode(Item23));
				if (TypeCache<T24>.IsValueType || !ReferenceEquals(Item24, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item24) ?? EqualityComparer<T24>.Default.GetHashCode(Item24));
				if (TypeCache<T25>.IsValueType || !ReferenceEquals(Item25, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item25) ?? EqualityComparer<T25>.Default.GetHashCode(Item25));
				if (TypeCache<T26>.IsValueType || !ReferenceEquals(Item26, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item26) ?? EqualityComparer<T26>.Default.GetHashCode(Item26));
				if (TypeCache<T27>.IsValueType || !ReferenceEquals(Item27, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item27) ?? EqualityComparer<T27>.Default.GetHashCode(Item27));
				if (TypeCache<T28>.IsValueType || !ReferenceEquals(Item28, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item28) ?? EqualityComparer<T28>.Default.GetHashCode(Item28));
				if (TypeCache<T29>.IsValueType || !ReferenceEquals(Item29, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item29) ?? EqualityComparer<T29>.Default.GetHashCode(Item29));
				if (TypeCache<T30>.IsValueType || !ReferenceEquals(Item30, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item30) ?? EqualityComparer<T30>.Default.GetHashCode(Item30));
				if (TypeCache<T31>.IsValueType || !ReferenceEquals(Item31, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item31) ?? EqualityComparer<T31>.Default.GetHashCode(Item31));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			if (!(comparer?.Equals(Item19, other.Item19) ?? EqualityComparer<T19>.Default.Equals(Item19, other.Item19)))
				return false;
			if (!(comparer?.Equals(Item20, other.Item20) ?? EqualityComparer<T20>.Default.Equals(Item20, other.Item20)))
				return false;
			if (!(comparer?.Equals(Item21, other.Item21) ?? EqualityComparer<T21>.Default.Equals(Item21, other.Item21)))
				return false;
			if (!(comparer?.Equals(Item22, other.Item22) ?? EqualityComparer<T22>.Default.Equals(Item22, other.Item22)))
				return false;
			if (!(comparer?.Equals(Item23, other.Item23) ?? EqualityComparer<T23>.Default.Equals(Item23, other.Item23)))
				return false;
			if (!(comparer?.Equals(Item24, other.Item24) ?? EqualityComparer<T24>.Default.Equals(Item24, other.Item24)))
				return false;
			if (!(comparer?.Equals(Item25, other.Item25) ?? EqualityComparer<T25>.Default.Equals(Item25, other.Item25)))
				return false;
			if (!(comparer?.Equals(Item26, other.Item26) ?? EqualityComparer<T26>.Default.Equals(Item26, other.Item26)))
				return false;
			if (!(comparer?.Equals(Item27, other.Item27) ?? EqualityComparer<T27>.Default.Equals(Item27, other.Item27)))
				return false;
			if (!(comparer?.Equals(Item28, other.Item28) ?? EqualityComparer<T28>.Default.Equals(Item28, other.Item28)))
				return false;
			if (!(comparer?.Equals(Item29, other.Item29) ?? EqualityComparer<T29>.Default.Equals(Item29, other.Item29)))
				return false;
			if (!(comparer?.Equals(Item30, other.Item30) ?? EqualityComparer<T30>.Default.Equals(Item30, other.Item30)))
				return false;
			if (!(comparer?.Equals(Item31, other.Item31) ?? EqualityComparer<T31>.Default.Equals(Item31, other.Item31)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item19, other.Item19) ?? Comparer<T19>.Default.Compare(Item19, other.Item19);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item20, other.Item20) ?? Comparer<T20>.Default.Compare(Item20, other.Item20);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item21, other.Item21) ?? Comparer<T21>.Default.Compare(Item21, other.Item21);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item22, other.Item22) ?? Comparer<T22>.Default.Compare(Item22, other.Item22);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item23, other.Item23) ?? Comparer<T23>.Default.Compare(Item23, other.Item23);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item24, other.Item24) ?? Comparer<T24>.Default.Compare(Item24, other.Item24);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item25, other.Item25) ?? Comparer<T25>.Default.Compare(Item25, other.Item25);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item26, other.Item26) ?? Comparer<T26>.Default.Compare(Item26, other.Item26);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item27, other.Item27) ?? Comparer<T27>.Default.Compare(Item27, other.Item27);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item28, other.Item28) ?? Comparer<T28>.Default.Compare(Item28, other.Item28);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item29, other.Item29) ?? Comparer<T29>.Default.Compare(Item29, other.Item29);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item30, other.Item30) ?? Comparer<T30>.Default.Compare(Item30, other.Item30);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item31, other.Item31) ?? Comparer<T31>.Default.Compare(Item31, other.Item31);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

	public class Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32> : IEquatable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>>, IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>>, IStructuralComparable, IStructuralEquatable, IComparable
	{
		public T1 Item1 { get; set; }
		public T2 Item2 { get; set; }
		public T3 Item3 { get; set; }
		public T4 Item4 { get; set; }
		public T5 Item5 { get; set; }
		public T6 Item6 { get; set; }
		public T7 Item7 { get; set; }
		public T8 Item8 { get; set; }
		public T9 Item9 { get; set; }
		public T10 Item10 { get; set; }
		public T11 Item11 { get; set; }
		public T12 Item12 { get; set; }
		public T13 Item13 { get; set; }
		public T14 Item14 { get; set; }
		public T15 Item15 { get; set; }
		public T16 Item16 { get; set; }
		public T17 Item17 { get; set; }
		public T18 Item18 { get; set; }
		public T19 Item19 { get; set; }
		public T20 Item20 { get; set; }
		public T21 Item21 { get; set; }
		public T22 Item22 { get; set; }
		public T23 Item23 { get; set; }
		public T24 Item24 { get; set; }
		public T25 Item25 { get; set; }
		public T26 Item26 { get; set; }
		public T27 Item27 { get; set; }
		public T28 Item28 { get; set; }
		public T29 Item29 { get; set; }
		public T30 Item30 { get; set; }
		public T31 Item31 { get; set; }
		public T32 Item32 { get; set; }

		public Mutuple() {}
		public Mutuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8, T9 item9, T10 item10, T11 item11, T12 item12, T13 item13, T14 item14, T15 item15, T16 item16, T17 item17, T18 item18, T19 item19, T20 item20, T21 item21, T22 item22, T23 item23, T24 item24, T25 item25, T26 item26, T27 item27, T28 item28, T29 item29, T30 item30, T31 item31, T32 item32) { Item1 = item1; Item2 = item2; Item3 = item3; Item4 = item4; Item5 = item5; Item6 = item6; Item7 = item7; Item8 = item8; Item9 = item9; Item10 = item10; Item11 = item11; Item12 = item12; Item13 = item13; Item14 = item14; Item15 = item15; Item16 = item16; Item17 = item17; Item18 = item18; Item19 = item19; Item20 = item20; Item21 = item21; Item22 = item22; Item23 = item23; Item24 = item24; Item25 = item25; Item26 = item26; Item27 = item27; Item28 = item28; Item29 = item29; Item30 = item30; Item31 = item31; Item32 = item32; }
		public override String ToString() => $"({Item1}, {Item2}, {Item3}, {Item4}, {Item5}, {Item6}, {Item7}, {Item8}, {Item9}, {Item10}, {Item11}, {Item12}, {Item13}, {Item14}, {Item15}, {Item16}, {Item17}, {Item18}, {Item19}, {Item20}, {Item21}, {Item22}, {Item23}, {Item24}, {Item25}, {Item26}, {Item27}, {Item28}, {Item29}, {Item30}, {Item31}, {Item32})";

		#region GetHashCode
		public override Int32 GetHashCode() => GetHashCode(null);

		Int32 IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return GetHashCode(comparer);
		}

		private Int32 GetHashCode(IEqualityComparer comparer) {
			var hash = 0x51ed270b;
			unchecked {
				if (TypeCache<T1>.IsValueType || !ReferenceEquals(Item1, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item1) ?? EqualityComparer<T1>.Default.GetHashCode(Item1));
				if (TypeCache<T2>.IsValueType || !ReferenceEquals(Item2, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item2) ?? EqualityComparer<T2>.Default.GetHashCode(Item2));
				if (TypeCache<T3>.IsValueType || !ReferenceEquals(Item3, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item3) ?? EqualityComparer<T3>.Default.GetHashCode(Item3));
				if (TypeCache<T4>.IsValueType || !ReferenceEquals(Item4, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item4) ?? EqualityComparer<T4>.Default.GetHashCode(Item4));
				if (TypeCache<T5>.IsValueType || !ReferenceEquals(Item5, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item5) ?? EqualityComparer<T5>.Default.GetHashCode(Item5));
				if (TypeCache<T6>.IsValueType || !ReferenceEquals(Item6, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item6) ?? EqualityComparer<T6>.Default.GetHashCode(Item6));
				if (TypeCache<T7>.IsValueType || !ReferenceEquals(Item7, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item7) ?? EqualityComparer<T7>.Default.GetHashCode(Item7));
				if (TypeCache<T8>.IsValueType || !ReferenceEquals(Item8, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item8) ?? EqualityComparer<T8>.Default.GetHashCode(Item8));
				if (TypeCache<T9>.IsValueType || !ReferenceEquals(Item9, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item9) ?? EqualityComparer<T9>.Default.GetHashCode(Item9));
				if (TypeCache<T10>.IsValueType || !ReferenceEquals(Item10, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item10) ?? EqualityComparer<T10>.Default.GetHashCode(Item10));
				if (TypeCache<T11>.IsValueType || !ReferenceEquals(Item11, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item11) ?? EqualityComparer<T11>.Default.GetHashCode(Item11));
				if (TypeCache<T12>.IsValueType || !ReferenceEquals(Item12, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item12) ?? EqualityComparer<T12>.Default.GetHashCode(Item12));
				if (TypeCache<T13>.IsValueType || !ReferenceEquals(Item13, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item13) ?? EqualityComparer<T13>.Default.GetHashCode(Item13));
				if (TypeCache<T14>.IsValueType || !ReferenceEquals(Item14, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item14) ?? EqualityComparer<T14>.Default.GetHashCode(Item14));
				if (TypeCache<T15>.IsValueType || !ReferenceEquals(Item15, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item15) ?? EqualityComparer<T15>.Default.GetHashCode(Item15));
				if (TypeCache<T16>.IsValueType || !ReferenceEquals(Item16, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item16) ?? EqualityComparer<T16>.Default.GetHashCode(Item16));
				if (TypeCache<T17>.IsValueType || !ReferenceEquals(Item17, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item17) ?? EqualityComparer<T17>.Default.GetHashCode(Item17));
				if (TypeCache<T18>.IsValueType || !ReferenceEquals(Item18, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item18) ?? EqualityComparer<T18>.Default.GetHashCode(Item18));
				if (TypeCache<T19>.IsValueType || !ReferenceEquals(Item19, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item19) ?? EqualityComparer<T19>.Default.GetHashCode(Item19));
				if (TypeCache<T20>.IsValueType || !ReferenceEquals(Item20, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item20) ?? EqualityComparer<T20>.Default.GetHashCode(Item20));
				if (TypeCache<T21>.IsValueType || !ReferenceEquals(Item21, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item21) ?? EqualityComparer<T21>.Default.GetHashCode(Item21));
				if (TypeCache<T22>.IsValueType || !ReferenceEquals(Item22, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item22) ?? EqualityComparer<T22>.Default.GetHashCode(Item22));
				if (TypeCache<T23>.IsValueType || !ReferenceEquals(Item23, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item23) ?? EqualityComparer<T23>.Default.GetHashCode(Item23));
				if (TypeCache<T24>.IsValueType || !ReferenceEquals(Item24, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item24) ?? EqualityComparer<T24>.Default.GetHashCode(Item24));
				if (TypeCache<T25>.IsValueType || !ReferenceEquals(Item25, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item25) ?? EqualityComparer<T25>.Default.GetHashCode(Item25));
				if (TypeCache<T26>.IsValueType || !ReferenceEquals(Item26, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item26) ?? EqualityComparer<T26>.Default.GetHashCode(Item26));
				if (TypeCache<T27>.IsValueType || !ReferenceEquals(Item27, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item27) ?? EqualityComparer<T27>.Default.GetHashCode(Item27));
				if (TypeCache<T28>.IsValueType || !ReferenceEquals(Item28, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item28) ?? EqualityComparer<T28>.Default.GetHashCode(Item28));
				if (TypeCache<T29>.IsValueType || !ReferenceEquals(Item29, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item29) ?? EqualityComparer<T29>.Default.GetHashCode(Item29));
				if (TypeCache<T30>.IsValueType || !ReferenceEquals(Item30, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item30) ?? EqualityComparer<T30>.Default.GetHashCode(Item30));
				if (TypeCache<T31>.IsValueType || !ReferenceEquals(Item31, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item31) ?? EqualityComparer<T31>.Default.GetHashCode(Item31));
				if (TypeCache<T32>.IsValueType || !ReferenceEquals(Item32, null))
					hash = (hash * -1521134295) + (comparer?.GetHashCode(Item32) ?? EqualityComparer<T32>.Default.GetHashCode(Item32));
			}
			return hash;
		}
		#endregion

		#region Equals
		public override Boolean Equals(Object obj) => Equals(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>);

		public Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32> other) => Equals(other, null);

		Boolean IStructuralEquatable.Equals(Object other, IEqualityComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			return Equals(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>, comparer);
		}

		private Boolean Equals(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32> other, IEqualityComparer comparer) {
			if (other == null)
				return false;
			if (!(comparer?.Equals(Item1, other.Item1) ?? EqualityComparer<T1>.Default.Equals(Item1, other.Item1)))
				return false;
			if (!(comparer?.Equals(Item2, other.Item2) ?? EqualityComparer<T2>.Default.Equals(Item2, other.Item2)))
				return false;
			if (!(comparer?.Equals(Item3, other.Item3) ?? EqualityComparer<T3>.Default.Equals(Item3, other.Item3)))
				return false;
			if (!(comparer?.Equals(Item4, other.Item4) ?? EqualityComparer<T4>.Default.Equals(Item4, other.Item4)))
				return false;
			if (!(comparer?.Equals(Item5, other.Item5) ?? EqualityComparer<T5>.Default.Equals(Item5, other.Item5)))
				return false;
			if (!(comparer?.Equals(Item6, other.Item6) ?? EqualityComparer<T6>.Default.Equals(Item6, other.Item6)))
				return false;
			if (!(comparer?.Equals(Item7, other.Item7) ?? EqualityComparer<T7>.Default.Equals(Item7, other.Item7)))
				return false;
			if (!(comparer?.Equals(Item8, other.Item8) ?? EqualityComparer<T8>.Default.Equals(Item8, other.Item8)))
				return false;
			if (!(comparer?.Equals(Item9, other.Item9) ?? EqualityComparer<T9>.Default.Equals(Item9, other.Item9)))
				return false;
			if (!(comparer?.Equals(Item10, other.Item10) ?? EqualityComparer<T10>.Default.Equals(Item10, other.Item10)))
				return false;
			if (!(comparer?.Equals(Item11, other.Item11) ?? EqualityComparer<T11>.Default.Equals(Item11, other.Item11)))
				return false;
			if (!(comparer?.Equals(Item12, other.Item12) ?? EqualityComparer<T12>.Default.Equals(Item12, other.Item12)))
				return false;
			if (!(comparer?.Equals(Item13, other.Item13) ?? EqualityComparer<T13>.Default.Equals(Item13, other.Item13)))
				return false;
			if (!(comparer?.Equals(Item14, other.Item14) ?? EqualityComparer<T14>.Default.Equals(Item14, other.Item14)))
				return false;
			if (!(comparer?.Equals(Item15, other.Item15) ?? EqualityComparer<T15>.Default.Equals(Item15, other.Item15)))
				return false;
			if (!(comparer?.Equals(Item16, other.Item16) ?? EqualityComparer<T16>.Default.Equals(Item16, other.Item16)))
				return false;
			if (!(comparer?.Equals(Item17, other.Item17) ?? EqualityComparer<T17>.Default.Equals(Item17, other.Item17)))
				return false;
			if (!(comparer?.Equals(Item18, other.Item18) ?? EqualityComparer<T18>.Default.Equals(Item18, other.Item18)))
				return false;
			if (!(comparer?.Equals(Item19, other.Item19) ?? EqualityComparer<T19>.Default.Equals(Item19, other.Item19)))
				return false;
			if (!(comparer?.Equals(Item20, other.Item20) ?? EqualityComparer<T20>.Default.Equals(Item20, other.Item20)))
				return false;
			if (!(comparer?.Equals(Item21, other.Item21) ?? EqualityComparer<T21>.Default.Equals(Item21, other.Item21)))
				return false;
			if (!(comparer?.Equals(Item22, other.Item22) ?? EqualityComparer<T22>.Default.Equals(Item22, other.Item22)))
				return false;
			if (!(comparer?.Equals(Item23, other.Item23) ?? EqualityComparer<T23>.Default.Equals(Item23, other.Item23)))
				return false;
			if (!(comparer?.Equals(Item24, other.Item24) ?? EqualityComparer<T24>.Default.Equals(Item24, other.Item24)))
				return false;
			if (!(comparer?.Equals(Item25, other.Item25) ?? EqualityComparer<T25>.Default.Equals(Item25, other.Item25)))
				return false;
			if (!(comparer?.Equals(Item26, other.Item26) ?? EqualityComparer<T26>.Default.Equals(Item26, other.Item26)))
				return false;
			if (!(comparer?.Equals(Item27, other.Item27) ?? EqualityComparer<T27>.Default.Equals(Item27, other.Item27)))
				return false;
			if (!(comparer?.Equals(Item28, other.Item28) ?? EqualityComparer<T28>.Default.Equals(Item28, other.Item28)))
				return false;
			if (!(comparer?.Equals(Item29, other.Item29) ?? EqualityComparer<T29>.Default.Equals(Item29, other.Item29)))
				return false;
			if (!(comparer?.Equals(Item30, other.Item30) ?? EqualityComparer<T30>.Default.Equals(Item30, other.Item30)))
				return false;
			if (!(comparer?.Equals(Item31, other.Item31) ?? EqualityComparer<T31>.Default.Equals(Item31, other.Item31)))
				return false;
			if (!(comparer?.Equals(Item32, other.Item32) ?? EqualityComparer<T32>.Default.Equals(Item32, other.Item32)))
				return false;
			return true;
		}
		#endregion

		#region CompareTo
		Int32 IComparable.CompareTo(Object obj) {
			if (obj == null)
				return 1;
			return CompareTo(obj as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>, null);
		}

		Int32 IComparable<Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>>.CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32> other)  {
			if (other == null)
				return 1;
			return CompareTo(other, null);
		}

		Int32 IStructuralComparable.CompareTo(Object other, IComparer comparer) {
			if (comparer == null)
				throw new ArgumentNullException(nameof(comparer));
			if (other == null)
				return 1;
			return CompareTo(other as Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>, comparer);
		}

		private Int32 CompareTo(Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32> other, IComparer comparer) {
			if (other == null)
				throw new ArgumentException("Incorrect type, must be `Mutuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32>`", nameof(other));
			Int32 num;
			num = comparer?.Compare(Item1, other.Item1) ?? Comparer<T1>.Default.Compare(Item1, other.Item1);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item2, other.Item2) ?? Comparer<T2>.Default.Compare(Item2, other.Item2);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item3, other.Item3) ?? Comparer<T3>.Default.Compare(Item3, other.Item3);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item4, other.Item4) ?? Comparer<T4>.Default.Compare(Item4, other.Item4);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item5, other.Item5) ?? Comparer<T5>.Default.Compare(Item5, other.Item5);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item6, other.Item6) ?? Comparer<T6>.Default.Compare(Item6, other.Item6);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item7, other.Item7) ?? Comparer<T7>.Default.Compare(Item7, other.Item7);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item8, other.Item8) ?? Comparer<T8>.Default.Compare(Item8, other.Item8);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item9, other.Item9) ?? Comparer<T9>.Default.Compare(Item9, other.Item9);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item10, other.Item10) ?? Comparer<T10>.Default.Compare(Item10, other.Item10);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item11, other.Item11) ?? Comparer<T11>.Default.Compare(Item11, other.Item11);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item12, other.Item12) ?? Comparer<T12>.Default.Compare(Item12, other.Item12);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item13, other.Item13) ?? Comparer<T13>.Default.Compare(Item13, other.Item13);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item14, other.Item14) ?? Comparer<T14>.Default.Compare(Item14, other.Item14);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item15, other.Item15) ?? Comparer<T15>.Default.Compare(Item15, other.Item15);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item16, other.Item16) ?? Comparer<T16>.Default.Compare(Item16, other.Item16);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item17, other.Item17) ?? Comparer<T17>.Default.Compare(Item17, other.Item17);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item18, other.Item18) ?? Comparer<T18>.Default.Compare(Item18, other.Item18);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item19, other.Item19) ?? Comparer<T19>.Default.Compare(Item19, other.Item19);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item20, other.Item20) ?? Comparer<T20>.Default.Compare(Item20, other.Item20);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item21, other.Item21) ?? Comparer<T21>.Default.Compare(Item21, other.Item21);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item22, other.Item22) ?? Comparer<T22>.Default.Compare(Item22, other.Item22);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item23, other.Item23) ?? Comparer<T23>.Default.Compare(Item23, other.Item23);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item24, other.Item24) ?? Comparer<T24>.Default.Compare(Item24, other.Item24);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item25, other.Item25) ?? Comparer<T25>.Default.Compare(Item25, other.Item25);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item26, other.Item26) ?? Comparer<T26>.Default.Compare(Item26, other.Item26);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item27, other.Item27) ?? Comparer<T27>.Default.Compare(Item27, other.Item27);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item28, other.Item28) ?? Comparer<T28>.Default.Compare(Item28, other.Item28);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item29, other.Item29) ?? Comparer<T29>.Default.Compare(Item29, other.Item29);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item30, other.Item30) ?? Comparer<T30>.Default.Compare(Item30, other.Item30);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item31, other.Item31) ?? Comparer<T31>.Default.Compare(Item31, other.Item31);
			if (num != 0)
				return num;
			num = comparer?.Compare(Item32, other.Item32) ?? Comparer<T32>.Default.Compare(Item32, other.Item32);
			if (num != 0)
				return num;
			return num;
		}
		#endregion
	}

}