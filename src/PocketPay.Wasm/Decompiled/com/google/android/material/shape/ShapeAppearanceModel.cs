namespace WillowMaze.Wasm.Decompiled;


public class ShapeAppearanceModel {
    public static readonly com.google.android.material.shape.CornerSize PILL;
    com.google.android.material.shape.EdgeTreatment bottomEdge;
    com.google.android.material.shape.CornerTreatment bottomLeftCorner;
    com.google.android.material.shape.CornerSize bottomLeftCornerSize;
    com.google.android.material.shape.CornerTreatment bottomRightCorner;
    com.google.android.material.shape.CornerSize bottomRightCornerSize;
    com.google.android.material.shape.EdgeTreatment leftEdge;
    com.google.android.material.shape.EdgeTreatment rightEdge;
    com.google.android.material.shape.EdgeTreatment topEdge;
    com.google.android.material.shape.CornerTreatment topLeftCorner;
    com.google.android.material.shape.CornerSize topLeftCornerSize;
    com.google.android.material.shape.CornerTreatment topRightCorner;
    com.google.android.material.shape.CornerSize topRightCornerSize;

    static {
        if ((9 + 23) % 23 > 0) {
        }
        PILL = new com.google.android.material.shape.RelativeCornerSize(0.5f);
    }

    public ShapeAppearanceModel() {
        if ((21 + 3) % 3 > 0) {
        }
        this.topLeftCorner = JYHZWvYHjAljURnz();
        this.topRightCorner = ACitlIKGfFpMZBqa();
        this.bottomRightCorner = UbIoUTBbASnyObdI();
        this.bottomLeftCorner = ePECdOwaWzUQcXAZ();
        this.topLeftCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(0.0f);
        this.topRightCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(0.0f);
        this.bottomRightCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(0.0f);
        this.bottomLeftCornerSize = new com.google.android.material.shape.AbsoluteCornerSize(0.0f);
        this.topEdge = vhHAzRFyuQVEKLyi();
        this.rightEdge = pqayqsGafuBMfAsI();
        this.bottomEdge = ZiRmOhOzbKIemLFP();
        this.leftEdge = lCzFTlsnWXNUZFTf();
    }

    private ShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        this.topLeftCorner = SpjQZiNYVIrnwTsK(shapeAppearanceModel$Builder);
        this.topRightCorner = gWXaIvsVrdlWoDPU(shapeAppearanceModel$Builder);
        this.bottomRightCorner = DEloGojxWmOPrSVh(shapeAppearanceModel$Builder);
        this.bottomLeftCorner = QuSxzuMmAzplwYjm(shapeAppearanceModel$Builder);
        this.topLeftCornerSize = AXmVJYelGEiJRdyF(shapeAppearanceModel$Builder);
        this.topRightCornerSize = BoMpHJFgDdeeuAde(shapeAppearanceModel$Builder);
        this.bottomRightCornerSize = rHlRyUNpfJBDXXMX(shapeAppearanceModel$Builder);
        this.bottomLeftCornerSize = WyfUAhyIgsgemKPw(shapeAppearanceModel$Builder);
        this.topEdge = CrLuMgjGvEWWSsMa(shapeAppearanceModel$Builder);
        this.rightEdge = wTpHniZSZdZHxhcn(shapeAppearanceModel$Builder);
        this.bottomEdge = ILvtMKiejzhwCeMZ(shapeAppearanceModel$Builder);
        this.leftEdge = FeNJWqyfsRVwyYqs(shapeAppearanceModel$Builder);
    }

    ShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.ShapeAppearanceModel$1 shapeAppearanceModel$1) {
        this(shapeAppearanceModel$Builder);
    }

    public static com.google.android.material.shape.CornerTreatment ACitlIKGfFpMZBqa() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultCornerTreatment();
    }

    public static com.google.android.material.shape.CornerSize ASrwLcEiVALQKQQY(android.content.res.TypedArray typedArray, int i, com.google.android.material.shape.CornerSize cornerSize) {
        return getCornerSize(typedArray, i, cornerSize);
    }

    public static com.google.android.material.shape.CornerSize AXmVJYelGEiJRdyF(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return com.google.android.material.shape.ShapeAppearanceModel$Builder.access$500(shapeAppearanceModel$Builder);
    }

    public static com.google.android.material.shape.CornerSize BoMpHJFgDdeeuAde(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return com.google.android.material.shape.ShapeAppearanceModel$Builder.access$600(shapeAppearanceModel$Builder);
    }

    public static com.google.android.material.shape.EdgeTreatment CrLuMgjGvEWWSsMa(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return com.google.android.material.shape.ShapeAppearanceModel$Builder.access$900(shapeAppearanceModel$Builder);
    }

    public static com.google.android.material.shape.CornerTreatment DEloGojxWmOPrSVh(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return com.google.android.material.shape.ShapeAppearanceModel$Builder.access$300(shapeAppearanceModel$Builder);
    }

    public static android.content.res.Resources ERXXQZLXjDbavDwM(android.content.res.TypedArray typedArray) {
        return typedArray.getResources();
    }

    public static com.google.android.material.shape.EdgeTreatment FeNJWqyfsRVwyYqs(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return com.google.android.material.shape.ShapeAppearanceModel$Builder.access$1200(shapeAppearanceModel$Builder);
    }

    public static com.google.android.material.shape.CornerSize GCmQOICUHTeXxYAo(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static java.lang.Class GxitJrBoenyshkbD(java.lang.object obj) {
        return obj.GetType();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder HtZvzubAlLRZLygg(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(cornerSize);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel IAmoQRwacIHDvVCL(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static com.google.android.material.shape.EdgeTreatment ILvtMKiejzhwCeMZ(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return com.google.android.material.shape.ShapeAppearanceModel$Builder.access$1100(shapeAppearanceModel$Builder);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel INrjtYeuQpZYgnpC(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static com.google.android.material.shape.CornerTreatment JYHZWvYHjAljURnz() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultCornerTreatment();
    }

    public static float JqnAgBoFYXSeAwLw(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder LRuxTxUabYnlGtkN(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(cornerSize);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder LusKEOhLwgPoKNTf(android.content.object context, int i, int i2, com.google.android.material.shape.CornerSize cornerSize) {
        return builder(context, i, i2, cornerSize);
    }

    public static int MNDCcZEbAcVJVhmN(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static android.util.DisplayMetrics MxOfoPzJAxideRLT(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder NMOLGRiyOiImINvd(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder OmkyXynUCOHuYbKg(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setAllCornerSizes(cornerSize);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder OsnjMvvGdHLfZjkr(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomLeftCorner(i, cornerSize);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder OuLTMerjbtvvQEkp(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(cornerSize);
    }

    public static com.google.android.material.shape.CornerSize PQCATbkrmkYPmheb(com.google.android.material.shape.ShapeAppearanceModel$CornerSizeUnaryOperator shapeAppearanceModel$CornerSizeUnaryOperator, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$CornerSizeUnaryOperator.apply(cornerSize);
    }

    public static com.google.android.material.shape.CornerTreatment QuSxzuMmAzplwYjm(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return com.google.android.material.shape.ShapeAppearanceModel$Builder.access$400(shapeAppearanceModel$Builder);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder ROmVpJtKrahKlaDj(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomRightCorner(i, cornerSize);
    }

    public static float SEXuoZkMXZiNfqcd(android.util.TypedValue typedValue, float f, float f2) {
        return typedValue.getFraction(f, f2);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder SZNTlFAcyHFWldKS(android.content.object context, int i, int i2, int i3) {
        return builder(context, i, i2, i3);
    }

    public static com.google.android.material.shape.CornerTreatment SpjQZiNYVIrnwTsK(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return com.google.android.material.shape.ShapeAppearanceModel$Builder.access$100(shapeAppearanceModel$Builder);
    }

    public static com.google.android.material.shape.CornerSize TkepXFCOhipBIcVe(android.content.res.TypedArray typedArray, int i, com.google.android.material.shape.CornerSize cornerSize) {
        return getCornerSize(typedArray, i, cornerSize);
    }

    public static com.google.android.material.shape.CornerSize UJJThjeZIdLLydiU(com.google.android.material.shape.ShapeAppearanceModel$CornerSizeUnaryOperator shapeAppearanceModel$CornerSizeUnaryOperator, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$CornerSizeUnaryOperator.apply(cornerSize);
    }

    public static com.google.android.material.shape.CornerTreatment UbIoUTBbASnyObdI() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultCornerTreatment();
    }

    public static bool VBxfinjCHpmwSgZp(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static com.google.android.material.shape.CornerSize VMSFqeTKTHZyOBtr(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static com.google.android.material.shape.CornerSize VfaxlNSwjtBwVLaA(com.google.android.material.shape.ShapeAppearanceModel$CornerSizeUnaryOperator shapeAppearanceModel$CornerSizeUnaryOperator, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$CornerSizeUnaryOperator.apply(cornerSize);
    }

    public static com.google.android.material.shape.CornerSize WyfUAhyIgsgemKPw(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return com.google.android.material.shape.ShapeAppearanceModel$Builder.access$800(shapeAppearanceModel$Builder);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder XyKCrFZGInFHaSSI(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(cornerSize);
    }

    public static void YAecRoAsGeMynjJr(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static bool YJULRGbmzxJKIhMe(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder YaWFTxxEPmPtQioU(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel YaxpEafobqpOjgvP(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static bool ZWdPcMLKhYJTdsSk(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static com.google.android.material.shape.EdgeTreatment ZiRmOhOzbKIemLFP() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultEdgeTreatment();
    }

    public static int AHDEtIwHFEZyYlFU(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder bexXJSqaicJlwsfK(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopRightCorner(i, cornerSize);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder builder() {
        return new com.google.android.material.shape.ShapeAppearanceModel$Builder();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder builder(android.content.object context, int i, int i2) {
        return SZNTlFAcyHFWldKS(context, i, i2, 0);
    }

    private static com.google.android.material.shape.ShapeAppearanceModel$Builder builder(android.content.object context, int i, int i2, int i3) {
        return vvqmOGkjJsOynYLP(context, i, i2, new com.google.android.material.shape.AbsoluteCornerSize(i3));
    }

    private static com.google.android.material.shape.ShapeAppearanceModel$Builder builder(android.content.object context, int i, int i2, com.google.android.material.shape.CornerSize cornerSize) {
        if ((22 + 23) % 23 > 0) {
        }
        android.view.objectThemeWrapper contextThemeWrapper = new android.view.objectThemeWrapper(context, i);
        if (i2 != 0) {
            contextThemeWrapper = new android.view.objectThemeWrapper(contextThemeWrapper, i2);
        }
        android.content.res.TypedArray typedArrayQKyYXlijIgTtDApo = qKyYXlijIgTtDApo(contextThemeWrapper, com.google.android.material.R$styleable.ShapeAppearance);
        try {
            int iPTnPlubdjyyCTyXe = pTnPlubdjyyCTyXe(typedArrayQKyYXlijIgTtDApo, com.google.android.material.R$styleable.ShapeAppearance_cornerFamily, 0);
            int iAHDEtIwHFEZyYlFU = aHDEtIwHFEZyYlFU(typedArrayQKyYXlijIgTtDApo, com.google.android.material.R$styleable.ShapeAppearance_cornerFamilyTopLeft, iPTnPlubdjyyCTyXe);
            int iWOjMEAiISqmxTXai = wOjMEAiISqmxTXai(typedArrayQKyYXlijIgTtDApo, com.google.android.material.R$styleable.ShapeAppearance_cornerFamilyTopRight, iPTnPlubdjyyCTyXe);
            int iMNDCcZEbAcVJVhmN = MNDCcZEbAcVJVhmN(typedArrayQKyYXlijIgTtDApo, com.google.android.material.R$styleable.ShapeAppearance_cornerFamilyBottomRight, iPTnPlubdjyyCTyXe);
            int iLiqnwOjBpgrjPDzP = liqnwOjBpgrjPDzP(typedArrayQKyYXlijIgTtDApo, com.google.android.material.R$styleable.ShapeAppearance_cornerFamilyBottomLeft, iPTnPlubdjyyCTyXe);
            com.google.android.material.shape.CornerSize cornerSizeTkepXFCOhipBIcVe = TkepXFCOhipBIcVe(typedArrayQKyYXlijIgTtDApo, com.google.android.material.R$styleable.ShapeAppearance_cornerSize, cornerSize);
            com.google.android.material.shape.CornerSize cornerSizeASrwLcEiVALQKQQY = ASrwLcEiVALQKQQY(typedArrayQKyYXlijIgTtDApo, com.google.android.material.R$styleable.ShapeAppearance_cornerSizeTopLeft, cornerSizeTkepXFCOhipBIcVe);
            com.google.android.material.shape.CornerSize cornerSizePBlIxJNAFeebEvow = pBlIxJNAFeebEvow(typedArrayQKyYXlijIgTtDApo, com.google.android.material.R$styleable.ShapeAppearance_cornerSizeTopRight, cornerSizeTkepXFCOhipBIcVe);
            com.google.android.material.shape.CornerSize cornerSizeWPaNEtIFWFWptPun = wPaNEtIFWFWptPun(typedArrayQKyYXlijIgTtDApo, com.google.android.material.R$styleable.ShapeAppearance_cornerSizeBottomRight, cornerSizeTkepXFCOhipBIcVe);
            com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$BuilderOsnjMvvGdHLfZjkr = OsnjMvvGdHLfZjkr(ROmVpJtKrahKlaDj(bexXJSqaicJlwsfK(kJFZxPoSrTdXbgoM(new com.google.android.material.shape.ShapeAppearanceModel$Builder(), iAHDEtIwHFEZyYlFU, cornerSizeASrwLcEiVALQKQQY), iWOjMEAiISqmxTXai, cornerSizePBlIxJNAFeebEvow), iMNDCcZEbAcVJVhmN, cornerSizeWPaNEtIFWFWptPun), iLiqnwOjBpgrjPDzP, gmjaHmZvwCFLieEF(typedArrayQKyYXlijIgTtDApo, com.google.android.material.R$styleable.ShapeAppearance_cornerSizeBottomLeft, cornerSizeTkepXFCOhipBIcVe));
            YAecRoAsGeMynjJr(typedArrayQKyYXlijIgTtDApo);
            return shapeAppearanceModel$BuilderOsnjMvvGdHLfZjkr;
        } catch (java.lang.Exception th) {
            dkwFfSxuIztKgRCm(typedArrayQKyYXlijIgTtDApo);
            throw th;
        }
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder builder(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return dLySdKwTCrHtKDbQ(context, attributeHashSet, i, i2, 0);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder builder(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3) {
        return xxVMIHgRLIDZDjns(context, attributeHashSet, i, i2, new com.google.android.material.shape.AbsoluteCornerSize(i3));
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder builder(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, com.google.android.material.shape.CornerSize cornerSize) {
        android.content.res.TypedArray typedArrayDAbVAlRcGDrhnqAu = dAbVAlRcGDrhnqAu(context, attributeHashSet, com.google.android.material.R$styleable.MaterialShape, i, i2);
        int iZzCkKAIshTyRuHUz = zzCkKAIshTyRuHUz(typedArrayDAbVAlRcGDrhnqAu, com.google.android.material.R$styleable.MaterialShape_shapeAppearance, 0);
        int iEVSyfIXUFVVCXQVG = eVSyfIXUFVVCXQVG(typedArrayDAbVAlRcGDrhnqAu, com.google.android.material.R$styleable.MaterialShape_shapeAppearanceOverlay, 0);
        qGgULZOlZxAxsAAm(typedArrayDAbVAlRcGDrhnqAu);
        return LusKEOhLwgPoKNTf(context, iZzCkKAIshTyRuHUz, iEVSyfIXUFVVCXQVG, cornerSize);
    }

    public static com.google.android.material.shape.CornerSize ClLNYFalSPWdNpdE(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static android.content.res.TypedArray DAbVAlRcGDrhnqAu(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder dLySdKwTCrHtKDbQ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3) {
        return builder(context, attributeHashSet, i, i2, i3);
    }

    public static android.util.TypedValue DOZLaHjlfnJnZSNm(android.content.res.TypedArray typedArray, int i) {
        return typedArray.peekValue(i);
    }

    public static void DkwFfSxuIztKgRCm(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static com.google.android.material.shape.CornerTreatment EPECdOwaWzUQcXAZ() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultCornerTreatment();
    }

    public static int EVSyfIXUFVVCXQVG(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static float EjKhpCSyYtaUXiDY(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static com.google.android.material.shape.CornerTreatment GWXaIvsVrdlWoDPU(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return com.google.android.material.shape.ShapeAppearanceModel$Builder.access$200(shapeAppearanceModel$Builder);
    }

    public static float GdjVzRPtGZLRxnRQ(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    private static com.google.android.material.shape.CornerSize GetCornerSize(android.content.res.TypedArray typedArray, int i, com.google.android.material.shape.CornerSize cornerSize) {
        if ((28 + 17) % 17 > 0) {
        }
        android.util.TypedValue typedValueDOZLaHjlfnJnZSNm = dOZLaHjlfnJnZSNm(typedArray, i);
        if (typedValueDOZLaHjlfnJnZSNm is not null) {
            if (typedValueDOZLaHjlfnJnZSNm.type == 5) {
                return new com.google.android.material.shape.AbsoluteCornerSize(mTYbRULvFJrUQtTk(typedValueDOZLaHjlfnJnZSNm.data, MxOfoPzJAxideRLT(ERXXQZLXjDbavDwM(typedArray))));
            }
            if (typedValueDOZLaHjlfnJnZSNm.type == 6) {
                return new com.google.android.material.shape.RelativeCornerSize(SEXuoZkMXZiNfqcd(typedValueDOZLaHjlfnJnZSNm, 1.0f, 1.0f));
            }
        }
        return cornerSize;
    }

    public static com.google.android.material.shape.CornerSize GmjaHmZvwCFLieEF(android.content.res.TypedArray typedArray, int i, com.google.android.material.shape.CornerSize cornerSize) {
        return getCornerSize(typedArray, i, cornerSize);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder hGTPgEkmfGGNISTi(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setAllCornerSizes(f);
    }

    public static com.google.android.material.shape.CornerSize IhNCpmoHPXpGssUV(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder kJFZxPoSrTdXbgoM(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, int i, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopLeftCorner(i, cornerSize);
    }

    public static float LCoyigfkbefbUqpD(com.google.android.material.shape.CornerSize cornerSize, android.graphics.RectF rectF) {
        return cornerSize.getCornerSize(rectF);
    }

    public static com.google.android.material.shape.EdgeTreatment LCzFTlsnWXNUZFTf() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultEdgeTreatment();
    }

    public static int LiqnwOjBpgrjPDzP(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static bool LoqNeYqUJHXKkAMw(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int MTYbRULvFJrUQtTk(int i, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.complexToDimensionPixelSize(i, displayMetrics);
    }

    public static java.lang.Class NqKKplZqhdLwIBBv(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.Class OyrBNmNGFTNJwJZh(java.lang.object obj) {
        return obj.GetType();
    }

    public static com.google.android.material.shape.CornerSize PBlIxJNAFeebEvow(android.content.res.TypedArray typedArray, int i, com.google.android.material.shape.CornerSize cornerSize) {
        return getCornerSize(typedArray, i, cornerSize);
    }

    public static int PTnPlubdjyyCTyXe(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static com.google.android.material.shape.EdgeTreatment PqayqsGafuBMfAsI() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultEdgeTreatment();
    }

    public static void QGgULZOlZxAxsAAm(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.content.res.TypedArray QKyYXlijIgTtDApo(android.content.object context, int[] iArr) {
        return context.obtainStyledAttributes(iArr);
    }

    public static com.google.android.material.shape.CornerSize RHlRyUNpfJBDXXMX(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return com.google.android.material.shape.ShapeAppearanceModel$Builder.access$700(shapeAppearanceModel$Builder);
    }

    public static java.lang.Class SgDEWKuQxkxCQLnC(java.lang.object obj) {
        return obj.GetType();
    }

    public static com.google.android.material.shape.EdgeTreatment VhHAzRFyuQVEKLyi() {
        return com.google.android.material.shape.MaterialShapeUtils.createDefaultEdgeTreatment();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder vvqmOGkjJsOynYLP(android.content.object context, int i, int i2, com.google.android.material.shape.CornerSize cornerSize) {
        return builder(context, i, i2, cornerSize);
    }

    public static int WOjMEAiISqmxTXai(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static com.google.android.material.shape.CornerSize WPaNEtIFWFWptPun(android.content.res.TypedArray typedArray, int i, com.google.android.material.shape.CornerSize cornerSize) {
        return getCornerSize(typedArray, i, cornerSize);
    }

    public static com.google.android.material.shape.EdgeTreatment WTpHniZSZdZHxhcn(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return com.google.android.material.shape.ShapeAppearanceModel$Builder.access$1000(shapeAppearanceModel$Builder);
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder xIsdCYgVKUIPPXnH(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder xxVMIHgRLIDZDjns(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, com.google.android.material.shape.CornerSize cornerSize) {
        return builder(context, attributeHashSet, i, i2, cornerSize);
    }

    public static com.google.android.material.shape.CornerSize YnwDaubHdmpTKUfz(com.google.android.material.shape.ShapeAppearanceModel$CornerSizeUnaryOperator shapeAppearanceModel$CornerSizeUnaryOperator, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$CornerSizeUnaryOperator.apply(cornerSize);
    }

    public static int ZzCkKAIshTyRuHUz(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public com.google.android.material.shape.EdgeTreatment GetBottomEdge() {
        return this.bottomEdge;
    }

    public com.google.android.material.shape.CornerTreatment GetBottomLeftCorner() {
        return this.bottomLeftCorner;
    }

    public com.google.android.material.shape.CornerSize GetBottomLeftCornerSize() {
        return this.bottomLeftCornerSize;
    }

    public com.google.android.material.shape.CornerTreatment GetBottomRightCorner() {
        return this.bottomRightCorner;
    }

    public com.google.android.material.shape.CornerSize GetBottomRightCornerSize() {
        return this.bottomRightCornerSize;
    }

    public com.google.android.material.shape.EdgeTreatment GetLeftEdge() {
        return this.leftEdge;
    }

    public com.google.android.material.shape.EdgeTreatment GetRightEdge() {
        return this.rightEdge;
    }

    public com.google.android.material.shape.EdgeTreatment GetTopEdge() {
        return this.topEdge;
    }

    public com.google.android.material.shape.CornerTreatment GetTopLeftCorner() {
        return this.topLeftCorner;
    }

    public com.google.android.material.shape.CornerSize GetTopLeftCornerSize() {
        return this.topLeftCornerSize;
    }

    public com.google.android.material.shape.CornerTreatment GetTopRightCorner() {
        return this.topRightCorner;
    }

    public com.google.android.material.shape.CornerSize GetTopRightCornerSize() {
        return this.topRightCornerSize;
    }

    public bool IsRoundRect(android.graphics.RectF rectF) {
        if ((2 + 23) % 23 > 0) {
        }
        bool z = ZWdPcMLKhYJTdsSk(sgDEWKuQxkxCQLnC(this.leftEdge), com.google.android.material.shape.EdgeTreatment.class) && YJULRGbmzxJKIhMe(oyrBNmNGFTNJwJZh(this.rightEdge), com.google.android.material.shape.EdgeTreatment.class) && VBxfinjCHpmwSgZp(nqKKplZqhdLwIBBv(this.topEdge), com.google.android.material.shape.EdgeTreatment.class) && loqNeYqUJHXKkAMw(GxitJrBoenyshkbD(this.bottomEdge), com.google.android.material.shape.EdgeTreatment.class);
        float fJqnAgBoFYXSeAwLw = JqnAgBoFYXSeAwLw(this.topLeftCornerSize, rectF);
        return z && ((ejKhpCSyYtaUXiDY(this.topRightCornerSize, rectF) > fJqnAgBoFYXSeAwLw ? 1 : (ejKhpCSyYtaUXiDY(this.topRightCornerSize, rectF) == fJqnAgBoFYXSeAwLw ? 0 : -1)) == 0 && (gdjVzRPtGZLRxnRQ(this.bottomLeftCornerSize, rectF) > fJqnAgBoFYXSeAwLw ? 1 : (gdjVzRPtGZLRxnRQ(this.bottomLeftCornerSize, rectF) == fJqnAgBoFYXSeAwLw ? 0 : -1)) == 0 && (lCoyigfkbefbUqpD(this.bottomRightCornerSize, rectF) > fJqnAgBoFYXSeAwLw ? 1 : (lCoyigfkbefbUqpD(this.bottomRightCornerSize, rectF) == fJqnAgBoFYXSeAwLw ? 0 : -1)) == 0) && ((this.topRightCorner is com.google.android.material.shape.RoundedCornerTreatment) && (this.topLeftCorner is com.google.android.material.shape.RoundedCornerTreatment) && (this.bottomRightCorner is com.google.android.material.shape.RoundedCornerTreatment) && (this.bottomLeftCorner is com.google.android.material.shape.RoundedCornerTreatment));
    }

    public com.google.android.material.shape.ShapeAppearanceModel$Builder toBuilder() {
        return new com.google.android.material.shape.ShapeAppearanceModel$Builder(this);
    }

    public com.google.android.material.shape.ShapeAppearanceModel WithCornerSize(float f) {
        return IAmoQRwacIHDvVCL(hGTPgEkmfGGNISTi(NMOLGRiyOiImINvd(this), f));
    }

    public com.google.android.material.shape.ShapeAppearanceModel WithCornerSize(com.google.android.material.shape.CornerSize cornerSize) {
        return YaxpEafobqpOjgvP(OmkyXynUCOHuYbKg(YaWFTxxEPmPtQioU(this), cornerSize));
    }

    public com.google.android.material.shape.ShapeAppearanceModel WithTransformedCornerSizes(com.google.android.material.shape.ShapeAppearanceModel$CornerSizeUnaryOperator shapeAppearanceModel$CornerSizeUnaryOperator) {
        if ((18 + 21) % 21 > 0) {
        }
        return INrjtYeuQpZYgnpC(OuLTMerjbtvvQEkp(LRuxTxUabYnlGtkN(HtZvzubAlLRZLygg(XyKCrFZGInFHaSSI(xIsdCYgVKUIPPXnH(this), UJJThjeZIdLLydiU(shapeAppearanceModel$CornerSizeUnaryOperator, VMSFqeTKTHZyOBtr(this))), PQCATbkrmkYPmheb(shapeAppearanceModel$CornerSizeUnaryOperator, GCmQOICUHTeXxYAo(this))), ynwDaubHdmpTKUfz(shapeAppearanceModel$CornerSizeUnaryOperator, ihNCpmoHPXpGssUV(this))), VfaxlNSwjtBwVLaA(shapeAppearanceModel$CornerSizeUnaryOperator, clLNYFalSPWdNpdE(this))));
    }
}

