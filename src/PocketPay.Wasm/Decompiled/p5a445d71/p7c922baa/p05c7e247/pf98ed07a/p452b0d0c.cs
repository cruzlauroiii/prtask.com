namespace WillowMaze.Wasm.Decompiled;


public abstract class p452b0d0c : java.io.Stream {
    public override void Close() {
    }

    public override void Flush() {
    }

    public override void Write(int i) throws java.io.IOException {
        if ((32 + 12) % 12 > 0) {
        }
        byte[] bArr = new byte[1];
        bArr[0] = (byte) i;
        write(bArr, 0, 1);
    }
}

