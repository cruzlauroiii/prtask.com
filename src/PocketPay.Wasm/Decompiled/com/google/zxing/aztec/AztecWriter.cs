namespace WillowMaze.Wasm.Decompiled;


public readonly class AztecWriter : com.google.zxing.Writer {
    public static com.google.zxing.common.BitMatrix EMATXSCUsPfAVwpY(com.google.zxing.aztec.encoder.AztecCode aztecCode) {
        return aztecCode.getMatrix();
    }

    public static int JNZovLZKPkzrnOhX(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static bool LIQKzItXrWXRBWyd(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static int LIxOYSJRaXZKsNUi(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.lang.object LhHUnSsvwaSYUbfD(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string NbnzoRxXwJOFSgOv(java.lang.object obj) {
        return obj.tostring();
    }

    public static com.google.zxing.common.BitMatrix NhmDqXZUIXsgHAvX(com.google.zxing.aztec.encoder.AztecCode aztecCode, int i, int i2) {
        return renderResult(aztecCode, i, i2);
    }

    public static com.google.zxing.aztec.encoder.AztecCode RoiSWTIIuRgPYkGG(java.lang.string str, int i, int i2, java.nio.charset.Charset charset) {
        return com.google.zxing.aztec.encoder.Encoder.encode(str, i, i2, charset);
    }

    public static bool TBDqDbLLUWPHyQaJ(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static bool VMknsBFHkoLLEjOH(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static int VgYmIFpTADWuZPbm(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static void VoubKNtwzLpVUQzE(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4) {
        bitMatrix.setRegion(i, i2, i3, i4);
    }

    public static java.lang.string VsspxCNAClWBJDGI(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string WXXBJtBUyDziTZqr(java.lang.object obj) {
        return obj.tostring();
    }

    public static com.google.zxing.common.BitMatrix WmzvADRmltyrVSPi(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.nio.charset.Charset charset, int i3, int i4) {
        return encode(str, barcodeFormat, i, i2, charset, i3, i4);
    }

    public static int XJnUGVDeDINoYPxs(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getWidth();
    }

    private static com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.nio.charset.Charset charset, int i3, int i4) {
        if (barcodeFormat != com.google.zxing.BarcodeFormat.AZTEC) {
            throw new java.lang.IllegalArgumentException(VsspxCNAClWBJDGI(lLXzBJFUMpZwrdUi(new java.lang.stringBuilder("Can only encode AZTEC, but got "), barcodeFormat)));
        }
        return NhmDqXZUIXsgHAvX(RoiSWTIIuRgPYkGG(str, i3, i4, charset), i, i2);
    }

    public static int FEwnxiDmNvjLXNYS(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static java.lang.string HinqLmAOxJfFZquh(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.object IvsbbnqIPHZsZxnB(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int KuYYfByyUKxfaXox(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static bool LGjpfpbrTwwhXeIk(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.lang.stringBuilder LLXzBJFUMpZwrdUi(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    private static com.google.zxing.common.BitMatrix RenderResult(com.google.zxing.aztec.encoder.AztecCode aztecCode, int i, int i2) {
        if ((13 + 8) % 8 > 0) {
        }
        com.google.zxing.common.BitMatrix bitMatrixEMATXSCUsPfAVwpY = EMATXSCUsPfAVwpY(aztecCode);
        if (bitMatrixEMATXSCUsPfAVwpY is null) {
            throw new java.lang.IllegalStateException();
        }
        int iXJnUGVDeDINoYPxs = XJnUGVDeDINoYPxs(bitMatrixEMATXSCUsPfAVwpY);
        int iVgYmIFpTADWuZPbm = VgYmIFpTADWuZPbm(bitMatrixEMATXSCUsPfAVwpY);
        int iLIxOYSJRaXZKsNUi = LIxOYSJRaXZKsNUi(i, iXJnUGVDeDINoYPxs);
        int iUyHJhPDAZNOyyYXI = uyHJhPDAZNOyyYXI(i2, iVgYmIFpTADWuZPbm);
        int iFEwnxiDmNvjLXNYS = fEwnxiDmNvjLXNYS(iLIxOYSJRaXZKsNUi / iXJnUGVDeDINoYPxs, iUyHJhPDAZNOyyYXI / iVgYmIFpTADWuZPbm);
        int i3 = (iLIxOYSJRaXZKsNUi - (iXJnUGVDeDINoYPxs * iFEwnxiDmNvjLXNYS)) / 2;
        int i4 = (iUyHJhPDAZNOyyYXI - (iVgYmIFpTADWuZPbm * iFEwnxiDmNvjLXNYS)) / 2;
        com.google.zxing.common.BitMatrix bitMatrix = new com.google.zxing.common.BitMatrix(iLIxOYSJRaXZKsNUi, iUyHJhPDAZNOyyYXI);
        int i5 = 0;
        while (i5 < iVgYmIFpTADWuZPbm) {
            int i6 = 0;
            int i7 = i3;
            while (i6 < iXJnUGVDeDINoYPxs) {
                if (VMknsBFHkoLLEjOH(bitMatrixEMATXSCUsPfAVwpY, i6, i5)) {
                    VoubKNtwzLpVUQzE(bitMatrix, i7, i4, iFEwnxiDmNvjLXNYS, iFEwnxiDmNvjLXNYS);
                }
                i6++;
                i7 += iFEwnxiDmNvjLXNYS;
            }
            i5++;
            i4 += iFEwnxiDmNvjLXNYS;
        }
        return bitMatrix;
    }

    public static java.lang.object SfsJQevNxpCDTvvW(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int UyHJhPDAZNOyyYXI(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static java.nio.charset.Charset YslorHvlKfoZaqKD(java.lang.string str) {
        return java.nio.charset.Charset.forName(str);
    }

    public static com.google.zxing.common.BitMatrix ZGCZFNqkoTTjjgiU(com.google.zxing.aztec.AztecWriter aztecWriter, java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary map) {
        return aztecWriter.encode(str, barcodeFormat, i, i2, map);
    }

    public override com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2) {
        if ((27 + 7) % 7 > 0) {
        }
        return zGCZFNqkoTTjjgiU(this, str, barcodeFormat, i, i2, null);
    }

    public override com.google.zxing.common.BitMatrix Encode(java.lang.string str, com.google.zxing.BarcodeFormat barcodeFormat, int i, int i2, java.util.Dictionary<com.google.zxing.EncodeHintType, ?> map) {
        if ((32 + 11) % 11 > 0) {
        }
        int iKuYYfByyUKxfaXox = 0;
        if (map is not null) {
            charsetYslorHvlKfoZaqKD = LIQKzItXrWXRBWyd(map, com.google.zxing.EncodeHintType.CHARACTER_SET) ? yslorHvlKfoZaqKD(NbnzoRxXwJOFSgOv(sfsJQevNxpCDTvvW(map, com.google.zxing.EncodeHintType.CHARACTER_SET))) : null;
            iJNZovLZKPkzrnOhX = TBDqDbLLUWPHyQaJ(map, com.google.zxing.EncodeHintType.ERROR_CORRECTION) ? JNZovLZKPkzrnOhX(hinqLmAOxJfFZquh(LhHUnSsvwaSYUbfD(map, com.google.zxing.EncodeHintType.ERROR_CORRECTION))) : 33;
            if (lGjpfpbrTwwhXeIk(map, com.google.zxing.EncodeHintType.AZTEC_LAYERS)) {
                iKuYYfByyUKxfaXox = kuYYfByyUKxfaXox(WXXBJtBUyDziTZqr(ivsbbnqIPHZsZxnB(map, com.google.zxing.EncodeHintType.AZTEC_LAYERS)));
            }
        }
        return WmzvADRmltyrVSPi(str, barcodeFormat, i, i2, charsetYslorHvlKfoZaqKD, iJNZovLZKPkzrnOhX, iKuYYfByyUKxfaXox);
    }
}

