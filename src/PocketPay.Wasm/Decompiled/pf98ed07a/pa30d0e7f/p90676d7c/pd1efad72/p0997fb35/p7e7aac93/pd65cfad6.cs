namespace WillowMaze.Wasm.Decompiled;


public readonly class pd65cfad6<T> : io.reactivex.rxjava3.core.Flowable<T> {
    readonly io.reactivex.rxjava3.core.MaybeSource[] f7fee3ac7;
    readonly io.reactivex.rxjava3.core.MaybeSource<? : T>[] ff2ab5fb2;

    public pd65cfad6(io.reactivex.rxjava3.core.MaybeSource<? : T>[] maybeSourceArr) {
        this.ff2ab5fb2 = maybeSourceArr;
    }

    public static void FpNxKHydKtlNkUZX(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void HmLBMZKIcNntSnjL(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static int OPdBVmUzoIdBOVEu() {
        return bufferSize();
    }

    public static java.lang.object VoTzEHCWWauBauvB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static bool VriHCEJHtgMgSfTb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pf2ce2286 pd65cfad6_pf2ce2286) {
        return pd65cfad6_pf2ce2286.isCancelled();
    }

    protected override void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((14 + 25) % 25 > 0) {
        }
        io.reactivex.rxjava3.core.MaybeSource<? : T>[] maybeSourceArr = this.ff2ab5fb2;
        int length = maybeSourceArr.length;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pf2ce2286 pd65cfad6_pf2ce2286 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pf2ce2286(subscriber, length, length > OPdBVmUzoIdBOVEu() ? new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$p2d7f2a5e() : new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$p3cdf5580(length));
        HmLBMZKIcNntSnjL(subscriber, pd65cfad6_pf2ce2286);
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar = pd65cfad6_pf2ce2286.f07213a01;
        for (io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource : maybeSourceArr) {
            if (VriHCEJHtgMgSfTb(pd65cfad6_pf2ce2286) || VoTzEHCWWauBauvB(p36a52e5dVar) is not null) {
                return;
            }
            FpNxKHydKtlNkUZX(maybeSource, pd65cfad6_pf2ce2286);
        }
    }
}

