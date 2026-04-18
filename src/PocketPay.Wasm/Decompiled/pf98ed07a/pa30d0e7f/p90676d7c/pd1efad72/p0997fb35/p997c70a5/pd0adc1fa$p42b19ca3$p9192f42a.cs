namespace WillowMaze.Wasm.Decompiled;


readonly class pd0adc1fa$p42b19ca3$p9192f42a<U> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<U> {
    private static readonly long f483ddbbd = -7449079488798789337L;
    private static readonly long fc6e1e520 = -7449079488798789337L;
    readonly io.reactivex.rxjava3.core.Observer f5d8383b1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3 f60b9a6de;
    readonly io.reactivex.rxjava3.core.Observer fa1a3d1c1;
    readonly io.reactivex.rxjava3.core.Observer fc5a17f09;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3 fcb39d4c9;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionaryScheduler$ConcatDictionaryObserver<object, object> fd0e45878;
    readonly io.reactivex.rxjava3.core.Observer<U> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Observer fdb3a69c8;

    pd0adc1fa$p42b19ca3$p9192f42a(io.reactivex.rxjava3.core.Observer<U> observer, io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionaryScheduler$ConcatDictionaryObserver<object, object> observableConcatDictionaryScheduler$ConcatDictionaryObserver) {
        this.fd22a0a80 = observer;
        this.fd0e45878 = observableConcatDictionaryScheduler$ConcatDictionaryObserver;
    }

    public static bool NWuNwDUisHfmJkcm(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void UZnrvtEUXBnLvJZH(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void BpYiVsfpuvfdmVFv(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void DwkNSQFhZbKkZuqp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3 pd0adc1fa_p42b19ca3) {
        pd0adc1fa_p42b19ca3.innerComplete();
    }

    public static bool VuolNHYVRQLIQtye(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void ZeHmTDAwyNfAFoiH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3 pd0adc1fa_p42b19ca3) {
        pd0adc1fa_p42b19ca3.dispose();
    }

    void dispose() {
        NWuNwDUisHfmJkcm(this);
    }

    public override void OnComplete() {
        dwkNSQFhZbKkZuqp(this.fd0e45878);
    }

    public override void OnError(java.lang.Exception th) {
        zeHmTDAwyNfAFoiH(this.fd0e45878);
        UZnrvtEUXBnLvJZH(this.fd22a0a80, th);
    }

    public override void OnNext(U u) {
        bpYiVsfpuvfdmVFv(this.fd22a0a80, u);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        vuolNHYVRQLIQtye(this, p7beea252Var);
    }
}

