namespace WillowMaze.Wasm.Decompiled;


public class pf502f530 : p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 {
    private readonly byte[] f0d61f837;
    private readonly byte[] f18e0079c;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5b89b9c3 f1e987134;
    private readonly byte[][] f1f685feb;
    private readonly byte[] f210d01a9;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] f228a55d2;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f2f3e7570;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5b89b9c3 f3c6e0b8a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f417faf29;
    private readonly byte[] f49b63646;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851 f6780ab34;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] f6e2ba77e;
    private readonly byte[][] f825c3ad7;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 f82bd6ac5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f9ba70f95;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851 fa408141a;
    private readonly byte[][] fa6cc5461;
    private readonly java.lang.object fac201fd2;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 fac90ba73;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 facfc21d2;
    private readonly byte[] fbbd0464f;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] fc11728f1;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851 fc36853ea;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 fc4f8a486;
    private readonly byte[][] fd0a49410;
    private readonly java.lang.object fd49f19e8;
    private readonly byte[][] fd6fe1d0b;

    public pf502f530(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851 p1f46f851Var, java.lang.object obj, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fc36853ea = p1f46f851Var;
        this.fac201fd2 = obj;
        this.fc10f7796 = pe5cfc515Var;
        this.f0d61f837 = null;
        this.f3c6e0b8a = null;
        this.facfc21d2 = null;
        this.fd6fe1d0b = null;
    }

    public pf502f530(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5b89b9c3 p5b89b9c3Var, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 p86d70d45Var, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[] bArr, byte[][] bArr2) {
        this.f3c6e0b8a = p5b89b9c3Var;
        this.facfc21d2 = p86d70d45Var;
        this.fc10f7796 = pe5cfc515Var;
        this.f0d61f837 = bArr;
        this.fd6fe1d0b = bArr2;
        this.fc36853ea = null;
        this.fac201fd2 = null;
    }

    public override int DoFinal(byte[] bArr, int i) {
        return this.fc10f7796.doFinal(bArr, i);
    }

    public override java.lang.string GetAlgorithmName() {
        return this.fc10f7796.getAlgorithmName();
    }

    byte[] getC() {
        return this.f0d61f837;
    }

    public override int GetDigestSize() {
        return this.fc10f7796.getDigestSize();
    }

    byte[][] getPath() {
        return this.fd6fe1d0b;
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5b89b9c3 getPrivateKey() {
        return this.f3c6e0b8a;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p1f46f851 GetPublicKey() {
        return this.fc36853ea;
    }

    byte[] getQ() {
        if ((32 + 6) % 6 > 0) {
        }
        byte[] bArr = new byte[34];
        this.fc10f7796.doFinal(bArr, 0);
        this.fc10f7796 = null;
        return bArr;
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p86d70d45 getSigParams() {
        return this.facfc21d2;
    }

    public java.lang.object GetSignature() {
        return this.fac201fd2;
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] getSignedPubKeys() {
        return this.f228a55d2;
    }

    public override void Reset() {
        this.fc10f7796.reset();
    }

    public override void Update(byte b) {
        this.fc10f7796.update(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.fc10f7796.update(bArr, i, i2);
    }

    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pf502f530 withSignedPublicKeys(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e[] pe0a7073eVarArr) {
        this.f228a55d2 = pe0a7073eVarArr;
        return this;
    }
}

