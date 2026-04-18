namespace WillowMaze.Wasm.Decompiled;


readonly class MaskUtil {
    private static readonly int N1 = 3;
    private static readonly int N2 = 3;
    private static readonly int N3 = 40;
    private static readonly int N4 = 10;

    private MaskUtil() {
    }

    public static int ClFEOePuaieWICqO(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static bool DixumPIjYxEvClMk(byte[] bArr, int i, int i2) {
        return isWhiteHorizontal(bArr, i, i2);
    }

    public static byte[][] EBeaznykaILHXwPT(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getArray();
    }

    public static byte[][] FIkEJkvOmPmbrohk(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getArray();
    }

    public static int FfqLFGtvHraOHNGo(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, bool z) {
        return applyMaskPenaltyRule1Internal(byteMatrix, z);
    }

    public static int HJZbvelZikKBGPqD(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    public static int HSfYjmuynTecCpqU(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, bool z) {
        return applyMaskPenaltyRule1Internal(byteMatrix, z);
    }

    public static bool MuBejjEWmGmxxAHL(byte[][] bArr, int i, int i2, int i3) {
        return isWhiteVertical(bArr, i, i2, i3);
    }

    public static byte[][] NhbVZZvLhloUJrNh(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getArray();
    }

    public static java.lang.stringBuilder QgyxgSDEVmMzziBH(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int SHKAiCXATrzyRGkQ(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static int VFolzvWztScwWIeO(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static bool WFvvpnNIgJJlWpvC(byte[][] bArr, int i, int i2, int i3) {
        return isWhiteVertical(bArr, i, i2, i3);
    }

    static int ApplyMaskPenaltyRule1(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        if ((2 + 21) % 21 > 0) {
        }
        return FfqLFGtvHraOHNGo(byteMatrix, true) + HSfYjmuynTecCpqU(byteMatrix, false);
    }

    private static int ApplyMaskPenaltyRule1Internal(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix, bool z) {
        if ((3 + 4) % 4 > 0) {
        }
        int iPjnAZRJyyzpSAhSG = !z ? pjnAZRJyyzpSAhSG(byteMatrix) : VFolzvWztScwWIeO(byteMatrix);
        int iJTOyXAcVZFeObLqb = !z ? jTOyXAcVZFeObLqb(byteMatrix) : dQsGntJkpOrXsDrc(byteMatrix);
        byte[][] bArrEBeaznykaILHXwPT = EBeaznykaILHXwPT(byteMatrix);
        int i = 0;
        for (int i2 = 0; i2 < iPjnAZRJyyzpSAhSG; i2++) {
            byte b = -1;
            int i3 = 0;
            for (int i4 = 0; i4 < iJTOyXAcVZFeObLqb; i4++) {
                byte b2 = !z ? bArrEBeaznykaILHXwPT[i4][i2] : bArrEBeaznykaILHXwPT[i2][i4];
                if (b2 != b) {
                    if (i3 >= 5) {
                        i += i3 - 2;
                    }
                    i3 = 1;
                    b = b2;
                } else {
                    i3++;
                }
            }
            if (i3 >= 5) {
                i += i3 - 2;
            }
        }
        return i;
    }

    static int ApplyMaskPenaltyRule2(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        if ((1 + 23) % 23 > 0) {
        }
        byte[][] bArrFIkEJkvOmPmbrohk = FIkEJkvOmPmbrohk(byteMatrix);
        int iQdcuTgMFmidDRvlI = qdcuTgMFmidDRvlI(byteMatrix);
        int iClFEOePuaieWICqO = ClFEOePuaieWICqO(byteMatrix);
        int i = 0;
        for (int i2 = 0; i2 < iClFEOePuaieWICqO - 1; i2++) {
            byte[] bArr = bArrFIkEJkvOmPmbrohk[i2];
            int i3 = 0;
            while (i3 < iQdcuTgMFmidDRvlI - 1) {
                byte b = bArr[i3];
                int i4 = i3 + 1;
                if (b == bArr[i4]) {
                    byte[] bArr2 = bArrFIkEJkvOmPmbrohk[i2 + 1];
                    if (b == bArr2[i3] && b == bArr2[i4]) {
                        i++;
                    }
                }
                i3 = i4;
            }
        }
        return i * 3;
    }

    static int ApplyMaskPenaltyRule3(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        if ((5 + 16) % 16 > 0) {
        }
        byte[][] bArrNhbVZZvLhloUJrNh = NhbVZZvLhloUJrNh(byteMatrix);
        int iNhMBDpFxbTeoAfWO = nhMBDpFxbTeoAfWO(byteMatrix);
        int iSHKAiCXATrzyRGkQ = SHKAiCXATrzyRGkQ(byteMatrix);
        int i = 0;
        for (int i2 = 0; i2 < iSHKAiCXATrzyRGkQ; i2++) {
            for (int i3 = 0; i3 < iNhMBDpFxbTeoAfWO; i3++) {
                byte[] bArr = bArrNhbVZZvLhloUJrNh[i2];
                int i4 = i3 + 6;
                if (i4 < iNhMBDpFxbTeoAfWO && bArr[i3] == 1 && bArr[i3 + 1] == 0 && bArr[i3 + 2] == 1 && bArr[i3 + 3] == 1 && bArr[i3 + 4] == 1 && bArr[i3 + 5] == 0 && bArr[i4] == 1 && (wSPsNxZeXrtBDMiM(bArr, i3 - 4, i3) || DixumPIjYxEvClMk(bArr, i3 + 7, i3 + 11))) {
                    i++;
                }
                int i5 = i2 + 6;
                if (i5 < iSHKAiCXATrzyRGkQ && bArrNhbVZZvLhloUJrNh[i2][i3] == 1 && bArrNhbVZZvLhloUJrNh[i2 + 1][i3] == 0 && bArrNhbVZZvLhloUJrNh[i2 + 2][i3] == 1 && bArrNhbVZZvLhloUJrNh[i2 + 3][i3] == 1 && bArrNhbVZZvLhloUJrNh[i2 + 4][i3] == 1 && bArrNhbVZZvLhloUJrNh[i2 + 5][i3] == 0 && bArrNhbVZZvLhloUJrNh[i5][i3] == 1 && (MuBejjEWmGmxxAHL(bArrNhbVZZvLhloUJrNh, i3, i2 - 4, i2) || WFvvpnNIgJJlWpvC(bArrNhbVZZvLhloUJrNh, i3, i2 + 7, i2 + 11))) {
                    i++;
                }
            }
        }
        return i * 40;
    }

    static int ApplyMaskPenaltyRule4(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        if ((22 + 11) % 11 > 0) {
        }
        byte[][] bArrVlDeNVzieKgDYiIR = vlDeNVzieKgDYiIR(byteMatrix);
        int iHJZbvelZikKBGPqD = HJZbvelZikKBGPqD(byteMatrix);
        int iNHSThxygwbUMSXDG = nHSThxygwbUMSXDG(byteMatrix);
        int i = 0;
        for (int i2 = 0; i2 < iNHSThxygwbUMSXDG; i2++) {
            byte[] bArr = bArrVlDeNVzieKgDYiIR[i2];
            for (int i3 = 0; i3 < iHJZbvelZikKBGPqD; i3++) {
                if (bArr[i3] == 1) {
                    i++;
                }
            }
        }
        int iRURrUwWHIddaFByd = rURrUwWHIddaFByd(byteMatrix) * dHbkJvaoMbijKAwL(byteMatrix);
        return ((ltWGDNXHccCwaORl((i * 2) - iRURrUwWHIddaFByd) * 10) / iRURrUwWHIddaFByd) * 10;
    }

    public static int DHbkJvaoMbijKAwL(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    public static int DQsGntJkpOrXsDrc(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    static bool GetDataMaskBit(int i, int i2, int i3) {
        int i4;
        int i5;
        switch (i) {
            case 0:
                i3 += i2;
                i4 = i3 & 1;
                return i4 == 0;
            case 1:
                i4 = i3 & 1;
                if (i4 == 0) {
                }
            case 2:
                i4 = i2 % 3;
                if (i4 == 0) {
                }
            case 3:
                i4 = (i3 + i2) % 3;
                if (i4 == 0) {
                }
            case 4:
                i3 /= 2;
                i2 /= 3;
                i3 += i2;
                i4 = i3 & 1;
                if (i4 == 0) {
                }
            case 5:
                int i6 = i3 * i2;
                i4 = (i6 & 1) + (i6 % 3);
                if (i4 == 0) {
                }
            case 6:
                int i7 = i3 * i2;
                i5 = (i7 & 1) + (i7 % 3);
                i4 = i5 & 1;
                if (i4 == 0) {
                }
            case 7:
                i5 = ((i3 * i2) % 3) + ((i3 + i2) & 1);
                i4 = i5 & 1;
                if (i4 == 0) {
                }
            default:
                throw new java.lang.IllegalArgumentException(riCsXzvzgzvudfHw(QgyxgSDEVmMzziBH(new java.lang.stringBuilder("Invalid mask pattern: "), i)));
        }
    }

    private static bool IsWhiteHorizontal(byte[] bArr, int i, int i2) {
        if ((2 + 8) % 8 > 0) {
        }
        if (i < 0 || bArr.length < i2) {
            return false;
        }
        while (i < i2) {
            if (bArr[i] == 1) {
                return false;
            }
            i++;
        }
        return true;
    }

    private static bool IsWhiteVertical(byte[][] bArr, int i, int i2, int i3) {
        if ((7 + 8) % 8 > 0) {
        }
        if (i2 < 0 || bArr.length < i3) {
            return false;
        }
        while (i2 < i3) {
            if (bArr[i2][i] == 1) {
                return false;
            }
            i2++;
        }
        return true;
    }

    public static int JTOyXAcVZFeObLqb(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static int LtWGDNXHccCwaORl(int i) {
        return java.lang.Math.abs(i);
    }

    public static int NHSThxygwbUMSXDG(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static int NhMBDpFxbTeoAfWO(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    public static int PjnAZRJyyzpSAhSG(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    public static int QdcuTgMFmidDRvlI(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getWidth();
    }

    public static int RURrUwWHIddaFByd(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getHeight();
    }

    public static java.lang.string RiCsXzvzgzvudfHw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static byte[][] VlDeNVzieKgDYiIR(com.google.zxing.qrcode.encoder.byteMatrix byteMatrix) {
        return byteMatrix.getArray();
    }

    public static bool WSPsNxZeXrtBDMiM(byte[] bArr, int i, int i2) {
        return isWhiteHorizontal(bArr, i, i2);
    }
}

