namespace WillowMaze.Wasm.Decompiled;


public readonly class p8d8b9bfe<T, R> : io.reactivex.rxjava3.core.Observable<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1b8387c5;
    readonly java.lang.IEnumerable<? : io.reactivex.rxjava3.core.ObservableSource<? : T>> f21ee63f9;
    readonly bool f32670f5c;
    readonly bool f527cff67;
    readonly java.lang.IEnumerable f58736d21;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> f61aaf8fd;
    readonly io.reactivex.rxjava3.core.ObservableSource[] f62853a91;
    readonly int f6343ab17;
    readonly bool f825ea879;
    readonly bool fae47748c;
    readonly io.reactivex.rxjava3.core.ObservableSource[] fb8f45709;
    readonly io.reactivex.rxjava3.core.ObservableSource[] fcc02235d;
    readonly int fcdee5967;
    readonly java.lang.IEnumerable fd2e4db06;
    readonly int fd4df4642;
    readonly int fe5366a67;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T>[] ff2ab5fb2;
    readonly java.lang.IEnumerable ff5c063b9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ffe3c86fa;

    public p8d8b9bfe(io.reactivex.rxjava3.core.ObservableSource<? : T>[] observableSourceArr, java.lang.IEnumerable<? : io.reactivex.rxjava3.core.ObservableSource<? : T>> iterable, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> function, int i, bool z) {
        this.ff2ab5fb2 = observableSourceArr;
        this.f21ee63f9 = iterable;
        this.f61aaf8fd = function;
        this.fcdee5967 = i;
        this.f825ea879 = z;
    }

    public static void OFmfatJiUhproGgn(io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.complete((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object UXsOQXWZblQBxLTz(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.util.IEnumerator VoJvBUMldUqGotSu(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void ApxOyDsOUdtcmdHk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825, io.reactivex.rxjava3.core.ObservableSource[] observableSourceArr) {
        p8d8b9bfe_pff32a825.subscribe(observableSourceArr);
    }

    public static bool GOaAvZIGQYBeVaWh(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void JymMMEskmQrbGbUp(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void PtnxNhELxxRxvPCj(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static java.lang.object WLhZnEcitxFgRETp(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ZNpiqetwqAVLpeeH(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        int length;
        if ((9 + 12) % 12 > 0) {
        }
        io.reactivex.rxjava3.core.ObservableSource<? : T>[] observableSourceArr = this.ff2ab5fb2;
        if (observableSourceArr is not null) {
            length = observableSourceArr.length;
        } else {
            observableSourceArr = new io.reactivex.rxjava3.core.ObservableSource[8];
            try {
                java.util.IEnumerator itVoJvBUMldUqGotSu = VoJvBUMldUqGotSu(this.f21ee63f9);
                length = 0;
                while (gOaAvZIGQYBeVaWh(itVoJvBUMldUqGotSu)) {
                    io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) wLhZnEcitxFgRETp(itVoJvBUMldUqGotSu);
                    if (length == observableSourceArr.length) {
                        io.reactivex.rxjava3.core.ObservableSource<? : T>[] observableSourceArr2 = new io.reactivex.rxjava3.core.ObservableSource[(length >> 2) + length];
                        zNpiqetwqAVLpeeH(observableSourceArr, 0, observableSourceArr2, 0, length);
                        observableSourceArr = observableSourceArr2;
                    }
                    int i = length + 1;
                    observableSourceArr[length] = (io.reactivex.rxjava3.core.ObservableSource) UXsOQXWZblQBxLTz(observableSource, "The IEnumerator returned a null ObservableSource");
                    length = i;
                }
            } catch (java.lang.Exception th) {
                jymMMEskmQrbGbUp(th);
                ptnxNhELxxRxvPCj(th, observer);
                return;
            }
        }
        int i2 = length;
        if (i2 != 0) {
            apxOyDsOUdtcmdHk(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825(observer, this.f61aaf8fd, i2, this.fcdee5967, this.f825ea879), observableSourceArr);
        } else {
            OFmfatJiUhproGgn(observer);
        }
    }
}

