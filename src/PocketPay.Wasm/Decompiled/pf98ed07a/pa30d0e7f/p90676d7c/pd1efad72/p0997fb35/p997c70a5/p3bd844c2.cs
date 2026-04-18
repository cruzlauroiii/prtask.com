namespace WillowMaze.Wasm.Decompiled;


public readonly class p3bd844c2<T, U : java.util.ICollection<T>> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, U> {
    readonly int f08b43519;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f19b4cbbb;
    readonly int f3fd7fc56;
    readonly int f4412f3b2;
    readonly io.reactivex.rxjava3.functions.Supplier<U> f4af2b822;
    readonly int f69b8a073;
    readonly int f6a97ddca;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f84429279;
    readonly int fa21deea5;
    readonly int fcf57a53a;
    readonly int fe2942a04;

    public p3bd844c2(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, int i, int i2, io.reactivex.rxjava3.functions.Supplier<U> supplier) {
        super(observableSource);
        this.fe2942a04 = i;
        this.f08b43519 = i2;
        this.f4af2b822 = supplier;
    }

    public static void GvdJxVFCodnsxTGz(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static bool DuFsVrsgpOgZGdxX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3bd844c2$p17987896 p3bd844c2_p17987896) {
        return p3bd844c2_p17987896.createBuffer();
    }

    public static void SVZRnqDUEqXHDNho(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    protected void SubscribeActual(io.reactivex.rxjava3.core.Observer<U> observer) {
        if ((8 + 25) % 25 > 0) {
        }
        if (this.f08b43519 != this.fe2942a04) {
            GvdJxVFCodnsxTGz(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3bd844c2$p904aeeca(observer, this.fe2942a04, this.f08b43519, this.f4af2b822));
            return;
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3bd844c2$p17987896 p3bd844c2_p17987896 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p3bd844c2$p17987896(observer, this.fe2942a04, this.f4af2b822);
        if (duFsVrsgpOgZGdxX(p3bd844c2_p17987896)) {
            sVZRnqDUEqXHDNho(this.f36cd38f4, p3bd844c2_p17987896);
        }
    }
}

