namespace WillowMaze.Wasm.Decompiled;


readonly class p748b767e$pa01d495c<T> : java.util.concurrent.atomic.Atomicint : p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f198c6054 = 466549804534799122L;
    private static readonly long f44d0aef2 = 466549804534799122L;
    private static readonly long fc6e1e520 = 466549804534799122L;
    java.lang.object f098f3aac;
    readonly p5a445d71.p18f29add.p992c4a5b f10362322;
    volatile bool f29969986;
    volatile bool f2fc4fd8f;
    java.lang.object f3185be9a;
    volatile bool f38881e0a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p748b767e f490efc0b;
    volatile bool f54231cfb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p748b767e f5c3bc914;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly p5a445d71.p18f29add.p992c4a5b f6a71ccbf;
    java.lang.object f6a992d55;
    readonly java.util.concurrent.atomic.Atomiclong f70e8900c;
    long f75bffecb;
    long f7f635c2b;
    readonly java.util.concurrent.atomic.Atomiclong f82678e09;
    readonly java.util.concurrent.atomic.Atomiclong f847a9059;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p748b767e f893a45b0;
    volatile bool f8a74a071;
    long f8bc8a991;
    java.lang.object f979dca39;
    readonly io.reactivex.rxjava3.processors.ReplayProcessor<T> f9ed39e2e;
    readonly p5a445d71.p18f29add.p992c4a5b fa180da48;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p748b767e fec61ef34;

    p748b767e$pa01d495c(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.processors.ReplayProcessor<T> replayProcessor) {
        this.fd22a0a80 = subscriber;
        this.f9ed39e2e = replayProcessor;
    }

    public static void BdbiiydzCEiUbVFo(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p748b767e$p244f52bf p748b767e_p244f52bf, pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p748b767e$pa01d495c p748b767e_pa01d495c) {
        p748b767e_p244f52bf.replay(p748b767e_pa01d495c);
    }

    public static void KEdcDqQhCmhoZRgH(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p748b767e p748b767eVar, pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p748b767e$pa01d495c p748b767e_pa01d495c) {
        p748b767eVar.Remove(p748b767e_pa01d495c);
    }

    public static bool CtpMNciYCmqJwIzS(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static long IhWosXPiqxdNHITo(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((22 + 27) % 27 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public override void Cancel() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        KEdcDqQhCmhoZRgH(this.f9ed39e2e, this);
    }

    public override void Request(long j) {
        if (ctpMNciYCmqJwIzS(j)) {
            ihWosXPiqxdNHITo(this.f67a14a21, j);
            BdbiiydzCEiUbVFo(this.f9ed39e2e.f7f2db423, this);
        }
    }
}

