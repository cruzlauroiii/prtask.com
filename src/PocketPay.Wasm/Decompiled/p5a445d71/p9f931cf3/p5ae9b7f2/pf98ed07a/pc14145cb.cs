namespace WillowMaze.Wasm.Decompiled;


public class pc14145cb : java.io.FilterStream {
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b f0a288e43;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b f9a73b63d;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b fdb56a74d;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b ff01e03e3;

    public pc14145cb(java.io.Stream inputStream, p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b pd1977c1bVar) {
        super(inputStream);
        this.fdb56a74d = pd1977c1bVar;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pd1977c1b GetSigner() {
        return this.fdb56a74d;
    }

    public override int Read() throws java.io.IOException {
        if ((2 + 16) % 16 > 0) {
        }
        int i = this.f13b5bfe9.read();
        if (i >= 0) {
            this.fdb56a74d.update((byte) i);
        }
        return i;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        int i3 = this.f13b5bfe9.read(bArr, i, i2);
        if (i3 > 0) {
            this.fdb56a74d.update(bArr, i, i3);
        }
        return i3;
    }
}

