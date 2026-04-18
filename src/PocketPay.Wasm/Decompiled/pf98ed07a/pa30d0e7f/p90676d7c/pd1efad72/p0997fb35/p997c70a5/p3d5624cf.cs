namespace WillowMaze.Wasm.Decompiled;


public readonly class p3d5624cf<T, R> : io.reactivex.rxjava3.core.Observable<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0d0c4dfa;
    readonly int f1b7d93f3;
    readonly int f1ea246d1;
    readonly java.lang.IEnumerable<? : io.reactivex.rxjava3.core.ObservableSource<? : T>> f21ee63f9;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> f3298b476;
    readonly java.lang.IEnumerable f33e358ff;
    readonly java.lang.IEnumerable f4b3a174a;
    readonly bool f5016f1b1;
    readonly int f76986f07;
    readonly bool f825ea879;
    readonly io.reactivex.rxjava3.core.ObservableSource[] f8ef4cc90;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9c0d7f12;
    readonly bool fcd0a77fb;
    readonly int fcdee5967;
    readonly bool fce896f7f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fda0eb2e7;
    readonly bool fda1758f7;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T>[] ff2ab5fb2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff451019f;

    public p3d5624cf(io.reactivex.rxjava3.core.ObservableSource<? : T>[] observableSourceArr, java.lang.IEnumerable<? : io.reactivex.rxjava3.core.ObservableSource<? : T>> iterable, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> function, int i, bool z) {
        this.ff2ab5fb2 = observableSourceArr;
        this.f21ee63f9 = iterable;
        this.f3298b476 = function;
        this.fcdee5967 = i;
        this.f825ea879 = z;
    }

    public static void DLhpVfmWJSOiHRrf(io.reactivex.rxjava3.core.Observer observer) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p9da67c7a.complete((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static bool MiKiYanidIgvBqNG(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void VJSYhPXZyIlRVdlu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22 p3d5624cf_pcbceec22, io.reactivex.rxjava3.core.ObservableSource[] observableSourceArr, int i) {
        p3d5624cf_pcbceec22.subscribe(observableSourceArr, i);
    }

    public static java.lang.object YIzuMKgBgfRkgSOu(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator CIdqiWPHHbaSkatA(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void QtKXDzJBchBdExPM(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<R> observer) {
        int length;
        if ((29 + 6) % 6 > 0) {
        }
        io.reactivex.rxjava3.core.ObservableSource<? : T>[] observableSourceArr = this.ff2ab5fb2;
        if (observableSourceArr is not null) {
            length = observableSourceArr.length;
        } else {
            observableSourceArr = new io.reactivex.rxjava3.core.ObservableSource[8];
            java.util.IEnumerator itCIdqiWPHHbaSkatA = cIdqiWPHHbaSkatA(this.f21ee63f9);
            length = 0;
            while (MiKiYanidIgvBqNG(itCIdqiWPHHbaSkatA)) {
                io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource = (io.reactivex.rxjava3.core.ObservableSource) YIzuMKgBgfRkgSOu(itCIdqiWPHHbaSkatA);
                if (length == observableSourceArr.length) {
                    io.reactivex.rxjava3.core.ObservableSource<? : T>[] observableSourceArr2 = new io.reactivex.rxjava3.core.ObservableSource[(length >> 2) + length];
                    qtKXDzJBchBdExPM(observableSourceArr, 0, observableSourceArr2, 0, length);
                    observableSourceArr = observableSourceArr2;
                }
                int i = length + 1;
                observableSourceArr[length] = observableSource;
                length = i;
            }
        }
        if (length != 0) {
            VJSYhPXZyIlRVdlu(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3d5624cf$pcbceec22(observer, this.f3298b476, length, this.f825ea879), observableSourceArr, this.fcdee5967);
        } else {
            DLhpVfmWJSOiHRrf(observer);
        }
    }
}

