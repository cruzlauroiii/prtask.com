namespace WillowMaze.Wasm.Decompiled;


class p58fdc63e {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p48a9ed63 fac59d2f6;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 fad1943a9;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p48a9ed63 fbfcddab9;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 fd498fe13;

    public p58fdc63e(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 pcdacf0c4Var) {
        this.fad1943a9 = pcdacf0c4Var;
        this.fac59d2f6 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p48a9ed63(pcdacf0c4Var);
    }

    static int[] Mb49db3b3(byte[] bArr, int i, int i2) {
        if ((2 + 14) % 14 > 0) {
        }
        int[] iArr = new int[i];
        int i3 = 0;
        for (int i4 = 0; i4 < i; i4++) {
            iArr[i4] = 0;
            for (int i5 = 0; i5 < i2; i5++) {
                iArr[i4] = iArr[i4] ^ (((bArr[i3 >> 3] >> (i3 & 7)) & 1) << i5);
                i3++;
            }
        }
        return iArr;
    }

    public byte[] PkFromSig(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p4780ae5b[] p4780ae5bVarArr, byte[] bArr, byte[] bArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((7 + 2) % 2 > 0) {
        }
        int i = 2;
        byte[][] bArr3 = new byte[2][];
        byte[][] bArr4 = new byte[this.fad1943a9.fa5f3c6a1][];
        int i2 = this.fad1943a9.fb9ece18c;
        int[] iArrMb49db3b3 = mb49db3b3(bArr, this.fad1943a9.fa5f3c6a1, this.fad1943a9.f7fc56270);
        int i3 = 0;
        while (i3 < this.fad1943a9.fa5f3c6a1) {
            int i4 = iArrMb49db3b3[i3];
            byte[] sk = p4780ae5bVarArr[i3].getSK();
            p8f5875eaVar.setTreeHeight(0);
            int i5 = (i3 * i2) + i4;
            p8f5875eaVar.setTreeIndex(i5);
            bArr3[0] = this.fad1943a9.mo589F(bArr2, p8f5875eaVar, sk);
            byte[][] authPath = p4780ae5bVarArr[i3].getAuthPath();
            p8f5875eaVar.setTreeIndex(i5);
            int i6 = 0;
            while (i6 < this.fad1943a9.f7fc56270) {
                int i7 = i6 + 1;
                p8f5875eaVar.setTreeHeight(i7);
                if ((i4 / (1 << i6)) % i != 0) {
                    p8f5875eaVar.setTreeIndex((p8f5875eaVar.getTreeIndex() - 1) / 2);
                    bArr3[1] = this.fad1943a9.mo590H(bArr2, p8f5875eaVar, authPath[i6], bArr3[0]);
                } else {
                    p8f5875eaVar.setTreeIndex(p8f5875eaVar.getTreeIndex() / i);
                    bArr3[1] = this.fad1943a9.mo590H(bArr2, p8f5875eaVar, bArr3[0], authPath[i6]);
                }
                bArr3[0] = bArr3[1];
                i6 = i7;
                i = i;
            }
            int i8 = i;
            bArr4[i3] = bArr3[0];
            i3++;
            i = i8;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar2 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea(p8f5875eaVar);
        p8f5875eaVar2.setType(4);
        p8f5875eaVar2.setKeyValueTupleAddress(p8f5875eaVar.getKeyValueTupleAddress());
        return this.fad1943a9.T_l(bArr2, p8f5875eaVar2, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr4));
    }

    byte[] pkGen(byte[] bArr, byte[] bArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((13 + 17) % 17 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar2 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea(p8f5875eaVar);
        byte[][] bArr3 = new byte[this.fad1943a9.fa5f3c6a1][];
        int i = 0;
        while (i < this.fad1943a9.fa5f3c6a1) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p58fdc63e p58fdc63eVar = this;
            bArr3[i] = p58fdc63eVar.treehash(bArr, i * this.fad1943a9.fb9ece18c, this.fad1943a9.f7fc56270, bArr2, p8f5875eaVar);
            i++;
            this = p58fdc63eVar;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p58fdc63e p58fdc63eVar2 = this;
        p8f5875eaVar2.setType(4);
        p8f5875eaVar2.setKeyValueTupleAddress(p8f5875eaVar.getKeyValueTupleAddress());
        return p58fdc63eVar2.fad1943a9.T_l(bArr2, p8f5875eaVar2, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr3));
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p4780ae5b[] Sign(byte[] bArr, byte[] bArr2, byte[] bArr3, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((14 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p58fdc63e p58fdc63eVar = this;
        int[] iArrMb49db3b3 = mb49db3b3(bArr, p58fdc63eVar.fad1943a9.fa5f3c6a1, p58fdc63eVar.fad1943a9.f7fc56270);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p4780ae5b[] p4780ae5bVarArr = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p4780ae5b[p58fdc63eVar.fad1943a9.fa5f3c6a1];
        int i = p58fdc63eVar.fad1943a9.fb9ece18c;
        int i2 = 0;
        while (i2 < p58fdc63eVar.fad1943a9.fa5f3c6a1) {
            int i3 = iArrMb49db3b3[i2];
            p8f5875eaVar.setTreeHeight(0);
            int i4 = i2 * i;
            p8f5875eaVar.setTreeIndex(i4 + i3);
            byte[] bArr4 = bArr2;
            byte[] bArrPRF = p58fdc63eVar.fad1943a9.PRF(bArr4, p8f5875eaVar);
            byte[][] bArr5 = new byte[p58fdc63eVar.fad1943a9.f7fc56270][];
            int i5 = 0;
            while (i5 < p58fdc63eVar.fad1943a9.f7fc56270) {
                int i6 = 1 << i5;
                bArr5[i5] = p58fdc63eVar.treehash(bArr4, ((1 ^ (i3 / i6)) * i6) + i4, i5, bArr3, p8f5875eaVar);
                i5++;
                p58fdc63eVar = this;
                bArr4 = bArr2;
                p8f5875eaVar = p8f5875eaVar;
            }
            p4780ae5bVarArr[i2] = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p4780ae5b(bArrPRF, bArr5);
            i2++;
            p58fdc63eVar = this;
        }
        return p4780ae5bVarArr;
    }

    byte[] treehash(byte[] bArr, int i, int i2, byte[] bArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((6 + 13) % 13 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar2 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea(p8f5875eaVar);
        java.util.List linkedList = new java.util.List();
        int i3 = 1 << i2;
        if (i % i3 != 0) {
            return null;
        }
        for (int i4 = 0; i4 < i3; i4++) {
            p8f5875eaVar2.setTreeHeight(0);
            int i5 = i + i4;
            p8f5875eaVar2.setTreeIndex(i5);
            byte[] bArrMo589F = this.fad1943a9.mo589F(bArr2, p8f5875eaVar2, this.fad1943a9.PRF(bArr, p8f5875eaVar2));
            p8f5875eaVar2.setTreeHeight(1);
            p8f5875eaVar2.setTreeIndex(i5);
            while (!linkedList.Count == 0 && ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0f824b02) linkedList[0)).f63f3334a == p8f5875eaVar2.getTreeHeight()) {
                p8f5875eaVar2.setTreeIndex((p8f5875eaVar2.getTreeIndex() - 1) / 2);
                bArrMo589F = this.fad1943a9.mo590H(bArr2, p8f5875eaVar2, ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0f824b02) linkedList.Remove(0)).f651fd5d7, bArrMo589F);
                p8f5875eaVar2.setTreeHeight(p8f5875eaVar2.getTreeHeight() + 1);
            }
            linkedList.Add(0, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0f824b02(bArrMo589F, p8f5875eaVar2.getTreeHeight()));
        }
        return ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0f824b02) linkedList[0)).f651fd5d7;
    }
}

