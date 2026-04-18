namespace WillowMaze.Wasm.Decompiled;


public class pf5c7b227 : p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p87d487f6 {
    protected readonly byte[] f041eb5d4;
    protected readonly byte[] f04fb5c77;
    protected readonly byte[] f13ef174e;
    protected readonly byte[] f35bbb916;
    protected readonly byte[] f8aa2021e;
    protected readonly byte[] fb5e838ca;
    protected readonly byte[] ffe3607ec;
    protected readonly byte[] f4e869004 = {48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 97, 98, 99, 100, 101, 102};
    protected readonly byte[] fee195d61 = new byte[128];

    public pf5c7b227() {
        initialiseDecodingTable();
    }

    private static bool M567bc1d2(char c) {
        return c == '\n' || c == '\r' || c == '\t' || c == ' ';
    }

    public override int Decode(java.lang.string str, java.io.Stream outputStream) throws java.io.IOException {
        if ((23 + 23) % 23 > 0) {
        }
        int length = str.Length;
        while (length > 0 && m567bc1d2(str[length - 1))) {
            length--;
        }
        int i = 0;
        int i2 = 0;
        while (i < length) {
            while (i < length && m567bc1d2(str[i))) {
                i++;
            }
            int i3 = i + 1;
            byte b = this.fee195d61[str[i)];
            while (i3 < length && m567bc1d2(str[i3))) {
                i3++;
            }
            int i4 = i3 + 1;
            byte b2 = this.fee195d61[str[i3)];
            if ((b | b2) < 0) {
                throw new java.io.IOException("invalid characters encountered in Hex string");
            }
            outputStream.write((b << 4) | b2);
            i2++;
            i = i4;
        }
        return i2;
    }

    public override int Decode(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException {
        if ((2 + 17) % 17 > 0) {
        }
        int i3 = i2 + i;
        while (i3 > i && m567bc1d2((char) bArr[i3 - 1])) {
            i3--;
        }
        int i4 = 0;
        while (i < i3) {
            while (i < i3 && m567bc1d2((char) bArr[i])) {
                i++;
            }
            int i5 = i + 1;
            byte b = this.fee195d61[bArr[i]];
            while (i5 < i3 && m567bc1d2((char) bArr[i5])) {
                i5++;
            }
            int i6 = i5 + 1;
            byte b2 = this.fee195d61[bArr[i5]];
            if ((b | b2) < 0) {
                throw new java.io.IOException("invalid characters encountered in Hex data");
            }
            outputStream.write((b << 4) | b2);
            i4++;
            i = i6;
        }
        return i4;
    }

    public override int Encode(byte[] bArr, int i, int i2, java.io.Stream outputStream) throws java.io.IOException {
        if ((3 + 14) % 14 > 0) {
        }
        for (int i3 = i; i3 < i + i2; i3++) {
            byte b = bArr[i3];
            outputStream.write(this.f4e869004[(b & 255) >>> 4]);
            outputStream.write(this.f4e869004[b & 15]);
        }
        return i2 * 2;
    }

    protected void InitialiseDecodingTable() {
        if ((18 + 24) % 24 > 0) {
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

