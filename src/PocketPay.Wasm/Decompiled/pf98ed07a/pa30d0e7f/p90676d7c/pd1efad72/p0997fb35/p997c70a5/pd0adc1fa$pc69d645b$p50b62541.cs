namespace WillowMaze.Wasm.Decompiled;


readonly class pd0adc1fa$pc69d645b$p50b62541<R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<R> {
    private static readonly long fc6e1e520 = 2620149119579502636L;
    private static readonly long fe4cb44c1 = 2620149119579502636L;
    readonly io.reactivex.rxjava3.core.Observer f1d3f53ea;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b f21d73574;
    readonly io.reactivex.rxjava3.core.Observer fa0dee886;
    readonly io.reactivex.rxjava3.core.Observer fb83f1af0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b fc0b7a43c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b fc984e857;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver<object, R> fd0e45878;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;

    pd0adc1fa$pc69d645b$p50b62541(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver<object, R> observableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver) {
        this.fd22a0a80 = observer;
        this.fd0e45878 = observableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver;
    }

    public static void CdMPcGCMmHLDdCpI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b pd0adc1fa_pc69d645b) {
        pd0adc1fa_pc69d645b.drain();
    }

    public static void SRpWljWPektKQUmE(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void SZJEgUHcDusgRMLL(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool XTcmtSNnsSzhApqo(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool AMeRPCOrKvvTxSSV(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static bool LWHQtFbXOyxbFwgE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void OrFkYQLQDrcpWFkw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b pd0adc1fa_pc69d645b) {
        pd0adc1fa_pc69d645b.drain();
    }

    void dispose() {
        XTcmtSNnsSzhApqo(this);
    }

    public override void OnComplete() {
        io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver<object, R> observableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver = this.fd0e45878;
        observableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver.fc76a5e84 = false;
        orFkYQLQDrcpWFkw(observableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver);
    }

    public override void OnError(java.lang.Exception th) {
        io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver<object, R> observableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver = this.fd0e45878;
        if (lWHQtFbXOyxbFwgE(observableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver.f07213a01, th)) {
            if (!observableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver.f5b5965a0) {
                SRpWljWPektKQUmE(observableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver.fbc3b0556);
            }
            observableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver.fc76a5e84 = false;
            CdMPcGCMmHLDdCpI(observableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver);
        }
    }

    public override void OnNext(R r) {
        SZJEgUHcDusgRMLL(this.fd22a0a80, r);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        aMeRPCOrKvvTxSSV(this, p7beea252Var);
    }
}

