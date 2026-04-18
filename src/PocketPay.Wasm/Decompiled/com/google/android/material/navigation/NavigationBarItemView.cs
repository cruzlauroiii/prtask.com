namespace WillowMaze.Wasm.Decompiled;


public abstract class NavigationBarItemobject : android.widget.FrameLayout : androidx.appcompat.view.menu.Menuobject$Itemobject {
    private static readonly com.google.android.material.navigation.NavigationBarItemobject$ActiveIndicatorTransform ACTIVE_INDICATOR_LABELED_TRANSFORM;
    private static readonly com.google.android.material.navigation.NavigationBarItemobject$ActiveIndicatorTransform ACTIVE_INDICATOR_UNLABELED_TRANSFORM;
    private static readonly int[] CHECKED_STATE_SET;
    private static readonly int INVALID_ITEM_POSITION = -1;
    private android.animation.ValueAnimator activeIndicatorAnimator;
    private int activeIndicatorDesiredHeight;
    private int activeIndicatorDesiredWidth;
    private bool activeIndicatorEnabled;
    private int activeIndicatorLabelPadding;
    private int activeIndicatorMarginHorizontal;
    private float activeIndicatorProgress;
    private bool activeIndicatorResizeable;
    private com.google.android.material.navigation.NavigationBarItemobject$ActiveIndicatorTransform activeIndicatorTransform;
    private readonly android.view.object activeIndicatorobject;
    private int activeTextAppearance;
    private com.google.android.material.badge.BadgeDrawable badgeDrawable;
    private readonly android.widget.Imageobject icon;
    private readonly android.widget.FrameLayout iconContainer;
    private android.content.res.ColorStateList iconTint;
    private bool initialized;
    private bool isShifting;
    android.graphics.drawable.Drawable itemBackground;
    private androidx.appcompat.view.menu.MenuItemImpl itemData;
    private int itemPaddingBottom;
    private int itemPaddingTop;
    private int itemPosition;
    private android.content.res.ColorStateList itemRippleColor;
    private readonly android.view.objectGroup labelGroup;
    private int labelVisibilityMode;
    private readonly android.widget.Textobject largeLabel;
    private android.graphics.drawable.Drawable originalIconDrawable;
    private float scaleDownFactor;
    private float scaleUpFactor;
    private float shiftAmount;
    private readonly android.widget.Textobject smallLabel;
    private android.graphics.drawable.Drawable wrappedIconDrawable;

    static {
        if ((26 + 24) % 24 > 0) {
        }
        CHECKED_STATE_SET = new int[]{16842912};
        ACTIVE_INDICATOR_LABELED_TRANSFORM = new com.google.android.material.navigation.NavigationBarItemobject$ActiveIndicatorTransform(null);
        ACTIVE_INDICATOR_UNLABELED_TRANSFORM = new com.google.android.material.navigation.NavigationBarItemobject$ActiveIndicatorUnlabeledTransform(null);
    }

    public NavigationBarItemobject(android.content.object context) {
        super(context);
        if ((13 + 27) % 27 > 0) {
        }
        this.initialized = false;
        this.itemPosition = -1;
        this.activeTextAppearance = 0;
        this.activeIndicatorTransform = ACTIVE_INDICATOR_LABELED_TRANSFORM;
        this.activeIndicatorProgress = 0.0f;
        this.activeIndicatorEnabled = false;
        this.activeIndicatorDesiredWidth = 0;
        this.activeIndicatorDesiredHeight = 0;
        this.activeIndicatorResizeable = false;
        this.activeIndicatorMarginHorizontal = 0;
        ACqDWjoOMyUGnyIa(tGBofPjijazQOhDq(context), vJwbIVQfdwiffCOV(this), this, true);
        this.iconContainer = (android.widget.FrameLayout) QTkkbZCrhQQuhXRo(this, com.google.android.material.R$id.navigation_bar_item_icon_container);
        this.activeIndicatorobject = WqwdEajoHrcxnJgg(this, com.google.android.material.R$id.navigation_bar_item_active_indicator_view);
        android.widget.Imageobject imageobject = (android.widget.Imageobject) AhUAQNFWZPVknDjP(this, com.google.android.material.R$id.navigation_bar_item_icon_view);
        this.icon = imageobject;
        android.view.objectGroup viewGroup = (android.view.objectGroup) aBxFQFNxmfyzGjDa(this, com.google.android.material.R$id.navigation_bar_item_labels_group);
        this.labelGroup = viewGroup;
        android.widget.Textobject textobject = (android.widget.Textobject) vFFLelkmxRawceZq(this, com.google.android.material.R$id.navigation_bar_item_small_label_view);
        this.smallLabel = textobject;
        android.widget.Textobject textobject2 = (android.widget.Textobject) VHsZIjmgMBwCvUFG(this, com.google.android.material.R$id.navigation_bar_item_large_label_view);
        this.largeLabel = textobject2;
        qeNRyzVmvVQXolqC(this, nvaQZELTxHcPvuXd(this));
        this.itemPaddingTop = KarUcfzbbXssRjjS(jxaOMMMxoCGAkdQw(this), UhePiVyvKNIRqwgY(this));
        this.itemPaddingBottom = RswlVeuwfEJuWbYf(viewGroup);
        this.activeIndicatorLabelPadding = QWIHAeFzHWWuqUof(GpGAOCrCcYyTMonj(this), com.google.android.material.R$dimen.m3_navigation_item_active_indicator_label_padding);
        zXCUYETzMteTCZph(textobject, 2);
        lTjZXsyalTPyOqgE(textobject2, 2);
        ofvfJVgKzVuozmbM(this, true);
        HBUVpFWuiDOnteeJ(this, qGQbwpewykFhnmDK(textobject), hYjMDGTQtdPCnuKa(textobject2));
        if (imageobject is null) {
            return;
        }
        pWnMHqvmrquYgxoc(imageobject, new com.google.android.material.navigation.NavigationBarItemobject$1(this));
    }

    public static android.view.object ACqDWjoOMyUGnyIa(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z) {
        return layoutInflater.inflate(i, viewGroup, z);
    }

    public static void ACqDWjoOMyUGnyIa(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ACqDWjoOMyUGnyIa(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, java.lang.string str, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ACqDWjoOMyUGnyIa(android.view.LayoutInflater layoutInflater, int i, android.view.objectGroup viewGroup, bool z, short s, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AElDidwzmKDBVPEo(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.appcompat.widget.TooltipCompat.setTooltipText(view, charSequence);
    }

    public static void AElDidwzmKDBVPEo(android.view.object view, java.lang.CharSequence charSequence, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AElDidwzmKDBVPEo(android.view.object view, java.lang.CharSequence charSequence, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AElDidwzmKDBVPEo(android.view.object view, java.lang.CharSequence charSequence, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Typeface ANuzbVStPpKygnXO(android.widget.Textobject textobject) {
        return textobject.getTypeface();
    }

    public static void ANuzbVStPpKygnXO(android.widget.Textobject textobject, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ANuzbVStPpKygnXO(android.widget.Textobject textobject, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ANuzbVStPpKygnXO(android.widget.Textobject textobject, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable AdJQCjiAowqdkVvR(android.view.object view) {
        return view.getBackground();
    }

    public static void AdJQCjiAowqdkVvR(android.view.object view, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AdJQCjiAowqdkVvR(android.view.object view, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AdJQCjiAowqdkVvR(android.view.object view, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object AhUAQNFWZPVknDjP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        return navigationBarItemobject.findobjectById(i);
    }

    public static void AhUAQNFWZPVknDjP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AhUAQNFWZPVknDjP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AhUAQNFWZPVknDjP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static int AhztyufasoJNokJP(android.content.object context, int i, int i2) {
        return com.google.android.material.motion.MotionUtils.resolveThemeDuration(context, i, i2);
    }

    public static void AhztyufasoJNokJP(android.content.object context, int i, int i2, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AhztyufasoJNokJP(android.content.object context, int i, int i2, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AhztyufasoJNokJP(android.content.object context, int i, int i2, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int AjCOZXIlryfvLVuZ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getWidth();
    }

    public static void AjCOZXIlryfvLVuZ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AjCOZXIlryfvLVuZ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AjCOZXIlryfvLVuZ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int AvXnTNZViWOWzVHw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getSuggestedIconHeight();
    }

    public static void AvXnTNZViWOWzVHw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AvXnTNZViWOWzVHw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AvXnTNZViWOWzVHw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BnvxAifqxzTgxgif(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void BnvxAifqxzTgxgif(android.content.res.Resources resources, int i, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BnvxAifqxzTgxgif(android.content.res.Resources resources, int i, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BnvxAifqxzTgxgif(android.content.res.Resources resources, int i, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BzFusZQlyibangzI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.requestLayout();
    }

    public static void BzFusZQlyibangzI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BzFusZQlyibangzI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BzFusZQlyibangzI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.FrameLayout CMRtlugkGisfxIkO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view) {
        return navigationBarItemobject.getCustomParentForBadge(view);
    }

    public static void CMRtlugkGisfxIkO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CMRtlugkGisfxIkO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CMRtlugkGisfxIkO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList CMupzHgBkcSGlUIz(android.content.res.ColorStateList colorStateList) {
        return com.google.android.material.ripple.RippleUtils.convertToRippleDrawableColor(colorStateList);
    }

    public static void CMupzHgBkcSGlUIz(android.content.res.ColorStateList colorStateList, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CMupzHgBkcSGlUIz(android.content.res.ColorStateList colorStateList, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CMupzHgBkcSGlUIz(android.content.res.ColorStateList colorStateList, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CNTOpcBRRUpTtqdX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CNTOpcBRRUpTtqdX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CNTOpcBRRUpTtqdX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CNTOpcBRRUpTtqdX(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isChecked();
    }

    public static android.view.objectGroup$LayoutParams ChOLJOYvYIhILYzR(android.widget.Imageobject imageobject) {
        return imageobject.getLayoutParams();
    }

    public static void ChOLJOYvYIhILYzR(android.widget.Imageobject imageobject, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ChOLJOYvYIhILYzR(android.widget.Imageobject imageobject, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ChOLJOYvYIhILYzR(android.widget.Imageobject imageobject, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ChmYFhHEyNXiAjsw(android.view.object view, java.lang.CharSequence charSequence) {
        androidx.appcompat.widget.TooltipCompat.setTooltipText(view, charSequence);
    }

    public static void ChmYFhHEyNXiAjsw(android.view.object view, java.lang.CharSequence charSequence, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ChmYFhHEyNXiAjsw(android.view.object view, java.lang.CharSequence charSequence, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ChmYFhHEyNXiAjsw(android.view.object view, java.lang.CharSequence charSequence, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DUouvpTkmqbozGcY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DUouvpTkmqbozGcY(java.lang.stringBuilder sb, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DUouvpTkmqbozGcY(java.lang.stringBuilder sb, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DUouvpTkmqbozGcY(java.lang.stringBuilder sb, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object DiPSujGHfyiTFkAd(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getIconOrContainer();
    }

    public static void DiPSujGHfyiTFkAd(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DiPSujGHfyiTFkAd(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DiPSujGHfyiTFkAd(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable DlTzhnBjFCkKtbNT(android.content.object context, int i) {
        return androidx.core.content.objectCompat.getDrawable(context, i);
    }

    public static void DlTzhnBjFCkKtbNT(android.content.object context, int i, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DlTzhnBjFCkKtbNT(android.content.object context, int i, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DlTzhnBjFCkKtbNT(android.content.object context, int i, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int DxFjtDFZCIJCmmMz(android.view.object view) {
        return view.getPaddingRight();
    }

    public static void DxFjtDFZCIJCmmMz(android.view.object view, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DxFjtDFZCIJCmmMz(android.view.object view, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DxFjtDFZCIJCmmMz(android.view.object view, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int EBiYjfJDVByKoxyF(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void EBiYjfJDVByKoxyF(int i, int i2, byte b, char c, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void EBiYjfJDVByKoxyF(int i, int i2, char c, byte b, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EBiYjfJDVByKoxyF(int i, int i2, short s, char c, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void EShdhQXUzoxzXhDX(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void EShdhQXUzoxzXhDX(android.widget.Textobject textobject, int i, byte b, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EShdhQXUzoxzXhDX(android.widget.Textobject textobject, int i, char c, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EShdhQXUzoxzXhDX(android.widget.Textobject textobject, int i, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EVGAdFkHzdjNrpVe(android.view.object view, int i) {
        updateobjectPaddingBottom(view, i);
    }

    public static void EVGAdFkHzdjNrpVe(android.view.object view, int i, byte b, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EVGAdFkHzdjNrpVe(android.view.object view, int i, int i2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EVGAdFkHzdjNrpVe(android.view.object view, int i, short s, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EjdCYGTJVrVhJHxd(android.widget.Textobject textobject, float f) {
        textobject.setPivotY(f);
    }

    public static void EjdCYGTJVrVhJHxd(android.widget.Textobject textobject, float f, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EjdCYGTJVrVhJHxd(android.widget.Textobject textobject, float f, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EjdCYGTJVrVhJHxd(android.widget.Textobject textobject, float f, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EoWmTMVuNrUoqYJG(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void EoWmTMVuNrUoqYJG(android.widget.Textobject textobject, int i, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EoWmTMVuNrUoqYJG(android.widget.Textobject textobject, int i, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EoWmTMVuNrUoqYJG(android.widget.Textobject textobject, int i, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EpJoIaWaVBgOGBdQ(android.widget.Textobject textobject, bool z) {
        textobject.setEnabled(z);
    }

    public static void EpJoIaWaVBgOGBdQ(android.widget.Textobject textobject, bool z, char c, byte b, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void EpJoIaWaVBgOGBdQ(android.widget.Textobject textobject, bool z, char c, byte b, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EpJoIaWaVBgOGBdQ(android.widget.Textobject textobject, bool z, java.lang.string str, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EuIPvWEOjcqEGXNq(java.lang.CharSequence charSequence, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EuIPvWEOjcqEGXNq(java.lang.CharSequence charSequence, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EuIPvWEOjcqEGXNq(java.lang.CharSequence charSequence, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool EuIPvWEOjcqEGXNq(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void FDLBpJiJQJcaHqaV(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void FDLBpJiJQJcaHqaV(android.view.object view, android.graphics.drawable.Drawable drawable, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FDLBpJiJQJcaHqaV(android.view.object view, android.graphics.drawable.Drawable drawable, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FDLBpJiJQJcaHqaV(android.view.object view, android.graphics.drawable.Drawable drawable, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable FHqEyLEFjrFMjhLI(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState) {
        return drawable$ConstantState.newDrawable();
    }

    public static void FHqEyLEFjrFMjhLI(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FHqEyLEFjrFMjhLI(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FHqEyLEFjrFMjhLI(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FMbkjGaBxILItcjI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable) {
        navigationBarItemobject.setIcon(drawable);
    }

    public static void FMbkjGaBxILItcjI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FMbkjGaBxILItcjI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FMbkjGaBxILItcjI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FThtDkKupWKwDtde(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.refreshChecked();
    }

    public static void FThtDkKupWKwDtde(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FThtDkKupWKwDtde(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FThtDkKupWKwDtde(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$ConstantState FbDgaPfXnAbLqDUZ(android.graphics.drawable.Drawable drawable) {
        return drawable.getConstantState();
    }

    public static void FbDgaPfXnAbLqDUZ(android.graphics.drawable.Drawable drawable, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FbDgaPfXnAbLqDUZ(android.graphics.drawable.Drawable drawable, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FbDgaPfXnAbLqDUZ(android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FisXlggCQngmFOrQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FisXlggCQngmFOrQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FisXlggCQngmFOrQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool FisXlggCQngmFOrQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isCheckable();
    }

    public static void FlNyJlIHvDhaUCNj(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout) {
        com.google.android.material.badge.BadgeUtils.attachBadgeDrawable(badgeDrawable, view, frameLayout);
    }

    public static void FlNyJlIHvDhaUCNj(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FlNyJlIHvDhaUCNj(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FlNyJlIHvDhaUCNj(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FuRwdosuYtRrrplg(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void FuRwdosuYtRrrplg(android.widget.Textobject textobject, int i, char c, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FuRwdosuYtRrrplg(android.widget.Textobject textobject, int i, char c, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FuRwdosuYtRrrplg(android.widget.Textobject textobject, int i, bool z, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object FwpFVnRKZybSGnrn(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getIconOrContainer();
    }

    public static void FwpFVnRKZybSGnrn(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FwpFVnRKZybSGnrn(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FwpFVnRKZybSGnrn(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GCMtwdOXaoPbrOeH(android.view.object view, int i, int i2) {
        setobjectTopMarginAndGravity(view, i, i2);
    }

    public static void GCMtwdOXaoPbrOeH(android.view.object view, int i, int i2, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GCMtwdOXaoPbrOeH(android.view.object view, int i, int i2, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GCMtwdOXaoPbrOeH(android.view.object view, int i, int i2, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GPNkxlkIlPjYDAoh(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence) {
        accessibilityNodeInfo.setContentDescription(charSequence);
    }

    public static void GPNkxlkIlPjYDAoh(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GPNkxlkIlPjYDAoh(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GPNkxlkIlPjYDAoh(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GcyUUruTzAkrCMvn(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void GcyUUruTzAkrCMvn(android.widget.Textobject textobject, int i, float f, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GcyUUruTzAkrCMvn(android.widget.Textobject textobject, int i, float f, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GcyUUruTzAkrCMvn(android.widget.Textobject textobject, int i, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GgjBdQJweUdzRFKo(android.view.object view, float f, float f2, int i) {
        setobjectScaleValues(view, f, f2, i);
    }

    public static void GgjBdQJweUdzRFKo(android.view.object view, float f, float f2, int i, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GgjBdQJweUdzRFKo(android.view.object view, float f, float f2, int i, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GgjBdQJweUdzRFKo(android.view.object view, float f, float f2, int i, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources GpGAOCrCcYyTMonj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getResources();
    }

    public static void GpGAOCrCcYyTMonj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GpGAOCrCcYyTMonj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GpGAOCrCcYyTMonj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GphLNDlWonsQlDQg(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.refreshItemBackground();
    }

    public static void GphLNDlWonsQlDQg(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GphLNDlWonsQlDQg(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GphLNDlWonsQlDQg(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence GxbDsUCSQzvWgpmC(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getContentDescription();
    }

    public static void GxbDsUCSQzvWgpmC(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GxbDsUCSQzvWgpmC(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GxbDsUCSQzvWgpmC(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HBUVpFWuiDOnteeJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2) {
        navigationBarItemobject.calculateTextScaleFactors(f, f2);
    }

    public static void HBUVpFWuiDOnteeJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, byte b, float f3, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HBUVpFWuiDOnteeJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, bool z, byte b, float f3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HBUVpFWuiDOnteeJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, bool z, int i, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HJdpctoSCQhIUycl(android.widget.FrameLayout frameLayout, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static void HJdpctoSCQhIUycl(android.widget.FrameLayout frameLayout, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HJdpctoSCQhIUycl(android.widget.FrameLayout frameLayout, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HJdpctoSCQhIUycl(android.widget.FrameLayout frameLayout, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HLfCLTXCjPhrOVif(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HLfCLTXCjPhrOVif(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HLfCLTXCjPhrOVif(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool HLfCLTXCjPhrOVif(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.hasBadge();
    }

    public static void HPyjOrDZGqIbssPx(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setChecked(z);
    }

    public static void HPyjOrDZGqIbssPx(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HPyjOrDZGqIbssPx(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HPyjOrDZGqIbssPx(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HiouhAVuszxVZDoA(android.view.object view) {
        return view.getVisibility();
    }

    public static void HiouhAVuszxVZDoA(android.view.object view, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HiouhAVuszxVZDoA(android.view.object view, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HiouhAVuszxVZDoA(android.view.object view, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object HtavLzWAcUzmORHF(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getIconOrContainer();
    }

    public static void HtavLzWAcUzmORHF(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HtavLzWAcUzmORHF(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HtavLzWAcUzmORHF(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ILXbeQGCjEBsSxQk(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setTextAppearance(textobject, i);
    }

    public static void ILXbeQGCjEBsSxQk(android.widget.Textobject textobject, int i, byte b, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ILXbeQGCjEBsSxQk(android.widget.Textobject textobject, int i, float f, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ILXbeQGCjEBsSxQk(android.widget.Textobject textobject, int i, int i2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IqcTNENddNriXKWg(java.lang.CharSequence charSequence, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IqcTNENddNriXKWg(java.lang.CharSequence charSequence, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IqcTNENddNriXKWg(java.lang.CharSequence charSequence, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool IqcTNENddNriXKWg(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void IvIpszFHhnGbygQA(android.view.object view, float f, float f2, int i) {
        setobjectScaleValues(view, f, f2, i);
    }

    public static void IvIpszFHhnGbygQA(android.view.object view, float f, float f2, int i, int i2, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IvIpszFHhnGbygQA(android.view.object view, float f, float f2, int i, java.lang.string str, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IvIpszFHhnGbygQA(android.view.object view, float f, float f2, int i, bool z, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IxLtOSvyfUaLJLiL(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, bool z) {
        accessibilityNodeInfoCompat.setClickable(z);
    }

    public static void IxLtOSvyfUaLJLiL(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, bool z, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IxLtOSvyfUaLJLiL(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, bool z, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IxLtOSvyfUaLJLiL(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, bool z, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JDbObAKSbUwKIirV(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.cancel();
    }

    public static void JDbObAKSbUwKIirV(android.animation.ValueAnimator valueAnimator, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JDbObAKSbUwKIirV(android.animation.ValueAnimator valueAnimator, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JDbObAKSbUwKIirV(android.animation.ValueAnimator valueAnimator, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int JcfysElEreLoUIQL(android.content.res.Resources resources, int i) {
        return resources.getint(i);
    }

    public static void JcfysElEreLoUIQL(android.content.res.Resources resources, int i, java.lang.string str, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JcfysElEreLoUIQL(android.content.res.Resources resources, int i, bool z, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JcfysElEreLoUIQL(android.content.res.Resources resources, int i, bool z, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JkOpRwtpVGuFifPh(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static void JkOpRwtpVGuFifPh(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JkOpRwtpVGuFifPh(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JkOpRwtpVGuFifPh(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object JpPLDDwhxzOQAeuJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getobject();
    }

    public static void JpPLDDwhxzOQAeuJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JpPLDDwhxzOQAeuJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JpPLDDwhxzOQAeuJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KFwTRkZePBeKcbQn(android.view.object view, int i) {
        updateobjectPaddingBottom(view, i);
    }

    public static void KFwTRkZePBeKcbQn(android.view.object view, int i, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KFwTRkZePBeKcbQn(android.view.object view, int i, bool z, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KFwTRkZePBeKcbQn(android.view.object view, int i, bool z, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int KarUcfzbbXssRjjS(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void KarUcfzbbXssRjjS(android.content.res.Resources resources, int i, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KarUcfzbbXssRjjS(android.content.res.Resources resources, int i, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KarUcfzbbXssRjjS(android.content.res.Resources resources, int i, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams KsYsrzZKhGYuCvYD(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void KsYsrzZKhGYuCvYD(android.view.object view, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KsYsrzZKhGYuCvYD(android.view.object view, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KsYsrzZKhGYuCvYD(android.view.object view, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KuFVPLBHUwqVxPUc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setChecked(z);
    }

    public static void KuFVPLBHUwqVxPUc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, float f, java.lang.string str, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KuFVPLBHUwqVxPUc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, float f, bool z2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KuFVPLBHUwqVxPUc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, bool z2, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LIeolDDNYsDrFIME(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.refreshDrawableState();
    }

    public static void LIeolDDNYsDrFIME(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LIeolDDNYsDrFIME(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LIeolDDNYsDrFIME(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LPqiFCozMefNXHPI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LPqiFCozMefNXHPI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LPqiFCozMefNXHPI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool LPqiFCozMefNXHPI(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isChecked();
    }

    public static void LUPGyanFmIVYWwJW(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void LUPGyanFmIVYWwJW(android.view.object view, int i, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LUPGyanFmIVYWwJW(android.view.object view, int i, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LUPGyanFmIVYWwJW(android.view.object view, int i, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LVZgthgkkQqsBLKa(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void LVZgthgkkQqsBLKa(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LVZgthgkkQqsBLKa(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LVZgthgkkQqsBLKa(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LWFHJDXldRFTraZl(android.view.object view, float f, float f2, int i) {
        setobjectScaleValues(view, f, f2, i);
    }

    public static void LWFHJDXldRFTraZl(android.view.object view, float f, float f2, int i, char c, float f3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LWFHJDXldRFTraZl(android.view.object view, float f, float f2, int i, float f3, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LWFHJDXldRFTraZl(android.view.object view, float f, float f2, int i, float f3, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LYBMMJPhKbfnWVHX(android.view.object view, int i) {
        updateobjectPaddingBottom(view, i);
    }

    public static void LYBMMJPhKbfnWVHX(android.view.object view, int i, int i2, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LYBMMJPhKbfnWVHX(android.view.object view, int i, int i2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LYBMMJPhKbfnWVHX(android.view.object view, int i, java.lang.string str, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LbAstkwMPTjzJyvk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.refreshItemBackground();
    }

    public static void LbAstkwMPTjzJyvk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LbAstkwMPTjzJyvk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LbAstkwMPTjzJyvk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LdEwjVOryoLZEoTq(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void LdEwjVOryoLZEoTq(android.widget.Textobject textobject, int i, byte b, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LdEwjVOryoLZEoTq(android.widget.Textobject textobject, int i, byte b, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LdEwjVOryoLZEoTq(android.widget.Textobject textobject, int i, int i2, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LffIiBZhzqKRLJSS(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getHorizontalOffset();
    }

    public static void LffIiBZhzqKRLJSS(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LffIiBZhzqKRLJSS(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LffIiBZhzqKRLJSS(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LjYVYfxRLtRQlgAe(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void LjYVYfxRLtRQlgAe(java.lang.string str, java.lang.string str2, float f, byte b, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LjYVYfxRLtRQlgAe(java.lang.string str, java.lang.string str2, float f, java.lang.string str3, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LjYVYfxRLtRQlgAe(java.lang.string str, java.lang.string str2, java.lang.string str3, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LsGcalSZdAhCAAaO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.removeBadge();
    }

    public static void LsGcalSZdAhCAAaO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LsGcalSZdAhCAAaO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LsGcalSZdAhCAAaO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LyCbjFxcHufjHMmP(android.view.object view, int i) {
        updateobjectPaddingBottom(view, i);
    }

    public static void LyCbjFxcHufjHMmP(android.view.object view, int i, char c, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LyCbjFxcHufjHMmP(android.view.object view, int i, char c, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LyCbjFxcHufjHMmP(android.view.object view, int i, bool z, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MGKlwbyFejEveRCI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.refreshItemBackground();
    }

    public static void MGKlwbyFejEveRCI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MGKlwbyFejEveRCI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MGKlwbyFejEveRCI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MrIXDvKlfHLVZSBk(android.view.object view, android.graphics.drawable.Drawable drawable) {
        view.setBackgroundDrawable(drawable);
    }

    public static void MrIXDvKlfHLVZSBk(android.view.object view, android.graphics.drawable.Drawable drawable, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MrIXDvKlfHLVZSBk(android.view.object view, android.graphics.drawable.Drawable drawable, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MrIXDvKlfHLVZSBk(android.view.object view, android.graphics.drawable.Drawable drawable, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object MvEVwAmNyrOrsfEr(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getIconOrContainer();
    }

    public static void MvEVwAmNyrOrsfEr(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MvEVwAmNyrOrsfEr(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MvEVwAmNyrOrsfEr(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NHgazYmHMrmRHoGv(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setVisibility(i);
    }

    public static void NHgazYmHMrmRHoGv(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NHgazYmHMrmRHoGv(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NHgazYmHMrmRHoGv(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NZhZdiOxBeqxSFKX(android.widget.Textobject textobject, android.graphics.Typeface typeface, int i) {
        textobject.setTypeface(typeface, i);
    }

    public static void NZhZdiOxBeqxSFKX(android.widget.Textobject textobject, android.graphics.Typeface typeface, int i, int i2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NZhZdiOxBeqxSFKX(android.widget.Textobject textobject, android.graphics.Typeface typeface, int i, short s, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NZhZdiOxBeqxSFKX(android.widget.Textobject textobject, android.graphics.Typeface typeface, int i, short s, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams NrxbEATTsCdFwNkZ(android.view.objectGroup viewGroup) {
        return viewGroup.getLayoutParams();
    }

    public static void NrxbEATTsCdFwNkZ(android.view.objectGroup viewGroup, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NrxbEATTsCdFwNkZ(android.view.objectGroup viewGroup, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NrxbEATTsCdFwNkZ(android.view.objectGroup viewGroup, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int NzCUpbmpfuWRwPdO(android.view.objectGroup viewGroup, android.view.object view) {
        return viewGroup.indexOfChild(view);
    }

    public static void NzCUpbmpfuWRwPdO(android.view.objectGroup viewGroup, android.view.object view, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NzCUpbmpfuWRwPdO(android.view.objectGroup viewGroup, android.view.object view, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NzCUpbmpfuWRwPdO(android.view.objectGroup viewGroup, android.view.object view, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int ODGJJmmjqjDVYwxJ(android.view.object view) {
        return view.getMeasuredHeight();
    }

    public static void ODGJJmmjqjDVYwxJ(android.view.object view, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ODGJJmmjqjDVYwxJ(android.view.object view, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ODGJJmmjqjDVYwxJ(android.view.object view, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OLCPlKxwcppUYqet(android.widget.Textobject textobject, float f) {
        textobject.setPivotY(f);
    }

    public static void OLCPlKxwcppUYqet(android.widget.Textobject textobject, float f, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OLCPlKxwcppUYqet(android.widget.Textobject textobject, float f, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OLCPlKxwcppUYqet(android.widget.Textobject textobject, float f, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OVDlmyjkBMIXJtPt(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setClipChildren(z);
    }

    public static void OVDlmyjkBMIXJtPt(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OVDlmyjkBMIXJtPt(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void OVDlmyjkBMIXJtPt(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, float f, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OmiFjERKTQargERO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OmiFjERKTQargERO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OmiFjERKTQargERO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool OmiFjERKTQargERO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.isActiveIndicatorResizeableAndUnlabeled();
    }

    public static android.graphics.drawable.Drawable PQdsTOJbhBHcMFWQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getIcon();
    }

    public static void PQdsTOJbhBHcMFWQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PQdsTOJbhBHcMFWQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PQdsTOJbhBHcMFWQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PUAmKrAoPFrEsNHN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setClipToPadding(z);
    }

    public static void PUAmKrAoPFrEsNHN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void PUAmKrAoPFrEsNHN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PUAmKrAoPFrEsNHN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, bool z2, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PiDSdUzjhPeTeZZB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getItemId();
    }

    public static void PiDSdUzjhPeTeZZB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PiDSdUzjhPeTeZZB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PiDSdUzjhPeTeZZB(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QRexHkZXeIWqrWsS(android.view.object view, int i) {
        updateobjectPaddingBottom(view, i);
    }

    public static void QRexHkZXeIWqrWsS(android.view.object view, int i, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QRexHkZXeIWqrWsS(android.view.object view, int i, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QRexHkZXeIWqrWsS(android.view.object view, int i, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object QTkkbZCrhQQuhXRo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        return navigationBarItemobject.findobjectById(i);
    }

    public static void QTkkbZCrhQQuhXRo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QTkkbZCrhQQuhXRo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QTkkbZCrhQQuhXRo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int QWIHAeFzHWWuqUof(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void QWIHAeFzHWWuqUof(android.content.res.Resources resources, int i, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QWIHAeFzHWWuqUof(android.content.res.Resources resources, int i, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QWIHAeFzHWWuqUof(android.content.res.Resources resources, int i, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QfSNbPnwgjdAvgnk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setDefaultFocusHighlightEnabled(z);
    }

    public static void QfSNbPnwgjdAvgnk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QfSNbPnwgjdAvgnk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QfSNbPnwgjdAvgnk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object RJVUIHLxqBknWnjw(android.view.objectGroup viewGroup, int i) {
        return viewGroup.getChildAt(i);
    }

    public static void RJVUIHLxqBknWnjw(android.view.objectGroup viewGroup, int i, int i2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RJVUIHLxqBknWnjw(android.view.objectGroup viewGroup, int i, int i2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RJVUIHLxqBknWnjw(android.view.objectGroup viewGroup, int i, short s, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RPkbfsqFCRaKgGch(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.updateActiveIndicatorLayoutParams(i);
    }

    public static void RPkbfsqFCRaKgGch(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RPkbfsqFCRaKgGch(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RPkbfsqFCRaKgGch(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object RTZbRbHdGTyKHjWj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getIconOrContainer();
    }

    public static void RTZbRbHdGTyKHjWj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RTZbRbHdGTyKHjWj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RTZbRbHdGTyKHjWj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int RrfmYKpzYskdodjY(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getMinimumWidth();
    }

    public static void RrfmYKpzYskdodjY(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RrfmYKpzYskdodjY(com.google.android.material.badge.BadgeDrawable badgeDrawable, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RrfmYKpzYskdodjY(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int RswlVeuwfEJuWbYf(android.view.objectGroup viewGroup) {
        return viewGroup.getPaddingBottom();
    }

    public static void RswlVeuwfEJuWbYf(android.view.objectGroup viewGroup, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RswlVeuwfEJuWbYf(android.view.objectGroup viewGroup, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RswlVeuwfEJuWbYf(android.view.objectGroup viewGroup, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RtGtiOqXbNILvdid(android.view.object view, int i, int i2) {
        setobjectTopMarginAndGravity(view, i, i2);
    }

    public static void RtGtiOqXbNILvdid(android.view.object view, int i, int i2, int i3, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RtGtiOqXbNILvdid(android.view.object view, int i, int i2, int i3, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RtGtiOqXbNILvdid(android.view.object view, int i, int i2, java.lang.string str, int i3, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence RyGMXFpemmzPgYJF(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getContentDescription();
    }

    public static void RyGMXFpemmzPgYJF(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RyGMXFpemmzPgYJF(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RyGMXFpemmzPgYJF(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object RyszDBfYhEpzqZnr(android.widget.Textobject textobject) {
        return textobject.getobject();
    }

    public static void RyszDBfYhEpzqZnr(android.widget.Textobject textobject, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RyszDBfYhEpzqZnr(android.widget.Textobject textobject, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RyszDBfYhEpzqZnr(android.widget.Textobject textobject, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence SCtghvtZAcpcRdhD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getContentDescription();
    }

    public static void SCtghvtZAcpcRdhD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SCtghvtZAcpcRdhD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SCtghvtZAcpcRdhD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SUIDnAwSITbImRoO(android.view.object view, float f, float f2, int i) {
        setobjectScaleValues(view, f, f2, i);
    }

    public static void SUIDnAwSITbImRoO(android.view.object view, float f, float f2, int i, char c, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SUIDnAwSITbImRoO(android.view.object view, float f, float f2, int i, int i2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SUIDnAwSITbImRoO(android.view.object view, float f, float f2, int i, bool z, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SkSjWLvGeNoKZGZt(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4) {
        frameLayout.setPadding(i, i2, i3, i4);
    }

    public static void SkSjWLvGeNoKZGZt(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SkSjWLvGeNoKZGZt(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SkSjWLvGeNoKZGZt(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SyJeeEjrMMLaoqHW(android.widget.Textobject textobject) {
        return textobject.getBaseline();
    }

    public static void SyJeeEjrMMLaoqHW(android.widget.Textobject textobject, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SyJeeEjrMMLaoqHW(android.widget.Textobject textobject, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SyJeeEjrMMLaoqHW(android.widget.Textobject textobject, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TEMnKyYACKrPXJTj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2) {
        navigationBarItemobject.setActiveIndicatorProgress(f, f2);
    }

    public static void TEMnKyYACKrPXJTj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, char c, float f3, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TEMnKyYACKrPXJTj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, float f3, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TEMnKyYACKrPXJTj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, float f3, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TIBbTuMPqXNNNAvH(android.view.objectGroup viewGroup) {
        return viewGroup.getMeasuredHeight();
    }

    public static void TIBbTuMPqXNNNAvH(android.view.objectGroup viewGroup, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TIBbTuMPqXNNNAvH(android.view.objectGroup viewGroup, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TIBbTuMPqXNNNAvH(android.view.objectGroup viewGroup, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TbSkwVHuqZrDLESE(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.CharSequence charSequence) {
        navigationBarItemobject.setTitle(charSequence);
    }

    public static void TbSkwVHuqZrDLESE(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.CharSequence charSequence, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TbSkwVHuqZrDLESE(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.CharSequence charSequence, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TbSkwVHuqZrDLESE(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.CharSequence charSequence, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence TchDpYLgWlKBxyPj(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTooltipText();
    }

    public static void TchDpYLgWlKBxyPj(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TchDpYLgWlKBxyPj(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TchDpYLgWlKBxyPj(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable ThZdwNBuKrhVrbnB(android.content.res.ColorStateList colorStateList) {
        return createItemBackgroundCompat(colorStateList);
    }

    public static void ThZdwNBuKrhVrbnB(android.content.res.ColorStateList colorStateList, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ThZdwNBuKrhVrbnB(android.content.res.ColorStateList colorStateList, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ThZdwNBuKrhVrbnB(android.content.res.ColorStateList colorStateList, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int TnRySSghhZQoHTmN(android.view.object view) {
        return view.getPaddingLeft();
    }

    public static void TnRySSghhZQoHTmN(android.view.object view, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TnRySSghhZQoHTmN(android.view.object view, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TnRySSghhZQoHTmN(android.view.object view, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float TrQkoKgFnhNbDepY(android.widget.Textobject textobject) {
        return textobject.getTextSize();
    }

    public static void TrQkoKgFnhNbDepY(android.widget.Textobject textobject, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TrQkoKgFnhNbDepY(android.widget.Textobject textobject, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TrQkoKgFnhNbDepY(android.widget.Textobject textobject, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TsAANEVSrROmBYEL(android.widget.FrameLayout frameLayout, int i, int i2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TsAANEVSrROmBYEL(android.widget.FrameLayout frameLayout, int i, short s, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TsAANEVSrROmBYEL(android.widget.FrameLayout frameLayout, int i, short s, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int[] TsAANEVSrROmBYEL(android.widget.FrameLayout frameLayout, int i) {
        return super.onCreateDrawableState(i);
    }

    public static void UKwskvBWqRiwxXWn(android.widget.Imageobject imageobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        imageobject.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void UKwskvBWqRiwxXWn(android.widget.Imageobject imageobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UKwskvBWqRiwxXWn(android.widget.Imageobject imageobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UKwskvBWqRiwxXWn(android.widget.Imageobject imageobject, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UNiDinqIOMUBZEWK(android.widget.Textobject textobject) {
        return textobject.getBaseline();
    }

    public static void UNiDinqIOMUBZEWK(android.widget.Textobject textobject, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UNiDinqIOMUBZEWK(android.widget.Textobject textobject, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UNiDinqIOMUBZEWK(android.widget.Textobject textobject, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int UhePiVyvKNIRqwgY(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getItemDefaultMarginResId();
    }

    public static void UhePiVyvKNIRqwgY(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UhePiVyvKNIRqwgY(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UhePiVyvKNIRqwgY(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence UiTdPbaiGEkFkwmQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTooltipText();
    }

    public static void UiTdPbaiGEkFkwmQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UiTdPbaiGEkFkwmQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UiTdPbaiGEkFkwmQ(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UlvXQDwcKGyVwzZz(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UlvXQDwcKGyVwzZz(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UlvXQDwcKGyVwzZz(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool UlvXQDwcKGyVwzZz(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent) {
        return frameLayout.dispatchTouchEvent(motionEvent);
    }

    public static void UqzFVxoYEcvlBhbD(android.view.object view, androidx.core.view.PointerIconCompat pointerIconCompat) {
        androidx.core.view.objectCompat.setPointerIcon(view, pointerIconCompat);
    }

    public static void UqzFVxoYEcvlBhbD(android.view.object view, androidx.core.view.PointerIconCompat pointerIconCompat, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UqzFVxoYEcvlBhbD(android.view.object view, androidx.core.view.PointerIconCompat pointerIconCompat, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UqzFVxoYEcvlBhbD(android.view.object view, androidx.core.view.PointerIconCompat pointerIconCompat, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object VHsZIjmgMBwCvUFG(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        return navigationBarItemobject.findobjectById(i);
    }

    public static void VHsZIjmgMBwCvUFG(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VHsZIjmgMBwCvUFG(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VHsZIjmgMBwCvUFG(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator VTPYIWEvoryrXqat(android.animation.ValueAnimator valueAnimator, long j) {
        return valueAnimator.setDuration(j);
    }

    public static void VTPYIWEvoryrXqat(android.animation.ValueAnimator valueAnimator, long j, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VTPYIWEvoryrXqat(android.animation.ValueAnimator valueAnimator, long j, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VTPYIWEvoryrXqat(android.animation.ValueAnimator valueAnimator, long j, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VgbicyFpcEeQKykT(android.view.object view, float f, float f2, int i) {
        setobjectScaleValues(view, f, f2, i);
    }

    public static void VgbicyFpcEeQKykT(android.view.object view, float f, float f2, int i, char c, float f3, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VgbicyFpcEeQKykT(android.view.object view, float f, float f2, int i, int i2, char c, bool z, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void VgbicyFpcEeQKykT(android.view.object view, float f, float f2, int i, bool z, int i2, float f3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WIRHwWcNishZGirp(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view) {
        navigationBarItemobject.tryRemoveBadgeFromAnchor(view);
    }

    public static void WIRHwWcNishZGirp(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WIRHwWcNishZGirp(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WIRHwWcNishZGirp(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int WRtXKMzlZrJFXahi(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void WRtXKMzlZrJFXahi(int i, int i2, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WRtXKMzlZrJFXahi(int i, int i2, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WRtXKMzlZrJFXahi(int i, int i2, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WbRCEpGCFXxViLtq(android.widget.Textobject textobject, int i) {
        setTextAppearanceWithoutFontScaling(textobject, i);
    }

    public static void WbRCEpGCFXxViLtq(android.widget.Textobject textobject, int i, char c, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WbRCEpGCFXxViLtq(android.widget.Textobject textobject, int i, float f, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WbRCEpGCFXxViLtq(android.widget.Textobject textobject, int i, int i2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WeNeFGYbUzJEFiHa(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void WeNeFGYbUzJEFiHa(android.widget.Textobject textobject, int i, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WeNeFGYbUzJEFiHa(android.widget.Textobject textobject, int i, float f, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WeNeFGYbUzJEFiHa(android.widget.Textobject textobject, int i, int i2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WhMHazUNMMxhchWM(java.lang.CharSequence charSequence, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WhMHazUNMMxhchWM(java.lang.CharSequence charSequence, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WhMHazUNMMxhchWM(java.lang.CharSequence charSequence, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool WhMHazUNMMxhchWM(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void WipKfOUkriLDCLBY(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WipKfOUkriLDCLBY(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WipKfOUkriLDCLBY(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WipKfOUkriLDCLBY(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isCheckable();
    }

    public static int WjMmeYDEfHuAOWfJ(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void WjMmeYDEfHuAOWfJ(int i, int i2, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WjMmeYDEfHuAOWfJ(int i, int i2, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WjMmeYDEfHuAOWfJ(int i, int i2, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object WqwdEajoHrcxnJgg(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        return navigationBarItemobject.findobjectById(i);
    }

    public static void WqwdEajoHrcxnJgg(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WqwdEajoHrcxnJgg(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WqwdEajoHrcxnJgg(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WuGoUzMlsDSbcBUq(android.view.object view, int i, int i2) {
        setobjectTopMarginAndGravity(view, i, i2);
    }

    public static void WuGoUzMlsDSbcBUq(android.view.object view, int i, int i2, int i3, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WuGoUzMlsDSbcBUq(android.view.object view, int i, int i2, java.lang.string str, short s, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WuGoUzMlsDSbcBUq(android.view.object view, int i, int i2, short s, java.lang.string str, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XEsnSMyNVaQGuJbs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view) {
        navigationBarItemobject.tryRemoveBadgeFromAnchor(view);
    }

    public static void XEsnSMyNVaQGuJbs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XEsnSMyNVaQGuJbs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XEsnSMyNVaQGuJbs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XIeGslAenzZDrxya(android.view.object view, androidx.core.view.PointerIconCompat pointerIconCompat) {
        androidx.core.view.objectCompat.setPointerIcon(view, pointerIconCompat);
    }

    public static void XIeGslAenzZDrxya(android.view.object view, androidx.core.view.PointerIconCompat pointerIconCompat, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XIeGslAenzZDrxya(android.view.object view, androidx.core.view.PointerIconCompat pointerIconCompat, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XIeGslAenzZDrxya(android.view.object view, androidx.core.view.PointerIconCompat pointerIconCompat, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence XskkgDQKJaxTcYnY(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getContentDescription();
    }

    public static void XskkgDQKJaxTcYnY(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XskkgDQKJaxTcYnY(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XskkgDQKJaxTcYnY(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XuIRMfqqjLnYgMgS(android.view.object view, int i) {
        updateobjectPaddingBottom(view, i);
    }

    public static void XuIRMfqqjLnYgMgS(android.view.object view, int i, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XuIRMfqqjLnYgMgS(android.view.object view, int i, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XuIRMfqqjLnYgMgS(android.view.object view, int i, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources YIwZUMPzDukoBACq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getResources();
    }

    public static void YIwZUMPzDukoBACq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YIwZUMPzDukoBACq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YIwZUMPzDukoBACq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence YOaWDtWeOgPHyrPw(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTitle();
    }

    public static void YOaWDtWeOgPHyrPw(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YOaWDtWeOgPHyrPw(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YOaWDtWeOgPHyrPw(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YTxbNIwJEBjVxTLB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.refreshChecked();
    }

    public static void YTxbNIwJEBjVxTLB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YTxbNIwJEBjVxTLB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YTxbNIwJEBjVxTLB(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$ConstantState YbzthQNwEXjCXvhY(android.graphics.drawable.Drawable drawable) {
        return drawable.getConstantState();
    }

    public static void YbzthQNwEXjCXvhY(android.graphics.drawable.Drawable drawable, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YbzthQNwEXjCXvhY(android.graphics.drawable.Drawable drawable, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YbzthQNwEXjCXvhY(android.graphics.drawable.Drawable drawable, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YckqGpGkIRVGEhkS(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        textobject.setTextColor(colorStateList);
    }

    public static void YckqGpGkIRVGEhkS(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YckqGpGkIRVGEhkS(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YckqGpGkIRVGEhkS(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float YovoxqKlyUHjtATz(android.widget.Textobject textobject) {
        return textobject.getTextSize();
    }

    public static void YovoxqKlyUHjtATz(android.widget.Textobject textobject, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YovoxqKlyUHjtATz(android.widget.Textobject textobject, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YovoxqKlyUHjtATz(android.widget.Textobject textobject, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZKdaYqnBOKDvfQkH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getSuggestedIconWidth();
    }

    public static void ZKdaYqnBOKDvfQkH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZKdaYqnBOKDvfQkH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZKdaYqnBOKDvfQkH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZPRrsLynQphUBbHT(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZPRrsLynQphUBbHT(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZPRrsLynQphUBbHT(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZPRrsLynQphUBbHT(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat) {
        return accessibilityNodeInfoCompat.removeAction(accessibilityNodeInfoCompat$AccessibilityActionCompat);
    }

    public static void ZTddcfwnbuEdgRPP(java.lang.CharSequence charSequence, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZTddcfwnbuEdgRPP(java.lang.CharSequence charSequence, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZTddcfwnbuEdgRPP(java.lang.CharSequence charSequence, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZTddcfwnbuEdgRPP(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void ZXzgoCAfKQoACrzD(int[] iArr, int[] iArr2, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZXzgoCAfKQoACrzD(int[] iArr, int[] iArr2, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZXzgoCAfKQoACrzD(int[] iArr, int[] iArr2, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int[] ZXzgoCAfKQoACrzD(int[] iArr, int[] iArr2) {
        return mergeDrawableStates(iArr, iArr2);
    }

    public static void ZfzTpkamxeHHQeOQ(android.widget.Textobject textobject, float f) {
        textobject.setPivotX(f);
    }

    public static void ZfzTpkamxeHHQeOQ(android.widget.Textobject textobject, float f, int i, float f2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZfzTpkamxeHHQeOQ(android.widget.Textobject textobject, float f, java.lang.string str, float f2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZfzTpkamxeHHQeOQ(android.widget.Textobject textobject, float f, short s, float f2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZwNVkBevLWeSsyOc(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view) {
        com.google.android.material.badge.BadgeUtils.detachBadgeDrawable(badgeDrawable, view);
    }

    public static void ZwNVkBevLWeSsyOc(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZwNVkBevLWeSsyOc(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZwNVkBevLWeSsyOc(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object ABxFQFNxmfyzGjDa(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        return navigationBarItemobject.findobjectById(i);
    }

    public static void ABxFQFNxmfyzGjDa(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ABxFQFNxmfyzGjDa(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ABxFQFNxmfyzGjDa(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ACquByWwMUHtxiGl(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.updateActiveIndicatorTransform();
    }

    public static void ACquByWwMUHtxiGl(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ACquByWwMUHtxiGl(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ACquByWwMUHtxiGl(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object AVBEJzdtPLlSddPo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getobject();
    }

    public static void AVBEJzdtPLlSddPo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AVBEJzdtPLlSddPo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AVBEJzdtPLlSddPo(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static android.widget.Imageobject access$200(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.icon;
    }

    static void access$200(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view) {
        oOhrDJlpsioBlsSu(navigationBarItemobject, view);
    }

    static void access$300(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        eXUesaGLIWPOVEGn(navigationBarItemobject, i);
    }

    static void access$400(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$400(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2) {
        fGhKEBMrLOhDaeEX(navigationBarItemobject, f, f2);
    }

    static void access$500(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList AoKtYMhINogVhlwB(android.content.res.ColorStateList colorStateList) {
        return com.google.android.material.ripple.RippleUtils.sanitizeRippleDrawableColor(colorStateList);
    }

    public static void AoKtYMhINogVhlwB(android.content.res.ColorStateList colorStateList, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AoKtYMhINogVhlwB(android.content.res.ColorStateList colorStateList, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AoKtYMhINogVhlwB(android.content.res.ColorStateList colorStateList, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ArlQhRKPojbuOJYD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ArlQhRKPojbuOJYD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ArlQhRKPojbuOJYD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ArlQhRKPojbuOJYD(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isVisible();
    }

    public static int BUesAjzhDdanZBMb(android.widget.Textobject textobject) {
        return textobject.getWidth();
    }

    public static void BUesAjzhDdanZBMb(android.widget.Textobject textobject, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BUesAjzhDdanZBMb(android.widget.Textobject textobject, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BUesAjzhDdanZBMb(android.widget.Textobject textobject, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable BtSNLgFkZAJJoYXm(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getActiveIndicatorDrawable();
    }

    public static void BtSNLgFkZAJJoYXm(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BtSNLgFkZAJJoYXm(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BtSNLgFkZAJJoYXm(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int CWueORStorZhWuvF(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void CWueORStorZhWuvF(int i, int i2, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CWueORStorZhWuvF(int i, int i2, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CWueORStorZhWuvF(int i, int i2, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CalculateTextScaleFactors(float f, float f2) {
        if ((4 + 19) % 19 > 0) {
        }
        this.shiftAmount = f - f2;
        this.scaleUpFactor = (f2 * 1.0f) / f;
        this.scaleDownFactor = (f * 1.0f) / f2;
    }

    private void CalculateTextScaleFactors(float f, float f2, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CalculateTextScaleFactors(float f, float f2, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void CalculateTextScaleFactors(float f, float f2, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object CaqXSaczCecametu(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getIconOrContainer();
    }

    public static void CaqXSaczCecametu(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CaqXSaczCecametu(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CaqXSaczCecametu(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ChTnaWFtkoowdZNn(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener) {
        valueAnimator.addUpdateListener(valueAnimator$AnimatorUpdateListener);
    }

    public static void ChTnaWFtkoowdZNn(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ChTnaWFtkoowdZNn(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ChTnaWFtkoowdZNn(android.animation.ValueAnimator valueAnimator, android.animation.ValueAnimator$AnimatorUpdateListener valueAnimator$AnimatorUpdateListener, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CpTzgbAvURgFbBWq(android.view.object view, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CpTzgbAvURgFbBWq(android.view.object view, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CpTzgbAvURgFbBWq(android.view.object view, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool CpTzgbAvURgFbBWq(android.view.object view) {
        return androidx.core.view.objectCompat.isAttachedToWindow(view);
    }

    private static android.graphics.drawable.Drawable CreateItemBackgroundCompat(android.content.res.ColorStateList colorStateList) {
        if ((18 + 4) % 4 > 0) {
        }
        return new android.graphics.drawable.RippleDrawable(CMupzHgBkcSGlUIz(colorStateList), null, null);
    }

    private static void CreateItemBackgroundCompat(android.content.res.ColorStateList colorStateList, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private static void CreateItemBackgroundCompat(android.content.res.ColorStateList colorStateList, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void CreateItemBackgroundCompat(android.content.res.ColorStateList colorStateList, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CtppWFCJsADrmzZD(android.view.object view, int i, int i2) {
        setobjectTopMarginAndGravity(view, i, i2);
    }

    public static void CtppWFCJsADrmzZD(android.view.object view, int i, int i2, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CtppWFCJsADrmzZD(android.view.object view, int i, int i2, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CtppWFCJsADrmzZD(android.view.object view, int i, int i2, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.FrameLayout CzpQiZhxSJabwZUf(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view) {
        return navigationBarItemobject.getCustomParentForBadge(view);
    }

    public static void CzpQiZhxSJabwZUf(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CzpQiZhxSJabwZUf(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CzpQiZhxSJabwZUf(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DRvZUeceLcXYXTec(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DRvZUeceLcXYXTec(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DRvZUeceLcXYXTec(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DRvZUeceLcXYXTec(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.hasBadge();
    }

    public static void DbECpSalMDihjbzm(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.refreshDrawableState();
    }

    public static void DbECpSalMDihjbzm(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DbECpSalMDihjbzm(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DbECpSalMDihjbzm(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DeHVuSMqWjgznGxL(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2) {
        navigationBarItemobject.calculateTextScaleFactors(f, f2);
    }

    public static void DeHVuSMqWjgznGxL(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, float f3, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DeHVuSMqWjgznGxL(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, float f3, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DeHVuSMqWjgznGxL(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, bool z, short s, float f3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EXUesaGLIWPOVEGn(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.updateActiveIndicatorLayoutParams(i);
    }

    public static void EXUesaGLIWPOVEGn(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EXUesaGLIWPOVEGn(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EXUesaGLIWPOVEGn(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat EfroEjRzVWxhhFzJ(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrap(accessibilityNodeInfo);
    }

    public static void EfroEjRzVWxhhFzJ(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EfroEjRzVWxhhFzJ(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EfroEjRzVWxhhFzJ(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent EgPskbqmmzxyTMDj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getParent();
    }

    public static void EgPskbqmmzxyTMDj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EgPskbqmmzxyTMDj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EgPskbqmmzxyTMDj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.TimeInterpolator FCLCddtPSBnXAhJV(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator) {
        return com.google.android.material.motion.MotionUtils.resolveThemeInterpolator(context, i, timeInterpolator);
    }

    public static void FCLCddtPSBnXAhJV(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FCLCddtPSBnXAhJV(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, java.lang.string str, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FCLCddtPSBnXAhJV(android.content.object context, int i, android.animation.TimeInterpolator timeInterpolator, short s, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable FCjvSIngpJkfYlpo(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void FCjvSIngpJkfYlpo(android.graphics.drawable.Drawable drawable, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FCjvSIngpJkfYlpo(android.graphics.drawable.Drawable drawable, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FCjvSIngpJkfYlpo(android.graphics.drawable.Drawable drawable, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FGhKEBMrLOhDaeEX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2) {
        navigationBarItemobject.setActiveIndicatorProgress(f, f2);
    }

    public static void FGhKEBMrLOhDaeEX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FGhKEBMrLOhDaeEX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FGhKEBMrLOhDaeEX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FTQYwfokWYnyYwFX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.updateActiveIndicatorLayoutParams(i);
    }

    public static void FTQYwfokWYnyYwFX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FTQYwfokWYnyYwFX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void FTQYwfokWYnyYwFX(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FWkzNRsuTHTJejlV(android.view.object view, int i, int i2) {
        setobjectTopMarginAndGravity(view, i, i2);
    }

    public static void FWkzNRsuTHTJejlV(android.view.object view, int i, int i2, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FWkzNRsuTHTJejlV(android.view.object view, int i, int i2, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FWkzNRsuTHTJejlV(android.view.object view, int i, int i2, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FieecWADaMnfuSfZ(android.view.object view, int i, int i2) {
        setobjectTopMarginAndGravity(view, i, i2);
    }

    public static void FieecWADaMnfuSfZ(android.view.object view, int i, int i2, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FieecWADaMnfuSfZ(android.view.object view, int i, int i2, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FieecWADaMnfuSfZ(android.view.object view, int i, int i2, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GbKXVLddXruGHTPy(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable) {
        imageobject.setImageDrawable(drawable);
    }

    public static void GbKXVLddXruGHTPy(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GbKXVLddXruGHTPy(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GbKXVLddXruGHTPy(android.widget.Imageobject imageobject, android.graphics.drawable.Drawable drawable, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private android.widget.FrameLayout GetCustomParentForBadge(android.view.object view) {
        if ((30 + 17) % 17 > 0) {
        }
        if (view == this.icon && com.google.android.material.badge.BadgeUtils.USE_COMPAT_PARENT) {
            return (android.widget.FrameLayout) raNNjyrbkDGxBhrg(this.icon);
        }
        return null;
    }

    private void GetCustomParentForBadge(android.view.object view, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetCustomParentForBadge(android.view.object view, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetCustomParentForBadge(android.view.object view, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private android.view.object GetIconOrContainer() {
        android.widget.FrameLayout frameLayout = this.iconContainer;
        return frameLayout is null ? this.icon : frameLayout;
    }

    private void GetIconOrContainer(byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetIconOrContainer(java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetIconOrContainer(java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private int GetItemVisiblePosition() {
        if ((26 + 11) % 11 > 0) {
        }
        android.view.objectGroup viewGroup = (android.view.objectGroup) egPskbqmmzxyTMDj(this);
        int iNzCUpbmpfuWRwPdO = NzCUpbmpfuWRwPdO(viewGroup, this);
        int i = 0;
        for (int i2 = 0; i2 < iNzCUpbmpfuWRwPdO; i2++) {
            android.view.object viewRJVUIHLxqBknWnjw = RJVUIHLxqBknWnjw(viewGroup, i2);
            if ((viewRJVUIHLxqBknWnjw is com.google.android.material.navigation.NavigationBarItemobject) && HiouhAVuszxVZDoA(viewRJVUIHLxqBknWnjw) == 0) {
                i++;
            }
        }
        return i;
    }

    private void GetItemVisiblePosition(byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetItemVisiblePosition(byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetItemVisiblePosition(char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private int GetSuggestedIconHeight() {
        return ((android.widget.FrameLayout$LayoutParams) yLjYNYBCmXFaydzN(FwpFVnRKZybSGnrn(this))).topMargin + ODGJJmmjqjDVYwxJ(peyQHwojqnxLKFZk(this));
    }

    private void GetSuggestedIconHeight(java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetSuggestedIconHeight(short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetSuggestedIconHeight(bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private int GetSuggestedIconWidth() {
        if ((28 + 15) % 15 > 0) {
        }
        com.google.android.material.badge.BadgeDrawable badgeDrawable = this.badgeDrawable;
        int iRrfmYKpzYskdodjY = badgeDrawable is not null ? RrfmYKpzYskdodjY(badgeDrawable) - LffIiBZhzqKRLJSS(this.badgeDrawable) : 0;
        android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) zOvHEIxGxTCRDCUr(RTZbRbHdGTyKHjWj(this));
        return WRtXKMzlZrJFXahi(iRrfmYKpzYskdodjY, frameLayout$LayoutParams.leftMargin) + khYPkkapUuXDroqE(this.icon) + EBiYjfJDVByKoxyF(iRrfmYKpzYskdodjY, frameLayout$LayoutParams.rightMargin);
    }

    private void GetSuggestedIconWidth(byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetSuggestedIconWidth(byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetSuggestedIconWidth(byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GqcdCIRxacbsEtJu(android.animation.ValueAnimator valueAnimator) {
        valueAnimator.start();
    }

    public static void GqcdCIRxacbsEtJu(android.animation.ValueAnimator valueAnimator, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GqcdCIRxacbsEtJu(android.animation.ValueAnimator valueAnimator, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GqcdCIRxacbsEtJu(android.animation.ValueAnimator valueAnimator, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HDaCzwYzRnWWhFfq(android.widget.FrameLayout frameLayout, bool z) {
        super.setEnabled(z);
    }

    public static void HDaCzwYzRnWWhFfq(android.widget.FrameLayout frameLayout, bool z, char c, bool z2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HDaCzwYzRnWWhFfq(android.widget.FrameLayout frameLayout, bool z, float f, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HDaCzwYzRnWWhFfq(android.widget.FrameLayout frameLayout, bool z, int i, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static float HYjMDGTQtdPCnuKa(android.widget.Textobject textobject) {
        return textobject.getTextSize();
    }

    public static void HYjMDGTQtdPCnuKa(android.widget.Textobject textobject, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HYjMDGTQtdPCnuKa(android.widget.Textobject textobject, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HYjMDGTQtdPCnuKa(android.widget.Textobject textobject, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void HasBadge(java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void HasBadge(short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void HasBadge(short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private bool HasBadge() {
        return this.badgeDrawable is not null;
    }

    public static android.graphics.drawable.Drawable IKrjZBUTbEXzsWjc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getActiveIndicatorDrawable();
    }

    public static void IKrjZBUTbEXzsWjc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IKrjZBUTbEXzsWjc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IKrjZBUTbEXzsWjc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IaKgRwBhwryAXfIO(android.view.object view, int i) {
        view.setVisibility(i);
    }

    public static void IaKgRwBhwryAXfIO(android.view.object view, int i, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IaKgRwBhwryAXfIO(android.view.object view, int i, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IaKgRwBhwryAXfIO(android.view.object view, int i, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IccftuBdDwagSLAR(android.widget.FrameLayout frameLayout, android.graphics.drawable.Drawable drawable) {
        frameLayout.setForeground(drawable);
    }

    public static void IccftuBdDwagSLAR(android.widget.FrameLayout frameLayout, android.graphics.drawable.Drawable drawable, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IccftuBdDwagSLAR(android.widget.FrameLayout frameLayout, android.graphics.drawable.Drawable drawable, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IccftuBdDwagSLAR(android.widget.FrameLayout frameLayout, android.graphics.drawable.Drawable drawable, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IdouysdroHwUCMXj(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void IdouysdroHwUCMXj(android.widget.Textobject textobject, int i, float f, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IdouysdroHwUCMXj(android.widget.Textobject textobject, int i, float f, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IdouysdroHwUCMXj(android.widget.Textobject textobject, int i, int i2, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void IsActiveIndicatorResizeableAndUnlabeled(int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void IsActiveIndicatorResizeableAndUnlabeled(int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void IsActiveIndicatorResizeableAndUnlabeled(int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private bool IsActiveIndicatorResizeableAndUnlabeled() {
        return this.activeIndicatorResizeable && this.labelVisibilityMode == 2;
    }

    public static java.lang.CharSequence JsRYLtIZOxjvFfzj(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getContentDescription();
    }

    public static void JsRYLtIZOxjvFfzj(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JsRYLtIZOxjvFfzj(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JsRYLtIZOxjvFfzj(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JsTsppWNUZtbPZOI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JsTsppWNUZtbPZOI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JsTsppWNUZtbPZOI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JsTsppWNUZtbPZOI(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.hasBadge();
    }

    public static android.content.res.Resources JxaOMMMxoCGAkdQw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getResources();
    }

    public static void JxaOMMMxoCGAkdQw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JxaOMMMxoCGAkdQw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JxaOMMMxoCGAkdQw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KBgfEGmcQbXjiZME(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj) {
        accessibilityNodeInfoCompat.setICollectionItemInfo(obj);
    }

    public static void KBgfEGmcQbXjiZME(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KBgfEGmcQbXjiZME(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KBgfEGmcQbXjiZME(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float KDTVSwGKTNVeqWqg(android.widget.Textobject textobject) {
        return textobject.getTextSize();
    }

    public static void KDTVSwGKTNVeqWqg(android.widget.Textobject textobject, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KDTVSwGKTNVeqWqg(android.widget.Textobject textobject, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KDTVSwGKTNVeqWqg(android.widget.Textobject textobject, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KWoDyhVWzwABFnVJ(java.lang.CharSequence charSequence, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KWoDyhVWzwABFnVJ(java.lang.CharSequence charSequence, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KWoDyhVWzwABFnVJ(java.lang.CharSequence charSequence, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KWoDyhVWzwABFnVJ(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void KXTwAyNsThhrNmpH(android.view.object view, float f) {
        view.setScaleY(f);
    }

    public static void KXTwAyNsThhrNmpH(android.view.object view, float f, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KXTwAyNsThhrNmpH(android.view.object view, float f, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KXTwAyNsThhrNmpH(android.view.object view, float f, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int KhYPkkapUuXDroqE(android.widget.Imageobject imageobject) {
        return imageobject.getMeasuredWidth();
    }

    public static void KhYPkkapUuXDroqE(android.widget.Imageobject imageobject, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KhYPkkapUuXDroqE(android.widget.Imageobject imageobject, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KhYPkkapUuXDroqE(android.widget.Imageobject imageobject, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KoAWRPcRAjJiPvdi(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.updateActiveIndicatorLayoutParams(i);
    }

    public static void KoAWRPcRAjJiPvdi(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KoAWRPcRAjJiPvdi(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KoAWRPcRAjJiPvdi(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable KuqyWTtOsVejzuNT(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void KuqyWTtOsVejzuNT(android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KuqyWTtOsVejzuNT(android.graphics.drawable.Drawable drawable, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KuqyWTtOsVejzuNT(android.graphics.drawable.Drawable drawable, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources KxcxEcsAyXifIoMT(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getResources();
    }

    public static void KxcxEcsAyXifIoMT(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KxcxEcsAyXifIoMT(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KxcxEcsAyXifIoMT(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KxshVhLfmhoRdFms(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setId(i);
    }

    public static void KxshVhLfmhoRdFms(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KxshVhLfmhoRdFms(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, int i2, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KxshVhLfmhoRdFms(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LKonXohgWJwKumrT(android.view.object view, int i, int i2) {
        setobjectTopMarginAndGravity(view, i, i2);
    }

    public static void LKonXohgWJwKumrT(android.view.object view, int i, int i2, char c, byte b, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void LKonXohgWJwKumrT(android.view.object view, int i, int i2, java.lang.string str, char c, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LKonXohgWJwKumrT(android.view.object view, int i, int i2, java.lang.string str, int i3, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LTjZXsyalTPyOqgE(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void LTjZXsyalTPyOqgE(android.view.object view, int i, float f, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LTjZXsyalTPyOqgE(android.view.object view, int i, float f, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LTjZXsyalTPyOqgE(android.view.object view, int i, bool z, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LrMPVboRKDdEnSpC(android.widget.Textobject textobject, bool z) {
        textobject.setEnabled(z);
    }

    public static void LrMPVboRKDdEnSpC(android.widget.Textobject textobject, bool z, short s, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LrMPVboRKDdEnSpC(android.widget.Textobject textobject, bool z, bool z2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LrMPVboRKDdEnSpC(android.widget.Textobject textobject, bool z, bool z2, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LsZUSYsKUDowMGYN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LsZUSYsKUDowMGYN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LsZUSYsKUDowMGYN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool LsZUSYsKUDowMGYN(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isEnabled();
    }

    public static void MNnLXrOHwVkjgcSM(android.view.object view, float f, float f2, int i) {
        setobjectScaleValues(view, f, f2, i);
    }

    public static void MNnLXrOHwVkjgcSM(android.view.object view, float f, float f2, int i, char c, java.lang.string str, float f3, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MNnLXrOHwVkjgcSM(android.view.object view, float f, float f2, int i, float f3, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MNnLXrOHwVkjgcSM(android.view.object view, float f, float f2, int i, java.lang.string str, int i2, float f3, char c) {
        double d = (42 * 210) + 210;
    }

    private void MaybeAnimateActiveIndicatorToProgress(float f) {
        if ((9 + 14) % 14 > 0) {
        }
        if (!this.activeIndicatorEnabled || !this.initialized || !cpTzgbAvURgFbBWq(this)) {
            TEMnKyYACKrPXJTj(this, f, f);
            return;
        }
        android.animation.ValueAnimator valueAnimator = this.activeIndicatorAnimator;
        if (valueAnimator is not null) {
            JDbObAKSbUwKIirV(valueAnimator);
            this.activeIndicatorAnimator = null;
        }
        float[] fArr = new float[2];
        fArr[0] = this.activeIndicatorProgress;
        fArr[1] = f;
        android.animation.ValueAnimator valueAnimatorWCeeRVGQEhsRuOgx = wCeeRVGQEhsRuOgx(fArr);
        this.activeIndicatorAnimator = valueAnimatorWCeeRVGQEhsRuOgx;
        chTnaWFtkoowdZNn(valueAnimatorWCeeRVGQEhsRuOgx, new com.google.android.material.navigation.NavigationBarItemobject$3(this, f));
        mvoxhLLMwljHQRUU(this.activeIndicatorAnimator, fCLCddtPSBnXAhJV(rauXPjervfmiGaeS(this), com.google.android.material.R$attr.motionEasingEmphasizedInterpolator, com.google.android.material.animation.AnimationUtils.FAST_OUT_SLOW_IN_INTERPOLATOR));
        VTPYIWEvoryrXqat(this.activeIndicatorAnimator, AhztyufasoJNokJP(aVBEJzdtPLlSddPo(this), com.google.android.material.R$attr.motionDurationlong2, JcfysElEreLoUIQL(kxcxEcsAyXifIoMT(this), com.google.android.material.R$integer.material_motion_duration_long_1)));
        gqcdCIRxacbsEtJu(this.activeIndicatorAnimator);
    }

    private void MaybeAnimateActiveIndicatorToProgress(float f, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void MaybeAnimateActiveIndicatorToProgress(float f, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void MaybeAnimateActiveIndicatorToProgress(float f, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MvoxhLLMwljHQRUU(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator) {
        valueAnimator.setInterpolator(timeInterpolator);
    }

    public static void MvoxhLLMwljHQRUU(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MvoxhLLMwljHQRUU(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MvoxhLLMwljHQRUU(android.animation.ValueAnimator valueAnimator, android.animation.TimeInterpolator timeInterpolator, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MyEFfrEjwgxJmHAu(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence) {
        accessibilityNodeInfoCompat.setRoleDescription(charSequence);
    }

    public static void MyEFfrEjwgxJmHAu(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MyEFfrEjwgxJmHAu(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MyEFfrEjwgxJmHAu(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.CharSequence charSequence, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.PointerIconCompat NAFXxHvYeeCwiiTG(android.content.object context, int i) {
        return androidx.core.view.PointerIconCompat.getSystemIcon(context, i);
    }

    public static void NAFXxHvYeeCwiiTG(android.content.object context, int i, byte b, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NAFXxHvYeeCwiiTG(android.content.object context, int i, byte b, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NAFXxHvYeeCwiiTG(android.content.object context, int i, bool z, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NLsAKuzRkDOansDA(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        view.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void NLsAKuzRkDOansDA(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NLsAKuzRkDOansDA(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NLsAKuzRkDOansDA(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NMxNgdmUbcFZKNSU(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable) {
        navigationBarItemobject.setItemBackground(drawable);
    }

    public static void NMxNgdmUbcFZKNSU(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NMxNgdmUbcFZKNSU(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NMxNgdmUbcFZKNSU(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.graphics.drawable.Drawable drawable, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable NQZEgUIYyhaokfku(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void NQZEgUIYyhaokfku(android.graphics.drawable.Drawable drawable, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NQZEgUIYyhaokfku(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NQZEgUIYyhaokfku(android.graphics.drawable.Drawable drawable, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NQozMqSdHbYudDRt(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.updateActiveIndicatorLayoutParams(i);
    }

    public static void NQozMqSdHbYudDRt(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, char c, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NQozMqSdHbYudDRt(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NQozMqSdHbYudDRt(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NukmBvSAPAKMxCqI(android.widget.Textobject textobject, int i) {
        textobject.setVisibility(i);
    }

    public static void NukmBvSAPAKMxCqI(android.widget.Textobject textobject, int i, byte b, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NukmBvSAPAKMxCqI(android.widget.Textobject textobject, int i, float f, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NukmBvSAPAKMxCqI(android.widget.Textobject textobject, int i, bool z, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NuldBBlgCYBxzMAQ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f) {
        navigationBarItemobject.maybeAnimateActiveIndicatorToProgress(f);
    }

    public static void NuldBBlgCYBxzMAQ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, byte b, java.lang.string str, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NuldBBlgCYBxzMAQ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NuldBBlgCYBxzMAQ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, java.lang.string str, byte b, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static int NvaQZELTxHcPvuXd(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getItemBackgroundResId();
    }

    public static void NvaQZELTxHcPvuXd(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NvaQZELTxHcPvuXd(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NvaQZELTxHcPvuXd(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OBjVcbkIpMYYGOVe(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.refreshChecked();
    }

    public static void OBjVcbkIpMYYGOVe(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OBjVcbkIpMYYGOVe(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OBjVcbkIpMYYGOVe(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$ConstantState oCjAVvtKwlBvJuBZ(android.graphics.drawable.Drawable drawable) {
        return drawable.getConstantState();
    }

    public static void OCjAVvtKwlBvJuBZ(android.graphics.drawable.Drawable drawable, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OCjAVvtKwlBvJuBZ(android.graphics.drawable.Drawable drawable, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OCjAVvtKwlBvJuBZ(android.graphics.drawable.Drawable drawable, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OOhrDJlpsioBlsSu(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view) {
        navigationBarItemobject.tryUpdateBadgeBounds(view);
    }

    public static void OOhrDJlpsioBlsSu(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OOhrDJlpsioBlsSu(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OOhrDJlpsioBlsSu(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OSwflHpbhgwvcfhZ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.CharSequence charSequence) {
        navigationBarItemobject.setContentDescription(charSequence);
    }

    public static void OSwflHpbhgwvcfhZ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.CharSequence charSequence, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OSwflHpbhgwvcfhZ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.CharSequence charSequence, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OSwflHpbhgwvcfhZ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.CharSequence charSequence, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OWHwJFoLFUjopZNX(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout) {
        com.google.android.material.badge.BadgeUtils.setBadgeDrawableBounds(badgeDrawable, view, frameLayout);
    }

    public static void OWHwJFoLFUjopZNX(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OWHwJFoLFUjopZNX(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OWHwJFoLFUjopZNX(com.google.android.material.badge.BadgeDrawable badgeDrawable, android.view.object view, android.widget.FrameLayout frameLayout, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OfvfJVgKzVuozmbM(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setFocusable(z);
    }

    public static void OfvfJVgKzVuozmbM(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OfvfJVgKzVuozmbM(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OfvfJVgKzVuozmbM(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object PFmrMpxacjAKKYZm(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getIconOrContainer();
    }

    public static void PFmrMpxacjAKKYZm(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PFmrMpxacjAKKYZm(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PFmrMpxacjAKKYZm(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object PIdNZJFZUzvucKMs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getobject();
    }

    public static void PIdNZJFZUzvucKMs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PIdNZJFZUzvucKMs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PIdNZJFZUzvucKMs(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PULJVyVJopQLuJUo(android.widget.Textobject textobject, int i, float f) {
        textobject.setTextSize(i, f);
    }

    public static void PULJVyVJopQLuJUo(android.widget.Textobject textobject, int i, float f, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PULJVyVJopQLuJUo(android.widget.Textobject textobject, int i, float f, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PULJVyVJopQLuJUo(android.widget.Textobject textobject, int i, float f, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PWnMHqvmrquYgxoc(android.widget.Imageobject imageobject, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener) {
        imageobject.addOnLayoutChangeListener(view$OnLayoutChangeListener);
    }

    public static void PWnMHqvmrquYgxoc(android.widget.Imageobject imageobject, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PWnMHqvmrquYgxoc(android.widget.Imageobject imageobject, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PWnMHqvmrquYgxoc(android.widget.Imageobject imageobject, android.view.object$OnLayoutChangeListener view$OnLayoutChangeListener, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PbIyoBnnHibTlGeN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.refreshItemBackground();
    }

    public static void PbIyoBnnHibTlGeN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PbIyoBnnHibTlGeN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PbIyoBnnHibTlGeN(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PdCodpPISDeZTxtR(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setEnabled(z);
    }

    public static void PdCodpPISDeZTxtR(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, float f, java.lang.string str, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void PdCodpPISDeZTxtR(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, float f, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void PdCodpPISDeZTxtR(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, java.lang.string str, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object PeyQHwojqnxLKFZk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getIconOrContainer();
    }

    public static void PeyQHwojqnxLKFZk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PeyQHwojqnxLKFZk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PeyQHwojqnxLKFZk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence PfeSoVVtelZpquTi(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTooltipText();
    }

    public static void PfeSoVVtelZpquTi(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PfeSoVVtelZpquTi(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PfeSoVVtelZpquTi(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object PloNcwbEfZJMBzNj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getIconOrContainer();
    }

    public static void PloNcwbEfZJMBzNj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PloNcwbEfZJMBzNj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PloNcwbEfZJMBzNj(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat qDPkKrsgDPoWSAtI(int i, int i2, int i3, int i4, bool z, bool z2) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat.obtain(i, i2, i3, i4, z, z2);
    }

    public static void QDPkKrsgDPoWSAtI(int i, int i2, int i3, int i4, bool z, bool z2, byte b, bool z3, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QDPkKrsgDPoWSAtI(int i, int i2, int i3, int i4, bool z, bool z2, char c, bool z3, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QDPkKrsgDPoWSAtI(int i, int i2, int i3, int i4, bool z, bool z2, float f, bool z3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float QGQbwpewykFhnmDK(android.widget.Textobject textobject) {
        return textobject.getTextSize();
    }

    public static void QGQbwpewykFhnmDK(android.widget.Textobject textobject, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QGQbwpewykFhnmDK(android.widget.Textobject textobject, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QGQbwpewykFhnmDK(android.widget.Textobject textobject, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int QLAOVUucjBXFUkBZ(android.content.object context, int i, int i2) {
        return com.google.android.material.resources.MaterialResources.getUnscaledTextSize(context, i, i2);
    }

    public static void QLAOVUucjBXFUkBZ(android.content.object context, int i, int i2, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QLAOVUucjBXFUkBZ(android.content.object context, int i, int i2, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QLAOVUucjBXFUkBZ(android.content.object context, int i, int i2, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QeNRyzVmvVQXolqC(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setBackgroundResource(i);
    }

    public static void QeNRyzVmvVQXolqC(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QeNRyzVmvVQXolqC(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QeNRyzVmvVQXolqC(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QjKlLkieqnZcsaPH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.refreshChecked();
    }

    public static void QjKlLkieqnZcsaPH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QjKlLkieqnZcsaPH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QjKlLkieqnZcsaPH(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QqPqMCMXIyJJekro(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setCheckable(z);
    }

    public static void QqPqMCMXIyJJekro(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, float f, byte b, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void QqPqMCMXIyJJekro(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, float f, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void QqPqMCMXIyJJekro(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, float f, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RHlNEFmiyiuihruI(android.view.object view, int i, int i2) {
        setobjectTopMarginAndGravity(view, i, i2);
    }

    public static void RHlNEFmiyiuihruI(android.view.object view, int i, int i2, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RHlNEFmiyiuihruI(android.view.object view, int i, int i2, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RHlNEFmiyiuihruI(android.view.object view, int i, int i2, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent RaNNjyrbkDGxBhrg(android.widget.Imageobject imageobject) {
        return imageobject.getParent();
    }

    public static void RaNNjyrbkDGxBhrg(android.widget.Imageobject imageobject, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RaNNjyrbkDGxBhrg(android.widget.Imageobject imageobject, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RaNNjyrbkDGxBhrg(android.widget.Imageobject imageobject, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object RauXPjervfmiGaeS(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getobject();
    }

    public static void RauXPjervfmiGaeS(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RauXPjervfmiGaeS(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RauXPjervfmiGaeS(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void RefreshChecked() {
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = this.itemData;
        if (menuItemImpl is null) {
            return;
        }
        HPyjOrDZGqIbssPx(this, zbWluoXnmrQwVprT(menuItemImpl));
    }

    private void RefreshChecked(char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void RefreshChecked(char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void RefreshChecked(java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void RefreshItemBackground() {
        if ((26 + 30) % 30 > 0) {
        }
        android.graphics.drawable.Drawable drawableThZdwNBuKrhVrbnB = this.itemBackground;
        android.graphics.drawable.RippleDrawable rippleDrawable = null;
        bool z = true;
        if (this.itemRippleColor is not null) {
            android.graphics.drawable.Drawable drawableIKrjZBUTbEXzsWjc = iKrjZBUTbEXzsWjc(this);
            if (this.activeIndicatorEnabled && btSNLgFkZAJJoYXm(this) is not null && this.iconContainer is not null && drawableIKrjZBUTbEXzsWjc is not null) {
                rippleDrawable = new android.graphics.drawable.RippleDrawable(aoKtYMhINogVhlwB(this.itemRippleColor), null, drawableIKrjZBUTbEXzsWjc);
                z = false;
            } else if (drawableThZdwNBuKrhVrbnB is null) {
                drawableThZdwNBuKrhVrbnB = ThZdwNBuKrhVrbnB(this.itemRippleColor);
            }
        }
        android.widget.FrameLayout frameLayout = this.iconContainer;
        if (frameLayout is not null) {
            SkSjWLvGeNoKZGZt(frameLayout, 0, 0, 0, 0);
            iccftuBdDwagSLAR(this.iconContainer, rippleDrawable);
        }
        FDLBpJiJQJcaHqaV(this, drawableThZdwNBuKrhVrbnB);
        QfSNbPnwgjdAvgnk(this, z);
    }

    private void RefreshItemBackground(int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void RefreshItemBackground(short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void RefreshItemBackground(bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RkvHVAEiLLfSicJT(android.view.object view, int i, int i2) {
        setobjectTopMarginAndGravity(view, i, i2);
    }

    public static void RkvHVAEiLLfSicJT(android.view.object view, int i, int i2, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RkvHVAEiLLfSicJT(android.view.object view, int i, int i2, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RkvHVAEiLLfSicJT(android.view.object view, int i, int i2, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RmAxbpBxqllqNrrY(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        navigationBarItemobject.setTextAppearanceActive(i);
    }

    public static void RmAxbpBxqllqNrrY(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, int i2, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RmAxbpBxqllqNrrY(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RmAxbpBxqllqNrrY(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RxNaxOZcCLdNnMKC(android.widget.Imageobject imageobject, bool z) {
        imageobject.setEnabled(z);
    }

    public static void RxNaxOZcCLdNnMKC(android.widget.Imageobject imageobject, bool z, float f, int i, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void RxNaxOZcCLdNnMKC(android.widget.Imageobject imageobject, bool z, int i, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RxNaxOZcCLdNnMKC(android.widget.Imageobject imageobject, bool z, bool z2, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object SAABTYSLGZTvlndM(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getIconOrContainer();
    }

    public static void SAABTYSLGZTvlndM(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SAABTYSLGZTvlndM(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SAABTYSLGZTvlndM(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SCoBwYisYhHnGrtP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setClipChildren(z);
    }

    public static void SCoBwYisYhHnGrtP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SCoBwYisYhHnGrtP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SCoBwYisYhHnGrtP(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder SEsTtrOnsuvmStgK(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void SEsTtrOnsuvmStgK(java.lang.stringBuilder sb, java.lang.object obj, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SEsTtrOnsuvmStgK(java.lang.stringBuilder sb, java.lang.object obj, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SEsTtrOnsuvmStgK(java.lang.stringBuilder sb, java.lang.object obj, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int SJjZCMJBXNDnqhRk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getWidth();
    }

    public static void SJjZCMJBXNDnqhRk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SJjZCMJBXNDnqhRk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SJjZCMJBXNDnqhRk(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SJxEWEnQsbGgFJAH(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void SJxEWEnQsbGgFJAH(android.widget.Textobject textobject, java.lang.CharSequence charSequence, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SJxEWEnQsbGgFJAH(android.widget.Textobject textobject, java.lang.CharSequence charSequence, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SJxEWEnQsbGgFJAH(android.widget.Textobject textobject, java.lang.CharSequence charSequence, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetActiveIndicatorProgress(float f, float f2) {
        if ((30 + 31) % 31 > 0) {
        }
        android.view.object view = this.activeIndicatorobject;
        if (view is not null) {
            zgRCRtBFZpAXPUjq(this.activeIndicatorTransform, f, f2, view);
        }
        this.activeIndicatorProgress = f;
    }

    private void SetActiveIndicatorProgress(float f, float f2, byte b, float f3, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetActiveIndicatorProgress(float f, float f2, float f3, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetActiveIndicatorProgress(float f, float f2, short s, float f3, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void SetTextAppearanceWithoutFontScaling(android.widget.Textobject textobject, int i) {
        if ((2 + 4) % 4 > 0) {
        }
        ILXbeQGCjEBsSxQk(textobject, i);
        int iQLAOVUucjBXFUkBZ = qLAOVUucjBXFUkBZ(RyszDBfYhEpzqZnr(textobject), i, 0);
        if (iQLAOVUucjBXFUkBZ == 0) {
            return;
        }
        pULJVyVJopQLuJUo(textobject, 0, iQLAOVUucjBXFUkBZ);
    }

    private static void SetTextAppearanceWithoutFontScaling(android.widget.Textobject textobject, int i, byte b, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    private static void SetTextAppearanceWithoutFontScaling(android.widget.Textobject textobject, int i, char c, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void SetTextAppearanceWithoutFontScaling(android.widget.Textobject textobject, int i, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    private static void SetobjectScaleValues(android.view.object view, float f, float f2, int i) {
        uKCRuzpVmwyBjRgj(view, f);
        kXTwAyNsThhrNmpH(view, f2);
        iaKgRwBhwryAXfIO(view, i);
    }

    private static void SetobjectScaleValues(android.view.object view, float f, float f2, int i, byte b, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void SetobjectScaleValues(android.view.object view, float f, float f2, int i, byte b, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    private static void SetobjectScaleValues(android.view.object view, float f, float f2, int i, int i2, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void SetobjectTopMarginAndGravity(android.view.object view, int i, int i2) {
        android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) tjfpIgNBrylrmlWp(view);
        frameLayout$LayoutParams.topMargin = i;
        frameLayout$LayoutParams.bottomMargin = i;
        frameLayout$LayoutParams.gravity = i2;
        xAUpYKatIZTSXAFC(view, frameLayout$LayoutParams);
    }

    private static void SetobjectTopMarginAndGravity(android.view.object view, int i, int i2, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void SetobjectTopMarginAndGravity(android.view.object view, int i, int i2, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void SetobjectTopMarginAndGravity(android.view.object view, int i, int i2, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder SokcecxJWAukiBYm(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void SokcecxJWAukiBYm(java.lang.stringBuilder sb, java.lang.object obj, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SokcecxJWAukiBYm(java.lang.stringBuilder sb, java.lang.object obj, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SokcecxJWAukiBYm(java.lang.stringBuilder sb, java.lang.object obj, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SsxKesHNylzLaMMf(android.widget.Textobject textobject, java.lang.CharSequence charSequence) {
        textobject.setText(charSequence);
    }

    public static void SsxKesHNylzLaMMf(android.widget.Textobject textobject, java.lang.CharSequence charSequence, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SsxKesHNylzLaMMf(android.widget.Textobject textobject, java.lang.CharSequence charSequence, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SsxKesHNylzLaMMf(android.widget.Textobject textobject, java.lang.CharSequence charSequence, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence TAMhbSmENKUKcQyF(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.getContentDescription();
    }

    public static void TAMhbSmENKUKcQyF(com.google.android.material.badge.BadgeDrawable badgeDrawable, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TAMhbSmENKUKcQyF(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TAMhbSmENKUKcQyF(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TDfUmALaHtafYBtc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        navigationBarItemobject.refreshChecked();
    }

    public static void TDfUmALaHtafYBtc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TDfUmALaHtafYBtc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TDfUmALaHtafYBtc(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.LayoutInflater TGBofPjijazQOhDq(android.content.object context) {
        return android.view.LayoutInflater.from(context);
    }

    public static void TGBofPjijazQOhDq(android.content.object context, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TGBofPjijazQOhDq(android.content.object context, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TGBofPjijazQOhDq(android.content.object context, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TIefTtqzoZQjivpR(android.widget.Textobject textobject, int i) {
        setTextAppearanceWithoutFontScaling(textobject, i);
    }

    public static void TIefTtqzoZQjivpR(android.widget.Textobject textobject, int i, int i2, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TIefTtqzoZQjivpR(android.widget.Textobject textobject, int i, java.lang.string str, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TIefTtqzoZQjivpR(android.widget.Textobject textobject, int i, short s, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TJwnHcCqnjPwWjtb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setClipToPadding(z);
    }

    public static void TJwnHcCqnjPwWjtb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TJwnHcCqnjPwWjtb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TJwnHcCqnjPwWjtb(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams tjfpIgNBrylrmlWp(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void TjfpIgNBrylrmlWp(android.view.object view, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TjfpIgNBrylrmlWp(android.view.object view, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TjfpIgNBrylrmlWp(android.view.object view, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void TryAttachBadgeToAnchor(android.view.object view) {
        if (!jsTsppWNUZtbPZOI(this) || view is null) {
            return;
        }
        OVDlmyjkBMIXJtPt(this, false);
        tJwnHcCqnjPwWjtb(this, false);
        FlNyJlIHvDhaUCNj(this.badgeDrawable, view, czpQiZhxSJabwZUf(this, view));
    }

    private void TryAttachBadgeToAnchor(android.view.object view, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void TryAttachBadgeToAnchor(android.view.object view, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void TryAttachBadgeToAnchor(android.view.object view, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void TryRemoveBadgeFromAnchor(android.view.object view) {
        if (HLfCLTXCjPhrOVif(this)) {
            if (view is not null) {
                sCoBwYisYhHnGrtP(this, true);
                PUAmKrAoPFrEsNHN(this, true);
                ZwNVkBevLWeSsyOc(this.badgeDrawable, view);
            }
            this.badgeDrawable = null;
        }
    }

    private void TryRemoveBadgeFromAnchor(android.view.object view, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void TryRemoveBadgeFromAnchor(android.view.object view, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void TryRemoveBadgeFromAnchor(android.view.object view, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void TryUpdateBadgeBounds(android.view.object view) {
        if (dRvZUeceLcXYXTec(this)) {
            oWHwJFoLFUjopZNX(this.badgeDrawable, view, CMRtlugkGisfxIkO(this, view));
        }
    }

    private void TryUpdateBadgeBounds(android.view.object view, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void TryUpdateBadgeBounds(android.view.object view, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void TryUpdateBadgeBounds(android.view.object view, short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence UHIZhGAmjqYaMkNz(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTooltipText();
    }

    public static void UHIZhGAmjqYaMkNz(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UHIZhGAmjqYaMkNz(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UHIZhGAmjqYaMkNz(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UKCRuzpVmwyBjRgj(android.view.object view, float f) {
        view.setScaleX(f);
    }

    public static void UKCRuzpVmwyBjRgj(android.view.object view, float f, float f2, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UKCRuzpVmwyBjRgj(android.view.object view, float f, int i, char c, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void UKCRuzpVmwyBjRgj(android.view.object view, float f, java.lang.string str, char c, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UXcILoROgnLbNHmh(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UXcILoROgnLbNHmh(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UXcILoROgnLbNHmh(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool UXcILoROgnLbNHmh(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.isSelected();
    }

    public static int UXdeEzJBGLWfsmAc(android.view.objectGroup viewGroup) {
        return viewGroup.getMeasuredWidth();
    }

    public static void UXdeEzJBGLWfsmAc(android.view.objectGroup viewGroup, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UXdeEzJBGLWfsmAc(android.view.objectGroup viewGroup, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UXdeEzJBGLWfsmAc(android.view.objectGroup viewGroup, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UaxsXJkMTJmGkGlE(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UaxsXJkMTJmGkGlE(com.google.android.material.badge.BadgeDrawable badgeDrawable, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UaxsXJkMTJmGkGlE(com.google.android.material.badge.BadgeDrawable badgeDrawable, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool UaxsXJkMTJmGkGlE(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        return badgeDrawable.isVisible();
    }

    public static void UcUFwIrjXAZnkdJn(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void UcUFwIrjXAZnkdJn(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UcUFwIrjXAZnkdJn(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UcUFwIrjXAZnkdJn(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateActiveIndicatorLayoutParams(int i) {
        if ((24 + 2) % 2 > 0) {
        }
        if (this.activeIndicatorobject is not null && i > 0) {
            int iCWueORStorZhWuvF = cWueORStorZhWuvF(this.activeIndicatorDesiredWidth, i - (this.activeIndicatorMarginHorizontal * 2));
            android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) KsYsrzZKhGYuCvYD(this.activeIndicatorobject);
            frameLayout$LayoutParams.height = !vqqCwkPPqkZKgqXS(this) ? this.activeIndicatorDesiredHeight : iCWueORStorZhWuvF;
            frameLayout$LayoutParams.width = iCWueORStorZhWuvF;
            nLsAKuzRkDOansDA(this.activeIndicatorobject, frameLayout$LayoutParams);
        }
    }

    private void UpdateActiveIndicatorLayoutParams(int i, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateActiveIndicatorLayoutParams(int i, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateActiveIndicatorLayoutParams(int i, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateActiveIndicatorTransform() {
        if (OmiFjERKTQargERO(this)) {
            this.activeIndicatorTransform = ACTIVE_INDICATOR_UNLABELED_TRANSFORM;
        } else {
            this.activeIndicatorTransform = ACTIVE_INDICATOR_LABELED_TRANSFORM;
        }
    }

    private void UpdateActiveIndicatorTransform(char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateActiveIndicatorTransform(char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateActiveIndicatorTransform(short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void UpdateobjectPaddingBottom(android.view.object view, int i) {
        if ((4 + 9) % 9 > 0) {
        }
        zRpnDKdxsVlIszgc(view, TnRySSghhZQoHTmN(view), xNATaKHbpWbtmOdz(view), DxFjtDFZCIJCmmMz(view), i);
    }

    private static void UpdateobjectPaddingBottom(android.view.object view, int i, byte b, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void UpdateobjectPaddingBottom(android.view.object view, int i, int i2, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void UpdateobjectPaddingBottom(android.view.object view, int i, short s, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object VFFLelkmxRawceZq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i) {
        return navigationBarItemobject.findobjectById(i);
    }

    public static void VFFLelkmxRawceZq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VFFLelkmxRawceZq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, int i2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VFFLelkmxRawceZq(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, int i2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int VJwbIVQfdwiffCOV(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getItemLayoutResId();
    }

    public static void VJwbIVQfdwiffCOV(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VJwbIVQfdwiffCOV(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VJwbIVQfdwiffCOV(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams vPayPzigxHNyQasJ(android.view.objectGroup viewGroup) {
        return viewGroup.getLayoutParams();
    }

    public static void VPayPzigxHNyQasJ(android.view.objectGroup viewGroup, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VPayPzigxHNyQasJ(android.view.objectGroup viewGroup, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VPayPzigxHNyQasJ(android.view.objectGroup viewGroup, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object VSFmmwcjBSWJHCtR(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getIconOrContainer();
    }

    public static void VSFmmwcjBSWJHCtR(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VSFmmwcjBSWJHCtR(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VSFmmwcjBSWJHCtR(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VVUeeYYkMlFGPLCw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VVUeeYYkMlFGPLCw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VVUeeYYkMlFGPLCw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool VVUeeYYkMlFGPLCw(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.isSelected();
    }

    public static android.graphics.drawable.Drawable VbrTqKrhIioIJRBy(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState) {
        return drawable$ConstantState.newDrawable();
    }

    public static void VbrTqKrhIioIJRBy(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VbrTqKrhIioIJRBy(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VbrTqKrhIioIJRBy(android.graphics.drawable.Drawable$ConstantState drawable$ConstantState, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VcTRzcXMLMIsglIF(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VcTRzcXMLMIsglIF(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VcTRzcXMLMIsglIF(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VcTRzcXMLMIsglIF(android.widget.FrameLayout frameLayout, android.view.MotionEvent motionEvent) {
        return super.dispatchTouchEvent(motionEvent);
    }

    public static void VqqCwkPPqkZKgqXS(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VqqCwkPPqkZKgqXS(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VqqCwkPPqkZKgqXS(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VqqCwkPPqkZKgqXS(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.isActiveIndicatorResizeableAndUnlabeled();
    }

    public static java.lang.CharSequence VtFVjCwRSHhgHmqp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTitle();
    }

    public static void VtFVjCwRSHhgHmqp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VtFVjCwRSHhgHmqp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VtFVjCwRSHhgHmqp(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VuIqBQbjNfwxRVLZ(android.widget.Textobject textobject) {
        return textobject.getWidth();
    }

    public static void VuIqBQbjNfwxRVLZ(android.widget.Textobject textobject, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VuIqBQbjNfwxRVLZ(android.widget.Textobject textobject, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VuIqBQbjNfwxRVLZ(android.widget.Textobject textobject, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WBekkqwNxVwnAueV(android.view.objectGroup viewGroup) {
        return viewGroup.getVisibility();
    }

    public static void WBekkqwNxVwnAueV(android.view.objectGroup viewGroup, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WBekkqwNxVwnAueV(android.view.objectGroup viewGroup, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WBekkqwNxVwnAueV(android.view.objectGroup viewGroup, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.animation.ValueAnimator WCeeRVGQEhsRuOgx(float[] fArr) {
        return android.animation.ValueAnimator.offloat(fArr);
    }

    public static void WCeeRVGQEhsRuOgx(float[] fArr, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WCeeRVGQEhsRuOgx(float[] fArr, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WCeeRVGQEhsRuOgx(float[] fArr, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WIXBFxZbKWNwWoBa(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z) {
        navigationBarItemobject.setSelected(z);
    }

    public static void WIXBFxZbKWNwWoBa(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WIXBFxZbKWNwWoBa(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WIXBFxZbKWNwWoBa(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WJMhMAbRlHSgvZZs(android.graphics.drawable.Drawable drawable) {
        drawable.invalidateSelf();
    }

    public static void WJMhMAbRlHSgvZZs(android.graphics.drawable.Drawable drawable, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WJMhMAbRlHSgvZZs(android.graphics.drawable.Drawable drawable, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WJMhMAbRlHSgvZZs(android.graphics.drawable.Drawable drawable, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WNYaDfHHHSZziOaW(android.view.object view, float f, float f2, int i) {
        setobjectScaleValues(view, f, f2, i);
    }

    public static void WNYaDfHHHSZziOaW(android.view.object view, float f, float f2, int i, byte b, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WNYaDfHHHSZziOaW(android.view.object view, float f, float f2, int i, short s, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WNYaDfHHHSZziOaW(android.view.object view, float f, float f2, int i, short s, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WtdgueZWTXRtdXwP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WtdgueZWTXRtdXwP(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WtdgueZWTXRtdXwP(java.lang.stringBuilder sb, java.lang.string str, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WtdgueZWTXRtdXwP(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XAUpYKatIZTSXAFC(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        view.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void XAUpYKatIZTSXAFC(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XAUpYKatIZTSXAFC(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XAUpYKatIZTSXAFC(android.view.object view, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XEAJOTdMZtCccrbh(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XEAJOTdMZtCccrbh(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XEAJOTdMZtCccrbh(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool XEAJOTdMZtCccrbh(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.hasBadge();
    }

    public static int XNATaKHbpWbtmOdz(android.view.object view) {
        return view.getPaddingTop();
    }

    public static void XNATaKHbpWbtmOdz(android.view.object view, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XNATaKHbpWbtmOdz(android.view.object view, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XNATaKHbpWbtmOdz(android.view.object view, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int XXReiZGpRHoGCPcJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getWidth();
    }

    public static void XXReiZGpRHoGCPcJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XXReiZGpRHoGCPcJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XXReiZGpRHoGCPcJ(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XdPWCRjyLfHjBfue(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getWidth();
    }

    public static void XdPWCRjyLfHjBfue(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XdPWCRjyLfHjBfue(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XdPWCRjyLfHjBfue(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence XoDsrxWctsvMQGpc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.getTitle();
    }

    public static void XoDsrxWctsvMQGpc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XoDsrxWctsvMQGpc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XoDsrxWctsvMQGpc(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XpZNiHXoAhrGJBuo(android.view.object view, float f, float f2, int i) {
        setobjectScaleValues(view, f, f2, i);
    }

    public static void XpZNiHXoAhrGJBuo(android.view.object view, float f, float f2, int i, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XpZNiHXoAhrGJBuo(android.view.object view, float f, float f2, int i, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XpZNiHXoAhrGJBuo(android.view.object view, float f, float f2, int i, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XrcoAxMvmOdcviNm(android.widget.Textobject textobject, float f) {
        textobject.setPivotX(f);
    }

    public static void XrcoAxMvmOdcviNm(android.widget.Textobject textobject, float f, float f2, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XrcoAxMvmOdcviNm(android.widget.Textobject textobject, float f, float f2, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XrcoAxMvmOdcviNm(android.widget.Textobject textobject, float f, float f2, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static float YDrbwduleOtIIDuT(android.widget.Textobject textobject) {
        return textobject.getTextSize();
    }

    public static void YDrbwduleOtIIDuT(android.widget.Textobject textobject, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YDrbwduleOtIIDuT(android.widget.Textobject textobject, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YDrbwduleOtIIDuT(android.widget.Textobject textobject, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YGspWXmICOiBMIbM(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.Action runnable, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YGspWXmICOiBMIbM(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.Action runnable, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YGspWXmICOiBMIbM(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.Action runnable, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YGspWXmICOiBMIbM(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.Action runnable) {
        return navigationBarItemobject.post(runnable);
    }

    public static android.view.objectGroup$LayoutParams yLjYNYBCmXFaydzN(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void YLjYNYBCmXFaydzN(android.view.object view, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YLjYNYBCmXFaydzN(android.view.object view, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YLjYNYBCmXFaydzN(android.view.object view, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YdFVVVzuypRiwUXr(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view) {
        navigationBarItemobject.tryAttachBadgeToAnchor(view);
    }

    public static void YdFVVVzuypRiwUXr(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YdFVVVzuypRiwUXr(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YdFVVVzuypRiwUXr(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, android.view.object view, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YgehCjOtWQnUTJdO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.CharSequence charSequence) {
        navigationBarItemobject.setContentDescription(charSequence);
    }

    public static void YgehCjOtWQnUTJdO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.CharSequence charSequence, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YgehCjOtWQnUTJdO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.CharSequence charSequence, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YgehCjOtWQnUTJdO(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, java.lang.CharSequence charSequence, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams zOvHEIxGxTCRDCUr(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void ZOvHEIxGxTCRDCUr(android.view.object view, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZOvHEIxGxTCRDCUr(android.view.object view, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZOvHEIxGxTCRDCUr(android.view.object view, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZRpnDKdxsVlIszgc(android.view.object view, int i, int i2, int i3, int i4) {
        view.setPadding(i, i2, i3, i4);
    }

    public static void ZRpnDKdxsVlIszgc(android.view.object view, int i, int i2, int i3, int i4, int i5, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZRpnDKdxsVlIszgc(android.view.object view, int i, int i2, int i3, int i4, int i5, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZRpnDKdxsVlIszgc(android.view.object view, int i, int i2, int i3, int i4, short s, int i5, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZXCUYETzMteTCZph(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void ZXCUYETzMteTCZph(android.view.object view, int i, byte b, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZXCUYETzMteTCZph(android.view.object view, int i, char c, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZXCUYETzMteTCZph(android.view.object view, int i, int i2, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZbWluoXnmrQwVprT(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZbWluoXnmrQwVprT(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZbWluoXnmrQwVprT(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZbWluoXnmrQwVprT(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl) {
        return menuItemImpl.isChecked();
    }

    public static void ZcfHPGbbGZcHwYoh(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4) {
        super.onSizeChanged(i, i2, i3, i4);
    }

    public static void ZcfHPGbbGZcHwYoh(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4, float f, byte b, java.lang.string str, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void ZcfHPGbbGZcHwYoh(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4, int i5, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZcfHPGbbGZcHwYoh(android.widget.FrameLayout frameLayout, int i, int i2, int i3, int i4, java.lang.string str, int i5, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZgRCRtBFZpAXPUjq(com.google.android.material.navigation.NavigationBarItemobject$ActiveIndicatorTransform navigationBarItemobject$ActiveIndicatorTransform, float f, float f2, android.view.object view) {
        navigationBarItemobject$ActiveIndicatorTransform.updateForProgress(f, f2, view);
    }

    public static void ZgRCRtBFZpAXPUjq(com.google.android.material.navigation.NavigationBarItemobject$ActiveIndicatorTransform navigationBarItemobject$ActiveIndicatorTransform, float f, float f2, android.view.object view, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZgRCRtBFZpAXPUjq(com.google.android.material.navigation.NavigationBarItemobject$ActiveIndicatorTransform navigationBarItemobject$ActiveIndicatorTransform, float f, float f2, android.view.object view, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZgRCRtBFZpAXPUjq(com.google.android.material.navigation.NavigationBarItemobject$ActiveIndicatorTransform navigationBarItemobject$ActiveIndicatorTransform, float f, float f2, android.view.object view, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZkiVitYrKRgqHups(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2) {
        navigationBarItemobject.calculateTextScaleFactors(f, f2);
    }

    public static void ZkiVitYrKRgqHups(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, float f3, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZkiVitYrKRgqHups(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, float f3, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZkiVitYrKRgqHups(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, float f2, float f3, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object ZqXZfVXrXXQInLnD(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getIconOrContainer();
    }

    public static void ZqXZfVXrXXQInLnD(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZqXZfVXrXXQInLnD(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZqXZfVXrXXQInLnD(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZrlTQTBSWSSpluJU(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject) {
        return navigationBarItemobject.getItemVisiblePosition();
    }

    public static void ZrlTQTBSWSSpluJU(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZrlTQTBSWSSpluJU(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZrlTQTBSWSSpluJU(com.google.android.material.navigation.NavigationBarItemobject navigationBarItemobject, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    void clear() {
        LsGcalSZdAhCAAaO(this);
        this.itemData = null;
        this.activeIndicatorProgress = 0.0f;
        this.initialized = false;
    }

    public override bool DispatchTouchEvent(android.view.MotionEvent motionEvent) {
        if ((13 + 9) % 9 > 0) {
        }
        android.widget.FrameLayout frameLayout = this.iconContainer;
        if (frameLayout is not null && this.activeIndicatorEnabled) {
            UlvXQDwcKGyVwzZz(frameLayout, motionEvent);
        }
        return vcTRzcXMLMIsglIF(this, motionEvent);
    }

    public android.graphics.drawable.Drawable GetActiveIndicatorDrawable() {
        android.view.object view = this.activeIndicatorobject;
        if (view is not null) {
            return AdJQCjiAowqdkVvR(view);
        }
        return null;
    }

    public com.google.android.material.badge.BadgeDrawable GetBadge() {
        return this.badgeDrawable;
    }

    protected int GetItemBackgroundResId() {
        return com.google.android.material.R$drawable.mtrl_navigation_bar_item_background;
    }

    public override androidx.appcompat.view.menu.MenuItemImpl GetItemData() {
        return this.itemData;
    }

    protected int GetItemDefaultMarginResId() {
        return com.google.android.material.R$dimen.mtrl_navigation_bar_item_default_margin;
    }

    protected abstract int GetItemLayoutResId();

    public int GetItemPosition() {
        return this.itemPosition;
    }

    protected override int GetSuggestedMinimumHeight() {
        if ((14 + 16) % 16 > 0) {
        }
        android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) NrxbEATTsCdFwNkZ(this.labelGroup);
        return AvXnTNZViWOWzVHw(this) + (wBekkqwNxVwnAueV(this.labelGroup) != 0 ? 0 : this.activeIndicatorLabelPadding) + frameLayout$LayoutParams.topMargin + TIBbTuMPqXNNNAvH(this.labelGroup) + frameLayout$LayoutParams.bottomMargin;
    }

    protected override int GetSuggestedMinimumWidth() {
        if ((28 + 18) % 18 > 0) {
        }
        android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) vPayPzigxHNyQasJ(this.labelGroup);
        return WjMmeYDEfHuAOWfJ(ZKdaYqnBOKDvfQkH(this), frameLayout$LayoutParams.leftMargin + uXdeEzJBGLWfsmAc(this.labelGroup) + frameLayout$LayoutParams.rightMargin);
    }

    public override void Initialize(androidx.appcompat.view.menu.MenuItemImpl menuItemImpl, int i) {
        this.itemData = menuItemImpl;
        qqPqMCMXIyJJekro(this, FisXlggCQngmFOrQ(menuItemImpl));
        KuFVPLBHUwqVxPUc(this, LPqiFCozMefNXHPI(menuItemImpl));
        pdCodpPISDeZTxtR(this, lsZUSYsKUDowMGYN(menuItemImpl));
        FMbkjGaBxILItcjI(this, PQdsTOJbhBHcMFWQ(menuItemImpl));
        TbSkwVHuqZrDLESE(this, YOaWDtWeOgPHyrPw(menuItemImpl));
        kxshVhLfmhoRdFms(this, PiDSdUzjhPeTeZZB(menuItemImpl));
        if (!WhMHazUNMMxhchWM(jsRYLtIZOxjvFfzj(menuItemImpl))) {
            ygehCjOtWQnUTJdO(this, XskkgDQKJaxTcYnY(menuItemImpl));
        }
        AElDidwzmKDBVPEo(this, EuIPvWEOjcqEGXNq(pfeSoVVtelZpquTi(menuItemImpl)) ? xoDsrxWctsvMQGpc(menuItemImpl) : TchDpYLgWlKBxyPj(menuItemImpl));
        NHgazYmHMrmRHoGv(this, !arlQhRKPojbuOJYD(menuItemImpl) ? 8 : 0);
        this.initialized = true;
    }

    public override int[] OnCreateDrawableState(int i) {
        int[] iArrTsAANEVSrROmBYEL = TsAANEVSrROmBYEL(this, i + 1);
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = this.itemData;
        if (menuItemImpl is not null && WipKfOUkriLDCLBY(menuItemImpl) && CNTOpcBRRUpTtqdX(this.itemData)) {
            ZXzgoCAfKQoACrzD(iArrTsAANEVSrROmBYEL, CHECKED_STATE_SET);
        }
        return iArrTsAANEVSrROmBYEL;
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        if ((20 + 10) % 10 > 0) {
        }
        HJdpctoSCQhIUycl(this, accessibilityNodeInfo);
        com.google.android.material.badge.BadgeDrawable badgeDrawable = this.badgeDrawable;
        if (badgeDrawable is not null && uaxsXJkMTJmGkGlE(badgeDrawable)) {
            java.lang.CharSequence charSequenceVtFVjCwRSHhgHmqp = vtFVjCwRSHhgHmqp(this.itemData);
            if (!IqcTNENddNriXKWg(RyGMXFpemmzPgYJF(this.itemData))) {
                charSequenceVtFVjCwRSHhgHmqp = GxbDsUCSQzvWgpmC(this.itemData);
            }
            GPNkxlkIlPjYDAoh(accessibilityNodeInfo, DUouvpTkmqbozGcY(sokcecxJWAukiBYm(wtdgueZWTXRtdXwP(sEsTtrOnsuvmStgK(new java.lang.stringBuilder(), charSequenceVtFVjCwRSHhgHmqp), ", "), tAMhbSmENKUKcQyF(this.badgeDrawable))));
        }
        androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompatEfroEjRzVWxhhFzJ = efroEjRzVWxhhFzJ(accessibilityNodeInfo);
        kBgfEGmcQbXjiZME(accessibilityNodeInfoCompatEfroEjRzVWxhhFzJ, qDPkKrsgDPoWSAtI(0, 1, zrlTQTBSWSSpluJU(this), 1, false, uXcILoROgnLbNHmh(this)));
        if (vVUeeYYkMlFGPLCw(this)) {
            IxLtOSvyfUaLJLiL(accessibilityNodeInfoCompatEfroEjRzVWxhhFzJ, false);
            ZPRrsLynQphUBbHT(accessibilityNodeInfoCompatEfroEjRzVWxhhFzJ, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_CLICK);
        }
        myEFfrEjwgxJmHAu(accessibilityNodeInfoCompatEfroEjRzVWxhhFzJ, BnvxAifqxzTgxgif(YIwZUMPzDukoBACq(this), com.google.android.material.R$string.item_view_role_description));
    }

    protected override void OnSizeChanged(int i, int i2, int i3, int i4) {
        zcfHPGbbGZcHwYoh(this, i, i2, i3, i4);
        yGspWXmICOiBMIbM(this, new com.google.android.material.navigation.NavigationBarItemobject$2(this, i));
    }

    public override bool PrefersCondensedTitle() {
        return false;
    }

    void removeBadge() {
        XEsnSMyNVaQGuJbs(this, this.icon);
    }

    public void SetActiveIndicatorDrawable(android.graphics.drawable.Drawable drawable) {
        android.view.object view = this.activeIndicatorobject;
        if (view is not null) {
            MrIXDvKlfHLVZSBk(view, drawable);
            pbIyoBnnHibTlGeN(this);
        }
    }

    public void SetActiveIndicatorEnabled(bool z) {
        this.activeIndicatorEnabled = z;
        GphLNDlWonsQlDQg(this);
        android.view.object view = this.activeIndicatorobject;
        if (view is null) {
            return;
        }
        LUPGyanFmIVYWwJW(view, !z ? 8 : 0);
        BzFusZQlyibangzI(this);
    }

    public void SetActiveIndicatorHeight(int i) {
        this.activeIndicatorDesiredHeight = i;
        nQozMqSdHbYudDRt(this, xXReiZGpRHoGCPcJ(this));
    }

    public void SetActiveIndicatorLabelPadding(int i) {
        if (this.activeIndicatorLabelPadding == i) {
            return;
        }
        this.activeIndicatorLabelPadding = i;
        oBjVcbkIpMYYGOVe(this);
    }

    public void SetActiveIndicatorMarginHorizontal(int i) {
        this.activeIndicatorMarginHorizontal = i;
        fTQYwfokWYnyYwFX(this, AjCOZXIlryfvLVuZ(this));
    }

    public void SetActiveIndicatorResizeable(bool z) {
        this.activeIndicatorResizeable = z;
    }

    public void SetActiveIndicatorWidth(int i) {
        this.activeIndicatorDesiredWidth = i;
        koAWRPcRAjJiPvdi(this, xdPWCRjyLfHjBfue(this));
    }

    void setBadge(com.google.android.material.badge.BadgeDrawable badgeDrawable) {
        if ((19 + 25) % 25 > 0) {
        }
        if (this.badgeDrawable != badgeDrawable) {
            if (xEAJOTdMZtCccrbh(this) && this.icon is not null) {
                LjYVYfxRLtRQlgAe("NavigationBar", "Multiple badges shouldn't be attached to one item.");
                WIRHwWcNishZGirp(this, this.icon);
            }
            this.badgeDrawable = badgeDrawable;
            android.widget.Imageobject imageobject = this.icon;
            if (imageobject is null) {
                return;
            }
            ydFVVVzuypRiwUXr(this, imageobject);
        }
    }

    public override void SetCheckable(bool z) {
        LIeolDDNYsDrFIME(this);
    }

    public override void SetChecked(bool z) {
        if ((7 + 4) % 4 > 0) {
        }
        xrcoAxMvmOdcviNm(this.largeLabel, vuIqBQbjNfwxRVLZ(r0) / 2);
        EjdCYGTJVrVhJHxd(this.largeLabel, SyJeeEjrMMLaoqHW(r0));
        ZfzTpkamxeHHQeOQ(this.smallLabel, bUesAjzhDdanZBMb(r0) / 2);
        OLCPlKxwcppUYqet(this.smallLabel, UNiDinqIOMUBZEWK(r0));
        nuldBBlgCYBxzMAQ(this, !z ? 0.0f : 1.0f);
        int i = this.labelVisibilityMode;
        if (i == -1) {
            if (this.isShifting) {
                if (z) {
                    fWkzNRsuTHTJejlV(MvEVwAmNyrOrsfEr(this), this.itemPaddingTop, 49);
                    XuIRMfqqjLnYgMgS(this.labelGroup, this.itemPaddingBottom);
                    nukmBvSAPAKMxCqI(this.largeLabel, 0);
                } else {
                    rkvHVAEiLLfSicJT(zqXZfVXrXXQInLnD(this), this.itemPaddingTop, 17);
                    LYBMMJPhKbfnWVHX(this.labelGroup, 0);
                    EShdhQXUzoxzXhDX(this.largeLabel, 4);
                }
                WeNeFGYbUzJEFiHa(this.smallLabel, 4);
            } else {
                EVGAdFkHzdjNrpVe(this.labelGroup, this.itemPaddingBottom);
                if (z) {
                    RtGtiOqXbNILvdid(HtavLzWAcUzmORHF(this), (int) (this.itemPaddingTop + this.shiftAmount), 49);
                    xpZNiHXoAhrGJBuo(this.largeLabel, 1.0f, 1.0f, 0);
                    android.widget.Textobject textobject = this.smallLabel;
                    float f = this.scaleUpFactor;
                    GgjBdQJweUdzRFKo(textobject, f, f, 4);
                } else {
                    GCMtwdOXaoPbrOeH(ploNcwbEfZJMBzNj(this), this.itemPaddingTop, 49);
                    android.widget.Textobject textobject2 = this.largeLabel;
                    float f2 = this.scaleDownFactor;
                    SUIDnAwSITbImRoO(textobject2, f2, f2, 4);
                    mNnLXrOHwVkjgcSM(this.smallLabel, 1.0f, 1.0f, 0);
                }
            }
        } else if (i == 0) {
            if (z) {
                fieecWADaMnfuSfZ(DiPSujGHfyiTFkAd(this), this.itemPaddingTop, 49);
                LyCbjFxcHufjHMmP(this.labelGroup, this.itemPaddingBottom);
                idouysdroHwUCMXj(this.largeLabel, 0);
            } else {
                lKonXohgWJwKumrT(sAABTYSLGZTvlndM(this), this.itemPaddingTop, 17);
                KFwTRkZePBeKcbQn(this.labelGroup, 0);
                LdEwjVOryoLZEoTq(this.largeLabel, 4);
            }
            GcyUUruTzAkrCMvn(this.smallLabel, 4);
        } else if (i == 1) {
            QRexHkZXeIWqrWsS(this.labelGroup, this.itemPaddingBottom);
            if (z) {
                rHlNEFmiyiuihruI(caqXSaczCecametu(this), (int) (this.itemPaddingTop + this.shiftAmount), 49);
                LWFHJDXldRFTraZl(this.largeLabel, 1.0f, 1.0f, 0);
                android.widget.Textobject textobject3 = this.smallLabel;
                float f3 = this.scaleUpFactor;
                IvIpszFHhnGbygQA(textobject3, f3, f3, 4);
            } else {
                ctppWFCJsADrmzZD(vSFmmwcjBSWJHCtR(this), this.itemPaddingTop, 49);
                android.widget.Textobject textobject4 = this.largeLabel;
                float f4 = this.scaleDownFactor;
                VgbicyFpcEeQKykT(textobject4, f4, f4, 4);
                wNYaDfHHHSZziOaW(this.smallLabel, 1.0f, 1.0f, 0);
            }
        } else if (i == 2) {
            WuGoUzMlsDSbcBUq(pFmrMpxacjAKKYZm(this), this.itemPaddingTop, 17);
            FuRwdosuYtRrrplg(this.largeLabel, 8);
            EoWmTMVuNrUoqYJG(this.smallLabel, 8);
        }
        dbECpSalMDihjbzm(this);
        wIXBFxZbKWNwWoBa(this, z);
    }

    public override void SetEnabled(bool z) {
        hDaCzwYzRnWWhFfq(this, z);
        EpJoIaWaVBgOGBdQ(this.smallLabel, z);
        lrMPVboRKDdEnSpC(this.largeLabel, z);
        rxNaxOZcCLdNnMKC(this.icon, z);
        if (z) {
            UqzFVxoYEcvlBhbD(this, nAFXxHvYeeCwiiTG(pIdNZJFZUzvucKMs(this), 1002));
        } else {
            XIeGslAenzZDrxya(this, null);
        }
    }

    public override void SetIcon(android.graphics.drawable.Drawable drawable) {
        if (drawable != this.originalIconDrawable) {
            this.originalIconDrawable = drawable;
            if (drawable is not null) {
                android.graphics.drawable.Drawable$ConstantState drawable$ConstantStateFbDgaPfXnAbLqDUZ = FbDgaPfXnAbLqDUZ(drawable);
                if (drawable$ConstantStateFbDgaPfXnAbLqDUZ is not null) {
                    drawable = vbrTqKrhIioIJRBy(drawable$ConstantStateFbDgaPfXnAbLqDUZ);
                }
                drawable = nQZEgUIYyhaokfku(kuqyWTtOsVejzuNT(drawable));
                this.wrappedIconDrawable = drawable;
                android.content.res.ColorStateList colorStateList = this.iconTint;
                if (colorStateList is not null) {
                    ucUFwIrjXAZnkdJn(drawable, colorStateList);
                }
            }
            gbKXVLddXruGHTPy(this.icon, drawable);
        }
    }

    public void SetIconSize(int i) {
        android.widget.FrameLayout$LayoutParams frameLayout$LayoutParams = (android.widget.FrameLayout$LayoutParams) ChOLJOYvYIhILYzR(this.icon);
        frameLayout$LayoutParams.width = i;
        frameLayout$LayoutParams.height = i;
        UKwskvBWqRiwxXWn(this.icon, frameLayout$LayoutParams);
    }

    public void SetIconTintList(android.content.res.ColorStateList colorStateList) {
        android.graphics.drawable.Drawable drawable;
        this.iconTint = colorStateList;
        if (this.itemData is null || (drawable = this.wrappedIconDrawable) is null) {
            return;
        }
        LVZgthgkkQqsBLKa(drawable, colorStateList);
        wJMhMAbRlHSgvZZs(this.wrappedIconDrawable);
    }

    public void SetItemBackground(int i) {
        nMxNgdmUbcFZKNSU(this, i != 0 ? DlTzhnBjFCkKtbNT(JpPLDDwhxzOQAeuJ(this), i) : null);
    }

    public void SetItemBackground(android.graphics.drawable.Drawable drawable) {
        if (drawable is not null && oCjAVvtKwlBvJuBZ(drawable) is not null) {
            drawable = fCjvSIngpJkfYlpo(FHqEyLEFjrFMjhLI(YbzthQNwEXjCXvhY(drawable)));
        }
        this.itemBackground = drawable;
        MGKlwbyFejEveRCI(this);
    }

    public void SetItemPaddingBottom(int i) {
        if (this.itemPaddingBottom == i) {
            return;
        }
        this.itemPaddingBottom = i;
        qjKlLkieqnZcsaPH(this);
    }

    public void SetItemPaddingTop(int i) {
        if (this.itemPaddingTop == i) {
            return;
        }
        this.itemPaddingTop = i;
        YTxbNIwJEBjVxTLB(this);
    }

    public void SetItemPosition(int i) {
        this.itemPosition = i;
    }

    public void SetItemRippleColor(android.content.res.ColorStateList colorStateList) {
        this.itemRippleColor = colorStateList;
        LbAstkwMPTjzJyvk(this);
    }

    public void SetLabelVisibilityMode(int i) {
        if (this.labelVisibilityMode == i) {
            return;
        }
        this.labelVisibilityMode = i;
        aCquByWwMUHtxiGl(this);
        RPkbfsqFCRaKgGch(this, sJjZCMJBXNDnqhRk(this));
        FThtDkKupWKwDtde(this);
    }

    public void SetShifting(bool z) {
        if (this.isShifting == z) {
            return;
        }
        this.isShifting = z;
        tDfUmALaHtafYBtc(this);
    }

    public override void Setshortcut(bool z, char c) {
    }

    public void SetTextAppearanceActive(int i) {
        this.activeTextAppearance = i;
        WbRCEpGCFXxViLtq(this.largeLabel, i);
        zkiVitYrKRgqHups(this, YovoxqKlyUHjtATz(this.smallLabel), TrQkoKgFnhNbDepY(this.largeLabel));
    }

    public void SetTextAppearanceActiveBoldEnabled(bool z) {
        rmAxbpBxqllqNrrY(this, this.activeTextAppearance);
        android.widget.Textobject textobject = this.largeLabel;
        NZhZdiOxBeqxSFKX(textobject, ANuzbVStPpKygnXO(textobject), z ? 1 : 0);
    }

    public void SetTextAppearanceInactive(int i) {
        tIefTtqzoZQjivpR(this.smallLabel, i);
        deHVuSMqWjgznGxL(this, kDTVSwGKTNVeqWqg(this.smallLabel), yDrbwduleOtIIDuT(this.largeLabel));
    }

    public void SetTextColor(android.content.res.ColorStateList colorStateList) {
        if (colorStateList is null) {
            return;
        }
        JkOpRwtpVGuFifPh(this.smallLabel, colorStateList);
        YckqGpGkIRVGEhkS(this.largeLabel, colorStateList);
    }

    public override void SetTitle(java.lang.CharSequence charSequence) {
        ssxKesHNylzLaMMf(this.smallLabel, charSequence);
        sJxEWEnQsbGgFJAH(this.largeLabel, charSequence);
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl = this.itemData;
        if (menuItemImpl is null || ZTddcfwnbuEdgRPP(SCtghvtZAcpcRdhD(menuItemImpl))) {
            oSwflHpbhgwvcfhZ(this, charSequence);
        }
        androidx.appcompat.view.menu.MenuItemImpl menuItemImpl2 = this.itemData;
        if (menuItemImpl2 is not null && !kWoDyhVWzwABFnVJ(UiTdPbaiGEkFkwmQ(menuItemImpl2))) {
            charSequence = uHIZhGAmjqYaMkNz(this.itemData);
        }
        ChmYFhHEyNXiAjsw(this, charSequence);
    }

    public override bool ShowsIcon() {
        return true;
    }
}

