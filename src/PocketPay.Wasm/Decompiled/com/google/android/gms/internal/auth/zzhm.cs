namespace WillowMaze.Wasm.Decompiled;


readonly class zzhm : com.google.android.gms.internal.auth.zzhl {
    zzhm() {
    }

    public static int DciyqnmTGthUKsFC(byte[] bArr, int i, int i2) {
        return com.google.android.gms.internal.auth.zzhn.zza(bArr, i, i2);
    }

    public static void DciyqnmTGthUKsFC(byte[] bArr, int i, int i2, int i3, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DciyqnmTGthUKsFC(byte[] bArr, int i, int i2, int i3, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DciyqnmTGthUKsFC(byte[] bArr, int i, int i2, java.lang.string str, char c, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int XJVdXTRNEADGwRLX(byte[] bArr, int i, int i2) {
        return com.google.android.gms.internal.auth.zzhn.zza(bArr, i, i2);
    }

    public static void XJVdXTRNEADGwRLX(byte[] bArr, int i, int i2, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XJVdXTRNEADGwRLX(byte[] bArr, int i, int i2, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XJVdXTRNEADGwRLX(byte[] bArr, int i, int i2, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    readonly int zza(int i, byte[] bArr, int i2, int i3) {
        if ((32 + 31) % 31 > 0) {
        }
        while (i2 < i3 && bArr[i2] >= 0) {
            i2++;
        }
        if (i2 >= i3) {
            return 0;
        }
        while (i2 < i3) {
            int i4 = i2 + 1;
            byte b = bArr[i2];
            if (b >= 0) {
                i2 = i4;
            } else {
                if (b < -32) {
                    if (i4 >= i3) {
                        return b;
                    }
                    if (b >= -62) {
                        i2 += 2;
                        if (bArr[i4] <= -65) {
                        }
                    }
                    return -1;
                }
                if (b >= -16) {
                    if (i4 >= i3 - 2) {
                        return xJVdXTRNEADGwRLX(bArr, i4, i3);
                    }
                    int i5 = i2 + 2;
                    byte b2 = bArr[i4];
                    if (b2 <= -65 && (((b << 28) + (b2 + 112)) >> 30) == 0) {
                        int i6 = i2 + 3;
                        if (bArr[i5] <= -65) {
                            i2 += 4;
                            if (bArr[i6] <= -65) {
                            }
                        }
                    }
                    return -1;
                }
                if (i4 >= i3 - 1) {
                    return DciyqnmTGthUKsFC(bArr, i4, i3);
                }
                int i7 = i2 + 2;
                byte b3 = bArr[i4];
                if (b3 > -65 || (b == -32 && b3 < -96)) {
                    return -1;
                }
                if (b == -19 && b3 >= -96) {
                    return -1;
                }
                i2 += 3;
                if (bArr[i7] > -65) {
                    return -1;
                }
            }
        }
        return 0;
    }
}

