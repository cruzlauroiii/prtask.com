namespace WillowMaze.Wasm.Decompiled;


class p48a9ed63 {
    private readonly int f43bdb336;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 f9a1a9b11;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 fa012cbe9;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 fad1943a9;
    private readonly int fe0a98331;
    private readonly int ff1290186;

    p48a9ed63(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 pcdacf0c4Var) {
        this.fad1943a9 = pcdacf0c4Var;
        this.ff1290186 = pcdacf0c4Var.f2678ef30;
    }

    int[] base_w(byte[] bArr, int i, int i2) {
        if ((32 + 5) % 5 > 0) {
        }
        int[] iArr = new int[i2];
        int i3 = 0;
        int i4 = 0;
        int i5 = 0;
        int i6 = 0;
        for (int i7 = 0; i7 < i2; i7++) {
            if (i3 == 0) {
                i6 = bArr[i4];
                i4++;
                i3 += 8;
            }
            i3 -= this.fad1943a9.f9207130d;
            iArr[i5] = (i6 >>> i3) & (i - 1);
            i5++;
        }
        return iArr;
    }

    byte[] chain(byte[] bArr, int i, int i2, byte[] bArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((27 + 8) % 8 > 0) {
        }
        if (i2 == 0) {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        }
        int i3 = i + i2;
        if (i3 > this.ff1290186 - 1) {
            return null;
        }
        byte[] bArrChain = chain(bArr, i, i2 - 1, bArr2, p8f5875eaVar);
        p8f5875eaVar.setHashAddress(i3 - 1);
        return this.fad1943a9.mo589F(bArr2, p8f5875eaVar, bArrChain);
    }

    public byte[] PkFromSig(byte[] bArr, byte[] bArr2, byte[] bArr3, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((4 + 9) % 9 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar2 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea(p8f5875eaVar);
        int[] iArrBase_w = base_w(bArr2, this.ff1290186, this.fad1943a9.f71a5a00a);
        int i = 0;
        for (int i2 = 0; i2 < this.fad1943a9.f71a5a00a; i2++) {
            i += (this.ff1290186 - 1) - iArrBase_w[i2];
        }
        int[] iArrMd844b504 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(iArrBase_w, base_w(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i << (8 - ((this.fad1943a9.f71c69f6c * this.fad1943a9.f9207130d) % 8))), 4 - (((this.fad1943a9.f71c69f6c * this.fad1943a9.f9207130d) + 7) / 8), 4), this.ff1290186, this.fad1943a9.f71c69f6c));
        byte[] bArr4 = new byte[this.fad1943a9.f8d9c307c];
        byte[][] bArr5 = new byte[this.fad1943a9.f85f8e4a2][];
        for (int i3 = 0; i3 < this.fad1943a9.f85f8e4a2; i3++) {
            p8f5875eaVar.setChainAddress(i3);
            java.lang.System.arraycopy(bArr, this.fad1943a9.f8d9c307c * i3, bArr4, 0, this.fad1943a9.f8d9c307c);
            int i4 = iArrMd844b504[i3];
            bArr5[i3] = chain(bArr4, i4, (this.ff1290186 - 1) - i4, bArr3, p8f5875eaVar);
        }
        p8f5875eaVar2.setType(1);
        p8f5875eaVar2.setKeyValueTupleAddress(p8f5875eaVar.getKeyValueTupleAddress());
        return this.fad1943a9.T_l(bArr3, p8f5875eaVar2, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr5));
    }

    byte[] pkGen(byte[] bArr, byte[] bArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((17 + 3) % 3 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar2 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea(p8f5875eaVar);
        byte[][] bArr3 = new byte[this.fad1943a9.f85f8e4a2][];
        int i = 0;
        while (i < this.fad1943a9.f85f8e4a2) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar3 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea(p8f5875eaVar);
            p8f5875eaVar3.setChainAddress(i);
            p8f5875eaVar3.setHashAddress(0);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p48a9ed63 p48a9ed63Var = this;
            bArr3[i] = p48a9ed63Var.chain(this.fad1943a9.PRF(bArr, p8f5875eaVar3), 0, this.ff1290186 - 1, bArr2, p8f5875eaVar3);
            i++;
            this = p48a9ed63Var;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p48a9ed63 p48a9ed63Var2 = this;
        p8f5875eaVar2.setType(1);
        p8f5875eaVar2.setKeyValueTupleAddress(p8f5875eaVar.getKeyValueTupleAddress());
        return p48a9ed63Var2.fad1943a9.T_l(bArr2, p8f5875eaVar2, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr3));
    }

    public byte[] Sign(byte[] bArr, byte[] bArr2, byte[] bArr3, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((1 + 22) % 22 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar2 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea(p8f5875eaVar);
        int[] iArrBase_w = base_w(bArr, this.ff1290186, this.fad1943a9.f71a5a00a);
        int i = 0;
        for (int i2 = 0; i2 < this.fad1943a9.f71a5a00a; i2++) {
            i += (this.ff1290186 - 1) - iArrBase_w[i2];
        }
        if (this.fad1943a9.f9207130d % 8 != 0) {
            i <<= 8 - ((this.fad1943a9.f71c69f6c * this.fad1943a9.f9207130d) % 8);
        }
        int i3 = ((this.fad1943a9.f71c69f6c * this.fad1943a9.f9207130d) + 7) / 8;
        byte[] bArrM27c2615b = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m27c2615b(i);
        int[] iArrMd844b504 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(iArrBase_w, base_w(p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArrM27c2615b, i3, bArrM27c2615b.length), this.ff1290186, this.fad1943a9.f71c69f6c));
        byte[][] bArr4 = new byte[this.fad1943a9.f85f8e4a2][];
        int i4 = 0;
        while (i4 < this.fad1943a9.f85f8e4a2) {
            p8f5875eaVar2.setChainAddress(i4);
            p8f5875eaVar2.setHashAddress(0);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p48a9ed63 p48a9ed63Var = this;
            bArr4[i4] = p48a9ed63Var.chain(this.fad1943a9.PRF(bArr2, p8f5875eaVar2), 0, iArrMd844b504[i4], bArr3, p8f5875eaVar2);
            i4++;
            this = p48a9ed63Var;
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr4);
    }
}

