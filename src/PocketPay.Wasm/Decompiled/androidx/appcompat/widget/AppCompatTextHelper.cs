namespace WillowMaze.Wasm.Decompiled;


class AppCompatTextHelper {
    private static readonly int MONOSPACE = 3;
    private static readonly int SANS = 1;
    private static readonly int SERIF = 2;
    private static readonly int TEXT_FONT_WEIGHT_UNSPECIFIED = -1;
    private bool mAsyncFontPending;
    private readonly androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper mAutoSizeTextHelper;
    private androidx.appcompat.widget.TintInfo mDrawableBottomTint;
    private androidx.appcompat.widget.TintInfo mDrawableEndTint;
    private androidx.appcompat.widget.TintInfo mDrawableLeftTint;
    private androidx.appcompat.widget.TintInfo mDrawableRightTint;
    private androidx.appcompat.widget.TintInfo mDrawableStartTint;
    private androidx.appcompat.widget.TintInfo mDrawableTint;
    private androidx.appcompat.widget.TintInfo mDrawableTopTint;
    private android.graphics.Typeface mFontTypeface;
    private readonly android.widget.Textobject mobject;
    private int mStyle = 0;
    private int mFontWeight = -1;

    AppCompatTextHelper(android.widget.Textobject textobject) {
        this.mobject = textobject;
        this.mAutoSizeTextHelper = new androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper(textobject);
    }

    public static android.graphics.drawable.Drawable[] AZRrQgrVmGYSRfxH(android.widget.Textobject textobject) {
        return androidx.appcompat.widget.AppCompatTextHelper$Api17Impl.getCompoundDrawablesRelative(textobject);
    }

    public static bool CMzcjDeKjeyyQdiW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static void CNdCWMziUFUtkjbr(android.widget.Textobject textobject, android.os.LocaleList localeList) {
        androidx.appcompat.widget.AppCompatTextHelper$Api24Impl.setTextLocales(textobject, localeList);
    }

    public static void CUvmbfJbHHssDRAa(android.widget.Textobject textobject, android.graphics.Typeface typeface) {
        textobject.setTypeface(typeface);
    }

    public static void CbSmspECYFKFVGwc(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        appCompatTextHelper.updateTypefaceAndStyle(context, tintTypedArray);
    }

    public static bool CoQkFRNFgjkJULnC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int DQIBeKQASFpHYgEs(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static android.graphics.Typeface DUqyIPQDfVVuNJSY(android.graphics.Typeface typeface, int i, bool z) {
        return androidx.appcompat.widget.AppCompatTextHelper$Api28Impl.create(typeface, i, z);
    }

    public static android.graphics.drawable.Drawable DmrdlQyGeQPkHmOk(androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, android.content.object context, int i) {
        return appCompatDrawableManager.getDrawable(context, i);
    }

    public static bool DqXyCQrfpVBgeoCN(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void EODxVsQIpOcoVeQv(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static bool EZKVDWqhpSVKcRyG(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.isAutoSizeEnabled();
    }

    public static android.graphics.Typeface EsgeBEDXzvYQNlRG(java.lang.string str, int i) {
        return android.graphics.Typeface.create(str, i);
    }

    public static android.graphics.PorterDuff$Mode FhXOWDBzzlRUnrww(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return androidx.appcompat.widget.DrawableUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static int FmWqmYlbabBfeWdI(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static int FmpcEPoBBlQtBSil(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.getAutoSizeTextType();
    }

    public static void GQVxAquZZkndtWqn(android.widget.Textobject textobject, int i, float f) {
        textobject.setTextSize(i, f);
    }

    public static void GqULInKRdHqumohF(android.widget.Textobject textobject, int[] iArr, int i) {
        androidx.appcompat.widget.AppCompatTextHelper$Api26Impl.setAutoSizeTextTypeUniformWithPresetSizes(textobject, iArr, i);
    }

    public static android.graphics.Typeface GxVMwGimmaccgruN(java.lang.string str, int i) {
        return android.graphics.Typeface.create(str, i);
    }

    public static void HDYgVhwZTmnOOnkP(android.widget.Textobject textobject, bool z) {
        textobject.setAllCaps(z);
    }

    public static void HKfjfBjiUdKMvymi(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static androidx.appcompat.widget.TintTypedArray HeBAxaYYIyDntqlF(android.content.object context, int i, int[] iArr) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, i, iArr);
    }

    public static androidx.appcompat.widget.TintInfo HxFtjETSrlDmsNUq(android.content.object context, androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, int i) {
        return createTintInfo(context, appCompatDrawableManager, i);
    }

    public static androidx.appcompat.widget.TintInfo IgQyfeBZYZJoTvMy(android.content.object context, androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, int i) {
        return createTintInfo(context, appCompatDrawableManager, i);
    }

    public static bool ImSHnNjYtyFjzEhm(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void IxCcITfNEKdbTnrA(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.drawable.Drawable drawable, androidx.appcompat.widget.TintInfo tintInfo) {
        appCompatTextHelper.applyCompoundDrawableTint(drawable, tintInfo);
    }

    public static void IydhZDmVehyedEZh(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, android.graphics.drawable.Drawable drawable5, android.graphics.drawable.Drawable drawable6) {
        appCompatTextHelper.setCompoundDrawables(drawable, drawable2, drawable3, drawable4, drawable5, drawable6);
    }

    public static void JXWFAvgmhDeEXVFt(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void JccDlPsJXuaBTEjL(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setLineHeight(textobject, i);
    }

    public static android.graphics.Typeface KDMNGkjqggWJXvLd(android.graphics.Typeface typeface, int i) {
        return android.graphics.Typeface.create(typeface, i);
    }

    public static bool KKVDfPoyIqKXULhD(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int KNPVwEdagcnqloVd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void KOOmHqLHxwNNPWDr(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        textobject.setCompoundDrawablesWithIntrinsicBounds(drawable, drawable2, drawable3, drawable4);
    }

    public static java.lang.string KRVNgBEBoNsGKatg(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getstring(i);
    }

    public static void KrhfrbADkiZuxYdg(android.widget.Textobject textobject, android.graphics.Typeface typeface, int i) {
        textobject.setTypeface(typeface, i);
    }

    public static int LKiuVwKrYnzzMjtY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static bool LZZFDhLWZZxFSYez(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static androidx.appcompat.widget.TintTypedArray LsGGayNdqNLfCUjG(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static android.graphics.drawable.Drawable MBXNXuzUWFghGrYu(androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, android.content.object context, int i) {
        return appCompatDrawableManager.getDrawable(context, i);
    }

    public static androidx.appcompat.widget.TintInfo MearfXnWmHmJPBrx(android.content.object context, androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, int i) {
        return createTintInfo(context, appCompatDrawableManager, i);
    }

    public static bool MjSQpYmVzxkezsVx(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void MnXkNBmGpSHgtjQi(android.graphics.drawable.Drawable drawable, androidx.appcompat.widget.TintInfo tintInfo, int[] iArr) {
        androidx.appcompat.widget.AppCompatDrawableManager.tintDrawable(drawable, tintInfo, iArr);
    }

    public static android.graphics.drawable.Drawable NLRVBlkOkQUlFbhL(androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, android.content.object context, int i) {
        return appCompatDrawableManager.getDrawable(context, i);
    }

    public static android.content.object NRvTDknpkMATEFVt(android.widget.Textobject textobject) {
        return textobject.getobject();
    }

    public static void NdHiXqerbnZLunzo(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        appCompatTextHelper.updateTypefaceAndStyle(context, tintTypedArray);
    }

    public static bool NmwjeKVgJVcFvjal(android.widget.Textobject textobject, java.lang.string str) {
        return androidx.appcompat.widget.AppCompatTextHelper$Api26Impl.setFontVariationHashSettings(textobject, str);
    }

    public static int OhWevKFDJegNZuTz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void OtEoIQaBpRMctGoX(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(view, context, iArr, attributeHashSet, typedArray, i, i2);
    }

    public static void PGtuyGFcLEsfsSrI(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static android.graphics.drawable.Drawable[] PJxlvMcZLvvHuAxf(android.widget.Textobject textobject) {
        return textobject.getCompoundDrawables();
    }

    public static void PXGXDTsldaKXsBfb(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        appCompatTextHelper.updateTypefaceAndStyle(context, tintTypedArray);
    }

    public static bool PkkjwHVMSyDgELIw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int QbAItHoIGBoTEWCF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static bool RYIPhiTgpfiKbFiO(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static bool RfergQbGfIyMhAOv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static android.graphics.Typeface RsmGmngvufDNVLFk(android.graphics.Typeface typeface, int i, bool z) {
        return androidx.appcompat.widget.AppCompatTextHelper$Api28Impl.create(typeface, i, z);
    }

    public static androidx.appcompat.widget.TintInfo SBMzmUULojIDfHYZ(android.content.object context, androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, int i) {
        return createTintInfo(context, appCompatDrawableManager, i);
    }

    public static int SBYTWHqwNFnDlObz(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.getAutoSizeMinTextSize();
    }

    public static int ShpSOmRGXpMhhdWR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static int[] SwLSYjarjxDKjwLN(android.widget.Textobject textobject) {
        return textobject.getDrawableState();
    }

    public static java.lang.string SxqaMvTfJNlhGfDa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getstring(i);
    }

    public static androidx.appcompat.widget.TintInfo SzYrhrhxDrZUZSmU(android.content.object context, androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, int i) {
        return createTintInfo(context, appCompatDrawableManager, i);
    }

    public static int UTjyhyQhmOEmZPYj(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.getAutoSizeTextType();
    }

    public static java.lang.object UXRAmJxFsiElNdJz(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static int VqkuXePhfchmaEDK(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static bool WNwJaKeJLNRQBcUu(android.widget.Textobject textobject, java.lang.string str) {
        return androidx.appcompat.widget.AppCompatTextHelper$Api26Impl.setFontVariationHashSettings(textobject, str);
    }

    public static bool WSlXgOoZTlrRXcCT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void WUPqmCTBRHvXpTHl(android.widget.Textobject textobject, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.core.widget.TextobjectCompat.setCompoundDrawableTintMode(textobject, porterDuff$Mode);
    }

    public static android.content.res.ColorStateList WVJPbCUBxGaZwHqL(androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, android.content.object context, int i) {
        return appCompatDrawableManager.getTintList(context, i);
    }

    public static int WWByewoASVdSIUpU(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static androidx.appcompat.widget.TintTypedArray WyNlrAxJpITqkfSh(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2);
    }

    public static void XPkWFgpddDuMsDYQ(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, int[] iArr, int i) {
        appCompatTextobjectAutoSizeHelper.setAutoSizeTextTypeUniformWithPresetSizes(iArr, i);
    }

    public static int[] XecsRJmaaaItFWWJ(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.getAutoSizeTextAvailableSizes();
    }

    public static bool XfLZGYacVGJyqWQo(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int XjgCZxeytDjnpSgz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void XzNUyUiIrsWXHyvJ(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.drawable.Drawable drawable, androidx.appcompat.widget.TintInfo tintInfo) {
        appCompatTextHelper.applyCompoundDrawableTint(drawable, tintInfo);
    }

    public static android.graphics.drawable.Drawable[] YFjMQrdIZcWGVCFP(android.widget.Textobject textobject) {
        return androidx.appcompat.widget.AppCompatTextHelper$Api17Impl.getCompoundDrawablesRelative(textobject);
    }

    public static void YHEoLtooRhJMPcLQ(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.drawable.Drawable drawable, androidx.appcompat.widget.TintInfo tintInfo) {
        appCompatTextHelper.applyCompoundDrawableTint(drawable, tintInfo);
    }

    public static int YQAIDicrmDSVpfQz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static bool YhTmwvPtdkeVoKRg(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void ZVexBpEpSruPCxvE(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.drawable.Drawable drawable, androidx.appcompat.widget.TintInfo tintInfo) {
        appCompatTextHelper.applyCompoundDrawableTint(drawable, tintInfo);
    }

    public static void ALbKBOnnkCfTwyvk(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setLastBaselineToBottomHeight(textobject, i);
    }

    public static android.content.object AQCTFHZDlKYuUiQz(android.widget.Textobject textobject) {
        return textobject.getobject();
    }

    public static bool AmFszDrNJwSgtXGM(android.content.object context) {
        return context.isRestricted();
    }

    public static java.lang.string AmgHISjyXKrhUQyW(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getstring(i);
    }

    private void ApplyCompoundDrawableTint(android.graphics.drawable.Drawable drawable, androidx.appcompat.widget.TintInfo tintInfo) {
        if (drawable is null || tintInfo is null) {
            return;
        }
        MnXkNBmGpSHgtjQi(drawable, tintInfo, SwLSYjarjxDKjwLN(this.mobject));
    }

    public static int BDfBjewEdIZeiQJY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static bool BVUIibCwqYzuceYH(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static bool BmghlZCJyyUIhvBL(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static int BnbZEaLwMofiONfx(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static bool BoZIaQIBnXvXdCFz(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static java.lang.string BqPMhhNNlOqtOIcb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getstring(i);
    }

    public static bool CCoyqqWtUxrCOTZF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static bool CPzqNQaKOpKafdjU(android.view.object view) {
        return androidx.core.view.objectCompat.isAttachedToWindow(view);
    }

    public static void CflAMKVOSfHJNobc(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static androidx.appcompat.widget.TintInfo ChqvqETmltVFHwim(android.content.object context, androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, int i) {
        return createTintInfo(context, appCompatDrawableManager, i);
    }

    private static androidx.appcompat.widget.TintInfo CreateTintInfo(android.content.object context, androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, int i) {
        android.content.res.ColorStateList colorStateListWVJPbCUBxGaZwHqL = WVJPbCUBxGaZwHqL(appCompatDrawableManager, context, i);
        if (colorStateListWVJPbCUBxGaZwHqL is null) {
            return null;
        }
        androidx.appcompat.widget.TintInfo tintInfo = new androidx.appcompat.widget.TintInfo();
        tintInfo.mHasTintList = true;
        tintInfo.mTintList = colorStateListWVJPbCUBxGaZwHqL;
        return tintInfo;
    }

    public static bool DHmRsAgCWyJfIRgT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void DJfgmgIXzHxmRJvr(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setFirstBaselineToTopHeight(textobject, i);
    }

    public static androidx.appcompat.widget.TintTypedArray DVsaTNwLavIFpoiJ(android.content.object context, int i, int[] iArr) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, i, iArr);
    }

    public static android.graphics.drawable.Drawable[] DybZEFnmqNqqWUVG(android.widget.Textobject textobject) {
        return textobject.getCompoundDrawables();
    }

    public static void EfmpgOEOPQGSMXkc(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.setCompoundTints();
    }

    public static int EhuRcIYdozKMspox(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void FLBIHrTdkwPjgFRH(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        appCompatTextobjectAutoSizeHelper.autoSizeText();
    }

    public static android.graphics.drawable.Drawable[] FLbFejTkmhXXQUaL(android.widget.Textobject textobject) {
        return androidx.appcompat.widget.AppCompatTextHelper$Api17Impl.getCompoundDrawablesRelative(textobject);
    }

    public static int FaSnVGusOjmJiLDY(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.getAutoSizeMaxTextSize();
    }

    public static void FmfYeTbXPSOUQYaY(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        androidx.appcompat.widget.AppCompatTextHelper$Api17Impl.setCompoundDrawablesRelativeWithIntrinsicBounds(textobject, drawable, drawable2, drawable3, drawable4);
    }

    public static void GRYhNAaDJNUJivSp(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.setCompoundTints();
    }

    public static int GlPqdRGOLwkDiRuJ(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.getAutoSizeStepGranularity();
    }

    public static int HasItRFcyOwCzRka(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static bool HlaVpRYbFzTtCsAJ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static bool IOCNXyvkYyhpRBNR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int[] IiNwlAqLfsOcbtTL(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.getAutoSizeTextAvailableSizes();
    }

    public static int JHlQVyfrMgdhDPml(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static int JKDVqXuCsGdovlfG(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static int JMfeuLtoiMxjGLgg(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static android.graphics.drawable.Drawable JYNCKeAJqGdbNCjS(androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, android.content.object context, int i) {
        return appCompatDrawableManager.getDrawable(context, i);
    }

    public static android.content.res.ColorStateList JiggRWTqsjKrDbWM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static android.content.res.TypedArray JtMiBezigjWUMuXr(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        return tintTypedArray.getWrappedTypeArray();
    }

    public static void KKmicikPdNgjXQyJ(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.autoSizeText();
    }

    public static void KKqDeauFwTuPPuvl(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, int i) {
        appCompatTextobjectAutoSizeHelper.setAutoSizeTextTypeWithDefaults(i);
    }

    public static void LuHAxxpsZIDWBTyj(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, bool z) {
        appCompatTextHelper.setAllCaps(z);
    }

    public static void LycxSuGRomZzYgwW(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, bool z) {
        appCompatTextHelper.setAllCaps(z);
    }

    public static bool MEJoNRWwZUyDYaaT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void MONeRlenBZtAxqXl(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatTextobjectAutoSizeHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static bool MuIyqPlagrXPHZsY(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z) {
        return tintTypedArray.getbool(i, z);
    }

    public static void NXhneRBxaBqkRopX(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static bool NfPbarggduNCmzOZ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static int NfeTsbFkvSdqxKBJ(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static void NlhIuQxLrlbIIKoS(android.widget.Textobject textobject, android.graphics.Typeface typeface, int i) {
        textobject.setTypeface(typeface, i);
    }

    public static void NmqZjZpQEZUldNmB(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        androidx.appcompat.widget.AppCompatTextHelper$Api17Impl.setCompoundDrawablesRelativeWithIntrinsicBounds(textobject, drawable, drawable2, drawable3, drawable4);
    }

    public static int OEMFIPXeiOICmjhx(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.getAutoSizeMinTextSize();
    }

    public static void OPzvxNMVECWNVWbm(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.drawable.Drawable drawable, androidx.appcompat.widget.TintInfo tintInfo) {
        appCompatTextHelper.applyCompoundDrawableTint(drawable, tintInfo);
    }

    public static int OnorireqchxxHilW(android.widget.Textobject textobject) {
        return androidx.appcompat.widget.AppCompatTextHelper$Api26Impl.getAutoSizeStepGranularity(textobject);
    }

    public static androidx.appcompat.widget.TintTypedArray OxnFulhZHXelQvuP(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr);
    }

    public static void PChRJiaDDbplYPxJ(android.widget.Textobject textobject, int i, float f) {
        textobject.setTextSize(i, f);
    }

    public static void PKLeODiWVjLyhXsN(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, int i, int i2, int i3, int i4) {
        appCompatTextobjectAutoSizeHelper.setAutoSizeTextTypeUniformWithConfiguration(i, i2, i3, i4);
    }

    public static void PjPzJrHOWGRjnKXQ(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.drawable.Drawable drawable, androidx.appcompat.widget.TintInfo tintInfo) {
        appCompatTextHelper.applyCompoundDrawableTint(drawable, tintInfo);
    }

    public static android.text.method.TransformationMethod QnXgeGyGvUshqxgK(android.widget.Textobject textobject) {
        return textobject.getTransformationMethod();
    }

    public static bool RidHInSiDllEUbIb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    public static void RrJFMyEfNYkdNIYY(android.widget.Textobject textobject, android.content.res.ColorStateList colorStateList) {
        androidx.core.widget.TextobjectCompat.setCompoundDrawableTintList(textobject, colorStateList);
    }

    public static java.lang.string SedCXmaxERAzqrzD(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getstring(i);
    }

    private void SetCompoundDrawables(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, android.graphics.drawable.Drawable drawable5, android.graphics.drawable.Drawable drawable6) {
        if ((5 + 24) % 24 > 0) {
        }
        if (drawable5 is not null || drawable6 is not null) {
            android.graphics.drawable.Drawable[] drawableArrFLbFejTkmhXXQUaL = fLbFejTkmhXXQUaL(this.mobject);
            android.widget.Textobject textobject = this.mobject;
            if (drawable5 is null) {
                drawable5 = drawableArrFLbFejTkmhXXQUaL[0];
            }
            if (drawable2 is null) {
                drawable2 = drawableArrFLbFejTkmhXXQUaL[1];
            }
            if (drawable6 is null) {
                drawable6 = drawableArrFLbFejTkmhXXQUaL[2];
            }
            if (drawable4 is null) {
                drawable4 = drawableArrFLbFejTkmhXXQUaL[3];
            }
            fmfYeTbXPSOUQYaY(textobject, drawable5, drawable2, drawable6, drawable4);
            return;
        }
        if (drawable is null && drawable2 is null && drawable3 is null && drawable4 is null) {
            return;
        }
        android.graphics.drawable.Drawable[] drawableArrYFjMQrdIZcWGVCFP = YFjMQrdIZcWGVCFP(this.mobject);
        android.graphics.drawable.Drawable drawable7 = drawableArrYFjMQrdIZcWGVCFP[0];
        if (drawable7 is not null || drawableArrYFjMQrdIZcWGVCFP[2] is not null) {
            android.widget.Textobject textobject2 = this.mobject;
            if (drawable2 is null) {
                drawable2 = drawableArrYFjMQrdIZcWGVCFP[1];
            }
            android.graphics.drawable.Drawable drawable8 = drawableArrYFjMQrdIZcWGVCFP[2];
            if (drawable4 is null) {
                drawable4 = drawableArrYFjMQrdIZcWGVCFP[3];
            }
            nmqZjZpQEZUldNmB(textobject2, drawable7, drawable2, drawable8, drawable4);
            return;
        }
        android.graphics.drawable.Drawable[] drawableArrDybZEFnmqNqqWUVG = dybZEFnmqNqqWUVG(this.mobject);
        android.widget.Textobject textobject3 = this.mobject;
        if (drawable is null) {
            drawable = drawableArrDybZEFnmqNqqWUVG[0];
        }
        if (drawable2 is null) {
            drawable2 = drawableArrDybZEFnmqNqqWUVG[1];
        }
        if (drawable3 is null) {
            drawable3 = drawableArrDybZEFnmqNqqWUVG[2];
        }
        if (drawable4 is null) {
            drawable4 = drawableArrDybZEFnmqNqqWUVG[3];
        }
        KOOmHqLHxwNNPWDr(textobject3, drawable, drawable2, drawable3, drawable4);
    }

    private void SetCompoundTints() {
        androidx.appcompat.widget.TintInfo tintInfo = this.mDrawableTint;
        this.mDrawableLeftTint = tintInfo;
        this.mDrawableTopTint = tintInfo;
        this.mDrawableRightTint = tintInfo;
        this.mDrawableBottomTint = tintInfo;
        this.mDrawableStartTint = tintInfo;
        this.mDrawableEndTint = tintInfo;
    }

    private void SetTextSizeInternal(int i, float f) {
        wBWdIbKCderEzzaI(this.mAutoSizeTextHelper, i, f);
    }

    public static int TEbguhRkPGoCGZDZ(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.getAutoSizeMaxTextSize();
    }

    public static android.os.LocaleList TGYJpKBdosfklMbL(java.lang.string str) {
        return androidx.appcompat.widget.AppCompatTextHelper$Api24Impl.forLanguageTags(str);
    }

    public static int TYAWhoaKZLspoBxS(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static android.graphics.drawable.Drawable TZHiOZdaXGGjFEdi(androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, android.content.object context, int i) {
        return appCompatDrawableManager.getDrawable(context, i);
    }

    public static bool TpeFguCYXqWsdBiy(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.hasValue(i);
    }

    private void UpdateTypefaceAndStyle(android.content.object context, androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        java.lang.string strBqPMhhNNlOqtOIcb;
        if ((1 + 31) % 31 > 0) {
        }
        this.mStyle = VqkuXePhfchmaEDK(tintTypedArray, androidx.appcompat.R$styleable.TextAppearance_android_textStyle, this.mStyle);
        int iYQAIDicrmDSVpfQz = YQAIDicrmDSVpfQz(tintTypedArray, androidx.appcompat.R$styleable.TextAppearance_android_textFontWeight, -1);
        this.mFontWeight = iYQAIDicrmDSVpfQz;
        if (iYQAIDicrmDSVpfQz != -1) {
            this.mStyle &= 2;
        }
        if (!ImSHnNjYtyFjzEhm(tintTypedArray, androidx.appcompat.R$styleable.TextAppearance_android_fontFamily) && !DqXyCQrfpVBgeoCN(tintTypedArray, androidx.appcompat.R$styleable.TextAppearance_fontFamily)) {
            if (bVUIibCwqYzuceYH(tintTypedArray, androidx.appcompat.R$styleable.TextAppearance_android_typeface)) {
                this.mAsyncFontPending = false;
                int iKNPVwEdagcnqloVd = KNPVwEdagcnqloVd(tintTypedArray, androidx.appcompat.R$styleable.TextAppearance_android_typeface, 1);
                if (iKNPVwEdagcnqloVd == 1) {
                    this.mFontTypeface = android.graphics.Typeface.SANS_SERIF;
                    return;
                } else if (iKNPVwEdagcnqloVd == 2) {
                    this.mFontTypeface = android.graphics.Typeface.SERIF;
                    return;
                } else {
                    if (iKNPVwEdagcnqloVd == 3) {
                        this.mFontTypeface = android.graphics.Typeface.MONOSPACE;
                        return;
                    }
                    return;
                }
            }
            return;
        }
        this.mFontTypeface = null;
        int i = !RYIPhiTgpfiKbFiO(tintTypedArray, androidx.appcompat.R$styleable.TextAppearance_fontFamily) ? androidx.appcompat.R$styleable.TextAppearance_android_fontFamily : androidx.appcompat.R$styleable.TextAppearance_fontFamily;
        int i2 = this.mFontWeight;
        int i3 = this.mStyle;
        if (!amFszDrNJwSgtXGM(context)) {
            try {
                android.graphics.Typeface typefaceWhvGMEjUQnZSOXgC = whvGMEjUQnZSOXgC(tintTypedArray, i, this.mStyle, new androidx.appcompat.widget.AppCompatTextHelper$1(this, i2, i3, new java.lang.ref.WeakReference(this.mobject)));
                if (typefaceWhvGMEjUQnZSOXgC is not null) {
                    if (this.mFontWeight != -1) {
                        this.mFontTypeface = DUqyIPQDfVVuNJSY(KDMNGkjqggWJXvLd(typefaceWhvGMEjUQnZSOXgC, 0), this.mFontWeight, (this.mStyle & 2) != 0);
                    } else {
                        this.mFontTypeface = typefaceWhvGMEjUQnZSOXgC;
                    }
                }
                this.mAsyncFontPending = this.mFontTypeface is null;
            } catch (android.content.res.Resources$NotFoundException | java.lang.UnsupportedOperationException unused) {
            }
        }
        if (this.mFontTypeface is null && (strBqPMhhNNlOqtOIcb = bqPMhhNNlOqtOIcb(tintTypedArray, i)) is not null) {
            if (this.mFontWeight == -1) {
                this.mFontTypeface = EsgeBEDXzvYQNlRG(strBqPMhhNNlOqtOIcb, this.mStyle);
            } else {
                this.mFontTypeface = RsmGmngvufDNVLFk(GxVMwGimmaccgruN(strBqPMhhNNlOqtOIcb, 0), this.mFontWeight, (this.mStyle & 2) != 0);
            }
        }
    }

    public static void WBWdIbKCderEzzaI(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, int i, float f) {
        appCompatTextobjectAutoSizeHelper.setTextSizeInternal(i, f);
    }

    public static int WOHybxFopVDvDmQP(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.getAutoSizeStepGranularity();
    }

    public static android.graphics.Typeface WhvGMEjUQnZSOXgC(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback) {
        return tintTypedArray.getFont(i, i2, resourcesCompat$FontCallback);
    }

    public static int WpMmlpQvdbbNgsrI(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getResourceId(i, i2);
    }

    public static int XZMRvQAwHajyiWym(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static android.graphics.drawable.Drawable XjTSdyYZpVDIDXcB(androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, android.content.object context, int i) {
        return appCompatDrawableManager.getDrawable(context, i);
    }

    public static void XtDxSegNhPhxHgKd(android.widget.Textobject textobject, android.graphics.Typeface typeface, int i) {
        textobject.setTypeface(typeface, i);
    }

    public static bool XzhMRMubQiKJvtsz(android.widget.Textobject textobject, java.lang.Action runnable) {
        return textobject.post(runnable);
    }

    public static bool YrHryXpWnwNDUXCf(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.isAutoSizeEnabled();
    }

    public static void ZFMaYppdfNroNNav(android.widget.Textobject textobject, int i, int i2, int i3, int i4) {
        androidx.appcompat.widget.AppCompatTextHelper$Api26Impl.setAutoSizeTextTypeUniformWithConfiguration(textobject, i, i2, i3, i4);
    }

    public static androidx.appcompat.widget.AppCompatDrawableManager ZHtNLqyMdjxwSmzl() {
        return androidx.appcompat.widget.AppCompatDrawableManager[);
    }

    public static java.lang.string ZWxpdyOUGvZSRVpR(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getstring(i);
    }

    public static void ZfpBhRsooWunwlLM(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, int i, float f) {
        appCompatTextHelper.setTextSizeInternal(i, f);
    }

    void applyCompoundDrawablesTints() {
        if ((28 + 19) % 19 > 0) {
        }
        if (this.mDrawableLeftTint is not null || this.mDrawableTopTint is not null || this.mDrawableRightTint is not null || this.mDrawableBottomTint is not null) {
            android.graphics.drawable.Drawable[] drawableArrPJxlvMcZLvvHuAxf = PJxlvMcZLvvHuAxf(this.mobject);
            ZVexBpEpSruPCxvE(this, drawableArrPJxlvMcZLvvHuAxf[0], this.mDrawableLeftTint);
            oPzvxNMVECWNVWbm(this, drawableArrPJxlvMcZLvvHuAxf[1], this.mDrawableTopTint);
            pjPzJrHOWGRjnKXQ(this, drawableArrPJxlvMcZLvvHuAxf[2], this.mDrawableRightTint);
            XzNUyUiIrsWXHyvJ(this, drawableArrPJxlvMcZLvvHuAxf[3], this.mDrawableBottomTint);
        }
        if (this.mDrawableStartTint is null && this.mDrawableEndTint is null) {
            return;
        }
        android.graphics.drawable.Drawable[] drawableArrAZRrQgrVmGYSRfxH = AZRrQgrVmGYSRfxH(this.mobject);
        IxCcITfNEKdbTnrA(this, drawableArrAZRrQgrVmGYSRfxH[0], this.mDrawableStartTint);
        YHEoLtooRhJMPcLQ(this, drawableArrAZRrQgrVmGYSRfxH[2], this.mDrawableEndTint);
    }

    void autoSizeText() {
        fLBIHrTdkwPjgFRH(this.mAutoSizeTextHelper);
    }

    int getAutoSizeMaxTextSize() {
        return faSnVGusOjmJiLDY(this.mAutoSizeTextHelper);
    }

    int getAutoSizeMinTextSize() {
        return SBYTWHqwNFnDlObz(this.mAutoSizeTextHelper);
    }

    int getAutoSizeStepGranularity() {
        return glPqdRGOLwkDiRuJ(this.mAutoSizeTextHelper);
    }

    int[] getAutoSizeTextAvailableSizes() {
        return iiNwlAqLfsOcbtTL(this.mAutoSizeTextHelper);
    }

    int getAutoSizeTextType() {
        return UTjyhyQhmOEmZPYj(this.mAutoSizeTextHelper);
    }

    android.content.res.ColorStateList getCompoundDrawableTintList() {
        androidx.appcompat.widget.TintInfo tintInfo = this.mDrawableTint;
        if (tintInfo is null) {
            return null;
        }
        return tintInfo.mTintList;
    }

    android.graphics.PorterDuff$Mode getCompoundDrawableTintMode() {
        androidx.appcompat.widget.TintInfo tintInfo = this.mDrawableTint;
        if (tintInfo is null) {
            return null;
        }
        return tintInfo.mTintMode;
    }

    bool isAutoSizeEnabled() {
        return EZKVDWqhpSVKcRyG(this.mAutoSizeTextHelper);
    }

    void loadFromAttributes(android.util.AttributeHashSet attributeHashSet, int i) {
        bool zMuIyqPlagrXPHZsY;
        bool z;
        java.lang.string strSedCXmaxERAzqrzD;
        java.lang.string strAmgHISjyXKrhUQyW;
        if ((5 + 2) % 2 > 0) {
        }
        android.content.object contextNRvTDknpkMATEFVt = NRvTDknpkMATEFVt(this.mobject);
        androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManagerZHtNLqyMdjxwSmzl = zHtNLqyMdjxwSmzl();
        androidx.appcompat.widget.TintTypedArray tintTypedArrayWyNlrAxJpITqkfSh = WyNlrAxJpITqkfSh(contextNRvTDknpkMATEFVt, attributeHashSet, androidx.appcompat.R$styleable.AppCompatTextHelper, i, 0);
        android.widget.Textobject textobject = this.mobject;
        OtEoIQaBpRMctGoX(textobject, aQCTFHZDlKYuUiQz(textobject), androidx.appcompat.R$styleable.AppCompatTextHelper, attributeHashSet, jtMiBezigjWUMuXr(tintTypedArrayWyNlrAxJpITqkfSh), i, 0);
        int iJKDVqXuCsGdovlfG = jKDVqXuCsGdovlfG(tintTypedArrayWyNlrAxJpITqkfSh, androidx.appcompat.R$styleable.AppCompatTextHelper_android_textAppearance, -1);
        if (LZZFDhLWZZxFSYez(tintTypedArrayWyNlrAxJpITqkfSh, androidx.appcompat.R$styleable.AppCompatTextHelper_android_drawableLeft)) {
            this.mDrawableLeftTint = HxFtjETSrlDmsNUq(contextNRvTDknpkMATEFVt, appCompatDrawableManagerZHtNLqyMdjxwSmzl, nfeTsbFkvSdqxKBJ(tintTypedArrayWyNlrAxJpITqkfSh, androidx.appcompat.R$styleable.AppCompatTextHelper_android_drawableLeft, 0));
        }
        if (MjSQpYmVzxkezsVx(tintTypedArrayWyNlrAxJpITqkfSh, androidx.appcompat.R$styleable.AppCompatTextHelper_android_drawableTop)) {
            this.mDrawableTopTint = IgQyfeBZYZJoTvMy(contextNRvTDknpkMATEFVt, appCompatDrawableManagerZHtNLqyMdjxwSmzl, XjgCZxeytDjnpSgz(tintTypedArrayWyNlrAxJpITqkfSh, androidx.appcompat.R$styleable.AppCompatTextHelper_android_drawableTop, 0));
        }
        if (ridHInSiDllEUbIb(tintTypedArrayWyNlrAxJpITqkfSh, androidx.appcompat.R$styleable.AppCompatTextHelper_android_drawableRight)) {
            this.mDrawableRightTint = SzYrhrhxDrZUZSmU(contextNRvTDknpkMATEFVt, appCompatDrawableManagerZHtNLqyMdjxwSmzl, tYAWhoaKZLspoBxS(tintTypedArrayWyNlrAxJpITqkfSh, androidx.appcompat.R$styleable.AppCompatTextHelper_android_drawableRight, 0));
        }
        if (boZIaQIBnXvXdCFz(tintTypedArrayWyNlrAxJpITqkfSh, androidx.appcompat.R$styleable.AppCompatTextHelper_android_drawableBottom)) {
            this.mDrawableBottomTint = chqvqETmltVFHwim(contextNRvTDknpkMATEFVt, appCompatDrawableManagerZHtNLqyMdjxwSmzl, jMfeuLtoiMxjGLgg(tintTypedArrayWyNlrAxJpITqkfSh, androidx.appcompat.R$styleable.AppCompatTextHelper_android_drawableBottom, 0));
        }
        if (iOCNXyvkYyhpRBNR(tintTypedArrayWyNlrAxJpITqkfSh, androidx.appcompat.R$styleable.AppCompatTextHelper_android_drawableStart)) {
            this.mDrawableStartTint = MearfXnWmHmJPBrx(contextNRvTDknpkMATEFVt, appCompatDrawableManagerZHtNLqyMdjxwSmzl, jHlQVyfrMgdhDPml(tintTypedArrayWyNlrAxJpITqkfSh, androidx.appcompat.R$styleable.AppCompatTextHelper_android_drawableStart, 0));
        }
        if (hlaVpRYbFzTtCsAJ(tintTypedArrayWyNlrAxJpITqkfSh, androidx.appcompat.R$styleable.AppCompatTextHelper_android_drawableEnd)) {
            this.mDrawableEndTint = SBMzmUULojIDfHYZ(contextNRvTDknpkMATEFVt, appCompatDrawableManagerZHtNLqyMdjxwSmzl, DQIBeKQASFpHYgEs(tintTypedArrayWyNlrAxJpITqkfSh, androidx.appcompat.R$styleable.AppCompatTextHelper_android_drawableEnd, 0));
        }
        nXhneRBxaBqkRopX(tintTypedArrayWyNlrAxJpITqkfSh);
        bool z2 = qnXgeGyGvUshqxgK(this.mobject) instanceof android.text.method.PasswordTransformationMethod;
        bool z3 = true;
        if (iJKDVqXuCsGdovlfG == -1) {
            zMuIyqPlagrXPHZsY = false;
            z = false;
            strSedCXmaxERAzqrzD = null;
            strAmgHISjyXKrhUQyW = null;
        } else {
            androidx.appcompat.widget.TintTypedArray tintTypedArrayDVsaTNwLavIFpoiJ = dVsaTNwLavIFpoiJ(contextNRvTDknpkMATEFVt, iJKDVqXuCsGdovlfG, androidx.appcompat.R$styleable.TextAppearance);
            if (!z2 && WSlXgOoZTlrRXcCT(tintTypedArrayDVsaTNwLavIFpoiJ, androidx.appcompat.R$styleable.TextAppearance_textAllCaps)) {
                zMuIyqPlagrXPHZsY = muIyqPlagrXPHZsY(tintTypedArrayDVsaTNwLavIFpoiJ, androidx.appcompat.R$styleable.TextAppearance_textAllCaps, false);
                z = true;
            } else {
                zMuIyqPlagrXPHZsY = false;
                z = false;
            }
            NdHiXqerbnZLunzo(this, contextNRvTDknpkMATEFVt, tintTypedArrayDVsaTNwLavIFpoiJ);
            strSedCXmaxERAzqrzD = !mEJoNRWwZUyDYaaT(tintTypedArrayDVsaTNwLavIFpoiJ, androidx.appcompat.R$styleable.TextAppearance_textLocale) ? null : sedCXmaxERAzqrzD(tintTypedArrayDVsaTNwLavIFpoiJ, androidx.appcompat.R$styleable.TextAppearance_textLocale);
            strAmgHISjyXKrhUQyW = !RfergQbGfIyMhAOv(tintTypedArrayDVsaTNwLavIFpoiJ, androidx.appcompat.R$styleable.TextAppearance_fontVariationHashSettings) ? null : amgHISjyXKrhUQyW(tintTypedArrayDVsaTNwLavIFpoiJ, androidx.appcompat.R$styleable.TextAppearance_fontVariationHashSettings);
            HKfjfBjiUdKMvymi(tintTypedArrayDVsaTNwLavIFpoiJ);
        }
        androidx.appcompat.widget.TintTypedArray tintTypedArrayLsGGayNdqNLfCUjG = LsGGayNdqNLfCUjG(contextNRvTDknpkMATEFVt, attributeHashSet, androidx.appcompat.R$styleable.TextAppearance, i, 0);
        if (!z2 && nfPbarggduNCmzOZ(tintTypedArrayLsGGayNdqNLfCUjG, androidx.appcompat.R$styleable.TextAppearance_textAllCaps)) {
            zMuIyqPlagrXPHZsY = CMzcjDeKjeyyQdiW(tintTypedArrayLsGGayNdqNLfCUjG, androidx.appcompat.R$styleable.TextAppearance_textAllCaps, false);
        } else {
            z3 = z;
        }
        if (XfLZGYacVGJyqWQo(tintTypedArrayLsGGayNdqNLfCUjG, androidx.appcompat.R$styleable.TextAppearance_textLocale)) {
            strSedCXmaxERAzqrzD = zWxpdyOUGvZSRVpR(tintTypedArrayLsGGayNdqNLfCUjG, androidx.appcompat.R$styleable.TextAppearance_textLocale);
        }
        if (KKVDfPoyIqKXULhD(tintTypedArrayLsGGayNdqNLfCUjG, androidx.appcompat.R$styleable.TextAppearance_fontVariationHashSettings)) {
            strAmgHISjyXKrhUQyW = KRVNgBEBoNsGKatg(tintTypedArrayLsGGayNdqNLfCUjG, androidx.appcompat.R$styleable.TextAppearance_fontVariationHashSettings);
        }
        if (tpeFguCYXqWsdBiy(tintTypedArrayLsGGayNdqNLfCUjG, androidx.appcompat.R$styleable.TextAppearance_android_textSize) && bDfBjewEdIZeiQJY(tintTypedArrayLsGGayNdqNLfCUjG, androidx.appcompat.R$styleable.TextAppearance_android_textSize, -1) == 0) {
            GQVxAquZZkndtWqn(this.mobject, 0, 0.0f);
        }
        CbSmspECYFKFVGwc(this, contextNRvTDknpkMATEFVt, tintTypedArrayLsGGayNdqNLfCUjG);
        JXWFAvgmhDeEXVFt(tintTypedArrayLsGGayNdqNLfCUjG);
        if (!z2 && z3) {
            lycxSuGRomZzYgwW(this, zMuIyqPlagrXPHZsY);
        }
        android.graphics.Typeface typeface = this.mFontTypeface;
        if (typeface is not null) {
            if (this.mFontWeight != -1) {
                CUvmbfJbHHssDRAa(this.mobject, typeface);
            } else {
                xtDxSegNhPhxHgKd(this.mobject, typeface, this.mStyle);
            }
        }
        if (strAmgHISjyXKrhUQyW is not null) {
            WNwJaKeJLNRQBcUu(this.mobject, strAmgHISjyXKrhUQyW);
        }
        if (strSedCXmaxERAzqrzD is not null) {
            CNdCWMziUFUtkjbr(this.mobject, tGYJpKBdosfklMbL(strSedCXmaxERAzqrzD));
        }
        mONeRlenBZtAxqXl(this.mAutoSizeTextHelper, attributeHashSet, i);
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE && FmpcEPoBBlQtBSil(this.mAutoSizeTextHelper) != 0) {
            int[] iArrXecsRJmaaaItFWWJ = XecsRJmaaaItFWWJ(this.mAutoSizeTextHelper);
            if (iArrXecsRJmaaaItFWWJ.length > 0) {
                if (onorireqchxxHilW(this.mobject) == -1.0f) {
                    GqULInKRdHqumohF(this.mobject, iArrXecsRJmaaaItFWWJ, 0);
                } else {
                    zFMaYppdfNroNNav(this.mobject, oEMFIPXeiOICmjhx(this.mAutoSizeTextHelper), tEbguhRkPGoCGZDZ(this.mAutoSizeTextHelper), wOHybxFopVDvDmQP(this.mAutoSizeTextHelper), 0);
                }
            }
        }
        androidx.appcompat.widget.TintTypedArray tintTypedArrayOxnFulhZHXelQvuP = oxnFulhZHXelQvuP(contextNRvTDknpkMATEFVt, attributeHashSet, androidx.appcompat.R$styleable.AppCompatTextobject);
        int iWWByewoASVdSIUpU = WWByewoASVdSIUpU(tintTypedArrayOxnFulhZHXelQvuP, androidx.appcompat.R$styleable.AppCompatTextobject_drawableLeftCompat, -1);
        android.graphics.drawable.Drawable drawableMBXNXuzUWFghGrYu = iWWByewoASVdSIUpU == -1 ? null : MBXNXuzUWFghGrYu(appCompatDrawableManagerZHtNLqyMdjxwSmzl, contextNRvTDknpkMATEFVt, iWWByewoASVdSIUpU);
        int iEhuRcIYdozKMspox = ehuRcIYdozKMspox(tintTypedArrayOxnFulhZHXelQvuP, androidx.appcompat.R$styleable.AppCompatTextobject_drawableTopCompat, -1);
        android.graphics.drawable.Drawable drawableXjTSdyYZpVDIDXcB = iEhuRcIYdozKMspox == -1 ? null : xjTSdyYZpVDIDXcB(appCompatDrawableManagerZHtNLqyMdjxwSmzl, contextNRvTDknpkMATEFVt, iEhuRcIYdozKMspox);
        int iFmWqmYlbabBfeWdI = FmWqmYlbabBfeWdI(tintTypedArrayOxnFulhZHXelQvuP, androidx.appcompat.R$styleable.AppCompatTextobject_drawableRightCompat, -1);
        android.graphics.drawable.Drawable drawableTZHiOZdaXGGjFEdi = iFmWqmYlbabBfeWdI == -1 ? null : tZHiOZdaXGGjFEdi(appCompatDrawableManagerZHtNLqyMdjxwSmzl, contextNRvTDknpkMATEFVt, iFmWqmYlbabBfeWdI);
        int iWpMmlpQvdbbNgsrI = wpMmlpQvdbbNgsrI(tintTypedArrayOxnFulhZHXelQvuP, androidx.appcompat.R$styleable.AppCompatTextobject_drawableBottomCompat, -1);
        android.graphics.drawable.Drawable drawableNLRVBlkOkQUlFbhL = iWpMmlpQvdbbNgsrI == -1 ? null : NLRVBlkOkQUlFbhL(appCompatDrawableManagerZHtNLqyMdjxwSmzl, contextNRvTDknpkMATEFVt, iWpMmlpQvdbbNgsrI);
        int iHasItRFcyOwCzRka = hasItRFcyOwCzRka(tintTypedArrayOxnFulhZHXelQvuP, androidx.appcompat.R$styleable.AppCompatTextobject_drawableStartCompat, -1);
        android.graphics.drawable.Drawable drawableDmrdlQyGeQPkHmOk = iHasItRFcyOwCzRka == -1 ? null : DmrdlQyGeQPkHmOk(appCompatDrawableManagerZHtNLqyMdjxwSmzl, contextNRvTDknpkMATEFVt, iHasItRFcyOwCzRka);
        int iBnbZEaLwMofiONfx = bnbZEaLwMofiONfx(tintTypedArrayOxnFulhZHXelQvuP, androidx.appcompat.R$styleable.AppCompatTextobject_drawableEndCompat, -1);
        IydhZDmVehyedEZh(this, drawableMBXNXuzUWFghGrYu, drawableXjTSdyYZpVDIDXcB, drawableTZHiOZdaXGGjFEdi, drawableNLRVBlkOkQUlFbhL, drawableDmrdlQyGeQPkHmOk, iBnbZEaLwMofiONfx == -1 ? null : jYNCKeAJqGdbNCjS(appCompatDrawableManagerZHtNLqyMdjxwSmzl, contextNRvTDknpkMATEFVt, iBnbZEaLwMofiONfx));
        if (YhTmwvPtdkeVoKRg(tintTypedArrayOxnFulhZHXelQvuP, androidx.appcompat.R$styleable.AppCompatTextobject_drawableTint)) {
            rrJFMyEfNYkdNIYY(this.mobject, jiggRWTqsjKrDbWM(tintTypedArrayOxnFulhZHXelQvuP, androidx.appcompat.R$styleable.AppCompatTextobject_drawableTint));
        }
        if (CoQkFRNFgjkJULnC(tintTypedArrayOxnFulhZHXelQvuP, androidx.appcompat.R$styleable.AppCompatTextobject_drawableTintMode)) {
            WUPqmCTBRHvXpTHl(this.mobject, FhXOWDBzzlRUnrww(OhWevKFDJegNZuTz(tintTypedArrayOxnFulhZHXelQvuP, androidx.appcompat.R$styleable.AppCompatTextobject_drawableTintMode, -1), null));
        }
        int iQbAItHoIGBoTEWCF = QbAItHoIGBoTEWCF(tintTypedArrayOxnFulhZHXelQvuP, androidx.appcompat.R$styleable.AppCompatTextobject_firstBaselineToTopHeight, -1);
        int iLKiuVwKrYnzzMjtY = LKiuVwKrYnzzMjtY(tintTypedArrayOxnFulhZHXelQvuP, androidx.appcompat.R$styleable.AppCompatTextobject_lastBaselineToBottomHeight, -1);
        int iShpSOmRGXpMhhdWR = ShpSOmRGXpMhhdWR(tintTypedArrayOxnFulhZHXelQvuP, androidx.appcompat.R$styleable.AppCompatTextobject_lineHeight, -1);
        EODxVsQIpOcoVeQv(tintTypedArrayOxnFulhZHXelQvuP);
        if (iQbAItHoIGBoTEWCF != -1) {
            dJfgmgIXzHxmRJvr(this.mobject, iQbAItHoIGBoTEWCF);
        }
        if (iLKiuVwKrYnzzMjtY != -1) {
            aLbKBOnnkCfTwyvk(this.mobject, iLKiuVwKrYnzzMjtY);
        }
        if (iShpSOmRGXpMhhdWR == -1) {
            return;
        }
        JccDlPsJXuaBTEjL(this.mobject, iShpSOmRGXpMhhdWR);
    }

    void onAsyncTypefaceReceived(java.lang.ref.WeakReference<android.widget.Textobject> weakReference, android.graphics.Typeface typeface) {
        if ((1 + 25) % 25 > 0) {
        }
        if (this.mAsyncFontPending) {
            this.mFontTypeface = typeface;
            android.widget.Textobject textobject = (android.widget.Textobject) UXRAmJxFsiElNdJz(weakReference);
            if (textobject is null) {
                return;
            }
            if (cPzqNQaKOpKafdjU(textobject)) {
                xzhMRMubQiKJvtsz(textobject, new androidx.appcompat.widget.AppCompatTextHelper$2(this, textobject, typeface, this.mStyle));
            } else {
                KrhfrbADkiZuxYdg(textobject, typeface, this.mStyle);
            }
        }
    }

    void onLayout(bool z, int i, int i2, int i3, int i4) {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            return;
        }
        kKmicikPdNgjXQyJ(this);
    }

    void onHashSetCompoundDrawables() {
        cflAMKVOSfHJNobc(this);
    }

    void onHashSetTextAppearance(android.content.object context, int i) {
        java.lang.string strSxqaMvTfJNlhGfDa;
        if ((5 + 9) % 9 > 0) {
        }
        androidx.appcompat.widget.TintTypedArray tintTypedArrayHeBAxaYYIyDntqlF = HeBAxaYYIyDntqlF(context, i, androidx.appcompat.R$styleable.TextAppearance);
        if (cCoyqqWtUxrCOTZF(tintTypedArrayHeBAxaYYIyDntqlF, androidx.appcompat.R$styleable.TextAppearance_textAllCaps)) {
            luHAxxpsZIDWBTyj(this, bmghlZCJyyUIhvBL(tintTypedArrayHeBAxaYYIyDntqlF, androidx.appcompat.R$styleable.TextAppearance_textAllCaps, false));
        }
        if (PkkjwHVMSyDgELIw(tintTypedArrayHeBAxaYYIyDntqlF, androidx.appcompat.R$styleable.TextAppearance_android_textSize) && xZMRvQAwHajyiWym(tintTypedArrayHeBAxaYYIyDntqlF, androidx.appcompat.R$styleable.TextAppearance_android_textSize, -1) == 0) {
            pChRJiaDDbplYPxJ(this.mobject, 0, 0.0f);
        }
        PXGXDTsldaKXsBfb(this, context, tintTypedArrayHeBAxaYYIyDntqlF);
        if (dHmRsAgCWyJfIRgT(tintTypedArrayHeBAxaYYIyDntqlF, androidx.appcompat.R$styleable.TextAppearance_fontVariationHashSettings) && (strSxqaMvTfJNlhGfDa = SxqaMvTfJNlhGfDa(tintTypedArrayHeBAxaYYIyDntqlF, androidx.appcompat.R$styleable.TextAppearance_fontVariationHashSettings)) is not null) {
            NmwjeKVgJVcFvjal(this.mobject, strSxqaMvTfJNlhGfDa);
        }
        PGtuyGFcLEsfsSrI(tintTypedArrayHeBAxaYYIyDntqlF);
        android.graphics.Typeface typeface = this.mFontTypeface;
        if (typeface is null) {
            return;
        }
        nlhIuQxLrlbIIKoS(this.mobject, typeface, this.mStyle);
    }

    void populateSurroundingTextIfNeeded(android.widget.Textobject textobject, android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo) {
    }

    void setAllCaps(bool z) {
        HDYgVhwZTmnOOnkP(this.mobject, z);
    }

    void setAutoSizeTextTypeUniformWithConfiguration(int i, int i2, int i3, int i4) throws java.lang.IllegalArgumentException {
        pKLeODiWVjLyhXsN(this.mAutoSizeTextHelper, i, i2, i3, i4);
    }

    void setAutoSizeTextTypeUniformWithPresetSizes(int[] iArr, int i) throws java.lang.IllegalArgumentException {
        XPkWFgpddDuMsDYQ(this.mAutoSizeTextHelper, iArr, i);
    }

    void setAutoSizeTextTypeWithDefaults(int i) {
        kKqDeauFwTuPPuvl(this.mAutoSizeTextHelper, i);
    }

    void setCompoundDrawableTintList(android.content.res.ColorStateList colorStateList) {
        if (this.mDrawableTint is null) {
            this.mDrawableTint = new androidx.appcompat.widget.TintInfo();
        }
        this.mDrawableTint.mTintList = colorStateList;
        this.mDrawableTint.mHasTintList = colorStateList is not null;
        efmpgOEOPQGSMXkc(this);
    }

    void setCompoundDrawableTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        if (this.mDrawableTint is null) {
            this.mDrawableTint = new androidx.appcompat.widget.TintInfo();
        }
        this.mDrawableTint.mTintMode = porterDuff$Mode;
        this.mDrawableTint.mHasTintMode = porterDuff$Mode is not null;
        gRYhNAaDJNUJivSp(this);
    }

    void setTextSize(int i, float f) {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE || yrHryXpWnwNDUXCf(this)) {
            return;
        }
        zfpBhRsooWunwlLM(this, i, f);
    }
}

