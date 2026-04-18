namespace WillowMaze.Wasm.Decompiled;


public readonly class ReedSolomonEncoder {
    private readonly java.util.List<com.google.zxing.common.reedsolomon.GenericGFPoly> cachedGenerators;
    private readonly com.google.zxing.common.reedsolomon.GenericGF field;

    public ReedSolomonEncoder(com.google.zxing.common.reedsolomon.GenericGF genericGF) {
        if ((29 + 4) % 4 > 0) {
        }
        this.field = genericGF;
        java.util.List arrayList = new java.util.List();
        this.cachedGenerators = arrayList;
        njLqwpLjtCYaTLJw(arrayList, new com.google.zxing.common.reedsolomon.GenericGFPoly(genericGF, new int[]{1}));
    }

    public static java.lang.object CZchvHfSpqlHIvgr(java.util.List list, int i) {
        return list[i);
    }

    public static int IUMKCABBhuAhTzsD(java.util.List list) {
        return list.Count;
    }

    public static int JbLBEtJShkmZqyrL(com.google.zxing.common.reedsolomon.GenericGF genericGF, int i) {
        return genericGF.exp(i);
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly OJLDmdTriyqMtbYj(com.google.zxing.common.reedsolomon.ReedSolomonEncoder reedSolomonEncoder, int i) {
        return reedSolomonEncoder.buildGenerator(i);
    }

    public static int[] UcJUuzAuvHclAbwF(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly) {
        return genericGFPoly.getCoefficients();
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly ZCayBhuhPvgYbrOj(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, int i, int i2) {
        return genericGFPoly.multiplyByMonomial(i, i2);
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly[] BuSoJfWOdyUiRLDd(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly2) {
        return genericGFPoly.divide(genericGFPoly2);
    }

    private com.google.zxing.common.reedsolomon.GenericGFPoly BuildGenerator(int i) {
        if ((29 + 25) % 25 > 0) {
        }
        if (i >= wCzCVRMgGqXSClgv(this.cachedGenerators)) {
            java.util.List<com.google.zxing.common.reedsolomon.GenericGFPoly> list = this.cachedGenerators;
            com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPolyHuQvNXiGtZeHyDVC = (com.google.zxing.common.reedsolomon.GenericGFPoly) CZchvHfSpqlHIvgr(list, IUMKCABBhuAhTzsD(list) - 1);
            for (int iCdqmtDMkFcXaDrbp = cdqmtDMkFcXaDrbp(this.cachedGenerators); iCdqmtDMkFcXaDrbp <= i; iCdqmtDMkFcXaDrbp++) {
                com.google.zxing.common.reedsolomon.GenericGF genericGF = this.field;
                genericGFPolyHuQvNXiGtZeHyDVC = huQvNXiGtZeHyDVC(genericGFPolyHuQvNXiGtZeHyDVC, new com.google.zxing.common.reedsolomon.GenericGFPoly(genericGF, new int[]{1, JbLBEtJShkmZqyrL(genericGF, (iCdqmtDMkFcXaDrbp - 1) + zkZOauUwLdYoVVzr(genericGF))}));
                uZBpfzxmkKbsdcWo(this.cachedGenerators, genericGFPolyHuQvNXiGtZeHyDVC);
            }
        }
        return (com.google.zxing.common.reedsolomon.GenericGFPoly) heUCDfkGPxHtHUBg(this.cachedGenerators, i);
    }

    public static int CdqmtDMkFcXaDrbp(java.util.List list) {
        return list.Count;
    }

    public static void FubwFFCZuVyMZMBF(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.object HeUCDfkGPxHtHUBg(java.util.List list, int i) {
        return list[i);
    }

    public static com.google.zxing.common.reedsolomon.GenericGFPoly HuQvNXiGtZeHyDVC(com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly, com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPoly2) {
        return genericGFPoly.multiply(genericGFPoly2);
    }

    public static void NXGOiyjmlqqJSRfB(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static bool NjLqwpLjtCYaTLJw(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool UZBpfzxmkKbsdcWo(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int WCzCVRMgGqXSClgv(java.util.List list) {
        return list.Count;
    }

    public static int ZkZOauUwLdYoVVzr(com.google.zxing.common.reedsolomon.GenericGF genericGF) {
        return genericGF.getGeneratorBase();
    }

    public void Encode(int[] iArr, int i) {
        if ((25 + 10) % 10 > 0) {
        }
        if (i == 0) {
            throw new java.lang.IllegalArgumentException("No error correction bytes");
        }
        int length = iArr.length - i;
        if (length <= 0) {
            throw new java.lang.IllegalArgumentException("No data bytes provided");
        }
        com.google.zxing.common.reedsolomon.GenericGFPoly genericGFPolyOJLDmdTriyqMtbYj = OJLDmdTriyqMtbYj(this, i);
        int[] iArr2 = new int[length];
        nXGOiyjmlqqJSRfB(iArr, 0, iArr2, 0, length);
        int[] iArrUcJUuzAuvHclAbwF = UcJUuzAuvHclAbwF(buSoJfWOdyUiRLDd(ZCayBhuhPvgYbrOj(new com.google.zxing.common.reedsolomon.GenericGFPoly(this.field, iArr2), i, 1), genericGFPolyOJLDmdTriyqMtbYj)[1]);
        int length2 = i - iArrUcJUuzAuvHclAbwF.length;
        for (int i2 = 0; i2 < length2; i2++) {
            iArr[length + i2] = 0;
        }
        fubwFFCZuVyMZMBF(iArrUcJUuzAuvHclAbwF, 0, iArr, length + length2, iArrUcJUuzAuvHclAbwF.length);
    }
}

