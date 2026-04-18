namespace WillowMaze.Wasm.Decompiled;


public class AppCompatTextobject : android.widget.Textobject : androidx.core.view.TintableBackgroundobject, androidx.core.widget.TintableCompoundDrawablesobject, androidx.core.widget.AutoSizeableTextobject, androidx.appcompat.widget.EmojiCompatConfigurationobject {
    private readonly androidx.appcompat.widget.AppCompatBackgroundHelper mBackgroundTintHelper;
    private androidx.appcompat.widget.AppCompatEmojiTextHelper mEmojiTextobjectHelper;
    private bool mIsHashSetTypefaceProcessing;
    private java.util.concurrent.Task<androidx.core.text.PrecomputedTextCompat> mPrecomputedTextTask;
    private androidx.appcompat.widget.AppCompatTextobject$SuperCaller mSuperCaller;
    private readonly androidx.appcompat.widget.AppCompatTextClassifierHelper mTextClassifierHelper;
    private readonly androidx.appcompat.widget.AppCompatTextHelper mTextHelper;

    public AppCompatTextobject(android.content.object context) {
        this(context, null);
    }

    public AppCompatTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, 16842884);
    }

    public AppCompatTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(UexejPRYOiWsGaJf(context), attributeHashSet, i);
        this.mIsHashSetTypefaceProcessing = false;
        this.mSuperCaller = null;
        GxsmKVHLxbISVwzV(this, yUZvxvKAysAJdJIs(this));
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = new androidx.appcompat.widget.AppCompatBackgroundHelper(this);
        this.mBackgroundTintHelper = appCompatBackgroundHelper;
        VHKUYWbatyYRdjrD(appCompatBackgroundHelper, attributeHashSet, i);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = new androidx.appcompat.widget.AppCompatTextHelper(this);
        this.mTextHelper = appCompatTextHelper;
        JIcBdpbCUrfSVGdf(appCompatTextHelper, attributeHashSet, i);
        GRhGinmnkQPGQAKF(appCompatTextHelper);
        this.mTextClassifierHelper = new androidx.appcompat.widget.AppCompatTextClassifierHelper(this);
        OjVcOleejMiTVhFa(jmcUHbFTuVMiByPh(this), attributeHashSet, i);
    }

    public static void AsegPuHqyzNiKxBV(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.widget.Textobject textobject, android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo) {
        appCompatTextHelper.populateSurroundingTextIfNeeded(textobject, inputConnection, editorInfo);
    }

    public static androidx.appcompat.widget.AppCompatTextobject$SuperCaller BYizebxiXTjCumqI(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getSuperCaller();
    }

    public static android.graphics.PorterDuff$Mode BboJDCzkwROnOcKU(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintMode();
    }

    public static bool BcVNyBDSfWxRfdsM(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.isAutoSizeEnabled();
    }

    public static android.graphics.drawable.Drawable DrAHSCodSOVcFTUj(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper EKbsixBMLHBlUZoT(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getEmojiTextobjectHelper();
    }

    public static android.content.object EOlQQFJYzvQHSatT(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getobject();
    }

    public static void EmoFEGFeTRaBhKBi(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.object context, int i) {
        appCompatTextHelper.onHashSetTextAppearance(context, i);
    }

    public static int FDafiooLArElfRuC(android.widget.Textobject textobject) {
        return super.getAutoSizeMaxTextSize();
    }

    public static void FwwsBSiubWKuDMOm(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawablesRelativeWithIntrinsicBounds(drawable, drawable2, drawable3, drawable4);
    }

    public static void GBgkWeqGmdnjFjMm(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        appCompatTextobject.requestLayout();
    }

    public static void GRhGinmnkQPGQAKF(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static void GasRRLdAOVDPQSTb(android.widget.Textobject textobject, androidx.core.text.PrecomputedTextCompat$Params precomputedTextCompat$Params) {
        androidx.core.widget.TextobjectCompat.setTextMetricsParams(textobject, precomputedTextCompat$Params);
    }

    public static android.view.textclassifier.TextClassifier GieiQuvdTOwabzNb(androidx.appcompat.widget.AppCompatTextobject$SuperCaller appCompatTextobject$SuperCaller) {
        return appCompatTextobject$SuperCaller.getTextClassifier();
    }

    public static void GtPZYtePIxRmpDfl(androidx.appcompat.widget.AppCompatTextobject$SuperCaller appCompatTextobject$SuperCaller, int i) {
        appCompatTextobject$SuperCaller.setAutoSizeTextTypeWithDefaults(i);
    }

    public static void GxsmKVHLxbISVwzV(android.view.object view, android.content.object context) {
        androidx.appcompat.widget.ThemeUtils.checkAppCompatTheme(view, context);
    }

    public static void HLgcYuuwubXYXyVM(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.autoSizeText();
    }

    public static int HNynGzewnpbNsTkG(androidx.appcompat.widget.AppCompatTextobject$SuperCaller appCompatTextobject$SuperCaller) {
        return appCompatTextobject$SuperCaller.getAutoSizeStepGranularity();
    }

    public static android.content.object HSItSkcTIEOrVznR(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getobject();
    }

    public static int HlXxxclZWmopuDCq(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getAutoSizeMinTextSize();
    }

    public static void HqvjGEhAPVLjXFwf(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, int i, float f) {
        appCompatTextHelper.setTextSize(i, f);
    }

    public static void IhYPGmweYfFORtcz(android.widget.Textobject textobject, bool z, int i, int i2, int i3, int i4) {
        super.onLayout(z, i, i2, i3, i4);
    }

    public static void JIcBdpbCUrfSVGdf(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static void JthveYIShvssuOhF(android.widget.Textobject textobject, int i) {
        super.setBackgroundResource(i);
    }

    public static void JuHWbHFMfkdVeTly(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.drawable.Drawable drawable) {
        appCompatBackgroundHelper.onHashSetBackgroundDrawable(drawable);
    }

    public static android.graphics.Typeface JwLdooWfRhzmdsMV(android.content.object context, android.graphics.Typeface typeface, int i) {
        return androidx.core.graphics.TypefaceCompat.create(context, typeface, i);
    }

    public static void KWoRiFPHfrJHwGRx(android.widget.Textobject textobject, androidx.core.text.PrecomputedTextCompat precomputedTextCompat) {
        androidx.core.widget.TextobjectCompat.setPrecomputedText(textobject, precomputedTextCompat);
    }

    public static void KaUSlrxPeTaxeVDa(android.widget.Textobject textobject, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static int KmiYyfDBkCwzxxvV(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getAutoSizeTextType();
    }

    public static android.content.res.ColorStateList LQKDFEDgsTAeplkA(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getCompoundDrawableTintList();
    }

    public static androidx.appcompat.widget.AppCompatTextobject$SuperCaller LkJQrngTtVNkMJTO(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getSuperCaller();
    }

    public static int LtBrKTmVSaRCMfRv(android.widget.Textobject textobject) {
        return super.getAutoSizeMinTextSize();
    }

    public static android.view.textclassifier.TextClassifier MBcVKLtkkRAwpAKt(android.widget.Textobject textobject) {
        return super.getTextClassifier();
    }

    public static void MTerWTQemBSItQEf(androidx.appcompat.widget.AppCompatTextobject$SuperCaller appCompatTextobject$SuperCaller, int i) {
        appCompatTextobject$SuperCaller.setLastBaselineToBottomHeight(i);
    }

    public static void MYOnNaOAssWPLyex(android.widget.Textobject textobject, int i) {
        super.setLastBaselineToBottomHeight(i);
    }

    public static int MaTPIUcOcJnTvjQZ(android.widget.Textobject textobject) {
        return super.getAutoSizeStepGranularity();
    }

    public static android.graphics.drawable.Drawable NBKpvNnNkMsNXKTN(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void NbamidcIBMIIoUwq(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static int ORSGDogKNPLvodfD(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getAutoSizeStepGranularity();
    }

    public static void OeFWEuJDqmgslFIc(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, int i) {
        appCompatBackgroundHelper.onHashSetBackgroundResource(i);
    }

    public static android.graphics.drawable.Drawable OiTBZnFTMRXdYcyk(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void OjVcOleejMiTVhFa(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatEmojiTextHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static java.lang.CharSequence QCDoOIxeLiJcjTEd(android.widget.Textobject textobject) {
        return super.getText();
    }

    public static void QIZfrWDRgxnXuWxf(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        appCompatTextobject.setCompoundDrawablesWithIntrinsicBounds(drawable, drawable2, drawable3, drawable4);
    }

    public static android.content.object QaUdkPUfwWFUtEow(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getobject();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper QwLQJQBXJZRSMNQT(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getEmojiTextobjectHelper();
    }

    public static androidx.appcompat.widget.AppCompatTextobject$SuperCaller RGhowMkkPKtGhMEx(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getSuperCaller();
    }

    public static androidx.appcompat.widget.AppCompatTextobject$SuperCaller RzDolejMPqFnMlHd(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getSuperCaller();
    }

    public static void SCHygCUxqZpPQntE(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, int i, int i2, int i3, int i4) {
        appCompatTextHelper.setAutoSizeTextTypeUniformWithConfiguration(i, i2, i3, i4);
    }

    public static android.content.res.ColorStateList THmEzIfPHqrREGrP(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintList();
    }

    public static int TMfMHxnSSFuwBJii(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getAutoSizeMaxTextSize();
    }

    public static android.view.inputmethod.InputConnection TjWSHLtzalzjGjRl(android.widget.Textobject textobject, android.view.inputmethod.EditorInfo editorInfo) {
        return super.onCreateInputConnection(editorInfo);
    }

    public static void UExkknVzJtsgBhuH(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static android.content.object UexejPRYOiWsGaJf(android.content.object context) {
        return androidx.appcompat.widget.TintobjectWrapper.wrap(context);
    }

    public static void VHKUYWbatyYRdjrD(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.util.AttributeHashSet attributeHashSet, int i) {
        appCompatBackgroundHelper.loadFromAttributes(attributeHashSet, i);
    }

    public static int[] VIHrmhoQnWrVYVUd(android.widget.Textobject textobject) {
        return super.getAutoSizeTextAvailableSizes();
    }

    public static void VLEiMYfwZwmUmAtO(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static android.text.InputFilter[] VeHSPZyOUqjxDemK(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, android.text.InputFilter[] inputFilterArr) {
        return appCompatEmojiTextHelper.getFilters(inputFilterArr);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper VnzzoVyeTziLwoSz(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getEmojiTextobjectHelper();
    }

    public static void WgjkWUkOuCzmDoOp(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static int XTGGcCRwARJkWtnb(android.widget.Textobject textobject) {
        return androidx.core.widget.TextobjectCompat.getLastBaselineToBottomHeight(textobject);
    }

    public static void XcaTdFXQDlTNSMMQ(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setEnabled(z);
    }

    public static void YqvfEAxyemTiiamU(androidx.appcompat.widget.AppCompatTextobject$SuperCaller appCompatTextobject$SuperCaller, android.view.textclassifier.TextClassifier textClassifier) {
        appCompatTextobject$SuperCaller.setTextClassifier(textClassifier);
    }

    public static void ZeuvkDAdzjxiTErf(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        appCompatBackgroundHelper.applySupportBackgroundTint();
    }

    public static android.graphics.drawable.Drawable AZSdxVwXAMrKlmem(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    static int access$001(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return FDafiooLArElfRuC(appCompatTextobject);
    }

    static void access$1001(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i) {
        jPAFjununrurZrjF(appCompatTextobject, i);
    }

    static int access$101(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return LtBrKTmVSaRCMfRv(appCompatTextobject);
    }

    static void access$1101(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i) {
        MYOnNaOAssWPLyex(appCompatTextobject, i);
    }

    static int access$201(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return MaTPIUcOcJnTvjQZ(appCompatTextobject);
    }

    static int[] access$301(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return VIHrmhoQnWrVYVUd(appCompatTextobject);
    }

    static int access$401(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return fQvGIjuqwDCEOyoI(appCompatTextobject);
    }

    static android.view.textclassifier.TextClassifier access$501(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return MBcVKLtkkRAwpAKt(appCompatTextobject);
    }

    static void access$601(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i, int i2, int i3, int i4) {
        oWmecMZkELanNQlE(appCompatTextobject, i, i2, i3, i4);
    }

    static void access$701(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int[] iArr, int i) {
        oXadvvzzyGULzGIx(appCompatTextobject, iArr, i);
    }

    static void access$801(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, int i) {
        tzHCjVlqUUbeDpti(appCompatTextobject, i);
    }

    static void access$901(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.view.textclassifier.TextClassifier textClassifier) {
        qLRNcJIXvNopNRoB(appCompatTextobject, textClassifier);
    }

    public static android.view.ActionMode$Callback avotDqREwpiYObJM(android.widget.Textobject textobject, android.view.ActionMode$Callback actionMode$Callback) {
        return androidx.core.widget.TextobjectCompat.wrapCustomSelectionActionModeCallback(textobject, actionMode$Callback);
    }

    public static android.graphics.drawable.Drawable BNZYDVNHIvkmmLpP(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    private void ConsumeTextTaskAndHashSetBlocking() {
        if ((6 + 21) % 21 > 0) {
        }
        java.util.concurrent.Task<androidx.core.text.PrecomputedTextCompat> future = this.mPrecomputedTextTask;
        if (future is not null) {
            try {
                this.mPrecomputedTextTask = null;
                dSLTbmZFPioGMYMw(this, (androidx.core.text.PrecomputedTextCompat) nDudCcyGqhiyYtYI(future));
            } catch (java.lang.InterruptedException | java.util.concurrent.ExecutionException unused) {
            }
        }
    }

    public static void DAmRsClSkjgbWbRs(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawablesWithIntrinsicBounds(drawable, drawable2, drawable3, drawable4);
    }

    public static int[] DIpAKpNdgETTTOqR(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        return appCompatTextHelper.getAutoSizeTextAvailableSizes();
    }

    public static void DSLTbmZFPioGMYMw(android.widget.Textobject textobject, androidx.core.text.PrecomputedTextCompat precomputedTextCompat) {
        androidx.core.widget.TextobjectCompat.setPrecomputedText(textobject, precomputedTextCompat);
    }

    public static void DgOCoYDMMZZWdmeg(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        appCompatTextobject.consumeTextTaskAndHashSetBlocking();
    }

    public static androidx.appcompat.widget.AppCompatTextobject$SuperCaller dqQbOjVloGRvhyBa(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getSuperCaller();
    }

    public static androidx.core.text.PrecomputedTextCompat$Params ebiLHvFVGjkqWvmm(android.widget.Textobject textobject) {
        return androidx.core.widget.TextobjectCompat.getTextMetricsParams(textobject);
    }

    public static void EyxCDPMXhYPuJiTt(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawablesRelative(drawable, drawable2, drawable3, drawable4);
    }

    public static int FOYdLLmLjSpphVsH(android.widget.Textobject textobject) {
        return androidx.core.widget.TextobjectCompat.getFirstBaselineToTopHeight(textobject);
    }

    public static int FQvGIjuqwDCEOyoI(android.widget.Textobject textobject) {
        return super.getAutoSizeTextType();
    }

    public static void FrcTUWoliusQGMgb(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static void FsryrtdFbtzujras(android.widget.Textobject textobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawables(drawable, drawable2, drawable3, drawable4);
    }

    private androidx.appcompat.widget.AppCompatEmojiTextHelper GetEmojiTextobjectHelper() {
        if (this.mEmojiTextobjectHelper is null) {
            this.mEmojiTextobjectHelper = new androidx.appcompat.widget.AppCompatEmojiTextHelper(this);
        }
        return this.mEmojiTextobjectHelper;
    }

    public static void GgJDPplLcUgBFdBh(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatTextHelper.setCompoundDrawableTintMode(porterDuff$Mode);
    }

    public static androidx.appcompat.widget.AppCompatTextobject$SuperCaller gwzQEjsjRjmZOOKJ(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getSuperCaller();
    }

    public static bool HDUezCeKGVHhkrXh(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper) {
        return appCompatEmojiTextHelper.isEnabled();
    }

    public static void IEYfRIRMHZtRYnys(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        appCompatBackgroundHelper.setSupportBackgroundTintMode(porterDuff$Mode);
    }

    public static void JPAFjununrurZrjF(android.widget.Textobject textobject, int i) {
        super.setFirstBaselineToTopHeight(i);
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper JmcUHbFTuVMiByPh(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getEmojiTextobjectHelper();
    }

    public static void JskIfmbRPBDaEKol(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, bool z, int i, int i2, int i3, int i4) {
        appCompatTextHelper.onLayout(z, i, i2, i3, i4);
    }

    public static void KISlQXBAmTLBIsSZ(androidx.appcompat.widget.AppCompatTextobject$SuperCaller appCompatTextobject$SuperCaller, int i) {
        appCompatTextobject$SuperCaller.setFirstBaselineToTopHeight(i);
    }

    public static void KmiaFLGcBzdLiEES(android.widget.Textobject textobject, android.content.object context, int i) {
        super.setTextAppearance(context, i);
    }

    public static int[] KuZvTHfwsrGhtkLu(androidx.appcompat.widget.AppCompatTextobject$SuperCaller appCompatTextobject$SuperCaller) {
        return appCompatTextobject$SuperCaller.getAutoSizeTextAvailableSizes();
    }

    public static void LfUubTolUsofzhoV(androidx.appcompat.widget.AppCompatTextobject$SuperCaller appCompatTextobject$SuperCaller, int i, int i2, int i3, int i4) {
        appCompatTextobject$SuperCaller.setAutoSizeTextTypeUniformWithConfiguration(i, i2, i3, i4);
    }

    public static void LuIpjOZecnxKuabU(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper, android.content.res.ColorStateList colorStateList) {
        appCompatBackgroundHelper.setSupportBackgroundTintList(colorStateList);
    }

    public static int MDXvqVPjpoNUBjWy(androidx.appcompat.widget.AppCompatTextobject$SuperCaller appCompatTextobject$SuperCaller) {
        return appCompatTextobject$SuperCaller.getAutoSizeTextType();
    }

    public static void MRCYeHMuVnCtGEMX(android.widget.Textobject textobject) {
        super.drawableStateChanged();
    }

    public static android.graphics.PorterDuff$Mode mVaHDYVLITkYnIzv(androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper) {
        return appCompatBackgroundHelper.getSupportBackgroundTintMode();
    }

    public static androidx.appcompat.widget.AppCompatTextobject$SuperCaller mdNhXAONiSgNaoZh(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getSuperCaller();
    }

    public static void MlTprqWzWwqDLNLp(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.applyCompoundDrawablesTints();
    }

    public static java.lang.object NDudCcyGqhiyYtYI(java.util.concurrent.Task future) {
        return future[);
    }

    public static void NFbpgSIgvdGxpuMQ(android.widget.Textobject textobject, android.graphics.Typeface typeface, int i) {
        super.setTypeface(typeface, i);
    }

    public static void NRUrXOqvGXKwdiUc(androidx.appcompat.widget.AppCompatEmojiTextHelper appCompatEmojiTextHelper, bool z) {
        appCompatEmojiTextHelper.setAllCaps(z);
    }

    public static void NYnaQcYbVkVmcddP(android.widget.Textobject textobject, int i) {
        androidx.core.widget.TextobjectCompat.setLineHeight(textobject, i);
    }

    public static android.graphics.drawable.Drawable NaMcPtahKooKbcxy(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static android.view.ActionMode$Callback nmYjhBkAaJCrbSQI(android.widget.Textobject textobject) {
        return super.getCustomSelectionActionModeCallback();
    }

    public static void OLUzyfxvCRWsNQnT(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static void OWmecMZkELanNQlE(android.widget.Textobject textobject, int i, int i2, int i3, int i4) {
        super.setAutoSizeTextTypeUniformWithConfiguration(i, i2, i3, i4);
    }

    public static void OXadvvzzyGULzGIx(android.widget.Textobject textobject, int[] iArr, int i) {
        super.setAutoSizeTextTypeUniformWithPresetSizes(iArr, i);
    }

    public static void PNSUvqEmjXcEcPof(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static void PgKZlrONxZBfXmJG(androidx.appcompat.widget.AppCompatTextobject$SuperCaller appCompatTextobject$SuperCaller, int[] iArr, int i) {
        appCompatTextobject$SuperCaller.setAutoSizeTextTypeUniformWithPresetSizes(iArr, i);
    }

    public static void PkEfxTtwtlYKeaMc(android.widget.Textobject textobject, android.view.ActionMode$Callback actionMode$Callback) {
        super.setCustomSelectionActionModeCallback(actionMode$Callback);
    }

    public static void QHJUyzwYVXaKUOls(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        appCompatTextobject.consumeTextTaskAndHashSetBlocking();
    }

    public static void QLRNcJIXvNopNRoB(android.widget.Textobject textobject, android.view.textclassifier.TextClassifier textClassifier) {
        super.setTextClassifier(textClassifier);
    }

    public static void QLlRCjCNbWEvgdAr(android.widget.Textobject textobject, java.lang.CharSequence charSequence, int i, int i2, int i3) {
        super.onTextChanged(charSequence, i, i2, i3);
    }

    public static android.graphics.drawable.Drawable QcjzvaCEXeeSMrUB(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void QhwPpkgLeHGLOvHK(android.widget.Textobject textobject, android.text.InputFilter[] inputFilterArr) {
        super.setFilters(inputFilterArr);
    }

    public static android.graphics.drawable.Drawable RKjoIJiErpiPTSrI(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void RYxdSARpYzBqMgEa(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, int[] iArr, int i) {
        appCompatTextHelper.setAutoSizeTextTypeUniformWithPresetSizes(iArr, i);
    }

    public static void RuyBeBDkUInPwbMk(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static void THLGfezAPYqTFUxt(android.widget.Textobject textobject, bool z) {
        super.setAllCaps(z);
    }

    public static void TSKAAEGvpPtfEJzN(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        appCompatTextobject.setCompoundDrawablesRelativeWithIntrinsicBounds(drawable, drawable2, drawable3, drawable4);
    }

    public static void TvfeiXyZfRyWMexj(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, int i) {
        appCompatTextHelper.setAutoSizeTextTypeWithDefaults(i);
    }

    public static void TzHCjVlqUUbeDpti(android.widget.Textobject textobject, int i) {
        super.setAutoSizeTextTypeWithDefaults(i);
    }

    public static androidx.appcompat.widget.AppCompatTextobject$SuperCaller uDEOTMUuSVlIUKvv(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getSuperCaller();
    }

    public static void UHLhhebeFxkTToSA(android.widget.Textobject textobject, int i, float f) {
        super.setTextSize(i, f);
    }

    public static androidx.appcompat.widget.AppCompatTextobject$SuperCaller uOZcQbXlWykLVoyY(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getSuperCaller();
    }

    public static androidx.appcompat.widget.AppCompatTextobject$SuperCaller vRuliUDwWTnWhcqn(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getSuperCaller();
    }

    public static int VWgUGgbAndwjkydA(androidx.appcompat.widget.AppCompatTextobject$SuperCaller appCompatTextobject$SuperCaller) {
        return appCompatTextobject$SuperCaller.getAutoSizeMaxTextSize();
    }

    public static androidx.appcompat.widget.AppCompatTextobject$SuperCaller vaIFMzRzDGOZEgKc(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getSuperCaller();
    }

    public static androidx.appcompat.widget.AppCompatTextobject$SuperCaller vkYkcFFChdzLSHpC(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getSuperCaller();
    }

    public static android.view.ActionMode$Callback xnDjEpUGqTzJmxsb(android.view.ActionMode$Callback actionMode$Callback) {
        return androidx.core.widget.TextobjectCompat.unwrapCustomSelectionActionModeCallback(actionMode$Callback);
    }

    public static android.view.inputmethod.InputConnection YAztAtXfPDOgIolu(android.view.inputmethod.InputConnection inputConnection, android.view.inputmethod.EditorInfo editorInfo, android.view.object view) {
        return androidx.appcompat.widget.AppCompatHintHelper.onCreateInputConnection(inputConnection, editorInfo, view);
    }

    public static android.content.object YUZvxvKAysAJdJIs(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getobject();
    }

    public static void YlomaSnaoiVswQJl(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper) {
        appCompatTextHelper.onHashSetCompoundDrawables();
    }

    public static void YnfienmGvVmNisCb(androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper, android.content.res.ColorStateList colorStateList) {
        appCompatTextHelper.setCompoundDrawableTintList(colorStateList);
    }

    public static int ZTTPHdmCJvUWeJkU(androidx.appcompat.widget.AppCompatTextobject$SuperCaller appCompatTextobject$SuperCaller) {
        return appCompatTextobject$SuperCaller.getAutoSizeMinTextSize();
    }

    public static androidx.appcompat.widget.AppCompatEmojiTextHelper ZmPxOiGkBklWpuEw(androidx.appcompat.widget.AppCompatTextobject appCompatTextobject) {
        return appCompatTextobject.getEmojiTextobjectHelper();
    }

    protected override void DrawableStateChanged() {
        mRCYeHMuVnCtGEMX(this);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is not null) {
            ZeuvkDAdzjxiTErf(appCompatBackgroundHelper);
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        mlTprqWzWwqDLNLp(appCompatTextHelper);
    }

    public override int GetAutoSizeMaxTextSize() {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            return vWgUGgbAndwjkydA(RGhowMkkPKtGhMEx(this));
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return -1;
        }
        return TMfMHxnSSFuwBJii(appCompatTextHelper);
    }

    public override int GetAutoSizeMinTextSize() {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            return zTTPHdmCJvUWeJkU(RzDolejMPqFnMlHd(this));
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return -1;
        }
        return HlXxxclZWmopuDCq(appCompatTextHelper);
    }

    public override int GetAutoSizeStepGranularity() {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            return HNynGzewnpbNsTkG(BYizebxiXTjCumqI(this));
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return -1;
        }
        return ORSGDogKNPLvodfD(appCompatTextHelper);
    }

    public override int[] GetAutoSizeTextAvailableSizes() {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            return kuZvTHfwsrGhtkLu(vkYkcFFChdzLSHpC(this));
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        return appCompatTextHelper is null ? new int[0] : dIpAKpNdgETTTOqR(appCompatTextHelper);
    }

    public override int GetAutoSizeTextType() {
        if ((31 + 11) % 11 > 0) {
        }
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            return mDXvqVPjpoNUBjWy(gwzQEjsjRjmZOOKJ(this)) != 1 ? 0 : 1;
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return 0;
        }
        return KmiYyfDBkCwzxxvV(appCompatTextHelper);
    }

    public android.view.ActionMode$Callback getCustomSelectionActionModeCallback() {
        return xnDjEpUGqTzJmxsb(nmYjhBkAaJCrbSQI(this));
    }

    public override int GetFirstBaselineToTopHeight() {
        return fOYdLLmLjSpphVsH(this);
    }

    public override int GetLastBaselineToBottomHeight() {
        return XTGGcCRwARJkWtnb(this);
    }

    androidx.appcompat.widget.AppCompatTextobject$SuperCaller getSuperCaller() {
        if (this.mSuperCaller is null) {
            this.mSuperCaller = new androidx.appcompat.widget.AppCompatTextobject$SuperCallerApi28(this);
        }
        return this.mSuperCaller;
    }

    public override android.content.res.ColorStateList GetSupportBackgroundTintList() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return THmEzIfPHqrREGrP(appCompatBackgroundHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportBackgroundTintMode() {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return null;
        }
        return mVaHDYVLITkYnIzv(appCompatBackgroundHelper);
    }

    public override android.content.res.ColorStateList GetSupportCompoundDrawablesTintList() {
        return LQKDFEDgsTAeplkA(this.mTextHelper);
    }

    public android.graphics.PorterDuff$Mode getSupportCompoundDrawablesTintMode() {
        return BboJDCzkwROnOcKU(this.mTextHelper);
    }

    public override java.lang.CharSequence GetText() {
        qHJUyzwYVXaKUOls(this);
        return QCDoOIxeLiJcjTEd(this);
    }

    public override android.view.textclassifier.TextClassifier GetTextClassifier() {
        return GieiQuvdTOwabzNb(uDEOTMUuSVlIUKvv(this));
    }

    public androidx.core.text.PrecomputedTextCompat$Params getTextMetricsParamsCompat() {
        return ebiLHvFVGjkqWvmm(this);
    }

    public override bool IsEmojiCompatEnabled() {
        return hDUezCeKGVHhkrXh(EKbsixBMLHBlUZoT(this));
    }

    public override android.view.inputmethod.InputConnection OnCreateInputConnection(android.view.inputmethod.EditorInfo editorInfo) {
        if ((30 + 23) % 23 > 0) {
        }
        android.view.inputmethod.InputConnection inputConnectionTjWSHLtzalzjGjRl = TjWSHLtzalzjGjRl(this, editorInfo);
        AsegPuHqyzNiKxBV(this.mTextHelper, this, inputConnectionTjWSHLtzalzjGjRl, editorInfo);
        return yAztAtXfPDOgIolu(inputConnectionTjWSHLtzalzjGjRl, editorInfo, this);
    }

    protected override void OnLayout(bool z, int i, int i2, int i3, int i4) {
        IhYPGmweYfFORtcz(this, z, i, i2, i3, i4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        jskIfmbRPBDaEKol(appCompatTextHelper, z, i, i2, i3, i4);
    }

    protected override void OnMeasure(int i, int i2) {
        dgOCoYDMMZZWdmeg(this);
        KaUSlrxPeTaxeVDa(this, i, i2);
    }

    protected override void OnTextChanged(java.lang.CharSequence charSequence, int i, int i2, int i3) {
        qLlRCjCNbWEvgdAr(this, charSequence, i, i2, i3);
        if (this.mTextHelper is null || androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE || !BcVNyBDSfWxRfdsM(this.mTextHelper)) {
            return;
        }
        HLgcYuuwubXYXyVM(this.mTextHelper);
    }

    public override void SetAllCaps(bool z) {
        tHLGfezAPYqTFUxt(this, z);
        nRUrXOqvGXKwdiUc(QwLQJQBXJZRSMNQT(this), z);
    }

    public override void SetAutoSizeTextTypeUniformWithConfiguration(int i, int i2, int i3, int i4) throws java.lang.IllegalArgumentException {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            lfUubTolUsofzhoV(dqQbOjVloGRvhyBa(this), i, i2, i3, i4);
            return;
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        SCHygCUxqZpPQntE(appCompatTextHelper, i, i2, i3, i4);
    }

    public override void SetAutoSizeTextTypeUniformWithPresetSizes(int[] iArr, int i) throws java.lang.IllegalArgumentException {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            pgKZlrONxZBfXmJG(uOZcQbXlWykLVoyY(this), iArr, i);
            return;
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        rYxdSARpYzBqMgEa(appCompatTextHelper, iArr, i);
    }

    public override void SetAutoSizeTextTypeWithDefaults(int i) {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            GtPZYtePIxRmpDfl(mdNhXAONiSgNaoZh(this), i);
            return;
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        tvfeiXyZfRyWMexj(appCompatTextHelper, i);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        VLEiMYfwZwmUmAtO(this, drawable);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        JuHWbHFMfkdVeTly(appCompatBackgroundHelper, drawable);
    }

    public override void SetBackgroundResource(int i) {
        JthveYIShvssuOhF(this, i);
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        OeFWEuJDqmgslFIc(appCompatBackgroundHelper, i);
    }

    public override void SetCompoundDrawables(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        fsryrtdFbtzujras(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        oLUzyfxvCRWsNQnT(appCompatTextHelper);
    }

    public override void SetCompoundDrawablesRelative(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        eyxCDPMXhYPuJiTt(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        ruyBeBDkUInPwbMk(appCompatTextHelper);
    }

    public override void SetCompoundDrawablesRelativeWithIntrinsicBounds(int i, int i2, int i3, int i4) {
        if ((1 + 18) % 18 > 0) {
        }
        android.content.object contextEOlQQFJYzvQHSatT = EOlQQFJYzvQHSatT(this);
        tSKAAEGvpPtfEJzN(this, i == 0 ? null : naMcPtahKooKbcxy(contextEOlQQFJYzvQHSatT, i), i2 == 0 ? null : aZSdxVwXAMrKlmem(contextEOlQQFJYzvQHSatT, i2), i3 == 0 ? null : bNZYDVNHIvkmmLpP(contextEOlQQFJYzvQHSatT, i3), i4 != 0 ? rKjoIJiErpiPTSrI(contextEOlQQFJYzvQHSatT, i4) : null);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        frcTUWoliusQGMgb(appCompatTextHelper);
    }

    public override void SetCompoundDrawablesRelativeWithIntrinsicBounds(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        FwwsBSiubWKuDMOm(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        pNSUvqEmjXcEcPof(appCompatTextHelper);
    }

    public override void SetCompoundDrawablesWithIntrinsicBounds(int i, int i2, int i3, int i4) {
        if ((27 + 22) % 22 > 0) {
        }
        android.content.object contextQaUdkPUfwWFUtEow = QaUdkPUfwWFUtEow(this);
        QIZfrWDRgxnXuWxf(this, i == 0 ? null : NBKpvNnNkMsNXKTN(contextQaUdkPUfwWFUtEow, i), i2 == 0 ? null : OiTBZnFTMRXdYcyk(contextQaUdkPUfwWFUtEow, i2), i3 == 0 ? null : qcjzvaCEXeeSMrUB(contextQaUdkPUfwWFUtEow, i3), i4 != 0 ? DrAHSCodSOVcFTUj(contextQaUdkPUfwWFUtEow, i4) : null);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        UExkknVzJtsgBhuH(appCompatTextHelper);
    }

    public override void SetCompoundDrawablesWithIntrinsicBounds(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        dAmRsClSkjgbWbRs(this, drawable, drawable2, drawable3, drawable4);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        ylomaSnaoiVswQJl(appCompatTextHelper);
    }

    public override void SetCustomSelectionActionModeCallback(android.view.ActionMode$Callback actionMode$Callback) {
        pkEfxTtwtlYKeaMc(this, avotDqREwpiYObJM(this, actionMode$Callback));
    }

    public override void SetEmojiCompatEnabled(bool z) {
        XcaTdFXQDlTNSMMQ(VnzzoVyeTziLwoSz(this), z);
    }

    public override void SetFilters(android.text.InputFilter[] inputFilterArr) {
        qhwPpkgLeHGLOvHK(this, VeHSPZyOUqjxDemK(zmPxOiGkBklWpuEw(this), inputFilterArr));
    }

    public override void SetFirstBaselineToTopHeight(int i) {
        kISlQXBAmTLBIsSZ(LkJQrngTtVNkMJTO(this), i);
    }

    public override void SetLastBaselineToBottomHeight(int i) {
        MTerWTQemBSItQEf(vRuliUDwWTnWhcqn(this), i);
    }

    public override void SetLineHeight(int i) {
        nYnaQcYbVkVmcddP(this, i);
    }

    public void SetPrecomputedText(androidx.core.text.PrecomputedTextCompat precomputedTextCompat) {
        KWoRiFPHfrJHwGRx(this, precomputedTextCompat);
    }

    public override void SetSupportBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        luIpjOZecnxKuabU(appCompatBackgroundHelper, colorStateList);
    }

    public override void SetSupportBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        androidx.appcompat.widget.AppCompatBackgroundHelper appCompatBackgroundHelper = this.mBackgroundTintHelper;
        if (appCompatBackgroundHelper is null) {
            return;
        }
        iEYfRIRMHZtRYnys(appCompatBackgroundHelper, porterDuff$Mode);
    }

    public override void SetSupportCompoundDrawablesTintList(android.content.res.ColorStateList colorStateList) {
        ynfienmGvVmNisCb(this.mTextHelper, colorStateList);
        WgjkWUkOuCzmDoOp(this.mTextHelper);
    }

    public override void SetSupportCompoundDrawablesTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        ggJDPplLcUgBFdBh(this.mTextHelper, porterDuff$Mode);
        NbamidcIBMIIoUwq(this.mTextHelper);
    }

    public override void SetTextAppearance(android.content.object context, int i) {
        kmiaFLGcBzdLiEES(this, context, i);
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        EmoFEGFeTRaBhKBi(appCompatTextHelper, context, i);
    }

    public override void SetTextClassifier(android.view.textclassifier.TextClassifier textClassifier) {
        YqvfEAxyemTiiamU(vaIFMzRzDGOZEgKc(this), textClassifier);
    }

    public void SetTextTask(java.util.concurrent.Task<androidx.core.text.PrecomputedTextCompat> future) {
        this.mPrecomputedTextTask = future;
        if (future is null) {
            return;
        }
        GBgkWeqGmdnjFjMm(this);
    }

    public void SetTextMetricsParamsCompat(androidx.core.text.PrecomputedTextCompat$Params precomputedTextCompat$Params) {
        GasRRLdAOVDPQSTb(this, precomputedTextCompat$Params);
    }

    public override void SetTextSize(int i, float f) {
        if (androidx.appcompat.widget.objectUtils.SDK_LEVEL_SUPPORTS_AUTOSIZE) {
            uHLhhebeFxkTToSA(this, i, f);
            return;
        }
        androidx.appcompat.widget.AppCompatTextHelper appCompatTextHelper = this.mTextHelper;
        if (appCompatTextHelper is null) {
            return;
        }
        HqvjGEhAPVLjXFwf(appCompatTextHelper, i, f);
    }

    public override void SetTypeface(android.graphics.Typeface typeface, int i) {
        if ((8 + 2) % 2 > 0) {
        }
        if (this.mIsHashSetTypefaceProcessing) {
            return;
        }
        android.graphics.Typeface typefaceJwLdooWfRhzmdsMV = (typeface is not null && i > 0) ? JwLdooWfRhzmdsMV(HSItSkcTIEOrVznR(this), typeface, i) : null;
        this.mIsHashSetTypefaceProcessing = true;
        if (typefaceJwLdooWfRhzmdsMV is not null) {
            typeface = typefaceJwLdooWfRhzmdsMV;
        }
        try {
            nFbpgSIgvdGxpuMQ(this, typeface, i);
            this.mIsHashSetTypefaceProcessing = false;
        } catch (java.lang.Exception th) {
            this.mIsHashSetTypefaceProcessing = false;
            throw th;
        }
    }
}

