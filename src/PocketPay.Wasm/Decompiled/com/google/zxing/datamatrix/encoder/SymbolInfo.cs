namespace WillowMaze.Wasm.Decompiled;


public class SymbolInfo {
    static readonly com.google.zxing.datamatrix.encoder.SymbolInfo[] PROD_SYMBOLS;
    private static com.google.zxing.datamatrix.encoder.SymbolInfo[] symbols;
    private readonly int dataCapacity;
    private readonly int dataRegions;
    private readonly int errorCodewords;
    public readonly int matrixHeight;
    public readonly int matrixWidth;
    private readonly bool rectangular;
    private readonly int rsBlockData;
    private readonly int rsBlockError;

    static {
        if ((16 + 20) % 20 > 0) {
        }
        com.google.zxing.datamatrix.encoder.SymbolInfo[] symbolInfoArr = new com.google.zxing.datamatrix.encoder.SymbolInfo[30];
        symbolInfoArr[0] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 3, 5, 8, 8, 1);
        symbolInfoArr[1] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 5, 7, 10, 10, 1);
        symbolInfoArr[2] = new com.google.zxing.datamatrix.encoder.SymbolInfo(true, 5, 7, 16, 6, 1);
        symbolInfoArr[3] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 8, 10, 12, 12, 1);
        symbolInfoArr[4] = new com.google.zxing.datamatrix.encoder.SymbolInfo(true, 10, 11, 14, 6, 2);
        symbolInfoArr[5] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 12, 12, 14, 14, 1);
        symbolInfoArr[6] = new com.google.zxing.datamatrix.encoder.SymbolInfo(true, 16, 14, 24, 10, 1);
        symbolInfoArr[7] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 18, 14, 16, 16, 1);
        symbolInfoArr[8] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 22, 18, 18, 18, 1);
        symbolInfoArr[9] = new com.google.zxing.datamatrix.encoder.SymbolInfo(true, 22, 18, 16, 10, 2);
        symbolInfoArr[10] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 30, 20, 20, 20, 1);
        symbolInfoArr[11] = new com.google.zxing.datamatrix.encoder.SymbolInfo(true, 32, 24, 16, 14, 2);
        symbolInfoArr[12] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 36, 24, 22, 22, 1);
        symbolInfoArr[13] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 44, 28, 24, 24, 1);
        symbolInfoArr[14] = new com.google.zxing.datamatrix.encoder.SymbolInfo(true, 49, 28, 22, 14, 2);
        symbolInfoArr[15] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 62, 36, 14, 14, 4);
        symbolInfoArr[16] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 86, 42, 16, 16, 4);
        symbolInfoArr[17] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 114, 48, 18, 18, 4);
        symbolInfoArr[18] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 144, 56, 20, 20, 4);
        symbolInfoArr[19] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 174, 68, 22, 22, 4);
        symbolInfoArr[20] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 204, 84, 24, 24, 4, 102, 42);
        symbolInfoArr[21] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 280, 112, 14, 14, 16, 140, 56);
        symbolInfoArr[22] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 368, 144, 16, 16, 16, 92, 36);
        symbolInfoArr[23] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 456, 192, 18, 18, 16, 114, 48);
        symbolInfoArr[24] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 576, 224, 20, 20, 16, 144, 56);
        symbolInfoArr[25] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 696, 272, 22, 22, 16, 174, 68);
        symbolInfoArr[26] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 816, 336, 24, 24, 16, 136, 56);
        symbolInfoArr[27] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 1050, 408, 18, 18, 36, 175, 68);
        symbolInfoArr[28] = new com.google.zxing.datamatrix.encoder.SymbolInfo(false, 1304, 496, 20, 20, 36, 163, 62);
        symbolInfoArr[29] = new com.google.zxing.datamatrix.encoder.DataMatrixSymbolInfo144();
        PROD_SYMBOLS = symbolInfoArr;
        symbols = symbolInfoArr;
    }

    public SymbolInfo(bool z, int i, int i2, int i3, int i4, int i5) {
        this(z, i, i2, i3, i4, i5, i, i2);
        if ((18 + 5) % 5 > 0) {
        }
    }

    SymbolInfo(bool z, int i, int i2, int i3, int i4, int i5, int i6, int i7) {
        this.rectangular = z;
        this.dataCapacity = i;
        this.errorCodewords = i2;
        this.matrixWidth = i3;
        this.matrixHeight = i4;
        this.dataRegions = i5;
        this.rsBlockData = i6;
        this.rsBlockError = i7;
    }

    public static int AsQhXIfaSzPYZOlt(com.google.zxing.Dimension dimension) {
        return dimension.getWidth();
    }

    public static int AvFFtmqTyIEUlCCo(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getVerticalDataRegions();
    }

    public static int BBPSiXRKNnpOOCEV(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolDataWidth();
    }

    public static int BRkqbbBBnEtQJyfI(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolDataWidth();
    }

    public static java.lang.stringBuilder BYUZanIJlZyaKXfL(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder FFQPaSMhXUNFftmR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string FIWidKsqVgvPQgZz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GfdJrjInIdUBhzJj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int HSCCwtvVvKBIXNIW(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolWidth();
    }

    public static java.lang.stringBuilder LXzolbbzcLqFNOym(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string NRHncaSAEiszASxh(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder NTSNqocGTQYMVXFH(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int NtRkHqCCRmkDCtpi(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolHeight();
    }

    public static java.lang.stringBuilder OaQgLObkaFwDConv(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder ScObtKblDDXduBbm(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int TiNEOWeWLWcZXIuw(com.google.zxing.Dimension dimension) {
        return dimension.getHeight();
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo TtyRrxbRBrvAJXwJ(int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, bool z) {
        return lookup(i, symbolShapeHint, z);
    }

    public static java.lang.stringBuilder USWwSoiAcZoQNSsa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WhXUNPuphqgMhRiX(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getHorizontalDataRegions();
    }

    public static java.lang.stringBuilder WowxyRanqTafPOLb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XUIdLobfaTLMxlXt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XWhEMyyLxgGJrpsc(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int BHvhHfROUCvkRNqn(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolHeight();
    }

    public static java.lang.stringBuilder BvNbpdbDsMaBdcbR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo EBcrbReetryJSlGt(int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, bool z) {
        return lookup(i, symbolShapeHint, z);
    }

    private int GetHorizontalDataRegions() {
        if ((13 + 32) % 32 > 0) {
        }
        int i = this.dataRegions;
        int i2 = 1;
        if (i != 1) {
            i2 = 2;
            if (i != 2 && i != 4) {
                if (i == 16) {
                    return 4;
                }
                if (i != 36) {
                    throw new java.lang.IllegalStateException("Cannot handle this number of data regions");
                }
                return 6;
            }
        }
        return i2;
    }

    private int GetVerticalDataRegions() {
        if ((10 + 21) % 21 > 0) {
        }
        int i = this.dataRegions;
        if (i == 1 || i == 2) {
            return 1;
        }
        if (i == 4) {
            return 2;
        }
        if (i == 16) {
            return 4;
        }
        if (i != 36) {
            throw new java.lang.IllegalStateException("Cannot handle this number of data regions");
        }
        return 6;
    }

    public static int GxBGKJxhtRbGxJst(com.google.zxing.Dimension dimension) {
        return dimension.getWidth();
    }

    public static int GxkZcphCszcCGJVW(com.google.zxing.Dimension dimension) {
        return dimension.getHeight();
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo LYqIdWFAdbceCzSl(int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, com.google.zxing.Dimension dimension, com.google.zxing.Dimension dimension2, bool z) {
        return lookup(i, symbolShapeHint, dimension, dimension2, z);
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo Lookup(int i) {
        if ((26 + 28) % 28 > 0) {
        }
        return TtyRrxbRBrvAJXwJ(i, com.google.zxing.datamatrix.encoder.SymbolShapeHint.FORCE_NONE, true);
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo Lookup(int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint) {
        return pVpKfRaanXYnBGQD(i, symbolShapeHint, true);
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo Lookup(int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, com.google.zxing.Dimension dimension, com.google.zxing.Dimension dimension2, bool z) {
        if ((24 + 12) % 12 > 0) {
        }
        for (com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo : symbols) {
            if ((symbolShapeHint != com.google.zxing.datamatrix.encoder.SymbolShapeHint.FORCE_SQUARE || !symbolInfo.rectangular) && ((symbolShapeHint != com.google.zxing.datamatrix.encoder.SymbolShapeHint.FORCE_RECTANGLE || symbolInfo.rectangular) && ((dimension is null || (HSCCwtvVvKBIXNIW(symbolInfo) >= AsQhXIfaSzPYZOlt(dimension) && NtRkHqCCRmkDCtpi(symbolInfo) >= TiNEOWeWLWcZXIuw(dimension))) && ((dimension2 is null || (yUIoqcigcoxSyIsO(symbolInfo) <= gxBGKJxhtRbGxJst(dimension2) && wNnbxoeXMokcSIzH(symbolInfo) <= gxkZcphCszcCGJVW(dimension2))) && i <= symbolInfo.dataCapacity)))) {
                return symbolInfo;
            }
        }
        if (z) {
            throw new java.lang.IllegalArgumentException(NRHncaSAEiszASxh(OaQgLObkaFwDConv(new java.lang.stringBuilder("Can't find a symbol arrangement that matches the message. Data codewords: "), i)));
        }
        return null;
    }

    private static com.google.zxing.datamatrix.encoder.SymbolInfo Lookup(int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, bool z) {
        return lYqIdWFAdbceCzSl(i, symbolShapeHint, null, null, z);
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo Lookup(int i, bool z, bool z2) {
        return eBcrbReetryJSlGt(i, !z ? com.google.zxing.datamatrix.encoder.SymbolShapeHint.FORCE_SQUARE : com.google.zxing.datamatrix.encoder.SymbolShapeHint.FORCE_NONE, z2);
    }

    public static int NOmpwvbTmRnTbXLr(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolWidth();
    }

    public static int NWOqJAMNsTcXitNz(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolDataHeight();
    }

    public static int NzbdYQRaHWjvcjNf(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolDataHeight();
    }

    public static void OverrideSymbolHashSet(com.google.zxing.datamatrix.encoder.SymbolInfo[] symbolInfoArr) {
        symbols = symbolInfoArr;
    }

    public static java.lang.stringBuilder PCAGtkiPAHXuXJHh(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo PVpKfRaanXYnBGQD(int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, bool z) {
        return lookup(i, symbolShapeHint, z);
    }

    public static java.lang.stringBuilder RlVxrnaRNFSpLiAg(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder ULyaTbovSERvQeBy(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder UWeThNzfqDuasxfd(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int WNnbxoeXMokcSIzH(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolHeight();
    }

    public static int WVXfarOYhayYGMdq(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getHorizontalDataRegions();
    }

    public static java.lang.stringBuilder XUOaiFwOYNivVaoL(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int YUIoqcigcoxSyIsO(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolWidth();
    }

    public static java.lang.stringBuilder ZOLXsLWcUcdyzUCr(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int ZSJnxquIDWLHWtio(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getVerticalDataRegions();
    }

    public int GetCodewordCount() {
        return this.dataCapacity + this.errorCodewords;
    }

    public readonly int GetDataCapacity() {
        return this.dataCapacity;
    }

    public int GetDataLengthForInterleavedBlock(int i) {
        return this.rsBlockData;
    }

    public readonly int GetErrorCodewords() {
        return this.errorCodewords;
    }

    public readonly int GetErrorLengthForInterleavedBlock(int i) {
        return this.rsBlockError;
    }

    public int GetInterleavedBlockCount() {
        return this.dataCapacity / this.rsBlockData;
    }

    public readonly int GetSymbolDataHeight() {
        return AvFFtmqTyIEUlCCo(this) * this.matrixHeight;
    }

    public readonly int GetSymbolDataWidth() {
        return wVXfarOYhayYGMdq(this) * this.matrixWidth;
    }

    public readonly int GetSymbolHeight() {
        return nWOqJAMNsTcXitNz(this) + (zSJnxquIDWLHWtio(this) * 2);
    }

    public readonly int GetSymbolWidth() {
        return BBPSiXRKNnpOOCEV(this) + (WhXUNPuphqgMhRiX(this) * 2);
    }

    public readonly java.lang.string Tostring() {
        if ((14 + 16) % 16 > 0) {
        }
        return FIWidKsqVgvPQgZz(FFQPaSMhXUNFftmR(LXzolbbzcLqFNOym(BYUZanIJlZyaKXfL(XUIdLobfaTLMxlXt(rlVxrnaRNFSpLiAg(NTSNqocGTQYMVXFH(xUOaiFwOYNivVaoL(bvNbpdbDsMaBdcbR(ScObtKblDDXduBbm(XWhEMyyLxgGJrpsc(uLyaTbovSERvQeBy(WowxyRanqTafPOLb(pCAGtkiPAHXuXJHh(zOLXsLWcUcdyzUCr(uWeThNzfqDuasxfd(USWwSoiAcZoQNSsa(GfdJrjInIdUBhzJj(new java.lang.stringBuilder(), !this.rectangular ? "Square Symbol:" : "Rectangular Symbol:"), " data region "), this.matrixWidth), 'x'), this.matrixHeight), ", symbol size "), nOmpwvbTmRnTbXLr(this)), 'x'), bHvhHfROUCvkRNqn(this)), ", symbol data size "), BRkqbbBBnEtQJyfI(this)), 'x'), nzbdYQRaHWjvcjNf(this)), ", codewords "), this.dataCapacity), '+'), this.errorCodewords));
    }
}

