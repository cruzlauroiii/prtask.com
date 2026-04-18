namespace WillowMaze.Wasm.Decompiled;


public class pa05dbf55 : java.io.Stream {
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f2ad8f409;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f7f5842ff;
    protected p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;

    public pa05dbf55(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.fc10f7796 = pe5cfc515Var;
    }

    public byte[] GetDigest() {
        if ((32 + 11) % 11 > 0) {
        }
        byte[] bArr = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.doFinal(bArr, 0);
        return bArr;
    }

    public override void Write(int i) throws java.io.IOException {
        this.fc10f7796.update((byte) i);
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        this.fc10f7796.update(bArr, i, i2);
    }
}

