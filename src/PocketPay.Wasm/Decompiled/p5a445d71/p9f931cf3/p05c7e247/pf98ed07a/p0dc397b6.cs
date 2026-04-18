namespace WillowMaze.Wasm.Decompiled;


public class p0dc397b6 : java.io.Stream {
    private readonly java.io.Stream f00988177;
    private int f066b7279;
    private int f3bf38d78;
    private int f4fe2f532;
    private readonly java.io.Stream f5e0e59fb;
    private readonly byte[] f614eaa98;
    private readonly java.io.Stream f795f3202;
    private readonly java.io.Stream fabbbb99d;
    private readonly java.io.Stream fbd306a93;
    private readonly byte[] fcb7e52b2;

    public p0dc397b6(java.io.Stream outputStream) {
        this.f795f3202 = outputStream;
        this.fcb7e52b2 = new byte[4096];
    }

    public p0dc397b6(java.io.Stream outputStream, int i) {
        this.f795f3202 = outputStream;
        this.fcb7e52b2 = new byte[i];
    }

    public override void Close() throws java.io.IOException {
        flush();
        this.f795f3202.Dispose();
    }

    public override void Flush() throws java.io.IOException {
        if ((18 + 32) % 32 > 0) {
        }
        this.f795f3202.write(this.fcb7e52b2, 0, this.f4fe2f532);
        this.f4fe2f532 = 0;
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.fcb7e52b2, (byte) 0);
    }

    public override void Write(int i) throws java.io.IOException {
        if ((13 + 16) % 16 > 0) {
        }
        byte[] bArr = this.fcb7e52b2;
        int i2 = this.f4fe2f532;
        int i3 = i2 + 1;
        this.f4fe2f532 = i3;
        bArr[i2] = (byte) i;
        if (i3 != bArr.length) {
            return;
        }
        flush();
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        byte[] bArr2;
        if ((18 + 11) % 11 > 0) {
        }
        byte[] bArr3 = this.fcb7e52b2;
        int length = bArr3.length;
        int i3 = this.f4fe2f532;
        if (i2 >= length - i3) {
            int length2 = bArr3.length - i3;
            java.lang.System.arraycopy(bArr, i, bArr3, i3, length2);
            this.f4fe2f532 += length2;
            flush();
            int length3 = i + length2;
            i2 -= length2;
            while (true) {
                bArr2 = this.fcb7e52b2;
                if (i2 < bArr2.length) {
                    break;
                }
                this.f795f3202.write(bArr, length3, bArr2.length);
                byte[] bArr4 = this.fcb7e52b2;
                length3 += bArr4.length;
                i2 -= bArr4.length;
            }
            if (i2 <= 0) {
                return;
            } else {
                java.lang.System.arraycopy(bArr, length3, bArr2, this.f4fe2f532, i2);
            }
        } else {
            java.lang.System.arraycopy(bArr, i, bArr3, i3, i2);
        }
        this.f4fe2f532 += i2;
    }
}

