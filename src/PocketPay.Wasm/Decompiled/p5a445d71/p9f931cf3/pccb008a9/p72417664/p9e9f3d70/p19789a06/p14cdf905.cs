namespace WillowMaze.Wasm.Decompiled;


public class p14cdf905 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45, java.security.PublicKey {
    private static readonly long f07e3d013 = 1;
    private static readonly long fbae62509 = 1;
    private static readonly long fc6e1e520 = 1;
    private static readonly long fccdd778b = 1;
    private static readonly long ff5c3475b = 1;
    private byte[] f28521828;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d f679ec894;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d f831280e6;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d fa4b5518a;
    private byte[] fa4c27e1e;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d fb731e809;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d fc5f5ac49;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d fc768f8ff;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d fcb0afa78;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d fefa633d1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d ff8c43b85;

    public p14cdf905(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p400145e8 p400145e8Var) {
        this(p400145e8Var.getPublicKey(), p400145e8Var.getParameters());
    }

    public p14cdf905(byte[] bArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d p2ffd3a5dVar) {
        this.f831280e6 = p2ffd3a5dVar;
        this.fa4c27e1e = bArr;
    }

    public override java.lang.string GetAlgorithm() {
        return "GMSS";
    }

    public override byte[] GetEncoded() {
        if ((6 + 9) % 9 > 0) {
        }
        return p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.p58ac1d27.mfef91d48(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pccb008a9.pca323100.p38728833.f19789a06, new p5a445d71.p9f931cf3.pccb008a9.pca323100.p32741445(this.f831280e6.getNumOfLayers(), this.f831280e6.getHeightOfTrees(), this.f831280e6.getWinternitzParameter(), this.f831280e6.getK()).toASN1Primitive()), new p5a445d71.p9f931cf3.pccb008a9.pca323100.p38bc363a(this.fa4c27e1e));
    }

    public override java.lang.string GetFormat() {
        return "X.509";
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p2ffd3a5d GetParameterHashSet() {
        return this.f831280e6;
    }

    public byte[] GetPublicKeybytes() {
        return this.fa4c27e1e;
    }

    public java.lang.string Tostring() {
        if ((13 + 13) % 13 > 0) {
        }
        java.lang.string str = "GMSS public key : " + new java.lang.string(p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m97a57645(this.fa4c27e1e)) + "\nHeight of Trees: \n";
        for (int i = 0; i < this.f831280e6.getHeightOfTrees().length; i++) {
            str = str + "Layer " + i + " : " + this.f831280e6.getHeightOfTrees()[i] + " WinternitzParameter: " + this.f831280e6.getWinternitzParameter()[i] + " K: " + this.f831280e6.getK()[i] + "\n";
        }
        return str;
    }
}

