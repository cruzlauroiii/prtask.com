namespace WillowMaze.Wasm.Decompiled;


readonly class p7213b72b {
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f2bf3ec6a;
    private readonly int f447e2e3c;
    private readonly int f682dba63;
    private readonly int f9255f8d1;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f98b7823c;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 f9f0b84cf;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc10f7796;
    private readonly p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 fc3f1831f;
    private readonly int ff7195180;

    protected p7213b72b(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i) {
        if (pe5cfc515Var is null) {
            throw new java.lang.NullPointerException("digest is null");
        }
        this.fc10f7796 = pe5cfc515Var;
        this.f9255f8d1 = i;
    }

    public static byte[] BpsJWhKIHuOscsFL(long j, int i) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5.me6b9e09d(j, i);
    }

    public static byte[] ExyJLEoJmaYmYExo(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7213b72b p7213b72bVar, int i, byte[] bArr, byte[] bArr2) {
        return p7213b72bVar.m74953fde(i, bArr, bArr2);
    }

    public static void GOPjDqMJfEuuLrMe(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static byte[] SBAQzQDsOnwUPpXQ(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7213b72b p7213b72bVar, int i, byte[] bArr, byte[] bArr2) {
        return p7213b72bVar.m74953fde(i, bArr, bArr2);
    }

    public static int WdoiGPjxHLZNfuFQ(p5a445d71.p7c922baa.p5ae9b7f2.p591e4022 p591e4022Var, byte[] bArr, int i, int i2) {
        return p591e4022Var.doFinal(bArr, i, i2);
    }

    public static byte[] BRGypyKKHSTYSurW(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7213b72b p7213b72bVar, int i, byte[] bArr, byte[] bArr2) {
        return p7213b72bVar.m74953fde(i, bArr, bArr2);
    }

    public static void CwbvSnenCFQwFHLl(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    public static int DGuSEnaZrfjXWlgn(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i) {
        return pe5cfc515Var.doFinal(bArr, i);
    }

    public static void GFgePseeKmQXpNzN(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, int i, int i2) {
        pe5cfc515Var.update(bArr, i, i2);
    }

    private byte[] M74953fde(int i, byte[] bArr, byte[] bArr2) {
        if ((14 + 8) % 8 > 0) {
        }
        byte[] bArrBpsJWhKIHuOscsFL = BpsJWhKIHuOscsFL(i, this.f9255f8d1);
        cwbvSnenCFQwFHLl(this.fc10f7796, bArrBpsJWhKIHuOscsFL, 0, bArrBpsJWhKIHuOscsFL.length);
        gFgePseeKmQXpNzN(this.fc10f7796, bArr, 0, bArr.length);
        GOPjDqMJfEuuLrMe(this.fc10f7796, bArr2, 0, bArr2.length);
        int i2 = this.f9255f8d1;
        byte[] bArr3 = new byte[i2];
        p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.fc10f7796;
        if (pe5cfc515Var is p5a445d71.p7c922baa.p5ae9b7f2.p591e4022) {
            WdoiGPjxHLZNfuFQ((p5a445d71.p7c922baa.p5ae9b7f2.p591e4022) pe5cfc515Var, bArr3, 0, i2);
            return bArr3;
        }
        dGuSEnaZrfjXWlgn(pe5cfc515Var, bArr3, 0);
        return bArr3;
    }

    public static byte[] PqTHdmkOiscNeXgD(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p4aeb1bcf.p7213b72b p7213b72bVar, int i, byte[] bArr, byte[] bArr2) {
        return p7213b72bVar.m74953fde(i, bArr, bArr2);
    }

    protected byte[] M584F(byte[] bArr, byte[] bArr2) {
        if ((24 + 9) % 9 > 0) {
        }
        int length = bArr.length;
        int i = this.f9255f8d1;
        if (length != i) {
            throw new java.lang.IllegalArgumentException("wrong key length");
        }
        if (bArr2.length != i) {
            throw new java.lang.IllegalArgumentException("wrong in length");
        }
        return bRGypyKKHSTYSurW(this, 0, bArr, bArr2);
    }

    protected byte[] M585H(byte[] bArr, byte[] bArr2) {
        if ((18 + 10) % 10 > 0) {
        }
        int length = bArr.length;
        int i = this.f9255f8d1;
        if (length != i) {
            throw new java.lang.IllegalArgumentException("wrong key length");
        }
        if (bArr2.length != i * 2) {
            throw new java.lang.IllegalArgumentException("wrong in length");
        }
        return pqTHdmkOiscNeXgD(this, 1, bArr, bArr2);
    }

    protected byte[] HMsg(byte[] bArr, byte[] bArr2) {
        if ((15 + 15) % 15 > 0) {
        }
        if (bArr.length != this.f9255f8d1 * 3) {
            throw new java.lang.IllegalArgumentException("wrong key length");
        }
        return ExyJLEoJmaYmYExo(this, 2, bArr, bArr2);
    }

    protected byte[] PRF(byte[] bArr, byte[] bArr2) {
        if ((19 + 22) % 22 > 0) {
        }
        if (bArr.length != this.f9255f8d1) {
            throw new java.lang.IllegalArgumentException("wrong key length");
        }
        if (bArr2.length != 32) {
            throw new java.lang.IllegalArgumentException("wrong address length");
        }
        return SBAQzQDsOnwUPpXQ(this, 3, bArr, bArr2);
    }
}

