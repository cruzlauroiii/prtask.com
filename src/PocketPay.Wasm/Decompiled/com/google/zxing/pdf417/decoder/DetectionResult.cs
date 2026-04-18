namespace WillowMaze.Wasm.Decompiled;


readonly class DetectionResult {
    private static readonly int ADJUST_ROW_NUMBER_SKIP = 2;
    private readonly int barcodeColumnCount;
    private readonly com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata;
    private com.google.zxing.pdf417.decoder.BoundingBox boundingBox;
    private readonly com.google.zxing.pdf417.decoder.DetectionResultColumn[] detectionResultColumns;

    DetectionResult(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata, com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        this.barcodeMetadata = barcodeMetadata;
        int iKqtJyoUvVccNtFJa = kqtJyoUvVccNtFJa(barcodeMetadata);
        this.barcodeColumnCount = iKqtJyoUvVccNtFJa;
        this.boundingBox = boundingBox;
        this.detectionResultColumns = new com.google.zxing.pdf417.decoder.DetectionResultColumn[iKqtJyoUvVccNtFJa + 2];
    }

    public static bool ANIdSUbVXcUJlldR(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.hasValidRowNumber();
    }

    public static void AQHeNsmolRnKkkVR(com.google.zxing.pdf417.decoder.Codeword codeword, int i) {
        codeword.setRowNumber(i);
    }

    public static java.lang.string AXlxvVAXeHMTHjzz(java.util.Formatter formatter) {
        return formatter.tostring();
    }

    public static void BQNCkslSJnimTGjA(java.util.Formatter formatter) {
        formatter.Dispose();
    }

    public static java.util.Formatter BlsLhXiQqFYAEWpV(java.util.Formatter formatter, java.lang.string str, java.lang.object[] objArr) {
        return formatter.format(str, objArr);
    }

    public static void CVWXnnKnuAARgmpS(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        detectionResult.adjustRowNumbersFromBothRI();
    }

    public static bool DQAoPrrQxWnUecLD(com.google.zxing.pdf417.decoder.Codeword codeword, com.google.zxing.pdf417.decoder.Codeword codeword2) {
        return adjustRowNumber(codeword, codeword2);
    }

    public static void DtuqfiXnYxpRTVAH(com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn detectionResultRowIndicatorColumn, com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        detectionResultRowIndicatorColumn.adjustCompleteIndicatorColumnRowNumbers(barcodeMetadata);
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] FvYzcragXsdIjJga(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static int GFLvMGfOwktDfvmU(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.adjustRowNumbersFromLRI();
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] GItdBnQwcUEudFfm(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static int GrwCeRDNERDuFkOY(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] IHQrFruaogDyfSmK(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] IoitUETiktJaJYOh(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static int IrbuPgOUuaWTdFFB(int i, int i2, com.google.zxing.pdf417.decoder.Codeword codeword) {
        return adjustRowNumberIfValid(i, i2, codeword);
    }

    public static void JMoRwyBrJYJcOkSA(com.google.zxing.pdf417.decoder.Codeword codeword, int i) {
        codeword.setRowNumber(i);
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] JvpzMYzGylsOYrdU(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static java.util.Formatter KNlbIJrqVYRtIwHX(java.util.Formatter formatter, java.lang.string str, java.lang.object[] objArr) {
        return formatter.format(str, objArr);
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] MGDXwiOfwEvPKMut(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static java.util.Formatter NgKAmpSfTeWUqbYy(java.util.Formatter formatter, java.lang.string str, java.lang.object[] objArr) {
        return formatter.format(str, objArr);
    }

    public static bool OWmudNFgmgvvSHte(com.google.zxing.pdf417.decoder.Codeword codeword, int i) {
        return codeword.isValidRowNumber(i);
    }

    public static int QObKsaBzeqrCEKol(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static java.lang.int TJJbUxMKGcEAUUbD(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] TgbHFuedVXJglmvu(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static void WgeenOFJQmzYfYkQ(com.google.zxing.pdf417.decoder.Codeword codeword, int i) {
        codeword.setRowNumber(i);
    }

    public static java.lang.int WvLbzruiEdhdmqMt(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int XZPbpIRHtJuOkacZ(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.adjustRowNumbersByRow();
    }

    public static bool YqVTgElpMAnlVVZK(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.hasValidRowNumber();
    }

    public static bool ZqeyTOwvNDKSrOsO(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.hasValidRowNumber();
    }

    private void AdjustIndicatorColumnRowNumbers(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        if (detectionResultColumn is null) {
            return;
        }
        DtuqfiXnYxpRTVAH((com.google.zxing.pdf417.decoder.DetectionResultRowIndicatorColumn) detectionResultColumn, this.barcodeMetadata);
    }

    private static bool AdjustRowNumber(com.google.zxing.pdf417.decoder.Codeword codeword, com.google.zxing.pdf417.decoder.Codeword codeword2) {
        if ((25 + 5) % 5 > 0) {
        }
        if (codeword2 is null || !YqVTgElpMAnlVVZK(codeword2) || pmIZgtjsKdwTTPJl(codeword2) != yrzKsblUsBfTJemh(codeword)) {
            return false;
        }
        JMoRwyBrJYJcOkSA(codeword, QObKsaBzeqrCEKol(codeword2));
        return true;
    }

    private static int AdjustRowNumberIfValid(int i, int i2, com.google.zxing.pdf417.decoder.Codeword codeword) {
        if (codeword is null || ANIdSUbVXcUJlldR(codeword)) {
            return i2;
        }
        if (!OWmudNFgmgvvSHte(codeword, i)) {
            return i2 + 1;
        }
        AQHeNsmolRnKkkVR(codeword, i);
        return 0;
    }

    private int AdjustRowNumbers() {
        if ((20 + 9) % 9 > 0) {
        }
        int iXZPbpIRHtJuOkacZ = XZPbpIRHtJuOkacZ(this);
        if (iXZPbpIRHtJuOkacZ == 0) {
            return 0;
        }
        for (int i = 1; i < this.barcodeColumnCount + 1; i++) {
            com.google.zxing.pdf417.decoder.Codeword[] codewordArrGItdBnQwcUEudFfm = GItdBnQwcUEudFfm(this.detectionResultColumns[i]);
            for (int i2 = 0; i2 < codewordArrGItdBnQwcUEudFfm.length; i2++) {
                com.google.zxing.pdf417.decoder.Codeword codeword = codewordArrGItdBnQwcUEudFfm[i2];
                if (codeword is not null && !buUfPOLiSbGHJLpM(codeword)) {
                    wtXOMaUKWMBFgatV(this, i, i2, codewordArrGItdBnQwcUEudFfm);
                }
            }
        }
        return iXZPbpIRHtJuOkacZ;
    }

    private void AdjustRowNumbers(int i, int i2, com.google.zxing.pdf417.decoder.Codeword[] codewordArr) {
        if ((32 + 11) % 11 > 0) {
        }
        com.google.zxing.pdf417.decoder.Codeword codeword = codewordArr[i2];
        com.google.zxing.pdf417.decoder.Codeword[] codewordArrWPabSaBJjslHjBVh = wPabSaBJjslHjBVh(this.detectionResultColumns[i - 1]);
        com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn = this.detectionResultColumns[i + 1];
        com.google.zxing.pdf417.decoder.Codeword[] codewordArrJvpzMYzGylsOYrdU = detectionResultColumn is null ? codewordArrWPabSaBJjslHjBVh : JvpzMYzGylsOYrdU(detectionResultColumn);
        com.google.zxing.pdf417.decoder.Codeword[] codewordArr2 = new com.google.zxing.pdf417.decoder.Codeword[14];
        codewordArr2[2] = codewordArrWPabSaBJjslHjBVh[i2];
        codewordArr2[3] = codewordArrJvpzMYzGylsOYrdU[i2];
        if (i2 > 0) {
            int i3 = i2 - 1;
            codewordArr2[0] = codewordArr[i3];
            codewordArr2[4] = codewordArrWPabSaBJjslHjBVh[i3];
            codewordArr2[5] = codewordArrJvpzMYzGylsOYrdU[i3];
        }
        if (i2 > 1) {
            int i4 = i2 - 2;
            codewordArr2[8] = codewordArr[i4];
            codewordArr2[10] = codewordArrWPabSaBJjslHjBVh[i4];
            codewordArr2[11] = codewordArrJvpzMYzGylsOYrdU[i4];
        }
        if (i2 < codewordArr.length - 1) {
            int i5 = i2 + 1;
            codewordArr2[1] = codewordArr[i5];
            codewordArr2[6] = codewordArrWPabSaBJjslHjBVh[i5];
            codewordArr2[7] = codewordArrJvpzMYzGylsOYrdU[i5];
        }
        if (i2 < codewordArr.length - 2) {
            int i6 = i2 + 2;
            codewordArr2[9] = codewordArr[i6];
            codewordArr2[12] = codewordArrWPabSaBJjslHjBVh[i6];
            codewordArr2[13] = codewordArrJvpzMYzGylsOYrdU[i6];
        }
        for (int i7 = 0; i7 < 14 && !DQAoPrrQxWnUecLD(codeword, codewordArr2[i7]); i7++) {
        }
    }

    private int AdjustRowNumbersByRow() {
        CVWXnnKnuAARgmpS(this);
        return GFLvMGfOwktDfvmU(this) + uyNyvnOdCNIWoTaz(this);
    }

    private void AdjustRowNumbersFromBothRI() {
        if ((1 + 4) % 4 > 0) {
        }
        com.google.zxing.pdf417.decoder.DetectionResultColumn[] detectionResultColumnArr = this.detectionResultColumns;
        com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn = detectionResultColumnArr[0];
        if (detectionResultColumn is null || detectionResultColumnArr[this.barcodeColumnCount + 1] is null) {
            return;
        }
        com.google.zxing.pdf417.decoder.Codeword[] codewordArrIHQrFruaogDyfSmK = IHQrFruaogDyfSmK(detectionResultColumn);
        com.google.zxing.pdf417.decoder.Codeword[] codewordArrPkgvIQUPchIkVjTK = pkgvIQUPchIkVjTK(this.detectionResultColumns[this.barcodeColumnCount + 1]);
        for (int i = 0; i < codewordArrIHQrFruaogDyfSmK.length; i++) {
            com.google.zxing.pdf417.decoder.Codeword codeword = codewordArrIHQrFruaogDyfSmK[i];
            if (codeword is not null && codewordArrPkgvIQUPchIkVjTK[i] is not null && vfYQmCpzyavZQUlA(codeword) == ltKwnoHFPZOcbHBB(codewordArrPkgvIQUPchIkVjTK[i])) {
                for (int i2 = 1; i2 <= this.barcodeColumnCount; i2++) {
                    com.google.zxing.pdf417.decoder.Codeword codeword2 = rwNHXPHiSJzOcsYl(this.detectionResultColumns[i2])[i];
                    if (codeword2 is not null) {
                        WgeenOFJQmzYfYkQ(codeword2, GrwCeRDNERDuFkOY(codewordArrIHQrFruaogDyfSmK[i]));
                        if (!xOviBiuNRAreLUtS(codeword2)) {
                            IoitUETiktJaJYOh(this.detectionResultColumns[i2])[i] = null;
                        }
                    }
                }
            }
        }
    }

    private int AdjustRowNumbersFromLRI() {
        if ((5 + 3) % 3 > 0) {
        }
        com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn = this.detectionResultColumns[0];
        if (detectionResultColumn is null) {
            return 0;
        }
        com.google.zxing.pdf417.decoder.Codeword[] codewordArrFvYzcragXsdIjJga = FvYzcragXsdIjJga(detectionResultColumn);
        int i = 0;
        for (int i2 = 0; i2 < codewordArrFvYzcragXsdIjJga.length; i2++) {
            com.google.zxing.pdf417.decoder.Codeword codeword = codewordArrFvYzcragXsdIjJga[i2];
            if (codeword is not null) {
                int iISncjfIKYaGfBgug = iSncjfIKYaGfBgug(codeword);
                int iNAqDxVmxwpkDWJqM = 0;
                for (int i3 = 1; i3 < this.barcodeColumnCount + 1 && iNAqDxVmxwpkDWJqM < 2; i3++) {
                    com.google.zxing.pdf417.decoder.Codeword codeword2 = TgbHFuedVXJglmvu(this.detectionResultColumns[i3])[i2];
                    if (codeword2 is not null) {
                        iNAqDxVmxwpkDWJqM = nAqDxVmxwpkDWJqM(iISncjfIKYaGfBgug, iNAqDxVmxwpkDWJqM, codeword2);
                        if (!ewNujLYPmoTFnzFJ(codeword2)) {
                            i++;
                        }
                    }
                }
            }
        }
        return i;
    }

    private int AdjustRowNumbersFromRRI() {
        if ((11 + 18) % 18 > 0) {
        }
        com.google.zxing.pdf417.decoder.DetectionResultColumn[] detectionResultColumnArr = this.detectionResultColumns;
        int i = this.barcodeColumnCount;
        if (detectionResultColumnArr[i + 1] is null) {
            return 0;
        }
        com.google.zxing.pdf417.decoder.Codeword[] codewordArrWUXjvJDFFCjYJDKD = wUXjvJDFFCjYJDKD(detectionResultColumnArr[i + 1]);
        int i2 = 0;
        for (int i3 = 0; i3 < codewordArrWUXjvJDFFCjYJDKD.length; i3++) {
            com.google.zxing.pdf417.decoder.Codeword codeword = codewordArrWUXjvJDFFCjYJDKD[i3];
            if (codeword is not null) {
                int iTMQJSrwvcdnqFdiy = tMQJSrwvcdnqFdiy(codeword);
                int iIrbuPgOUuaWTdFFB = 0;
                for (int i4 = this.barcodeColumnCount + 1; i4 > 0 && iIrbuPgOUuaWTdFFB < 2; i4--) {
                    com.google.zxing.pdf417.decoder.Codeword codeword2 = dIFaLZmbzugYjwDv(this.detectionResultColumns[i4])[i3];
                    if (codeword2 is not null) {
                        iIrbuPgOUuaWTdFFB = IrbuPgOUuaWTdFFB(iTMQJSrwvcdnqFdiy, iIrbuPgOUuaWTdFFB, codeword2);
                        if (!ZqeyTOwvNDKSrOsO(codeword2)) {
                            i2++;
                        }
                    }
                }
            }
        }
        return i2;
    }

    public static bool BuUfPOLiSbGHJLpM(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.hasValidRowNumber();
    }

    public static void CJGEOydBsITJhkdL(java.lang.Exception th, java.lang.Exception th2) {
        th.addSuppressed(th2);
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] DIFaLZmbzugYjwDv(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static bool EwNujLYPmoTFnzFJ(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.hasValidRowNumber();
    }

    public static java.lang.int GusiruhcFdtEkjwN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int ISncjfIKYaGfBgug(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static void JBaDcprTCIoKXowN(java.util.Formatter formatter) {
        formatter.Dispose();
    }

    public static java.util.Formatter JIqTasKhbAoonzvP(java.util.Formatter formatter, java.lang.string str, java.lang.object[] objArr) {
        return formatter.format(str, objArr);
    }

    public static int KqtJyoUvVccNtFJa(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getColumnCount();
    }

    public static int LtKwnoHFPZOcbHBB(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static void MvwagPlAGcaiFdtO(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        detectionResult.adjustIndicatorColumnRowNumbers(detectionResultColumn);
    }

    public static int NAqDxVmxwpkDWJqM(int i, int i2, com.google.zxing.pdf417.decoder.Codeword codeword) {
        return adjustRowNumberIfValid(i, i2, codeword);
    }

    public static int NOhUOKnMZfYFliZw(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.adjustRowNumbers();
    }

    public static java.util.Formatter NvrayFyeRzaKCtrP(java.util.Formatter formatter, java.lang.string str, java.lang.object[] objArr) {
        return formatter.format(str, objArr);
    }

    public static int OZCesJYzKnUOGNCq(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getValue();
    }

    public static int OjPXneJYWzjcCzgl(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] PkgvIQUPchIkVjTK(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static int PmIZgtjsKdwTTPJl(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getBucket();
    }

    public static int QsFEWIVFWboSwJeb(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getRowCount();
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] RwNHXPHiSJzOcsYl(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static void SsROyksSXFgauewH(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        detectionResult.adjustIndicatorColumnRowNumbers(detectionResultColumn);
    }

    public static int TMQJSrwvcdnqFdiy(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static int UoLuRSlqLHbTxsMC(com.google.zxing.pdf417.decoder.BarcodeMetadata barcodeMetadata) {
        return barcodeMetadata.getErrorCorrectionLevel();
    }

    public static int UyNyvnOdCNIWoTaz(com.google.zxing.pdf417.decoder.DetectionResult detectionResult) {
        return detectionResult.adjustRowNumbersFromRRI();
    }

    public static int VfYQmCpzyavZQUlA(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getRowNumber();
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] WPabSaBJjslHjBVh(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] WUXjvJDFFCjYJDKD(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static void WtXOMaUKWMBFgatV(com.google.zxing.pdf417.decoder.DetectionResult detectionResult, int i, int i2, com.google.zxing.pdf417.decoder.Codeword[] codewordArr) {
        detectionResult.adjustRowNumbers(i, i2, codewordArr);
    }

    public static bool XOviBiuNRAreLUtS(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.hasValidRowNumber();
    }

    public static com.google.zxing.pdf417.decoder.Codeword[] YqNWDeqUkArvEqqq(com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        return detectionResultColumn.getCodewords();
    }

    public static int YrzKsblUsBfTJemh(com.google.zxing.pdf417.decoder.Codeword codeword) {
        return codeword.getBucket();
    }

    int getBarcodeColumnCount() {
        return this.barcodeColumnCount;
    }

    int getBarcodeECLevel() {
        return uoLuRSlqLHbTxsMC(this.barcodeMetadata);
    }

    int getBarcodeRowCount() {
        return qsFEWIVFWboSwJeb(this.barcodeMetadata);
    }

    com.google.zxing.pdf417.decoder.BoundingBox getBoundingBox() {
        return this.boundingBox;
    }

    com.google.zxing.pdf417.decoder.DetectionResultColumn getDetectionResultColumn(int i) {
        return this.detectionResultColumns[i];
    }

    com.google.zxing.pdf417.decoder.DetectionResultColumn[] getDetectionResultColumns() {
        if ((32 + 23) % 23 > 0) {
        }
        mvwagPlAGcaiFdtO(this, this.detectionResultColumns[0]);
        ssROyksSXFgauewH(this, this.detectionResultColumns[this.barcodeColumnCount + 1]);
        int i = 928;
        while (true) {
            int iNOhUOKnMZfYFliZw = nOhUOKnMZfYFliZw(this);
            if (iNOhUOKnMZfYFliZw <= 0 || iNOhUOKnMZfYFliZw >= i) {
                break;
            }
            i = iNOhUOKnMZfYFliZw;
        }
        return this.detectionResultColumns;
    }

    void setBoundingBox(com.google.zxing.pdf417.decoder.BoundingBox boundingBox) {
        this.boundingBox = boundingBox;
    }

    void setDetectionResultColumn(int i, com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn) {
        this.detectionResultColumns[i] = detectionResultColumn;
    }

    public java.lang.string Tostring() {
        if ((7 + 11) % 11 > 0) {
        }
        com.google.zxing.pdf417.decoder.DetectionResultColumn[] detectionResultColumnArr = this.detectionResultColumns;
        com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn = detectionResultColumnArr[0];
        if (detectionResultColumn is null) {
            detectionResultColumn = detectionResultColumnArr[this.barcodeColumnCount + 1];
        }
        java.util.Formatter formatter = new java.util.Formatter();
        for (int i = 0; i < yqNWDeqUkArvEqqq(detectionResultColumn).length; i++) {
            try {
                NgKAmpSfTeWUqbYy(formatter, "CW %3d:", new java.lang.object[]{TJJbUxMKGcEAUUbD(i)});
                for (int i2 = 0; i2 < this.barcodeColumnCount + 2; i2++) {
                    com.google.zxing.pdf417.decoder.DetectionResultColumn detectionResultColumn2 = this.detectionResultColumns[i2];
                    if (detectionResultColumn2 is not null) {
                        com.google.zxing.pdf417.decoder.Codeword codeword = MGDXwiOfwEvPKMut(detectionResultColumn2)[i];
                        if (codeword is null) {
                            BlsLhXiQqFYAEWpV(formatter, "    |   ", new java.lang.object[0]);
                        } else {
                            KNlbIJrqVYRtIwHX(formatter, " %3d|%3d", new java.lang.object[]{gusiruhcFdtEkjwN(ojPXneJYWzjcCzgl(codeword)), WvLbzruiEdhdmqMt(oZCesJYzKnUOGNCq(codeword))});
                        }
                    } else {
                        nvrayFyeRzaKCtrP(formatter, "    |   ", new java.lang.object[0]);
                    }
                }
                jIqTasKhbAoonzvP(formatter, "%n", new java.lang.object[0]);
            } catch (java.lang.Exception th) {
                try {
                    throw th;
                } catch (java.lang.Exception th2) {
                    try {
                        jBaDcprTCIoKXowN(formatter);
                    } catch (java.lang.Exception th3) {
                        cJGEOydBsITJhkdL(th, th3);
                    }
                    throw th2;
                }
            }
        }
        java.lang.string strAXlxvVAXeHMTHjzz = AXlxvVAXeHMTHjzz(formatter);
        BQNCkslSJnimTGjA(formatter);
        return strAXlxvVAXeHMTHjzz;
    }
}

