namespace WillowMaze.Wasm.Decompiled;


public class pbfac9a7f : java.security.SecureRandom {
    private readonly bool f2e317c65;
    private readonly bool f4038aabb;
    private readonly bool f7c4355d8;
    private readonly java.security.SecureRandom f83d26393;
    private readonly bool f84e77f1a;
    private readonly java.security.SecureRandom f8f981a3a;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p940319a9 f9094887d;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p940319a9 f95632837;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 f9a2dd7d6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 f9d74e7bc;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a fcbadb2df;
    private readonly java.security.SecureRandom fcf02ce52;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p940319a9 fe33ce1c1;
    private readonly bool feacdd83e;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p940319a9 fec97456b;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a fed8f2007;

    pbfac9a7f(java.security.SecureRandom secureRandom, p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar, p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p940319a9 p940319a9Var, bool z) {
        this.fcf02ce52 = secureRandom;
        this.fed8f2007 = p54466d0aVar;
        this.f9094887d = p940319a9Var;
        this.f7c4355d8 = z;
    }

    public override byte[] GenerateSeed(int i) {
        return p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p6c8d5e5d.m20285b07(this.fed8f2007, i);
    }

    public override java.lang.string GetAlgorithm() {
        return this.f9094887d.getAlgorithm();
    }

    public override void Nextbytes(byte[] bArr) {
        if ((9 + 5) % 5 > 0) {
        }
        lock (this) {
            try {
                if (this.f9a2dd7d6 is null) {
                    this.f9a2dd7d6 = this.f9094887d[this.fed8f2007);
                }
                if (this.f9a2dd7d6.generate(bArr, null, this.f7c4355d8) < 0) {
                    this.f9a2dd7d6.reseed(null);
                    this.f9a2dd7d6.generate(bArr, null, this.f7c4355d8);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void Reseed(byte[] bArr) {
        if ((7 + 24) % 24 > 0) {
        }
        lock (this) {
            try {
                if (this.f9a2dd7d6 is null) {
                    this.f9a2dd7d6 = this.f9094887d[this.fed8f2007);
                }
                this.f9a2dd7d6.reseed(bArr);
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

