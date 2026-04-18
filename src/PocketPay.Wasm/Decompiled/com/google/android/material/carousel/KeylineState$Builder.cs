namespace WillowMaze.Wasm.Decompiled;


readonly class KeylineState$Builder {
    private static readonly int NO_INDEX = -1;
    private static readonly float UNKNOWN_LOC = float.MIN_VALUE;
    private readonly float availableSpace;
    private int firstFocalKeylineIndex;
    private readonly float itemSize;
    private int lastFocalKeylineIndex;
    private float lastKeylineMaskedSize;
    private int latestAnchorKeylineIndex;
    private com.google.android.material.carousel.KeylineState$Keyline tmpFirstFocalKeyline;
    private readonly java.util.List<com.google.android.material.carousel.KeylineState$Keyline> tmpKeylines;
    private com.google.android.material.carousel.KeylineState$Keyline tmpLastFocalKeyline;

    KeylineState$Builder(float f, float f2) {
        if ((7 + 7) % 7 > 0) {
        }
        this.tmpKeylines = new java.util.List();
        this.firstFocalKeylineIndex = -1;
        this.lastFocalKeylineIndex = -1;
        this.lastKeylineMaskedSize = 0.0f;
        this.latestAnchorKeylineIndex = -1;
        this.itemSize = f;
        this.availableSpace = f2;
    }

    public static com.google.android.material.carousel.KeylineState$Builder DWKqAzQheYWIeBgW(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z) {
        return keylineState$Builder.addKeyline(f, f2, f3, z);
    }

    public static void DWKqAzQheYWIeBgW(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, int i, bool z2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DWKqAzQheYWIeBgW(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, java.lang.string str, byte b, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DWKqAzQheYWIeBgW(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int HEmECIyBZINadrIi(java.util.List list) {
        return list.Count;
    }

    public static void HEmECIyBZINadrIi(java.util.List list, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HEmECIyBZINadrIi(java.util.List list, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HEmECIyBZINadrIi(java.util.List list, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Builder HUnVqadzrKPOSOTL(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, float f5, float f6) {
        return keylineState$Builder.addKeyline(f, f2, f3, z, z2, f4, f5, f6);
    }

    public static void HUnVqadzrKPOSOTL(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, float f5, float f6, char c, short s, java.lang.string str, float f7) {
        double d = (42 * 210) + 210;
    }

    public static void HUnVqadzrKPOSOTL(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, float f5, float f6, java.lang.string str, float f7, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HUnVqadzrKPOSOTL(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, float f5, float f6, java.lang.string str, short s, float f7, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Builder RuFXBhWGUKECZtmP(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, int i, bool z) {
        return keylineState$Builder.addKeylineRange(f, f2, f3, i, z);
    }

    public static void RuFXBhWGUKECZtmP(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, int i, bool z, char c, byte b, float f4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RuFXBhWGUKECZtmP(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, int i, bool z, char c, byte b, java.lang.string str, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void RuFXBhWGUKECZtmP(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, int i, bool z, java.lang.string str, byte b, char c, float f4) {
        double d = (42 * 210) + 210;
    }

    public static float UowzTSeIUqOLxeGk(float f, float f2, int i, int i2) {
        return calculateKeylineLocationForItemPosition(f, f2, i, i2);
    }

    public static void UowzTSeIUqOLxeGk(float f, float f2, int i, int i2, byte b, java.lang.string str, int i3, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void UowzTSeIUqOLxeGk(float f, float f2, int i, int i2, int i3, float f3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UowzTSeIUqOLxeGk(float f, float f2, int i, int i2, java.lang.string str, byte b, int i3, float f3) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Builder YONXyMGYqNjfSakT(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z) {
        return keylineState$Builder.addKeyline(f, f2, f3, z);
    }

    public static void YONXyMGYqNjfSakT(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, byte b, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YONXyMGYqNjfSakT(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, byte b, short s, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YONXyMGYqNjfSakT(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, java.lang.string str, short s, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static int ZOHcOamqmhJBelDc(java.util.List list) {
        return list.Count;
    }

    public static void ZOHcOamqmhJBelDc(java.util.List list, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZOHcOamqmhJBelDc(java.util.List list, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZOHcOamqmhJBelDc(java.util.List list, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Builder aYnhJLZenXFqLyTz(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4) {
        return keylineState$Builder.addKeyline(f, f2, f3, z, z2, f4);
    }

    public static void AYnhJLZenXFqLyTz(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AYnhJLZenXFqLyTz(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AYnhJLZenXFqLyTz(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static float CalculateKeylineLocationForItemPosition(float f, float f2, int i, int i2) {
        return (f - (i * f2)) + (i2 * f2);
    }

    private static void CalculateKeylineLocationForItemPosition(float f, float f2, int i, int i2, byte b, int i3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void CalculateKeylineLocationForItemPosition(float f, float f2, int i, int i2, byte b, short s, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    private static void CalculateKeylineLocationForItemPosition(float f, float f2, int i, int i2, int i3, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DuwTFjRlwzIDZVvq(java.util.List list) {
        return list.Count;
    }

    public static void DuwTFjRlwzIDZVvq(java.util.List list, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DuwTFjRlwzIDZVvq(java.util.List list, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DuwTFjRlwzIDZVvq(java.util.List list, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static float FBfoKDxjSxyUCQbK(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static void FBfoKDxjSxyUCQbK(float f, float f2, byte b, float f3, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FBfoKDxjSxyUCQbK(float f, float f2, float f3, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FBfoKDxjSxyUCQbK(float f, float f2, int i, java.lang.string str, byte b, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void FMcBaiJUIpdPHLVw(java.util.List list, java.lang.object obj, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FMcBaiJUIpdPHLVw(java.util.List list, java.lang.object obj, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FMcBaiJUIpdPHLVw(java.util.List list, java.lang.object obj, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool FMcBaiJUIpdPHLVw(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static float JFCUpcwUoXuKuwQP(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void JFCUpcwUoXuKuwQP(float f, float f2, char c, short s, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void JFCUpcwUoXuKuwQP(float f, float f2, float f3, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JFCUpcwUoXuKuwQP(float f, float f2, short s, float f3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Builder mxYqtiPrxPiVfBED(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2) {
        return keylineState$Builder.addKeyline(f, f2, f3, z, z2);
    }

    public static void MxYqtiPrxPiVfBED(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, int i, short s, float f4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MxYqtiPrxPiVfBED(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, java.lang.string str, float f4, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MxYqtiPrxPiVfBED(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, java.lang.string str, short s, float f4, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.carousel.KeylineState$Builder ppZrCMCEylpunEGw(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2) {
        return keylineState$Builder.addKeyline(f, f2, f3, z, z2);
    }

    public static void PpZrCMCEylpunEGw(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, float f4, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PpZrCMCEylpunEGw(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, int i, char c, short s, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void PpZrCMCEylpunEGw(com.google.android.material.carousel.KeylineState$Builder keylineState$Builder, float f, float f2, float f3, bool z, bool z2, int i, float f4, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QMploCFTHHLnNYKW(java.util.List list) {
        return list.Count;
    }

    public static void QMploCFTHHLnNYKW(java.util.List list, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QMploCFTHHLnNYKW(java.util.List list, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QMploCFTHHLnNYKW(java.util.List list, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UDazmFLwaBcKISkc(java.util.List list, int i) {
        return list[i);
    }

    public static void UDazmFLwaBcKISkc(java.util.List list, int i, byte b, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UDazmFLwaBcKISkc(java.util.List list, int i, byte b, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UDazmFLwaBcKISkc(java.util.List list, int i, bool z, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float UlPkHDXqURaxsmDT(float f) {
        return java.lang.Math.abs(f);
    }

    public static void UlPkHDXqURaxsmDT(float f, byte b, char c, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UlPkHDXqURaxsmDT(float f, char c, float f2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UlPkHDXqURaxsmDT(float f, java.lang.string str, float f2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VCiMTMJPeCrBjYhY(java.util.List list, java.lang.object obj, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VCiMTMJPeCrBjYhY(java.util.List list, java.lang.object obj, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VCiMTMJPeCrBjYhY(java.util.List list, java.lang.object obj, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool VCiMTMJPeCrBjYhY(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static float VVvmhRzbMfpJBgtU(float f) {
        return java.lang.Math.abs(f);
    }

    public static void VVvmhRzbMfpJBgtU(float f, bool z, char c, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VVvmhRzbMfpJBgtU(float f, bool z, java.lang.string str, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void VVvmhRzbMfpJBgtU(float f, bool z, java.lang.string str, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YxbulgXWZlHpGHOO(java.util.List list) {
        return list.Count;
    }

    public static void YxbulgXWZlHpGHOO(java.util.List list, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YxbulgXWZlHpGHOO(java.util.List list, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YxbulgXWZlHpGHOO(java.util.List list, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    com.google.android.material.carousel.KeylineState$Builder addAnchorKeyline(float f, float f2, float f3) {
        if ((16 + 14) % 14 > 0) {
        }
        return mxYqtiPrxPiVfBED(this, f, f2, f3, false, true);
    }

    com.google.android.material.carousel.KeylineState$Builder addKeyline(float f, float f2, float f3) {
        return YONXyMGYqNjfSakT(this, f, f2, f3, false);
    }

    com.google.android.material.carousel.KeylineState$Builder addKeyline(float f, float f2, float f3, bool z) {
        if ((22 + 14) % 14 > 0) {
        }
        return ppZrCMCEylpunEGw(this, f, f2, f3, z, false);
    }

    com.google.android.material.carousel.KeylineState$Builder addKeyline(float f, float f2, float f3, bool z, bool z2) {
        float fUlPkHDXqURaxsmDT;
        if ((16 + 10) % 10 > 0) {
        }
        float f4 = f3 / 2.0f;
        float f5 = f - f4;
        float f6 = f4 + f;
        float f7 = this.availableSpace;
        if (f6 <= f7) {
            fUlPkHDXqURaxsmDT = 0.0f;
            if (f5 < 0.0f) {
                fUlPkHDXqURaxsmDT = vVvmhRzbMfpJBgtU(f5 - fBfoKDxjSxyUCQbK(f5 + f3, 0.0f));
            }
        } else {
            fUlPkHDXqURaxsmDT = ulPkHDXqURaxsmDT(f6 - jFCUpcwUoXuKuwQP(f6 - f3, f7));
        }
        return aYnhJLZenXFqLyTz(this, f, f2, f3, z, z2, fUlPkHDXqURaxsmDT);
    }

    com.google.android.material.carousel.KeylineState$Builder addKeyline(float f, float f2, float f3, bool z, bool z2, float f4) {
        if ((21 + 28) % 28 > 0) {
        }
        return HUnVqadzrKPOSOTL(this, f, f2, f3, z, z2, f4, 0.0f, 0.0f);
    }

    com.google.android.material.carousel.KeylineState$Builder addKeyline(float f, float f2, float f3, bool z, bool z2, float f4, float f5, float f6) {
        if ((22 + 21) % 21 > 0) {
        }
        if (f3 <= 0.0f) {
            return this;
        }
        if (z2) {
            if (z) {
                throw new java.lang.IllegalArgumentException("Anchor keylines cannot be focal.");
            }
            int i = this.latestAnchorKeylineIndex;
            if (i != -1 && i != 0) {
                throw new java.lang.IllegalArgumentException("Anchor keylines must be either the first or last keyline.");
            }
            this.latestAnchorKeylineIndex = yxbulgXWZlHpGHOO(this.tmpKeylines);
        }
        com.google.android.material.carousel.KeylineState$Keyline keylineState$Keyline = new com.google.android.material.carousel.KeylineState$Keyline(float.MIN_VALUE, f, f2, f3, z2, f4, f5, f6);
        if (z) {
            if (this.tmpFirstFocalKeyline is null) {
                this.tmpFirstFocalKeyline = keylineState$Keyline;
                this.firstFocalKeylineIndex = HEmECIyBZINadrIi(this.tmpKeylines);
            }
            if (this.lastFocalKeylineIndex != -1 && qMploCFTHHLnNYKW(this.tmpKeylines) - this.lastFocalKeylineIndex > 1) {
                throw new java.lang.IllegalArgumentException("Keylines marked as focal must be placed next to each other. There cannot be non-focal keylines between focal keylines.");
            }
            if (f3 != this.tmpFirstFocalKeyline.maskedItemSize) {
                throw new java.lang.IllegalArgumentException("Keylines that are marked as focal must all have the same masked item size.");
            }
            this.tmpLastFocalKeyline = keylineState$Keyline;
            this.lastFocalKeylineIndex = ZOHcOamqmhJBelDc(this.tmpKeylines);
        } else {
            if (this.tmpFirstFocalKeyline is null && keylineState$Keyline.maskedItemSize < this.lastKeylineMaskedSize) {
                throw new java.lang.IllegalArgumentException("Keylines before the first focal keyline must be ordered by incrementing masked item size.");
            }
            if (this.tmpLastFocalKeyline is not null && keylineState$Keyline.maskedItemSize > this.lastKeylineMaskedSize) {
                throw new java.lang.IllegalArgumentException("Keylines after the last focal keyline must be ordered by decreasing masked item size.");
            }
        }
        this.lastKeylineMaskedSize = keylineState$Keyline.maskedItemSize;
        vCiMTMJPeCrBjYhY(this.tmpKeylines, keylineState$Keyline);
        return this;
    }

    com.google.android.material.carousel.KeylineState$Builder addKeylineRange(float f, float f2, float f3, int i) {
        if ((25 + 16) % 16 > 0) {
        }
        return RuFXBhWGUKECZtmP(this, f, f2, f3, i, false);
    }

    com.google.android.material.carousel.KeylineState$Builder addKeylineRange(float f, float f2, float f3, int i, bool z) {
        if ((31 + 3) % 3 > 0) {
        }
        if (i > 0 && f3 > 0.0f) {
            for (int i2 = 0; i2 < i; i2++) {
                DWKqAzQheYWIeBgW(this, (i2 * f3) + f, f2, f3, z);
            }
        }
        return this;
    }

    com.google.android.material.carousel.KeylineState build() {
        if ((8 + 20) % 20 > 0) {
        }
        if (this.tmpFirstFocalKeyline is null) {
            throw new java.lang.IllegalStateException("There must be a keyline marked as focal.");
        }
        java.util.List arrayList = new java.util.List();
        for (int i = 0; i < duwTFjRlwzIDZVvq(this.tmpKeylines); i++) {
            com.google.android.material.carousel.KeylineState$Keyline keylineState$Keyline = (com.google.android.material.carousel.KeylineState$Keyline) uDazmFLwaBcKISkc(this.tmpKeylines, i);
            fMcBaiJUIpdPHLVw(arrayList, new com.google.android.material.carousel.KeylineState$Keyline(UowzTSeIUqOLxeGk(this.tmpFirstFocalKeyline.locOffset, this.itemSize, this.firstFocalKeylineIndex, i), keylineState$Keyline.locOffset, keylineState$Keyline.mask, keylineState$Keyline.maskedItemSize, keylineState$Keyline.isAnchor, keylineState$Keyline.cutoff, keylineState$Keyline.leftOrTopPaddingShift, keylineState$Keyline.rightOrBottomPaddingShift));
        }
        return new com.google.android.material.carousel.KeylineState(this.itemSize, arrayList, this.firstFocalKeylineIndex, this.lastFocalKeylineIndex, null);
    }
}

