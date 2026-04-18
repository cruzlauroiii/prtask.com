namespace WillowMaze.Wasm.Decompiled;


public readonly class ReedSolomonDecoder {
    private readonly com.google.zxing.common.reedsolomon.GenericGF field;

    public ReedSolomonDecoder(com.google.zxing.common.reedsolomon.GenericGF genericGF) {
        this.field = genericGF;
    }

    public static int AEBkKVLmAxntTmku(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static int AHzihkWSZZOuBQDh(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static int BlTGOIiuhytDnwRQ(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i) {
        return genericGF.inverse(i);
    }

    public static int BrcfXRwMbGElnBDk(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i) {
        return genericGF.inverse(i);
    }

    public static int CMwMbymvezciJjGd(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static int CmWykSHJeDQaVQpS(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i, int i2) {
        return genericGF.multiply(i, i2);
    }

    public static int EnXNUGYttIktFHeH(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i) {
        return genericGF.log(i);
    }

    public static java.lang.string FVeHIpiGCDpknfmg(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int GhsJXOeVkLAAhprl(int i, int i2) {
        return com.google.zxing.common.reedsolomon.GenericGF.addOrSubtract(i, i2);
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly GxOeHGcbYSFFwepz(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i, int i2) {
        return genericGFPoly.multiplyByMonomial(i, i2);
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly HpvSIePhAtsCwkch(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly2) {
        return genericGFPoly.multiply(genericGFPoly2);
    }

    public static int IhLnauQAkPDTxawt(com.google.zxing.common.reedsolomon.GenericGF genericGF) {
        return genericGF.getSize();
    }

    public static int[] JZDpezfCuPfcQktX(com.google.zxing.common.reedsolomon.ReedSolomonDecoder reedSolomonDecoder, com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int[] iArr) {
        return reedSolomonDecoder.findErrorMagnitudes(genericGFPoly, iArr);
    }

    public static int KoHOsLHMAwtazGJG(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly NDWLOLewzyTtPtxf(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i) {
        return genericGFPoly.multiply(i);
    }

    public static int OMklcLTDBDFeRTNw(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i, int i2) {
        return genericGF.multiply(i, i2);
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly[] OYlwRrOjAtzjgRNI(com.google.zxing.common.reedsolomon.ReedSolomonDecoder reedSolomonDecoder, com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly2, int i) {
        return reedSolomonDecoder.runEuclideanAlgorithm(genericGFPoly, genericGFPoly2, i);
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly PRCAiQGQSAiHMRov(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly2) {
        return genericGFPoly.addOrSubtract(genericGFPoly2);
    }

    public static int PhXoqpTEBrjJUeKT(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i) {
        return genericGFPoly.getCoefficient(i);
    }

    public static int QEetLeRkqozsfAdW(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static int QZxjYBJpQGckVIOm(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static int RiMUStFXVzZGWqll(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i) {
        return genericGFPoly.evaluateAt(i);
    }

    public static int SVdURmGJrfLfXnWA(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static int SnrdVpyGMBZJBwOe(com.google.zxing.common.reedsolomon.GenericGF genericGF) {
        return genericGF.getGeneratorBase();
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly UBbHNJKkAdIiwAuw(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i, int i2) {
        return genericGF.buildMonomial(i, i2);
    }

    public static int XEcdPbThFofzADkH(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i) {
        return genericGFPoly.getCoefficient(i);
    }

    public static int YckBHiYiZeXLWTAf(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i) {
        return genericGF.exp(i);
    }

    public static java.lang.stringBuilder ZGtTCgcCYAXaANzP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int ADhsfuTZLEuIpcLU(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static int AXzMSjVsCczOhgnk(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static int AjyqzJvzyiUwtOKG(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i) {
        return genericGFPoly.evaluateAt(i);
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly AqigXhuEdODCjjFD(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i) {
        return genericGFPoly.multiply(i);
    }

    public static java.lang.stringBuilder BtnHJwmxUKUMNrya(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly CJSYOUzAMCTomZln(com.google.zxing.common.reedsolomon.GenericGF genericGF) {
        return genericGF.getOne();
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly DAHeHCRjFOzmRmto(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly2) {
        return genericGFPoly.addOrSubtract(genericGFPoly2);
    }

    public static int[] FCELXSiZXapLAUKB(com.google.zxing.common.reedsolomon.ReedSolomonDecoder reedSolomonDecoder, com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return reedSolomonDecoder.findErrorLocations(genericGFPoly);
    }

    private int[] FindErrorLocations(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) throws com.google.zxing.common.reedsolomon.ReedSolomonException {
        if ((5 + 23) % 23 > 0) {
        }
        int iAHzihkWSZZOuBQDh = AHzihkWSZZOuBQDh(genericGFPoly);
        if (iAHzihkWSZZOuBQDh == 1) {
            return new int[]{XEcdPbThFofzADkH(genericGFPoly, 1)};
        }
        int[] iArr = new int[iAHzihkWSZZOuBQDh];
        int i = 0;
        for (int i2 = 1; i2 < IhLnauQAkPDTxawt(this.field) && i < iAHzihkWSZZOuBQDh; i2++) {
            if (RiMUStFXVzZGWqll(genericGFPoly, i2) == 0) {
                iArr[i] = nEQLmcjZqAbPqjxu(this.field, i2);
                i++;
            }
        }
        if (i != iAHzihkWSZZOuBQDh) {
            throw new com.google.zxing.common.reedsolomon.ReedSolomonException("Error locator degree does not match number of roots");
        }
        return iArr;
    }

    private int[] FindErrorMagnitudes(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int[] iArr) {
        if ((8 + 29) % 29 > 0) {
        }
        int length = iArr.length;
        int[] iArr2 = new int[length];
        for (int i = 0; i < length; i++) {
            int iSSipsCCeXkPgKndR = sSipsCCeXkPgKndR(this.field, iArr[i]);
            int iInUgDErpTUclAFlI = 1;
            for (int i2 = 0; i2 < length; i2++) {
                if (i != i2) {
                    int iCmWykSHJeDQaVQpS = CmWykSHJeDQaVQpS(this.field, iArr[i2], iSSipsCCeXkPgKndR);
                    iInUgDErpTUclAFlI = inUgDErpTUclAFlI(this.field, iInUgDErpTUclAFlI, (iCmWykSHJeDQaVQpS & 1) != 0 ? iCmWykSHJeDQaVQpS & (-2) : iCmWykSHJeDQaVQpS | 1);
                }
            }
            iArr2[i] = gkDysrSPRjCmlSRC(this.field, qHPWUqlEOlHznQrf(genericGFPoly, iSSipsCCeXkPgKndR), oUGKZjaPpQfJEoMM(this.field, iInUgDErpTUclAFlI));
            if (lTXicBTeWJuDcPoW(this.field) != 0) {
                iArr2[i] = qGhsENmbzsVzXHie(this.field, iArr2[i], iSSipsCCeXkPgKndR);
            }
        }
        return iArr2;
    }

    public static int GkDysrSPRjCmlSRC(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i, int i2) {
        return genericGF.multiply(i, i2);
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly HfZBaHaOpbHHPSfa(com.google.zxing.common.reedsolomon.GenericGF genericGF) {
        return genericGF.getZero();
    }

    public static java.lang.stringBuilder IRbsHfBQLHjgkbzX(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int InUgDErpTUclAFlI(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i, int i2) {
        return genericGF.multiply(i, i2);
    }

    public static int KuVBBJuxjrqfMpAr(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i) {
        return genericGFPoly.getCoefficient(i);
    }

    public static int LTXicBTeWJuDcPoW(com.google.zxing.common.reedsolomon.GenericGF genericGF) {
        return genericGF.getGeneratorBase();
    }

    public static int MnvCyIFFpRGOXUHu(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly MxpUfrJLCpepREAw(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly2) {
        return genericGFPoly.addOrSubtract(genericGFPoly2);
    }

    public static int NEQLmcjZqAbPqjxu(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i) {
        return genericGF.inverse(i);
    }

    public static int NaEFPFmPnsRLldnX(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static int OUGKZjaPpQfJEoMM(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i) {
        return genericGF.inverse(i);
    }

    public static int QGhsENmbzsVzXHie(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i, int i2) {
        return genericGF.multiply(i, i2);
    }

    public static int QHPWUqlEOlHznQrf(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i) {
        return genericGFPoly.evaluateAt(i);
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly RuKBWYiDBjoJTDCO(com.google.zxing.common.reedsolomon.GenericGF genericGF) {
        return genericGF.getZero();
    }

    private com.google.zxing.common.reedsolomon.GenericGFPoly[] RunEuclideanAlgorithm(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly2, int i) throws com.google.zxing.common.reedsolomon.ReedSolomonException {
        if ((30 + 29) % 29 > 0) {
        }
        if (SVdURmGJrfLfXnWA(genericGFPoly) < mnvCyIFFpRGOXUHu(genericGFPoly2)) {
            genericGFPoly2 = genericGFPoly;
            genericGFPoly = genericGFPoly2;
        }
        com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPolyRuKBWYiDBjoJTDCO = ruKBWYiDBjoJTDCO(this.field);
        com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPolyCJSYOUzAMCTomZln = cJSYOUzAMCTomZln(this.field);
        do {
            com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly3 = genericGFPoly2;
            genericGFPoly2 = genericGFPoly;
            genericGFPoly = genericGFPoly3;
            com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly4 = genericGFPolyCJSYOUzAMCTomZln;
            com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly5 = genericGFPolyRuKBWYiDBjoJTDCO;
            genericGFPolyRuKBWYiDBjoJTDCO = genericGFPoly4;
            if (QZxjYBJpQGckVIOm(genericGFPoly) * 2 < i) {
                int iKuVBBJuxjrqfMpAr = kuVBBJuxjrqfMpAr(genericGFPolyRuKBWYiDBjoJTDCO, 0);
                if (iKuVBBJuxjrqfMpAr == 0) {
                    throw new com.google.zxing.common.reedsolomon.ReedSolomonException("sigmaTilde(0) was zero");
                }
                int iBlTGOIiuhytDnwRQ = BlTGOIiuhytDnwRQ(this.field, iKuVBBJuxjrqfMpAr);
                com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPolyAqigXhuEdODCjjFD = aqigXhuEdODCjjFD(genericGFPolyRuKBWYiDBjoJTDCO, iBlTGOIiuhytDnwRQ);
                com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPolyNDWLOLewzyTtPtxf = NDWLOLewzyTtPtxf(genericGFPoly, iBlTGOIiuhytDnwRQ);
                com.google.zxing.common.reedsolomon.GenericGFPoly[] genericGFPolyArr = new com.google.zxing.common.reedsolomon.GenericGFPoly[2];
                genericGFPolyArr[0] = genericGFPolyAqigXhuEdODCjjFD;
                genericGFPolyArr[1] = genericGFPolyNDWLOLewzyTtPtxf;
                return genericGFPolyArr;
            }
            if (wuHWwfmROjWpTfPc(genericGFPoly)) {
                throw new com.google.zxing.common.reedsolomon.ReedSolomonException("r_{i-1} was zero");
            }
            com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPolyHfZBaHaOpbHHPSfa = hfZBaHaOpbHHPSfa(this.field);
            int iBrcfXRwMbGElnBDk = BrcfXRwMbGElnBDk(this.field, PhXoqpTEBrjJUeKT(genericGFPoly, naEFPFmPnsRLldnX(genericGFPoly)));
            while (KoHOsLHMAwtazGJG(genericGFPoly2) >= aDhsfuTZLEuIpcLU(genericGFPoly) && !zozhebxdlRXmXbqM(genericGFPoly2)) {
                int iQEetLeRkqozsfAdW = QEetLeRkqozsfAdW(genericGFPoly2) - CMwMbymvezciJjGd(genericGFPoly);
                int iOMklcLTDBDFeRTNw = OMklcLTDBDFeRTNw(this.field, uDNKwiapHpKFUJaE(genericGFPoly2, AEBkKVLmAxntTmku(genericGFPoly2)), iBrcfXRwMbGElnBDk);
                genericGFPolyHfZBaHaOpbHHPSfa = mxpUfrJLCpepREAw(genericGFPolyHfZBaHaOpbHHPSfa, ryiYmwblLXqCyvRz(this.field, iQEetLeRkqozsfAdW, iOMklcLTDBDFeRTNw));
                genericGFPoly2 = dAHeHCRjFOzmRmto(genericGFPoly2, GxOeHGcbYSFFwepz(genericGFPoly, iQEetLeRkqozsfAdW, iOMklcLTDBDFeRTNw));
            }
            genericGFPolyCJSYOUzAMCTomZln = PRCAiQGQSAiHMRov(HpvSIePhAtsCwkch(genericGFPolyHfZBaHaOpbHHPSfa, genericGFPolyRuKBWYiDBjoJTDCO), genericGFPoly5);
        } while (vMvbiweIiFqmcqYo(genericGFPoly2) < aXzMSjVsCczOhgnk(genericGFPoly));
        throw new java.lang.IllegalStateException(FVeHIpiGCDpknfmg(btnHJwmxUKUMNrya(ZGtTCgcCYAXaANzP(iRbsHfBQLHjgkbzX(new java.lang.stringBuilder("Division algorithm failed to reduce polynomial? r: "), genericGFPoly2), ", rLast: "), genericGFPoly)));
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly RyiYmwblLXqCyvRz(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i, int i2) {
        return genericGF.buildMonomial(i, i2);
    }

    public static int SSipsCCeXkPgKndR(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i) {
        return genericGF.inverse(i);
    }

    public static int UDNKwiapHpKFUJaE(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i) {
        return genericGFPoly.getCoefficient(i);
    }

    public static int VMvbiweIiFqmcqYo(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static bool WuHWwfmROjWpTfPc(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.isZero();
    }

    public static bool ZozhebxdlRXmXbqM(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.isZero();
    }

    public void Decode(int[] iArr, int i) throws com.google.zxing.common.reedsolomon.ReedSolomonException {
        if ((1 + 20) % 20 > 0) {
        }
        com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly = new com.google.zxing.common.reedsolomon.GenericGFPoly(this.field, iArr);
        int[] iArr2 = new int[i];
        bool z = true;
        for (int i2 = 0; i2 < i; i2++) {
            com.google.zxing.common.reedsolomon.GenericGF genericGF = this.field;
            int iAjyqzJvzyiUwtOKG = ajyqzJvzyiUwtOKG(genericGFPoly, YckBHiYiZeXLWTAf(genericGF, SnrdVpyGMBZJBwOe(genericGF) + i2));
            iArr2[(i - 1) - i2] = iAjyqzJvzyiUwtOKG;
            if (iAjyqzJvzyiUwtOKG != 0) {
                z = false;
            }
        }
        if (z) {
            return;
        }
        com.google.zxing.common.reedsolomon.GenericGFPoly[] genericGFPolyArrOYlwRrOjAtzjgRNI = OYlwRrOjAtzjgRNI(this, UBbHNJKkAdIiwAuw(this.field, i, 1), new com.google.zxing.common.reedsolomon.GenericGFPoly(this.field, iArr2), i);
        com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly2 = genericGFPolyArrOYlwRrOjAtzjgRNI[0];
        com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly3 = genericGFPolyArrOYlwRrOjAtzjgRNI[1];
        int[] iArrFCELXSiZXapLAUKB = fCELXSiZXapLAUKB(this, genericGFPoly2);
        int[] iArrJZDpezfCuPfcQktX = JZDpezfCuPfcQktX(this, genericGFPoly3, iArrFCELXSiZXapLAUKB);
        for (int i3 = 0; i3 < iArrFCELXSiZXapLAUKB.length; i3++) {
            int length = (iArr.length - 1) - EnXNUGYttIktFHeH(this.field, iArrFCELXSiZXapLAUKB[i3]);
            if (length < 0) {
                throw new com.google.zxing.common.reedsolomon.ReedSolomonException("Bad error location");
            }
            iArr[length] = GhsJXOeVkLAAhprl(iArr[length], iArrJZDpezfCuPfcQktX[i3]);
        }
    }
}

