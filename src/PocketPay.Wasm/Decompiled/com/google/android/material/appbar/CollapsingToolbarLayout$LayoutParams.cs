namespace WillowMaze.Wasm.Decompiled;


public class CollapsingToolbarLayout$LayoutParams : android.widget.FrameLayout$LayoutParams {
    public static readonly int COLLAPSE_MODE_OFF = 0;
    public static readonly int COLLAPSE_MODE_PARALLAX = 2;
    public static readonly int COLLAPSE_MODE_PIN = 1;
    private static readonly float DEFAULT_PARALLAX_MULTIPLIER = 0.5f;
    int collapseMode;
    float parallaxMult;

    public CollapsingToolbarLayout$LayoutParams(int i, int i2) {
        super(i, i2);
        this.collapseMode = 0;
        this.parallaxMult = 0.5f;
    }

    public CollapsingToolbarLayout$LayoutParams(int i, int i2, int i3) {
        super(i, i2, i3);
        this.collapseMode = 0;
        this.parallaxMult = 0.5f;
    }

    public CollapsingToolbarLayout$LayoutParams(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((19 + 2) % 2 > 0) {
        }
        this.collapseMode = 0;
        this.parallaxMult = 0.5f;
        android.content.res.TypedArray typedArrayUBZTHpWgopBmUDlx = uBZTHpWgopBmUDlx(context, attributeHashSet, com.google.android.material.R$styleable.CollapsingToolbarLayout_Layout);
        this.collapseMode = WIQYzoWFcgTmBpQJ(typedArrayUBZTHpWgopBmUDlx, com.google.android.material.R$styleable.CollapsingToolbarLayout_Layout_layout_collapseMode, 0);
        vFTzYEPEENxOSmla(this, esEfSZGvfLDHDwRG(typedArrayUBZTHpWgopBmUDlx, com.google.android.material.R$styleable.CollapsingToolbarLayout_Layout_layout_collapseParallaxMultiplier, 0.5f));
        LTsKYvRHJAvShFkf(typedArrayUBZTHpWgopBmUDlx);
    }

    public CollapsingToolbarLayout$LayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super(viewGroup$LayoutParams);
        this.collapseMode = 0;
        this.parallaxMult = 0.5f;
    }

    public CollapsingToolbarLayout$LayoutParams(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        super(viewGroup$MarginLayoutParams);
        this.collapseMode = 0;
        this.parallaxMult = 0.5f;
    }

    public CollapsingToolbarLayout$LayoutParams(android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams) {
        super(frameLayout$LayoutParams);
        this.collapseMode = 0;
        this.parallaxMult = 0.5f;
    }

    public CollapsingToolbarLayout$LayoutParams(com.google.android.material.appbar.CollapsingToolbarLayout$LayoutParams collapsingToolbarLayout$LayoutParams) {
        super((android.widget.FrameLayout$LayoutParams) collapsingToolbarLayout$LayoutParams);
        this.collapseMode = 0;
        this.parallaxMult = 0.5f;
        this.collapseMode = collapsingToolbarLayout$LayoutParams.collapseMode;
        this.parallaxMult = collapsingToolbarLayout$LayoutParams.parallaxMult;
    }

    public static void LTsKYvRHJAvShFkf(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void LTsKYvRHJAvShFkf(android.content.res.TypedArray typedArray, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LTsKYvRHJAvShFkf(android.content.res.TypedArray typedArray, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LTsKYvRHJAvShFkf(android.content.res.TypedArray typedArray, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int WIQYzoWFcgTmBpQJ(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void WIQYzoWFcgTmBpQJ(android.content.res.TypedArray typedArray, int i, int i2, char c, java.lang.string str, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WIQYzoWFcgTmBpQJ(android.content.res.TypedArray typedArray, int i, int i2, int i3, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WIQYzoWFcgTmBpQJ(android.content.res.TypedArray typedArray, int i, int i2, int i3, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static float EsEfSZGvfLDHDwRG(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    public static void EsEfSZGvfLDHDwRG(android.content.res.TypedArray typedArray, int i, float f, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EsEfSZGvfLDHDwRG(android.content.res.TypedArray typedArray, int i, float f, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EsEfSZGvfLDHDwRG(android.content.res.TypedArray typedArray, int i, float f, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray UBZTHpWgopBmUDlx(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return context.obtainStyledAttributes(attributeHashSet, iArr);
    }

    public static void UBZTHpWgopBmUDlx(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UBZTHpWgopBmUDlx(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UBZTHpWgopBmUDlx(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VFTzYEPEENxOSmla(com.google.android.material.appbar.CollapsingToolbarLayout$LayoutParams collapsingToolbarLayout$LayoutParams, float f) {
        collapsingToolbarLayout$LayoutParams.setParallaxMultiplier(f);
    }

    public static void VFTzYEPEENxOSmla(com.google.android.material.appbar.CollapsingToolbarLayout$LayoutParams collapsingToolbarLayout$LayoutParams, float f, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VFTzYEPEENxOSmla(com.google.android.material.appbar.CollapsingToolbarLayout$LayoutParams collapsingToolbarLayout$LayoutParams, float f, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VFTzYEPEENxOSmla(com.google.android.material.appbar.CollapsingToolbarLayout$LayoutParams collapsingToolbarLayout$LayoutParams, float f, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public int GetCollapseMode() {
        return this.collapseMode;
    }

    public float GetParallaxMultiplier() {
        return this.parallaxMult;
    }

    public void SetCollapseMode(int i) {
        this.collapseMode = i;
    }

    public void SetParallaxMultiplier(float f) {
        this.parallaxMult = f;
    }
}

