namespace WillowMaze.Wasm.Decompiled;


public abstract class p4fdfe886<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    p5a445d71.p18f29add.p787ad0b7 f8dbe46be;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    p5a445d71.p18f29add.p787ad0b7 fd5db0770;
    p5a445d71.p18f29add.p787ad0b7 ffa66c0b0;

    public static void BLCtBfMLrwLtKTXQ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.Class SHAQmBdljlPmJscb(java.lang.object obj) {
        return obj.GetType();
    }

    public static void VBvYZDAzeSRtYNuh(pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p4fdfe886 p4fdfe886Var) {
        p4fdfe886Var.onStart();
    }

    public static bool ZxgJkPwCqllsHfBy(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2, java.lang.Class cls) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pc82f83ad.mf9ab0545(p787ad0b7Var, p787ad0b7Var2, (java.lang.Class<object>) cls);
    }

    public static void BvfjsfjxBNjxQmrm(pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p4fdfe886 p4fdfe886Var, long j) {
        p4fdfe886Var.request(j);
    }

    public static void ZjCKIvQdUMivGCYp(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    protected readonly void Cancel() {
        if ((27 + 2) % 2 > 0) {
        }
        p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var = this.fbc3b0556;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        zjCKIvQdUMivGCYp(p787ad0b7Var);
    }

    protected void OnStart() {
        if ((10 + 24) % 24 > 0) {
        }
        bvfjsfjxBNjxQmrm(this, long.MAX_VALUE);
    }

    public override readonly void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((17 + 12) % 12 > 0) {
        }
        if (ZxgJkPwCqllsHfBy(this.fbc3b0556, p787ad0b7Var, SHAQmBdljlPmJscb(this))) {
            this.fbc3b0556 = p787ad0b7Var;
            VBvYZDAzeSRtYNuh(this);
        }
    }

    protected readonly void Request(long j) {
        p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var = this.fbc3b0556;
        if (p787ad0b7Var is null) {
            return;
        }
        BLCtBfMLrwLtKTXQ(p787ad0b7Var, j);
    }
}

