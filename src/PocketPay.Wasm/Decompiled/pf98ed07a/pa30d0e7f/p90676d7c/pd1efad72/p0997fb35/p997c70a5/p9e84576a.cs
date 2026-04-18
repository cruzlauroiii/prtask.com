namespace WillowMaze.Wasm.Decompiled;


public readonly class p9e84576a<T, R> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, R> {
    readonly java.lang.IEnumerable f0b68eca4;
    readonly java.lang.IEnumerable f3bbe191d;
    readonly java.lang.IEnumerable<? : io.reactivex.rxjava3.core.ObservableSource<object>> f3ee0557a;
    readonly io.reactivex.rxjava3.core.ObservableSource<object>[] f44c387ca;
    readonly io.reactivex.rxjava3.core.ObservableSource[] f5bd6bb16;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], R> f61aaf8fd;
    readonly io.reactivex.rxjava3.core.ObservableSource[] f61aff35f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f79b80dae;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f837e8176;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa65126c7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa79e0483;
    readonly io.reactivex.rxjava3.core.ObservableSource[] fa852a84e;
    readonly io.reactivex.rxjava3.core.ObservableSource[] fd015cd6f;
    readonly java.lang.IEnumerable fe3c35eec;

    public p9e84576a(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, java.lang.IEnumerable<? : io.reactivex.rxjava3.core.ObservableSource<object>> iterable, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], R> function) {
        super(observableSource);
        this.f44c387ca = null;
        this.f3ee0557a = iterable;
        this.f61aaf8fd = function;
    }

    public p9e84576a(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, io.reactivex.rxjava3.core.ObservableSource<object>[] observableSourceArr, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], R> function) {
        super(observableSource);
        this.f44c387ca = observableSourceArr;
        this.f3ee0557a = null;
        this.f61aaf8fd = function;
    }

    public static java.lang.object[] BDgUOyROSpwQElJO(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static void HucyuLqlJwfmaWfP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pf81b0546 p9e84576a_pf81b0546, io.reactivex.rxjava3.core.ObservableSource[] observableSourceArr, int i) {
        p9e84576a_pf81b0546.subscribe(observableSourceArr, i);
    }

    public static void UqjoyJJVDvmkczBf(java.lang.Exception th, io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.error(th, (io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void NLqWAAYPmTYXYxLE(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void NjLsTSRYlSkhECVA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p915ea05a p915ea05aVar, io.reactivex.rxjava3.core.Observer observer) {
        p915ea05aVar.subscribeActual(observer);
    }

    public static bool OBkkSekTaXbwsDrJ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object OZXKSQAmRAFxsZBr(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void QoUHUesdukkvpjAH(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void TnZrShGZCgcsfZSj(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.util.IEnumerator XPjPzbQdOksUIKyn(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        int length;
        if ((12 + 21) % 21 > 0) {
        }
        io.reactivex.rxjava3.core.ObservableSource<object>[] observableSourceArr = this.f44c387ca;
        if (observableSourceArr is not null) {
            length = observableSourceArr.length;
        } else {
            observableSourceArr = new io.reactivex.rxjava3.core.ObservableSource[8];
            try {
                java.util.IEnumerator itXPjPzbQdOksUIKyn = xPjPzbQdOksUIKyn(this.f3ee0557a);
                length = 0;
                while (oBkkSekTaXbwsDrJ(itXPjPzbQdOksUIKyn)) {
                    io.reactivex.rxjava3.core.ObservableSource<object> observableSource = (io.reactivex.rxjava3.core.ObservableSource) oZXKSQAmRAFxsZBr(itXPjPzbQdOksUIKyn);
                    if (length == observableSourceArr.length) {
                        observableSourceArr = (io.reactivex.rxjava3.core.ObservableSource[]) BDgUOyROSpwQElJO(observableSourceArr, (length >> 1) + length);
                    }
                    int i = length + 1;
                    observableSourceArr[length] = observableSource;
                    length = i;
                }
            } catch (java.lang.Exception th) {
                tnZrShGZCgcsfZSj(th);
                UqjoyJJVDvmkczBf(th, observer);
                return;
            }
        }
        if (length == 0) {
            njLsTSRYlSkhECVA(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p915ea05a(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pfb7c43fc(this)), observer);
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pf81b0546 p9e84576a_pf81b0546 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pf81b0546(observer, this.f61aaf8fd, length);
        nLqWAAYPmTYXYxLE(observer, p9e84576a_pf81b0546);
        HucyuLqlJwfmaWfP(p9e84576a_pf81b0546, observableSourceArr, length);
        qoUHUesdukkvpjAH(this.f36cd38f4, p9e84576a_pf81b0546);
    }
}

