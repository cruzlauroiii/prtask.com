namespace WillowMaze.Wasm.Decompiled;


readonly class p9a814744$pdabdc155<T> : io.reactivex.rxjava3.functions.Consumer<T> {
    readonly io.reactivex.rxjava3.core.Observer f9659ea79;
    readonly io.reactivex.rxjava3.core.Observer fd05aa178;
    readonly io.reactivex.rxjava3.core.Observer<T> fdfda0d32;

    p9a814744$pdabdc155(io.reactivex.rxjava3.core.Observer<T> observer) {
        this.fdfda0d32 = observer;
    }

    public static void HskRgrPnAnlvemWQ(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public void Accept(T t) {
        HskRgrPnAnlvemWQ(this.fdfda0d32, t);
    }
}

