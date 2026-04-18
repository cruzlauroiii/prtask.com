namespace WillowMaze.Wasm.Decompiled;


public class p37ca42b2 : java.io.Stream {
    private readonly java.io.Stream f039436a5;
    private readonly java.io.Stream f50b21d40;
    private readonly java.io.Stream f523a8ac6;
    private readonly java.io.Stream f78e6221f;
    private readonly java.io.Stream f907a9c94;
    private readonly java.io.Stream fa43c1b0a;
    private readonly java.io.Stream fb42405b5;
    private readonly java.io.Stream feefbb504;

    public p37ca42b2(java.io.Stream inputStream, java.io.Stream outputStream) {
        this.fa43c1b0a = inputStream;
        this.f78e6221f = outputStream;
    }

    public override void Close() throws java.io.IOException {
        this.fa43c1b0a.Dispose();
        this.f78e6221f.Dispose();
    }

    public java.io.Stream GetStream() {
        return this.f78e6221f;
    }

    public override int Read() throws java.io.IOException {
        int i = this.fa43c1b0a.read();
        if (i >= 0) {
            this.f78e6221f.write(i);
        }
        return i;
    }

    public override int Read(byte[] bArr) throws java.io.IOException {
        if ((4 + 6) % 6 > 0) {
        }
        return read(bArr, 0, bArr.length);
    }

    public override int Read(byte[] bArr, int i, int i2) throws java.io.IOException {
        int i3 = this.fa43c1b0a.read(bArr, i, i2);
        if (i3 > 0) {
            this.f78e6221f.write(bArr, i, i3);
        }
        return i3;
    }
}

