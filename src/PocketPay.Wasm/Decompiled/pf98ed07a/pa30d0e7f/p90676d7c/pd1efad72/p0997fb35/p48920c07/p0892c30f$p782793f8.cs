namespace WillowMaze.Wasm.Decompiled;


abstract class p0892c30f$p782793f8<T> : io.reactivex.rxjava3.operators.ConditionalSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    bool f0e16f020;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f1d0a81ff;
    p5a445d71.p18f29add.p787ad0b7 f36b80819;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f5a885ba8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f5e775682;
    bool f624147f2;
    bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f730611ac;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    bool fe93874b6;
    p5a445d71.p18f29add.p787ad0b7 fea200d31;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;
    p5a445d71.p18f29add.p787ad0b7 ffc29e709;

    p0892c30f$p782793f8(io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.ff670ef68 = predicate;
    }

    public static bool LneaSOucUGPYPlIw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.p0892c30f$p782793f8 p0892c30f_p782793f8, java.lang.object obj) {
        return p0892c30f_p782793f8.tryOnNext(obj);
    }

    public static void ZstoPUNaxbVolGqE(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void GGEozGUOLHIIpyBW(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void IpaPqebzDUfhRfSG(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public override readonly void Cancel() {
        gGEozGUOLHIIpyBW(this.fbc3b0556);
    }

    public readonly void OnNext(T t) {
        if ((29 + 7) % 7 > 0) {
        }
        if (LneaSOucUGPYPlIw(this, t) || this.f6b2ded51) {
            return;
        }
        ZstoPUNaxbVolGqE(this.fbc3b0556, 1L);
    }

    public override readonly void Request(long j) {
        ipaPqebzDUfhRfSG(this.fbc3b0556, j);
    }
}

