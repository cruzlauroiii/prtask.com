namespace WillowMaze.Wasm.Decompiled;


public class AppBarLayout : android.widget.LinearLayout : androidx.coordinatorlayout.widget.CoordinatorLayout$AttachedBehavior {
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_Design_AppBarLayout;
    private static readonly int INVALID_SCROLL_RANGE = -1;
    static readonly int PENDING_ACTION_ANIMATE_ENABLED = 4;
    static readonly int PENDING_ACTION_COLLAPSED = 2;
    static readonly int PENDING_ACTION_EXPANDED = 1;
    static readonly int PENDING_ACTION_FORCE = 8;
    static readonly int PENDING_ACTION_NONE = 0;
    private readonly float appBarElevation;
    private com.google.android.material.appbar.AppBarLayout$Behavior behavior;
    private int currentOffset;
    private int downPreScrollRange;
    private int downScrollRange;
    private readonly bool hasLiftOnScrollColor;
    private bool haveChildWithInterpolator;
    private androidx.core.view.WindowInsetsCompat lastInsets;
    private bool liftOnScroll;
    private android.animation.ValueAnimator liftOnScrollColorAnimator;
    private readonly long liftOnScrollColorDuration;
    private readonly android.animation.TimeInterpolator liftOnScrollColorInterpolator;
    private android.animation.ValueAnimator$AnimatorUpdateListener liftOnScrollColorUpdateListener;
    private readonly java.util.List<com.google.android.material.appbar.AppBarLayout$LiftOnScrollListener> liftOnScrollListeners;
    private java.lang.ref.WeakReference<android.view.object> liftOnScrollTargetobject;
    private int liftOnScrollTargetobjectId;
    private bool liftable;
    private bool liftableOverride;
    private bool lifted;
    private java.util.List<com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener> listeners;
    private int pendingAction;
    private android.graphics.drawable.Drawable statusBarForeground;
    private java.lang.int statusBarForegroundOriginalColor;
    private int[] tmpStatesArray;
    private int totalScrollRange;

    public AppBarLayout(android.content.object context) {
        this(context, null);
    }

    public AppBarLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.appBarLayoutStyle);
    }

    public AppBarLayout(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((13 + 12) % 12 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(iVxXwVLIkXEDKLsm(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.totalScrollRange = -1;
        this.downPreScrollRange = -1;
        this.downScrollRange = -1;
        this.pendingAction = 0;
        this.liftOnScrollListeners = new java.util.List();
        android.content.object contextZGRhlKAYZtFVSECX = zGRhlKAYZtFVSECX(this);
        mZeQukvsesAKGRit(this, 1);
        if (vCTjYqHMdONhlLiD(this) == android.view.objectOutlineProvider.BACKGROUND) {
            xgmsYxjREDZZkjuq(this);
        }
        ldZOKAbuBMUwRNST(this, attributeHashSet, i, i2);
        android.content.res.TypedArray typedArrayRHEcRYzEWBfMQeUU = RHEcRYzEWBfMQeUU(contextZGRhlKAYZtFVSECX, attributeHashSet, com.google.android.material.R$styleable.AppBarLayout, i, i2, new int[0]);
        PkyjnBIdtuCnadyD(this, OkQawfsykxyFpJJH(typedArrayRHEcRYzEWBfMQeUU, com.google.android.material.R$styleable.AppBarLayout_android_background));
        android.content.res.ColorStateList colorStateListBuMWXxlEXUpoModJ = buMWXxlEXUpoModJ(contextZGRhlKAYZtFVSECX, typedArrayRHEcRYzEWBfMQeUU, com.google.android.material.R$styleable.AppBarLayout_liftOnScrollColor);
        this.hasLiftOnScrollColor = colorStateListBuMWXxlEXUpoModJ is not null;
        android.content.res.ColorStateList colorStateListEEcXHJqFbxJynLJR = EEcXHJqFbxJynLJR(ajqJCFSVvGijcWUv(this));
        if (colorStateListEEcXHJqFbxJynLJR is not null) {
            com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable();
            pJdaTILGbiLkjkbB(materialShapeDrawable, colorStateListEEcXHJqFbxJynLJR);
            if (colorStateListBuMWXxlEXUpoModJ is null) {
                nSpwxnajNjXDndJw(this, contextZGRhlKAYZtFVSECX, materialShapeDrawable);
            } else {
                YGkgQLmAfeFYKnDM(this, materialShapeDrawable, colorStateListEEcXHJqFbxJynLJR, colorStateListBuMWXxlEXUpoModJ);
            }
        }
        this.liftOnScrollColorDuration = JdTJEpaTXUMRthxs(contextZGRhlKAYZtFVSECX, com.google.android.material.R$attr.motionDurationMedium2, xmwOPGfCslloORMc(gnQWUrvpEgLioade(this), com.google.android.material.R$integer.app_bar_elevation_anim_duration));
        this.liftOnScrollColorInterpolator = CxOFOZwrSHhKdSaR(contextZGRhlKAYZtFVSECX, com.google.android.material.R$attr.motionEasingStandardInterpolator, com.google.android.material.animation.AnimationUtils.LINEAR_INTERPOLATOR);
        if (ZvjIGsLuoOmUIAup(typedArrayRHEcRYzEWBfMQeUU, com.google.android.material.R$styleable.AppBarLayout_expanded)) {
            mTsEtsUKsEBqiJyN(this, jZRLaZRAdFFStbRB(typedArrayRHEcRYzEWBfMQeUU, com.google.android.material.R$styleable.AppBarLayout_expanded, false), false, false);
        }
        if (CXjEeEoYvhzPPoFk(typedArrayRHEcRYzEWBfMQeUU, com.google.android.material.R$styleable.AppBarLayout_elevation)) {
            mCtgLtVLFYfciCpy(this, bKdpfoJuojwRCpks(typedArrayRHEcRYzEWBfMQeUU, com.google.android.material.R$styleable.AppBarLayout_elevation, 0));
        }
        if (YlPoBhoyylTbSkjq(typedArrayRHEcRYzEWBfMQeUU, com.google.android.material.R$styleable.AppBarLayout_android_keyboardNavigationCluster)) {
            xeqoollEuRxADqTS(this, CUQZAkQTwTLqcnPK(typedArrayRHEcRYzEWBfMQeUU, com.google.android.material.R$styleable.AppBarLayout_android_keyboardNavigationCluster, false));
        }
        if (cQVoZjvNcdAsxCvT(typedArrayRHEcRYzEWBfMQeUU, com.google.android.material.R$styleable.AppBarLayout_android_touchscreenBlocksFocus)) {
            gTBEgBYLHrrdmeQt(this, HOdmWtJGdPjRNSQz(typedArrayRHEcRYzEWBfMQeUU, com.google.android.material.R$styleable.AppBarLayout_android_touchscreenBlocksFocus, false));
        }
        this.appBarElevation = WzfEcKygvnIjmjIh(iMBCtHNosVqciPhk(this), com.google.android.material.R$dimen.design_appbar_elevation);
        this.liftOnScroll = vTvpYFCVKQFWjPOl(typedArrayRHEcRYzEWBfMQeUU, com.google.android.material.R$styleable.AppBarLayout_liftOnScroll, false);
        this.liftOnScrollTargetobjectId = pcGVNAXNHLzHMTuz(typedArrayRHEcRYzEWBfMQeUU, com.google.android.material.R$styleable.AppBarLayout_liftOnScrollTargetobjectId, -1);
        PJMfSPcQIYNhbzem(this, ZzKqZZsgIkfLnBLG(typedArrayRHEcRYzEWBfMQeUU, com.google.android.material.R$styleable.AppBarLayout_statusBarForeground));
        LvmInWxowbQMrBXW(typedArrayRHEcRYzEWBfMQeUU);
        tTFJnNfgEcHxxDjB(this, new com.google.android.material.appbar.AppBarLayout$1(this));
    }

    public static int AGlULtzMbpQqwMcz(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getChildCount();
    }

    public static void AGlULtzMbpQqwMcz(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AGlULtzMbpQqwMcz(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AGlULtzMbpQqwMcz(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ANbQfGvWbEFbftZM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static void ANbQfGvWbEFbftZM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, bool z, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ANbQfGvWbEFbftZM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, float f2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ANbQfGvWbEFbftZM(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, bool z, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void ARBMQAGGwGQhCkRY(java.lang.object obj, java.lang.object obj2, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ARBMQAGGwGQhCkRY(java.lang.object obj, java.lang.object obj2, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ARBMQAGGwGQhCkRY(java.lang.object obj, java.lang.object obj2, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool ARBMQAGGwGQhCkRY(java.lang.object obj, java.lang.object obj2) {
        return androidx.core.util.objectsCompat.Equals(obj, obj2);
    }

    public static void AscQlkYFHObUJzuc(android.view.object view, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AscQlkYFHObUJzuc(android.view.object view, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AscQlkYFHObUJzuc(android.view.object view, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool AscQlkYFHObUJzuc(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static int BVyORYcWPHCVSiYZ(android.view.object view) {
        return androidx.core.view.objectCompat.getMinimumHeight(view);
    }

    public static void BVyORYcWPHCVSiYZ(android.view.object view, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BVyORYcWPHCVSiYZ(android.view.object view, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BVyORYcWPHCVSiYZ(android.view.object view, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BmLheZCqZcGuEEeO(java.util.List list) {
        list.clear();
    }

    public static void BmLheZCqZcGuEEeO(java.util.List list, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BmLheZCqZcGuEEeO(java.util.List list, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BmLheZCqZcGuEEeO(java.util.List list, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CUQZAkQTwTLqcnPK(android.content.res.TypedArray typedArray, int i, bool z, float f, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CUQZAkQTwTLqcnPK(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CUQZAkQTwTLqcnPK(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool CUQZAkQTwTLqcnPK(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void CXjEeEoYvhzPPoFk(android.content.res.TypedArray typedArray, int i, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CXjEeEoYvhzPPoFk(android.content.res.TypedArray typedArray, int i, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CXjEeEoYvhzPPoFk(android.content.res.TypedArray typedArray, int i, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool CXjEeEoYvhzPPoFk(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static int CZClqqqjLsQQJgkW(int i) {
        return android.view.object$MeasureSpec.getMode(i);
    }

    public static void CZClqqqjLsQQJgkW(int i, byte b, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CZClqqqjLsQQJgkW(int i, float f, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CZClqqqjLsQQJgkW(int i, int i2, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams CeDiVExrTrmvUQNS(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void CeDiVExrTrmvUQNS(android.view.object view, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CeDiVExrTrmvUQNS(android.view.object view, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CeDiVExrTrmvUQNS(android.view.object view, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.TimeInterpolator CxOFOZwrSHhKdSaR(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void CxOFOZwrSHhKdSaR(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CxOFOZwrSHhKdSaR(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CxOFOZwrSHhKdSaR(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.appbar.AppBarLayout$LayoutParams DKdeYIrEFKbHbKni(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.generateDefaultLayoutParams();
    }

    public static void DKdeYIrEFKbHbKni(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DKdeYIrEFKbHbKni(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DKdeYIrEFKbHbKni(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DPRNtyEDlHnxyNCz(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DPRNtyEDlHnxyNCz(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DPRNtyEDlHnxyNCz(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int[] DPRNtyEDlHnxyNCz(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getDrawableState();
    }

    public static com.google.android.material.appbar.AppBarLayout$LayoutParams DRrfxzPjSyZzXAWa(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.generateDefaultLayoutParams();
    }

    public static void DRrfxzPjSyZzXAWa(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DRrfxzPjSyZzXAWa(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DRrfxzPjSyZzXAWa(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DsudnmsuiaRnFZWh(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void DsudnmsuiaRnFZWh(android.widget.LinearLayout linearLayout, int i, int i2, char c, int i3, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DsudnmsuiaRnFZWh(android.widget.LinearLayout linearLayout, int i, int i2, char c, java.lang.string str, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DsudnmsuiaRnFZWh(android.widget.LinearLayout linearLayout, int i, int i2, int i3, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList EEcXHJqFbxJynLJR(android.graphics.drawable.Drawable drawable) {
        return com.google.android.material.drawable.DrawableUtils.getColorStateListOrNull(drawable);
    }

    public static void EEcXHJqFbxJynLJR(android.graphics.drawable.Drawable drawable, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EEcXHJqFbxJynLJR(android.graphics.drawable.Drawable drawable, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EEcXHJqFbxJynLJR(android.graphics.drawable.Drawable drawable, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ESogvHjvMOGoAOlY(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ESogvHjvMOGoAOlY(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ESogvHjvMOGoAOlY(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool ESogvHjvMOGoAOlY(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.shouldOffsetFirstChild();
    }

    public static void EVQnhKAFOYjdKrPM(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, float f2) {
        appBarLayout.startLiftOnScrollColorAnimation(f, f2);
    }

    public static void EVQnhKAFOYjdKrPM(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, float f2, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EVQnhKAFOYjdKrPM(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, float f2, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EVQnhKAFOYjdKrPM(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, float f2, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int EnFCuQktiNOgdFYW(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void EnFCuQktiNOgdFYW(int i, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EnFCuQktiNOgdFYW(int i, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EnFCuQktiNOgdFYW(int i, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable FMWiJBfJMivZAPzm(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getBackground();
    }

    public static void FMWiJBfJMivZAPzm(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FMWiJBfJMivZAPzm(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FMWiJBfJMivZAPzm(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FSlXvumGJrnjbdfj(android.widget.LinearLayout linearLayout) {
        super.onDetachedFromWindow();
    }

    public static void FSlXvumGJrnjbdfj(android.widget.LinearLayout linearLayout, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FSlXvumGJrnjbdfj(android.widget.LinearLayout linearLayout, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FSlXvumGJrnjbdfj(android.widget.LinearLayout linearLayout, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GAWjgWWSZfMrQKEl(int[] iArr, int[] iArr2, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GAWjgWWSZfMrQKEl(int[] iArr, int[] iArr2, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GAWjgWWSZfMrQKEl(int[] iArr, int[] iArr2, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] GAWjgWWSZfMrQKEl(int[] iArr, int[] iArr2) {
        return mergeDrawableStates(iArr, iArr2);
    }

    public static void GhOhvwWBiDOIwumX(android.widget.LinearLayout linearLayout, int i) {
        super.setVisibility(i);
    }

    public static void GhOhvwWBiDOIwumX(android.widget.LinearLayout linearLayout, int i, short s, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GhOhvwWBiDOIwumX(android.widget.LinearLayout linearLayout, int i, bool z, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GhOhvwWBiDOIwumX(android.widget.LinearLayout linearLayout, int i, bool z, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GvjdLQShJPxtIOiJ(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas) {
        drawable.draw(canvas);
    }

    public static void GvjdLQShJPxtIOiJ(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GvjdLQShJPxtIOiJ(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GvjdLQShJPxtIOiJ(android.graphics.drawable.Drawable drawable, android.graphics.Canvas canvas, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList HBSCdwRbWsIqypoP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getFillColor();
    }

    public static void HBSCdwRbWsIqypoP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HBSCdwRbWsIqypoP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HBSCdwRbWsIqypoP(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HOdmWtJGdPjRNSQz(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, int i2, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HOdmWtJGdPjRNSQz(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, short s, bool z2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HOdmWtJGdPjRNSQz(android.content.res.TypedArray typedArray, int i, bool z, bool z2, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool HOdmWtJGdPjRNSQz(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static com.google.android.material.appbar.AppBarLayout$BaseBehavior$SavedState HSXZQDEcCBfUhdzZ(com.google.android.material.appbar.AppBarLayout$Behavior appBarLayout$Behavior, android.os.Parcelable parcelable, com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout$Behavior.saveScrollState(parcelable, appBarLayout);
    }

    public static void HSXZQDEcCBfUhdzZ(com.google.android.material.appbar.AppBarLayout$Behavior appBarLayout$Behavior, android.os.Parcelable parcelable, com.google.android.material.appbar.AppBarLayout appBarLayout, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HSXZQDEcCBfUhdzZ(com.google.android.material.appbar.AppBarLayout$Behavior appBarLayout$Behavior, android.os.Parcelable parcelable, com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HSXZQDEcCBfUhdzZ(com.google.android.material.appbar.AppBarLayout$Behavior appBarLayout$Behavior, android.os.Parcelable parcelable, com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HoHPZoKBqosfZCjj(com.google.android.material.appbar.AppBarLayout$LiftOnScrollListener appBarLayout$LiftOnScrollListener, float f, int i) {
        appBarLayout$LiftOnScrollListener.onUpdate(f, i);
    }

    public static void HoHPZoKBqosfZCjj(com.google.android.material.appbar.AppBarLayout$LiftOnScrollListener appBarLayout$LiftOnScrollListener, float f, int i, byte b, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HoHPZoKBqosfZCjj(com.google.android.material.appbar.AppBarLayout$LiftOnScrollListener appBarLayout$LiftOnScrollListener, float f, int i, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HoHPZoKBqosfZCjj(com.google.android.material.appbar.AppBarLayout$LiftOnScrollListener appBarLayout$LiftOnScrollListener, float f, int i, int i2, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int IFXWygPCgDHeQttw(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void IFXWygPCgDHeQttw(android.view.object view, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IFXWygPCgDHeQttw(android.view.object view, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IFXWygPCgDHeQttw(android.view.object view, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int IPOvYDTgoUBJtcfo(int i, int i2, int i3) {
        return androidx.core.math.MathUtils.clamp(i, i2, i3);
    }

    public static void IPOvYDTgoUBJtcfo(int i, int i2, int i3, char c, int i4, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IPOvYDTgoUBJtcfo(int i, int i2, int i3, char c, bool z, int i4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IPOvYDTgoUBJtcfo(int i, int i2, int i3, int i4, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IhwUKNmAgbZJzMlg(android.view.object view) {
        return androidx.core.view.objectCompat.getMinimumHeight(view);
    }

    public static void IhwUKNmAgbZJzMlg(android.view.object view, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IhwUKNmAgbZJzMlg(android.view.object view, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IhwUKNmAgbZJzMlg(android.view.object view, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IoyhtBPPstznyZAi(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IoyhtBPPstznyZAi(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IoyhtBPPstznyZAi(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool IoyhtBPPstznyZAi(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        return appBarLayout.setLiftableState(z);
    }

    public static int JBUkTaZCDlLStolU(android.view.object view) {
        return androidx.core.view.objectCompat.getMinimumHeight(view);
    }

    public static void JBUkTaZCDlLStolU(android.view.object view, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JBUkTaZCDlLStolU(android.view.object view, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JBUkTaZCDlLStolU(android.view.object view, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int JdTJEpaTXUMRthxs(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void JdTJEpaTXUMRthxs(android.content.object context, int i, int i2, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JdTJEpaTXUMRthxs(android.content.object context, int i, int i2, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JdTJEpaTXUMRthxs(android.content.object context, int i, int i2, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KAJwGmEukzzTQfJn(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getTopInset();
    }

    public static void KAJwGmEukzzTQfJn(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KAJwGmEukzzTQfJn(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KAJwGmEukzzTQfJn(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KwQqEZuAZhlOCORa(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getTotalScrollRange();
    }

    public static void KwQqEZuAZhlOCORa(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KwQqEZuAZhlOCORa(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KwQqEZuAZhlOCORa(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent LDBRpUXBpZjhVTJq(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getParent();
    }

    public static void LDBRpUXBpZjhVTJq(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LDBRpUXBpZjhVTJq(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LDBRpUXBpZjhVTJq(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int LTYPqcjaqyaoYGRQ(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void LTYPqcjaqyaoYGRQ(android.content.res.ColorStateList colorStateList, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LTYPqcjaqyaoYGRQ(android.content.res.ColorStateList colorStateList, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LTYPqcjaqyaoYGRQ(android.content.res.ColorStateList colorStateList, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LitZKMYGpobsVvrd(android.view.object view, float f) {
        com.google.android.material.shape.MaterialShapeUtils.setElevation(view, f);
    }

    public static void LitZKMYGpobsVvrd(android.view.object view, float f, byte b, int i, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void LitZKMYGpobsVvrd(android.view.object view, float f, char c, byte b, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void LitZKMYGpobsVvrd(android.view.object view, float f, char c, float f2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LjzYFsbUkNIzoYfp(android.view.object view) {
        return view.getVisibility();
    }

    public static void LjzYFsbUkNIzoYfp(android.view.object view, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LjzYFsbUkNIzoYfp(android.view.object view, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LjzYFsbUkNIzoYfp(android.view.object view, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int LtkyJOapxhpMhQyX(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.extractStatusBarForegroundColor();
    }

    public static void LtkyJOapxhpMhQyX(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LtkyJOapxhpMhQyX(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LtkyJOapxhpMhQyX(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LvmInWxowbQMrBXW(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void LvmInWxowbQMrBXW(android.content.res.TypedArray typedArray, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LvmInWxowbQMrBXW(android.content.res.TypedArray typedArray, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LvmInWxowbQMrBXW(android.content.res.TypedArray typedArray, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MTvbSVuuLMUZyxGp(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        appBarLayout.clearLiftOnScrollTargetobject();
    }

    public static void MTvbSVuuLMUZyxGp(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MTvbSVuuLMUZyxGp(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MTvbSVuuLMUZyxGp(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MeSRWrhmJhazOOow(android.widget.LinearLayout linearLayout, int i) {
        super.setOrientation(i);
    }

    public static void MeSRWrhmJhazOOow(android.widget.LinearLayout linearLayout, int i, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MeSRWrhmJhazOOow(android.widget.LinearLayout linearLayout, int i, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MeSRWrhmJhazOOow(android.widget.LinearLayout linearLayout, int i, java.lang.string str, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static int MkQZZtDPKKtlvDrX(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void MkQZZtDPKKtlvDrX(android.content.res.ColorStateList colorStateList, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MkQZZtDPKKtlvDrX(android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MkQZZtDPKKtlvDrX(android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MoivMyEcTcjsvnfb(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        appBarLayout.invalidateScrollRanges();
    }

    public static void MoivMyEcTcjsvnfb(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MoivMyEcTcjsvnfb(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MoivMyEcTcjsvnfb(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MqVEcaHNGtPwHlOL(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        appBarLayout.updateWillNotDraw();
    }

    public static void MqVEcaHNGtPwHlOL(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MqVEcaHNGtPwHlOL(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MqVEcaHNGtPwHlOL(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MqWgcZbkHpOdowMl(android.view.object view, int i, int i2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MqWgcZbkHpOdowMl(android.view.object view, int i, java.lang.string str, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MqWgcZbkHpOdowMl(android.view.object view, int i, java.lang.string str, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MqWgcZbkHpOdowMl(android.view.object view, int i) {
        return view.canScrollVertically(i);
    }

    public static void MsAtSBmoyIwrxvjJ(android.view.object view, float f) {
        com.google.android.material.appbar.objectUtilsLollipop.setDefaultAppBarLayoutStateListAnimator(view, f);
    }

    public static void MsAtSBmoyIwrxvjJ(android.view.object view, float f, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MsAtSBmoyIwrxvjJ(android.view.object view, float f, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MsAtSBmoyIwrxvjJ(android.view.object view, float f, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MsqLDiFTdebzHxZZ(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void MsqLDiFTdebzHxZZ(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, char c, int i5, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MsqLDiFTdebzHxZZ(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, float f, java.lang.string str, char c, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void MsqLDiFTdebzHxZZ(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, int i5, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NRjzbsnMQitLyfuP(android.widget.LinearLayout linearLayout, android.graphics.drawable.Drawable drawable, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NRjzbsnMQitLyfuP(android.widget.LinearLayout linearLayout, android.graphics.drawable.Drawable drawable, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NRjzbsnMQitLyfuP(android.widget.LinearLayout linearLayout, android.graphics.drawable.Drawable drawable, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NRjzbsnMQitLyfuP(android.widget.LinearLayout linearLayout, android.graphics.drawable.Drawable drawable) {
        return super.verifyDrawable(drawable);
    }

    public static java.lang.object NgEqmzcIQYaQFkDJ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void NgEqmzcIQYaQFkDJ(java.util.IEnumerator it, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NgEqmzcIQYaQFkDJ(java.util.IEnumerator it, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NgEqmzcIQYaQFkDJ(java.util.IEnumerator it, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int NoOcHeMOfLjfqrVR(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getChildCount();
    }

    public static void NoOcHeMOfLjfqrVR(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NoOcHeMOfLjfqrVR(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NoOcHeMOfLjfqrVR(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NvRCEOeHXCmQRytA(android.graphics.drawable.Drawable drawable, int i, byte b, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NvRCEOeHXCmQRytA(android.graphics.drawable.Drawable drawable, int i, float f, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NvRCEOeHXCmQRytA(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NvRCEOeHXCmQRytA(android.graphics.drawable.Drawable drawable, int i) {
        return androidx.core.graphics.drawable.DrawableCompat.setLayoutDirection(drawable, i);
    }

    public static int NvtwQJxmwPJkFOpU(java.util.List list) {
        return list.Count;
    }

    public static void NvtwQJxmwPJkFOpU(java.util.List list, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NvtwQJxmwPJkFOpU(java.util.List list, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NvtwQJxmwPJkFOpU(java.util.List list, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object ODiVKjZytDWCBvID(com.google.android.material.appbar.AppBarLayout appBarLayout, android.view.object view) {
        return appBarLayout.findLiftOnScrollTargetobject(view);
    }

    public static void ODiVKjZytDWCBvID(com.google.android.material.appbar.AppBarLayout appBarLayout, android.view.object view, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ODiVKjZytDWCBvID(com.google.android.material.appbar.AppBarLayout appBarLayout, android.view.object view, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ODiVKjZytDWCBvID(com.google.android.material.appbar.AppBarLayout appBarLayout, android.view.object view, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OFaauneUcZsHYagw(android.widget.LinearLayout linearLayout, float f) {
        super.setElevation(f);
    }

    public static void OFaauneUcZsHYagw(android.widget.LinearLayout linearLayout, float f, byte b, bool z, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void OFaauneUcZsHYagw(android.widget.LinearLayout linearLayout, float f, char c, byte b, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OFaauneUcZsHYagw(android.widget.LinearLayout linearLayout, float f, char c, bool z, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void OYjGhSDolNnSuYTb(android.graphics.drawable.Drawable drawable, int[] iArr, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OYjGhSDolNnSuYTb(android.graphics.drawable.Drawable drawable, int[] iArr, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OYjGhSDolNnSuYTb(android.graphics.drawable.Drawable drawable, int[] iArr, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OYjGhSDolNnSuYTb(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static int OeLPWlgYCJQUDNxC(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getMeasuredHeight();
    }

    public static void OeLPWlgYCJQUDNxC(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OeLPWlgYCJQUDNxC(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OeLPWlgYCJQUDNxC(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OhBvsEMtwjNebsmx(android.widget.LinearLayout linearLayout) {
        super.onAttachedToWindow();
    }

    public static void OhBvsEMtwjNebsmx(android.widget.LinearLayout linearLayout, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OhBvsEMtwjNebsmx(android.widget.LinearLayout linearLayout, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OhBvsEMtwjNebsmx(android.widget.LinearLayout linearLayout, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable OkQawfsykxyFpJJH(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getDrawable(i);
    }

    public static void OkQawfsykxyFpJJH(android.content.res.TypedArray typedArray, int i, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OkQawfsykxyFpJJH(android.content.res.TypedArray typedArray, int i, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OkQawfsykxyFpJJH(android.content.res.TypedArray typedArray, int i, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PJMfSPcQIYNhbzem(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable) {
        appBarLayout.setStatusBarForeground(drawable);
    }

    public static void PJMfSPcQIYNhbzem(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PJMfSPcQIYNhbzem(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PJMfSPcQIYNhbzem(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PgybQAgSMPBWnOpo(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, float f2) {
        appBarLayout.startLiftOnScrollColorAnimation(f, f2);
    }

    public static void PgybQAgSMPBWnOpo(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, float f2, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PgybQAgSMPBWnOpo(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, float f2, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PgybQAgSMPBWnOpo(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, float f2, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PkBXvKAGtmORrzgY(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void PkBXvKAGtmORrzgY(int i, int i2, char c, int i3, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PkBXvKAGtmORrzgY(int i, int i2, int i3, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PkBXvKAGtmORrzgY(int i, int i2, bool z, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PkyjnBIdtuCnadyD(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void PkyjnBIdtuCnadyD(android.view.object view, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PkyjnBIdtuCnadyD(android.view.object view, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PkyjnBIdtuCnadyD(android.view.object view, android.graphics.drawable.Drawable drawable, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object PnTNuItKRbPeqtzA(com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        return appBarLayout.getChildAt(i);
    }

    public static void PnTNuItKRbPeqtzA(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, byte b, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PnTNuItKRbPeqtzA(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PnTNuItKRbPeqtzA(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, short s, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PnvXqCyGccrjSegD(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PnvXqCyGccrjSegD(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PnvXqCyGccrjSegD(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PnvXqCyGccrjSegD(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.willNotDraw();
    }

    public static void QBMPwUHLyeQfwZQi(java.lang.ref.WeakReference weakReference) {
        weakReference.clear();
    }

    public static void QBMPwUHLyeQfwZQi(java.lang.ref.WeakReference weakReference, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QBMPwUHLyeQfwZQi(java.lang.ref.WeakReference weakReference, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QBMPwUHLyeQfwZQi(java.lang.ref.WeakReference weakReference, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QEeedzQDKOvmMEfV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void QEeedzQDKOvmMEfV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QEeedzQDKOvmMEfV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QEeedzQDKOvmMEfV(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.appbar.AppBarLayout$LayoutParams QZijJyihhiiOkkXk(com.google.android.material.appbar.AppBarLayout appBarLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return appBarLayout.generateLayoutParams(viewGroup$LayoutParams);
    }

    public static void QZijJyihhiiOkkXk(com.google.android.material.appbar.AppBarLayout appBarLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QZijJyihhiiOkkXk(com.google.android.material.appbar.AppBarLayout appBarLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QZijJyihhiiOkkXk(com.google.android.material.appbar.AppBarLayout appBarLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int REVwEfgnaciXjQcs(android.view.object view) {
        return view.getVisibility();
    }

    public static void REVwEfgnaciXjQcs(android.view.object view, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void REVwEfgnaciXjQcs(android.view.object view, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void REVwEfgnaciXjQcs(android.view.object view, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray RHEcRYzEWBfMQeUU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void RHEcRYzEWBfMQeUU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, byte b, float f, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RHEcRYzEWBfMQeUU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, byte b, bool z, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RHEcRYzEWBfMQeUU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, float f, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RabOYkOZqvBBABmx(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static void RabOYkOZqvBBABmx(android.animation.ValueAnimator valueAnimator, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RabOYkOZqvBBABmx(android.animation.ValueAnimator valueAnimator, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RabOYkOZqvBBABmx(android.animation.ValueAnimator valueAnimator, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RfZtMXkaLMpUOyHj(android.view.object view, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RfZtMXkaLMpUOyHj(android.view.object view, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RfZtMXkaLMpUOyHj(android.view.object view, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RfZtMXkaLMpUOyHj(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static void RtdsmtfifeSadksa(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RtdsmtfifeSadksa(android.graphics.drawable.Drawable drawable, bool z, bool z2, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RtdsmtfifeSadksa(android.graphics.drawable.Drawable drawable, bool z, bool z2, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RtdsmtfifeSadksa(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static void RwtWLdxuQkPAJKXV(android.view.object view, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RwtWLdxuQkPAJKXV(android.view.object view, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RwtWLdxuQkPAJKXV(android.view.object view, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RwtWLdxuQkPAJKXV(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static void SEjmEZRorJEnxPbm(android.widget.LinearLayout linearLayout, int i, char c, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SEjmEZRorJEnxPbm(android.widget.LinearLayout linearLayout, int i, char c, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SEjmEZRorJEnxPbm(android.widget.LinearLayout linearLayout, int i, java.lang.string str, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int[] SEjmEZRorJEnxPbm(android.widget.LinearLayout linearLayout, int i) {
        return super.onCreateDrawableState(i);
    }

    public static int SOhFMzJMGgaaxKRe(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void SOhFMzJMGgaaxKRe(int i, int i2, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SOhFMzJMGgaaxKRe(int i, int i2, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SOhFMzJMGgaaxKRe(int i, int i2, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int SYCOwiEWKTlqwGHm(android.content.object context, int i) {
        return com.google.android.material.color.MaterialColors.getColorOrNull(context, i);
    }

    public static void SYCOwiEWKTlqwGHm(android.content.object context, int i, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SYCOwiEWKTlqwGHm(android.content.object context, int i, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SYCOwiEWKTlqwGHm(android.content.object context, int i, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object SeJmYWWBOzDFaOhe(android.view.objectGroup viewGroup, int i) {
        return viewGroup.findobjectById(i);
    }

    public static void SeJmYWWBOzDFaOhe(android.view.objectGroup viewGroup, int i, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SeJmYWWBOzDFaOhe(android.view.objectGroup viewGroup, int i, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SeJmYWWBOzDFaOhe(android.view.objectGroup viewGroup, int i, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SmhwOupKrHJxTKPp(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SmhwOupKrHJxTKPp(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SmhwOupKrHJxTKPp(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool SmhwOupKrHJxTKPp(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams) {
        return appBarLayout$LayoutParams.isCollapsible();
    }

    public static void SzMJLxfEiMUIJOCm(android.graphics.drawable.Drawable drawable, int i) {
        androidx.core.graphics.drawable.DrawableCompat.setTint(drawable, i);
    }

    public static void SzMJLxfEiMUIJOCm(android.graphics.drawable.Drawable drawable, int i, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SzMJLxfEiMUIJOCm(android.graphics.drawable.Drawable drawable, int i, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SzMJLxfEiMUIJOCm(android.graphics.drawable.Drawable drawable, int i, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TFsCuopzZuxOlnRW(android.view.object view, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TFsCuopzZuxOlnRW(android.view.object view, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TFsCuopzZuxOlnRW(android.view.object view, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool TFsCuopzZuxOlnRW(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static int TWhiTGhGcCaRLAMi(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getTotalScrollRange();
    }

    public static void TWhiTGhGcCaRLAMi(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TWhiTGhGcCaRLAMi(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TWhiTGhGcCaRLAMi(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TnossPviSCJuUsAv(int i) {
        return android.view.object$MeasureSpec.getSize(i);
    }

    public static void TnossPviSCJuUsAv(int i, byte b, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TnossPviSCJuUsAv(int i, java.lang.string str, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TnossPviSCJuUsAv(int i, java.lang.string str, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UcElnDZQNJjwuPLm(android.view.object view, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UcElnDZQNJjwuPLm(android.view.object view, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UcElnDZQNJjwuPLm(android.view.object view, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool UcElnDZQNJjwuPLm(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static void UgyMISqUXiunlYie(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        appBarLayout.requestLayout();
    }

    public static void UgyMISqUXiunlYie(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UgyMISqUXiunlYie(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UgyMISqUXiunlYie(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UhjLchmOhqpLzvxh(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        appBarLayout.updateWillNotDraw();
    }

    public static void UhjLchmOhqpLzvxh(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UhjLchmOhqpLzvxh(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UhjLchmOhqpLzvxh(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UmkADQfUcwuifxiy(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void UmkADQfUcwuifxiy(java.util.IEnumerator it, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UmkADQfUcwuifxiy(java.util.IEnumerator it, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UmkADQfUcwuifxiy(java.util.IEnumerator it, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int VEjnZQkbqFxWNtFz(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getMeasuredHeight();
    }

    public static void VEjnZQkbqFxWNtFz(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VEjnZQkbqFxWNtFz(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VEjnZQkbqFxWNtFz(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VmeRbcrajvvXiqtp(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getChildCount();
    }

    public static void VmeRbcrajvvXiqtp(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VmeRbcrajvvXiqtp(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VmeRbcrajvvXiqtp(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VuWhQgGpWSFGFKiw(java.util.List list, java.lang.object obj, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VuWhQgGpWSFGFKiw(java.util.List list, java.lang.object obj, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VuWhQgGpWSFGFKiw(java.util.List list, java.lang.object obj, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool VuWhQgGpWSFGFKiw(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
    }

    public static android.view.object VuXhWRcGvImgOAEx(com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        return appBarLayout.getChildAt(i);
    }

    public static void VuXhWRcGvImgOAEx(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VuXhWRcGvImgOAEx(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, char c, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VuXhWRcGvImgOAEx(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, float f, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VxvNYLJYQShJFTrD(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getTopInset();
    }

    public static void VxvNYLJYQShJFTrD(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VxvNYLJYQShJFTrD(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VxvNYLJYQShJFTrD(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WGdunfITTpSaCOHP(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void WGdunfITTpSaCOHP(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WGdunfITTpSaCOHP(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WGdunfITTpSaCOHP(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WlcSXCrkMrtQIIJs(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getMeasuredWidth();
    }

    public static void WlcSXCrkMrtQIIJs(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WlcSXCrkMrtQIIJs(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WlcSXCrkMrtQIIJs(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float WzfEcKygvnIjmjIh(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static void WzfEcKygvnIjmjIh(android.content.res.Resources resources, int i, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WzfEcKygvnIjmjIh(android.content.res.Resources resources, int i, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WzfEcKygvnIjmjIh(android.content.res.Resources resources, int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int XFXdrsLwUVOsyQZB(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getWidth();
    }

    public static void XFXdrsLwUVOsyQZB(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XFXdrsLwUVOsyQZB(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XFXdrsLwUVOsyQZB(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XmizdfkSxfrpkLdF(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XmizdfkSxfrpkLdF(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XmizdfkSxfrpkLdF(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XmizdfkSxfrpkLdF(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        return appBarLayout.setLiftableState(z);
    }

    public static void XoMdCyTAQTVNoHbc(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        appBarLayout.refreshDrawableState();
    }

    public static void XoMdCyTAQTVNoHbc(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XoMdCyTAQTVNoHbc(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XoMdCyTAQTVNoHbc(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XySNgXgkULOsNSqo(java.util.List list, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XySNgXgkULOsNSqo(java.util.List list, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XySNgXgkULOsNSqo(java.util.List list, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XySNgXgkULOsNSqo(java.util.List list) {
        return list.Count == 0;
    }

    public static void YGkgQLmAfeFYKnDM(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, android.content.res.ColorStateList colorStateList2) {
        appBarLayout.initializeLiftOnScrollWithColor(materialShapeDrawable, colorStateList, colorStateList2);
    }

    public static void YGkgQLmAfeFYKnDM(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, android.content.res.ColorStateList colorStateList2, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YGkgQLmAfeFYKnDM(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, android.content.res.ColorStateList colorStateList2, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YGkgQLmAfeFYKnDM(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, android.content.res.ColorStateList colorStateList2, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YlPoBhoyylTbSkjq(android.content.res.TypedArray typedArray, int i, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YlPoBhoyylTbSkjq(android.content.res.TypedArray typedArray, int i, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YlPoBhoyylTbSkjq(android.content.res.TypedArray typedArray, int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YlPoBhoyylTbSkjq(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.content.object ZCmecaGqAaxfPXkb(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getobject();
    }

    public static void ZCmecaGqAaxfPXkb(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZCmecaGqAaxfPXkb(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZCmecaGqAaxfPXkb(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object ZDEimrrfLafeuPOZ(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void ZDEimrrfLafeuPOZ(android.view.object view, int i, float f, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZDEimrrfLafeuPOZ(android.view.object view, int i, int i2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZDEimrrfLafeuPOZ(android.view.object view, int i, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZOgMjrdOsNSoyxfS(java.util.List list, java.lang.object obj, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZOgMjrdOsNSoyxfS(java.util.List list, java.lang.object obj, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZOgMjrdOsNSoyxfS(java.util.List list, java.lang.object obj, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool ZOgMjrdOsNSoyxfS(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void ZpTlvKkCQafBwosQ(android.graphics.Canvas canvas, int i) {
        canvas.restoreToCount(i);
    }

    public static void ZpTlvKkCQafBwosQ(android.graphics.Canvas canvas, int i, float f, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZpTlvKkCQafBwosQ(android.graphics.Canvas canvas, int i, int i2, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZpTlvKkCQafBwosQ(android.graphics.Canvas canvas, int i, short s, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZvjIGsLuoOmUIAup(android.content.res.TypedArray typedArray, int i, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZvjIGsLuoOmUIAup(android.content.res.TypedArray typedArray, int i, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZvjIGsLuoOmUIAup(android.content.res.TypedArray typedArray, int i, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool ZvjIGsLuoOmUIAup(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.graphics.drawable.Drawable ZzKqZZsgIkfLnBLG(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getDrawable(i);
    }

    public static void ZzKqZZsgIkfLnBLG(android.content.res.TypedArray typedArray, int i, byte b, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZzKqZZsgIkfLnBLG(android.content.res.TypedArray typedArray, int i, byte b, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZzKqZZsgIkfLnBLG(android.content.res.TypedArray typedArray, int i, bool z, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AFmtiwWecETLXyoz(com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener, com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        appBarLayout$BaseOnOffsetChangedListener.onOffsetChanged(appBarLayout, i);
    }

    public static void AFmtiwWecETLXyoz(com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener, com.google.android.material.appbar.AppBarLayout appBarLayout, int i, int i2, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AFmtiwWecETLXyoz(com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener, com.google.android.material.appbar.AppBarLayout appBarLayout, int i, java.lang.string str, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AFmtiwWecETLXyoz(com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener, com.google.android.material.appbar.AppBarLayout appBarLayout, int i, bool z, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int AYxFurBGTRLHGkxZ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void AYxFurBGTRLHGkxZ(int i, int i2, float f, int i3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AYxFurBGTRLHGkxZ(int i, int i2, int i3, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AYxFurBGTRLHGkxZ(int i, int i2, short s, float f, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AfhAHEReXsTzjRXi(com.google.android.material.appbar.AppBarLayout$Behavior appBarLayout$Behavior, com.google.android.material.appbar.AppBarLayout$BaseBehavior$SavedState appBarLayout$BaseBehavior$SavedState, bool z) {
        appBarLayout$Behavior.restoreScrollState(appBarLayout$BaseBehavior$SavedState, z);
    }

    public static void AfhAHEReXsTzjRXi(com.google.android.material.appbar.AppBarLayout$Behavior appBarLayout$Behavior, com.google.android.material.appbar.AppBarLayout$BaseBehavior$SavedState appBarLayout$BaseBehavior$SavedState, bool z, byte b, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void AfhAHEReXsTzjRXi(com.google.android.material.appbar.AppBarLayout$Behavior appBarLayout$Behavior, com.google.android.material.appbar.AppBarLayout$BaseBehavior$SavedState appBarLayout$BaseBehavior$SavedState, bool z, short s, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void AfhAHEReXsTzjRXi(com.google.android.material.appbar.AppBarLayout$Behavior appBarLayout$Behavior, com.google.android.material.appbar.AppBarLayout$BaseBehavior$SavedState appBarLayout$BaseBehavior$SavedState, bool z, bool z2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable AjqJCFSVvGijcWUv(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getBackground();
    }

    public static void AjqJCFSVvGijcWUv(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AjqJCFSVvGijcWUv(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AjqJCFSVvGijcWUv(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AmIKfcuWMGvqjoBh(android.graphics.drawable.Drawable drawable, int[] iArr, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AmIKfcuWMGvqjoBh(android.graphics.drawable.Drawable drawable, int[] iArr, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AmIKfcuWMGvqjoBh(android.graphics.drawable.Drawable drawable, int[] iArr, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AmIKfcuWMGvqjoBh(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static int AyzZOpgmagyAzrwn(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getChildCount();
    }

    public static void AyzZOpgmagyAzrwn(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AyzZOpgmagyAzrwn(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AyzZOpgmagyAzrwn(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BKWaqezDxocPYbXx(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        appBarLayout.requestLayout();
    }

    public static void BKWaqezDxocPYbXx(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BKWaqezDxocPYbXx(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BKWaqezDxocPYbXx(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int BKdpfoJuojwRCpks(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void BKdpfoJuojwRCpks(android.content.res.TypedArray typedArray, int i, int i2, byte b, char c, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BKdpfoJuojwRCpks(android.content.res.TypedArray typedArray, int i, int i2, byte b, java.lang.string str, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void BKdpfoJuojwRCpks(android.content.res.TypedArray typedArray, int i, int i2, char c, byte b, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable BWygAojkeVBajXjL(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getBackground();
    }

    public static void BWygAojkeVBajXjL(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BWygAojkeVBajXjL(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BWygAojkeVBajXjL(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList BuMWXxlEXUpoModJ(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void BuMWXxlEXUpoModJ(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BuMWXxlEXUpoModJ(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BuMWXxlEXUpoModJ(android.content.object context, android.content.res.TypedArray typedArray, int i, bool z, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CFCEIndfLiVQyOfs(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static void CFCEIndfLiVQyOfs(android.animation.ValueAnimator valueAnimator, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CFCEIndfLiVQyOfs(android.animation.ValueAnimator valueAnimator, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CFCEIndfLiVQyOfs(android.animation.ValueAnimator valueAnimator, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CIbsjxlKsdhCilYS(android.widget.LinearLayout linearLayout) {
        super.drawableStateChanged();
    }

    public static void CIbsjxlKsdhCilYS(android.widget.LinearLayout linearLayout, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CIbsjxlKsdhCilYS(android.widget.LinearLayout linearLayout, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CIbsjxlKsdhCilYS(android.widget.LinearLayout linearLayout, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CQVoZjvNcdAsxCvT(android.content.res.TypedArray typedArray, int i, byte b, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CQVoZjvNcdAsxCvT(android.content.res.TypedArray typedArray, int i, short s, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CQVoZjvNcdAsxCvT(android.content.res.TypedArray typedArray, int i, bool z, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool CQVoZjvNcdAsxCvT(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    private void ClearLiftOnScrollTargetobject() {
        java.lang.ref.WeakReference<android.view.object> weakReference = this.liftOnScrollTargetobject;
        if (weakReference is not null) {
            QBMPwUHLyeQfwZQi(weakReference);
        }
        this.liftOnScrollTargetobject = null;
    }

    private void ClearLiftOnScrollTargetobject(char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void ClearLiftOnScrollTargetobject(char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ClearLiftOnScrollTargetobject(short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CpWLqAlJbMiTPCmU(android.view.object view, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CpWLqAlJbMiTPCmU(android.view.object view, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CpWLqAlJbMiTPCmU(android.view.object view, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool CpWLqAlJbMiTPCmU(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static void CstVKRLwrCrtwLcy(android.graphics.Canvas canvas, float f, float f2) {
        canvas.translate(f, f2);
    }

    public static void CstVKRLwrCrtwLcy(android.graphics.Canvas canvas, float f, float f2, byte b, float f3, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CstVKRLwrCrtwLcy(android.graphics.Canvas canvas, float f, float f2, float f3, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CstVKRLwrCrtwLcy(android.graphics.Canvas canvas, float f, float f2, short s, float f3, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CtZIIWkemcrHLJyw(android.graphics.Canvas canvas) {
        return canvas.save();
    }

    public static void CtZIIWkemcrHLJyw(android.graphics.Canvas canvas, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CtZIIWkemcrHLJyw(android.graphics.Canvas canvas, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CtZIIWkemcrHLJyw(android.graphics.Canvas canvas, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CuxoFmNUyOPsrdkW(android.widget.LinearLayout linearLayout, android.graphics.Canvas canvas) {
        super.draw(canvas);
    }

    public static void CuxoFmNUyOPsrdkW(android.widget.LinearLayout linearLayout, android.graphics.Canvas canvas, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CuxoFmNUyOPsrdkW(android.widget.LinearLayout linearLayout, android.graphics.Canvas canvas, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CuxoFmNUyOPsrdkW(android.widget.LinearLayout linearLayout, android.graphics.Canvas canvas, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable DLpfbmQwUKVysZut(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void DLpfbmQwUKVysZut(android.content.object context, int i, int i2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DLpfbmQwUKVysZut(android.content.object context, int i, short s, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DLpfbmQwUKVysZut(android.content.object context, int i, bool z, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DMjJriTaXKAxSMPV(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, int i2) {
        appBarLayout.setMeasuredDimension(i, i2);
    }

    public static void DMjJriTaXKAxSMPV(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, int i2, byte b, float f, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DMjJriTaXKAxSMPV(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, int i2, float f, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void DMjJriTaXKAxSMPV(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, int i2, int i3, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DPEcIqLyLLocHqjq(android.view.object view, int i) {
        androidx.core.view.objectCompat.offsetTopAndBottom(view, i);
    }

    public static void DPEcIqLyLLocHqjq(android.view.object view, int i, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DPEcIqLyLLocHqjq(android.view.object view, int i, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DPEcIqLyLLocHqjq(android.view.object view, int i, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DYxlBcIFfTcGmXKN(android.widget.LinearLayout linearLayout, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void DYxlBcIFfTcGmXKN(android.widget.LinearLayout linearLayout, bool z, int i, int i2, int i3, int i4, char c, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DYxlBcIFfTcGmXKN(android.widget.LinearLayout linearLayout, bool z, int i, int i2, int i3, int i4, java.lang.string str, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DYxlBcIFfTcGmXKN(android.widget.LinearLayout linearLayout, bool z, int i, int i2, int i3, int i4, short s, bool z2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator DdPOKtEMOSMIFfqM(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void DdPOKtEMOSMIFfqM(float[] fArr, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DdPOKtEMOSMIFfqM(float[] fArr, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DdPOKtEMOSMIFfqM(float[] fArr, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int DeVTWrkrGMOydlTG(android.view.object view) {
        return view.getScrollY();
    }

    public static void DeVTWrkrGMOydlTG(android.view.object view, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DeVTWrkrGMOydlTG(android.view.object view, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DeVTWrkrGMOydlTG(android.view.object view, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int DgNoBSVpYmaVCuPR(android.view.object view) {
        return view.getVisibility();
    }

    public static void DgNoBSVpYmaVCuPR(android.view.object view, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DgNoBSVpYmaVCuPR(android.view.object view, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DgNoBSVpYmaVCuPR(android.view.object view, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int DgyRqrKJmEfHNReu(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getTopInset();
    }

    public static void DgyRqrKJmEfHNReu(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DgyRqrKJmEfHNReu(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DgyRqrKJmEfHNReu(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DqdFCkqOYJuTHpsz(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void DqdFCkqOYJuTHpsz(android.view.object view, android.graphics.drawable.Drawable drawable, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DqdFCkqOYJuTHpsz(android.view.object view, android.graphics.drawable.Drawable drawable, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DqdFCkqOYJuTHpsz(android.view.object view, android.graphics.drawable.Drawable drawable, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EEJWBJHtIDCplTcc(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable) {
        appBarLayout.setStatusBarForeground(drawable);
    }

    public static void EEJWBJHtIDCplTcc(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EEJWBJHtIDCplTcc(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EEJWBJHtIDCplTcc(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EOHvMRpGkavOsQeN(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EOHvMRpGkavOsQeN(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EOHvMRpGkavOsQeN(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool EOHvMRpGkavOsQeN(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.shouldOffsetFirstChild();
    }

    public static int EUdNAdqGJkXrSFbW(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getResolvedTintColor();
    }

    public static void EUdNAdqGJkXrSFbW(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EUdNAdqGJkXrSFbW(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EUdNAdqGJkXrSFbW(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private java.lang.int ExtractStatusBarForegroundColor() {
        android.graphics.drawable.Drawable drawable = this.statusBarForeground;
        if (drawable is com.google.android.material.shape.MaterialShapeDrawable) {
            return EnFCuQktiNOgdFYW(eUdNAdqGJkXrSFbW((com.google.android.material.shape.MaterialShapeDrawable) drawable));
        }
        android.content.res.ColorStateList colorStateListTKoeOohCnoZnmXcE = tKoeOohCnoZnmXcE(drawable);
        if (colorStateListTKoeOohCnoZnmXcE is null) {
            return null;
        }
        return rTxRjoPyJNSnkXEc(LTYPqcjaqyaoYGRQ(colorStateListTKoeOohCnoZnmXcE));
    }

    private void ExtractStatusBarForegroundColor(float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ExtractStatusBarForegroundColor(bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void ExtractStatusBarForegroundColor(bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private android.view.object FindLiftOnScrollTargetobject(android.view.object view) {
        if ((10 + 13) % 13 > 0) {
        }
        if (this.liftOnScrollTargetobject is null) {
            int i = this.liftOnScrollTargetobjectId;
            if (i != -1) {
                android.view.object viewZDEimrrfLafeuPOZ = view is null ? null : ZDEimrrfLafeuPOZ(view, i);
                if (viewZDEimrrfLafeuPOZ is null && (LDBRpUXBpZjhVTJq(this) instanceof android.view.objectGroup)) {
                    viewZDEimrrfLafeuPOZ = SeJmYWWBOzDFaOhe((android.view.objectGroup) ojGbTdyxsQTjBjra(this), this.liftOnScrollTargetobjectId);
                }
                if (viewZDEimrrfLafeuPOZ is not null) {
                    this.liftOnScrollTargetobject = new java.lang.ref.WeakReference<>(viewZDEimrrfLafeuPOZ);
                }
            }
        }
        java.lang.ref.WeakReference<android.view.object> weakReference = this.liftOnScrollTargetobject;
        if (weakReference is null) {
            return null;
        }
        return (android.view.object) kzSHslNdmhIPOKbj(weakReference);
    }

    private void FindLiftOnScrollTargetobject(android.view.object view, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void FindLiftOnScrollTargetobject(android.view.object view, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void FindLiftOnScrollTargetobject(android.view.object view, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FnVhyogTVvghwcZe(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static void FnVhyogTVvghwcZe(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FnVhyogTVvghwcZe(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FnVhyogTVvghwcZe(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GTBEgBYLHrrdmeQt(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        appBarLayout.setTouchscreenBlocksFocus(z);
    }

    public static void GTBEgBYLHrrdmeQt(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GTBEgBYLHrrdmeQt(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GTBEgBYLHrrdmeQt(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources GnQWUrvpEgLioade(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getResources();
    }

    public static void GnQWUrvpEgLioade(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GnQWUrvpEgLioade(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GnQWUrvpEgLioade(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HCLvEitWmpzZVYst(com.google.android.material.appbar.AppBarLayout$LiftOnScrollListener appBarLayout$LiftOnScrollListener, float f, int i) {
        appBarLayout$LiftOnScrollListener.onUpdate(f, i);
    }

    public static void HCLvEitWmpzZVYst(com.google.android.material.appbar.AppBarLayout$LiftOnScrollListener appBarLayout$LiftOnScrollListener, float f, int i, int i2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HCLvEitWmpzZVYst(com.google.android.material.appbar.AppBarLayout$LiftOnScrollListener appBarLayout$LiftOnScrollListener, float f, int i, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HCLvEitWmpzZVYst(com.google.android.material.appbar.AppBarLayout$LiftOnScrollListener appBarLayout$LiftOnScrollListener, float f, int i, java.lang.string str, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int HLgYDvrEPhuDlrXY(android.view.object view) {
        return androidx.core.view.objectCompat.getMinimumHeight(view);
    }

    public static void HLgYDvrEPhuDlrXY(android.view.object view, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HLgYDvrEPhuDlrXY(android.view.object view, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HLgYDvrEPhuDlrXY(android.view.object view, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void HasCollapsibleChild(char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void HasCollapsibleChild(float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void HasCollapsibleChild(short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private bool HasCollapsibleChild() {
        if ((27 + 22) % 22 > 0) {
        }
        int iVmeRbcrajvvXiqtp = VmeRbcrajvvXiqtp(this);
        for (int i = 0; i < iVmeRbcrajvvXiqtp; i++) {
            if (SmhwOupKrHJxTKPp((com.google.android.material.appbar.AppBarLayout$LayoutParams) iWTayuGsEpjhChRn(naXluEHYWTFTnokw(this, i)))) {
                return true;
            }
        }
        return false;
    }

    public static void HxtAnkaelhdHxIWb(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2) {
        appBarLayout.setExpanded(z, z2);
    }

    public static void HxtAnkaelhdHxIWb(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HxtAnkaelhdHxIWb(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HxtAnkaelhdHxIWb(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IBJlQYCDOSTFvOgZ(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable) {
        appBarLayout.invalidateDrawable(drawable);
    }

    public static void IBJlQYCDOSTFvOgZ(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IBJlQYCDOSTFvOgZ(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IBJlQYCDOSTFvOgZ(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources IMBCtHNosVqciPhk(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getResources();
    }

    public static void IMBCtHNosVqciPhk(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IMBCtHNosVqciPhk(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IMBCtHNosVqciPhk(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object IVxXwVLIkXEDKLsm(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void IVxXwVLIkXEDKLsm(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, float f, byte b, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IVxXwVLIkXEDKLsm(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IVxXwVLIkXEDKLsm(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, byte b, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams iWTayuGsEpjhChRn(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void IWTayuGsEpjhChRn(android.view.object view, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IWTayuGsEpjhChRn(android.view.object view, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IWTayuGsEpjhChRn(android.view.object view, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IXOHAcqDgihWhmjF(android.view.object view, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IXOHAcqDgihWhmjF(android.view.object view, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IXOHAcqDgihWhmjF(android.view.object view, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IXOHAcqDgihWhmjF(android.view.object view) {
        return androidx.core.view.objectCompat.getFitsSystemWindows(view);
    }

    public static int IkCZQQAQTSVnheeV(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static void IkCZQQAQTSVnheeV(androidx.core.view.WindowInsetsCompat windowInsetsCompat, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IkCZQQAQTSVnheeV(androidx.core.view.WindowInsetsCompat windowInsetsCompat, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IkCZQQAQTSVnheeV(androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void InitializeLiftOnScrollWithColor(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, android.content.res.ColorStateList colorStateList2) {
        if ((7 + 16) % 16 > 0) {
        }
        this.liftOnScrollColorUpdateListener = new com.google.android.material.appbar.AppBarLayout$$ExternalSyntheticLambda0(this, colorStateList, colorStateList2, materialShapeDrawable, SYCOwiEWKTlqwGHm(vhFXnlFDLpGSeoAd(this), com.google.android.material.R$attr.colorSurface));
        yBbEOvRItEqwuXCH(this, materialShapeDrawable);
    }

    private void InitializeLiftOnScrollWithColor(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, android.content.res.ColorStateList colorStateList2, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void InitializeLiftOnScrollWithColor(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, android.content.res.ColorStateList colorStateList2, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void InitializeLiftOnScrollWithColor(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, android.content.res.ColorStateList colorStateList2, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void InitializeLiftOnScrollWithElevation(android.content.object context, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        kBSHvFQZGwMZGeUC(materialShapeDrawable, context);
        this.liftOnScrollColorUpdateListener = new com.google.android.material.appbar.AppBarLayout$$ExternalSyntheticLambda1(this, materialShapeDrawable);
        dqdFCkqOYJuTHpsz(this, materialShapeDrawable);
    }

    private void InitializeLiftOnScrollWithElevation(android.content.object context, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void InitializeLiftOnScrollWithElevation(android.content.object context, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void InitializeLiftOnScrollWithElevation(android.content.object context, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void InvalidateScrollRanges() {
        if ((25 + 17) % 17 > 0) {
        }
        com.google.android.material.appbar.AppBarLayout$Behavior appBarLayout$Behavior = this.behavior;
        com.google.android.material.appbar.AppBarLayout$BaseBehavior$SavedState appBarLayout$BaseBehavior$SavedStateHSXZQDEcCBfUhdzZ = (appBarLayout$Behavior is null || this.totalScrollRange == -1 || this.pendingAction != 0) ? null : HSXZQDEcCBfUhdzZ(appBarLayout$Behavior, androidx.customview.view.AbsSavedState.EMPTY_STATE, this);
        this.totalScrollRange = -1;
        this.downPreScrollRange = -1;
        this.downScrollRange = -1;
        if (appBarLayout$BaseBehavior$SavedStateHSXZQDEcCBfUhdzZ is null) {
            return;
        }
        afhAHEReXsTzjRXi(this.behavior, appBarLayout$BaseBehavior$SavedStateHSXZQDEcCBfUhdzZ, false);
    }

    private void InvalidateScrollRanges(byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void InvalidateScrollRanges(char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void InvalidateScrollRanges(int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void IsLiftOnScrollCompatibleBackground(float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsLiftOnScrollCompatibleBackground(short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void IsLiftOnScrollCompatibleBackground(short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private bool IsLiftOnScrollCompatibleBackground() {
        return FMWiJBfJMivZAPzm(this) instanceof com.google.android.material.shape.MaterialShapeDrawable;
    }

    public static com.google.android.material.appbar.AppBarLayout$LayoutParams iuGBUGlFwfvejdpS(com.google.android.material.appbar.AppBarLayout appBarLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return appBarLayout.generateLayoutParams(viewGroup$LayoutParams);
    }

    public static void IuGBUGlFwfvejdpS(com.google.android.material.appbar.AppBarLayout appBarLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IuGBUGlFwfvejdpS(com.google.android.material.appbar.AppBarLayout appBarLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IuGBUGlFwfvejdpS(com.google.android.material.appbar.AppBarLayout appBarLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IxIRolutJoxWabpx(android.graphics.drawable.Drawable drawable, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IxIRolutJoxWabpx(android.graphics.drawable.Drawable drawable, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IxIRolutJoxWabpx(android.graphics.drawable.Drawable drawable, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool IxIRolutJoxWabpx(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static android.view.object JWrUPwHAwTmQBWmt(com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        return appBarLayout.getChildAt(i);
    }

    public static void JWrUPwHAwTmQBWmt(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, int i2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JWrUPwHAwTmQBWmt(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, short s, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JWrUPwHAwTmQBWmt(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, bool z, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JXUcnEZzIMiZznbc(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        appBarLayout.refreshDrawableState();
    }

    public static void JXUcnEZzIMiZznbc(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JXUcnEZzIMiZznbc(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JXUcnEZzIMiZznbc(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JZRLaZRAdFFStbRB(android.content.res.TypedArray typedArray, int i, bool z, byte b, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JZRLaZRAdFFStbRB(android.content.res.TypedArray typedArray, int i, bool z, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JZRLaZRAdFFStbRB(android.content.res.TypedArray typedArray, int i, bool z, int i2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool JZRLaZRAdFFStbRB(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void JawwrBmPYhHndMxA(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener) {
        appBarLayout.removeOnOffsetChangedListener(appBarLayout$BaseOnOffsetChangedListener);
    }

    public static void JawwrBmPYhHndMxA(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JawwrBmPYhHndMxA(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JawwrBmPYhHndMxA(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int JjSiXCBJRpLTRBGk(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void JjSiXCBJRpLTRBGk(int i, int i2, int i3, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JjSiXCBJRpLTRBGk(int i, int i2, int i3, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JjSiXCBJRpLTRBGk(int i, int i2, short s, float f, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void KBSHvFQZGwMZGeUC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static void KBSHvFQZGwMZGeUC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KBSHvFQZGwMZGeUC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KBSHvFQZGwMZGeUC(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KHUbwCQOiTuzyVfB(java.util.List list, int i) {
        return list[i);
    }

    public static void KHUbwCQOiTuzyVfB(java.util.List list, int i, byte b, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KHUbwCQOiTuzyVfB(java.util.List list, int i, float f, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KHUbwCQOiTuzyVfB(java.util.List list, int i, int i2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable KIPuQaYJUspBLKGq(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void KIPuQaYJUspBLKGq(android.graphics.drawable.Drawable drawable, byte b, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KIPuQaYJUspBLKGq(android.graphics.drawable.Drawable drawable, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KIPuQaYJUspBLKGq(android.graphics.drawable.Drawable drawable, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams kLLPEceSFpFSzdmy(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void KLLPEceSFpFSzdmy(android.view.object view, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KLLPEceSFpFSzdmy(android.view.object view, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KLLPEceSFpFSzdmy(android.view.object view, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator KfNrqNqxqRXuFFTi(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void KfNrqNqxqRXuFFTi(java.util.List list, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KfNrqNqxqRXuFFTi(java.util.List list, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KfNrqNqxqRXuFFTi(java.util.List list, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KpLJEjeBDfgahMzf(android.graphics.drawable.Drawable drawable, bool z, bool z2, byte b, bool z3, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KpLJEjeBDfgahMzf(android.graphics.drawable.Drawable drawable, bool z, bool z2, char c, short s, byte b, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void KpLJEjeBDfgahMzf(android.graphics.drawable.Drawable drawable, bool z, bool z2, short s, bool z3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KpLJEjeBDfgahMzf(android.graphics.drawable.Drawable drawable, bool z, bool z2) {
        return drawable.setVisible(z, z2);
    }

    public static java.lang.object KtTlHBCkGKKEICAQ(android.animation.ValueAnimator valueAnimator) {
        return valueAnimator.getAnimatedValue();
    }

    public static void KtTlHBCkGKKEICAQ(android.animation.ValueAnimator valueAnimator, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KtTlHBCkGKKEICAQ(android.animation.ValueAnimator valueAnimator, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KtTlHBCkGKKEICAQ(android.animation.ValueAnimator valueAnimator, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int KwCZHFHunpvAplIV(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getTopInset();
    }

    public static void KwCZHFHunpvAplIV(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KwCZHFHunpvAplIV(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KwCZHFHunpvAplIV(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KzSHslNdmhIPOKbj(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void KzSHslNdmhIPOKbj(java.lang.ref.WeakReference weakReference, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KzSHslNdmhIPOKbj(java.lang.ref.WeakReference weakReference, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KzSHslNdmhIPOKbj(java.lang.ref.WeakReference weakReference, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LHXXAcdsNaSJqsVj(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void LHXXAcdsNaSJqsVj(android.view.object view, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LHXXAcdsNaSJqsVj(android.view.object view, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LHXXAcdsNaSJqsVj(android.view.object view, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LIOZVZqxoqPjjLoi(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getTopInset();
    }

    public static void LIOZVZqxoqPjjLoi(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LIOZVZqxoqPjjLoi(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LIOZVZqxoqPjjLoi(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LQaXtXTvhwYjOeoR(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getTopInset();
    }

    public static void LQaXtXTvhwYjOeoR(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LQaXtXTvhwYjOeoR(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LQaXtXTvhwYjOeoR(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object LYmPheoLjwceEEck(com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        return appBarLayout.getChildAt(i);
    }

    public static void LYmPheoLjwceEEck(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, int i2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LYmPheoLjwceEEck(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, short s, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LYmPheoLjwceEEck(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, short s, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LdZOKAbuBMUwRNST(android.view.object view, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        com.google.android.material.appbar.objectUtilsLollipop.setStateListAnimatorFromAttrs(view, attributeHashSet, i, i2);
    }

    public static void LdZOKAbuBMUwRNST(android.view.object view, android.util.AttributeHashSet attributeHashSet, int i, int i2, char c, short s, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LdZOKAbuBMUwRNST(android.view.object view, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, char c, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LdZOKAbuBMUwRNST(android.view.object view, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, char c, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object LkEaZGgZOJcJbvPJ(com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        return appBarLayout.getChildAt(i);
    }

    public static void LkEaZGgZOJcJbvPJ(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, int i2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LkEaZGgZOJcJbvPJ(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, int i2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LkEaZGgZOJcJbvPJ(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, short s, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LqSNSMPxaboRMPSC(java.util.IEnumerator it, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LqSNSMPxaboRMPSC(java.util.IEnumerator it, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LqSNSMPxaboRMPSC(java.util.IEnumerator it, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool LqSNSMPxaboRMPSC(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void LyzrawahlWBcnGfF(android.view.object view) {
        androidx.core.view.objectCompat.postInvalidateOnAnimation(view);
    }

    public static void LyzrawahlWBcnGfF(android.view.object view, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LyzrawahlWBcnGfF(android.view.object view, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LyzrawahlWBcnGfF(android.view.object view, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MCIZqBciUkkHFbNy(android.view.object view) {
        com.google.android.material.shape.MaterialShapeUtils.setParentAbsoluteElevation(view);
    }

    public static void MCIZqBciUkkHFbNy(android.view.object view, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MCIZqBciUkkHFbNy(android.view.object view, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MCIZqBciUkkHFbNy(android.view.object view, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.animation.Interpolator MCqPZhcgDkYKNyiB(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams) {
        return appBarLayout$LayoutParams.getScrollInterpolator();
    }

    public static void MCqPZhcgDkYKNyiB(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MCqPZhcgDkYKNyiB(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MCqPZhcgDkYKNyiB(com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MCtgLtVLFYfciCpy(android.view.object view, float f) {
        com.google.android.material.appbar.objectUtilsLollipop.setDefaultAppBarLayoutStateListAnimator(view, f);
    }

    public static void MCtgLtVLFYfciCpy(android.view.object view, float f, float f2, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MCtgLtVLFYfciCpy(android.view.object view, float f, float f2, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MCtgLtVLFYfciCpy(android.view.object view, float f, bool z, short s, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MDBPOMgMWQgaTymO(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener) {
        appBarLayout.addOnOffsetChangedListener(appBarLayout$BaseOnOffsetChangedListener);
    }

    public static void MDBPOMgMWQgaTymO(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MDBPOMgMWQgaTymO(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MDBPOMgMWQgaTymO(com.google.android.material.appbar.AppBarLayout appBarLayout, com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object MIqsFWgwxzJPvsYd(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getobject();
    }

    public static void MIqsFWgwxzJPvsYd(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MIqsFWgwxzJPvsYd(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MIqsFWgwxzJPvsYd(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static float MNBjiVSLfKZtCiuO(java.lang.float f) {
        return f.floatValue();
    }

    public static void MNBjiVSLfKZtCiuO(java.lang.float f, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MNBjiVSLfKZtCiuO(java.lang.float f, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MNBjiVSLfKZtCiuO(java.lang.float f, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MTsEtsUKsEBqiJyN(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, bool z3) {
        appBarLayout.setExpanded(z, z2, z3);
    }

    public static void MTsEtsUKsEBqiJyN(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, bool z3, float f, char c, bool z4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MTsEtsUKsEBqiJyN(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, bool z3, java.lang.string str, float f, char c, bool z4) {
        double d = (42 * 210) + 210;
    }

    public static void MTsEtsUKsEBqiJyN(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, bool z3, bool z4, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MZeQukvsesAKGRit(com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        appBarLayout.setOrientation(i);
    }

    public static void MZeQukvsesAKGRit(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, float f, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MZeQukvsesAKGRit(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, float f, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MZeQukvsesAKGRit(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, int i2, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int NMIdxZnhkwkHCWyd(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getHeight();
    }

    public static void NMIdxZnhkwkHCWyd(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NMIdxZnhkwkHCWyd(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NMIdxZnhkwkHCWyd(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NSpwxnajNjXDndJw(com.google.android.material.appbar.AppBarLayout appBarLayout, android.content.object context, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        appBarLayout.initializeLiftOnScrollWithElevation(context, materialShapeDrawable);
    }

    public static void NSpwxnajNjXDndJw(com.google.android.material.appbar.AppBarLayout appBarLayout, android.content.object context, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NSpwxnajNjXDndJw(com.google.android.material.appbar.AppBarLayout appBarLayout, android.content.object context, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NSpwxnajNjXDndJw(com.google.android.material.appbar.AppBarLayout appBarLayout, android.content.object context, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator NWjVZXbXhVWdIpQN(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void NWjVZXbXhVWdIpQN(android.animation.ValueAnimator valueAnimator, long j, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NWjVZXbXhVWdIpQN(android.animation.ValueAnimator valueAnimator, long j, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NWjVZXbXhVWdIpQN(android.animation.ValueAnimator valueAnimator, long j, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object NaXluEHYWTFTnokw(com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        return appBarLayout.getChildAt(i);
    }

    public static void NaXluEHYWTFTnokw(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NaXluEHYWTFTnokw(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NaXluEHYWTFTnokw(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList NltGTFsmBrqMOzKJ(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void NltGTFsmBrqMOzKJ(int i, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NltGTFsmBrqMOzKJ(int i, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NltGTFsmBrqMOzKJ(int i, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NtVbunMKCGAwjJVH(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void NtVbunMKCGAwjJVH(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NtVbunMKCGAwjJVH(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NtVbunMKCGAwjJVH(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NuhIELWoxLxtmtKc(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NuhIELWoxLxtmtKc(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NuhIELWoxLxtmtKc(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] NuhIELWoxLxtmtKc(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getDrawableState();
    }

    public static android.view.objectParent OjGbTdyxsQTjBjra(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getParent();
    }

    public static void OjGbTdyxsQTjBjra(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OjGbTdyxsQTjBjra(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OjGbTdyxsQTjBjra(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int OzEyuUNUoPLlzuqK(android.view.object view) {
        return view.getVisibility();
    }

    public static void OzEyuUNUoPLlzuqK(android.view.object view, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OzEyuUNUoPLlzuqK(android.view.object view, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OzEyuUNUoPLlzuqK(android.view.object view, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PJdaTILGbiLkjkbB(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void PJdaTILGbiLkjkbB(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PJdaTILGbiLkjkbB(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PJdaTILGbiLkjkbB(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PMcAKZVAgcLgGkdL(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void PMcAKZVAgcLgGkdL(android.content.res.ColorStateList colorStateList, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PMcAKZVAgcLgGkdL(android.content.res.ColorStateList colorStateList, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PMcAKZVAgcLgGkdL(android.content.res.ColorStateList colorStateList, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PaoLgimqKiChivbv(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getChildCount();
    }

    public static void PaoLgimqKiChivbv(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PaoLgimqKiChivbv(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PaoLgimqKiChivbv(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PcGVNAXNHLzHMTuz(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void PcGVNAXNHLzHMTuz(android.content.res.TypedArray typedArray, int i, int i2, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PcGVNAXNHLzHMTuz(android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PcGVNAXNHLzHMTuz(android.content.res.TypedArray typedArray, int i, int i2, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PgfqtmDeSChoDcMd(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PgfqtmDeSChoDcMd(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PgfqtmDeSChoDcMd(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool PgfqtmDeSChoDcMd(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.shouldDrawStatusBarForeground();
    }

    public static void PgqPBykLKYWUIFPg(java.util.List list, java.lang.object obj, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PgqPBykLKYWUIFPg(java.util.List list, java.lang.object obj, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PgqPBykLKYWUIFPg(java.util.List list, java.lang.object obj, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PgqPBykLKYWUIFPg(java.util.List list, java.lang.object obj) {
        return list.Contains(obj);
    }

    public static void QvAtOnVOYHUdEKkk(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QvAtOnVOYHUdEKkk(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QvAtOnVOYHUdEKkk(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QvAtOnVOYHUdEKkk(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2) {
        return appBarLayout.setLiftedState(z, z2);
    }

    public static java.lang.int RTxRjoPyJNSnkXEc(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void RTxRjoPyJNSnkXEc(int i, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RTxRjoPyJNSnkXEc(int i, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RTxRjoPyJNSnkXEc(int i, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int RnBJQjsvkXRZptSf(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static void RnBJQjsvkXRZptSf(int i, int i2, float f, byte b, float f2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RnBJQjsvkXRZptSf(int i, int i2, float f, byte b, java.lang.string str, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void RnBJQjsvkXRZptSf(int i, int i2, float f, byte b, short s, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int RtidExdaqgqYMuHU(android.view.object view) {
        return androidx.core.view.objectCompat.getMinimumHeight(view);
    }

    public static void RtidExdaqgqYMuHU(android.view.object view, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RtidExdaqgqYMuHU(android.view.object view, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RtidExdaqgqYMuHU(android.view.object view, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RvNGbJzxzZYeJrjr(android.graphics.drawable.Drawable drawable, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RvNGbJzxzZYeJrjr(android.graphics.drawable.Drawable drawable, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RvNGbJzxzZYeJrjr(android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RvNGbJzxzZYeJrjr(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static void SIhPzZuURnUTWkLB(java.lang.int num, java.lang.object obj, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SIhPzZuURnUTWkLB(java.lang.int num, java.lang.object obj, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SIhPzZuURnUTWkLB(java.lang.int num, java.lang.object obj, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool SIhPzZuURnUTWkLB(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static com.google.android.material.appbar.AppBarLayout$LayoutParams sbVZmbpyCdDydcLw(com.google.android.material.appbar.AppBarLayout appBarLayout, android.util.AttributeHashSet attributeHashSet) {
        return appBarLayout.generateLayoutParams(attributeHashSet);
    }

    public static void SbVZmbpyCdDydcLw(com.google.android.material.appbar.AppBarLayout appBarLayout, android.util.AttributeHashSet attributeHashSet, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SbVZmbpyCdDydcLw(com.google.android.material.appbar.AppBarLayout appBarLayout, android.util.AttributeHashSet attributeHashSet, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SbVZmbpyCdDydcLw(com.google.android.material.appbar.AppBarLayout appBarLayout, android.util.AttributeHashSet attributeHashSet, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ScXVaHkAtBZrsLmt(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void ScXVaHkAtBZrsLmt(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ScXVaHkAtBZrsLmt(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ScXVaHkAtBZrsLmt(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams seonnEZHivxrmtGe(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void SeonnEZHivxrmtGe(android.view.object view, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SeonnEZHivxrmtGe(android.view.object view, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SeonnEZHivxrmtGe(android.view.object view, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetExpanded(bool z, bool z2, bool z3) {
        this.pendingAction = (!z ? 2 : 1) | (!z2 ? 0 : 4) | (z3 ? 8 : 0);
        UgyMISqUXiunlYie(this);
    }

    private void SetExpanded(bool z, bool z2, bool z3, int i, float f, bool z4, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetExpanded(bool z, bool z2, bool z3, short s, int i, bool z4, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetExpanded(bool z, bool z2, bool z3, bool z4, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetLiftableState(bool z, float f, short s, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void SetLiftableState(bool z, float f, bool z2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetLiftableState(bool z, short s, bool z2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private bool SetLiftableState(bool z) {
        if (this.liftable == z) {
            return false;
        }
        this.liftable = z;
        jXUcnEZzIMiZznbc(this);
        return true;
    }

    private void ShouldDrawStatusBarForeground(byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldDrawStatusBarForeground(bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldDrawStatusBarForeground(bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldDrawStatusBarForeground() {
        return this.statusBarForeground is not null && wFvDOhuEzYEphLEM(this) > 0;
    }

    private void ShouldOffsetFirstChild(char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldOffsetFirstChild(int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ShouldOffsetFirstChild(short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldOffsetFirstChild() {
        if ((11 + 28) % 28 > 0) {
        }
        if (AGlULtzMbpQqwMcz(this) > 0) {
            android.view.object viewPnTNuItKRbPeqtzA = PnTNuItKRbPeqtzA(this, 0);
            if (ozEyuUNUoPLlzuqK(viewPnTNuItKRbPeqtzA) != 8 && !UcElnDZQNJjwuPLm(viewPnTNuItKRbPeqtzA)) {
                return true;
            }
        }
        return false;
    }

    public static int SodxHKjYhRPbaDiP(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getVisibility();
    }

    public static void SodxHKjYhRPbaDiP(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SodxHKjYhRPbaDiP(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SodxHKjYhRPbaDiP(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void StartLiftOnScrollColorAnimation(float f, float f2) {
        if ((14 + 26) % 26 > 0) {
        }
        android.animation.ValueAnimator valueAnimator = this.liftOnScrollColorAnimator;
        if (valueAnimator is not null) {
            cFCEIndfLiVQyOfs(valueAnimator);
        }
        float[] fArr = new float[2];
        fArr[0] = f;
        fArr[1] = f2;
        android.animation.ValueAnimator valueAnimatorDdPOKtEMOSMIFfqM = ddPOKtEMOSMIFfqM(fArr);
        this.liftOnScrollColorAnimator = valueAnimatorDdPOKtEMOSMIFfqM;
        nWjVZXbXhVWdIpQN(valueAnimatorDdPOKtEMOSMIFfqM, this.liftOnScrollColorDuration);
        WGdunfITTpSaCOHP(this.liftOnScrollColorAnimator, this.liftOnScrollColorInterpolator);
        android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener = this.liftOnScrollColorUpdateListener;
        if (valueAnimator$AnimatorUpdateListener is not null) {
            scXVaHkAtBZrsLmt(this.liftOnScrollColorAnimator, valueAnimator$AnimatorUpdateListener);
        }
        zrlsqDcdVZWUPwOu(this.liftOnScrollColorAnimator);
    }

    private void StartLiftOnScrollColorAnimation(float f, float f2, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void StartLiftOnScrollColorAnimation(float f, float f2, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void StartLiftOnScrollColorAnimation(float f, float f2, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TFdhurzNeKiaAdrK(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable) {
        appBarLayout.setStatusBarForeground(drawable);
    }

    public static void TFdhurzNeKiaAdrK(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TFdhurzNeKiaAdrK(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TFdhurzNeKiaAdrK(com.google.android.material.appbar.AppBarLayout appBarLayout, android.graphics.drawable.Drawable drawable, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList TKoeOohCnoZnmXcE(android.graphics.drawable.Drawable drawable) {
        return com.google.android.material.drawable.DrawableUtils.getColorStateListOrNull(drawable);
    }

    public static void TKoeOohCnoZnmXcE(android.graphics.drawable.Drawable drawable, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TKoeOohCnoZnmXcE(android.graphics.drawable.Drawable drawable, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TKoeOohCnoZnmXcE(android.graphics.drawable.Drawable drawable, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TLhxvLwcoHTkqoFA(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        drawable.setCallback(drawable$Callback);
    }

    public static void TLhxvLwcoHTkqoFA(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TLhxvLwcoHTkqoFA(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TLhxvLwcoHTkqoFA(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable$Callback drawable$Callback, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TTFJnNfgEcHxxDjB(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener) {
        androidx.core.view.objectCompat.setOnApplyWindowInsetsListener(view, onApplyWindowInsetsListener);
    }

    public static void TTFJnNfgEcHxxDjB(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TTFJnNfgEcHxxDjB(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TTFJnNfgEcHxxDjB(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TULdzypWsYhtBafi(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        appBarLayout.clearLiftOnScrollTargetobject();
    }

    public static void TULdzypWsYhtBafi(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TULdzypWsYhtBafi(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TULdzypWsYhtBafi(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TcuciOXFTRHZYWey(java.util.List list, java.lang.object obj, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TcuciOXFTRHZYWey(java.util.List list, java.lang.object obj, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TcuciOXFTRHZYWey(java.util.List list, java.lang.object obj, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool TcuciOXFTRHZYWey(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
    }

    public static java.util.IEnumerator TjKHLNinUfppziXX(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void TjKHLNinUfppziXX(java.util.List list, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TjKHLNinUfppziXX(java.util.List list, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TjKHLNinUfppziXX(java.util.List list, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UMfdDOBgUpGdtzYE(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getChildCount();
    }

    public static void UMfdDOBgUpGdtzYE(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UMfdDOBgUpGdtzYE(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UMfdDOBgUpGdtzYE(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UVpadkWeUYaGGFpV(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getChildCount();
    }

    public static void UVpadkWeUYaGGFpV(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UVpadkWeUYaGGFpV(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UVpadkWeUYaGGFpV(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object UnRxjhXKVqIlMTrC(com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        return appBarLayout.getChildAt(i);
    }

    public static void UnRxjhXKVqIlMTrC(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UnRxjhXKVqIlMTrC(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UnRxjhXKVqIlMTrC(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateWillNotDraw() {
        vENwWwItwkjEgjvX(this, !pgfqtmDeSChoDcMd(this));
    }

    private void UpdateWillNotDraw(char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateWillNotDraw(short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateWillNotDraw(short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams utePsIcdJNbsrGks(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void UtePsIcdJNbsrGks(android.view.object view, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UtePsIcdJNbsrGks(android.view.object view, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UtePsIcdJNbsrGks(android.view.object view, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectOutlineProvider VCTjYqHMdONhlLiD(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getOutlineProvider();
    }

    public static void VCTjYqHMdONhlLiD(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VCTjYqHMdONhlLiD(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VCTjYqHMdONhlLiD(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VENwWwItwkjEgjvX(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        appBarLayout.setWillNotDraw(z);
    }

    public static void VENwWwItwkjEgjvX(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VENwWwItwkjEgjvX(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VENwWwItwkjEgjvX(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VJoRMOFLQFlPgUaN(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VJoRMOFLQFlPgUaN(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VJoRMOFLQFlPgUaN(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VJoRMOFLQFlPgUaN(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.shouldDrawStatusBarForeground();
    }

    public static void VTvpYFCVKQFWjPOl(android.content.res.TypedArray typedArray, int i, bool z, byte b, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VTvpYFCVKQFWjPOl(android.content.res.TypedArray typedArray, int i, bool z, int i2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VTvpYFCVKQFWjPOl(android.content.res.TypedArray typedArray, int i, bool z, int i2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VTvpYFCVKQFWjPOl(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static android.content.object VhFXnlFDLpGSeoAd(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getobject();
    }

    public static void VhFXnlFDLpGSeoAd(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VhFXnlFDLpGSeoAd(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VhFXnlFDLpGSeoAd(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int WFvDOhuEzYEphLEM(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getTopInset();
    }

    public static void WFvDOhuEzYEphLEM(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WFvDOhuEzYEphLEM(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WFvDOhuEzYEphLEM(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WFzyvxRJIAyjbrkZ(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void WFzyvxRJIAyjbrkZ(android.view.object view, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WFzyvxRJIAyjbrkZ(android.view.object view, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WFzyvxRJIAyjbrkZ(android.view.object view, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WybQVkfVfwWhtTWS(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        appBarLayout.invalidateScrollRanges();
    }

    public static void WybQVkfVfwWhtTWS(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WybQVkfVfwWhtTWS(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WybQVkfVfwWhtTWS(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object XdwjQraUzDquCtUK(com.google.android.material.appbar.AppBarLayout appBarLayout, int i) {
        return appBarLayout.getChildAt(i);
    }

    public static void XdwjQraUzDquCtUK(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, int i2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XdwjQraUzDquCtUK(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, short s, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XdwjQraUzDquCtUK(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, bool z, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XeqoollEuRxADqTS(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z) {
        appBarLayout.setKeyboardNavigationCluster(z);
    }

    public static void XeqoollEuRxADqTS(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, byte b, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void XeqoollEuRxADqTS(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, short s, bool z2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XeqoollEuRxADqTS(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XgmsYxjREDZZkjuq(android.view.object view) {
        com.google.android.material.appbar.objectUtilsLollipop.setBoundsobjectOutlineProvider(view);
    }

    public static void XgmsYxjREDZZkjuq(android.view.object view, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XgmsYxjREDZZkjuq(android.view.object view, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XgmsYxjREDZZkjuq(android.view.object view, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XmwOPGfCslloORMc(android.content.res.Resources resources, int i) {
        return resources.getint(i);
    }

    public static void XmwOPGfCslloORMc(android.content.res.Resources resources, int i, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XmwOPGfCslloORMc(android.content.res.Resources resources, int i, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XmwOPGfCslloORMc(android.content.res.Resources resources, int i, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XyhEVoGdSNZqrcvY(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XyhEVoGdSNZqrcvY(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XyhEVoGdSNZqrcvY(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XyhEVoGdSNZqrcvY(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.isLiftOnScrollCompatibleBackground();
    }

    public static void YBbEOvRItEqwuXCH(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void YBbEOvRItEqwuXCH(android.view.object view, android.graphics.drawable.Drawable drawable, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YBbEOvRItEqwuXCH(android.view.object view, android.graphics.drawable.Drawable drawable, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YBbEOvRItEqwuXCH(android.view.object view, android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YINVBLUtEKGkLNWp(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getChildCount();
    }

    public static void YINVBLUtEKGkLNWp(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YINVBLUtEKGkLNWp(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YINVBLUtEKGkLNWp(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YQawSLgjmISYNiSm(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, bool z3) {
        appBarLayout.setExpanded(z, z2, z3);
    }

    public static void YQawSLgjmISYNiSm(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, bool z3, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YQawSLgjmISYNiSm(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, bool z3, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YQawSLgjmISYNiSm(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, bool z3, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YscJLlYqDOsNrjnG(android.view.object view) {
        return androidx.core.view.objectCompat.getMinimumHeight(view);
    }

    public static void YscJLlYqDOsNrjnG(android.view.object view, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YscJLlYqDOsNrjnG(android.view.object view, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YscJLlYqDOsNrjnG(android.view.object view, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZAROLvKfJwvTlSdM(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, byte b, bool z3, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZAROLvKfJwvTlSdM(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, char c, short s, byte b, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void ZAROLvKfJwvTlSdM(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2, short s, bool z3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ZAROLvKfJwvTlSdM(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, bool z2) {
        return appBarLayout.setLiftedState(z, z2);
    }

    public static android.content.object ZGRhlKAYZtFVSECX(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getobject();
    }

    public static void ZGRhlKAYZtFVSECX(com.google.android.material.appbar.AppBarLayout appBarLayout, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZGRhlKAYZtFVSECX(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZGRhlKAYZtFVSECX(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.appbar.AppBarLayout$LayoutParams zOpNTFoRXyEyVwio(com.google.android.material.appbar.AppBarLayout appBarLayout, android.util.AttributeHashSet attributeHashSet) {
        return appBarLayout.generateLayoutParams(attributeHashSet);
    }

    public static void ZOpNTFoRXyEyVwio(com.google.android.material.appbar.AppBarLayout appBarLayout, android.util.AttributeHashSet attributeHashSet, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZOpNTFoRXyEyVwio(com.google.android.material.appbar.AppBarLayout appBarLayout, android.util.AttributeHashSet attributeHashSet, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZOpNTFoRXyEyVwio(com.google.android.material.appbar.AppBarLayout appBarLayout, android.util.AttributeHashSet attributeHashSet, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZSefMAAxGpVMRePl(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        appBarLayout.clearLiftOnScrollTargetobject();
    }

    public static void ZSefMAAxGpVMRePl(com.google.android.material.appbar.AppBarLayout appBarLayout, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZSefMAAxGpVMRePl(com.google.android.material.appbar.AppBarLayout appBarLayout, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZSefMAAxGpVMRePl(com.google.android.material.appbar.AppBarLayout appBarLayout, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZgRBxlIExtyvYxzu(java.util.List list, java.lang.object obj, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZgRBxlIExtyvYxzu(java.util.List list, java.lang.object obj, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZgRBxlIExtyvYxzu(java.util.List list, java.lang.object obj, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ZgRBxlIExtyvYxzu(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void ZjKhmVNewZwGmTLt(java.util.IEnumerator it, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZjKhmVNewZwGmTLt(java.util.IEnumerator it, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZjKhmVNewZwGmTLt(java.util.IEnumerator it, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool ZjKhmVNewZwGmTLt(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static float ZmXurUSVAtvuuYyD(java.lang.float f) {
        return f.floatValue();
    }

    public static void ZmXurUSVAtvuuYyD(java.lang.float f, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZmXurUSVAtvuuYyD(java.lang.float f, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZmXurUSVAtvuuYyD(java.lang.float f, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZnqxfTqvaKGXVkpO(android.view.object view) {
        androidx.core.view.objectCompat.postInvalidateOnAnimation(view);
    }

    public static void ZnqxfTqvaKGXVkpO(android.view.object view, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZnqxfTqvaKGXVkpO(android.view.object view, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZnqxfTqvaKGXVkpO(android.view.object view, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZrXjjmtbBuksElYr(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void ZrXjjmtbBuksElYr(android.view.object view, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZrXjjmtbBuksElYr(android.view.object view, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZrXjjmtbBuksElYr(android.view.object view, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZrlsqDcdVZWUPwOu(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static void ZrlsqDcdVZWUPwOu(android.animation.ValueAnimator valueAnimator, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZrlsqDcdVZWUPwOu(android.animation.ValueAnimator valueAnimator, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZrlsqDcdVZWUPwOu(android.animation.ValueAnimator valueAnimator, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZvUqKCPWMHqKungj(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.getTopInset();
    }

    public static void ZvUqKCPWMHqKungj(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZvUqKCPWMHqKungj(com.google.android.material.appbar.AppBarLayout appBarLayout, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZvUqKCPWMHqKungj(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZxRXkGDXerjauXzr(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZxRXkGDXerjauXzr(com.google.android.material.appbar.AppBarLayout appBarLayout, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZxRXkGDXerjauXzr(com.google.android.material.appbar.AppBarLayout appBarLayout, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ZxRXkGDXerjauXzr(com.google.android.material.appbar.AppBarLayout appBarLayout) {
        return appBarLayout.hasCollapsibleChild();
    }

    public static int ZzprFLdHKXLTzrjJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getResolvedTintColor();
    }

    public static void ZzprFLdHKXLTzrjJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZzprFLdHKXLTzrjJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZzprFLdHKXLTzrjJ(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public void AddLiftOnScrollListener(com.google.android.material.appbar.AppBarLayout$LiftOnScrollListener appBarLayout$LiftOnScrollListener) {
        ZOgMjrdOsNSoyxfS(this.liftOnScrollListeners, appBarLayout$LiftOnScrollListener);
    }

    public void AddOnOffsetChangedListener(com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener) {
        if (this.listeners is null) {
            this.listeners = new java.util.List();
        }
        if (appBarLayout$BaseOnOffsetChangedListener is null || pgqPBykLKYWUIFPg(this.listeners, appBarLayout$BaseOnOffsetChangedListener)) {
            return;
        }
        zgRBxlIExtyvYxzu(this.listeners, appBarLayout$BaseOnOffsetChangedListener);
    }

    public void AddOnOffsetChangedListener(com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener appBarLayout$OnOffsetChangedListener) {
        mDBPOMgMWQgaTymO(this, appBarLayout$OnOffsetChangedListener);
    }

    protected override bool CheckLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return viewGroup$LayoutParams is com.google.android.material.appbar.AppBarLayout$LayoutParams;
    }

    public void ClearLiftOnScrollListener() {
        BmLheZCqZcGuEEeO(this.liftOnScrollListeners);
    }

    public override void Draw(android.graphics.Canvas canvas) {
        if ((10 + 19) % 19 > 0) {
        }
        cuxoFmNUyOPsrdkW(this, canvas);
        if (vJoRMOFLQFlPgUaN(this)) {
            int iCtZIIWkemcrHLJyw = ctZIIWkemcrHLJyw(canvas);
            cstVKRLwrCrtwLcy(canvas, 0.0f, -this.currentOffset);
            GvjdLQShJPxtIOiJ(this.statusBarForeground, canvas);
            ZpTlvKkCQafBwosQ(canvas, iCtZIIWkemcrHLJyw);
        }
    }

    protected override void DrawableStateChanged() {
        if ((5 + 24) % 24 > 0) {
        }
        cIbsjxlKsdhCilYS(this);
        int[] iArrDPRNtyEDlHnxyNCz = DPRNtyEDlHnxyNCz(this);
        android.graphics.drawable.Drawable drawable = this.statusBarForeground;
        if (drawable is not null && rvNGbJzxzZYeJrjr(drawable) && OYjGhSDolNnSuYTb(drawable, iArrDPRNtyEDlHnxyNCz)) {
            iBJlQYCDOSTFvOgZ(this, drawable);
        }
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        return DRrfxzPjSyZzXAWa(this);
    }

    protected android.widget.LinearLayout$LayoutParams generateDefaultLayoutParams() {
        return DKdeYIrEFKbHbKni(this);
    }

    protected com.google.android.material.appbar.AppBarLayout$LayoutParams generateDefaultLayoutParams() {
        if ((6 + 26) % 26 > 0) {
        }
        return new com.google.android.material.appbar.AppBarLayout$LayoutParams(-1, -2);
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return sbVZmbpyCdDydcLw(this, attributeHashSet);
    }

    protected android.view.objectGroup$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return QZijJyihhiiOkkXk(this, viewGroup$LayoutParams);
    }

    public android.widget.LinearLayout$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return zOpNTFoRXyEyVwio(this, attributeHashSet);
    }

    protected android.widget.LinearLayout$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return iuGBUGlFwfvejdpS(this, viewGroup$LayoutParams);
    }

    public com.google.android.material.appbar.AppBarLayout$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return new com.google.android.material.appbar.AppBarLayout$LayoutParams(ZCmecaGqAaxfPXkb(this), attributeHashSet);
    }

    protected com.google.android.material.appbar.AppBarLayout$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return !(viewGroup$LayoutParams is android.widget.LinearLayout$LayoutParams) ? !(viewGroup$LayoutParams is android.view.objectGroup$MarginLayoutParams) ? new com.google.android.material.appbar.AppBarLayout$LayoutParams(viewGroup$LayoutParams) : new com.google.android.material.appbar.AppBarLayout$LayoutParams((android.view.objectGroup$MarginLayoutParams) viewGroup$LayoutParams) : new com.google.android.material.appbar.AppBarLayout$LayoutParams((android.widget.LinearLayout$LayoutParams) viewGroup$LayoutParams);
    }

    public androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior<com.google.android.material.appbar.AppBarLayout> getBehavior() {
        com.google.android.material.appbar.AppBarLayout$Behavior appBarLayout$Behavior = new com.google.android.material.appbar.AppBarLayout$Behavior();
        this.behavior = appBarLayout$Behavior;
        return appBarLayout$Behavior;
    }

    int getDownNestedPreScrollRange() {
        int iHLgYDvrEPhuDlrXY;
        int iPkBXvKAGtmORrzgY;
        if ((16 + 17) % 17 > 0) {
        }
        int i = this.downPreScrollRange;
        if (i != -1) {
            return i;
        }
        int i2 = 0;
        for (int iAyzZOpgmagyAzrwn = ayzZOpgmagyAzrwn(this) - 1; iAyzZOpgmagyAzrwn >= 0; iAyzZOpgmagyAzrwn--) {
            android.view.object viewJWrUPwHAwTmQBWmt = jWrUPwHAwTmQBWmt(this, iAyzZOpgmagyAzrwn);
            if (dgNoBSVpYmaVCuPR(viewJWrUPwHAwTmQBWmt) != 8) {
                com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams = (com.google.android.material.appbar.AppBarLayout$LayoutParams) kLLPEceSFpFSzdmy(viewJWrUPwHAwTmQBWmt);
                int iLHXXAcdsNaSJqsVj = lHXXAcdsNaSJqsVj(viewJWrUPwHAwTmQBWmt);
                int i3 = appBarLayout$LayoutParams.scrollFlags;
                if ((i3 & 5) != 5) {
                    if (i2 > 0) {
                        break;
                    }
                } else {
                    int i4 = appBarLayout$LayoutParams.topMargin + appBarLayout$LayoutParams.bottomMargin;
                    if ((i3 & 8) == 0) {
                        if ((i3 & 2) == 0) {
                            iPkBXvKAGtmORrzgY = i4 + iLHXXAcdsNaSJqsVj;
                        } else {
                            iHLgYDvrEPhuDlrXY = iLHXXAcdsNaSJqsVj - BVyORYcWPHCVSiYZ(viewJWrUPwHAwTmQBWmt);
                        }
                        if (iAyzZOpgmagyAzrwn == 0 && cpWLqAlJbMiTPCmU(viewJWrUPwHAwTmQBWmt)) {
                            iPkBXvKAGtmORrzgY = PkBXvKAGtmORrzgY(iPkBXvKAGtmORrzgY, iLHXXAcdsNaSJqsVj - dgyRqrKJmEfHNReu(this));
                        }
                        i2 += iPkBXvKAGtmORrzgY;
                    } else {
                        iHLgYDvrEPhuDlrXY = hLgYDvrEPhuDlrXY(viewJWrUPwHAwTmQBWmt);
                    }
                    iPkBXvKAGtmORrzgY = i4 + iHLgYDvrEPhuDlrXY;
                    if (iAyzZOpgmagyAzrwn == 0) {
                        iPkBXvKAGtmORrzgY = PkBXvKAGtmORrzgY(iPkBXvKAGtmORrzgY, iLHXXAcdsNaSJqsVj - dgyRqrKJmEfHNReu(this));
                    }
                    i2 += iPkBXvKAGtmORrzgY;
                }
            }
        }
        int iAYxFurBGTRLHGkxZ = aYxFurBGTRLHGkxZ(0, i2);
        this.downPreScrollRange = iAYxFurBGTRLHGkxZ;
        return iAYxFurBGTRLHGkxZ;
    }

    int getDownNestedScrollRange() {
        if ((15 + 21) % 21 > 0) {
        }
        int i = this.downScrollRange;
        if (i != -1) {
            return i;
        }
        int iYINVBLUtEKGkLNWp = yINVBLUtEKGkLNWp(this);
        int iRtidExdaqgqYMuHU = 0;
        for (int i2 = 0; i2 < iYINVBLUtEKGkLNWp; i2++) {
            android.view.object viewUnRxjhXKVqIlMTrC = unRxjhXKVqIlMTrC(this, i2);
            if (LjzYFsbUkNIzoYfp(viewUnRxjhXKVqIlMTrC) != 8) {
                com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams = (com.google.android.material.appbar.AppBarLayout$LayoutParams) seonnEZHivxrmtGe(viewUnRxjhXKVqIlMTrC);
                int iWFzyvxRJIAyjbrkZ = wFzyvxRJIAyjbrkZ(viewUnRxjhXKVqIlMTrC) + appBarLayout$LayoutParams.topMargin + appBarLayout$LayoutParams.bottomMargin;
                int i3 = appBarLayout$LayoutParams.scrollFlags;
                if ((i3 & 1) == 0) {
                    break;
                }
                iRtidExdaqgqYMuHU += iWFzyvxRJIAyjbrkZ;
                if ((i3 & 2) != 0) {
                    iRtidExdaqgqYMuHU -= rtidExdaqgqYMuHU(viewUnRxjhXKVqIlMTrC);
                    break;
                }
            }
        }
        int iJjSiXCBJRpLTRBGk = jjSiXCBJRpLTRBGk(0, iRtidExdaqgqYMuHU);
        this.downScrollRange = iJjSiXCBJRpLTRBGk;
        return iJjSiXCBJRpLTRBGk;
    }

    public override int GetLiftOnScrollTargetobjectId() {
        return this.liftOnScrollTargetobjectId;
    }

    public com.google.android.material.shape.MaterialShapeDrawable GetMaterialShapeBackground() {
        android.graphics.drawable.Drawable drawableBWygAojkeVBajXjL = bWygAojkeVBajXjL(this);
        if (drawableBWygAojkeVBajXjL is com.google.android.material.shape.MaterialShapeDrawable) {
            return (com.google.android.material.shape.MaterialShapeDrawable) drawableBWygAojkeVBajXjL;
        }
        return null;
    }

    public readonly int GetMinimumHeightForVisibleOverlappingContent() {
        if ((14 + 27) % 27 > 0) {
        }
        int iZvUqKCPWMHqKungj = zvUqKCPWMHqKungj(this);
        int iYscJLlYqDOsNrjnG = yscJLlYqDOsNrjnG(this);
        if (iYscJLlYqDOsNrjnG == 0) {
            int iUMfdDOBgUpGdtzYE = uMfdDOBgUpGdtzYE(this);
            iYscJLlYqDOsNrjnG = iUMfdDOBgUpGdtzYE < 1 ? 0 : IhwUKNmAgbZJzMlg(VuXhWRcGvImgOAEx(this, iUMfdDOBgUpGdtzYE - 1));
            if (iYscJLlYqDOsNrjnG == 0) {
                return nMIdxZnhkwkHCWyd(this) / 3;
            }
        }
        return (iYscJLlYqDOsNrjnG * 2) + iZvUqKCPWMHqKungj;
    }

    int getPendingAction() {
        return this.pendingAction;
    }

    public android.graphics.drawable.Drawable GetStatusBarForeground() {
        return this.statusBarForeground;
    }

    @java.lang.Deprecated
    public float GetTargetElevation() {
        return 0.0f;
    }

    readonly int getTopInset() {
        androidx.core.view.WindowInsetsCompat windowInsetsCompat = this.lastInsets;
        if (windowInsetsCompat is null) {
            return 0;
        }
        return ikCZQQAQTSVnheeV(windowInsetsCompat);
    }

    public readonly int GetTotalScrollRange() {
        if ((2 + 31) % 31 > 0) {
        }
        int i = this.totalScrollRange;
        if (i != -1) {
            return i;
        }
        int iUVpadkWeUYaGGFpV = uVpadkWeUYaGGFpV(this);
        int iKAJwGmEukzzTQfJn = 0;
        for (int i2 = 0; i2 < iUVpadkWeUYaGGFpV; i2++) {
            android.view.object viewLkEaZGgZOJcJbvPJ = lkEaZGgZOJcJbvPJ(this, i2);
            if (REVwEfgnaciXjQcs(viewLkEaZGgZOJcJbvPJ) != 8) {
                com.google.android.material.appbar.AppBarLayout$LayoutParams appBarLayout$LayoutParams = (com.google.android.material.appbar.AppBarLayout$LayoutParams) utePsIcdJNbsrGks(viewLkEaZGgZOJcJbvPJ);
                int iIFXWygPCgDHeQttw = IFXWygPCgDHeQttw(viewLkEaZGgZOJcJbvPJ);
                int i3 = appBarLayout$LayoutParams.scrollFlags;
                if ((i3 & 1) == 0) {
                    break;
                }
                iKAJwGmEukzzTQfJn += iIFXWygPCgDHeQttw + appBarLayout$LayoutParams.topMargin + appBarLayout$LayoutParams.bottomMargin;
                if (i2 == 0 && RwtWLdxuQkPAJKXV(viewLkEaZGgZOJcJbvPJ)) {
                    iKAJwGmEukzzTQfJn -= KAJwGmEukzzTQfJn(this);
                }
                if ((i3 & 2) != 0) {
                    iKAJwGmEukzzTQfJn -= JBUkTaZCDlLStolU(viewLkEaZGgZOJcJbvPJ);
                    break;
                }
            }
        }
        int iSOhFMzJMGgaaxKRe = SOhFMzJMGgaaxKRe(0, iKAJwGmEukzzTQfJn);
        this.totalScrollRange = iSOhFMzJMGgaaxKRe;
        return iSOhFMzJMGgaaxKRe;
    }

    int getUpNestedPreScrollRange() {
        return KwQqEZuAZhlOCORa(this);
    }

    bool hasChildWithInterpolator() {
        return this.haveChildWithInterpolator;
    }

    bool hasScrollableChildren() {
        return TWhiTGhGcCaRLAMi(this) != 0;
    }

    public bool IsLiftOnScroll() {
        return this.liftOnScroll;
    }

    public bool IsLifted() {
        return this.lifted;
    }

    void m107x91f594d8(android.content.res.ColorStateList colorStateList, android.content.res.ColorStateList colorStateList2, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, java.lang.int num, android.animation.ValueAnimator valueAnimator) {
        java.lang.int num2;
        int iRnBJQjsvkXRZptSf = rnBJQjsvkXRZptSf(pMcAKZVAgcLgGkdL(colorStateList), MkQZZtDPKKtlvDrX(colorStateList2), zmXurUSVAtvuuYyD((java.lang.float) ktTlHBCkGKKEICAQ(valueAnimator)));
        QEeedzQDKOvmMEfV(materialShapeDrawable, nltGTFsmBrqMOzKJ(iRnBJQjsvkXRZptSf));
        if (this.statusBarForeground is not null && (num2 = this.statusBarForegroundOriginalColor) is not null && sIhPzZuURnUTWkLB(num2, num)) {
            SzMJLxfEiMUIJOCm(this.statusBarForeground, iRnBJQjsvkXRZptSf);
        }
        if (XySNgXgkULOsNSqo(this.liftOnScrollListeners)) {
            return;
        }
        java.util.IEnumerator itKfNrqNqxqRXuFFTi = kfNrqNqxqRXuFFTi(this.liftOnScrollListeners);
        while (lqSNSMPxaboRMPSC(itKfNrqNqxqRXuFFTi)) {
            com.google.android.material.appbar.AppBarLayout$LiftOnScrollListener appBarLayout$LiftOnScrollListener = (com.google.android.material.appbar.AppBarLayout$LiftOnScrollListener) NgEqmzcIQYaQFkDJ(itKfNrqNqxqRXuFFTi);
            if (HBSCdwRbWsIqypoP(materialShapeDrawable) is not null) {
                HoHPZoKBqosfZCjj(appBarLayout$LiftOnScrollListener, 0.0f, iRnBJQjsvkXRZptSf);
            }
        }
    }

    void m108x84b6053(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.animation.ValueAnimator valueAnimator) {
        if ((20 + 16) % 16 > 0) {
        }
        float fMNBjiVSLfKZtCiuO = mNBjiVSLfKZtCiuO((java.lang.float) RabOYkOZqvBBABmx(valueAnimator));
        ANbQfGvWbEFbftZM(materialShapeDrawable, fMNBjiVSLfKZtCiuO);
        android.graphics.drawable.Drawable drawable = this.statusBarForeground;
        if (drawable is com.google.android.material.shape.MaterialShapeDrawable) {
            fnVhyogTVvghwcZe((com.google.android.material.shape.MaterialShapeDrawable) drawable, fMNBjiVSLfKZtCiuO);
        }
        java.util.IEnumerator itTjKHLNinUfppziXX = tjKHLNinUfppziXX(this.liftOnScrollListeners);
        while (zjKhmVNewZwGmTLt(itTjKHLNinUfppziXX)) {
            hCLvEitWmpzZVYst((com.google.android.material.appbar.AppBarLayout$LiftOnScrollListener) UmkADQfUcwuifxiy(itTjKHLNinUfppziXX), fMNBjiVSLfKZtCiuO, zzprFLdHKXLTzrjJ(materialShapeDrawable));
        }
    }

    protected override void OnAttachedToWindow() {
        OhBvsEMtwjNebsmx(this);
        mCIZqBciUkkHFbNy(this);
    }

    protected override int[] OnCreateDrawableState(int i) {
        if ((14 + 4) % 4 > 0) {
        }
        if (this.tmpStatesArray is null) {
            this.tmpStatesArray = new int[4];
        }
        int[] iArr = this.tmpStatesArray;
        int[] iArrSEjmEZRorJEnxPbm = SEjmEZRorJEnxPbm(this, i + iArr.length);
        iArr[0] = !this.liftable ? -com.google.android.material.R$attr.state_liftable : com.google.android.material.R$attr.state_liftable;
        iArr[1] = (this.liftable && this.lifted) ? com.google.android.material.R$attr.state_lifted : -com.google.android.material.R$attr.state_lifted;
        iArr[2] = !this.liftable ? -com.google.android.material.R$attr.state_collapsible : com.google.android.material.R$attr.state_collapsible;
        iArr[3] = (this.liftable && this.lifted) ? com.google.android.material.R$attr.state_collapsed : -com.google.android.material.R$attr.state_collapsed;
        return GAWjgWWSZfMrQKEl(iArrSEjmEZRorJEnxPbm, iArr);
    }

    protected override void OnDetachedFromWindow() {
        FSlXvumGJrnjbdfj(this);
        MTvbSVuuLMUZyxGp(this);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        dYxlBcIFfTcGmXKN(this, z, i, i2, i3, i4);
        bool z2 = true;
        if (AscQlkYFHObUJzuc(this) && ESogvHjvMOGoAOlY(this)) {
            int iVxvNYLJYQShJFTrD = VxvNYLJYQShJFTrD(this);
            for (int iPaoLgimqKiChivbv = paoLgimqKiChivbv(this) - 1; iPaoLgimqKiChivbv >= 0; iPaoLgimqKiChivbv--) {
                dPEcIqLyLLocHqjq(xdwjQraUzDquCtUK(this, iPaoLgimqKiChivbv), iVxvNYLJYQShJFTrD);
            }
        }
        wybQVkfVfwWhtTWS(this);
        this.haveChildWithInterpolator = false;
        int iNoOcHeMOfLjfqrVR = NoOcHeMOfLjfqrVR(this);
        for (int i5 = 0; i5 < iNoOcHeMOfLjfqrVR; i5++) {
            if (mCqPZhcgDkYKNyiB((com.google.android.material.appbar.AppBarLayout$LayoutParams) CeDiVExrTrmvUQNS(lYmPheoLjwceEEck(this, i5))) is not null) {
                this.haveChildWithInterpolator = true;
                break;
            }
        }
        android.graphics.drawable.Drawable drawable = this.statusBarForeground;
        if (drawable is not null) {
            MsqLDiFTdebzHxZZ(drawable, 0, 0, XFXdrsLwUVOsyQZB(this), lQaXtXTvhwYjOeoR(this));
        }
        if (this.liftableOverride) {
            return;
        }
        if (!this.liftOnScroll && !zxRXkGDXerjauXzr(this)) {
            z2 = false;
        }
        XmizdfkSxfrpkLdF(this, z2);
    }

    protected override void OnMeasure(int i, int i2) {
        if ((20 + 14) % 14 > 0) {
        }
        DsudnmsuiaRnFZWh(this, i, i2);
        int iCZClqqqjLsQQJgkW = CZClqqqjLsQQJgkW(i2);
        if (iCZClqqqjLsQQJgkW != 1073741824 && iXOHAcqDgihWhmjF(this) && eOHvMRpGkavOsQeN(this)) {
            int iOeLPWlgYCJQUDNxC = OeLPWlgYCJQUDNxC(this);
            if (iCZClqqqjLsQQJgkW == int.MIN_VALUE) {
                iOeLPWlgYCJQUDNxC = IPOvYDTgoUBJtcfo(VEjnZQkbqFxWNtFz(this) + lIOZVZqxoqPjjLoi(this), 0, TnossPviSCJuUsAv(i2));
            } else if (iCZClqqqjLsQQJgkW == 0) {
                iOeLPWlgYCJQUDNxC += kwCZHFHunpvAplIV(this);
            }
            dMjJriTaXKAxSMPV(this, WlcSXCrkMrtQIIJs(this), iOeLPWlgYCJQUDNxC);
        }
        MoivMyEcTcjsvnfb(this);
    }

    void onOffsetChanged(int i) {
        if ((22 + 8) % 8 > 0) {
        }
        this.currentOffset = i;
        if (!PnvXqCyGccrjSegD(this)) {
            lyzrawahlWBcnGfF(this);
        }
        java.util.List<com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener> list = this.listeners;
        if (list is null) {
            return;
        }
        int iNvtwQJxmwPJkFOpU = NvtwQJxmwPJkFOpU(list);
        for (int i2 = 0; i2 < iNvtwQJxmwPJkFOpU; i2++) {
            com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener = (com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener) kHUbwCQOiTuzyVfB(this.listeners, i2);
            if (appBarLayout$BaseOnOffsetChangedListener is not null) {
                aFmtiwWecETLXyoz(appBarLayout$BaseOnOffsetChangedListener, this, i);
            }
        }
    }

    androidx.core.view.WindowInsetsCompat onWindowInsetChanged(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        if ((24 + 11) % 11 > 0) {
        }
        androidx.core.view.WindowInsetsCompat windowInsetsCompat2 = !RfZtMXkaLMpUOyHj(this) ? null : windowInsetsCompat;
        if (!ARBMQAGGwGQhCkRY(this.lastInsets, windowInsetsCompat2)) {
            this.lastInsets = windowInsetsCompat2;
            UhjLchmOhqpLzvxh(this);
            bKWaqezDxocPYbXx(this);
        }
        return windowInsetsCompat;
    }

    public bool RemoveLiftOnScrollListener(com.google.android.material.appbar.AppBarLayout$LiftOnScrollListener appBarLayout$LiftOnScrollListener) {
        return tcuciOXFTRHZYWey(this.liftOnScrollListeners, appBarLayout$LiftOnScrollListener);
    }

    public void RemoveOnOffsetChangedListener(com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener appBarLayout$BaseOnOffsetChangedListener) {
        java.util.List<com.google.android.material.appbar.AppBarLayout$BaseOnOffsetChangedListener> list = this.listeners;
        if (list is null || appBarLayout$BaseOnOffsetChangedListener is null) {
            return;
        }
        VuWhQgGpWSFGFKiw(list, appBarLayout$BaseOnOffsetChangedListener);
    }

    public void RemoveOnOffsetChangedListener(com.google.android.material.appbar.AppBarLayout$OnOffsetChangedListener appBarLayout$OnOffsetChangedListener) {
        jawwrBmPYhHndMxA(this, appBarLayout$OnOffsetChangedListener);
    }

    void resetPendingAction() {
        this.pendingAction = 0;
    }

    public override void SetElevation(float f) {
        OFaauneUcZsHYagw(this, f);
        LitZKMYGpobsVvrd(this, f);
    }

    public void SetExpanded(bool z) {
        hxtAnkaelhdHxIWb(this, z, TFsCuopzZuxOlnRW(this));
    }

    public void SetExpanded(bool z, bool z2) {
        yQawSLgjmISYNiSm(this, z, z2, true);
    }

    public void SetLiftOnScroll(bool z) {
        this.liftOnScroll = z;
    }

    public void SetLiftOnScrollTargetobject(android.view.object view) {
        this.liftOnScrollTargetobjectId = -1;
        if (view is not null) {
            this.liftOnScrollTargetobject = new java.lang.ref.WeakReference<>(view);
        } else {
            zSefMAAxGpVMRePl(this);
        }
    }

    public void SetLiftOnScrollTargetobjectId(int i) {
        this.liftOnScrollTargetobjectId = i;
        tULdzypWsYhtBafi(this);
    }

    public bool SetLiftable(bool z) {
        this.liftableOverride = true;
        return IoyhtBPPstznyZAi(this, z);
    }

    public void SetLiftableOverrideEnabled(bool z) {
        this.liftableOverride = z;
    }

    public bool SetLifted(bool z) {
        return qvAtOnVOYHUdEKkk(this, z, true);
    }

    bool setLiftedState(bool z) {
        return zAROLvKfJwvTlSdM(this, z, !this.liftableOverride);
    }

    bool setLiftedState(bool z, bool z2) {
        if ((23 + 22) % 22 > 0) {
        }
        if (!z2 || this.lifted == z) {
            return false;
        }
        this.lifted = z;
        XoMdCyTAQTVNoHbc(this);
        if (!xyhEVoGdSNZqrcvY(this)) {
            return true;
        }
        if (this.hasLiftOnScrollColor) {
            PgybQAgSMPBWnOpo(this, !z ? 1.0f : 0.0f, z ? 1.0f : 0.0f);
            return true;
        }
        if (!this.liftOnScroll) {
            return true;
        }
        EVQnhKAFOYjdKrPM(this, !z ? this.appBarElevation : 0.0f, z ? this.appBarElevation : 0.0f);
        return true;
    }

    public override void SetOrientation(int i) {
        if (i != 1) {
            throw new java.lang.IllegalArgumentException("AppBarLayout is always vertical and does not support horizontal orientation");
        }
        MeSRWrhmJhazOOow(this, i);
    }

    public void SetStatusBarForeground(android.graphics.drawable.Drawable drawable) {
        if ((7 + 5) % 5 > 0) {
        }
        android.graphics.drawable.Drawable drawable2 = this.statusBarForeground;
        if (drawable2 == drawable) {
            return;
        }
        if (drawable2 is not null) {
            tLhxvLwcoHTkqoFA(drawable2, null);
        }
        this.statusBarForeground = drawable is not null ? kIPuQaYJUspBLKGq(drawable) : null;
        this.statusBarForegroundOriginalColor = LtkyJOapxhpMhQyX(this);
        android.graphics.drawable.Drawable drawable3 = this.statusBarForeground;
        if (drawable3 is not null) {
            if (ixIRolutJoxWabpx(drawable3)) {
                amIKfcuWMGvqjoBh(this.statusBarForeground, nuhIELWoxLxtmtKc(this));
            }
            NvRCEOeHXCmQRytA(this.statusBarForeground, zrXjjmtbBuksElYr(this));
            RtdsmtfifeSadksa(this.statusBarForeground, sodxHKjYhRPbaDiP(this) == 0, false);
            ntVbunMKCGAwjJVH(this.statusBarForeground, this);
        }
        MqVEcaHNGtPwHlOL(this);
        znqxfTqvaKGXVkpO(this);
    }

    public void SetStatusBarForegroundColor(int i) {
        tFdhurzNeKiaAdrK(this, new android.graphics.drawable.ColorDrawable(i));
    }

    public void SetStatusBarForegroundResource(int i) {
        eEJWBJHtIDCplTcc(this, dLpfbmQwUKVysZut(mIqsFWgwxzJPvsYd(this), i));
    }

    @java.lang.Deprecated
    public void SetTargetElevation(float f) {
        MsAtSBmoyIwrxvjJ(this, f);
    }

    public override void SetVisibility(int i) {
        GhOhvwWBiDOIwumX(this, i);
        bool z = i == 0;
        android.graphics.drawable.Drawable drawable = this.statusBarForeground;
        if (drawable is null) {
            return;
        }
        kpLJEjeBDfgahMzf(drawable, z, false);
    }

    bool shouldLift(android.view.object view) {
        android.view.object viewODiVKjZytDWCBvID = ODiVKjZytDWCBvID(this, view);
        if (viewODiVKjZytDWCBvID is not null) {
            view = viewODiVKjZytDWCBvID;
        }
        if (view is null) {
            return false;
        }
        return MqWgcZbkHpOdowMl(view, -1) || deVTWrkrGMOydlTG(view) > 0;
    }

    protected override bool VerifyDrawable(android.graphics.drawable.Drawable drawable) {
        return NRjzbsnMQitLyfuP(this, drawable) || drawable == this.statusBarForeground;
    }
}

