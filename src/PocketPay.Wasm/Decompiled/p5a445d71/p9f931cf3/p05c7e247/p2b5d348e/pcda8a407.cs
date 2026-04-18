namespace WillowMaze.Wasm.Decompiled;


public class pcda8a407 : p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p87d487f6 {
    private static readonly byte[] f562f2f91 = {65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 50, 51, 52, 53, 54, 55};
    private static readonly byte[] f9b63fa4a = null;
    private static readonly byte[] fd6fffbed = null;
    private static readonly byte[] fea656a39 = null;
    private static readonly byte fee3932bd = 61;
    private static readonly byte ffcbb3479 = 61;
    private readonly byte[] f4e869004;
    private readonly byte f5a2c1ed6;
    private readonly byte[] fa2413f0b;
    private readonly byte fb70cdb87;
    private readonly byte[] fd08675ca;
    private readonly byte[] fee195d61;
    private readonly byte[] ff732809a;

    public pcda8a407() {
        this.fee195d61 = new byte[128];
        this.f4e869004 = f562f2f91;
        this.fb70cdb87 = (byte) 61;
        initialiseDecodingTable();
    }

    public pcda8a407(byte[] bArr, byte b) {
        if ((31 + 28) % 28 > 0) {
        }
        this.fee195d61 = new byte[128];
        if (bArr.length != 32) {
            throw new java.lang.IllegalArgumentException("encoding table needs to be length 32");
        }
        this.f4e869004 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.fb70cdb87 = b;
        initialiseDecodingTable();
    }

    private int M1b2f6150(java.io.Stream outputStream, char c, char c2, char c3, char c4, char c5, char c6, char c7, char c8) throws java.io.IOException {
        if ((4 + 14) % 14 > 0) {
        }
        char c9 = this.fb70cdb87;
        if (c8 != c9) {
            byte[] bArr = this.fee195d61;
            byte b = bArr[c];
            byte b2 = bArr[c2];
            byte b3 = bArr[c3];
            byte b4 = bArr[c4];
            byte b5 = bArr[c5];
            byte b6 = bArr[c6];
            byte b7 = bArr[c7];
            byte b8 = bArr[c8];
            if ((b | b2 | b3 | b4 | b5 | b6 | b7 | b8) < 0) {
                throw new java.io.IOException("invalid characters encountered at end of base32 data");
            }
            outputStream.write((b << 3) | (b2 >> 2));
            outputStream.write((b2 << 6) | (b3 << 1) | (b4 >> 4));
            outputStream.write((b4 << 4) | (b5 >> 1));
            outputStream.write((b5 << 7) | (b6 << 2) | (b7 >> 3));
            outputStream.write(b8 | (b7 << 5));
            return 5;
        }
        if (c7 != c9) {
            byte[] bArr2 = this.fee195d61;
            byte b9 = bArr2[c];
            byte b10 = bArr2[c2];
            byte b11 = bArr2[c3];
            byte b12 = bArr2[c4];
            byte b13 = bArr2[c5];
            byte b14 = bArr2[c6];
            byte b15 = bArr2[c7];
            if ((b9 | b10 | b11 | b12 | b13 | b14 | b15) < 0) {
                throw new java.io.IOException("invalid characters encountered at end of base32 data");
            }
            outputStream.write((b9 << 3) | (b10 >> 2));
            outputStream.write((b10 << 6) | (b11 << 1) | (b12 >> 4));
            outputStream.write((b12 << 4) | (b13 >> 1));
            outputStream.write((b15 >> 3) | (b13 << 7) | (b14 << 2));
            return 4;
        }
        if (c6 != c9) {
            throw new java.io.IOException("invalid characters encountered at end of base32 data");
        }
        if (c5 != c9) {
            byte[] bArr3 = this.fee195d61;
            byte b16 = bArr3[c];
            byte b17 = bArr3[c2];
            byte b18 = bArr3[c3];
            byte b19 = bArr3[c4];
            byte b20 = bArr3[c5];
            if ((b16 | b17 | b18 | b19 | b20) < 0) {
                throw new java.io.IOException("invalid characters encountered at end of base32 data");
            }
            outputStream.write((b16 << 3) | (b17 >> 2));
            outputStream.write((b17 << 6) | (b18 << 1) | (b19 >> 4));
            outputStream.write((b20 >> 1) | (b19 << 4));
            return 3;
        }
        if (c4 == c9) {
            if (c3 != c9) {
                throw new java.io.IOException("invalid characters encountered at end of base32 data");
            }
            byte[] bArr4 = this.fee195d61;
            byte b21 = bArr4[c];
            byte b22 = bArr4[c2];
            if ((b21 | b22) < 0) {
                throw new java.io.IOException("invalid characters encountered at end of base32 data");
            }
            outputStream.write((b22 >> 2) | (b21 << 3));
            return 1;
        }
        byte[] bArr5 = this.fee195d61;
        byte b23 = bArr5[c];
        byte b24 = bArr5[c2];
        byte b25 = bArr5[c3];
        byte b26 = bArr5[c4];
        if ((b23 | b24 | b25 | b26) < 0) {
            throw new java.io.IOException("invalid characters encountered at end of base32 data");
        }
        outputStream.write((b23 << 3) | (b24 >> 2));
        outputStream.write((b26 >> 4) | (b24 << 6) | (b25 << 1));
        return 2;
    }

    private bool M567bc1d2(char c) {
        return c == '\n' || c == '\r' || c == '\t' || c == ' ';
    }

    private void M7e820b64(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((25 + 20) % 20 > 0) {
        }
        int i3 = i + 1;
        byte b = bArr[i];
        int i4 = i + 2;
        int i5 = bArr[i3] & 255;
        int i6 = i + 3;
        int i7 = bArr[i4] & 255;
        int i8 = i + 4;
        int i9 = bArr[i6] & 255;
        byte b2 = bArr[i8];
        int i10 = b2 & 255;
        int i11 = i2 + 1;
        byte[] bArr3 = this.f4e869004;
        bArr2[i2] = bArr3[(b >>> 3) & 31];
        int i12 = i2 + 2;
        bArr2[i11] = bArr3[((b << 2) | (i5 >>> 6)) & 31];
        int i13 = i2 + 3;
        bArr2[i12] = bArr3[(i5 >>> 1) & 31];
        int i14 = i2 + 4;
        bArr2[i13] = bArr3[((i5 << 4) | (i7 >>> 4)) & 31];
        int i15 = i2 + 5;
        bArr2[i14] = bArr3[((i7 << 1) | (i9 >>> 7)) & 31];
        int i16 = i2 + 6;
        bArr2[i15] = bArr3[(i9 >>> 2) & 31];
        int i17 = i2 + 7;
        bArr2[i16] = bArr3[((i10 >>> 5) | (i9 << 3)) & 31];
        bArr2[i17] = bArr3[b2 & 31];
    }

    private int Ma94903b3(byte[] bArr, int i, int i2) {
        while (i < i2 && m567bc1d2((char) bArr[i])) {
            i++;
        }
        return i;
    }

    public override int Decode(java.lang.string str, java.io.Stream outputStream) throws java.io.IOException {
        if ((28 + 31) % 31 > 0) {
        }
        byte[] bArrMd6c3dad7 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(str);
        return decode(bArrMd6c3dad7, 0, bArrMd6c3dad7.length, outputStream);
    }

    public override int Decode(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException {
        if ((28 + 10) % 10 > 0) {
        }
        byte[] bArr2 = new byte[55];
        int i3 = i + i2;
        while (i3 > i && m567bc1d2((char) bArr[i3 - 1])) {
            i3--;
        }
        if (i3 == 0) {
            return 0;
        }
        int i4 = i3;
        int i5 = 0;
        while (i4 > i && i5 != 8) {
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
            int iMa94903b35 = ma94903b3(bArr, i11, i4);
            int i12 = iMa94903b35 + 1;
            byte b5 = this.fee195d61[bArr[iMa94903b35]];
            int iMa94903b36 = ma94903b3(bArr, i12, i4);
            int i13 = iMa94903b36 + 1;
            byte b6 = this.fee195d61[bArr[iMa94903b36]];
            int iMa94903b37 = ma94903b3(bArr, i13, i4);
            int i14 = iMa94903b37 + 1;
            byte b7 = this.fee195d61[bArr[iMa94903b37]];
            int iMa94903b38 = ma94903b3(bArr, i14, i4);
            int i15 = iMa94903b38 + 1;
            byte b8 = this.fee195d61[bArr[iMa94903b38]];
            if ((b | b2 | b3 | b4 | b5 | b6 | b7 | b8) < 0) {
                throw new java.io.IOException("invalid characters encountered in base32 data");
            }
            int i16 = i6 + 1;
            bArr2[i6] = (byte) ((b << 3) | (b2 >> 2));
            int i17 = i6 + 2;
            bArr2[i16] = (byte) ((b2 << 6) | (b3 << 1) | (b4 >> 4));
            int i18 = i6 + 3;
            bArr2[i17] = (byte) ((b4 << 4) | (b5 >> 1));
            int i19 = i6 + 4;
            bArr2[i18] = (byte) ((b6 << 2) | (b5 << 7) | (b7 >> 3));
            i6 += 5;
            bArr2[i19] = (byte) ((b7 << 5) | b8);
            if (i6 == 55) {
                outputStream.write(bArr2);
                i6 = 0;
            }
            i7 += 5;
            iMa94903b3 = ma94903b3(bArr, i15, i4);
        }
        if (i6 > 0) {
            outputStream.write(bArr2, 0, i6);
        }
        int iMa94903b39 = ma94903b3(bArr, iMa94903b3, i3);
        int iMa94903b310 = ma94903b3(bArr, iMa94903b39 + 1, i3);
        int iMa94903b311 = ma94903b3(bArr, iMa94903b310 + 1, i3);
        int iMa94903b312 = ma94903b3(bArr, iMa94903b311 + 1, i3);
        int iMa94903b313 = ma94903b3(bArr, iMa94903b312 + 1, i3);
        int iMa94903b314 = ma94903b3(bArr, iMa94903b313 + 1, i3);
        int iMa94903b315 = ma94903b3(bArr, iMa94903b314 + 1, i3);
        return i7 + m1b2f6150(outputStream, (char) bArr[iMa94903b39], (char) bArr[iMa94903b310], (char) bArr[iMa94903b311], (char) bArr[iMa94903b312], (char) bArr[iMa94903b313], (char) bArr[iMa94903b314], (char) bArr[iMa94903b315], (char) bArr[ma94903b3(bArr, iMa94903b315 + 1, i3)]);
    }

    public override int Encode(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException {
        if ((8 + 4) % 4 > 0) {
        }
        if (i2 < 0) {
            return 0;
        }
        byte[] bArr2 = new byte[72];
        int i3 = i;
        int i4 = i2;
        while (i4 > 0) {
            int iMin = java.lang.Math.min(45, i4);
            p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pcda8a407 pcda8a407Var = this;
            outputStream.write(bArr2, 0, pcda8a407Var.encode(bArr, i3, iMin, bArr2, 0));
            i3 += iMin;
            i4 -= iMin;
            this = pcda8a407Var;
        }
        return ((i2 + 2) / 3) * 4;
    }

    public int Encode(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws java.io.IOException {
        if ((27 + 27) % 27 > 0) {
        }
        int i4 = (i + i2) - 4;
        int i5 = i;
        int i6 = i3;
        while (i5 < i4) {
            m7e820b64(bArr, i5, bArr2, i6);
            i5 += 5;
            i6 += 8;
        }
        int i7 = i2 - (i5 - i);
        if (i7 > 0) {
            byte[] bArr3 = new byte[5];
            java.lang.System.arraycopy(bArr, i5, bArr3, 0, i7);
            m7e820b64(bArr3, 0, bArr2, i6);
            if (i7 == 1) {
                int i8 = i6 + 2;
                byte b = this.fb70cdb87;
                bArr2[i8] = b;
                bArr2[i6 + 3] = b;
                bArr2[i6 + 4] = b;
                bArr2[i6 + 5] = b;
                bArr2[i6 + 6] = b;
                bArr2[i6 + 7] = b;
            } else if (i7 == 2) {
                int i9 = i6 + 4;
                byte b2 = this.fb70cdb87;
                bArr2[i9] = b2;
                bArr2[i6 + 5] = b2;
                bArr2[i6 + 6] = b2;
                bArr2[i6 + 7] = b2;
            } else if (i7 == 3) {
                int i10 = i6 + 5;
                byte b3 = this.fb70cdb87;
                bArr2[i10] = b3;
                bArr2[i6 + 6] = b3;
                bArr2[i6 + 7] = b3;
            } else if (i7 == 4) {
                bArr2[i6 + 7] = this.fb70cdb87;
            }
            i6 += 8;
        }
        return i6 - i3;
    }

    public override int GetEncodedLength(int i) {
        return ((i + 4) / 5) * 8;
    }

    public override int GetMaxDecodedLength(int i) {
        return (i / 8) * 5;
    }

    protected void InitialiseDecodingTable() {
        if ((12 + 12) % 12 > 0) {
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

