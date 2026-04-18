namespace WillowMaze.Wasm.Decompiled;


public class p7e83e3ae : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly byte[] f024427d7;
    private readonly byte[] f0adbf62f;
    private readonly byte[] f1725370b;
    private readonly byte[] f246658d0;
    private readonly byte[] f27dc7a44;
    private readonly int f2af72f10;
    private readonly byte[] f376b1e82;
    private readonly byte[] f4356ec2a;
    private readonly byte[] f529a2433;
    private readonly int f530363fe;
    private readonly int f5403cb5d;
    private readonly byte[] f63a9f0ea;
    private readonly int f6a992d55;
    private readonly byte[] f7b77d4aa;
    private readonly int f7c40dfe1;
    private readonly byte[] f9915b688;
    private readonly int fa3c41e1b;
    private readonly int fabf25611;
    private readonly byte[] faf14d4b0;
    private readonly byte[] fb3a0a7bb;
    private readonly int fb63ea3b7;
    private readonly byte[] fbbdc55e1;
    private readonly byte[] fbe1ac75e;
    private readonly int fc6ef20fc;
    private readonly byte[] fc7c10a65;
    private readonly int fcc9ad12f;
    private readonly int fd010d703;
    private readonly byte[] fd5b78f78;
    private readonly byte[] fd70b5bc6;
    private readonly byte[] fe245c6c6;

    public p7e83e3ae(int i, byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4, byte[] bArr5) {
        this.f2af72f10 = 0;
        this.f6a992d55 = i;
        this.fd70b5bc6 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.fb3a0a7bb = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr2);
        this.f529a2433 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr3);
        this.f63a9f0ea = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr4);
        this.f246658d0 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr5);
        this.fa3c41e1b = -1;
    }

    public p7e83e3ae(int i, byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4, byte[] bArr5, int i2) {
        this.f2af72f10 = 1;
        this.f6a992d55 = i;
        this.fd70b5bc6 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.fb3a0a7bb = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr2);
        this.f529a2433 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr3);
        this.f63a9f0ea = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr4);
        this.f246658d0 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr5);
        this.fa3c41e1b = i2;
    }

    private p7e83e3ae(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        int iIntValueExact;
        if ((28 + 17) % 17 > 0) {
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
        this.f6a992d55 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729VarM8bab0102.getobjectAt(0)).intValueExact();
        this.fd70b5bc6 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(p80f8c729VarM8bab0102.getobjectAt(1)).getOctets());
        this.fb3a0a7bb = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(p80f8c729VarM8bab0102.getobjectAt(2)).getOctets());
        this.f529a2433 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(p80f8c729VarM8bab0102.getobjectAt(3)).getOctets());
        this.f63a9f0ea = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(p80f8c729VarM8bab0102.getobjectAt(4)).getOctets());
        if (p80f8c729VarM8bab0102.Count == 6) {
            p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p582a4948.m8bab0102(p80f8c729VarM8bab0102.getobjectAt(5));
            if (p582a4948VarM8bab0102.getTagNo() != 0) {
                throw new java.lang.IllegalArgumentException("unknown tag in XMSSPrivateKey");
            }
            iIntValueExact = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p582a4948VarM8bab0102, false).intValueExact();
        } else {
            if (p80f8c729VarM8bab0102.Count != 5) {
                throw new java.lang.IllegalArgumentException("keySeq should be 5 or 6 in length");
            }
            iIntValueExact = -1;
        }
        this.fa3c41e1b = iIntValueExact;
        if (p80f8c729Var.Count != 3) {
            this.f246658d0 = null;
        } else {
            this.f246658d0 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(p5a445d71.p9f931cf3.pca323100.p582a4948.m8bab0102(p80f8c729Var.getobjectAt(2)), true).getOctets());
        }
    }

    public static p5a445d71.p9f931cf3.pccb008a9.pca323100.p7e83e3ae M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pccb008a9.pca323100.p7e83e3ae) {
            return (p5a445d71.p9f931cf3.pccb008a9.pca323100.p7e83e3ae) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.pca323100.p7e83e3ae(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public byte[] GetBdsState() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f246658d0);
    }

    public int GetIndex() {
        return this.f6a992d55;
    }

    public int GetMaxIndex() {
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
        if ((18 + 14) % 14 > 0) {
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

