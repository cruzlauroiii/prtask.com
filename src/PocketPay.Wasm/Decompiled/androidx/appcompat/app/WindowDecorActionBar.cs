namespace WillowMaze.Wasm.Decompiled;


public class WindowDecorActionBar : androidx.appcompat.app.ActionBar : androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback {
    private static readonly long FADE_IN_DURATION_MS = 200;
    private static readonly long FADE_OUT_DURATION_MS = 100;
    private static readonly int INVALID_POSITION = -1;
    private static readonly java.lang.string TAG = "WindowDecorActionBar";
    private static readonly android.view.animation.Interpolator sHideInterpolator = new android.view.animation.AccelerateInterpolator();
    private static readonly android.view.animation.Interpolator sShowInterpolator = new android.view.animation.DecelerateInterpolator();
    androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl mActionMode;
    private android.app.object mobject;
    androidx.appcompat.widget.ActionBarContainer mContainerobject;
    android.view.object mContentobject;
    android.content.object mobject;
    androidx.appcompat.widget.ActionBarobjectobject mobjectobject;
    androidx.appcompat.view.objectPropertyAnimatorCompatHashSet mCurrentShowAnim;
    androidx.appcompat.widget.DecorToolbar mDecorToolbar;
    androidx.appcompat.view.ActionMode mDeferredDestroyActionMode;
    androidx.appcompat.view.ActionMode$Callback mDeferredModeDestroyCallback;
    private bool mDisplayHomeAsUpHashSet;
    private bool mHasEmbeddedTabs;
    bool mHiddenByApp;
    bool mHiddenBySystem;
    bool mHideOnContentScroll;
    private bool mLastMenuVisibility;
    androidx.appcompat.widget.ActionBarOverlayLayout mOverlayLayout;
    private androidx.appcompat.app.WindowDecorActionBar$TabImpl mSelectedTab;
    private bool mShowHideAnimationEnabled;
    private bool mShowingForMode;
    androidx.appcompat.widget.ScrollingTabContainerobject mTabScrollobject;
    private android.content.object mThemedobject;
    private java.util.List<androidx.appcompat.app.WindowDecorActionBar$TabImpl> mTabs = new java.util.List<>();
    private int mSavedTabPosition = -1;
    private java.util.List<androidx.appcompat.app.ActionBar$OnMenuVisibilityListener> mMenuVisibilityListeners = new java.util.List<>();
    private int mCurWindowVisibility = 0;
    bool mContentAnimations = true;
    private bool mNowShowing = true;
    readonly androidx.core.view.objectPropertyAnimatorListener mHideListener = new androidx.appcompat.app.WindowDecorActionBar$1(this);
    readonly androidx.core.view.objectPropertyAnimatorListener mShowListener = new androidx.appcompat.app.WindowDecorActionBar$2(this);
    readonly androidx.core.view.objectPropertyAnimatorUpdateListener mUpdateListener = new androidx.appcompat.app.WindowDecorActionBar$3(this);

    public WindowDecorActionBar(android.app.object activity, bool z) {
        this.mobject = activity;
        android.view.object viewVEfTkXATgkgTnnGH = VEfTkXATgkgTnnGH(OabyrbHHOwYtMMZD(activity));
        yFnIvgdOHoDhbELi(this, viewVEfTkXATgkgTnnGH);
        if (z) {
            return;
        }
        this.mContentobject = spewhQRyUzhqYxuO(viewVEfTkXATgkgTnnGH, 16908290);
    }

    public WindowDecorActionBar(android.app.Dialog dialog) {
        snEqvfEucSMJaiWh(this, sfdJaizelLtouFgG(UcxUVSiFmkkNjHmW(dialog)));
    }

    public WindowDecorActionBar(android.view.object view) {
        YAzqpoJtTWZFcxjI(this, view);
    }

    public static androidx.core.view.objectPropertyAnimatorCompat AKViteDILelUMTRo(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, long j) {
        return decorToolbar.setupAnimatorToVisibility(i, j);
    }

    public static void AKViteDILelUMTRo(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, long j, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AKViteDILelUMTRo(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, long j, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AKViteDILelUMTRo(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, long j, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object AQcGWKhxQYGcswbP(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobject();
    }

    public static void AQcGWKhxQYGcswbP(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AQcGWKhxQYGcswbP(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AQcGWKhxQYGcswbP(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int AlIQzYztaMhhTnXm(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        return windowDecorActionBar.getNavigationMode();
    }

    public static void AlIQzYztaMhhTnXm(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AlIQzYztaMhhTnXm(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AlIQzYztaMhhTnXm(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AnXclOSWISQoSdAg(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i) {
        windowDecorActionBar.removeTabAt(i);
    }

    public static void AnXclOSWISQoSdAg(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AnXclOSWISQoSdAg(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AnXclOSWISQoSdAg(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AqAAhQdOhicNVcCa(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        decorToolbar.setEmbeddedTabobject(scrollingTabContainerobject);
    }

    public static void AqAAhQdOhicNVcCa(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AqAAhQdOhicNVcCa(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AqAAhQdOhicNVcCa(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AxdSRULlNCoBVCvv(androidx.appcompat.view.ActionMode$Callback actionMode$Callback, androidx.appcompat.view.ActionMode actionMode) {
        actionMode$Callback.onDestroyActionMode(actionMode);
    }

    public static void AxdSRULlNCoBVCvv(androidx.appcompat.view.ActionMode$Callback actionMode$Callback, androidx.appcompat.view.ActionMode actionMode, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AxdSRULlNCoBVCvv(androidx.appcompat.view.ActionMode$Callback actionMode$Callback, androidx.appcompat.view.ActionMode actionMode, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AxdSRULlNCoBVCvv(androidx.appcompat.view.ActionMode$Callback actionMode$Callback, androidx.appcompat.view.ActionMode actionMode, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int AyRPJnEOAmTNiIQz(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getDisplayOptions();
    }

    public static void AyRPJnEOAmTNiIQz(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AyRPJnEOAmTNiIQz(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AyRPJnEOAmTNiIQz(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BABuWzHJuOOEqbjM(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence) {
        decorToolbar.setWindowTitle(charSequence);
    }

    public static void BABuWzHJuOOEqbjM(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BABuWzHJuOOEqbjM(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BABuWzHJuOOEqbjM(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BGuNuxMvfYzBkSzo(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.graphics.drawable.Drawable drawable) {
        actionBarContainer.setStackedBackground(drawable);
    }

    public static void BGuNuxMvfYzBkSzo(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.graphics.drawable.Drawable drawable, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BGuNuxMvfYzBkSzo(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.graphics.drawable.Drawable drawable, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BGuNuxMvfYzBkSzo(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.graphics.drawable.Drawable drawable, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.objectPropertyAnimatorCompat BLoxTOaqKtqxabuL(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorUpdateListener viewPropertyAnimatorUpdateListener) {
        return viewPropertyAnimatorCompat.setUpdateListener(viewPropertyAnimatorUpdateListener);
    }

    public static void BLoxTOaqKtqxabuL(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorUpdateListener viewPropertyAnimatorUpdateListener, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BLoxTOaqKtqxabuL(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorUpdateListener viewPropertyAnimatorUpdateListener, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BLoxTOaqKtqxabuL(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorUpdateListener viewPropertyAnimatorUpdateListener, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BNrAbGspSQatKpLt(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int[] iArr) {
        actionBarContainer.getLocationInWindow(iArr);
    }

    public static void BNrAbGspSQatKpLt(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int[] iArr, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BNrAbGspSQatKpLt(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int[] iArr, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BNrAbGspSQatKpLt(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int[] iArr, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BaPdUDfFkRavRtgN(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        actionBarobjectobject.killMode();
    }

    public static void BaPdUDfFkRavRtgN(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BaPdUDfFkRavRtgN(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BaPdUDfFkRavRtgN(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BdUYHEymDmRZKaYU(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.animateToTab(i);
    }

    public static void BdUYHEymDmRZKaYU(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, int i2, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BdUYHEymDmRZKaYU(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, java.lang.string str, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BdUYHEymDmRZKaYU(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, bool z, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CrSzPEZBmTViMrHX(android.view.Menu menu, bool z) {
        menu.setQwertyMode(z);
    }

    public static void CrSzPEZBmTViMrHX(android.view.Menu menu, bool z, char c, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CrSzPEZBmTViMrHX(android.view.Menu menu, bool z, java.lang.string str, bool z2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CrSzPEZBmTViMrHX(android.view.Menu menu, bool z, short s, java.lang.string str, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CyuAcZEypwLAKNzG(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.setVisibility(i);
    }

    public static void CyuAcZEypwLAKNzG(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CyuAcZEypwLAKNzG(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CyuAcZEypwLAKNzG(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder DQLnFOkkGWIIDpCg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DQLnFOkkGWIIDpCg(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DQLnFOkkGWIIDpCg(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DQLnFOkkGWIIDpCg(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DRihNGRobUUNNkFA(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        windowDecorActionBar.selectTab(actionBar$Tab);
    }

    public static void DRihNGRobUUNNkFA(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DRihNGRobUUNNkFA(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DRihNGRobUUNNkFA(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DYcGCHRXuIXjCGfN(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        return actionBar$Tab.getPosition();
    }

    public static void DYcGCHRXuIXjCGfN(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DYcGCHRXuIXjCGfN(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DYcGCHRXuIXjCGfN(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DgSPdhkDTVQKUXvt(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i) {
        windowDecorActionBar.configureTab(actionBar$Tab, i);
    }

    public static void DgSPdhkDTVQKUXvt(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DgSPdhkDTVQKUXvt(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DgSPdhkDTVQKUXvt(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DnOXAGgNvNIoUDnp(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z) {
        decorToolbar.setHomeButtonEnabled(z);
    }

    public static void DnOXAGgNvNIoUDnp(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DnOXAGgNvNIoUDnp(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DnOXAGgNvNIoUDnp(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DzVrUmCxmANBVKbi(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        decorToolbar.setEmbeddedTabobject(scrollingTabContainerobject);
    }

    public static void DzVrUmCxmANBVKbi(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DzVrUmCxmANBVKbi(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DzVrUmCxmANBVKbi(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EMUZbQHVBbbVuEva(java.util.List arrayList, java.lang.object obj, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EMUZbQHVBbbVuEva(java.util.List arrayList, java.lang.object obj, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EMUZbQHVBbbVuEva(java.util.List arrayList, java.lang.object obj, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool EMUZbQHVBbbVuEva(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static void ENCYcIBCwMQLMjse(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2) {
        windowDecorActionBar.setDisplayOptions(i, i2);
    }

    public static void ENCYcIBCwMQLMjse(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, char c, float f, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ENCYcIBCwMQLMjse(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, char c, int i3, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ENCYcIBCwMQLMjse(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, int i3, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class EUbcTdWURqIWHoWm(java.lang.object obj) {
        return obj.GetType();
    }

    public static void EUbcTdWURqIWHoWm(java.lang.object obj, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EUbcTdWURqIWHoWm(java.lang.object obj, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EUbcTdWURqIWHoWm(java.lang.object obj, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ExdLQqZmXphuZQKK(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ExdLQqZmXphuZQKK(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ExdLQqZmXphuZQKK(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ExdLQqZmXphuZQKK(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.hasExpandedActionobject();
    }

    public static void FAiOnVRUhEOccCoE(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.setVisibility(i);
    }

    public static void FAiOnVRUhEOccCoE(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FAiOnVRUhEOccCoE(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FAiOnVRUhEOccCoE(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.objectPropertyAnimatorCompat FBxQtXkYLuYGfrGR(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, long j) {
        return actionBarobjectobject.setupAnimatorToVisibility(i, j);
    }

    public static void FBxQtXkYLuYGfrGR(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, long j, byte b, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FBxQtXkYLuYGfrGR(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, long j, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FBxQtXkYLuYGfrGR(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, long j, java.lang.string str, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FCxMKPNEgabFwtGD(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setDisplayOptions(i);
    }

    public static void FCxMKPNEgabFwtGD(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, int i2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FCxMKPNEgabFwtGD(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, int i2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FCxMKPNEgabFwtGD(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, java.lang.string str, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FQTUkixTCtxSPIcl(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable) {
        decorToolbar.setIcon(drawable);
    }

    public static void FQTUkixTCtxSPIcl(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FQTUkixTCtxSPIcl(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FQTUkixTCtxSPIcl(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup FZxZyJYKfdJclCTO(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobjectGroup();
    }

    public static void FZxZyJYKfdJclCTO(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FZxZyJYKfdJclCTO(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FZxZyJYKfdJclCTO(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FaoJQVzffGvSiQlv(androidx.appcompat.view.ActionBarPolicy actionBarPolicy, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FaoJQVzffGvSiQlv(androidx.appcompat.view.ActionBarPolicy actionBarPolicy, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FaoJQVzffGvSiQlv(androidx.appcompat.view.ActionBarPolicy actionBarPolicy, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool FaoJQVzffGvSiQlv(androidx.appcompat.view.ActionBarPolicy actionBarPolicy) {
        return actionBarPolicy.hasEmbeddedTabs();
    }

    public static void FjpCpUBxeubchmpo(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z) {
        windowDecorActionBar.updateVisibility(z);
    }

    public static void FjpCpUBxeubchmpo(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, byte b, char c, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FjpCpUBxeubchmpo(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, byte b, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FjpCpUBxeubchmpo(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, int i, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FliCfyYboDjlQCJH(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getHeight();
    }

    public static void FliCfyYboDjlQCJH(androidx.appcompat.widget.ActionBarContainer actionBarContainer, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FliCfyYboDjlQCJH(androidx.appcompat.widget.ActionBarContainer actionBarContainer, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FliCfyYboDjlQCJH(androidx.appcompat.widget.ActionBarContainer actionBarContainer, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FomdAHbyYnuWkGJj(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void FomdAHbyYnuWkGJj(java.util.List arrayList, int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FomdAHbyYnuWkGJj(java.util.List arrayList, int i, int i2, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FomdAHbyYnuWkGJj(java.util.List arrayList, int i, bool z, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GDnDDMmwiNqUxTii(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        windowDecorActionBar.hideForActionMode();
    }

    public static void GDnDDMmwiNqUxTii(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GDnDDMmwiNqUxTii(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GDnDDMmwiNqUxTii(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GDvdGgQGSnOecCun(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void GDvdGgQGSnOecCun(java.util.List arrayList, int i, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GDvdGgQGSnOecCun(java.util.List arrayList, int i, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GDvdGgQGSnOecCun(java.util.List arrayList, int i, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GEKIsNZnhlNhSJPe(androidx.appcompat.app.ActionBar$OnMenuVisibilityListener actionBar$OnMenuVisibilityListener, bool z) {
        actionBar$OnMenuVisibilityListener.onMenuVisibilityChanged(z);
    }

    public static void GEKIsNZnhlNhSJPe(androidx.appcompat.app.ActionBar$OnMenuVisibilityListener actionBar$OnMenuVisibilityListener, bool z, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GEKIsNZnhlNhSJPe(androidx.appcompat.app.ActionBar$OnMenuVisibilityListener actionBar$OnMenuVisibilityListener, bool z, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GEKIsNZnhlNhSJPe(androidx.appcompat.app.ActionBar$OnMenuVisibilityListener actionBar$OnMenuVisibilityListener, bool z, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int GEnPYkSPUSXOdTkB(androidx.fragment.app.objectTransaction fragmentTransaction) {
        return fragmentTransaction.commit();
    }

    public static void GEnPYkSPUSXOdTkB(androidx.fragment.app.objectTransaction fragmentTransaction, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GEnPYkSPUSXOdTkB(androidx.fragment.app.objectTransaction fragmentTransaction, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GEnPYkSPUSXOdTkB(androidx.fragment.app.objectTransaction fragmentTransaction, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GNjfIqEocxLmlYtM(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void GNjfIqEocxLmlYtM(android.content.res.TypedArray typedArray, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GNjfIqEocxLmlYtM(android.content.res.TypedArray typedArray, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GNjfIqEocxLmlYtM(android.content.res.TypedArray typedArray, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GYkGAHxmAFRURVWr(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2) {
        windowDecorActionBar.setDisplayOptions(i, i2);
    }

    public static void GYkGAHxmAFRURVWr(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, int i3, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GYkGAHxmAFRURVWr(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, short s, int i3, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GYkGAHxmAFRURVWr(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, short s, java.lang.string str, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GlzQBMTqvTCPNjvh(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        windowDecorActionBar.ensureTabsExist();
    }

    public static void GlzQBMTqvTCPNjvh(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GlzQBMTqvTCPNjvh(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GlzQBMTqvTCPNjvh(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GqpOihPFzcPqRygi(androidx.appcompat.widget.ActionBarContainer actionBarContainer, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        actionBarContainer.setTabContainer(scrollingTabContainerobject);
    }

    public static void GqpOihPFzcPqRygi(androidx.appcompat.widget.ActionBarContainer actionBarContainer, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GqpOihPFzcPqRygi(androidx.appcompat.widget.ActionBarContainer actionBarContainer, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GqpOihPFzcPqRygi(androidx.appcompat.widget.ActionBarContainer actionBarContainer, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HEqTYvTraMlnZbeG(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setIcon(i);
    }

    public static void HEqTYvTraMlnZbeG(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HEqTYvTraMlnZbeG(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HEqTYvTraMlnZbeG(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HFRbxFmkFgkqxIIp(android.view.Menu menu, int i, android.view.KeyEvent keyEvent, int i2, int i3, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HFRbxFmkFgkqxIIp(android.view.Menu menu, int i, android.view.KeyEvent keyEvent, int i2, short s, int i3, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HFRbxFmkFgkqxIIp(android.view.Menu menu, int i, android.view.KeyEvent keyEvent, int i2, short s, bool z, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static bool HFRbxFmkFgkqxIIp(android.view.Menu menu, int i, android.view.KeyEvent keyEvent, int i2) {
        return menu.performshortcut(i, keyEvent, i2);
    }

    public static int HHoWMcpsnHjBVMXe(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl) {
        return windowDecorActionBar$TabImpl.getPosition();
    }

    public static void HHoWMcpsnHjBVMXe(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HHoWMcpsnHjBVMXe(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HHoWMcpsnHjBVMXe(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class HdpenzhzxBBIoUaY(java.lang.object obj) {
        return obj.GetType();
    }

    public static void HdpenzhzxBBIoUaY(java.lang.object obj, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HdpenzhzxBBIoUaY(java.lang.object obj, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HdpenzhzxBBIoUaY(java.lang.object obj, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HsmDhteixxpZLDon(java.lang.Class cls) {
        return cls.getSimpleName();
    }

    public static void HsmDhteixxpZLDon(java.lang.Class cls, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HsmDhteixxpZLDon(java.lang.Class cls, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HsmDhteixxpZLDon(java.lang.Class cls, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IJiqsAzqHxrIXUoR(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet) {
        viewPropertyAnimatorCompatHashSet.cancel();
    }

    public static void IJiqsAzqHxrIXUoR(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IJiqsAzqHxrIXUoR(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IJiqsAzqHxrIXUoR(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ILIwgcBpplpHtjtY(androidx.appcompat.view.ActionBarPolicy actionBarPolicy, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ILIwgcBpplpHtjtY(androidx.appcompat.view.ActionBarPolicy actionBarPolicy, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ILIwgcBpplpHtjtY(androidx.appcompat.view.ActionBarPolicy actionBarPolicy, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool ILIwgcBpplpHtjtY(androidx.appcompat.view.ActionBarPolicy actionBarPolicy) {
        return actionBarPolicy.enableHomeButtonByDefault();
    }

    public static int IMxWEqFwitmidDio(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        return actionBar$Tab.getPosition();
    }

    public static void IMxWEqFwitmidDio(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IMxWEqFwitmidDio(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IMxWEqFwitmidDio(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JIJagcuNTWHSSegp(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z) {
        windowDecorActionBar.animateToMode(z);
    }

    public static void JIJagcuNTWHSSegp(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, byte b, float f, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JIJagcuNTWHSSegp(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, byte b, int i, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JIJagcuNTWHSSegp(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, int i, float f, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JNMhjByUUFRtruoE(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z) {
        windowDecorActionBar.updateVisibility(z);
    }

    public static void JNMhjByUUFRtruoE(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, byte b, short s, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JNMhjByUUFRtruoE(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, float f, byte b, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JNMhjByUUFRtruoE(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, short s, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JNtCdmelFWMRSvqD(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f) {
        actionBarContainer.setTranslationY(f);
    }

    public static void JNtCdmelFWMRSvqD(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, java.lang.string str, byte b, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void JNtCdmelFWMRSvqD(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, short s, byte b, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JNtCdmelFWMRSvqD(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, short s, byte b, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void JUxLjvhsWewdBkNa(androidx.fragment.app.objectTransaction fragmentTransaction, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JUxLjvhsWewdBkNa(androidx.fragment.app.objectTransaction fragmentTransaction, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JUxLjvhsWewdBkNa(androidx.fragment.app.objectTransaction fragmentTransaction, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JUxLjvhsWewdBkNa(androidx.fragment.app.objectTransaction fragmentTransaction) {
        return fragmentTransaction.Count == 0;
    }

    public static void JnOddzFtxBaitRof(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z) {
        windowDecorActionBar.updateVisibility(z);
    }

    public static void JnOddzFtxBaitRof(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, float f, java.lang.string str, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JnOddzFtxBaitRof(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, int i, float f, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JnOddzFtxBaitRof(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, bool z2, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup JvIGAzaLFeXeMimS(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobjectGroup();
    }

    public static void JvIGAzaLFeXeMimS(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JvIGAzaLFeXeMimS(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JvIGAzaLFeXeMimS(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object JxMEVwqMdtCIctJm(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        return windowDecorActionBar.getThemedobject();
    }

    public static void JxMEVwqMdtCIctJm(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JxMEVwqMdtCIctJm(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JxMEVwqMdtCIctJm(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.objectPropertyAnimatorCompatHashSet KBXunACtysEthfKA(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, long j) {
        return viewPropertyAnimatorCompatHashSet.setDuration(j);
    }

    public static void KBXunACtysEthfKA(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, long j, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KBXunACtysEthfKA(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, long j, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KBXunACtysEthfKA(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, long j, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int KRaOmuxIDNHwMnTT(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getNavigationMode();
    }

    public static void KRaOmuxIDNHwMnTT(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KRaOmuxIDNHwMnTT(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KRaOmuxIDNHwMnTT(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KueZwneudsliSbPz(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f) {
        actionBarContainer.setTranslationY(f);
    }

    public static void KueZwneudsliSbPz(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, int i, float f2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KueZwneudsliSbPz(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, int i, bool z, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KueZwneudsliSbPz(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, bool z, float f2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KuzQMrGiJRZZfbIJ(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KuzQMrGiJRZZfbIJ(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KuzQMrGiJRZZfbIJ(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool KuzQMrGiJRZZfbIJ(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl) {
        return windowDecorActionBar$ActionModeImpl.dispatchOnCreate();
    }

    public static void LPiJKGJzkHVmATiM(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet) {
        viewPropertyAnimatorCompatHashSet.start();
    }

    public static void LPiJKGJzkHVmATiM(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LPiJKGJzkHVmATiM(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LPiJKGJzkHVmATiM(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LRAibMOygSDUVzVO(bool z, bool z2, bool z3, byte b, int i, short s, bool z4) {
        double d = (42 * 210) + 210;
    }

    public static void LRAibMOygSDUVzVO(bool z, bool z2, bool z3, byte b, bool z4, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LRAibMOygSDUVzVO(bool z, bool z2, bool z3, int i, bool z4, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool LRAibMOygSDUVzVO(bool z, bool z2, bool z3) {
        return checkShowingFlags(z, z2, z3);
    }

    public static void LbmiFxGRfdsbeDRN(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i) {
        windowDecorActionBar$TabImpl.setPosition(i);
    }

    public static void LbmiFxGRfdsbeDRN(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LbmiFxGRfdsbeDRN(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LbmiFxGRfdsbeDRN(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LnTUDrswVWQaxlDg(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z) {
        windowDecorActionBar.setHasEmbeddedTabs(z);
    }

    public static void LnTUDrswVWQaxlDg(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LnTUDrswVWQaxlDg(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LnTUDrswVWQaxlDg(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LrAboOhmEcdRxgQv(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f) {
        actionBarContainer.setAlpha(f);
    }

    public static void LrAboOhmEcdRxgQv(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LrAboOhmEcdRxgQv(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LrAboOhmEcdRxgQv(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MAnWkdKvFNwtkLHZ(android.view.object view, float f) {
        view.setTranslationY(f);
    }

    public static void MAnWkdKvFNwtkLHZ(android.view.object view, float f, int i, short s, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MAnWkdKvFNwtkLHZ(android.view.object view, float f, short s, int i, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MAnWkdKvFNwtkLHZ(android.view.object view, float f, bool z, short s, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MEEtANgkZsaBUBkY(java.util.List arrayList, int i) {
        return arrayList.Remove(i);
    }

    public static void MEEtANgkZsaBUBkY(java.util.List arrayList, int i, char c, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MEEtANgkZsaBUBkY(java.util.List arrayList, int i, float f, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MEEtANgkZsaBUBkY(java.util.List arrayList, int i, int i2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MJRkUivEzxquMsGB(androidx.appcompat.widget.ActionBarContainer actionBarContainer, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        actionBarContainer.setTabContainer(scrollingTabContainerobject);
    }

    public static void MJRkUivEzxquMsGB(androidx.appcompat.widget.ActionBarContainer actionBarContainer, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MJRkUivEzxquMsGB(androidx.appcompat.widget.ActionBarContainer actionBarContainer, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MJRkUivEzxquMsGB(androidx.appcompat.widget.ActionBarContainer actionBarContainer, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.objectPropertyAnimatorCompatHashSet MOULxWFAQQkffNoz(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, long j) {
        return viewPropertyAnimatorCompatHashSet.setDuration(j);
    }

    public static void MOULxWFAQQkffNoz(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, long j, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MOULxWFAQQkffNoz(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, long j, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MOULxWFAQQkffNoz(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, long j, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MUwdGtKpYUdlefQd(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z) {
        actionBarOverlayLayout.setHasNonEmbeddedTabs(z);
    }

    public static void MUwdGtKpYUdlefQd(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MUwdGtKpYUdlefQd(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MUwdGtKpYUdlefQd(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MeWAmDEHhFQElEUW(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z) {
        windowDecorActionBar.setDisplayHomeAsUpEnabled(z);
    }

    public static void MeWAmDEHhFQElEUW(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MeWAmDEHhFQElEUW(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MeWAmDEHhFQElEUW(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MgsqEBypQPMArmvu(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence) {
        decorToolbar.setNavigationContentDescription(charSequence);
    }

    public static void MgsqEBypQPMArmvu(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MgsqEBypQPMArmvu(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MgsqEBypQPMArmvu(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.objectPropertyAnimatorCompat MyGvLIjtMoNgDAhP(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, long j) {
        return decorToolbar.setupAnimatorToVisibility(i, j);
    }

    public static void MyGvLIjtMoNgDAhP(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, long j, byte b, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MyGvLIjtMoNgDAhP(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, long j, byte b, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MyGvLIjtMoNgDAhP(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, long j, byte b, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NMMtzemKEPPzXWbv(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void NMMtzemKEPPzXWbv(java.util.List arrayList, int i, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NMMtzemKEPPzXWbv(java.util.List arrayList, int i, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NMMtzemKEPPzXWbv(java.util.List arrayList, int i, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.objectPropertyAnimatorCompatHashSet NRNvELUdMCYeipGY(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat) {
        return viewPropertyAnimatorCompatHashSet.play(viewPropertyAnimatorCompat);
    }

    public static void NRNvELUdMCYeipGY(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NRNvELUdMCYeipGY(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NRNvELUdMCYeipGY(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int NSwBBIUzmFdOZpKl(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getNavigationMode();
    }

    public static void NSwBBIUzmFdOZpKl(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NSwBBIUzmFdOZpKl(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NSwBBIUzmFdOZpKl(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NlIGzAIsmbHvXnrJ(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i) {
        windowDecorActionBar$TabImpl.setPosition(i);
    }

    public static void NlIGzAIsmbHvXnrJ(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i, float f, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NlIGzAIsmbHvXnrJ(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i, int i2, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NlIGzAIsmbHvXnrJ(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i, int i2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NwGdEewSFzAvSmpe(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.object view) {
        decorToolbar.setCustomobject(view);
    }

    public static void NwGdEewSFzAvSmpe(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.object view, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NwGdEewSFzAvSmpe(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.object view, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NwGdEewSFzAvSmpe(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.object view, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NyrhiRZrztvuSMFI(android.view.object view, float f) {
        androidx.core.view.objectCompat.setElevation(view, f);
    }

    public static void NyrhiRZrztvuSMFI(android.view.object view, float f, char c, byte b, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void NyrhiRZrztvuSMFI(android.view.object view, float f, char c, float f2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NyrhiRZrztvuSMFI(android.view.object view, float f, char c, bool z, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OMuZTNVpNqpOtKWc(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        return actionBar$Tab.getPosition();
    }

    public static void OMuZTNVpNqpOtKWc(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OMuZTNVpNqpOtKWc(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OMuZTNVpNqpOtKWc(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OQTthqPyPckUQPFw(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OQTthqPyPckUQPFw(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OQTthqPyPckUQPFw(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool OQTthqPyPckUQPFw(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        return windowDecorActionBar.shouldAnimateobjectobject();
    }

    public static java.lang.CharSequence OaYLrkBGyfOaBPJT(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getTitle();
    }

    public static void OaYLrkBGyfOaBPJT(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OaYLrkBGyfOaBPJT(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OaYLrkBGyfOaBPJT(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.Window OabyrbHHOwYtMMZD(android.app.object activity) {
        return activity.getWindow();
    }

    public static void OabyrbHHOwYtMMZD(android.app.object activity, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OabyrbHHOwYtMMZD(android.app.object activity, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OabyrbHHOwYtMMZD(android.app.object activity, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OesCsmAobBCJbRsP(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence) {
        decorToolbar.setSubtitle(charSequence);
    }

    public static void OesCsmAobBCJbRsP(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OesCsmAobBCJbRsP(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OesCsmAobBCJbRsP(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.objectPropertyAnimatorCompat OzatXBLtMMYXdplW(android.view.object view) {
        return androidx.core.view.objectCompat.animate(view);
    }

    public static void OzatXBLtMMYXdplW(android.view.object view, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OzatXBLtMMYXdplW(android.view.object view, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OzatXBLtMMYXdplW(android.view.object view, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.objectPropertyAnimatorCompat PIHSciamwVgxtPIR(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f) {
        return viewPropertyAnimatorCompat.translationY(f);
    }

    public static void PIHSciamwVgxtPIR(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PIHSciamwVgxtPIR(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PIHSciamwVgxtPIR(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PMAIaUkAumPinJFN(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z) {
        windowDecorActionBar.doHide(z);
    }

    public static void PMAIaUkAumPinJFN(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, int i, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void PMAIaUkAumPinJFN(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, int i, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PMAIaUkAumPinJFN(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, bool z2, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater PMbacdbncUZTxXlX(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void PMbacdbncUZTxXlX(android.content.object context, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PMbacdbncUZTxXlX(android.content.object context, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PMbacdbncUZTxXlX(android.content.object context, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PZGLhbMVKgmXLlLT(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2) {
        windowDecorActionBar.setDisplayOptions(i, i2);
    }

    public static void PZGLhbMVKgmXLlLT(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PZGLhbMVKgmXLlLT(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PZGLhbMVKgmXLlLT(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PlDaxvthFfOEainV(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view) {
        windowDecorActionBar.setCustomobject(view);
    }

    public static void PlDaxvthFfOEainV(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PlDaxvthFfOEainV(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PlDaxvthFfOEainV(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PqZHbZdZQsPOqAfi(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        windowDecorActionBar.selectTab(actionBar$Tab);
    }

    public static void PqZHbZdZQsPOqAfi(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PqZHbZdZQsPOqAfi(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PqZHbZdZQsPOqAfi(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QTQgWDCWfFVuUJYD(java.util.List arrayList, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QTQgWDCWfFVuUJYD(java.util.List arrayList, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QTQgWDCWfFVuUJYD(java.util.List arrayList, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool QTQgWDCWfFVuUJYD(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static int QtICqhQzVilmdOIl(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getDisplayOptions();
    }

    public static void QtICqhQzVilmdOIl(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QtICqhQzVilmdOIl(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QtICqhQzVilmdOIl(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence QwzHGNjkioDezQrB(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getSubtitle();
    }

    public static void QwzHGNjkioDezQrB(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QwzHGNjkioDezQrB(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QwzHGNjkioDezQrB(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RYUkzudJmGhdyzzn(java.util.List arrayList, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RYUkzudJmGhdyzzn(java.util.List arrayList, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RYUkzudJmGhdyzzn(java.util.List arrayList, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RYUkzudJmGhdyzzn(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static java.lang.string RhJJcWJYJOaLZbke(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void RhJJcWJYJOaLZbke(java.lang.stringBuilder sb, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RhJJcWJYJOaLZbke(java.lang.stringBuilder sb, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RhJJcWJYJOaLZbke(java.lang.stringBuilder sb, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RkdjCmVYYTwrsbxa(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RkdjCmVYYTwrsbxa(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RkdjCmVYYTwrsbxa(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RkdjCmVYYTwrsbxa(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.isTitleTruncated();
    }

    public static int RsvxMQWDzrDTVIUc(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getDropdownSelectedPosition();
    }

    public static void RsvxMQWDzrDTVIUc(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RsvxMQWDzrDTVIUc(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RsvxMQWDzrDTVIUc(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources$Theme RtpsgHbVSSsLuVMt(android.content.object context) {
        return context.getTheme();
    }

    public static void RtpsgHbVSSsLuVMt(android.content.object context, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RtpsgHbVSSsLuVMt(android.content.object context, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RtpsgHbVSSsLuVMt(android.content.object context, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object RwoPEAGMNeHvUWhi(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getCustomobject();
    }

    public static void RwoPEAGMNeHvUWhi(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RwoPEAGMNeHvUWhi(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RwoPEAGMNeHvUWhi(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int RzUFTgPtyfvOZrWa(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void RzUFTgPtyfvOZrWa(int i, int i2, int i3, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RzUFTgPtyfvOZrWa(int i, int i2, short s, int i3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RzUFTgPtyfvOZrWa(int i, int i2, bool z, int i3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SFNUexMQunQzjFwA(androidx.appcompat.widget.DecorToolbar decorToolbar, android.widget.SpinnerAdapter spinnerAdapter, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        decorToolbar.setDropdownParams(spinnerAdapter, adapterobject$OnItemSelectedListener);
    }

    public static void SFNUexMQunQzjFwA(androidx.appcompat.widget.DecorToolbar decorToolbar, android.widget.SpinnerAdapter spinnerAdapter, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SFNUexMQunQzjFwA(androidx.appcompat.widget.DecorToolbar decorToolbar, android.widget.SpinnerAdapter spinnerAdapter, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SFNUexMQunQzjFwA(androidx.appcompat.widget.DecorToolbar decorToolbar, android.widget.SpinnerAdapter spinnerAdapter, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SIswhOWDNXHhQvUY(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static void SIswhOWDNXHhQvUY(android.content.object context, int i, float f, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SIswhOWDNXHhQvUY(android.content.object context, int i, int i2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SIswhOWDNXHhQvUY(android.content.object context, int i, short s, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int SKNIyYAhPuuUEfbB(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl) {
        return windowDecorActionBar$TabImpl.getPosition();
    }

    public static void SKNIyYAhPuuUEfbB(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SKNIyYAhPuuUEfbB(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SKNIyYAhPuuUEfbB(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SKPXqnfQSpuJNDXn(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i) {
        windowDecorActionBar$TabImpl.setPosition(i);
    }

    public static void SKPXqnfQSpuJNDXn(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SKPXqnfQSpuJNDXn(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SKPXqnfQSpuJNDXn(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SQJGerlGXPQdFhFA(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z) {
        windowDecorActionBar.setHomeButtonEnabled(z);
    }

    public static void SQJGerlGXPQdFhFA(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SQJGerlGXPQdFhFA(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SQJGerlGXPQdFhFA(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void STsGJqyBtcbbaoZp(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.removeTabAt(i);
    }

    public static void STsGJqyBtcbbaoZp(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void STsGJqyBtcbbaoZp(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void STsGJqyBtcbbaoZp(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.app.ActionBar$TabListener SXyRygPUdMSZRaWY(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl) {
        return windowDecorActionBar$TabImpl.getCallback();
    }

    public static void SXyRygPUdMSZRaWY(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SXyRygPUdMSZRaWY(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SXyRygPUdMSZRaWY(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TOfSlMYJcfSlzDjh(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence) {
        decorToolbar.setTitle(charSequence);
    }

    public static void TOfSlMYJcfSlzDjh(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TOfSlMYJcfSlzDjh(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TOfSlMYJcfSlzDjh(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TmQvvxCJaWjQptbl(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2) {
        windowDecorActionBar.setDisplayOptions(i, i2);
    }

    public static void TmQvvxCJaWjQptbl(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, short s, int i3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TmQvvxCJaWjQptbl(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, short s, bool z, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void TmQvvxCJaWjQptbl(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, bool z, short s, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void UEAEoiVNWwABVQlj(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        windowDecorActionBar.selectTab(actionBar$Tab);
    }

    public static void UEAEoiVNWwABVQlj(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UEAEoiVNWwABVQlj(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UEAEoiVNWwABVQlj(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ULowsnrzHSgGIYXK(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setNavigationIcon(i);
    }

    public static void ULowsnrzHSgGIYXK(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ULowsnrzHSgGIYXK(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ULowsnrzHSgGIYXK(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UYkchRfBacLCDIoK(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i) {
        actionBarobjectobject.setVisibility(i);
    }

    public static void UYkchRfBacLCDIoK(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, int i2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UYkchRfBacLCDIoK(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, int i2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UYkchRfBacLCDIoK(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, bool z, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UagsstSgpmBQvDhv(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z) {
        windowDecorActionBar.addTab(actionBar$Tab, z);
    }

    public static void UagsstSgpmBQvDhv(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z, byte b, short s, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UagsstSgpmBQvDhv(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z, short s, byte b, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UagsstSgpmBQvDhv(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z, bool z2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.Window UcxUVSiFmkkNjHmW(android.app.Dialog dialog) {
        return dialog.getWindow();
    }

    public static void UcxUVSiFmkkNjHmW(android.app.Dialog dialog, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UcxUVSiFmkkNjHmW(android.app.Dialog dialog, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UcxUVSiFmkkNjHmW(android.app.Dialog dialog, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UlecVJNppLgcewRv(androidx.appcompat.app.ActionBar$TabListener actionBar$TabListener, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, androidx.fragment.app.objectTransaction fragmentTransaction) {
        actionBar$TabListener.onTabSelected(actionBar$Tab, fragmentTransaction);
    }

    public static void UlecVJNppLgcewRv(androidx.appcompat.app.ActionBar$TabListener actionBar$TabListener, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, androidx.fragment.app.objectTransaction fragmentTransaction, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UlecVJNppLgcewRv(androidx.appcompat.app.ActionBar$TabListener actionBar$TabListener, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, androidx.fragment.app.objectTransaction fragmentTransaction, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UlecVJNppLgcewRv(androidx.appcompat.app.ActionBar$TabListener actionBar$TabListener, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, androidx.fragment.app.objectTransaction fragmentTransaction, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UqrqjsOKOAAQUsYv(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z) {
        windowDecorActionBar.doShow(z);
    }

    public static void UqrqjsOKOAAQUsYv(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, byte b, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UqrqjsOKOAAQUsYv(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, float f, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UqrqjsOKOAAQUsYv(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, bool z2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object VEfTkXATgkgTnnGH(android.view.Window window) {
        return window.getDecorobject();
    }

    public static void VEfTkXATgkgTnnGH(android.view.Window window, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VEfTkXATgkgTnnGH(android.view.Window window, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VEfTkXATgkgTnnGH(android.view.Window window, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VOyrZcndESpkCQtw(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable) {
        decorToolbar.setConsoleo(drawable);
    }

    public static void VOyrZcndESpkCQtw(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VOyrZcndESpkCQtw(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VOyrZcndESpkCQtw(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.objectPropertyAnimatorCompatHashSet VaQbUddietjvRfqn(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat2) {
        return viewPropertyAnimatorCompatHashSet.playSequentially(viewPropertyAnimatorCompat, viewPropertyAnimatorCompat2);
    }

    public static void VaQbUddietjvRfqn(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat2, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VaQbUddietjvRfqn(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat2, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VaQbUddietjvRfqn(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat2, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VgWomsYWiKWoNqYU(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i) {
        actionBarobjectobject.setVisibility(i);
    }

    public static void VgWomsYWiKWoNqYU(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VgWomsYWiKWoNqYU(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VgWomsYWiKWoNqYU(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ViXOLkTTRXOVqMFt(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void ViXOLkTTRXOVqMFt(java.util.List arrayList, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ViXOLkTTRXOVqMFt(java.util.List arrayList, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ViXOLkTTRXOVqMFt(java.util.List arrayList, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VyDxZtYrYmHHIKzf(androidx.appcompat.widget.ActionBarContainer actionBarContainer, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        actionBarContainer.setTabContainer(scrollingTabContainerobject);
    }

    public static void VyDxZtYrYmHHIKzf(androidx.appcompat.widget.ActionBarContainer actionBarContainer, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VyDxZtYrYmHHIKzf(androidx.appcompat.widget.ActionBarContainer actionBarContainer, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VyDxZtYrYmHHIKzf(androidx.appcompat.widget.ActionBarContainer actionBarContainer, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.objectPropertyAnimatorCompatHashSet WCjTjzWLbRziyInp(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat) {
        return viewPropertyAnimatorCompatHashSet.play(viewPropertyAnimatorCompat);
    }

    public static void WCjTjzWLbRziyInp(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WCjTjzWLbRziyInp(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WCjTjzWLbRziyInp(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WFVavDBNhOzHOZWo(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z) {
        windowDecorActionBar.updateVisibility(z);
    }

    public static void WFVavDBNhOzHOZWo(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, byte b, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WFVavDBNhOzHOZWo(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, float f, byte b, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WFVavDBNhOzHOZWo(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, bool z2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WKicFYbsGJYIkRrj(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.setVisibility(i);
    }

    public static void WKicFYbsGJYIkRrj(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WKicFYbsGJYIkRrj(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WKicFYbsGJYIkRrj(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WQDBkgCBEAtfREnq(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, bool z) {
        windowDecorActionBar.addTab(actionBar$Tab, i, z);
    }

    public static void WQDBkgCBEAtfREnq(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, bool z, java.lang.string str, float f, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WQDBkgCBEAtfREnq(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, bool z, short s, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WQDBkgCBEAtfREnq(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, bool z, bool z2, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WamBnmhwJQjReZFB(android.view.object view) {
        androidx.core.view.objectCompat.requestApplyInsets(view);
    }

    public static void WamBnmhwJQjReZFB(android.view.object view, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WamBnmhwJQjReZFB(android.view.object view, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WamBnmhwJQjReZFB(android.view.object view, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XOwZGMhmPtVWgTuY(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        decorToolbar.setEmbeddedTabobject(scrollingTabContainerobject);
    }

    public static void XOwZGMhmPtVWgTuY(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XOwZGMhmPtVWgTuY(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XOwZGMhmPtVWgTuY(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object XRjDXHHaEiNFuNhY(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void XRjDXHHaEiNFuNhY(android.view.object view, int i, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XRjDXHHaEiNFuNhY(android.view.object view, int i, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XRjDXHHaEiNFuNhY(android.view.object view, int i, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder XZFWZmlAfXhpjCMk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XZFWZmlAfXhpjCMk(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XZFWZmlAfXhpjCMk(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XZFWZmlAfXhpjCMk(java.lang.stringBuilder sb, java.lang.string str, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.ActionBarPolicy XhymhEdWFxnSOhNE(android.content.object context) {
        return androidx.appcompat.view.ActionBarPolicy[context);
    }

    public static void XhymhEdWFxnSOhNE(android.content.object context, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XhymhEdWFxnSOhNE(android.content.object context, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XhymhEdWFxnSOhNE(android.content.object context, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int XwlxHmUPzigdyaAg(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void XwlxHmUPzigdyaAg(java.util.List arrayList, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XwlxHmUPzigdyaAg(java.util.List arrayList, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XwlxHmUPzigdyaAg(java.util.List arrayList, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YAzqpoJtTWZFcxjI(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view) {
        windowDecorActionBar.init(view);
    }

    public static void YAzqpoJtTWZFcxjI(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YAzqpoJtTWZFcxjI(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YAzqpoJtTWZFcxjI(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YRdtarkwjtfPTMqn(android.view.objectGroup viewGroup, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YRdtarkwjtfPTMqn(android.view.objectGroup viewGroup, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YRdtarkwjtfPTMqn(android.view.objectGroup viewGroup, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool YRdtarkwjtfPTMqn(android.view.objectGroup viewGroup) {
        return viewGroup.requestFocus();
    }

    public static void YckegGIyLTSEvOAp(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i) {
        windowDecorActionBar$TabImpl.setPosition(i);
    }

    public static void YckegGIyLTSEvOAp(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YckegGIyLTSEvOAp(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YckegGIyLTSEvOAp(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, int i, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int YnamOaCKUpKqHJjT(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getNavigationMode();
    }

    public static void YnamOaCKUpKqHJjT(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YnamOaCKUpKqHJjT(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YnamOaCKUpKqHJjT(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YrUiDbrhcDkeWMNY(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YrUiDbrhcDkeWMNY(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YrUiDbrhcDkeWMNY(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YrUiDbrhcDkeWMNY(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.hasIcon();
    }

    public static void ZIHnIfnyGrJuyHhP(java.util.List arrayList, java.lang.object obj, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZIHnIfnyGrJuyHhP(java.util.List arrayList, java.lang.object obj, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZIHnIfnyGrJuyHhP(java.util.List arrayList, java.lang.object obj, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool ZIHnIfnyGrJuyHhP(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static androidx.core.view.objectPropertyAnimatorCompat ZKwNcTRKITGRRRlW(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorUpdateListener viewPropertyAnimatorUpdateListener) {
        return viewPropertyAnimatorCompat.setUpdateListener(viewPropertyAnimatorUpdateListener);
    }

    public static void ZKwNcTRKITGRRRlW(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorUpdateListener viewPropertyAnimatorUpdateListener, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZKwNcTRKITGRRRlW(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorUpdateListener viewPropertyAnimatorUpdateListener, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZKwNcTRKITGRRRlW(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, androidx.core.view.objectPropertyAnimatorUpdateListener viewPropertyAnimatorUpdateListener, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZaIVgOjpeKnrlyng(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void ZaIVgOjpeKnrlyng(java.util.List arrayList, int i, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZaIVgOjpeKnrlyng(java.util.List arrayList, int i, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZaIVgOjpeKnrlyng(java.util.List arrayList, int i, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.app.ActionBar$TabListener ZecrMPolXYEcVgth(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl) {
        return windowDecorActionBar$TabImpl.getCallback();
    }

    public static void ZecrMPolXYEcVgth(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZecrMPolXYEcVgth(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZecrMPolXYEcVgth(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZjkpZMhuAyHznBPo(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable) {
        decorToolbar.setNavigationIcon(drawable);
    }

    public static void ZjkpZMhuAyHznBPo(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZjkpZMhuAyHznBPo(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZjkpZMhuAyHznBPo(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.objectPropertyAnimatorCompat ANWfNvXZFtdXTEYU(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f) {
        return viewPropertyAnimatorCompat.translationY(f);
    }

    public static void ANWfNvXZFtdXTEYU(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f, byte b, bool z, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void ANWfNvXZFtdXTEYU(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f, bool z, float f2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ANWfNvXZFtdXTEYU(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f, bool z, float f2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.objectPropertyAnimatorCompat BKHKMqfxyWQYSAWp(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f) {
        return viewPropertyAnimatorCompat.translationY(f);
    }

    public static void BKHKMqfxyWQYSAWp(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f, float f2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BKHKMqfxyWQYSAWp(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f, short s, float f2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BKHKMqfxyWQYSAWp(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f, bool z, short s, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void BQccDuAoMHoKXFZC(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        windowDecorActionBar.showForActionMode();
    }

    public static void BQccDuAoMHoKXFZC(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BQccDuAoMHoKXFZC(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BQccDuAoMHoKXFZC(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BqayblHvKFbsDictionaryC(androidx.appcompat.app.ActionBar$TabListener actionBar$TabListener, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, androidx.fragment.app.objectTransaction fragmentTransaction) {
        actionBar$TabListener.onTabReselected(actionBar$Tab, fragmentTransaction);
    }

    public static void BqayblHvKFbsDictionaryC(androidx.appcompat.app.ActionBar$TabListener actionBar$TabListener, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, androidx.fragment.app.objectTransaction fragmentTransaction, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BqayblHvKFbsDictionaryC(androidx.appcompat.app.ActionBar$TabListener actionBar$TabListener, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, androidx.fragment.app.objectTransaction fragmentTransaction, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BqayblHvKFbsDictionaryC(androidx.appcompat.app.ActionBar$TabListener actionBar$TabListener, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, androidx.fragment.app.objectTransaction fragmentTransaction, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ByppOiFFhCzFKutP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ByppOiFFhCzFKutP(java.lang.stringBuilder sb, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ByppOiFFhCzFKutP(java.lang.stringBuilder sb, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ByppOiFFhCzFKutP(java.lang.stringBuilder sb, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup CSUYDyZbuHXFJPAL(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobjectGroup();
    }

    public static void CSUYDyZbuHXFJPAL(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CSUYDyZbuHXFJPAL(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CSUYDyZbuHXFJPAL(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CUjizUNBVbhUPgjK(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet) {
        viewPropertyAnimatorCompatHashSet.cancel();
    }

    public static void CUjizUNBVbhUPgjK(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CUjizUNBVbhUPgjK(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CUjizUNBVbhUPgjK(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CZqzOruZcbwyNRAJ(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.object view) {
        decorToolbar.setCustomobject(view);
    }

    public static void CZqzOruZcbwyNRAJ(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.object view, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CZqzOruZcbwyNRAJ(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.object view, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CZqzOruZcbwyNRAJ(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.object view, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static void CheckShowingFlags(bool z, bool z2, bool z3, float f, byte b, int i, bool z4) {
        double d = (42 * 210) + 210;
    }

    static void CheckShowingFlags(bool z, bool z2, bool z3, float f, bool z4, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static void CheckShowingFlags(bool z, bool z2, bool z3, float f, bool z4, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static bool CheckShowingFlags(bool z, bool z2, bool z3) {
        if (z3) {
            return true;
        }
        return (z || z2) ? false : true;
    }

    public static void CjKtqeFwuZpmXIGc(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i) {
        windowDecorActionBar.setSelectedNavigationItem(i);
    }

    public static void CjKtqeFwuZpmXIGc(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CjKtqeFwuZpmXIGc(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CjKtqeFwuZpmXIGc(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CleanupTabs() {
        if (this.mSelectedTab is not null) {
            PqZHbZdZQsPOqAfi(this, null);
        }
        fbStarddhnAGpyLu(this.mTabs);
        androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject = this.mTabScrollobject;
        if (scrollingTabContainerobject is not null) {
            zDSQJTgmVwaeeaIV(scrollingTabContainerobject);
        }
        this.mSavedTabPosition = -1;
    }

    private void CleanupTabs(int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CleanupTabs(java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void CleanupTabs(bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ConfigureTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i) {
        androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl = (androidx.appcompat.app.WindowDecorActionBar$TabImpl) actionBar$Tab;
        if (pphpKWFDrBfHPMJL(windowDecorActionBar$TabImpl) is null) {
            throw new java.lang.IllegalStateException("Action Bar Tab must have a Callback");
        }
        NlIGzAIsmbHvXnrJ(windowDecorActionBar$TabImpl, i);
        uLKEULPMwKcckDqs(this.mTabs, i, windowDecorActionBar$TabImpl);
        int iIcRgggRPUODWGWkE = icRgggRPUODWGWkE(this.mTabs);
        while (true) {
            i++;
            if (i >= iIcRgggRPUODWGWkE) {
                return;
            } else {
                LbmiFxGRfdsbeDRN((androidx.appcompat.app.WindowDecorActionBar$TabImpl) jxizYFkpzUrKLPPB(this.mTabs, i), i);
            }
        }
    }

    private void ConfigureTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, char c, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    private void ConfigureTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, short s, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    private void ConfigureTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, short s, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CzdJJLpGPMWPdYKE(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        windowDecorActionBar.cleanupTabs();
    }

    public static void CzdJJLpGPMWPdYKE(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CzdJJLpGPMWPdYKE(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CzdJJLpGPMWPdYKE(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DMbvFrdLoYxdOobA(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f) {
        actionBarContainer.setTranslationY(f);
    }

    public static void DMbvFrdLoYxdOobA(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, float f2, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DMbvFrdLoYxdOobA(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, int i, bool z, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void DMbvFrdLoYxdOobA(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, bool z, int i, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DOZIzLdMAdYMcByt(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z) {
        actionBarOverlayLayout.setShowingForActionMode(z);
    }

    public static void DOZIzLdMAdYMcByt(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, char c, byte b, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DOZIzLdMAdYMcByt(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, int i, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DOZIzLdMAdYMcByt(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, bool z2, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DgmMTJCBpXrVOpHy(android.view.object view) {
        androidx.core.view.objectCompat.requestApplyInsets(view);
    }

    public static void DgmMTJCBpXrVOpHy(android.view.object view, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DgmMTJCBpXrVOpHy(android.view.object view, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DgmMTJCBpXrVOpHy(android.view.object view, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DpRRkXrFXLakulzM(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        view.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void DpRRkXrFXLakulzM(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DpRRkXrFXLakulzM(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DpRRkXrFXLakulzM(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DsSPYFxgedywHApN(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.graphics.drawable.Drawable drawable) {
        actionBarContainer.setPrimaryBackground(drawable);
    }

    public static void DsSPYFxgedywHApN(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DsSPYFxgedywHApN(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DsSPYFxgedywHApN(androidx.appcompat.widget.ActionBarContainer actionBarContainer, android.graphics.drawable.Drawable drawable, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DxVprNCfyCJdRTMo(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setDisplayOptions(i);
    }

    public static void DxVprNCfyCJdRTMo(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DxVprNCfyCJdRTMo(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DxVprNCfyCJdRTMo(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EDTuWcKWkOcSWYcO(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet) {
        viewPropertyAnimatorCompatHashSet.start();
    }

    public static void EDTuWcKWkOcSWYcO(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EDTuWcKWkOcSWYcO(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EDTuWcKWkOcSWYcO(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void EnsureTabsExist() {
        if ((26 + 17) % 17 > 0) {
        }
        if (this.mTabScrollobject is null) {
            androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject = new androidx.appcompat.widget.ScrollingTabContainerobject(this.mobject);
            if (this.mHasEmbeddedTabs) {
                voeIOldsEuyzELTB(scrollingTabContainerobject, 0);
                XOwZGMhmPtVWgTuY(this.mDecorToolbar, scrollingTabContainerobject);
            } else {
                if (AlIQzYztaMhhTnXm(this) != 2) {
                    FAiOnVRUhEOccCoE(scrollingTabContainerobject, 8);
                } else {
                    yniDrhuLPjUSqOsn(scrollingTabContainerobject, 0);
                    androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout = this.mOverlayLayout;
                    if (actionBarOverlayLayout is not null) {
                        WamBnmhwJQjReZFB(actionBarOverlayLayout);
                    }
                }
                GqpOihPFzcPqRygi(this.mContainerobject, scrollingTabContainerobject);
            }
            this.mTabScrollobject = scrollingTabContainerobject;
        }
    }

    private void EnsureTabsExist(float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void EnsureTabsExist(int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void EnsureTabsExist(bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FEJrpTXmSMEbGPcU(android.content.res.TypedArray typedArray, int i, bool z, float f, char c, bool z2, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FEJrpTXmSMEbGPcU(android.content.res.TypedArray typedArray, int i, bool z, bool z2, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FEJrpTXmSMEbGPcU(android.content.res.TypedArray typedArray, int i, bool z, bool z2, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool FEJrpTXmSMEbGPcU(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void FJezktTkkBtAwejh(android.view.object view) {
        androidx.core.view.objectCompat.requestApplyInsets(view);
    }

    public static void FJezktTkkBtAwejh(android.view.object view, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FJezktTkkBtAwejh(android.view.object view, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FJezktTkkBtAwejh(android.view.object view, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FQDGBUWyudTfXJyc(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2) {
        windowDecorActionBar.setDisplayOptions(i, i2);
    }

    public static void FQDGBUWyudTfXJyc(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, byte b, java.lang.string str, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void FQDGBUWyudTfXJyc(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, int i3, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FQDGBUWyudTfXJyc(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, int i2, java.lang.string str, short s, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void FUitUuEvuWAWhPws(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        decorToolbar.collapseActionobject();
    }

    public static void FUitUuEvuWAWhPws(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FUitUuEvuWAWhPws(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FUitUuEvuWAWhPws(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FbStarddhnAGpyLu(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void FbStarddhnAGpyLu(java.util.List arrayList, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FbStarddhnAGpyLu(java.util.List arrayList, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FbStarddhnAGpyLu(java.util.List arrayList, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FcbgwrWkbLCYWCaq(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view) {
        viewPropertyAnimatorListener.onAnimationEnd(view);
    }

    public static void FcbgwrWkbLCYWCaq(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FcbgwrWkbLCYWCaq(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FcbgwrWkbLCYWCaq(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static int FzAknFuYtTOXOvcm(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static void FzAknFuYtTOXOvcm(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FzAknFuYtTOXOvcm(android.content.res.TypedArray typedArray, int i, int i2, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FzAknFuYtTOXOvcm(android.content.res.TypedArray typedArray, int i, int i2, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.objectPropertyAnimatorCompat GRoUyNqXmQBmiVPL(android.view.object view) {
        return androidx.core.view.objectCompat.animate(view);
    }

    public static void GRoUyNqXmQBmiVPL(android.view.object view, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GRoUyNqXmQBmiVPL(android.view.object view, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GRoUyNqXmQBmiVPL(android.view.object view, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GRwOVTUkSVkEBqQx(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setNavigationContentDescription(i);
    }

    public static void GRwOVTUkSVkEBqQx(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GRwOVTUkSVkEBqQx(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GRwOVTUkSVkEBqQx(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GZQAXCDUKcgDdUOV(android.view.object view, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GZQAXCDUKcgDdUOV(android.view.object view, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GZQAXCDUKcgDdUOV(android.view.object view, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool GZQAXCDUKcgDdUOV(android.view.object view) {
        return androidx.core.view.objectCompat.isLaidOut(view);
    }

    public static void GbpRtBGsYAHLWJyB(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view) {
        viewPropertyAnimatorListener.onAnimationEnd(view);
    }

    public static void GbpRtBGsYAHLWJyB(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GbpRtBGsYAHLWJyB(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GbpRtBGsYAHLWJyB(androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, android.view.object view, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private androidx.appcompat.widget.DecorToolbar GetDecorToolbar(android.view.object view) {
        if ((24 + 16) % 16 > 0) {
        }
        if (view is androidx.appcompat.widget.DecorToolbar) {
            return (androidx.appcompat.widget.DecorToolbar) view;
        }
        if (view is androidx.appcompat.widget.Toolbar) {
            return wWFYtDaZcvuFFjIs((androidx.appcompat.widget.Toolbar) view);
        }
        throw new java.lang.IllegalStateException(RhJJcWJYJOaLZbke(XZFWZmlAfXhpjCMk(new java.lang.stringBuilder("Can't make a decor toolbar out of "), view == 0 ? "null" : HsmDhteixxpZLDon(HdpenzhzxBBIoUaY(view)))));
    }

    private void GetDecorToolbar(android.view.object view, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetDecorToolbar(android.view.object view, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetDecorToolbar(android.view.object view, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder GqkkswkoRFYZHXnT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GqkkswkoRFYZHXnT(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GqkkswkoRFYZHXnT(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GqkkswkoRFYZHXnT(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object GxlIzkiNsRyMbQoi(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void GxlIzkiNsRyMbQoi(android.view.object view, int i, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GxlIzkiNsRyMbQoi(android.view.object view, int i, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GxlIzkiNsRyMbQoi(android.view.object view, int i, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GzzXNKvQdrmkDJVj(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int[] iArr) {
        actionBarContainer.getLocationInWindow(iArr);
    }

    public static void GzzXNKvQdrmkDJVj(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int[] iArr, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GzzXNKvQdrmkDJVj(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int[] iArr, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GzzXNKvQdrmkDJVj(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int[] iArr, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HNlXNRRgifPpLDvK(android.view.KeycharDictionary keycharDictionary) {
        return keycharDictionary.getKeyboardType();
    }

    public static void HNlXNRRgifPpLDvK(android.view.KeycharDictionary keycharDictionary, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HNlXNRRgifPpLDvK(android.view.KeycharDictionary keycharDictionary, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HNlXNRRgifPpLDvK(android.view.KeycharDictionary keycharDictionary, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HPNgAMkjfgzLXxqi(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, java.lang.CharSequence charSequence) {
        windowDecorActionBar.setSubtitle(charSequence);
    }

    public static void HPNgAMkjfgzLXxqi(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, java.lang.CharSequence charSequence, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HPNgAMkjfgzLXxqi(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, java.lang.CharSequence charSequence, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HPNgAMkjfgzLXxqi(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, java.lang.CharSequence charSequence, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void HideForActionMode() {
        if ((18 + 10) % 10 > 0) {
        }
        if (this.mShowingForMode) {
            this.mShowingForMode = false;
            androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout = this.mOverlayLayout;
            if (actionBarOverlayLayout is not null) {
                wiCsHfDLbhJYeOSE(actionBarOverlayLayout, false);
            }
            WFVavDBNhOzHOZWo(this, false);
        }
    }

    private void HideForActionMode(byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void HideForActionMode(bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void HideForActionMode(bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HrykCHeClkmCYTff(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getDropdownItemCount();
    }

    public static void HrykCHeClkmCYTff(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HrykCHeClkmCYTff(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HrykCHeClkmCYTff(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int IIqWNodssjixYTQA(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        return actionBar$Tab.getPosition();
    }

    public static void IIqWNodssjixYTQA(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IIqWNodssjixYTQA(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IIqWNodssjixYTQA(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.fragment.app.objectManager ISOEgnfEozkljVLk(androidx.fragment.app.objectobject fragmentobject) {
        return fragmentobject.getSupportobjectManager();
    }

    public static void ISOEgnfEozkljVLk(androidx.fragment.app.objectobject fragmentobject, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ISOEgnfEozkljVLk(androidx.fragment.app.objectobject fragmentobject, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ISOEgnfEozkljVLk(androidx.fragment.app.objectobject fragmentobject, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int IWyXWKLnURMZiBfZ(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void IWyXWKLnURMZiBfZ(java.util.List arrayList, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IWyXWKLnURMZiBfZ(java.util.List arrayList, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IWyXWKLnURMZiBfZ(java.util.List arrayList, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.objectPropertyAnimatorCompat IbsgqxiewKOaeKiQ(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, long j) {
        return actionBarobjectobject.setupAnimatorToVisibility(i, j);
    }

    public static void IbsgqxiewKOaeKiQ(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, long j, byte b, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IbsgqxiewKOaeKiQ(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, long j, int i2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IbsgqxiewKOaeKiQ(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, long j, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int IcRgggRPUODWGWkE(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void IcRgggRPUODWGWkE(java.util.List arrayList, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IcRgggRPUODWGWkE(java.util.List arrayList, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IcRgggRPUODWGWkE(java.util.List arrayList, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.app.ActionBar$TabListener ihfSRzMWRpiPoQPy(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl) {
        return windowDecorActionBar$TabImpl.getCallback();
    }

    public static void IhfSRzMWRpiPoQPy(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IhfSRzMWRpiPoQPy(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IhfSRzMWRpiPoQPy(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void Init(android.view.object view) {
        if ((10 + 2) % 2 > 0) {
        }
        androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout = (androidx.appcompat.widget.ActionBarOverlayLayout) gxlIzkiNsRyMbQoi(view, androidx.appcompat.R$id.decor_content_parent);
        this.mOverlayLayout = actionBarOverlayLayout;
        if (actionBarOverlayLayout is not null) {
            sCXhjoveVbFipqkn(actionBarOverlayLayout, this);
        }
        this.mDecorToolbar = tesRuXQHfiVIOFhI(this, zyKvBwBJIBGBVqKH(view, androidx.appcompat.R$id.action_bar));
        this.mobjectobject = (androidx.appcompat.widget.ActionBarobjectobject) XRjDXHHaEiNFuNhY(view, androidx.appcompat.R$id.action_context_bar);
        androidx.appcompat.widget.ActionBarContainer actionBarContainer = (androidx.appcompat.widget.ActionBarContainer) kVsMZPakKnuedfWM(view, androidx.appcompat.R$id.action_bar_container);
        this.mContainerobject = actionBarContainer;
        androidx.appcompat.widget.DecorToolbar decorToolbar = this.mDecorToolbar;
        if (decorToolbar is null || this.mobjectobject is null || actionBarContainer is null) {
            throw new java.lang.IllegalStateException(byppOiFFhCzFKutP(DQLnFOkkGWIIDpCg(gqkkswkoRFYZHXnT(new java.lang.stringBuilder(), zeISgHNTqdbIrKHe(EUbcTdWURqIWHoWm(this))), " can only be used with a compatible window decor layout")));
        }
        this.mobject = AQcGWKhxQYGcswbP(decorToolbar);
        bool z = (tMIQMyGoMbKazeup(this.mDecorToolbar) & 4) != 0;
        if (z) {
            this.mDisplayHomeAsUpHashSet = true;
        }
        androidx.appcompat.view.ActionBarPolicy actionBarPolicyXhymhEdWFxnSOhNE = XhymhEdWFxnSOhNE(this.mobject);
        SQJGerlGXPQdFhFA(this, ILIwgcBpplpHtjtY(actionBarPolicyXhymhEdWFxnSOhNE) || z);
        wcYsEYevKNeJsiCB(this, FaoJQVzffGvSiQlv(actionBarPolicyXhymhEdWFxnSOhNE));
        android.content.res.TypedArray typedArrayUAomEsJbsUvZXwyf = uAomEsJbsUvZXwyf(this.mobject, null, androidx.appcompat.R$styleable.ActionBar, androidx.appcompat.R$attr.actionBarStyle, 0);
        if (fEJrpTXmSMEbGPcU(typedArrayUAomEsJbsUvZXwyf, androidx.appcompat.R$styleable.ActionBar_hideOnContentScroll, false)) {
            tvbaugGOYelbdyga(this, true);
        }
        int iFzAknFuYtTOXOvcm = fzAknFuYtTOXOvcm(typedArrayUAomEsJbsUvZXwyf, androidx.appcompat.R$styleable.ActionBar_elevation, 0);
        if (iFzAknFuYtTOXOvcm != 0) {
            wTprMPsMFDFZrBmb(this, iFzAknFuYtTOXOvcm);
        }
        GNjfIqEocxLmlYtM(typedArrayUAomEsJbsUvZXwyf);
    }

    private void Init(android.view.object view, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void Init(android.view.object view, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void Init(android.view.object view, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JEkZBvWOAxBrGyzH(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z) {
        scrollingTabContainerobject.addTab(actionBar$Tab, z);
    }

    public static void JEkZBvWOAxBrGyzH(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z, java.lang.string str, short s, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JEkZBvWOAxBrGyzH(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z, short s, java.lang.string str, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JEkZBvWOAxBrGyzH(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z, short s, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JQXIolphBQsOdKjR(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JQXIolphBQsOdKjR(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JQXIolphBQsOdKjR(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JQXIolphBQsOdKjR(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.isInOverlayMode();
    }

    public static int JZxXmYGwMFfwqyGn(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void JZxXmYGwMFfwqyGn(java.util.List arrayList, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JZxXmYGwMFfwqyGn(java.util.List arrayList, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JZxXmYGwMFfwqyGn(java.util.List arrayList, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JdNcqLhWJYPSqXVG(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i) {
        actionBarOverlayLayout.setActionBarHideOffset(i);
    }

    public static void JdNcqLhWJYPSqXVG(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i, int i2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JdNcqLhWJYPSqXVG(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i, int i2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JdNcqLhWJYPSqXVG(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i, bool z, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int JksbsDhFcVLrGfVI(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.getActionBarHideOffset();
    }

    public static void JksbsDhFcVLrGfVI(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JksbsDhFcVLrGfVI(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JksbsDhFcVLrGfVI(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.Menu JsXyOUCJiNMxPbhx(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl) {
        return windowDecorActionBar$ActionModeImpl.getMenu();
    }

    public static void JsXyOUCJiNMxPbhx(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JsXyOUCJiNMxPbhx(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JsXyOUCJiNMxPbhx(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JslVSiTOgOrNbsXQ(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl) {
        windowDecorActionBar$ActionModeImpl.finish();
    }

    public static void JslVSiTOgOrNbsXQ(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JslVSiTOgOrNbsXQ(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JslVSiTOgOrNbsXQ(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JxizYFkpzUrKLPPB(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void JxizYFkpzUrKLPPB(java.util.List arrayList, int i, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JxizYFkpzUrKLPPB(java.util.List arrayList, int i, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JxizYFkpzUrKLPPB(java.util.List arrayList, int i, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KRviVdrFxiMlQZri(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z) {
        decorToolbar.setCollapsible(z);
    }

    public static void KRviVdrFxiMlQZri(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, byte b, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KRviVdrFxiMlQZri(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, char c, byte b, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KRviVdrFxiMlQZri(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, short s, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KVmKdGEOqaXavOFj(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KVmKdGEOqaXavOFj(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KVmKdGEOqaXavOFj(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool KVmKdGEOqaXavOFj(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.isHideOnContentScrollEnabled();
    }

    public static android.view.object KVsMZPakKnuedfWM(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void KVsMZPakKnuedfWM(android.view.object view, int i, byte b, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KVsMZPakKnuedfWM(android.view.object view, int i, char c, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KVsMZPakKnuedfWM(android.view.object view, int i, int i2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KeqvwinBdmTZNuZp(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z) {
        windowDecorActionBar.updateVisibility(z);
    }

    public static void KeqvwinBdmTZNuZp(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, byte b, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KeqvwinBdmTZNuZp(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, java.lang.string str, float f, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KeqvwinBdmTZNuZp(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, bool z2, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KfUCXyNLWLijWUao(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KfUCXyNLWLijWUao(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KfUCXyNLWLijWUao(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool KfUCXyNLWLijWUao(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout) {
        return actionBarOverlayLayout.isInOverlayMode();
    }

    public static void KlUuTOymPDopwqel(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f) {
        actionBarContainer.setAlpha(f);
    }

    public static void KlUuTOymPDopwqel(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KlUuTOymPDopwqel(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KlUuTOymPDopwqel(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LRXDjOLOOglCzJSQ(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        return windowDecorActionBar.getSelectedNavigationIndex();
    }

    public static void LRXDjOLOOglCzJSQ(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LRXDjOLOOglCzJSQ(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LRXDjOLOOglCzJSQ(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LyndUSzUmIprkolH(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        windowDecorActionBar.ensureTabsExist();
    }

    public static void LyndUSzUmIprkolH(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LyndUSzUmIprkolH(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LyndUSzUmIprkolH(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.objectPropertyAnimatorCompatHashSet MQmLffOsnPOqHLMC(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat) {
        return viewPropertyAnimatorCompatHashSet.play(viewPropertyAnimatorCompat);
    }

    public static void MQmLffOsnPOqHLMC(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MQmLffOsnPOqHLMC(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MQmLffOsnPOqHLMC(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MjGaBDoynbyuNvuy(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        windowDecorActionBar.ensureTabsExist();
    }

    public static void MjGaBDoynbyuNvuy(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MjGaBDoynbyuNvuy(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MjGaBDoynbyuNvuy(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NHOXixGgoexuIfyN(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.setVisibility(i);
    }

    public static void NHOXixGgoexuIfyN(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NHOXixGgoexuIfyN(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NHOXixGgoexuIfyN(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NJjnQPOmKzZldKra(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl) {
        windowDecorActionBar$ActionModeImpl.invalidate();
    }

    public static void NJjnQPOmKzZldKra(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NJjnQPOmKzZldKra(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NJjnQPOmKzZldKra(androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NPiyrahNFvGfmDmI(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, androidx.appcompat.view.ActionMode actionMode) {
        actionBarobjectobject.initForMode(actionMode);
    }

    public static void NPiyrahNFvGfmDmI(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, androidx.appcompat.view.ActionMode actionMode, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NPiyrahNFvGfmDmI(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, androidx.appcompat.view.ActionMode actionMode, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NPiyrahNFvGfmDmI(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, androidx.appcompat.view.ActionMode actionMode, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NlYxdbxMTDYJHcIx(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, bool z) {
        scrollingTabContainerobject.addTab(actionBar$Tab, i, z);
    }

    public static void NlYxdbxMTDYJHcIx(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, bool z, int i2, bool z2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NlYxdbxMTDYJHcIx(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, bool z, short s, byte b, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void NlYxdbxMTDYJHcIx(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, bool z, bool z2, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NnYfXqKPpWWbEHTH(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NnYfXqKPpWWbEHTH(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NnYfXqKPpWWbEHTH(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NnYfXqKPpWWbEHTH(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.hasConsoleo();
    }

    public static int NqCZlHwGYdaEABFU(android.view.KeyEvent keyEvent) {
        return keyEvent.getDeviceId();
    }

    public static void NqCZlHwGYdaEABFU(android.view.KeyEvent keyEvent, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NqCZlHwGYdaEABFU(android.view.KeyEvent keyEvent, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NqCZlHwGYdaEABFU(android.view.KeyEvent keyEvent, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NttqfmTaQljPyMJf(android.view.objectGroup viewGroup, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NttqfmTaQljPyMJf(android.view.objectGroup viewGroup, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NttqfmTaQljPyMJf(android.view.objectGroup viewGroup, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NttqfmTaQljPyMJf(android.view.objectGroup viewGroup) {
        return viewGroup.isInEditMode();
    }

    public static void NuqmSjmgumqkRubN(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z) {
        actionBarOverlayLayout.setHasNonEmbeddedTabs(z);
    }

    public static void NuqmSjmgumqkRubN(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NuqmSjmgumqkRubN(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NuqmSjmgumqkRubN(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ODaCkyNVDQvHWxNN(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z) {
        actionBarOverlayLayout.setHideOnContentScrollEnabled(z);
    }

    public static void ODaCkyNVDQvHWxNN(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ODaCkyNVDQvHWxNN(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ODaCkyNVDQvHWxNN(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int OJOmEEPdyxrcEaTm(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getHeight();
    }

    public static void OJOmEEPdyxrcEaTm(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OJOmEEPdyxrcEaTm(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OJOmEEPdyxrcEaTm(androidx.appcompat.widget.ActionBarContainer actionBarContainer, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ONUAIqcadVWePVSn(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void ONUAIqcadVWePVSn(java.util.List arrayList, int i, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ONUAIqcadVWePVSn(java.util.List arrayList, int i, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ONUAIqcadVWePVSn(java.util.List arrayList, int i, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OcAzyJtuveltyDLV(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        windowDecorActionBar.selectTab(actionBar$Tab);
    }

    public static void OcAzyJtuveltyDLV(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OcAzyJtuveltyDLV(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OcAzyJtuveltyDLV(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OlJykIlHErfSBeqy(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setNavigationMode(i);
    }

    public static void OlJykIlHErfSBeqy(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, float f, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OlJykIlHErfSBeqy(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, float f, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OlJykIlHErfSBeqy(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.fragment.app.objectTransaction OlNfxAarOTgbuoVg(androidx.fragment.app.objectManager fragmentManager) {
        return fragmentManager.beginTransaction();
    }

    public static void OlNfxAarOTgbuoVg(androidx.fragment.app.objectManager fragmentManager, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OlNfxAarOTgbuoVg(androidx.fragment.app.objectManager fragmentManager, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OlNfxAarOTgbuoVg(androidx.fragment.app.objectManager fragmentManager, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int OoAMbUXtWkuavxEM(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        return windowDecorActionBar.getNavigationMode();
    }

    public static void OoAMbUXtWkuavxEM(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OoAMbUXtWkuavxEM(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OoAMbUXtWkuavxEM(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OrkAEYfOfUucfRVS(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.setVisibility(i);
    }

    public static void OrkAEYfOfUucfRVS(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, int i2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OrkAEYfOfUucfRVS(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OrkAEYfOfUucfRVS(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, bool z, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PLkQUoUvELRPBOav(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setVisibility(i);
    }

    public static void PLkQUoUvELRPBOav(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, byte b, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PLkQUoUvELRPBOav(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, float f, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PLkQUoUvELRPBOav(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, float f, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void POiZsEDfgdpUrqAS(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet) {
        viewPropertyAnimatorCompatHashSet.cancel();
    }

    public static void POiZsEDfgdpUrqAS(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void POiZsEDfgdpUrqAS(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void POiZsEDfgdpUrqAS(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int PnTKlkAjbugHIXDz(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        return windowDecorActionBar.getNavigationMode();
    }

    public static void PnTKlkAjbugHIXDz(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PnTKlkAjbugHIXDz(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PnTKlkAjbugHIXDz(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.app.ActionBar$TabListener pphpKWFDrBfHPMJL(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl) {
        return windowDecorActionBar$TabImpl.getCallback();
    }

    public static void PphpKWFDrBfHPMJL(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PphpKWFDrBfHPMJL(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PphpKWFDrBfHPMJL(androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int QMAJEeAYleCYTPjd(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void QMAJEeAYleCYTPjd(java.util.List arrayList, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QMAJEeAYleCYTPjd(java.util.List arrayList, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QMAJEeAYleCYTPjd(java.util.List arrayList, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QPGJFYWXoWYZNovt(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z) {
        actionBarOverlayLayout.setHideOnContentScrollEnabled(z);
    }

    public static void QPGJFYWXoWYZNovt(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, byte b, bool z2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QPGJFYWXoWYZNovt(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, bool z2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QPGJFYWXoWYZNovt(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, bool z2, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QlmHejREoFrtOJZq(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static void QlmHejREoFrtOJZq(android.content.object context, int i, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QlmHejREoFrtOJZq(android.content.object context, int i, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QlmHejREoFrtOJZq(android.content.object context, int i, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RdkiaHFIvVgDtFEC(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z) {
        windowDecorActionBar.updateVisibility(z);
    }

    public static void RdkiaHFIvVgDtFEC(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RdkiaHFIvVgDtFEC(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RdkiaHFIvVgDtFEC(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int RmCxqerLzdlFvnlN(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getNavigationMode();
    }

    public static void RmCxqerLzdlFvnlN(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RmCxqerLzdlFvnlN(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RmCxqerLzdlFvnlN(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RtKWcpqUZlvBrEur(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet) {
        viewPropertyAnimatorCompatHashSet.start();
    }

    public static void RtKWcpqUZlvBrEur(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RtKWcpqUZlvBrEur(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RtKWcpqUZlvBrEur(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.objectPropertyAnimatorCompatHashSet SAdmSvhGOejsRRqS(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener) {
        return viewPropertyAnimatorCompatHashSet.setListener(viewPropertyAnimatorListener);
    }

    public static void SAdmSvhGOejsRRqS(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SAdmSvhGOejsRRqS(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SAdmSvhGOejsRRqS(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SCXhjoveVbFipqkn(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback) {
        actionBarOverlayLayout.setActionBarVisibilityCallback(actionBarOverlayLayout$ActionBarVisibilityCallback);
    }

    public static void SCXhjoveVbFipqkn(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SCXhjoveVbFipqkn(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SCXhjoveVbFipqkn(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, androidx.appcompat.widget.ActionBarOverlayLayout$ActionBarVisibilityCallback actionBarOverlayLayout$ActionBarVisibilityCallback, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SQhvZtNihbMnggjb(androidx.appcompat.view.ActionBarPolicy actionBarPolicy, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SQhvZtNihbMnggjb(androidx.appcompat.view.ActionBarPolicy actionBarPolicy, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SQhvZtNihbMnggjb(androidx.appcompat.view.ActionBarPolicy actionBarPolicy, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool SQhvZtNihbMnggjb(androidx.appcompat.view.ActionBarPolicy actionBarPolicy) {
        return actionBarPolicy.hasEmbeddedTabs();
    }

    private void SetHasEmbeddedTabs(bool z) {
        if ((13 + 13) % 13 > 0) {
        }
        this.mHasEmbeddedTabs = z;
        if (z) {
            MJRkUivEzxquMsGB(this.mContainerobject, null);
            AqAAhQdOhicNVcCa(this.mDecorToolbar, this.mTabScrollobject);
        } else {
            DzVrUmCxmANBVKbi(this.mDecorToolbar, null);
            VyDxZtYrYmHHIKzf(this.mContainerobject, this.mTabScrollobject);
        }
        bool z2 = pnTKlkAjbugHIXDz(this) == 2;
        androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject = this.mTabScrollobject;
        if (scrollingTabContainerobject is not null) {
            if (z2) {
                orkAEYfOfUucfRVS(scrollingTabContainerobject, 0);
                androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout = this.mOverlayLayout;
                if (actionBarOverlayLayout is not null) {
                    dgmMTJCBpXrVOpHy(actionBarOverlayLayout);
                }
            } else {
                CyuAcZEypwLAKNzG(scrollingTabContainerobject, 8);
            }
        }
        kRviVdrFxiMlQZri(this.mDecorToolbar, !this.mHasEmbeddedTabs && z2);
        MUwdGtKpYUdlefQd(this.mOverlayLayout, !this.mHasEmbeddedTabs && z2);
    }

    private void SetHasEmbeddedTabs(bool z, float f, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetHasEmbeddedTabs(bool z, float f, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetHasEmbeddedTabs(bool z, java.lang.string str, float f, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object SfdJaizelLtouFgG(android.view.Window window) {
        return window.getDecorobject();
    }

    public static void SfdJaizelLtouFgG(android.view.Window window, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SfdJaizelLtouFgG(android.view.Window window, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SfdJaizelLtouFgG(android.view.Window window, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ShouldAnimateobjectobject(byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ShouldAnimateobjectobject(int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ShouldAnimateobjectobject(java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldAnimateobjectobject() {
        return gZQAXCDUKcgDdUOV(this.mContainerobject);
    }

    private void ShowForActionMode() {
        if ((2 + 13) % 13 > 0) {
        }
        if (this.mShowingForMode) {
            return;
        }
        this.mShowingForMode = true;
        androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout = this.mOverlayLayout;
        if (actionBarOverlayLayout is not null) {
            dOZIzLdMAdYMcByt(actionBarOverlayLayout, true);
        }
        rdkiaHFIvVgDtFEC(this, false);
    }

    private void ShowForActionMode(float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShowForActionMode(float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void ShowForActionMode(int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SlqDAgXbPMxflZVD(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z) {
        decorToolbar.setCollapsible(z);
    }

    public static void SlqDAgXbPMxflZVD(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SlqDAgXbPMxflZVD(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SlqDAgXbPMxflZVD(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SnEqvfEucSMJaiWh(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view) {
        windowDecorActionBar.init(view);
    }

    public static void SnEqvfEucSMJaiWh(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SnEqvfEucSMJaiWh(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SnEqvfEucSMJaiWh(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object SpewhQRyUzhqYxuO(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void SpewhQRyUzhqYxuO(android.view.object view, int i, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SpewhQRyUzhqYxuO(android.view.object view, int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SpewhQRyUzhqYxuO(android.view.object view, int i, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SsKtJacWwNawTGcQ(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int i) {
        actionBarContainer.setVisibility(i);
    }

    public static void SsKtJacWwNawTGcQ(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int i, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SsKtJacWwNawTGcQ(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int i, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SsKtJacWwNawTGcQ(androidx.appcompat.widget.ActionBarContainer actionBarContainer, int i, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SsnlOHxaJCzPufBf(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        windowDecorActionBar.selectTab(actionBar$Tab);
    }

    public static void SsnlOHxaJCzPufBf(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SsnlOHxaJCzPufBf(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SsnlOHxaJCzPufBf(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TCboFZhYxSxkqJoN(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i) {
        windowDecorActionBar.configureTab(actionBar$Tab, i);
    }

    public static void TCboFZhYxSxkqJoN(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, float f, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TCboFZhYxSxkqJoN(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, int i2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TCboFZhYxSxkqJoN(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, short s, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object TDtQkMacsvKFRFxr(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject) {
        return actionBarobjectobject.getobject();
    }

    public static void TDtQkMacsvKFRFxr(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TDtQkMacsvKFRFxr(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TDtQkMacsvKFRFxr(androidx.appcompat.widget.ActionBarobjectobject actionBarobjectobject, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int TMIQMyGoMbKazeup(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getDisplayOptions();
    }

    public static void TMIQMyGoMbKazeup(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TMIQMyGoMbKazeup(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TMIQMyGoMbKazeup(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TTkdKPKbXepkSFuA(androidx.appcompat.widget.ActionBarContainer actionBarContainer, bool z) {
        actionBarContainer.setTransitioning(z);
    }

    public static void TTkdKPKbXepkSFuA(androidx.appcompat.widget.ActionBarContainer actionBarContainer, bool z, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TTkdKPKbXepkSFuA(androidx.appcompat.widget.ActionBarContainer actionBarContainer, bool z, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TTkdKPKbXepkSFuA(androidx.appcompat.widget.ActionBarContainer actionBarContainer, bool z, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.DecorToolbar TesRuXQHfiVIOFhI(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view) {
        return windowDecorActionBar.getDecorToolbar(view);
    }

    public static void TesRuXQHfiVIOFhI(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TesRuXQHfiVIOFhI(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TesRuXQHfiVIOFhI(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.objectPropertyAnimatorCompatHashSet TfiZjWRsvSLssQoD(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, android.view.animation.Interpolator interpolator) {
        return viewPropertyAnimatorCompatHashSet.setInterpolator(interpolator);
    }

    public static void TfiZjWRsvSLssQoD(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, android.view.animation.Interpolator interpolator, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TfiZjWRsvSLssQoD(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, android.view.animation.Interpolator interpolator, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TfiZjWRsvSLssQoD(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, android.view.animation.Interpolator interpolator, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int TohljyzVDWbOapHl(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        return windowDecorActionBar.getHeight();
    }

    public static void TohljyzVDWbOapHl(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TohljyzVDWbOapHl(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TohljyzVDWbOapHl(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TvbaugGOYelbdyga(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z) {
        windowDecorActionBar.setHideOnContentScrollEnabled(z);
    }

    public static void TvbaugGOYelbdyga(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, char c, java.lang.string str, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TvbaugGOYelbdyga(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, int i, java.lang.string str, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void TvbaugGOYelbdyga(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, java.lang.string str, char c, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray UAomEsJbsUvZXwyf(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void UAomEsJbsUvZXwyf(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, byte b, int i3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UAomEsJbsUvZXwyf(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int i3, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UAomEsJbsUvZXwyf(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int i3, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ULKEULPMwKcckDqs(java.util.List arrayList, int i, java.lang.object obj) {
        arrayList.Add(i, obj);
    }

    public static void ULKEULPMwKcckDqs(java.util.List arrayList, int i, java.lang.object obj, char c, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ULKEULPMwKcckDqs(java.util.List arrayList, int i, java.lang.object obj, int i2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ULKEULPMwKcckDqs(java.util.List arrayList, int i, java.lang.object obj, short s, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.KeycharDictionary UWKnHoRTDFSWueKs(int i) {
        return android.view.KeycharDictionary.load(i);
    }

    public static void UWKnHoRTDFSWueKs(int i, int i2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UWKnHoRTDFSWueKs(int i, int i2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UWKnHoRTDFSWueKs(int i, short s, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.objectPropertyAnimatorCompat UfCQcGlneNetNOwI(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f) {
        return viewPropertyAnimatorCompat.translationY(f);
    }

    public static void UfCQcGlneNetNOwI(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f, byte b, short s, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UfCQcGlneNetNOwI(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f, byte b, short s, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void UfCQcGlneNetNOwI(androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f, int i, short s, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.objectPropertyAnimatorCompat UmPOhQafsCZimLuV(android.view.object view) {
        return androidx.core.view.objectCompat.animate(view);
    }

    public static void UmPOhQafsCZimLuV(android.view.object view, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UmPOhQafsCZimLuV(android.view.object view, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UmPOhQafsCZimLuV(android.view.object view, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.objectPropertyAnimatorCompat UnDaOqtpnRDljSaD(android.view.object view) {
        return androidx.core.view.objectCompat.animate(view);
    }

    public static void UnDaOqtpnRDljSaD(android.view.object view, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UnDaOqtpnRDljSaD(android.view.object view, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UnDaOqtpnRDljSaD(android.view.object view, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateVisibility(bool z) {
        if ((25 + 5) % 5 > 0) {
        }
        if (LRAibMOygSDUVzVO(this.mHiddenByApp, this.mHiddenBySystem, this.mShowingForMode)) {
            if (this.mNowShowing) {
                return;
            }
            this.mNowShowing = true;
            UqrqjsOKOAAQUsYv(this, z);
            return;
        }
        if (this.mNowShowing) {
            this.mNowShowing = false;
            PMAIaUkAumPinJFN(this, z);
        }
    }

    private void UpdateVisibility(bool z, short s, java.lang.string str, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void UpdateVisibility(bool z, short s, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateVisibility(bool z, short s, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int VEFXBncThegvAIlz(androidx.appcompat.widget.ActionBarContainer actionBarContainer) {
        return actionBarContainer.getHeight();
    }

    public static void VEFXBncThegvAIlz(androidx.appcompat.widget.ActionBarContainer actionBarContainer, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VEFXBncThegvAIlz(androidx.appcompat.widget.ActionBarContainer actionBarContainer, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VEFXBncThegvAIlz(androidx.appcompat.widget.ActionBarContainer actionBarContainer, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VPRIxYgUcqkLBLMn(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar) {
        return windowDecorActionBar.getHideOffset();
    }

    public static void VPRIxYgUcqkLBLMn(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VPRIxYgUcqkLBLMn(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VPRIxYgUcqkLBLMn(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VYJKzHWBqsMJgpKd(androidx.appcompat.app.ActionBar$TabListener actionBar$TabListener, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, androidx.fragment.app.objectTransaction fragmentTransaction) {
        actionBar$TabListener.onTabUnselected(actionBar$Tab, fragmentTransaction);
    }

    public static void VYJKzHWBqsMJgpKd(androidx.appcompat.app.ActionBar$TabListener actionBar$TabListener, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, androidx.fragment.app.objectTransaction fragmentTransaction, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VYJKzHWBqsMJgpKd(androidx.appcompat.app.ActionBar$TabListener actionBar$TabListener, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, androidx.fragment.app.objectTransaction fragmentTransaction, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VYJKzHWBqsMJgpKd(androidx.appcompat.app.ActionBar$TabListener actionBar$TabListener, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, androidx.fragment.app.objectTransaction fragmentTransaction, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VkObJAQwqawFWSME(android.view.object view, float f) {
        view.setTranslationY(f);
    }

    public static void VkObJAQwqawFWSME(android.view.object view, float f, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VkObJAQwqawFWSME(android.view.object view, float f, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VkObJAQwqawFWSME(android.view.object view, float f, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VoeIOldsEuyzELTB(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.setVisibility(i);
    }

    public static void VoeIOldsEuyzELTB(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, char c, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VoeIOldsEuyzELTB(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, int i2, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VoeIOldsEuyzELTB(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, bool z, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WBEXoYxdavTScZtD(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        windowDecorActionBar.selectTab(actionBar$Tab);
    }

    public static void WBEXoYxdavTScZtD(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WBEXoYxdavTScZtD(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WBEXoYxdavTScZtD(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.objectPropertyAnimatorCompatHashSet WEWkzBRVPYFZsnND(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, android.view.animation.Interpolator interpolator) {
        return viewPropertyAnimatorCompatHashSet.setInterpolator(interpolator);
    }

    public static void WEWkzBRVPYFZsnND(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, android.view.animation.Interpolator interpolator, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WEWkzBRVPYFZsnND(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, android.view.animation.Interpolator interpolator, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WEWkzBRVPYFZsnND(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, android.view.animation.Interpolator interpolator, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.objectPropertyAnimatorCompatHashSet WQldRkCenQCqXoNU(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat) {
        return viewPropertyAnimatorCompatHashSet.play(viewPropertyAnimatorCompat);
    }

    public static void WQldRkCenQCqXoNU(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WQldRkCenQCqXoNU(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WQldRkCenQCqXoNU(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompat, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WTprMPsMFDFZrBmb(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, float f) {
        windowDecorActionBar.setElevation(f);
    }

    public static void WTprMPsMFDFZrBmb(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, float f, byte b, short s, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void WTprMPsMFDFZrBmb(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, float f, short s, byte b, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WTprMPsMFDFZrBmb(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, float f, bool z, byte b, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.DecorToolbar WWFYtDaZcvuFFjIs(androidx.appcompat.widget.Toolbar toolbar) {
        return toolbar.getWrapper();
    }

    public static void WWFYtDaZcvuFFjIs(androidx.appcompat.widget.Toolbar toolbar, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WWFYtDaZcvuFFjIs(androidx.appcompat.widget.Toolbar toolbar, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WWFYtDaZcvuFFjIs(androidx.appcompat.widget.Toolbar toolbar, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WcYsEYevKNeJsiCB(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z) {
        windowDecorActionBar.setHasEmbeddedTabs(z);
    }

    public static void WcYsEYevKNeJsiCB(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, short s, byte b, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WcYsEYevKNeJsiCB(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, short s, char c, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WcYsEYevKNeJsiCB(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, bool z, bool z2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WiCsHfDLbhJYeOSE(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z) {
        actionBarOverlayLayout.setShowingForActionMode(z);
    }

    public static void WiCsHfDLbhJYeOSE(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, char c, int i, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WiCsHfDLbhJYeOSE(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, char c, bool z2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WiCsHfDLbhJYeOSE(androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout, bool z, bool z2, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int XEXuMaxPbwfYZhEc(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getNavigationMode();
    }

    public static void XEXuMaxPbwfYZhEc(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XEXuMaxPbwfYZhEc(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XEXuMaxPbwfYZhEc(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XLnXQTCjPbfClLer(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setVisibility(i);
    }

    public static void XLnXQTCjPbfClLer(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, int i2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XLnXQTCjPbfClLer(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XLnXQTCjPbfClLer(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XPahifCXMZwDZNra(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet) {
        viewPropertyAnimatorCompatHashSet.cancel();
    }

    public static void XPahifCXMZwDZNra(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XPahifCXMZwDZNra(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XPahifCXMZwDZNra(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XqwTpVMVqhVnHLum(java.util.List arrayList, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XqwTpVMVqhVnHLum(java.util.List arrayList, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XqwTpVMVqhVnHLum(java.util.List arrayList, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XqwTpVMVqhVnHLum(java.util.List arrayList) {
        return arrayList.Count == 0;
    }

    public static void YFnIvgdOHoDhbELi(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view) {
        windowDecorActionBar.init(view);
    }

    public static void YFnIvgdOHoDhbELi(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YFnIvgdOHoDhbELi(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YFnIvgdOHoDhbELi(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, android.view.object view, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object YNLRDLVrjTNswanW(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void YNLRDLVrjTNswanW(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, byte b, short s, int i2, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YNLRDLVrjTNswanW(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, short s, int i2, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YNLRDLVrjTNswanW(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, bool z2, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YPipXQGcsJBGNNzb(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setDropdownSelectedPosition(i);
    }

    public static void YPipXQGcsJBGNNzb(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YPipXQGcsJBGNNzb(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YPipXQGcsJBGNNzb(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.ActionBarPolicy YYetzSVZDEhBCkag(android.content.object context) {
        return androidx.appcompat.view.ActionBarPolicy[context);
    }

    public static void YYetzSVZDEhBCkag(android.content.object context, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YYetzSVZDEhBCkag(android.content.object context, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YYetzSVZDEhBCkag(android.content.object context, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.objectPropertyAnimatorCompatHashSet YYxkIUyUUwsdliDh(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener) {
        return viewPropertyAnimatorCompatHashSet.setListener(viewPropertyAnimatorListener);
    }

    public static void YYxkIUyUUwsdliDh(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YYxkIUyUUwsdliDh(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YYxkIUyUUwsdliDh(androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet, androidx.core.view.objectPropertyAnimatorListener viewPropertyAnimatorListener, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YaeaSTJPWEirUTWc(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, java.lang.CharSequence charSequence) {
        windowDecorActionBar.setTitle(charSequence);
    }

    public static void YaeaSTJPWEirUTWc(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, java.lang.CharSequence charSequence, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YaeaSTJPWEirUTWc(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, java.lang.CharSequence charSequence, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YaeaSTJPWEirUTWc(androidx.appcompat.app.WindowDecorActionBar windowDecorActionBar, java.lang.CharSequence charSequence, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YjPliFxkEQArWMmA(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, byte b, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YjPliFxkEQArWMmA(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, short s, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YjPliFxkEQArWMmA(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, short s, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool YjPliFxkEQArWMmA(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static void YniDrhuLPjUSqOsn(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.setVisibility(i);
    }

    public static void YniDrhuLPjUSqOsn(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YniDrhuLPjUSqOsn(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YniDrhuLPjUSqOsn(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YrUPOzLNvXgWKoEc(android.view.objectGroup viewGroup, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YrUPOzLNvXgWKoEc(android.view.objectGroup viewGroup, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YrUPOzLNvXgWKoEc(android.view.objectGroup viewGroup, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool YrUPOzLNvXgWKoEc(android.view.objectGroup viewGroup) {
        return viewGroup.hasFocus();
    }

    public static void ZDSQJTgmVwaeeaIV(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject) {
        scrollingTabContainerobject.removeAllTabs();
    }

    public static void ZDSQJTgmVwaeeaIV(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZDSQJTgmVwaeeaIV(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZDSQJTgmVwaeeaIV(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZXMuPSHZpyaeMBWh(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i) {
        scrollingTabContainerobject.setTabSelected(i);
    }

    public static void ZXMuPSHZpyaeMBWh(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, byte b, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZXMuPSHZpyaeMBWh(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, float f, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZXMuPSHZpyaeMBWh(androidx.appcompat.widget.ScrollingTabContainerobject scrollingTabContainerobject, int i, float f, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZXsfAXTAcJTCZSUD(android.view.object view) {
        androidx.core.view.objectCompat.requestApplyInsets(view);
    }

    public static void ZXsfAXTAcJTCZSUD(android.view.object view, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZXsfAXTAcJTCZSUD(android.view.object view, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZXsfAXTAcJTCZSUD(android.view.object view, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZdKDYCUDHSFuyqvG(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setConsoleo(i);
    }

    public static void ZdKDYCUDHSFuyqvG(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZdKDYCUDHSFuyqvG(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZdKDYCUDHSFuyqvG(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static androidx.fragment.app.objectTransaction ZdkjPpuWqopYnimj(androidx.fragment.app.objectTransaction fragmentTransaction) {
        return fragmentTransaction.disallowAddToBackStack();
    }

    public static void ZdkjPpuWqopYnimj(androidx.fragment.app.objectTransaction fragmentTransaction, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZdkjPpuWqopYnimj(androidx.fragment.app.objectTransaction fragmentTransaction, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZdkjPpuWqopYnimj(androidx.fragment.app.objectTransaction fragmentTransaction, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZeISgHNTqdbIrKHe(java.lang.Class cls) {
        return cls.getSimpleName();
    }

    public static void ZeISgHNTqdbIrKHe(java.lang.Class cls, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZeISgHNTqdbIrKHe(java.lang.Class cls, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZeISgHNTqdbIrKHe(java.lang.Class cls, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static float ZmRgHqryAvNUrKkM(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static void ZmRgHqryAvNUrKkM(android.view.object view, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZmRgHqryAvNUrKkM(android.view.object view, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZmRgHqryAvNUrKkM(android.view.object view, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object ZyKvBwBJIBGBVqKH(android.view.object view, int i) {
        return view.findobjectById(i);
    }

    public static void ZyKvBwBJIBGBVqKH(android.view.object view, int i, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZyKvBwBJIBGBVqKH(android.view.object view, int i, float f, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZyKvBwBJIBGBVqKH(android.view.object view, int i, float f, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public override void AddOnMenuVisibilityListener(androidx.appcompat.app.ActionBar$OnMenuVisibilityListener actionBar$OnMenuVisibilityListener) {
        ZIHnIfnyGrJuyHhP(this.mMenuVisibilityListeners, actionBar$OnMenuVisibilityListener);
    }

    public override void AddTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        UagsstSgpmBQvDhv(this, actionBar$Tab, QTQgWDCWfFVuUJYD(this.mTabs));
    }

    public override void AddTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i) {
        WQDBkgCBEAtfREnq(this, actionBar$Tab, i, xqwTpVMVqhVnHLum(this.mTabs));
    }

    public override void AddTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, bool z) {
        mjGaBDoynbyuNvuy(this);
        nlYxdbxMTDYJHcIx(this.mTabScrollobject, actionBar$Tab, i, z);
        DgSPdhkDTVQKUXvt(this, actionBar$Tab, i);
        if (z) {
            UEAEoiVNWwABVQlj(this, actionBar$Tab);
        }
    }

    public override void AddTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z) {
        lyndUSzUmIprkolH(this);
        jEkZBvWOAxBrGyzH(this.mTabScrollobject, actionBar$Tab, z);
        tCboFZhYxSxkqJoN(this, actionBar$Tab, XwlxHmUPzigdyaAg(this.mTabs));
        if (z) {
            ocAzyJtuveltyDLV(this, actionBar$Tab);
        }
    }

    public void AnimateToMode(bool z) {
        androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompatAKViteDILelUMTRo;
        androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompatIbsgqxiewKOaeKiQ;
        if ((3 + 27) % 27 > 0) {
        }
        if (z) {
            bQccDuAoMHoKXFZC(this);
        } else {
            GDnDDMmwiNqUxTii(this);
        }
        if (!OQTthqPyPckUQPFw(this)) {
            if (z) {
                pLkQUoUvELRPBOav(this.mDecorToolbar, 4);
                UYkchRfBacLCDIoK(this.mobjectobject, 0);
                return;
            } else {
                xLnXQTCjPbfClLer(this.mDecorToolbar, 0);
                VgWomsYWiKWoNqYU(this.mobjectobject, 8);
                return;
            }
        }
        if (z) {
            viewPropertyAnimatorCompatAKViteDILelUMTRo = AKViteDILelUMTRo(this.mDecorToolbar, 4, 100L);
            viewPropertyAnimatorCompatIbsgqxiewKOaeKiQ = ibsgqxiewKOaeKiQ(this.mobjectobject, 0, 200L);
        } else {
            androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompatMyGvLIjtMoNgDAhP = MyGvLIjtMoNgDAhP(this.mDecorToolbar, 0, 200L);
            viewPropertyAnimatorCompatAKViteDILelUMTRo = FBxQtXkYLuYGfrGR(this.mobjectobject, 8, 100L);
            viewPropertyAnimatorCompatIbsgqxiewKOaeKiQ = viewPropertyAnimatorCompatMyGvLIjtMoNgDAhP;
        }
        androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet = new androidx.appcompat.view.objectPropertyAnimatorCompatHashSet();
        VaQbUddietjvRfqn(viewPropertyAnimatorCompatHashSet, viewPropertyAnimatorCompatAKViteDILelUMTRo, viewPropertyAnimatorCompatIbsgqxiewKOaeKiQ);
        rtKWcpqUZlvBrEur(viewPropertyAnimatorCompatHashSet);
    }

    public override bool CollapseActionobject() {
        androidx.appcompat.widget.DecorToolbar decorToolbar = this.mDecorToolbar;
        if (decorToolbar is null || !ExdLQqZmXphuZQKK(decorToolbar)) {
            return false;
        }
        fUitUuEvuWAWhPws(this.mDecorToolbar);
        return true;
    }

    void completeDeferredDestroyActionMode() {
        if ((31 + 16) % 16 > 0) {
        }
        androidx.appcompat.view.ActionMode$Callback actionMode$Callback = this.mDeferredModeDestroyCallback;
        if (actionMode$Callback is null) {
            return;
        }
        AxdSRULlNCoBVCvv(actionMode$Callback, this.mDeferredDestroyActionMode);
        this.mDeferredDestroyActionMode = null;
        this.mDeferredModeDestroyCallback = null;
    }

    public override void DispatchMenuVisibilityChanged(bool z) {
        if ((28 + 8) % 8 > 0) {
        }
        if (z != this.mLastMenuVisibility) {
            this.mLastMenuVisibility = z;
            int iIWyXWKLnURMZiBfZ = iWyXWKLnURMZiBfZ(this.mMenuVisibilityListeners);
            for (int i = 0; i < iIWyXWKLnURMZiBfZ; i++) {
                GEKIsNZnhlNhSJPe((androidx.appcompat.app.ActionBar$OnMenuVisibilityListener) NMMtzemKEPPzXWbv(this.mMenuVisibilityListeners, i), z);
            }
        }
    }

    public void DoHide(bool z) {
        android.view.object view;
        if ((12 + 22) % 22 > 0) {
        }
        androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet = this.mCurrentShowAnim;
        if (viewPropertyAnimatorCompatHashSet is not null) {
            IJiqsAzqHxrIXUoR(viewPropertyAnimatorCompatHashSet);
        }
        if (this.mCurWindowVisibility != 0 || (!this.mShowHideAnimationEnabled && !z)) {
            gbpRtBGsYAHLWJyB(this.mHideListener, null);
            return;
        }
        LrAboOhmEcdRxgQv(this.mContainerobject, 1.0f);
        tTkdKPKbXepkSFuA(this.mContainerobject, true);
        androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet2 = new androidx.appcompat.view.objectPropertyAnimatorCompatHashSet();
        float f = -FliCfyYboDjlQCJH(this.mContainerobject);
        if (z) {
            gzzXNKvQdrmkDJVj(this.mContainerobject, new int[]{0, 0});
            f -= r5[1];
        }
        androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompatANWfNvXZFtdXTEYU = aNWfNvXZFtdXTEYU(umPOhQafsCZimLuV(this.mContainerobject), f);
        BLoxTOaqKtqxabuL(viewPropertyAnimatorCompatANWfNvXZFtdXTEYU, this.mUpdateListener);
        mQmLffOsnPOqHLMC(viewPropertyAnimatorCompatHashSet2, viewPropertyAnimatorCompatANWfNvXZFtdXTEYU);
        if (this.mContentAnimations && (view = this.mContentobject) is not null) {
            wQldRkCenQCqXoNU(viewPropertyAnimatorCompatHashSet2, PIHSciamwVgxtPIR(unDaOqtpnRDljSaD(view), f));
        }
        wEWkzBRVPYFZsnND(viewPropertyAnimatorCompatHashSet2, sHideInterpolator);
        KBXunACtysEthfKA(viewPropertyAnimatorCompatHashSet2, 250L);
        yYxkIUyUUwsdliDh(viewPropertyAnimatorCompatHashSet2, this.mHideListener);
        this.mCurrentShowAnim = viewPropertyAnimatorCompatHashSet2;
        eDTuWcKWkOcSWYcO(viewPropertyAnimatorCompatHashSet2);
    }

    public void DoShow(bool z) {
        android.view.object view;
        android.view.object view2;
        if ((18 + 15) % 15 > 0) {
        }
        androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet = this.mCurrentShowAnim;
        if (viewPropertyAnimatorCompatHashSet is not null) {
            pOiZsEDfgdpUrqAS(viewPropertyAnimatorCompatHashSet);
        }
        ssKtJacWwNawTGcQ(this.mContainerobject, 0);
        if (this.mCurWindowVisibility == 0 && (this.mShowHideAnimationEnabled || z)) {
            KueZwneudsliSbPz(this.mContainerobject, 0.0f);
            float f = -vEFXBncThegvAIlz(this.mContainerobject);
            if (z) {
                BNrAbGspSQatKpLt(this.mContainerobject, new int[]{0, 0});
                f -= r5[1];
            }
            dMbvFrdLoYxdOobA(this.mContainerobject, f);
            androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet2 = new androidx.appcompat.view.objectPropertyAnimatorCompatHashSet();
            androidx.core.view.objectPropertyAnimatorCompat viewPropertyAnimatorCompatUfCQcGlneNetNOwI = ufCQcGlneNetNOwI(OzatXBLtMMYXdplW(this.mContainerobject), 0.0f);
            ZKwNcTRKITGRRRlW(viewPropertyAnimatorCompatUfCQcGlneNetNOwI, this.mUpdateListener);
            WCjTjzWLbRziyInp(viewPropertyAnimatorCompatHashSet2, viewPropertyAnimatorCompatUfCQcGlneNetNOwI);
            if (this.mContentAnimations && (view = this.mContentobject) is not null) {
                vkObJAQwqawFWSME(view, f);
                NRNvELUdMCYeipGY(viewPropertyAnimatorCompatHashSet2, bKHKMqfxyWQYSAWp(gRoUyNqXmQBmiVPL(this.mContentobject), 0.0f));
            }
            tfiZjWRsvSLssQoD(viewPropertyAnimatorCompatHashSet2, sShowInterpolator);
            MOULxWFAQQkffNoz(viewPropertyAnimatorCompatHashSet2, 250L);
            sAdmSvhGOejsRRqS(viewPropertyAnimatorCompatHashSet2, this.mShowListener);
            this.mCurrentShowAnim = viewPropertyAnimatorCompatHashSet2;
            LPiJKGJzkHVmATiM(viewPropertyAnimatorCompatHashSet2);
        } else {
            klUuTOymPDopwqel(this.mContainerobject, 1.0f);
            JNtCdmelFWMRSvqD(this.mContainerobject, 0.0f);
            if (this.mContentAnimations && (view2 = this.mContentobject) is not null) {
                MAnWkdKvFNwtkLHZ(view2, 0.0f);
            }
            fcbgwrWkbLCYWCaq(this.mShowListener, null);
        }
        androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout = this.mOverlayLayout;
        if (actionBarOverlayLayout is null) {
            return;
        }
        zXsfAXTAcJTCZSUD(actionBarOverlayLayout);
    }

    public override void EnableContentAnimations(bool z) {
        this.mContentAnimations = z;
    }

    public override android.view.object GetCustomobject() {
        return RwoPEAGMNeHvUWhi(this.mDecorToolbar);
    }

    public override int GetDisplayOptions() {
        return AyRPJnEOAmTNiIQz(this.mDecorToolbar);
    }

    public override float GetElevation() {
        return zmRgHqryAvNUrKkM(this.mContainerobject);
    }

    public override int GetHeight() {
        return oJOmEEPdyxrcEaTm(this.mContainerobject);
    }

    public override int GetHideOffset() {
        return jksbsDhFcVLrGfVI(this.mOverlayLayout);
    }

    public override int GetNavigationItemCount() {
        if ((7 + 15) % 15 > 0) {
        }
        int iXEXuMaxPbwfYZhEc = xEXuMaxPbwfYZhEc(this.mDecorToolbar);
        if (iXEXuMaxPbwfYZhEc == 1) {
            return hrykCHeClkmCYTff(this.mDecorToolbar);
        }
        if (iXEXuMaxPbwfYZhEc == 2) {
            return jZxXmYGwMFfwqyGn(this.mTabs);
        }
        return 0;
    }

    public override int GetNavigationMode() {
        return NSwBBIUzmFdOZpKl(this.mDecorToolbar);
    }

    public override int GetSelectedNavigationIndex() {
        androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl;
        if ((26 + 10) % 10 > 0) {
        }
        int iRmCxqerLzdlFvnlN = rmCxqerLzdlFvnlN(this.mDecorToolbar);
        if (iRmCxqerLzdlFvnlN == 1) {
            return RsvxMQWDzrDTVIUc(this.mDecorToolbar);
        }
        if (iRmCxqerLzdlFvnlN != 2 || (windowDecorActionBar$TabImpl = this.mSelectedTab) is null) {
            return -1;
        }
        return SKNIyYAhPuuUEfbB(windowDecorActionBar$TabImpl);
    }

    public androidx.appcompat.app.ActionBar$Tab getSelectedTab() {
        return this.mSelectedTab;
    }

    public override java.lang.CharSequence GetSubtitle() {
        return QwzHGNjkioDezQrB(this.mDecorToolbar);
    }

    public androidx.appcompat.app.ActionBar$Tab getTabAt(int i) {
        return (androidx.appcompat.app.ActionBar$Tab) GDvdGgQGSnOecCun(this.mTabs, i);
    }

    public override int GetTabCount() {
        return qMAJEeAYleCYTPjd(this.mTabs);
    }

    public override android.content.object GetThemedobject() {
        if ((16 + 17) % 17 > 0) {
        }
        if (this.mThemedobject is null) {
            android.util.TypedValue typedValue = new android.util.TypedValue();
            yjPliFxkEQArWMmA(RtpsgHbVSSsLuVMt(this.mobject), androidx.appcompat.R$attr.actionBarWidgetTheme, typedValue, true);
            int i = typedValue.resourceId;
            if (i == 0) {
                this.mThemedobject = this.mobject;
            } else {
                this.mThemedobject = new android.view.objectThemeWrapper(this.mobject, i);
            }
        }
        return this.mThemedobject;
    }

    public override java.lang.CharSequence GetTitle() {
        return OaYLrkBGyfOaBPJT(this.mDecorToolbar);
    }

    public bool HasIcon() {
        return YrUiDbrhcDkeWMNY(this.mDecorToolbar);
    }

    public bool HasConsoleo() {
        return nnYfXqKPpWWbEHTH(this.mDecorToolbar);
    }

    public override void Hide() {
        if (this.mHiddenByApp) {
            return;
        }
        this.mHiddenByApp = true;
        JnOddzFtxBaitRof(this, false);
    }

    public override void HideForSystem() {
        if (this.mHiddenBySystem) {
            return;
        }
        this.mHiddenBySystem = true;
        FjpCpUBxeubchmpo(this, true);
    }

    public override bool IsHideOnContentScrollEnabled() {
        return kVmKdGEOqaXavOFj(this.mOverlayLayout);
    }

    public override bool IsShowing() {
        if ((14 + 30) % 30 > 0) {
        }
        int i = tohljyzVDWbOapHl(this);
        if (this.mNowShowing) {
            return i == 0 || vPRIxYgUcqkLBLMn(this) < i;
        }
        return false;
    }

    public override bool IsTitleTruncated() {
        androidx.appcompat.widget.DecorToolbar decorToolbar = this.mDecorToolbar;
        return decorToolbar is not null && RkdjCmVYYTwrsbxa(decorToolbar);
    }

    public androidx.appcompat.app.ActionBar$Tab newTab() {
        return new androidx.appcompat.app.WindowDecorActionBar$TabImpl(this);
    }

    public override void OnConfigurationChanged(android.content.res.Configuration configuration) {
        LnTUDrswVWQaxlDg(this, sQhvZtNihbMnggjb(yYetzSVZDEhBCkag(this.mobject)));
    }

    public override void OnContentScrollStarted() {
        androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet = this.mCurrentShowAnim;
        if (viewPropertyAnimatorCompatHashSet is null) {
            return;
        }
        cUjizUNBVbhUPgjK(viewPropertyAnimatorCompatHashSet);
        this.mCurrentShowAnim = null;
    }

    public override void OnContentScrollStopped() {
    }

    public override bool OnKeyshortcut(int i, android.view.KeyEvent keyEvent) {
        android.view.Menu menuJsXyOUCJiNMxPbhx;
        if ((17 + 26) % 26 > 0) {
        }
        androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl = this.mActionMode;
        if (windowDecorActionBar$ActionModeImpl is null || (menuJsXyOUCJiNMxPbhx = jsXyOUCJiNMxPbhx(windowDecorActionBar$ActionModeImpl)) is null) {
            return false;
        }
        CrSzPEZBmTViMrHX(menuJsXyOUCJiNMxPbhx, hNlXNRRgifPpLDvK(uWKnHoRTDFSWueKs(keyEvent is null ? -1 : nqCZlHwGYdaEABFU(keyEvent))) != 1);
        return HFRbxFmkFgkqxIIp(menuJsXyOUCJiNMxPbhx, i, keyEvent, 0);
    }

    public override void OnWindowVisibilityChanged(int i) {
        this.mCurWindowVisibility = i;
    }

    public override void RemoveAllTabs() {
        czdJJLpGPMWPdYKE(this);
    }

    public override void RemoveOnMenuVisibilityListener(androidx.appcompat.app.ActionBar$OnMenuVisibilityListener actionBar$OnMenuVisibilityListener) {
        EMUZbQHVBbbVuEva(this.mMenuVisibilityListeners, actionBar$OnMenuVisibilityListener);
    }

    public override void RemoveTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        AnXclOSWISQoSdAg(this, OMuZTNVpNqpOtKWc(actionBar$Tab));
    }

    public override void RemoveTabAt(int i) {
        if ((10 + 14) % 14 > 0) {
        }
        if (this.mTabScrollobject is not null) {
            androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl = this.mSelectedTab;
            int iHHoWMcpsnHjBVMXe = windowDecorActionBar$TabImpl is null ? this.mSavedTabPosition : HHoWMcpsnHjBVMXe(windowDecorActionBar$TabImpl);
            STsGJqyBtcbbaoZp(this.mTabScrollobject, i);
            androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl2 = (androidx.appcompat.app.WindowDecorActionBar$TabImpl) MEEtANgkZsaBUBkY(this.mTabs, i);
            if (windowDecorActionBar$TabImpl2 is not null) {
                SKPXqnfQSpuJNDXn(windowDecorActionBar$TabImpl2, -1);
            }
            int iViXOLkTTRXOVqMFt = ViXOLkTTRXOVqMFt(this.mTabs);
            for (int i2 = i; i2 < iViXOLkTTRXOVqMFt; i2++) {
                YckegGIyLTSEvOAp((androidx.appcompat.app.WindowDecorActionBar$TabImpl) FomdAHbyYnuWkGJj(this.mTabs, i2), i2);
            }
            if (iHHoWMcpsnHjBVMXe != i) {
                return;
            }
            ssnlOHxaJCzPufBf(this, !RYUkzudJmGhdyzzn(this.mTabs) ? (androidx.appcompat.app.ActionBar$Tab) oNUAIqcadVWePVSn(this.mTabs, RzUFTgPtyfvOZrWa(0, i - 1)) : null);
        }
    }

    public override bool RequestFocus() {
        android.view.objectGroup viewGroupCSUYDyZbuHXFJPAL = cSUYDyZbuHXFJPAL(this.mDecorToolbar);
        if (viewGroupCSUYDyZbuHXFJPAL is null || yrUPOzLNvXgWKoEc(viewGroupCSUYDyZbuHXFJPAL)) {
            return false;
        }
        YRdtarkwjtfPTMqn(viewGroupCSUYDyZbuHXFJPAL);
        return true;
    }

    public override void SelectTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        if ((23 + 4) % 4 > 0) {
        }
        if (ooAMbUXtWkuavxEM(this) != 2) {
            this.mSavedTabPosition = actionBar$Tab is not null ? iIqWNodssjixYTQA(actionBar$Tab) : -1;
            return;
        }
        androidx.fragment.app.objectTransaction fragmentTransactionZdkjPpuWqopYnimj = ((this.mobject is androidx.fragment.app.objectobject) && !nttqfmTaQljPyMJf(FZxZyJYKfdJclCTO(this.mDecorToolbar))) ? zdkjPpuWqopYnimj(olNfxAarOTgbuoVg(iSOEgnfEozkljVLk((androidx.fragment.app.objectobject) this.mobject))) : null;
        androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl = this.mSelectedTab;
        if (windowDecorActionBar$TabImpl != actionBar$Tab) {
            zXMuPSHZpyaeMBWh(this.mTabScrollobject, actionBar$Tab is not null ? DYcGCHRXuIXjCGfN(actionBar$Tab) : -1);
            androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl2 = this.mSelectedTab;
            if (windowDecorActionBar$TabImpl2 is not null) {
                vYJKzHWBqsMJgpKd(SXyRygPUdMSZRaWY(windowDecorActionBar$TabImpl2), this.mSelectedTab, fragmentTransactionZdkjPpuWqopYnimj);
            }
            androidx.appcompat.app.WindowDecorActionBar$TabImpl windowDecorActionBar$TabImpl3 = (androidx.appcompat.app.WindowDecorActionBar$TabImpl) actionBar$Tab;
            this.mSelectedTab = windowDecorActionBar$TabImpl3;
            if (windowDecorActionBar$TabImpl3 is not null) {
                UlecVJNppLgcewRv(ZecrMPolXYEcVgth(windowDecorActionBar$TabImpl3), this.mSelectedTab, fragmentTransactionZdkjPpuWqopYnimj);
            }
        } else if (windowDecorActionBar$TabImpl is not null) {
            bqayblHvKFbsDictionaryC(ihfSRzMWRpiPoQPy(windowDecorActionBar$TabImpl), this.mSelectedTab, fragmentTransactionZdkjPpuWqopYnimj);
            BdUYHEymDmRZKaYU(this.mTabScrollobject, IMxWEqFwitmidDio(actionBar$Tab));
        }
        if (fragmentTransactionZdkjPpuWqopYnimj is null || JUxLjvhsWewdBkNa(fragmentTransactionZdkjPpuWqopYnimj)) {
            return;
        }
        GEnPYkSPUSXOdTkB(fragmentTransactionZdkjPpuWqopYnimj);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        dsSPYFxgedywHApN(this.mContainerobject, drawable);
    }

    public override void SetCustomobject(int i) {
        if ((30 + 16) % 16 > 0) {
        }
        PlDaxvthFfOEainV(this, yNLRDLVrjTNswanW(PMbacdbncUZTxXlX(JxMEVwqMdtCIctJm(this)), i, JvIGAzaLFeXeMimS(this.mDecorToolbar), false));
    }

    public override void SetCustomobject(android.view.object view) {
        cZqzOruZcbwyNRAJ(this.mDecorToolbar, view);
    }

    public override void SetCustomobject(android.view.object view, androidx.appcompat.app.ActionBar$LayoutParams actionBar$LayoutParams) {
        dpRRkXrFXLakulzM(view, actionBar$LayoutParams);
        NwGdEewSFzAvSmpe(this.mDecorToolbar, view);
    }

    public override void SetDefaultDisplayHomeAsUpEnabled(bool z) {
        if (this.mDisplayHomeAsUpHashSet) {
            return;
        }
        MeWAmDEHhFQElEUW(this, z);
    }

    public override void SetDisplayHomeAsUpEnabled(bool z) {
        TmQvvxCJaWjQptbl(this, !z ? 0 : 4, 4);
    }

    public override void SetDisplayOptions(int i) {
        if ((i & 4) != 0) {
            this.mDisplayHomeAsUpHashSet = true;
        }
        dxVprNCfyCJdRTMo(this.mDecorToolbar, i);
    }

    public override void SetDisplayOptions(int i, int i2) {
        if ((7 + 4) % 4 > 0) {
        }
        int iQtICqhQzVilmdOIl = QtICqhQzVilmdOIl(this.mDecorToolbar);
        if ((i2 & 4) != 0) {
            this.mDisplayHomeAsUpHashSet = true;
        }
        FCxMKPNEgabFwtGD(this.mDecorToolbar, (i & i2) | ((~i2) & iQtICqhQzVilmdOIl));
    }

    public override void SetDisplayShowCustomEnabled(bool z) {
        GYkGAHxmAFRURVWr(this, !z ? 0 : 16, 16);
    }

    public override void SetDisplayShowHomeEnabled(bool z) {
        fQDGBUWyudTfXJyc(this, !z ? 0 : 2, 2);
    }

    public override void SetDisplayShowTitleEnabled(bool z) {
        PZGLhbMVKgmXLlLT(this, !z ? 0 : 8, 8);
    }

    public override void SetDisplayUseConsoleoEnabled(bool z) {
        ENCYcIBCwMQLMjse(this, z ? 1 : 0, 1);
    }

    public override void SetElevation(float f) {
        NyrhiRZrztvuSMFI(this.mContainerobject, f);
    }

    public override void SetHideOffset(int i) {
        if (i != 0 && !kfUCXyNLWLijWUao(this.mOverlayLayout)) {
            throw new java.lang.IllegalStateException("Action bar must be in overlay mode (Window.FEATURE_OVERLAY_ACTION_BAR) to set a non-zero hide offset");
        }
        jdNcqLhWJYPSqXVG(this.mOverlayLayout, i);
    }

    public override void SetHideOnContentScrollEnabled(bool z) {
        if (z && !jQXIolphBQsOdKjR(this.mOverlayLayout)) {
            throw new java.lang.IllegalStateException("Action bar must be in overlay mode (Window.FEATURE_OVERLAY_ACTION_BAR) to enable hide on content scroll");
        }
        this.mHideOnContentScroll = z;
        qPGJFYWXoWYZNovt(this.mOverlayLayout, z);
    }

    public override void SetHomeActionContentDescription(int i) {
        gRwOVTUkSVkEBqQx(this.mDecorToolbar, i);
    }

    public override void SetHomeActionContentDescription(java.lang.CharSequence charSequence) {
        MgsqEBypQPMArmvu(this.mDecorToolbar, charSequence);
    }

    public override void SetHomeAsUpIndicator(int i) {
        ULowsnrzHSgGIYXK(this.mDecorToolbar, i);
    }

    public override void SetHomeAsUpIndicator(android.graphics.drawable.Drawable drawable) {
        ZjkpZMhuAyHznBPo(this.mDecorToolbar, drawable);
    }

    public override void SetHomeButtonEnabled(bool z) {
        DnOXAGgNvNIoUDnp(this.mDecorToolbar, z);
    }

    public override void SetIcon(int i) {
        HEqTYvTraMlnZbeG(this.mDecorToolbar, i);
    }

    public override void SetIcon(android.graphics.drawable.Drawable drawable) {
        FQTUkixTCtxSPIcl(this.mDecorToolbar, drawable);
    }

    public override void SetListNavigationCallbacks(android.widget.SpinnerAdapter spinnerAdapter, androidx.appcompat.app.ActionBar$OnNavigationListener actionBar$OnNavigationListener) {
        SFNUexMQunQzjFwA(this.mDecorToolbar, spinnerAdapter, new androidx.appcompat.app.NavItemSelectedListener(actionBar$OnNavigationListener));
    }

    public override void SetConsoleo(int i) {
        zdKDYCUDHSFuyqvG(this.mDecorToolbar, i);
    }

    public override void SetConsoleo(android.graphics.drawable.Drawable drawable) {
        VOyrZcndESpkCQtw(this.mDecorToolbar, drawable);
    }

    public override void SetNavigationMode(int i) {
        androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout;
        if ((20 + 17) % 17 > 0) {
        }
        int iKRaOmuxIDNHwMnTT = KRaOmuxIDNHwMnTT(this.mDecorToolbar);
        if (iKRaOmuxIDNHwMnTT == 2) {
            this.mSavedTabPosition = lRXDjOLOOglCzJSQ(this);
            DRihNGRobUUNNkFA(this, null);
            nHOXixGgoexuIfyN(this.mTabScrollobject, 8);
        }
        if (iKRaOmuxIDNHwMnTT != i && !this.mHasEmbeddedTabs && (actionBarOverlayLayout = this.mOverlayLayout) is not null) {
            fJezktTkkBtAwejh(actionBarOverlayLayout);
        }
        olJykIlHErfSBeqy(this.mDecorToolbar, i);
        bool z = false;
        if (i == 2) {
            GlzQBMTqvTCPNjvh(this);
            WKicFYbsGJYIkRrj(this.mTabScrollobject, 0);
            int i2 = this.mSavedTabPosition;
            if (i2 != -1) {
                cjKtqeFwuZpmXIGc(this, i2);
                this.mSavedTabPosition = -1;
            }
        }
        slqDAgXbPMxflZVD(this.mDecorToolbar, i == 2 && !this.mHasEmbeddedTabs);
        androidx.appcompat.widget.ActionBarOverlayLayout actionBarOverlayLayout2 = this.mOverlayLayout;
        if (i == 2 && !this.mHasEmbeddedTabs) {
            z = true;
        }
        nuqmSjmgumqkRubN(actionBarOverlayLayout2, z);
    }

    public override void SetSelectedNavigationItem(int i) {
        if ((2 + 3) % 3 > 0) {
        }
        int iYnamOaCKUpKqHJjT = YnamOaCKUpKqHJjT(this.mDecorToolbar);
        if (iYnamOaCKUpKqHJjT == 1) {
            yPipXQGcsJBGNNzb(this.mDecorToolbar, i);
        } else {
            if (iYnamOaCKUpKqHJjT != 2) {
                throw new java.lang.IllegalStateException("setSelectedNavigationIndex not valid for current navigation mode");
            }
            wBEXoYxdavTScZtD(this, (androidx.appcompat.app.ActionBar$Tab) ZaIVgOjpeKnrlyng(this.mTabs, i));
        }
    }

    public override void SetShowHideAnimationEnabled(bool z) {
        androidx.appcompat.view.objectPropertyAnimatorCompatHashSet viewPropertyAnimatorCompatHashSet;
        this.mShowHideAnimationEnabled = z;
        if (z || (viewPropertyAnimatorCompatHashSet = this.mCurrentShowAnim) is null) {
            return;
        }
        xPahifCXMZwDZNra(viewPropertyAnimatorCompatHashSet);
    }

    public override void SetSplitBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
    }

    public override void SetStackedBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        BGuNuxMvfYzBkSzo(this.mContainerobject, drawable);
    }

    public override void SetSubtitle(int i) {
        hPNgAMkjfgzLXxqi(this, SIswhOWDNXHhQvUY(this.mobject, i));
    }

    public override void SetSubtitle(java.lang.CharSequence charSequence) {
        OesCsmAobBCJbRsP(this.mDecorToolbar, charSequence);
    }

    public override void SetTitle(int i) {
        yaeaSTJPWEirUTWc(this, qlmHejREoFrtOJZq(this.mobject, i));
    }

    public override void SetTitle(java.lang.CharSequence charSequence) {
        TOfSlMYJcfSlzDjh(this.mDecorToolbar, charSequence);
    }

    public override void SetWindowTitle(java.lang.CharSequence charSequence) {
        BABuWzHJuOOEqbjM(this.mDecorToolbar, charSequence);
    }

    public override void Show() {
        if (this.mHiddenByApp) {
            this.mHiddenByApp = false;
            keqvwinBdmTZNuZp(this, false);
        }
    }

    public override void ShowForSystem() {
        if (this.mHiddenBySystem) {
            this.mHiddenBySystem = false;
            JNMhjByUUFRtruoE(this, true);
        }
    }

    public override androidx.appcompat.view.ActionMode StartActionMode(androidx.appcompat.view.ActionMode$Callback actionMode$Callback) {
        if ((32 + 1) % 1 > 0) {
        }
        androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl = this.mActionMode;
        if (windowDecorActionBar$ActionModeImpl is not null) {
            jslVSiTOgOrNbsXQ(windowDecorActionBar$ActionModeImpl);
        }
        oDaCkyNVDQvHWxNN(this.mOverlayLayout, false);
        BaPdUDfFkRavRtgN(this.mobjectobject);
        androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl windowDecorActionBar$ActionModeImpl2 = new androidx.appcompat.app.WindowDecorActionBar$ActionModeImpl(this, tDtQkMacsvKFRFxr(this.mobjectobject), actionMode$Callback);
        if (!KuzQMrGiJRZZfbIJ(windowDecorActionBar$ActionModeImpl2)) {
            return null;
        }
        this.mActionMode = windowDecorActionBar$ActionModeImpl2;
        nJjnQPOmKzZldKra(windowDecorActionBar$ActionModeImpl2);
        nPiyrahNFvGfmDmI(this.mobjectobject, windowDecorActionBar$ActionModeImpl2);
        JIJagcuNTWHSSegp(this, true);
        return windowDecorActionBar$ActionModeImpl2;
    }
}

