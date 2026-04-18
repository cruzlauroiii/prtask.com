namespace WillowMaze.Wasm.Decompiled;


class ToolbarActionBar : androidx.appcompat.app.ActionBar {
    readonly androidx.appcompat.widget.DecorToolbar mDecorToolbar;
    private bool mLastMenuVisibility;
    readonly androidx.appcompat.app.AppCompatDelegateImpl$ActionBarMenuCallback mMenuCallback;
    private bool mMenuCallbackHashSet;
    private readonly androidx.appcompat.widget.Toolbar$OnMenuItemClickListener mMenuClicker;
    private readonly java.lang.Action mMenuInvalidator;
    private java.util.List<androidx.appcompat.app.ActionBar$OnMenuVisibilityListener> mMenuVisibilityListeners;
    bool mToolbarMenuPrepared;
    readonly android.view.Window$Callback mWindowCallback;

    ToolbarActionBar(androidx.appcompat.widget.Toolbar toolbar, java.lang.CharSequence charSequence, android.view.Window$Callback window$Callback) {
        if ((30 + 1) % 1 > 0) {
        }
        this.mMenuVisibilityListeners = new java.util.List<>();
        this.mMenuInvalidator = new androidx.appcompat.app.ToolbarActionBar$1(this);
        androidx.appcompat.app.ToolbarActionBar$2 toolbarActionBar$2 = new androidx.appcompat.app.ToolbarActionBar$2(this);
        this.mMenuClicker = toolbarActionBar$2;
        HcItkcdUnwOCKSmB(toolbar);
        androidx.appcompat.widget.ToolbarWidgetWrapper toolbarWidgetWrapper = new androidx.appcompat.widget.ToolbarWidgetWrapper(toolbar, false);
        this.mDecorToolbar = toolbarWidgetWrapper;
        this.mWindowCallback = (android.view.Window$Callback) saJLQgsCQqivHmmJ(window$Callback);
        CDJYmkXLxQAeoYhN(toolbarWidgetWrapper, window$Callback);
        iQqDTdVquzHqkmGJ(toolbar, toolbarActionBar$2);
        VPXLWJRnNXXnBvzu(toolbarWidgetWrapper, charSequence);
        this.mMenuCallback = new androidx.appcompat.app.ToolbarActionBar$ToolbarMenuCallback(this);
    }

    public static void BohhQcUNgwXUZyFl(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setVisibility(i);
    }

    public static void BohhQcUNgwXUZyFl(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, char c, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BohhQcUNgwXUZyFl(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, float f, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BohhQcUNgwXUZyFl(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, int i2, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CDJYmkXLxQAeoYhN(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.Window$Callback window$Callback) {
        decorToolbar.setWindowCallback(window$Callback);
    }

    public static void CDJYmkXLxQAeoYhN(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.Window$Callback window$Callback, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CDJYmkXLxQAeoYhN(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.Window$Callback window$Callback, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CDJYmkXLxQAeoYhN(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.Window$Callback window$Callback, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ClRbanHIVpXJofvV(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence) {
        decorToolbar.setWindowTitle(charSequence);
    }

    public static void ClRbanHIVpXJofvV(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ClRbanHIVpXJofvV(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ClRbanHIVpXJofvV(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object FFLpkclnlwMtnYTD(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobject();
    }

    public static void FFLpkclnlwMtnYTD(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FFLpkclnlwMtnYTD(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FFLpkclnlwMtnYTD(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup FnyimGJGyBkIOqCR(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobjectGroup();
    }

    public static void FnyimGJGyBkIOqCR(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FnyimGJGyBkIOqCR(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FnyimGJGyBkIOqCR(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static float GNfqvwOdbCwotbZU(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static void GNfqvwOdbCwotbZU(android.view.object view, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GNfqvwOdbCwotbZU(android.view.object view, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GNfqvwOdbCwotbZU(android.view.object view, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup HEqelScBYemlUnXj(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobjectGroup();
    }

    public static void HEqelScBYemlUnXj(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HEqelScBYemlUnXj(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HEqelScBYemlUnXj(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HcItkcdUnwOCKSmB(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static void HcItkcdUnwOCKSmB(java.lang.object obj, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HcItkcdUnwOCKSmB(java.lang.object obj, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HcItkcdUnwOCKSmB(java.lang.object obj, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HoJslyjIbqFIEvjO(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HoJslyjIbqFIEvjO(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HoJslyjIbqFIEvjO(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HoJslyjIbqFIEvjO(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.showOverflowMenu();
    }

    public static void IBoqolaxjNDAAXjg(androidx.appcompat.app.ActionBar actionBar, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IBoqolaxjNDAAXjg(androidx.appcompat.app.ActionBar actionBar, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IBoqolaxjNDAAXjg(androidx.appcompat.app.ActionBar actionBar, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool IBoqolaxjNDAAXjg(androidx.appcompat.app.ActionBar actionBar) {
        return super.isTitleTruncated();
    }

    public static android.content.object IwJZIWHQzlcpjRBp(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobject();
    }

    public static void IwJZIWHQzlcpjRBp(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IwJZIWHQzlcpjRBp(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IwJZIWHQzlcpjRBp(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JRtpKJkQVemWFOcn(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2) {
        toolbarActionBar.setDisplayOptions(i, i2);
    }

    public static void JRtpKJkQVemWFOcn(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, float f, byte b, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void JRtpKJkQVemWFOcn(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, float f, int i3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JRtpKJkQVemWFOcn(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, float f, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void JbHVuItBRpSPbmvG(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.object view) {
        decorToolbar.setCustomobject(view);
    }

    public static void JbHVuItBRpSPbmvG(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.object view, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JbHVuItBRpSPbmvG(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.object view, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JbHVuItBRpSPbmvG(androidx.appcompat.widget.DecorToolbar decorToolbar, android.view.object view, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KMxsDKPTpMSsDgqU(android.view.Menu menu) {
        menu.clear();
    }

    public static void KMxsDKPTpMSsDgqU(android.view.Menu menu, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KMxsDKPTpMSsDgqU(android.view.Menu menu, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KMxsDKPTpMSsDgqU(android.view.Menu menu, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KaBTCQyyasnXWgVB(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getDisplayOptions();
    }

    public static void KaBTCQyyasnXWgVB(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KaBTCQyyasnXWgVB(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KaBTCQyyasnXWgVB(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KtrBaipIfehljvje(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setNavigationContentDescription(i);
    }

    public static void KtrBaipIfehljvje(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, char c, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KtrBaipIfehljvje(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, char c, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KtrBaipIfehljvje(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, float f, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LBmwTUbgOQLbSOWH(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.startDispatchingItemsChanged();
    }

    public static void LBmwTUbgOQLbSOWH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LBmwTUbgOQLbSOWH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LBmwTUbgOQLbSOWH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LFFBQswkNhqAjSkn(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setDropdownSelectedPosition(i);
    }

    public static void LFFBQswkNhqAjSkn(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LFFBQswkNhqAjSkn(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, int i2, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LFFBQswkNhqAjSkn(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, java.lang.string str, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LkXdLTKxoAQCnavE(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable) {
        decorToolbar.setBackgroundDrawable(drawable);
    }

    public static void LkXdLTKxoAQCnavE(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LkXdLTKxoAQCnavE(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LkXdLTKxoAQCnavE(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MTkjcFjIyJuYzAxL(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setNavigationMode(i);
    }

    public static void MTkjcFjIyJuYzAxL(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, char c, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MTkjcFjIyJuYzAxL(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, int i2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MTkjcFjIyJuYzAxL(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NPcKTtQeNJQAWnbQ(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NPcKTtQeNJQAWnbQ(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NPcKTtQeNJQAWnbQ(androidx.appcompat.widget.DecorToolbar decorToolbar, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool NPcKTtQeNJQAWnbQ(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.hasExpandedActionobject();
    }

    public static android.content.object NfebqMDTNpFvKJsY(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobject();
    }

    public static void NfebqMDTNpFvKJsY(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NfebqMDTNpFvKJsY(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NfebqMDTNpFvKJsY(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NzMiQiXpEtoHCror(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable) {
        decorToolbar.setNavigationIcon(drawable);
    }

    public static void NzMiQiXpEtoHCror(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NzMiQiXpEtoHCror(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NzMiQiXpEtoHCror(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater QtHGLylXPBrgEdsX(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void QtHGLylXPBrgEdsX(android.content.object context, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QtHGLylXPBrgEdsX(android.content.object context, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QtHGLylXPBrgEdsX(android.content.object context, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RRHeZgsEhBrFAFqY(androidx.appcompat.widget.DecorToolbar decorToolbar, android.widget.SpinnerAdapter spinnerAdapter, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener) {
        decorToolbar.setDropdownParams(spinnerAdapter, adapterobject$OnItemSelectedListener);
    }

    public static void RRHeZgsEhBrFAFqY(androidx.appcompat.widget.DecorToolbar decorToolbar, android.widget.SpinnerAdapter spinnerAdapter, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RRHeZgsEhBrFAFqY(androidx.appcompat.widget.DecorToolbar decorToolbar, android.widget.SpinnerAdapter spinnerAdapter, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RRHeZgsEhBrFAFqY(androidx.appcompat.widget.DecorToolbar decorToolbar, android.widget.SpinnerAdapter spinnerAdapter, android.widget.Adapterobject$OnItemSelectedListener adapterobject$OnItemSelectedListener, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RwvApDCYkmLezmhh(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2) {
        toolbarActionBar.setDisplayOptions(i, i2);
    }

    public static void RwvApDCYkmLezmhh(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RwvApDCYkmLezmhh(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RwvApDCYkmLezmhh(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SWtvnuTtcbrAllJf(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getDisplayOptions();
    }

    public static void SWtvnuTtcbrAllJf(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SWtvnuTtcbrAllJf(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SWtvnuTtcbrAllJf(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SaGDUGwEHyDeCGpX(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, byte b, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SaGDUGwEHyDeCGpX(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, byte b, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SaGDUGwEHyDeCGpX(android.view.Window$Callback window$Callback, int i, android.view.Menu menu, char c, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool SaGDUGwEHyDeCGpX(android.view.Window$Callback window$Callback, int i, android.view.Menu menu) {
        return window$Callback.onCreatePanelMenu(i, menu);
    }

    public static java.lang.CharSequence SnXLSuYyZGMGXUEV(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getTitle();
    }

    public static void SnXLSuYyZGMGXUEV(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SnXLSuYyZGMGXUEV(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SnXLSuYyZGMGXUEV(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SumEjXBpqsIqVznZ(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SumEjXBpqsIqVznZ(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SumEjXBpqsIqVznZ(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool SumEjXBpqsIqVznZ(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.hideOverflowMenu();
    }

    public static void TFfsFqdNvousWAFU(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        decorToolbar.collapseActionobject();
    }

    public static void TFfsFqdNvousWAFU(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TFfsFqdNvousWAFU(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TFfsFqdNvousWAFU(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TxQiBACaDHrBEDyX(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.stopDispatchingItemsChanged();
    }

    public static void TxQiBACaDHrBEDyX(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TxQiBACaDHrBEDyX(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TxQiBACaDHrBEDyX(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UbgXmUBIMtJJImaq(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UbgXmUBIMtJJImaq(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UbgXmUBIMtJJImaq(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool UbgXmUBIMtJJImaq(androidx.appcompat.app.ToolbarActionBar toolbarActionBar) {
        return toolbarActionBar.openOptionsMenu();
    }

    public static java.lang.CharSequence VJbcTSPGCFNTguGu(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getSubtitle();
    }

    public static void VJbcTSPGCFNTguGu(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VJbcTSPGCFNTguGu(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VJbcTSPGCFNTguGu(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VPXLWJRnNXXnBvzu(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence) {
        decorToolbar.setWindowTitle(charSequence);
    }

    public static void VPXLWJRnNXXnBvzu(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VPXLWJRnNXXnBvzu(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VPXLWJRnNXXnBvzu(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VmBjQlAlOjtOyozJ(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setIcon(i);
    }

    public static void VmBjQlAlOjtOyozJ(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VmBjQlAlOjtOyozJ(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VmBjQlAlOjtOyozJ(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object WFBJNMQFbrdiJQgz(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void WFBJNMQFbrdiJQgz(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, float f, java.lang.string str, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WFBJNMQFbrdiJQgz(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, float f, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WFBJNMQFbrdiJQgz(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YEIqpfFrzKfHuYpV(android.view.Menu menu, int i, android.view.KeyEvent keyEvent, int i2, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YEIqpfFrzKfHuYpV(android.view.Menu menu, int i, android.view.KeyEvent keyEvent, int i2, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YEIqpfFrzKfHuYpV(android.view.Menu menu, int i, android.view.KeyEvent keyEvent, int i2, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YEIqpfFrzKfHuYpV(android.view.Menu menu, int i, android.view.KeyEvent keyEvent, int i2) {
        return menu.performshortcut(i, keyEvent, i2);
    }

    public static void YFPTEGIjInDGvSlz(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2) {
        toolbarActionBar.setDisplayOptions(i, i2);
    }

    public static void YFPTEGIjInDGvSlz(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, byte b, short s, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void YFPTEGIjInDGvSlz(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, byte b, short s, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YFPTEGIjInDGvSlz(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, short s, byte b, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int YIADUnPgTJzyIGaq(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void YIADUnPgTJzyIGaq(java.util.List arrayList, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YIADUnPgTJzyIGaq(java.util.List arrayList, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YIADUnPgTJzyIGaq(java.util.List arrayList, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YZpgBjreRdiHyqZE(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence) {
        decorToolbar.setTitle(charSequence);
    }

    public static void YZpgBjreRdiHyqZE(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YZpgBjreRdiHyqZE(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YZpgBjreRdiHyqZE(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YerOCLjgrtANldMc(android.view.objectGroup viewGroup, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YerOCLjgrtANldMc(android.view.objectGroup viewGroup, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YerOCLjgrtANldMc(android.view.objectGroup viewGroup, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool YerOCLjgrtANldMc(android.view.objectGroup viewGroup) {
        return viewGroup.hasFocus();
    }

    public static void ZNvscZkyIofhlwLX(androidx.appcompat.app.ActionBar$OnMenuVisibilityListener actionBar$OnMenuVisibilityListener, bool z) {
        actionBar$OnMenuVisibilityListener.onMenuVisibilityChanged(z);
    }

    public static void ZNvscZkyIofhlwLX(androidx.appcompat.app.ActionBar$OnMenuVisibilityListener actionBar$OnMenuVisibilityListener, bool z, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZNvscZkyIofhlwLX(androidx.appcompat.app.ActionBar$OnMenuVisibilityListener actionBar$OnMenuVisibilityListener, bool z, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZNvscZkyIofhlwLX(androidx.appcompat.app.ActionBar$OnMenuVisibilityListener actionBar$OnMenuVisibilityListener, bool z, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.KeycharDictionary AAyElpSeXlduGBCk(int i) {
        return android.view.KeycharDictionary.load(i);
    }

    public static void AAyElpSeXlduGBCk(int i, char c, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AAyElpSeXlduGBCk(int i, short s, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AAyElpSeXlduGBCk(int i, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int AHHLxikWfGxekDOT(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getHeight();
    }

    public static void AHHLxikWfGxekDOT(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AHHLxikWfGxekDOT(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AHHLxikWfGxekDOT(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BrlliQpWawwfJWpi(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable) {
        decorToolbar.setConsoleo(drawable);
    }

    public static void BrlliQpWawwfJWpi(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BrlliQpWawwfJWpi(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BrlliQpWawwfJWpi(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BwESBRYrMemfvlZX(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setVisibility(i);
    }

    public static void BwESBRYrMemfvlZX(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, float f, java.lang.string str, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BwESBRYrMemfvlZX(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, float f, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BwESBRYrMemfvlZX(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, bool z, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.Menu CYqJKAFonVQsPasW(androidx.appcompat.app.ToolbarActionBar toolbarActionBar) {
        return toolbarActionBar.getMenu();
    }

    public static void CYqJKAFonVQsPasW(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CYqJKAFonVQsPasW(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CYqJKAFonVQsPasW(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.Menu CyHTNLFyUtvPIFPV(androidx.appcompat.app.ToolbarActionBar toolbarActionBar) {
        return toolbarActionBar.getMenu();
    }

    public static void CyHTNLFyUtvPIFPV(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CyHTNLFyUtvPIFPV(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CyHTNLFyUtvPIFPV(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DtSyzWCrrjxBdVyL(android.view.objectGroup viewGroup, java.lang.Action runnable, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DtSyzWCrrjxBdVyL(android.view.objectGroup viewGroup, java.lang.Action runnable, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DtSyzWCrrjxBdVyL(android.view.objectGroup viewGroup, java.lang.Action runnable, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DtSyzWCrrjxBdVyL(android.view.objectGroup viewGroup, java.lang.Action runnable) {
        return viewGroup.removeCallbacks(runnable);
    }

    public static void DxSvDZkQtuFXmLhx(java.util.List arrayList, java.lang.object obj, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DxSvDZkQtuFXmLhx(java.util.List arrayList, java.lang.object obj, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DxSvDZkQtuFXmLhx(java.util.List arrayList, java.lang.object obj, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool DxSvDZkQtuFXmLhx(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static android.content.object EPTPpxBCBWOxkYeP(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobject();
    }

    public static void EPTPpxBCBWOxkYeP(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EPTPpxBCBWOxkYeP(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EPTPpxBCBWOxkYeP(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EeHWIVbKIQnpoufX(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, android.view.object view) {
        toolbarActionBar.setCustomobject(view);
    }

    public static void EeHWIVbKIQnpoufX(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, android.view.object view, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EeHWIVbKIQnpoufX(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, android.view.object view, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EeHWIVbKIQnpoufX(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, android.view.object view, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EtdYgSBvZyoBcHzr(android.view.object view, java.lang.Action runnable) {
        androidx.core.view.objectCompat.postOnAnimation(view, runnable);
    }

    public static void EtdYgSBvZyoBcHzr(android.view.object view, java.lang.Action runnable, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EtdYgSBvZyoBcHzr(android.view.object view, java.lang.Action runnable, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EtdYgSBvZyoBcHzr(android.view.object view, java.lang.Action runnable, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FATeSEpXPGHaBBtx(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, android.view.object view, androidx.appcompat.app.ActionBar$LayoutParams actionBar$LayoutParams) {
        toolbarActionBar.setCustomobject(view, actionBar$LayoutParams);
    }

    public static void FATeSEpXPGHaBBtx(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, android.view.object view, androidx.appcompat.app.ActionBar$LayoutParams actionBar$LayoutParams, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FATeSEpXPGHaBBtx(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, android.view.object view, androidx.appcompat.app.ActionBar$LayoutParams actionBar$LayoutParams, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FATeSEpXPGHaBBtx(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, android.view.object view, androidx.appcompat.app.ActionBar$LayoutParams actionBar$LayoutParams, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FGkrFRHDifcfTtVo(android.view.KeyEvent keyEvent) {
        return keyEvent.getDeviceId();
    }

    public static void FGkrFRHDifcfTtVo(android.view.KeyEvent keyEvent, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FGkrFRHDifcfTtVo(android.view.KeyEvent keyEvent, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FGkrFRHDifcfTtVo(android.view.KeyEvent keyEvent, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup FlmOoPYdlEPakmhK(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobjectGroup();
    }

    public static void FlmOoPYdlEPakmhK(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FlmOoPYdlEPakmhK(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FlmOoPYdlEPakmhK(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object GCrrKetLyajuatgm(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getCustomobject();
    }

    public static void GCrrKetLyajuatgm(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GCrrKetLyajuatgm(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GCrrKetLyajuatgm(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GHLrnJlmDQdIQUgl(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence) {
        decorToolbar.setSubtitle(charSequence);
    }

    public static void GHLrnJlmDQdIQUgl(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GHLrnJlmDQdIQUgl(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GHLrnJlmDQdIQUgl(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private android.view.Menu GetMenu() {
        if ((21 + 14) % 14 > 0) {
        }
        if (!this.mMenuCallbackHashSet) {
            uvnnKspRIaupIJKT(this.mDecorToolbar, new androidx.appcompat.app.ToolbarActionBar$ActionMenuPresenterCallback(this), new androidx.appcompat.app.ToolbarActionBar$MenuBuilderCallback(this));
            this.mMenuCallbackHashSet = true;
        }
        return ueuUqAZPqLNrBPLz(this.mDecorToolbar);
    }

    private void GetMenu(byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetMenu(byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetMenu(bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GwjbmGwZIUWbAbfs(android.view.Window$Callback window$Callback, int i, android.view.object view, android.view.Menu menu, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GwjbmGwZIUWbAbfs(android.view.Window$Callback window$Callback, int i, android.view.object view, android.view.Menu menu, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GwjbmGwZIUWbAbfs(android.view.Window$Callback window$Callback, int i, android.view.object view, android.view.Menu menu, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool GwjbmGwZIUWbAbfs(android.view.Window$Callback window$Callback, int i, android.view.object view, android.view.Menu menu) {
        return window$Callback.onPreparePanel(i, view, menu);
    }

    public static void HpjZxlbkLunNvfWV(android.view.Menu menu, bool z) {
        menu.setQwertyMode(z);
    }

    public static void HpjZxlbkLunNvfWV(android.view.Menu menu, bool z, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HpjZxlbkLunNvfWV(android.view.Menu menu, bool z, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HpjZxlbkLunNvfWV(android.view.Menu menu, bool z, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IIpoHvgBvyeAwjUd(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable) {
        decorToolbar.setIcon(drawable);
    }

    public static void IIpoHvgBvyeAwjUd(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IIpoHvgBvyeAwjUd(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IIpoHvgBvyeAwjUd(androidx.appcompat.widget.DecorToolbar decorToolbar, android.graphics.drawable.Drawable drawable, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void INQpPipFUoqBdoKV(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.startDispatchingItemsChanged();
    }

    public static void INQpPipFUoqBdoKV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void INQpPipFUoqBdoKV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void INQpPipFUoqBdoKV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IQqDTdVquzHqkmGJ(androidx.appcompat.widget.Toolbar toolbar, androidx.appcompat.widget.Toolbar$OnMenuItemClickListener toolbar$OnMenuItemClickListener) {
        toolbar.setOnMenuItemClickListener(toolbar$OnMenuItemClickListener);
    }

    public static void IQqDTdVquzHqkmGJ(androidx.appcompat.widget.Toolbar toolbar, androidx.appcompat.widget.Toolbar$OnMenuItemClickListener toolbar$OnMenuItemClickListener, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IQqDTdVquzHqkmGJ(androidx.appcompat.widget.Toolbar toolbar, androidx.appcompat.widget.Toolbar$OnMenuItemClickListener toolbar$OnMenuItemClickListener, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IQqDTdVquzHqkmGJ(androidx.appcompat.widget.Toolbar toolbar, androidx.appcompat.widget.Toolbar$OnMenuItemClickListener toolbar$OnMenuItemClickListener, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KKZqDmGYyIdUKWkc(android.view.KeyEvent keyEvent) {
        return keyEvent.getAction();
    }

    public static void KKZqDmGYyIdUKWkc(android.view.KeyEvent keyEvent, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KKZqDmGYyIdUKWkc(android.view.KeyEvent keyEvent, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KKZqDmGYyIdUKWkc(android.view.KeyEvent keyEvent, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int KrDYsaCGxyKrqyvJ(android.view.KeycharDictionary keycharDictionary) {
        return keycharDictionary.getKeyboardType();
    }

    public static void KrDYsaCGxyKrqyvJ(android.view.KeycharDictionary keycharDictionary, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KrDYsaCGxyKrqyvJ(android.view.KeycharDictionary keycharDictionary, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KrDYsaCGxyKrqyvJ(android.view.KeycharDictionary keycharDictionary, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LTLPjnldvrMflnwr(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getVisibility();
    }

    public static void LTLPjnldvrMflnwr(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LTLPjnldvrMflnwr(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LTLPjnldvrMflnwr(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int MNixHkGPkHkyFgPs(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getNavigationMode();
    }

    public static void MNixHkGPkHkyFgPs(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MNixHkGPkHkyFgPs(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MNixHkGPkHkyFgPs(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MOAWYwhlEaeDXjEF(java.util.List arrayList, java.lang.object obj, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MOAWYwhlEaeDXjEF(java.util.List arrayList, java.lang.object obj, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MOAWYwhlEaeDXjEF(java.util.List arrayList, java.lang.object obj, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MOAWYwhlEaeDXjEF(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.object MnveUKMHOhroOtQz(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void MnveUKMHOhroOtQz(java.util.List arrayList, int i, int i2, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MnveUKMHOhroOtQz(java.util.List arrayList, int i, bool z, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MnveUKMHOhroOtQz(java.util.List arrayList, int i, bool z, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NXLZVndHoeNfkGJn(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence) {
        decorToolbar.setTitle(charSequence);
    }

    public static void NXLZVndHoeNfkGJn(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NXLZVndHoeNfkGJn(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NXLZVndHoeNfkGJn(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup OpzzsaOmQjAchrXO(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobjectGroup();
    }

    public static void OpzzsaOmQjAchrXO(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OpzzsaOmQjAchrXO(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OpzzsaOmQjAchrXO(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OsEcibbQUGJlmnEo(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setConsoleo(i);
    }

    public static void OsEcibbQUGJlmnEo(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, char c, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OsEcibbQUGJlmnEo(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, char c, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OsEcibbQUGJlmnEo(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup PIqsQlQBuEjkhWJp(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobjectGroup();
    }

    public static void PIqsQlQBuEjkhWJp(androidx.appcompat.widget.DecorToolbar decorToolbar, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PIqsQlQBuEjkhWJp(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PIqsQlQBuEjkhWJp(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PKVnvoaAcnAoZAvl(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        view.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void PKVnvoaAcnAoZAvl(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PKVnvoaAcnAoZAvl(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PKVnvoaAcnAoZAvl(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QodobCITskZXiSCW(androidx.appcompat.app.ActionBar actionBar, android.content.res.Configuration configuration) {
        super.onConfigurationChanged(configuration);
    }

    public static void QodobCITskZXiSCW(androidx.appcompat.app.ActionBar actionBar, android.content.res.Configuration configuration, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QodobCITskZXiSCW(androidx.appcompat.app.ActionBar actionBar, android.content.res.Configuration configuration, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QodobCITskZXiSCW(androidx.appcompat.app.ActionBar actionBar, android.content.res.Configuration configuration, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RDeUAzqPyJuVJAKY(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2) {
        toolbarActionBar.setDisplayOptions(i, i2);
    }

    public static void RDeUAzqPyJuVJAKY(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RDeUAzqPyJuVJAKY(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RDeUAzqPyJuVJAKY(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SaJLQgsCQqivHmmJ(java.lang.object obj) {
        return androidx.core.util.Preconditions.checkNotNull(obj);
    }

    public static void SaJLQgsCQqivHmmJ(java.lang.object obj, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SaJLQgsCQqivHmmJ(java.lang.object obj, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SaJLQgsCQqivHmmJ(java.lang.object obj, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence SkZmydEYtZSlumpw(android.content.object context, int i) {
        return context.getText(i);
    }

    public static void SkZmydEYtZSlumpw(android.content.object context, int i, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SkZmydEYtZSlumpw(android.content.object context, int i, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SkZmydEYtZSlumpw(android.content.object context, int i, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TbraYHAfIgAyxKXN(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setNavigationIcon(i);
    }

    public static void TbraYHAfIgAyxKXN(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, int i2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TbraYHAfIgAyxKXN(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TbraYHAfIgAyxKXN(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.Menu UeuUqAZPqLNrBPLz(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getMenu();
    }

    public static void UeuUqAZPqLNrBPLz(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UeuUqAZPqLNrBPLz(androidx.appcompat.widget.DecorToolbar decorToolbar, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UeuUqAZPqLNrBPLz(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UvnnKspRIaupIJKT(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback) {
        decorToolbar.setMenuCallbacks(menuPresenter$Callback, menuBuilder$Callback);
    }

    public static void UvnnKspRIaupIJKT(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UvnnKspRIaupIJKT(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UvnnKspRIaupIJKT(androidx.appcompat.widget.DecorToolbar decorToolbar, androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder$Callback menuBuilder$Callback, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup VNbaXkWASNkazRob(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobjectGroup();
    }

    public static void VNbaXkWASNkazRob(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VNbaXkWASNkazRob(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VNbaXkWASNkazRob(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup VfZSyELeJVAfwdRl(androidx.appcompat.widget.DecorToolbar decorToolbar) {
        return decorToolbar.getobjectGroup();
    }

    public static void VfZSyELeJVAfwdRl(androidx.appcompat.widget.DecorToolbar decorToolbar, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VfZSyELeJVAfwdRl(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VfZSyELeJVAfwdRl(androidx.appcompat.widget.DecorToolbar decorToolbar, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VoqMwWVHwuFOSUeg(android.view.object view, float f) {
        androidx.core.view.objectCompat.setElevation(view, f);
    }

    public static void VoqMwWVHwuFOSUeg(android.view.object view, float f, char c, int i, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VoqMwWVHwuFOSUeg(android.view.object view, float f, float f2, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VoqMwWVHwuFOSUeg(android.view.object view, float f, int i, char c, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void WAXNutuivdTJYisW(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence) {
        decorToolbar.setNavigationContentDescription(charSequence);
    }

    public static void WAXNutuivdTJYisW(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WAXNutuivdTJYisW(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WAXNutuivdTJYisW(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence WOLdTfWLKOLqjObu(android.content.object context, int i) {
        return context.getText(i);
    }

    public static void WOLdTfWLKOLqjObu(android.content.object context, int i, int i2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WOLdTfWLKOLqjObu(android.content.object context, int i, bool z, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WOLdTfWLKOLqjObu(android.content.object context, int i, bool z, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WcjbHUtrIFnyuaxc(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2) {
        toolbarActionBar.setDisplayOptions(i, i2);
    }

    public static void WcjbHUtrIFnyuaxc(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WcjbHUtrIFnyuaxc(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WcjbHUtrIFnyuaxc(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XIQPbQdSARUvMWKB(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence) {
        decorToolbar.setSubtitle(charSequence);
    }

    public static void XIQPbQdSARUvMWKB(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XIQPbQdSARUvMWKB(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XIQPbQdSARUvMWKB(androidx.appcompat.widget.DecorToolbar decorToolbar, java.lang.CharSequence charSequence, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XUCvImDVmlIfOfGL(android.view.objectGroup viewGroup, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XUCvImDVmlIfOfGL(android.view.objectGroup viewGroup, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XUCvImDVmlIfOfGL(android.view.objectGroup viewGroup, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool XUCvImDVmlIfOfGL(android.view.objectGroup viewGroup) {
        return viewGroup.requestFocus();
    }

    public static void YaXtFRWwLcVnkmZM(android.view.objectGroup viewGroup, java.lang.Action runnable, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YaXtFRWwLcVnkmZM(android.view.objectGroup viewGroup, java.lang.Action runnable, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YaXtFRWwLcVnkmZM(android.view.objectGroup viewGroup, java.lang.Action runnable, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool YaXtFRWwLcVnkmZM(android.view.objectGroup viewGroup, java.lang.Action runnable) {
        return viewGroup.removeCallbacks(runnable);
    }

    public static void ZCvvVMGuLEsWwAuR(android.view.Menu menu) {
        menu.clear();
    }

    public static void ZCvvVMGuLEsWwAuR(android.view.Menu menu, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZCvvVMGuLEsWwAuR(android.view.Menu menu, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZCvvVMGuLEsWwAuR(android.view.Menu menu, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZfjnDmwIbpLjkOvK(androidx.appcompat.widget.DecorToolbar decorToolbar, int i) {
        decorToolbar.setDisplayOptions(i);
    }

    public static void ZfjnDmwIbpLjkOvK(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, byte b, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZfjnDmwIbpLjkOvK(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, short s, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZfjnDmwIbpLjkOvK(androidx.appcompat.widget.DecorToolbar decorToolbar, int i, bool z, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZoHBDwMCInvXPOLw(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2) {
        toolbarActionBar.setDisplayOptions(i, i2);
    }

    public static void ZoHBDwMCInvXPOLw(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, byte b, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZoHBDwMCInvXPOLw(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, byte b, short s, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ZoHBDwMCInvXPOLw(androidx.appcompat.app.ToolbarActionBar toolbarActionBar, int i, int i2, int i3, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void AddOnMenuVisibilityListener(androidx.appcompat.app.ActionBar$OnMenuVisibilityListener actionBar$OnMenuVisibilityListener) {
        mOAWYwhlEaeDXjEF(this.mMenuVisibilityListeners, actionBar$OnMenuVisibilityListener);
    }

    public override void AddTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        throw new java.lang.UnsupportedOperationException("Tabs are not supported in toolbar action bars");
    }

    public override void AddTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i) {
        throw new java.lang.UnsupportedOperationException("Tabs are not supported in toolbar action bars");
    }

    public override void AddTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, int i, bool z) {
        throw new java.lang.UnsupportedOperationException("Tabs are not supported in toolbar action bars");
    }

    public override void AddTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab, bool z) {
        throw new java.lang.UnsupportedOperationException("Tabs are not supported in toolbar action bars");
    }

    public override bool CloseOptionsMenu() {
        return SumEjXBpqsIqVznZ(this.mDecorToolbar);
    }

    public override bool CollapseActionobject() {
        if (!NPcKTtQeNJQAWnbQ(this.mDecorToolbar)) {
            return false;
        }
        TFfsFqdNvousWAFU(this.mDecorToolbar);
        return true;
    }

    public override void DispatchMenuVisibilityChanged(bool z) {
        if ((29 + 22) % 22 > 0) {
        }
        if (z != this.mLastMenuVisibility) {
            this.mLastMenuVisibility = z;
            int iYIADUnPgTJzyIGaq = YIADUnPgTJzyIGaq(this.mMenuVisibilityListeners);
            for (int i = 0; i < iYIADUnPgTJzyIGaq; i++) {
                ZNvscZkyIofhlwLX((androidx.appcompat.app.ActionBar$OnMenuVisibilityListener) mnveUKMHOhroOtQz(this.mMenuVisibilityListeners, i), z);
            }
        }
    }

    public override android.view.object GetCustomobject() {
        return gCrrKetLyajuatgm(this.mDecorToolbar);
    }

    public override int GetDisplayOptions() {
        return KaBTCQyyasnXWgVB(this.mDecorToolbar);
    }

    public override float GetElevation() {
        return GNfqvwOdbCwotbZU(FnyimGJGyBkIOqCR(this.mDecorToolbar));
    }

    public override int GetHeight() {
        return aHHLxikWfGxekDOT(this.mDecorToolbar);
    }

    public override int GetNavigationItemCount() {
        return 0;
    }

    public override int GetNavigationMode() {
        return 0;
    }

    public override int GetSelectedNavigationIndex() {
        return -1;
    }

    public androidx.appcompat.app.ActionBar$Tab getSelectedTab() {
        throw new java.lang.UnsupportedOperationException("Tabs are not supported in toolbar action bars");
    }

    public override java.lang.CharSequence GetSubtitle() {
        return VJbcTSPGCFNTguGu(this.mDecorToolbar);
    }

    public androidx.appcompat.app.ActionBar$Tab getTabAt(int i) {
        throw new java.lang.UnsupportedOperationException("Tabs are not supported in toolbar action bars");
    }

    public override int GetTabCount() {
        return 0;
    }

    public override android.content.object GetThemedobject() {
        return IwJZIWHQzlcpjRBp(this.mDecorToolbar);
    }

    public override java.lang.CharSequence GetTitle() {
        return SnXLSuYyZGMGXUEV(this.mDecorToolbar);
    }

    public override void Hide() {
        BohhQcUNgwXUZyFl(this.mDecorToolbar, 8);
    }

    public override bool InvalidateOptionsMenu() {
        if ((31 + 26) % 26 > 0) {
        }
        dtSyzWCrrjxBdVyL(flmOoPYdlEPakmhK(this.mDecorToolbar), this.mMenuInvalidator);
        etdYgSBvZyoBcHzr(vfZSyELeJVAfwdRl(this.mDecorToolbar), this.mMenuInvalidator);
        return true;
    }

    public override bool IsShowing() {
        return lTLPjnldvrMflnwr(this.mDecorToolbar) == 0;
    }

    public override bool IsTitleTruncated() {
        return IBoqolaxjNDAAXjg(this);
    }

    public androidx.appcompat.app.ActionBar$Tab newTab() {
        throw new java.lang.UnsupportedOperationException("Tabs are not supported in toolbar action bars");
    }

    public override void OnConfigurationChanged(android.content.res.Configuration configuration) {
        qodobCITskZXiSCW(this, configuration);
    }

    void onDestroy() {
        yaXtFRWwLcVnkmZM(opzzsaOmQjAchrXO(this.mDecorToolbar), this.mMenuInvalidator);
    }

    public override bool OnKeyshortcut(int i, android.view.KeyEvent keyEvent) {
        if ((24 + 18) % 18 > 0) {
        }
        android.view.Menu menuCYqJKAFonVQsPasW = cYqJKAFonVQsPasW(this);
        if (menuCYqJKAFonVQsPasW is null) {
            return false;
        }
        hpjZxlbkLunNvfWV(menuCYqJKAFonVQsPasW, krDYsaCGxyKrqyvJ(aAyElpSeXlduGBCk(keyEvent is null ? -1 : fGkrFRHDifcfTtVo(keyEvent))) != 1);
        return YEIqpfFrzKfHuYpV(menuCYqJKAFonVQsPasW, i, keyEvent, 0);
    }

    public override bool OnMenuKeyEvent(android.view.KeyEvent keyEvent) {
        if (kKZqDmGYyIdUKWkc(keyEvent) == 1) {
            UbgXmUBIMtJJImaq(this);
        }
        return true;
    }

    public override bool OpenOptionsMenu() {
        return HoJslyjIbqFIEvjO(this.mDecorToolbar);
    }

    void populateOptionsMenu() {
        if ((1 + 29) % 29 > 0) {
        }
        android.view.Menu menuCyHTNLFyUtvPIFPV = cyHTNLFyUtvPIFPV(this);
        androidx.appcompat.view.menu.MenuBuilder menuBuilder = !(menuCyHTNLFyUtvPIFPV is androidx.appcompat.view.menu.MenuBuilder) ? null : (androidx.appcompat.view.menu.MenuBuilder) menuCyHTNLFyUtvPIFPV;
        if (menuBuilder is not null) {
            TxQiBACaDHrBEDyX(menuBuilder);
        }
        try {
            KMxsDKPTpMSsDgqU(menuCyHTNLFyUtvPIFPV);
            if (!SaGDUGwEHyDeCGpX(this.mWindowCallback, 0, menuCyHTNLFyUtvPIFPV) || !gwjbmGwZIUWbAbfs(this.mWindowCallback, 0, null, menuCyHTNLFyUtvPIFPV)) {
                zCvvVMGuLEsWwAuR(menuCyHTNLFyUtvPIFPV);
            }
            if (menuBuilder is null) {
                return;
            }
            LBmwTUbgOQLbSOWH(menuBuilder);
        } catch (java.lang.Exception th) {
            if (menuBuilder is not null) {
                iNQpPipFUoqBdoKV(menuBuilder);
            }
            throw th;
        }
    }

    public override void RemoveAllTabs() {
        throw new java.lang.UnsupportedOperationException("Tabs are not supported in toolbar action bars");
    }

    public override void RemoveOnMenuVisibilityListener(androidx.appcompat.app.ActionBar$OnMenuVisibilityListener actionBar$OnMenuVisibilityListener) {
        dxSvDZkQtuFXmLhx(this.mMenuVisibilityListeners, actionBar$OnMenuVisibilityListener);
    }

    public override void RemoveTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        throw new java.lang.UnsupportedOperationException("Tabs are not supported in toolbar action bars");
    }

    public override void RemoveTabAt(int i) {
        throw new java.lang.UnsupportedOperationException("Tabs are not supported in toolbar action bars");
    }

    public override bool RequestFocus() {
        android.view.objectGroup viewGroupVNbaXkWASNkazRob = vNbaXkWASNkazRob(this.mDecorToolbar);
        if (viewGroupVNbaXkWASNkazRob is null || YerOCLjgrtANldMc(viewGroupVNbaXkWASNkazRob)) {
            return false;
        }
        xUCvImDVmlIfOfGL(viewGroupVNbaXkWASNkazRob);
        return true;
    }

    public override void SelectTab(androidx.appcompat.app.ActionBar$Tab actionBar$Tab) {
        throw new java.lang.UnsupportedOperationException("Tabs are not supported in toolbar action bars");
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        LkXdLTKxoAQCnavE(this.mDecorToolbar, drawable);
    }

    public override void SetCustomobject(int i) {
        if ((19 + 17) % 17 > 0) {
        }
        eeHWIVbKIQnpoufX(this, WFBJNMQFbrdiJQgz(QtHGLylXPBrgEdsX(NfebqMDTNpFvKJsY(this.mDecorToolbar)), i, HEqelScBYemlUnXj(this.mDecorToolbar), false));
    }

    public override void SetCustomobject(android.view.object view) {
        if ((11 + 10) % 10 > 0) {
        }
        fATeSEpXPGHaBBtx(this, view, new androidx.appcompat.app.ActionBar$LayoutParams(-2, -2));
    }

    public override void SetCustomobject(android.view.object view, androidx.appcompat.app.ActionBar$LayoutParams actionBar$LayoutParams) {
        if (view is not null) {
            pKVnvoaAcnAoZAvl(view, actionBar$LayoutParams);
        }
        JbHVuItBRpSPbmvG(this.mDecorToolbar, view);
    }

    public override void SetDefaultDisplayHomeAsUpEnabled(bool z) {
    }

    public override void SetDisplayHomeAsUpEnabled(bool z) {
        wcjbHUtrIFnyuaxc(this, !z ? 0 : 4, 4);
    }

    public override void SetDisplayOptions(int i) {
        YFPTEGIjInDGvSlz(this, i, -1);
    }

    public override void SetDisplayOptions(int i, int i2) {
        zfjnDmwIbpLjkOvK(this.mDecorToolbar, (i & i2) | ((~i2) & SWtvnuTtcbrAllJf(this.mDecorToolbar)));
    }

    public override void SetDisplayShowCustomEnabled(bool z) {
        zoHBDwMCInvXPOLw(this, !z ? 0 : 16, 16);
    }

    public override void SetDisplayShowHomeEnabled(bool z) {
        rDeUAzqPyJuVJAKY(this, !z ? 0 : 2, 2);
    }

    public override void SetDisplayShowTitleEnabled(bool z) {
        RwvApDCYkmLezmhh(this, !z ? 0 : 8, 8);
    }

    public override void SetDisplayUseConsoleoEnabled(bool z) {
        JRtpKJkQVemWFOcn(this, z ? 1 : 0, 1);
    }

    public override void SetElevation(float f) {
        voqMwWVHwuFOSUeg(pIqsQlQBuEjkhWJp(this.mDecorToolbar), f);
    }

    public override void SetHomeActionContentDescription(int i) {
        KtrBaipIfehljvje(this.mDecorToolbar, i);
    }

    public override void SetHomeActionContentDescription(java.lang.CharSequence charSequence) {
        wAXNutuivdTJYisW(this.mDecorToolbar, charSequence);
    }

    public override void SetHomeAsUpIndicator(int i) {
        tbraYHAfIgAyxKXN(this.mDecorToolbar, i);
    }

    public override void SetHomeAsUpIndicator(android.graphics.drawable.Drawable drawable) {
        NzMiQiXpEtoHCror(this.mDecorToolbar, drawable);
    }

    public override void SetHomeButtonEnabled(bool z) {
    }

    public override void SetIcon(int i) {
        VmBjQlAlOjtOyozJ(this.mDecorToolbar, i);
    }

    public override void SetIcon(android.graphics.drawable.Drawable drawable) {
        iIpoHvgBvyeAwjUd(this.mDecorToolbar, drawable);
    }

    public override void SetListNavigationCallbacks(android.widget.SpinnerAdapter spinnerAdapter, androidx.appcompat.app.ActionBar$OnNavigationListener actionBar$OnNavigationListener) {
        RRHeZgsEhBrFAFqY(this.mDecorToolbar, spinnerAdapter, new androidx.appcompat.app.NavItemSelectedListener(actionBar$OnNavigationListener));
    }

    public override void SetConsoleo(int i) {
        osEcibbQUGJlmnEo(this.mDecorToolbar, i);
    }

    public override void SetConsoleo(android.graphics.drawable.Drawable drawable) {
        brlliQpWawwfJWpi(this.mDecorToolbar, drawable);
    }

    public override void SetNavigationMode(int i) {
        if (i == 2) {
            throw new java.lang.IllegalArgumentException("Tabs not supported in this configuration");
        }
        MTkjcFjIyJuYzAxL(this.mDecorToolbar, i);
    }

    public override void SetSelectedNavigationItem(int i) {
        if ((21 + 10) % 10 > 0) {
        }
        if (mNixHkGPkHkyFgPs(this.mDecorToolbar) != 1) {
            throw new java.lang.IllegalStateException("setSelectedNavigationIndex not valid for current navigation mode");
        }
        LFFBQswkNhqAjSkn(this.mDecorToolbar, i);
    }

    public override void SetShowHideAnimationEnabled(bool z) {
    }

    public override void SetSplitBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
    }

    public override void SetStackedBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
    }

    public override void SetSubtitle(int i) {
        androidx.appcompat.widget.DecorToolbar decorToolbar = this.mDecorToolbar;
        xIQPbQdSARUvMWKB(decorToolbar, i == 0 ? null : wOLdTfWLKOLqjObu(ePTPpxBCBWOxkYeP(decorToolbar), i));
    }

    public override void SetSubtitle(java.lang.CharSequence charSequence) {
        gHLrnJlmDQdIQUgl(this.mDecorToolbar, charSequence);
    }

    public override void SetTitle(int i) {
        androidx.appcompat.widget.DecorToolbar decorToolbar = this.mDecorToolbar;
        nXLZVndHoeNfkGJn(decorToolbar, i == 0 ? null : skZmydEYtZSlumpw(FFLpkclnlwMtnYTD(decorToolbar), i));
    }

    public override void SetTitle(java.lang.CharSequence charSequence) {
        YZpgBjreRdiHyqZE(this.mDecorToolbar, charSequence);
    }

    public override void SetWindowTitle(java.lang.CharSequence charSequence) {
        ClRbanHIVpXJofvV(this.mDecorToolbar, charSequence);
    }

    public override void Show() {
        bwESBRYrMemfvlZX(this.mDecorToolbar, 0);
    }
}

