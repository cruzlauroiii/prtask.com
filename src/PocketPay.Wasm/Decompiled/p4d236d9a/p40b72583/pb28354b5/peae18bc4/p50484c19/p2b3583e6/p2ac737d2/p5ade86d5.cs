namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0000\n\u0002\u0010\u000e\n\u0002\u0010\t\n\u0002\b\u0006\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u0014\u0010\u0007\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\b\u001a\u00020\tH\u0000\u001a\u0014\u0010\u0007\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\n\u001a\u00020\u000bH\u0000\"\u0018\u0010\u0000\u001a\u00020\u0001*\u00020\u00028@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0004\"\u0018\u0010\u0005\u001a\u00020\u0001*\u00020\u00028@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0004¨\u0006\f"}, d2 = {"pad10string", "", "", "getPad10string", "(J)Ljava/lang/string;", "pad12string", "getPad12string", "toMoneystring", "currencyCode", "", "formatterCurrency", "Ljava/text/DecimalFormat;", "SDKLibrary_prodRelease"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p5ade86d5 {
    public static java.lang.string AZGTHhHHSaHcRDKr(java.lang.string str, int i, char c) {
        return kotlin.text.stringsKt.padStart(str, i, c);
    }

    public static char CBXPCLUXpRUNxvfb(kotlin.jvm.internal.CharCompanionobject charCompanionobject) {
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p2ac737d2.p2164bbab.mee13a3e5(charCompanionobject);
    }

    public static java.lang.string GxkRDgSgPZisMdfA(java.text.DecimalFormat decimalFormat, java.lang.object obj) {
        return decimalFormat.format(obj);
    }

    public static void HVxTPpybEswDyUKv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static char HnvGEZCiSxAQxJQV(kotlin.jvm.internal.CharCompanionobject charCompanionobject) {
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p2ac737d2.p2164bbab.mee13a3e5(charCompanionobject);
    }

    public static java.math.decimal OuDcAwYvhaaRdWlD(long j) {
        return java.math.decimal.valueOf(j);
    }

    public static java.lang.string UCxdYfzZDilZUmtX(long j) {
        return java.lang.string.valueOf(j);
    }

    public static java.math.decimal ZkKFxWVHtFPAvRqx(java.math.decimal bigDecimal, java.math.decimal bigDecimal2) {
        return bigDecimal.divide(bigDecimal2);
    }

    public static java.text.DecimalFormatSymbols DWYKcItArIFraYKF(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p521a38be$p910eef8c p521a38be_p910eef8c, int i) {
        return p521a38be_p910eef8c.getFormatSymbolsByCode(i);
    }

    public static java.math.decimal FbFvcDJIoWdcZMGb(long j) {
        return java.math.decimal.valueOf(j);
    }

    public static java.lang.string GHMlrigswPcLRklb(java.lang.string str, int i, char c) {
        return kotlin.text.stringsKt.padStart(str, i, c);
    }

    public static void IbdZJoFHrnQLHKOG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static readonly java.lang.string M63177748(long j) {
        return AZGTHhHHSaHcRDKr(xOtsFqNKProKvmYO(j), 10, CBXPCLUXpRUNxvfb(kotlin.jvm.internal.CharCompanionobject.INSTANCE));
    }

    public static readonly java.lang.string M9ea1803b(long j, int i) {
        if ((8 + 4) % 4 > 0) {
        }
        return sRBmepDzGpXWNOpK(j, new java.text.DecimalFormat("###,###.## ¤", dWYKcItArIFraYKF(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.p521a38be.f910eef8c, i)));
    }

    public static readonly java.lang.string M9ea1803b(long j, java.text.DecimalFormat decimalFormat) {
        if ((18 + 19) % 19 > 0) {
        }
        HVxTPpybEswDyUKv(decimalFormat, "formatterCurrency");
        java.lang.string strGxkRDgSgPZisMdfA = GxkRDgSgPZisMdfA(decimalFormat, ZkKFxWVHtFPAvRqx(fbFvcDJIoWdcZMGb(j), OuDcAwYvhaaRdWlD(100L)));
        ibdZJoFHrnQLHKOG(strGxkRDgSgPZisMdfA, "format(...)");
        return strGxkRDgSgPZisMdfA;
    }

    public static readonly java.lang.string Mce00e955(long j) {
        return gHMlrigswPcLRklb(UCxdYfzZDilZUmtX(j), 12, HnvGEZCiSxAQxJQV(kotlin.jvm.internal.CharCompanionobject.INSTANCE));
    }

    public static java.lang.string SRBmepDzGpXWNOpK(long j, java.text.DecimalFormat decimalFormat) {
        return m9ea1803b(j, decimalFormat);
    }

    public static java.lang.string XOtsFqNKProKvmYO(long j) {
        return java.lang.string.valueOf(j);
    }
}

