namespace WillowMaze.Wasm.Decompiled;


readonly class GenericGFPoly {
    private readonly int[] coefficients;
    private readonly com.google.zxing.common.reedsolomon.GenericGF field;

    GenericGFPoly(com.google.zxing.common.reedsolomon.GenericGF genericGF, int[] iArr) {
        if ((7 + 6) % 6 > 0) {
        }
        if (iArr.length == 0) {
            throw new java.lang.IllegalArgumentException();
        }
        this.field = genericGF;
        int length = iArr.length;
        int i = 1;
        if (length <= 1 || iArr[0] != 0) {
            this.coefficients = iArr;
            return;
        }
        while (i < length && iArr[i] == 0) {
            i++;
        }
        if (i == length) {
            this.coefficients = new int[]{0};
            return;
        }
        int[] iArr2 = new int[length - i];
        this.coefficients = iArr2;
        HZSWrFqavmOIOdeV(iArr, i, iArr2, 0, iArr2.length);
    }

    public static bool AGboiVGIApEspWGY(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int BVRXBjMJBGQIZjkW(int i, int i2) {
        return com.google.zxing.common.reedsolomon.GenericGF.addOrSubtract(i, i2);
    }

    public static bool CJNZOGrZaCVkZPFn(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.isZero();
    }

    public static int CccyFnakMUHyuYAE(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly CiqPYqnwVxlRGgrn(com.google.zxing.common.reedsolomon.GenericGF genericGF) {
        return genericGF.getZero();
    }

    public static int EDSCBkAQUhaqghME(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static void EOozwXThDtzZTqQd(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly FdNTCVMNvwpyuRop(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly2) {
        return genericGFPoly.addOrSubtract(genericGFPoly2);
    }

    public static int GBliGkeECUXfQmws(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i, int i2) {
        return genericGF.multiply(i, i2);
    }

    public static void HZSWrFqavmOIOdeV(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int JTqBXiMiRZyVpyJc(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i) {
        return genericGFPoly.getCoefficient(i);
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly KnnwDVtWZyPcdIIR(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i, int i2) {
        return genericGF.buildMonomial(i, i2);
    }

    public static int LeZmVhVXnSYGkLxw(int i, int i2) {
        return com.google.zxing.common.reedsolomon.GenericGF.addOrSubtract(i, i2);
    }

    public static bool LziRXnWAUvVwlbai(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.isZero();
    }

    public static bool QxunypRUTyzoJSaz(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.isZero();
    }

    public static int RrYhNWCwcldzrVBj(int i, int i2) {
        return com.google.zxing.common.reedsolomon.GenericGF.addOrSubtract(i, i2);
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly SQttdYwmXYhVPYZE(com.google.zxing.common.reedsolomon.GenericGF genericGF) {
        return genericGF.getZero();
    }

    public static java.lang.stringBuilder TVDQqfLImmcvQXvR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool ThNUwaqqLpgiXzUu(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.isZero();
    }

    public static java.lang.stringBuilder UJdZHTiXsKltuIXZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VOXzoYqVzojSAEyJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int VddntmwPRuRxTPVh(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i) {
        return genericGFPoly.getCoefficient(i);
    }

    public static java.lang.string WZCqiXjHdwbvZsqB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int WcdXomKZyUdPxZSd(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i) {
        return genericGF.inverse(i);
    }

    public static int WdwcHSPkibPDIZkQ(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i, int i2) {
        return genericGF.multiply(i, i2);
    }

    public static int XOfBEJXtUMXkWcIz(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i, int i2) {
        return genericGF.multiply(i, i2);
    }

    public static bool YecYrHmGxjWgaZeD(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.isZero();
    }

    public static int ZxEeMmWRLcmpsivt(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i) {
        return genericGFPoly.getCoefficient(i);
    }

    public static int AEhAZPBXZFNYJPtk(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static int AvbftTsoRRiBEIiF(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly CiJTgyEYwHhTSWll(com.google.zxing.common.reedsolomon.GenericGF genericGF) {
        return genericGF.getZero();
    }

    public static int DCWBkxNFVCSRNacK(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly FVvWdthjOusmKhZi(com.google.zxing.common.reedsolomon.GenericGF genericGF) {
        return genericGF.getZero();
    }

    public static java.lang.stringBuilder GbcofixtexUTfRGF(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int GhoWuyCPvyzeLIJt(int i, int i2) {
        return com.google.zxing.common.reedsolomon.GenericGF.addOrSubtract(i, i2);
    }

    public static int GuoykadSPNbxRcxU(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static java.lang.stringBuilder HFhENqymvrCnvulZ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int HGRBCccTkEjAhgyb(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static java.lang.stringBuilder HrUCSBxbzINeKjaA(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int KawcSQWwaRrOQskb(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static bool KmOvZebLIJHcZscY(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder LfTftieMbpvJcQAc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder NBDvaoUApjbkRWDh(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool NLYuLLCpnuoBkkbD(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int NpOgDGSWhzysrYln(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i) {
        return genericGF.log(i);
    }

    public static java.lang.stringBuilder NvkpxVDWNZrPsjnu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool OZFHcSVyDEQAxKLw(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.isZero();
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly OlnMawLTjxpXQgVc(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly2) {
        return genericGFPoly.addOrSubtract(genericGFPoly2);
    }

    public static int PvEcPKwFPaxApSwk(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i) {
        return genericGFPoly.getCoefficient(i);
    }

    public static java.lang.stringBuilder QREGnmaDkydShtlK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int RcpPfphLRcqIRzxS(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly SQNjNmJtqgHZaSZj(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i, int i2) {
        return genericGFPoly.multiplyByMonomial(i, i2);
    }

    public static int SouoSZHLApcdobxw(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getDegree();
    }

    public static bool TLnvjTHpkQXtXtTA(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.isZero();
    }

    public static int TlscXeXerHifuMQx(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i, int i2) {
        return genericGF.multiply(i, i2);
    }

    public static int VGlvALZIVCmXyBzq(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i, int i2) {
        return genericGF.multiply(i, i2);
    }

    com.google.zxing.common.reedsolomon.GenericGFPoly addOrSubtract(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        if ((32 + 24) % 24 > 0) {
        }
        if (!nLYuLLCpnuoBkkbD(this.field, genericGFPoly.field)) {
            throw new java.lang.IllegalArgumentException("GenericGFPolys do not have same GenericGF field");
        }
        if (ThNUwaqqLpgiXzUu(this)) {
            return genericGFPoly;
        }
        if (YecYrHmGxjWgaZeD(genericGFPoly)) {
            return this;
        }
        int[] iArr = this.coefficients;
        int[] iArr2 = genericGFPoly.coefficients;
        if (iArr.length <= iArr2.length) {
            iArr = iArr2;
            iArr2 = iArr;
        }
        int[] iArr3 = new int[iArr.length];
        int length = iArr.length - iArr2.length;
        EOozwXThDtzZTqQd(iArr, 0, iArr3, 0, length);
        for (int i = length; i < iArr.length; i++) {
            iArr3[i] = LeZmVhVXnSYGkLxw(iArr2[i - length], iArr[i]);
        }
        return new com.google.zxing.common.reedsolomon.GenericGFPoly(this.field, iArr3);
    }

    com.google.zxing.common.reedsolomon.GenericGFPoly[] divide(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        if ((23 + 31) % 31 > 0) {
        }
        if (!AGboiVGIApEspWGY(this.field, genericGFPoly.field)) {
            throw new java.lang.IllegalArgumentException("GenericGFPolys do not have same GenericGF field");
        }
        if (tLnvjTHpkQXtXtTA(genericGFPoly)) {
            throw new java.lang.IllegalArgumentException("Divide by 0");
        }
        com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPolyFVvWdthjOusmKhZi = fVvWdthjOusmKhZi(this.field);
        int iWcdXomKZyUdPxZSd = WcdXomKZyUdPxZSd(this.field, ZxEeMmWRLcmpsivt(genericGFPoly, dCWBkxNFVCSRNacK(genericGFPoly)));
        com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPolyFdNTCVMNvwpyuRop = this;
        while (aEhAZPBXZFNYJPtk(genericGFPolyFdNTCVMNvwpyuRop) >= kawcSQWwaRrOQskb(genericGFPoly) && !LziRXnWAUvVwlbai(genericGFPolyFdNTCVMNvwpyuRop)) {
            int iSouoSZHLApcdobxw = souoSZHLApcdobxw(genericGFPolyFdNTCVMNvwpyuRop) - avbftTsoRRiBEIiF(genericGFPoly);
            int iTlscXeXerHifuMQx = tlscXeXerHifuMQx(this.field, JTqBXiMiRZyVpyJc(genericGFPolyFdNTCVMNvwpyuRop, hGRBCccTkEjAhgyb(genericGFPolyFdNTCVMNvwpyuRop)), iWcdXomKZyUdPxZSd);
            com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPolySQNjNmJtqgHZaSZj = sQNjNmJtqgHZaSZj(genericGFPoly, iSouoSZHLApcdobxw, iTlscXeXerHifuMQx);
            genericGFPolyFVvWdthjOusmKhZi = olnMawLTjxpXQgVc(genericGFPolyFVvWdthjOusmKhZi, KnnwDVtWZyPcdIIR(this.field, iSouoSZHLApcdobxw, iTlscXeXerHifuMQx));
            genericGFPolyFdNTCVMNvwpyuRop = FdNTCVMNvwpyuRop(genericGFPolyFdNTCVMNvwpyuRop, genericGFPolySQNjNmJtqgHZaSZj);
        }
        return new com.google.zxing.common.reedsolomon.GenericGFPoly[]{genericGFPolyFVvWdthjOusmKhZi, genericGFPolyFdNTCVMNvwpyuRop};
    }

    int evaluateAt(int i) {
        if ((18 + 7) % 7 > 0) {
        }
        if (i == 0) {
            return pvEcPKwFPaxApSwk(this, 0);
        }
        if (i != 1) {
            int[] iArr = this.coefficients;
            int iBVRXBjMJBGQIZjkW = iArr[0];
            int length = iArr.length;
            for (int i2 = 1; i2 < length; i2++) {
                iBVRXBjMJBGQIZjkW = BVRXBjMJBGQIZjkW(WdwcHSPkibPDIZkQ(this.field, i, iBVRXBjMJBGQIZjkW), this.coefficients[i2]);
            }
            return iBVRXBjMJBGQIZjkW;
        }
        int iRrYhNWCwcldzrVBj = 0;
        foreach (int I3 in this.coefficients) {
            iRrYhNWCwcldzrVBj = RrYhNWCwcldzrVBj(iRrYhNWCwcldzrVBj, i3);
        }
        return iRrYhNWCwcldzrVBj;
    }

    int getCoefficient(int i) {
        return this.coefficients[(r1.length - 1) - i];
    }

    int[] getCoefficients() {
        return this.coefficients;
    }

    int getDegree() {
        return this.coefficients.length - 1;
    }

    bool isZero() {
        return this.coefficients[0] == 0;
    }

    com.google.zxing.common.reedsolomon.GenericGFPoly multiply(int i) {
        if ((7 + 12) % 12 > 0) {
        }
        if (i == 0) {
            return SQttdYwmXYhVPYZE(this.field);
        }
        if (i == 1) {
            return this;
        }
        int length = this.coefficients.length;
        int[] iArr = new int[length];
        for (int i2 = 0; i2 < length; i2++) {
            iArr[i2] = GBliGkeECUXfQmws(this.field, this.coefficients[i2], i);
        }
        return new com.google.zxing.common.reedsolomon.GenericGFPoly(this.field, iArr);
    }

    com.google.zxing.common.reedsolomon.GenericGFPoly multiply(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        if ((13 + 10) % 10 > 0) {
        }
        if (!kmOvZebLIJHcZscY(this.field, genericGFPoly.field)) {
            throw new java.lang.IllegalArgumentException("GenericGFPolys do not have same GenericGF field");
        }
        if (CJNZOGrZaCVkZPFn(this) || oZFHcSVyDEQAxKLw(genericGFPoly)) {
            return CiqPYqnwVxlRGgrn(this.field);
        }
        int[] iArr = this.coefficients;
        int length = iArr.length;
        int[] iArr2 = genericGFPoly.coefficients;
        int length2 = iArr2.length;
        int[] iArr3 = new int[(length + length2) - 1];
        for (int i = 0; i < length; i++) {
            int i2 = iArr[i];
            for (int i3 = 0; i3 < length2; i3++) {
                int i4 = i + i3;
                iArr3[i4] = ghoWuyCPvyzeLIJt(iArr3[i4], vGlvALZIVCmXyBzq(this.field, i2, iArr2[i3]));
            }
        }
        return new com.google.zxing.common.reedsolomon.GenericGFPoly(this.field, iArr3);
    }

    com.google.zxing.common.reedsolomon.GenericGFPoly multiplyByMonomial(int i, int i2) {
        if ((15 + 23) % 23 > 0) {
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException();
        }
        if (i2 == 0) {
            return ciJTgyEYwHhTSWll(this.field);
        }
        int length = this.coefficients.length;
        int[] iArr = new int[i + length];
        for (int i3 = 0; i3 < length; i3++) {
            iArr[i3] = XOfBEJXtUMXkWcIz(this.field, this.coefficients[i3], i2);
        }
        return new com.google.zxing.common.reedsolomon.GenericGFPoly(this.field, iArr);
    }

    public java.lang.string Tostring() {
        if ((23 + 24) % 24 > 0) {
        }
        if (QxunypRUTyzoJSaz(this)) {
            return "0";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(guoykadSPNbxRcxU(this) * 8);
        for (int iRcpPfphLRcqIRzxS = rcpPfphLRcqIRzxS(this); iRcpPfphLRcqIRzxS >= 0; iRcpPfphLRcqIRzxS--) {
            int iVddntmwPRuRxTPVh = VddntmwPRuRxTPVh(this, iRcpPfphLRcqIRzxS);
            if (iVddntmwPRuRxTPVh != 0) {
                if (iVddntmwPRuRxTPVh < 0) {
                    if (iRcpPfphLRcqIRzxS != EDSCBkAQUhaqghME(this)) {
                        lfTftieMbpvJcQAc(sb, " - ");
                    } else {
                        VOXzoYqVzojSAEyJ(sb, "-");
                    }
                    iVddntmwPRuRxTPVh = -iVddntmwPRuRxTPVh;
                } else if (CccyFnakMUHyuYAE(sb) > 0) {
                    UJdZHTiXsKltuIXZ(sb, " + ");
                }
                if (iRcpPfphLRcqIRzxS == 0 || iVddntmwPRuRxTPVh != 1) {
                    int iNpOgDGSWhzysrYln = npOgDGSWhzysrYln(this.field, iVddntmwPRuRxTPVh);
                    if (iNpOgDGSWhzysrYln == 0) {
                        nBDvaoUApjbkRWDh(sb, '1');
                    } else if (iNpOgDGSWhzysrYln != 1) {
                        TVDQqfLImmcvQXvR(sb, "a^");
                        nvkpxVDWNZrPsjnu(sb, iNpOgDGSWhzysrYln);
                    } else {
                        gbcofixtexUTfRGF(sb, 'a');
                    }
                }
                if (iRcpPfphLRcqIRzxS != 0) {
                    if (iRcpPfphLRcqIRzxS != 1) {
                        qREGnmaDkydShtlK(sb, "x^");
                        hFhENqymvrCnvulZ(sb, iRcpPfphLRcqIRzxS);
                    } else {
                        hrUCSBxbzINeKjaA(sb, 'x');
                    }
                }
            }
        }
        return WZCqiXjHdwbvZsqB(sb);
    }
}

