namespace WillowMaze.Wasm.Decompiled;


public class p221def6f {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a f25a6c368;
    private readonly byte[] f3ff1e624;
    private readonly byte[] f93e9d78a;
    private readonly byte[] f98bf46eb;
    private readonly byte[] f9e81e7b9;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a fb9515e61;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a fc36853ea;
    private readonly byte[] fc8abd7de;

    public p221def6f(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar, byte[] bArr) {
        this.fc36853ea = pcfffbc4aVar;
        this.f9e81e7b9 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a GetPublicKey() {
        return this.fc36853ea;
    }

    public byte[] GetSharedValue() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f9e81e7b9);
    }
}

