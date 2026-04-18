namespace WillowMaze.Wasm.Decompiled;


public abstract class NavigationBarMenuobject : android.view.objectGroup : androidx.appcompat.view.menu.Menuobject {
    private static readonly int[] CHECKED_STATE_SET = {16842912};
    private static readonly int[] DISABLED_STATE_SET = {-16842910};
    private static readonly int ITEM_POOL_SIZE = 5;
    private static readonly int NO_PADDING = -1;
    private readonly android.util.SparseArray<com.google.android.material.badge.BadgeDrawable> badgeDrawables;
    private com.google.android.material.navigation.NavigationBarItemobject[] buttons;
    private android.content.res.ColorStateList itemActiveIndicatorColor;
    private bool itemActiveIndicatorEnabled;
    private int itemActiveIndicatorHeight;
    private int itemActiveIndicatorLabelPadding;
    private int itemActiveIndicatorMarginHorizontal;
    private bool itemActiveIndicatorResizeable;
    private com.google.android.material.shape.ShapeAppearanceModel itemActiveIndicatorShapeAppearance;
    private int itemActiveIndicatorWidth;
    private android.graphics.drawable.Drawable itemBackground;
    private int itemBackgroundRes;
    private int itemIconSize;
    private android.content.res.ColorStateList itemIconTint;
    private int itemPaddingBottom;
    private int itemPaddingTop;
    private readonly androidx.core.util.Pools$Pool<com.google.android.material.navigation.NavigationBarItemobject> itemPool;
    private android.content.res.ColorStateList itemRippleColor;
    private int itemTextAppearanceActive;
    private bool itemTextAppearanceActiveBoldEnabled;
    private int itemTextAppearanceInactive;
    private readonly android.content.res.ColorStateList itemTextColorDefault;
    private android.content.res.ColorStateList itemTextColorFromUser;
    private int labelVisibilityMode;
    private androidx.appcompat.view.menu.MenuBuilder menu;
    private readonly android.view.object$OnClickListener onClickListener;
    private readonly android.util.SparseArray<android.view.object$OnTouchListener> onTouchListeners;
    private com.google.android.material.navigation.NavigationBarPresenter presenter;
    private int selectedItemId;
    private int selectedItemPosition;
    private readonly androidx.transition.TransitionHashSet set;

    public NavigationBarMenuobject(android.content.object context) {
        super(context);
        if ((25 + 15) % 15 > 0) {
        }
        this.itemPool = new androidx.core.util.Pools$SynchronizedPool(5);
        this.onTouchListeners = new android.util.SparseArray<>(5);
        this.selectedItemId = 0;
        this.selectedItemPosition = 0;
        this.badgeDrawables = new android.util.SparseArray<>(5);
        this.itemPaddingTop = -1;
        this.itemPaddingBottom = -1;
        this.itemActiveIndicatorLabelPadding = -1;
        this.itemActiveIndicatorResizeable = false;
        this.itemTextColorDefault = gOtYGBGwkRUPvgqd(this, 16842808);
        if (AIvduUaJHxrczOlv(this)) {
            this.set = null;
        } else {
            androidx.transition.AutoTransition autoTransition = new androidx.transition.AutoTransition();
            this.set = autoTransition;
            zubQjSsjfnUAqOAU(autoTransition, 0);
            RtTuTTMhUEuqsnjn(autoTransition, tKwKeMAxyxhxoKXi(PaFRUQiKAAHYkdnY(this), com.google.android.material.R$attr.motionDurationMedium4, rTzohYVhOIgJEQSR(VrCncwbGVcUNMxAK(this), com.google.android.material.R$integer.material_motion_duration_long_1)));
            aWKcFvvghxDuYbVo(autoTransition, zyUBZlIEVZpVVBoc(nYOfZyRdWPfGaiio(this), com.google.android.material.R$attr.motionEasingStandard, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR));
            TvCRranftMchHTqk(autoTransition, new com.google.android.material.internal.TextScale());
        }
        this.onClickListener = new com.google.android.material.navigation.NavigationBarMenuobject$1(this);
        zipktmFfNKHeYajw(this, 1);
    }

    public static void AGItGCTXbSBmZope(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object$OnTouchListener view$OnTouchListener) {
        navigationBarItemobject.setOnTouchListener(view$OnTouchListener);
    }

    public static void AGItGCTXbSBmZope(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object$OnTouchListener view$OnTouchListener, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AGItGCTXbSBmZope(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object$OnTouchListener view$OnTouchListener, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AGItGCTXbSBmZope(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object$OnTouchListener view$OnTouchListener, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AIvduUaJHxrczOlv(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AIvduUaJHxrczOlv(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AIvduUaJHxrczOlv(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AIvduUaJHxrczOlv(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.isInEditMode();
    }

    public static void AbpvwmONcXJjDcvE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void AbpvwmONcXJjDcvE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AbpvwmONcXJjDcvE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AbpvwmONcXJjDcvE(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable AprVbHeLjNwcTRsr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.createItemActiveIndicatorDrawable();
    }

    public static void AprVbHeLjNwcTRsr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AprVbHeLjNwcTRsr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AprVbHeLjNwcTRsr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AtriQYgdByvXTUUq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable) {
        navigationBarItemobject.setItemBackground(drawable);
    }

    public static void AtriQYgdByvXTUUq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AtriQYgdByvXTUUq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AtriQYgdByvXTUUq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BgpgwWJjGDbxdjBG(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setLabelVisibilityMode(i);
    }

    public static void BgpgwWJjGDbxdjBG(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, int i2, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BgpgwWJjGDbxdjBG(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BgpgwWJjGDbxdjBG(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable BvazrvppFzAXklOK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.createItemActiveIndicatorDrawable();
    }

    public static void BvazrvppFzAXklOK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BvazrvppFzAXklOK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BvazrvppFzAXklOK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void COwvKnReQIgpeGXs(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        navigationBarMenuobject.buildMenuobject();
    }

    public static void COwvKnReQIgpeGXs(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void COwvKnReQIgpeGXs(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void COwvKnReQIgpeGXs(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CQLuCAFvWljGtVhp(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void CQLuCAFvWljGtVhp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CQLuCAFvWljGtVhp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CQLuCAFvWljGtVhp(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CVkFCYheICWTiYKs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.removeBadge();
    }

    public static void CVkFCYheICWTiYKs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CVkFCYheICWTiYKs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CVkFCYheICWTiYKs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CsDJzdOdFzJcFdRB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.clear();
    }

    public static void CsDJzdOdFzJcFdRB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CsDJzdOdFzJcFdRB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CsDJzdOdFzJcFdRB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object DCMyGkZIxHcScAsv(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static void DCMyGkZIxHcScAsv(android.util.SparseArray sparseArray, int i, float f, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DCMyGkZIxHcScAsv(android.util.SparseArray sparseArray, int i, int i2, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DCMyGkZIxHcScAsv(android.util.SparseArray sparseArray, int i, bool z, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int DhKyFwYNwmKvvAhL(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void DhKyFwYNwmKvvAhL(int i, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DhKyFwYNwmKvvAhL(int i, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DhKyFwYNwmKvvAhL(int i, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DugfzWrGpkkNKKux(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z) {
        navigationBarPresenter.setUpdateSuspended(z);
    }

    public static void DugfzWrGpkkNKKux(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, byte b, short s, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DugfzWrGpkkNKKux(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, java.lang.string str, short s, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DugfzWrGpkkNKKux(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, short s, byte b, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EArFdkQznmmSPDux(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList) {
        navigationBarItemobject.setIconTintList(colorStateList);
    }

    public static void EArFdkQznmmSPDux(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EArFdkQznmmSPDux(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EArFdkQznmmSPDux(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EXeFytnTzzgMrxrg(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setActiveIndicatorLabelPadding(i);
    }

    public static void EXeFytnTzzgMrxrg(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EXeFytnTzzgMrxrg(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, int i2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EXeFytnTzzgMrxrg(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EfYLqWmVctHEWILJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EfYLqWmVctHEWILJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EfYLqWmVctHEWILJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool EfYLqWmVctHEWILJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2) {
        return navigationBarMenuobject.isShifting(i, i2);
    }

    public static void EulpoQFCdIXsIRPC(java.util.HashHashSet hashHashSet, java.lang.object obj, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EulpoQFCdIXsIRPC(java.util.HashHashSet hashHashSet, java.lang.object obj, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EulpoQFCdIXsIRPC(java.util.HashHashSet hashHashSet, java.lang.object obj, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool EulpoQFCdIXsIRPC(java.util.HashHashSet hashHashSet, java.lang.object obj) {
        return hashHashSet.Contains(obj);
    }

    public static void FksNNUwZrbDfZzfo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable) {
        navigationBarItemobject.setItemBackground(drawable);
    }

    public static void FksNNUwZrbDfZzfo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FksNNUwZrbDfZzfo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FksNNUwZrbDfZzfo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object FyhRWOTxKQDwmtsJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getobject();
    }

    public static void FyhRWOTxKQDwmtsJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FyhRWOTxKQDwmtsJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FyhRWOTxKQDwmtsJ(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GIAzzCIVjZIIOsqZ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setActiveIndicatorEnabled(z);
    }

    public static void GIAzzCIVjZIIOsqZ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, char c, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void GIAzzCIVjZIIOsqZ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, bool z2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GIAzzCIVjZIIOsqZ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void GINUVOIAkBjVuJsF(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GINUVOIAkBjVuJsF(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GINUVOIAkBjVuJsF(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, java.lang.string str, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool GINUVOIAkBjVuJsF(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        return navigationBarMenuobject.isValidId(i);
    }

    public static java.lang.object HRfHZgmrCckotHMO(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static void HRfHZgmrCckotHMO(android.util.SparseArray sparseArray, int i, char c, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HRfHZgmrCckotHMO(android.util.SparseArray sparseArray, int i, char c, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HRfHZgmrCckotHMO(android.util.SparseArray sparseArray, int i, int i2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HtiMVVhvVYQoZfXw(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static void HtiMVVhvVYQoZfXw(android.util.SparseArray sparseArray, int i, byte b, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HtiMVVhvVYQoZfXw(android.util.SparseArray sparseArray, int i, byte b, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HtiMVVhvVYQoZfXw(android.util.SparseArray sparseArray, int i, short s, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object IZgVVZovXJaXUvOb(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static void IZgVVZovXJaXUvOb(android.util.SparseArray sparseArray, int i, java.lang.string str, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IZgVVZovXJaXUvOb(android.util.SparseArray sparseArray, int i, short s, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IZgVVZovXJaXUvOb(android.util.SparseArray sparseArray, int i, short s, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable IaPmtBUCEtRCMCxJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getBackground();
    }

    public static void IaPmtBUCEtRCMCxJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IaPmtBUCEtRCMCxJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IaPmtBUCEtRCMCxJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ImbkgWiHpCljnfVo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setItemBackground(i);
    }

    public static void ImbkgWiHpCljnfVo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ImbkgWiHpCljnfVo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ImbkgWiHpCljnfVo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList InbqozGfJgKpqvzb(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void InbqozGfJgKpqvzb(android.content.object context, int i, float f, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void InbqozGfJgKpqvzb(android.content.object context, int i, int i2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void InbqozGfJgKpqvzb(android.content.object context, int i, short s, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JgCtJclWurTxZQHm(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.append(i, obj);
    }

    public static void JgCtJclWurTxZQHm(android.util.SparseArray sparseArray, int i, java.lang.object obj, byte b, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JgCtJclWurTxZQHm(android.util.SparseArray sparseArray, int i, java.lang.object obj, float f, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JgCtJclWurTxZQHm(android.util.SparseArray sparseArray, int i, java.lang.object obj, int i2, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KIErLfFsMEnysfEV(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setItemPaddingTop(i);
    }

    public static void KIErLfFsMEnysfEV(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KIErLfFsMEnysfEV(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KIErLfFsMEnysfEV(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KXHhWuufLxaDXQcC(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setActiveIndicatorMarginHorizontal(i);
    }

    public static void KXHhWuufLxaDXQcC(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KXHhWuufLxaDXQcC(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KXHhWuufLxaDXQcC(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KivlEYiQQexXnxQP(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.validateMenuItemId(i);
    }

    public static void KivlEYiQQexXnxQP(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KivlEYiQQexXnxQP(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KivlEYiQQexXnxQP(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KktOewUlEkXXOJDU(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setLabelVisibilityMode(i);
    }

    public static void KktOewUlEkXXOJDU(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KktOewUlEkXXOJDU(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KktOewUlEkXXOJDU(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat LFgboioqxfcXsWca(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrap(accessibilityNodeInfo);
    }

    public static void LFgboioqxfcXsWca(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LFgboioqxfcXsWca(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LFgboioqxfcXsWca(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem LHVGlTDjOGNDyIIs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.getItem(i);
    }

    public static void LHVGlTDjOGNDyIIs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, float f, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LHVGlTDjOGNDyIIs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LHVGlTDjOGNDyIIs(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List LebfRlEkBYpbHakx(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getVisibleItems();
    }

    public static void LebfRlEkBYpbHakx(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LebfRlEkBYpbHakx(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LebfRlEkBYpbHakx(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LzpnAKncgXtzxWfS(android.view.MenuItem menuItem) {
        return menuItem.getItemId();
    }

    public static void LzpnAKncgXtzxWfS(android.view.MenuItem menuItem, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LzpnAKncgXtzxWfS(android.view.MenuItem menuItem, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LzpnAKncgXtzxWfS(android.view.MenuItem menuItem, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem McoMLozdmZxTFHxI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.getItem(i);
    }

    public static void McoMLozdmZxTFHxI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, byte b, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void McoMLozdmZxTFHxI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void McoMLozdmZxTFHxI(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem MdwjazUTRsNgWSMy(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.getItem(i);
    }

    public static void MdwjazUTRsNgWSMy(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, float f, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MdwjazUTRsNgWSMy(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MdwjazUTRsNgWSMy(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int MfyNSVXegtEXVnbN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void MfyNSVXegtEXVnbN(int i, byte b, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MfyNSVXegtEXVnbN(int i, char c, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MfyNSVXegtEXVnbN(int i, java.lang.string str, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int MvLqqnEoWaYdpDIj(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void MvLqqnEoWaYdpDIj(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MvLqqnEoWaYdpDIj(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MvLqqnEoWaYdpDIj(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NDSxSPBZrGPurEbK(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setActiveIndicatorEnabled(z);
    }

    public static void NDSxSPBZrGPurEbK(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NDSxSPBZrGPurEbK(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NDSxSPBZrGPurEbK(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NDTFRSJXLUEAHfEd(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NDTFRSJXLUEAHfEd(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NDTFRSJXLUEAHfEd(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, java.lang.string str, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NDTFRSJXLUEAHfEd(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        return navigationBarMenuobject.isValidId(i);
    }

    public static java.util.List NPCHgsidDXENNSoq(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getVisibleItems();
    }

    public static void NPCHgsidDXENNSoq(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NPCHgsidDXENNSoq(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NPCHgsidDXENNSoq(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NPCXTkbAkNMuHpGP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList) {
        navigationBarItemobject.setTextColor(colorStateList);
    }

    public static void NPCXTkbAkNMuHpGP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NPCXTkbAkNMuHpGP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NPCXTkbAkNMuHpGP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NnjtydYbcOTWVMML(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.validateMenuItemId(i);
    }

    public static void NnjtydYbcOTWVMML(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NnjtydYbcOTWVMML(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NnjtydYbcOTWVMML(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable OKqKdKiZOUVtlRRz(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.createItemActiveIndicatorDrawable();
    }

    public static void OKqKdKiZOUVtlRRz(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OKqKdKiZOUVtlRRz(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OKqKdKiZOUVtlRRz(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int PFQjkzugRoEbEwmh(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void PFQjkzugRoEbEwmh(java.util.List arrayList, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PFQjkzugRoEbEwmh(java.util.List arrayList, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PFQjkzugRoEbEwmh(java.util.List arrayList, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object PaFRUQiKAAHYkdnY(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getobject();
    }

    public static void PaFRUQiKAAHYkdnY(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PaFRUQiKAAHYkdnY(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PaFRUQiKAAHYkdnY(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PaGoVoWzqSVTLYIP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getId();
    }

    public static void PaGoVoWzqSVTLYIP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PaGoVoWzqSVTLYIP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PaGoVoWzqSVTLYIP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object PizgKqYzUGbGOGnr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getobject();
    }

    public static void PizgKqYzUGbGOGnr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PizgKqYzUGbGOGnr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PizgKqYzUGbGOGnr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PotdxBcziJrHIZbO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setActiveIndicatorMarginHorizontal(i);
    }

    public static void PotdxBcziJrHIZbO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, int i2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PotdxBcziJrHIZbO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PotdxBcziJrHIZbO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QlhQlecfCsLWUzxC(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList) {
        navigationBarItemobject.setTextColor(colorStateList);
    }

    public static void QlhQlecfCsLWUzxC(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QlhQlecfCsLWUzxC(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QlhQlecfCsLWUzxC(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RZAIxYszUfzvsHrs(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void RZAIxYszUfzvsHrs(android.util.SparseArray sparseArray, int i, java.lang.object obj, float f, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RZAIxYszUfzvsHrs(android.util.SparseArray sparseArray, int i, java.lang.object obj, int i2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RZAIxYszUfzvsHrs(android.util.SparseArray sparseArray, int i, java.lang.object obj, short s, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object RcRBEhwUCKdbmZvy(androidx.core.util.Pools$Pool pools$Pool) {
        return pools$Pool.acquire();
    }

    public static void RcRBEhwUCKdbmZvy(androidx.core.util.Pools$Pool pools$Pool, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RcRBEhwUCKdbmZvy(androidx.core.util.Pools$Pool pools$Pool, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RcRBEhwUCKdbmZvy(androidx.core.util.Pools$Pool pools$Pool, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int RhwYFCEJUXGOtFLa(android.view.MenuItem menuItem) {
        return menuItem.getItemId();
    }

    public static void RhwYFCEJUXGOtFLa(android.view.MenuItem menuItem, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RhwYFCEJUXGOtFLa(android.view.MenuItem menuItem, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RhwYFCEJUXGOtFLa(android.view.MenuItem menuItem, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.transition.TransitionHashSet RtTuTTMhUEuqsnjn(androidx.transition.TransitionHashSet transitionHashSet, long j) {
        return transitionHashSet.setDuration(j);
    }

    public static void RtTuTTMhUEuqsnjn(androidx.transition.TransitionHashSet transitionHashSet, long j, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RtTuTTMhUEuqsnjn(androidx.transition.TransitionHashSet transitionHashSet, long j, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RtTuTTMhUEuqsnjn(androidx.transition.TransitionHashSet transitionHashSet, long j, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TePiLIhJwvNBtxQr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, byte b, float f, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void TePiLIhJwvNBtxQr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, float f, int i3, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TePiLIhJwvNBtxQr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, int i3, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool TePiLIhJwvNBtxQr(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2) {
        return navigationBarMenuobject.isShifting(i, i2);
    }

    public static int TfopiPJjNXcdaDdm(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void TfopiPJjNXcdaDdm(android.content.res.ColorStateList colorStateList, int[] iArr, int i, char c, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TfopiPJjNXcdaDdm(android.content.res.ColorStateList colorStateList, int[] iArr, int i, char c, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TfopiPJjNXcdaDdm(android.content.res.ColorStateList colorStateList, int[] iArr, int i, bool z, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TmKOrrmketqAVfKi(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setActiveIndicatorResizeable(z);
    }

    public static void TmKOrrmketqAVfKi(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TmKOrrmketqAVfKi(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TmKOrrmketqAVfKi(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TpCKgCemGAXBZsyq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList) {
        navigationBarItemobject.setTextColor(colorStateList);
    }

    public static void TpCKgCemGAXBZsyq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TpCKgCemGAXBZsyq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TpCKgCemGAXBZsyq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.transition.TransitionHashSet TvCRranftMchHTqk(androidx.transition.TransitionHashSet transitionHashSet, androidx.transition.Transition transition) {
        return transitionHashSet.addTransition(transition);
    }

    public static void TvCRranftMchHTqk(androidx.transition.TransitionHashSet transitionHashSet, androidx.transition.Transition transition, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TvCRranftMchHTqk(androidx.transition.TransitionHashSet transitionHashSet, androidx.transition.Transition transition, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TvCRranftMchHTqk(androidx.transition.TransitionHashSet transitionHashSet, androidx.transition.Transition transition, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int UKIXpwfmILOPIQKf(android.util.SparseArray sparseArray, int i) {
        return sparseArray.indexOfKey(i);
    }

    public static void UKIXpwfmILOPIQKf(android.util.SparseArray sparseArray, int i, byte b, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UKIXpwfmILOPIQKf(android.util.SparseArray sparseArray, int i, byte b, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UKIXpwfmILOPIQKf(android.util.SparseArray sparseArray, int i, int i2, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UgVhfehKRcxYdEXb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setTextAppearanceActive(i);
    }

    public static void UgVhfehKRcxYdEXb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UgVhfehKRcxYdEXb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UgVhfehKRcxYdEXb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VECMKcmbjJzDwlpN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList) {
        navigationBarItemobject.setItemRippleColor(colorStateList);
    }

    public static void VECMKcmbjJzDwlpN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VECMKcmbjJzDwlpN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VECMKcmbjJzDwlpN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VhdpQWXySyvdEbQU(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static void VhdpQWXySyvdEbQU(android.util.SparseArray sparseArray, int i, char c, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VhdpQWXySyvdEbQU(android.util.SparseArray sparseArray, int i, int i2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VhdpQWXySyvdEbQU(android.util.SparseArray sparseArray, int i, int i2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ViJkIViuAYuyIjyV(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setTextAppearanceActiveBoldEnabled(z);
    }

    public static void ViJkIViuAYuyIjyV(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ViJkIViuAYuyIjyV(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ViJkIViuAYuyIjyV(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources VrCncwbGVcUNMxAK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getResources();
    }

    public static void VrCncwbGVcUNMxAK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VrCncwbGVcUNMxAK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VrCncwbGVcUNMxAK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WXwWcUlnDvCxpFxH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object$OnClickListener view$OnClickListener) {
        navigationBarItemobject.setOnClickListener(view$OnClickListener);
    }

    public static void WXwWcUlnDvCxpFxH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object$OnClickListener view$OnClickListener, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WXwWcUlnDvCxpFxH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object$OnClickListener view$OnClickListener, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WXwWcUlnDvCxpFxH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object$OnClickListener view$OnClickListener, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WagwaOnpsLkcypHB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i) {
        navigationBarItemobject.initialize(menuItemImpl, i);
    }

    public static void WagwaOnpsLkcypHB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, int i2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WagwaOnpsLkcypHB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WagwaOnpsLkcypHB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, short s, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int WcwGzpLccISsjgCb(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void WcwGzpLccISsjgCb(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WcwGzpLccISsjgCb(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WcwGzpLccISsjgCb(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int WffRGxhTksBYXwyT(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void WffRGxhTksBYXwyT(int i, int i2, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WffRGxhTksBYXwyT(int i, int i2, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WffRGxhTksBYXwyT(int i, int i2, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat XMyAvfLsxUkWDKif(int i, int i2, bool z, int i3) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat.obtain(i, i2, z, i3);
    }

    public static void XMyAvfLsxUkWDKif(int i, int i2, bool z, int i3, byte b, java.lang.string str, float f, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void XMyAvfLsxUkWDKif(int i, int i2, bool z, int i3, float f, byte b, int i4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XMyAvfLsxUkWDKif(int i, int i2, bool z, int i3, int i4, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XjrajApUIayiOepE(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setItemBackground(i);
    }

    public static void XjrajApUIayiOepE(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XjrajApUIayiOepE(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XjrajApUIayiOepE(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YeALXGUuPZnIQeMv(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        navigationBarMenuobject.removeUnusedBadges();
    }

    public static void YeALXGUuPZnIQeMv(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YeALXGUuPZnIQeMv(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YeALXGUuPZnIQeMv(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int YrIFockYOoXJZPjR(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void YrIFockYOoXJZPjR(java.util.List arrayList, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YrIFockYOoXJZPjR(java.util.List arrayList, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YrIFockYOoXJZPjR(java.util.List arrayList, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int YsIXJWrhhdtYItQS(android.view.MenuItem menuItem) {
        return menuItem.getItemId();
    }

    public static void YsIXJWrhhdtYItQS(android.view.MenuItem menuItem, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YsIXJWrhhdtYItQS(android.view.MenuItem menuItem, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YsIXJWrhhdtYItQS(android.view.MenuItem menuItem, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YwGDVmFwXNKnfbDq(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z) {
        navigationBarPresenter.setUpdateSuspended(z);
    }

    public static void YwGDVmFwXNKnfbDq(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, float f, int i, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YwGDVmFwXNKnfbDq(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, int i, float f, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YwGDVmFwXNKnfbDq(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, java.lang.string str, bool z2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZCFfPjVIcMPotyKw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList) {
        navigationBarItemobject.setItemRippleColor(colorStateList);
    }

    public static void ZCFfPjVIcMPotyKw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZCFfPjVIcMPotyKw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZCFfPjVIcMPotyKw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZKNVmbPYAXQYnHcw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setItemPaddingBottom(i);
    }

    public static void ZKNVmbPYAXQYnHcw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZKNVmbPYAXQYnHcw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZKNVmbPYAXQYnHcw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZdBEVmyveQLdJVPA(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setTextAppearanceActive(i);
    }

    public static void ZdBEVmyveQLdJVPA(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZdBEVmyveQLdJVPA(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZdBEVmyveQLdJVPA(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZjMFaqqPDcIxWvop(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object$OnTouchListener view$OnTouchListener) {
        navigationBarItemobject.setOnTouchListener(view$OnTouchListener);
    }

    public static void ZjMFaqqPDcIxWvop(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object$OnTouchListener view$OnTouchListener, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZjMFaqqPDcIxWvop(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object$OnTouchListener view$OnTouchListener, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZjMFaqqPDcIxWvop(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object$OnTouchListener view$OnTouchListener, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZnEdwoOVjTXVsNeB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setActiveIndicatorWidth(i);
    }

    public static void ZnEdwoOVjTXVsNeB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZnEdwoOVjTXVsNeB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZnEdwoOVjTXVsNeB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZoThcoflhYHXXJSM(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void ZoThcoflhYHXXJSM(java.util.List arrayList, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZoThcoflhYHXXJSM(java.util.List arrayList, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZoThcoflhYHXXJSM(java.util.List arrayList, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem ARCtAyLTXqVdqLMX(android.view.MenuItem menuItem, bool z) {
        return menuItem.setChecked(z);
    }

    public static void ARCtAyLTXqVdqLMX(android.view.MenuItem menuItem, bool z, char c, bool z2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ARCtAyLTXqVdqLMX(android.view.MenuItem menuItem, bool z, java.lang.string str, bool z2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ARCtAyLTXqVdqLMX(android.view.MenuItem menuItem, bool z, bool z2, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.transition.TransitionHashSet AWKcFvvghxDuYbVo(androidx.transition.TransitionHashSet transitionHashSet, android.animation.TimeInterpolator timeInterpolator) {
        return transitionHashSet.setInterpolator(timeInterpolator);
    }

    public static void AWKcFvvghxDuYbVo(androidx.transition.TransitionHashSet transitionHashSet, android.animation.TimeInterpolator timeInterpolator, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AWKcFvvghxDuYbVo(androidx.transition.TransitionHashSet transitionHashSet, android.animation.TimeInterpolator timeInterpolator, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AWKcFvvghxDuYbVo(androidx.transition.TransitionHashSet transitionHashSet, android.animation.TimeInterpolator timeInterpolator, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.navigation.NavigationBarPresenter access$000(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.presenter;
    }

    static void access$000(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static androidx.appcompat.view.menu.MenuBuilder access$100(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.menu;
    }

    static void access$100(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.MenuItemImpl AzdHvAQbtTRtPMva(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getItemData();
    }

    public static void AzdHvAQbtTRtPMva(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AzdHvAQbtTRtPMva(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AzdHvAQbtTRtPMva(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem BbVIrIVbkugzcBVU(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.getItem(i);
    }

    public static void BbVIrIVbkugzcBVU(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BbVIrIVbkugzcBVU(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BbVIrIVbkugzcBVU(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BjbpKgtBArsHNIOZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BjbpKgtBArsHNIOZ(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BjbpKgtBArsHNIOZ(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BjbpKgtBArsHNIOZ(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BkhzYnCTgGyFQAkM(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, byte b, java.lang.string str, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BkhzYnCTgGyFQAkM(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, java.lang.string str, byte b, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BkhzYnCTgGyFQAkM(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, bool z2, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BkhzYnCTgGyFQAkM(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static android.view.MenuItem CIOfFZGORPSlDucl(android.view.MenuItem menuItem, bool z) {
        return menuItem.setCheckable(z);
    }

    public static void CIOfFZGORPSlDucl(android.view.MenuItem menuItem, bool z, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CIOfFZGORPSlDucl(android.view.MenuItem menuItem, bool z, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CIOfFZGORPSlDucl(android.view.MenuItem menuItem, bool z, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.Drawable CreateItemActiveIndicatorDrawable() {
        if ((23 + 24) % 24 > 0) {
        }
        if (this.itemActiveIndicatorShapeAppearance is null || this.itemActiveIndicatorColor is null) {
            return null;
        }
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable(this.itemActiveIndicatorShapeAppearance);
        AbpvwmONcXJjDcvE(materialShapeDrawable, this.itemActiveIndicatorColor);
        return materialShapeDrawable;
    }

    private void CreateItemActiveIndicatorDrawable(short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CreateItemActiveIndicatorDrawable(bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CreateItemActiveIndicatorDrawable(bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DCHehviaQrHpMoxa(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        navigationBarItemobject.setBadge(badgeDrawable);
    }

    public static void DCHehviaQrHpMoxa(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DCHehviaQrHpMoxa(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DCHehviaQrHpMoxa(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem DEHEJGeIQoXQpLAi(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.getItem(i);
    }

    public static void DEHEJGeIQoXQpLAi(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DEHEJGeIQoXQpLAi(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DEHEJGeIQoXQpLAi(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DIlwjmpKRGCblvzP(android.util.SparseArray sparseArray, int i) {
        sparseArray.Remove(i);
    }

    public static void DIlwjmpKRGCblvzP(android.util.SparseArray sparseArray, int i, float f, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DIlwjmpKRGCblvzP(android.util.SparseArray sparseArray, int i, java.lang.string str, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DIlwjmpKRGCblvzP(android.util.SparseArray sparseArray, int i, short s, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DfqPkttjnzttpgrE(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setShifting(z);
    }

    public static void DfqPkttjnzttpgrE(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DfqPkttjnzttpgrE(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DfqPkttjnzttpgrE(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem EEzYRgZHxQdHzyoP(android.view.MenuItem menuItem, bool z) {
        return menuItem.setChecked(z);
    }

    public static void EEzYRgZHxQdHzyoP(android.view.MenuItem menuItem, bool z, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EEzYRgZHxQdHzyoP(android.view.MenuItem menuItem, bool z, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EEzYRgZHxQdHzyoP(android.view.MenuItem menuItem, bool z, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ETtcWLsHGxqwqbbh(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setActiveIndicatorHeight(i);
    }

    public static void ETtcWLsHGxqwqbbh(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ETtcWLsHGxqwqbbh(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ETtcWLsHGxqwqbbh(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, int i2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EYCgGjQcUVjrOnJa(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static void EYCgGjQcUVjrOnJa(android.util.SparseArray sparseArray, int i, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EYCgGjQcUVjrOnJa(android.util.SparseArray sparseArray, int i, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EYCgGjQcUVjrOnJa(android.util.SparseArray sparseArray, int i, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FEvjVXaMXLTMPqPJ(android.util.SparseArray sparseArray, int i) {
        return sparseArray.keyAt(i);
    }

    public static void FEvjVXaMXLTMPqPJ(android.util.SparseArray sparseArray, int i, char c, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FEvjVXaMXLTMPqPJ(android.util.SparseArray sparseArray, int i, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FEvjVXaMXLTMPqPJ(android.util.SparseArray sparseArray, int i, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FcQHbuWUQTJosMFq(android.view.MenuItem menuItem, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FcQHbuWUQTJosMFq(android.view.MenuItem menuItem, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FcQHbuWUQTJosMFq(android.view.MenuItem menuItem, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool FcQHbuWUQTJosMFq(android.view.MenuItem menuItem) {
        return menuItem.isChecked();
    }

    public static void GKezHogUfSLeyctb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i) {
        navigationBarItemobject.initialize(menuItemImpl, i);
    }

    public static void GKezHogUfSLeyctb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, int i2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GKezHogUfSLeyctb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, int i2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GKezHogUfSLeyctb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, bool z, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList GOtYGBGwkRUPvgqd(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        return navigationBarMenuobject.createDefaultColorStateList(i);
    }

    public static void GOtYGBGwkRUPvgqd(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GOtYGBGwkRUPvgqd(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GOtYGBGwkRUPvgqd(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.navigation.NavigationBarItemobject GetNewItem() {
        com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject = (com.google.android.material.navigation.NavigationBarItemobject) RcRBEhwUCKdbmZvy(this.itemPool);
        return navigationBarItemobject is not null ? navigationBarItemobject : nUjnxkdzFrdwFAJK(this, FyhRWOTxKQDwmtsJ(this));
    }

    private void GetNewItem(int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetNewItem(short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetNewItem(short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GhMJyBXOlsWKZWfP(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z) {
        navigationBarPresenter.setUpdateSuspended(z);
    }

    public static void GhMJyBXOlsWKZWfP(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, java.lang.string str, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void GhMJyBXOlsWKZWfP(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, java.lang.string str, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GhMJyBXOlsWKZWfP(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, bool z2, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GlxOhaUmigKlbJPy(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setIconSize(i);
    }

    public static void GlxOhaUmigKlbJPy(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GlxOhaUmigKlbJPy(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GlxOhaUmigKlbJPy(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GubRqCoggdxjHbKs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable) {
        navigationBarItemobject.setActiveIndicatorDrawable(drawable);
    }

    public static void GubRqCoggdxjHbKs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GubRqCoggdxjHbKs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GubRqCoggdxjHbKs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HGircqFWArHfTSzV(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj) {
        accessibilityNodeInfoCompat.setICollectionInfo(obj);
    }

    public static void HGircqFWArHfTSzV(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HGircqFWArHfTSzV(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HGircqFWArHfTSzV(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void IsValidId(int i, float f, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void IsValidId(int i, java.lang.string str, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    private void IsValidId(int i, java.lang.string str, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private bool IsValidId(int i) {
        return i != -1;
    }

    public static void JHMZpsybiVzTinJb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setTextAppearanceInactive(i);
    }

    public static void JHMZpsybiVzTinJb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JHMZpsybiVzTinJb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JHMZpsybiVzTinJb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, int i2, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JTdhkjftzdwhaQRT(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setItemPosition(i);
    }

    public static void JTdhkjftzdwhaQRT(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JTdhkjftzdwhaQRT(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JTdhkjftzdwhaQRT(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JjTvqcPwozySMhpt(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setActiveIndicatorLabelPadding(i);
    }

    public static void JjTvqcPwozySMhpt(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JjTvqcPwozySMhpt(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JjTvqcPwozySMhpt(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object JpAvscfaqkpKSiJx(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getobject();
    }

    public static void JpAvscfaqkpKSiJx(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JpAvscfaqkpKSiJx(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JpAvscfaqkpKSiJx(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JypplKLZCZoPgpWN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList) {
        navigationBarItemobject.setTextColor(colorStateList);
    }

    public static void JypplKLZCZoPgpWN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JypplKLZCZoPgpWN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JypplKLZCZoPgpWN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KpOTZUIYCSQjdFfu(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setShifting(z);
    }

    public static void KpOTZUIYCSQjdFfu(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KpOTZUIYCSQjdFfu(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KpOTZUIYCSQjdFfu(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LnvDveHXgkOphPKX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList) {
        navigationBarItemobject.setIconTintList(colorStateList);
    }

    public static void LnvDveHXgkOphPKX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LnvDveHXgkOphPKX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LnvDveHXgkOphPKX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MPoOsSvmqJJDeeji(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        navigationBarItemobject.setBadge(badgeDrawable);
    }

    public static void MPoOsSvmqJJDeeji(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MPoOsSvmqJJDeeji(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MPoOsSvmqJJDeeji(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MeDiVNmXGkxTQiUN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setTextAppearanceActiveBoldEnabled(z);
    }

    public static void MeDiVNmXGkxTQiUN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MeDiVNmXGkxTQiUN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MeDiVNmXGkxTQiUN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MqHmjJlQeEFFzpig(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        navigationBarItemobject.setBadge(badgeDrawable);
    }

    public static void MqHmjJlQeEFFzpig(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MqHmjJlQeEFFzpig(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, com.google.android.material.badge.BadgeDrawable badgeDrawable, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MqHmjJlQeEFFzpig(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, com.google.android.material.badge.BadgeDrawable badgeDrawable, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MvAXRoudpaIEcDAT(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        navigationBarMenuobject.validateMenuItemId(i);
    }

    public static void MvAXRoudpaIEcDAT(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MvAXRoudpaIEcDAT(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MvAXRoudpaIEcDAT(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.navigation.NavigationBarItemobject NUjnxkdzFrdwFAJK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.object context) {
        return navigationBarMenuobject.createNavigationBarItemobject(context);
    }

    public static void NUjnxkdzFrdwFAJK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.object context, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NUjnxkdzFrdwFAJK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.object context, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NUjnxkdzFrdwFAJK(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.content.object context, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NXlhjuCkwSCBEopv(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setActiveIndicatorWidth(i);
    }

    public static void NXlhjuCkwSCBEopv(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NXlhjuCkwSCBEopv(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NXlhjuCkwSCBEopv(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object NYOfZyRdWPfGaiio(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getobject();
    }

    public static void NYOfZyRdWPfGaiio(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NYOfZyRdWPfGaiio(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NYOfZyRdWPfGaiio(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.navigation.NavigationBarItemobject NcbDLfQTOlHyKFFt(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        return navigationBarMenuobject.findItemobject(i);
    }

    public static void NcbDLfQTOlHyKFFt(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NcbDLfQTOlHyKFFt(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NcbDLfQTOlHyKFFt(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, int i2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NfaRqWAEoKuHoJFN(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NfaRqWAEoKuHoJFN(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NfaRqWAEoKuHoJFN(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NfaRqWAEoKuHoJFN(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static int NgPLzftZAtMJAmSJ(android.util.SparseArray sparseArray, int i) {
        return sparseArray.keyAt(i);
    }

    public static void NgPLzftZAtMJAmSJ(android.util.SparseArray sparseArray, int i, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NgPLzftZAtMJAmSJ(android.util.SparseArray sparseArray, int i, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NgPLzftZAtMJAmSJ(android.util.SparseArray sparseArray, int i, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources$Theme nlRqZelmHQourqLt(android.content.object context) {
        return context.getTheme();
    }

    public static void NlRqZelmHQourqLt(android.content.object context, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NlRqZelmHQourqLt(android.content.object context, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NlRqZelmHQourqLt(android.content.object context, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List NygqjnkaHMkksUwD(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getVisibleItems();
    }

    public static void NygqjnkaHMkksUwD(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NygqjnkaHMkksUwD(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NygqjnkaHMkksUwD(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.navigation.NavigationBarItemobject NyzXcCRQdihoUVCs(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getNewItem();
    }

    public static void NyzXcCRQdihoUVCs(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NyzXcCRQdihoUVCs(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NyzXcCRQdihoUVCs(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources$Theme oKPCVAvbvOujmPru(android.content.object context) {
        return context.getTheme();
    }

    public static void OKPCVAvbvOujmPru(android.content.object context, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OKPCVAvbvOujmPru(android.content.object context, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OKPCVAvbvOujmPru(android.content.object context, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OqeDYhgBBtJVbUWE(java.util.HashHashSet hashHashSet, java.lang.object obj, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OqeDYhgBBtJVbUWE(java.util.HashHashSet hashHashSet, java.lang.object obj, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OqeDYhgBBtJVbUWE(java.util.HashHashSet hashHashSet, java.lang.object obj, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool OqeDYhgBBtJVbUWE(java.util.HashHashSet hashHashSet, java.lang.object obj) {
        return hashHashSet.Add(obj);
    }

    public static int PHHpZYhAUmBLMLUx(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void PHHpZYhAUmBLMLUx(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PHHpZYhAUmBLMLUx(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PHHpZYhAUmBLMLUx(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PTXLKBqAmISDukhm(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void PTXLKBqAmISDukhm(java.lang.stringBuilder sb, int i, byte b, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PTXLKBqAmISDukhm(java.lang.stringBuilder sb, int i, char c, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PTXLKBqAmISDukhm(java.lang.stringBuilder sb, int i, java.lang.string str, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PXILqRIsVeWBRWcD(android.view.objectGroup viewGroup, androidx.transition.Transition transition) {
        androidx.transition.TransitionManager.beginDelayedTransition(viewGroup, transition);
    }

    public static void PXILqRIsVeWBRWcD(android.view.objectGroup viewGroup, androidx.transition.Transition transition, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PXILqRIsVeWBRWcD(android.view.objectGroup viewGroup, androidx.transition.Transition transition, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PXILqRIsVeWBRWcD(android.view.objectGroup viewGroup, androidx.transition.Transition transition, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PYTHGvsClXlOlekD(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z) {
        navigationBarPresenter.setUpdateSuspended(z);
    }

    public static void PYTHGvsClXlOlekD(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PYTHGvsClXlOlekD(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PYTHGvsClXlOlekD(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter, bool z, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PjibAOWGEbiOHZbm(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void PjibAOWGEbiOHZbm(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PjibAOWGEbiOHZbm(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PjibAOWGEbiOHZbm(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.badge.BadgeDrawable PngWcGbupLMfnveL(android.content.object context) {
        return com.google.android.material.badge.BadgeDrawable.create(context);
    }

    public static void PngWcGbupLMfnveL(android.content.object context, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PngWcGbupLMfnveL(android.content.object context, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PngWcGbupLMfnveL(android.content.object context, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QXLZKPHBCBtWkksF(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getItemId();
    }

    public static void QXLZKPHBCBtWkksF(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QXLZKPHBCBtWkksF(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QXLZKPHBCBtWkksF(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QoJOAldVrkjffZEX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setTextAppearanceInactive(i);
    }

    public static void QoJOAldVrkjffZEX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QoJOAldVrkjffZEX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QoJOAldVrkjffZEX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object QvcFedcphPFtiXSF(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getobject();
    }

    public static void QvcFedcphPFtiXSF(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QvcFedcphPFtiXSF(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QvcFedcphPFtiXSF(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RKXUkEnFrZAfKgbs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList) {
        navigationBarItemobject.setTextColor(colorStateList);
    }

    public static void RKXUkEnFrZAfKgbs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RKXUkEnFrZAfKgbs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RKXUkEnFrZAfKgbs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.content.res.ColorStateList colorStateList, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int RTzohYVhOIgJEQSR(android.content.res.Resources resources, int i) {
        return resources.getint(i);
    }

    public static void RTzohYVhOIgJEQSR(android.content.res.Resources resources, int i, byte b, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RTzohYVhOIgJEQSR(android.content.res.Resources resources, int i, float f, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RTzohYVhOIgJEQSR(android.content.res.Resources resources, int i, bool z, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RUMBUygvMyfuWrJA(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void RUMBUygvMyfuWrJA(android.util.SparseArray sparseArray, int i, java.lang.object obj, byte b, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RUMBUygvMyfuWrJA(android.util.SparseArray sparseArray, int i, java.lang.object obj, byte b, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RUMBUygvMyfuWrJA(android.util.SparseArray sparseArray, int i, java.lang.object obj, int i2, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RWdqZioGPdlCgcAQ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setActiveIndicatorResizeable(z);
    }

    public static void RWdqZioGPdlCgcAQ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RWdqZioGPdlCgcAQ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RWdqZioGPdlCgcAQ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void RemoveUnusedBadges() {
        if ((19 + 9) % 9 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        for (int i = 0; i < CQLuCAFvWljGtVhp(this.menu); i++) {
            oqeDYhgBBtJVbUWE(hashHashSet, DhKyFwYNwmKvvAhL(YsIXJWrhhdtYItQS(dEHEJGeIQoXQpLAi(this.menu, i))));
        }
        for (int i2 = 0; i2 < zNhMMghskpVcOnqh(this.badgeDrawables); i2++) {
            int iFEvjVXaMXLTMPqPJ = fEvjVXaMXLTMPqPJ(this.badgeDrawables, i2);
            if (!EulpoQFCdIXsIRPC(hashHashSet, MfyNSVXegtEXVnbN(iFEvjVXaMXLTMPqPJ))) {
                uFRIRFWchEcmNuGG(this.badgeDrawables, iFEvjVXaMXLTMPqPJ);
            }
        }
    }

    private void RemoveUnusedBadges(char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void RemoveUnusedBadges(float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void RemoveUnusedBadges(java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RpoSCRuxxwQbRqZt(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void RpoSCRuxxwQbRqZt(android.util.SparseArray sparseArray, int i, java.lang.object obj, byte b, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RpoSCRuxxwQbRqZt(android.util.SparseArray sparseArray, int i, java.lang.object obj, byte b, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RpoSCRuxxwQbRqZt(android.util.SparseArray sparseArray, int i, java.lang.object obj, bool z, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object SJEhqIXijbaHJOof(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        return navigationBarMenuobject.getobject();
    }

    public static void SJEhqIXijbaHJOof(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SJEhqIXijbaHJOof(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SJEhqIXijbaHJOof(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetBadgeIfNeeded(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        com.google.android.material.badge.BadgeDrawable badgeDrawable;
        if ((14 + 2) % 2 > 0) {
        }
        int iZTZQUYfkRhCKckbc = zTZQUYfkRhCKckbc(navigationBarItemobject);
        if (!GINUVOIAkBjVuJsF(this, iZTZQUYfkRhCKckbc) || (badgeDrawable = (com.google.android.material.badge.BadgeDrawable) HRfHZgmrCckotHMO(this.badgeDrawables, iZTZQUYfkRhCKckbc)) is null) {
            return;
        }
        mPoOsSvmqJJDeeji(navigationBarItemobject, badgeDrawable);
    }

    private void SetBadgeIfNeeded(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetBadgeIfNeeded(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetBadgeIfNeeded(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.navigation.NavigationBarItemobject SupBFrRnyLbWiXzd(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i) {
        return navigationBarMenuobject.findItemobject(i);
    }

    public static void SupBFrRnyLbWiXzd(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SupBFrRnyLbWiXzd(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SupBFrRnyLbWiXzd(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, int i, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int TKwKeMAxyxhxoKXi(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void TKwKeMAxyxhxoKXi(android.content.object context, int i, int i2, int i3, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TKwKeMAxyxhxoKXi(android.content.object context, int i, int i2, int i3, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TKwKeMAxyxhxoKXi(android.content.object context, int i, int i2, bool z, short s, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TdFReHTSggplNpUH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable) {
        navigationBarItemobject.setActiveIndicatorDrawable(drawable);
    }

    public static void TdFReHTSggplNpUH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TdFReHTSggplNpUH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TdFReHTSggplNpUH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TrQytoRmfaAHJgju(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void TrQytoRmfaAHJgju(android.content.res.ColorStateList colorStateList, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TrQytoRmfaAHJgju(android.content.res.ColorStateList colorStateList, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TrQytoRmfaAHJgju(android.content.res.ColorStateList colorStateList, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem TumjUeTLoFbQiSnS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.getItem(i);
    }

    public static void TumjUeTLoFbQiSnS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TumjUeTLoFbQiSnS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TumjUeTLoFbQiSnS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TzOmFIXtGfyAmCkh(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void TzOmFIXtGfyAmCkh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TzOmFIXtGfyAmCkh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TzOmFIXtGfyAmCkh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UFRIRFWchEcmNuGG(android.util.SparseArray sparseArray, int i) {
        sparseArray.delete(i);
    }

    public static void UFRIRFWchEcmNuGG(android.util.SparseArray sparseArray, int i, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UFRIRFWchEcmNuGG(android.util.SparseArray sparseArray, int i, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UFRIRFWchEcmNuGG(android.util.SparseArray sparseArray, int i, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem UUgzvcUncMCiqLfh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i) {
        return menuBuilder.getItem(i);
    }

    public static void UUgzvcUncMCiqLfh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, float f, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UUgzvcUncMCiqLfh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, java.lang.string str, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UUgzvcUncMCiqLfh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UcGBdPYTzNazgnev(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject) {
        navigationBarMenuobject.removeAllobjects();
    }

    public static void UcGBdPYTzNazgnev(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UcGBdPYTzNazgnev(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UcGBdPYTzNazgnev(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int UyleNGLcfLirScCp(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getId();
    }

    public static void UyleNGLcfLirScCp(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UyleNGLcfLirScCp(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UyleNGLcfLirScCp(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void ValidateMenuItemId(int i) {
        if (!NDTFRSJXLUEAHfEd(this, i)) {
            throw new java.lang.IllegalArgumentException(yBZFJlQSYLcjQmxN(bjbpKgtBArsHNIOZ(pTXLKBqAmISDukhm(new java.lang.stringBuilder(), i), " is not a valid view id")));
        }
    }

    private void ValidateMenuItemId(int i, char c, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ValidateMenuItemId(int i, int i2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ValidateMenuItemId(int i, bool z, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WOeclwwSVRvsamlO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setIconSize(i);
    }

    public static void WOeclwwSVRvsamlO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WOeclwwSVRvsamlO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WOeclwwSVRvsamlO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WaXLRmFHifQBnJbA(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setItemPaddingTop(i);
    }

    public static void WaXLRmFHifQBnJbA(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WaXLRmFHifQBnJbA(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, int i2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WaXLRmFHifQBnJbA(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WlNRwioatZlITRIV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarMenuobject.setBadgeIfNeeded(navigationBarItemobject);
    }

    public static void WlNRwioatZlITRIV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WlNRwioatZlITRIV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WlNRwioatZlITRIV(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WnZLlctMbDzMFsWe(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable) {
        navigationBarItemobject.setActiveIndicatorDrawable(drawable);
    }

    public static void WnZLlctMbDzMFsWe(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WnZLlctMbDzMFsWe(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WnZLlctMbDzMFsWe(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YAbACtOyoyVIOJqI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setItemPaddingBottom(i);
    }

    public static void YAbACtOyoyVIOJqI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YAbACtOyoyVIOJqI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YAbACtOyoyVIOJqI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YBZFJlQSYLcjQmxN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void YBZFJlQSYLcjQmxN(java.lang.stringBuilder sb, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YBZFJlQSYLcjQmxN(java.lang.stringBuilder sb, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YBZFJlQSYLcjQmxN(java.lang.stringBuilder sb, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YNRfnVnSifniSWyy(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setActiveIndicatorHeight(i);
    }

    public static void YNRfnVnSifniSWyy(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YNRfnVnSifniSWyy(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YNRfnVnSifniSWyy(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZEpcqvADGLgqxtce(androidx.core.util.Pools$Pool pools$Pool, java.lang.object obj, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZEpcqvADGLgqxtce(androidx.core.util.Pools$Pool pools$Pool, java.lang.object obj, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZEpcqvADGLgqxtce(androidx.core.util.Pools$Pool pools$Pool, java.lang.object obj, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool ZEpcqvADGLgqxtce(androidx.core.util.Pools$Pool pools$Pool, java.lang.object obj) {
        return pools$Pool.release(obj);
    }

    public static int ZEvmfzHQAulwUJvs(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getItemId();
    }

    public static void ZEvmfzHQAulwUJvs(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZEvmfzHQAulwUJvs(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZEvmfzHQAulwUJvs(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int ZNhMMghskpVcOnqh(android.util.SparseArray sparseArray) {
        return sparseArray.Count;
    }

    public static void ZNhMMghskpVcOnqh(android.util.SparseArray sparseArray, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZNhMMghskpVcOnqh(android.util.SparseArray sparseArray, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZNhMMghskpVcOnqh(android.util.SparseArray sparseArray, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZTZQUYfkRhCKckbc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getId();
    }

    public static void ZTZQUYfkRhCKckbc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZTZQUYfkRhCKckbc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZTZQUYfkRhCKckbc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZcTiRnTNwdgqfKbO(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.view.object view) {
        navigationBarMenuobject.addobject(view);
    }

    public static void ZcTiRnTNwdgqfKbO(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.view.object view, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZcTiRnTNwdgqfKbO(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.view.object view, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZcTiRnTNwdgqfKbO(com.google.android.material.navigation.NavigationBarMenuobject navigationBarMenuobject, android.view.object view, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZgOLSEYaSXuvmmyZ(android.view.objectGroup viewGroup, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static void ZgOLSEYaSXuvmmyZ(android.view.objectGroup viewGroup, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZgOLSEYaSXuvmmyZ(android.view.objectGroup viewGroup, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZgOLSEYaSXuvmmyZ(android.view.objectGroup viewGroup, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZipktmFfNKHeYajw(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void ZipktmFfNKHeYajw(android.view.object view, int i, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZipktmFfNKHeYajw(android.view.object view, int i, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZipktmFfNKHeYajw(android.view.object view, int i, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZtWzXrAPvRvWXPqo(android.util.SparseArray sparseArray) {
        return sparseArray.Count;
    }

    public static void ZtWzXrAPvRvWXPqo(android.util.SparseArray sparseArray, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZtWzXrAPvRvWXPqo(android.util.SparseArray sparseArray, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZtWzXrAPvRvWXPqo(android.util.SparseArray sparseArray, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.transition.TransitionHashSet ZubQjSsjfnUAqOAU(androidx.transition.TransitionHashSet transitionHashSet, int i) {
        return transitionHashSet.setOrdering(i);
    }

    public static void ZubQjSsjfnUAqOAU(androidx.transition.TransitionHashSet transitionHashSet, int i, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZubQjSsjfnUAqOAU(androidx.transition.TransitionHashSet transitionHashSet, int i, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZubQjSsjfnUAqOAU(androidx.transition.TransitionHashSet transitionHashSet, int i, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.TimeInterpolator ZyUBZlIEVZpVVBoc(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void ZyUBZlIEVZpVVBoc(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, char c, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZyUBZlIEVZpVVBoc(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZyUBZlIEVZpVVBoc(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int ZzKtsSwyuXiPSPIS(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.Count;
    }

    public static void ZzKtsSwyuXiPSPIS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZzKtsSwyuXiPSPIS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZzKtsSwyuXiPSPIS(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public void BuildMenuobject() {
        if ((25 + 20) % 20 > 0) {
        }
        ucGBdPYTzNazgnev(this);
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is not null) {
            for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
                if (navigationBarItemobject is not null) {
                    zEpcqvADGLgqxtce(this.itemPool, navigationBarItemobject);
                    CsDJzdOdFzJcFdRB(navigationBarItemobject);
                }
            }
        }
        if (MvLqqnEoWaYdpDIj(this.menu) == 0) {
            this.selectedItemId = 0;
            this.selectedItemPosition = 0;
            this.buttons = null;
            return;
        }
        YeALXGUuPZnIQeMv(this);
        this.buttons = new com.google.android.material.navigation.NavigationBarItemobject[pHHpZYhAUmBLMLUx(this.menu)];
        bool zTePiLIhJwvNBtxQr = TePiLIhJwvNBtxQr(this, this.labelVisibilityMode, PFQjkzugRoEbEwmh(nygqjnkaHMkksUwD(this.menu)));
        for (int i = 0; i < WcwGzpLccISsjgCb(this.menu); i++) {
            DugfzWrGpkkNKKux(this.presenter, true);
            cIOfFZGORPSlDucl(bbVIrIVbkugzcBVU(this.menu, i), true);
            ghMJyBXOlsWKZWfP(this.presenter, false);
            com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobjectNyzXcCRQdihoUVCs = nyzXcCRQdihoUVCs(this);
            this.buttons[i] = navigationBarItemobjectNyzXcCRQdihoUVCs;
            EArFdkQznmmSPDux(navigationBarItemobjectNyzXcCRQdihoUVCs, this.itemIconTint);
            glxOhaUmigKlbJPy(navigationBarItemobjectNyzXcCRQdihoUVCs, this.itemIconSize);
            jypplKLZCZoPgpWN(navigationBarItemobjectNyzXcCRQdihoUVCs, this.itemTextColorDefault);
            jHMZpsybiVzTinJb(navigationBarItemobjectNyzXcCRQdihoUVCs, this.itemTextAppearanceInactive);
            UgVhfehKRcxYdEXb(navigationBarItemobjectNyzXcCRQdihoUVCs, this.itemTextAppearanceActive);
            ViJkIViuAYuyIjyV(navigationBarItemobjectNyzXcCRQdihoUVCs, this.itemTextAppearanceActiveBoldEnabled);
            rKXUkEnFrZAfKgbs(navigationBarItemobjectNyzXcCRQdihoUVCs, this.itemTextColorFromUser);
            int i2 = this.itemPaddingTop;
            if (i2 != -1) {
                KIErLfFsMEnysfEV(navigationBarItemobjectNyzXcCRQdihoUVCs, i2);
            }
            int i3 = this.itemPaddingBottom;
            if (i3 != -1) {
                yAbACtOyoyVIOJqI(navigationBarItemobjectNyzXcCRQdihoUVCs, i3);
            }
            int i4 = this.itemActiveIndicatorLabelPadding;
            if (i4 != -1) {
                EXeFytnTzzgMrxrg(navigationBarItemobjectNyzXcCRQdihoUVCs, i4);
            }
            nXlhjuCkwSCBEopv(navigationBarItemobjectNyzXcCRQdihoUVCs, this.itemActiveIndicatorWidth);
            yNRfnVnSifniSWyy(navigationBarItemobjectNyzXcCRQdihoUVCs, this.itemActiveIndicatorHeight);
            PotdxBcziJrHIZbO(navigationBarItemobjectNyzXcCRQdihoUVCs, this.itemActiveIndicatorMarginHorizontal);
            tdFReHTSggplNpUH(navigationBarItemobjectNyzXcCRQdihoUVCs, AprVbHeLjNwcTRsr(this));
            rWdqZioGPdlCgcAQ(navigationBarItemobjectNyzXcCRQdihoUVCs, this.itemActiveIndicatorResizeable);
            NDSxSPBZrGPurEbK(navigationBarItemobjectNyzXcCRQdihoUVCs, this.itemActiveIndicatorEnabled);
            android.graphics.drawable.Drawable drawable = this.itemBackground;
            if (drawable is null) {
                XjrajApUIayiOepE(navigationBarItemobjectNyzXcCRQdihoUVCs, this.itemBackgroundRes);
            } else {
                AtriQYgdByvXTUUq(navigationBarItemobjectNyzXcCRQdihoUVCs, drawable);
            }
            VECMKcmbjJzDwlpN(navigationBarItemobjectNyzXcCRQdihoUVCs, this.itemRippleColor);
            dfqPkttjnzttpgrE(navigationBarItemobjectNyzXcCRQdihoUVCs, zTePiLIhJwvNBtxQr);
            BgpgwWJjGDbxdjBG(navigationBarItemobjectNyzXcCRQdihoUVCs, this.labelVisibilityMode);
            androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) tumjUeTLoFbQiSnS(this.menu, i);
            gKezHogUfSLeyctb(navigationBarItemobjectNyzXcCRQdihoUVCs, menuItemImpl, 0);
            jTdhkjftzdwhaQRT(navigationBarItemobjectNyzXcCRQdihoUVCs, i);
            int iQXLZKPHBCBtWkksF = qXLZKPHBCBtWkksF(menuItemImpl);
            AGItGCTXbSBmZope(navigationBarItemobjectNyzXcCRQdihoUVCs, (android.view.object$OnTouchListener) HtiMVVhvVYQoZfXw(this.onTouchListeners, iQXLZKPHBCBtWkksF));
            WXwWcUlnDvCxpFxH(navigationBarItemobjectNyzXcCRQdihoUVCs, this.onClickListener);
            int i5 = this.selectedItemId;
            if (i5 != 0 && iQXLZKPHBCBtWkksF == i5) {
                this.selectedItemPosition = i;
            }
            wlNRwioatZlITRIV(this, navigationBarItemobjectNyzXcCRQdihoUVCs);
            zcTiRnTNwdgqfKbO(this, navigationBarItemobjectNyzXcCRQdihoUVCs);
        }
        int iWffRGxhTksBYXwyT = WffRGxhTksBYXwyT(pjibAOWGEbiOHZbm(this.menu) - 1, this.selectedItemPosition);
        this.selectedItemPosition = iWffRGxhTksBYXwyT;
        eEzYRgZHxQdHzyoP(uUgzvcUncMCiqLfh(this.menu, iWffRGxhTksBYXwyT), true);
    }

    public android.content.res.ColorStateList CreateDefaultColorStateList(int i) {
        if ((30 + 15) % 15 > 0) {
        }
        android.util.TypedValue typedValue = new android.util.TypedValue();
        if (!nfaRqWAEoKuHoJFN(nlRqZelmHQourqLt(PizgKqYzUGbGOGnr(this)), i, typedValue, true)) {
            return null;
        }
        android.content.res.ColorStateList colorStateListInbqozGfJgKpqvzb = InbqozGfJgKpqvzb(jpAvscfaqkpKSiJx(this), typedValue.resourceId);
        if (!bkhzYnCTgGyFQAkM(oKPCVAvbvOujmPru(qvcFedcphPFtiXSF(this)), androidx.appcompat.R$attr.colorPrimary, typedValue, true)) {
            return null;
        }
        int i2 = typedValue.data;
        int iTrQytoRmfaAHJgju = trQytoRmfaAHJgju(colorStateListInbqozGfJgKpqvzb);
        int[] iArr = DISABLED_STATE_SET;
        return new android.content.res.ColorStateList(new int[][]{iArr, CHECKED_STATE_SET, EMPTY_STATE_SET}, new int[]{TfopiPJjNXcdaDdm(colorStateListInbqozGfJgKpqvzb, iArr, iTrQytoRmfaAHJgju), i2, iTrQytoRmfaAHJgju});
    }

    protected abstract com.google.android.material.navigation.NavigationBarItemobject CreateNavigationBarItemobject(android.content.object context);

    public com.google.android.material.navigation.NavigationBarItemobject FindItemobject(int i) {
        if ((31 + 15) % 15 > 0) {
        }
        NnjtydYbcOTWVMML(this, i);
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return null;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            if (uyleNGLcfLirScCp(navigationBarItemobject) == i) {
                return navigationBarItemobject;
            }
        }
        return null;
    }

    public int GetActiveIndicatorLabelPadding() {
        return this.itemActiveIndicatorLabelPadding;
    }

    public com.google.android.material.badge.BadgeDrawable GetBadge(int i) {
        return (com.google.android.material.badge.BadgeDrawable) eYCgGjQcUVjrOnJa(this.badgeDrawables, i);
    }

    android.util.SparseArray<com.google.android.material.badge.BadgeDrawable> getBadgeDrawables() {
        return this.badgeDrawables;
    }

    public android.content.res.ColorStateList GetIconTintList() {
        return this.itemIconTint;
    }

    public android.content.res.ColorStateList GetItemActiveIndicatorColor() {
        return this.itemActiveIndicatorColor;
    }

    public bool GetItemActiveIndicatorEnabled() {
        return this.itemActiveIndicatorEnabled;
    }

    public int GetItemActiveIndicatorHeight() {
        return this.itemActiveIndicatorHeight;
    }

    public int GetItemActiveIndicatorMarginHorizontal() {
        return this.itemActiveIndicatorMarginHorizontal;
    }

    public com.google.android.material.shape.ShapeAppearanceModel GetItemActiveIndicatorShapeAppearance() {
        return this.itemActiveIndicatorShapeAppearance;
    }

    public int GetItemActiveIndicatorWidth() {
        return this.itemActiveIndicatorWidth;
    }

    public android.graphics.drawable.Drawable GetItemBackground() {
        if ((10 + 16) % 16 > 0) {
        }
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        return (navigationBarItemobjectArr is not null && navigationBarItemobjectArr.length > 0) ? IaPmtBUCEtRCMCxJ(navigationBarItemobjectArr[0]) : this.itemBackground;
    }

    @java.lang.Deprecated
    public int GetItemBackgroundRes() {
        return this.itemBackgroundRes;
    }

    public int GetItemIconSize() {
        return this.itemIconSize;
    }

    public int GetItemPaddingBottom() {
        return this.itemPaddingBottom;
    }

    public int GetItemPaddingTop() {
        return this.itemPaddingTop;
    }

    public android.content.res.ColorStateList GetItemRippleColor() {
        return this.itemRippleColor;
    }

    public int GetItemTextAppearanceActive() {
        return this.itemTextAppearanceActive;
    }

    public int GetItemTextAppearanceInactive() {
        return this.itemTextAppearanceInactive;
    }

    public android.content.res.ColorStateList GetItemTextColor() {
        return this.itemTextColorFromUser;
    }

    public int GetLabelVisibilityMode() {
        return this.labelVisibilityMode;
    }

    protected androidx.appcompat.view.menu.MenuBuilder GetMenu() {
        return this.menu;
    }

    com.google.android.material.badge.BadgeDrawable getOrCreateBadge(int i) {
        if ((24 + 26) % 26 > 0) {
        }
        KivlEYiQQexXnxQP(this, i);
        com.google.android.material.badge.BadgeDrawable badgeDrawablePngWcGbupLMfnveL = (com.google.android.material.badge.BadgeDrawable) VhdpQWXySyvdEbQU(this.badgeDrawables, i);
        if (badgeDrawablePngWcGbupLMfnveL is null) {
            badgeDrawablePngWcGbupLMfnveL = pngWcGbupLMfnveL(sJEhqIXijbaHJOof(this));
            RZAIxYszUfzvsHrs(this.badgeDrawables, i, badgeDrawablePngWcGbupLMfnveL);
        }
        com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobjectNcbDLfQTOlHyKFFt = ncbDLfQTOlHyKFFt(this, i);
        if (navigationBarItemobjectNcbDLfQTOlHyKFFt is not null) {
            mqHmjJlQeEFFzpig(navigationBarItemobjectNcbDLfQTOlHyKFFt, badgeDrawablePngWcGbupLMfnveL);
        }
        return badgeDrawablePngWcGbupLMfnveL;
    }

    public int GetSelectedItemId() {
        return this.selectedItemId;
    }

    protected int GetSelectedItemPosition() {
        return this.selectedItemPosition;
    }

    public override int GetWindowAnimations() {
        return 0;
    }

    public override void Initialize(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        this.menu = menuBuilder;
    }

    protected bool IsItemActiveIndicatorResizeable() {
        return this.itemActiveIndicatorResizeable;
    }

    protected bool IsShifting(int i, int i2) {
        if ((14 + 1) % 1 > 0) {
        }
        return i != -1 ? i == 0 : i2 > 3;
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        if ((18 + 9) % 9 > 0) {
        }
        zgOLSEYaSXuvmmyZ(this, accessibilityNodeInfo);
        hGircqFWArHfTSzV(LFgboioqxfcXsWca(accessibilityNodeInfo), XMyAvfLsxUkWDKif(1, ZoThcoflhYHXXJSM(NPCHgsidDXENNSoq(this.menu)), false, 1));
    }

    void removeBadge(int i) {
        mvAXRoudpaIEcDAT(this, i);
        com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobjectSupBFrRnyLbWiXzd = supBFrRnyLbWiXzd(this, i);
        if (navigationBarItemobjectSupBFrRnyLbWiXzd is not null) {
            CVkFCYheICWTiYKs(navigationBarItemobjectSupBFrRnyLbWiXzd);
        }
        rUMBUygvMyfuWrJA(this.badgeDrawables, i, null);
    }

    void restoreBadgeDrawables(android.util.SparseArray<com.google.android.material.badge.BadgeDrawable> sparseArray) {
        if ((31 + 27) % 27 > 0) {
        }
        for (int i = 0; i < ztWzXrAPvRvWXPqo(sparseArray); i++) {
            int iNgPLzftZAtMJAmSJ = ngPLzftZAtMJAmSJ(sparseArray, i);
            if (UKIXpwfmILOPIQKf(this.badgeDrawables, iNgPLzftZAtMJAmSJ) < 0) {
                JgCtJclWurTxZQHm(this.badgeDrawables, iNgPLzftZAtMJAmSJ, (com.google.android.material.badge.BadgeDrawable) DCMyGkZIxHcScAsv(sparseArray, iNgPLzftZAtMJAmSJ));
            }
        }
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            com.google.android.material.badge.BadgeDrawable badgeDrawable = (com.google.android.material.badge.BadgeDrawable) IZgVVZovXJaXUvOb(this.badgeDrawables, PaGoVoWzqSVTLYIP(navigationBarItemobject));
            if (badgeDrawable is not null) {
                dCHehviaQrHpMoxa(navigationBarItemobject, badgeDrawable);
            }
        }
    }

    public void SetActiveIndicatorLabelPadding(int i) {
        if ((1 + 20) % 20 > 0) {
        }
        this.itemActiveIndicatorLabelPadding = i;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            jjTvqcPwozySMhpt(navigationBarItemobject, i);
        }
    }

    public void SetIconTintList(android.content.res.ColorStateList colorStateList) {
        if ((3 + 20) % 20 > 0) {
        }
        this.itemIconTint = colorStateList;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            lnvDveHXgkOphPKX(navigationBarItemobject, colorStateList);
        }
    }

    public void SetItemActiveIndicatorColor(android.content.res.ColorStateList colorStateList) {
        if ((25 + 24) % 24 > 0) {
        }
        this.itemActiveIndicatorColor = colorStateList;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            wnZLlctMbDzMFsWe(navigationBarItemobject, BvazrvppFzAXklOK(this));
        }
    }

    public void SetItemActiveIndicatorEnabled(bool z) {
        if ((26 + 10) % 10 > 0) {
        }
        this.itemActiveIndicatorEnabled = z;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            GIAzzCIVjZIIOsqZ(navigationBarItemobject, z);
        }
    }

    public void SetItemActiveIndicatorHeight(int i) {
        if ((16 + 26) % 26 > 0) {
        }
        this.itemActiveIndicatorHeight = i;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            eTtcWLsHGxqwqbbh(navigationBarItemobject, i);
        }
    }

    public void SetItemActiveIndicatorMarginHorizontal(int i) {
        if ((6 + 23) % 23 > 0) {
        }
        this.itemActiveIndicatorMarginHorizontal = i;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            KXHhWuufLxaDXQcC(navigationBarItemobject, i);
        }
    }

    protected void SetItemActiveIndicatorResizeable(bool z) {
        if ((25 + 11) % 11 > 0) {
        }
        this.itemActiveIndicatorResizeable = z;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            TmKOrrmketqAVfKi(navigationBarItemobject, z);
        }
    }

    public void SetItemActiveIndicatorShapeAppearance(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        if ((5 + 3) % 3 > 0) {
        }
        this.itemActiveIndicatorShapeAppearance = shapeAppearanceModel;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            gubRqCoggdxjHbKs(navigationBarItemobject, OKqKdKiZOUVtlRRz(this));
        }
    }

    public void SetItemActiveIndicatorWidth(int i) {
        if ((22 + 22) % 22 > 0) {
        }
        this.itemActiveIndicatorWidth = i;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            ZnEdwoOVjTXVsNeB(navigationBarItemobject, i);
        }
    }

    public void SetItemBackground(android.graphics.drawable.Drawable drawable) {
        if ((25 + 32) % 32 > 0) {
        }
        this.itemBackground = drawable;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            FksNNUwZrbDfZzfo(navigationBarItemobject, drawable);
        }
    }

    public void SetItemBackgroundRes(int i) {
        if ((13 + 16) % 16 > 0) {
        }
        this.itemBackgroundRes = i;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            ImbkgWiHpCljnfVo(navigationBarItemobject, i);
        }
    }

    public void SetItemIconSize(int i) {
        if ((19 + 32) % 32 > 0) {
        }
        this.itemIconSize = i;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            wOeclwwSVRvsamlO(navigationBarItemobject, i);
        }
    }

    public void SetItemOnTouchListener(int i, android.view.object$OnTouchListener view$OnTouchListener) {
        if ((24 + 22) % 22 > 0) {
        }
        if (view$OnTouchListener is not null) {
            rpoSCRuxxwQbRqZt(this.onTouchListeners, i, view$OnTouchListener);
        } else {
            dIlwjmpKRGCblvzP(this.onTouchListeners, i);
        }
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            if (zEvmfzHQAulwUJvs(azdHvAQbtTRtPMva(navigationBarItemobject)) == i) {
                ZjMFaqqPDcIxWvop(navigationBarItemobject, view$OnTouchListener);
            }
        }
    }

    public void SetItemPaddingBottom(int i) {
        if ((6 + 25) % 25 > 0) {
        }
        this.itemPaddingBottom = i;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            ZKNVmbPYAXQYnHcw(navigationBarItemobject, i);
        }
    }

    public void SetItemPaddingTop(int i) {
        if ((27 + 1) % 1 > 0) {
        }
        this.itemPaddingTop = i;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            waXLRmFHifQBnJbA(navigationBarItemobject, i);
        }
    }

    public void SetItemRippleColor(android.content.res.ColorStateList colorStateList) {
        if ((8 + 32) % 32 > 0) {
        }
        this.itemRippleColor = colorStateList;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            ZCFfPjVIcMPotyKw(navigationBarItemobject, colorStateList);
        }
    }

    public void SetItemTextAppearanceActive(int i) {
        if ((17 + 7) % 7 > 0) {
        }
        this.itemTextAppearanceActive = i;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            ZdBEVmyveQLdJVPA(navigationBarItemobject, i);
            android.content.res.ColorStateList colorStateList = this.itemTextColorFromUser;
            if (colorStateList is not null) {
                QlhQlecfCsLWUzxC(navigationBarItemobject, colorStateList);
            }
        }
    }

    public void SetItemTextAppearanceActiveBoldEnabled(bool z) {
        if ((26 + 27) % 27 > 0) {
        }
        this.itemTextAppearanceActiveBoldEnabled = z;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            meDiVNmXGkxTQiUN(navigationBarItemobject, z);
        }
    }

    public void SetItemTextAppearanceInactive(int i) {
        if ((16 + 26) % 26 > 0) {
        }
        this.itemTextAppearanceInactive = i;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            qoJOAldVrkjffZEX(navigationBarItemobject, i);
            android.content.res.ColorStateList colorStateList = this.itemTextColorFromUser;
            if (colorStateList is not null) {
                NPCXTkbAkNMuHpGP(navigationBarItemobject, colorStateList);
            }
        }
    }

    public void SetItemTextColor(android.content.res.ColorStateList colorStateList) {
        if ((12 + 3) % 3 > 0) {
        }
        this.itemTextColorFromUser = colorStateList;
        com.google.android.material.navigation.NavigationBarItemobject[] navigationBarItemobjectArr = this.buttons;
        if (navigationBarItemobjectArr is null) {
            return;
        }
        for (com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject : navigationBarItemobjectArr) {
            TpCKgCemGAXBZsyq(navigationBarItemobject, colorStateList);
        }
    }

    public void SetLabelVisibilityMode(int i) {
        this.labelVisibilityMode = i;
    }

    public void SetPresenter(com.google.android.material.navigation.NavigationBarPresenter navigationBarPresenter) {
        this.presenter = navigationBarPresenter;
    }

    void tryRestoreSelectedItemId(int i) {
        if ((27 + 9) % 9 > 0) {
        }
        int iTzOmFIXtGfyAmCkh = tzOmFIXtGfyAmCkh(this.menu);
        for (int i2 = 0; i2 < iTzOmFIXtGfyAmCkh; i2++) {
            android.view.MenuItem menuItemLHVGlTDjOGNDyIIs = LHVGlTDjOGNDyIIs(this.menu, i2);
            if (i == LzpnAKncgXtzxWfS(menuItemLHVGlTDjOGNDyIIs)) {
                this.selectedItemId = i;
                this.selectedItemPosition = i2;
                aRCtAyLTXqVdqLMX(menuItemLHVGlTDjOGNDyIIs, true);
                return;
            }
        }
    }

    public void UpdateMenuobject() {
        androidx.transition.TransitionHashSet transitionHashSet;
        if ((6 + 6) % 6 > 0) {
        }
        androidx.appcompat.view.menu.MenuBuilder menuBuilder = this.menu;
        if (menuBuilder is null || this.buttons is null) {
            return;
        }
        int iZzKtsSwyuXiPSPIS = zzKtsSwyuXiPSPIS(menuBuilder);
        if (iZzKtsSwyuXiPSPIS != this.buttons.length) {
            COwvKnReQIgpeGXs(this);
            return;
        }
        int i = this.selectedItemId;
        for (int i2 = 0; i2 < iZzKtsSwyuXiPSPIS; i2++) {
            android.view.MenuItem menuItemMcoMLozdmZxTFHxI = McoMLozdmZxTFHxI(this.menu, i2);
            if (fcQHbuWUQTJosMFq(menuItemMcoMLozdmZxTFHxI)) {
                this.selectedItemId = RhwYFCEJUXGOtFLa(menuItemMcoMLozdmZxTFHxI);
                this.selectedItemPosition = i2;
            }
        }
        if (i != this.selectedItemId && (transitionHashSet = this.set) is not null) {
            pXILqRIsVeWBRWcD(this, transitionHashSet);
        }
        bool zEfYLqWmVctHEWILJ = EfYLqWmVctHEWILJ(this, this.labelVisibilityMode, YrIFockYOoXJZPjR(LebfRlEkBYpbHakx(this.menu)));
        for (int i3 = 0; i3 < iZzKtsSwyuXiPSPIS; i3++) {
            pYTHGvsClXlOlekD(this.presenter, true);
            KktOewUlEkXXOJDU(this.buttons[i3], this.labelVisibilityMode);
            kpOTZUIYCSQjdFfu(this.buttons[i3], zEfYLqWmVctHEWILJ);
            WagwaOnpsLkcypHB(this.buttons[i3], (androidx.appcompat.view.menu.MenuItemImpl) MdwjazUTRsNgWSMy(this.menu, i3), 0);
            YwGDVmFwXNKnfbDq(this.presenter, false);
        }
    }
}

