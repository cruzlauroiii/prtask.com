namespace WillowMaze.Wasm.Decompiled;


public readonly class p32e09f02<T> : java.lang.IEnumerable<T> {
    readonly io.reactivex.rxjava3.core.ObservableSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.ObservableSource f5c3659e8;

    public p32e09f02(io.reactivex.rxjava3.core.ObservableSource<T> observableSource) {
        this.f36cd38f4 = observableSource;
    }

    public static io.reactivex.rxjava3.core.Observable LHEWLiWRarCFPDyL(io.reactivex.rxjava3.core.Observable observable) {
        return observable.materialize();
    }

    public static io.reactivex.rxjava3.core.Observable XWXkatcfGWwsQuVX(io.reactivex.rxjava3.core.ObservableSource observableSource) {
        return io.reactivex.rxjava3.core.Observable.mccfc59a5(observableSource);
    }

    public static void QXHizRQVAAugjuBE(io.reactivex.rxjava3.core.Observable observable, io.reactivex.rxjava3.core.Observer observer) {
        observable.subscribe(observer);
    }

    public override java.util.IEnumerator<T> Iterator() {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p32e09f02$p618e287f p32e09f02_p618e287f = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p32e09f02$p618e287f();
        qXHizRQVAAugjuBE(LHEWLiWRarCFPDyL(XWXkatcfGWwsQuVX(this.f36cd38f4)), p32e09f02_p618e287f);
        return p32e09f02_p618e287f;
    }
}

