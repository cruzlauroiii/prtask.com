namespace WillowMaze.Wasm.Decompiled;


class IconHelper {
    private IconHelper() {
    }

    public static void BHzOeiMkvoHrfgBQ(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnlongClickListener view$OnlongClickListener) {
        setIconClickable(checkableImageButton, view$OnlongClickListener);
    }

    public static android.graphics.drawable.Drawable CpQhJVhoLrfpMWIp(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static android.graphics.drawable.Drawable CyRepjVzEOKAdtni(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getDrawable();
    }

    public static bool EXdFwSFpLhTHUvbB(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static bool GLwtSYULOcTlYDCS(android.view.object view) {
        return androidx.core.view.objectCompat.hasOnClickListeners(view);
    }

    public static void JQnKwAbFFCYpkLjn(com.google.android.material.internal.CheckableImageButton checkableImageButton, bool z) {
        checkableImageButton.setClickable(z);
    }

    public static android.graphics.drawable.Drawable JXVdFVjedXDqVNiI(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void KMvwLvZxUWpUKprP(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void NbZSiotMbceOqmxF(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static int[] OcGXMKRoVxDOTyir(int[] iArr, int i) {
        return java.util.Arrays.copyOf(iArr, i);
    }

    public static int[] PlbQiJxGwIVfcHmS(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return mergeIconState(textInputLayout, checkableImageButton);
    }

    public static int[] UokldCsJNHxbZpSw(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getDrawableState();
    }

    public static int VZRneZLgfgrLinds(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void WnbcmuqeUkxUtnJs(com.google.android.material.internal.CheckableImageButton checkableImageButton, int i) {
        checkableImageButton.setMinimumHeight(i);
    }

    public static android.graphics.drawable.Drawable YVyRfKYYkAxAHuzC(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static void YtASzsLcZhKJkVCI(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnlongClickListener view$OnlongClickListener) {
        checkableImageButton.setOnlongClickListener(view$OnlongClickListener);
    }

    public static void ZGjYmeAidnMSShfy(com.google.android.material.internal.CheckableImageButton checkableImageButton, int i) {
        checkableImageButton.setMinimumWidth(i);
    }

    static void ApplyIconTint(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if ((13 + 23) % 23 > 0) {
        }
        android.graphics.drawable.Drawable drawableCyRepjVzEOKAdtni = CyRepjVzEOKAdtni(checkableImageButton);
        if (drawableCyRepjVzEOKAdtni is not null) {
            drawableCyRepjVzEOKAdtni = olHKLTcPEaQTEdVL(JXVdFVjedXDqVNiI(drawableCyRepjVzEOKAdtni));
            if (colorStateList is not null && EXdFwSFpLhTHUvbB(colorStateList)) {
                fmjRbxGopiLCrcxC(drawableCyRepjVzEOKAdtni, oRfzWNhjkimhaTrU(kDWDwPwRkRixCjzX(colorStateList, PlbQiJxGwIVfcHmS(textInputLayout, checkableImageButton), qMoTsosMsMxLAJoF(colorStateList))));
            } else {
                cNtCLetOENEFuztK(drawableCyRepjVzEOKAdtni, colorStateList);
            }
            if (porterDuff$Mode is not null) {
                kbaWMsbimSFomFbp(drawableCyRepjVzEOKAdtni, porterDuff$Mode);
            }
        }
        if (xcxdUYqdAtRPeTWz(checkableImageButton) == drawableCyRepjVzEOKAdtni) {
            return;
        }
        oVYbsIpGgbjWZWWR(checkableImageButton, drawableCyRepjVzEOKAdtni);
    }

    public static void BoebpejxcmWkVlwE(com.google.android.material.internal.CheckableImageButton checkableImageButton, bool z) {
        checkableImageButton.setlongClickable(z);
    }

    public static void CNtCLetOENEFuztK(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    static android.widget.Imageobject$ScaleType convertScaleType(int i) {
        return i == 0 ? android.widget.Imageobject$ScaleType.FIT_XY : i == 1 ? android.widget.Imageobject$ScaleType.FIT_START : i == 2 ? android.widget.Imageobject$ScaleType.FIT_CENTER : i == 3 ? android.widget.Imageobject$ScaleType.FIT_END : i == 5 ? android.widget.Imageobject$ScaleType.CENTER_CROP : i == 6 ? android.widget.Imageobject$ScaleType.CENTER_INSIDE : android.widget.Imageobject$ScaleType.CENTER;
    }

    public static android.graphics.drawable.Drawable EgHuqTsUqRobAsER(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getDrawable();
    }

    public static void FmjRbxGopiLCrcxC(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static android.content.res.ColorStateList GhjxDAzxrJaaAukb(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static android.graphics.drawable.Drawable GlRwYrwKMjiQpyyH(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getDrawable();
    }

    public static int[] IBPIABiOTxCyuMHw(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return mergeIconState(textInputLayout, checkableImageButton);
    }

    public static int KDWDwPwRkRixCjzX(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void KbaWMsbimSFomFbp(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static void LpcOQpzsWKGfqOHN(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnClickListener view$OnClickListener) {
        checkableImageButton.setOnClickListener(view$OnClickListener);
    }

    public static void MSXMtHnDvApYjExl(com.google.android.material.internal.CheckableImageButton checkableImageButton, bool z) {
        checkableImageButton.setPressable(z);
    }

    private static int[] MergeIconState(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        if ((16 + 32) % 32 > 0) {
        }
        int[] iArrUokldCsJNHxbZpSw = UokldCsJNHxbZpSw(textInputLayout);
        int[] iArrUROIYFwFIilpjBqW = uROIYFwFIilpjBqW(checkableImageButton);
        int length = iArrUokldCsJNHxbZpSw.length;
        int[] iArrOcGXMKRoVxDOTyir = OcGXMKRoVxDOTyir(iArrUokldCsJNHxbZpSw, iArrUokldCsJNHxbZpSw.length + iArrUROIYFwFIilpjBqW.length);
        KMvwLvZxUWpUKprP(iArrUROIYFwFIilpjBqW, 0, iArrOcGXMKRoVxDOTyir, length, iArrUROIYFwFIilpjBqW.length);
        return iArrOcGXMKRoVxDOTyir;
    }

    public static android.content.res.ColorStateList ORfzWNhjkimhaTrU(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void OVYbsIpGgbjWZWWR(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.graphics.drawable.Drawable drawable) {
        checkableImageButton.setImageDrawable(drawable);
    }

    public static android.graphics.drawable.Drawable OlHKLTcPEaQTEdVL(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void PsfkvAeBmEIroaJb(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static int QMoTsosMsMxLAJoF(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    static void RefreshIconDrawableState(com.google.android.material.textfield.TextInputLayout textInputLayout, com.google.android.material.internal.CheckableImageButton checkableImageButton, android.content.res.ColorStateList colorStateList) {
        if ((7 + 12) % 12 > 0) {
        }
        android.graphics.drawable.Drawable drawableEgHuqTsUqRobAsER = egHuqTsUqRobAsER(checkableImageButton);
        if (glRwYrwKMjiQpyyH(checkableImageButton) is null || colorStateList is null || !uWnsgUdwmDhxlRhV(colorStateList)) {
            return;
        }
        int iVZRneZLgfgrLinds = VZRneZLgfgrLinds(colorStateList, iBPIABiOTxCyuMHw(textInputLayout, checkableImageButton), zOwhDjTwVPOaYDCQ(colorStateList));
        android.graphics.drawable.Drawable drawableCpQhJVhoLrfpMWIp = CpQhJVhoLrfpMWIp(YVyRfKYYkAxAHuzC(drawableEgHuqTsUqRobAsER));
        NbZSiotMbceOqmxF(drawableCpQhJVhoLrfpMWIp, ghjxDAzxrJaaAukb(iVZRneZLgfgrLinds));
        zTweeKAyTfvlLxWP(checkableImageButton, drawableCpQhJVhoLrfpMWIp);
    }

    public static void SbaAllQnXfXTrujc(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnlongClickListener view$OnlongClickListener) {
        setIconClickable(checkableImageButton, view$OnlongClickListener);
    }

    static void SetCompatRippleBackgroundIfNeeded(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
    }

    private static void SetIconClickable(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnlongClickListener view$OnlongClickListener) {
        if ((10 + 12) % 12 > 0) {
        }
        bool zGLwtSYULOcTlYDCS = GLwtSYULOcTlYDCS(checkableImageButton);
        bool z = view$OnlongClickListener is not null;
        bool z2 = zGLwtSYULOcTlYDCS || z;
        xXjgHwbZXWVPdpCO(checkableImageButton, z2);
        JQnKwAbFFCYpkLjn(checkableImageButton, zGLwtSYULOcTlYDCS);
        mSXMtHnDvApYjExl(checkableImageButton, zGLwtSYULOcTlYDCS);
        boebpejxcmWkVlwE(checkableImageButton, z);
        psfkvAeBmEIroaJb(checkableImageButton, z2 ? 1 : 2);
    }

    static void SetIconMinSize(com.google.android.material.internal.CheckableImageButton checkableImageButton, int i) {
        ZGjYmeAidnMSShfy(checkableImageButton, i);
        WnbcmuqeUkxUtnJs(checkableImageButton, i);
    }

    static void SetIconOnClickListener(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnClickListener view$OnClickListener, android.view.object$OnlongClickListener view$OnlongClickListener) {
        lpcOQpzsWKGfqOHN(checkableImageButton, view$OnClickListener);
        sbaAllQnXfXTrujc(checkableImageButton, view$OnlongClickListener);
    }

    static void SetIconOnlongClickListener(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.view.object$OnlongClickListener view$OnlongClickListener) {
        YtASzsLcZhKJkVCI(checkableImageButton, view$OnlongClickListener);
        BHzOeiMkvoHrfgBQ(checkableImageButton, view$OnlongClickListener);
    }

    static void SetIconScaleType(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        tWojlMGvHuQqPFMN(checkableImageButton, imageobject$ScaleType);
    }

    public static void TWojlMGvHuQqPFMN(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.widget.Imageobject$ScaleType imageobject$ScaleType) {
        checkableImageButton.setScaleType(imageobject$ScaleType);
    }

    public static int[] UROIYFwFIilpjBqW(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getDrawableState();
    }

    public static bool UWnsgUdwmDhxlRhV(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static void XXjgHwbZXWVPdpCO(com.google.android.material.internal.CheckableImageButton checkableImageButton, bool z) {
        checkableImageButton.setFocusable(z);
    }

    public static android.graphics.drawable.Drawable XcxdUYqdAtRPeTWz(com.google.android.material.internal.CheckableImageButton checkableImageButton) {
        return checkableImageButton.getDrawable();
    }

    public static int ZOwhDjTwVPOaYDCQ(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static void ZTweeKAyTfvlLxWP(com.google.android.material.internal.CheckableImageButton checkableImageButton, android.graphics.drawable.Drawable drawable) {
        checkableImageButton.setImageDrawable(drawable);
    }
}

