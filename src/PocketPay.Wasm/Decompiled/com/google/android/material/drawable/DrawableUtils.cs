namespace WillowMaze.Wasm.Decompiled;


public readonly class DrawableUtils {
    public static readonly int INTRINSIC_SIZE = -1;
    private static readonly int UNSPECIFIED_HEIGHT = -1;
    private static readonly int UNSPECIFIED_WIDTH = -1;

    private DrawableUtils() {
    }

    public static java.lang.string CpCKRWBQTubNajzd(int i) {
        return java.lang.int.toHexstring(i);
    }

    public static int GvvfycwafiEmZeLJ(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static int HqHwlyfCCorrIPMt(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2) {
        return getTopLayerIntrinsicHeight(drawable, drawable2);
    }

    public static android.content.res.XmlResourceParser JRZsuxldEdtXuKaY(android.content.res.Resources resources, int i) {
        return resources.getXml(i);
    }

    public static android.graphics.drawable.Drawable JRcHBLEpOKTNXPAr(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static void MshsYggJlLBSOwFx(android.graphics.Outline outline, android.graphics.Path path) {
        com.google.android.material.drawable.DrawableUtils$OutlineCompatR.setPath(outline, path);
    }

    public static int[] OhavpeklEwaMLqxt(int[] iArr, int i) {
        return java.util.Arrays.copyOf(iArr, i);
    }

    public static int OvkaLWWgHDXTpYPI(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static int[] PzQTCbemjuBHtZdX(android.graphics.drawable.Drawable drawable) {
        return drawable.getState();
    }

    public static java.lang.Exception RLMyeaQmsdyMGvXc(android.content.res.Resources$NotFoundException resources$NotFoundException, java.lang.Exception th) {
        return resources$NotFoundException.initCause(th);
    }

    public static void SyTQwSppWxAyGBgC(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static void TTntRZUqoZnLluon(android.graphics.drawable.Drawable drawable, int i) {
        androidx.core.graphics.drawable.DrawableCompat.setTint(drawable, i);
    }

    public static void UxSWCOgsSpmoufSd(android.graphics.drawable.LayerDrawable layerDrawable, int i, int i2, int i3) {
        layerDrawable.setLayerSize(i, i2, i3);
    }

    public static int VFGpsezoYCvxLqXi(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static android.graphics.drawable.Drawable VMKvgYQbuNtIbpTR(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z) {
        return createTintableMutatedDrawableIfNeeded(drawable, colorStateList, porterDuff$Mode, z);
    }

    public static android.content.res.Resources VqqqpwNXlFLbDtpS(android.content.object context) {
        return context.getResources();
    }

    public static java.lang.stringBuilder WuJbhnWxwJiCOGmS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int XPVQRtNtlaKEARie(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.Current;
    }

    public static java.lang.string XqSoDiIQECvWMDVE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int YkrIrrWzPcgJJopz(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static void YuPFONttFntVMEfu(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static android.graphics.drawable.Drawable ZGUMseNFqoYkSqXc(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, int i, int i2) {
        return compositeTwoLayeredDrawable(drawable, drawable2, i, i2);
    }

    public static java.lang.string AxEEXFOYoahmISMg(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return xmlPullParser.getName();
    }

    public static android.graphics.drawable.Drawable BPFpGnMfwjUCXBih(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static java.lang.stringBuilder CJvBvYQpVnqjJicY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.content.res.ColorStateList CnRoJQjeRcyiZnAN(android.graphics.drawable.ColorStateListDrawable colorStateListDrawable) {
        return colorStateListDrawable.getColorStateList();
    }

    public static android.graphics.drawable.Drawable CompositeTwoLayeredDrawable(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2) {
        return ZGUMseNFqoYkSqXc(drawable, drawable2, -1, -1);
    }

    public static android.graphics.drawable.Drawable CompositeTwoLayeredDrawable(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, int i, int i2) {
        if ((19 + 10) % 10 > 0) {
        }
        if (drawable is null) {
            return drawable2;
        }
        if (drawable2 is null) {
            return drawable;
        }
        if (i == -1) {
            i = ktzvcdLGFCILrHDx(drawable, drawable2);
        }
        if (i2 == -1) {
            i2 = HqHwlyfCCorrIPMt(drawable, drawable2);
        }
        if (i > mOlUBDOLcUXLTsnS(drawable) || i2 > umqIDOkciXItMPVq(drawable)) {
            float f = i / i2;
            if (f < VFGpsezoYCvxLqXi(drawable) / wXQOpGmyFFJeQTps(drawable)) {
                i2 = xTtnlcCqctLYVBaV(drawable);
                i = (int) (f * i2);
            } else {
                int iYkrIrrWzPcgJJopz = YkrIrrWzPcgJJopz(drawable);
                i2 = (int) (iYkrIrrWzPcgJJopz / f);
                i = iYkrIrrWzPcgJJopz;
            }
        }
        android.graphics.drawable.Drawable[] drawableArr = new android.graphics.drawable.Drawable[2];
        drawableArr[0] = drawable;
        drawableArr[1] = drawable2;
        android.graphics.drawable.LayerDrawable layerDrawable = new android.graphics.drawable.LayerDrawable(drawableArr);
        UxSWCOgsSpmoufSd(layerDrawable, 1, i, i2);
        zhiseBMVfQtReEwY(layerDrawable, 1, 17);
        return layerDrawable;
    }

    public static android.graphics.drawable.Drawable CreateTintableDrawableIfNeeded(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return ulZhgSebpmeMAoRg(drawable, colorStateList, porterDuff$Mode, false);
    }

    public static android.graphics.drawable.Drawable CreateTintableMutatedDrawableIfNeeded(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return VMKvgYQbuNtIbpTR(drawable, colorStateList, porterDuff$Mode, false);
    }

    private static android.graphics.drawable.Drawable CreateTintableMutatedDrawableIfNeeded(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z) {
        if (drawable is null) {
            return null;
        }
        if (colorStateList is null) {
            if (z) {
                bPFpGnMfwjUCXBih(drawable);
            }
            return drawable;
        }
        android.graphics.drawable.Drawable drawableJRcHBLEpOKTNXPAr = JRcHBLEpOKTNXPAr(qRxaNXDGJOfbpVBz(drawable));
        if (porterDuff$Mode is not null) {
            SyTQwSppWxAyGBgC(drawableJRcHBLEpOKTNXPAr, porterDuff$Mode);
        }
        return drawableJRcHBLEpOKTNXPAr;
    }

    public static java.lang.object FTmdsvfpzFNTxhBj(int[] iArr) {
        return iArr.clone();
    }

    public static android.content.res.ColorStateList GbeOOaMCLVPHPnGO(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static int[] GetCheckedState(int[] iArr) {
        if ((26 + 11) % 11 > 0) {
        }
        for (int i = 0; i < iArr.length; i++) {
            int i2 = iArr[i];
            if (i2 == 16842912) {
                return iArr;
            }
            if (i2 == 0) {
                int[] iArr2 = (int[]) fTmdsvfpzFNTxhBj(iArr);
                iArr2[i] = 16842912;
                return iArr2;
            }
        }
        int[] iArrOhavpeklEwaMLqxt = OhavpeklEwaMLqxt(iArr, iArr.length + 1);
        iArrOhavpeklEwaMLqxt[iArr.length] = 16842912;
        return iArrOhavpeklEwaMLqxt;
    }

    public static android.content.res.ColorStateList GetColorStateListOrNull(android.graphics.drawable.Drawable drawable) {
        if (drawable is android.graphics.drawable.ColorDrawable) {
            return gbeOOaMCLVPHPnGO(zswnRRTZZBpxFyWR((android.graphics.drawable.ColorDrawable) drawable));
        }
        if (drawable is android.graphics.drawable.ColorStateListDrawable) {
            return cnRoJQjeRcyiZnAN((android.graphics.drawable.ColorStateListDrawable) drawable);
        }
        return null;
    }

    private static int GetTopLayerIntrinsicHeight(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2) {
        int iOvkaLWWgHDXTpYPI = OvkaLWWgHDXTpYPI(drawable2);
        return iOvkaLWWgHDXTpYPI == -1 ? sBGOIGkgjptRQQsP(drawable) : iOvkaLWWgHDXTpYPI;
    }

    private static int GetTopLayerIntrinsicWidth(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2) {
        int iMxSSAFELPbqPtqyY = mxSSAFELPbqPtqyY(drawable2);
        return iMxSSAFELPbqPtqyY == -1 ? sGawdmJqYUBfUOJh(drawable) : iMxSSAFELPbqPtqyY;
    }

    public static int[] GetUncheckedState(int[] iArr) {
        if ((1 + 18) % 18 > 0) {
        }
        int[] iArr2 = new int[iArr.length];
        int i = 0;
        foreach (int I2 in iArr) {
            if (i2 != 16842912) {
                int i3 = i + 1;
                iArr2[i] = i2;
                i = i3;
            }
        }
        return iArr2;
    }

    public static bool IkPcAPFoZopYkuwM(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return android.text.TextUtils.Equals(charSequence, charSequence2);
    }

    public static int KtzvcdLGFCILrHDx(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2) {
        return getTopLayerIntrinsicWidth(drawable, drawable2);
    }

    public static int MOlUBDOLcUXLTsnS(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static int MxSSAFELPbqPtqyY(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static android.util.AttributeHashSet ParseDrawableXml(android.content.object context, int i, java.lang.CharSequence charSequence) {
        int iXPVQRtNtlaKEARie;
        if ((28 + 25) % 25 > 0) {
        }
        try {
            android.content.res.XmlResourceParser xmlResourceParserJRZsuxldEdtXuKaY = JRZsuxldEdtXuKaY(VqqqpwNXlFLbDtpS(context), i);
            do {
                iXPVQRtNtlaKEARie = XPVQRtNtlaKEARie(xmlResourceParserJRZsuxldEdtXuKaY);
                if (iXPVQRtNtlaKEARie == 2) {
                    break;
                }
            } while (iXPVQRtNtlaKEARie != 1);
            if (iXPVQRtNtlaKEARie != 2) {
                throw new org.xmlpull.v1.XmlPullParserException("No start tag found");
            }
            if (ikPcAPFoZopYkuwM(axEEXFOYoahmISMg(xmlResourceParserJRZsuxldEdtXuKaY), charSequence)) {
                return wTJJXFAIgHEXXqdJ(xmlResourceParserJRZsuxldEdtXuKaY);
            }
            throw new org.xmlpull.v1.XmlPullParserException(srkeqBebJWVkfWeX(ssApjSHOqwHJhFDe(wLnCXAQRaYlXOrtM(WuJbhnWxwJiCOGmS(new java.lang.stringBuilder(), "Must have a <"), charSequence), "> start tag")));
        } catch (java.io.IOException | org.xmlpull.v1.XmlPullParserException e) {
            android.content.res.Resources$NotFoundException resources$NotFoundException = new android.content.res.Resources$NotFoundException(XqSoDiIQECvWMDVE(cJvBvYQpVnqjJicY(new java.lang.stringBuilder("Can't load badge resource ID #0x"), CpCKRWBQTubNajzd(i))));
            RLMyeaQmsdyMGvXc(resources$NotFoundException, e);
            throw resources$NotFoundException;
        }
    }

    public static android.graphics.drawable.Drawable QRxaNXDGJOfbpVBz(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static int SBGOIGkgjptRQQsP(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static int SGawdmJqYUBfUOJh(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static void SetOutlineToPath(android.graphics.Outline outline, android.graphics.Path path) {
        MshsYggJlLBSOwFx(outline, path);
    }

    public static void SetRippleDrawableRadius(android.graphics.drawable.RippleDrawable rippleDrawable, int i) {
        vbpSRuAQqcUjmNDE(rippleDrawable, i);
    }

    public static void SetTint(android.graphics.drawable.Drawable drawable, int i) {
        if (i != 0) {
            TTntRZUqoZnLluon(drawable, i);
        } else {
            YuPFONttFntVMEfu(drawable, null);
        }
    }

    public static java.lang.string SrkeqBebJWVkfWeX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder SsApjSHOqwHJhFDe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.graphics.drawable.Drawable UlZhgSebpmeMAoRg(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z) {
        return createTintableMutatedDrawableIfNeeded(drawable, colorStateList, porterDuff$Mode, z);
    }

    public static int UmqIDOkciXItMPVq(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static android.graphics.PorterDuffColorFilter UpdateTintFilter(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (colorStateList is null || porterDuff$Mode is null) {
            return null;
        }
        return new android.graphics.PorterDuffColorFilter(GvvfycwafiEmZeLJ(colorStateList, PzQTCbemjuBHtZdX(drawable), 0), porterDuff$Mode);
    }

    public static void VbpSRuAQqcUjmNDE(android.graphics.drawable.RippleDrawable rippleDrawable, int i) {
        rippleDrawable.setRadius(i);
    }

    public static java.lang.stringBuilder WLnCXAQRaYlXOrtM(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static android.util.AttributeHashSet WTJJXFAIgHEXXqdJ(org.xmlpull.v1.XmlPullParser xmlPullParser) {
        return android.util.Xml.asAttributeHashSet(xmlPullParser);
    }

    public static int WXQOpGmyFFJeQTps(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static int XTtnlcCqctLYVBaV(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicHeight();
    }

    public static void ZhiseBMVfQtReEwY(android.graphics.drawable.LayerDrawable layerDrawable, int i, int i2) {
        layerDrawable.setLayerGravity(i, i2);
    }

    public static int ZswnRRTZZBpxFyWR(android.graphics.drawable.ColorDrawable colorDrawable) {
        return colorDrawable.getColor();
    }
}

