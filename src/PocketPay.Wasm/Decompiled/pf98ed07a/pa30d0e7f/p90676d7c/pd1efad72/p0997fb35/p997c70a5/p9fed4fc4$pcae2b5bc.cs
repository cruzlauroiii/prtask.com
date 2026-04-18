namespace WillowMaze.Wasm.Decompiled;


readonly class p9fed4fc4$pcae2b5bc<K, T> : io.reactivex.rxjava3.observables.GroupedObservable<K, T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c f04d3796d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c f9cfca54c;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableGroupBy$State<T, K> f9ed39e2e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c fa07581ce;

    protected p9fed4fc4$pcae2b5bc(K k, io.reactivex.rxjava3.internal.operators.observable.ObservableGroupBy$State<T, K> observableGroupBy$State) {
        super(k);
        this.f9ed39e2e = observableGroupBy$State;
    }

    public static void JhwRLQVrbKhClcqn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c, java.lang.Exception th) {
        p9fed4fc4_p46a2a41c.onError(th);
    }

    public static void NsejTGrcxyrIxPDu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c, io.reactivex.rxjava3.core.Observer observer) {
        p9fed4fc4_p46a2a41c.subscribe(observer);
    }

    public static void XbwJbKacIMtfBCgt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c) {
        p9fed4fc4_p46a2a41c.onComplete();
    }

    public static <T, K> io.reactivex.rxjava3.internal.operators.observable.ObservableGroupBy$GroupedUnicast<K, T> m94f56f66(K k, int i, io.reactivex.rxjava3.internal.operators.observable.ObservableGroupBy$GroupByObserver<object, K, T> observableGroupBy$GroupByObserver, bool z) {
        return new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$pcae2b5bc(k, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c(i, observableGroupBy$GroupByObserver, k, z));
    }

    public static void QHogMhTmNHOHRNsY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c, java.lang.object obj) {
        p9fed4fc4_p46a2a41c.onNext(obj);
    }

    public void OnComplete() {
        XbwJbKacIMtfBCgt(this.f9ed39e2e);
    }

    public void OnError(java.lang.Exception th) {
        JhwRLQVrbKhClcqn(this.f9ed39e2e, th);
    }

    public void OnNext(T t) {
        qHogMhTmNHOHRNsY(this.f9ed39e2e, t);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        NsejTGrcxyrIxPDu(this.f9ed39e2e, observer);
    }
}

