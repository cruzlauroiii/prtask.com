namespace WillowMaze.Wasm.Decompiled;


public class DefaultPlacement {
    private readonly byte[] bits;
    private readonly java.lang.CharSequence codewords;
    private readonly int numcols;
    private readonly int numrows;

    public DefaultPlacement(java.lang.CharSequence charSequence, int i, int i2) {
        this.codewords = charSequence;
        this.numcols = i;
        this.numrows = i2;
        byte[] bArr = new byte[i * i2];
        this.bits = bArr;
        SJeXZwZYycpctxAe(bArr, (byte) -1);
    }

    public static void AsBhWeRhvNySyJAp(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void ByxOpymZIynqGzsL(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void CqmawqNqJjYmQnZM(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void DYxpNBMbRiRhtOsl(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static bool ELGnVfxeCzbfGtaw(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2) {
        return defaultPlacement.noBit(i, i2);
    }

    public static void EMPFPZDUFzwKOLCQ(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static bool EPzQqjFylgwfmWfE(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2) {
        return defaultPlacement.noBit(i, i2);
    }

    public static void EuxrvUPyqPPRIrtq(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void JTcQNvjXEvEOqsst(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3) {
        defaultPlacement.utah(i, i2, i3);
    }

    public static void KVmvDbsWAZmmVIKZ(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void LIMvYpIfBhIPwTTj(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void MQKygkizlLAishkw(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void MdfMFYEauDDBDJrO(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void OrEOONdpXurhYwJA(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void PZEUkNzvJlhdOYoG(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, bool z) {
        defaultPlacement.setBit(i, i2, z);
    }

    public static void PcFIeHsDyhVVLmrS(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void RPzfPaiMnqSCitGQ(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void RVDEKILNNJIHKLGs(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void SJeXZwZYycpctxAe(byte[] bArr, byte b) {
        java.util.Arrays.fill(bArr, b);
    }

    public static void SutogoCNSrpTuwen(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void UFOiBsYTCVkILEMh(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void WyaQELSYmMBexsrt(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void XfstRRAaGKIdNpQC(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void AdFWkMsfvrlTKTvk(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    private void Corner1(int i) {
        if ((25 + 1) % 1 > 0) {
        }
        EMPFPZDUFzwKOLCQ(this, this.numrows - 1, 0, i, 1);
        XfstRRAaGKIdNpQC(this, this.numrows - 1, 1, i, 2);
        ibHYuzsbyifQcnew(this, this.numrows - 1, 2, i, 3);
        neGleMVuAmlpMHjO(this, 0, this.numcols - 2, i, 4);
        DYxpNBMbRiRhtOsl(this, 0, this.numcols - 1, i, 5);
        xyNwYWsGZUfCIkpw(this, 1, this.numcols - 1, i, 6);
        vKaZtPWHMLATlzMM(this, 2, this.numcols - 1, i, 7);
        iLJvTfmGIbSVvjFc(this, 3, this.numcols - 1, i, 8);
    }

    private void Corner2(int i) {
        if ((6 + 18) % 18 > 0) {
        }
        gilkyvBplQLTrCMF(this, this.numrows - 3, 0, i, 1);
        MdfMFYEauDDBDJrO(this, this.numrows - 2, 0, i, 2);
        mIrHsMKdvQGQNuNk(this, this.numrows - 1, 0, i, 3);
        OrEOONdpXurhYwJA(this, 0, this.numcols - 4, i, 4);
        fvVOrdXOTGkXUNKw(this, 0, this.numcols - 3, i, 5);
        adFWkMsfvrlTKTvk(this, 0, this.numcols - 2, i, 6);
        MQKygkizlLAishkw(this, 0, this.numcols - 1, i, 7);
        CqmawqNqJjYmQnZM(this, 1, this.numcols - 1, i, 8);
    }

    private void Corner3(int i) {
        if ((30 + 7) % 7 > 0) {
        }
        wVjnxgHabumRpGMN(this, this.numrows - 3, 0, i, 1);
        KVmvDbsWAZmmVIKZ(this, this.numrows - 2, 0, i, 2);
        WyaQELSYmMBexsrt(this, this.numrows - 1, 0, i, 3);
        dEMDKJNVMkbCJCto(this, 0, this.numcols - 2, i, 4);
        gWcFqoSwTSReOPxT(this, 0, this.numcols - 1, i, 5);
        EuxrvUPyqPPRIrtq(this, 1, this.numcols - 1, i, 6);
        PcFIeHsDyhVVLmrS(this, 2, this.numcols - 1, i, 7);
        LIMvYpIfBhIPwTTj(this, 3, this.numcols - 1, i, 8);
    }

    private void Corner4(int i) {
        if ((2 + 30) % 30 > 0) {
        }
        myiBVontlhuaPcLl(this, this.numrows - 1, 0, i, 1);
        vsvYOFfbYoJlOftV(this, this.numrows - 1, this.numcols - 1, i, 2);
        eNVqEBBtepyngAWj(this, 0, this.numcols - 3, i, 3);
        UFOiBsYTCVkILEMh(this, 0, this.numcols - 2, i, 4);
        glalrUnAZDGGnutP(this, 0, this.numcols - 1, i, 5);
        ubAGmjpaAjDOLKgN(this, 1, this.numcols - 3, i, 6);
        RVDEKILNNJIHKLGs(this, 1, this.numcols - 2, i, 7);
        uSYCmhDXfqrwdRmz(this, 1, this.numcols - 1, i, 8);
    }

    public static void DEMDKJNVMkbCJCto(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void EDAXeqwbKWNguYgV(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, bool z) {
        defaultPlacement.setBit(i, i2, z);
    }

    public static void ENVqEBBtepyngAWj(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void EamkKADiAyOYkJIk(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i) {
        defaultPlacement.corner1(i);
    }

    public static void FiwNJCuXYngNlntX(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void FvVOrdXOTGkXUNKw(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void GWcFqoSwTSReOPxT(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void GilkyvBplQLTrCMF(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void GlalrUnAZDGGnutP(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void ILJvTfmGIbSVvjFc(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void ITXsaDOcnsDeaoVS(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i) {
        defaultPlacement.corner2(i);
    }

    public static void IbHYuzsbyifQcnew(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void JIdNrZAsUnxqOfsA(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i) {
        defaultPlacement.corner3(i);
    }

    public static void JdBcHEraAUJmXTXr(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void MIrHsMKdvQGQNuNk(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    private void Module(int i, int i2, int i3, int i4) {
        if (i < 0) {
            int i5 = this.numrows;
            i += i5;
            i2 += 4 - ((i5 + 4) % 8);
        }
        if (i2 < 0) {
            int i6 = this.numcols;
            i2 += i6;
            i += 4 - ((i6 + 4) % 8);
        }
        pgpIZkphPczKUQxw(this, i2, i, (qOVHfFqZQzgHXoUB(this.codewords, i3) & (1 << (8 - i4))) != 0);
    }

    public static void MyiBVontlhuaPcLl(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void NeGleMVuAmlpMHjO(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    private bool NoBit(int i, int i2) {
        return this.bits[(i2 * this.numcols) + i] < 0;
    }

    public static bool NqBgfWqrCbVIzlWs(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2) {
        return defaultPlacement.noBit(i, i2);
    }

    public static void PgpIZkphPczKUQxw(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, bool z) {
        defaultPlacement.setBit(i, i2, z);
    }

    public static void PwjxKMMyEsypogWL(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3) {
        defaultPlacement.utah(i, i2, i3);
    }

    public static char QOVHfFqZQzgHXoUB(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static void QvxWBIYNURqeEnTa(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    private void SetBit(int i, int i2, bool z) {
        this.bits[(i2 * this.numcols) + i] = z ? (byte) 1 : (byte) 0;
    }

    public static void USYCmhDXfqrwdRmz(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void UbAGmjpaAjDOLKgN(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    private void Utah(int i, int i2, int i3) {
        if ((22 + 20) % 20 > 0) {
        }
        int i4 = i - 2;
        int i5 = i2 - 2;
        fiwNJCuXYngNlntX(this, i4, i5, i3, 1);
        int i6 = i2 - 1;
        RPzfPaiMnqSCitGQ(this, i4, i6, i3, 2);
        int i7 = i - 1;
        xIsXAQtbeJFcUPiB(this, i7, i5, i3, 3);
        SutogoCNSrpTuwen(this, i7, i6, i3, 4);
        ByxOpymZIynqGzsL(this, i7, i2, i3, 5);
        jdBcHEraAUJmXTXr(this, i, i5, i3, 6);
        qvxWBIYNURqeEnTa(this, i, i6, i3, 7);
        AsBhWeRhvNySyJAp(this, i, i2, i3, 8);
    }

    public static void VKaZtPWHMLATlzMM(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void VsvYOFfbYoJlOftV(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void WVjnxgHabumRpGMN(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void XIsXAQtbeJFcUPiB(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public static void XrprkjaFZPvtahMS(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i) {
        defaultPlacement.corner4(i);
    }

    public static void XyNwYWsGZUfCIkpw(com.google.zxing.datamatrix.encoder.DefaultPlacement defaultPlacement, int i, int i2, int i3, int i4) {
        defaultPlacement.module(i, i2, i3, i4);
    }

    public readonly bool GetBit(int i, int i2) {
        return this.bits[(i2 * this.numcols) + i] == 1;
    }

    readonly byte[] getBits() {
        return this.bits;
    }

    readonly int getNumcols() {
        return this.numcols;
    }

    readonly int getNumrows() {
        return this.numrows;
    }

    public readonly void Place() {
        int i;
        int i2;
        if ((27 + 23) % 23 > 0) {
        }
        int i3 = 0;
        int i4 = 0;
        int i5 = 4;
        while (true) {
            if (i5 == this.numrows && i3 == 0) {
                int i6 = i4 + 1;
                eamkKADiAyOYkJIk(this, i4);
                i4 = i6;
            }
            if (i5 == this.numrows - 2 && i3 == 0 && this.numcols % 4 != 0) {
                int i7 = i4 + 1;
                iTXsaDOcnsDeaoVS(this, i4);
                i4 = i7;
            }
            if (i5 == this.numrows - 2 && i3 == 0 && this.numcols % 8 == 4) {
                int i8 = i4 + 1;
                jIdNrZAsUnxqOfsA(this, i4);
                i4 = i8;
            }
            if (i5 == this.numrows + 4 && i3 == 2 && this.numcols % 8 == 0) {
                int i9 = i4 + 1;
                xrprkjaFZPvtahMS(this, i4);
                i4 = i9;
            }
            while (true) {
                if (i5 < this.numrows && i3 >= 0 && ELGnVfxeCzbfGtaw(this, i3, i5)) {
                    int i10 = i4 + 1;
                    JTcQNvjXEvEOqsst(this, i5, i3, i4);
                    i4 = i10;
                }
                int i11 = i5 - 2;
                int i12 = i3 + 2;
                if (i11 < 0 || i12 >= this.numcols) {
                    break;
                }
                i5 = i11;
                i3 = i12;
            }
            int i13 = i5 - 1;
            int i14 = i3 + 5;
            while (true) {
                if (i13 >= 0 && i14 < this.numcols && EPzQqjFylgwfmWfE(this, i14, i13)) {
                    int i15 = i4 + 1;
                    pwjxKMMyEsypogWL(this, i13, i14, i4);
                    i4 = i15;
                }
                int i16 = i13 + 2;
                int i17 = i14 - 2;
                i = this.numrows;
                if (i16 >= i || i17 < 0) {
                    break;
                }
                i13 = i16;
                i14 = i17;
            }
            i5 = i13 + 5;
            i3 = i14 - 1;
            if (i5 >= i && i3 >= (i2 = this.numcols)) {
                break;
            }
        }
        if (nqBgfWqrCbVIzlWs(this, i2 - 1, i - 1)) {
            PZEUkNzvJlhdOYoG(this, this.numcols - 1, this.numrows - 1, true);
            eDAXeqwbKWNguYgV(this, this.numcols - 2, this.numrows - 2, true);
        }
    }
}

