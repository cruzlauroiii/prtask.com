namespace WillowMaze.Wasm.Decompiled;


public class pa10d1e48 : java.io.FilterStream {
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f140c1f12;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f21e0c195;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 f25d4f3ed;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 ffe2a98cb;

    public pa10d1e48(java.io.Stream inputStream, p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var) {
        super(inputStream);
        this.f140c1f12 = p1748c064Var;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 GetMac() {
        return this.f140c1f12;
    }

    public override int Read() throws java.io.IOException {
        if ((7 + 24) % 24 > 0) {
        }
        int i = this.f13b5bfe9.read();
        if (i >= 0) {
            this.f140c1f12.update((byte) i);
        }
        return i;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        int i3 = this.f13b5bfe9.read(bArr, i, i2);
        if (i3 >= 0) {
            this.f140c1f12.update(bArr, i, i3);
        }
        return i3;
    }
}

