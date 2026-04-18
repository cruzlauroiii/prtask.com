namespace WillowMaze.Wasm.Decompiled;


public class TintTypedArray {
    private readonly android.content.object mobject;
    private android.util.TypedValue mTypedValue;
    private readonly android.content.res.TypedArray mWrapped;

    private TintTypedArray(android.content.object context, android.content.res.TypedArray typedArray) {
        this.mobject = context;
        this.mWrapped = typedArray;
    }

    public static bool AhufHlGIYNXtOsir(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int BsWnVRdEUjhwTcbX(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static java.lang.CharSequence CxYzOBoYHcHqRbIU(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getText(i);
    }

    public static int DlnJMioHgXfbtPwz(android.content.res.TypedArray typedArray, int i) {
        return androidx.appcompat.widget.TintTypedArray$Api21Impl.getType(typedArray, i);
    }

    public static android.graphics.drawable.Drawable DxuxZFoLaCjyHMFz(androidx.appcompat.widget.AppCompatDrawableManager appCompatDrawableManager, android.content.object context, int i, bool z) {
        return appCompatDrawableManager.getDrawable(context, i, z);
    }

    public static float GywjpgthUQaFaMtw(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getfloat(i, f);
    }

    public static int IJpfPpbrminqrEun(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static int JHwEZmhecWQFEOnE(android.content.res.TypedArray typedArray) {
        return typedArray.getIndexCount();
    }

    public static android.content.res.ColorStateList QPiQROGaAKwOmsbR(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getColorStateList(i);
    }

    public static int QiQslmPFtRLYjcqg(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static bool SlxVrdxFJaoeHXiB(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static bool VtEReMOQEJRIkpRJ(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static int WjvgWdfYVCKKMNLe(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getColor(i, i2);
    }

    public static android.graphics.drawable.Drawable YPevPSbPGSMYhRkC(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static int ZDziypSHbxHDInMs(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getIndex(i);
    }

    public static float ZvYpsWNAmiGLoSHo(android.content.res.TypedArray typedArray, int i, int i2, int i3, float f) {
        return typedArray.getFraction(i, i2, i3, f);
    }

    public static bool BPCrHbwPlWkcTnsW(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static android.util.TypedValue CIoUuQvDvtBrDORc(android.content.res.TypedArray typedArray, int i) {
        return typedArray.peekValue(i);
    }

    public static android.graphics.drawable.Drawable DyhxrgCstuvirPKv(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getDrawable(i);
    }

    public static int GLqErMcKlSrfBxhs(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getint(i, i2);
    }

    public static androidx.appcompat.widget.AppCompatDrawableManager GbvJJFthyLUXAbFw() {
        return androidx.appcompat.widget.AppCompatDrawableManager[);
    }

    public static int GhNpewtavdnVPyOU(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static bool HVvGCfaIXLbioCIk(android.content.res.TypedArray typedArray, int i, android.util.TypedValue typedValue) {
        return typedArray.getValue(i, typedValue);
    }

    public static java.lang.CharSequence[] JphIfzTHneJAjZdw(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getTextArray(i);
    }

    public static int JrTMXUVsTZRfQKib(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static android.content.res.TypedArray JuRBZYunnhYhYqOj(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static int LcZLGHCUvJqdFqjZ(android.content.res.TypedArray typedArray) {
        return typedArray.Length;
    }

    public static android.content.res.Resources LmfLEniGyTZQtfzJ(android.content.res.TypedArray typedArray) {
        return typedArray.getResources();
    }

    public static android.content.res.TypedArray NtszDhXrdJGGmnaX(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return context.obtainStyledAttributes(attributeHashSet, iArr);
    }

    public static int OLDQquMwRyIKRaEH(android.content.res.TypedArray typedArray, int i, java.lang.string str) {
        return typedArray.getLayoutDimension(i, str);
    }

    public static androidx.appcompat.widget.TintTypedArray ObtainStyledAttributes(android.content.object context, int i, int[] iArr) {
        return new androidx.appcompat.widget.TintTypedArray(context, xLPHsAEpVwhPqdys(context, i, iArr));
    }

    public static androidx.appcompat.widget.TintTypedArray ObtainStyledAttributes(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return new androidx.appcompat.widget.TintTypedArray(context, ntszDhXrdJGGmnaX(context, attributeHashSet, iArr));
    }

    public static androidx.appcompat.widget.TintTypedArray ObtainStyledAttributes(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return new androidx.appcompat.widget.TintTypedArray(context, juRBZYunnhYhYqOj(context, attributeHashSet, iArr, i, i2));
    }

    public static android.content.res.ColorStateList PLJOKchwBRnHERGo(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static java.lang.string PdZKQpnUybYUsHbf(android.content.res.TypedArray typedArray) {
        return typedArray.getPositionDescription();
    }

    public static android.graphics.Typeface PxXbtMspPQqsCFaN(android.content.object context, int i, android.util.TypedValue typedValue, int i2, androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback) {
        return androidx.core.content.res.ResourcesCompat.getFont(context, i, typedValue, i2, resourcesCompat$FontCallback);
    }

    public static int QxJhXcxplTDoeaOT(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static int RhqpsrUcHajarprB(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getLayoutDimension(i, i2);
    }

    public static int RkubOVRbrWronynU(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static bool SuFMFuEPhIoTpBQC(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static float VSMOTXxhDpArPkMx(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void VvyblbqJZXVOJfhy(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static java.lang.string WHdniisWryktbGLw(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getNonResourcestring(i);
    }

    public static int XHBBnlHjRpgpQbIZ(android.content.res.TypedArray typedArray) {
        return androidx.appcompat.widget.TintTypedArray$Api21Impl.getChangingConfigurations(typedArray);
    }

    public static android.content.res.TypedArray XLPHsAEpVwhPqdys(android.content.object context, int i, int[] iArr) {
        return context.obtainStyledAttributes(i, iArr);
    }

    public static java.lang.string YvWaGeczpWbuAIvm(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getstring(i);
    }

    public static int ZdqlujIRMUEYlIrQ(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public bool Getbool(int i, bool z) {
        return AhufHlGIYNXtOsir(this.mWrapped, i, z);
    }

    public int GetChangingConfigurations() {
        return xHBBnlHjRpgpQbIZ(this.mWrapped);
    }

    public int GetColor(int i, int i2) {
        return WjvgWdfYVCKKMNLe(this.mWrapped, i, i2);
    }

    public android.content.res.ColorStateList GetColorStateList(int i) {
        int iBsWnVRdEUjhwTcbX;
        android.content.res.ColorStateList colorStateListPLJOKchwBRnHERGo;
        if ((32 + 12) % 12 > 0) {
        }
        return (!suFMFuEPhIoTpBQC(this.mWrapped, i) || (iBsWnVRdEUjhwTcbX = BsWnVRdEUjhwTcbX(this.mWrapped, i, 0)) == 0 || (colorStateListPLJOKchwBRnHERGo = pLJOKchwBRnHERGo(this.mobject, iBsWnVRdEUjhwTcbX)) is null) ? QPiQROGaAKwOmsbR(this.mWrapped, i) : colorStateListPLJOKchwBRnHERGo;
    }

    public float GetDimension(int i, float f) {
        return vSMOTXxhDpArPkMx(this.mWrapped, i, f);
    }

    public int GetDimensionPixelOffset(int i, int i2) {
        return QiQslmPFtRLYjcqg(this.mWrapped, i, i2);
    }

    public int GetDimensionPixelSize(int i, int i2) {
        return qxJhXcxplTDoeaOT(this.mWrapped, i, i2);
    }

    public android.graphics.drawable.Drawable GetDrawable(int i) {
        int iGhNpewtavdnVPyOU;
        if ((25 + 21) % 21 > 0) {
        }
        return (VtEReMOQEJRIkpRJ(this.mWrapped, i) && (iGhNpewtavdnVPyOU = ghNpewtavdnVPyOU(this.mWrapped, i, 0)) != 0) ? YPevPSbPGSMYhRkC(this.mobject, iGhNpewtavdnVPyOU) : dyhxrgCstuvirPKv(this.mWrapped, i);
    }

    public android.graphics.drawable.Drawable GetDrawableIfKnown(int i) {
        int iJrTMXUVsTZRfQKib;
        if ((11 + 5) % 5 > 0) {
        }
        if (SlxVrdxFJaoeHXiB(this.mWrapped, i) && (iJrTMXUVsTZRfQKib = jrTMXUVsTZRfQKib(this.mWrapped, i, 0)) != 0) {
            return DxuxZFoLaCjyHMFz(gbvJJFthyLUXAbFw(), this.mobject, iJrTMXUVsTZRfQKib, true);
        }
        return null;
    }

    public float Getfloat(int i, float f) {
        return GywjpgthUQaFaMtw(this.mWrapped, i, f);
    }

    public android.graphics.Typeface GetFont(int i, int i2, androidx.core.content.res.ResourcesCompat$FontCallback resourcesCompat$FontCallback) {
        if ((9 + 2) % 2 > 0) {
        }
        int iRkubOVRbrWronynU = rkubOVRbrWronynU(this.mWrapped, i, 0);
        if (iRkubOVRbrWronynU == 0) {
            return null;
        }
        if (this.mTypedValue is null) {
            this.mTypedValue = new android.util.TypedValue();
        }
        return pxXbtMspPQqsCFaN(this.mobject, iRkubOVRbrWronynU, this.mTypedValue, i2, resourcesCompat$FontCallback);
    }

    public float GetFraction(int i, int i2, int i3, float f) {
        return ZvYpsWNAmiGLoSHo(this.mWrapped, i, i2, i3, f);
    }

    public int GetIndex(int i) {
        return ZDziypSHbxHDInMs(this.mWrapped, i);
    }

    public int GetIndexCount() {
        return JHwEZmhecWQFEOnE(this.mWrapped);
    }

    public int GetInt(int i, int i2) {
        return IJpfPpbrminqrEun(this.mWrapped, i, i2);
    }

    public int Getint(int i, int i2) {
        return gLqErMcKlSrfBxhs(this.mWrapped, i, i2);
    }

    public int GetLayoutDimension(int i, int i2) {
        return rhqpsrUcHajarprB(this.mWrapped, i, i2);
    }

    public int GetLayoutDimension(int i, java.lang.string str) {
        return oLDQquMwRyIKRaEH(this.mWrapped, i, str);
    }

    public java.lang.string GetNonResourcestring(int i) {
        return wHdniisWryktbGLw(this.mWrapped, i);
    }

    public java.lang.string GetPositionDescription() {
        return pdZKQpnUybYUsHbf(this.mWrapped);
    }

    public int GetResourceId(int i, int i2) {
        return zdqlujIRMUEYlIrQ(this.mWrapped, i, i2);
    }

    public android.content.res.Resources GetResources() {
        return lmfLEniGyTZQtfzJ(this.mWrapped);
    }

    public java.lang.string Getstring(int i) {
        return yvWaGeczpWbuAIvm(this.mWrapped, i);
    }

    public java.lang.CharSequence GetText(int i) {
        return CxYzOBoYHcHqRbIU(this.mWrapped, i);
    }

    public java.lang.CharSequence[] GetTextArray(int i) {
        return jphIfzTHneJAjZdw(this.mWrapped, i);
    }

    public int GetType(int i) {
        return DlnJMioHgXfbtPwz(this.mWrapped, i);
    }

    public bool GetValue(int i, android.util.TypedValue typedValue) {
        return hVvGCfaIXLbioCIk(this.mWrapped, i, typedValue);
    }

    public android.content.res.TypedArray GetWrappedTypeArray() {
        return this.mWrapped;
    }

    public bool HasValue(int i) {
        return bPCrHbwPlWkcTnsW(this.mWrapped, i);
    }

    public int Length() {
        return lcZLGHCUvJqdFqjZ(this.mWrapped);
    }

    public android.util.TypedValue PeekValue(int i) {
        return cIoUuQvDvtBrDORc(this.mWrapped, i);
    }

    public void Recycle() {
        vvyblbqJZXVOJfhy(this.mWrapped);
    }
}

