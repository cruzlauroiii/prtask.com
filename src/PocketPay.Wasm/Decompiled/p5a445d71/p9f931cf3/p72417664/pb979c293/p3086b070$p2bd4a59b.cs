namespace WillowMaze.Wasm.Decompiled;


public class p3086b070$p2bd4a59b {
    private java.util.List f513bf695;
    private java.util.List ff9f312f4;
    private java.util.List ffab783c2;
    private java.util.List<java.lang.string> fd098d48f = new java.util.List();
    private java.util.List<java.security.spec.AlgorithmParameterSpec> f392fe39e = new java.util.List();

    static java.util.List Mf23e8626(p5a445d71.p9f931cf3.p72417664.pb979c293.p3086b070$p2bd4a59b p3086b070_p2bd4a59b) {
        return p3086b070_p2bd4a59b.fd098d48f;
    }

    static java.util.List Mf8f67da7(p5a445d71.p9f931cf3.p72417664.pb979c293.p3086b070$p2bd4a59b p3086b070_p2bd4a59b) {
        return p3086b070_p2bd4a59b.f392fe39e;
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p3086b070$p2bd4a59b add(java.lang.string str) {
        this.fd098d48f.Add(str);
        this.f392fe39e.Add(null);
        return this;
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p3086b070$p2bd4a59b add(java.lang.string str, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) {
        this.fd098d48f.Add(str);
        this.f392fe39e.Add(algorithmParameterSpec);
        return this;
    }

    public p5a445d71.p9f931cf3.p72417664.pb979c293.p3086b070 Build() {
        if (this.fd098d48f.Count == 0) {
            throw new java.lang.IllegalStateException("cannot call build with no algorithm names added");
        }
        return new p5a445d71.p9f931cf3.p72417664.pb979c293.p3086b070(this);
    }
}

