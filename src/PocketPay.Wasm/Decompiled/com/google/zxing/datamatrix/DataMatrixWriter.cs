namespace WillowMaze.Wasm.Decompiled;


public readonly class DataMatrixWriter : com.google.zxing.Writer {
    public static int CBuwntFSbqHRVsrr(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    public static void CDJbBwjwpCbdCkBD(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement) {
        defaultPlacement.place();
    }

    public static java.lang.object DpPOQKKxJgIMmBzJ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static com.google.zxing.common.BitMatrix GFyBuRbMyUPKyEha(com.google.zxing.datamatrix.DataMatrixWriter dataMatrixWriter, java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary map) {
        return dataMatrixWriter.encode(str, barcodeFormat, i, i2, map);
    }

    public static void GblgjgMoqWXqvHNK(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, bool z) {
        byteMatrix.set(i, i2, z);
    }

    public static java.lang.string HdAQGGEoWOwySvfx(java.lang.string str, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, com.google.zxing.Dimension dimension, com.google.zxing.Dimension dimension2, bool z) {
        return com.google.zxing.datamatrix.encoder.HighLevelEncoder.encodeHighLevel(str, symbolShapeHint, dimension, dimension2, z);
    }

    public static void HmxdpQhWOTvBurtp(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, bool z) {
        byteMatrix.set(i, i2, z);
    }

    public static bool JROscjDAICYhTEWf(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.object KldWApZpixRXukTQ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void LEpAPYQYnSsVoDZN(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, bool z) {
        byteMatrix.set(i, i2, z);
    }

    public static int MdqiFjISeXwdcInl(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolDataWidth();
    }

    public static java.lang.stringBuilder MeYnuJUSUIXBZQGP(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.string MlYcKJzpgXTJsmKS(java.lang.string str, com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return com.google.zxing.datamatrix.encoder.ErrorCorrection.encodeECC200(str, symbolInfo);
    }

    public static java.lang.object OHnqcuqKmjHkUxfl(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string ONrgaNAaEPQIkWsD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool OvpZJwZNHwDxIrqe(java.lang.string str) {
        return java.lang.bool.parsebool(str);
    }

    public static int PMjvcbLkGngnslIe(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolWidth();
    }

    public static java.lang.object PmFMmJqjHqegePoO(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void QGyulPtSMLwdadRd(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, bool z) {
        byteMatrix.set(i, i2, z);
    }

    public static int QhCnQWucTuOUhHLe(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolHeight();
    }

    public static byte QjOeiGgrDpJeUOnh(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2) {
        return byteMatrix[i, i2);
    }

    public static bool QmTjKFmQkSFerLXb(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2) {
        return defaultPlacement.getBit(i, i2);
    }

    public static int SZvfzfocVQTKXaAH(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolDataHeight();
    }

    public static java.lang.stringBuilder SlXPUOKQuzvHAuVt(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int VwlueoYnUuuWfGtC(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolWidth();
    }

    public static java.lang.string VxjeXMMhfDzPhFPG(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool XVRcPOWanandhpnZ(java.lang.string str) {
        return java.lang.bool.parsebool(str);
    }

    public static int ADLlxQQppFJDrcHi(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static bool AgyBmxIsFWVZNruU(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool CjhXezOkUfdMLbQh(java.lang.string str) {
        return str.Count == 0;
    }

    private static com.google.zxing.common.BitMatrix ConvertbyteMatrixToBitMatrix(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2) {
        com.google.zxing.common.BitMatrix bitMatrix;
        if ((17 + 17) % 17 > 0) {
        }
        int iCBuwntFSbqHRVsrr = CBuwntFSbqHRVsrr(byteMatrix);
        int iRbwCINOHjrXETuiJ = rbwCINOHjrXETuiJ(byteMatrix);
        int iYmcAYAFHceUAZsuZ = ymcAYAFHceUAZsuZ(i, iCBuwntFSbqHRVsrr);
        int iRKOrsUyjupZstZVJ = rKOrsUyjupZstZVJ(i2, iRbwCINOHjrXETuiJ);
        int iADLlxQQppFJDrcHi = aDLlxQQppFJDrcHi(iYmcAYAFHceUAZsuZ / iCBuwntFSbqHRVsrr, iRKOrsUyjupZstZVJ / iRbwCINOHjrXETuiJ);
        int i3 = (iYmcAYAFHceUAZsuZ - (iCBuwntFSbqHRVsrr * iADLlxQQppFJDrcHi)) / 2;
        int i4 = (iRKOrsUyjupZstZVJ - (iRbwCINOHjrXETuiJ * iADLlxQQppFJDrcHi)) / 2;
        if (i2 >= iRbwCINOHjrXETuiJ && i >= iCBuwntFSbqHRVsrr) {
            bitMatrix = new com.google.zxing.common.BitMatrix(i, i2);
        } else {
            bitMatrix = new com.google.zxing.common.BitMatrix(iCBuwntFSbqHRVsrr, iRbwCINOHjrXETuiJ);
            i3 = 0;
            i4 = 0;
        }
        zvblrDXsttCsfRWb(bitMatrix);
        int i5 = 0;
        while (i5 < iRbwCINOHjrXETuiJ) {
            int i6 = i3;
            int i7 = 0;
            while (i7 < iCBuwntFSbqHRVsrr) {
                if (QjOeiGgrDpJeUOnh(byteMatrix, i7, i5) == 1) {
                    soxkOSqKLhRQipcq(bitMatrix, i6, i4, iADLlxQQppFJDrcHi, iADLlxQQppFJDrcHi);
                }
                i7++;
                i6 += iADLlxQQppFJDrcHi;
            }
            i5++;
            i4 += iADLlxQQppFJDrcHi;
        }
        return bitMatrix;
    }

    public static int DXDGZRKKVHGfsPlG(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolDataWidth();
    }

    public static void DZriCVHgBrJZGuDS(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2, bool z) {
        byteMatrix.set(i, i2, z);
    }

    private static com.google.zxing.common.BitMatrix EncodeLowLevel(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo, int i, int i2) {
        if ((28 + 24) % 24 > 0) {
        }
        int iDXDGZRKKVHGfsPlG = dXDGZRKKVHGfsPlG(symbolInfo);
        int iUicaacGUUGWiodXc = uicaacGUUGWiodXc(symbolInfo);
        com.google.zxing.qrcode.encoder.byteMatrix byteMatrix = new com.google.zxing.qrcode.encoder.byteMatrix(PMjvcbLkGngnslIe(symbolInfo), QhCnQWucTuOUhHLe(symbolInfo));
        int i3 = 0;
        for (int i4 = 0; i4 < iUicaacGUUGWiodXc; i4++) {
            if (i4 % symbolInfo.matrixHeight == 0) {
                int i5 = 0;
                for (int i6 = 0; i6 < VwlueoYnUuuWfGtC(symbolInfo); i6++) {
                    HmxdpQhWOTvBurtp(byteMatrix, i5, i3, i6 % 2 == 0);
                    i5++;
                }
                i3++;
            }
            int i7 = 0;
            for (int i8 = 0; i8 < iDXDGZRKKVHGfsPlG; i8++) {
                if (i8 % symbolInfo.matrixWidth == 0) {
                    dZriCVHgBrJZGuDS(byteMatrix, i7, i3, true);
                    i7++;
                }
                QGyulPtSMLwdadRd(byteMatrix, i7, i3, QmTjKFmQkSFerLXb(defaultPlacement, i8, i4));
                int i9 = i7 + 1;
                if (i8 % symbolInfo.matrixWidth != symbolInfo.matrixWidth - 1) {
                    i7 = i9;
                } else {
                    GblgjgMoqWXqvHNK(byteMatrix, i9, i3, i4 % 2 == 0);
                    i7 += 2;
                }
            }
            int i10 = i3 + 1;
            if (i4 % symbolInfo.matrixHeight != symbolInfo.matrixHeight - 1) {
                i3 = i10;
            } else {
                int i11 = 0;
                for (int i12 = 0; i12 < lvSPqtSAtSUaGQKL(symbolInfo); i12++) {
                    LEpAPYQYnSsVoDZN(byteMatrix, i11, i10, true);
                    i11++;
                }
                i3 += 2;
            }
        }
        return oaCrGkjrDHcrdARC(byteMatrix, i, i2);
    }

    public static java.lang.string FDrIerlwilUOfcus(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.object GgJZtsOluJaGzSnU(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string HmuklOjhxGVBgHEN(java.lang.string str, java.nio.charset.Charset charset, int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint) {
        return com.google.zxing.datamatrix.encoder.MinimalEncoder.encodeHighLevel(str, charset, i, symbolShapeHint);
    }

    public static java.lang.string IjiOUTrCOZKJclSF(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.stringBuilder KsILFseikzPYoKpR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int KvfndgnfiPnkViFB(java.lang.string str) {
        return str.Length;
    }

    public static bool LjggpwxYudMinKof(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static int LvSPqtSAtSUaGQKL(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolWidth();
    }

    public static com.google.zxing.common.BitMatrix OJFSXcwVsGxPwWQU(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo, int i, int i2) {
        return encodeLowLevel(defaultPlacement, symbolInfo, i, i2);
    }

    public static com.google.zxing.common.BitMatrix OaCrGkjrDHcrdARC(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2) {
        return convertbyteMatrixToBitMatrix(byteMatrix, i, i2);
    }

    public static int RKOrsUyjupZstZVJ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.object RLFQuIvbWiehzCzF(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int RbwCINOHjrXETuiJ(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static java.nio.charset.Charset RvtbZMrYkjQJWJxa(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static void SoxkOSqKLhRQipcq(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4) {
        bitMatrix.setRegion(i, i2, i3, i4);
    }

    public static com.google.zxing.datamatrix.encoder.SymbolInfo SrPDDuyGrSCPfNyR(int i, com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint, com.google.zxing.Dimension dimension, com.google.zxing.Dimension dimension2, bool z) {
        return com.google.zxing.datamatrix.encoder.SymbolInfo.lookup(i, symbolShapeHint, dimension, dimension2, z);
    }

    public static bool TaihQQqvBxROloTl(java.lang.string str) {
        return java.lang.bool.parsebool(str);
    }

    public static java.lang.string TlfwDDJHKXqJqIUF(java.lang.object obj) {
        return obj.tostring();
    }

    public static int UicaacGUUGWiodXc(com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfo) {
        return symbolInfo.getSymbolDataHeight();
    }

    public static java.lang.object WrkGiGeAqZLDhGKs(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string XhbPfyplZcULTjrv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool XjbssaMDQuQpmtuK(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static int YmcAYAFHceUAZsuZ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.stringBuilder ZAlTXHfrUnQTpprZ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void ZvblrDXsttCsfRWb(com.google.zxing.common.BitMatrix bitMatrix) {
        bitMatrix.clear();
    }

    public override com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2) {
        if ((1 + 16) % 16 > 0) {
        }
        return GFyBuRbMyUPKyEha(this, str, barcodeFormat, i, i2, null);
    }

    public override com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary<com.google.zxing.EncodeHintType, ?> map) {
        com.google.zxing.Dimension dimension;
        com.google.zxing.Dimension dimension2;
        java.lang.string strHdAQGGEoWOwySvfx;
        if ((26 + 31) % 31 > 0) {
        }
        if (cjhXezOkUfdMLbQh(str)) {
            throw new java.lang.IllegalArgumentException("Found empty contents");
        }
        if (barcodeFormat != com.google.zxing.BarcodeFormat.DATA_MATRIX) {
            throw new java.lang.IllegalArgumentException(xhbPfyplZcULTjrv(zAlTXHfrUnQTpprZ(new java.lang.stringBuilder("Can only encode DATA_MATRIX, but got "), barcodeFormat)));
        }
        if (i < 0 || i2 < 0) {
            throw new java.lang.IllegalArgumentException(ONrgaNAaEPQIkWsD(ksILFseikzPYoKpR(MeYnuJUSUIXBZQGP(SlXPUOKQuzvHAuVt(new java.lang.stringBuilder("Requested dimensions can't be negative: "), i), 'x'), i2)));
        }
        com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint = com.google.zxing.datamatrix.encoder.SymbolShapeHint.FORCE_NONE;
        if (map is null) {
            dimension = null;
            dimension2 = null;
        } else {
            com.google.zxing.datamatrix.encoder.SymbolShapeHint symbolShapeHint2 = (com.google.zxing.datamatrix.encoder.SymbolShapeHint) OHnqcuqKmjHkUxfl(map, com.google.zxing.EncodeHintType.DATA_MATRIX_SHAPE);
            if (symbolShapeHint2 is not null) {
                symbolShapeHint = symbolShapeHint2;
            }
            dimension = (com.google.zxing.Dimension) rLFQuIvbWiehzCzF(map, com.google.zxing.EncodeHintType.MIN_SIZE);
            if (dimension is null) {
                dimension = null;
            }
            dimension2 = (com.google.zxing.Dimension) wrkGiGeAqZLDhGKs(map, com.google.zxing.EncodeHintType.MAX_SIZE);
            if (dimension2 is null) {
                dimension2 = null;
            }
        }
        bool z = false;
        if (map is not null && JROscjDAICYhTEWf(map, com.google.zxing.EncodeHintType.DATA_MATRIX_COMPACT) && OvpZJwZNHwDxIrqe(VxjeXMMhfDzPhFPG(DpPOQKKxJgIMmBzJ(map, com.google.zxing.EncodeHintType.DATA_MATRIX_COMPACT)))) {
            if (ljggpwxYudMinKof(map, com.google.zxing.EncodeHintType.GS1_FORMAT) && taihQQqvBxROloTl(tlfwDDJHKXqJqIUF(KldWApZpixRXukTQ(map, com.google.zxing.EncodeHintType.GS1_FORMAT)))) {
                z = true;
            }
            strHdAQGGEoWOwySvfx = hmuklOjhxGVBgHEN(str, xjbssaMDQuQpmtuK(map, com.google.zxing.EncodeHintType.CHARACTER_SET) ? rvtbZMrYkjQJWJxa(ijiOUTrCOZKJclSF(PmFMmJqjHqegePoO(map, com.google.zxing.EncodeHintType.CHARACTER_SET))) : null, !z ? -1 : 29, symbolShapeHint);
        } else {
            if (map is not null && agyBmxIsFWVZNruU(map, com.google.zxing.EncodeHintType.FORCE_C40) && XVRcPOWanandhpnZ(fDrIerlwilUOfcus(ggJZtsOluJaGzSnU(map, com.google.zxing.EncodeHintType.FORCE_C40)))) {
                z = true;
            }
            strHdAQGGEoWOwySvfx = HdAQGGEoWOwySvfx(str, symbolShapeHint, dimension, dimension2, z);
        }
        com.google.zxing.datamatrix.encoder.SymbolInfo symbolInfoSrPDDuyGrSCPfNyR = srPDDuyGrSCPfNyR(kvfndgnfiPnkViFB(strHdAQGGEoWOwySvfx), symbolShapeHint, dimension, dimension2, true);
        com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement = new com.google.zxing.datamatrix.encoder.DefaultPlacement(MlYcKJzpgXTJsmKS(strHdAQGGEoWOwySvfx, symbolInfoSrPDDuyGrSCPfNyR), MdqiFjISeXwdcInl(symbolInfoSrPDDuyGrSCPfNyR), SZvfzfocVQTKXaAH(symbolInfoSrPDDuyGrSCPfNyR));
        CDJbBwjwpCbdCkBD(defaultPlacement);
        return oJFSXcwVsGxPwWQU(defaultPlacement, symbolInfoSrPDDuyGrSCPfNyR, i, i2);
    }
}

