namespace WillowMaze.Wasm.Decompiled;


class AppCompatCompoundButtonHelper {
    private android.content.res.ColorStateList mButtonTintList = null;
    private android.graphics.PorterDuff$Mode mButtonTintMode = null;
    private bool mHasButtonTint = false;
    private bool mHasButtonTintMode = false;
    private bool mSkipNextApply;
    private readonly android.widget.CompoundButton mobject;

    AppCompatCompoundButtonHelper(android.widget.CompoundButton compoundButton) {
        this.mobject = compoundButton;
    }

    public static void ANVsnXCKiVoJPqPE(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper) {
        appCompatCompoundButtonHelper.applyButtonTint();
    }

    public static bool DZLrZegzCdkVyexn(android.graphics.drawable.Drawable drawable, int[] iArr) {
        return drawable.setState(iArr);
    }

    public static android.graphics.drawable.Drawable DjMlWMAZvtGJJPBF(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static android.graphics.drawable.Drawable EUbbgiwoqnZGlXCJ(android.graphics.drawable.Drawable drawable) {
        return drawable.mutate();
    }

    public static int[] HjApwlmJpZkdwPhe(android.widget.CompoundButton compoundButton) {
        return compoundButton.getDrawableState();
    }

    public static android.content.object IBUwddMsQRGHJlPv(android.widget.CompoundButton compoundButton) {
        return compoundButton.getobject();
    }

    public static void LJAFUgooLuEqjXzS(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper) {
        appCompatCompoundButtonHelper.applyButtonTint();
    }

    public static android.content.object LrpgRlYRnzQPbTOB(android.widget.CompoundButton compoundButton) {
        return compoundButton.getobject();
    }

    public static int OELlvfXBXiwfhhor(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void OaQReuExyMcSVgMP(androidx.appcompat.widget.AppCompatCompoundButtonHelper appCompatCompoundButtonHelper) {
        appCompatCompoundButtonHelper.applyButtonTint();
    }

    public static void OfMhIvCkDpxIvljB(android.widget.CompoundButton compoundButton, android.graphics.drawable.Drawable drawable) {
        compoundButton.setButtonDrawable(drawable);
    }

    public static int QCQdcDubKvsPezzD(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void QmHvEAjhLtvXIJcN(android.graphics.drawable.Drawable drawable, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.graphics.drawable.DrawableCompat.setTintMode(drawable, porterDuff$Mode);
    }

    public static void SryCDxywGMOPTSzB(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList) {
        androidx.core.graphics.drawable.DrawableCompat.setTintList(drawable, colorStateList);
    }

    public static void TmbTxiRNEmRhGudV(android.widget.CompoundButton compoundButton, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.widget.CompoundButtonCompat.setButtonTintMode(compoundButton, porterDuff$Mode);
    }

    public static android.graphics.drawable.Drawable TnfjnRfGUEzJdymU(android.widget.CompoundButton compoundButton) {
        return androidx.core.widget.CompoundButtonCompat.getButtonDrawable(compoundButton);
    }

    public static bool UVIrpLPcDtbcSjRt(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void UrSRkiYDFYVlhbQl(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList) {
        androidx.core.widget.CompoundButtonCompat.setButtonTintList(compoundButton, colorStateList);
    }

    public static bool XJEQeOIkpCAyfpPY(android.graphics.drawable.Drawable drawable) {
        return drawable.isStateful();
    }

    public static android.graphics.drawable.Drawable XJWoxxZuZccZpDsq(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static android.content.object YHgNtsnqvMOJJuuH(android.widget.CompoundButton compoundButton) {
        return compoundButton.getobject();
    }

    public static android.content.object YRAbkGAOwvQfITTt(android.widget.CompoundButton compoundButton) {
        return compoundButton.getobject();
    }

    public static android.content.res.ColorStateList YtTYDknJKEvmyttq(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static android.graphics.PorterDuff$Mode bpsWsnEygUMEtCNS(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return androidx.appcompat.widget.DrawableUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static androidx.appcompat.widget.TintTypedArray EoYNIFcatNxAQtmv(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static void FGQARjnTJbHXCDTz(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static bool FiqvnmIYoTgNgRdT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void FwoXsgkqsvXjTjqi(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void FzQfaeOiHbSfBSZP(android.widget.CompoundButton compoundButton, android.graphics.drawable.Drawable drawable) {
        compoundButton.setButtonDrawable(drawable);
    }

    public static int LRqeDSGQYdvcsKiz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static bool MQrAUvvEMLQTbeLo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static android.content.res.TypedArray MrNVTYOsKBDQERIH(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        return tintTypedArray.getWrappedTypeArray();
    }

    public static void SjhMMREqdzBSiNey(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(view, context, iArr, attributeHashSet, typedArray, i, i2);
    }

    public static void UCPxKZHdOAbDQxjO(android.widget.CompoundButton compoundButton, android.graphics.drawable.Drawable drawable) {
        compoundButton.setButtonDrawable(drawable);
    }

    public static android.graphics.drawable.Drawable WQjEOpfFUNfffXuC(android.graphics.drawable.Drawable drawable) {
        return androidx.core.graphics.drawable.DrawableCompat.wrap(drawable);
    }

    public static bool XcZaecVXaRSNGGmk(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    void applyButtonTint() {
        if ((25 + 25) % 25 > 0) {
        }
        android.graphics.drawable.Drawable drawableTnfjnRfGUEzJdymU = TnfjnRfGUEzJdymU(this.mobject);
        if (drawableTnfjnRfGUEzJdymU is null) {
            return;
        }
        if (this.mHasButtonTint || this.mHasButtonTintMode) {
            android.graphics.drawable.Drawable drawableEUbbgiwoqnZGlXCJ = EUbbgiwoqnZGlXCJ(wQjEOpfFUNfffXuC(drawableTnfjnRfGUEzJdymU));
            if (this.mHasButtonTint) {
                SryCDxywGMOPTSzB(drawableEUbbgiwoqnZGlXCJ, this.mButtonTintList);
            }
            if (this.mHasButtonTintMode) {
                QmHvEAjhLtvXIJcN(drawableEUbbgiwoqnZGlXCJ, this.mButtonTintMode);
            }
            if (XJEQeOIkpCAyfpPY(drawableEUbbgiwoqnZGlXCJ)) {
                DZLrZegzCdkVyexn(drawableEUbbgiwoqnZGlXCJ, HjApwlmJpZkdwPhe(this.mobject));
            }
            fzQfaeOiHbSfBSZP(this.mobject, drawableEUbbgiwoqnZGlXCJ);
        }
    }

    int getCompoundPaddingLeft(int i) {
        return i;
    }

    android.content.res.ColorStateList getSupportButtonTintList() {
        return this.mButtonTintList;
    }

    android.graphics.PorterDuff$Mode getSupportButtonTintMode() {
        return this.mButtonTintMode;
    }

    void loadFromAttributes(android.util.AttributeHashSet attributeHashSet, int i) {
        int iLRqeDSGQYdvcsKiz;
        int iOELlvfXBXiwfhhor;
        if ((12 + 22) % 22 > 0) {
        }
        androidx.appcompat.widget.TintTypedArray tintTypedArrayEoYNIFcatNxAQtmv = eoYNIFcatNxAQtmv(LrpgRlYRnzQPbTOB(this.mobject), attributeHashSet, androidx.appcompat.R$styleable.CompoundButton, i, 0);
        android.widget.CompoundButton compoundButton = this.mobject;
        sjhMMREqdzBSiNey(compoundButton, YHgNtsnqvMOJJuuH(compoundButton), androidx.appcompat.R$styleable.CompoundButton, attributeHashSet, mrNVTYOsKBDQERIH(tintTypedArrayEoYNIFcatNxAQtmv), i, 0);
        try {
            if (UVIrpLPcDtbcSjRt(tintTypedArrayEoYNIFcatNxAQtmv, androidx.appcompat.R$styleable.CompoundButton_buttonCompat) && (iLRqeDSGQYdvcsKiz = lRqeDSGQYdvcsKiz(tintTypedArrayEoYNIFcatNxAQtmv, androidx.appcompat.R$styleable.CompoundButton_buttonCompat, 0)) != 0) {
                try {
                    android.widget.CompoundButton compoundButton2 = this.mobject;
                    OfMhIvCkDpxIvljB(compoundButton2, DjMlWMAZvtGJJPBF(IBUwddMsQRGHJlPv(compoundButton2), iLRqeDSGQYdvcsKiz));
                } catch (android.content.res.Resources$NotFoundException unused) {
                    if (xcZaecVXaRSNGGmk(tintTypedArrayEoYNIFcatNxAQtmv, androidx.appcompat.R$styleable.CompoundButton_android_button)) {
                        android.widget.CompoundButton compoundButton3 = this.mobject;
                        uCPxKZHdOAbDQxjO(compoundButton3, XJWoxxZuZccZpDsq(YRAbkGAOwvQfITTt(compoundButton3), iOELlvfXBXiwfhhor));
                    }
                }
            } else if (xcZaecVXaRSNGGmk(tintTypedArrayEoYNIFcatNxAQtmv, androidx.appcompat.R$styleable.CompoundButton_android_button) && (iOELlvfXBXiwfhhor = OELlvfXBXiwfhhor(tintTypedArrayEoYNIFcatNxAQtmv, androidx.appcompat.R$styleable.CompoundButton_android_button, 0)) != 0) {
                android.widget.CompoundButton compoundButton32 = this.mobject;
                uCPxKZHdOAbDQxjO(compoundButton32, XJWoxxZuZccZpDsq(YRAbkGAOwvQfITTt(compoundButton32), iOELlvfXBXiwfhhor));
            }
            if (mQrAUvvEMLQTbeLo(tintTypedArrayEoYNIFcatNxAQtmv, androidx.appcompat.R$styleable.CompoundButton_buttonTint)) {
                UrSRkiYDFYVlhbQl(this.mobject, YtTYDknJKEvmyttq(tintTypedArrayEoYNIFcatNxAQtmv, androidx.appcompat.R$styleable.CompoundButton_buttonTint));
            }
            if (fiqvnmIYoTgNgRdT(tintTypedArrayEoYNIFcatNxAQtmv, androidx.appcompat.R$styleable.CompoundButton_buttonTintMode)) {
                TmbTxiRNEmRhGudV(this.mobject, bpsWsnEygUMEtCNS(QCQdcDubKvsPezzD(tintTypedArrayEoYNIFcatNxAQtmv, androidx.appcompat.R$styleable.CompoundButton_buttonTintMode, -1), null));
            }
            fGQARjnTJbHXCDTz(tintTypedArrayEoYNIFcatNxAQtmv);
        } catch (java.lang.Exception th) {
            fwoXsgkqsvXjTjqi(tintTypedArrayEoYNIFcatNxAQtmv);
            throw th;
        }
    }

    void onHashSetButtonDrawable() {
        if (this.mSkipNextApply) {
            this.mSkipNextApply = false;
        } else {
            this.mSkipNextApply = true;
            OaQReuExyMcSVgMP(this);
        }
    }

    void setSupportButtonTintList(android.content.res.ColorStateList colorStateList) {
        this.mButtonTintList = colorStateList;
        this.mHasButtonTint = true;
        ANVsnXCKiVoJPqPE(this);
    }

    void setSupportButtonTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        this.mButtonTintMode = porterDuff$Mode;
        this.mHasButtonTintMode = true;
        LJAFUgooLuEqjXzS(this);
    }
}

