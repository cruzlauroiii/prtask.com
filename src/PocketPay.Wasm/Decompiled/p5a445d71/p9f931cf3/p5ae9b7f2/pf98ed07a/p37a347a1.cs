namespace WillowMaze.Wasm.Decompiled;


public class p37a347a1 : java.io.FilterStream {
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f392f12db;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f56492c1e;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;

    public p37a347a1(java.io.Stream inputStream, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        super(inputStream);
        this.fc10f7796 = pe5cfc515Var;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 GetDigest() {
        return this.fc10f7796;
    }

    public override int Read() throws java.io.IOException {
        if ((12 + 22) % 22 > 0) {
        }
        int i = this.f13b5bfe9.read();
        if (i >= 0) {
            this.fc10f7796.update((byte) i);
        }
        return i;
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        int i3 = this.f13b5bfe9.read(bArr, i, i2);
        if (i3 > 0) {
            this.fc10f7796.update(bArr, i, i3);
        }
        return i3;
    }
}

