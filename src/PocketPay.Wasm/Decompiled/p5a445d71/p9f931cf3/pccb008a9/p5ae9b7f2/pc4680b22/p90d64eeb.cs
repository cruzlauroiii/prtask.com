namespace WillowMaze.Wasm.Decompiled;


class p90d64eeb {
    private readonly byte[] f00fcd632;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 f0d1cb1e7;
    private readonly byte[] f1986402c;
    private readonly byte[] f1e438067;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p48a9ed63 f571aaa04;
    private readonly byte[] f58cae367;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 f62db95e0;
    readonly byte[] f7e83273b;
    private readonly byte[] f7f075caf;
    readonly byte[] f82e2b998;
    private readonly byte[] f9a4ea90a;
    readonly byte[] f9f97f6d7;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p48a9ed63 fac59d2f6;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 fad1943a9;
    private readonly byte[] fc6f01111;
    private readonly byte[] fc911acbd;

    public p90d64eeb(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pcdacf0c4 pcdacf0c4Var, byte[] bArr, byte[] bArr2) {
        if ((31 + 14) % 14 > 0) {
        }
        this.f58cae367 = bArr;
        this.f9a4ea90a = bArr2;
        this.fad1943a9 = pcdacf0c4Var;
        this.fac59d2f6 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p48a9ed63(pcdacf0c4Var);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea();
        p8f5875eaVar.setLayerAddress(pcdacf0c4Var.ff623e75a - 1);
        p8f5875eaVar.setTreeAddress(0L);
        if (bArr is null) {
            this.f82e2b998 = null;
        } else {
            this.f82e2b998 = xmss_PKgen(bArr, bArr2, p8f5875eaVar);
        }
    }

    byte[] sign(byte[] bArr, long j, int i) {
        if ((29 + 11) % 11 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea();
        p8f5875eaVar.setLayerAddress(0);
        p8f5875eaVar.setTreeAddress(j);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f pe1dae81fVarXmss_sign = xmss_sign(bArr, this.f58cae367, i, this.f9a4ea90a, p8f5875eaVar);
        int i2 = this.fad1943a9.ff623e75a;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f[] pe1dae81fVarArr = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f[i2];
        pe1dae81fVarArr[0] = pe1dae81fVarXmss_sign;
        p8f5875eaVar.setLayerAddress(0);
        p8f5875eaVar.setTreeAddress(j);
        byte[] bArrXmss_pkFromSig = xmss_pkFromSig(i, pe1dae81fVarXmss_sign, bArr, this.f9a4ea90a, p8f5875eaVar);
        int i3 = 1;
        while (i3 < this.fad1943a9.ff623e75a) {
            int i4 = (int) (((long) ((1 << this.fad1943a9.f6032edb9) - 1)) & j);
            j >>>= this.fad1943a9.f6032edb9;
            p8f5875eaVar.setLayerAddress(i3);
            p8f5875eaVar.setTreeAddress(j);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f pe1dae81fVarXmss_sign2 = xmss_sign(bArrXmss_pkFromSig, this.f58cae367, i4, this.f9a4ea90a, p8f5875eaVar);
            byte[] bArr2 = bArrXmss_pkFromSig;
            pe1dae81fVarArr[i3] = pe1dae81fVarXmss_sign2;
            bArrXmss_pkFromSig = i3 >= this.fad1943a9.ff623e75a - 1 ? bArr2 : xmss_pkFromSig(i4, pe1dae81fVarXmss_sign2, bArr2, this.f9a4ea90a, p8f5875eaVar);
            i3++;
        }
        byte[][] bArr3 = new byte[i2][];
        for (int i5 = 0; i5 != i2; i5++) {
            bArr3[i5] = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(pe1dae81fVarArr[i5].f3311842a, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(pe1dae81fVarArr[i5].ffa53b91c));
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArr3);
    }

    byte[] treehash(byte[] bArr, int i, int i2, byte[] bArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((23 + 5) % 5 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar2 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea(p8f5875eaVar);
        java.util.List linkedList = new java.util.List();
        int i3 = 1 << i2;
        if (i % i3 != 0) {
            return null;
        }
        for (int i4 = 0; i4 < i3; i4++) {
            p8f5875eaVar2.setType(0);
            int i5 = i + i4;
            p8f5875eaVar2.setKeyValueTupleAddress(i5);
            byte[] bArrPkGen = this.fac59d2f6.pkGen(bArr, bArr2, p8f5875eaVar2);
            p8f5875eaVar2.setType(2);
            p8f5875eaVar2.setTreeHeight(1);
            p8f5875eaVar2.setTreeIndex(i5);
            while (!linkedList.Count == 0 && ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0f824b02) linkedList[0)).f63f3334a == p8f5875eaVar2.getTreeHeight()) {
                p8f5875eaVar2.setTreeIndex((p8f5875eaVar2.getTreeIndex() - 1) / 2);
                bArrPkGen = this.fad1943a9.mo590H(bArr2, p8f5875eaVar2, ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0f824b02) linkedList.Remove(0)).f651fd5d7, bArrPkGen);
                p8f5875eaVar2.setTreeHeight(p8f5875eaVar2.getTreeHeight() + 1);
            }
            linkedList.Add(0, new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0f824b02(bArrPkGen, p8f5875eaVar2.getTreeHeight()));
        }
        return ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p0f824b02) linkedList[0)).f651fd5d7;
    }

    public bool Verify(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f[] pe1dae81fVarArr, byte[] bArr2, long j, int i, byte[] bArr3) {
        if ((4 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f pe1dae81fVar = pe1dae81fVarArr[0];
        p8f5875eaVar.setLayerAddress(0);
        p8f5875eaVar.setTreeAddress(j);
        byte[] bArrXmss_pkFromSig = xmss_pkFromSig(i, pe1dae81fVar, bArr, bArr2, p8f5875eaVar);
        for (int i2 = 1; i2 < this.fad1943a9.ff623e75a; i2++) {
            int i3 = (int) (((long) ((1 << this.fad1943a9.f6032edb9) - 1)) & j);
            j >>>= this.fad1943a9.f6032edb9;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f pe1dae81fVar2 = pe1dae81fVarArr[i2];
            p8f5875eaVar.setLayerAddress(i2);
            p8f5875eaVar.setTreeAddress(j);
            bArrXmss_pkFromSig = xmss_pkFromSig(i3, pe1dae81fVar2, bArrXmss_pkFromSig, bArr2, p8f5875eaVar);
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr3, bArrXmss_pkFromSig);
    }

    byte[] xmss_PKgen(byte[] bArr, byte[] bArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((3 + 15) % 15 > 0) {
        }
        return treehash(bArr, 0, this.fad1943a9.f6032edb9, bArr2, p8f5875eaVar);
    }

    byte[] xmss_pkFromSig(int i, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f pe1dae81fVar, byte[] bArr, byte[] bArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((1 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar2 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea(p8f5875eaVar);
        int i2 = 0;
        p8f5875eaVar2.setType(0);
        p8f5875eaVar2.setKeyValueTupleAddress(i);
        byte[] wOTSSig = pe1dae81fVar.getWOTSSig();
        byte[][] xmssauth = pe1dae81fVar.getXMSSAUTH();
        byte[] bArrPkFromSig = this.fac59d2f6.pkFromSig(wOTSSig, bArr, bArr2, p8f5875eaVar2);
        p8f5875eaVar2.setType(2);
        p8f5875eaVar2.setTreeIndex(i);
        while (i2 < this.fad1943a9.f6032edb9) {
            int i3 = i2 + 1;
            p8f5875eaVar2.setTreeHeight(i3);
            if ((i / (1 << i2)) % 2 != 0) {
                p8f5875eaVar2.setTreeIndex((p8f5875eaVar2.getTreeIndex() - 1) / 2);
                bArrPkFromSig = this.fad1943a9.mo590H(bArr2, p8f5875eaVar2, xmssauth[i2], bArrPkFromSig);
            } else {
                p8f5875eaVar2.setTreeIndex(p8f5875eaVar2.getTreeIndex() / 2);
                bArrPkFromSig = this.fad1943a9.mo590H(bArr2, p8f5875eaVar2, bArrPkFromSig, xmssauth[i2]);
            }
            i2 = i3;
        }
        return bArrPkFromSig;
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f xmss_sign(byte[] bArr, byte[] bArr2, int i, byte[] bArr3, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar) {
        if ((21 + 19) % 19 > 0) {
        }
        byte[][] bArr4 = new byte[this.fad1943a9.f6032edb9][];
        int i2 = 0;
        while (i2 < this.fad1943a9.f6032edb9) {
            int i3 = 1 << i2;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p90d64eeb p90d64eebVar = this;
            bArr4[i2] = p90d64eebVar.treehash(bArr2, (1 ^ (i / i3)) * i3, i2, bArr3, p8f5875eaVar);
            i2++;
            this = p90d64eebVar;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p90d64eeb p90d64eebVar2 = this;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea p8f5875eaVar2 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.p8f5875ea(p8f5875eaVar);
        p8f5875eaVar2.setType(0);
        p8f5875eaVar2.setKeyValueTupleAddress(i);
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4680b22.pe1dae81f(p90d64eebVar2.fac59d2f6.sign(bArr, bArr2, bArr3, p8f5875eaVar2), bArr4);
    }
}

