namespace WillowMaze.Wasm.Decompiled;


public readonly class pdd1d1158<T, R> : io.reactivex.rxjava3.core.Flowable<R> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0809ba41;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f14ebffa6;
    readonly org.reactivestreams.Publisher<T> f36cd38f4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> f4b9f83e1;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f4d1a4d73;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f560019e4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5e910ad6;
    readonly int f7c3516b3;
    readonly p5a445d71.p18f29add.p32c73be0 f7ea32dc2;
    readonly int fac484523;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 fccaebcff;
    readonly p5a445d71.p18f29add.p32c73be0 fd13a9f51;
    readonly p5a445d71.p18f29add.p32c73be0 fd392ea66;
    readonly p5a445d71.p18f29add.p32c73be0 fd4e88b54;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 fde869c77;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 ff319e1bd;
    readonly int fffd37e65;

    public pdd1d1158(org.reactivestreams.Publisher<T> publisher, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.SingleSource<? : R>> function, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var, int i) {
        this.f36cd38f4 = publisher;
        this.f4b9f83e1 = function;
        this.f560019e4 = pcd04add9Var;
        this.f4c203b76 = i;
    }

    public static void VlVmBjbHtzQxknTG(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((10 + 15) % 15 > 0) {
        }
        VlVmBjbHtzQxknTG(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p656efe82$pc1f6a0ba(subscriber, this.f4b9f83e1, this.f4c203b76, this.f560019e4));
    }
}

