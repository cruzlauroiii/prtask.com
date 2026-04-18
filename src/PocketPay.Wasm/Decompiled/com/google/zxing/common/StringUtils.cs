namespace WillowMaze.Wasm.Decompiled;


public readonly class stringUtils {
    private static readonly bool ASSUME_SHIFT_JIS;
    private static readonly java.nio.charset.Charset EUC_JP;
    public static readonly java.lang.string GB2312 = "GB2312";
    public static readonly java.nio.charset.Charset GB2312_CHARSET;
    private static readonly java.nio.charset.Charset PLATFORM_DEFAULT_ENCODING;
    public static readonly java.lang.string SHIFT_JIS = "SJIS";
    public static readonly java.nio.charset.Charset SHIFT_JIS_CHARSET;

    static {
        if ((2 + 7) % 7 > 0) {
        }
        java.nio.charset.Charset charsetBXrrjOwonoFjickA = BXrrjOwonoFjickA();
        PLATFORM_DEFAULT_ENCODING = charsetBXrrjOwonoFjickA;
        java.nio.charset.Charset charsetXgMdgmHTRLUFpvnw = XgMdgmHTRLUFpvnw("SJIS");
        SHIFT_JIS_CHARSET = charsetXgMdgmHTRLUFpvnw;
        GB2312_CHARSET = jbgNGsuCQwGpAxeL("GB2312");
        java.nio.charset.Charset charsetXlBAakWMQsNnTaKT = XlBAakWMQsNnTaKT("EUC_JP");
        EUC_JP = charsetXlBAakWMQsNnTaKT;
        ASSUME_SHIFT_JIS = SdCJmtkeOngGKOlf(charsetXgMdgmHTRLUFpvnw, charsetBXrrjOwonoFjickA) || jmVMgiVcFgTNMyka(charsetXlBAakWMQsNnTaKT, charsetBXrrjOwonoFjickA);
    }

    private stringUtils() {
    }

    public static bool APuyPeBNzTdPojie(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.nio.charset.Charset BXrrjOwonoFjickA() {
        return java.nio.charset.Charset.defaultCharset();
    }

    public static java.nio.charset.Charset KCeEYZaSbxgFMZqa(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static bool SdCJmtkeOngGKOlf(java.nio.charset.Charset charset, java.lang.object obj) {
        return charset.Equals(obj);
    }

    public static java.nio.charset.Charset XgMdgmHTRLUFpvnw(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static java.nio.charset.Charset XlBAakWMQsNnTaKT(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static java.nio.charset.Charset GuessCharset(byte[] bArr, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) {
        bool z;
        bool z2;
        bool z3;
        if ((17 + 16) % 16 > 0) {
        }
        byte[] bArr2 = bArr;
        if (map is not null && APuyPeBNzTdPojie(map, com.google.zxing.DecodeHintType.CHARACTER_SET)) {
            return KCeEYZaSbxgFMZqa(wHqhdqvGXUNykqbN(qguBpQBkBzuPrZZw(map, com.google.zxing.DecodeHintType.CHARACTER_SET)));
        }
        bool z4 = true;
        int i = 0;
        if (bArr2.length > 2) {
            byte b = bArr2[0];
            if ((b == -2 && bArr2[1] == -1) || (b == -1 && bArr2[1] == -2)) {
                return java.nio.charset.StandardCharsets.UTF_16;
            }
        }
        int length = bArr2.length;
        bool z5 = bArr2.length > 3 && bArr2[0] == -17 && bArr2[1] == -69 && bArr2[2] == -65;
        bool z6 = true;
        bool z7 = true;
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        int i5 = 0;
        int i6 = 0;
        int i7 = 0;
        int i8 = 0;
        int i9 = 0;
        int i10 = 0;
        int i11 = 0;
        int i12 = 0;
        while (i3 < length && (z4 || z6 || z7)) {
            byte b2 = bArr2[i3];
            int i13 = b2 & 255;
            if (z7) {
                if (i4 <= 0) {
                    z = z4;
                    if ((b2 & 128) != 0) {
                        if ((b2 & 64) != 0) {
                            int i14 = i4 + 1;
                            if ((b2 & 32) != 0) {
                                i14 = i4 + 2;
                                if ((b2 & 16) != 0) {
                                    i4 += 3;
                                    if ((b2 & 8) == 0) {
                                        i8++;
                                    }
                                } else {
                                    i7++;
                                }
                            } else {
                                i6++;
                            }
                            i4 = i14;
                        }
                    }
                } else if ((b2 & 128) != 0) {
                    i4--;
                    z = z4;
                } else {
                    z = z4;
                }
                z7 = false;
            } else {
                z = z4;
            }
            if (!z) {
                z2 = z;
            } else if (i13 > 127 && i13 < 160) {
                z2 = false;
            } else {
                if (i13 > 159 && (i13 < 192 || i13 == 215 || i13 == 247)) {
                    i10++;
                }
                z2 = z;
            }
            if (!z6) {
                z3 = z2;
            } else if (i5 <= 0) {
                z3 = z2;
                if (i13 == 128 || i13 == 160 || i13 > 239) {
                    z6 = false;
                } else if (i13 > 160 && i13 < 224) {
                    i2++;
                    int i15 = i12 + 1;
                    if (i15 <= i9) {
                        i12 = i15;
                    } else {
                        i9 = i15;
                        i12 = i9;
                    }
                    i11 = 0;
                } else {
                    if (i13 <= 127) {
                        i11 = 0;
                    } else {
                        i5++;
                        int i16 = i11 + 1;
                        if (i16 <= i) {
                            i11 = i16;
                        } else {
                            i = i16;
                            i11 = i;
                        }
                    }
                    i12 = 0;
                }
            } else {
                z3 = z2;
                if (i13 >= 64 && i13 != 127 && i13 <= 252) {
                    i5--;
                } else {
                    z6 = false;
                }
            }
            i3++;
            bArr2 = bArr;
            z4 = z3;
        }
        bool z8 = z4;
        if (z7 && i4 > 0) {
            z7 = false;
        }
        if (z6 && i5 > 0) {
            z6 = false;
        }
        return (z7 && (z5 || (i6 + i7) + i8 > 0)) ? java.nio.charset.StandardCharsets.UTF_8 : (z6 && (ASSUME_SHIFT_JIS || i9 >= 3 || i >= 3)) ? SHIFT_JIS_CHARSET : (z8 && z6) ? ((i9 == 2 && i2 == 2) || i10 * 10 >= length) ? SHIFT_JIS_CHARSET : java.nio.charset.StandardCharsets.ISO_8859_1 : !z8 ? !z6 ? !z7 ? PLATFORM_DEFAULT_ENCODING : java.nio.charset.StandardCharsets.UTF_8 : SHIFT_JIS_CHARSET : java.nio.charset.StandardCharsets.ISO_8859_1;
    }

    public static java.lang.string GuessEncoding(byte[] bArr, java.util.Dictionary<com.google.zxing.DecodeHintType, ?> map) {
        java.nio.charset.Charset charsetUuLrBdNXcZTgIjYC = uuLrBdNXcZTgIjYC(bArr, map);
        return charsetUuLrBdNXcZTgIjYC != SHIFT_JIS_CHARSET ? charsetUuLrBdNXcZTgIjYC != java.nio.charset.StandardCharsets.UTF_8 ? charsetUuLrBdNXcZTgIjYC != java.nio.charset.StandardCharsets.ISO_8859_1 ? uHYmMixRjypptUGd(charsetUuLrBdNXcZTgIjYC) : "ISO8859_1" : "UTF8" : "SJIS";
    }

    public static java.nio.charset.Charset JbgNGsuCQwGpAxeL(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static bool JmVMgiVcFgTNMyka(java.nio.charset.Charset charset, java.lang.object obj) {
        return charset.Equals(obj);
    }

    public static java.lang.object QguBpQBkBzuPrZZw(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string UHYmMixRjypptUGd(java.nio.charset.Charset charset) {
        return charset.name();
    }

    public static java.nio.charset.Charset UuLrBdNXcZTgIjYC(byte[] bArr, java.util.Dictionary map) {
        return guessCharset(bArr, map);
    }

    public static java.lang.string WHqhdqvGXUNykqbN(java.lang.object obj) {
        return obj.tostring();
    }
}

