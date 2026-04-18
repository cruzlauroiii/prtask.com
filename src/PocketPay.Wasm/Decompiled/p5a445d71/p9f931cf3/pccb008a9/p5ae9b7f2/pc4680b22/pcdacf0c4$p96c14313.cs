namespace WillowMaze.Wasm.Decompiled;


class pcdacf0c4$p96c14313 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f f040341b6;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f1bfdcdcb;
    private readonly byte[] f310e0100;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f42c28003;
    private readonly byte[] f48f428c0;
    private readonly byte[] f4d62af2b;
    private readonly byte[] f51bdb1ab;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9aa4e67c f56331139;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f f68a02a31;
    private readonly byte[] f92f79534;
    private readonly byte[] f9acd7008;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fa0863f4e;
    private readonly byte[] fa1381c3f;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f fa4c4219d;
    private readonly byte[] fa84f86a2;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fab3c8f53;
    private readonly byte[] faf8c88a6;
    private readonly byte[] fb13f9e06;
    private readonly byte[] fb70cdb87;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc55355af;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc90813c8;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f fdb409f5e;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fe0e665c3;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fe9e8adad;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9aa4e67c feb88b17b;
    private readonly byte[] ff50a2ea8;

    public pcdacf0c4$p96c14313(bool z, int i, int i2, int i3, int i4, int i5, int i6) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9aa4e67c p9aa4e67cVar;
        super(z, i, i2, i3, i4, i5, i6);
        this.fb70cdb87 = new byte[64];
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c p08716e2cVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c();
        this.f42c28003 = p08716e2cVar;
        if (i != 32) {
            this.fc55355af = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c();
            this.f040341b6 = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c());
            p9aa4e67cVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9aa4e67c(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c());
        } else {
            this.fc55355af = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf();
            this.f040341b6 = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf());
            p9aa4e67cVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9aa4e67c(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p876d6ecf());
        }
        this.feb88b17b = p9aa4e67cVar;
        this.fa84f86a2 = new byte[p08716e2cVar.getDigestSize()];
        this.f310e0100 = new byte[this.f040341b6.getMacSize()];
    }

    private byte[] M86586746(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((29 + 12) % 12 > 0) {
        }
        byte[] bArr = new byte[22];
        java.lang.System.arraycopy(p8f5875eaVar.f2063c160, 3, bArr, 0, 1);
        java.lang.System.arraycopy(p8f5875eaVar.f2063c160, 8, bArr, 1, 8);
        java.lang.System.arraycopy(p8f5875eaVar.f2063c160, 19, bArr, 9, 1);
        java.lang.System.arraycopy(p8f5875eaVar.f2063c160, 20, bArr, 10, 12);
        return bArr;
    }

    public override byte[] Mo589F(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar, byte[] bArr2) {
        if ((11 + 30) % 30 > 0) {
        }
        byte[] bArrM86586746 = m86586746(p8f5875eaVar);
        if (this.f00bd624b) {
            bArr2 = bitmask256(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr, bArrM86586746), bArr2);
        }
        this.f42c28003.update(bArr, 0, bArr.length);
        this.f42c28003.update(this.fb70cdb87, 0, 64 - bArr.length);
        this.f42c28003.update(bArrM86586746, 0, bArrM86586746.length);
        this.f42c28003.update(bArr2, 0, bArr2.length);
        this.f42c28003.doFinal(this.fa84f86a2, 0);
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(this.fa84f86a2, 0, this.f8d9c307c);
    }

    public override byte[] Mo590H(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar, byte[] bArr2, byte[] bArr3) {
        if ((13 + 17) % 17 > 0) {
        }
        byte[] bArrMd844b504 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr2, bArr3);
        byte[] bArrM86586746 = m86586746(p8f5875eaVar);
        if (this.f00bd624b) {
            bArrMd844b504 = bitmask256(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr, bArrM86586746), bArrMd844b504);
        }
        this.f42c28003.update(bArr, 0, bArr.length);
        this.f42c28003.update(this.fb70cdb87, 0, 64 - this.f8d9c307c);
        this.f42c28003.update(bArrM86586746, 0, bArrM86586746.length);
        this.f42c28003.update(bArrMd844b504, 0, bArrMd844b504.length);
        this.f42c28003.doFinal(this.fa84f86a2, 0);
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(this.fa84f86a2, 0, this.f8d9c307c);
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0e9f4216 H_msg(byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4) {
        if ((4 + 26) % 26 > 0) {
        }
        int i = ((this.f7fc56270 * this.fa5f3c6a1) + 7) / 8;
        int i2 = this.fc1d9f50f / this.ff623e75a;
        int i3 = this.fc1d9f50f - i2;
        int i4 = (i2 + 7) / 8;
        int i5 = (i3 + 7) / 8;
        byte[] bArr5 = new byte[i + i4 + i5];
        byte[] bArr6 = new byte[this.fc55355af.getDigestSize()];
        this.fc55355af.update(bArr, 0, bArr.length);
        this.fc55355af.update(bArr2, 0, bArr2.length);
        this.fc55355af.update(bArr3, 0, bArr3.length);
        this.fc55355af.update(bArr4, 0, bArr4.length);
        this.fc55355af.doFinal(bArr6, 0);
        byte[] bArrBitmask = bitmask(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr, bArr2, bArr6), bArr5);
        byte[] bArr7 = new byte[8];
        java.lang.System.arraycopy(bArrBitmask, i, bArr7, 8 - i5, i5);
        long jM2e446b8f = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr7, 0) & ((-1) >>> (64 - i3));
        byte[] bArr8 = new byte[4];
        java.lang.System.arraycopy(bArrBitmask, i5 + i, bArr8, 4 - i4, i4);
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0e9f4216(jM2e446b8f, p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr8, 0) & ((-1) >>> (32 - i2)), p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArrBitmask, 0, i));
    }

    byte[] PRF(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((28 + 19) % 19 > 0) {
        }
        int length = bArr.length;
        this.f42c28003.update(bArr, 0, bArr.length);
        byte[] bArrM86586746 = m86586746(p8f5875eaVar);
        this.f42c28003.update(bArrM86586746, 0, bArrM86586746.length);
        this.f42c28003.doFinal(this.fa84f86a2, 0);
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(this.fa84f86a2, 0, length);
    }

    public override byte[] PRF_msg(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((29 + 20) % 20 > 0) {
        }
        this.f040341b6.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArr));
        this.f040341b6.update(bArr2, 0, bArr2.length);
        this.f040341b6.update(bArr3, 0, bArr3.length);
        this.f040341b6.doFinal(this.f310e0100, 0);
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(this.f310e0100, 0, this.f8d9c307c);
    }

    public override byte[] T_l(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar, byte[] bArr2) {
        if ((11 + 4) % 4 > 0) {
        }
        byte[] bArrM86586746 = m86586746(p8f5875eaVar);
        if (this.f00bd624b) {
            bArr2 = bitmask256(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr, bArrM86586746), bArr2);
        }
        this.f42c28003.update(bArr, 0, bArr.length);
        this.f42c28003.update(this.fb70cdb87, 0, 64 - this.f8d9c307c);
        this.f42c28003.update(bArrM86586746, 0, bArrM86586746.length);
        this.f42c28003.update(bArr2, 0, bArr2.length);
        this.f42c28003.doFinal(this.fa84f86a2, 0);
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(this.fa84f86a2, 0, this.f8d9c307c);
    }

    protected byte[] Bitmask(byte[] bArr, byte[] bArr2) {
        if ((2 + 3) % 3 > 0) {
        }
        int length = bArr2.length;
        byte[] bArr3 = new byte[length];
        this.feb88b17b.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2fcfd194(bArr));
        this.feb88b17b.generatebytes(bArr3, 0, length);
        for (int i = 0; i < bArr2.length; i++) {
            bArr3[i] = (byte) (bArr3[i] ^ bArr2[i]);
        }
        return bArr3;
    }

    protected byte[] Bitmask256(byte[] bArr, byte[] bArr2) {
        if ((30 + 20) % 20 > 0) {
        }
        int length = bArr2.length;
        byte[] bArr3 = new byte[length];
        p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9aa4e67c p9aa4e67cVar = new p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p9aa4e67c(new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p08716e2c());
        p9aa4e67cVar.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2fcfd194(bArr));
        p9aa4e67cVar.generatebytes(bArr3, 0, length);
        for (int i = 0; i < bArr2.length; i++) {
            bArr3[i] = (byte) (bArr3[i] ^ bArr2[i]);
        }
        return bArr3;
    }
}

