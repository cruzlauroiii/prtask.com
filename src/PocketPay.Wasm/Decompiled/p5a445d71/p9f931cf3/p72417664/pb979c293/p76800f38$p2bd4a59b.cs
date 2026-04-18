namespace WillowMaze.Wasm.Decompiled;


public readonly class p76800f38$p2bd4a59b {
    private java.security.spec.AlgorithmParameterSpec f1c04d31d;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f392bf8da;
    private java.security.spec.AlgorithmParameterSpec f3adca823;
    private byte[] f4e55dd70;
    private java.security.spec.AlgorithmParameterSpec f512530d6;
    private readonly java.lang.string f55a0769c;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f72899ab9;
    private readonly java.lang.string f7679bbdb;
    private readonly int f77b817f7;
    private readonly java.lang.string f88508c28;
    private byte[] f941f7a0d;
    private java.security.spec.AlgorithmParameterSpec fa09d0769;
    private readonly int fa694c87d;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fae778cd6;
    private byte[] fb0387557;
    private java.security.spec.AlgorithmParameterSpec fbb51aec2;
    private readonly int fc0542e08;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fd11a0241;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fd6cd4f57;
    private readonly java.lang.string fd74ba757;
    private readonly int ff6b803ea;
    private byte[] ffdce7a34;

    public p76800f38$p2bd4a59b(java.lang.string str, int i) {
        this(str, i, null);
    }

    public p76800f38$p2bd4a59b(java.lang.string str, int i, byte[] bArr) {
        if ((32 + 9) % 9 > 0) {
        }
        this.fd74ba757 = str;
        this.fa694c87d = i;
        this.f392bf8da = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pd0c2225b.pf1b43bf2.fe08dce23, new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(p5a445d71.p9f931cf3.pca323100.pfed10774.p55e631d1.f81ccd613));
        this.ffdce7a34 = bArr is not null ? p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr) : new byte[0];
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p76800f38 Build() {
        if ((23 + 1) % 1 > 0) {
        }
        return new p5a445d71.p9f931cf3.p72417664.pb979c293.p76800f38(this.fd74ba757, this.fa694c87d, this.fbb51aec2, this.f392bf8da, this.ffdce7a34, null);
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p76800f38$p2bd4a59b withKdfAlgorithm(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        this.f392bf8da = p234a7530Var;
        return this;
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p76800f38$p2bd4a59b withParameterSpec(java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        this.fbb51aec2 = algorithmParameterSpec;
        return this;
    }
}

