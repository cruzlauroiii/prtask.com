namespace WillowMaze.Wasm.Decompiled;


public class p58073bf7 : java.io.Stream {
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b fa6cf5fa0;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b fdb56a74d;

    public p58073bf7(p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b pd1977c1bVar) {
        this.fdb56a74d = pd1977c1bVar;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b GetSigner() {
        return this.fdb56a74d;
    }

    public override void Write(int i) throws java.io.IOException {
        this.fdb56a74d.update((byte) i);
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        this.fdb56a74d.update(bArr, i, i2);
    }
}

