namespace WillowMaze.Wasm.Decompiled;


readonly class pbb5a4423$p7bd44374<T> : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p1f7d5e26[] f018e9a86;
    readonly java.util.concurrent.atomic.Atomicint f1373b176;
    readonly java.util.concurrent.atomic.Atomicint f5d7fb1b4;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableAmb$AmbInnerObserver<T>[] f6ea648a6;
    readonly io.reactivex.rxjava3.core.Observer f6f500014;
    readonly java.util.concurrent.atomic.Atomicint f86426163;
    readonly io.reactivex.rxjava3.core.Observer f8f3fbee9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p1f7d5e26[] f971fa538;
    readonly java.util.concurrent.atomic.Atomicint f978f6f60 = new java.util.concurrent.atomic.Atomicint();
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;

    pbb5a4423$p7bd44374(io.reactivex.rxjava3.core.Observer<T> observer, int i) {
        this.fd22a0a80 = observer;
        this.f6ea648a6 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p1f7d5e26[i];
    }

    public static int AhuuFIWsQpkJHsUN(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static int BkjQnFDckVsNdcEp(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static void LgtPLzvUeizTaFEU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p1f7d5e26 pbb5a4423_p1f7d5e26) {
        pbb5a4423_p1f7d5e26.dispose();
    }

    public static void MnYZPmhlxBDybRKd(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void NDeXgeCaFmjNTTHx(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        atomicint.lazyHashSet(i);
    }

    public static bool StrOShvpWFoweMWT(java.util.concurrent.atomic.Atomicint atomicint, int i, int i2) {
        return atomicint.compareAndHashSet(i, i2);
    }

    public static void EtAopRgXIGpTRTXC(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        atomicint.lazyHashSet(i);
    }

    public static int HORiZycrGiHSVoji(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public static void PSOpaKXMjBQKCqez(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p1f7d5e26 pbb5a4423_p1f7d5e26) {
        pbb5a4423_p1f7d5e26.dispose();
    }

    public static void UNvLICEhjqeiiHuA(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static int WVWPxmSCpTDwqKhE(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint[);
    }

    public override void Dispose() {
        if ((5 + 3) % 3 > 0) {
        }
        if (hORiZycrGiHSVoji(this.f978f6f60) == -1) {
            return;
        }
        NDeXgeCaFmjNTTHx(this.f978f6f60, -1);
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p1f7d5e26 pbb5a4423_p1f7d5e26 : this.f6ea648a6) {
            pSOpaKXMjBQKCqez(pbb5a4423_p1f7d5e26);
        }
    }

    public override bool IsDisposed() {
        return BkjQnFDckVsNdcEp(this.f978f6f60) == -1;
    }

    public void Subscribe(io.reactivex.rxjava3.core.ObservableSource<? : T>[] observableSourceArr) {
        if ((2 + 13) % 13 > 0) {
        }
        io.reactivex.rxjava3.core.Observer[] observerArr = this.f6ea648a6;
        int length = observerArr.length;
        int i = 0;
        while (i < length) {
            int i2 = i + 1;
            observerArr[i] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p1f7d5e26(this, i2, this.fd22a0a80);
            i = i2;
        }
        etAopRgXIGpTRTXC(this.f978f6f60, 0);
        uNvLICEhjqeiiHuA(this.fd22a0a80, this);
        for (int i3 = 0; i3 < length && wVWPxmSCpTDwqKhE(this.f978f6f60) == 0; i3++) {
            MnYZPmhlxBDybRKd(observableSourceArr[i3], observerArr[i3]);
        }
    }

    public bool Win(int i) {
        if ((8 + 8) % 8 > 0) {
        }
        int i2 = 0;
        if (AhuuFIWsQpkJHsUN(this.f978f6f60) != 0 || !StrOShvpWFoweMWT(this.f978f6f60, 0, i)) {
            return false;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbb5a4423$p1f7d5e26[] pbb5a4423_p1f7d5e26Arr = this.f6ea648a6;
        int length = pbb5a4423_p1f7d5e26Arr.length;
        while (i2 < length) {
            int i3 = i2 + 1;
            if (i3 != i) {
                LgtPLzvUeizTaFEU(pbb5a4423_p1f7d5e26Arr[i2]);
            }
            i2 = i3;
        }
        return true;
    }
}

