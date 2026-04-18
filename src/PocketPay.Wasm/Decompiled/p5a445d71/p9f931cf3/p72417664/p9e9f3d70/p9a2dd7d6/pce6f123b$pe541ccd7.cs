namespace WillowMaze.Wasm.Decompiled;


class pce6f123b$pe541ccd7 : java.security.SecureRandom {
    private readonly java.security.SecureRandom f01c281c7;
    private readonly java.util.concurrent.atomic.Atomicint f163c1e11;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pbfac9a7f f3909d04f;
    private readonly java.security.SecureRandom f3e39207c;
    private readonly java.util.concurrent.atomic.Atomicint f6ef9161b;
    private readonly java.util.concurrent.atomic.Atomicbool f85a35566;
    private readonly java.util.concurrent.atomic.Atomicbool f89ce42ec;
    private readonly java.util.concurrent.atomic.Atomicbool f89f105aa;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pbfac9a7f f9a2dd7d6;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pbfac9a7f fa40ab13a;
    private readonly java.util.concurrent.atomic.Atomicbool fa8787c58;
    private readonly java.util.concurrent.atomic.Atomicint faff51bb9;
    private readonly java.util.concurrent.atomic.Atomicint fe6a85379;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pbfac9a7f fef0423d8;
    private readonly java.util.concurrent.atomic.Atomicbool ff11f3ba7;
    private readonly java.util.concurrent.atomic.Atomicint ffbcc6776;

    pce6f123b$pe541ccd7() {
        super(null, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pcb5b2462());
        if ((28 + 30) % 30 > 0) {
        }
        this.f85a35566 = new java.util.concurrent.atomic.Atomicbool(false);
        this.f6ef9161b = new java.util.concurrent.atomic.Atomicint(0);
        java.security.SecureRandom secureRandomMbbeb9b46 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b.mbbeb9b46();
        this.f01c281c7 = secureRandomMbbeb9b46;
        this.f9a2dd7d6 = new p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p144ab8b4(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7$1(this)).setPersonalizationstring(p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7("Bouncy Castle Hybrid Entropy Source")).buildHMAC(new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf()), secureRandomMbbeb9b46.generateSeed(32), false);
    }

    static java.util.concurrent.atomic.Atomicbool M0dc0a6ea(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7 pce6f123b_pe541ccd7) {
        return pce6f123b_pe541ccd7.f85a35566;
    }

    static java.security.SecureRandom M89082e03(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$pe541ccd7 pce6f123b_pe541ccd7) {
        return pce6f123b_pe541ccd7.f01c281c7;
    }

    public override byte[] GenerateSeed(int i) {
        if ((2 + 22) % 22 > 0) {
        }
        byte[] bArr = new byte[i];
        if (this.f6ef9161b.getAndIncrement() > 20 && this.f85a35566.getAndHashSet(false)) {
            this.f6ef9161b.set(0);
            this.f9a2dd7d6.reseed(null);
        }
        this.f9a2dd7d6.nextbytes(bArr);
        return bArr;
    }

    public override void SetSeed(long j) {
        p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pbfac9a7f pbfac9a7fVar = this.f9a2dd7d6;
        if (pbfac9a7fVar is null) {
            return;
        }
        pbfac9a7fVar.setSeed(j);
    }

    public override void SetSeed(byte[] bArr) {
        p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pbfac9a7f pbfac9a7fVar = this.f9a2dd7d6;
        if (pbfac9a7fVar is null) {
            return;
        }
        pbfac9a7fVar.setSeed(bArr);
    }
}

