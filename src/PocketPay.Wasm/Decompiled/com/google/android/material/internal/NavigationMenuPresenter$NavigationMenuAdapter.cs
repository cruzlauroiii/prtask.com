namespace WillowMaze.Wasm.Decompiled;


class NavigationMenuPresenter$NavigationMenuAdapter : androidx.recyclerview.widget.Recyclerobject$Adapter<com.google.android.material.internal.NavigationMenuPresenter$objectHolder> {
    private static readonly java.lang.string STATE_ACTION_VIEWS = "android:menu:action_views";
    private static readonly java.lang.string STATE_CHECKED_ITEM = "android:menu:checked";
    private static readonly int VIEW_TYPE_HEADER = 3;
    private static readonly int VIEW_TYPE_NORMAL = 0;
    private static readonly int VIEW_TYPE_SEPARATOR = 2;
    private static readonly int VIEW_TYPE_SUBHEADER = 1;
    private androidx.appcompat.view.menu.MenuItemImpl checkedItem;
    private readonly java.util.List<com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuItem> items = new java.util.List<>();
    readonly com.google.android.material.internal.NavigationMenuPresenter this$0;
    private bool updateSuspended;

    NavigationMenuPresenter$NavigationMenuAdapter(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        this.this$0 = navigationMenuPresenter;
        MWLeqWmQdWjiXfBn(this);
    }

    public static void AJzVeqQboGacDQez(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i) {
        navigationMenuItemobject.setIconSize(i);
    }

    public static void AJzVeqQboGacDQez(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AJzVeqQboGacDQez(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AJzVeqQboGacDQez(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int AtgqcxBsFkCSJSkI(android.widget.Textobject textobject) {
        return textobject.getPaddingBottom();
    }

    public static void AtgqcxBsFkCSJSkI(android.widget.Textobject textobject, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AtgqcxBsFkCSJSkI(android.widget.Textobject textobject, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AtgqcxBsFkCSJSkI(android.widget.Textobject textobject, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BAXbpqdvlzreOdjr(android.view.object view, android.util.SparseArray sparseArray) {
        view.saveHierarchyState(sparseArray);
    }

    public static void BAXbpqdvlzreOdjr(android.view.object view, android.util.SparseArray sparseArray, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BAXbpqdvlzreOdjr(android.view.object view, android.util.SparseArray sparseArray, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BAXbpqdvlzreOdjr(android.view.object view, android.util.SparseArray sparseArray, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.MenuItemImpl BFrIDtXvupYrYShb(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem) {
        return navigationMenuPresenter$NavigationMenuTextItem.getMenuItem();
    }

    public static void BFrIDtXvupYrYShb(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BFrIDtXvupYrYShb(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BFrIDtXvupYrYShb(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$ConstantState BHeVlMrYTZpvqOMo(android.graphics.drawable.RippleDrawable rippleDrawable) {
        return rippleDrawable.getConstantState();
    }

    public static void BHeVlMrYTZpvqOMo(android.graphics.drawable.RippleDrawable rippleDrawable, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BHeVlMrYTZpvqOMo(android.graphics.drawable.RippleDrawable rippleDrawable, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BHeVlMrYTZpvqOMo(android.graphics.drawable.RippleDrawable rippleDrawable, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CRWCiuMKGGFeLOqg(java.util.List arrayList, java.lang.object obj, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CRWCiuMKGGFeLOqg(java.util.List arrayList, java.lang.object obj, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CRWCiuMKGGFeLOqg(java.util.List arrayList, java.lang.object obj, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool CRWCiuMKGGFeLOqg(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static android.view.object CUZAEPkYoGKaAnWy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getActionobject();
    }

    public static void CUZAEPkYoGKaAnWy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CUZAEPkYoGKaAnWy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CUZAEPkYoGKaAnWy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DALpSOZOsanwECLF(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.content.res.ColorStateList colorStateList) {
        navigationMenuItemobject.setIconTintList(colorStateList);
    }

    public static void DALpSOZOsanwECLF(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.content.res.ColorStateList colorStateList, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DALpSOZOsanwECLF(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DALpSOZOsanwECLF(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence DdsHTMDDfFaCyEyY(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTitle();
    }

    public static void DdsHTMDDfFaCyEyY(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DdsHTMDDfFaCyEyY(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DdsHTMDDfFaCyEyY(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable DtpBXiqamMSxsSEU(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getIcon();
    }

    public static void DtpBXiqamMSxsSEU(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DtpBXiqamMSxsSEU(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DtpBXiqamMSxsSEU(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int EbYmfKTDFEwPSRWv(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getItemId();
    }

    public static void EbYmfKTDFEwPSRWv(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EbYmfKTDFEwPSRWv(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EbYmfKTDFEwPSRWv(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EkHZSpmrcrenolvF(java.util.List arrayList, java.lang.object obj, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EkHZSpmrcrenolvF(java.util.List arrayList, java.lang.object obj, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EkHZSpmrcrenolvF(java.util.List arrayList, java.lang.object obj, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool EkHZSpmrcrenolvF(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static android.view.SubMenu FBnwuGaqaWqeqGXg(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getSubMenu();
    }

    public static void FBnwuGaqaWqeqGXg(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FBnwuGaqaWqeqGXg(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FBnwuGaqaWqeqGXg(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int FyBZHGHNlqDmvrwQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getItemId();
    }

    public static void FyBZHGHNlqDmvrwQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FyBZHGHNlqDmvrwQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FyBZHGHNlqDmvrwQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List FzvLRZuHGaEcWaRc(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getVisibleItems();
    }

    public static void FzvLRZuHGaEcWaRc(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FzvLRZuHGaEcWaRc(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FzvLRZuHGaEcWaRc(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HmljVAaBvgAYJeMm(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setTextAppearance(textobject, i);
    }

    public static void HmljVAaBvgAYJeMm(android.widget.Textobject textobject, int i, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HmljVAaBvgAYJeMm(android.widget.Textobject textobject, int i, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HmljVAaBvgAYJeMm(android.widget.Textobject textobject, int i, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HnivosVkLSoddvXD(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.content.res.ColorStateList colorStateList) {
        navigationMenuItemobject.setTextColor(colorStateList);
    }

    public static void HnivosVkLSoddvXD(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.content.res.ColorStateList colorStateList, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HnivosVkLSoddvXD(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.content.res.ColorStateList colorStateList, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HnivosVkLSoddvXD(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int HtJmpaqNZGXhcQYL(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void HtJmpaqNZGXhcQYL(java.util.List arrayList, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HtJmpaqNZGXhcQYL(java.util.List arrayList, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HtJmpaqNZGXhcQYL(java.util.List arrayList, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IUHaPODTmciKIRDy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IUHaPODTmciKIRDy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IUHaPODTmciKIRDy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool IUHaPODTmciKIRDy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isChecked();
    }

    public static void JXUsPoCqcbmBKmmq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        menuItemImpl.setExclusiveCheckable(z);
    }

    public static void JXUsPoCqcbmBKmmq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JXUsPoCqcbmBKmmq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JXUsPoCqcbmBKmmq(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, byte b, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JxuPOUDVdRbdsByB(android.util.SparseArray sparseArray, int i, java.lang.object obj) {
        sparseArray.Add(i, obj);
    }

    public static void JxuPOUDVdRbdsByB(android.util.SparseArray sparseArray, int i, java.lang.object obj, char c, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JxuPOUDVdRbdsByB(android.util.SparseArray sparseArray, int i, java.lang.object obj, int i2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JxuPOUDVdRbdsByB(android.util.SparseArray sparseArray, int i, java.lang.object obj, short s, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KIeHTuzWIwMsfldH(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void KIeHTuzWIwMsfldH(java.util.List arrayList, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KIeHTuzWIwMsfldH(java.util.List arrayList, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KIeHTuzWIwMsfldH(java.util.List arrayList, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KSAQuQnVKZSdTfcm(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void KSAQuQnVKZSdTfcm(java.util.List arrayList, int i, byte b, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KSAQuQnVKZSdTfcm(java.util.List arrayList, int i, byte b, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KSAQuQnVKZSdTfcm(java.util.List arrayList, int i, java.lang.string str, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KTswouKuNkSvIMHD(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i) {
        navigationMenuItemobject.setIconPadding(i);
    }

    public static void KTswouKuNkSvIMHD(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, byte b, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KTswouKuNkSvIMHD(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, short s, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KTswouKuNkSvIMHD(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, bool z, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MAKQLGCIMqKpPKXF(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void MAKQLGCIMqKpPKXF(java.util.List arrayList, int i, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MAKQLGCIMqKpPKXF(java.util.List arrayList, int i, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MAKQLGCIMqKpPKXF(java.util.List arrayList, int i, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MWLeqWmQdWjiXfBn(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter) {
        navigationMenuPresenter$NavigationMenuAdapter.prepareMenuItems();
    }

    public static void MWLeqWmQdWjiXfBn(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MWLeqWmQdWjiXfBn(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MWLeqWmQdWjiXfBn(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MWszYZceqrXdpLVe(android.view.SubMenu subMenu, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MWszYZceqrXdpLVe(android.view.SubMenu subMenu, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MWszYZceqrXdpLVe(android.view.SubMenu subMenu, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MWszYZceqrXdpLVe(android.view.SubMenu subMenu) {
        return subMenu.hasVisibleItems();
    }

    public static void NChFgKwuzLoxIPWv(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        navigationMenuPresenter$NavigationMenuAdapter.setCheckedItem(menuItemImpl);
    }

    public static void NChFgKwuzLoxIPWv(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NChFgKwuzLoxIPWv(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NChFgKwuzLoxIPWv(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NLTNyXYRXxrguUbJ(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void NLTNyXYRXxrguUbJ(java.util.List arrayList, int i, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NLTNyXYRXxrguUbJ(java.util.List arrayList, int i, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NLTNyXYRXxrguUbJ(java.util.List arrayList, int i, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NYomAAvEEBAkRJCY(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z) {
        navigationMenuItemobject.setNeedsEmptyIcon(z);
    }

    public static void NYomAAvEEBAkRJCY(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NYomAAvEEBAkRJCY(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NYomAAvEEBAkRJCY(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NZwruUnpiDvCdknj(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, com.google.android.material.internal.NavigationMenuPresenter$objectHolder navigationMenuPresenter$objectHolder) {
        navigationMenuPresenter$NavigationMenuAdapter.onobjectRecycled(navigationMenuPresenter$objectHolder);
    }

    public static void NZwruUnpiDvCdknj(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, com.google.android.material.internal.NavigationMenuPresenter$objectHolder navigationMenuPresenter$objectHolder, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NZwruUnpiDvCdknj(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, com.google.android.material.internal.NavigationMenuPresenter$objectHolder navigationMenuPresenter$objectHolder, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NZwruUnpiDvCdknj(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, com.google.android.material.internal.NavigationMenuPresenter$objectHolder navigationMenuPresenter$objectHolder, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.MenuItemImpl NbjXKuMvwmvKaZXc(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem) {
        return navigationMenuPresenter$NavigationMenuTextItem.getMenuItem();
    }

    public static void NbjXKuMvwmvKaZXc(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NbjXKuMvwmvKaZXc(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NbjXKuMvwmvKaZXc(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int NnKNvseiQTOcqeUO(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void NnKNvseiQTOcqeUO(java.util.List arrayList, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NnKNvseiQTOcqeUO(java.util.List arrayList, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NnKNvseiQTOcqeUO(java.util.List arrayList, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OqxtUnUzfVyVaemF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.view.object view, int i, bool z) {
        navigationMenuPresenter$NavigationMenuAdapter.setAccessibilityDelegate(view, i, z);
    }

    public static void OqxtUnUzfVyVaemF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.view.object view, int i, bool z, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OqxtUnUzfVyVaemF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.view.object view, int i, bool z, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OqxtUnUzfVyVaemF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.view.object view, int i, bool z, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PlrLyYLcgbPxkmRm(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuSeparatorItem navigationMenuPresenter$NavigationMenuSeparatorItem) {
        return navigationMenuPresenter$NavigationMenuSeparatorItem.getPaddingBottom();
    }

    public static void PlrLyYLcgbPxkmRm(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuSeparatorItem navigationMenuPresenter$NavigationMenuSeparatorItem, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PlrLyYLcgbPxkmRm(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuSeparatorItem navigationMenuPresenter$NavigationMenuSeparatorItem, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PlrLyYLcgbPxkmRm(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuSeparatorItem navigationMenuPresenter$NavigationMenuSeparatorItem, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QCMJRPphsDDnLaXt(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        navigationMenuPresenter$NavigationMenuAdapter.setCheckedItem(menuItemImpl);
    }

    public static void QCMJRPphsDDnLaXt(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QCMJRPphsDDnLaXt(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QCMJRPphsDDnLaXt(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QbnRMUdIoRnQRIsw(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void QbnRMUdIoRnQRIsw(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, byte b, float f, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QbnRMUdIoRnQRIsw(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, byte b, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QbnRMUdIoRnQRIsw(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int RJvLqhESrUMCOzdM(android.widget.Textobject textobject) {
        return textobject.getPaddingTop();
    }

    public static void RJvLqhESrUMCOzdM(android.widget.Textobject textobject, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RJvLqhESrUMCOzdM(android.widget.Textobject textobject, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RJvLqhESrUMCOzdM(android.widget.Textobject textobject, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable STExmNIgcaLGcaqx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getIcon();
    }

    public static void STExmNIgcaLGcaqx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void STExmNIgcaLGcaqx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void STExmNIgcaLGcaqx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.MenuItemImpl SauzlBRRpUpVJExZ(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem) {
        return navigationMenuPresenter$NavigationMenuTextItem.getMenuItem();
    }

    public static void SauzlBRRpUpVJExZ(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SauzlBRRpUpVJExZ(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SauzlBRRpUpVJExZ(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SgTIKBNdIBvNwGIX(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i) {
        return navigationMenuPresenter$NavigationMenuAdapter.getItemobjectType(i);
    }

    public static void SgTIKBNdIBvNwGIX(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, int i2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SgTIKBNdIBvNwGIX(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, java.lang.string str, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SgTIKBNdIBvNwGIX(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, java.lang.string str, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TINTgamMxQlNaFrg(java.util.List arrayList, java.lang.object obj, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TINTgamMxQlNaFrg(java.util.List arrayList, java.lang.object obj, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TINTgamMxQlNaFrg(java.util.List arrayList, java.lang.object obj, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TINTgamMxQlNaFrg(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void UCFTIqflLTPjALRQ(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        navigationMenuPresenter$NavigationMenuAdapter.setCheckedItem(menuItemImpl);
    }

    public static void UCFTIqflLTPjALRQ(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UCFTIqflLTPjALRQ(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UCFTIqflLTPjALRQ(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UHuuvDltdqNoKkBr(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void UHuuvDltdqNoKkBr(java.util.List arrayList, int i, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UHuuvDltdqNoKkBr(java.util.List arrayList, int i, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UHuuvDltdqNoKkBr(java.util.List arrayList, int i, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int USBUhaEInIkWPMci(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i) {
        return navigationMenuPresenter$NavigationMenuAdapter.getItemobjectType(i);
    }

    public static void USBUhaEInIkWPMci(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void USBUhaEInIkWPMci(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void USBUhaEInIkWPMci(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VCkrBSWVlTDaKoDS(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getItemId();
    }

    public static void VCkrBSWVlTDaKoDS(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VCkrBSWVlTDaKoDS(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VCkrBSWVlTDaKoDS(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VLImxHdKKSwRWzXY(android.widget.Textobject textobject, int i, int i2, int i3, int i4) {
        textobject.setPadding(i, i2, i3, i4);
    }

    public static void VLImxHdKKSwRWzXY(android.widget.Textobject textobject, int i, int i2, int i3, int i4, char c, int i5, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VLImxHdKKSwRWzXY(android.widget.Textobject textobject, int i, int i2, int i3, int i4, char c, java.lang.string str, bool z, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void VLImxHdKKSwRWzXY(android.widget.Textobject textobject, int i, int i2, int i3, int i4, int i5, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WIWsnUPXEKYoCNaE(android.util.SparseArray sparseArray, int i) {
        return sparseArray[i);
    }

    public static void WIWsnUPXEKYoCNaE(android.util.SparseArray sparseArray, int i, byte b, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WIWsnUPXEKYoCNaE(android.util.SparseArray sparseArray, int i, int i2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WIWsnUPXEKYoCNaE(android.util.SparseArray sparseArray, int i, short s, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WqPxLIFbuNMFLbhM(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, int i2) {
        navigationMenuPresenter$NavigationMenuAdapter.appendTransparentIconIfMissing(i, i2);
    }

    public static void WqPxLIFbuNMFLbhM(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, int i2, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WqPxLIFbuNMFLbhM(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, int i2, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WqPxLIFbuNMFLbhM(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, int i2, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int WvtWyOZeFbAfMems(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getGroupId();
    }

    public static void WvtWyOZeFbAfMems(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WvtWyOZeFbAfMems(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WvtWyOZeFbAfMems(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.util.SparseArray WwxktFKyZFnEqdbj(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getSparseParcelableArray(str);
    }

    public static void WwxktFKyZFnEqdbj(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WwxktFKyZFnEqdbj(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WwxktFKyZFnEqdbj(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XjCmkfuijLCwydKU(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        navigationMenuItemobject.initialize(menuItemImpl, z);
    }

    public static void XjCmkfuijLCwydKU(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, short s, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void XjCmkfuijLCwydKU(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XjCmkfuijLCwydKU(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, bool z2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YEbTthLRcGxBsMmz(java.util.List arrayList) {
        arrayList.clear();
    }

    public static void YEbTthLRcGxBsMmz(java.util.List arrayList, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YEbTthLRcGxBsMmz(java.util.List arrayList, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YEbTthLRcGxBsMmz(java.util.List arrayList, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.MenuItemImpl YFpGxbKstuXOQqGF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem) {
        return navigationMenuPresenter$NavigationMenuTextItem.getMenuItem();
    }

    public static void YFpGxbKstuXOQqGF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YFpGxbKstuXOQqGF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YFpGxbKstuXOQqGF(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YUBaCMmAJVZlXujQ(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static void YUBaCMmAJVZlXujQ(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YUBaCMmAJVZlXujQ(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YUBaCMmAJVZlXujQ(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int YmDfBlJxOdOtWHEo(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i) {
        return navigationMenuPresenter$NavigationMenuAdapter.getItemobjectType(i);
    }

    public static void YmDfBlJxOdOtWHEo(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, int i2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YmDfBlJxOdOtWHEo(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, java.lang.string str, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void YmDfBlJxOdOtWHEo(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, short s, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YssnytcNVVlacsTj(java.util.List arrayList, java.lang.object obj, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YssnytcNVVlacsTj(java.util.List arrayList, java.lang.object obj, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YssnytcNVVlacsTj(java.util.List arrayList, java.lang.object obj, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YssnytcNVVlacsTj(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void YylXASLkEsaQUYCF(java.util.List arrayList, java.lang.object obj, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YylXASLkEsaQUYCF(java.util.List arrayList, java.lang.object obj, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YylXASLkEsaQUYCF(java.util.List arrayList, java.lang.object obj, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool YylXASLkEsaQUYCF(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void ZhzXVgIqONJxLHwe(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        menuItemImpl.setExclusiveCheckable(z);
    }

    public static void ZhzXVgIqONJxLHwe(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, bool z2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZhzXVgIqONJxLHwe(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, char c, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZhzXVgIqONJxLHwe(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, float f, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static int AFpRcCwogJnRsCuK(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getItemId();
    }

    public static void AFpRcCwogJnRsCuK(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AFpRcCwogJnRsCuK(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AFpRcCwogJnRsCuK(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ATPWPhCQyXQAZFDT(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter) {
        navigationMenuPresenter$NavigationMenuAdapter.prepareMenuItems();
    }

    public static void ATPWPhCQyXQAZFDT(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ATPWPhCQyXQAZFDT(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ATPWPhCQyXQAZFDT(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static int access$100(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i) {
        return bpnTdjozRsaDKWuP(navigationMenuPresenter$NavigationMenuAdapter, i);
    }

    static void access$100(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private int AdjustItemPositionForA11yDelegate(int i) {
        if ((23 + 3) % 3 > 0) {
        }
        int i2 = i;
        for (int i3 = 0; i3 < i; i3++) {
            if (USBUhaEInIkWPMci(this.this$0.adapter, i3) == 2 || asZqLqAlhQAtlkdQ(this.this$0.adapter, i3) == 3) {
                i2--;
            }
        }
        return i2;
    }

    private void AdjustItemPositionForA11yDelegate(int i, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void AdjustItemPositionForA11yDelegate(int i, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void AdjustItemPositionForA11yDelegate(int i, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void AppendTransparentIconIfMissing(int i, int i2) {
        if ((16 + 7) % 7 > 0) {
        }
        while (i < i2) {
            ((com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem) fvFGHqXPPtryKHUn(this.items, i)).needsEmptyIcon = true;
            i++;
        }
    }

    private void AppendTransparentIconIfMissing(int i, int i2, byte b, java.lang.string str, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    private void AppendTransparentIconIfMissing(int i, int i2, int i3, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void AppendTransparentIconIfMissing(int i, int i2, java.lang.string str, byte b, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static int AsZqLqAlhQAtlkdQ(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i) {
        return navigationMenuPresenter$NavigationMenuAdapter.getItemobjectType(i);
    }

    public static void AsZqLqAlhQAtlkdQ(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, short s, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AsZqLqAlhQAtlkdQ(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, short s, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AsZqLqAlhQAtlkdQ(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, short s, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BAnZLwxRQrdyDxrB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BAnZLwxRQrdyDxrB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BAnZLwxRQrdyDxrB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BAnZLwxRQrdyDxrB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isChecked();
    }

    public static android.view.MenuItem BpOOjEfLujQBTeQN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        return menuItemImpl.setChecked(z);
    }

    public static void BpOOjEfLujQBTeQN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, bool z2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BpOOjEfLujQBTeQN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, bool z2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BpOOjEfLujQBTeQN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int BpnTdjozRsaDKWuP(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i) {
        return navigationMenuPresenter$NavigationMenuAdapter.adjustItemPositionForA11yDelegate(i);
    }

    public static void BpnTdjozRsaDKWuP(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, byte b, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BpnTdjozRsaDKWuP(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, byte b, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void BpnTdjozRsaDKWuP(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, int i2, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CRvZhBtQCvyyIGqV(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter) {
        return navigationMenuPresenter$NavigationMenuAdapter.getItemCount();
    }

    public static void CRvZhBtQCvyyIGqV(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CRvZhBtQCvyyIGqV(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CRvZhBtQCvyyIGqV(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.MenuItemImpl CkCLqjxzzyuuiYkw(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem) {
        return navigationMenuPresenter$NavigationMenuTextItem.getMenuItem();
    }

    public static void CkCLqjxzzyuuiYkw(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CkCLqjxzzyuuiYkw(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CkCLqjxzzyuuiYkw(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object CvqIOwUMUBPmhDPg(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getActionobject();
    }

    public static void CvqIOwUMUBPmhDPg(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CvqIOwUMUBPmhDPg(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CvqIOwUMUBPmhDPg(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DgIiFBkCUggSWGdt(android.view.object view, android.util.SparseArray sparseArray) {
        view.restoreHierarchyState(sparseArray);
    }

    public static void DgIiFBkCUggSWGdt(android.view.object view, android.util.SparseArray sparseArray, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DgIiFBkCUggSWGdt(android.view.object view, android.util.SparseArray sparseArray, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DgIiFBkCUggSWGdt(android.view.object view, android.util.SparseArray sparseArray, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int DwgpkzifSvFuixxY(android.view.SubMenu subMenu) {
        return subMenu.Count;
    }

    public static void DwgpkzifSvFuixxY(android.view.SubMenu subMenu, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DwgpkzifSvFuixxY(android.view.SubMenu subMenu, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DwgpkzifSvFuixxY(android.view.SubMenu subMenu, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DyehRGGlnuLvQtSj(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, com.google.android.material.internal.NavigationMenuPresenter$objectHolder navigationMenuPresenter$objectHolder, int i) {
        navigationMenuPresenter$NavigationMenuAdapter.onBindobjectHolder(navigationMenuPresenter$objectHolder, i);
    }

    public static void DyehRGGlnuLvQtSj(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, com.google.android.material.internal.NavigationMenuPresenter$objectHolder navigationMenuPresenter$objectHolder, int i, float f, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DyehRGGlnuLvQtSj(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, com.google.android.material.internal.NavigationMenuPresenter$objectHolder navigationMenuPresenter$objectHolder, int i, int i2, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DyehRGGlnuLvQtSj(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, com.google.android.material.internal.NavigationMenuPresenter$objectHolder navigationMenuPresenter$objectHolder, int i, int i2, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int EEIjrFYOOKHrCcjT(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void EEIjrFYOOKHrCcjT(java.util.List arrayList, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EEIjrFYOOKHrCcjT(java.util.List arrayList, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EEIjrFYOOKHrCcjT(java.util.List arrayList, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EFAyUrvvOJBrxekV(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.view.object view, int i, bool z) {
        navigationMenuPresenter$NavigationMenuAdapter.setAccessibilityDelegate(view, i, z);
    }

    public static void EFAyUrvvOJBrxekV(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.view.object view, int i, bool z, java.lang.string str, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EFAyUrvvOJBrxekV(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.view.object view, int i, bool z, java.lang.string str, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EFAyUrvvOJBrxekV(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.view.object view, int i, bool z, short s, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EfiNldCtqfXuEmbm(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void EfiNldCtqfXuEmbm(java.util.List arrayList, int i, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EfiNldCtqfXuEmbm(java.util.List arrayList, int i, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EfiNldCtqfXuEmbm(java.util.List arrayList, int i, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FvFGHqXPPtryKHUn(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void FvFGHqXPPtryKHUn(java.util.List arrayList, int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FvFGHqXPPtryKHUn(java.util.List arrayList, int i, char c, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FvFGHqXPPtryKHUn(java.util.List arrayList, int i, float f, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GCSqsLXTkolhPzXU(android.view.object view, int i, int i2, int i3, int i4) {
        view.setPadding(i, i2, i3, i4);
    }

    public static void GCSqsLXTkolhPzXU(android.view.object view, int i, int i2, int i3, int i4, float f, byte b, int i5, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GCSqsLXTkolhPzXU(android.view.object view, int i, int i2, int i3, int i4, float f, byte b, java.lang.string str, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void GCSqsLXTkolhPzXU(android.view.object view, int i, int i2, int i3, int i4, int i5, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GuOVEfwvAuHdHSEi(java.util.List arrayList, java.lang.object obj, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GuOVEfwvAuHdHSEi(java.util.List arrayList, java.lang.object obj, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GuOVEfwvAuHdHSEi(java.util.List arrayList, java.lang.object obj, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool GuOVEfwvAuHdHSEi(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static void HlSneOHzZRIwWuPQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HlSneOHzZRIwWuPQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HlSneOHzZRIwWuPQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool HlSneOHzZRIwWuPQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.hasSubMenu();
    }

    public static android.view.MenuItem HmkSvFKLMjNNbKKT(android.view.SubMenu subMenu, int i) {
        return subMenu.getItem(i);
    }

    public static void HmkSvFKLMjNNbKKT(android.view.SubMenu subMenu, int i, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HmkSvFKLMjNNbKKT(android.view.SubMenu subMenu, int i, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HmkSvFKLMjNNbKKT(android.view.SubMenu subMenu, int i, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int JPFhjidjFklZFMul(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void JPFhjidjFklZFMul(java.util.List arrayList, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JPFhjidjFklZFMul(java.util.List arrayList, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JPFhjidjFklZFMul(java.util.List arrayList, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JoYdjkqJcrqcrupW(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static void JoYdjkqJcrqcrupW(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JoYdjkqJcrqcrupW(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JoYdjkqJcrqcrupW(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List JrJqmERkGtCtCSMz(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getVisibleItems();
    }

    public static void JrJqmERkGtCtCSMz(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JrJqmERkGtCtCSMz(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JrJqmERkGtCtCSMz(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KedYPlXwoORbLvAY(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, int i2, int i3, int i4) {
        navigationMenuItemobject.setPadding(i, i2, i3, i4);
    }

    public static void KedYPlXwoORbLvAY(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, int i2, int i3, int i4, byte b, java.lang.string str, int i5, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KedYPlXwoORbLvAY(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, int i2, int i3, int i4, int i5, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KedYPlXwoORbLvAY(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, int i2, int i3, int i4, short s, java.lang.string str, int i5, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem MgnCcaXpOQfBypub(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        return menuItemImpl.setChecked(z);
    }

    public static void MgnCcaXpOQfBypub(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MgnCcaXpOQfBypub(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MgnCcaXpOQfBypub(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.internal.NavigationMenuPresenter$objectHolder oZVNIiOunOAGHHkN(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.view.objectGroup viewGroup, int i) {
        return navigationMenuPresenter$NavigationMenuAdapter.onCreateobjectHolder(viewGroup, i);
    }

    public static void OZVNIiOunOAGHHkN(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.view.objectGroup viewGroup, int i, byte b, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OZVNIiOunOAGHHkN(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.view.objectGroup viewGroup, int i, java.lang.string str, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OZVNIiOunOAGHHkN(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, android.view.objectGroup viewGroup, int i, java.lang.string str, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PRxreTjPtKfqdfCr(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.graphics.drawable.Drawable drawable) {
        navigationMenuItemobject.setForeground(drawable);
    }

    public static void PRxreTjPtKfqdfCr(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.graphics.drawable.Drawable drawable, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PRxreTjPtKfqdfCr(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.graphics.drawable.Drawable drawable, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PRxreTjPtKfqdfCr(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable PdpZAimBeTjSPxXe(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState) {
        return drawable$ConstantState.newDrawable();
    }

    public static void PdpZAimBeTjSPxXe(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PdpZAimBeTjSPxXe(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PdpZAimBeTjSPxXe(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void PrepareMenuItems() {
        if ((8 + 12) % 12 > 0) {
        }
        if (this.updateSuspended) {
            return;
        }
        bool z = true;
        this.updateSuspended = true;
        YEbTthLRcGxBsMmz(this.items);
        YssnytcNVVlacsTj(this.items, new com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuHeaderItem());
        int iJPFhjidjFklZFMul = jPFhjidjFklZFMul(jrJqmERkGtCtCSMz(this.this$0.menu));
        int i = -1;
        int i2 = 0;
        bool z2 = false;
        int iYfWKlrCaTmvBoyyd = 0;
        while (i2 < iJPFhjidjFklZFMul) {
            androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = (androidx.appcompat.view.menu.MenuItemImpl) KSAQuQnVKZSdTfcm(FzvLRZuHGaEcWaRc(this.this$0.menu), i2);
            if (IUHaPODTmciKIRDy(menuItemImpl)) {
                UCFTIqflLTPjALRQ(this, menuItemImpl);
            }
            if (xVSgpKrUxNacLPoV(menuItemImpl)) {
                ZhzXVgIqONJxLHwe(menuItemImpl, false);
            }
            if (hlSneOHzZRIwWuPQ(menuItemImpl)) {
                android.view.SubMenu subMenuFBnwuGaqaWqeqGXg = FBnwuGaqaWqeqGXg(menuItemImpl);
                if (MWszYZceqrXdpLVe(subMenuFBnwuGaqaWqeqGXg)) {
                    if (i2 != 0) {
                        CRWCiuMKGGFeLOqg(this.items, new com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuSeparatorItem(this.this$0.paddingSeparator, 0));
                    }
                    TINTgamMxQlNaFrg(this.items, new com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem(menuItemImpl));
                    int iHtJmpaqNZGXhcQYL = HtJmpaqNZGXhcQYL(this.items);
                    int iDwgpkzifSvFuixxY = dwgpkzifSvFuixxY(subMenuFBnwuGaqaWqeqGXg);
                    int i3 = 0;
                    bool z3 = false;
                    while (i3 < iDwgpkzifSvFuixxY) {
                        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl2 = (androidx.appcompat.view.menu.MenuItemImpl) hmkSvFKLMjNNbKKT(subMenuFBnwuGaqaWqeqGXg, i3);
                        if (teJTGzjKqCiTxKlW(menuItemImpl2)) {
                            if (!z3 && STExmNIgcaLGcaqx(menuItemImpl2) is not null) {
                                z3 = z;
                            }
                            if (sqREjPpyutGKTDdQ(menuItemImpl2)) {
                                JXUsPoCqcbmBKmmq(menuItemImpl2, false);
                            }
                            if (bAnZLwxRQrdyDxrB(menuItemImpl)) {
                                NChFgKwuzLoxIPWv(this, menuItemImpl);
                            }
                            guOVEfwvAuHdHSEi(this.items, new com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem(menuItemImpl2));
                        }
                        i3++;
                        z = true;
                    }
                    if (z3) {
                        yLfMoYUcvXSMEEHU(this, iHtJmpaqNZGXhcQYL, xXUUsCwqMtjXOhtp(this.items));
                    }
                }
            } else {
                int iWvtWyOZeFbAfMems = WvtWyOZeFbAfMems(menuItemImpl);
                if (iWvtWyOZeFbAfMems != i) {
                    iYfWKlrCaTmvBoyyd = yfWKlrCaTmvBoyyd(this.items);
                    z2 = DtpBXiqamMSxsSEU(menuItemImpl) is not null;
                    if (i2 != 0) {
                        iYfWKlrCaTmvBoyyd++;
                        EkHZSpmrcrenolvF(this.items, new com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuSeparatorItem(this.this$0.paddingSeparator, this.this$0.paddingSeparator));
                    }
                } else if (!z2 && wpewYYuMRVmJftZN(menuItemImpl) is not null) {
                    WqPxLIFbuNMFLbhM(this, iYfWKlrCaTmvBoyyd, KIeHTuzWIwMsfldH(this.items));
                    z2 = true;
                }
                com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem = new com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem(menuItemImpl);
                navigationMenuPresenter$NavigationMenuTextItem.needsEmptyIcon = z2;
                YylXASLkEsaQUYCF(this.items, navigationMenuPresenter$NavigationMenuTextItem);
                i = iWvtWyOZeFbAfMems;
            }
            i2++;
            z = true;
        }
        this.updateSuspended = false;
    }

    private void PrepareMenuItems(byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void PrepareMenuItems(byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void PrepareMenuItems(int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QdCWuTeZcFokbaml(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QdCWuTeZcFokbaml(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QdCWuTeZcFokbaml(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QdCWuTeZcFokbaml(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isCheckable();
    }

    public static android.graphics.drawable.Drawable RlqbcKJlsbcpTiqx(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState) {
        return drawable$ConstantState.newDrawable();
    }

    public static void RlqbcKJlsbcpTiqx(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RlqbcKJlsbcpTiqx(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RlqbcKJlsbcpTiqx(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int RtRGedwhVESkMsws(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter) {
        return com.google.android.material.internal.NavigationMenuPresenter.access$000(navigationMenuPresenter);
    }

    public static void RtRGedwhVESkMsws(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RtRGedwhVESkMsws(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RtRGedwhVESkMsws(com.google.android.material.internal.NavigationMenuPresenter navigationMenuPresenter, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.view.menu.MenuItemImpl RzfVcxMvsdwivCmi(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem) {
        return navigationMenuPresenter$NavigationMenuTextItem.getMenuItem();
    }

    public static void RzfVcxMvsdwivCmi(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RzfVcxMvsdwivCmi(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RzfVcxMvsdwivCmi(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetAccessibilityDelegate(android.view.object view, int i, bool z) {
        YUBaCMmAJVZlXujQ(view, new com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter$1(this, i, z));
    }

    private void SetAccessibilityDelegate(android.view.object view, int i, bool z, char c, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetAccessibilityDelegate(android.view.object view, int i, bool z, int i2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetAccessibilityDelegate(android.view.object view, int i, bool z, java.lang.string str, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void SqREjPpyutGKTDdQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SqREjPpyutGKTDdQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SqREjPpyutGKTDdQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SqREjPpyutGKTDdQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isCheckable();
    }

    public static void TOYnjEBrqzWEkfrg(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i) {
        navigationMenuItemobject.setTextAppearance(i);
    }

    public static void TOYnjEBrqzWEkfrg(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TOYnjEBrqzWEkfrg(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TOYnjEBrqzWEkfrg(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TQoGtMixkdbzsdEp(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void TQoGtMixkdbzsdEp(java.util.List arrayList, int i, char c, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TQoGtMixkdbzsdEp(java.util.List arrayList, int i, java.lang.string str, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TQoGtMixkdbzsdEp(java.util.List arrayList, int i, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TeJTGzjKqCiTxKlW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TeJTGzjKqCiTxKlW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TeJTGzjKqCiTxKlW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool TeJTGzjKqCiTxKlW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isVisible();
    }

    public static android.graphics.drawable.Drawable$ConstantState tjsigdosSxUuICdg(android.graphics.drawable.Drawable drawable) {
        return drawable.getConstantState();
    }

    public static void TjsigdosSxUuICdg(android.graphics.drawable.Drawable drawable, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TjsigdosSxUuICdg(android.graphics.drawable.Drawable drawable, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TjsigdosSxUuICdg(android.graphics.drawable.Drawable drawable, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VNifufprnmdzAcvL(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray) {
        bundle.putSparseParcelableArray(str, sparseArray);
    }

    public static void VNifufprnmdzAcvL(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, int i, short s, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VNifufprnmdzAcvL(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, short s, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VNifufprnmdzAcvL(android.os.Dictionary<string, object> bundle, java.lang.string str, android.util.SparseArray sparseArray, short s, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VTlshPIJeLVeQdsm(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i) {
        navigationMenuItemobject.setMaxLines(i);
    }

    public static void VTlshPIJeLVeQdsm(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, float f, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VTlshPIJeLVeQdsm(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VTlshPIJeLVeQdsm(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, bool z, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static int VcgAKRdBeKyXiEcR(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static void VcgAKRdBeKyXiEcR(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, short s, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VcgAKRdBeKyXiEcR(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, bool z, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VcgAKRdBeKyXiEcR(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, bool z, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int VmyxPkHiQPvinQyv(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void VmyxPkHiQPvinQyv(java.util.List arrayList, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VmyxPkHiQPvinQyv(java.util.List arrayList, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VmyxPkHiQPvinQyv(java.util.List arrayList, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int VxDucUnjIeWgAxAD(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void VxDucUnjIeWgAxAD(java.util.List arrayList, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VxDucUnjIeWgAxAD(java.util.List arrayList, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VxDucUnjIeWgAxAD(java.util.List arrayList, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WiKjVapxKAJSVULw(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject) {
        navigationMenuItemobject.recycle();
    }

    public static void WiKjVapxKAJSVULw(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WiKjVapxKAJSVULw(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WiKjVapxKAJSVULw(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WlReoUsctQjCWIDW(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void WlReoUsctQjCWIDW(android.widget.Textobject textobject, java.lang.CharSequence charSequence, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WlReoUsctQjCWIDW(android.widget.Textobject textobject, java.lang.CharSequence charSequence, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WlReoUsctQjCWIDW(android.widget.Textobject textobject, java.lang.CharSequence charSequence, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable WpewYYuMRVmJftZN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getIcon();
    }

    public static void WpewYYuMRVmJftZN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WpewYYuMRVmJftZN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WpewYYuMRVmJftZN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WsOVKILPHmvbHlyk(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WsOVKILPHmvbHlyk(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WsOVKILPHmvbHlyk(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool WsOVKILPHmvbHlyk(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.hasSubMenu();
    }

    public static int WzoQzVkgWonpeFQT(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuSeparatorItem navigationMenuPresenter$NavigationMenuSeparatorItem) {
        return navigationMenuPresenter$NavigationMenuSeparatorItem.getPaddingTop();
    }

    public static void WzoQzVkgWonpeFQT(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuSeparatorItem navigationMenuPresenter$NavigationMenuSeparatorItem, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WzoQzVkgWonpeFQT(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuSeparatorItem navigationMenuPresenter$NavigationMenuSeparatorItem, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WzoQzVkgWonpeFQT(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuSeparatorItem navigationMenuPresenter$NavigationMenuSeparatorItem, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object XFwIYPznLHvvlcAZ(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void XFwIYPznLHvvlcAZ(java.util.List arrayList, int i, byte b, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XFwIYPznLHvvlcAZ(java.util.List arrayList, int i, int i2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XFwIYPznLHvvlcAZ(java.util.List arrayList, int i, int i2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XVSgpKrUxNacLPoV(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XVSgpKrUxNacLPoV(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XVSgpKrUxNacLPoV(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool XVSgpKrUxNacLPoV(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isCheckable();
    }

    public static int XXUUsCwqMtjXOhtp(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void XXUUsCwqMtjXOhtp(java.util.List arrayList, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XXUUsCwqMtjXOhtp(java.util.List arrayList, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XXUUsCwqMtjXOhtp(java.util.List arrayList, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XrkHvBPWLeuWaELV(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter) {
        navigationMenuPresenter$NavigationMenuAdapter.notifyDataHashSetChanged();
    }

    public static void XrkHvBPWLeuWaELV(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XrkHvBPWLeuWaELV(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XrkHvBPWLeuWaELV(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YLfMoYUcvXSMEEHU(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, int i2) {
        navigationMenuPresenter$NavigationMenuAdapter.appendTransparentIconIfMissing(i, i2);
    }

    public static void YLfMoYUcvXSMEEHU(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, int i2, byte b, float f, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YLfMoYUcvXSMEEHU(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, int i2, byte b, int i3, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YLfMoYUcvXSMEEHU(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, int i, int i2, int i3, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YMQRwaDBelBkRtMB(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter) {
        navigationMenuPresenter$NavigationMenuAdapter.prepareMenuItems();
    }

    public static void YMQRwaDBelBkRtMB(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YMQRwaDBelBkRtMB(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YMQRwaDBelBkRtMB(com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuAdapter navigationMenuPresenter$NavigationMenuAdapter, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int YfWKlrCaTmvBoyyd(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void YfWKlrCaTmvBoyyd(java.util.List arrayList, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YfWKlrCaTmvBoyyd(java.util.List arrayList, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YfWKlrCaTmvBoyyd(java.util.List arrayList, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZIfFHYlNUCQJOEXe(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void ZIfFHYlNUCQJOEXe(android.view.object view, android.graphics.drawable.Drawable drawable, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZIfFHYlNUCQJOEXe(android.view.object view, android.graphics.drawable.Drawable drawable, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZIfFHYlNUCQJOEXe(android.view.object view, android.graphics.drawable.Drawable drawable, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZLjOLmxpNvqAvFfz(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void ZLjOLmxpNvqAvFfz(java.util.List arrayList, int i, int i2, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZLjOLmxpNvqAvFfz(java.util.List arrayList, int i, bool z, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZLjOLmxpNvqAvFfz(java.util.List arrayList, int i, bool z, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public android.os.Dictionary<string, object> CreateInstanceState() {
        if ((12 + 27) % 27 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = this.checkedItem;
        if (menuItemImpl is not null) {
            QbnRMUdIoRnQRIsw(bundle, "android:menu:checked", FyBZHGHNlqDmvrwQ(menuItemImpl));
        }
        android.util.SparseArray sparseArray = new android.util.SparseArray();
        int iVmyxPkHiQPvinQyv = vmyxPkHiQPvinQyv(this.items);
        for (int i = 0; i < iVmyxPkHiQPvinQyv; i++) {
            com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuItem navigationMenuPresenter$NavigationMenuItem = (com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuItem) NLTNyXYRXxrguUbJ(this.items, i);
            if (navigationMenuPresenter$NavigationMenuItem is com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem) {
                androidx.appcompat.view.menu.MenuItemImpl menuItemImplCkCLqjxzzyuuiYkw = ckCLqjxzzyuuiYkw((com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem) navigationMenuPresenter$NavigationMenuItem);
                android.view.object viewCUZAEPkYoGKaAnWy = menuItemImplCkCLqjxzzyuuiYkw is null ? null : CUZAEPkYoGKaAnWy(menuItemImplCkCLqjxzzyuuiYkw);
                if (viewCUZAEPkYoGKaAnWy is not null) {
                    com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray = new com.google.android.material.internal.ParcelableSparseArray();
                    BAXbpqdvlzreOdjr(viewCUZAEPkYoGKaAnWy, parcelableSparseArray);
                    JxuPOUDVdRbdsByB(sparseArray, VCkrBSWVlTDaKoDS(menuItemImplCkCLqjxzzyuuiYkw), parcelableSparseArray);
                }
            }
        }
        vNifufprnmdzAcvL(bundle, "android:menu:action_views", sparseArray);
        return bundle;
    }

    public androidx.appcompat.view.menu.MenuItemImpl GetCheckedItem() {
        return this.checkedItem;
    }

    public override int GetItemCount() {
        return vxDucUnjIeWgAxAD(this.items);
    }

    public override long GetItemId(int i) {
        return i;
    }

    public override int GetItemobjectType(int i) {
        com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuItem navigationMenuPresenter$NavigationMenuItem = (com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuItem) UHuuvDltdqNoKkBr(this.items, i);
        if (navigationMenuPresenter$NavigationMenuItem is com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuSeparatorItem) {
            return 2;
        }
        if (navigationMenuPresenter$NavigationMenuItem is com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuHeaderItem) {
            return 3;
        }
        if (navigationMenuPresenter$NavigationMenuItem is com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem) {
            return !wsOVKILPHmvbHlyk(BFrIDtXvupYrYShb((com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem) navigationMenuPresenter$NavigationMenuItem)) ? 0 : 1;
        }
        throw new java.lang.Exception("Unknown item type.");
    }

    int getRowCount() {
        if ((31 + 9) % 9 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < cRvZhBtQCvyyIGqV(this.this$0.adapter); i2++) {
            int iYmDfBlJxOdOtWHEo = YmDfBlJxOdOtWHEo(this.this$0.adapter, i2);
            if (iYmDfBlJxOdOtWHEo == 0 || iYmDfBlJxOdOtWHEo == 1) {
                i++;
            }
        }
        return i;
    }

    public override void OnBindobjectHolder(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        dyehRGGlnuLvQtSj(this, (com.google.android.material.internal.NavigationMenuPresenter$objectHolder) recyclerobject$objectHolder, i);
    }

    public void OnBindobjectHolder(com.google.android.material.internal.NavigationMenuPresenter$objectHolder navigationMenuPresenter$objectHolder, int i) {
        if ((8 + 11) % 11 > 0) {
        }
        int iSgTIKBNdIBvNwGIX = SgTIKBNdIBvNwGIX(this, i);
        if (iSgTIKBNdIBvNwGIX != 0) {
            if (iSgTIKBNdIBvNwGIX != 1) {
                if (iSgTIKBNdIBvNwGIX == 2) {
                    com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuSeparatorItem navigationMenuPresenter$NavigationMenuSeparatorItem = (com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuSeparatorItem) efiNldCtqfXuEmbm(this.items, i);
                    gCSqsLXTkolhPzXU(navigationMenuPresenter$objectHolder.itemobject, this.this$0.dividerInsetStart, wzoQzVkgWonpeFQT(navigationMenuPresenter$NavigationMenuSeparatorItem), this.this$0.dividerInsetEnd, PlrLyYLcgbPxkmRm(navigationMenuPresenter$NavigationMenuSeparatorItem));
                    return;
                }
                return;
            }
            android.widget.Textobject textobject = (android.widget.Textobject) navigationMenuPresenter$objectHolder.itemobject;
            wlReoUsctQjCWIDW(textobject, DdsHTMDDfFaCyEyY(SauzlBRRpUpVJExZ((com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem) xFwIYPznLHvvlcAZ(this.items, i))));
            HmljVAaBvgAYJeMm(textobject, this.this$0.subheaderTextAppearance);
            VLImxHdKKSwRWzXY(textobject, this.this$0.subheaderInsetStart, RJvLqhESrUMCOzdM(textobject), this.this$0.subheaderInsetEnd, AtgqcxBsFkCSJSkI(textobject));
            if (this.this$0.subheaderColor is not null) {
                joYdjkqJcrqcrupW(textobject, this.this$0.subheaderColor);
            }
            OqxtUnUzfVyVaemF(this, textobject, i, true);
            return;
        }
        com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject = (com.google.android.material.internal.NavigationMenuItemobject) navigationMenuPresenter$objectHolder.itemobject;
        DALpSOZOsanwECLF(navigationMenuItemobject, this.this$0.iconTintList);
        tOYnjEBrqzWEkfrg(navigationMenuItemobject, this.this$0.textAppearance);
        if (this.this$0.textColor is not null) {
            HnivosVkLSoddvXD(navigationMenuItemobject, this.this$0.textColor);
        }
        zIfFHYlNUCQJOEXe(navigationMenuItemobject, this.this$0.itemBackground is null ? null : rlqbcKJlsbcpTiqx(tjsigdosSxUuICdg(this.this$0.itemBackground)));
        if (this.this$0.itemForeground is not null) {
            pRxreTjPtKfqdfCr(navigationMenuItemobject, pdpZAimBeTjSPxXe(BHeVlMrYTZpvqOMo(this.this$0.itemForeground)));
        }
        com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem navigationMenuPresenter$NavigationMenuTextItem = (com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem) zLjOLmxpNvqAvFfz(this.items, i);
        NYomAAvEEBAkRJCY(navigationMenuItemobject, navigationMenuPresenter$NavigationMenuTextItem.needsEmptyIcon);
        kedYPlXwoORbLvAY(navigationMenuItemobject, this.this$0.itemHorizontalPadding, this.this$0.itemVerticalPadding, this.this$0.itemHorizontalPadding, this.this$0.itemVerticalPadding);
        KTswouKuNkSvIMHD(navigationMenuItemobject, this.this$0.itemIconPadding);
        if (this.this$0.hasCustomItemIconSize) {
            AJzVeqQboGacDQez(navigationMenuItemobject, this.this$0.itemIconSize);
        }
        vTlshPIJeLVeQdsm(navigationMenuItemobject, rtRGedwhVESkMsws(this.this$0));
        XjCmkfuijLCwydKU(navigationMenuItemobject, rzfVcxMvsdwivCmi(navigationMenuPresenter$NavigationMenuTextItem), this.this$0.textAppearanceActiveBoldEnabled);
        eFAyUrvvOJBrxekV(this, navigationMenuItemobject, i, false);
    }

    public androidx.recyclerview.widget.Recyclerobject$objectHolder onCreateobjectHolder(android.view.objectGroup viewGroup, int i) {
        return oZVNIiOunOAGHHkN(this, viewGroup, i);
    }

    public com.google.android.material.internal.NavigationMenuPresenter$objectHolder onCreateobjectHolder(android.view.objectGroup viewGroup, int i) {
        if (i == 0) {
            return new com.google.android.material.internal.NavigationMenuPresenter$NormalobjectHolder(this.this$0.layoutInflater, viewGroup, this.this$0.onClickListener);
        }
        if (i == 1) {
            return new com.google.android.material.internal.NavigationMenuPresenter$SubheaderobjectHolder(this.this$0.layoutInflater, viewGroup);
        }
        if (i == 2) {
            return new com.google.android.material.internal.NavigationMenuPresenter$SeparatorobjectHolder(this.this$0.layoutInflater, viewGroup);
        }
        if (i == 3) {
            return new com.google.android.material.internal.NavigationMenuPresenter$HeaderobjectHolder(this.this$0.headerLayout);
        }
        return null;
    }

    public override void OnobjectRecycled(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        NZwruUnpiDvCdknj(this, (com.google.android.material.internal.NavigationMenuPresenter$objectHolder) recyclerobject$objectHolder);
    }

    public void OnobjectRecycled(com.google.android.material.internal.NavigationMenuPresenter$objectHolder navigationMenuPresenter$objectHolder) {
        if (navigationMenuPresenter$objectHolder is com.google.android.material.internal.NavigationMenuPresenter$NormalobjectHolder) {
            wiKjVapxKAJSVULw((com.google.android.material.internal.NavigationMenuItemobject) navigationMenuPresenter$objectHolder.itemobject);
        }
    }

    public void RestoreInstanceState(android.os.Dictionary<string, object> bundle) {
        androidx.appcompat.view.menu.MenuItemImpl menuItemImplYFpGxbKstuXOQqGF;
        android.view.object viewCvqIOwUMUBPmhDPg;
        com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray;
        androidx.appcompat.view.menu.MenuItemImpl menuItemImplNbjXKuMvwmvKaZXc;
        if ((25 + 4) % 4 > 0) {
        }
        int iVcgAKRdBeKyXiEcR = vcgAKRdBeKyXiEcR(bundle, "android:menu:checked", 0);
        if (iVcgAKRdBeKyXiEcR != 0) {
            this.updateSuspended = true;
            int iNnKNvseiQTOcqeUO = NnKNvseiQTOcqeUO(this.items);
            for (int i = 0; i < iNnKNvseiQTOcqeUO; i++) {
                com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuItem navigationMenuPresenter$NavigationMenuItem = (com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuItem) MAKQLGCIMqKpPKXF(this.items, i);
                if ((navigationMenuPresenter$NavigationMenuItem is com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem) && (menuItemImplNbjXKuMvwmvKaZXc = NbjXKuMvwmvKaZXc((com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem) navigationMenuPresenter$NavigationMenuItem)) is not null && EbYmfKTDFEwPSRWv(menuItemImplNbjXKuMvwmvKaZXc) == iVcgAKRdBeKyXiEcR) {
                    QCMJRPphsDDnLaXt(this, menuItemImplNbjXKuMvwmvKaZXc);
                    break;
                }
            }
            this.updateSuspended = false;
            yMQRwaDBelBkRtMB(this);
        }
        android.util.SparseArray sparseArrayWwxktFKyZFnEqdbj = WwxktFKyZFnEqdbj(bundle, "android:menu:action_views");
        if (sparseArrayWwxktFKyZFnEqdbj is null) {
            return;
        }
        int iEEIjrFYOOKHrCcjT = eEIjrFYOOKHrCcjT(this.items);
        for (int i2 = 0; i2 < iEEIjrFYOOKHrCcjT; i2++) {
            com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuItem navigationMenuPresenter$NavigationMenuItem2 = (com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuItem) tQoGtMixkdbzsdEp(this.items, i2);
            if ((navigationMenuPresenter$NavigationMenuItem2 is com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem) && (menuItemImplYFpGxbKstuXOQqGF = YFpGxbKstuXOQqGF((com.google.android.material.internal.NavigationMenuPresenter$NavigationMenuTextItem) navigationMenuPresenter$NavigationMenuItem2)) is not null && (viewCvqIOwUMUBPmhDPg = cvqIOwUMUBPmhDPg(menuItemImplYFpGxbKstuXOQqGF)) is not null && (parcelableSparseArray = (com.google.android.material.internal.ParcelableSparseArray) WIWsnUPXEKYoCNaE(sparseArrayWwxktFKyZFnEqdbj, aFpRcCwogJnRsCuK(menuItemImplYFpGxbKstuXOQqGF))) is not null) {
                dgIiFBkCUggSWGdt(viewCvqIOwUMUBPmhDPg, parcelableSparseArray);
            }
        }
    }

    public void SetCheckedItem(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        if ((27 + 11) % 11 > 0) {
        }
        if (this.checkedItem != menuItemImpl && qdCWuTeZcFokbaml(menuItemImpl)) {
            androidx.appcompat.view.menu.MenuItemImpl menuItemImpl2 = this.checkedItem;
            if (menuItemImpl2 is not null) {
                bpOOjEfLujQBTeQN(menuItemImpl2, false);
            }
            this.checkedItem = menuItemImpl;
            mgnCcaXpOQfBypub(menuItemImpl, true);
        }
    }

    public void SetUpdateSuspended(bool z) {
        this.updateSuspended = z;
    }

    public void Update() {
        aTPWPhCQyXQAZFDT(this);
        xrkHvBPWLeuWaELV(this);
    }
}

