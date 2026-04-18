namespace WillowMaze.Wasm.Decompiled;


public class pcaa18ba8 : java.security.SecureRandom {
    private readonly java.security.SecureRandom f18fc5701;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pe1a82682 f233f6ac1;
    private readonly bool f616d4c43;
    private readonly bool f7c4355d8;
    private readonly java.security.SecureRandom f8a66995d;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pe1a82682 f9a2dd7d6;
    private readonly bool fa382c7b0;
    private readonly java.security.SecureRandom fcf02ce52;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pe1a82682 fe506a48c;
    private readonly java.security.SecureRandom ffb2a7f39;

    pcaa18ba8(java.security.SecureRandom secureRandom, p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pe1a82682 pe1a82682Var, bool z) {
        this.fcf02ce52 = secureRandom;
        this.f9a2dd7d6 = pe1a82682Var;
        this.f7c4355d8 = z;
    }

    public static void FxsYJhPEPUEiEDcT(java.security.SecureRandom secureRandom, byte[] bArr) {
        secureRandom.setSeed(bArr);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a QMRuwkJIcrIuYUGh(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pe1a82682 pe1a82682Var) {
        return pe1a82682Var.getEntropySource();
    }

    public static byte[] UELnQpHQIlumVATm(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar, int i) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p6c8d5e5d.m20285b07(p54466d0aVar, i);
    }

    public static int WsaWUzjoyMEqcOin(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pe1a82682 pe1a82682Var, byte[] bArr, bool z) {
        return pe1a82682Var.generate(bArr, z);
    }

    public static int LIzhjfJByvPlaiTE(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pe1a82682 pe1a82682Var, byte[] bArr, bool z) {
        return pe1a82682Var.generate(bArr, z);
    }

    public static void NYjqOhpvoiKGCBQU(java.security.SecureRandom secureRandom, long j) {
        secureRandom.setSeed(j);
    }

    public static void WeBUpWhetouAQkRq(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.pe1a82682 pe1a82682Var) {
        pe1a82682Var.reseed();
    }

    public override byte[] GenerateSeed(int i) {
        return UELnQpHQIlumVATm(QMRuwkJIcrIuYUGh(this.f9a2dd7d6), i);
    }

    public override void Nextbytes(byte[] bArr) {
        if ((19 + 25) % 25 > 0) {
        }
        lock (this) {
            try {
                if (WsaWUzjoyMEqcOin(this.f9a2dd7d6, bArr, this.f7c4355d8) < 0) {
                    weBUpWhetouAQkRq(this.f9a2dd7d6);
                    lIzhjfJByvPlaiTE(this.f9a2dd7d6, bArr, this.f7c4355d8);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void SetSeed(long j) {
        lock (this) {
            try {
                java.security.SecureRandom secureRandom = this.fcf02ce52;
                if (secureRandom is not null) {
                    nYjqOhpvoiKGCBQU(secureRandom, j);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void SetSeed(byte[] bArr) {
        lock (this) {
            try {
                java.security.SecureRandom secureRandom = this.fcf02ce52;
                if (secureRandom is not null) {
                    FxsYJhPEPUEiEDcT(secureRandom, bArr);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

