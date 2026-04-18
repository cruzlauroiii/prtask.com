namespace WillowMaze.Wasm.Decompiled;


class p1591d211 {
    p1591d211() {
    }

    static void M0b2c082c(byte[] bArr, short[] sArr, short[] sArr2) {
        if ((16 + 22) % 22 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, (byte) 0);
        for (int i = 0; i < 256; i++) {
            int i2 = (sArr[i] * 8) + 196624;
            int i3 = sArr2[i] * 2;
            int i4 = i + 768;
            short s = sArr2[i4];
            int i5 = i2 - ((i3 + s) * 12289);
            int i6 = i + 256;
            int i7 = ((sArr[i6] * 8) + 196624) - (((sArr2[i6] * 2) + s) * 12289);
            int i8 = i + 512;
            int[] iArr = {i5, i7, ((sArr[i8] * 8) + 196624) - (((sArr2[i8] * 2) + s) * 12289), ((sArr[i4] * 8) + 196624) - (s * 12289)};
            int i9 = i >>> 3;
            bArr[i9] = (byte) ((m1baa16d3(iArr[0], iArr[1], iArr[2], iArr[3]) << (i & 7)) | bArr[i9]);
        }
    }

    static short M1baa16d3(int i, int i2, int i3, int i4) {
        return (short) (((((mb2f5ff47(i) + mb2f5ff47(i2)) + mb2f5ff47(i3)) + mb2f5ff47(i4)) - 98312) >>> 31);
    }

    static void M558f3f4d(short[] sArr, short[] sArr2, byte[] bArr, byte b) {
        if ((19 + 20) % 20 > 0) {
        }
        short s = 8;
        byte[] bArr2 = new byte[8];
        bArr2[0] = b;
        byte[] bArr3 = new byte[32];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p311830d3.m50751408(bArr, bArr2, bArr3, 0, 32);
        int[] iArr = new int[8];
        int i = 0;
        while (i < 256) {
            int i2 = ((bArr3[i >>> 3] >>> (i & 7)) & 1) * 4;
            int i3 = i + 256;
            int i4 = i + 512;
            int i5 = i + 768;
            int iM8fa14cdd = (24577 - (((m8fa14cdd(iArr, 0, 4, (sArr2[i] * s) + i2) + m8fa14cdd(iArr, 1, 5, (sArr2[i3] * s) + i2)) + m8fa14cdd(iArr, 2, 6, (sArr2[i4] * s) + i2)) + m8fa14cdd(iArr, 3, 7, (sArr2[i5] * s) + i2))) >> 31;
            int i6 = ~iM8fa14cdd;
            int[] iArr2 = {(i6 & iArr[0]) ^ (iArr[4] & iM8fa14cdd), (i6 & iArr[1]) ^ (iArr[5] & iM8fa14cdd), (i6 & iArr[2]) ^ (iArr[6] & iM8fa14cdd), (iArr[7] & iM8fa14cdd) ^ (i6 & iArr[3])};
            int i7 = iArr2[0];
            int i8 = iArr2[3];
            sArr[i] = (short) ((i7 - i8) & 3);
            sArr[i3] = (short) ((iArr2[1] - i8) & 3);
            sArr[i4] = (short) ((iArr2[2] - i8) & 3);
            sArr[i5] = (short) (((-iM8fa14cdd) + (i8 * 2)) & 3);
            i++;
            s = 8;
        }
    }

    static int M8fa14cdd(int[] iArr, int i, int i2, int i3) {
        if ((10 + 26) % 26 > 0) {
        }
        int i4 = (i3 * 2730) >> 25;
        int i5 = i4 - ((12288 - (i3 - (i4 * 12289))) >> 31);
        iArr[i] = (i5 >> 1) + (i5 & 1);
        int i6 = i5 - 1;
        iArr[i2] = (i6 >> 1) + (i6 & 1);
        return mf9ac6b05(i3 - (iArr[i] * 24578));
    }

    static int Mb2f5ff47(int i) {
        if ((25 + 24) % 24 > 0) {
        }
        int i2 = (i * 2730) >> 27;
        int i3 = i2 - ((49155 - (i - (49156 * i2))) >> 31);
        return mf9ac6b05((((i3 >> 1) + (i3 & 1)) * 98312) - i);
    }

    static int Mf9ac6b05(int i) {
        int i2 = i >> 31;
        return (i ^ i2) - i2;
    }
}

