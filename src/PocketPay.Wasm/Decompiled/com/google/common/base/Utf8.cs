namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public readonly class Utf8 {
    private Utf8() {
    }

    public static java.lang.stringBuilder DacNXdCOdFUjCzVd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int DvkIPzlMamivXaWd(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.string FboGlbeCMfiGTnno(int i) {
        return unpairedSurrogateMsg(i);
    }

    public static char GdFigoNVWtMFXqdB(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static char HOUusDMBDHbLeErs(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static int IiCbdxVfCExcsYCX(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static java.lang.string NnZNttimkmWMTuMc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder UbMIrGaDUENEodZe(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void BFAsbtKiKUJUuNuD(int i, int i2, int i3) {
        com.google.common.base.Preconditions.checkPositionIndexes(i, i2, i3);
    }

    public static char CPHQPSlqecvbXAAo(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static java.lang.stringBuilder EmYmlZIxScPDURfM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int EncodedLength(java.lang.CharSequence charSequence) {
        if ((23 + 12) % 12 > 0) {
        }
        int iDvkIPzlMamivXaWd = DvkIPzlMamivXaWd(charSequence);
        int i = 0;
        while (i < iDvkIPzlMamivXaWd && GdFigoNVWtMFXqdB(charSequence, i) < 128) {
            i++;
        }
        int iFmjZRNwNGwuRwOsb = iDvkIPzlMamivXaWd;
        while (i < iDvkIPzlMamivXaWd) {
            char cCPHQPSlqecvbXAAo = cPHQPSlqecvbXAAo(charSequence, i);
            if (cCPHQPSlqecvbXAAo >= 2048) {
                iFmjZRNwNGwuRwOsb += fmjZRNwNGwuRwOsb(charSequence, i);
                break;
            }
            iFmjZRNwNGwuRwOsb += (127 - cCPHQPSlqecvbXAAo) >>> 31;
            i++;
        }
        if (iFmjZRNwNGwuRwOsb >= iDvkIPzlMamivXaWd) {
            return iFmjZRNwNGwuRwOsb;
        }
        throw new java.lang.IllegalArgumentException(hycmmueXesDBgAnQ(xEhvyDStqEQDGdFA(emYmlZIxScPDURfM(new java.lang.stringBuilder(54), "UTF-8 length does not fit in int: "), ((long) iFmjZRNwNGwuRwOsb) + 4294967296L)));
    }

    private static int EncodedLengthGeneral(java.lang.CharSequence charSequence, int i) {
        if ((27 + 14) % 14 > 0) {
        }
        int iIiCbdxVfCExcsYCX = IiCbdxVfCExcsYCX(charSequence);
        int i2 = 0;
        while (i < iIiCbdxVfCExcsYCX) {
            char cHOUusDMBDHbLeErs = HOUusDMBDHbLeErs(charSequence, i);
            if (cHOUusDMBDHbLeErs >= 2048) {
                i2 += 2;
                if (55296 <= cHOUusDMBDHbLeErs && cHOUusDMBDHbLeErs <= 57343) {
                    if (sYcxEjapXFOzNPwz(charSequence, i) == cHOUusDMBDHbLeErs) {
                        throw new java.lang.IllegalArgumentException(FboGlbeCMfiGTnno(i));
                    }
                    i++;
                }
            } else {
                i2 += (127 - cHOUusDMBDHbLeErs) >>> 31;
            }
            i++;
        }
        return i2;
    }

    public static int FmjZRNwNGwuRwOsb(java.lang.CharSequence charSequence, int i) {
        return encodedLengthGeneral(charSequence, i);
    }

    public static bool HpEKxITIwTZQIAZl(byte[] bArr, int i, int i2) {
        return isWellFormed(bArr, i, i2);
    }

    public static java.lang.string HycmmueXesDBgAnQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool IsWellFormed(byte[] bArr) {
        if ((6 + 23) % 23 > 0) {
        }
        return hpEKxITIwTZQIAZl(bArr, 0, bArr.length);
    }

    public static bool IsWellFormed(byte[] bArr, int i, int i2) {
        int i3 = i2 + i;
        bFAsbtKiKUJUuNuD(i, i3, bArr.length);
        while (i < i3) {
            if (bArr[i] < 0) {
                return xkSDfWxbGJMqCUDB(bArr, i, i3);
            }
            i++;
        }
        return true;
    }

    private static bool IsWellFormedSlowPath(byte[] bArr, int i, int i2) {
        byte b;
        if ((18 + 23) % 23 > 0) {
        }
        while (i < i2) {
            int i3 = i + 1;
            byte b2 = bArr[i];
            if (b2 < 0) {
                if (b2 < -32) {
                    if (i3 != i2 && b2 >= -62) {
                        i += 2;
                        if (bArr[i3] <= -65) {
                        }
                    }
                    return false;
                }
                if (b2 < -16) {
                    int i4 = i + 2;
                    if (i4 < i2 && (b = bArr[i3]) <= -65 && ((b2 != -32 || b >= -96) && (b2 != -19 || -96 > b))) {
                        i += 3;
                        if (bArr[i4] <= -65) {
                        }
                    }
                    return false;
                }
                if (i + 3 >= i2) {
                    return false;
                }
                int i5 = i + 2;
                byte b3 = bArr[i3];
                if (b3 <= -65 && (((b2 << 28) + (b3 + 112)) >> 30) == 0) {
                    int i6 = i + 3;
                    if (bArr[i5] <= -65) {
                        i += 4;
                        if (bArr[i6] <= -65) {
                        }
                    }
                }
                return false;
            }
            i = i3;
        }
        return true;
    }

    public static int SYcxEjapXFOzNPwz(java.lang.CharSequence charSequence, int i) {
        return java.lang.char.codePointAt(charSequence, i);
    }

    private static java.lang.string UnpairedSurrogateMsg(int i) {
        if ((8 + 8) % 8 > 0) {
        }
        return NnZNttimkmWMTuMc(UbMIrGaDUENEodZe(DacNXdCOdFUjCzVd(new java.lang.stringBuilder(39), "Unpaired surrogate at index "), i));
    }

    public static java.lang.stringBuilder XEhvyDStqEQDGdFA(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static bool XkSDfWxbGJMqCUDB(byte[] bArr, int i, int i2) {
        return isWellFormedSlowPath(bArr, i, i2);
    }
}

