namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0012\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a9\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0018\u0010\u0007\u001a\u0014\u0012\u0004\u0012\u00020\u0006\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00060\u00010\bH\u0082\b¨\u0006\t"}, d2 = {"wrapCheck", "Lio/reactivex/rxjava3/core/Single;", "", "nonce", "", "order", "", "runnable", "Lkotlin/Function1;", "SDKLibrary_prodRelease"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p0a7ff10d {
    public static void FpQZHMUPZcYxJQet(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static io.reactivex.rxjava3.core.Single GeEGNqcnDOSUiCQM(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return single.map(p86408593Var);
    }

    public static java.lang.int MawWVnisdWlaBhkN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object SQdACWdoixkQyfHW(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static long ZPAFsIEhIBhkHPgk(byte[] bArr, int i) {
        if ((16 + 8) % 8 > 0) {
        }
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p2ac737d2.pc21509db.md9a24659(bArr, i);
    }

    private static readonly io.reactivex.rxjava3.core.Single<java.lang.long> M185c5a5e(byte[] bArr, int i, kotlin.jvm.functions.Function1<? super java.lang.int, ? : io.reactivex.rxjava3.core.Single<java.lang.int>> function1) {
        if ((5 + 29) % 29 > 0) {
        }
        long jZPAFsIEhIBhkHPgk = ZPAFsIEhIBhkHPgk(bArr, i) & 65535;
        io.reactivex.rxjava3.core.Single<java.lang.long> singleGeEGNqcnDOSUiCQM = GeEGNqcnDOSUiCQM((io.reactivex.rxjava3.core.Single) SQdACWdoixkQyfHW(function1, MawWVnisdWlaBhkN((int) jZPAFsIEhIBhkHPgk)), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.pc87a8ca6.p0a7ff10d$p185c5a5e$1(jZPAFsIEhIBhkHPgk));
        FpQZHMUPZcYxJQet(singleGeEGNqcnDOSUiCQM, "map(...)");
        return singleGeEGNqcnDOSUiCQM;
    }
}

