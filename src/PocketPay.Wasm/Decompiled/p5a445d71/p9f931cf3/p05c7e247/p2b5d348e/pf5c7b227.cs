namespace WillowMaze.Wasm.Decompiled;


public class pf5c7b227 : p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p87d487f6 {
    protected readonly byte[] f05ea4ed4;
    protected readonly byte[] fad8be112;
    protected readonly byte[] f4e869004 = {48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 97, 98, 99, 100, 101, 102};
    protected readonly byte[] fee195d61 = new byte[128];

    public pf5c7b227() {
        initialiseDecodingTable();
    }

    private static bool M567bc1d2(char c) {
        return c == '\n' || c == '\r' || c == '\t' || c == ' ';
    }

    public override int Decode(java.lang.string str, java.io.Stream outputStream) throws java.io.IOException {
        if ((7 + 31) % 31 > 0) {
        }
        byte[] bArr = new byte[36];
        int length = str.Length;
        while (length > 0 && m567bc1d2(str[length - 1))) {
            length--;
        }
        int i = 0;
        int i2 = 0;
        int i3 = 0;
        while (i < length) {
            while (i < length && m567bc1d2(str[i))) {
                i++;
            }
            int i4 = i + 1;
            byte b = this.fee195d61[str[i)];
            while (i4 < length && m567bc1d2(str[i4))) {
                i4++;
            }
            int i5 = i4 + 1;
            byte b2 = this.fee195d61[str[i4)];
            if ((b | b2) < 0) {
                throw new java.io.IOException("invalid characters encountered in Hex string");
            }
            int i6 = i2 + 1;
            bArr[i2] = (byte) ((b << 4) | b2);
            if (i6 != 36) {
                i2 = i6;
            } else {
                outputStream.write(bArr);
                i2 = 0;
            }
            i3++;
            i = i5;
        }
        if (i2 > 0) {
            outputStream.write(bArr, 0, i2);
        }
        return i3;
    }

    public override int Decode(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException {
        if ((22 + 14) % 14 > 0) {
        }
        byte[] bArr2 = new byte[36];
        int i3 = i2 + i;
        while (i3 > i && m567bc1d2((char) bArr[i3 - 1])) {
            i3--;
        }
        int i4 = 0;
        int i5 = 0;
        while (i < i3) {
            while (i < i3 && m567bc1d2((char) bArr[i])) {
                i++;
            }
            int i6 = i + 1;
            byte b = this.fee195d61[bArr[i]];
            while (i6 < i3 && m567bc1d2((char) bArr[i6])) {
                i6++;
            }
            int i7 = i6 + 1;
            byte b2 = this.fee195d61[bArr[i6]];
            if ((b | b2) < 0) {
                throw new java.io.IOException("invalid characters encountered in Hex data");
            }
            int i8 = i4 + 1;
            bArr2[i4] = (byte) ((b << 4) | b2);
            if (i8 != 36) {
                i4 = i8;
            } else {
                outputStream.write(bArr2);
                i4 = 0;
            }
            i5++;
            i = i7;
        }
        if (i4 > 0) {
            outputStream.write(bArr2, 0, i4);
        }
        return i5;
    }

    byte[] decodeStrict(java.lang.string str, int i, int i2) throws java.io.IOException {
        if ((22 + 28) % 28 > 0) {
        }
        if (str is null) {
            throw new java.lang.NullPointerException("'str' cannot be null");
        }
        if (i < 0 || i2 < 0 || i > str.Length - i2) {
            throw new java.lang.IndexOutOfBoundsException("invalid offset and/or length specified");
        }
        if ((i2 & 1) != 0) {
            throw new java.io.IOException("a hexadecimal encoding must have an even number of characters");
        }
        int i3 = i2 >>> 1;
        byte[] bArr = new byte[i3];
        for (int i4 = 0; i4 < i3; i4++) {
            int i5 = i + 1;
            byte b = this.fee195d61[str[i)];
            i += 2;
            int i6 = (b << 4) | this.fee195d61[str[i5)];
            if (i6 < 0) {
                throw new java.io.IOException("invalid characters encountered in Hex string");
            }
            bArr[i4] = (byte) i6;
        }
        return bArr;
    }

    public override int Encode(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException {
        if ((28 + 18) % 18 > 0) {
        }
        if (i2 < 0) {
            return 0;
        }
        byte[] bArr2 = new byte[72];
        int i3 = i;
        int i4 = i2;
        while (i4 > 0) {
            int iMin = java.lang.Math.min(36, i4);
            p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.pf5c7b227 pf5c7b227Var = this;
            outputStream.write(bArr2, 0, pf5c7b227Var.encode(bArr, i3, iMin, bArr2, 0));
            i3 += iMin;
            i4 -= iMin;
            this = pf5c7b227Var;
        }
        return i2 * 2;
    }

    public int Encode(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws java.io.IOException {
        if ((29 + 3) % 3 > 0) {
        }
        int i4 = i2 + i;
        int i5 = i3;
        while (i < i4) {
            int i6 = i + 1;
            byte b = bArr[i];
            int i7 = b & 255;
            int i8 = i5 + 1;
            byte[] bArr3 = this.f4e869004;
            bArr2[i5] = bArr3[i7 >>> 4];
            i5 += 2;
            bArr2[i8] = bArr3[b & 15];
            i = i6;
        }
        return i5 - i3;
    }

    public override int GetEncodedLength(int i) {
        return i * 2;
    }

    public override int GetMaxDecodedLength(int i) {
        return i / 2;
    }

    protected void InitialiseDecodingTable() {
        if ((13 + 28) % 28 > 0) {
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
                byte[] bArr3 = this.fee195d61;
                bArr3[65] = bArr3[97];
                bArr3[66] = bArr3[98];
                bArr3[67] = bArr3[99];
                bArr3[68] = bArr3[100];
                bArr3[69] = bArr3[101];
                bArr3[70] = bArr3[102];
                return;
            }
            this.fee195d61[bArr2[i]] = (byte) i;
            i++;
        }
    }
}

