namespace WillowMaze.Wasm.Decompiled;


readonly class p9e84576a$pf81b0546<T, R> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fc5f1f12d = 1577321883966341961L;
    private static readonly long fc6e1e520 = 1577321883966341961L;
    volatile bool f0c518878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pdca3b148[] f12f21e8c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1a8878f3;
    readonly io.reactivex.rxjava3.core.Observer f36284ade;
    readonly java.util.concurrent.atomic.objectArray f3a48509a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f3bf14643;
    volatile bool f472f8dc9;
    readonly java.util.concurrent.atomic.object f4ac032a1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pdca3b148[] f5167430d;
    readonly java.util.concurrent.atomic.objectArray f599da640;
    readonly io.reactivex.rxjava3.core.Observer f602e7795;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], R> f61aaf8fd;
    volatile bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pdca3b148[] f6ea648a6;
    readonly io.reactivex.rxjava3.core.Observer f74343037;
    readonly java.util.concurrent.atomic.object f7d36b1d0;
    readonly io.reactivex.rxjava3.core.Observer f7dd08f3c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f80fbf036;
    readonly java.util.concurrent.atomic.object f9758dbcf;
    volatile bool fa837a69a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fb10ec49a;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fcb5e100e;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    volatile bool fe3f74752;
    readonly java.util.concurrent.atomic.object fee6c60da;
    readonly java.util.concurrent.atomic.objectArray fef2f7fea;
    readonly java.util.concurrent.atomic.objectArray<java.lang.object> ff09cc7ee;
    readonly java.util.concurrent.atomic.objectArray ff0d8a9b6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pdca3b148[] ff11fe619;

    p9e84576a$pf81b0546(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], R> function, int i) {
        this.fd22a0a80 = observer;
        this.f61aaf8fd = function;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pdca3b148[] p9e84576a_pdca3b148Arr = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pdca3b148[i];
        for (int i2 = 0; i2 < i; i2++) {
            p9e84576a_pdca3b148Arr[i2] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pdca3b148(this, i2);
        }
        this.f6ea648a6 = p9e84576a_pdca3b148Arr;
        this.ff09cc7ee = new java.util.concurrent.atomic.objectArray<>(i);
        this.fbc3b0556 = new java.util.concurrent.atomic.object<>();
        this.fcb5e100e = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    }

    public static void BjfasKzJkpylEWxQ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void CpvAsDsDyOwcTZlL(io.reactivex.rxjava3.core.Observer observer, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.m6ae9fbb6((io.reactivex.rxjava3.core.Observer<object>) observer, atomicint, p36a52e5dVar);
    }

    public static bool DktrkyESTJlYKjNw(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static java.lang.object FZSJIGcifZiBsEkG(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool JRDaHNMzUiLcuWTJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static java.lang.object KuqzuVGehoCEbZpr(java.util.concurrent.atomic.objectArray atomicReferenceArray, int i) {
        return atomicReferenceArray[i);
    }

    public static void LaNCFjKodKmglEnW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pf81b0546 p9e84576a_pf81b0546, int i) {
        p9e84576a_pf81b0546.cancelAllBut(i);
    }

    public static void PazarUdiEDeJVuHr(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object SKfIGpbGiBUCNeDR(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool SSpRuFKuwbUOoDhn(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static java.lang.object VCnoZLUyyjQWbfaq(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void VdnXwfyxlJhcuXpy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pf81b0546 p9e84576a_pf81b0546, java.lang.Exception th) {
        p9e84576a_pf81b0546.onError(th);
    }

    public static void WJxJZEhlbctwdDXD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pdca3b148 p9e84576a_pdca3b148) {
        p9e84576a_pdca3b148.dispose();
    }

    public static void XewZydffycWlizsH(io.reactivex.rxjava3.core.Observer observer, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.m6ae9fbb6((io.reactivex.rxjava3.core.Observer<object>) observer, atomicint, p36a52e5dVar);
    }

    public static void ZvnzZhktbBDVYVGh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pf81b0546 p9e84576a_pf81b0546) {
        p9e84576a_pf81b0546.dispose();
    }

    public static void AiWSOmWPXBiflvAe(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.mdcce2ff2((io.reactivex.rxjava3.core.Observer<object>) observer, th, atomicint, p36a52e5dVar);
    }

    public static void BQTYJbxChBEbBhNW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pf81b0546 p9e84576a_pf81b0546, int i) {
        p9e84576a_pf81b0546.cancelAllBut(i);
    }

    public static java.lang.object EhWsqSIKQZclwARE(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool FtfPaxyeIifZHqMp(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static void JWSBgnpAjXJjEJrt(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.mf51350c3((io.reactivex.rxjava3.core.Observer<java.lang.object>) observer, obj, atomicint, p36a52e5dVar);
    }

    public static void JimkYeCmixZVHAeR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pf81b0546 p9e84576a_pf81b0546, int i) {
        p9e84576a_pf81b0546.cancelAllBut(i);
    }

    public static void KdPEMytSJXynEXJQ(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void LfOmZHvZzUqodfHv(java.util.concurrent.atomic.objectArray atomicReferenceArray, int i, java.lang.object obj) {
        atomicReferenceArray.set(i, obj);
    }

    public static int MHwJJEkZnVJaqviT(java.util.concurrent.atomic.objectArray atomicReferenceArray) {
        return atomicReferenceArray.Length;
    }

    public static void MvvGYKMOdQRJmUyl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pdca3b148 p9e84576a_pdca3b148) {
        p9e84576a_pdca3b148.dispose();
    }

    public static void OrDiPTMPkmgZhPwA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pf81b0546 p9e84576a_pf81b0546, int i) {
        p9e84576a_pf81b0546.cancelAllBut(i);
    }

    public static bool WvwZCeBuMTSIhEJt(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void YpxWrHkGdnwFPGTj(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th, java.util.concurrent.atomic.Atomicint atomicint, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc584ea14.mdcce2ff2((io.reactivex.rxjava3.core.Observer<object>) observer, th, atomicint, p36a52e5dVar);
    }

    void cancelAllBut(int i) {
        if ((30 + 7) % 7 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pdca3b148[] p9e84576a_pdca3b148Arr = this.f6ea648a6;
        for (int i2 = 0; i2 < p9e84576a_pdca3b148Arr.length; i2++) {
            if (i2 != i) {
                WJxJZEhlbctwdDXD(p9e84576a_pdca3b148Arr[i2]);
            }
        }
    }

    public override void Dispose() {
        if ((13 + 10) % 10 > 0) {
        }
        DktrkyESTJlYKjNw(this.fbc3b0556);
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pdca3b148 p9e84576a_pdca3b148 : this.f6ea648a6) {
            mvvGYKMOdQRJmUyl(p9e84576a_pdca3b148);
        }
    }

    void innerComplete(int i, bool z) {
        if (z) {
            return;
        }
        this.f6b2ded51 = true;
        LaNCFjKodKmglEnW(this, i);
        XewZydffycWlizsH(this.fd22a0a80, this, this.fcb5e100e);
    }

    void innerError(int i, java.lang.Exception th) {
        this.f6b2ded51 = true;
        wvwZCeBuMTSIhEJt(this.fbc3b0556);
        orDiPTMPkmgZhPwA(this, i);
        aiWSOmWPXBiflvAe(this.fd22a0a80, th, this, this.fcb5e100e);
    }

    void innerNext(int i, java.lang.object obj) {
        lfOmZHvZzUqodfHv(this.ff09cc7ee, i, obj);
    }

    public override bool IsDisposed() {
        return JRDaHNMzUiLcuWTJ((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) ehWsqSIKQZclwARE(this.fbc3b0556));
    }

    public override void OnComplete() {
        if ((7 + 27) % 27 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        jimkYeCmixZVHAeR(this, -1);
        CpvAsDsDyOwcTZlL(this.fd22a0a80, this, this.fcb5e100e);
    }

    public override void OnError(java.lang.Exception th) {
        if ((10 + 5) % 5 > 0) {
        }
        if (this.f6b2ded51) {
            BjfasKzJkpylEWxQ(th);
            return;
        }
        this.f6b2ded51 = true;
        bQTYJbxChBEbBhNW(this, -1);
        ypxWrHkGdnwFPGTj(this.fd22a0a80, th, this, this.fcb5e100e);
    }

    public override void OnNext(T t) {
        if ((2 + 14) % 14 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        java.util.concurrent.atomic.objectArray<java.lang.object> atomicReferenceArray = this.ff09cc7ee;
        int iMHwJJEkZnVJaqviT = mHwJJEkZnVJaqviT(atomicReferenceArray);
        java.lang.object[] objArr = new java.lang.object[iMHwJJEkZnVJaqviT + 1];
        int i = 0;
        objArr[0] = t;
        while (i < iMHwJJEkZnVJaqviT) {
            java.lang.object objKuqzuVGehoCEbZpr = KuqzuVGehoCEbZpr(atomicReferenceArray, i);
            if (objKuqzuVGehoCEbZpr is null) {
                return;
            }
            i++;
            objArr[i] = objKuqzuVGehoCEbZpr;
        }
        try {
            jWSBgnpAjXJjEJrt(this.fd22a0a80, VCnoZLUyyjQWbfaq(SKfIGpbGiBUCNeDR(this.f61aaf8fd, objArr), "combiner returned a null value"), this, this.fcb5e100e);
        } catch (java.lang.Exception th) {
            PazarUdiEDeJVuHr(th);
            ZvnzZhktbBDVYVGh(this);
            VdnXwfyxlJhcuXpy(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        ftfPaxyeIifZHqMp(this.fbc3b0556, p7beea252Var);
    }

    void subscribe(io.reactivex.rxjava3.core.ObservableSource<object>[] observableSourceArr, int i) {
        if ((25 + 17) % 17 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9e84576a$pdca3b148[] p9e84576a_pdca3b148Arr = this.f6ea648a6;
        java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> atomicReference = this.fbc3b0556;
        for (int i2 = 0; i2 < i && !SSpRuFKuwbUOoDhn((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) FZSJIGcifZiBsEkG(atomicReference)) && !this.f6b2ded51; i2++) {
            kdPEMytSJXynEXJQ(observableSourceArr[i2], p9e84576a_pdca3b148Arr[i2]);
        }
    }
}

