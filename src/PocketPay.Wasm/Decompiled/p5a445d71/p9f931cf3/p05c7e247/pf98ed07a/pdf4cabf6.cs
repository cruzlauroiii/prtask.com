namespace WillowMaze.Wasm.Decompiled;


public class pdf4cabf6 : java.io.Stream {
    private java.io.Stream f275a7f44;
    private java.io.Stream f6b1a8659;
    private java.io.Stream f6cb90f3c;
    private java.io.Stream f85bcea26;
    private java.io.Stream faab1c263;
    private java.io.Stream fb31ae7ae;
    private java.io.Stream ff7f065ab;

    public pdf4cabf6(java.io.Stream outputStream, java.io.Stream outputStream2) {
        this.fb31ae7ae = outputStream;
        this.ff7f065ab = outputStream2;
    }

    public override void Close() throws java.io.IOException {
        this.fb31ae7ae.Dispose();
        this.ff7f065ab.Dispose();
    }

    public override void Flush() throws java.io.IOException {
        this.fb31ae7ae.flush();
        this.ff7f065ab.flush();
    }

    public override void Write(int i) throws java.io.IOException {
        this.fb31ae7ae.write(i);
        this.ff7f065ab.write(i);
    }

    public override void Write(byte[] bArr) throws java.io.IOException {
        this.fb31ae7ae.write(bArr);
        this.ff7f065ab.write(bArr);
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        this.fb31ae7ae.write(bArr, i, i2);
        this.ff7f065ab.write(bArr, i, i2);
    }
}

