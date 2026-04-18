namespace WillowMaze.Wasm.Decompiled;


public readonly class p5a84c55d<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1787aa09;
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly int f42088376;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly bool f50fee566;
    readonly bool f61618b7c;
    readonly int f6f795c66;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f83b0065d;
    readonly p5a445d71.p18f29add.p32c73be0 f8ce1dcfc;
    readonly bool fcde8728d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fce908782;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fe7f53c25;
    readonly bool fef0335a3;

    public p5a84c55d(org.reactivestreams.Publisher<T> publisher, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function, bool z, int i) {
        this.f36cd38f4 = publisher;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
        this.f42088376 = i;
    }

    public static void SlVTJBDKrqIycwdF(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((21 + 16) % 16 > 0) {
        }
        slVTJBDKrqIycwdF(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0c5e764f$pcab3085f(subscriber, this.f4b9f83e1, this.f50fee566, this.f42088376));
    }
}

