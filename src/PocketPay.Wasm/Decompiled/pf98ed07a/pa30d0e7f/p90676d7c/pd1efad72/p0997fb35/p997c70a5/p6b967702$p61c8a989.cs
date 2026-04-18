namespace WillowMaze.Wasm.Decompiled;


readonly class p6b967702$p61c8a989<T> : io.reactivex.rxjava3.observers.DefaultObserver<T> {
    volatile java.lang.object f2063c160;
    volatile java.lang.object f2a89226a;

    p6b967702$p61c8a989(T t) {
        this.f2063c160 = FHqUDUmNpWxuweZB(t);
    }

    public static java.lang.object BIQbZaDupUZKwXcZ(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.next(obj);
    }

    public static java.lang.object FHqUDUmNpWxuweZB(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.next(obj);
    }

    public static java.lang.object QycbraALhAkaRNRu(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.error(th);
    }

    public static java.lang.object TsGECpjYeebKSAfY() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.complete();
    }

    public io.reactivex.rxjava3.internal.operators.observable.BlockingObservableMostRecent$MostRecentObserver<T>.BlockingObservableMostRecent$MostRecentObserver$MostRecentIEnumerator getIEnumerable() {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6b967702$p61c8a989$p5e28cf10(this);
    }

    public void OnComplete() {
        this.f2063c160 = tsGECpjYeebKSAfY();
    }

    public void OnError(java.lang.Exception th) {
        this.f2063c160 = qycbraALhAkaRNRu(th);
    }

    public void OnNext(T t) {
        this.f2063c160 = BIQbZaDupUZKwXcZ(t);
    }
}

