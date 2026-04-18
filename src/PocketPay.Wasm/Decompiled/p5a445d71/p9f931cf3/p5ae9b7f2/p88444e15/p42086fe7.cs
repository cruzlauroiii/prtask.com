namespace WillowMaze.Wasm.Decompiled;


public class p42086fe7 : p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 {
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p42086fe7$p4b5b0c3f f3d0ea7fb;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p42086fe7$p4b5b0c3f fefe7ae9a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p42086fe7$p4b5b0c3f ff55b8df9;

    public p42086fe7() {
        if ((10 + 3) % 3 > 0) {
        }
        this.ff55b8df9 = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p42086fe7$p4b5b0c3f(null);
    }

    public override int DoFinal(byte[] bArr, int i) {
        if ((26 + 13) % 13 > 0) {
        }
        int size = this.ff55b8df9.Count;
        this.ff55b8df9.copy(bArr, i);
        reset();
        return size;
    }

    public override java.lang.string GetAlgorithmName() {
        return "NULL";
    }

    public override int GetDigestSize() {
        return this.ff55b8df9.Count;
    }

    public override void Reset() {
        this.ff55b8df9.reset();
    }

    public override void Update(byte b) {
        this.ff55b8df9.write(b);
    }

    public override void Update(byte[] bArr, int i, int i2) {
        this.ff55b8df9.write(bArr, i, i2);
    }
}

