namespace WillowMaze.Wasm.Decompiled;


readonly class p975b8e81$p178e26c5<T> : io.reactivex.rxjava3.functions.Consumer<T> {
    readonly p5a445d71.p18f29add.p992c4a5b f1c66d6da;
    readonly p5a445d71.p18f29add.p992c4a5b f50f4eba7;
    readonly org.reactivestreams.Subscriber<T> f9367a975;
    readonly p5a445d71.p18f29add.p992c4a5b ffe58c3a6;

    p975b8e81$p178e26c5(org.reactivestreams.Subscriber<T> subscriber) {
        this.f9367a975 = subscriber;
    }

    public static void AcIwjDDXiIGUdUnD(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public void Accept(T t) {
        AcIwjDDXiIGUdUnD(this.f9367a975, t);
    }
}

