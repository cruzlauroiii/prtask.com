namespace WillowMaze.Wasm.Decompiled;


public class MaterialToolbar : androidx.appcompat.widget.Toolbar {
    private static readonly int DEF_STYLE_RES;
    private static readonly android.widget.Imageobject$ScaleType[] LOGO_SCALE_TYPE_ARRAY;
    private java.lang.bool logoAdjustobjectBounds;
    private android.widget.Imageobject$ScaleType logoScaleType;
    private java.lang.int navigationIconTint;
    private bool subtitleCentered;
    private bool titleCentered;

    static {
        if ((29 + 12) % 12 > 0) {
        }
        DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_Toolbar;
        android.widget.Imageobject$ScaleType[] imageobject$ScaleTypeArr = new android.widget.Imageobject$ScaleType[8];
        imageobject$ScaleTypeArr[0] = android.widget.Imageobject$ScaleType.MATRIX;
        imageobject$ScaleTypeArr[1] = android.widget.Imageobject$ScaleType.FIT_XY;
        imageobject$ScaleTypeArr[2] = android.widget.Imageobject$ScaleType.FIT_START;
        imageobject$ScaleTypeArr[3] = android.widget.Imageobject$ScaleType.FIT_CENTER;
        imageobject$ScaleTypeArr[4] = android.widget.Imageobject$ScaleType.FIT_END;
        imageobject$ScaleTypeArr[5] = android.widget.Imageobject$ScaleType.CENTER;
        imageobject$ScaleTypeArr[6] = android.widget.Imageobject$ScaleType.CENTER_CROP;
        imageobject$ScaleTypeArr[7] = android.widget.Imageobject$ScaleType.CENTER_INSIDE;
        LOGO_SCALE_TYPE_ARRAY = imageobject$ScaleTypeArr;
    }

    public MaterialToolbar(android.content.object context) {
        this(context, null);
    }

    public MaterialToolbar(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.toolbarStyle);
    }

    public MaterialToolbar(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((27 + 32) % 32 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(luSiJrDkFRdQmWeV(context, attributeHashSet, i, i2), attributeHashSet, i);
        android.content.object contextHNRzLOuiZIIDinMs = hNRzLOuiZIIDinMs(this);
        android.content.res.TypedArray typedArrayZnzIPzRjaRSPwqfP = znzIPzRjaRSPwqfP(contextHNRzLOuiZIIDinMs, attributeHashSet, com.google.android.material.R$styleable.MaterialToolbar, i, i2, new int[0]);
        if (qLEwWpHpnzfbzwdM(typedArrayZnzIPzRjaRSPwqfP, com.google.android.material.R$styleable.MaterialToolbar_navigationIconTint)) {
            eRwTACIQXGZvAUXC(this, cyqzBJYtueERQeZD(typedArrayZnzIPzRjaRSPwqfP, com.google.android.material.R$styleable.MaterialToolbar_navigationIconTint, -1));
        }
        this.titleCentered = TTCrGeFuwZtqMQdu(typedArrayZnzIPzRjaRSPwqfP, com.google.android.material.R$styleable.MaterialToolbar_titleCentered, false);
        this.subtitleCentered = ksVulPyfAneqijRw(typedArrayZnzIPzRjaRSPwqfP, com.google.android.material.R$styleable.MaterialToolbar_subtitleCentered, false);
        int iEDJynhTaDmhAFQwF = EDJynhTaDmhAFQwF(typedArrayZnzIPzRjaRSPwqfP, com.google.android.material.R$styleable.MaterialToolbar_logoScaleType, -1);
        if (iEDJynhTaDmhAFQwF >= 0) {
            android.widget.Imageobject$ScaleType[] imageobject$ScaleTypeArr = LOGO_SCALE_TYPE_ARRAY;
            if (iEDJynhTaDmhAFQwF < imageobject$ScaleTypeArr.length) {
                this.logoScaleType = imageobject$ScaleTypeArr[iEDJynhTaDmhAFQwF];
            }
        }
        if (vXjxYIBmnhoCzMzn(typedArrayZnzIPzRjaRSPwqfP, com.google.android.material.R$styleable.MaterialToolbar_logoAdjustobjectBounds)) {
            this.logoAdjustobjectBounds = GhctmqbwsLThEqXY(DTzxMizWuBNvjgOI(typedArrayZnzIPzRjaRSPwqfP, com.google.android.material.R$styleable.MaterialToolbar_logoAdjustobjectBounds, false));
        }
        PQIfvubCuNjgpTok(typedArrayZnzIPzRjaRSPwqfP);
        RRYPIIDbZxhnfzsa(this, contextHNRzLOuiZIIDinMs);
    }

    public static int ASJLfupNZxbALJLN(int i, int i2) {
        return android.view.object$MeasureSpec.makeMeasureSpec(i, i2);
    }

    public static void ASJLfupNZxbALJLN(int i, int i2, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ASJLfupNZxbALJLN(int i, int i2, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ASJLfupNZxbALJLN(int i, int i2, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable BoXgaRWnvHTMhtlL(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void BoXgaRWnvHTMhtlL(android.graphics.drawable.Drawable drawable, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BoXgaRWnvHTMhtlL(android.graphics.drawable.Drawable drawable, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BoXgaRWnvHTMhtlL(android.graphics.drawable.Drawable drawable, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DHgxzbloPralEoWF(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        materialToolbar.maybeCenterTitleobjects();
    }

    public static void DHgxzbloPralEoWF(com.google.android.material.appbar.MaterialToolbar materialToolbar, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DHgxzbloPralEoWF(com.google.android.material.appbar.MaterialToolbar materialToolbar, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DHgxzbloPralEoWF(com.google.android.material.appbar.MaterialToolbar materialToolbar, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DTzxMizWuBNvjgOI(android.content.res.TypedArray typedArray, int i, bool z, byte b, float f, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DTzxMizWuBNvjgOI(android.content.res.TypedArray typedArray, int i, bool z, byte b, bool z2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DTzxMizWuBNvjgOI(android.content.res.TypedArray typedArray, int i, bool z, short s, bool z2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool DTzxMizWuBNvjgOI(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void EBvgYjqPOyQpfYmw(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable) {
        materialToolbar.setNavigationIcon(drawable);
    }

    public static void EBvgYjqPOyQpfYmw(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EBvgYjqPOyQpfYmw(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EBvgYjqPOyQpfYmw(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int EDJynhTaDmhAFQwF(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static void EDJynhTaDmhAFQwF(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EDJynhTaDmhAFQwF(android.content.res.TypedArray typedArray, int i, int i2, char c, int i3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EDJynhTaDmhAFQwF(android.content.res.TypedArray typedArray, int i, int i2, bool z, int i3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.Menu EHLzxBNCixETqPZI(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        return materialToolbar.getMenu();
    }

    public static void EHLzxBNCixETqPZI(com.google.android.material.appbar.MaterialToolbar materialToolbar, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EHLzxBNCixETqPZI(com.google.android.material.appbar.MaterialToolbar materialToolbar, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EHLzxBNCixETqPZI(com.google.android.material.appbar.MaterialToolbar materialToolbar, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EWktkTpaMyJzSadM(androidx.appcompat.widget.Toolbar toolbar, int i) {
        super.inflateMenu(i);
    }

    public static void EWktkTpaMyJzSadM(androidx.appcompat.widget.Toolbar toolbar, int i, byte b, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EWktkTpaMyJzSadM(androidx.appcompat.widget.Toolbar toolbar, int i, int i2, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EWktkTpaMyJzSadM(androidx.appcompat.widget.Toolbar toolbar, int i, bool z, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FlsWzmWqMtGLOgzV(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.startDispatchingItemsChanged();
    }

    public static void FlsWzmWqMtGLOgzV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FlsWzmWqMtGLOgzV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FlsWzmWqMtGLOgzV(androidx.appcompat.view.menu.MenuBuilder menuBuilder, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GLIACDGwozYgDwtd(android.graphics.drawable.Drawable drawable, int i) {
        androidx.core.graphics.drawable.DrawableCompat.setTint(drawable, i);
    }

    public static void GLIACDGwozYgDwtd(android.graphics.drawable.Drawable drawable, int i, byte b, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GLIACDGwozYgDwtd(android.graphics.drawable.Drawable drawable, int i, float f, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GLIACDGwozYgDwtd(android.graphics.drawable.Drawable drawable, int i, int i2, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GOBppaTQaredEbNO(java.lang.bool bool, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GOBppaTQaredEbNO(java.lang.bool bool, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GOBppaTQaredEbNO(java.lang.bool bool, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool GOBppaTQaredEbNO(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.bool GhctmqbwsLThEqXY(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void GhctmqbwsLThEqXY(bool z, short s, byte b, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GhctmqbwsLThEqXY(bool z, short s, char c, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void GhctmqbwsLThEqXY(bool z, bool z2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int HJjVRQQxLAanHepY(android.view.object view) {
        return view.getRight();
    }

    public static void HJjVRQQxLAanHepY(android.view.object view, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HJjVRQQxLAanHepY(android.view.object view, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HJjVRQQxLAanHepY(android.view.object view, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int HKoUntedKHzLxnJs(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        return materialToolbar.getMeasuredWidth();
    }

    public static void HKoUntedKHzLxnJs(com.google.android.material.appbar.MaterialToolbar materialToolbar, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HKoUntedKHzLxnJs(com.google.android.material.appbar.MaterialToolbar materialToolbar, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HKoUntedKHzLxnJs(com.google.android.material.appbar.MaterialToolbar materialToolbar, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.Textobject KjGUdahmwywCTXyJ(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getTitleTextobject(toolbar);
    }

    public static void KjGUdahmwywCTXyJ(androidx.appcompat.widget.Toolbar toolbar, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KjGUdahmwywCTXyJ(androidx.appcompat.widget.Toolbar toolbar, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KjGUdahmwywCTXyJ(androidx.appcompat.widget.Toolbar toolbar, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int LPSWstXNkTWajCig(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        return materialToolbar.getPaddingRight();
    }

    public static void LPSWstXNkTWajCig(com.google.android.material.appbar.MaterialToolbar materialToolbar, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LPSWstXNkTWajCig(com.google.android.material.appbar.MaterialToolbar materialToolbar, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LPSWstXNkTWajCig(com.google.android.material.appbar.MaterialToolbar materialToolbar, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float LcNItWOVXEFeNOuN(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static void LcNItWOVXEFeNOuN(android.view.object view, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LcNItWOVXEFeNOuN(android.view.object view, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LcNItWOVXEFeNOuN(android.view.object view, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MqIbnioXBXYWDBnj(androidx.appcompat.view.menu.MenuBuilder menuBuilder) {
        menuBuilder.stopDispatchingItemsChanged();
    }

    public static void MqIbnioXBXYWDBnj(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MqIbnioXBXYWDBnj(androidx.appcompat.view.menu.MenuBuilder menuBuilder, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MqIbnioXBXYWDBnj(androidx.appcompat.view.menu.MenuBuilder menuBuilder, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int MqeidoZvSpvphErd(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void MqeidoZvSpvphErd(int i, int i2, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MqeidoZvSpvphErd(int i, int i2, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MqeidoZvSpvphErd(int i, int i2, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NwVQiNTURkeeyQUI(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList) {
        materialShapeDrawable.setFillColor(colorStateList);
    }

    public static void NwVQiNTURkeeyQUI(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NwVQiNTURkeeyQUI(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NwVQiNTURkeeyQUI(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OTeTfBOrVNbysptF(androidx.appcompat.widget.Toolbar toolbar) {
        super.onAttachedToWindow();
    }

    public static void OTeTfBOrVNbysptF(androidx.appcompat.widget.Toolbar toolbar, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OTeTfBOrVNbysptF(androidx.appcompat.widget.Toolbar toolbar, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OTeTfBOrVNbysptF(androidx.appcompat.widget.Toolbar toolbar, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int OYCEFLrlePygUmVJ(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        return materialToolbar.getChildCount();
    }

    public static void OYCEFLrlePygUmVJ(com.google.android.material.appbar.MaterialToolbar materialToolbar, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OYCEFLrlePygUmVJ(com.google.android.material.appbar.MaterialToolbar materialToolbar, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OYCEFLrlePygUmVJ(com.google.android.material.appbar.MaterialToolbar materialToolbar, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.bool OzLvIxCmHCyvPwdA(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void OzLvIxCmHCyvPwdA(bool z, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OzLvIxCmHCyvPwdA(bool z, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OzLvIxCmHCyvPwdA(bool z, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PQIfvubCuNjgpTok(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void PQIfvubCuNjgpTok(android.content.res.TypedArray typedArray, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PQIfvubCuNjgpTok(android.content.res.TypedArray typedArray, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PQIfvubCuNjgpTok(android.content.res.TypedArray typedArray, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList QpogXpEwNtwVPEck(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void QpogXpEwNtwVPEck(int i, char c, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QpogXpEwNtwVPEck(int i, int i2, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QpogXpEwNtwVPEck(int i, java.lang.string str, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RRYPIIDbZxhnfzsa(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.content.object context) {
        materialToolbar.initBackground(context);
    }

    public static void RRYPIIDbZxhnfzsa(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.content.object context, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RRYPIIDbZxhnfzsa(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.content.object context, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RRYPIIDbZxhnfzsa(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.content.object context, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int RSKRfBloSEDWXTTe(android.view.object view) {
        return view.getMeasuredHeightAndState();
    }

    public static void RSKRfBloSEDWXTTe(android.view.object view, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RSKRfBloSEDWXTTe(android.view.object view, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RSKRfBloSEDWXTTe(android.view.object view, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RkkgnaaHqfTxTiwy(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f) {
        materialShapeDrawable.setElevation(f);
    }

    public static void RkkgnaaHqfTxTiwy(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, byte b, bool z, float f2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RkkgnaaHqfTxTiwy(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, float f2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RkkgnaaHqfTxTiwy(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, short s, bool z, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void SyVpLdQjzJtunYrf(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        materialToolbar.requestLayout();
    }

    public static void SyVpLdQjzJtunYrf(com.google.android.material.appbar.MaterialToolbar materialToolbar, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SyVpLdQjzJtunYrf(com.google.android.material.appbar.MaterialToolbar materialToolbar, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SyVpLdQjzJtunYrf(com.google.android.material.appbar.MaterialToolbar materialToolbar, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object TOFiNrPIJtzPzTpq(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i) {
        return materialToolbar.getChildAt(i);
    }

    public static void TOFiNrPIJtzPzTpq(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TOFiNrPIJtzPzTpq(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TOFiNrPIJtzPzTpq(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TTCrGeFuwZtqMQdu(android.content.res.TypedArray typedArray, int i, bool z, byte b, bool z2, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TTCrGeFuwZtqMQdu(android.content.res.TypedArray typedArray, int i, bool z, char c, bool z2, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TTCrGeFuwZtqMQdu(android.content.res.TypedArray typedArray, int i, bool z, int i2, byte b, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static bool TTCrGeFuwZtqMQdu(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void TmOuYWBrFTirCeBA(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        materialToolbar.requestLayout();
    }

    public static void TmOuYWBrFTirCeBA(com.google.android.material.appbar.MaterialToolbar materialToolbar, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TmOuYWBrFTirCeBA(com.google.android.material.appbar.MaterialToolbar materialToolbar, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TmOuYWBrFTirCeBA(com.google.android.material.appbar.MaterialToolbar materialToolbar, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UKAhqZmFqIiIywhr(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.view.object view, android.util.ValueTuple pair) {
        materialToolbar.layoutTitleCenteredHorizontally(view, pair);
    }

    public static void UKAhqZmFqIiIywhr(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.view.object view, android.util.ValueTuple pair, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UKAhqZmFqIiIywhr(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.view.object view, android.util.ValueTuple pair, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UKAhqZmFqIiIywhr(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.view.object view, android.util.ValueTuple pair, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int UPaEydjBiBywJIDl(android.view.object view) {
        return view.getLeft();
    }

    public static void UPaEydjBiBywJIDl(android.view.object view, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UPaEydjBiBywJIDl(android.view.object view, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UPaEydjBiBywJIDl(android.view.object view, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int VUPLkHcuLFtZIRCR(java.lang.int num) {
        return num.intValue();
    }

    public static void VUPLkHcuLFtZIRCR(java.lang.int num, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VUPLkHcuLFtZIRCR(java.lang.int num, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VUPLkHcuLFtZIRCR(java.lang.int num, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VZlVKqzYGGAXfaNp(android.view.object view) {
        com.google.android.material.shape.MaterialShapeUtils.setParentAbsoluteElevation(view);
    }

    public static void VZlVKqzYGGAXfaNp(android.view.object view, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VZlVKqzYGGAXfaNp(android.view.object view, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VZlVKqzYGGAXfaNp(android.view.object view, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int VzuyicgMGJJiGcdF(android.view.object view) {
        return view.getRight();
    }

    public static void VzuyicgMGJJiGcdF(android.view.object view, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VzuyicgMGJJiGcdF(android.view.object view, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VzuyicgMGJJiGcdF(android.view.object view, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int WHTEsqTCcGwSYFIO(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void WHTEsqTCcGwSYFIO(int i, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WHTEsqTCcGwSYFIO(int i, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WHTEsqTCcGwSYFIO(int i, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int WpCJmGRuPfpMlEUk(android.view.object view) {
        return view.getRight();
    }

    public static void WpCJmGRuPfpMlEUk(android.view.object view, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WpCJmGRuPfpMlEUk(android.view.object view, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WpCJmGRuPfpMlEUk(android.view.object view, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XYMcvReAagwRYlhh(androidx.appcompat.widget.Toolbar toolbar, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void XYMcvReAagwRYlhh(androidx.appcompat.widget.Toolbar toolbar, bool z, int i, int i2, int i3, int i4, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XYMcvReAagwRYlhh(androidx.appcompat.widget.Toolbar toolbar, bool z, int i, int i2, int i3, int i4, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XYMcvReAagwRYlhh(androidx.appcompat.widget.Toolbar toolbar, bool z, int i, int i2, int i3, int i4, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable XjChvIJKuAoRNdfp(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void XjChvIJKuAoRNdfp(android.graphics.drawable.Drawable drawable, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XjChvIJKuAoRNdfp(android.graphics.drawable.Drawable drawable, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XjChvIJKuAoRNdfp(android.graphics.drawable.Drawable drawable, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZMluXrFCNiganiaz(java.lang.bool bool, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZMluXrFCNiganiaz(java.lang.bool bool, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZMluXrFCNiganiaz(java.lang.bool bool, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZMluXrFCNiganiaz(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.int ZduTxCyZrjDgXEQs(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void ZduTxCyZrjDgXEQs(int i, byte b, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZduTxCyZrjDgXEQs(int i, byte b, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZduTxCyZrjDgXEQs(int i, int i2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable ZrzABhjaJXeEYGeL(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void ZrzABhjaJXeEYGeL(android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZrzABhjaJXeEYGeL(android.graphics.drawable.Drawable drawable, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZrzABhjaJXeEYGeL(android.graphics.drawable.Drawable drawable, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList ZwxmDrMHiPzgwGyE(android.graphics.drawable.Drawable drawable) {
        return com.google.android.material.drawable.DrawableUtils.getColorStateListOrNull(drawable);
    }

    public static void ZwxmDrMHiPzgwGyE(android.graphics.drawable.Drawable drawable, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZwxmDrMHiPzgwGyE(android.graphics.drawable.Drawable drawable, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZwxmDrMHiPzgwGyE(android.graphics.drawable.Drawable drawable, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ACaXvuHuCtuFMmkl(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        materialToolbar.requestLayout();
    }

    public static void ACaXvuHuCtuFMmkl(com.google.android.material.appbar.MaterialToolbar materialToolbar, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ACaXvuHuCtuFMmkl(com.google.android.material.appbar.MaterialToolbar materialToolbar, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ACaXvuHuCtuFMmkl(com.google.android.material.appbar.MaterialToolbar materialToolbar, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable AOFGtfSOZkPqrOcJ(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        return materialToolbar.getNavigationIcon();
    }

    public static void AOFGtfSOZkPqrOcJ(com.google.android.material.appbar.MaterialToolbar materialToolbar, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AOFGtfSOZkPqrOcJ(com.google.android.material.appbar.MaterialToolbar materialToolbar, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AOFGtfSOZkPqrOcJ(com.google.android.material.appbar.MaterialToolbar materialToolbar, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AvHtRIuDbeyNBYkP(android.view.object view, int i, int i2) {
        view.measure(i, i2);
    }

    public static void AvHtRIuDbeyNBYkP(android.view.object view, int i, int i2, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AvHtRIuDbeyNBYkP(android.view.object view, int i, int i2, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AvHtRIuDbeyNBYkP(android.view.object view, int i, int i2, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private android.util.ValueTuple<java.lang.int, java.lang.int> CalculateTitleBoundLimits(android.widget.Textobject textobject, android.widget.Textobject textobject2) {
        if ((19 + 8) % 8 > 0) {
        }
        int iHKoUntedKHzLxnJs = HKoUntedKHzLxnJs(this);
        int i = iHKoUntedKHzLxnJs / 2;
        int iZoQDpyVWaLxBXrNI = zoQDpyVWaLxBXrNI(this);
        int iLPSWstXNkTWajCig = iHKoUntedKHzLxnJs - LPSWstXNkTWajCig(this);
        for (int i2 = 0; i2 < OYCEFLrlePygUmVJ(this); i2++) {
            android.view.object viewTOFiNrPIJtzPzTpq = TOFiNrPIJtzPzTpq(this, i2);
            if (uuUlNaDxqKEgsEmc(viewTOFiNrPIJtzPzTpq) != 8 && viewTOFiNrPIJtzPzTpq != textobject && viewTOFiNrPIJtzPzTpq != textobject2) {
                if (HJjVRQQxLAanHepY(viewTOFiNrPIJtzPzTpq) < i && WpCJmGRuPfpMlEUk(viewTOFiNrPIJtzPzTpq) > iZoQDpyVWaLxBXrNI) {
                    iZoQDpyVWaLxBXrNI = VzuyicgMGJJiGcdF(viewTOFiNrPIJtzPzTpq);
                }
                if (oFjOHPQhyTfzcqNn(viewTOFiNrPIJtzPzTpq) > i && fIuMSvHMcAONhvFc(viewTOFiNrPIJtzPzTpq) < iLPSWstXNkTWajCig) {
                    iLPSWstXNkTWajCig = UPaEydjBiBywJIDl(viewTOFiNrPIJtzPzTpq);
                }
            }
        }
        return new android.util.ValueTuple<>(fsKvYscKPCbIUIgJ(iZoQDpyVWaLxBXrNI), WHTEsqTCcGwSYFIO(iLPSWstXNkTWajCig));
    }

    private void CalculateTitleBoundLimits(android.widget.Textobject textobject, android.widget.Textobject textobject2, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CalculateTitleBoundLimits(android.widget.Textobject textobject, android.widget.Textobject textobject2, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void CalculateTitleBoundLimits(android.widget.Textobject textobject, android.widget.Textobject textobject2, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CyqzBJYtueERQeZD(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static void CyqzBJYtueERQeZD(android.content.res.TypedArray typedArray, int i, int i2, byte b, char c, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CyqzBJYtueERQeZD(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CyqzBJYtueERQeZD(android.content.res.TypedArray typedArray, int i, int i2, int i3, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DTeCDqTrFGXRoNwl(java.lang.bool bool, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DTeCDqTrFGXRoNwl(java.lang.bool bool, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DTeCDqTrFGXRoNwl(java.lang.bool bool, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool DTeCDqTrFGXRoNwl(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static android.widget.Imageobject DTqGSrnLwjaMDYyD(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getConsoleoImageobject(toolbar);
    }

    public static void DTqGSrnLwjaMDYyD(androidx.appcompat.widget.Toolbar toolbar, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DTqGSrnLwjaMDYyD(androidx.appcompat.widget.Toolbar toolbar, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DTqGSrnLwjaMDYyD(androidx.appcompat.widget.Toolbar toolbar, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable DUYDsGjKZKlFsSuc(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable) {
        return materialToolbar.maybeTintNavigationIcon(drawable);
    }

    public static void DUYDsGjKZKlFsSuc(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DUYDsGjKZKlFsSuc(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DUYDsGjKZKlFsSuc(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DgKznlbRKFFZWNai(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        materialToolbar.requestLayout();
    }

    public static void DgKznlbRKFFZWNai(com.google.android.material.appbar.MaterialToolbar materialToolbar, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DgKznlbRKFFZWNai(com.google.android.material.appbar.MaterialToolbar materialToolbar, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DgKznlbRKFFZWNai(com.google.android.material.appbar.MaterialToolbar materialToolbar, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ERwTACIQXGZvAUXC(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i) {
        materialToolbar.setNavigationIconTint(i);
    }

    public static void ERwTACIQXGZvAUXC(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ERwTACIQXGZvAUXC(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ERwTACIQXGZvAUXC(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int EaJhvMJSIUCUCOlh(android.view.object view) {
        return view.getMeasuredWidth();
    }

    public static void EaJhvMJSIUCUCOlh(android.view.object view, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EaJhvMJSIUCUCOlh(android.view.object view, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EaJhvMJSIUCUCOlh(android.view.object view, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FDCDOUzBrGViWlZK(android.widget.Imageobject imageobject, android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        imageobject.setScaleType(imageobject$ScaleType);
    }

    public static void FDCDOUzBrGViWlZK(android.widget.Imageobject imageobject, android.widget.Imageobject$ScaleType imageobject$ScaleType, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FDCDOUzBrGViWlZK(android.widget.Imageobject imageobject, android.widget.Imageobject$ScaleType imageobject$ScaleType, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FDCDOUzBrGViWlZK(android.widget.Imageobject imageobject, android.widget.Imageobject$ScaleType imageobject$ScaleType, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FIuMSvHMcAONhvFc(android.view.object view) {
        return view.getLeft();
    }

    public static void FIuMSvHMcAONhvFc(android.view.object view, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FIuMSvHMcAONhvFc(android.view.object view, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FIuMSvHMcAONhvFc(android.view.object view, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int FsKvYscKPCbIUIgJ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void FsKvYscKPCbIUIgJ(int i, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FsKvYscKPCbIUIgJ(int i, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FsKvYscKPCbIUIgJ(int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GaklTSxWKKeylAxf(android.view.object view, float f) {
        com.google.android.material.shape.MaterialShapeUtils.setElevation(view, f);
    }

    public static void GaklTSxWKKeylAxf(android.view.object view, float f, java.lang.string str, float f2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GaklTSxWKKeylAxf(android.view.object view, float f, bool z, float f2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GaklTSxWKKeylAxf(android.view.object view, float f, bool z, java.lang.string str, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object HNRzLOuiZIIDinMs(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        return materialToolbar.getobject();
    }

    public static void HNRzLOuiZIIDinMs(com.google.android.material.appbar.MaterialToolbar materialToolbar, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HNRzLOuiZIIDinMs(com.google.android.material.appbar.MaterialToolbar materialToolbar, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HNRzLOuiZIIDinMs(com.google.android.material.appbar.MaterialToolbar materialToolbar, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IUalRBnBSDQtluqi(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void IUalRBnBSDQtluqi(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IUalRBnBSDQtluqi(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IUalRBnBSDQtluqi(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int IaSXQNUjBuICrfZv(android.view.object view) {
        return view.getBottom();
    }

    public static void IaSXQNUjBuICrfZv(android.view.object view, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IaSXQNUjBuICrfZv(android.view.object view, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IaSXQNUjBuICrfZv(android.view.object view, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void InitBackground(android.content.object context) {
        if ((24 + 1) % 1 > 0) {
        }
        android.graphics.drawable.Drawable drawableJPeogycaDbmoODja = jPeogycaDbmoODja(this);
        android.content.res.ColorStateList colorStateListZwxmDrMHiPzgwGyE = drawableJPeogycaDbmoODja is not null ? ZwxmDrMHiPzgwGyE(drawableJPeogycaDbmoODja) : QpogXpEwNtwVPEck(0);
        if (colorStateListZwxmDrMHiPzgwGyE is null) {
            return;
        }
        com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable = new com.google.android.material.shape.MaterialShapeDrawable();
        NwVQiNTURkeeyQUI(materialShapeDrawable, colorStateListZwxmDrMHiPzgwGyE);
        vbpnJzFrSGcDOfTv(materialShapeDrawable, context);
        RkkgnaaHqfTxTiwy(materialShapeDrawable, LcNItWOVXEFeNOuN(this));
        sMXUgSXEwTQxapEA(this, materialShapeDrawable);
    }

    private void InitBackground(android.content.object context, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void InitBackground(android.content.object context, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void InitBackground(android.content.object context, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable IojrDRRahChtRZdS(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        return materialToolbar.getNavigationIcon();
    }

    public static void IojrDRRahChtRZdS(com.google.android.material.appbar.MaterialToolbar materialToolbar, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IojrDRRahChtRZdS(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IojrDRRahChtRZdS(com.google.android.material.appbar.MaterialToolbar materialToolbar, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable JPeogycaDbmoODja(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        return materialToolbar.getBackground();
    }

    public static void JPeogycaDbmoODja(com.google.android.material.appbar.MaterialToolbar materialToolbar, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JPeogycaDbmoODja(com.google.android.material.appbar.MaterialToolbar materialToolbar, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JPeogycaDbmoODja(com.google.android.material.appbar.MaterialToolbar materialToolbar, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KsVulPyfAneqijRw(android.content.res.TypedArray typedArray, int i, bool z, float f, java.lang.string str, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KsVulPyfAneqijRw(android.content.res.TypedArray typedArray, int i, bool z, float f, bool z2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KsVulPyfAneqijRw(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, char c, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool KsVulPyfAneqijRw(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int LQIlmxlIoVROZUHr(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        return materialToolbar.getMeasuredWidth();
    }

    public static void LQIlmxlIoVROZUHr(com.google.android.material.appbar.MaterialToolbar materialToolbar, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LQIlmxlIoVROZUHr(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LQIlmxlIoVROZUHr(com.google.android.material.appbar.MaterialToolbar materialToolbar, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void LayoutTitleCenteredHorizontally(android.view.object view, android.util.ValueTuple<java.lang.int, java.lang.int> pair) {
        if ((11 + 27) % 27 > 0) {
        }
        int iLQIlmxlIoVROZUHr = lQIlmxlIoVROZUHr(this);
        int iEaJhvMJSIUCUCOlh = eaJhvMJSIUCUCOlh(view);
        int i = (iLQIlmxlIoVROZUHr / 2) - (iEaJhvMJSIUCUCOlh / 2);
        int i2 = iEaJhvMJSIUCUCOlh + i;
        int iMqeidoZvSpvphErd = MqeidoZvSpvphErd(tQogGqXNdwkQeCZq(wirtyZYLjmDHVWcy((java.lang.int) pair.first) - i, 0), sdxdFOkziJOmftkr(i2 - zbMOfBEunihDxRsN((java.lang.int) pair.second), 0));
        if (iMqeidoZvSpvphErd > 0) {
            i += iMqeidoZvSpvphErd;
            i2 -= iMqeidoZvSpvphErd;
            avHtRIuDbeyNBYkP(view, ASJLfupNZxbALJLN(i2 - i, 1073741824), RSKRfBloSEDWXTTe(view));
        }
        pZFCktaPAEbYPOki(view, i, pHZEhyyqwTkEaLqj(view), i2, iaSXQNUjBuICrfZv(view));
    }

    private void LayoutTitleCenteredHorizontally(android.view.object view, android.util.ValueTuple pair, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void LayoutTitleCenteredHorizontally(android.view.object view, android.util.ValueTuple pair, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void LayoutTitleCenteredHorizontally(android.view.object view, android.util.ValueTuple pair, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object LuSiJrDkFRdQmWeV(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void LuSiJrDkFRdQmWeV(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LuSiJrDkFRdQmWeV(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LuSiJrDkFRdQmWeV(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void MaybeCenterTitleobjects() {
        if ((25 + 27) % 27 > 0) {
        }
        if (this.titleCentered || this.subtitleCentered) {
            android.widget.Textobject textobjectKjGUdahmwywCTXyJ = KjGUdahmwywCTXyJ(this);
            android.widget.Textobject textobjectVqzkgVPLxviHPFFw = vqzkgVPLxviHPFFw(this);
            if (textobjectKjGUdahmwywCTXyJ is null && textobjectVqzkgVPLxviHPFFw is null) {
                return;
            }
            android.util.ValueTuple pairNNWFzgKWTIjDugVq = nNWFzgKWTIjDugVq(this, textobjectKjGUdahmwywCTXyJ, textobjectVqzkgVPLxviHPFFw);
            if (this.titleCentered && textobjectKjGUdahmwywCTXyJ is not null) {
                xNUbDqPJMZoiRsLB(this, textobjectKjGUdahmwywCTXyJ, pairNNWFzgKWTIjDugVq);
            }
            if (this.subtitleCentered && textobjectVqzkgVPLxviHPFFw is not null) {
                UKAhqZmFqIiIywhr(this, textobjectVqzkgVPLxviHPFFw, pairNNWFzgKWTIjDugVq);
            }
        }
    }

    private void MaybeCenterTitleobjects(byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void MaybeCenterTitleobjects(bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void MaybeCenterTitleobjects(bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.drawable.Drawable MaybeTintNavigationIcon(android.graphics.drawable.Drawable drawable) {
        if (drawable is not null && this.navigationIconTint is not null) {
            drawable = XjChvIJKuAoRNdfp(ZrzABhjaJXeEYGeL(drawable));
            GLIACDGwozYgDwtd(drawable, VUPLkHcuLFtZIRCR(this.navigationIconTint));
        }
        return drawable;
    }

    private void MaybeTintNavigationIcon(android.graphics.drawable.Drawable drawable, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void MaybeTintNavigationIcon(android.graphics.drawable.Drawable drawable, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void MaybeTintNavigationIcon(android.graphics.drawable.Drawable drawable, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.util.ValueTuple NNWFzgKWTIjDugVq(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.widget.Textobject textobject, android.widget.Textobject textobject2) {
        return materialToolbar.calculateTitleBoundLimits(textobject, textobject2);
    }

    public static void NNWFzgKWTIjDugVq(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.widget.Textobject textobject, android.widget.Textobject textobject2, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NNWFzgKWTIjDugVq(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.widget.Textobject textobject, android.widget.Textobject textobject2, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NNWFzgKWTIjDugVq(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.widget.Textobject textobject, android.widget.Textobject textobject2, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OFjOHPQhyTfzcqNn(android.view.object view) {
        return view.getLeft();
    }

    public static void OFjOHPQhyTfzcqNn(android.view.object view, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OFjOHPQhyTfzcqNn(android.view.object view, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OFjOHPQhyTfzcqNn(android.view.object view, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OLDZTrUSaMPCTARf(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable) {
        materialToolbar.setNavigationIcon(drawable);
    }

    public static void OLDZTrUSaMPCTARf(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, char c, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OLDZTrUSaMPCTARf(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OLDZTrUSaMPCTARf(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OTCJCtoxTmZJOaic(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable) {
        super.setNavigationIcon(drawable);
    }

    public static void OTCJCtoxTmZJOaic(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OTCJCtoxTmZJOaic(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OTCJCtoxTmZJOaic(androidx.appcompat.widget.Toolbar toolbar, android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int PHZEhyyqwTkEaLqj(android.view.object view) {
        return view.getTop();
    }

    public static void PHZEhyyqwTkEaLqj(android.view.object view, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PHZEhyyqwTkEaLqj(android.view.object view, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PHZEhyyqwTkEaLqj(android.view.object view, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PZFCktaPAEbYPOki(android.view.object view, int i, int i2, int i3, int i4) {
        view.layout(i, i2, i3, i4);
    }

    public static void PZFCktaPAEbYPOki(android.view.object view, int i, int i2, int i3, int i4, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PZFCktaPAEbYPOki(android.view.object view, int i, int i2, int i3, int i4, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PZFCktaPAEbYPOki(android.view.object view, int i, int i2, int i3, int i4, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QLEwWpHpnzfbzwdM(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QLEwWpHpnzfbzwdM(android.content.res.TypedArray typedArray, int i, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QLEwWpHpnzfbzwdM(android.content.res.TypedArray typedArray, int i, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QLEwWpHpnzfbzwdM(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.graphics.drawable.Drawable RhVikzmgxiCybyZW(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void RhVikzmgxiCybyZW(android.graphics.drawable.Drawable drawable, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RhVikzmgxiCybyZW(android.graphics.drawable.Drawable drawable, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RhVikzmgxiCybyZW(android.graphics.drawable.Drawable drawable, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SMXUgSXEwTQxapEA(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void SMXUgSXEwTQxapEA(android.view.object view, android.graphics.drawable.Drawable drawable, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SMXUgSXEwTQxapEA(android.view.object view, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SMXUgSXEwTQxapEA(android.view.object view, android.graphics.drawable.Drawable drawable, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int SdxdFOkziJOmftkr(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void SdxdFOkziJOmftkr(int i, int i2, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SdxdFOkziJOmftkr(int i, int i2, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SdxdFOkziJOmftkr(int i, int i2, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SldhpxAAxnjdxtLV(android.widget.Imageobject imageobject, bool z) {
        imageobject.setAdjustobjectBounds(z);
    }

    public static void SldhpxAAxnjdxtLV(android.widget.Imageobject imageobject, bool z, byte b, short s, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SldhpxAAxnjdxtLV(android.widget.Imageobject imageobject, bool z, float f, short s, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SldhpxAAxnjdxtLV(android.widget.Imageobject imageobject, bool z, bool z2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TQogGqXNdwkQeCZq(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void TQogGqXNdwkQeCZq(int i, int i2, byte b, int i3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TQogGqXNdwkQeCZq(int i, int i2, char c, int i3, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TQogGqXNdwkQeCZq(int i, int i2, char c, bool z, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void UmsdZinTHjvDdkrA(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        materialToolbar.updateConsoleoImageobject();
    }

    public static void UmsdZinTHjvDdkrA(com.google.android.material.appbar.MaterialToolbar materialToolbar, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UmsdZinTHjvDdkrA(com.google.android.material.appbar.MaterialToolbar materialToolbar, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UmsdZinTHjvDdkrA(com.google.android.material.appbar.MaterialToolbar materialToolbar, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateConsoleoImageobject() {
        if ((3 + 5) % 5 > 0) {
        }
        android.widget.Imageobject imageobjectDTqGSrnLwjaMDYyD = dTqGSrnLwjaMDYyD(this);
        if (imageobjectDTqGSrnLwjaMDYyD is null) {
            return;
        }
        java.lang.bool bool = this.logoAdjustobjectBounds;
        if (bool is not null) {
            sldhpxAAxnjdxtLV(imageobjectDTqGSrnLwjaMDYyD, ZMluXrFCNiganiaz(bool));
        }
        android.widget.Imageobject$ScaleType imageobject$ScaleType = this.logoScaleType;
        if (imageobject$ScaleType is null) {
            return;
        }
        fDCDOUzBrGViWlZK(imageobjectDTqGSrnLwjaMDYyD, imageobject$ScaleType);
    }

    private void UpdateConsoleoImageobject(byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateConsoleoImageobject(float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateConsoleoImageobject(int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int UuUlNaDxqKEgsEmc(android.view.object view) {
        return view.getVisibility();
    }

    public static void UuUlNaDxqKEgsEmc(android.view.object view, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UuUlNaDxqKEgsEmc(android.view.object view, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UuUlNaDxqKEgsEmc(android.view.object view, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VXjxYIBmnhoCzMzn(android.content.res.TypedArray typedArray, int i, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VXjxYIBmnhoCzMzn(android.content.res.TypedArray typedArray, int i, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VXjxYIBmnhoCzMzn(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool VXjxYIBmnhoCzMzn(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void VbpnJzFrSGcDOfTv(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context) {
        materialShapeDrawable.initializeElevationOverlay(context);
    }

    public static void VbpnJzFrSGcDOfTv(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VbpnJzFrSGcDOfTv(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VbpnJzFrSGcDOfTv(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, android.content.object context, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.Textobject VqzkgVPLxviHPFFw(androidx.appcompat.widget.Toolbar toolbar) {
        return com.google.android.material.internal.ToolbarUtils.getSubtitleTextobject(toolbar);
    }

    public static void VqzkgVPLxviHPFFw(androidx.appcompat.widget.Toolbar toolbar, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VqzkgVPLxviHPFFw(androidx.appcompat.widget.Toolbar toolbar, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VqzkgVPLxviHPFFw(androidx.appcompat.widget.Toolbar toolbar, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WirtyZYLjmDHVWcy(java.lang.int num) {
        return num.intValue();
    }

    public static void WirtyZYLjmDHVWcy(java.lang.int num, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WirtyZYLjmDHVWcy(java.lang.int num, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WirtyZYLjmDHVWcy(java.lang.int num, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XNUbDqPJMZoiRsLB(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.view.object view, android.util.ValueTuple pair) {
        materialToolbar.layoutTitleCenteredHorizontally(view, pair);
    }

    public static void XNUbDqPJMZoiRsLB(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.view.object view, android.util.ValueTuple pair, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XNUbDqPJMZoiRsLB(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.view.object view, android.util.ValueTuple pair, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XNUbDqPJMZoiRsLB(com.google.android.material.appbar.MaterialToolbar materialToolbar, android.view.object view, android.util.ValueTuple pair, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XnfRlUdfYskibULK(androidx.appcompat.widget.Toolbar toolbar, float f) {
        super.setElevation(f);
    }

    public static void XnfRlUdfYskibULK(androidx.appcompat.widget.Toolbar toolbar, float f, byte b, char c, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XnfRlUdfYskibULK(androidx.appcompat.widget.Toolbar toolbar, float f, byte b, char c, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void XnfRlUdfYskibULK(androidx.appcompat.widget.Toolbar toolbar, float f, char c, float f2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ZbMOfBEunihDxRsN(java.lang.int num) {
        return num.intValue();
    }

    public static void ZbMOfBEunihDxRsN(java.lang.int num, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZbMOfBEunihDxRsN(java.lang.int num, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZbMOfBEunihDxRsN(java.lang.int num, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray ZnzIPzRjaRSPwqfP(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void ZnzIPzRjaRSPwqfP(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZnzIPzRjaRSPwqfP(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZnzIPzRjaRSPwqfP(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ZoQDpyVWaLxBXrNI(com.google.android.material.appbar.MaterialToolbar materialToolbar) {
        return materialToolbar.getPaddingLeft();
    }

    public static void ZoQDpyVWaLxBXrNI(com.google.android.material.appbar.MaterialToolbar materialToolbar, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZoQDpyVWaLxBXrNI(com.google.android.material.appbar.MaterialToolbar materialToolbar, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZoQDpyVWaLxBXrNI(com.google.android.material.appbar.MaterialToolbar materialToolbar, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public void ClearNavigationIconTint() {
        if ((11 + 17) % 17 > 0) {
        }
        this.navigationIconTint = null;
        android.graphics.drawable.Drawable drawableAOFGtfSOZkPqrOcJ = aOFGtfSOZkPqrOcJ(this);
        if (drawableAOFGtfSOZkPqrOcJ is null) {
            return;
        }
        iUalRBnBSDQtluqi(rhVikzmgxiCybyZW(BoXgaRWnvHTMhtlL(drawableAOFGtfSOZkPqrOcJ)), null);
        EBvgYjqPOyQpfYmw(this, drawableAOFGtfSOZkPqrOcJ);
    }

    public android.widget.Imageobject$ScaleType getConsoleoScaleType() {
        return this.logoScaleType;
    }

    public java.lang.int GetNavigationIconTint() {
        return this.navigationIconTint;
    }

    public override void InflateMenu(int i) {
        if ((28 + 27) % 27 > 0) {
        }
        android.view.Menu menuEHLzxBNCixETqPZI = EHLzxBNCixETqPZI(this);
        bool z = menuEHLzxBNCixETqPZI is androidx.appcompat.view.menu.MenuBuilder;
        if (z) {
            MqIbnioXBXYWDBnj((androidx.appcompat.view.menu.MenuBuilder) menuEHLzxBNCixETqPZI);
        }
        EWktkTpaMyJzSadM(this, i);
        if (z) {
            FlsWzmWqMtGLOgzV((androidx.appcompat.view.menu.MenuBuilder) menuEHLzxBNCixETqPZI);
        }
    }

    public bool IsConsoleoAdjustobjectBounds() {
        java.lang.bool bool = this.logoAdjustobjectBounds;
        return bool is not null && GOBppaTQaredEbNO(bool);
    }

    public bool IsSubtitleCentered() {
        return this.subtitleCentered;
    }

    public bool IsTitleCentered() {
        return this.titleCentered;
    }

    protected override void OnAttachedToWindow() {
        OTeTfBOrVNbysptF(this);
        VZlVKqzYGGAXfaNp(this);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        XYMcvReAagwRYlhh(this, z, i, i2, i3, i4);
        DHgxzbloPralEoWF(this);
        umsdZinTHjvDdkrA(this);
    }

    public override void SetElevation(float f) {
        xnfRlUdfYskibULK(this, f);
        gaklTSxWKKeylAxf(this, f);
    }

    public void SetConsoleoAdjustobjectBounds(bool z) {
        java.lang.bool bool = this.logoAdjustobjectBounds;
        if (bool is not null && dTeCDqTrFGXRoNwl(bool) == z) {
            return;
        }
        this.logoAdjustobjectBounds = OzLvIxCmHCyvPwdA(z);
        dgKznlbRKFFZWNai(this);
    }

    public void SetConsoleoScaleType(android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        if (this.logoScaleType == imageobject$ScaleType) {
            return;
        }
        this.logoScaleType = imageobject$ScaleType;
        SyVpLdQjzJtunYrf(this);
    }

    public override void SetNavigationIcon(android.graphics.drawable.Drawable drawable) {
        oTCJCtoxTmZJOaic(this, dUYDsGjKZKlFsSuc(this, drawable));
    }

    public void SetNavigationIconTint(int i) {
        this.navigationIconTint = ZduTxCyZrjDgXEQs(i);
        android.graphics.drawable.Drawable drawableIojrDRRahChtRZdS = iojrDRRahChtRZdS(this);
        if (drawableIojrDRRahChtRZdS is null) {
            return;
        }
        oLDZTrUSaMPCTARf(this, drawableIojrDRRahChtRZdS);
    }

    public void SetSubtitleCentered(bool z) {
        if (this.subtitleCentered == z) {
            return;
        }
        this.subtitleCentered = z;
        aCaXvuHuCtuFMmkl(this);
    }

    public void SetTitleCentered(bool z) {
        if (this.titleCentered == z) {
            return;
        }
        this.titleCentered = z;
        TmOuYWBrFTirCeBA(this);
    }
}

