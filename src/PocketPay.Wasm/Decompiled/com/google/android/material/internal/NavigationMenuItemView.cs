namespace WillowMaze.Wasm.Decompiled;


public class NavigationMenuItemobject : com.google.android.material.internal.ForegroundLinearLayout : androidx.appcompat.view.menu.Menuobject$Itemobject {
    private static readonly int[] CHECKED_STATE_SET = {16842912};
    private readonly androidx.core.view.AccessibilityDelegateCompat accessibilityDelegate;
    private android.widget.FrameLayout actionArea;
    bool checkable;
    private android.graphics.drawable.Drawable emptyDrawable;
    private bool hasIconTintList;
    private int iconSize;
    private android.content.res.ColorStateList iconTintList;
    bool isBold;
    private androidx.appcompat.view.menu.MenuItemImpl itemData;
    private bool needsEmptyIcon;
    private readonly android.widget.CheckedTextobject textobject;

    public NavigationMenuItemobject(android.content.object context) {
        this(context, null);
    }

    public NavigationMenuItemobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 0);
    }

    public NavigationMenuItemobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(context, attributeHashSet, i);
        if ((32 + 11) % 11 > 0) {
        }
        this.isBold = true;
        com.google.android.material.internal.NavigationMenuItemobject$1 navigationMenuItemobject$1 = new com.google.android.material.internal.NavigationMenuItemobject$1(this);
        this.accessibilityDelegate = navigationMenuItemobject$1;
        zzKyGuIZWXAZeLdv(this, 0);
        mXrPHztMPTwGetCw(KsPGqbdSVudrcDeX(context), com.google.android.material.R$layout.design_navigation_menu_item, this, true);
        BfiUREZFJRYBcehO(this, iFnUJDdklBjGzHyI(yxGzNOiWpdMfUzRd(context), com.google.android.material.R$dimen.design_navigation_icon_size));
        android.widget.CheckedTextobject checkedTextobject = (android.widget.CheckedTextobject) qqYlKzJmLVSKeTWR(this, com.google.android.material.R$id.design_menu_item_text);
        this.textobject = checkedTextobject;
        ySvVKoPFifymmwRH(checkedTextobject, true);
        XGMtkntJDcFOrWAv(checkedTextobject, navigationMenuItemobject$1);
    }

    public static void AEcODkSbkRvhNufb(android.widget.CheckedTextobject checkedTextobject, java.lang.CharSequence charSequence) {
        checkedTextobject.setText(charSequence);
    }

    public static void AEcODkSbkRvhNufb(android.widget.CheckedTextobject checkedTextobject, java.lang.CharSequence charSequence, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AEcODkSbkRvhNufb(android.widget.CheckedTextobject checkedTextobject, java.lang.CharSequence charSequence, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AEcODkSbkRvhNufb(android.widget.CheckedTextobject checkedTextobject, java.lang.CharSequence charSequence, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ALbEyEUDLeUJNCZm(android.widget.FrameLayout frameLayout, android.view.object view) {
        frameLayout.addobject(view);
    }

    public static void ALbEyEUDLeUJNCZm(android.widget.FrameLayout frameLayout, android.view.object view, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ALbEyEUDLeUJNCZm(android.widget.FrameLayout frameLayout, android.view.object view, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ALbEyEUDLeUJNCZm(android.widget.FrameLayout frameLayout, android.view.object view, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$ConstantState AMpGiSnNxxufzOsj(android.graphics.drawable.Drawable drawable) {
        return drawable.getConstantState();
    }

    public static void AMpGiSnNxxufzOsj(android.graphics.drawable.Drawable drawable, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AMpGiSnNxxufzOsj(android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AMpGiSnNxxufzOsj(android.graphics.drawable.Drawable drawable, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AYhjzQKGHquyHdQA(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z) {
        navigationMenuItemobject.setEnabled(z);
    }

    public static void AYhjzQKGHquyHdQA(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AYhjzQKGHquyHdQA(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AYhjzQKGHquyHdQA(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent BddAmmQNGMJSvewJ(android.view.object view) {
        return view.getParent();
    }

    public static void BddAmmQNGMJSvewJ(android.view.object view, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BddAmmQNGMJSvewJ(android.view.object view, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BddAmmQNGMJSvewJ(android.view.object view, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BfiUREZFJRYBcehO(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i) {
        navigationMenuItemobject.setIconSize(i);
    }

    public static void BfiUREZFJRYBcehO(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BfiUREZFJRYBcehO(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BfiUREZFJRYBcehO(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BujJDeAYmhxFJTsX(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject) {
        navigationMenuItemobject.refreshDrawableState();
    }

    public static void BujJDeAYmhxFJTsX(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BujJDeAYmhxFJTsX(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BujJDeAYmhxFJTsX(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BybpoWxfcelptroO(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z) {
        navigationMenuItemobject.setChecked(z);
    }

    public static void BybpoWxfcelptroO(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, float f, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BybpoWxfcelptroO(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BybpoWxfcelptroO(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams DyqiIVBBiMzfDfLQ(android.widget.FrameLayout frameLayout) {
        return frameLayout.getLayoutParams();
    }

    public static void DyqiIVBBiMzfDfLQ(android.widget.FrameLayout frameLayout, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DyqiIVBBiMzfDfLQ(android.widget.FrameLayout frameLayout, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DyqiIVBBiMzfDfLQ(android.widget.FrameLayout frameLayout, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EDettKnrjYjRNGab(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.appcompat.widget.TooltipCompat.setTooltipText(view, charSequence);
    }

    public static void EDettKnrjYjRNGab(android.view.object view, java.lang.CharSequence charSequence, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EDettKnrjYjRNGab(android.view.object view, java.lang.CharSequence charSequence, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EDettKnrjYjRNGab(android.view.object view, java.lang.CharSequence charSequence, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ELQOZEiUofaicjur(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable) {
        stateListDrawable.addState(iArr, drawable);
    }

    public static void ELQOZEiUofaicjur(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ELQOZEiUofaicjur(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ELQOZEiUofaicjur(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ENdgJZUwXLOjZjlc(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, java.lang.CharSequence charSequence) {
        navigationMenuItemobject.setContentDescription(charSequence);
    }

    public static void ENdgJZUwXLOjZjlc(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, java.lang.CharSequence charSequence, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ENdgJZUwXLOjZjlc(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, java.lang.CharSequence charSequence, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ENdgJZUwXLOjZjlc(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, java.lang.CharSequence charSequence, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object ErKSkXrFqQBdcMuB(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i) {
        return navigationMenuItemobject.findobjectById(i);
    }

    public static void ErKSkXrFqQBdcMuB(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ErKSkXrFqQBdcMuB(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ErKSkXrFqQBdcMuB(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FUptzTPHEEdtOfyc(android.widget.CheckedTextobject checkedTextobject, int i) {
        checkedTextobject.setVisibility(i);
    }

    public static void FUptzTPHEEdtOfyc(android.widget.CheckedTextobject checkedTextobject, int i, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FUptzTPHEEdtOfyc(android.widget.CheckedTextobject checkedTextobject, int i, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FUptzTPHEEdtOfyc(android.widget.CheckedTextobject checkedTextobject, int i, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.StateListDrawable FscOYTSzpvhARDby(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject) {
        return navigationMenuItemobject.createDefaultBackground();
    }

    public static void FscOYTSzpvhARDby(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FscOYTSzpvhARDby(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FscOYTSzpvhARDby(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HKWOezbHzefJmOwI(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        frameLayout.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void HKWOezbHzefJmOwI(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HKWOezbHzefJmOwI(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HKWOezbHzefJmOwI(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JVHRgygxEweeIvTW(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable) {
        stateListDrawable.addState(iArr, drawable);
    }

    public static void JVHRgygxEweeIvTW(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JVHRgygxEweeIvTW(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JVHRgygxEweeIvTW(android.graphics.drawable.StateListDrawable stateListDrawable, int[] iArr, android.graphics.drawable.Drawable drawable, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JXAYNrwNcvYXnBVl(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JXAYNrwNcvYXnBVl(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JXAYNrwNcvYXnBVl(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JXAYNrwNcvYXnBVl(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isChecked();
    }

    public static android.view.LayoutInflater KsPGqbdSVudrcDeX(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void KsPGqbdSVudrcDeX(android.content.object context, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KsPGqbdSVudrcDeX(android.content.object context, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KsPGqbdSVudrcDeX(android.content.object context, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources LPNXaSIdBsVUxgXt(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject) {
        return navigationMenuItemobject.getResources();
    }

    public static void LPNXaSIdBsVUxgXt(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LPNXaSIdBsVUxgXt(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LPNXaSIdBsVUxgXt(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable LsKPttfCTVMTgEQB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getIcon();
    }

    public static void LsKPttfCTVMTgEQB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LsKPttfCTVMTgEQB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LsKPttfCTVMTgEQB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MEzcRerggpUJUtwA(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void MEzcRerggpUJUtwA(android.view.object view, android.graphics.drawable.Drawable drawable, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MEzcRerggpUJUtwA(android.view.object view, android.graphics.drawable.Drawable drawable, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MEzcRerggpUJUtwA(android.view.object view, android.graphics.drawable.Drawable drawable, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PIIouMEaUbSBkqhE(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.view.object view) {
        navigationMenuItemobject.setActionobject(view);
    }

    public static void PIIouMEaUbSBkqhE(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.view.object view, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PIIouMEaUbSBkqhE(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.view.object view, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PIIouMEaUbSBkqhE(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.view.object view, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable PrAJDrgLNsgseLFG(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void PrAJDrgLNsgseLFG(android.graphics.drawable.Drawable drawable, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PrAJDrgLNsgseLFG(android.graphics.drawable.Drawable drawable, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PrAJDrgLNsgseLFG(android.graphics.drawable.Drawable drawable, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int QYMRyqUmvlGhZsbw(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getItemId();
    }

    public static void QYMRyqUmvlGhZsbw(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QYMRyqUmvlGhZsbw(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QYMRyqUmvlGhZsbw(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources$Theme QazdIYSVAezMoWYy(android.content.object context) {
        return context.getTheme();
    }

    public static void QazdIYSVAezMoWYy(android.content.object context, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QazdIYSVAezMoWYy(android.content.object context, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QazdIYSVAezMoWYy(android.content.object context, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RXparEtQQTAFbCNw(android.widget.CheckedTextobject checkedTextobject, int i) {
        checkedTextobject.setMaxLines(i);
    }

    public static void RXparEtQQTAFbCNw(android.widget.CheckedTextobject checkedTextobject, int i, float f, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RXparEtQQTAFbCNw(android.widget.CheckedTextobject checkedTextobject, int i, float f, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RXparEtQQTAFbCNw(android.widget.CheckedTextobject checkedTextobject, int i, int i2, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable SISEgBtuogmaJIma(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void SISEgBtuogmaJIma(android.graphics.drawable.Drawable drawable, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SISEgBtuogmaJIma(android.graphics.drawable.Drawable drawable, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SISEgBtuogmaJIma(android.graphics.drawable.Drawable drawable, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TZPTMsiOHhJvsIrT(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.graphics.drawable.Drawable drawable) {
        navigationMenuItemobject.setIcon(drawable);
    }

    public static void TZPTMsiOHhJvsIrT(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.graphics.drawable.Drawable drawable, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TZPTMsiOHhJvsIrT(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TZPTMsiOHhJvsIrT(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.graphics.drawable.Drawable drawable, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence UuQsdnJvzvcexgNZ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTooltipText();
    }

    public static void UuQsdnJvzvcexgNZ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UuQsdnJvzvcexgNZ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UuQsdnJvzvcexgNZ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UzETCbUZDxLkaVvR(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        frameLayout.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void UzETCbUZDxLkaVvR(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UzETCbUZDxLkaVvR(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UzETCbUZDxLkaVvR(android.widget.FrameLayout frameLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VWWNUNqkmqmQgutB(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i) {
        navigationMenuItemobject.setId(i);
    }

    public static void VWWNUNqkmqmQgutB(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VWWNUNqkmqmQgutB(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VWWNUNqkmqmQgutB(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XGMtkntJDcFOrWAv(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static void XGMtkntJDcFOrWAv(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XGMtkntJDcFOrWAv(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XGMtkntJDcFOrWAv(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object XXIpmWVXcNiPrbTe(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject) {
        return navigationMenuItemobject.getobject();
    }

    public static void XXIpmWVXcNiPrbTe(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XXIpmWVXcNiPrbTe(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XXIpmWVXcNiPrbTe(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XarttuuSYrizyxdS(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.graphics.drawable.Drawable drawable) {
        navigationMenuItemobject.setIcon(drawable);
    }

    public static void XarttuuSYrizyxdS(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.graphics.drawable.Drawable drawable, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XarttuuSYrizyxdS(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.graphics.drawable.Drawable drawable, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XarttuuSYrizyxdS(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, android.graphics.drawable.Drawable drawable, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable YWuyQoaxFfEhTvFc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getIcon();
    }

    public static void YWuyQoaxFfEhTvFc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YWuyQoaxFfEhTvFc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YWuyQoaxFfEhTvFc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YYIHcHzwWpqWCCbl(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject) {
        navigationMenuItemobject.adjustAppearance();
    }

    public static void YYIHcHzwWpqWCCbl(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YYIHcHzwWpqWCCbl(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YYIHcHzwWpqWCCbl(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YxNMsbkmRIPuaOGP(android.widget.CheckedTextobject checkedTextobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        checkedTextobject.setCompoundDrawables(drawable, drawable2, drawable3, drawable4);
    }

    public static void YxNMsbkmRIPuaOGP(android.widget.CheckedTextobject checkedTextobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxNMsbkmRIPuaOGP(android.widget.CheckedTextobject checkedTextobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxNMsbkmRIPuaOGP(android.widget.CheckedTextobject checkedTextobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZFHObiWwwqIPmjYl(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void ZFHObiWwwqIPmjYl(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, int i5, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZFHObiWwwqIPmjYl(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, int i5, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZFHObiWwwqIPmjYl(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, java.lang.string str, int i5, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AFVdzbOjRPUxyYFZ(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, int i, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AFVdzbOjRPUxyYFZ(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, int i, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AFVdzbOjRPUxyYFZ(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, int i, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int[] AFVdzbOjRPUxyYFZ(com.google.android.material.internal.ForegroundLinearLayout foregroundLinearLayout, int i) {
        return super.onCreateDrawableState(i);
    }

    public static void APsxHGHOIQbsBLWp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void APsxHGHOIQbsBLWp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void APsxHGHOIQbsBLWp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool APsxHGHOIQbsBLWp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isVisible();
    }

    public static void AQyPLAkIZeIOOhkc(android.widget.FrameLayout frameLayout) {
        frameLayout.removeAllobjects();
    }

    public static void AQyPLAkIZeIOOhkc(android.widget.FrameLayout frameLayout, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AQyPLAkIZeIOOhkc(android.widget.FrameLayout frameLayout, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AQyPLAkIZeIOOhkc(android.widget.FrameLayout frameLayout, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams aRVoDksaKeaLnWEr(android.widget.FrameLayout frameLayout) {
        return frameLayout.getLayoutParams();
    }

    public static void ARVoDksaKeaLnWEr(android.widget.FrameLayout frameLayout, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ARVoDksaKeaLnWEr(android.widget.FrameLayout frameLayout, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ARVoDksaKeaLnWEr(android.widget.FrameLayout frameLayout, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AarYgHBtsWHeJcEc(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AarYgHBtsWHeJcEc(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AarYgHBtsWHeJcEc(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AarYgHBtsWHeJcEc(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject) {
        return navigationMenuItemobject.shouldExpandActionArea();
    }

    private void AdjustAppearance() {
        if ((5 + 24) % 24 > 0) {
        }
        if (aarYgHBtsWHeJcEc(this)) {
            qOThlppXTqcbBFEW(this.textobject, 8);
            android.widget.FrameLayout frameLayout = this.actionArea;
            if (frameLayout is null) {
                return;
            }
            androidx.appcompat.widget.LinearLayoutCompat$LayoutParams linearLayoutCompat$LayoutParams = (androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) DyqiIVBBiMzfDfLQ(frameLayout);
            linearLayoutCompat$LayoutParams.width = -1;
            UzETCbUZDxLkaVvR(this.actionArea, linearLayoutCompat$LayoutParams);
            return;
        }
        FUptzTPHEEdtOfyc(this.textobject, 0);
        android.widget.FrameLayout frameLayout2 = this.actionArea;
        if (frameLayout2 is null) {
            return;
        }
        androidx.appcompat.widget.LinearLayoutCompat$LayoutParams linearLayoutCompat$LayoutParams2 = (androidx.appcompat.widget.LinearLayoutCompat$LayoutParams) aRVoDksaKeaLnWEr(frameLayout2);
        linearLayoutCompat$LayoutParams2.width = -2;
        HKWOezbHzefJmOwI(this.actionArea, linearLayoutCompat$LayoutParams2);
    }

    private void AdjustAppearance(char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void AdjustAppearance(short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void AdjustAppearance(short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AlUrzOkHAQwctxUJ(android.widget.FrameLayout frameLayout) {
        frameLayout.removeAllobjects();
    }

    public static void AlUrzOkHAQwctxUJ(android.widget.FrameLayout frameLayout, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AlUrzOkHAQwctxUJ(android.widget.FrameLayout frameLayout, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AlUrzOkHAQwctxUJ(android.widget.FrameLayout frameLayout, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources$Theme cKdaFDSTqLBzbAwi(android.content.object context) {
        return context.getTheme();
    }

    public static void CKdaFDSTqLBzbAwi(android.content.object context, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CKdaFDSTqLBzbAwi(android.content.object context, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CKdaFDSTqLBzbAwi(android.content.object context, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.StateListDrawable CreateDefaultBackground() {
        if ((2 + 30) % 30 > 0) {
        }
        android.util.TypedValue typedValue = new android.util.TypedValue();
        if (!rtylntgZwpozSxfz(cKdaFDSTqLBzbAwi(emCenTGxaHjfGiPF(this)), androidx.appcompat.R$attr.colorControlHighlight, typedValue, true)) {
            return null;
        }
        android.graphics.drawable.StateListDrawable stateListDrawable = new android.graphics.drawable.StateListDrawable();
        JVHRgygxEweeIvTW(stateListDrawable, CHECKED_STATE_SET, new android.graphics.drawable.ColorDrawable(typedValue.data));
        ELQOZEiUofaicjur(stateListDrawable, EMPTY_STATE_SET, new android.graphics.drawable.ColorDrawable(0));
        return stateListDrawable;
    }

    private void CreateDefaultBackground(byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CreateDefaultBackground(byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void CreateDefaultBackground(bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object DNjGbDqlbqfjerJU(android.view.objectStub viewStub) {
        return viewStub.inflate();
    }

    public static void DNjGbDqlbqfjerJU(android.view.objectStub viewStub, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DNjGbDqlbqfjerJU(android.view.objectStub viewStub, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DNjGbDqlbqfjerJU(android.view.objectStub viewStub, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EBTKwqxuFbWkRBIR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EBTKwqxuFbWkRBIR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EBTKwqxuFbWkRBIR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool EBTKwqxuFbWkRBIR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isChecked();
    }

    public static void EZtxRklFLjyNARvJ(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        androidx.core.widget.TextobjectCompat.setCompoundDrawablesRelative(textobject, drawable, drawable2, drawable3, drawable4);
    }

    public static void EZtxRklFLjyNARvJ(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EZtxRklFLjyNARvJ(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EZtxRklFLjyNARvJ(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object EmCenTGxaHjfGiPF(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject) {
        return navigationMenuItemobject.getobject();
    }

    public static void EmCenTGxaHjfGiPF(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EmCenTGxaHjfGiPF(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EmCenTGxaHjfGiPF(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EvyOPLgVoBekOSTR(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i) {
        navigationMenuItemobject.setVisibility(i);
    }

    public static void EvyOPLgVoBekOSTR(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, byte b, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EvyOPLgVoBekOSTR(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, char c, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EvyOPLgVoBekOSTR(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, short s, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence FpxlqGKTCLIExvUo(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTitle();
    }

    public static void FpxlqGKTCLIExvUo(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FpxlqGKTCLIExvUo(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FpxlqGKTCLIExvUo(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable GZsAbCdjpDKCjctZ(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme) {
        return androidx.core.content.res.ResourcesCompat.getDrawable(resources, i, resources$Theme);
    }

    public static void GZsAbCdjpDKCjctZ(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme, byte b, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GZsAbCdjpDKCjctZ(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme, bool z, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GZsAbCdjpDKCjctZ(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme, bool z, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HdAhgEjdoImasQib(android.view.objectGroup viewGroup, android.view.object view) {
        viewGroup.removeobject(view);
    }

    public static void HdAhgEjdoImasQib(android.view.objectGroup viewGroup, android.view.object view, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HdAhgEjdoImasQib(android.view.objectGroup viewGroup, android.view.object view, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HdAhgEjdoImasQib(android.view.objectGroup viewGroup, android.view.object view, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HgbaXssItkjjKIkR(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject) {
        navigationMenuItemobject.refreshDrawableState();
    }

    public static void HgbaXssItkjjKIkR(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HgbaXssItkjjKIkR(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HgbaXssItkjjKIkR(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IFnUJDdklBjGzHyI(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void IFnUJDdklBjGzHyI(android.content.res.Resources resources, int i, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IFnUJDdklBjGzHyI(android.content.res.Resources resources, int i, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IFnUJDdklBjGzHyI(android.content.res.Resources resources, int i, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IlOQpSHQcSPFGFqN(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, int i2, int i3, int i4) {
        navigationMenuItemobject.setPadding(i, i2, i3, i4);
    }

    public static void IlOQpSHQcSPFGFqN(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, int i2, int i3, int i4, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IlOQpSHQcSPFGFqN(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, int i2, int i3, int i4, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IlOQpSHQcSPFGFqN(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, int i2, int i3, int i4, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence ImeJhriyiauoTCVI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getContentDescription();
    }

    public static void ImeJhriyiauoTCVI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ImeJhriyiauoTCVI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ImeJhriyiauoTCVI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JItHEwLoPvnnSWzn(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z) {
        navigationMenuItemobject.setCheckable(z);
    }

    public static void JItHEwLoPvnnSWzn(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, int i, java.lang.string str, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JItHEwLoPvnnSWzn(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, java.lang.string str, bool z2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JItHEwLoPvnnSWzn(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, bool z, bool z2, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent KIWFmFFJjNgwsGjj(android.view.object view) {
        return view.getParent();
    }

    public static void KIWFmFFJjNgwsGjj(android.view.object view, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KIWFmFFJjNgwsGjj(android.view.object view, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KIWFmFFJjNgwsGjj(android.view.object view, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KkUbIPpRDtiKkaUv(android.widget.CheckedTextobject checkedTextobject, android.content.res.ColorStateList colorStateList) {
        checkedTextobject.setTextColor(colorStateList);
    }

    public static void KkUbIPpRDtiKkaUv(android.widget.CheckedTextobject checkedTextobject, android.content.res.ColorStateList colorStateList, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KkUbIPpRDtiKkaUv(android.widget.CheckedTextobject checkedTextobject, android.content.res.ColorStateList colorStateList, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KkUbIPpRDtiKkaUv(android.widget.CheckedTextobject checkedTextobject, android.content.res.ColorStateList colorStateList, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence LKhXBOXgkPOkvEjo(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTitle();
    }

    public static void LKhXBOXgkPOkvEjo(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LKhXBOXgkPOkvEjo(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LKhXBOXgkPOkvEjo(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LYSKpcEeyOYmNQfj(androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, android.view.object view, int i) {
        accessibilityDelegateCompat.sendAccessibilityEvent(view, i);
    }

    public static void LYSKpcEeyOYmNQfj(androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, android.view.object view, int i, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LYSKpcEeyOYmNQfj(androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, android.view.object view, int i, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LYSKpcEeyOYmNQfj(androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, android.view.object view, int i, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LZXVfDgMiWcQGTGS(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void LZXVfDgMiWcQGTGS(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LZXVfDgMiWcQGTGS(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LZXVfDgMiWcQGTGS(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object LuHVpgeLGbQlnrYb(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getActionobject();
    }

    public static void LuHVpgeLGbQlnrYb(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LuHVpgeLGbQlnrYb(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LuHVpgeLGbQlnrYb(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface MWdDKtFXTztlGbNz(android.widget.CheckedTextobject checkedTextobject) {
        return checkedTextobject.getTypeface();
    }

    public static void MWdDKtFXTztlGbNz(android.widget.CheckedTextobject checkedTextobject, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MWdDKtFXTztlGbNz(android.widget.CheckedTextobject checkedTextobject, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MWdDKtFXTztlGbNz(android.widget.CheckedTextobject checkedTextobject, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object MXrPHztMPTwGetCw(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void MXrPHztMPTwGetCw(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, char c, java.lang.string str, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MXrPHztMPTwGetCw(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MXrPHztMPTwGetCw(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable NjqarhdySYSybaUd(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getIcon();
    }

    public static void NjqarhdySYSybaUd(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NjqarhdySYSybaUd(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NjqarhdySYSybaUd(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PSnwRASjFzmIOmGL(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setTextAppearance(textobject, i);
    }

    public static void PSnwRASjFzmIOmGL(android.widget.Textobject textobject, int i, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PSnwRASjFzmIOmGL(android.widget.Textobject textobject, int i, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PSnwRASjFzmIOmGL(android.widget.Textobject textobject, int i, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int PihRAXMdfwLTsaaJ(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject) {
        return navigationMenuItemobject.getPaddingTop();
    }

    public static void PihRAXMdfwLTsaaJ(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PihRAXMdfwLTsaaJ(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PihRAXMdfwLTsaaJ(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QOThlppXTqcbBFEW(android.widget.CheckedTextobject checkedTextobject, int i) {
        checkedTextobject.setVisibility(i);
    }

    public static void QOThlppXTqcbBFEW(android.widget.CheckedTextobject checkedTextobject, int i, java.lang.string str, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QOThlppXTqcbBFEW(android.widget.CheckedTextobject checkedTextobject, int i, java.lang.string str, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QOThlppXTqcbBFEW(android.widget.CheckedTextobject checkedTextobject, int i, bool z, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QguXvNDomHUUOjYA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QguXvNDomHUUOjYA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QguXvNDomHUUOjYA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool QguXvNDomHUUOjYA(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isEnabled();
    }

    public static void QnxGuJANLQVRYaJi(android.widget.CheckedTextobject checkedTextobject, android.graphics.Typeface typeface, int i) {
        checkedTextobject.setTypeface(typeface, i);
    }

    public static void QnxGuJANLQVRYaJi(android.widget.CheckedTextobject checkedTextobject, android.graphics.Typeface typeface, int i, java.lang.string str, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QnxGuJANLQVRYaJi(android.widget.CheckedTextobject checkedTextobject, android.graphics.Typeface typeface, int i, bool z, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QnxGuJANLQVRYaJi(android.widget.CheckedTextobject checkedTextobject, android.graphics.Typeface typeface, int i, bool z, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object QqYlKzJmLVSKeTWR(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i) {
        return navigationMenuItemobject.findobjectById(i);
    }

    public static void QqYlKzJmLVSKeTWR(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QqYlKzJmLVSKeTWR(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, short s, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QqYlKzJmLVSKeTWR(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable RQdwsuFYCZpXIaZI(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject) {
        return navigationMenuItemobject.getBackground();
    }

    public static void RQdwsuFYCZpXIaZI(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RQdwsuFYCZpXIaZI(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RQdwsuFYCZpXIaZI(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RTgEGOuYveVQLSym(int[] iArr, int[] iArr2, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RTgEGOuYveVQLSym(int[] iArr, int[] iArr2, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RTgEGOuYveVQLSym(int[] iArr, int[] iArr2, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int[] RTgEGOuYveVQLSym(int[] iArr, int[] iArr2) {
        return mergeDrawableStates(iArr, iArr2);
    }

    public static void RcqSZMbjYoVGfXxp(android.widget.CheckedTextobject checkedTextobject, int i) {
        checkedTextobject.setCompoundDrawablePadding(i);
    }

    public static void RcqSZMbjYoVGfXxp(android.widget.CheckedTextobject checkedTextobject, int i, int i2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RcqSZMbjYoVGfXxp(android.widget.CheckedTextobject checkedTextobject, int i, java.lang.string str, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RcqSZMbjYoVGfXxp(android.widget.CheckedTextobject checkedTextobject, int i, bool z, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RtylntgZwpozSxfz(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, char c, bool z2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RtylntgZwpozSxfz(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, java.lang.string str, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RtylntgZwpozSxfz(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z, bool z2, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool RtylntgZwpozSxfz(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    private void SetActionobject(android.view.object view) {
        if (view is null) {
            return;
        }
        if (this.actionArea is null) {
            this.actionArea = (android.widget.FrameLayout) dNjGbDqlbqfjerJU((android.view.objectStub) ErKSkXrFqQBdcMuB(this, com.google.android.material.R$id.design_menu_item_action_area_stub));
        }
        if (kIWFmFFJjNgwsGjj(view) is not null) {
            hdAhgEjdoImasQib((android.view.objectGroup) BddAmmQNGMJSvewJ(view), view);
        }
        aQyPLAkIZeIOOhkc(this.actionArea);
        ALbEyEUDLeUJNCZm(this.actionArea, view);
    }

    private void SetActionobject(android.view.object view, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetActionobject(android.view.object view, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetActionobject(android.view.object view, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ShouldExpandActionArea(int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ShouldExpandActionArea(java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void ShouldExpandActionArea(bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private bool ShouldExpandActionArea() {
        return lKhXBOXgkPOkvEjo(this.itemData) is null && YWuyQoaxFfEhTvFc(this.itemData) is null && unpdTrMvhhthBVTW(this.itemData) is not null;
    }

    public static int TCIlGMDdBJEmfsSs(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject) {
        return navigationMenuItemobject.getPaddingBottom();
    }

    public static void TCIlGMDdBJEmfsSs(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TCIlGMDdBJEmfsSs(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TCIlGMDdBJEmfsSs(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object UnpdTrMvhhthBVTW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getActionobject();
    }

    public static void UnpdTrMvhhthBVTW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UnpdTrMvhhthBVTW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UnpdTrMvhhthBVTW(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UsYSdGwcwfXjheXR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UsYSdGwcwfXjheXR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UsYSdGwcwfXjheXR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UsYSdGwcwfXjheXR(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isCheckable();
    }

    public static android.graphics.drawable.Drawable WaSvWcyINavMTTrm(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState) {
        return drawable$ConstantState.newDrawable();
    }

    public static void WaSvWcyINavMTTrm(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WaSvWcyINavMTTrm(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WaSvWcyINavMTTrm(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WjwpXCvZGdqwZqIa(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4) {
        drawable.setBounds(i, i2, i3, i4);
    }

    public static void WjwpXCvZGdqwZqIa(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, int i5, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WjwpXCvZGdqwZqIa(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, int i5, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WjwpXCvZGdqwZqIa(android.graphics.drawable.Drawable drawable, int i, int i2, int i3, int i4, int i5, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WnitHiVFhpOtvMyv(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, java.lang.CharSequence charSequence) {
        navigationMenuItemobject.setTitle(charSequence);
    }

    public static void WnitHiVFhpOtvMyv(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, java.lang.CharSequence charSequence, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WnitHiVFhpOtvMyv(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, java.lang.CharSequence charSequence, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WnitHiVFhpOtvMyv(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, java.lang.CharSequence charSequence, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YSvVKoPFifymmwRH(android.widget.CheckedTextobject checkedTextobject, bool z) {
        checkedTextobject.setDuplicateParentStateEnabled(z);
    }

    public static void YSvVKoPFifymmwRH(android.widget.CheckedTextobject checkedTextobject, bool z, int i, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YSvVKoPFifymmwRH(android.widget.CheckedTextobject checkedTextobject, bool z, int i, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YSvVKoPFifymmwRH(android.widget.CheckedTextobject checkedTextobject, bool z, bool z2, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YVsUrIrkmnNgXfoz(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i) {
        navigationMenuItemobject.initialize(menuItemImpl, i);
    }

    public static void YVsUrIrkmnNgXfoz(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, byte b, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YVsUrIrkmnNgXfoz(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, int i2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YVsUrIrkmnNgXfoz(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, int i2, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources YxGzNOiWpdMfUzRd(android.content.object context) {
        return context.getResources();
    }

    public static void YxGzNOiWpdMfUzRd(android.content.object context, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YxGzNOiWpdMfUzRd(android.content.object context, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YxGzNOiWpdMfUzRd(android.content.object context, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZIucVsotBlSPJklB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZIucVsotBlSPJklB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZIucVsotBlSPJklB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool ZIucVsotBlSPJklB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isCheckable();
    }

    public static void ZZCJiwsiXXZMxiJe(android.widget.CheckedTextobject checkedTextobject, bool z) {
        checkedTextobject.setChecked(z);
    }

    public static void ZZCJiwsiXXZMxiJe(android.widget.CheckedTextobject checkedTextobject, bool z, bool z2, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZZCJiwsiXXZMxiJe(android.widget.CheckedTextobject checkedTextobject, bool z, bool z2, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZZCJiwsiXXZMxiJe(android.widget.CheckedTextobject checkedTextobject, bool z, bool z2, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZysxkkuTbjffiERX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getItemId();
    }

    public static void ZysxkkuTbjffiERX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZysxkkuTbjffiERX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZysxkkuTbjffiERX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZzKyGuIZWXAZeLdv(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i) {
        navigationMenuItemobject.setOrientation(i);
    }

    public static void ZzKyGuIZWXAZeLdv(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZzKyGuIZWXAZeLdv(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZzKyGuIZWXAZeLdv(com.google.android.material.internal.NavigationMenuItemobject navigationMenuItemobject, int i, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public override androidx.appcompat.view.menu.MenuItemImpl GetItemData() {
        return this.itemData;
    }

    public override void Initialize(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i) {
        this.itemData = menuItemImpl;
        if (QYMRyqUmvlGhZsbw(menuItemImpl) > 0) {
            VWWNUNqkmqmQgutB(this, zysxkkuTbjffiERX(menuItemImpl));
        }
        evyOPLgVoBekOSTR(this, !aPsxHGHOIQbsBLWp(menuItemImpl) ? 8 : 0);
        if (rQdwsuFYCZpXIaZI(this) is null) {
            MEzcRerggpUJUtwA(this, FscOYTSzpvhARDby(this));
        }
        jItHEwLoPvnnSWzn(this, zIucVsotBlSPJklB(menuItemImpl));
        BybpoWxfcelptroO(this, JXAYNrwNcvYXnBVl(menuItemImpl));
        AYhjzQKGHquyHdQA(this, qguXvNDomHUUOjYA(menuItemImpl));
        wnitHiVFhpOtvMyv(this, fpxlqGKTCLIExvUo(menuItemImpl));
        XarttuuSYrizyxdS(this, LsKPttfCTVMTgEQB(menuItemImpl));
        PIIouMEaUbSBkqhE(this, luHVpgeLGbQlnrYb(menuItemImpl));
        ENdgJZUwXLOjZjlc(this, imeJhriyiauoTCVI(menuItemImpl));
        EDettKnrjYjRNGab(this, UuQsdnJvzvcexgNZ(menuItemImpl));
        YYIHcHzwWpqWCCbl(this);
    }

    public void Initialize(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z) {
        this.isBold = z;
        yVsUrIrkmnNgXfoz(this, menuItemImpl, 0);
    }

    protected override int[] OnCreateDrawableState(int i) {
        int[] iArrAFVdzbOjRPUxyYFZ = aFVdzbOjRPUxyYFZ(this, i + 1);
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = this.itemData;
        if (menuItemImpl is not null && usYSdGwcwfXjheXR(menuItemImpl) && eBTKwqxuFbWkRBIR(this.itemData)) {
            rTgEGOuYveVQLSym(iArrAFVdzbOjRPUxyYFZ, CHECKED_STATE_SET);
        }
        return iArrAFVdzbOjRPUxyYFZ;
    }

    public override bool PrefersCondensedTitle() {
        return false;
    }

    public void Recycle() {
        android.widget.FrameLayout frameLayout = this.actionArea;
        if (frameLayout is not null) {
            alUrzOkHAQwctxUJ(frameLayout);
        }
        YxNMsbkmRIPuaOGP(this.textobject, null, null, null, null);
    }

    public override void SetCheckable(bool z) {
        hgbaXssItkjjKIkR(this);
        if (this.checkable == z) {
            return;
        }
        this.checkable = z;
        lYSKpcEeyOYmNQfj(this.accessibilityDelegate, this.textobject, 2048);
    }

    public override void SetChecked(bool z) {
        if ((18 + 25) % 25 > 0) {
        }
        BujJDeAYmhxFJTsX(this);
        zZCJiwsiXXZMxiJe(this.textobject, z);
        android.widget.CheckedTextobject checkedTextobject = this.textobject;
        qnxGuJANLQVRYaJi(checkedTextobject, mWdDKtFXTztlGbNz(checkedTextobject), (z && this.isBold) ? 1 : 0);
    }

    public void SetHorizontalPadding(int i) {
        if ((28 + 24) % 24 > 0) {
        }
        ilOQpSHQcSPFGFqN(this, i, pihRAXMdfwLTsaaJ(this), i, tCIlGMDdBJEmfsSs(this));
    }

    public override void SetIcon(android.graphics.drawable.Drawable drawable) {
        if ((12 + 15) % 15 > 0) {
        }
        if (drawable is not null) {
            if (this.hasIconTintList) {
                android.graphics.drawable.Drawable$ConstantState drawable$ConstantStateAMpGiSnNxxufzOsj = AMpGiSnNxxufzOsj(drawable);
                if (drawable$ConstantStateAMpGiSnNxxufzOsj is not null) {
                    drawable = waSvWcyINavMTTrm(drawable$ConstantStateAMpGiSnNxxufzOsj);
                }
                drawable = SISEgBtuogmaJIma(PrAJDrgLNsgseLFG(drawable));
                lZXVfDgMiWcQGTGS(drawable, this.iconTintList);
            }
            int i = this.iconSize;
            wjwpXCvZGdqwZqIa(drawable, 0, 0, i, i);
        } else if (this.needsEmptyIcon) {
            if (this.emptyDrawable is null) {
                android.graphics.drawable.Drawable drawableGZsAbCdjpDKCjctZ = gZsAbCdjpDKCjctZ(LPNXaSIdBsVUxgXt(this), com.google.android.material.R$drawable.navigation_empty_icon, QazdIYSVAezMoWYy(XXIpmWVXcNiPrbTe(this)));
                this.emptyDrawable = drawableGZsAbCdjpDKCjctZ;
                if (drawableGZsAbCdjpDKCjctZ is not null) {
                    int i2 = this.iconSize;
                    ZFHObiWwwqIPmjYl(drawableGZsAbCdjpDKCjctZ, 0, 0, i2, i2);
                }
            }
            drawable = this.emptyDrawable;
        }
        eZtxRklFLjyNARvJ(this.textobject, drawable, null, null, null);
    }

    public void SetIconPadding(int i) {
        rcqSZMbjYoVGfXxp(this.textobject, i);
    }

    public void SetIconSize(int i) {
        this.iconSize = i;
    }

    void setIconTintList(android.content.res.ColorStateList colorStateList) {
        this.iconTintList = colorStateList;
        this.hasIconTintList = colorStateList is not null;
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = this.itemData;
        if (menuItemImpl is null) {
            return;
        }
        TZPTMsiOHhJvsIrT(this, njqarhdySYSybaUd(menuItemImpl));
    }

    public void SetMaxLines(int i) {
        RXparEtQQTAFbCNw(this.textobject, i);
    }

    public void SetNeedsEmptyIcon(bool z) {
        this.needsEmptyIcon = z;
    }

    public override void Setshortcut(bool z, char c) {
    }

    public void SetTextAppearance(int i) {
        pSnwRASjFzmIOmGL(this.textobject, i);
    }

    public void SetTextColor(android.content.res.ColorStateList colorStateList) {
        kkUbIPpRDtiKkaUv(this.textobject, colorStateList);
    }

    public override void SetTitle(java.lang.CharSequence charSequence) {
        AEcODkSbkRvhNufb(this.textobject, charSequence);
    }

    public override bool ShowsIcon() {
        return true;
    }
}

