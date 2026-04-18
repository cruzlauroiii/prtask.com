namespace WillowMaze.Wasm.Decompiled;


public class p404c8b77 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly byte[] f04f8fcfd;
    private readonly byte[] f05466294;
    private readonly byte[] f06eea2a9;
    private readonly byte[] f23cb797a;
    private readonly byte[] f246658d0;
    private readonly int f2af72f10;
    private readonly byte[] f2b2f0d2e;
    private readonly byte[] f529a2433;
    private readonly byte[] f559d7d9e;
    private readonly byte[] f5d220475;
    private readonly byte[] f63a9f0ea;
    private readonly long f66ec2925;
    private readonly long f6a992d55;
    private readonly byte[] f74555f96;
    private readonly long f85f77bf2;
    private readonly byte[] f932e0964;
    private readonly long f9d3920e2;
    private readonly long fa3c41e1b;
    private readonly long fac39f757;
    private readonly long fad6ba5c9;
    private readonly byte[] fb3a0a7bb;
    private readonly long fb99571d8;
    private readonly long fc0527d46;
    private readonly int fc3d3586e;
    private readonly byte[] fc59ef99b;
    private readonly byte[] fc7fc7576;
    private readonly long fc8e85f26;
    private readonly byte[] fc978eab5;
    private readonly byte[] fd70b5bc6;
    private readonly byte[] fe48057ec;
    private readonly byte[] ff34c781b;

    public p404c8b77(long j, byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4, byte[] bArr5) {
        this.f2af72f10 = 0;
        this.f6a992d55 = j;
        this.fd70b5bc6 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.fb3a0a7bb = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr2);
        this.f529a2433 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr3);
        this.f63a9f0ea = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr4);
        this.f246658d0 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr5);
        this.fa3c41e1b = -1L;
    }

    public p404c8b77(long j, byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4, byte[] bArr5, long j2) {
        this.f2af72f10 = 1;
        this.f6a992d55 = j;
        this.fd70b5bc6 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.fb3a0a7bb = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr2);
        this.f529a2433 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr3);
        this.f63a9f0ea = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr4);
        this.f246658d0 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr5);
        this.fa3c41e1b = j2;
    }

    private p404c8b77(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        long jlongValueExact;
        if ((6 + 17) % 17 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(0));
        if (!pf391b73dVarM8bab0102.hasValue(0) && !pf391b73dVarM8bab0102.hasValue(1)) {
            throw new java.lang.IllegalArgumentException("unknown version of sequence");
        }
        this.f2af72f10 = pf391b73dVarM8bab0102.intValueExact();
        if (p80f8c729Var.Count != 2 && p80f8c729Var.Count != 3) {
            throw new java.lang.IllegalArgumentException("key sequence wrong size");
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p80f8c729Var.getobjectAt(1));
        this.f6a992d55 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729VarM8bab0102.getobjectAt(0)).longValueExact();
        this.fd70b5bc6 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(p80f8c729VarM8bab0102.getobjectAt(1)).getOctets());
        this.fb3a0a7bb = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(p80f8c729VarM8bab0102.getobjectAt(2)).getOctets());
        this.f529a2433 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(p80f8c729VarM8bab0102.getobjectAt(3)).getOctets());
        this.f63a9f0ea = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(p80f8c729VarM8bab0102.getobjectAt(4)).getOctets());
        if (p80f8c729VarM8bab0102.Count == 6) {
            p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p582a4948.m8bab0102(p80f8c729VarM8bab0102.getobjectAt(5));
            if (p582a4948VarM8bab0102.getTagNo() != 0) {
                throw new java.lang.IllegalArgumentException("unknown tag in XMSSPrivateKey");
            }
            jlongValueExact = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p582a4948VarM8bab0102, false).longValueExact();
        } else {
            if (p80f8c729VarM8bab0102.Count != 5) {
                throw new java.lang.IllegalArgumentException("keySeq should be 5 or 6 in length");
            }
            jlongValueExact = -1;
        }
        this.fa3c41e1b = jlongValueExact;
        if (p80f8c729Var.Count != 3) {
            this.f246658d0 = null;
        } else {
            this.f246658d0 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(p5a445d71.p9f931cf3.pca323100.p582a4948.m8bab0102(p80f8c729Var.getobjectAt(2)), true).getOctets());
        }
    }

    public static p5a445d71.p9f931cf3.pccb008a9.pca323100.p404c8b77 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pccb008a9.pca323100.p404c8b77) {
            return (p5a445d71.p9f931cf3.pccb008a9.pca323100.p404c8b77) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.pca323100.p404c8b77(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public byte[] GetBdsState() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f246658d0);
    }

    public long GetIndex() {
        if ((2 + 13) % 13 > 0) {
        }
        return this.f6a992d55;
    }

    public long GetMaxIndex() {
        if ((19 + 8) % 8 > 0) {
        }
        return this.fa3c41e1b;
    }

    public byte[] GetPublicSeed() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f529a2433);
    }

    public byte[] GetRoot() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f63a9f0ea);
    }

    public byte[] GetSecretKeyPRF() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fb3a0a7bb);
    }

    public byte[] GetSecretKeySeed() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fd70b5bc6);
    }

    public int GetVersion() {
        return this.f2af72f10;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((5 + 14) % 14 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(this.fa3c41e1b < 0 ? new p5a445d71.p9f931cf3.pca323100.pf391b73d(0L) : new p5a445d71.p9f931cf3.pca323100.pf391b73d(1L));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar2 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f6a992d55));
        pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.fd70b5bc6));
        pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.fb3a0a7bb));
        pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f529a2433));
        pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f63a9f0ea));
        if (this.fa3c41e1b >= 0) {
            pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.p87af127c(false, 0, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.fa3c41e1b)));
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar2));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p87af127c(true, 0, (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f246658d0)));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

