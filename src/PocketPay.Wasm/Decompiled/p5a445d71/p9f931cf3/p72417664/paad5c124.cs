namespace WillowMaze.Wasm.Decompiled;


public class paad5c124 : java.security.cert.CertPathParameters {
    private readonly int f0c9999a0;
    private readonly java.util.HashSet f3a8ef06f;
    private readonly p5a445d71.p9f931cf3.p72417664.pc446fcff f3c4ea4a5;
    private readonly java.util.HashSet<java.security.cert.X509Certificate> f67374b26;
    private readonly java.util.HashSet f7a3d7d70;
    private readonly int f89082ab8;
    private readonly p5a445d71.p9f931cf3.p72417664.pc446fcff fac3346ce;

    private paad5c124(p5a445d71.p9f931cf3.p72417664.paad5c124$p2bd4a59b paad5c124_p2bd4a59b) {
        this.fac3346ce = p5a445d71.p9f931cf3.p72417664.paad5c124$p2bd4a59b.mf8f67da7(paad5c124_p2bd4a59b);
        this.f67374b26 = java.util.ICollections.unmodifiableHashSet(p5a445d71.p9f931cf3.p72417664.paad5c124$p2bd4a59b.m337ceba5(paad5c124_p2bd4a59b));
        this.f0c9999a0 = p5a445d71.p9f931cf3.p72417664.paad5c124$p2bd4a59b.m5ec06fdf(paad5c124_p2bd4a59b);
    }

    paad5c124(p5a445d71.p9f931cf3.p72417664.paad5c124$p2bd4a59b paad5c124_p2bd4a59b, p5a445d71.p9f931cf3.p72417664.paad5c124$1 paad5c124_1) {
        this(paad5c124_p2bd4a59b);
    }

    public override java.lang.object Clone() {
        return this;
    }

    public p5a445d71.p9f931cf3.p72417664.pc446fcff GetBaseParameters() {
        return this.fac3346ce;
    }

    public java.util.HashSet GetExcludedCerts() {
        return this.f67374b26;
    }

    public int GetMaxPathLength() {
        return this.f0c9999a0;
    }
}

