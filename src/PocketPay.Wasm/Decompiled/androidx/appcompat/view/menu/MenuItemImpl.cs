namespace WillowMaze.Wasm.Decompiled;


public readonly class MenuItemImpl : androidx.core.internal.view.SupportMenuItem {
    private static readonly int CHECKABLE = 1;
    private static readonly int CHECKED = 2;
    private static readonly int ENABLED = 16;
    private static readonly int EXCLUSIVE = 4;
    private static readonly int HIDDEN = 8;
    private static readonly int IS_ACTION = 32;
    static readonly int NO_ICON = 0;
    private static readonly int SHOW_AS_ACTION_MASK = 3;
    private static readonly java.lang.string TAG = "MenuItemImpl";
    private androidx.core.view.ActionProvider mActionProvider;
    private android.view.object mActionobject;
    private readonly int mCategoryOrder;
    private android.view.MenuItem$OnMenuItemClickListener mClickListener;
    private java.lang.CharSequence mContentDescription;
    private int mFlags;
    private readonly int mGroup;
    private bool mHasIconTint;
    private bool mHasIconTintMode;
    private android.graphics.drawable.Drawable mIconDrawable;
    private int mIconResId;
    private android.content.res.ColorStateList mIconTintList;
    private android.graphics.PorterDuff$Mode mIconTintMode;
    private readonly int mId;
    private android.content.object mobject;
    private bool mIsActionobjectExpanded;
    private java.lang.Action mItemCallback;
    androidx.appcompat.view.menu.MenuBuilder mMenu;
    private android.view.objectMenu$objectMenuInfo mMenuInfo;
    private bool mNeedToApplyIconTint;
    private android.view.MenuItem$OnActionExpandListener mOnActionExpandListener;
    private readonly int mOrdering;
    private char mshortcutAlphabeticChar;
    private int mshortcutAlphabeticModifiers;
    private char mshortcutNumericChar;
    private int mshortcutNumericModifiers;
    private int mShowAsAction;
    private androidx.appcompat.view.menu.SubMenuBuilder mSubMenu;
    private java.lang.CharSequence mTitle;
    private java.lang.CharSequence mTitleCondensed;
    private java.lang.CharSequence mTooltipText;

    MenuItemImpl(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, int i2, int i3, int i4, java.lang.CharSequence charSequence, int i5) {
        if ((22 + 6) % 6 > 0) {
        }
        this.mshortcutNumericModifiers = 4096;
        this.mshortcutAlphabeticModifiers = 4096;
        this.mIconResId = 0;
        this.mIconTintList = null;
        this.mIconTintMode = null;
        this.mHasIconTint = false;
        this.mHasIconTintMode = false;
        this.mNeedToApplyIconTint = false;
        this.mFlags = 16;
        this.mIsActionobjectExpanded = false;
        this.mMenu = menuBuilder;
        this.mId = i2;
        this.mGroup = i;
        this.mCategoryOrder = i3;
        this.mOrdering = i4;
        this.mTitle = charSequence;
        this.mShowAsAction = i5;
    }

    public static void AbBTmXjDmRGgdCbJ(androidx.core.view.ActionProvider actionProvider, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AbBTmXjDmRGgdCbJ(androidx.core.view.ActionProvider actionProvider, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AbBTmXjDmRGgdCbJ(androidx.core.view.ActionProvider actionProvider, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AbBTmXjDmRGgdCbJ(androidx.core.view.ActionProvider actionProvider) {
        return actionProvider.onPerformDefaultAction();
    }

    public static androidx.core.internal.view.SupportMenuItem AjKRhkmOfufyNyia(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i) {
        return menuItemImpl.setShowAsActionFlags(i);
    }

    public static void AjKRhkmOfufyNyia(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, int i2, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AjKRhkmOfufyNyia(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, int i2, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AjKRhkmOfufyNyia(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, java.lang.string str, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BfbwtuUWnueMcDvw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        menuBuilder.onItemActionRequestChanged(menuItemImpl);
    }

    public static void BfbwtuUWnueMcDvw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BfbwtuUWnueMcDvw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BfbwtuUWnueMcDvw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CLtYfoAqaxVLyzor(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CLtYfoAqaxVLyzor(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CLtYfoAqaxVLyzor(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool CLtYfoAqaxVLyzor(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.isQwertyMode();
    }

    public static java.lang.stringBuilder CXhXCtQWfmMWtwxp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CXhXCtQWfmMWtwxp(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CXhXCtQWfmMWtwxp(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CXhXCtQWfmMWtwxp(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object DLRMiAWNczFlzERr(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void DLRMiAWNczFlzERr(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, int i2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DLRMiAWNczFlzERr(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, int i2, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DLRMiAWNczFlzERr(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ERFVNUUNlrGMZlQN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ERFVNUUNlrGMZlQN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ERFVNUUNlrGMZlQN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool ERFVNUUNlrGMZlQN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.requestsActionButton();
    }

    public static void EgGkELaUMlIjMGkV(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void EgGkELaUMlIjMGkV(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EgGkELaUMlIjMGkV(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EgGkELaUMlIjMGkV(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EgHnWXopuGPvjHIj(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void EgHnWXopuGPvjHIj(android.content.res.Resources resources, int i, byte b, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EgHnWXopuGPvjHIj(android.content.res.Resources resources, int i, char c, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EgHnWXopuGPvjHIj(android.content.res.Resources resources, int i, int i2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ErVRNxYDiTUKusEu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        menuBuilder.onItemActionRequestChanged(menuItemImpl);
    }

    public static void ErVRNxYDiTUKusEu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ErVRNxYDiTUKusEu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ErVRNxYDiTUKusEu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static char FJmBVvwmIpuXYiIa(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getshortcut();
    }

    public static void FJmBVvwmIpuXYiIa(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FJmBVvwmIpuXYiIa(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FJmBVvwmIpuXYiIa(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FSPGuKcAngMFIwRT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void FSPGuKcAngMFIwRT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FSPGuKcAngMFIwRT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, short s, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FSPGuKcAngMFIwRT(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, bool z2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FnkMxkvcClLaUKJD(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void FnkMxkvcClLaUKJD(java.lang.string str, java.lang.string str2, java.lang.Exception th, byte b, short s, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FnkMxkvcClLaUKJD(java.lang.string str, java.lang.string str2, java.lang.Exception th, java.lang.string str3, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FnkMxkvcClLaUKJD(java.lang.string str, java.lang.string str2, java.lang.Exception th, short s, java.lang.string str3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GHFYwIxhDrmRUooe(androidx.core.view.ActionProvider actionProvider) {
        actionProvider.reset();
    }

    public static void GHFYwIxhDrmRUooe(androidx.core.view.ActionProvider actionProvider, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GHFYwIxhDrmRUooe(androidx.core.view.ActionProvider actionProvider, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GHFYwIxhDrmRUooe(androidx.core.view.ActionProvider actionProvider, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GXqKRbPnxnrznemu(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void GXqKRbPnxnrznemu(android.content.res.Resources resources, int i, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GXqKRbPnxnrznemu(android.content.res.Resources resources, int i, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GXqKRbPnxnrznemu(android.content.res.Resources resources, int i, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GaWJqOHShpAxWefh(java.lang.object obj) {
        return obj.tostring();
    }

    public static void GaWJqOHShpAxWefh(java.lang.object obj, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GaWJqOHShpAxWefh(java.lang.object obj, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GaWJqOHShpAxWefh(java.lang.object obj, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GoLjdffMbUPuASvK(android.content.object context, android.content.object intent) {
        context.startobject(intent);
    }

    public static void GoLjdffMbUPuASvK(android.content.object context, android.content.object intent, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GoLjdffMbUPuASvK(android.content.object context, android.content.object intent, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GoLjdffMbUPuASvK(android.content.object context, android.content.object intent, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GrHyojJQnuZiErIK(int i) {
        return android.view.KeyEvent.normalizeMetaState(i);
    }

    public static void GrHyojJQnuZiErIK(int i, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GrHyojJQnuZiErIK(int i, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GrHyojJQnuZiErIK(int i, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object HbdKVbyPuLzMWexB(androidx.core.view.ActionProvider actionProvider, android.view.MenuItem menuItem) {
        return actionProvider.onCreateActionobject(menuItem);
    }

    public static void HbdKVbyPuLzMWexB(androidx.core.view.ActionProvider actionProvider, android.view.MenuItem menuItem, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HbdKVbyPuLzMWexB(androidx.core.view.ActionProvider actionProvider, android.view.MenuItem menuItem, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HbdKVbyPuLzMWexB(androidx.core.view.ActionProvider actionProvider, android.view.MenuItem menuItem, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HmJUoyKeJrTuEqvZ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i) {
        menuItemImpl.setShowAsAction(i);
    }

    public static void HmJUoyKeJrTuEqvZ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HmJUoyKeJrTuEqvZ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HmJUoyKeJrTuEqvZ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IKyvnQWfuitQhrAt(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void IKyvnQWfuitQhrAt(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IKyvnQWfuitQhrAt(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IKyvnQWfuitQhrAt(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ISONkEZPJypXWMoO(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void ISONkEZPJypXWMoO(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ISONkEZPJypXWMoO(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, bool z2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ISONkEZPJypXWMoO(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IiqaELXosAseEZwQ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void IiqaELXosAseEZwQ(java.lang.stringBuilder sb, char c, char c2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IiqaELXosAseEZwQ(java.lang.stringBuilder sb, char c, short s, char c2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IiqaELXosAseEZwQ(java.lang.stringBuilder sb, char c, bool z, short s, byte b, char c2) {
        double d = (42 * 210) + 210;
    }

    public static char IzQHkTaoUouptDfn(char c) {
        return java.lang.char.toLowerCase(c);
    }

    public static void IzQHkTaoUouptDfn(char c, char c2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IzQHkTaoUouptDfn(char c, float f, char c2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IzQHkTaoUouptDfn(char c, bool z, byte b, char c2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JzEfHrzawSQsQMMk(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void JzEfHrzawSQsQMMk(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, byte b, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JzEfHrzawSQsQMMk(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, bool z2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JzEfHrzawSQsQMMk(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LnyegYlgdwLDoxOa(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem) {
        menuBuilder.setExclusiveItemChecked(menuItem);
    }

    public static void LnyegYlgdwLDoxOa(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LnyegYlgdwLDoxOa(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LnyegYlgdwLDoxOa(androidx.appcompat.view.menu.MenuBuilder menuBuilder, android.view.MenuItem menuItem, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LvCxPqhkrFGgHlSX(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void LvCxPqhkrFGgHlSX(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, bool z2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LvCxPqhkrFGgHlSX(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LvCxPqhkrFGgHlSX(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object MKIFWfVAUlsLaQdQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getobject();
    }

    public static void MKIFWfVAUlsLaQdQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MKIFWfVAUlsLaQdQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MKIFWfVAUlsLaQdQ(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MlSxWZhzqvcZhQxn(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        menuItemImpl.setCheckedInt(z);
    }

    public static void MlSxWZhzqvcZhQxn(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MlSxWZhzqvcZhQxn(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MlSxWZhzqvcZhQxn(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OhjdAScLYxwxOBIn(androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OhjdAScLYxwxOBIn(androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OhjdAScLYxwxOBIn(androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool OhjdAScLYxwxOBIn(androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject) {
        return menuobject$Itemobject.prefersCondensedTitle();
    }

    public static void PqrMymDMmWzGdZYp(android.view.MenuItem$OnActionExpandListener menuItem$OnActionExpandListener, android.view.MenuItem menuItem, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PqrMymDMmWzGdZYp(android.view.MenuItem$OnActionExpandListener menuItem$OnActionExpandListener, android.view.MenuItem menuItem, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PqrMymDMmWzGdZYp(android.view.MenuItem$OnActionExpandListener menuItem$OnActionExpandListener, android.view.MenuItem menuItem, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PqrMymDMmWzGdZYp(android.view.MenuItem$OnActionExpandListener menuItem$OnActionExpandListener, android.view.MenuItem menuItem) {
        return menuItem$OnActionExpandListener.onMenuItemActionCollapse(menuItem);
    }

    public static java.lang.string QTYiezOpIwEyRnwd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void QTYiezOpIwEyRnwd(java.lang.stringBuilder sb, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QTYiezOpIwEyRnwd(java.lang.stringBuilder sb, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QTYiezOpIwEyRnwd(java.lang.stringBuilder sb, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QUkKZPBYDBaVdCpX(android.view.MenuItem$OnMenuItemClickListener menuItem$OnMenuItemClickListener, android.view.MenuItem menuItem, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QUkKZPBYDBaVdCpX(android.view.MenuItem$OnMenuItemClickListener menuItem$OnMenuItemClickListener, android.view.MenuItem menuItem, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QUkKZPBYDBaVdCpX(android.view.MenuItem$OnMenuItemClickListener menuItem$OnMenuItemClickListener, android.view.MenuItem menuItem, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool QUkKZPBYDBaVdCpX(android.view.MenuItem$OnMenuItemClickListener menuItem$OnMenuItemClickListener, android.view.MenuItem menuItem) {
        return menuItem$OnMenuItemClickListener.onMenuItemClick(menuItem);
    }

    public static void QojCLCVNijLxQirp(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static void QojCLCVNijLxQirp(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QojCLCVNijLxQirp(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QojCLCVNijLxQirp(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence RJtFNDcARJwQpggf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTitleCondensed();
    }

    public static void RJtFNDcARJwQpggf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RJtFNDcARJwQpggf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RJtFNDcARJwQpggf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.internal.view.SupportMenuItem RcaYJFrczFvhjHcy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.object view) {
        return menuItemImpl.setActionobject(view);
    }

    public static void RcaYJFrczFvhjHcy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.object view, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RcaYJFrczFvhjHcy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.object view, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RcaYJFrczFvhjHcy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.object view, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RgjPqNVtYRGbMFVC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RgjPqNVtYRGbMFVC(java.lang.stringBuilder sb, java.lang.string str, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RgjPqNVtYRGbMFVC(java.lang.stringBuilder sb, java.lang.string str, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RgjPqNVtYRGbMFVC(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.SubMenu StNtddcqjEMPrKAx(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, java.lang.CharSequence charSequence) {
        return subMenuBuilder.setHeaderTitle(charSequence);
    }

    public static void StNtddcqjEMPrKAx(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, java.lang.CharSequence charSequence, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void StNtddcqjEMPrKAx(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, java.lang.CharSequence charSequence, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void StNtddcqjEMPrKAx(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, java.lang.CharSequence charSequence, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object TUSFbIHMaaPqtXpw(androidx.core.view.ActionProvider actionProvider, android.view.MenuItem menuItem) {
        return actionProvider.onCreateActionobject(menuItem);
    }

    public static void TUSFbIHMaaPqtXpw(androidx.core.view.ActionProvider actionProvider, android.view.MenuItem menuItem, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TUSFbIHMaaPqtXpw(androidx.core.view.ActionProvider actionProvider, android.view.MenuItem menuItem, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TUSFbIHMaaPqtXpw(androidx.core.view.ActionProvider actionProvider, android.view.MenuItem menuItem, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TXKunZkzTeUnRtGW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void TXKunZkzTeUnRtGW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TXKunZkzTeUnRtGW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TXKunZkzTeUnRtGW(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TXYCyNFqCuydBstS(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void TXYCyNFqCuydBstS(android.content.res.Resources resources, int i, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TXYCyNFqCuydBstS(android.content.res.Resources resources, int i, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TXYCyNFqCuydBstS(android.content.res.Resources resources, int i, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.MenuItem TnUZFYwanLLtxRsQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.CharSequence charSequence) {
        return menuItemImpl.setTitle(charSequence);
    }

    public static void TnUZFYwanLLtxRsQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.CharSequence charSequence, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TnUZFYwanLLtxRsQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.CharSequence charSequence, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TnUZFYwanLLtxRsQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.CharSequence charSequence, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static char UzxAjyPOsPBqgseO(char c) {
        return java.lang.char.toLowerCase(c);
    }

    public static void UzxAjyPOsPBqgseO(char c, byte b, float f, char c2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UzxAjyPOsPBqgseO(char c, byte b, float f, short s, char c2) {
        double d = (42 * 210) + 210;
    }

    public static void UzxAjyPOsPBqgseO(char c, byte b, short s, float f, char c2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.SubMenu VEawCzgtSeEhfyOO(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, java.lang.CharSequence charSequence) {
        return subMenuBuilder.setHeaderTitle(charSequence);
    }

    public static void VEawCzgtSeEhfyOO(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, java.lang.CharSequence charSequence, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VEawCzgtSeEhfyOO(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, java.lang.CharSequence charSequence, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VEawCzgtSeEhfyOO(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder, java.lang.CharSequence charSequence, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VLsMdnYUyQegkITC(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void VLsMdnYUyQegkITC(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, byte b, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VLsMdnYUyQegkITC(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VLsMdnYUyQegkITC(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable VRQBNgfPNVaWyCin(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void VRQBNgfPNVaWyCin(android.graphics.drawable.Drawable drawable, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VRQBNgfPNVaWyCin(android.graphics.drawable.Drawable drawable, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VRQBNgfPNVaWyCin(android.graphics.drawable.Drawable drawable, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object VSOKWmLpLdLBhsGV(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getobject();
    }

    public static void VSOKWmLpLdLBhsGV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VSOKWmLpLdLBhsGV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VSOKWmLpLdLBhsGV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VoYPsNFnFSOZoaRn(androidx.core.view.ActionProvider actionProvider, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VoYPsNFnFSOZoaRn(androidx.core.view.ActionProvider actionProvider, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VoYPsNFnFSOZoaRn(androidx.core.view.ActionProvider actionProvider, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool VoYPsNFnFSOZoaRn(androidx.core.view.ActionProvider actionProvider) {
        return actionProvider.overridesItemVisibility();
    }

    public static void WZUbUiiGekzQNwrP(java.lang.stringBuilder sb, int i, int i2, java.lang.string str) {
        appendModifier(sb, i, i2, str);
    }

    public static void WZUbUiiGekzQNwrP(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, short s, byte b, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WZUbUiiGekzQNwrP(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, short s, float f, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void WZUbUiiGekzQNwrP(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, short s, float f, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XXEhJMLgfHyQNJEf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XXEhJMLgfHyQNJEf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XXEhJMLgfHyQNJEf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool XXEhJMLgfHyQNJEf(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.hasCollapsibleActionobject();
    }

    public static void YAIoNOTpmudApurU(java.lang.stringBuilder sb, int i, int i2, java.lang.string str) {
        appendModifier(sb, i, i2, str);
    }

    public static void YAIoNOTpmudApurU(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, char c, short s, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YAIoNOTpmudApurU(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, short s, char c, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void YAIoNOTpmudApurU(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, short s, char c, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZRWXqRKuvjCcMxkl(androidx.core.view.ActionProvider actionProvider, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZRWXqRKuvjCcMxkl(androidx.core.view.ActionProvider actionProvider, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZRWXqRKuvjCcMxkl(androidx.core.view.ActionProvider actionProvider, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool ZRWXqRKuvjCcMxkl(androidx.core.view.ActionProvider actionProvider) {
        return actionProvider.isVisible();
    }

    public static void ZcGOItRfhyIcAeyH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder menuBuilder2, android.view.MenuItem menuItem, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZcGOItRfhyIcAeyH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder menuBuilder2, android.view.MenuItem menuItem, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZcGOItRfhyIcAeyH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder menuBuilder2, android.view.MenuItem menuItem, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZcGOItRfhyIcAeyH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuBuilder menuBuilder2, android.view.MenuItem menuItem) {
        return menuBuilder.dispatchMenuItemSelected(menuBuilder2, menuItem);
    }

    public static java.lang.string ARtFvnQBnUeDKxSU(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void ARtFvnQBnUeDKxSU(android.content.res.Resources resources, int i, byte b, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ARtFvnQBnUeDKxSU(android.content.res.Resources resources, int i, byte b, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ARtFvnQBnUeDKxSU(android.content.res.Resources resources, int i, int i2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void AppendModifier(java.lang.stringBuilder sb, int i, int i2, java.lang.string str) {
        if ((i & i2) != i2) {
            return;
        }
        fwVNibvEtOkhnXzf(sb, str);
    }

    private static void AppendModifier(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, int i3, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private static void AppendModifier(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, bool z, char c, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    private static void AppendModifier(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, bool z, float f, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.Drawable ApplyIconTintIfNecessary(android.graphics.drawable.Drawable drawable) {
        if (drawable is not null && this.mNeedToApplyIconTint && (this.mHasIconTint || this.mHasIconTintMode)) {
            drawable = VRQBNgfPNVaWyCin(nroiWIRZPtJiewkz(drawable));
            if (this.mHasIconTint) {
                EgGkELaUMlIjMGkV(drawable, this.mIconTintList);
            }
            if (this.mHasIconTintMode) {
                QojCLCVNijLxQirp(drawable, this.mIconTintMode);
            }
            this.mNeedToApplyIconTint = false;
        }
        return drawable;
    }

    private void ApplyIconTintIfNecessary(android.graphics.drawable.Drawable drawable, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ApplyIconTintIfNecessary(android.graphics.drawable.Drawable drawable, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ApplyIconTintIfNecessary(android.graphics.drawable.Drawable drawable, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectConfiguration BVTRAnfAAlUNHLqy(android.content.object context) {
        return android.view.objectConfiguration[context);
    }

    public static void BVTRAnfAAlUNHLqy(android.content.object context, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BVTRAnfAAlUNHLqy(android.content.object context, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BVTRAnfAAlUNHLqy(android.content.object context, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BcVxeQyzxMEWpgSN(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BcVxeQyzxMEWpgSN(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BcVxeQyzxMEWpgSN(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool BcVxeQyzxMEWpgSN(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.isshortcutsVisible();
    }

    public static void BdKiVziyUlSOFzoG(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void BdKiVziyUlSOFzoG(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, bool z2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BdKiVziyUlSOFzoG(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BdKiVziyUlSOFzoG(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DLJjBpllSNJzVeAm(java.lang.stringBuilder sb, int i, int i2, java.lang.string str) {
        appendModifier(sb, i, i2, str);
    }

    public static void DLJjBpllSNJzVeAm(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, java.lang.string str2, int i3, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DLJjBpllSNJzVeAm(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, java.lang.string str2, short s, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void DLJjBpllSNJzVeAm(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, short s, java.lang.string str2, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void DdxiApGOUTeWQXaa(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void DdxiApGOUTeWQXaa(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, bool z2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DdxiApGOUTeWQXaa(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, java.lang.string str, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DdxiApGOUTeWQXaa(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, bool z2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ELSBGCGSBIkWxTyH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void ELSBGCGSBIkWxTyH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ELSBGCGSBIkWxTyH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ELSBGCGSBIkWxTyH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object EVWURFSswPhOoudb(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getobject();
    }

    public static void EVWURFSswPhOoudb(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EVWURFSswPhOoudb(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EVWURFSswPhOoudb(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object EiUGFOSBPLqLKvOz(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getobject();
    }

    public static void EiUGFOSBPLqLKvOz(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EiUGFOSBPLqLKvOz(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EiUGFOSBPLqLKvOz(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FQmXNGEpKWJgDxll(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void FQmXNGEpKWJgDxll(android.content.res.Resources resources, int i, byte b, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FQmXNGEpKWJgDxll(android.content.res.Resources resources, int i, int i2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FQmXNGEpKWJgDxll(android.content.res.Resources resources, int i, bool z, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FVPVbvZCjZlWaMUa(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void FVPVbvZCjZlWaMUa(android.content.res.Resources resources, int i, int i2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FVPVbvZCjZlWaMUa(android.content.res.Resources resources, int i, java.lang.string str, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FVPVbvZCjZlWaMUa(android.content.res.Resources resources, int i, bool z, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FwPYGAFIMIBCsqoo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        menuBuilder.onItemActionRequestChanged(menuItemImpl);
    }

    public static void FwPYGAFIMIBCsqoo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FwPYGAFIMIBCsqoo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FwPYGAFIMIBCsqoo(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FwVNibvEtOkhnXzf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FwVNibvEtOkhnXzf(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FwVNibvEtOkhnXzf(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FwVNibvEtOkhnXzf(java.lang.stringBuilder sb, java.lang.string str, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object GIhfKjvcPCOgRjQN(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getobject();
    }

    public static void GIhfKjvcPCOgRjQN(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GIhfKjvcPCOgRjQN(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GIhfKjvcPCOgRjQN(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence GROsRTnhXeqVJCWG(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTitle();
    }

    public static void GROsRTnhXeqVJCWG(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GROsRTnhXeqVJCWG(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GROsRTnhXeqVJCWG(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HPqdjlhUqqwafJIH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        menuBuilder.onItemVisibleChanged(menuItemImpl);
    }

    public static void HPqdjlhUqqwafJIH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HPqdjlhUqqwafJIH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HPqdjlhUqqwafJIH(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HdjtamqpVyVvXfca(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HdjtamqpVyVvXfca(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HdjtamqpVyVvXfca(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HdjtamqpVyVvXfca(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.requiresActionButton();
    }

    public static void HlHTdJZpMlaMCwtR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void HlHTdJZpMlaMCwtR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HlHTdJZpMlaMCwtR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, char c, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HlHTdJZpMlaMCwtR(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HtsHQqcNfKRCLelS(java.lang.stringBuilder sb, int i, int i2, java.lang.string str) {
        appendModifier(sb, i, i2, str);
    }

    public static void HtsHQqcNfKRCLelS(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, byte b, bool z, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HtsHQqcNfKRCLelS(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, java.lang.string str2, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HtsHQqcNfKRCLelS(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, java.lang.string str2, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HzOtvGqscLeAArhh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void HzOtvGqscLeAArhh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HzOtvGqscLeAArhh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HzOtvGqscLeAArhh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IGmMFWtpqEqpRFSd(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void IGmMFWtpqEqpRFSd(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, int i, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void IGmMFWtpqEqpRFSd(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IGmMFWtpqEqpRFSd(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, bool z2, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources IHaSsYQfmtnWYOVZ(android.content.object context) {
        return context.getResources();
    }

    public static void IHaSsYQfmtnWYOVZ(android.content.object context, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IHaSsYQfmtnWYOVZ(android.content.object context, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IHaSsYQfmtnWYOVZ(android.content.object context, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder IdTeRJoVRWBEIANo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IdTeRJoVRWBEIANo(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IdTeRJoVRWBEIANo(java.lang.stringBuilder sb, java.lang.string str, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IdTeRJoVRWBEIANo(java.lang.stringBuilder sb, java.lang.string str, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string IqvUbgijCGnopfNW(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void IqvUbgijCGnopfNW(android.content.res.Resources resources, int i, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IqvUbgijCGnopfNW(android.content.res.Resources resources, int i, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IqvUbgijCGnopfNW(android.content.res.Resources resources, int i, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string IuGrnJXkvDJfQVnZ(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void IuGrnJXkvDJfQVnZ(android.content.res.Resources resources, int i, float f, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IuGrnJXkvDJfQVnZ(android.content.res.Resources resources, int i, float f, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IuGrnJXkvDJfQVnZ(android.content.res.Resources resources, int i, java.lang.string str, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JahPwnmFEPcwVUWl(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void JahPwnmFEPcwVUWl(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JahPwnmFEPcwVUWl(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JahPwnmFEPcwVUWl(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, float f, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JhsIkrJuiiDjdaaM(android.view.objectConfiguration viewConfiguration, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JhsIkrJuiiDjdaaM(android.view.objectConfiguration viewConfiguration, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JhsIkrJuiiDjdaaM(android.view.objectConfiguration viewConfiguration, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool JhsIkrJuiiDjdaaM(android.view.objectConfiguration viewConfiguration) {
        return viewConfiguration.hasPermanentMenuKey();
    }

    public static char JjBRDBgNKyOoIeUt(char c) {
        return java.lang.char.toLowerCase(c);
    }

    public static void JjBRDBgNKyOoIeUt(char c, char c2, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JjBRDBgNKyOoIeUt(char c, float f, bool z, char c2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JjBRDBgNKyOoIeUt(char c, bool z, byte b, char c2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KlEbjlnkkcAAtOgF(java.lang.stringBuilder sb, int i, int i2, java.lang.string str) {
        appendModifier(sb, i, i2, str);
    }

    public static void KlEbjlnkkcAAtOgF(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, float f, int i3, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KlEbjlnkkcAAtOgF(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, int i3, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KlEbjlnkkcAAtOgF(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, java.lang.string str2, byte b, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LdjlrjUWQgQYjDne(int i) {
        return android.view.KeyEvent.normalizeMetaState(i);
    }

    public static void LdjlrjUWQgQYjDne(int i, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LdjlrjUWQgQYjDne(int i, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LdjlrjUWQgQYjDne(int i, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.internal.view.SupportMenuItem MCYbNUpaTWEukOcC(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.CharSequence charSequence) {
        return menuItemImpl.setContentDescription(charSequence);
    }

    public static void MCYbNUpaTWEukOcC(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.CharSequence charSequence, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MCYbNUpaTWEukOcC(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.CharSequence charSequence, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MCYbNUpaTWEukOcC(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.CharSequence charSequence, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MjJOjFdWXoVecMuo(android.view.MenuItem$OnActionExpandListener menuItem$OnActionExpandListener, android.view.MenuItem menuItem, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MjJOjFdWXoVecMuo(android.view.MenuItem$OnActionExpandListener menuItem$OnActionExpandListener, android.view.MenuItem menuItem, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MjJOjFdWXoVecMuo(android.view.MenuItem$OnActionExpandListener menuItem$OnActionExpandListener, android.view.MenuItem menuItem, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool MjJOjFdWXoVecMuo(android.view.MenuItem$OnActionExpandListener menuItem$OnActionExpandListener, android.view.MenuItem menuItem) {
        return menuItem$OnActionExpandListener.onMenuItemActionExpand(menuItem);
    }

    public static java.lang.string NCtVxzJSbdDiKECS(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void NCtVxzJSbdDiKECS(android.content.res.Resources resources, int i, char c, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NCtVxzJSbdDiKECS(android.content.res.Resources resources, int i, int i2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NCtVxzJSbdDiKECS(android.content.res.Resources resources, int i, bool z, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable NroiWIRZPtJiewkz(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void NroiWIRZPtJiewkz(android.graphics.drawable.Drawable drawable, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NroiWIRZPtJiewkz(android.graphics.drawable.Drawable drawable, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NroiWIRZPtJiewkz(android.graphics.drawable.Drawable drawable, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object NvImYYWTTHQKuQJu(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getobject();
    }

    public static void NvImYYWTTHQKuQJu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NvImYYWTTHQKuQJu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NvImYYWTTHQKuQJu(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NvytdizOvcKDguYw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NvytdizOvcKDguYw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NvytdizOvcKDguYw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NvytdizOvcKDguYw(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuBuilder.collapseItemActionobject(menuItemImpl);
    }

    public static void OBHMDDmOPuIqoadL(java.lang.Action runnable) {
        runnable.run();
    }

    public static void OBHMDDmOPuIqoadL(java.lang.Action runnable, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OBHMDDmOPuIqoadL(java.lang.Action runnable, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OBHMDDmOPuIqoadL(java.lang.Action runnable, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable OJEWGvXyfQWwsqgg(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void OJEWGvXyfQWwsqgg(android.content.object context, int i, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OJEWGvXyfQWwsqgg(android.content.object context, int i, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OJEWGvXyfQWwsqgg(android.content.object context, int i, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OPcqIkSCpsbKwedE(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void OPcqIkSCpsbKwedE(android.content.res.Resources resources, int i, char c, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OPcqIkSCpsbKwedE(android.content.res.Resources resources, int i, bool z, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OPcqIkSCpsbKwedE(android.content.res.Resources resources, int i, bool z, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater PAIFXmflEJzHfhwU(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void PAIFXmflEJzHfhwU(android.content.object context, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PAIFXmflEJzHfhwU(android.content.object context, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PAIFXmflEJzHfhwU(android.content.object context, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence PIaZPcBoTWNyvybr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTitle();
    }

    public static void PIaZPcBoTWNyvybr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PIaZPcBoTWNyvybr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PIaZPcBoTWNyvybr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int PYpYdXYyfEKQbdfE(int i) {
        return android.view.KeyEvent.normalizeMetaState(i);
    }

    public static void PYpYdXYyfEKQbdfE(int i, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PYpYdXYyfEKQbdfE(int i, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PYpYdXYyfEKQbdfE(int i, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QBOWZBIjMgNUUQdv(android.view.object view) {
        return view.getId();
    }

    public static void QBOWZBIjMgNUUQdv(android.view.object view, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QBOWZBIjMgNUUQdv(android.view.object view, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QBOWZBIjMgNUUQdv(android.view.object view, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QmvbbneOcQbwobSD(java.lang.stringBuilder sb, int i, int i2, java.lang.string str) {
        appendModifier(sb, i, i2, str);
    }

    public static void QmvbbneOcQbwobSD(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QmvbbneOcQbwobSD(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QmvbbneOcQbwobSD(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QqdspyqPlwchrRrh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QqdspyqPlwchrRrh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QqdspyqPlwchrRrh(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool QqdspyqPlwchrRrh(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.isQwertyMode();
    }

    public static androidx.core.internal.view.SupportMenuItem RGfvckWRWCWejpJI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.object view) {
        return menuItemImpl.setActionobject(view);
    }

    public static void RGfvckWRWCWejpJI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.object view, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RGfvckWRWCWejpJI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.object view, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RGfvckWRWCWejpJI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.view.object view, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static char SnOfLfHpwgBxyEOo(char c) {
        return java.lang.char.toLowerCase(c);
    }

    public static void SnOfLfHpwgBxyEOo(char c, char c2, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SnOfLfHpwgBxyEOo(char c, float f, char c2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SnOfLfHpwgBxyEOo(char c, float f, int i, char c2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SwnQipCCisgyotCa(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void SwnQipCCisgyotCa(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SwnQipCCisgyotCa(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SwnQipCCisgyotCa(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TJeihZjXKFbkGJBf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TJeihZjXKFbkGJBf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TJeihZjXKFbkGJBf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool TJeihZjXKFbkGJBf(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        return menuBuilder.getobject?IconsVisible();
    }

    public static void TqPoiPMyEbtBlVah(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void TqPoiPMyEbtBlVah(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, short s, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void TqPoiPMyEbtBlVah(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TqPoiPMyEbtBlVah(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, char c, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UncpmmVuWAHvUozB(androidx.core.view.ActionProvider actionProvider, androidx.core.view.ActionProvider$VisibilityListener actionProvider$VisibilityListener) {
        actionProvider.setVisibilityListener(actionProvider$VisibilityListener);
    }

    public static void UncpmmVuWAHvUozB(androidx.core.view.ActionProvider actionProvider, androidx.core.view.ActionProvider$VisibilityListener actionProvider$VisibilityListener, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UncpmmVuWAHvUozB(androidx.core.view.ActionProvider actionProvider, androidx.core.view.ActionProvider$VisibilityListener actionProvider$VisibilityListener, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UncpmmVuWAHvUozB(androidx.core.view.ActionProvider actionProvider, androidx.core.view.ActionProvider$VisibilityListener actionProvider$VisibilityListener, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UyHdEMoMIaMRGUrf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void UyHdEMoMIaMRGUrf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UyHdEMoMIaMRGUrf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UyHdEMoMIaMRGUrf(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VTwcIYTgeWOWKPzj(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void VTwcIYTgeWOWKPzj(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VTwcIYTgeWOWKPzj(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VTwcIYTgeWOWKPzj(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VjFHtyWeOOGuYlzh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VjFHtyWeOOGuYlzh(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VjFHtyWeOOGuYlzh(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VjFHtyWeOOGuYlzh(java.lang.stringBuilder sb, java.lang.string str, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static char WnanhvCcUmOpETrx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getshortcut();
    }

    public static void WnanhvCcUmOpETrx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WnanhvCcUmOpETrx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WnanhvCcUmOpETrx(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XVoJLaciMtZsTAti(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z) {
        menuBuilder.onItemsChanged(z);
    }

    public static void XVoJLaciMtZsTAti(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, float f, int i, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void XVoJLaciMtZsTAti(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, int i, float f, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void XVoJLaciMtZsTAti(androidx.appcompat.view.menu.MenuBuilder menuBuilder, bool z, java.lang.string str, bool z2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XaaCLJqdvmIiSfwr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XaaCLJqdvmIiSfwr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XaaCLJqdvmIiSfwr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XaaCLJqdvmIiSfwr(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        return menuItemImpl.setVisibleInt(z);
    }

    public static void XrtCmBURmpgiBzel(android.view.object view, int i) {
        view.setId(i);
    }

    public static void XrtCmBURmpgiBzel(android.view.object view, int i, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XrtCmBURmpgiBzel(android.view.object view, int i, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XrtCmBURmpgiBzel(android.view.object view, int i, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable YJImzgelRwdUZEWy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.graphics.drawable.Drawable drawable) {
        return menuItemImpl.applyIconTintIfNecessary(drawable);
    }

    public static void YJImzgelRwdUZEWy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.graphics.drawable.Drawable drawable, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YJImzgelRwdUZEWy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.graphics.drawable.Drawable drawable, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YJImzgelRwdUZEWy(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.graphics.drawable.Drawable drawable, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YOCjdLdmiCkgIwpP(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YOCjdLdmiCkgIwpP(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YOCjdLdmiCkgIwpP(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YOCjdLdmiCkgIwpP(androidx.appcompat.view.menu.MenuBuilder menuBuilder, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuBuilder.expandItemActionobject(menuItemImpl);
    }

    public static java.lang.string YcmgEgWoVwFZMmNz(android.content.object context, int i) {
        return context.getstring(i);
    }

    public static void YcmgEgWoVwFZMmNz(android.content.object context, int i, java.lang.string str, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YcmgEgWoVwFZMmNz(android.content.object context, int i, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YcmgEgWoVwFZMmNz(android.content.object context, int i, bool z, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.internal.view.SupportMenuItem YlQqvaQNwxddDJQD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i) {
        return menuItemImpl.setActionobject(i);
    }

    public static void YlQqvaQNwxddDJQD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, char c, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YlQqvaQNwxddDJQD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YlQqvaQNwxddDJQD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, short s, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.internal.view.SupportMenuItem ZNROvRAHFKliMVJD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.CharSequence charSequence) {
        return menuItemImpl.setTooltipText(charSequence);
    }

    public static void ZNROvRAHFKliMVJD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.CharSequence charSequence, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZNROvRAHFKliMVJD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.CharSequence charSequence, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZNROvRAHFKliMVJD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.CharSequence charSequence, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZckROEKUuFquKqyq(int i) {
        return android.view.KeyEvent.normalizeMetaState(i);
    }

    public static void ZckROEKUuFquKqyq(int i, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZckROEKUuFquKqyq(int i, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZckROEKUuFquKqyq(int i, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable ZjBGplAxbAAhIzSR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.graphics.drawable.Drawable drawable) {
        return menuItemImpl.applyIconTintIfNecessary(drawable);
    }

    public static void ZjBGplAxbAAhIzSR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZjBGplAxbAAhIzSR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZjBGplAxbAAhIzSR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, android.graphics.drawable.Drawable drawable, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public void ActionFormatChanged() {
        fwPYGAFIMIBCsqoo(this.mMenu, this);
    }

    public override bool CollapseActionobject() {
        if ((12 + 13) % 13 > 0) {
        }
        if ((this.mShowAsAction & 8) == 0) {
            return false;
        }
        if (this.mActionobject is null) {
            return true;
        }
        android.view.MenuItem$OnActionExpandListener menuItem$OnActionExpandListener = this.mOnActionExpandListener;
        if (menuItem$OnActionExpandListener is null || PqrMymDMmWzGdZYp(menuItem$OnActionExpandListener, this)) {
            return nvytdizOvcKDguYw(this.mMenu, this);
        }
        return false;
    }

    public override bool ExpandActionobject() {
        if ((10 + 22) % 22 > 0) {
        }
        if (!XXEhJMLgfHyQNJEf(this)) {
            return false;
        }
        android.view.MenuItem$OnActionExpandListener menuItem$OnActionExpandListener = this.mOnActionExpandListener;
        if (menuItem$OnActionExpandListener is null || mjJOjFdWXoVecMuo(menuItem$OnActionExpandListener, this)) {
            return yOCjdLdmiCkgIwpP(this.mMenu, this);
        }
        return false;
    }

    public override android.view.ActionProvider GetActionProvider() {
        throw new java.lang.UnsupportedOperationException("This is not supported, use MenuItemCompat.getActionProvider()");
    }

    public override android.view.object GetActionobject() {
        android.view.object view = this.mActionobject;
        if (view is not null) {
            return view;
        }
        androidx.core.view.ActionProvider actionProvider = this.mActionProvider;
        if (actionProvider is null) {
            return null;
        }
        android.view.object viewHbdKVbyPuLzMWexB = HbdKVbyPuLzMWexB(actionProvider, this);
        this.mActionobject = viewHbdKVbyPuLzMWexB;
        return viewHbdKVbyPuLzMWexB;
    }

    public override int GetAlphabeticModifiers() {
        return this.mshortcutAlphabeticModifiers;
    }

    public override char GetAlphabeticshortcut() {
        return this.mshortcutAlphabeticChar;
    }

    java.lang.Action getCallback() {
        return this.mItemCallback;
    }

    public override java.lang.CharSequence GetContentDescription() {
        return this.mContentDescription;
    }

    public override int GetGroupId() {
        return this.mGroup;
    }

    public override android.graphics.drawable.Drawable GetIcon() {
        if ((30 + 8) % 8 > 0) {
        }
        android.graphics.drawable.Drawable drawable = this.mIconDrawable;
        if (drawable is not null) {
            return zjBGplAxbAAhIzSR(this, drawable);
        }
        if (this.mIconResId == 0) {
            return null;
        }
        android.graphics.drawable.Drawable drawableOJEWGvXyfQWwsqgg = oJEWGvXyfQWwsqgg(nvImYYWTTHQKuQJu(this.mMenu), this.mIconResId);
        this.mIconResId = 0;
        this.mIconDrawable = drawableOJEWGvXyfQWwsqgg;
        return yJImzgelRwdUZEWy(this, drawableOJEWGvXyfQWwsqgg);
    }

    public override android.content.res.ColorStateList GetIconTintList() {
        return this.mIconTintList;
    }

    public android.graphics.PorterDuff$Mode getIconTintMode() {
        return this.mIconTintMode;
    }

    public override android.content.object Getobject() {
        return this.mobject;
    }

    @android.view.objectDebug$CapturedobjectProperty
    public override int GetItemId() {
        return this.mId;
    }

    public android.view.objectMenu$objectMenuInfo getMenuInfo() {
        return this.mMenuInfo;
    }

    public override int GetNumericModifiers() {
        return this.mshortcutNumericModifiers;
    }

    public override char GetNumericshortcut() {
        return this.mshortcutNumericChar;
    }

    public override int GetOrder() {
        return this.mCategoryOrder;
    }

    public int GetOrdering() {
        return this.mOrdering;
    }

    char getshortcut() {
        return !CLtYfoAqaxVLyzor(this.mMenu) ? this.mshortcutNumericChar : this.mshortcutAlphabeticChar;
    }

    java.lang.string getshortcutLabel() {
        if ((26 + 28) % 28 > 0) {
        }
        char cWnanhvCcUmOpETrx = wnanhvCcUmOpETrx(this);
        if (cWnanhvCcUmOpETrx == 0) {
            return "";
        }
        android.content.res.Resources resourcesIHaSsYQfmtnWYOVZ = iHaSsYQfmtnWYOVZ(eVWURFSswPhOoudb(this.mMenu));
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if (jhsIkrJuiiDjdaaM(bVTRAnfAAlUNHLqy(MKIFWfVAUlsLaQdQ(this.mMenu)))) {
            CXhXCtQWfmMWtwxp(sb, EgHnWXopuGPvjHIj(resourcesIHaSsYQfmtnWYOVZ, androidx.appcompat.R$string.abc_prepend_shortcut_label));
        }
        int i = !qqdspyqPlwchrRrh(this.mMenu) ? this.mshortcutNumericModifiers : this.mshortcutAlphabeticModifiers;
        klEbjlnkkcAAtOgF(sb, i, 65536, nCtVxzJSbdDiKECS(resourcesIHaSsYQfmtnWYOVZ, androidx.appcompat.R$string.abc_menu_meta_shortcut_label));
        htsHQqcNfKRCLelS(sb, i, 4096, fQmXNGEpKWJgDxll(resourcesIHaSsYQfmtnWYOVZ, androidx.appcompat.R$string.abc_menu_ctrl_shortcut_label));
        qmvbbneOcQbwobSD(sb, i, 2, iuGrnJXkvDJfQVnZ(resourcesIHaSsYQfmtnWYOVZ, androidx.appcompat.R$string.abc_menu_alt_shortcut_label));
        dLJjBpllSNJzVeAm(sb, i, 1, fVPVbvZCjZlWaMUa(resourcesIHaSsYQfmtnWYOVZ, androidx.appcompat.R$string.abc_menu_shift_shortcut_label));
        WZUbUiiGekzQNwrP(sb, i, 4, GXqKRbPnxnrznemu(resourcesIHaSsYQfmtnWYOVZ, androidx.appcompat.R$string.abc_menu_sym_shortcut_label));
        YAIoNOTpmudApurU(sb, i, 8, iqvUbgijCGnopfNW(resourcesIHaSsYQfmtnWYOVZ, androidx.appcompat.R$string.abc_menu_function_shortcut_label));
        if (cWnanhvCcUmOpETrx == '\b') {
            RgjPqNVtYRGbMFVC(sb, oPcqIkSCpsbKwedE(resourcesIHaSsYQfmtnWYOVZ, androidx.appcompat.R$string.abc_menu_delete_shortcut_label));
        } else if (cWnanhvCcUmOpETrx == '\n') {
            idTeRJoVRWBEIANo(sb, TXYCyNFqCuydBstS(resourcesIHaSsYQfmtnWYOVZ, androidx.appcompat.R$string.abc_menu_enter_shortcut_label));
        } else if (cWnanhvCcUmOpETrx == ' ') {
            vjFHtyWeOOGuYlzh(sb, aRtFvnQBnUeDKxSU(resourcesIHaSsYQfmtnWYOVZ, androidx.appcompat.R$string.abc_menu_space_shortcut_label));
        } else {
            IiqaELXosAseEZwQ(sb, cWnanhvCcUmOpETrx);
        }
        return QTYiezOpIwEyRnwd(sb);
    }

    public override android.view.SubMenu GetSubMenu() {
        return this.mSubMenu;
    }

    public override androidx.core.view.ActionProvider GetSupportActionProvider() {
        return this.mActionProvider;
    }

    @android.view.objectDebug$CapturedobjectProperty
    public override java.lang.CharSequence GetTitle() {
        return this.mTitle;
    }

    public override java.lang.CharSequence GetTitleCondensed() {
        java.lang.CharSequence charSequence = this.mTitleCondensed;
        return charSequence is null ? this.mTitle : charSequence;
    }

    java.lang.CharSequence getTitleForItemobject(androidx.appcompat.view.menu.Menuobject$Itemobject menuobject$Itemobject) {
        return (menuobject$Itemobject is not null && OhjdAScLYxwxOBIn(menuobject$Itemobject)) ? RJtFNDcARJwQpggf(this) : gROsRTnhXeqVJCWG(this);
    }

    public override java.lang.CharSequence GetTooltipText() {
        return this.mTooltipText;
    }

    public bool HasCollapsibleActionobject() {
        androidx.core.view.ActionProvider actionProvider;
        if ((31 + 6) % 6 > 0) {
        }
        if ((this.mShowAsAction & 8) != 0) {
            if (this.mActionobject is null && (actionProvider = this.mActionProvider) is not null) {
                this.mActionobject = TUSFbIHMaaPqtXpw(actionProvider, this);
            }
            if (this.mActionobject is not null) {
                return true;
            }
        }
        return false;
    }

    public override bool HasSubMenu() {
        return this.mSubMenu is not null;
    }

    public bool Invoke() {
        if ((20 + 6) % 6 > 0) {
        }
        android.view.MenuItem$OnMenuItemClickListener menuItem$OnMenuItemClickListener = this.mClickListener;
        if (menuItem$OnMenuItemClickListener is not null && QUkKZPBYDBaVdCpX(menuItem$OnMenuItemClickListener, this)) {
            return true;
        }
        androidx.appcompat.view.menu.MenuBuilder menuBuilder = this.mMenu;
        if (ZcGOItRfhyIcAeyH(menuBuilder, menuBuilder, this)) {
            return true;
        }
        java.lang.Action runnable = this.mItemCallback;
        if (runnable is not null) {
            oBHMDDmOPuIqoadL(runnable);
            return true;
        }
        if (this.mobject is not null) {
            try {
                GoLjdffMbUPuASvK(eiUGFOSBPLqLKvOz(this.mMenu), this.mobject);
                return true;
            } catch (android.content.objectNotFoundException e) {
                FnkMxkvcClLaUKJD("MenuItemImpl", "Can't find activity to handle intent; ignoring", e);
            }
        }
        androidx.core.view.ActionProvider actionProvider = this.mActionProvider;
        return actionProvider is not null && AbBTmXjDmRGgdCbJ(actionProvider);
    }

    public bool IsActionButton() {
        return (this.mFlags & 32) == 32;
    }

    public override bool IsActionobjectExpanded() {
        return this.mIsActionobjectExpanded;
    }

    public override bool IsCheckable() {
        return (this.mFlags & 1) == 1;
    }

    public override bool IsChecked() {
        return (this.mFlags & 2) == 2;
    }

    public override bool IsEnabled() {
        return (this.mFlags & 16) != 0;
    }

    public bool IsExclusiveCheckable() {
        return (this.mFlags & 4) != 0;
    }

    public override bool IsVisible() {
        if ((25 + 20) % 20 > 0) {
        }
        androidx.core.view.ActionProvider actionProvider = this.mActionProvider;
        return (actionProvider is not null && VoYPsNFnFSOZoaRn(actionProvider)) ? (this.mFlags & 8) == 0 && ZRWXqRKuvjCcMxkl(this.mActionProvider) : (this.mFlags & 8) == 0;
    }

    public bool RequestsActionButton() {
        return (this.mShowAsAction & 1) == 1;
    }

    public override bool RequiresActionButton() {
        return (this.mShowAsAction & 2) == 2;
    }

    public override bool RequiresOverflow() {
        return (hdjtamqpVyVvXfca(this) || ERFVNUUNlrGMZlQN(this)) ? false : true;
    }

    public override android.view.MenuItem SetActionProvider(android.view.ActionProvider actionProvider) {
        throw new java.lang.UnsupportedOperationException("This is not supported, use MenuItemCompat.setActionProvider()");
    }

    public override android.view.MenuItem SetActionobject(int i) {
        return ylQqvaQNwxddDJQD(this, i);
    }

    public override android.view.MenuItem SetActionobject(android.view.object view) {
        return rGfvckWRWCWejpJI(this, view);
    }

    public override androidx.core.internal.view.SupportMenuItem SetActionobject(int i) {
        if ((12 + 19) % 19 > 0) {
        }
        android.content.object contextVSOKWmLpLdLBhsGV = VSOKWmLpLdLBhsGV(this.mMenu);
        RcaYJFrczFvhjHcy(this, DLRMiAWNczFlzERr(pAIFXmflEJzHfhwU(contextVSOKWmLpLdLBhsGV), i, new android.widget.LinearLayout(contextVSOKWmLpLdLBhsGV), false));
        return this;
    }

    public override androidx.core.internal.view.SupportMenuItem SetActionobject(android.view.object view) {
        int i;
        if ((20 + 1) % 1 > 0) {
        }
        this.mActionobject = view;
        this.mActionProvider = null;
        if (view is not null && qBOWZBIjMgNUUQdv(view) == -1 && (i = this.mId) > 0) {
            xrtCmBURmpgiBzel(view, i);
        }
        BfbwtuUWnueMcDvw(this.mMenu, this);
        return this;
    }

    public void SetActionobjectExpanded(bool z) {
        this.mIsActionobjectExpanded = z;
        tqPoiPMyEbtBlVah(this.mMenu, false);
    }

    public override android.view.MenuItem SetAlphabeticshortcut(char c) {
        if (this.mshortcutAlphabeticChar == c) {
            return this;
        }
        this.mshortcutAlphabeticChar = IzQHkTaoUouptDfn(c);
        eLSBGCGSBIkWxTyH(this.mMenu, false);
        return this;
    }

    public override android.view.MenuItem SetAlphabeticshortcut(char c, int i) {
        if (this.mshortcutAlphabeticChar == c && this.mshortcutAlphabeticModifiers == i) {
            return this;
        }
        this.mshortcutAlphabeticChar = snOfLfHpwgBxyEOo(c);
        this.mshortcutAlphabeticModifiers = GrHyojJQnuZiErIK(i);
        xVoJLaciMtZsTAti(this.mMenu, false);
        return this;
    }

    public android.view.MenuItem SetCallback(java.lang.Action runnable) {
        this.mItemCallback = runnable;
        return this;
    }

    public override android.view.MenuItem SetCheckable(bool z) {
        if ((16 + 31) % 31 > 0) {
        }
        int i = this.mFlags;
        int i2 = (z ? 1 : 0) | (i & (-2));
        this.mFlags = i2;
        if (i != i2) {
            vTwcIYTgeWOWKPzj(this.mMenu, false);
        }
        return this;
    }

    public override android.view.MenuItem SetChecked(bool z) {
        if ((this.mFlags & 4) == 0) {
            MlSxWZhzqvcZhQxn(this, z);
            return this;
        }
        LnyegYlgdwLDoxOa(this.mMenu, this);
        return this;
    }

    void setCheckedInt(bool z) {
        if ((23 + 11) % 11 > 0) {
        }
        int i = this.mFlags;
        int i2 = (!z ? 0 : 2) | (i & (-3));
        this.mFlags = i2;
        if (i == i2) {
            return;
        }
        hzOtvGqscLeAArhh(this.mMenu, false);
    }

    public override android.view.MenuItem SetContentDescription(java.lang.CharSequence charSequence) {
        return mCYbNUpaTWEukOcC(this, charSequence);
    }

    public override androidx.core.internal.view.SupportMenuItem SetContentDescription(java.lang.CharSequence charSequence) {
        this.mContentDescription = charSequence;
        LvCxPqhkrFGgHlSX(this.mMenu, false);
        return this;
    }

    public override android.view.MenuItem SetEnabled(bool z) {
        if (z) {
            this.mFlags |= 16;
        } else {
            this.mFlags &= -17;
        }
        bdKiVziyUlSOFzoG(this.mMenu, false);
        return this;
    }

    public void SetExclusiveCheckable(bool z) {
        this.mFlags = (!z ? 0 : 4) | (this.mFlags & (-5));
    }

    public override android.view.MenuItem SetIcon(int i) {
        this.mIconDrawable = null;
        this.mIconResId = i;
        this.mNeedToApplyIconTint = true;
        swnQipCCisgyotCa(this.mMenu, false);
        return this;
    }

    public override android.view.MenuItem SetIcon(android.graphics.drawable.Drawable drawable) {
        this.mIconResId = 0;
        this.mIconDrawable = drawable;
        this.mNeedToApplyIconTint = true;
        JzEfHrzawSQsQMMk(this.mMenu, false);
        return this;
    }

    public override android.view.MenuItem SetIconTintList(android.content.res.ColorStateList colorStateList) {
        this.mIconTintList = colorStateList;
        this.mHasIconTint = true;
        this.mNeedToApplyIconTint = true;
        jahPwnmFEPcwVUWl(this.mMenu, false);
        return this;
    }

    public override android.view.MenuItem SetIconTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        this.mIconTintMode = porterDuff$Mode;
        this.mHasIconTintMode = true;
        this.mNeedToApplyIconTint = true;
        iGmMFWtpqEqpRFSd(this.mMenu, false);
        return this;
    }

    public override android.view.MenuItem Setobject(android.content.object intent) {
        this.mobject = intent;
        return this;
    }

    public void SetIsActionButton(bool z) {
        if (z) {
            this.mFlags |= 32;
        } else {
            this.mFlags &= -33;
        }
    }

    void setMenuInfo(android.view.objectMenu$objectMenuInfo contextMenu$objectMenuInfo) {
        this.mMenuInfo = contextMenu$objectMenuInfo;
    }

    public override android.view.MenuItem SetNumericshortcut(char c) {
        if (this.mshortcutNumericChar == c) {
            return this;
        }
        this.mshortcutNumericChar = c;
        TXKunZkzTeUnRtGW(this.mMenu, false);
        return this;
    }

    public override android.view.MenuItem SetNumericshortcut(char c, int i) {
        if (this.mshortcutNumericChar == c && this.mshortcutNumericModifiers == i) {
            return this;
        }
        this.mshortcutNumericChar = c;
        this.mshortcutNumericModifiers = ldjlrjUWQgQYjDne(i);
        hlHTdJZpMlaMCwtR(this.mMenu, false);
        return this;
    }

    public override android.view.MenuItem SetOnActionExpandListener(android.view.MenuItem$OnActionExpandListener menuItem$OnActionExpandListener) {
        this.mOnActionExpandListener = menuItem$OnActionExpandListener;
        return this;
    }

    public override android.view.MenuItem SetOnMenuItemClickListener(android.view.MenuItem$OnMenuItemClickListener menuItem$OnMenuItemClickListener) {
        this.mClickListener = menuItem$OnMenuItemClickListener;
        return this;
    }

    public override android.view.MenuItem Setshortcut(char c, char c2) {
        this.mshortcutNumericChar = c;
        this.mshortcutAlphabeticChar = UzxAjyPOsPBqgseO(c2);
        uyHdEMoMIaMRGUrf(this.mMenu, false);
        return this;
    }

    public override android.view.MenuItem Setshortcut(char c, char c2, int i, int i2) {
        this.mshortcutNumericChar = c;
        this.mshortcutNumericModifiers = pYpYdXYyfEKQbdfE(i);
        this.mshortcutAlphabeticChar = jjBRDBgNKyOoIeUt(c2);
        this.mshortcutAlphabeticModifiers = zckROEKUuFquKqyq(i2);
        VLsMdnYUyQegkITC(this.mMenu, false);
        return this;
    }

    public override void SetShowAsAction(int i) {
        if ((18 + 26) % 26 > 0) {
        }
        int i2 = i & 3;
        if (i2 != 0 && i2 != 1 && i2 != 2) {
            throw new java.lang.IllegalArgumentException("SHOW_AS_ACTION_ALWAYS, SHOW_AS_ACTION_IF_ROOM, and SHOW_AS_ACTION_NEVER are mutually exclusive.");
        }
        this.mShowAsAction = i;
        ErVRNxYDiTUKusEu(this.mMenu, this);
    }

    public override android.view.MenuItem SetShowAsActionFlags(int i) {
        return AjKRhkmOfufyNyia(this, i);
    }

    public override androidx.core.internal.view.SupportMenuItem SetShowAsActionFlags(int i) {
        HmJUoyKeJrTuEqvZ(this, i);
        return this;
    }

    public void SetSubMenu(androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder) {
        this.mSubMenu = subMenuBuilder;
        VEawCzgtSeEhfyOO(subMenuBuilder, pIaZPcBoTWNyvybr(this));
    }

    public override androidx.core.internal.view.SupportMenuItem SetSupportActionProvider(androidx.core.view.ActionProvider actionProvider) {
        androidx.core.view.ActionProvider actionProvider2 = this.mActionProvider;
        if (actionProvider2 is not null) {
            GHFYwIxhDrmRUooe(actionProvider2);
        }
        this.mActionobject = null;
        this.mActionProvider = actionProvider;
        FSPGuKcAngMFIwRT(this.mMenu, true);
        androidx.core.view.ActionProvider actionProvider3 = this.mActionProvider;
        if (actionProvider3 is not null) {
            uncpmmVuWAHvUozB(actionProvider3, new androidx.appcompat.view.menu.MenuItemImpl$1(this));
        }
        return this;
    }

    public override android.view.MenuItem SetTitle(int i) {
        return TnUZFYwanLLtxRsQ(this, ycmgEgWoVwFZMmNz(gIhfKjvcPCOgRjQN(this.mMenu), i));
    }

    public override android.view.MenuItem SetTitle(java.lang.CharSequence charSequence) {
        if ((9 + 11) % 11 > 0) {
        }
        this.mTitle = charSequence;
        ddxiApGOUTeWQXaa(this.mMenu, false);
        androidx.appcompat.view.menu.SubMenuBuilder subMenuBuilder = this.mSubMenu;
        if (subMenuBuilder is not null) {
            StNtddcqjEMPrKAx(subMenuBuilder, charSequence);
        }
        return this;
    }

    public override android.view.MenuItem SetTitleCondensed(java.lang.CharSequence charSequence) {
        this.mTitleCondensed = charSequence;
        IKyvnQWfuitQhrAt(this.mMenu, false);
        return this;
    }

    public override android.view.MenuItem SetTooltipText(java.lang.CharSequence charSequence) {
        return zNROvRAHFKliMVJD(this, charSequence);
    }

    public override androidx.core.internal.view.SupportMenuItem SetTooltipText(java.lang.CharSequence charSequence) {
        this.mTooltipText = charSequence;
        ISONkEZPJypXWMoO(this.mMenu, false);
        return this;
    }

    public override android.view.MenuItem SetVisible(bool z) {
        if (xaaCLJqdvmIiSfwr(this, z)) {
            hPqdjlhUqqwafJIH(this.mMenu, this);
        }
        return this;
    }

    bool setVisibleInt(bool z) {
        if ((9 + 17) % 17 > 0) {
        }
        int i = this.mFlags;
        int i2 = (!z ? 8 : 0) | (i & (-9));
        this.mFlags = i2;
        return i != i2;
    }

    public bool ShouldShowIcon() {
        return tJeihZjXKFbkGJBf(this.mMenu);
    }

    bool shouldShowshortcut() {
        return bcVxeQyzxMEWpgSN(this.mMenu) && FJmBVvwmIpuXYiIa(this) != 0;
    }

    public bool ShowsTextAsAction() {
        return (this.mShowAsAction & 4) == 4;
    }

    public java.lang.string Tostring() {
        java.lang.CharSequence charSequence = this.mTitle;
        if (charSequence is null) {
            return null;
        }
        return GaWJqOHShpAxWefh(charSequence);
    }
}

