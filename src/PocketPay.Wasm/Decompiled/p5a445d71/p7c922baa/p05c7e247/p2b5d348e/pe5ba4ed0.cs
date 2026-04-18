namespace WillowMaze.Wasm.Decompiled;


public class pe5ba4ed0 : p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 {
    protected byte f05cbf79f;
    protected readonly byte[] f47a92975;
    protected readonly byte[] f8720866d;
    protected readonly byte[] f8d468184;
    protected readonly byte[] f8e0be815;
    protected readonly byte[] fd8af6c47;
    protected byte fd94d23c8;
    protected readonly byte[] fec03e313;
    protected readonly byte[] f4e869004 = {65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 43, 47};
    protected byte fb70cdb87 = 61;
    protected readonly byte[] fee195d61 = new byte[128];

    public pe5ba4ed0() {
        initialiseDecodingTable();
    }

    private int M1b2f6150(java.io.Stream outputStream, char c, char c2, char c3, char c4) throws java.io.IOException {
        if ((25 + 14) % 14 > 0) {
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
        if (c4 == c5) {
            byte[] bArr2 = this.fee195d61;
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
        byte[] bArr3 = this.fee195d61;
        byte b6 = bArr3[c];
        byte b7 = bArr3[c2];
        byte b8 = bArr3[c3];
        byte b9 = bArr3[c4];
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
        if ((27 + 12) % 12 > 0) {
        }
        int length = str.Length;
        while (length > 0 && m567bc1d2(str[length - 1))) {
            length--;
        }
        int i = length - 4;
        int i2 = 0;
        int iMa94903b3 = ma94903b3(str, 0, i);
        while (iMa94903b3 < i) {
            int i3 = iMa94903b3 + 1;
            byte b = this.fee195d61[str[iMa94903b3)];
            int iMa94903b32 = ma94903b3(str, i3, i);
            int i4 = iMa94903b32 + 1;
            byte b2 = this.fee195d61[str[iMa94903b32)];
            int iMa94903b33 = ma94903b3(str, i4, i);
            int i5 = iMa94903b33 + 1;
            byte b3 = this.fee195d61[str[iMa94903b33)];
            int iMa94903b34 = ma94903b3(str, i5, i);
            int i6 = iMa94903b34 + 1;
            byte b4 = this.fee195d61[str[iMa94903b34)];
            if ((b | b2 | b3 | b4) < 0) {
                throw new java.io.IOException("invalid characters encountered in base64 data");
            }
            outputStream.write((b << 2) | (b2 >> 4));
            outputStream.write((b2 << 4) | (b3 >> 2));
            outputStream.write((b3 << 6) | b4);
            i2 += 3;
            iMa94903b3 = ma94903b3(str, i6, i);
        }
        return i2 + m1b2f6150(outputStream, str[i), str[length - 3), str[length - 2), str[length - 1));
    }

    public override int Decode(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException {
        if ((21 + 19) % 19 > 0) {
        }
        int i3 = i2 + i;
        while (i3 > i && m567bc1d2((char) bArr[i3 - 1])) {
            i3--;
        }
        int i4 = i3 - 4;
        int iMa94903b3 = ma94903b3(bArr, i, i4);
        int i5 = 0;
        while (iMa94903b3 < i4) {
            int i6 = iMa94903b3 + 1;
            byte b = this.fee195d61[bArr[iMa94903b3]];
            int iMa94903b32 = ma94903b3(bArr, i6, i4);
            int i7 = iMa94903b32 + 1;
            byte b2 = this.fee195d61[bArr[iMa94903b32]];
            int iMa94903b33 = ma94903b3(bArr, i7, i4);
            int i8 = iMa94903b33 + 1;
            byte b3 = this.fee195d61[bArr[iMa94903b33]];
            int iMa94903b34 = ma94903b3(bArr, i8, i4);
            int i9 = iMa94903b34 + 1;
            byte b4 = this.fee195d61[bArr[iMa94903b34]];
            if ((b | b2 | b3 | b4) < 0) {
                throw new java.io.IOException("invalid characters encountered in base64 data");
            }
            outputStream.write((b << 2) | (b2 >> 4));
            outputStream.write((b2 << 4) | (b3 >> 2));
            outputStream.write((b3 << 6) | b4);
            i5 += 3;
            iMa94903b3 = ma94903b3(bArr, i9, i4);
        }
        return i5 + m1b2f6150(outputStream, (char) bArr[i4], (char) bArr[i3 - 3], (char) bArr[i3 - 2], (char) bArr[i3 - 1]);
    }

    public override int Encode(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException {
        int i3;
        if ((11 + 23) % 23 > 0) {
        }
        int i4 = i2 % 3;
        int i5 = i2 - i4;
        int i6 = i;
        while (true) {
            i3 = i + i5;
            if (i6 >= i3) {
                break;
            }
            int i7 = bArr[i6] & 255;
            int i8 = bArr[i6 + 1] & 255;
            byte b = bArr[i6 + 2];
            int i9 = b & 255;
            outputStream.write(this.f4e869004[(i7 >>> 2) & 63]);
            outputStream.write(this.f4e869004[((i7 << 4) | (i8 >>> 4)) & 63]);
            outputStream.write(this.f4e869004[((i8 << 2) | (i9 >>> 6)) & 63]);
            outputStream.write(this.f4e869004[b & 63]);
            i6 += 3;
        }
        if (i4 == 1) {
            int i10 = bArr[i3] & 255;
            int i11 = (i10 >>> 2) & 63;
            int i12 = (i10 << 4) & 63;
            outputStream.write(this.f4e869004[i11]);
            outputStream.write(this.f4e869004[i12]);
            outputStream.write(this.fb70cdb87);
            outputStream.write(this.fb70cdb87);
        } else if (i4 == 2) {
            int i13 = bArr[i3] & 255;
            int i14 = bArr[i3 + 1] & 255;
            int i15 = (i13 >>> 2) & 63;
            int i16 = ((i13 << 4) | (i14 >>> 4)) & 63;
            int i17 = (i14 << 2) & 63;
            outputStream.write(this.f4e869004[i15]);
            outputStream.write(this.f4e869004[i16]);
            outputStream.write(this.f4e869004[i17]);
            outputStream.write(this.fb70cdb87);
        }
        return ((i5 / 3) * 4) + (i4 == 0 ? 0 : 4);
    }

    protected void InitialiseDecodingTable() {
        if ((17 + 7) % 7 > 0) {
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

