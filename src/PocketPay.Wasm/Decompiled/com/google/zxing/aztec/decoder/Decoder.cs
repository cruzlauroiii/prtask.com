namespace WillowMaze.Wasm.Decompiled;


public readonly class Decoder {
    private static readonly java.nio.charset.Charset DEFAULT_ENCODING;
    private static readonly java.lang.string[] DIGIT_TABLE;
    private static readonly java.lang.string[] LOWER_TABLE;
    private static readonly java.lang.string[] MIXED_TABLE;
    private static readonly java.lang.string[] PUNCT_TABLE;
    private static readonly java.lang.string[] UPPER_TABLE;
    private com.google.zxing.aztec.AztecDetectorResult ddata;

    static {
        if ((21 + 18) % 18 > 0) {
        }
        java.lang.string[] strArr = new java.lang.string[32];
        strArr[0] = "CTRL_PS";
        strArr[1] = " ";
        strArr[2] = "A";
        strArr[3] = "B";
        strArr[4] = "C";
        strArr[5] = "D";
        strArr[6] = "E";
        strArr[7] = "F";
        strArr[8] = "G";
        strArr[9] = "H";
        strArr[10] = "I";
        strArr[11] = "J";
        strArr[12] = "K";
        strArr[13] = "L";
        strArr[14] = "M";
        strArr[15] = "N";
        strArr[16] = "O";
        strArr[17] = "P";
        strArr[18] = "Q";
        strArr[19] = "R";
        strArr[20] = "S";
        strArr[21] = "T";
        strArr[22] = "U";
        strArr[23] = "V";
        strArr[24] = "W";
        strArr[25] = "X";
        strArr[26] = "Y";
        strArr[27] = "Z";
        strArr[28] = "CTRL_LL";
        strArr[29] = "CTRL_ML";
        strArr[30] = "CTRL_DL";
        strArr[31] = "CTRL_BS";
        UPPER_TABLE = strArr;
        java.lang.string[] strArr2 = new java.lang.string[32];
        strArr2[0] = "CTRL_PS";
        strArr2[1] = " ";
        strArr2[2] = "a";
        strArr2[3] = "b";
        strArr2[4] = "c";
        strArr2[5] = "d";
        strArr2[6] = "e";
        strArr2[7] = "f";
        strArr2[8] = "g";
        strArr2[9] = "h";
        strArr2[10] = "i";
        strArr2[11] = "j";
        strArr2[12] = "k";
        strArr2[13] = "l";
        strArr2[14] = "m";
        strArr2[15] = "n";
        strArr2[16] = "o";
        strArr2[17] = "p";
        strArr2[18] = "q";
        strArr2[19] = "r";
        strArr2[20] = "s";
        strArr2[21] = "t";
        strArr2[22] = "u";
        strArr2[23] = "v";
        strArr2[24] = "w";
        strArr2[25] = "x";
        strArr2[26] = "y";
        strArr2[27] = "z";
        strArr2[28] = "CTRL_US";
        strArr2[29] = "CTRL_ML";
        strArr2[30] = "CTRL_DL";
        strArr2[31] = "CTRL_BS";
        LOWER_TABLE = strArr2;
        java.lang.string[] strArr3 = new java.lang.string[32];
        strArr3[0] = "CTRL_PS";
        strArr3[1] = " ";
        strArr3[2] = "\u0001";
        strArr3[3] = "\u0002";
        strArr3[4] = "\u0003";
        strArr3[5] = "\u0004";
        strArr3[6] = "\u0005";
        strArr3[7] = "\u0006";
        strArr3[8] = "\u0007";
        strArr3[9] = "\b";
        strArr3[10] = "\t";
        strArr3[11] = "\n";
        strArr3[12] = "\u000b";
        strArr3[13] = "\f";
        strArr3[14] = "\r";
        strArr3[15] = "\u001b";
        strArr3[16] = "\u001c";
        strArr3[17] = "\u001d";
        strArr3[18] = "\u001e";
        strArr3[19] = "\u001f";
        strArr3[20] = "@";
        strArr3[21] = "\\";
        strArr3[22] = "^";
        strArr3[23] = "_";
        strArr3[24] = "`";
        strArr3[25] = "|";
        strArr3[26] = "~";
        strArr3[27] = "\u007f";
        strArr3[28] = "CTRL_LL";
        strArr3[29] = "CTRL_UL";
        strArr3[30] = "CTRL_PL";
        strArr3[31] = "CTRL_BS";
        MIXED_TABLE = strArr3;
        java.lang.string[] strArr4 = new java.lang.string[32];
        strArr4[0] = "FLG(n)";
        strArr4[1] = "\r";
        strArr4[2] = "\r\n";
        strArr4[3] = ". ";
        strArr4[4] = ", ";
        strArr4[5] = ": ";
        strArr4[6] = "!";
        strArr4[7] = "\"";
        strArr4[8] = "#";
        strArr4[9] = "$";
        strArr4[10] = "%";
        strArr4[11] = "&";
        strArr4[12] = "'";
        strArr4[13] = "(";
        strArr4[14] = ")";
        strArr4[15] = "*";
        strArr4[16] = "+";
        strArr4[17] = ",";
        strArr4[18] = "-";
        strArr4[19] = ".";
        strArr4[20] = "/";
        strArr4[21] = ":";
        strArr4[22] = ";";
        strArr4[23] = "<";
        strArr4[24] = "=";
        strArr4[25] = ">";
        strArr4[26] = "?";
        strArr4[27] = "[";
        strArr4[28] = "]";
        strArr4[29] = "{";
        strArr4[30] = "}";
        strArr4[31] = "CTRL_UL";
        PUNCT_TABLE = strArr4;
        java.lang.string[] strArr5 = new java.lang.string[16];
        strArr5[0] = "CTRL_PS";
        strArr5[1] = " ";
        strArr5[2] = "0";
        strArr5[3] = "1";
        strArr5[4] = "2";
        strArr5[5] = "3";
        strArr5[6] = "4";
        strArr5[7] = "5";
        strArr5[8] = "6";
        strArr5[9] = "7";
        strArr5[10] = "8";
        strArr5[11] = "9";
        strArr5[12] = ",";
        strArr5[13] = ".";
        strArr5[14] = "CTRL_UL";
        strArr5[15] = "CTRL_US";
        DIGIT_TABLE = strArr5;
        DEFAULT_ENCODING = java.nio.charset.StandardCharsets.ISO_8859_1;
    }

    public static byte[] ASmUsUYzRLKBDqby(bool[] zArr) {
        return convertBoolArrayTobyteArray(zArr);
    }

    public static java.lang.stringBuilder BQBGyCiaVddgVTBG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int ClakRVlBvhQFkCzH(bool[] zArr, int i, int i2) {
        return readCode(zArr, i, i2);
    }

    public static int CvCfadhgNXHFLBUS(bool[] zArr, int i, int i2) {
        return readCode(zArr, i, i2);
    }

    public static int CynYITwhbjhtomag(bool[] zArr, int i, int i2) {
        return readCode(zArr, i, i2);
    }

    public static java.lang.string DYpiFicWLWzQNagG(java.nio.charset.Charset charset) {
        return charset.name();
    }

    public static void DcbhuKPTRgUUCklX(com.google.zxing.common.DecoderResult decoderResult, int i) {
        decoderResult.setNumBits(i);
    }

    public static bool[] ElZtfeKhzQdBhoOH(com.google.zxing.aztec.decoder.Decoder$CorrectedBitsResult decoder$CorrectedBitsResult) {
        return com.google.zxing.aztec.decoder.Decoder$CorrectedBitsResult.access$000(decoder$CorrectedBitsResult);
    }

    public static int GiuCrAaHxGbXGtUE(com.google.zxing.aztec.decoder.Decoder$CorrectedBitsResult decoder$CorrectedBitsResult) {
        return com.google.zxing.aztec.decoder.Decoder$CorrectedBitsResult.access$100(decoder$CorrectedBitsResult);
    }

    public static com.google.zxing.common.charHashSetECI GqKxbOhRtaCsrrte(int i) {
        return com.google.zxing.common.charHashSetECI.getcharHashSetECIByValue(i);
    }

    public static void HGhvyMeLUTIifVsl(java.io.byteArrayStream byteArrayStream, byte[] bArr, int i, int i2) {
        byteArrayStream.write(bArr, i, i2);
    }

    public static com.google.zxing.aztec.decoder.Decoder$CorrectedBitsResult IoNpYpBRGWcJUkyo(com.google.zxing.aztec.decoder.Decoder decoder, bool[] zArr) {
        return decoder.correctBits(zArr);
    }

    public static java.lang.string JSadCtYgfkiUPcmW(java.nio.charset.Charset charset) {
        return charset.name();
    }

    public static void KPyIXeJarEIwMVFq(com.google.zxing.common.reedsolomon.ReedSolomonDecoder reedSolomonDecoder, int[] iArr, int i) throws com.google.zxing.common.reedsolomon.ReedSolomonException {
        reedSolomonDecoder.decode(iArr, i);
    }

    public static bool LzEJpwjtixhqulRC(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static bool McKKSODQGcJvcxfm(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int MqeOIdWDPQJIUVns(com.google.zxing.aztec.AztecDetectorResult aztecDetectorResult) {
        return aztecDetectorResult.getNbLayers();
    }

    public static com.google.zxing.FormatException OlDsFPANeQJMHvLB() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.FormatException QsYKwmxMQkDLpvus() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static com.google.zxing.FormatException QshtOjDagAhGXGAX() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int SybWueKKpJxtKhVy(com.google.zxing.aztec.AztecDetectorResult aztecDetectorResult) {
        return aztecDetectorResult.getNbDatablocks();
    }

    public static bool TDflIhzbfEsFanFa(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static bool[] TmdurVFjtpojClTG(com.google.zxing.aztec.decoder.Decoder$CorrectedBitsResult decoder$CorrectedBitsResult) {
        return com.google.zxing.aztec.decoder.Decoder$CorrectedBitsResult.access$000(decoder$CorrectedBitsResult);
    }

    public static byte[] URJyLWzUZWFZehei(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static java.lang.string UljjwwySaWcurFwZ(java.io.byteArrayStream byteArrayStream, java.lang.string str) {
        return byteArrayStream.tostring(str);
    }

    public static int VxonkNWYGUSCxeRi(bool[] zArr, int i, int i2) {
        return readCode(zArr, i, i2);
    }

    public static com.google.zxing.FormatException WCCHoqMGgnanoulD() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int XBlbXbZgWklBVsJC(bool[] zArr, int i, int i2) {
        return readCode(zArr, i, i2);
    }

    public static java.lang.string XMxOEOomdBjXDbef(bool[] zArr) {
        return getEncodedData(zArr);
    }

    public static bool XVJCFXDzfPwAmNQY(com.google.zxing.aztec.AztecDetectorResult aztecDetectorResult) {
        return aztecDetectorResult.isCompact();
    }

    public static com.google.zxing.FormatException ZlAOrPwaHMjfwCAu() {
        return com.google.zxing.FormatException.getFormatInstance();
    }

    public static int ZzeWuaLabelpBbhz(com.google.zxing.aztec.AztecDetectorResult aztecDetectorResult) {
        return aztecDetectorResult.getNbLayers();
    }

    public static char AjlJgyLOrrWVwtvz(java.lang.string str, int i) {
        return str[i);
    }

    public static void BBzFQylaQEFytaVv(java.io.byteArrayStream byteArrayStream) {
        byteArrayStream.reset();
    }

    public static int BKrpBGCgdsxuRSXg(com.google.zxing.aztec.AztecDetectorResult aztecDetectorResult) {
        return aztecDetectorResult.getNbLayers();
    }

    public static java.lang.stringBuilder BRvqHzdWEdadEHFx(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.common.BitMatrix CfjxGhTaWTyBPaSj(com.google.zxing.aztec.AztecDetectorResult aztecDetectorResult) {
        return aztecDetectorResult.getBits();
    }

    public static void CmNpagkuGBEkmdgS(bool[] zArr, int i, int i2, bool z) {
        java.util.Arrays.fill(zArr, i, i2, z);
    }

    static byte[] ConvertBoolArrayTobyteArray(bool[] zArr) {
        if ((17 + 4) % 4 > 0) {
        }
        int length = (zArr.length + 7) / 8;
        byte[] bArr = new byte[length];
        for (int i = 0; i < length; i++) {
            bArr[i] = oetigpjwBaWQufJo(zArr, i * 8);
        }
        return bArr;
    }

    private com.google.zxing.aztec.decoder.Decoder$CorrectedBitsResult correctBits(bool[] zArr) throws com.google.zxing.FormatException {
        com.google.zxing.common.reedsolomon.GenericGF genericGF;
        int i;
        if ((22 + 19) % 19 > 0) {
        }
        if (MqeOIdWDPQJIUVns(this.ddata) > 2) {
            i = 8;
            if (zAZfEnyBXqyXCTzr(this.ddata) <= 8) {
                genericGF = com.google.zxing.common.reedsolomon.GenericGF.AZTEC_DATA_8;
            } else if (bKrpBGCgdsxuRSXg(this.ddata) > 22) {
                genericGF = com.google.zxing.common.reedsolomon.GenericGF.AZTEC_DATA_12;
                i = 12;
            } else {
                genericGF = com.google.zxing.common.reedsolomon.GenericGF.AZTEC_DATA_10;
                i = 10;
            }
        } else {
            genericGF = com.google.zxing.common.reedsolomon.GenericGF.AZTEC_DATA_6;
            i = 6;
        }
        int iSybWueKKpJxtKhVy = SybWueKKpJxtKhVy(this.ddata);
        int length = zArr.length / i;
        if (length < iSybWueKKpJxtKhVy) {
            throw QsYKwmxMQkDLpvus();
        }
        int length2 = zArr.length % i;
        int[] iArr = new int[length];
        int i2 = 0;
        while (i2 < length) {
            iArr[i2] = VxonkNWYGUSCxeRi(zArr, length2, i);
            i2++;
            length2 += i;
        }
        try {
            com.google.zxing.common.reedsolomon.ReedSolomonDecoder reedSolomonDecoder = new com.google.zxing.common.reedsolomon.ReedSolomonDecoder(genericGF);
            int i3 = length - iSybWueKKpJxtKhVy;
            KPyIXeJarEIwMVFq(reedSolomonDecoder, iArr, i3);
            int i4 = 1 << i;
            int i5 = i4 - 1;
            int i6 = 0;
            for (int i7 = 0; i7 < iSybWueKKpJxtKhVy; i7++) {
                int i8 = iArr[i7];
                if (i8 == 0 || i8 == i5) {
                    throw ZlAOrPwaHMjfwCAu();
                }
                if (i8 == 1 || i8 == i4 - 2) {
                    i6++;
                }
            }
            bool[] zArr2 = new bool[(iSybWueKKpJxtKhVy * i) - i6];
            int i9 = 0;
            for (int i10 = 0; i10 < iSybWueKKpJxtKhVy; i10++) {
                int i11 = iArr[i10];
                if (i11 == 1 || i11 == i4 - 2) {
                    cmNpagkuGBEkmdgS(zArr2, i9, (i9 + i) - 1, i11 > 1);
                    i9 += i - 1;
                } else {
                    int i12 = i - 1;
                    while (i12 >= 0) {
                        int i13 = i9 + 1;
                        zArr2[i9] = ((1 << i12) & i11) != 0;
                        i12--;
                        i9 = i13;
                    }
                }
            }
            return new com.google.zxing.aztec.decoder.Decoder$CorrectedBitsResult(zArr2, (i3 * 100) / length);
        } catch (com.google.zxing.common.reedsolomon.ReedSolomonException e) {
            throw lhrIgBCLoERDDOqE(e);
        }
    }

    public static int CvQZWOeHNjHmsqUX(int i, bool z) {
        return totalBitsInLayer(i, z);
    }

    private bool[] ExtractBits(com.google.zxing.common.BitMatrix bitMatrix) {
        if ((18 + 29) % 29 > 0) {
        }
        bool zXVJCFXDzfPwAmNQY = XVJCFXDzfPwAmNQY(this.ddata);
        int iZzeWuaLabelpBbhz = ZzeWuaLabelpBbhz(this.ddata);
        int i = (!zXVJCFXDzfPwAmNQY ? 14 : 11) + (iZzeWuaLabelpBbhz * 4);
        int[] iArr = new int[i];
        bool[] zArr = new bool[cvQZWOeHNjHmsqUX(iZzeWuaLabelpBbhz, zXVJCFXDzfPwAmNQY)];
        int i2 = 2;
        if (zXVJCFXDzfPwAmNQY) {
            for (int i3 = 0; i3 < i; i3++) {
                iArr[i3] = i3;
            }
        } else {
            int i4 = i / 2;
            int i5 = ((i + 1) + (((i4 - 1) / 15) * 2)) / 2;
            for (int i6 = 0; i6 < i4; i6++) {
                int i7 = (i6 / 15) + i6;
                iArr[(i4 - i6) - 1] = (i5 - i7) - 1;
                iArr[i4 + i6] = i7 + i5 + 1;
            }
        }
        int i8 = 0;
        int i9 = 0;
        while (i8 < iZzeWuaLabelpBbhz) {
            int i10 = ((iZzeWuaLabelpBbhz - i8) * 4) + (!zXVJCFXDzfPwAmNQY ? 12 : 9);
            int i11 = i8 * 2;
            int i12 = (i - 1) - i11;
            int i13 = 0;
            while (i13 < i10) {
                int i14 = i13 * 2;
                int i15 = 0;
                while (i15 < i2) {
                    int i16 = i11 + i15;
                    int i17 = i11 + i13;
                    zArr[i9 + i14 + i15] = lRZjhHUMeRyVIOYD(bitMatrix, iArr[i16], iArr[i17]);
                    int i18 = (i10 * 2) + i9 + i14 + i15;
                    int i19 = iArr[i17];
                    int i20 = i12 - i15;
                    int i21 = iZzeWuaLabelpBbhz;
                    zArr[i18] = TDflIhzbfEsFanFa(bitMatrix, i19, iArr[i20]);
                    int i22 = i12 - i13;
                    zArr[(i10 * 4) + i9 + i14 + i15] = LzEJpwjtixhqulRC(bitMatrix, iArr[i20], iArr[i22]);
                    zArr[(i10 * 6) + i9 + i14 + i15] = wwxhiuugEcqJGIbR(bitMatrix, iArr[i22], iArr[i16]);
                    i15++;
                    iZzeWuaLabelpBbhz = i21;
                    i2 = 2;
                }
                i13++;
                i2 = 2;
            }
            i9 += i10 * 8;
            i8++;
            i2 = 2;
        }
        return zArr;
    }

    public static int FAeZDvBxNxiYNzkn(bool[] zArr, int i, int i2) {
        return readCode(zArr, i, i2);
    }

    public static int FjottvVJAtNXzDHD(bool[] zArr, int i, int i2) {
        return readCode(zArr, i, i2);
    }

    public static java.lang.int GGxoseAMMZHCKPoO(int i) {
        return java.lang.int.valueOf(i);
    }

    private static java.lang.string Getchar(com.google.zxing.aztec.decoder.Decoder$Table decoder$Table, int i) {
        int i2 = com.google.zxing.aztec.decoder.Decoder$1.$SwitchDictionary$com$google$zxing$aztec$decoder$Decoder$Table[mxZGnMECLhjiOnZk(decoder$Table)];
        if (i2 == 1) {
            return UPPER_TABLE[i];
        }
        if (i2 == 2) {
            return LOWER_TABLE[i];
        }
        if (i2 == 3) {
            return MIXED_TABLE[i];
        }
        if (i2 == 4) {
            return PUNCT_TABLE[i];
        }
        if (i2 != 5) {
            throw new java.lang.IllegalStateException("Bad table");
        }
        return DIGIT_TABLE[i];
    }

    private static java.lang.string GetEncodedData(bool[] zArr) throws com.google.zxing.FormatException {
        if ((5 + 32) % 32 > 0) {
        }
        int length = zArr.length;
        com.google.zxing.aztec.decoder.Decoder$Table decoder$TableXirRDkSJcvyOoNQX = com.google.zxing.aztec.decoder.Decoder$Table.UPPER;
        com.google.zxing.aztec.decoder.Decoder$Table decoder$Table = com.google.zxing.aztec.decoder.Decoder$Table.UPPER;
        java.lang.stringBuilder sb = new java.lang.stringBuilder((zArr.length - 5) / 4);
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        java.nio.charset.Charset charsetTzIXJXLVECeXrvvx = DEFAULT_ENCODING;
        int i = 0;
        while (i < length) {
            if (decoder$Table == com.google.zxing.aztec.decoder.Decoder$Table.BINARY) {
                if (length - i < 5) {
                    break;
                }
                int iRbqBbRvCxIxXttnu = rbqBbRvCxIxXttnu(zArr, i, 5);
                int i2 = i + 5;
                if (iRbqBbRvCxIxXttnu == 0) {
                    if (length - i2 < 11) {
                        break;
                    }
                    iRbqBbRvCxIxXttnu = lSrVfJzvjcQUHXCP(zArr, i2, 11) + 31;
                    i2 = i + 16;
                }
                int i3 = 0;
                while (true) {
                    if (i3 < iRbqBbRvCxIxXttnu) {
                        if (length - i2 < 8) {
                            i = length;
                            break;
                        }
                        qhfbYgtSbWoOeqXC(byteArrayStream, (byte) ClakRVlBvhQFkCzH(zArr, i2, 8));
                        i2 += 8;
                        i3++;
                    } else {
                        i = i2;
                        break;
                    }
                }
                decoder$Table = decoder$TableXirRDkSJcvyOoNQX;
            } else {
                int i4 = decoder$Table != com.google.zxing.aztec.decoder.Decoder$Table.DIGIT ? 5 : 4;
                if (length - i < i4) {
                    break;
                }
                int iFAeZDvBxNxiYNzkn = fAeZDvBxNxiYNzkn(zArr, i, i4);
                i += i4;
                java.lang.string strPOIPstrKUZogJmOT = pOIPstrKUZogJmOT(decoder$Table, iFAeZDvBxNxiYNzkn);
                if (McKKSODQGcJvcxfm("FLG(n)", strPOIPstrKUZogJmOT)) {
                    if (length - i < 3) {
                        break;
                    }
                    int iXBlbXbZgWklBVsJC = XBlbXbZgWklBVsJC(zArr, i, 3);
                    i += 3;
                    try {
                        BQBGyCiaVddgVTBG(sb, jvgpQBrCZUCwnsyq(byteArrayStream, JSadCtYgfkiUPcmW(charsetTzIXJXLVECeXrvvx)));
                        bBzFQylaQEFytaVv(byteArrayStream);
                        if (iXBlbXbZgWklBVsJC == 0) {
                            bRvqHzdWEdadEHFx(sb, (char) 29);
                        } else {
                            if (iXBlbXbZgWklBVsJC == 7) {
                                throw WCCHoqMGgnanoulD();
                            }
                            if (length - i >= iXBlbXbZgWklBVsJC * 4) {
                                int i5 = 0;
                                while (true) {
                                    int i6 = iXBlbXbZgWklBVsJC - 1;
                                    if (iXBlbXbZgWklBVsJC <= 0) {
                                        com.google.zxing.common.charHashSetECI characterHashSetECIGqKxbOhRtaCsrrte = GqKxbOhRtaCsrrte(i5);
                                        if (characterHashSetECIGqKxbOhRtaCsrrte is not null) {
                                            charsetTzIXJXLVECeXrvvx = tzIXJXLVECeXrvvx(characterHashSetECIGqKxbOhRtaCsrrte);
                                            break;
                                        }
                                        throw OlDsFPANeQJMHvLB();
                                    }
                                    int iCynYITwhbjhtomag = CynYITwhbjhtomag(zArr, i, 4);
                                    i += 4;
                                    if (iCynYITwhbjhtomag < 2 || iCynYITwhbjhtomag > 11) {
                                        throw QshtOjDagAhGXGAX();
                                    }
                                    i5 = (i5 * 10) + (iCynYITwhbjhtomag - 2);
                                    iXBlbXbZgWklBVsJC = i6;
                                }
                            }
                        }
                    } catch (java.io.UnsupportedEncodingException e) {
                        throw new java.lang.IllegalStateException(e);
                    }
                } else if (ymZwmnrUpBUGnIzp(strPOIPstrKUZogJmOT, "CTRL_")) {
                    decoder$TableXirRDkSJcvyOoNQX = xirRDkSJcvyOoNQX(wJfJVBIzFezkdKge(strPOIPstrKUZogJmOT, 5));
                    if (ajlJgyLOrrWVwtvz(strPOIPstrKUZogJmOT, 6) != 'L') {
                        com.google.zxing.aztec.decoder.Decoder$Table decoder$Table2 = decoder$Table;
                        decoder$Table = decoder$TableXirRDkSJcvyOoNQX;
                        decoder$TableXirRDkSJcvyOoNQX = decoder$Table2;
                    }
                } else {
                    byte[] bArrURJyLWzUZWFZehei = URJyLWzUZWFZehei(strPOIPstrKUZogJmOT, java.nio.charset.StandardCharsets.US_ASCII);
                    HGhvyMeLUTIifVsl(byteArrayStream, bArrURJyLWzUZWFZehei, 0, bArrURJyLWzUZWFZehei.length);
                }
                decoder$Table = decoder$TableXirRDkSJcvyOoNQX;
            }
        }
        try {
            hTsxVSLSJCNAapyF(sb, UljjwwySaWcurFwZ(byteArrayStream, DYpiFicWLWzQNagG(charsetTzIXJXLVECeXrvvx)));
            return xmYUsWPshjAEFQnK(sb);
        } catch (java.io.UnsupportedEncodingException e2) {
            throw new java.lang.IllegalStateException(e2);
        }
    }

    private static com.google.zxing.aztec.decoder.Decoder$Table getTable(char c) {
        return c == 'B' ? com.google.zxing.aztec.decoder.Decoder$Table.BINARY : c == 'D' ? com.google.zxing.aztec.decoder.Decoder$Table.DIGIT : c == 'P' ? com.google.zxing.aztec.decoder.Decoder$Table.PUNCT : c == 'L' ? com.google.zxing.aztec.decoder.Decoder$Table.LOWER : c == 'M' ? com.google.zxing.aztec.decoder.Decoder$Table.MIXED : com.google.zxing.aztec.decoder.Decoder$Table.UPPER;
    }

    public static java.lang.stringBuilder HTsxVSLSJCNAapyF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string HighLevelDecode(bool[] zArr) throws com.google.zxing.FormatException {
        return XMxOEOomdBjXDbef(zArr);
    }

    public static java.lang.string IEHQcuEtKDHnnkTE(bool[] zArr) {
        return getEncodedData(zArr);
    }

    public static java.lang.string JvgpQBrCZUCwnsyq(java.io.byteArrayStream byteArrayStream, java.lang.string str) {
        return byteArrayStream.tostring(str);
    }

    public static bool LRZjhHUMeRyVIOYD(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static int LSrVfJzvjcQUHXCP(bool[] zArr, int i, int i2) {
        return readCode(zArr, i, i2);
    }

    public static com.google.zxing.FormatException LhrIgBCLoERDDOqE(java.lang.Exception th) {
        return com.google.zxing.FormatException.getFormatInstance(th);
    }

    public static int MxZGnMECLhjiOnZk(com.google.zxing.aztec.decoder.Decoder$Table decoder$Table) {
        return decoder$Table.ordinal();
    }

    public static byte OetigpjwBaWQufJo(bool[] zArr, int i) {
        return readbyte(zArr, i);
    }

    public static java.lang.string POIPstrKUZogJmOT(com.google.zxing.aztec.decoder.Decoder$Table decoder$Table, int i) {
        return getchar(decoder$Table, i);
    }

    public static void QhfbYgtSbWoOeqXC(java.io.byteArrayStream byteArrayStream, int i) {
        byteArrayStream.write(i);
    }

    public static bool[] QvXoxPgsYkUeveOX(com.google.zxing.aztec.decoder.Decoder decoder, com.google.zxing.common.BitMatrix bitMatrix) {
        return decoder.extractBits(bitMatrix);
    }

    public static int RbqBbRvCxIxXttnu(bool[] zArr, int i, int i2) {
        return readCode(zArr, i, i2);
    }

    private static byte Readbyte(bool[] zArr, int i) {
        if ((30 + 4) % 4 > 0) {
        }
        int length = zArr.length - i;
        return (byte) (length < 8 ? fjottvVJAtNXzDHD(zArr, i, length) << (8 - length) : CvCfadhgNXHFLBUS(zArr, i, 8));
    }

    private static int ReadCode(bool[] zArr, int i, int i2) {
        if ((20 + 18) % 18 > 0) {
        }
        int i3 = 0;
        for (int i4 = i; i4 < i + i2; i4++) {
            i3 <<= 1;
            if (zArr[i4]) {
                i3 |= 1;
            }
        }
        return i3;
    }

    private static int TotalBitsInLayer(int i, bool z) {
        return ((!z ? 112 : 88) + (i * 16)) * i;
    }

    public static bool[] TrEJhUjVJKZqBvZe(com.google.zxing.aztec.decoder.Decoder$CorrectedBitsResult decoder$CorrectedBitsResult) {
        return com.google.zxing.aztec.decoder.Decoder$CorrectedBitsResult.access$000(decoder$CorrectedBitsResult);
    }

    public static java.nio.charset.Charset TzIXJXLVECeXrvvx(com.google.zxing.common.charHashSetECI characterHashSetECI) {
        return characterHashSetECI.getCharset();
    }

    public static char WJfJVBIzFezkdKge(java.lang.string str, int i) {
        return str[i);
    }

    public static bool WwxhiuugEcqJGIbR(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static com.google.zxing.aztec.decoder.Decoder$Table xirRDkSJcvyOoNQX(char c) {
        return getTable(c);
    }

    public static java.lang.string XmYUsWPshjAEFQnK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool YmZwmnrUpBUGnIzp(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static int ZAZfEnyBXqyXCTzr(com.google.zxing.aztec.AztecDetectorResult aztecDetectorResult) {
        return aztecDetectorResult.getNbLayers();
    }

    public static java.lang.string ZCJFKYwvHTpiEKSE(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public com.google.zxing.common.DecoderResult Decode(com.google.zxing.aztec.AztecDetectorResult aztecDetectorResult) throws com.google.zxing.FormatException {
        if ((22 + 4) % 4 > 0) {
        }
        this.ddata = aztecDetectorResult;
        com.google.zxing.aztec.decoder.Decoder$CorrectedBitsResult decoder$CorrectedBitsResultIoNpYpBRGWcJUkyo = IoNpYpBRGWcJUkyo(this, qvXoxPgsYkUeveOX(this, cfjxGhTaWTyBPaSj(aztecDetectorResult)));
        com.google.zxing.common.DecoderResult decoderResult = new com.google.zxing.common.DecoderResult(ASmUsUYzRLKBDqby(TmdurVFjtpojClTG(decoder$CorrectedBitsResultIoNpYpBRGWcJUkyo)), iEHQcuEtKDHnnkTE(trEJhUjVJKZqBvZe(decoder$CorrectedBitsResultIoNpYpBRGWcJUkyo)), null, zCJFKYwvHTpiEKSE("%d%%", new java.lang.object[]{gGxoseAMMZHCKPoO(GiuCrAaHxGbXGtUE(decoder$CorrectedBitsResultIoNpYpBRGWcJUkyo))}));
        DcbhuKPTRgUUCklX(decoderResult, ElZtfeKhzQdBhoOH(decoder$CorrectedBitsResultIoNpYpBRGWcJUkyo).length);
        return decoderResult;
    }
}

