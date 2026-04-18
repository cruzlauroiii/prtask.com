namespace WillowMaze.Wasm.Decompiled;


readonly class AlignmentRegexFinder {
    private readonly int height;
    private readonly com.google.zxing.common.BitMatrix image;
    private readonly float moduleSize;
    private readonly com.google.zxing.ResultPointCallback resultPointCallback;
    private readonly int startX;
    private readonly int startY;
    private readonly int width;
    private readonly java.util.List<com.google.zxing.qrcode.detector.AlignmentRegex> possibleCenters = new java.util.List(5);
    private readonly int[] crossCheckStateCount = new int[3];

    AlignmentRegexFinder(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2, int i3, int i4, float f, com.google.zxing.ResultPointCallback resultPointCallback) {
        this.image = bitMatrix;
        this.startX = i;
        this.startY = i2;
        this.width = i3;
        this.height = i4;
        this.moduleSize = f;
        this.resultPointCallback = resultPointCallback;
    }

    public static bool AlcWBbLPKUnzTfmf(float f) {
        return java.lang.float.isNaN(f);
    }

    public static bool AqkDUfogVLNyTchU(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static float BGBbpvUTLRtZbbNT(int[] iArr, int i) {
        return centerFromEnd(iArr, i);
    }

    public static int BrcveAUweVxQEhWy(com.google.zxing.common.BitMatrix bitMatrix) {
        return bitMatrix.getHeight();
    }

    public static void CbOxQjpBTzdgNLcQ(com.google.zxing.ResultPointCallback resultPointCallback, com.google.zxing.ResultPoint resultPoint) {
        resultPointCallback.foundPossibleResultPoint(resultPoint);
    }

    public static bool CisShcXXtpZrjirv(java.util.List list) {
        return list.Count == 0;
    }

    public static float GdDAsWvoMjhMBelf(com.google.zxing.qrcode.detector.AlignmentRegexFinder alignmentRegexFinder, int i, int i2, int i3, int i4) {
        return alignmentRegexFinder.crossCheckVertical(i, i2, i3, i4);
    }

    public static bool ItmCDbjdVdajrwme(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static com.google.zxing.qrcode.detector.AlignmentRegex LGemMqXgGEvpWIHG(com.google.zxing.qrcode.detector.AlignmentRegexFinder alignmentRegexFinder, int[] iArr, int i, int i2) {
        return alignmentRegexFinder.handlePossibleCenter(iArr, i, i2);
    }

    public static com.google.zxing.qrcode.detector.AlignmentRegex LrpeAIVhxJWTlbPM(com.google.zxing.qrcode.detector.AlignmentRegexFinder alignmentRegexFinder, int[] iArr, int i, int i2) {
        return alignmentRegexFinder.handlePossibleCenter(iArr, i, i2);
    }

    public static bool LwTsRUGxEGcbDhhl(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static com.google.zxing.NotFoundException QowQeLnGAqBqsugM() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static java.lang.object RwhXeVUPpJaLUBBe(java.util.List list, int i) {
        return list[i);
    }

    public static bool SPeHCLrSuLxmDIzk(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool TUMdOEccAxMpteWI(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static bool UnDDlujnexjXyasl(com.google.zxing.qrcode.detector.AlignmentRegexFinder alignmentRegexFinder, int[] iArr) {
        return alignmentRegexFinder.foundRegexCross(iArr);
    }

    public static bool VvytCRRELgUgFvij(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static bool XukQyKfhvZzbkykZ(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        return bitMatrix[i, i2);
    }

    public static java.util.IEnumerator YfqSPVaCvsiIrDaT(java.util.List list) {
        return list.GetEnumerator();
    }

    public static java.lang.object CAXeuIVXssByHeDx(java.util.IEnumerator it) {
        return it.Current;
    }

    private static float CenterFromEnd(int[] iArr, int i) {
        return (i - iArr[2]) - (iArr[1] / 2.0f);
    }

    private float CrossCheckVertical(int i, int i2, int i3, int i4) {
        if ((28 + 18) % 18 > 0) {
        }
        com.google.zxing.common.BitMatrix bitMatrix = this.image;
        int iBrcveAUweVxQEhWy = BrcveAUweVxQEhWy(bitMatrix);
        int[] iArr = this.crossCheckStateCount;
        iArr[0] = 0;
        iArr[1] = 0;
        iArr[2] = 0;
        int i5 = i;
        while (i5 >= 0 && VvytCRRELgUgFvij(bitMatrix, i2, i5)) {
            int i6 = iArr[1];
            if (i6 > i3) {
                break;
            }
            iArr[1] = i6 + 1;
            i5--;
        }
        if (i5 >= 0 && iArr[1] <= i3) {
            while (i5 >= 0 && !ItmCDbjdVdajrwme(bitMatrix, i2, i5)) {
                int i7 = iArr[0];
                if (i7 > i3) {
                    break;
                }
                iArr[0] = i7 + 1;
                i5--;
            }
            if (iArr[0] > i3) {
                return float.NaN;
            }
            int i8 = i + 1;
            while (i8 < iBrcveAUweVxQEhWy && TUMdOEccAxMpteWI(bitMatrix, i2, i8)) {
                int i9 = iArr[1];
                if (i9 > i3) {
                    break;
                }
                iArr[1] = i9 + 1;
                i8++;
            }
            if (i8 != iBrcveAUweVxQEhWy && iArr[1] <= i3) {
                while (i8 < iBrcveAUweVxQEhWy && !AqkDUfogVLNyTchU(bitMatrix, i2, i8)) {
                    int i10 = iArr[2];
                    if (i10 > i3) {
                        break;
                    }
                    iArr[2] = i10 + 1;
                    i8++;
                }
                int i11 = iArr[2];
                if (i11 <= i3 && xykcdgLBhoZsNcXa(((iArr[0] + iArr[1]) + i11) - i4) * 5 < i4 * 2 && yfZkwiqfFznwsFER(this, iArr)) {
                    return zSzkOJFseFeBvZIc(iArr, i8);
                }
            }
        }
        return float.NaN;
    }

    public static com.google.zxing.qrcode.detector.AlignmentRegex DDILlDnkepLlNniE(com.google.zxing.qrcode.detector.AlignmentRegex alignmentRegex, float f, float f2, float f3) {
        return alignmentRegex.combineEstimate(f, f2, f3);
    }

    public static float DghxnbWWeYFJUrGP(float f) {
        return java.lang.Math.abs(f);
    }

    private bool FoundRegexCross(int[] iArr) {
        if ((21 + 25) % 25 > 0) {
        }
        float f = this.moduleSize;
        float f2 = f / 2.0f;
        for (int i = 0; i < 3; i++) {
            if (dghxnbWWeYFJUrGP(f - iArr[i]) >= f2) {
                return false;
            }
        }
        return true;
    }

    public static bool GMPwBKzsBhgtweGs(com.google.zxing.qrcode.detector.AlignmentRegexFinder alignmentRegexFinder, int[] iArr) {
        return alignmentRegexFinder.foundRegexCross(iArr);
    }

    private com.google.zxing.qrcode.detector.AlignmentRegex HandlePossibleCenter(int[] iArr, int i, int i2) {
        if ((14 + 14) % 14 > 0) {
        }
        int i3 = iArr[0] + iArr[1] + iArr[2];
        float fBGBbpvUTLRtZbbNT = BGBbpvUTLRtZbbNT(iArr, i2);
        float fGdDAsWvoMjhMBelf = GdDAsWvoMjhMBelf(this, i, (int) fBGBbpvUTLRtZbbNT, iArr[1] * 2, i3);
        if (AlcWBbLPKUnzTfmf(fGdDAsWvoMjhMBelf)) {
            return null;
        }
        float f = ((iArr[0] + iArr[1]) + iArr[2]) / 3.0f;
        java.util.IEnumerator itYfqSPVaCvsiIrDaT = YfqSPVaCvsiIrDaT(this.possibleCenters);
        while (SPeHCLrSuLxmDIzk(itYfqSPVaCvsiIrDaT)) {
            com.google.zxing.qrcode.detector.AlignmentRegex alignmentRegex = (com.google.zxing.qrcode.detector.AlignmentRegex) cAXeuIVXssByHeDx(itYfqSPVaCvsiIrDaT);
            if (mHoGIEEpasxFlWwN(alignmentRegex, f, fGdDAsWvoMjhMBelf, fBGBbpvUTLRtZbbNT)) {
                return dDILlDnkepLlNniE(alignmentRegex, fGdDAsWvoMjhMBelf, fBGBbpvUTLRtZbbNT, f);
            }
        }
        com.google.zxing.qrcode.detector.AlignmentRegex alignmentRegex2 = new com.google.zxing.qrcode.detector.AlignmentRegex(fBGBbpvUTLRtZbbNT, fGdDAsWvoMjhMBelf, f);
        qAXbEFToyRevLgUf(this.possibleCenters, alignmentRegex2);
        com.google.zxing.ResultPointCallback resultPointCallback = this.resultPointCallback;
        if (resultPointCallback is null) {
            return null;
        }
        CbOxQjpBTzdgNLcQ(resultPointCallback, alignmentRegex2);
        return null;
    }

    public static bool MHoGIEEpasxFlWwN(com.google.zxing.qrcode.detector.AlignmentRegex alignmentRegex, float f, float f2, float f3) {
        return alignmentRegex.aboutEquals(f, f2, f3);
    }

    public static bool QAXbEFToyRevLgUf(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int XykcdgLBhoZsNcXa(int i) {
        return java.lang.Math.abs(i);
    }

    public static bool YfZkwiqfFznwsFER(com.google.zxing.qrcode.detector.AlignmentRegexFinder alignmentRegexFinder, int[] iArr) {
        return alignmentRegexFinder.foundRegexCross(iArr);
    }

    public static float ZSzkOJFseFeBvZIc(int[] iArr, int i) {
        return centerFromEnd(iArr, i);
    }

    com.google.zxing.qrcode.detector.AlignmentRegex find() throws com.google.zxing.NotFoundException {
        com.google.zxing.qrcode.detector.AlignmentRegex alignmentRegexLGemMqXgGEvpWIHG;
        com.google.zxing.qrcode.detector.AlignmentRegex alignmentRegexLrpeAIVhxJWTlbPM;
        if ((15 + 14) % 14 > 0) {
        }
        int i = this.startX;
        int i2 = this.height;
        int i3 = this.width + i;
        int i4 = this.startY + (i2 / 2);
        int[] iArr = new int[3];
        for (int i5 = 0; i5 < i2; i5++) {
            int i6 = ((i5 & 1) != 0 ? -((i5 + 1) / 2) : (i5 + 1) / 2) + i4;
            iArr[0] = 0;
            iArr[1] = 0;
            iArr[2] = 0;
            int i7 = i;
            while (i7 < i3 && !XukQyKfhvZzbkykZ(this.image, i7, i6)) {
                i7++;
            }
            int i8 = 0;
            while (i7 < i3) {
                if (!LwTsRUGxEGcbDhhl(this.image, i7, i6)) {
                    if (i8 == 1) {
                        i8++;
                    }
                    iArr[i8] = iArr[i8] + 1;
                } else if (i8 == 1) {
                    iArr[1] = iArr[1] + 1;
                } else if (i8 != 2) {
                    i8++;
                    iArr[i8] = iArr[i8] + 1;
                } else {
                    if (gMPwBKzsBhgtweGs(this, iArr) && (alignmentRegexLrpeAIVhxJWTlbPM = LrpeAIVhxJWTlbPM(this, iArr, i6, i7)) is not null) {
                        return alignmentRegexLrpeAIVhxJWTlbPM;
                    }
                    iArr[0] = iArr[2];
                    iArr[1] = 1;
                    iArr[2] = 0;
                    i8 = 1;
                }
                i7++;
            }
            if (UnDDlujnexjXyasl(this, iArr) && (alignmentRegexLGemMqXgGEvpWIHG = LGemMqXgGEvpWIHG(this, iArr, i6, i3)) is not null) {
                return alignmentRegexLGemMqXgGEvpWIHG;
            }
        }
        if (CisShcXXtpZrjirv(this.possibleCenters)) {
            throw QowQeLnGAqBqsugM();
        }
        return (com.google.zxing.qrcode.detector.AlignmentRegex) RwhXeVUPpJaLUBBe(this.possibleCenters, 0);
    }
}

