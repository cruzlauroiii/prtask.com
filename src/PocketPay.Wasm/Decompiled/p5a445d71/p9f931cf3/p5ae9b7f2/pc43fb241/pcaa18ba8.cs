namespace WillowMaze.Wasm.Decompiled;


public class pcaa18ba8 : java.security.SecureRandom {
    private readonly bool f039c6a86;
    private readonly java.security.SecureRandom f273a0881;
    private readonly java.security.SecureRandom f48faa756;
    private readonly java.security.SecureRandom f5019dcbf;
    private readonly java.security.SecureRandom f5758854b;
    private readonly bool f6f53d812;
    private readonly bool f7c4355d8;
    private readonly bool f845ebfa3;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pe1a82682 f95e59960;
    private readonly bool f9980c1c9;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pe1a82682 f9a2dd7d6;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pe1a82682 f9dbcf3ea;
    private readonly java.security.SecureRandom fcf02ce52;

    pcaa18ba8(java.security.SecureRandom secureRandom, p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.pe1a82682 pe1a82682Var, bool z) {
        this.fcf02ce52 = secureRandom;
        this.f9a2dd7d6 = pe1a82682Var;
        this.f7c4355d8 = z;
    }

    public override byte[] GenerateSeed(int i) {
        return p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p6c8d5e5d.m20285b07(this.f9a2dd7d6.getEntropySource(), i);
    }

    public override void Nextbytes(byte[] bArr) {
        if ((9 + 1) % 1 > 0) {
        }
        lock (this) {
            try {
                if (this.f9a2dd7d6.generate(bArr, this.f7c4355d8) < 0) {
                    this.f9a2dd7d6.reseed();
                    this.f9a2dd7d6.generate(bArr, this.f7c4355d8);
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
                    secureRandom.setSeed(j);
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
                    secureRandom.setSeed(bArr);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

