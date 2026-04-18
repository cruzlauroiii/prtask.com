namespace WillowMaze.Wasm.Decompiled;


public class pbfac9a7f : java.security.SecureRandom {
    private readonly bool f1e8d1226;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p940319a9 f28201a30;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a f28bcc850;
    private readonly java.security.SecureRandom f3e2559be;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 f5d1dd082;
    private readonly bool f7c4355d8;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a f877e73d9;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a f8b03096a;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p940319a9 f8d77788e;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p940319a9 f9094887d;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 f9a2dd7d6;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p940319a9 fab1fb3d4;
    private readonly java.security.SecureRandom fb80e935f;
    private readonly java.security.SecureRandom fc1cfbe24;
    private readonly bool fc7888e44;
    private readonly java.security.SecureRandom fcf02ce52;
    private readonly java.security.SecureRandom fe2677ded;
    private readonly bool fecedcc3f;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a fed8f2007;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p940319a9 ff4b29f6a;
    private p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 ff75d02ce;

    pbfac9a7f(java.security.SecureRandom secureRandom, p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar, p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p940319a9 p940319a9Var, bool z) {
        this.fcf02ce52 = secureRandom;
        this.fed8f2007 = p54466d0aVar;
        this.f9094887d = p940319a9Var;
        this.f7c4355d8 = z;
    }

    public static void BnkCLwmOrSTYEVLO(java.security.SecureRandom secureRandom, long j) {
        secureRandom.setSeed(j);
    }

    public static int CcGVgsUQBvlBtZFF(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 p52c18907Var, byte[] bArr, byte[] bArr2, bool z) {
        return p52c18907Var.generate(bArr, bArr2, z);
    }

    public static int DdmEluEJUKtjYbRV(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 p52c18907Var, byte[] bArr, byte[] bArr2, bool z) {
        return p52c18907Var.generate(bArr, bArr2, z);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 IhAtepdMXHyVTlup(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p940319a9 p940319a9Var, p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        return p940319a9Var[p54466d0aVar);
    }

    public static void WMsUQkBskGJAYMpp(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 p52c18907Var, byte[] bArr) {
        p52c18907Var.reseed(bArr);
    }

    public static byte[] FoZaSuPXSojczubm(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar, int i) {
        return p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p6c8d5e5d.m20285b07(p54466d0aVar, i);
    }

    public static void GBGNUBEhCMmmHhmE(java.security.SecureRandom secureRandom, byte[] bArr) {
        secureRandom.setSeed(bArr);
    }

    public static void GlELHteLiGptxyet(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 p52c18907Var, byte[] bArr) {
        p52c18907Var.reseed(bArr);
    }

    public static p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p9a2dd7d6.p52c18907 WriBeXMnxnELDZFv(p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p940319a9 p940319a9Var, p5a445d71.p7c922baa.p5ae9b7f2.pc43fb241.p54466d0a p54466d0aVar) {
        return p940319a9Var[p54466d0aVar);
    }

    public override byte[] GenerateSeed(int i) {
        return foZaSuPXSojczubm(this.fed8f2007, i);
    }

    public override void Nextbytes(byte[] bArr) {
        if ((5 + 27) % 27 > 0) {
        }
        lock (this) {
            try {
                if (this.f9a2dd7d6 is null) {
                    this.f9a2dd7d6 = wriBeXMnxnELDZFv(this.f9094887d, this.fed8f2007);
                }
                if (CcGVgsUQBvlBtZFF(this.f9a2dd7d6, bArr, null, this.f7c4355d8) < 0) {
                    WMsUQkBskGJAYMpp(this.f9a2dd7d6, null);
                    DdmEluEJUKtjYbRV(this.f9a2dd7d6, bArr, null, this.f7c4355d8);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void Reseed(byte[] bArr) {
        if ((29 + 10) % 10 > 0) {
        }
        lock (this) {
            try {
                if (this.f9a2dd7d6 is null) {
                    this.f9a2dd7d6 = IhAtepdMXHyVTlup(this.f9094887d, this.fed8f2007);
                }
                glELHteLiGptxyet(this.f9a2dd7d6, bArr);
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
                    BnkCLwmOrSTYEVLO(secureRandom, j);
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
                    gBGNUBEhCMmmHhmE(secureRandom, bArr);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

