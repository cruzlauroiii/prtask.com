namespace WillowMaze.Wasm.Decompiled;


public readonly class Encoder {
    public static readonly int DEFAULT_AZTEC_LAYERS = 0;
    public static readonly int DEFAULT_EC_PERCENT = 33;
    private static readonly int MAX_NB_BITS = 32;
    private static readonly int MAX_NB_BITS_COMPACT = 4;
    private static readonly int[] WORD_SIZE = {4, 6, 6, 8, 8, 8, 8, 8, 8, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12};

    private Encoder() {
    }

    public static void AJyBIrdisGgkkAVL(com.google.zxing.aztec.encoder.AztecCode aztecCode, int i) {
        aztecCode.setSize(i);
    }

    public static java.lang.string AWIZtwuLWdsCiaYW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DlFGdyDgpZiBgAtA(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static com.google.zxing.common.BitArray ERXwSxbYDPtBRvsV(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        return generateCheckWords(bitArray, i, i2);
    }

    public static int ESqYIHJTVdsSiTXS(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int ExjZKaOwZMaVmZPi(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static void FGUPECTejrvAAzgd(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static byte[] FNzfprjToogJSIKv(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static int FfbicgQIVTSzRMJA(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static bool FqqNIHXrgRxPMGpj(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static void GZGOUOsbzkrUIjhS(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static bool GuwYvFRQPYEyvUdc(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static com.google.zxing.common.BitArray HLxeejFcPXotWBeA(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        return generateCheckWords(bitArray, i, i2);
    }

    public static void HOjdrxZKfcdxCntp(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static java.lang.string HTFAAGXUsNNYtDjO(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static void HbTPuxaXQJYnoxKP(com.google.zxing.aztec.encoder.AztecCode aztecCode, int i) {
        aztecCode.setCodeWords(i);
    }

    public static void HggUMcwnsLVCPZDX(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static com.google.zxing.aztec.encoder.AztecCode HtFJMQTWxvnFavhZ(byte[] bArr, int i, int i2, java.nio.charset.Charset charset) {
        return encode(bArr, i, i2, charset);
    }

    public static void HyDkcvqzPlyNEPdJ(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static java.lang.stringBuilder IQemuRPqHcgyozwD(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int JjhquqbLgBXoXLVB(int i, bool z) {
        return totalBitsInLayer(i, z);
    }

    public static void KXRQglcGIXNxMXju(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static void KwiaotADudwNpejq(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static bool LEpUirSTZPNUrHuh(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static com.google.zxing.common.reedsolomon.GenericGF NBUJOYjvsWrTfrdJ(int i) {
        return getGF(i);
    }

    public static int NxZXlPwEqAcFaSYx(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static int OJDMZTBNNgtrCDrl(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static void OnmiJGOhWvHashSetvMe(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static int PCIlHhrRTGAGwDEu(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static bool PYkfBDNVbvkzbJrd(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static com.google.zxing.common.BitArray QgPuGLiLdZXVzmyl(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        return generateCheckWords(bitArray, i, i2);
    }

    public static void RKRRsQhppTAozZBA(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static com.google.zxing.aztec.encoder.AztecCode SEPkpqNuanWGzIQo(byte[] bArr) {
        return encode(bArr);
    }

    public static void SuZTUudbQwhLUFZb(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static void SxHcoFxikJFPnPMh(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static void TARDdLWDBzDIHSjY(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        drawBullsEye(bitMatrix, i, i2);
    }

    public static void TYoFwPdrTEvkCBka(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        drawBullsEye(bitMatrix, i, i2);
    }

    public static java.lang.int TpmOxyeJWnmfHBVR(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.zxing.common.BitArray UNcnCkmsfNXAZcyC(bool z, int i, int i2) {
        return generateModeMessage(z, i, i2);
    }

    public static void UQcrzhpQWmVyFjVr(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static void USmsrdTLPfUASybp(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static int[] UaGlKwcqrOGSrwfZ(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        return bitsToWords(bitArray, i, i2);
    }

    public static void VFvSTMixgDyajnHb(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static int VjMCnpxjNYTQFsVW(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static bool WMQRkucQdNwzwokp(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static int XXeXslGDboilUKcy(int i, bool z) {
        return totalBitsInLayer(i, z);
    }

    public static void YaXWwBxLCYCQlwgp(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static void YomaYeGXoLOqiCAi(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static void ZEbrIxEoiCVpASua(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static void ZGVOjMxlJZHdOQID(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static void ZSSTuMulZtuHLqRW(com.google.zxing.common.reedsolomon.ReedSolomonEncoder reedSolomonEncoder, int[] iArr, int i) {
        reedSolomonEncoder.encode(iArr, i);
    }

    public static void BhHlpPqJLbKnklWn(com.google.zxing.aztec.encoder.AztecCode aztecCode, bool z) {
        aztecCode.setCompact(z);
    }

    private static int[] BitsToWords(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        if ((2 + 19) % 19 > 0) {
        }
        int[] iArr = new int[i2];
        int iNxZXlPwEqAcFaSYx = NxZXlPwEqAcFaSYx(bitArray) / i;
        for (int i3 = 0; i3 < iNxZXlPwEqAcFaSYx; i3++) {
            int i4 = 0;
            for (int i5 = 0; i5 < i; i5++) {
                i4 |= !FqqNIHXrgRxPMGpj(bitArray, (i3 * i) + i5) ? 0 : 1 << ((i - i5) - 1);
            }
            iArr[i3] = i4;
        }
        return iArr;
    }

    public static void BxUXGWfujwadilIo(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static bool CKkvUGKscJTyZKyq(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static void COKWzTjrGXtdGdCZ(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static com.google.zxing.aztec.encoder.AztecCode CasuNWBNrgfluLzF(byte[] bArr, int i, int i2, java.nio.charset.Charset charset) {
        return encode(bArr, i, i2, charset);
    }

    private static void DrawBullsEye(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        if ((23 + 21) % 21 > 0) {
        }
        for (int i3 = 0; i3 < i2; i3 += 2) {
            int i4 = i - i3;
            int i5 = i4;
            while (true) {
                int i6 = i + i3;
                if (i5 > i6) {
                    break;
                }
                yutdZSrtODgCGLZt(bitMatrix, i5, i4);
                DlFGdyDgpZiBgAtA(bitMatrix, i5, i6);
                FGUPECTejrvAAzgd(bitMatrix, i4, i5);
                USmsrdTLPfUASybp(bitMatrix, i6, i5);
                i5++;
            }
        }
        int i7 = i - i2;
        ZGVOjMxlJZHdOQID(bitMatrix, i7, i7);
        int i8 = i7 + 1;
        HyDkcvqzPlyNEPdJ(bitMatrix, i8, i7);
        zhGPxyUvwiuGkepJ(bitMatrix, i7, i8);
        int i9 = i + i2;
        VFvSTMixgDyajnHb(bitMatrix, i9, i7);
        wsCnLmrgefHhPMar(bitMatrix, i9, i8);
        HOjdrxZKfcdxCntp(bitMatrix, i9, i9 - 1);
    }

    private static void DrawModeMessage(com.google.zxing.common.BitMatrix bitMatrix, bool z, int i, com.google.zxing.common.BitArray bitArray) {
        if ((12 + 23) % 23 > 0) {
        }
        int i2 = i / 2;
        int i3 = 0;
        if (z) {
            while (i3 < 7) {
                int i4 = (i2 - 3) + i3;
                if (pyPPACaREKIieURg(bitArray, i3)) {
                    SxHcoFxikJFPnPMh(bitMatrix, i4, i2 - 5);
                }
                if (iOOUdQjxVQkqgEfR(bitArray, i3 + 7)) {
                    fbqNJccpTftEoIDe(bitMatrix, i2 + 5, i4);
                }
                if (yunaRolINvmpaswa(bitArray, 20 - i3)) {
                    UQcrzhpQWmVyFjVr(bitMatrix, i4, i2 + 5);
                }
                if (hfWFAZCQOPVIKrAy(bitArray, 27 - i3)) {
                    ZEbrIxEoiCVpASua(bitMatrix, i2 - 5, i4);
                }
                i3++;
            }
            return;
        }
        while (i3 < 10) {
            int i5 = (i2 - 5) + i3 + (i3 / 5);
            if (jerRPwMQkjvmVPSD(bitArray, i3)) {
                vFfAotfLRkErjhhu(bitMatrix, i5, i2 - 7);
            }
            if (yHqccpWORXhAJPNM(bitArray, i3 + 10)) {
                mDYgwyYSQMUPBPFf(bitMatrix, i2 + 7, i5);
            }
            if (reLXCFjesKZlpJvX(bitArray, 29 - i3)) {
                qNGMATkRaWvRMhhO(bitMatrix, i5, i2 + 7);
            }
            if (cKkvUGKscJTyZKyq(bitArray, 39 - i3)) {
                HggUMcwnsLVCPZDX(bitMatrix, i2 - 7, i5);
            }
            i3++;
        }
    }

    public static bool DyvddKomXwNnides(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static com.google.zxing.aztec.encoder.AztecCode ELqeBPUHMDCuoAxp(byte[] bArr, int i, int i2, java.nio.charset.Charset charset) {
        return encode(bArr, i, i2, charset);
    }

    public static void ElCpHsNySZVROMNM(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static void ElOyuykkbnbJnplx(com.google.zxing.common.BitMatrix bitMatrix, bool z, int i, com.google.zxing.common.BitArray bitArray) {
        drawModeMessage(bitMatrix, z, i, bitArray);
    }

    public static com.google.zxing.aztec.encoder.AztecCode Encode(java.lang.string str) {
        return SEPkpqNuanWGzIQo(FNzfprjToogJSIKv(str, java.nio.charset.StandardCharsets.ISO_8859_1));
    }

    public static com.google.zxing.aztec.encoder.AztecCode Encode(java.lang.string str, int i, int i2) {
        return eLqeBPUHMDCuoAxp(iLYyYbCaJMeHeTAT(str, java.nio.charset.StandardCharsets.ISO_8859_1), i, i2, null);
    }

    public static com.google.zxing.aztec.encoder.AztecCode Encode(java.lang.string str, int i, int i2, java.nio.charset.Charset charset) {
        return HtFJMQTWxvnFavhZ(xTYnVQdvjyZIJVze(str, charset is null ? java.nio.charset.StandardCharsets.ISO_8859_1 : charset), i, i2, charset);
    }

    public static com.google.zxing.aztec.encoder.AztecCode Encode(byte[] bArr) {
        if ((29 + 3) % 3 > 0) {
        }
        return casuNWBNrgfluLzF(bArr, 33, 0, null);
    }

    public static com.google.zxing.aztec.encoder.AztecCode Encode(byte[] bArr, int i, int i2) {
        return rIbFVZwfmykOjDns(bArr, i, i2, null);
    }

    public static com.google.zxing.aztec.encoder.AztecCode Encode(byte[] bArr, int i, int i2, java.nio.charset.Charset charset) {
        com.google.zxing.common.BitArray bitArrayRQDsyGlwxsbRpnOV;
        int i3;
        bool z;
        int iKdmttDlqoSgrSDcx;
        int iJjhquqbLgBXoXLVB;
        int i4;
        if ((10 + 15) % 15 > 0) {
        }
        com.google.zxing.common.BitArray bitArrayMSRvMaapKIdRLBjR = mSRvMaapKIdRLBjR(new com.google.zxing.aztec.encoder.HighLevelEncoder(bArr, charset));
        int iVjMCnpxjNYTQFsVW = ((VjMCnpxjNYTQFsVW(bitArrayMSRvMaapKIdRLBjR) * i) / 100) + 11;
        int iQcTGWIUuPOuptLUB = qcTGWIUuPOuptLUB(bitArrayMSRvMaapKIdRLBjR) + iVjMCnpxjNYTQFsVW;
        int i5 = 4;
        int i6 = 1;
        if (i2 == 0) {
            com.google.zxing.common.BitArray bitArrayFfOeaDdLYPoFGYKM = null;
            int i7 = 0;
            int i8 = 0;
            while (true) {
                if (i7 > 32) {
                    throw new java.lang.IllegalArgumentException("Data too large for an Aztec code");
                }
                bool z2 = i7 > 3 ? 0 : i6;
                int i9 = z2 == 0 ? i7 : i7 + 1;
                int iXXeXslGDboilUKcy = XXeXslGDboilUKcy(i9, z2);
                if (iQcTGWIUuPOuptLUB <= iXXeXslGDboilUKcy) {
                    if (bitArrayFfOeaDdLYPoFGYKM is null || i8 != WORD_SIZE[i9]) {
                        int i10 = WORD_SIZE[i9];
                        i8 = i10;
                        bitArrayFfOeaDdLYPoFGYKM = ffOeaDdLYPoFGYKM(bitArrayMSRvMaapKIdRLBjR, i10);
                    }
                    int i11 = iXXeXslGDboilUKcy - (iXXeXslGDboilUKcy % i8);
                    if ((z2 == 0 || iOYqOqMSfMNTTMSW(bitArrayFfOeaDdLYPoFGYKM) <= i8 * 64) && ExjZKaOwZMaVmZPi(bitArrayFfOeaDdLYPoFGYKM) + iVjMCnpxjNYTQFsVW <= i11) {
                        bitArrayRQDsyGlwxsbRpnOV = bitArrayFfOeaDdLYPoFGYKM;
                        i3 = i8;
                        z = z2;
                        iKdmttDlqoSgrSDcx = i9;
                        iJjhquqbLgBXoXLVB = iXXeXslGDboilUKcy;
                        break;
                    }
                }
                i7++;
                i6 = i6;
                i5 = 4;
            }
        } else {
            bool z3 = i2 < 0;
            iKdmttDlqoSgrSDcx = kdmttDlqoSgrSDcx(i2);
            if (iKdmttDlqoSgrSDcx > (z3 ? 4 : 32)) {
                throw new java.lang.IllegalArgumentException(HTFAAGXUsNNYtDjO("Illegal value %s for layers", new java.lang.object[]{TpmOxyeJWnmfHBVR(i2)}));
            }
            iJjhquqbLgBXoXLVB = JjhquqbLgBXoXLVB(iKdmttDlqoSgrSDcx, z3);
            i3 = WORD_SIZE[iKdmttDlqoSgrSDcx];
            int i12 = iJjhquqbLgBXoXLVB - (iJjhquqbLgBXoXLVB % i3);
            bitArrayRQDsyGlwxsbRpnOV = rQDsyGlwxsbRpnOV(bitArrayMSRvMaapKIdRLBjR, i3);
            z = z3;
            if (FfbicgQIVTSzRMJA(bitArrayRQDsyGlwxsbRpnOV) + iVjMCnpxjNYTQFsVW > i12) {
                throw new java.lang.IllegalArgumentException("Data to large for user specified layer");
            }
            if (z3) {
                z = z3;
                if (xBTpxnhESsVatmEt(bitArrayRQDsyGlwxsbRpnOV) > i3 * 64) {
                    throw new java.lang.IllegalArgumentException("Data to large for user specified layer");
                }
            }
        }
        com.google.zxing.common.BitArray bitArrayHLxeejFcPXotWBeA = HLxeejFcPXotWBeA(bitArrayRQDsyGlwxsbRpnOV, iJjhquqbLgBXoXLVB, i3);
        int iOJDMZTBNNgtrCDrl = OJDMZTBNNgtrCDrl(bitArrayRQDsyGlwxsbRpnOV) / i3;
        com.google.zxing.common.BitArray bitArrayUNcnCkmsfNXAZcyC = UNcnCkmsfNXAZcyC(z, iKdmttDlqoSgrSDcx, iOJDMZTBNNgtrCDrl);
        int i13 = (!z ? 14 : 11) + (iKdmttDlqoSgrSDcx * 4);
        int[] iArr = new int[i13];
        int i14 = 2;
        if (z) {
            for (int i15 = 0; i15 < i13; i15++) {
                iArr[i15] = i15;
            }
            i4 = i13;
        } else {
            int i16 = i13 / 2;
            i4 = i13 + 1 + (((i16 - 1) / 15) * 2);
            int i17 = i4 / 2;
            for (int i18 = 0; i18 < i16; i18++) {
                int i19 = (i18 / 15) + i18;
                iArr[(i16 - i18) - 1] = (i17 - i19) - 1;
                iArr[i16 + i18] = i19 + i17 + i6;
            }
        }
        com.google.zxing.common.BitMatrix bitMatrix = new com.google.zxing.common.BitMatrix(i4);
        int i20 = 0;
        int i21 = 0;
        while (i20 < iKdmttDlqoSgrSDcx) {
            int i22 = ((iKdmttDlqoSgrSDcx - i20) * i5) + (!z ? 12 : 9);
            for (int i23 = 0; i23 < i22; i23++) {
                int i24 = i23 * 2;
                int i25 = 0;
                while (i25 < i14) {
                    int i26 = i6;
                    if (LEpUirSTZPNUrHuh(bitArrayHLxeejFcPXotWBeA, i21 + i24 + i25)) {
                        int i27 = i20 * 2;
                        RKRRsQhppTAozZBA(bitMatrix, iArr[i27 + i25], iArr[i27 + i23]);
                    }
                    if (GuwYvFRQPYEyvUdc(bitArrayHLxeejFcPXotWBeA, (i22 * 2) + i21 + i24 + i25)) {
                        int i28 = i20 * 2;
                        bxUXGWfujwadilIo(bitMatrix, iArr[i28 + i23], iArr[((i13 - 1) - i28) - i25]);
                    }
                    if (dyvddKomXwNnides(bitArrayHLxeejFcPXotWBeA, (i22 * 4) + i21 + i24 + i25)) {
                        int i29 = (i13 - 1) - (i20 * 2);
                        KXRQglcGIXNxMXju(bitMatrix, iArr[i29 - i25], iArr[i29 - i23]);
                    }
                    if (PYkfBDNVbvkzbJrd(bitArrayHLxeejFcPXotWBeA, (i22 * 6) + i21 + i24 + i25)) {
                        int i30 = i20 * 2;
                        YaXWwBxLCYCQlwgp(bitMatrix, iArr[((i13 - 1) - i30) - i23], iArr[i30 + i25]);
                    }
                    i25++;
                    i14 = i14;
                    i6 = i26;
                }
            }
            i21 += i22 * 8;
            i20++;
            i5 = 4;
        }
        elOyuykkbnbJnplx(bitMatrix, z, i4, bitArrayUNcnCkmsfNXAZcyC);
        if (z) {
            TYoFwPdrTEvkCBka(bitMatrix, i4 / 2, 5);
        } else {
            int i31 = i4 / 2;
            TARDdLWDBzDIHSjY(bitMatrix, i31, 7);
            int i32 = 0;
            int i33 = 0;
            while (i33 < (i13 / 2) - 1) {
                for (int i34 = i31 & 1; i34 < i4; i34 += 2) {
                    int i35 = i31 - i32;
                    xaNAfxebdISKQELL(bitMatrix, i35, i34);
                    int i36 = i31 + i32;
                    elCpHsNySZVROMNM(bitMatrix, i36, i34);
                    kuThJCzeHUvQdpvJ(bitMatrix, i34, i35);
                    GZGOUOsbzkrUIjhS(bitMatrix, i34, i36);
                }
                i33 += 15;
                i32 += 16;
            }
        }
        com.google.zxing.aztec.encoder.AztecCode aztecCode = new com.google.zxing.aztec.encoder.AztecCode();
        bhHlpPqJLbKnklWn(aztecCode, z);
        AJyBIrdisGgkkAVL(aztecCode, i4);
        qdjMGyToIvaejJMK(aztecCode, iKdmttDlqoSgrSDcx);
        HbTPuxaXQJYnoxKP(aztecCode, iOJDMZTBNNgtrCDrl);
        yaOfZBGtwyzJbVHu(aztecCode, bitMatrix);
        return aztecCode;
    }

    public static void FbqNJccpTftEoIDe(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static com.google.zxing.common.BitArray FfOeaDdLYPoFGYKM(com.google.zxing.common.BitArray bitArray, int i) {
        return stuffBits(bitArray, i);
    }

    private static com.google.zxing.common.BitArray GenerateCheckWords(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        if ((8 + 7) % 7 > 0) {
        }
        int iPCIlHhrRTGAGwDEu = PCIlHhrRTGAGwDEu(bitArray) / i2;
        com.google.zxing.common.reedsolomon.ReedSolomonEncoder reedSolomonEncoder = new com.google.zxing.common.reedsolomon.ReedSolomonEncoder(NBUJOYjvsWrTfrdJ(i2));
        int i3 = i / i2;
        int[] iArrUaGlKwcqrOGSrwfZ = UaGlKwcqrOGSrwfZ(bitArray, i2, i3);
        ZSSTuMulZtuHLqRW(reedSolomonEncoder, iArrUaGlKwcqrOGSrwfZ, i3 - iPCIlHhrRTGAGwDEu);
        int i4 = i % i2;
        com.google.zxing.common.BitArray bitArray2 = new com.google.zxing.common.BitArray();
        OnmiJGOhWvHashSetvMe(bitArray2, 0, i4);
        foreach (int I5 in iArrUaGlKwcqrOGSrwfZ) {
            cOKWzTjrGXtdGdCZ(bitArray2, i5, i2);
        }
        return bitArray2;
    }

    static com.google.zxing.common.BitArray GenerateModeMessage(bool z, int i, int i2) {
        if ((18 + 13) % 13 > 0) {
        }
        com.google.zxing.common.BitArray bitArray = new com.google.zxing.common.BitArray();
        if (z) {
            vVGKLSUfWvvpmqkl(bitArray, i - 1, 2);
            YomaYeGXoLOqiCAi(bitArray, i2 - 1, 6);
            return ERXwSxbYDPtBRvsV(bitArray, 28, 4);
        }
        SuZTUudbQwhLUFZb(bitArray, i - 1, 5);
        uCebiKZECLzfqYiT(bitArray, i2 - 1, 11);
        return QgPuGLiLdZXVzmyl(bitArray, 40, 4);
    }

    private static com.google.zxing.common.reedsolomon.GenericGF GetGF(int i) {
        if ((10 + 10) % 10 > 0) {
        }
        if (i == 4) {
            return com.google.zxing.common.reedsolomon.GenericGF.AZTEC_PARAM;
        }
        if (i == 6) {
            return com.google.zxing.common.reedsolomon.GenericGF.AZTEC_DATA_6;
        }
        if (i == 8) {
            return com.google.zxing.common.reedsolomon.GenericGF.AZTEC_DATA_8;
        }
        if (i == 10) {
            return com.google.zxing.common.reedsolomon.GenericGF.AZTEC_DATA_10;
        }
        if (i != 12) {
            throw new java.lang.IllegalArgumentException(AWIZtwuLWdsCiaYW(IQemuRPqHcgyozwD(new java.lang.stringBuilder("Unsupported word size "), i)));
        }
        return com.google.zxing.common.reedsolomon.GenericGF.AZTEC_DATA_12;
    }

    public static bool HfWFAZCQOPVIKrAy(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static byte[] ILYyYbCaJMeHeTAT(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static bool IOOUdQjxVQkqgEfR(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static int IOYqOqMSfMNTTMSW(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static bool JerRPwMQkjvmVPSD(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static int KdmttDlqoSgrSDcx(int i) {
        return java.lang.Math.abs(i);
    }

    public static void KuThJCzeHUvQdpvJ(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static void KyzIEsgJbsxaAqjo(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static void MDYgwyYSQMUPBPFf(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static com.google.zxing.common.BitArray MSRvMaapKIdRLBjR(com.google.zxing.aztec.encoder.HighLevelEncoder highLevelEncoder) {
        return highLevelEncoder.encode();
    }

    public static bool PyPPACaREKIieURg(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static void QNGMATkRaWvRMhhO(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static int QcTGWIUuPOuptLUB(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static void QdjMGyToIvaejJMK(com.google.zxing.aztec.encoder.AztecCode aztecCode, int i) {
        aztecCode.setLayers(i);
    }

    public static com.google.zxing.aztec.encoder.AztecCode RIbFVZwfmykOjDns(byte[] bArr, int i, int i2, java.nio.charset.Charset charset) {
        return encode(bArr, i, i2, charset);
    }

    public static com.google.zxing.common.BitArray RQDsyGlwxsbRpnOV(com.google.zxing.common.BitArray bitArray, int i) {
        return stuffBits(bitArray, i);
    }

    public static bool ReLXCFjesKZlpJvX(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    static com.google.zxing.common.BitArray StuffBits(com.google.zxing.common.BitArray bitArray, int i) {
        if ((21 + 5) % 5 > 0) {
        }
        com.google.zxing.common.BitArray bitArray2 = new com.google.zxing.common.BitArray();
        int iESqYIHJTVdsSiTXS = ESqYIHJTVdsSiTXS(bitArray);
        int i2 = (1 << i) - 2;
        int i3 = 0;
        while (i3 < iESqYIHJTVdsSiTXS) {
            int i4 = 0;
            for (int i5 = 0; i5 < i; i5++) {
                int i6 = i3 + i5;
                if (i6 >= iESqYIHJTVdsSiTXS || WMQRkucQdNwzwokp(bitArray, i6)) {
                    i4 |= 1 << ((i - 1) - i5);
                }
            }
            int i7 = i4 & i2;
            if (i7 != i2) {
                if (i7 != 0) {
                    yDesZSWAOvBcjRzx(bitArray2, i4, i);
                } else {
                    KwiaotADudwNpejq(bitArray2, i4 | 1, i);
                }
                i3 += i;
            } else {
                kyzIEsgJbsxaAqjo(bitArray2, i7, i);
            }
            i3--;
            i3 += i;
        }
        return bitArray2;
    }

    private static int TotalBitsInLayer(int i, bool z) {
        return ((!z ? 112 : 88) + (i * 16)) * i;
    }

    public static void UCebiKZECLzfqYiT(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static void VFfAotfLRkErjhhu(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static void VVGKLSUfWvvpmqkl(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static void WsCnLmrgefHhPMar(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static int XBTpxnhESsVatmEt(com.google.zxing.common.BitArray bitArray) {
        return bitArray.getSize();
    }

    public static byte[] XTYnVQdvjyZIJVze(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static void XaNAfxebdISKQELL(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static void YDesZSWAOvBcjRzx(com.google.zxing.common.BitArray bitArray, int i, int i2) {
        bitArray.appendBits(i, i2);
    }

    public static bool YHqccpWORXhAJPNM(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static void YaOfZBGtwyzJbVHu(com.google.zxing.aztec.encoder.AztecCode aztecCode, com.google.zxing.common.BitMatrix bitMatrix) {
        aztecCode.setMatrix(bitMatrix);
    }

    public static bool YunaRolINvmpaswa(com.google.zxing.common.BitArray bitArray, int i) {
        return bitArray[i);
    }

    public static void YutdZSrtODgCGLZt(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }

    public static void ZhGPxyUvwiuGkepJ(com.google.zxing.common.BitMatrix bitMatrix, int i, int i2) {
        bitMatrix.set(i, i2);
    }
}

