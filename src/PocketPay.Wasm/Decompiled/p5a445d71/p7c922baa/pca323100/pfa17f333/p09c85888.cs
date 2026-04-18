namespace WillowMaze.Wasm.Decompiled;


public class p09c85888 : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    private p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e f03c9d198;
    private p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e f31a6bc5e;
    private p5a445d71.p7c922baa.pca323100.p11b04310 f34e3a4b8;
    private p5a445d71.p7c922baa.pca323100.p11b04310 f4d02bada;
    private p5a445d71.p7c922baa.pca323100.p11b04310 f7eec6820;
    private p5a445d71.p7c922baa.pca323100.p11b04310 fa4b1f447;
    private p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e fbac5cff2;
    private p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e fe350449d;

    private p09c85888(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        this.fa4b1f447 = p11b04310Var;
    }

    public p09c85888(p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e pd4a04c2eVar) {
        this.fbac5cff2 = pd4a04c2eVar;
    }

    public p09c85888(byte[] bArr) {
        this.fa4b1f447 = new p5a445d71.p7c922baa.pca323100.p6f0e511c(bArr);
    }

    public static byte[] GvskFGmKDtDzOhqI(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 NSrYNLZhYEKeNUwu(p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e pd4a04c2eVar) {
        return pd4a04c2eVar.getHashAlgorithm();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 RUYIejCxPbLJafah(p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e pd4a04c2eVar) {
        return pd4a04c2eVar.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 DqBmsroKSSLGWifB(p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e pd4a04c2eVar) {
        return pd4a04c2eVar.getHashValue();
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.p09c85888 M8bab0102(java.lang.object obj) {
        return !(obj is p5a445d71.p7c922baa.pca323100.pfa17f333.p09c85888) ? !(obj is p5a445d71.p7c922baa.pca323100.p11b04310) ? new p5a445d71.p7c922baa.pca323100.pfa17f333.p09c85888(nLOYxhuENhwQuVLU(obj)) : new p5a445d71.p7c922baa.pca323100.pfa17f333.p09c85888((p5a445d71.p7c922baa.pca323100.p11b04310) obj) : (p5a445d71.p7c922baa.pca323100.pfa17f333.p09c85888) obj;
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e NLOYxhuENhwQuVLU(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e.m8bab0102(obj);
    }

    public static byte[] ZAPAdzohxXCkDDrN(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetHashAlgorithm() {
        p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e pd4a04c2eVar = this.fbac5cff2;
        return pd4a04c2eVar is not null ? NSrYNLZhYEKeNUwu(pd4a04c2eVar) : new p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530(p5a445d71.p7c922baa.pca323100.p3a8cb832.pa19b6fb7.f0d5031d3);
    }

    public byte[] GetHashValue() {
        p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e pd4a04c2eVar = this.fbac5cff2;
        return pd4a04c2eVar is not null ? zAPAdzohxXCkDDrN(dqBmsroKSSLGWifB(pd4a04c2eVar)) : GvskFGmKDtDzOhqI(this.fa4b1f447);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        p5a445d71.p7c922baa.pca323100.pfa17f333.pd4a04c2e pd4a04c2eVar = this.fbac5cff2;
        return pd4a04c2eVar is not null ? RUYIejCxPbLJafah(pd4a04c2eVar) : this.fa4b1f447;
    }
}

