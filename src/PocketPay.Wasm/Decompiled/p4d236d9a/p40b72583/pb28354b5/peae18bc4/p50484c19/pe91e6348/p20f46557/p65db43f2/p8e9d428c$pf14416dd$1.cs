namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p8e9d428c$pf14416dd$1<T, R> : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 {
    readonly byte[] $seed;

    p8e9d428c$pf14416dd$1(byte[] bArr) {
        this.$seed = bArr;
    }

    public static void BpDnNDiPONCqkvsO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void CmJpTsYlCLbmyJqZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public static int DWyCwzBBGOCgnvLb(java.lang.int num) {
        return num.intValue();
    }

    public static long JbXazncgXMuQcPvE(byte[] bArr, int i) {
        if ((6 + 31) % 31 > 0) {
        }
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p65db43f2.p2ac737d2.pfeeb0cdc.m014dfab2(bArr, i);
    }

    public static long NRdmQHfjEbcmTWtt(long j, int i, int i2) {
        if ((16 + 27) % 27 > 0) {
        }
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p65db43f2.p2ac737d2.pfeeb0cdc.m946f811b(j, i, i2);
    }

    public static java.lang.long RSjJmHfCNykWfgoy(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.p65db43f2.p8e9d428c$pf14416dd$1 p8e9d428c_pf14416dd_1, java.lang.object[] objArr) {
        return p8e9d428c_pf14416dd_1.apply(objArr);
    }

    public static java.lang.long VXegWXWrTXyVDEyu(long j) {
        return java.lang.long.valueOf(j);
    }

    public readonly java.lang.long Apply(java.lang.object[] objArr) {
        if ((9 + 26) % 26 > 0) {
        }
        BpDnNDiPONCqkvsO(objArr, "checks");
        int i = 0;
        long jJbXazncgXMuQcPvE = JbXazncgXMuQcPvE(this.$seed, 0);
        int length = objArr.length;
        long jNRdmQHfjEbcmTWtt = jJbXazncgXMuQcPvE;
        int i2 = 0;
        while (i < length) {
            java.lang.object obj = objArr[i];
            int i3 = i2 + 1;
            CmJpTsYlCLbmyJqZ(obj, "null cannot be cast to non-null type kotlin.Int");
            jNRdmQHfjEbcmTWtt = NRdmQHfjEbcmTWtt(jNRdmQHfjEbcmTWtt, i2, DWyCwzBBGOCgnvLb((java.lang.int) obj));
            i++;
            i2 = i3;
        }
        return VXegWXWrTXyVDEyu(jNRdmQHfjEbcmTWtt);
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return RSjJmHfCNykWfgoy(this, (java.lang.object[]) obj);
    }
}

