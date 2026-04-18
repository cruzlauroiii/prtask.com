namespace WillowMaze.Wasm.Decompiled;


public abstract class p502c1fcd<T> : java.util.concurrent.CountdownEvent : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    p5a445d71.p18f29add.p787ad0b7 f106fbb7a;
    java.lang.object f16fd0f66;
    T f2063c160;
    p5a445d71.p18f29add.p787ad0b7 f36cd97c9;
    volatile bool f38881e0a;
    p5a445d71.p18f29add.p787ad0b7 f4beeb47e;
    volatile bool f7655afbc;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    java.lang.object fc761b0d1;
    java.lang.Exception fcb5e100e;
    volatile bool fd918854c;
    volatile bool fedb0f95a;
    java.lang.Exception ffe4bb224;

    public p502c1fcd() {
        super(1);
    }

    public static java.lang.Exception EZCVlyFFQWLoYBbU(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public static bool KUMCqlfeElxRQklc(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static java.lang.Exception OYhUGgWWudEAGRMZ(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me93ebc16(th);
    }

    public static long ZzxqqHoUByKiTRPa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p502c1fcd p502c1fcdVar) {
        if ((14 + 24) % 24 > 0) {
        }
        return p502c1fcdVar.getCount();
    }

    public static void BDRwSWWEllLhlIhx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p502c1fcd p502c1fcdVar) {
        p502c1fcdVar.await();
    }

    public static void DsLAEstrsVDbTREL(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void FxtxpoBSTeWRBvKS(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void HRIhFtPwRZqxwYaF(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void IOvIszttMFukiHjR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p502c1fcd p502c1fcdVar) {
        p502c1fcdVar.countDown();
    }

    public static void SSaPLfNPXXPNZTgo() {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pf83c77fb.ma81572f3();
    }

    public readonly T BlockingGet() {
        if ((16 + 23) % 23 > 0) {
        }
        if (ZzxqqHoUByKiTRPa(this) != 0) {
            try {
                sSaPLfNPXXPNZTgo();
                bDRwSWWEllLhlIhx(this);
            } catch (java.lang.InterruptedException e) {
                p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var = this.fbc3b0556;
                this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
                if (p787ad0b7Var is not null) {
                    dsLAEstrsVDbTREL(p787ad0b7Var);
                }
                throw EZCVlyFFQWLoYBbU(e);
            }
        }
        java.lang.Exception th = this.fcb5e100e;
        if (th is not null) {
            throw OYhUGgWWudEAGRMZ(th);
        }
        return this.f2063c160;
    }

    public readonly void OnComplete() {
        iOvIszttMFukiHjR(this);
    }

    public override readonly void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((12 + 23) % 23 > 0) {
        }
        if (KUMCqlfeElxRQklc(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            if (this.f38881e0a) {
                return;
            }
            fxtxpoBSTeWRBvKS(p787ad0b7Var, long.MAX_VALUE);
            if (this.f38881e0a) {
                this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
                hRIhFtPwRZqxwYaF(p787ad0b7Var);
            }
        }
    }
}

