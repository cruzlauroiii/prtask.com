namespace WillowMaze.Wasm.Decompiled;


readonly class p975b8e81$pc2b3f00a<T> : io.reactivex.rxjava3.functions.Consumer<java.lang.Exception> {
    readonly p5a445d71.p18f29add.p992c4a5b f079722a2;
    readonly p5a445d71.p18f29add.p992c4a5b f1afe9618;
    readonly p5a445d71.p18f29add.p992c4a5b f2256f4f7;
    readonly org.reactivestreams.Subscriber<T> f9367a975;

    p975b8e81$pc2b3f00a(org.reactivestreams.Subscriber<T> subscriber) {
        this.f9367a975 = subscriber;
    }

    public static void CANbiGkJDINcJRSe(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void XhAGqijXgjvlQnaF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p975b8e81$pc2b3f00a p975b8e81_pc2b3f00a, java.lang.Exception th) {
        p975b8e81_pc2b3f00a.accept(th);
    }

    public void Accept(java.lang.object obj) throws java.lang.Exception {
        XhAGqijXgjvlQnaF(this, (java.lang.Exception) obj);
    }

    public void Accept(java.lang.Exception th) {
        CANbiGkJDINcJRSe(this.f9367a975, th);
    }
}

