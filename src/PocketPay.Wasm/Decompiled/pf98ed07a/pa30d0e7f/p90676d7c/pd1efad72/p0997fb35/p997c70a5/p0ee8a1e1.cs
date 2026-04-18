namespace WillowMaze.Wasm.Decompiled;


public readonly class p0ee8a1e1<T> : io.reactivex.rxjava3.core.Observable<T> {
    readonly org.reactivestreams.Publisher<? : T> f36cd38f4;
    readonly p5a445d71.p18f29add.p32c73be0 f8c9bdc9e;
    readonly p5a445d71.p18f29add.p32c73be0 fe5b250fb;

    public p0ee8a1e1(org.reactivestreams.Publisher<? : T> publisher) {
        this.f36cd38f4 = publisher;
    }

    public static void VaBkvIdKlExbuNec(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        vaBkvIdKlExbuNec(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0ee8a1e1$p8b01a664(observer));
    }
}

