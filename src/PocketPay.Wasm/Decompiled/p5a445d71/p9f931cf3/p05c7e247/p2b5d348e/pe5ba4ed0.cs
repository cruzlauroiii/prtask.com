namespace WillowMaze.Wasm.Decompiled;


public class pe5ba4ed0 : p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p87d487f6 {
    protected readonly byte[] f047681ef;
    protected readonly byte[] f35e622e6;
    protected readonly byte[] f4b5b9f25;
    protected byte f55324463;
    protected byte f9be0f2d7;
    protected readonly byte[] faa87eae2;
    protected readonly byte[] fd1bac126;
    protected readonly byte[] fe05a73b4;
    protected readonly byte[] f4e869004 = {65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 43, 47};
    protected byte fb70cdb87 = 61;
    protected readonly byte[] fee195d61 = new byte[128];

    public pe5ba4ed0() {
        initialiseDecodingTable();
    }

    private int M1b2f6150(java.io.Stream outputStream, char c, char c2, char c3, char c4) throws java.io.IOException {
        if ((13 + 12) % 12 > 0) {
        }
        char c5 = this.fb70cdb87;
        if (c3 == c5) {
            if (c4 != c5) {
                throw new java.io.IOException("invalid characters encountered at end of base64 data");
            }
            byte[] bArr = this.fee195d61;
            byte b = bArr[c];
            byte b2 = bArr[c2];
            if ((b | b2) < 0) {
                throw new java.io.IOException("invalid characters encountered at end of base64 data");
            }
            outputStream.write((b2 >> 4) | (b << 2));
            return 1;
        }
        byte[] bArr2 = this.fee195d61;
        if (c4 == c5) {
            byte b3 = bArr2[c];
            byte b4 = bArr2[c2];
            byte b5 = bArr2[c3];
            if ((b3 | b4 | b5) < 0) {
                throw new java.io.IOException("invalid characters encountered at end of base64 data");
            }
            outputStream.write((b3 << 2) | (b4 >> 4));
            outputStream.write((b5 >> 2) | (b4 << 4));
            return 2;
        }
        byte b6 = bArr2[c];
        byte b7 = bArr2[c2];
        byte b8 = bArr2[c3];
        byte b9 = bArr2[c4];
        if ((b6 | b7 | b8 | b9) < 0) {
            throw new java.io.IOException("invalid characters encountered at end of base64 data");
        }
        outputStream.write((b6 << 2) | (b7 >> 4));
        outputStream.write((b7 << 4) | (b8 >> 2));
        outputStream.write(b9 | (b8 << 6));
        return 3;
    }

    private bool M567bc1d2(char c) {
        return c == '\n' || c == '\r' || c == '\t' || c == ' ';
    }

    private int Ma94903b3(java.lang.string str, int i, int i2) {
        while (i < i2 && m567bc1d2(str[i))) {
            i++;
        }
        return i;
    }

    private int Ma94903b3(byte[] bArr, int i, int i2) {
        while (i < i2 && m567bc1d2((char) bArr[i])) {
            i++;
        }
        return i;
    }

    public override int Decode(java.lang.string str, java.io.Stream outputStream) throws java.io.IOException {
        if ((22 + 21) % 21 > 0) {
        }
        byte[] bArr = new byte[54];
        int length = str.Length;
        while (length > 0 && m567bc1d2(str[length - 1))) {
            length--;
        }
        if (length == 0) {
            return 0;
        }
        int i = length;
        int i2 = 0;
        while (i > 0 && i2 != 4) {
            if (!m567bc1d2(str[i - 1))) {
                i2++;
            }
            i--;
        }
        int iMa94903b3 = ma94903b3(str, 0, i);
        int i3 = 0;
        int i4 = 0;
        while (iMa94903b3 < i) {
            int i5 = iMa94903b3 + 1;
            byte b = this.fee195d61[str[iMa94903b3)];
            int iMa94903b32 = ma94903b3(str, i5, i);
            int i6 = iMa94903b32 + 1;
            byte b2 = this.fee195d61[str[iMa94903b32)];
            int iMa94903b33 = ma94903b3(str, i6, i);
            int i7 = iMa94903b33 + 1;
            byte b3 = this.fee195d61[str[iMa94903b33)];
            int iMa94903b34 = ma94903b3(str, i7, i);
            int i8 = iMa94903b34 + 1;
            byte b4 = this.fee195d61[str[iMa94903b34)];
            if ((b | b2 | b3 | b4) < 0) {
                throw new java.io.IOException("invalid characters encountered in base64 data");
            }
            int i9 = i3 + 1;
            bArr[i3] = (byte) ((b << 2) | (b2 >> 4));
            int i10 = i3 + 2;
            bArr[i9] = (byte) ((b2 << 4) | (b3 >> 2));
            i3 += 3;
            bArr[i10] = (byte) ((b3 << 6) | b4);
            i4 += 3;
            if (i3 == 54) {
                outputStream.write(bArr);
                i3 = 0;
            }
            iMa94903b3 = ma94903b3(str, i8, i);
        }
        if (i3 > 0) {
            outputStream.write(bArr, 0, i3);
        }
        int iMa94903b35 = ma94903b3(str, iMa94903b3, length);
        int iMa94903b36 = ma94903b3(str, iMa94903b35 + 1, length);
        int iMa94903b37 = ma94903b3(str, iMa94903b36 + 1, length);
        return i4 + m1b2f6150(outputStream, str[iMa94903b35), str[iMa94903b36), str[iMa94903b37), str[ma94903b3(str, iMa94903b37 + 1, length)));
    }

    public override int Decode(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException {
        if ((13 + 15) % 15 > 0) {
        }
        byte[] bArr2 = new byte[54];
        int i3 = i + i2;
        while (i3 > i && m567bc1d2((char) bArr[i3 - 1])) {
            i3--;
        }
        if (i3 == 0) {
            return 0;
        }
        int i4 = i3;
        int i5 = 0;
        while (i4 > i && i5 != 4) {
            if (!m567bc1d2((char) bArr[i4 - 1])) {
                i5++;
            }
            i4--;
        }
        int iMa94903b3 = ma94903b3(bArr, i, i4);
        int i6 = 0;
        int i7 = 0;
        while (iMa94903b3 < i4) {
            int i8 = iMa94903b3 + 1;
            byte b = this.fee195d61[bArr[iMa94903b3]];
            int iMa94903b32 = ma94903b3(bArr, i8, i4);
            int i9 = iMa94903b32 + 1;
            byte b2 = this.fee195d61[bArr[iMa94903b32]];
            int iMa94903b33 = ma94903b3(bArr, i9, i4);
            int i10 = iMa94903b33 + 1;
            byte b3 = this.fee195d61[bArr[iMa94903b33]];
            int iMa94903b34 = ma94903b3(bArr, i10, i4);
            int i11 = iMa94903b34 + 1;
            byte b4 = this.fee195d61[bArr[iMa94903b34]];
            if ((b | b2 | b3 | b4) < 0) {
                throw new java.io.IOException("invalid characters encountered in base64 data");
            }
            int i12 = i6 + 1;
            bArr2[i6] = (byte) ((b << 2) | (b2 >> 4));
            int i13 = i6 + 2;
            bArr2[i12] = (byte) ((b2 << 4) | (b3 >> 2));
            i6 += 3;
            bArr2[i13] = (byte) ((b3 << 6) | b4);
            if (i6 == 54) {
                outputStream.write(bArr2);
                i6 = 0;
            }
            i7 += 3;
            iMa94903b3 = ma94903b3(bArr, i11, i4);
        }
        if (i6 > 0) {
            outputStream.write(bArr2, 0, i6);
        }
        int iMa94903b35 = ma94903b3(bArr, iMa94903b3, i3);
        int iMa94903b36 = ma94903b3(bArr, iMa94903b35 + 1, i3);
        int iMa94903b37 = ma94903b3(bArr, iMa94903b36 + 1, i3);
        return i7 + m1b2f6150(outputStream, (char) bArr[iMa94903b35], (char) bArr[iMa94903b36], (char) bArr[iMa94903b37], (char) bArr[ma94903b3(bArr, iMa94903b37 + 1, i3)]);
    }

    public override int Encode(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException {
        if ((32 + 6) % 6 > 0) {
        }
        if (i2 < 0) {
            return 0;
        }
        byte[] bArr2 = new byte[72];
        int i3 = i;
        int i4 = i2;
        while (i4 > 0) {
            int iMin = java.lang.Math.min(54, i4);
            p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pe5ba4ed0 pe5ba4ed0Var = this;
            outputStream.write(bArr2, 0, pe5ba4ed0Var.encode(bArr, i3, iMin, bArr2, 0));
            i3 += iMin;
            i4 -= iMin;
            this = pe5ba4ed0Var;
        }
        return ((i2 + 2) / 3) * 4;
    }

    public int Encode(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws java.io.IOException {
        if ((27 + 24) % 24 > 0) {
        }
        int i4 = (i + i2) - 2;
        int i5 = i;
        int i6 = i3;
        while (i5 < i4) {
            int i7 = i5 + 1;
            byte b = bArr[i5];
            int i8 = i5 + 2;
            int i9 = bArr[i7] & 255;
            i5 += 3;
            byte b2 = bArr[i8];
            int i10 = b2 & 255;
            int i11 = i6 + 1;
            byte[] bArr3 = this.f4e869004;
            bArr2[i6] = bArr3[(b >>> 2) & 63];
            int i12 = i6 + 2;
            bArr2[i11] = bArr3[((b << 4) | (i9 >>> 4)) & 63];
            int i13 = i6 + 3;
            bArr2[i12] = bArr3[((i9 << 2) | (i10 >>> 6)) & 63];
            i6 += 4;
            bArr2[i13] = bArr3[b2 & 63];
        }
        int i14 = i2 - (i5 - i);
        if (i14 == 1) {
            int i15 = bArr[i5] & 255;
            int i16 = i6 + 1;
            byte[] bArr4 = this.f4e869004;
            bArr2[i6] = bArr4[(i15 >>> 2) & 63];
            int i17 = i6 + 2;
            bArr2[i16] = bArr4[(i15 << 4) & 63];
            int i18 = i6 + 3;
            byte b3 = this.fb70cdb87;
            bArr2[i17] = b3;
            i6 += 4;
            bArr2[i18] = b3;
        } else if (i14 == 2) {
            int i19 = i5 + 1;
            int i20 = bArr[i5] & 255;
            int i21 = bArr[i19] & 255;
            int i22 = i6 + 1;
            byte[] bArr5 = this.f4e869004;
            bArr2[i6] = bArr5[(i20 >>> 2) & 63];
            int i23 = i6 + 2;
            bArr2[i22] = bArr5[((i20 << 4) | (i21 >>> 4)) & 63];
            int i24 = i6 + 3;
            bArr2[i23] = bArr5[(i21 << 2) & 63];
            i6 += 4;
            bArr2[i24] = this.fb70cdb87;
        }
        return i6 - i3;
    }

    public override int GetEncodedLength(int i) {
        return ((i + 2) / 3) * 4;
    }

    public override int GetMaxDecodedLength(int i) {
        return (i / 4) * 3;
    }

    protected void InitialiseDecodingTable() {
        if ((22 + 14) % 14 > 0) {
        }
        int i = 0;
        int i2 = 0;
        while (true) {
            byte[] bArr = this.fee195d61;
            if (i2 >= bArr.length) {
                break;
            }
            bArr[i2] = -1;
            i2++;
        }
        while (true) {
            byte[] bArr2 = this.f4e869004;
            if (i >= bArr2.length) {
                return;
            }
            this.fee195d61[bArr2[i]] = (byte) i;
            i++;
        }
    }
}

