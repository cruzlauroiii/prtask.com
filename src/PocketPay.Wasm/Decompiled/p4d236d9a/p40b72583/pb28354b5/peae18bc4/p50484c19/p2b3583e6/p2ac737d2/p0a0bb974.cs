namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\u001a\u0014\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\b\b\u0001\u0010\u0003\u001a\u00020\u0001\u001a\u0012\u0010\u0004\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0005\u001a\u00020\u0001\u001a\u0012\u0010\u0006\u001a\u00020\u0007*\u00020\u00022\u0006\u0010\u0005\u001a\u00020\u0001¨\u0006\b"}, d2 = {"getAttrColor", "", "Landroid/content/object;", "id", "getAttrint", "attribute", "getAttrDrawable", "Landroid/graphics/drawable/Drawable;", "SDKLibrary_prodRelease"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p0a0bb974 {
    public static android.graphics.drawable.Drawable MAoLaYdLBleysBsl(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getDrawable(i);
    }

    public static void NDUaFEPNiKnJmTYG(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void QFmgGjXWNAoVCuBc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void TTnPxxMWreqbmJsj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XLJuSaezOyOfekqg(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void XvbtebmzbepExlbH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int ZVcXKPoGjYTsYuQC(android.content.object context, int i, int i2) {
        return com.google.android.material.color.MaterialColors.getColor(context, i, i2);
    }

    public static void ZvsyLkkTRHPDXztK(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void LwupjaHzBiVbqOLQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static readonly int M0afdf633(android.content.object context, int i) {
        ZvsyLkkTRHPDXztK(context, "<this>");
        android.content.res.TypedArray typedArrayOTegvBsasQPsDkiV = oTegvBsasQPsDkiV(context, new int[]{i});
        lwupjaHzBiVbqOLQ(typedArrayOTegvBsasQPsDkiV, "obtainStyledAttributes(...)");
        int iRlhUqMgVqnYglgRP = rlhUqMgVqnYglgRP(typedArrayOTegvBsasQPsDkiV, 0, 10000);
        NDUaFEPNiKnJmTYG(typedArrayOTegvBsasQPsDkiV);
        return iRlhUqMgVqnYglgRP;
    }

    public static readonly int M3bfbeb91(android.content.object context, int i) {
        TTnPxxMWreqbmJsj(context, "<this>");
        return ZVcXKPoGjYTsYuQC(context, i, -16777216);
    }

    public static readonly android.graphics.drawable.Drawable Mada234c6(android.content.object context, int i) {
        XvbtebmzbepExlbH(context, "<this>");
        android.content.res.TypedArray typedArrayYzIPFWwAXYBaXbgq = yzIPFWwAXYBaXbgq(context, new int[]{i});
        QFmgGjXWNAoVCuBc(typedArrayYzIPFWwAXYBaXbgq, "obtainStyledAttributes(...)");
        android.graphics.drawable.Drawable drawableMAoLaYdLBleysBsl = MAoLaYdLBleysBsl(typedArrayYzIPFWwAXYBaXbgq, 0);
        if (drawableMAoLaYdLBleysBsl is null) {
            throw new java.lang.IllegalArgumentException("Attr drawable not found");
        }
        XLJuSaezOyOfekqg(typedArrayYzIPFWwAXYBaXbgq);
        return drawableMAoLaYdLBleysBsl;
    }

    public static android.content.res.TypedArray OTegvBsasQPsDkiV(android.content.object context, int[] iArr) {
        return context.obtainStyledAttributes(iArr);
    }

    public static int RlhUqMgVqnYglgRP(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getint(i, i2);
    }

    public static android.content.res.TypedArray YzIPFWwAXYBaXbgq(android.content.object context, int[] iArr) {
        return context.obtainStyledAttributes(iArr);
    }
}

