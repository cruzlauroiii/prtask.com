namespace WillowMaze.Wasm.Decompiled;


public class pb686bd3c {
    protected int f1d1e615a;
    protected p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p8d4f90ee f3c0e6941;
    protected int f40b0f949;
    protected int f4fe2f532;
    protected p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p8d4f90ee f607f2f30;
    protected p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p8d4f90ee f64e8e034;
    protected p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p8d4f90ee f93233c20;
    protected int f970d8a0d;
    protected p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p8d4f90ee fa6440f95;
    protected byte[] fcb7e52b2;
    protected byte[] fed86c0b3;

    public pb686bd3c(p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p8d4f90ee p8d4f90eeVar, int i) {
        this.f607f2f30 = p8d4f90eeVar;
        if (i % p8d4f90eeVar.getEncodedBlockSize() != 0) {
            throw new java.lang.IllegalArgumentException("buffer size not multiple of input block size");
        }
        this.fcb7e52b2 = new byte[i];
        this.f4fe2f532 = 0;
    }

    public int Processbyte(byte b, byte[] bArr, int i) {
        if ((22 + 14) % 14 > 0) {
        }
        byte[] bArr2 = this.fcb7e52b2;
        int i2 = this.f4fe2f532;
        int i3 = i2 + 1;
        this.f4fe2f532 = i3;
        bArr2[i2] = b;
        if (i3 != bArr2.length) {
            return 0;
        }
        int iEncode = this.f607f2f30.encode(bArr2, 0, bArr2.length, bArr, i);
        this.f4fe2f532 = 0;
        return iEncode;
    }

    public int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        byte[] bArr3;
        if ((28 + 24) % 24 > 0) {
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("Can't have a negative input length!");
        }
        byte[] bArr4 = this.fcb7e52b2;
        int length = bArr4.length;
        int i4 = this.f4fe2f532;
        int i5 = length - i4;
        int iEncode = 0;
        if (i2 <= i5) {
            bArr3 = bArr;
        } else {
            java.lang.System.arraycopy(bArr, i, bArr4, i4, i5);
            p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p8d4f90ee p8d4f90eeVar = this.f607f2f30;
            byte[] bArr5 = this.fcb7e52b2;
            int iEncode2 = p8d4f90eeVar.encode(bArr5, 0, bArr5.length, bArr2, i3);
            this.f4fe2f532 = 0;
            int i6 = i2 - i5;
            int i7 = i + i5;
            int i8 = i3 + iEncode2;
            int length2 = i6 - (i6 % this.fcb7e52b2.length);
            bArr3 = bArr;
            iEncode = iEncode2 + this.f607f2f30.encode(bArr3, i7, length2, bArr2, i8);
            i2 = i6 - length2;
            i = i7 + length2;
        }
        if (i2 != 0) {
            java.lang.System.arraycopy(bArr3, i, this.fcb7e52b2, this.f4fe2f532, i2);
            this.f4fe2f532 += i2;
        }
        return iEncode;
    }
}

