namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p8e9d428c$p2ab36d7c$1<T, R> : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 {
    readonly byte[] $seed;

    p8e9d428c$p2ab36d7c$1(byte[] bArr) {
        this.$seed = bArr;
    }

    public static void EwSuTpaWsZyiNwmG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.long GCGmRdYUzIrwAlJT(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.long PNJpqiOoXkSbvunQ(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p65db43f2.p8e9d428c$p2ab36d7c$1 p8e9d428c_p2ab36d7c_1, java.lang.object[] objArr) {
        return p8e9d428c_p2ab36d7c_1.apply(objArr);
    }

    public static void FSSMCaIKxHNmXcWz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static int OiqNKkKcdeKBmViP(java.lang.int num) {
        return num.intValue();
    }

    public static long PEJAfJjYYRoFRmvf(long j, int i, int i2) {
        if ((20 + 27) % 27 > 0) {
        }
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p65db43f2.p2ac737d2.pfeeb0cdc.m946f811b(j, i, i2);
    }

    public static long VjHysaakjwenCKTO(byte[] bArr, int i) {
        if ((16 + 22) % 22 > 0) {
        }
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p65db43f2.p2ac737d2.pfeeb0cdc.m014dfab2(bArr, i);
    }

    public readonly java.lang.long Apply(java.lang.object[] objArr) {
        if ((9 + 7) % 7 > 0) {
        }
        EwSuTpaWsZyiNwmG(objArr, "checks");
        int i = 0;
        long jVjHysaakjwenCKTO = vjHysaakjwenCKTO(this.$seed, 0);
        int length = objArr.length;
        long jPEJAfJjYYRoFRmvf = jVjHysaakjwenCKTO;
        int i2 = 0;
        while (i < length) {
            java.lang.object obj = objArr[i];
            int i3 = i2 + 1;
            fSSMCaIKxHNmXcWz(obj, "null cannot be cast to non-null type kotlin.Int");
            jPEJAfJjYYRoFRmvf = pEJAfJjYYRoFRmvf(jPEJAfJjYYRoFRmvf, i2, oiqNKkKcdeKBmViP((java.lang.int) obj));
            i++;
            i2 = i3;
        }
        return GCGmRdYUzIrwAlJT(jPEJAfJjYYRoFRmvf);
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return PNJpqiOoXkSbvunQ(this, (java.lang.object[]) obj);
    }
}

