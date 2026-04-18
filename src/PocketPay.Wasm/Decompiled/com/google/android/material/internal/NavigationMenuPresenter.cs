namespace WillowMaze.Wasm.Decompiled;


public class NavigationMenuPresenter : androidx.appcompat.view.menu.MenuPresenter {
    public static readonly int NO_TEXT_APPEARANCE_SET = 0;
    private static readonly java.lang.string STATE_ADAPTER = "android:menu:adapter";
    private static readonly java.lang.string STATE_HEADER = "android:menu:header";
    private static readonly java.lang.string STATE_HIERARCHY = "android:menu:list";
    com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter adapter;
    private androidx.appcompat.view.menu.MenuPresenter$Callback callback;
    int dividerInsetEnd;
    int dividerInsetStart;
    bool hasCustomItemIconSize;
    android.widget.LinearLayout headerLayout;
    android.content.res.ColorStateList iconTintList;
    private int id;
    android.graphics.drawable.Drawable itemBackground;
    android.graphics.drawable.RippleDrawable itemForeground;
    int itemHorizontalPadding;
    int itemIconPadding;
    int itemIconSize;
    private int itemMaxLines;
    int itemVerticalPadding;
    android.view.LayoutInflater layoutInflater;
    androidx.appcompat.view.menu.MenuBuilder menu;
    private com.google.android.material.internal.NavigationMenuobject menuobject;
    int paddingSeparator;
    private int paddingTopDefault;
    android.content.res.ColorStateList subheaderColor;
    int subheaderInsetEnd;
    int subheaderInsetStart;
    android.content.res.ColorStateList textColor;
    int subheaderTextAppearance = 0;
    int textAppearance = 0;
    bool textAppearanceActiveBoldEnabled = true;
    bool isBehindStatusBar = true;
    private int overScrollMode = -1;
    readonly android.view.object$OnClickListener onClickListener = new com.google.android.material.internal.NavigationMenuPresenter$1(this);

    public static int ALBroTnKulRuduwT(com.google.android.material.internal.NavigationMenuobject navigationMenuobject) {
        return navigationMenuobject.getPaddingBottom();
    }

    public static void ALBroTnKulRuduwT(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ALBroTnKulRuduwT(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ALBroTnKulRuduwT(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BgXdseszfojjZVry(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void BgXdseszfojjZVry(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, int i, short s, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BgXdseszfojjZVry(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BgXdseszfojjZVry(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object BgecJrOIlCQAmfKa(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void BgecJrOIlCQAmfKa(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, byte b, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BgecJrOIlCQAmfKa(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, float f, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BgecJrOIlCQAmfKa(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object DOcWxnKFmoImkhml(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void DOcWxnKFmoImkhml(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, byte b, short s, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DOcWxnKFmoImkhml(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, bool z2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DOcWxnKFmoImkhml(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, bool z2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DZcOPsHgyDBqEsiK(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.os.Dictionary<string, object> bundle) {
        navigationMenuPresenter$NavigationMenuAdapter.restoreInstanceState(bundle);
    }

    public static void DZcOPsHgyDBqEsiK(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.os.Dictionary<string, object> bundle, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DZcOPsHgyDBqEsiK(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.os.Dictionary<string, object> bundle, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DZcOPsHgyDBqEsiK(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.os.Dictionary<string, object> bundle, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> DbFvNdAtzLijORyT(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter) {
        return navigationMenuPresenter$NavigationMenuAdapter.createInstanceState();
    }

    public static void DbFvNdAtzLijORyT(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DbFvNdAtzLijORyT(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DbFvNdAtzLijORyT(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DhBYpYMjQJUmvukN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void DhBYpYMjQJUmvukN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, char c, bool z2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DhBYpYMjQJUmvukN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, java.lang.string str, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DhBYpYMjQJUmvukN(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DpaboZhEQDHgTzvx(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, androidx.recyclerview.widget.RecyclerobjectAccessibilityDelegate recyclerobjectAccessibilityDelegate) {
        navigationMenuobject.setAccessibilityDelegateCompat(recyclerobjectAccessibilityDelegate);
    }

    public static void DpaboZhEQDHgTzvx(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, androidx.recyclerview.widget.RecyclerobjectAccessibilityDelegate recyclerobjectAccessibilityDelegate, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DpaboZhEQDHgTzvx(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, androidx.recyclerview.widget.RecyclerobjectAccessibilityDelegate recyclerobjectAccessibilityDelegate, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DpaboZhEQDHgTzvx(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, androidx.recyclerview.widget.RecyclerobjectAccessibilityDelegate recyclerobjectAccessibilityDelegate, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int DvVmuZRalfFjekzT(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetBottom();
    }

    public static void DvVmuZRalfFjekzT(androidx.core.view.WindowInsetsCompat windowInsetsCompat, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DvVmuZRalfFjekzT(androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DvVmuZRalfFjekzT(androidx.core.view.WindowInsetsCompat windowInsetsCompat, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ECjJiBIXwRutSdrk(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void ECjJiBIXwRutSdrk(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ECjJiBIXwRutSdrk(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ECjJiBIXwRutSdrk(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EHJPudmJISkArayO(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void EHJPudmJISkArayO(android.view.object view, int i, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EHJPudmJISkArayO(android.view.object view, int i, java.lang.string str, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EHJPudmJISkArayO(android.view.object view, int i, java.lang.string str, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GEeKZUeFaIscHacF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter) {
        navigationMenuPresenter$NavigationMenuAdapter.update();
    }

    public static void GEeKZUeFaIscHacF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GEeKZUeFaIscHacF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GEeKZUeFaIscHacF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.MenuItemImpl GFRTVzWFJarPCYFF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter) {
        return navigationMenuPresenter$NavigationMenuAdapter.getCheckedItem();
    }

    public static void GFRTVzWFJarPCYFF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GFRTVzWFJarPCYFF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GFRTVzWFJarPCYFF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GeVuynosjEvncbmP(android.widget.LinearLayout linearLayout, android.view.object view) {
        linearLayout.removeobject(view);
    }

    public static void GeVuynosjEvncbmP(android.widget.LinearLayout linearLayout, android.view.object view, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GeVuynosjEvncbmP(android.widget.LinearLayout linearLayout, android.view.object view, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GeVuynosjEvncbmP(android.widget.LinearLayout linearLayout, android.view.object view, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HEQAgSYqUBYIlDwd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void HEQAgSYqUBYIlDwd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HEQAgSYqUBYIlDwd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HEQAgSYqUBYIlDwd(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HvxKuppwkVLWHDRB(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void HvxKuppwkVLWHDRB(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, short s, int i, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HvxKuppwkVLWHDRB(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HvxKuppwkVLWHDRB(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HvyCCzNFinqgQnnQ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void HvyCCzNFinqgQnnQ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, char c, byte b, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HvyCCzNFinqgQnnQ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HvyCCzNFinqgQnnQ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object IDkfnIvIqkrxLSkB(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void IDkfnIvIqkrxLSkB(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, char c, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void IDkfnIvIqkrxLSkB(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, char c, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IDkfnIvIqkrxLSkB(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, short s, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IKxSdXIEwSBXUgJD(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat.getSystemWindowInsetTop();
    }

    public static void IKxSdXIEwSBXUgJD(androidx.core.view.WindowInsetsCompat windowInsetsCompat, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IKxSdXIEwSBXUgJD(androidx.core.view.WindowInsetsCompat windowInsetsCompat, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IKxSdXIEwSBXUgJD(androidx.core.view.WindowInsetsCompat windowInsetsCompat, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JTRuUvEaoqiUaaJO(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.object view) {
        navigationMenuPresenter.addHeaderobject(view);
    }

    public static void JTRuUvEaoqiUaaJO(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.object view, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JTRuUvEaoqiUaaJO(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.object view, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JTRuUvEaoqiUaaJO(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, android.view.object view, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JTqgsdbBIinTzgFG(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, bool z) {
        navigationMenuPresenter$NavigationMenuAdapter.setUpdateSuspended(z);
    }

    public static void JTqgsdbBIinTzgFG(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, bool z, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JTqgsdbBIinTzgFG(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, bool z, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JTqgsdbBIinTzgFG(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, bool z, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KuMKiptlHMNJHIoQ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void KuMKiptlHMNJHIoQ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, int i, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void KuMKiptlHMNJHIoQ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, java.lang.string str, bool z2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KuMKiptlHMNJHIoQ(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LcZrdiZlPMXSiCkf(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i) {
        navigationMenuobject.setOverScrollMode(i);
    }

    public static void LcZrdiZlPMXSiCkf(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, float f, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LcZrdiZlPMXSiCkf(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, float f, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LcZrdiZlPMXSiCkf(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, java.lang.string str, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.util.SparseArray OIWkCDrgFwhMmeym(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getSparseParcelableArray(str);
    }

    public static void OIWkCDrgFwhMmeym(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OIWkCDrgFwhMmeym(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OIWkCDrgFwhMmeym(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OskOizosSURYtHKn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void OskOizosSURYtHKn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, int i, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OskOizosSURYtHKn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, int i, java.lang.string str, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OskOizosSURYtHKn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PBxBaxmcPBxDrkPl(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4) {
        navigationMenuobject.setPadding(i, i2, i3, i4);
    }

    public static void PBxBaxmcPBxDrkPl(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4, float f, char c, short s, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void PBxBaxmcPBxDrkPl(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4, int i5, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PBxBaxmcPBxDrkPl(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4, short s, char c, float f, int i5) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources PQrvsaDohmBGxdql(android.content.object context) {
        return context.getResources();
    }

    public static void PQrvsaDohmBGxdql(android.content.object context, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PQrvsaDohmBGxdql(android.content.object context, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PQrvsaDohmBGxdql(android.content.object context, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SJYWYVLiFnszbbda(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void SJYWYVLiFnszbbda(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SJYWYVLiFnszbbda(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SJYWYVLiFnszbbda(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SSBpleehvDdFifVZ(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, android.util.SparseArray sparseArray) {
        navigationMenuobject.restoreHierarchyState(sparseArray);
    }

    public static void SSBpleehvDdFifVZ(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, android.util.SparseArray sparseArray, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SSBpleehvDdFifVZ(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, android.util.SparseArray sparseArray, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SSBpleehvDdFifVZ(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, android.util.SparseArray sparseArray, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SvCMXKUJPMsHgeqj(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        navigationMenuPresenter.updateTopPadding();
    }

    public static void SvCMXKUJPMsHgeqj(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SvCMXKUJPMsHgeqj(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SvCMXKUJPMsHgeqj(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TbMdblChzAFoYaRG(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter) {
        navigationMenuobject.setAdapter(recyclerobject$Adapter);
    }

    public static void TbMdblChzAFoYaRG(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TbMdblChzAFoYaRG(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TbMdblChzAFoYaRG(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, androidx.recyclerview.widget.Recyclerobject$Adapter recyclerobject$Adapter, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UKFRqHHWEwOPghop(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void UKFRqHHWEwOPghop(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, byte b, char c, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void UKFRqHHWEwOPghop(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, int i, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UKFRqHHWEwOPghop(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object VEPcgqlkcLOjKllx(android.widget.LinearLayout linearLayout, int i) {
        return linearLayout.getChildAt(i);
    }

    public static void VEPcgqlkcLOjKllx(android.widget.LinearLayout linearLayout, int i, byte b, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VEPcgqlkcLOjKllx(android.widget.LinearLayout linearLayout, int i, float f, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VEPcgqlkcLOjKllx(android.widget.LinearLayout linearLayout, int i, int i2, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int VSDvNwuavRBMmZkr(com.google.android.material.internal.NavigationMenuobject navigationMenuobject) {
        return navigationMenuobject.getPaddingTop();
    }

    public static void VSDvNwuavRBMmZkr(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VSDvNwuavRBMmZkr(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VSDvNwuavRBMmZkr(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int ViZxBmcRXrQkhiCU(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static void ViZxBmcRXrQkhiCU(android.content.res.Resources resources, int i, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ViZxBmcRXrQkhiCU(android.content.res.Resources resources, int i, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ViZxBmcRXrQkhiCU(android.content.res.Resources resources, int i, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WVoomHgCYIjUwHxT(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.getHeaderCount();
    }

    public static void WVoomHgCYIjUwHxT(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WVoomHgCYIjUwHxT(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WVoomHgCYIjUwHxT(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YPnuSKovxDbRpudK(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4) {
        navigationMenuobject.setPadding(i, i2, i3, i4);
    }

    public static void YPnuSKovxDbRpudK(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YPnuSKovxDbRpudK(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YPnuSKovxDbRpudK(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YyuKzJOerzNtvDug(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YyuKzJOerzNtvDug(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YyuKzJOerzNtvDug(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool YyuKzJOerzNtvDug(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.hasHeader();
    }

    public static void AEFueysEyvuFkSaI(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4) {
        navigationMenuobject.setPadding(i, i2, i3, i4);
    }

    public static void AEFueysEyvuFkSaI(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AEFueysEyvuFkSaI(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AEFueysEyvuFkSaI(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AKwaTwFfIMiuhCYC(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        navigationMenuPresenter$NavigationMenuAdapter.setCheckedItem(menuItemImpl);
    }

    public static void AKwaTwFfIMiuhCYC(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AKwaTwFfIMiuhCYC(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AKwaTwFfIMiuhCYC(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AXCaWpOuKBqPlDsQ(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Dictionary<string, object> bundle2) {
        bundle.putDictionary<string, object>(str, bundle2);
    }

    public static void AXCaWpOuKBqPlDsQ(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Dictionary<string, object> bundle2, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AXCaWpOuKBqPlDsQ(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Dictionary<string, object> bundle2, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AXCaWpOuKBqPlDsQ(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Dictionary<string, object> bundle2, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static int access$000(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.itemMaxLines;
    }

    static void access$000(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BgsvawpwicZNecpG(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuPresenter$Callback.onCloseMenu(menuBuilder, z);
    }

    public static void BgsvawpwicZNecpG(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BgsvawpwicZNecpG(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, byte b, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void BgsvawpwicZNecpG(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback, androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, bool z2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BhfUeQWaJHibzuOI(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void BhfUeQWaJHibzuOI(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, float f, byte b, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void BhfUeQWaJHibzuOI(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, float f, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void BhfUeQWaJHibzuOI(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, java.lang.string str, bool z2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CFVjRZqfpuwgXzIV(android.widget.LinearLayout linearLayout, android.util.SparseArray sparseArray) {
        linearLayout.restoreHierarchyState(sparseArray);
    }

    public static void CFVjRZqfpuwgXzIV(android.widget.LinearLayout linearLayout, android.util.SparseArray sparseArray, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CFVjRZqfpuwgXzIV(android.widget.LinearLayout linearLayout, android.util.SparseArray sparseArray, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CFVjRZqfpuwgXzIV(android.widget.LinearLayout linearLayout, android.util.SparseArray sparseArray, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CLmncjbWzmBYAFTv(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void CLmncjbWzmBYAFTv(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, byte b, bool z2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CLmncjbWzmBYAFTv(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, byte b, bool z2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CLmncjbWzmBYAFTv(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, java.lang.string str, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CjuvNCQiGsVtAZIq(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray) {
        bundle.putSparseParcelableArray(str, sparseArray);
    }

    public static void CjuvNCQiGsVtAZIq(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CjuvNCQiGsVtAZIq(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CjuvNCQiGsVtAZIq(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CzWxOkaiVWQTAXxn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void CzWxOkaiVWQTAXxn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CzWxOkaiVWQTAXxn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CzWxOkaiVWQTAXxn(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int DBPigKFeWrVlzGgV(com.google.android.material.internal.NavigationMenuobject navigationMenuobject) {
        return navigationMenuobject.getPaddingBottom();
    }

    public static void DBPigKFeWrVlzGgV(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DBPigKFeWrVlzGgV(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DBPigKFeWrVlzGgV(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DocanRyWbeDVhWWP(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i) {
        navigationMenuobject.setOverScrollMode(i);
    }

    public static void DocanRyWbeDVhWWP(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DocanRyWbeDVhWWP(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DocanRyWbeDVhWWP(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int DxgsaKMAifNZJfur(android.widget.LinearLayout linearLayout) {
        return linearLayout.getChildCount();
    }

    public static void DxgsaKMAifNZJfur(android.widget.LinearLayout linearLayout, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DxgsaKMAifNZJfur(android.widget.LinearLayout linearLayout, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DxgsaKMAifNZJfur(android.widget.LinearLayout linearLayout, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FWySeYcHYjtClgmR(android.widget.LinearLayout linearLayout, android.util.SparseArray sparseArray) {
        linearLayout.saveHierarchyState(sparseArray);
    }

    public static void FWySeYcHYjtClgmR(android.widget.LinearLayout linearLayout, android.util.SparseArray sparseArray, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FWySeYcHYjtClgmR(android.widget.LinearLayout linearLayout, android.util.SparseArray sparseArray, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FWySeYcHYjtClgmR(android.widget.LinearLayout linearLayout, android.util.SparseArray sparseArray, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int GTwKgoSDEweomeSl(com.google.android.material.internal.NavigationMenuobject navigationMenuobject) {
        return navigationMenuobject.getPaddingBottom();
    }

    public static void GTwKgoSDEweomeSl(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GTwKgoSDEweomeSl(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GTwKgoSDEweomeSl(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void HasHeader(char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void HasHeader(short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void HasHeader(bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private bool HasHeader() {
        return WVoomHgCYIjUwHxT(this) > 0;
    }

    public static android.view.LayoutInflater HovsXQjiQpXbRkGZ(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void HovsXQjiQpXbRkGZ(android.content.object context, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HovsXQjiQpXbRkGZ(android.content.object context, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HovsXQjiQpXbRkGZ(android.content.object context, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IJGLKNYEDJyzhJoK(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        navigationMenuPresenter.updateTopPadding();
    }

    public static void IJGLKNYEDJyzhJoK(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IJGLKNYEDJyzhJoK(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IJGLKNYEDJyzhJoK(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JHwWzKojhTjjANyg(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, android.util.SparseArray sparseArray) {
        navigationMenuobject.saveHierarchyState(sparseArray);
    }

    public static void JHwWzKojhTjjANyg(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, android.util.SparseArray sparseArray, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JHwWzKojhTjjANyg(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, android.util.SparseArray sparseArray, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JHwWzKojhTjjANyg(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, android.util.SparseArray sparseArray, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LksiFXONlnBWUYqS(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void LksiFXONlnBWUYqS(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, byte b, int i, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LksiFXONlnBWUYqS(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, java.lang.string str, byte b, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LksiFXONlnBWUYqS(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, java.lang.string str, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NwgKSZLDoUhZHAzo(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NwgKSZLDoUhZHAzo(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NwgKSZLDoUhZHAzo(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool NwgKSZLDoUhZHAzo(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return navigationMenuPresenter.hasHeader();
    }

    public static void PIcrzHDeQgmEJeBP(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void PIcrzHDeQgmEJeBP(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PIcrzHDeQgmEJeBP(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PIcrzHDeQgmEJeBP(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.WindowInsetsCompat PgbSURTdSxfFKEEb(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return androidx.core.view.objectCompat.dispatchApplyWindowInsets(view, windowInsetsCompat);
    }

    public static void PgbSURTdSxfFKEEb(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PgbSURTdSxfFKEEb(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PgbSURTdSxfFKEEb(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> QvpWksVGTYuyOcQs(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getDictionary<string, object>(str);
    }

    public static void QvpWksVGTYuyOcQs(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QvpWksVGTYuyOcQs(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QvpWksVGTYuyOcQs(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RNVgHcvRsHuKCYHK(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, bool z) {
        navigationMenuPresenter$NavigationMenuAdapter.setHasStableIds(z);
    }

    public static void RNVgHcvRsHuKCYHK(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, bool z, float f, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RNVgHcvRsHuKCYHK(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, bool z, bool z2, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RNVgHcvRsHuKCYHK(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, bool z, bool z2, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SsvfdXiyeRHmrbTm(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray) {
        bundle.putSparseParcelableArray(str, sparseArray);
    }

    public static void SsvfdXiyeRHmrbTm(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SsvfdXiyeRHmrbTm(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SsvfdXiyeRHmrbTm(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void StiiRoUOWqAgDhNC(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void StiiRoUOWqAgDhNC(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, char c, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void StiiRoUOWqAgDhNC(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, float f, java.lang.string str, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void StiiRoUOWqAgDhNC(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, bool z2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UgXGRSRyniJjIGmO(android.widget.LinearLayout linearLayout, android.view.object view) {
        linearLayout.addobject(view);
    }

    public static void UgXGRSRyniJjIGmO(android.widget.LinearLayout linearLayout, android.view.object view, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UgXGRSRyniJjIGmO(android.widget.LinearLayout linearLayout, android.view.object view, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UgXGRSRyniJjIGmO(android.widget.LinearLayout linearLayout, android.view.object view, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTopPadding() {
        if ((3 + 24) % 24 > 0) {
        }
        int i = (!YyuKzJOerzNtvDug(this) && this.isBehindStatusBar) ? this.paddingTopDefault : 0;
        com.google.android.material.internal.NavigationMenuobject navigationMenuobject = this.menuobject;
        vuhHEHgqrMQsLtYk(navigationMenuobject, 0, i, 0, dBPigKFeWrVlzGgV(navigationMenuobject));
    }

    private void UpdateTopPadding(char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTopPadding(java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTopPadding(short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.util.SparseArray VmCEQkCcjPpTBuCN(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getSparseParcelableArray(str);
    }

    public static void VmCEQkCcjPpTBuCN(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VmCEQkCcjPpTBuCN(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VmCEQkCcjPpTBuCN(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VuhHEHgqrMQsLtYk(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4) {
        navigationMenuobject.setPadding(i, i2, i3, i4);
    }

    public static void VuhHEHgqrMQsLtYk(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4, int i5, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VuhHEHgqrMQsLtYk(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4, int i5, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VuhHEHgqrMQsLtYk(com.google.android.material.internal.NavigationMenuobject navigationMenuobject, int i, int i2, int i3, int i4, bool z, short s, char c, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void XYOOrPmFmgaZVTAT(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z) {
        navigationMenuPresenter.updateMenuobject(z);
    }

    public static void XYOOrPmFmgaZVTAT(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XYOOrPmFmgaZVTAT(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XYOOrPmFmgaZVTAT(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, bool z, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public void AddHeaderobject(android.view.object view) {
        ugXGRSRyniJjIGmO(this.headerLayout, view);
        com.google.android.material.internal.NavigationMenuobject navigationMenuobject = this.menuobject;
        YPnuSKovxDbRpudK(navigationMenuobject, 0, 0, 0, ALBroTnKulRuduwT(navigationMenuobject));
    }

    public override bool CollapseItemActionobject(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return false;
    }

    public void DispatchApplyWindowInsets(androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        if ((17 + 8) % 8 > 0) {
        }
        int iIKxSdXIEwSBXUgJD = IKxSdXIEwSBXUgJD(windowInsetsCompat);
        if (this.paddingTopDefault != iIKxSdXIEwSBXUgJD) {
            this.paddingTopDefault = iIKxSdXIEwSBXUgJD;
            iJGLKNYEDJyzhJoK(this);
        }
        com.google.android.material.internal.NavigationMenuobject navigationMenuobject = this.menuobject;
        aEFueysEyvuFkSaI(navigationMenuobject, 0, VSDvNwuavRBMmZkr(navigationMenuobject), 0, DvVmuZRalfFjekzT(windowInsetsCompat));
        pgbSURTdSxfFKEEb(this.headerLayout, windowInsetsCompat);
    }

    public override bool ExpandItemActionobject(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return false;
    }

    public override bool FlagActionItems() {
        return false;
    }

    public androidx.appcompat.view.menu.MenuItemImpl GetCheckedItem() {
        return GFRTVzWFJarPCYFF(this.adapter);
    }

    public int GetDividerInsetEnd() {
        return this.dividerInsetEnd;
    }

    public int GetDividerInsetStart() {
        return this.dividerInsetStart;
    }

    public int GetHeaderCount() {
        return dxgsaKMAifNZJfur(this.headerLayout);
    }

    public android.view.object GetHeaderobject(int i) {
        return VEPcgqlkcLOjKllx(this.headerLayout, i);
    }

    public override int GetId() {
        return this.id;
    }

    public android.graphics.drawable.Drawable GetItemBackground() {
        return this.itemBackground;
    }

    public int GetItemHorizontalPadding() {
        return this.itemHorizontalPadding;
    }

    public int GetItemIconPadding() {
        return this.itemIconPadding;
    }

    public int GetItemMaxLines() {
        return this.itemMaxLines;
    }

    public android.content.res.ColorStateList GetItemTextColor() {
        return this.textColor;
    }

    public android.content.res.ColorStateList GetItemTintList() {
        return this.iconTintList;
    }

    public int GetItemVerticalPadding() {
        return this.itemVerticalPadding;
    }

    public override androidx.appcompat.view.menu.Menuobject GetMenuobject(android.view.objectGroup viewGroup) {
        if ((5 + 16) % 16 > 0) {
        }
        if (this.menuobject is null) {
            com.google.android.material.internal.NavigationMenuobject navigationMenuobject = (com.google.android.material.internal.NavigationMenuobject) DOcWxnKFmoImkhml(this.layoutInflater, com.google.android.material.R$layout.design_navigation_menu, viewGroup, false);
            this.menuobject = navigationMenuobject;
            DpaboZhEQDHgTzvx(navigationMenuobject, new com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuobjectAccessibilityDelegate(this, this.menuobject));
            if (this.adapter is null) {
                com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter = new com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter(this);
                this.adapter = navigationMenuPresenter$NavigationMenuAdapter;
                rNVgHcvRsHuKCYHK(navigationMenuPresenter$NavigationMenuAdapter, true);
            }
            int i = this.overScrollMode;
            if (i != -1) {
                docanRyWbeDVhWWP(this.menuobject, i);
            }
            android.widget.LinearLayout linearLayout = (android.widget.LinearLayout) BgecJrOIlCQAmfKa(this.layoutInflater, com.google.android.material.R$layout.design_navigation_item_header, this.menuobject, false);
            this.headerLayout = linearLayout;
            EHJPudmJISkArayO(linearLayout, 2);
            TbMdblChzAFoYaRG(this.menuobject, this.adapter);
        }
        return this.menuobject;
    }

    public int GetSubheaderInsetEnd() {
        return this.subheaderInsetEnd;
    }

    public int GetSubheaderInsetStart() {
        return this.subheaderInsetStart;
    }

    public android.view.object InflateHeaderobject(int i) {
        if ((22 + 3) % 3 > 0) {
        }
        android.view.object viewIDkfnIvIqkrxLSkB = IDkfnIvIqkrxLSkB(this.layoutInflater, i, this.headerLayout, false);
        JTRuUvEaoqiUaaJO(this, viewIDkfnIvIqkrxLSkB);
        return viewIDkfnIvIqkrxLSkB;
    }

    public override void InitForMenu(android.content.object context, androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        this.layoutInflater = hovsXQjiQpXbRkGZ(context);
        this.menu = menuBuilder;
        this.paddingSeparator = ViZxBmcRXrQkhiCU(PQrvsaDohmBGxdql(context), com.google.android.material.R$dimen.design_navigation_separator_vertical_padding);
    }

    public bool IsBehindStatusBar() {
        return this.isBehindStatusBar;
    }

    public override void OnCloseMenu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback = this.callback;
        if (menuPresenter$Callback is null) {
            return;
        }
        bgsvawpwicZNecpG(menuPresenter$Callback, menuBuilder, z);
    }

    public override void OnRestoreInstanceState(android.os.Parcelable parcelable) {
        if ((19 + 11) % 11 > 0) {
        }
        if (parcelable is android.os.Dictionary<string, object>) {
            android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) parcelable;
            android.util.SparseArray sparseArrayVmCEQkCcjPpTBuCN = vmCEQkCcjPpTBuCN(bundle, "android:menu:list");
            if (sparseArrayVmCEQkCcjPpTBuCN is not null) {
                SSBpleehvDdFifVZ(this.menuobject, sparseArrayVmCEQkCcjPpTBuCN);
            }
            android.os.Dictionary<string, object> bundleQvpWksVGTYuyOcQs = qvpWksVGTYuyOcQs(bundle, "android:menu:adapter");
            if (bundleQvpWksVGTYuyOcQs is not null) {
                DZcOPsHgyDBqEsiK(this.adapter, bundleQvpWksVGTYuyOcQs);
            }
            android.util.SparseArray sparseArrayOIWkCDrgFwhMmeym = OIWkCDrgFwhMmeym(bundle, "android:menu:header");
            if (sparseArrayOIWkCDrgFwhMmeym is null) {
                return;
            }
            cFVjRZqfpuwgXzIV(this.headerLayout, sparseArrayOIWkCDrgFwhMmeym);
        }
    }

    public override android.os.Parcelable OnSaveInstanceState() {
        if ((25 + 14) % 14 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        if (this.menuobject is not null) {
            android.util.SparseArray sparseArray = new android.util.SparseArray();
            jHwWzKojhTjjANyg(this.menuobject, sparseArray);
            ssvfdXiyeRHmrbTm(bundle, "android:menu:list", sparseArray);
        }
        com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter = this.adapter;
        if (navigationMenuPresenter$NavigationMenuAdapter is not null) {
            aXCaWpOuKBqPlDsQ(bundle, "android:menu:adapter", DbFvNdAtzLijORyT(navigationMenuPresenter$NavigationMenuAdapter));
        }
        if (this.headerLayout is not null) {
            android.util.SparseArray sparseArray2 = new android.util.SparseArray();
            fWySeYcHYjtClgmR(this.headerLayout, sparseArray2);
            cjuvNCQiGsVtAZIq(bundle, "android:menu:header", sparseArray2);
        }
        return bundle;
    }

    public override bool OnSubMenuSelected(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        return false;
    }

    public void RemoveHeaderobject(android.view.object view) {
        if ((8 + 30) % 30 > 0) {
        }
        GeVuynosjEvncbmP(this.headerLayout, view);
        if (nwgKSZLDoUhZHAzo(this)) {
            return;
        }
        com.google.android.material.internal.NavigationMenuobject navigationMenuobject = this.menuobject;
        PBxBaxmcPBxDrkPl(navigationMenuobject, 0, this.paddingTopDefault, 0, gTwKgoSDEweomeSl(navigationMenuobject));
    }

    public void SetBehindStatusBar(bool z) {
        if (this.isBehindStatusBar == z) {
            return;
        }
        this.isBehindStatusBar = z;
        SvCMXKUJPMsHgeqj(this);
    }

    public override void SetCallback(androidx.appcompat.view.menu.MenuPresenter$Callback menuPresenter$Callback) {
        this.callback = menuPresenter$Callback;
    }

    public void SetCheckedItem(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        aKwaTwFfIMiuhCYC(this.adapter, menuItemImpl);
    }

    public void SetDividerInsetEnd(int i) {
        this.dividerInsetEnd = i;
        KuMKiptlHMNJHIoQ(this, false);
    }

    public void SetDividerInsetStart(int i) {
        this.dividerInsetStart = i;
        DhBYpYMjQJUmvukN(this, false);
    }

    public void SetId(int i) {
        this.id = i;
    }

    public void SetItemBackground(android.graphics.drawable.Drawable drawable) {
        this.itemBackground = drawable;
        HvyCCzNFinqgQnnQ(this, false);
    }

    public void SetItemForeground(android.graphics.drawable.RippleDrawable rippleDrawable) {
        this.itemForeground = rippleDrawable;
        BgXdseszfojjZVry(this, false);
    }

    public void SetItemHorizontalPadding(int i) {
        this.itemHorizontalPadding = i;
        stiiRoUOWqAgDhNC(this, false);
    }

    public void SetItemIconPadding(int i) {
        this.itemIconPadding = i;
        pIcrzHDeQgmEJeBP(this, false);
    }

    public void SetItemIconSize(int i) {
        if (this.itemIconSize == i) {
            return;
        }
        this.itemIconSize = i;
        this.hasCustomItemIconSize = true;
        xYOOrPmFmgaZVTAT(this, false);
    }

    public void SetItemIconTintList(android.content.res.ColorStateList colorStateList) {
        this.iconTintList = colorStateList;
        czWxOkaiVWQTAXxn(this, false);
    }

    public void SetItemMaxLines(int i) {
        this.itemMaxLines = i;
        OskOizosSURYtHKn(this, false);
    }

    public void SetItemTextAppearance(int i) {
        this.textAppearance = i;
        ECjJiBIXwRutSdrk(this, false);
    }

    public void SetItemTextAppearanceActiveBoldEnabled(bool z) {
        this.textAppearanceActiveBoldEnabled = z;
        HEQAgSYqUBYIlDwd(this, false);
    }

    public void SetItemTextColor(android.content.res.ColorStateList colorStateList) {
        this.textColor = colorStateList;
        bhfUeQWaJHibzuOI(this, false);
    }

    public void SetItemVerticalPadding(int i) {
        this.itemVerticalPadding = i;
        UKFRqHHWEwOPghop(this, false);
    }

    public void SetOverScrollMode(int i) {
        this.overScrollMode = i;
        com.google.android.material.internal.NavigationMenuobject navigationMenuobject = this.menuobject;
        if (navigationMenuobject is null) {
            return;
        }
        LcZrdiZlPMXSiCkf(navigationMenuobject, i);
    }

    public void SetSubheaderColor(android.content.res.ColorStateList colorStateList) {
        this.subheaderColor = colorStateList;
        lksiFXONlnBWUYqS(this, false);
    }

    public void SetSubheaderInsetEnd(int i) {
        this.subheaderInsetEnd = i;
        HvxKuppwkVLWHDRB(this, false);
    }

    public void SetSubheaderInsetStart(int i) {
        this.subheaderInsetStart = i;
        cLmncjbWzmBYAFTv(this, false);
    }

    public void SetSubheaderTextAppearance(int i) {
        this.subheaderTextAppearance = i;
        SJYWYVLiFnszbbda(this, false);
    }

    public void SetUpdateSuspended(bool z) {
        com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter = this.adapter;
        if (navigationMenuPresenter$NavigationMenuAdapter is null) {
            return;
        }
        JTqgsdbBIinTzgFG(navigationMenuPresenter$NavigationMenuAdapter, z);
    }

    public override void UpdateMenuobject(bool z) {
        com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter = this.adapter;
        if (navigationMenuPresenter$NavigationMenuAdapter is null) {
            return;
        }
        GEeKZUeFaIscHacF(navigationMenuPresenter$NavigationMenuAdapter);
    }
}

