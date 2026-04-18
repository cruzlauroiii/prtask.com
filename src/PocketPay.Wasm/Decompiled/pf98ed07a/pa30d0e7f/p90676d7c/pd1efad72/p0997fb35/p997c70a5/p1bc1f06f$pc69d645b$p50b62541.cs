namespace WillowMaze.Wasm.Decompiled;


readonly class p1bc1f06f$pc69d645b$p50b62541<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<R> {
    private static readonly long f3254c145 = 2620149119579502636L;
    private static readonly long f9b3f3364 = 2620149119579502636L;
    private static readonly long fc6e1e520 = 2620149119579502636L;
    readonly io.reactivex.rxjava3.core.Observer f5ba77cd1;
    readonly io.reactivex.rxjava3.core.Observer f5ff5d7b3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b f89332242;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b f8ddd9495;
    readonly io.reactivex.rxjava3.core.Observer fa0b573a3;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionary$ConcatDictionaryDelayErrorObserver<object, R> fd0e45878;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b fed3b64dc;
    readonly io.reactivex.rxjava3.core.Observer ff24e356a;

    p1bc1f06f$pc69d645b$p50b62541(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionary$ConcatDictionaryDelayErrorObserver<object, R> observableConcatDictionary$ConcatDictionaryDelayErrorObserver) {
        this.fd22a0a80 = observer;
        this.fd0e45878 = observableConcatDictionary$ConcatDictionaryDelayErrorObserver;
    }

    public static void FJDQeHjLaGBswkUy(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void HBsffuHvbebZokcq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b p1bc1f06f_pc69d645b) {
        p1bc1f06f_pc69d645b.drain();
    }

    public static bool IcSzQJkWTpVTQCxN(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static bool KNpJeJoxRRycbQBd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void UeTyKESLLfCbZYEZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void ZQaMTUEPVWqTdSLi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p1bc1f06f$pc69d645b p1bc1f06f_pc69d645b) {
        p1bc1f06f_pc69d645b.drain();
    }

    public static bool FPAhIrxFviKnXiXw(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    void dispose() {
        fPAhIrxFviKnXiXw(this);
    }

    public override void OnComplete() {
        io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionary$ConcatDictionaryDelayErrorObserver<object, R> observableConcatDictionary$ConcatDictionaryDelayErrorObserver = this.fd0e45878;
        observableConcatDictionary$ConcatDictionaryDelayErrorObserver.fc76a5e84 = false;
        HBsffuHvbebZokcq(observableConcatDictionary$ConcatDictionaryDelayErrorObserver);
    }

    public override void OnError(java.lang.Exception th) {
        io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionary$ConcatDictionaryDelayErrorObserver<object, R> observableConcatDictionary$ConcatDictionaryDelayErrorObserver = this.fd0e45878;
        if (KNpJeJoxRRycbQBd(observableConcatDictionary$ConcatDictionaryDelayErrorObserver.f07213a01, th)) {
            if (!observableConcatDictionary$ConcatDictionaryDelayErrorObserver.f5b5965a0) {
                UeTyKESLLfCbZYEZ(observableConcatDictionary$ConcatDictionaryDelayErrorObserver.fbc3b0556);
            }
            observableConcatDictionary$ConcatDictionaryDelayErrorObserver.fc76a5e84 = false;
            ZQaMTUEPVWqTdSLi(observableConcatDictionary$ConcatDictionaryDelayErrorObserver);
        }
    }

    public override void OnNext(R r) {
        FJDQeHjLaGBswkUy(this.fd22a0a80, r);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        IcSzQJkWTpVTQCxN(this, p7beea252Var);
    }
}

