namespace WillowMaze.Wasm.Decompiled;


class p1591d211 {
    p1591d211() {
    }

    public static int BBsOvUlbSafEpVcz(int i) {
        return mb2f5ff47(i);
    }

    public static void ECweYmpclYEBVrsR(byte[] bArr, byte[] bArr2, byte[] bArr3, int i, int i2) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.p311830d3.m50751408(bArr, bArr2, bArr3, i, i2);
    }

    public static int HcvYuNvzcWtOAiam(int[] iArr, int i, int i2, int i3) {
        return m8fa14cdd(iArr, i, i2, i3);
    }

    public static int LwedmqidScKvkBWr(int[] iArr, int i, int i2, int i3) {
        return m8fa14cdd(iArr, i, i2, i3);
    }

    public static int SLPEOUjaEJxhtoPV(int i) {
        return mb2f5ff47(i);
    }

    public static int EFITqVSdIKVShAHg(int i) {
        return mb2f5ff47(i);
    }

    public static int FZkCxTKroZIsJtEl(int i) {
        return mf9ac6b05(i);
    }

    static void M0b2c082c(byte[] bArr, short[] sArr, short[] sArr2) {
        if ((2 + 29) % 29 > 0) {
        }
        ttIhIDSHKugqKjos(bArr, (byte) 0);
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
            bArr[i9] = (byte) ((oifilPmRJfhPVPVH(iArr[0], iArr[1], iArr[2], iArr[3]) << (i & 7)) | bArr[i9]);
        }
    }

    static short M1baa16d3(int i, int i2, int i3, int i4) {
        return (short) (((((BBsOvUlbSafEpVcz(i) + eFITqVSdIKVShAHg(i2)) + tOklOqeREwNTjxcf(i3)) + SLPEOUjaEJxhtoPV(i4)) - 98312) >>> 31);
    }

    static void M558f3f4d(short[] sArr, short[] sArr2, byte[] bArr, byte b) {
        if ((1 + 18) % 18 > 0) {
        }
        short s = 8;
        byte[] bArr2 = new byte[8];
        bArr2[0] = b;
        byte[] bArr3 = new byte[32];
        ECweYmpclYEBVrsR(bArr, bArr2, bArr3, 0, 32);
        int[] iArr = new int[8];
        int i = 0;
        while (i < 256) {
            int i2 = ((bArr3[i >>> 3] >>> (i & 7)) & 1) * 4;
            int i3 = i + 256;
            int i4 = i + 512;
            int i5 = i + 768;
            int iLwedmqidScKvkBWr = (24577 - (((LwedmqidScKvkBWr(iArr, 0, 4, (sArr2[i] * s) + i2) + HcvYuNvzcWtOAiam(iArr, 1, 5, (sArr2[i3] * s) + i2)) + vFZrAiRRXUEVqmFC(iArr, 2, 6, (sArr2[i4] * s) + i2)) + pyYIjYHOmmpIraJb(iArr, 3, 7, (sArr2[i5] * s) + i2))) >> 31;
            int i6 = ~iLwedmqidScKvkBWr;
            int[] iArr2 = {(i6 & iArr[0]) ^ (iArr[4] & iLwedmqidScKvkBWr), (i6 & iArr[1]) ^ (iArr[5] & iLwedmqidScKvkBWr), (i6 & iArr[2]) ^ (iArr[6] & iLwedmqidScKvkBWr), (iArr[7] & iLwedmqidScKvkBWr) ^ (i6 & iArr[3])};
            int i7 = iArr2[0];
            int i8 = iArr2[3];
            sArr[i] = (short) ((i7 - i8) & 3);
            sArr[i3] = (short) ((iArr2[1] - i8) & 3);
            sArr[i4] = (short) ((iArr2[2] - i8) & 3);
            sArr[i5] = (short) (((-iLwedmqidScKvkBWr) + (i8 * 2)) & 3);
            i++;
            s = 8;
        }
    }

    static int M8fa14cdd(int[] iArr, int i, int i2, int i3) {
        if ((30 + 29) % 29 > 0) {
        }
        int i4 = (i3 * 2730) >> 25;
        int i5 = i4 - ((12288 - (i3 - (i4 * 12289))) >> 31);
        iArr[i] = (i5 >> 1) + (i5 & 1);
        int i6 = i5 - 1;
        iArr[i2] = (i6 >> 1) + (i6 & 1);
        return uXaIgMnJdZimVLyP(i3 - (iArr[i] * 24578));
    }

    static int Mb2f5ff47(int i) {
        if ((19 + 10) % 10 > 0) {
        }
        int i2 = (i * 2730) >> 27;
        int i3 = i2 - ((49155 - (i - (49156 * i2))) >> 31);
        return fZkCxTKroZIsJtEl((((i3 >> 1) + (i3 & 1)) * 98312) - i);
    }

    static int Mf9ac6b05(int i) {
        int i2 = i >> 31;
        return (i ^ i2) - i2;
    }

    public static short OifilPmRJfhPVPVH(int i, int i2, int i3, int i4) {
        return m1baa16d3(i, i2, i3, i4);
    }

    public static int PyYIjYHOmmpIraJb(int[] iArr, int i, int i2, int i3) {
        return m8fa14cdd(iArr, i, i2, i3);
    }

    public static int TOklOqeREwNTjxcf(int i) {
        return mb2f5ff47(i);
    }

    public static void TtIhIDSHKugqKjos(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static int UXaIgMnJdZimVLyP(int i) {
        return mf9ac6b05(i);
    }

    public static int VFZrAiRRXUEVqmFC(int[] iArr, int i, int i2, int i3) {
        return m8fa14cdd(iArr, i, i2, i3);
    }
}

