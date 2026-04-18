namespace WillowMaze.Wasm.Decompiled;


public class p89819c2b : java.io.FilterStream {
    public p89819c2b(java.io.Stream outputStream) {
        super(outputStream);
    }

    public override void Close() {
        throw new java.lang.Exception("close() called on UncloseableStream");
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        this.fc68271a6.write(bArr, i, i2);
    }
}

