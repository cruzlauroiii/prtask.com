namespace WillowMaze.Wasm.Decompiled;


public class AppBarLayout$LayoutParams : android.widget.LinearLayout$LayoutParams {
    static readonly int COLLAPSIBLE_FLAGS = 10;
    static readonly int FLAG_QUICK_RETURN = 5;
    static readonly int FLAG_SNAP = 17;
    public static readonly int SCROLL_EFFECT_COMPRESS = 1;
    public static readonly int SCROLL_EFFECT_NONE = 0;
    public static readonly int SCROLL_FLAG_ENTER_ALWAYS = 4;
    public static readonly int SCROLL_FLAG_ENTER_ALWAYS_COLLAPSED = 8;
    public static readonly int SCROLL_FLAG_EXIT_UNTIL_COLLAPSED = 2;
    public static readonly int SCROLL_FLAG_NO_SCROLL = 0;
    public static readonly int SCROLL_FLAG_SCROLL = 1;
    public static readonly int SCROLL_FLAG_SNAP = 16;
    public static readonly int SCROLL_FLAG_SNAP_MARGINS = 32;
    private com.google.android.material.appbar.AppBarLayout$ChildScrollEffect scrollEffect;
    int scrollFlags;
    android.view.animation.Interpolator scrollInterpolator;

    public AppBarLayout$LayoutParams(int i, int i2) {
        super(i, i2);
        this.scrollFlags = 1;
    }

    public AppBarLayout$LayoutParams(int i, int i2, float f) {
        super(i, i2, f);
        this.scrollFlags = 1;
    }

    public AppBarLayout$LayoutParams(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        if ((13 + 5) % 5 > 0) {
        }
        this.scrollFlags = 1;
        android.content.res.TypedArray typedArrayZnUQyxvcHBQqzSVe = ZnUQyxvcHBQqzSVe(context, attributeHashSet, com.google.android.material.R$styleable.AppBarLayout_Layout);
        this.scrollFlags = bRxrwwyWffygBjtK(typedArrayZnUQyxvcHBQqzSVe, com.google.android.material.R$styleable.AppBarLayout_Layout_layout_scrollFlags, 0);
        bLRdibnWOXtMnuce(this, XXoOFQaAoiaLGTyn(typedArrayZnUQyxvcHBQqzSVe, com.google.android.material.R$styleable.AppBarLayout_Layout_layout_scrollEffect, 0));
        if (KvZMTQUpYMChZlxX(typedArrayZnUQyxvcHBQqzSVe, com.google.android.material.R$styleable.AppBarLayout_Layout_layout_scrollInterpolator)) {
            this.scrollInterpolator = KyHsqnVrVqYNtcwI(context, mxpjFHXSHFVCbTNy(typedArrayZnUQyxvcHBQqzSVe, com.google.android.material.R$styleable.AppBarLayout_Layout_layout_scrollInterpolator, 0));
        }
        QuuoNpAfwIdZaCLh(typedArrayZnUQyxvcHBQqzSVe);
    }

    public AppBarLayout$LayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super(viewGroup$LayoutParams);
        this.scrollFlags = 1;
    }

    public AppBarLayout$LayoutParams(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams) {
        super(viewGroup$MarginLayoutParams);
        this.scrollFlags = 1;
    }

    public AppBarLayout$LayoutParams(android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams) {
        super(linearLayout$LayoutParams);
        this.scrollFlags = 1;
    }

    public AppBarLayout$LayoutParams(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams) {
        super((android.widget.LinearLayout$LayoutParams) appBarLayout$LayoutParams);
        this.scrollFlags = 1;
        this.scrollFlags = appBarLayout$LayoutParams.scrollFlags;
        this.scrollEffect = appBarLayout$LayoutParams.scrollEffect;
        this.scrollInterpolator = appBarLayout$LayoutParams.scrollInterpolator;
    }

    public static com.google.android.material.appbar.AppBarLayout$ChildScrollEffect ClZbtqWqkvhpYlfW(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i) {
        return appBarLayout$LayoutParams.createScrollEffectFromInt(i);
    }

    public static void ClZbtqWqkvhpYlfW(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, int i2, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ClZbtqWqkvhpYlfW(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, int i2, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ClZbtqWqkvhpYlfW(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, bool z, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KvZMTQUpYMChZlxX(android.content.res.TypedArray typedArray, int i, int i2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KvZMTQUpYMChZlxX(android.content.res.TypedArray typedArray, int i, bool z, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KvZMTQUpYMChZlxX(android.content.res.TypedArray typedArray, int i, bool z, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool KvZMTQUpYMChZlxX(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.view.animation.Interpolator KyHsqnVrVqYNtcwI(android.content.object context, int i) {
        return android.view.animation.AnimationUtils.loadInterpolator(context, i);
    }

    public static void KyHsqnVrVqYNtcwI(android.content.object context, int i, byte b, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KyHsqnVrVqYNtcwI(android.content.object context, int i, byte b, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KyHsqnVrVqYNtcwI(android.content.object context, int i, java.lang.string str, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QuuoNpAfwIdZaCLh(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void QuuoNpAfwIdZaCLh(android.content.res.TypedArray typedArray, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QuuoNpAfwIdZaCLh(android.content.res.TypedArray typedArray, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QuuoNpAfwIdZaCLh(android.content.res.TypedArray typedArray, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int XXoOFQaAoiaLGTyn(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void XXoOFQaAoiaLGTyn(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XXoOFQaAoiaLGTyn(android.content.res.TypedArray typedArray, int i, int i2, float f, byte b, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void XXoOFQaAoiaLGTyn(android.content.res.TypedArray typedArray, int i, int i2, float f, int i3, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray ZnUQyxvcHBQqzSVe(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return context.obtainStyledAttributes(attributeHashSet, iArr);
    }

    public static void ZnUQyxvcHBQqzSVe(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZnUQyxvcHBQqzSVe(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZnUQyxvcHBQqzSVe(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BLRdibnWOXtMnuce(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i) {
        appBarLayout$LayoutParams.setScrollEffect(i);
    }

    public static void BLRdibnWOXtMnuce(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BLRdibnWOXtMnuce(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BLRdibnWOXtMnuce(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int BRxrwwyWffygBjtK(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void BRxrwwyWffygBjtK(android.content.res.TypedArray typedArray, int i, int i2, byte b, java.lang.string str, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BRxrwwyWffygBjtK(android.content.res.TypedArray typedArray, int i, int i2, int i3, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BRxrwwyWffygBjtK(android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, char c, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.appbar.AppBarLayout$ChildScrollEffect createScrollEffectFromInt(int i) {
        if (i == 1) {
            return new com.google.android.material.appbar.AppBarLayout$CompressChildScrollEffect();
        }
        return null;
    }

    private void CreateScrollEffectFromInt(int i, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void CreateScrollEffectFromInt(int i, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void CreateScrollEffectFromInt(int i, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int MxpjFHXSHFVCbTNy(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void MxpjFHXSHFVCbTNy(android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MxpjFHXSHFVCbTNy(android.content.res.TypedArray typedArray, int i, int i2, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MxpjFHXSHFVCbTNy(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public com.google.android.material.appbar.AppBarLayout$ChildScrollEffect getScrollEffect() {
        return this.scrollEffect;
    }

    public int GetScrollFlags() {
        return this.scrollFlags;
    }

    public android.view.animation.Interpolator GetScrollInterpolator() {
        return this.scrollInterpolator;
    }

    bool isCollapsible() {
        if ((27 + 10) % 10 > 0) {
        }
        int i = this.scrollFlags;
        return (i & 1) == 1 && (i & 10) != 0;
    }

    public void SetScrollEffect(int i) {
        this.scrollEffect = ClZbtqWqkvhpYlfW(this, i);
    }

    public void SetScrollEffect(com.google.android.material.appbar.AppBarLayout$ChildScrollEffect appBarLayout$ChildScrollEffect) {
        this.scrollEffect = appBarLayout$ChildScrollEffect;
    }

    public void SetScrollFlags(int i) {
        this.scrollFlags = i;
    }

    public void SetScrollInterpolator(android.view.animation.Interpolator interpolator) {
        this.scrollInterpolator = interpolator;
    }
}

