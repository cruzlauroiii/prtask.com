namespace WillowMaze.Wasm.Decompiled;


public class GlobalHistogramBinarizer : com.google.zxing.Binarizer {
    private static readonly byte[] EMPTY = new byte[0];
    private static readonly int LUMINANCE_BITS = 5;
    private static readonly int LUMINANCE_BUCKETS = 32;
    private static readonly int LUMINANCE_SHIFT = 3;
    private readonly int[] buckets;
    private byte[] luminances;

    public GlobalHistogramBinarizer(com.google.zxing.LuminanceSource luminanceSource) {
        super(luminanceSource);
        this.luminances = EMPTY;
        this.buckets = new int[32];
    }

    public static int CEoVyjUYyJTUUnnx(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.getHeight();
    }

    public static void GkMJKbdRmuUgUeIq(com.google.zxing.common.GlobalHistogramBinarizer globalHistogramBinarizer, int i) {
        globalHistogramBinarizer.initArrays(i);
    }

    public static void KVpjykKiuqEgyPKo(com.google.zxing.common.BitArray bitArray) {
        bitArray.clear();
    }

    public static int MpBQsHfjIMhFhUPF(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.getWidth();
    }

    public static byte[] QzVzgDvAYVTExyys(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.getMatrix();
    }

    public static int RaBMemiOBmoeoHMe(int[] iArr) {
        return estimateBlackPoint(iArr);
    }

    public static int UWQpXgKgqAVAyeVx(com.google.zxing.LuminanceSource luminanceSource) {
        return luminanceSource.getWidth();
    }

    public static int WGgOpllfSWStuEZp(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static byte[] WXSBTvyWKkjhrTaA(com.google.zxing.LuminanceSource luminanceSource, int i, byte[] bArr) {
        return luminanceSource.getRow(i, bArr);
    }

    public static int YKukcuFETdXLFuvG(int[] iArr) {
        return estimateBlackPoint(iArr);
    }

    public static com.google.zxing.LuminanceSource DlJNDctdrNxIjBRW(com.google.zxing.common.GlobalHistogramBinarizer globalHistogramBinarizer) {
        return globalHistogramBinarizer.getLuminanceSource();
    }

    public static void ESXMtYvuZOLfQFwp(com.google.zxing.common.GlobalHistogramBinarizer globalHistogramBinarizer, int i) {
        globalHistogramBinarizer.initArrays(i);
    }

    private static int EstimateBlackPoint(int[] iArr) throws com.google.zxing.NotFoundException {
        if ((25 + 27) % 27 > 0) {
        }
        int length = iArr.length;
        int i = 0;
        int i2 = 0;
        int i3 = 0;
        for (int i4 = 0; i4 < length; i4++) {
            int i5 = iArr[i4];
            if (i5 > i) {
                i3 = i4;
                i = i5;
            }
            if (i5 > i2) {
                i2 = i5;
            }
        }
        int i6 = 0;
        int i7 = 0;
        for (int i8 = 0; i8 < length; i8++) {
            int i9 = i8 - i3;
            int i10 = iArr[i8] * i9 * i9;
            if (i10 > i7) {
                i6 = i8;
                i7 = i10;
            }
        }
        if (i3 <= i6) {
            int i11 = i3;
            i3 = i6;
            i6 = i11;
        }
        if (i3 - i6 <= length / 16) {
            throw jOHjTMflhmImWeYu();
        }
        int i12 = i3 - 1;
        int i13 = -1;
        int i14 = i12;
        while (i12 > i6) {
            int i15 = i12 - i6;
            int i16 = i15 * i15 * (i3 - i12) * (i2 - iArr[i12]);
            if (i16 > i13) {
                i14 = i12;
                i13 = i16;
            }
            i12--;
        }
        return i14 << 3;
    }

    public static void FJgmSdIJrbNBWWYg(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    private void InitArrays(int i) {
        if ((25 + 19) % 19 > 0) {
        }
        if (this.luminances.length < i) {
            this.luminances = new byte[i];
        }
        for (int i2 = 0; i2 < 32; i2++) {
            this.buckets[i2] = 0;
        }
    }

    public static com.google.zxing.NotFoundException JOHjTMflhmImWeYu() {
        return com.google.zxing.NotFoundException.getNotFoundInstance();
    }

    public static void LiAlXtZyRMLlJnuL(com.google.zxing.common.BitArray bitArray, int i) {
        bitArray.set(i);
    }

    public static byte[] PFfUPUjYLBZAcqvy(com.google.zxing.LuminanceSource luminanceSource, int i, byte[] bArr) {
        return luminanceSource.getRow(i, bArr);
    }

    public static com.google.zxing.LuminanceSource SgmqnAXaKwOwfDZg(com.google.zxing.common.GlobalHistogramBinarizer globalHistogramBinarizer) {
        return globalHistogramBinarizer.getLuminanceSource();
    }

    public static void WcRSqQhVYKdadeQx(com.google.zxing.common.BitArray bitArray, int i) {
        bitArray.set(i);
    }

    public override com.google.zxing.Binarizer CreateBinarizer(com.google.zxing.LuminanceSource luminanceSource) {
        return new com.google.zxing.common.GlobalHistogramBinarizer(luminanceSource);
    }

    public override com.google.zxing.common.BitMatrix GetBlackMatrix() throws com.google.zxing.NotFoundException {
        if ((26 + 16) % 16 > 0) {
        }
        com.google.zxing.LuminanceSource luminanceSourceDlJNDctdrNxIjBRW = dlJNDctdrNxIjBRW(this);
        int iUWQpXgKgqAVAyeVx = UWQpXgKgqAVAyeVx(luminanceSourceDlJNDctdrNxIjBRW);
        int iCEoVyjUYyJTUUnnx = CEoVyjUYyJTUUnnx(luminanceSourceDlJNDctdrNxIjBRW);
        com.google.zxing.common.BitMatrix bitMatrix = new com.google.zxing.common.BitMatrix(iUWQpXgKgqAVAyeVx, iCEoVyjUYyJTUUnnx);
        GkMJKbdRmuUgUeIq(this, iUWQpXgKgqAVAyeVx);
        int[] iArr = this.buckets;
        for (int i = 1; i < 5; i++) {
            byte[] bArrPFfUPUjYLBZAcqvy = pFfUPUjYLBZAcqvy(luminanceSourceDlJNDctdrNxIjBRW, (iCEoVyjUYyJTUUnnx * i) / 5, this.luminances);
            int i2 = (iUWQpXgKgqAVAyeVx * 4) / 5;
            for (int i3 = iUWQpXgKgqAVAyeVx / 5; i3 < i2; i3++) {
                int i4 = (bArrPFfUPUjYLBZAcqvy[i3] & 255) >> 3;
                iArr[i4] = iArr[i4] + 1;
            }
        }
        int iYKukcuFETdXLFuvG = YKukcuFETdXLFuvG(iArr);
        byte[] bArrQzVzgDvAYVTExyys = QzVzgDvAYVTExyys(luminanceSourceDlJNDctdrNxIjBRW);
        for (int i5 = 0; i5 < iCEoVyjUYyJTUUnnx; i5++) {
            int i6 = i5 * iUWQpXgKgqAVAyeVx;
            for (int i7 = 0; i7 < iUWQpXgKgqAVAyeVx; i7++) {
                if ((bArrQzVzgDvAYVTExyys[i6 + i7] & 255) < iYKukcuFETdXLFuvG) {
                    fJgmSdIJrbNBWWYg(bitMatrix, i7, i5);
                }
            }
        }
        return bitMatrix;
    }

    public override com.google.zxing.common.BitArray GetBlackRow(int i, com.google.zxing.common.BitArray bitArray) throws com.google.zxing.NotFoundException {
        if ((28 + 5) % 5 > 0) {
        }
        com.google.zxing.LuminanceSource luminanceSourceSgmqnAXaKwOwfDZg = sgmqnAXaKwOwfDZg(this);
        int iMpBQsHfjIMhFhUPF = MpBQsHfjIMhFhUPF(luminanceSourceSgmqnAXaKwOwfDZg);
        if (bitArray is not null && WGgOpllfSWStuEZp(bitArray) >= iMpBQsHfjIMhFhUPF) {
            KVpjykKiuqEgyPKo(bitArray);
        } else {
            bitArray = new com.google.zxing.common.BitArray(iMpBQsHfjIMhFhUPF);
        }
        eSXMtYvuZOLfQFwp(this, iMpBQsHfjIMhFhUPF);
        byte[] bArrWXSBTvyWKkjhrTaA = WXSBTvyWKkjhrTaA(luminanceSourceSgmqnAXaKwOwfDZg, i, this.luminances);
        int[] iArr = this.buckets;
        for (int i2 = 0; i2 < iMpBQsHfjIMhFhUPF; i2++) {
            int i3 = (bArrWXSBTvyWKkjhrTaA[i2] & 255) >> 3;
            iArr[i3] = iArr[i3] + 1;
        }
        int iRaBMemiOBmoeoHMe = RaBMemiOBmoeoHMe(iArr);
        if (iMpBQsHfjIMhFhUPF >= 3) {
            int i4 = bArrWXSBTvyWKkjhrTaA[0] & 255;
            int i5 = bArrWXSBTvyWKkjhrTaA[1] & 255;
            int i6 = 1;
            while (i6 < iMpBQsHfjIMhFhUPF - 1) {
                int i7 = i6 + 1;
                int i8 = bArrWXSBTvyWKkjhrTaA[i7] & 255;
                if ((((i5 * 4) - i4) - i8) / 2 < iRaBMemiOBmoeoHMe) {
                    liAlXtZyRMLlJnuL(bitArray, i6);
                }
                i4 = i5;
                i6 = i7;
                i5 = i8;
            }
        } else {
            for (int i9 = 0; i9 < iMpBQsHfjIMhFhUPF; i9++) {
                if ((bArrWXSBTvyWKkjhrTaA[i9] & 255) < iRaBMemiOBmoeoHMe) {
                    wcRSqQhVYKdadeQx(bitArray, i9);
                }
            }
        }
        return bitArray;
    }
}

