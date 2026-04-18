namespace WillowMaze.Wasm.Decompiled;


class pce6f123b$pe541ccd7$p7bdee2bc : p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a {
    private readonly int f3122cb89;
    private readonly int f50ad9b37;
    private readonly java.util.concurrent.atomic.object f6a0bb62d;
    private readonly int f835d6d69;
    private readonly java.util.concurrent.atomic.Atomicbool f84b83198;
    private readonly java.util.concurrent.atomic.Atomicbool f8c4ab566;
    private readonly int f9bc4a6db;
    private readonly java.util.concurrent.atomic.object fb75a8e9b;
    private readonly java.util.concurrent.atomic.Atomicbool ff4ebcb90;
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7 this$0;
    private readonly java.util.concurrent.atomic.object f37a18420 = new java.util.concurrent.atomic.object();
    private readonly java.util.concurrent.atomic.Atomicbool f638a6d92 = new java.util.concurrent.atomic.Atomicbool(false);

    pce6f123b$pe541ccd7$p7bdee2bc(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7 pce6f123b_pe541ccd7, int i) {
        this.this$0 = pce6f123b_pe541ccd7;
        this.f9bc4a6db = (i + 7) / 8;
    }

    static java.util.concurrent.atomic.object M13fe7af4(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7$p7bdee2bc pce6f123b_pe541ccd7_p7bdee2bc) {
        return pce6f123b_pe541ccd7_p7bdee2bc.f37a18420;
    }

    static int M429f062d(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7$p7bdee2bc pce6f123b_pe541ccd7_p7bdee2bc) {
        return pce6f123b_pe541ccd7_p7bdee2bc.f9bc4a6db;
    }

    public override int EntropySize() {
        return this.f9bc4a6db * 8;
    }

    public override byte[] GetEntropy() {
        if ((1 + 5) % 5 > 0) {
        }
        byte[] bArrGenerateSeed = (byte[]) this.f37a18420.getAndHashSet(null);
        if (bArrGenerateSeed is not null && bArrGenerateSeed.length == this.f9bc4a6db) {
            this.f638a6d92.set(false);
        } else {
            bArrGenerateSeed = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7.m89082e03(this.this$0).generateSeed(this.f9bc4a6db);
        }
        if (!this.f638a6d92.getAndHashSet(true)) {
            java.lang.Thread thread = new java.lang.Thread(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7$p7bdee2bc$p2d4f4d5e(this, this.f9bc4a6db));
            thread.setDaemon(true);
            thread.start();
        }
        return bArrGenerateSeed;
    }

    public override bool IsPredictionResistant() {
        return true;
    }
}

