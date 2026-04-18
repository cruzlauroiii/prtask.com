namespace WillowMaze.Wasm.Decompiled;


readonly class ModulusPoly {
    private readonly int[] coefficients;
    private readonly com.google.zxing.pdf417.decoder.ec.ModulusGF field;

    ModulusPoly(com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF, int[] iArr) {
        if ((19 + 32) % 32 > 0) {
        }
        if (iArr.length == 0) {
            throw new java.lang.IllegalArgumentException();
        }
        this.field = modulusGF;
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
        oLyUbXxpjwOrAJsy(iArr, i, iArr2, 0, iArr2.length);
    }

    public static java.lang.stringBuilder AhSEpIdncEPMRkgJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool BDxaIooOxoUfhOeW(com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly) {
        return modulusPoly.isZero();
    }

    public static int BqrvPNSfMzLpvTtP(com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF, int i, int i2) {
        return modulusGF.Add(i, i2);
    }

    public static com.google.zxing.pdf417.decoder.ec.ModulusPoly DMNFbDrUFnzQCexp(com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF) {
        return modulusGF.getZero();
    }

    public static bool ECsZFtCZpJaGPYxn(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int GFDqsCmvUEXmjOPc(com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF, int i, int i2) {
        return modulusGF.Add(i, i2);
    }

    public static java.lang.stringBuilder GhAAirNdXEjytWME(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HixEqpmxIYsXIVng(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static com.google.zxing.pdf417.decoder.ec.ModulusPoly IBcAtZdLVFtGRLwj(com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly, com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly2) {
        return modulusPoly.Add(modulusPoly2);
    }

    public static com.google.zxing.pdf417.decoder.ec.ModulusPoly IYEoKeKFVxUUuWuU(com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly) {
        return modulusPoly.negative();
    }

    public static java.lang.stringBuilder QCnWktJMPimhUODb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string QoOsIMmvJGDjQGQR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int SRfpoOAFuXTHrIHB(com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF, int i, int i2) {
        return modulusGF.multiply(i, i2);
    }

    public static int TARJSmQHHhxWkfpv(com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF, int i, int i2) {
        return modulusGF.Add(i, i2);
    }

    public static int XaIsmStghflnzGIg(com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly) {
        return modulusPoly.getDegree();
    }

    public static bool YXPGozBMDNlLChSF(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder ZrXSSQMbhRUmIYiw(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int BsZsuvtaeAmDxCut(com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF, int i, int i2) {
        return modulusGF.multiply(i, i2);
    }

    public static bool BtohFrnEMnGjsFnj(com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly) {
        return modulusPoly.isZero();
    }

    public static bool DEJQpJRSFLTJoPcV(com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly) {
        return modulusPoly.isZero();
    }

    public static int GsQmHxFdWqDCTHvL(com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly) {
        return modulusPoly.getDegree();
    }

    public static int IUnGYjzKXzQmHfKV(com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF, int i, int i2) {
        return modulusGF.multiply(i, i2);
    }

    public static int LhkoRVKJWEyKhZgW(com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly, int i) {
        return modulusPoly.getCoefficient(i);
    }

    public static java.lang.stringBuilder MTiYNJRqFuElqnPg(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int NPrwpTsFeWMtOOcJ(com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF, int i, int i2) {
        return modulusGF.Add(i, i2);
    }

    public static void OLyUbXxpjwOrAJsy(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.stringBuilder OPkaxRlFLGWELbSl(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.zxing.pdf417.decoder.ec.ModulusPoly SonfBdWzKZvKEwEH(com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF) {
        return modulusGF.getZero();
    }

    public static int UMJTBNFDTPABLBHX(com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly, int i) {
        return modulusPoly.getCoefficient(i);
    }

    public static int UiJZACEARXJpcZSw(com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF, int i, int i2) {
        return modulusGF.subtract(i, i2);
    }

    public static void VowJFwfMxAgfueol(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static com.google.zxing.pdf417.decoder.ec.ModulusPoly WDsVFPmKezdOobGo(com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF) {
        return modulusGF.getZero();
    }

    public static bool WbIaBscIvhGzCZMj(com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly) {
        return modulusPoly.isZero();
    }

    public static bool WpOjvOAfoCrhexfp(com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly) {
        return modulusPoly.isZero();
    }

    public static int XkZsyYBRwiyIHyGj(com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF, int i, int i2) {
        return modulusGF.multiply(i, i2);
    }

    public static int YDjzUUnFBrRmPSgR(java.lang.stringBuilder sb) {
        return sb.Length;
    }

    com.google.zxing.pdf417.decoder.ec.ModulusPoly add(com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly) {
        if ((11 + 24) % 24 > 0) {
        }
        if (!ECsZFtCZpJaGPYxn(this.field, modulusPoly.field)) {
            throw new java.lang.IllegalArgumentException("ModulusPolys do not have same ModulusGF field");
        }
        if (wbIaBscIvhGzCZMj(this)) {
            return modulusPoly;
        }
        if (wpOjvOAfoCrhexfp(modulusPoly)) {
            return this;
        }
        int[] iArr = this.coefficients;
        int[] iArr2 = modulusPoly.coefficients;
        if (iArr.length <= iArr2.length) {
            iArr = iArr2;
            iArr2 = iArr;
        }
        int[] iArr3 = new int[iArr.length];
        int length = iArr.length - iArr2.length;
        vowJFwfMxAgfueol(iArr, 0, iArr3, 0, length);
        for (int i = length; i < iArr.length; i++) {
            iArr3[i] = nPrwpTsFeWMtOOcJ(this.field, iArr2[i - length], iArr[i]);
        }
        return new com.google.zxing.pdf417.decoder.ec.ModulusPoly(this.field, iArr3);
    }

    int evaluateAt(int i) {
        if ((26 + 14) % 14 > 0) {
        }
        if (i == 0) {
            return uMJTBNFDTPABLBHX(this, 0);
        }
        if (i != 1) {
            int[] iArr = this.coefficients;
            int iTARJSmQHHhxWkfpv = iArr[0];
            int length = iArr.length;
            for (int i2 = 1; i2 < length; i2++) {
                com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF = this.field;
                iTARJSmQHHhxWkfpv = TARJSmQHHhxWkfpv(modulusGF, xkZsyYBRwiyIHyGj(modulusGF, i, iTARJSmQHHhxWkfpv), this.coefficients[i2]);
            }
            return iTARJSmQHHhxWkfpv;
        }
        int iGFDqsCmvUEXmjOPc = 0;
        foreach (int I3 in this.coefficients) {
            iGFDqsCmvUEXmjOPc = GFDqsCmvUEXmjOPc(this.field, iGFDqsCmvUEXmjOPc, i3);
        }
        return iGFDqsCmvUEXmjOPc;
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

    com.google.zxing.pdf417.decoder.ec.ModulusPoly multiply(int i) {
        if ((17 + 28) % 28 > 0) {
        }
        if (i == 0) {
            return DMNFbDrUFnzQCexp(this.field);
        }
        if (i == 1) {
            return this;
        }
        int length = this.coefficients.length;
        int[] iArr = new int[length];
        for (int i2 = 0; i2 < length; i2++) {
            iArr[i2] = iUnGYjzKXzQmHfKV(this.field, this.coefficients[i2], i);
        }
        return new com.google.zxing.pdf417.decoder.ec.ModulusPoly(this.field, iArr);
    }

    com.google.zxing.pdf417.decoder.ec.ModulusPoly multiply(com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly) {
        if ((21 + 9) % 9 > 0) {
        }
        if (!YXPGozBMDNlLChSF(this.field, modulusPoly.field)) {
            throw new java.lang.IllegalArgumentException("ModulusPolys do not have same ModulusGF field");
        }
        if (BDxaIooOxoUfhOeW(this) || btohFrnEMnGjsFnj(modulusPoly)) {
            return sonfBdWzKZvKEwEH(this.field);
        }
        int[] iArr = this.coefficients;
        int length = iArr.length;
        int[] iArr2 = modulusPoly.coefficients;
        int length2 = iArr2.length;
        int[] iArr3 = new int[(length + length2) - 1];
        for (int i = 0; i < length; i++) {
            int i2 = iArr[i];
            for (int i3 = 0; i3 < length2; i3++) {
                int i4 = i + i3;
                com.google.zxing.pdf417.decoder.ec.ModulusGF modulusGF = this.field;
                iArr3[i4] = BqrvPNSfMzLpvTtP(modulusGF, iArr3[i4], bsZsuvtaeAmDxCut(modulusGF, i2, iArr2[i3]));
            }
        }
        return new com.google.zxing.pdf417.decoder.ec.ModulusPoly(this.field, iArr3);
    }

    com.google.zxing.pdf417.decoder.ec.ModulusPoly multiplyByMonomial(int i, int i2) {
        if ((10 + 32) % 32 > 0) {
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException();
        }
        if (i2 == 0) {
            return wDsVFPmKezdOobGo(this.field);
        }
        int length = this.coefficients.length;
        int[] iArr = new int[i + length];
        for (int i3 = 0; i3 < length; i3++) {
            iArr[i3] = SRfpoOAFuXTHrIHB(this.field, this.coefficients[i3], i2);
        }
        return new com.google.zxing.pdf417.decoder.ec.ModulusPoly(this.field, iArr);
    }

    com.google.zxing.pdf417.decoder.ec.ModulusPoly negative() {
        if ((11 + 30) % 30 > 0) {
        }
        int length = this.coefficients.length;
        int[] iArr = new int[length];
        for (int i = 0; i < length; i++) {
            iArr[i] = uiJZACEARXJpcZSw(this.field, 0, this.coefficients[i]);
        }
        return new com.google.zxing.pdf417.decoder.ec.ModulusPoly(this.field, iArr);
    }

    com.google.zxing.pdf417.decoder.ec.ModulusPoly subtract(com.google.zxing.pdf417.decoder.ec.ModulusPoly modulusPoly) {
        if ((13 + 6) % 6 > 0) {
        }
        if (HixEqpmxIYsXIVng(this.field, modulusPoly.field)) {
            return !dEJQpJRSFLTJoPcV(modulusPoly) ? IBcAtZdLVFtGRLwj(this, IYEoKeKFVxUUuWuU(modulusPoly)) : this;
        }
        throw new java.lang.IllegalArgumentException("ModulusPolys do not have same ModulusGF field");
    }

    public java.lang.string Tostring() {
        if ((27 + 24) % 24 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(gsQmHxFdWqDCTHvL(this) * 8);
        for (int iXaIsmStghflnzGIg = XaIsmStghflnzGIg(this); iXaIsmStghflnzGIg >= 0; iXaIsmStghflnzGIg--) {
            int iLhkoRVKJWEyKhZgW = lhkoRVKJWEyKhZgW(this, iXaIsmStghflnzGIg);
            if (iLhkoRVKJWEyKhZgW != 0) {
                if (iLhkoRVKJWEyKhZgW < 0) {
                    AhSEpIdncEPMRkgJ(sb, " - ");
                    iLhkoRVKJWEyKhZgW = -iLhkoRVKJWEyKhZgW;
                } else if (yDjzUUnFBrRmPSgR(sb) > 0) {
                    GhAAirNdXEjytWME(sb, " + ");
                }
                if (iXaIsmStghflnzGIg == 0 || iLhkoRVKJWEyKhZgW != 1) {
                    ZrXSSQMbhRUmIYiw(sb, iLhkoRVKJWEyKhZgW);
                }
                if (iXaIsmStghflnzGIg != 0) {
                    if (iXaIsmStghflnzGIg != 1) {
                        QCnWktJMPimhUODb(sb, "x^");
                        oPkaxRlFLGWELbSl(sb, iXaIsmStghflnzGIg);
                    } else {
                        mTiYNJRqFuElqnPg(sb, 'x');
                    }
                }
            }
        }
        return QoOsIMmvJGDjQGQR(sb);
    }
}

