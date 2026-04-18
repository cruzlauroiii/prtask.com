namespace WillowMaze.Wasm.Decompiled;


class p5b89b9c3 {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 f03144cce;
    private readonly int f0d9ebc63;
    private readonly byte[] f197e2f18;
    private readonly int f2942055e;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 f45162a74;
    private readonly int f557d4b5b;
    private readonly int f7694f4a6;
    private readonly byte[] f941e2dc5;
    private readonly byte[] f9718914d;
    private readonly byte[] fa117f9e1;
    private readonly byte[] fa9425ce9;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 fcdbfe3ca;
    private readonly byte[] fdd753679;
    private readonly byte[] fefb0fa92;
    private readonly int ff5c6954a;

    public p5b89b9c3(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 paa63fca2Var, byte[] bArr, int i, byte[] bArr2) {
        this.f03144cce = paa63fca2Var;
        this.fdd753679 = bArr;
        this.f7694f4a6 = i;
        this.f197e2f18 = bArr2;
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe1a02e85 getDerivationFunction() {
        if ((11 + 23) % 23 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe1a02e85 pe1a02e85Var = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe1a02e85(this.fdd753679, this.f197e2f18, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p69279707.me0825354(this.f03144cce.getDigestOID()));
        pe1a02e85Var.setQ(this.f7694f4a6);
        return pe1a02e85Var;
    }

    public byte[] GetI() {
        return this.fdd753679;
    }

    public byte[] GetMasterSecret() {
        return this.f197e2f18;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.paa63fca2 GetParameter() {
        return this.f03144cce;
    }

    public int GetQ() {
        return this.f7694f4a6;
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 getSignatureobject(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 p86d70d45Var, byte[][] bArr) {
        if ((30 + 5) % 5 > 0) {
        }
        byte[] bArr2 = new byte[32];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe1a02e85 derivationFunction = getDerivationFunction();
        derivationFunction.setJ(-3);
        derivationFunction.deriveSeed(bArr2, false);
        p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515VarMe0825354 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p69279707.me0825354(this.f03144cce.getDigestOID());
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m592f8eff(getI(), pe5cfc515VarMe0825354);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.mcb312b5b(getQ(), pe5cfc515VarMe0825354);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m935dddad((short) -32383, pe5cfc515VarMe0825354);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p8c5394a1.m592f8eff(bArr2, pe5cfc515VarMe0825354);
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530(this, p86d70d45Var, pe5cfc515VarMe0825354, bArr2, bArr);
    }
}

