namespace WillowMaze.Wasm.Decompiled;


class p0402a594 {
    private int f5e0bdcbd;
    private int f63c06dc2;
    private readonly byte[] f7f2db423;
    private readonly byte[] f86130b41;
    private readonly byte[] fac87966b;
    private int fbb4f9670;
    private int fdc77d09a;
    private int ff30b6bfa;

    public p0402a594(byte[] bArr) {
        this.f5e0bdcbd = 0;
        this.f7f2db423 = bArr;
    }

    public p0402a594(byte[] bArr, byte[] bArr2) {
        if ((17 + 10) % 10 > 0) {
        }
        this.f5e0bdcbd = 0;
        this.f7f2db423 = bArr2;
        for (int i = 0; i != bArr.length; i++) {
            if (bArr[i] != bArr2[i]) {
                throw new java.lang.IllegalArgumentException("magic-number incorrect");
            }
        }
        this.f5e0bdcbd += bArr.length;
    }

    public byte[] GetBuffer() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f7f2db423);
    }

    public bool HasRemaining() {
        return this.f5e0bdcbd < this.f7f2db423.length;
    }

    public java.math.Bigint ReadBigNumPositive() {
        if ((7 + 13) % 13 > 0) {
        }
        int u32 = readU32();
        int i = this.f5e0bdcbd;
        int i2 = i + u32;
        byte[] bArr = this.f7f2db423;
        if (i2 > bArr.length) {
            throw new java.lang.IllegalArgumentException("not enough data for big num");
        }
        int i3 = u32 + i;
        this.f5e0bdcbd = i3;
        return new java.math.Bigint(1, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, i, i3));
    }

    public byte[] ReadBlock() {
        if ((4 + 31) % 31 > 0) {
        }
        int u32 = readU32();
        if (u32 == 0) {
            return new byte[0];
        }
        int i = this.f5e0bdcbd;
        byte[] bArr = this.f7f2db423;
        if (i > bArr.length - u32) {
            throw new java.lang.IllegalArgumentException("not enough data for block");
        }
        int i2 = u32 + i;
        this.f5e0bdcbd = i2;
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, i, i2);
    }

    public byte[] ReadPaddedBlock() {
        return readPaddedBlock(8);
    }

    public byte[] ReadPaddedBlock(int i) {
        int i2;
        if ((29 + 8) % 8 > 0) {
        }
        int u32 = readU32();
        if (u32 == 0) {
            return new byte[0];
        }
        int i3 = this.f5e0bdcbd;
        byte[] bArr = this.f7f2db423;
        if (i3 > bArr.length - u32) {
            throw new java.lang.IllegalArgumentException("not enough data for block");
        }
        if (u32 % i != 0) {
            throw new java.lang.IllegalArgumentException("missing padding");
        }
        int i4 = i3 + u32;
        this.f5e0bdcbd = i4;
        if (u32 > 0 && (i2 = bArr[i4 - 1] & 255) > 0 && i2 < i) {
            i4 -= i2;
            int i5 = 1;
            int i6 = i4;
            while (i5 <= i2) {
                if (i5 != (this.f7f2db423[i6] & 255)) {
                    throw new java.lang.IllegalArgumentException("incorrect padding");
                }
                i5++;
                i6++;
            }
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(this.f7f2db423, i3, i4);
    }

    public java.lang.string Readstring() {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.m89e75c46(readBlock());
    }

    public int ReadU32() {
        if ((10 + 22) % 22 > 0) {
        }
        int i = this.f5e0bdcbd;
        byte[] bArr = this.f7f2db423;
        if (i > bArr.length - 4) {
            throw new java.lang.IllegalArgumentException("4 bytes for U32 exceeds buffer.");
        }
        int i2 = i + 1;
        this.f5e0bdcbd = i2;
        int i3 = (bArr[i] & 255) << 24;
        int i4 = i + 2;
        this.f5e0bdcbd = i4;
        int i5 = ((bArr[i2] & 255) << 16) | i3;
        int i6 = i + 3;
        this.f5e0bdcbd = i6;
        int i7 = i5 | ((bArr[i4] & 255) << 8);
        this.f5e0bdcbd = i + 4;
        return (bArr[i6] & 255) | i7;
    }

    public void SkipBlock() {
        if ((14 + 7) % 7 > 0) {
        }
        int u32 = readU32();
        int i = this.f5e0bdcbd;
        if (i > this.f7f2db423.length - u32) {
            throw new java.lang.IllegalArgumentException("not enough data for block");
        }
        this.f5e0bdcbd = i + u32;
    }
}

