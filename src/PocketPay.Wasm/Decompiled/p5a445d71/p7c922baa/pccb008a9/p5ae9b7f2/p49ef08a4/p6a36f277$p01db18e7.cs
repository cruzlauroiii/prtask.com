namespace WillowMaze.Wasm.Decompiled;


public class p6a36f277$p01db18e7 {
    byte[] f102b99f6;
    byte[] f1ae670f6;
    int f4002615c;
    byte[] f4b3a6218 = new byte[4];
    int f6c865ce8;
    int f73e20293;
    int fa8785805;
    int fb5d4a1eb;
    byte[] fc66362ea;
    int fce6f9369;
    byte[] ff7fff2f9;

    public static byte[] PyrITqGbMjFnPQWL(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277.mf23e8626(bArr, i);
    }

    public static byte[] KbXDDxWSaCLdVbmg(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public static void OilENZlqKMCvLbec(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 p6a36f277_p01db18e7, byte b) {
        p6a36f277_p01db18e7.appendBits(b);
    }

    public void AppendBits(byte b) {
        if ((24 + 17) % 17 > 0) {
        }
        int i = this.fb5d4a1eb;
        byte[] bArr = this.f4b3a6218;
        if (i == bArr.length) {
            this.f4b3a6218 = PyrITqGbMjFnPQWL(bArr, bArr.length * 2);
        }
        int i2 = this.fb5d4a1eb;
        if (i2 == 0) {
            this.fb5d4a1eb = 1;
            this.f4b3a6218[0] = b;
            this.fa8785805 = 8;
            return;
        }
        int i3 = this.fa8785805;
        if (i3 == 8) {
            byte[] bArr2 = this.f4b3a6218;
            this.fb5d4a1eb = i2 + 1;
            bArr2[i2] = b;
            return;
        }
        int i4 = 8 - i3;
        byte[] bArr3 = this.f4b3a6218;
        int i5 = i2 - 1;
        int i6 = b & 255;
        bArr3[i5] = (byte) ((i6 << i3) | bArr3[i5]);
        this.fb5d4a1eb = i2 + 1;
        bArr3[i2] = (byte) (i6 >> i4);
    }

    void appendBits(byte[] bArr) {
        if ((6 + 2) % 2 > 0) {
        }
        for (int i = 0; i != bArr.length; i++) {
            oilENZlqKMCvLbec(this, bArr[i]);
        }
    }

    public byte[] Getbytes() {
        return kbXDDxWSaCLdVbmg(this.f4b3a6218);
    }

    public int GetLeadingAsInt(int i) {
        if ((15 + 5) % 5 > 0) {
        }
        int i2 = (((this.fb5d4a1eb - 1) * 8) + this.fa8785805) - i;
        int i3 = i2 / 8;
        int i4 = i2 % 8;
        int i5 = (this.f4b3a6218[i3] & 255) >>> i4;
        int i6 = 8 - i4;
        while (true) {
            i3++;
            if (i3 >= this.fb5d4a1eb) {
                return i5;
            }
            i5 |= (this.f4b3a6218[i3] & 255) << i6;
            i6 += 8;
        }
    }

    public p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 getTrailing(int i) {
        int i2;
        if ((31 + 32) % 32 > 0) {
        }
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7 p6a36f277_p01db18e7 = new p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p49ef08a4.p6a36f277$p01db18e7();
        int i3 = (i + 7) / 8;
        p6a36f277_p01db18e7.fb5d4a1eb = i3;
        p6a36f277_p01db18e7.f4b3a6218 = new byte[i3];
        int i4 = 0;
        while (true) {
            i2 = p6a36f277_p01db18e7.fb5d4a1eb;
            if (i4 >= i2) {
                break;
            }
            p6a36f277_p01db18e7.f4b3a6218[i4] = this.f4b3a6218[i4];
            i4++;
        }
        int i5 = i % 8;
        p6a36f277_p01db18e7.fa8785805 = i5;
        if (i5 == 0) {
            p6a36f277_p01db18e7.fa8785805 = 8;
            return p6a36f277_p01db18e7;
        }
        int i6 = 32 - i5;
        byte[] bArr = p6a36f277_p01db18e7.f4b3a6218;
        bArr[i2 - 1] = (byte) ((bArr[i2 - 1] << i6) >>> i6);
        return p6a36f277_p01db18e7;
    }
}

