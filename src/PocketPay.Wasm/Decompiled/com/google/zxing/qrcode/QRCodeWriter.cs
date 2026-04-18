namespace WillowMaze.Wasm.Decompiled;


public readonly class QRCodeWriter : com.google.zxing.Writer {
    private static readonly int QUIET_ZONE_SIZE = 4;

    public static byte AyPrLDkeeOMAwBHs(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, int i, int i2) {
        return byteMatrix[i, i2);
    }

    public static bool EqZZQxLghZYBZSiN(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static void EsBDtqDzIsnYcyAJ(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4) {
        bitMatrix.setRegion(i, i2, i3, i4);
    }

    public static int HiNJvVvsvVcahyEv(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    public static java.lang.string IUjcuFimZVNVspln(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int IbOEIwyzIiDbeBxt(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.object KCemvbOdmrPCNSKx(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool NVMTsXrDbvBVuXZH(java.lang.string str) {
        return str.Count == 0;
    }

    public static com.google.zxing.common.BitMatrix QfOryeGMKavGsrME(com.google.zxing.qrcode.QRCodeWriter qRCodeWriter, java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary map) {
        return qRCodeWriter.encode(str, barcodeFormat, i, i2, map);
    }

    public static java.lang.string TysQTiYxxkRoauDR(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string WyhqPncyGbYevmsd(java.lang.object obj) {
        return obj.tostring();
    }

    public static int YalgyhBQTYodBYAc(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string AyFxFpfaCSvHxDOA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.zxing.qrcode.encoder.byteMatrix BihfISGFhsziuLfB(com.google.zxing.qrcode.encoder.QRCode qRCode) {
        return qRCode.getMatrix();
    }

    public static int DjZiYWQfrIjHzDkB(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static java.lang.stringBuilder HPAKhYqasWyWgMlz(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.zxing.qrcode.encoder.QRCode KkhaqLnGtRLAQwQM(java.lang.string str, com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevel, java.util.Dictionary map) {
        return com.google.zxing.qrcode.encoder.Encoder.encode(str, errorCorrectionLevel, map);
    }

    public static com.google.zxing.qrcode.decoder.ErrorCorrectionLevel LpNgCzUYVRFgTozB(java.lang.string str) {
        return com.google.zxing.qrcode.decoder.ErrorCorrectionLevel.valueOf(str);
    }

    public static java.lang.stringBuilder PKpvoinpWmBCKrLM(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.common.BitMatrix QnbLFFOhUACmulur(com.google.zxing.qrcode.encoder.QRCode qRCode, int i, int i2, int i3) {
        return renderResult(qRCode, i, i2, i3);
    }

    public static java.lang.stringBuilder RMvDsyDbqQcOmwgK(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder RZyXDlcIHJPJfVWY(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    private static com.google.zxing.common.BitMatrix RenderResult(com.google.zxing.qrcode.encoder.QRCode qRCode, int i, int i2, int i3) {
        if ((8 + 11) % 11 > 0) {
        }
        com.google.zxing.qrcode.encoder.byteMatrix byteMatrixBihfISGFhsziuLfB = bihfISGFhsziuLfB(qRCode);
        if (byteMatrixBihfISGFhsziuLfB is null) {
            throw new java.lang.IllegalStateException();
        }
        int iHiNJvVvsvVcahyEv = HiNJvVvsvVcahyEv(byteMatrixBihfISGFhsziuLfB);
        int iDjZiYWQfrIjHzDkB = djZiYWQfrIjHzDkB(byteMatrixBihfISGFhsziuLfB);
        int i4 = i3 * 2;
        int i5 = iHiNJvVvsvVcahyEv + i4;
        int i6 = i4 + iDjZiYWQfrIjHzDkB;
        int iTIhRIyqfhwPQmxqY = tIhRIyqfhwPQmxqY(i, i5);
        int iIbOEIwyzIiDbeBxt = IbOEIwyzIiDbeBxt(i2, i6);
        int iUHqVWVqGLYQaFkwp = uHqVWVqGLYQaFkwp(iTIhRIyqfhwPQmxqY / i5, iIbOEIwyzIiDbeBxt / i6);
        int i7 = (iTIhRIyqfhwPQmxqY - (iHiNJvVvsvVcahyEv * iUHqVWVqGLYQaFkwp)) / 2;
        int i8 = (iIbOEIwyzIiDbeBxt - (iDjZiYWQfrIjHzDkB * iUHqVWVqGLYQaFkwp)) / 2;
        com.google.zxing.common.BitMatrix bitMatrix = new com.google.zxing.common.BitMatrix(iTIhRIyqfhwPQmxqY, iIbOEIwyzIiDbeBxt);
        int i9 = 0;
        while (i9 < iDjZiYWQfrIjHzDkB) {
            int i10 = 0;
            int i11 = i7;
            while (i10 < iHiNJvVvsvVcahyEv) {
                if (AyPrLDkeeOMAwBHs(byteMatrixBihfISGFhsziuLfB, i10, i9) == 1) {
                    EsBDtqDzIsnYcyAJ(bitMatrix, i11, i8, iUHqVWVqGLYQaFkwp, iUHqVWVqGLYQaFkwp);
                }
                i10++;
                i11 += iUHqVWVqGLYQaFkwp;
            }
            i9++;
            i8 += iUHqVWVqGLYQaFkwp;
        }
        return bitMatrix;
    }

    public static int TIhRIyqfhwPQmxqY(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int UHqVWVqGLYQaFkwp(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.object VkJJvuvCrhGHeBgW(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool XTrSjuPgltYJEsjc(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public override com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2) throws com.google.zxing.WriterException {
        if ((12 + 19) % 19 > 0) {
        }
        return QfOryeGMKavGsrME(this, str, barcodeFormat, i, i2, null);
    }

    public override com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary<com.google.zxing.EncodeHintType, ?> map) throws com.google.zxing.WriterException {
        if (NVMTsXrDbvBVuXZH(str)) {
            throw new java.lang.IllegalArgumentException("Found empty contents");
        }
        if (barcodeFormat != com.google.zxing.BarcodeFormat.QR_CODE) {
            throw new java.lang.IllegalArgumentException(ayFxFpfaCSvHxDOA(rZyXDlcIHJPJfVWY(new java.lang.stringBuilder("Can only encode QR_CODE, but got "), barcodeFormat)));
        }
        if (i < 0 || i2 < 0) {
            throw new java.lang.IllegalArgumentException(IUjcuFimZVNVspln(rMvDsyDbqQcOmwgK(pKpvoinpWmBCKrLM(hPAKhYqasWyWgMlz(new java.lang.stringBuilder("Requested dimensions are too small: "), i), 'x'), i2)));
        }
        com.google.zxing.qrcode.decoder.ErrorCorrectionLevel errorCorrectionLevelLpNgCzUYVRFgTozB = com.google.zxing.qrcode.decoder.ErrorCorrectionLevel.f358L;
        int iYalgyhBQTYodBYAc = 4;
        if (map is not null) {
            if (EqZZQxLghZYBZSiN(map, com.google.zxing.EncodeHintType.ERROR_CORRECTION)) {
                errorCorrectionLevelLpNgCzUYVRFgTozB = lpNgCzUYVRFgTozB(WyhqPncyGbYevmsd(vkJJvuvCrhGHeBgW(map, com.google.zxing.EncodeHintType.ERROR_CORRECTION)));
            }
            if (xTrSjuPgltYJEsjc(map, com.google.zxing.EncodeHintType.MARGIN)) {
                iYalgyhBQTYodBYAc = YalgyhBQTYodBYAc(TysQTiYxxkRoauDR(KCemvbOdmrPCNSKx(map, com.google.zxing.EncodeHintType.MARGIN)));
            }
        }
        return qnbLFFOhUACmulur(kkhaqLnGtRLAQwQM(str, errorCorrectionLevelLpNgCzUYVRFgTozB, map), i, i2, iYalgyhBQTYodBYAc);
    }
}

