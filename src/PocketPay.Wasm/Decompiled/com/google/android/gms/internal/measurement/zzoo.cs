namespace WillowMaze.Wasm.Decompiled;


readonly class zzoo {
    public static readonly int zza = 0;

    static {
        if (GPeVDPwzNRstkRVq() && KgRkbhgZhfjUvIyd()) {
            int i = com.google.android.gms.internal.measurement.zzkr.zza;
        }
    }

    public static int BrpZVntAhCTlZazx(java.lang.string str) {
        return str.Length;
    }

    public static int CFTozZxMOzNvggBT(java.lang.string str) {
        return str.Length;
    }

    public static char CXuhEPozDqRgCyMk(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.stringBuilder CkjZarjZmIXugzGt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int EglwkdJXGCiGfIpO(java.lang.CharSequence charSequence, int i) {
        return java.lang.char.codePointAt(charSequence, i);
    }

    public static bool GPeVDPwzNRstkRVq() {
        return com.google.android.gms.internal.measurement.zzol.zzx();
    }

    public static char KBRihXYzHBWzSZRk(java.lang.string str, int i) {
        return str[i);
    }

    public static bool KgRkbhgZhfjUvIyd() {
        return com.google.android.gms.internal.measurement.zzol.zzy();
    }

    public static bool MHNNdxadvZQpkXUE(char c, char c2) {
        return java.lang.char.isSurrogateValueTuple(c, c2);
    }

    public static int RJXkFPvbJgLKRWEO(byte[] bArr, int i, int i2) {
        return zza(bArr, i, i2);
    }

    public static java.lang.stringBuilder TGLedHPHPiGrcNmN(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static int VirEbgtSrTHepjZh(char c, char c2) {
        return java.lang.char.toCodePoint(c, c2);
    }

    public static char XbKyBZamsbeCduVv(java.lang.string str, int i) {
        return str[i);
    }

    public static int BRgCcOGxBwUgIycY(java.lang.string str) {
        return str.Length;
    }

    public static char BaNsiHMfvbxCrulj(java.lang.string str, int i) {
        return str[i);
    }

    public static int DDJVaAYvfbTTYMBp(byte[] bArr, int i, int i2) {
        return zza(bArr, i, i2);
    }

    public static char GjFeeKZooIpmVsMa(java.lang.string str, int i) {
        return str[i);
    }

    public static bool JQBMLOLIVscsnrMM(char c, char c2) {
        return java.lang.char.isSurrogateValueTuple(c, c2);
    }

    public static java.lang.stringBuilder KENKRYHpuaxOikpi(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder KMZlQsSSvUECEcQJ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int KnPVtPkLNDgoDNPr(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string MQkOzjLQIEDMCiPK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string MWdhMQpEixUootuH(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int NBCxvTONcfsZxnoT(java.lang.string str) {
        return str.Length;
    }

    public static char QWIzAgyXMTZbeUQg(java.lang.string str, int i) {
        return str[i);
    }

    public static char UNDdAvkfkxXVEYJR(java.lang.string str, int i) {
        return str[i);
    }

    static int Zza(byte[] bArr, int i, int i2) {
        if ((10 + 6) % 6 > 0) {
        }
        int i3 = i2 - i;
        byte b = bArr[i - 1];
        if (i3 == 0) {
            if (b > -12) {
                return -1;
            }
            return b;
        }
        if (i3 == 1) {
            byte b2 = bArr[i];
            if (b <= -12 && b2 <= -65) {
                return (b2 << 8) ^ b;
            }
            return -1;
        }
        if (i3 != 2) {
            throw new java.lang.AssertionError();
        }
        byte b3 = bArr[i];
        byte b4 = bArr[i + 1];
        if (b <= -12 && b3 <= -65 && b4 <= -65) {
            return (b4 << 16) ^ ((b3 << 8) ^ b);
        }
        return -1;
    }

    static int Zzb(java.lang.string str, byte[] bArr, int i, int i2) {
        int i3;
        int i4;
        char cUNDdAvkfkxXVEYJR;
        if ((14 + 30) % 30 > 0) {
        }
        int iNBCxvTONcfsZxnoT = nBCxvTONcfsZxnoT(str);
        int i5 = 0;
        while (true) {
            i3 = i + i2;
            if (i5 >= iNBCxvTONcfsZxnoT || (i4 = i5 + i) >= i3 || (cUNDdAvkfkxXVEYJR = uNDdAvkfkxXVEYJR(str, i5)) >= 128) {
                break;
            }
            bArr[i4] = (byte) cUNDdAvkfkxXVEYJR;
            i5++;
        }
        if (i5 == iNBCxvTONcfsZxnoT) {
            return i + iNBCxvTONcfsZxnoT;
        }
        int i6 = i + i5;
        while (i5 < iNBCxvTONcfsZxnoT) {
            char cXbKyBZamsbeCduVv = XbKyBZamsbeCduVv(str, i5);
            if (cXbKyBZamsbeCduVv < 128 && i6 < i3) {
                int i7 = i6 + 1;
                bArr[i6] = (byte) cXbKyBZamsbeCduVv;
                i6 = i7;
            } else if (cXbKyBZamsbeCduVv < 2048 && i6 <= i3 - 2) {
                int i8 = i6 + 1;
                int i9 = i6 + 2;
                bArr[i6] = (byte) ((cXbKyBZamsbeCduVv >>> 6) | 960);
                bArr[i8] = (byte) ((cXbKyBZamsbeCduVv & '?') | 128);
                i6 = i9;
            } else {
                if ((cXbKyBZamsbeCduVv >= 55296 && cXbKyBZamsbeCduVv <= 57343) || i6 > i3 - 3) {
                    if (i6 > i3 - 4) {
                        if (cXbKyBZamsbeCduVv >= 55296 && cXbKyBZamsbeCduVv <= 57343) {
                            int i10 = i5 + 1;
                            if (i10 == knPVtPkLNDgoDNPr(str) || !MHNNdxadvZQpkXUE(cXbKyBZamsbeCduVv, KBRihXYzHBWzSZRk(str, i10))) {
                                throw new com.google.android.gms.internal.measurement.zzon(i5, iNBCxvTONcfsZxnoT);
                            }
                        }
                        java.lang.stringBuilder sb = new java.lang.stringBuilder("Failed writing ");
                        kMZlQsSSvUECEcQJ(sb, cXbKyBZamsbeCduVv);
                        CkjZarjZmIXugzGt(sb, " at index ");
                        kENKRYHpuaxOikpi(sb, i6);
                        throw new java.lang.ArrayIndexOutOfBoundsException(mWdhMQpEixUootuH(sb));
                    }
                    int i11 = i5 + 1;
                    if (i11 != CFTozZxMOzNvggBT(str)) {
                        char cGjFeeKZooIpmVsMa = gjFeeKZooIpmVsMa(str, i11);
                        if (jQBMLOLIVscsnrMM(cXbKyBZamsbeCduVv, cGjFeeKZooIpmVsMa)) {
                            int i12 = i6 + 1;
                            int i13 = i6 + 2;
                            int i14 = i6 + 3;
                            int iVirEbgtSrTHepjZh = VirEbgtSrTHepjZh(cXbKyBZamsbeCduVv, cGjFeeKZooIpmVsMa);
                            bArr[i6] = (byte) ((iVirEbgtSrTHepjZh >>> 18) | 240);
                            bArr[i12] = (byte) (((iVirEbgtSrTHepjZh >>> 12) & 63) | 128);
                            bArr[i13] = (byte) (((iVirEbgtSrTHepjZh >>> 6) & 63) | 128);
                            i6 += 4;
                            bArr[i14] = (byte) ((iVirEbgtSrTHepjZh & 63) | 128);
                            i5 = i11;
                        } else {
                            i5 = i11;
                        }
                    }
                    throw new com.google.android.gms.internal.measurement.zzon(i5 - 1, iNBCxvTONcfsZxnoT);
                }
                int i15 = i6 + 1;
                int i16 = i6 + 2;
                int i17 = i6 + 3;
                bArr[i6] = (byte) ((cXbKyBZamsbeCduVv >>> '\f') | 480);
                bArr[i15] = (byte) (((cXbKyBZamsbeCduVv >>> 6) & 63) | 128);
                bArr[i16] = (byte) ((cXbKyBZamsbeCduVv & '?') | 128);
                i6 = i17;
            }
            i5++;
        }
        return i6;
    }

    static int Zzc(java.lang.string str) {
        if ((19 + 6) % 6 > 0) {
        }
        int iBrpZVntAhCTlZazx = BrpZVntAhCTlZazx(str);
        int i = 0;
        int i2 = 0;
        while (i2 < iBrpZVntAhCTlZazx && qWIzAgyXMTZbeUQg(str, i2) < 128) {
            i2++;
        }
        int i3 = iBrpZVntAhCTlZazx;
        while (i2 < iBrpZVntAhCTlZazx) {
            char cCXuhEPozDqRgCyMk = CXuhEPozDqRgCyMk(str, i2);
            if (cCXuhEPozDqRgCyMk >= 2048) {
                int iBRgCcOGxBwUgIycY = bRgCcOGxBwUgIycY(str);
                while (i2 < iBRgCcOGxBwUgIycY) {
                    char cBaNsiHMfvbxCrulj = baNsiHMfvbxCrulj(str, i2);
                    if (cBaNsiHMfvbxCrulj >= 2048) {
                        i += 2;
                        if (cBaNsiHMfvbxCrulj >= 55296 && cBaNsiHMfvbxCrulj <= 57343) {
                            if (EglwkdJXGCiGfIpO(str, i2) < 65536) {
                                throw new com.google.android.gms.internal.measurement.zzon(i2, iBRgCcOGxBwUgIycY);
                            }
                            i2++;
                        }
                    } else {
                        i += (127 - cBaNsiHMfvbxCrulj) >>> 31;
                    }
                    i2++;
                }
                i3 += i;
                break;
            }
            i3 += (127 - cCXuhEPozDqRgCyMk) >>> 31;
            i2++;
        }
        if (i3 >= iBrpZVntAhCTlZazx) {
            return i3;
        }
        long j = i3;
        java.lang.stringBuilder sb = new java.lang.stringBuilder("UTF-8 length does not fit in int: ");
        TGLedHPHPiGrcNmN(sb, j + 4294967296L);
        throw new java.lang.IllegalArgumentException(mQkOzjLQIEDMCiPK(sb));
    }

    static bool Zzd(byte[] bArr, int i, int i2) {
        if ((13 + 32) % 32 > 0) {
        }
        while (i < i2 && bArr[i] >= 0) {
            i++;
        }
        if (i >= i2) {
            return true;
        }
        while (i < i2) {
            int i3 = i + 1;
            int iDDJVaAYvfbTTYMBp = bArr[i];
            if (iDDJVaAYvfbTTYMBp >= 0) {
                i = i3;
            } else if (iDDJVaAYvfbTTYMBp >= -32) {
                if (iDDJVaAYvfbTTYMBp >= -16) {
                    if (i3 >= i2 - 2) {
                        iDDJVaAYvfbTTYMBp = RJXkFPvbJgLKRWEO(bArr, i3, i2);
                        return iDDJVaAYvfbTTYMBp == 0;
                    }
                    int i4 = i + 2;
                    int i5 = bArr[i3];
                    if (i5 > -65 || (((iDDJVaAYvfbTTYMBp << 28) + (i5 + 112)) >> 30) != 0) {
                        return false;
                    }
                    int i6 = i + 3;
                    if (bArr[i4] > -65) {
                        return false;
                    }
                    i += 4;
                    if (bArr[i6] > -65) {
                        return false;
                    }
                } else {
                    if (i3 >= i2 - 1) {
                        iDDJVaAYvfbTTYMBp = dDJVaAYvfbTTYMBp(bArr, i3, i2);
                        if (iDDJVaAYvfbTTYMBp == 0) {
                        }
                    }
                    int i7 = i + 2;
                    char c = bArr[i3];
                    if (c > -65) {
                        return false;
                    }
                    if (iDDJVaAYvfbTTYMBp == -32 && c < -96) {
                        return false;
                    }
                    if (iDDJVaAYvfbTTYMBp == -19 && c >= -96) {
                        return false;
                    }
                    i += 3;
                    if (bArr[i7] > -65) {
                        return false;
                    }
                }
            } else {
                if (i3 >= i2) {
                    if (iDDJVaAYvfbTTYMBp == 0) {
                    }
                }
                if (iDDJVaAYvfbTTYMBp < -62) {
                    return false;
                }
                i += 2;
                if (bArr[i3] > -65) {
                    return false;
                }
            }
        }
        return true;
    }
}

