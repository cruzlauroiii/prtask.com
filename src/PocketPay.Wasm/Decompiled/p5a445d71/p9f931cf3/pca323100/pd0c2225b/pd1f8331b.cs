namespace WillowMaze.Wasm.Decompiled;


public class pd1f8331b : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private static p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5 f0ea7dd4d = new p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5();
    private static p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5 f45b74b3e;
    private static p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5 f6b430dd4;
    private static p5a445d71.p9f931cf3.pca323100.pd0c2225b.pb79a74f5 ffed8a5fe;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a f1feed41b;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a f3c424853;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a f76eb99cc;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a f8fa14cdd;

    public pd1f8331b(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        this.f8fa14cdd = p5a196a0aVar;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a GetValue() {
        return this.f8fa14cdd;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((24 + 31) % 31 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.p6f0e511c(f0ea7dd4d.integerTobytes(this.f8fa14cdd.toBigint(), f0ea7dd4d.getbyteLength(this.f8fa14cdd)));
    }
}

