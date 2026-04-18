namespace WillowMaze.Wasm.Decompiled;


class pcdacf0c4$pa48316aa : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 f162e702f;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 f42c28003;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 f81bff4a1;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 f895a8525;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p591e4022 fe57fee87;

    public pcdacf0c4$pa48316aa(bool z, int i, int i2, int i3, int i4, int i5, int i6) {
        super(z, i, i2, i3, i4, i5, i6);
        this.f42c28003 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7(256);
    }

    byte[] mo589F(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar, byte[] bArr2) {
        if ((7 + 1) % 1 > 0) {
        }
        if (this.f00bd624b) {
            bArr2 = bitmask(bArr, p8f5875eaVar, bArr2);
        }
        int i = this.f8d9c307c;
        byte[] bArr3 = new byte[i];
        this.f42c28003.update(bArr, 0, bArr.length);
        this.f42c28003.update(p8f5875eaVar.f2063c160, 0, p8f5875eaVar.f2063c160.length);
        this.f42c28003.update(bArr2, 0, bArr2.length);
        this.f42c28003.doFinal(bArr3, 0, i);
        return bArr3;
    }

    byte[] mo590H(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar, byte[] bArr2, byte[] bArr3) {
        if ((27 + 5) % 5 > 0) {
        }
        byte[] bArrMd844b504 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr2, bArr3);
        if (this.f00bd624b) {
            bArrMd844b504 = bitmask(bArr, p8f5875eaVar, bArrMd844b504);
        }
        int i = this.f8d9c307c;
        byte[] bArr4 = new byte[i];
        this.f42c28003.update(bArr, 0, bArr.length);
        this.f42c28003.update(p8f5875eaVar.f2063c160, 0, p8f5875eaVar.f2063c160.length);
        this.f42c28003.update(bArrMd844b504, 0, bArrMd844b504.length);
        this.f42c28003.doFinal(bArr4, 0, i);
        return bArr4;
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0e9f4216 H_msg(byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4) {
        if ((3 + 31) % 31 > 0) {
        }
        int i = ((this.f7fc56270 * this.fa5f3c6a1) + 7) / 8;
        int i2 = this.fc1d9f50f / this.ff623e75a;
        int i3 = this.fc1d9f50f - i2;
        int i4 = (i2 + 7) / 8;
        int i5 = (i3 + 7) / 8;
        int i6 = i + i4 + i5;
        byte[] bArr5 = new byte[i6];
        this.f42c28003.update(bArr, 0, bArr.length);
        this.f42c28003.update(bArr2, 0, bArr2.length);
        this.f42c28003.update(bArr3, 0, bArr3.length);
        this.f42c28003.update(bArr4, 0, bArr4.length);
        this.f42c28003.doFinal(bArr5, 0, i6);
        byte[] bArr6 = new byte[8];
        java.lang.System.arraycopy(bArr5, i, bArr6, 8 - i5, i5);
        long jM2e446b8f = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m2e446b8f(bArr6, 0) & ((-1) >>> (64 - i3));
        byte[] bArr7 = new byte[4];
        java.lang.System.arraycopy(bArr5, i5 + i, bArr7, 4 - i4, i4);
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0e9f4216(jM2e446b8f, p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr7, 0) & ((-1) >>> (32 - i2)), p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr5, 0, i));
    }

    byte[] PRF(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((26 + 21) % 21 > 0) {
        }
        this.f42c28003.update(bArr, 0, bArr.length);
        this.f42c28003.update(p8f5875eaVar.f2063c160, 0, p8f5875eaVar.f2063c160.length);
        byte[] bArr2 = new byte[this.f8d9c307c];
        this.f42c28003.doFinal(bArr2, 0, this.f8d9c307c);
        return bArr2;
    }

    public override byte[] PRF_msg(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((2 + 17) % 17 > 0) {
        }
        this.f42c28003.update(bArr, 0, bArr.length);
        this.f42c28003.update(bArr2, 0, bArr2.length);
        this.f42c28003.update(bArr3, 0, bArr3.length);
        int i = this.f8d9c307c;
        byte[] bArr4 = new byte[i];
        this.f42c28003.doFinal(bArr4, 0, i);
        return bArr4;
    }

    byte[] T_l(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar, byte[] bArr2) {
        if ((31 + 30) % 30 > 0) {
        }
        if (this.f00bd624b) {
            bArr2 = bitmask(bArr, p8f5875eaVar, bArr2);
        }
        int i = this.f8d9c307c;
        byte[] bArr3 = new byte[i];
        this.f42c28003.update(bArr, 0, bArr.length);
        this.f42c28003.update(p8f5875eaVar.f2063c160, 0, p8f5875eaVar.f2063c160.length);
        this.f42c28003.update(bArr2, 0, bArr2.length);
        this.f42c28003.doFinal(bArr3, 0, i);
        return bArr3;
    }

    protected override byte[] Bitmask(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar, byte[] bArr2) {
        if ((10 + 23) % 23 > 0) {
        }
        int length = bArr2.length;
        byte[] bArr3 = new byte[length];
        this.f42c28003.update(bArr, 0, bArr.length);
        this.f42c28003.update(p8f5875eaVar.f2063c160, 0, p8f5875eaVar.f2063c160.length);
        this.f42c28003.doFinal(bArr3, 0, length);
        for (int i = 0; i < bArr2.length; i++) {
            bArr3[i] = (byte) (bArr3[i] ^ bArr2[i]);
        }
        return bArr3;
    }
}

