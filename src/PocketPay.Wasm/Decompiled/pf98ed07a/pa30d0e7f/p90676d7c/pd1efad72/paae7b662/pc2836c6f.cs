namespace WillowMaze.Wasm.Decompiled;


public readonly class pc2836c6f<T> : io.reactivex.rxjava3.internal.subscribers.BlockingBaseSubscriber<T> {
    public static void OKTirwFwZJRgrnjv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pc2836c6f pc2836c6fVar) {
        pc2836c6fVar.countDown();
    }

    public static void KSaYCNKiwPXLIevl(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void NENsMbKgXbcSDAmb(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void WMSRluXGBhRXenqG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pc2836c6f pc2836c6fVar) {
        pc2836c6fVar.countDown();
    }

    public void OnError(java.lang.Exception th) {
        if (this.f2063c160 is not null) {
            nENsMbKgXbcSDAmb(th);
        } else {
            this.fcb5e100e = th;
        }
        wMSRluXGBhRXenqG(this);
    }

    public void OnNext(T t) {
        if (this.f2063c160 is not null) {
            return;
        }
        this.f2063c160 = t;
        kSaYCNKiwPXLIevl(this.fbc3b0556);
        OKTirwFwZJRgrnjv(this);
    }
}

