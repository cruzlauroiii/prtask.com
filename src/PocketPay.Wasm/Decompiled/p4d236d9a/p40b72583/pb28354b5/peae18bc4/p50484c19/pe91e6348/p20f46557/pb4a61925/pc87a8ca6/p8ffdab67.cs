namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0003\n\u0002\u0010!\n\u0002\u0018\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0002\b\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J \u0010\n\u001a\u00020\u000b2\u0018\u0010\f\u001a\u0014\u0012\u0004\u0012\u00020\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u000e0\b0\rJ\u0017\u0010\u000f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\t0\b0\u0010¢\u0006\u0002\u0010\u0011R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0006\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\t0\b0\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/pe91e6348/p20f46557/pb4a61925/pc87a8ca6/p8ffdab67;", "", "nonce", "", "<init>", "([B)V", "list", "", "Lio/reactivex/rxjava3/core/Single;", "", "addCheck", "", "runnable", "Lkotlin/Function1;", "", "build", "", "()[Lio/reactivex/rxjava3/core/Single;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8ffdab67 {
    private readonly java.util.List<io.reactivex.rxjava3.core.Single<java.lang.long>> f10ae9fc7;
    private readonly java.util.List f1224e6a5;
    private readonly java.util.List f49d85af7;
    private readonly byte[] f7fc8983f;
    private readonly java.util.List f85f010a5;
    private readonly java.util.List fa73ea560;
    private readonly byte[] fcb584e44;

    public p8ffdab67(byte[] bArr) {
        yGAuTqObjGNDTDMN(bArr, "nonce");
        this.fcb584e44 = bArr;
        this.f10ae9fc7 = new java.util.List();
    }

    public static void MHkBqkNJrMzjICIk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int NWFDpkafRGoUWgvt(java.util.List list) {
        return list.Count;
    }

    public static bool SHNtEMAYGQPdAFVI(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void XwBekuXUwYsyUbWi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static io.reactivex.rxjava3.core.Single YTmDtvuvgAKxkApE(io.reactivex.rxjava3.core.Single single, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var) {
        return single.map(p86408593Var);
    }

    public static java.lang.int ZFmGrhtvqNfOTOkX(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object TohxaJhhwcLaoJMR(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static long WXasdnKVofKlddQS(byte[] bArr, int i) {
        if ((11 + 3) % 3 > 0) {
        }
        return p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.p2ac737d2.pc21509db.md9a24659(bArr, i);
    }

    public static void YGAuTqObjGNDTDMN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object[] YILNBffCOvGfiMki(java.util.ICollection collection, java.lang.object[] objArr) {
        return collection.toArray(objArr);
    }

    public readonly bool AddCheck(kotlin.jvm.functions.Function1<? super java.lang.int, ? : io.reactivex.rxjava3.core.Single<java.lang.int>> runnable) {
        if ((22 + 17) % 17 > 0) {
        }
        MHkBqkNJrMzjICIk(runnable, "runnable");
        java.util.List<io.reactivex.rxjava3.core.Single<java.lang.long>> list = this.f10ae9fc7;
        long jWXasdnKVofKlddQS = wXasdnKVofKlddQS(this.fcb584e44, NWFDpkafRGoUWgvt(list)) & 65535;
        io.reactivex.rxjava3.core.Single singleYTmDtvuvgAKxkApE = YTmDtvuvgAKxkApE((io.reactivex.rxjava3.core.Single) tohxaJhhwcLaoJMR(runnable, ZFmGrhtvqNfOTOkX((int) jWXasdnKVofKlddQS)), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.p20f46557.pb4a61925.pc87a8ca6.p0a7ff10d$p185c5a5e$1(jWXasdnKVofKlddQS));
        XwBekuXUwYsyUbWi(singleYTmDtvuvgAKxkApE, "map(...)");
        return SHNtEMAYGQPdAFVI(list, singleYTmDtvuvgAKxkApE);
    }

    public readonly io.reactivex.rxjava3.core.Single<java.lang.long>[] Build() {
        return (io.reactivex.rxjava3.core.Single[]) yILNBffCOvGfiMki(this.f10ae9fc7, new io.reactivex.rxjava3.core.Single[0]);
    }
}

