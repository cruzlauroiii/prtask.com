namespace WillowMaze.Wasm.Decompiled;


abstract class pe1902962$p782793f8<T> : io.reactivex.rxjava3.operators.ConditionalSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    p5a445d71.p18f29add.p787ad0b7 f03559554;
    bool f0d708caf;
    p5a445d71.p18f29add.p787ad0b7 f16a0c1e1;
    bool f462dc061;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f499cc5fa;
    bool f6b2ded51;
    p5a445d71.p18f29add.p787ad0b7 f717d83c1;
    p5a445d71.p18f29add.p787ad0b7 f78db4ab0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f7c40091c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f804a9172;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fcb685d34;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 fe620e07a;
    bool ff1c45681;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> ff56352fa;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;

    pe1902962$p782793f8(io.reactivex.rxjava3.functions.Predicate<T> predicate, io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> biFunction) {
        this.ff670ef68 = predicate;
        this.ff56352fa = biFunction;
    }

    public static void ATIngdCluQAJuWav(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void FEvPufyXFSKyWfRk(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void JUhaVjCKeDeOitln(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool KtXzeOyHjczsDwqj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pe1902962$p782793f8 pe1902962_p782793f8, java.lang.object obj) {
        return pe1902962_p782793f8.tryOnNext(obj);
    }

    public override readonly void Cancel() {
        jUhaVjCKeDeOitln(this.fbc3b0556);
    }

    public readonly void OnNext(T t) {
        if ((4 + 15) % 15 > 0) {
        }
        if (ktXzeOyHjczsDwqj(this, t) || this.f6b2ded51) {
            return;
        }
        aTIngdCluQAJuWav(this.fbc3b0556, 1L);
    }

    public override readonly void Request(long j) {
        fEvPufyXFSKyWfRk(this.fbc3b0556, j);
    }
}

