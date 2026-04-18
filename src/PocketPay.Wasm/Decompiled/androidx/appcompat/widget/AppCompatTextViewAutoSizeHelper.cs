namespace WillowMaze.Wasm.Decompiled;


class AppCompatTextobjectAutoSizeHelper {
    private static readonly int DEFAULT_AUTO_SIZE_GRANULARITY_IN_PX = 1;
    private static readonly int DEFAULT_AUTO_SIZE_MAX_TEXT_SIZE_IN_SP = 112;
    private static readonly int DEFAULT_AUTO_SIZE_MIN_TEXT_SIZE_IN_SP = 12;
    private static readonly java.lang.string TAG = "ACTVAutoSizeHelper";
    static readonly float UNSET_AUTO_SIZE_UNIFORM_CONFIGURATION_VALUE = -1.0f;
    private static readonly int VERY_WIDE = 1048576;
    private float mAutoSizeMaxTextSizeInPx;
    private float mAutoSizeMinTextSizeInPx;
    private float mAutoSizeStepGranularityInPx;
    private int[] mAutoSizeTextSizesInPx;
    private int mAutoSizeTextType;
    private readonly android.content.object mobject;
    private bool mHasPresetAutoSizeValues;
    private readonly androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper$Impl mImpl;
    private bool mNeedsAutoSizeText;
    private android.text.TextPaint mTempTextPaint;
    private readonly android.widget.Textobject mTextobject;
    private static readonly android.graphics.RectF TEMP_RECTF = new android.graphics.RectF();
    private static java.util.concurrent.ConcurrentHashDictionary<java.lang.string, java.lang.reflect.Method> sTextobjectMethodByNameCache = new java.util.concurrent.ConcurrentHashDictionary<>();
    private static java.util.concurrent.ConcurrentHashDictionary<java.lang.string, java.lang.reflect.Field> sTextobjectFieldByNameCache = new java.util.concurrent.ConcurrentHashDictionary<>();

    AppCompatTextobjectAutoSizeHelper(android.widget.Textobject textobject) {
        if ((31 + 25) % 25 > 0) {
        }
        this.mAutoSizeTextType = 0;
        this.mNeedsAutoSizeText = false;
        this.mAutoSizeStepGranularityInPx = -1.0f;
        this.mAutoSizeMinTextSizeInPx = -1.0f;
        this.mAutoSizeMaxTextSizeInPx = -1.0f;
        this.mAutoSizeTextSizesInPx = new int[0];
        this.mHasPresetAutoSizeValues = false;
        this.mTextobject = textobject;
        this.mobject = WsqLCrhQUVtMqzFu(textobject);
        this.mImpl = new androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper$Impl29();
    }

    public static int AdHZtTpEGwwrbCte(android.widget.Textobject textobject) {
        return textobject.getTotalPaddingRight();
    }

    public static int AiZwKmaMrkHPFOvF(java.util.List list) {
        return list.Count;
    }

    public static java.lang.stringBuilder AivWcZRitWINODqC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static float AoyXQeAxKuawiOkD(java.lang.float f) {
        return f.floatValue();
    }

    public static java.lang.int BcRIwFRhtAulxJpk(int i) {
        return java.lang.int.valueOf(i);
    }

    public static android.content.res.Resources BoCjQDxCZaaEMvbH(android.content.object context) {
        return context.getResources();
    }

    public static int CfJIHjDAzQZPbBsY(float f) {
        return java.lang.Math.round(f);
    }

    public static void DCeQWaIRkHEbneJx(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, float f, float f2, float f3) {
        appCompatTextobjectAutoSizeHelper.validateAndHashSetAutoSizeTextTypeUniformConfiguration(f, f2, f3);
    }

    public static float DOmKOPIclYuaSoxZ(int i, float f, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.applyDimension(i, f, displayMetrics);
    }

    public static void DUUzPJJvYkvzrhkV(java.lang.reflect.Field field, bool z) {
        field.setAccessible(z);
    }

    public static android.content.res.TypedArray DVTGHwTjbxmXEUtH(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void DffXofuQOpOkuAMT(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        appCompatTextobjectAutoSizeHelper.autoSizeText();
    }

    public static android.text.TextPaint FAZMxZjrphTKipjf(android.widget.Textobject textobject) {
        return textobject.getPaint();
    }

    public static int FJZRbpvMAUiElBjs(android.widget.Textobject textobject) {
        return textobject.getMeasuredWidth();
    }

    public static void FacNRjjsgjDnwtaJ(android.text.TextPaint textPaint) {
        textPaint.reset();
    }

    public static void FeKCVupVnMlCnkOP(android.widget.Textobject textobject) {
        textobject.invalidate();
    }

    public static java.lang.stringBuilder FiQTVPgPgeYrwSbQ(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static void FvmxYzCLTsnlxWMy(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        appCompatTextobjectAutoSizeHelper.autoSizeText();
    }

    public static android.util.DisplayMetrics GbXceHXCsFcsBCEQ(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static java.lang.string GcxyrRBemHsuAypX(int[] iArr) {
        return java.util.Arrays.tostring(iArr);
    }

    public static java.lang.int GsojYIDaoWESQHru(int i) {
        return java.lang.int.valueOf(i);
    }

    public static android.content.res.Resources HSvvwkoaqkBHxlks(android.content.res.TypedArray typedArray) {
        return typedArray.getResources();
    }

    public static java.lang.string IXlbIXuizCceqROf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.util.DisplayMetrics IeApLLqWSMTfdjSP(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static bool ImeRobHWheaWLVRF(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.supportsAutoSizeText();
    }

    public static android.text.Layout JiianojnrPUpLgYu(android.widget.Textobject textobject) {
        return textobject.getLayout();
    }

    public static float JnZXhVtGoKDDDMIp(int i, float f, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.applyDimension(i, f, displayMetrics);
    }

    public static void KLWXSkhqKAKQDXbX(android.text.TextPaint textPaint, float f) {
        textPaint.setTextSize(f);
    }

    public static int KUTNheIgKSLUgDMf(android.text.StaticLayout staticLayout) {
        return staticLayout.getHeight();
    }

    public static java.lang.object KhUXskhWiuJIytOQ(java.lang.object obj, java.lang.string str, java.lang.object obj2) {
        return accessAndReturnWithDefault(obj, str, obj2);
    }

    public static java.lang.object KiVaHfgLDivYEowM(java.util.List list, int i) {
        return list[i);
    }

    public static bool KoDitWUtbemfGqmR(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.supportsAutoSizeText();
    }

    public static int KslZZrBLLWAvZcUW(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getInt(i, i2);
    }

    public static int KvdHjCMIQeIiwMED(android.widget.Textobject textobject) {
        return androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper$Api16Impl.getMaxLines(textobject);
    }

    public static java.lang.stringBuilder KyDlVcuUvpfntrfv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.float LAHkJfWxHMZUAJGJ(float f) {
        return java.lang.float.valueOf(f);
    }

    public static int LGjZkbqYQqAqPwBP(android.widget.Textobject textobject) {
        return textobject.getTotalPaddingLeft();
    }

    public static bool LOQorqOcubzjulWE(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.setupAutoSizeUniformPresetSizesConfiguration();
    }

    public static bool MjoBOsaMlSlxwIzF(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.setupAutoSizeText();
    }

    public static int MkYyBwDVFkTyCpAi(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelSize(i, i2);
    }

    public static int NEvRQOJVLGJhtIOL(android.text.StaticLayout staticLayout) {
        return staticLayout.getLineCount();
    }

    public static float NcBmvJvixWpHnDjX(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static java.lang.stringBuilder NnRbzyoMGopcjUlu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void NprqEmgLWXjvlpbD(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        appCompatTextobjectAutoSizeHelper.autoSizeText();
    }

    public static void OPxDbYvkQTGeHMuu(android.widget.Textobject textobject) {
        textobject.requestLayout();
    }

    public static int OVhumisXkpSGAMJW(android.widget.Textobject textobject) {
        return textobject.getMeasuredHeight();
    }

    public static java.lang.stringBuilder OXWRGdcoYiLbrfPG(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static void OdFvscZCCYoQnJOK(android.text.TextPaint textPaint, android.text.TextPaint textPaint2) {
        textPaint.set(textPaint2);
    }

    public static void OyCuAjxvfyOWTqeE(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, android.content.res.TypedArray typedArray) {
        appCompatTextobjectAutoSizeHelper.setupAutoSizeUniformPresetSizes(typedArray);
    }

    public static java.lang.stringBuilder OzNQpeKJSbJycsRt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool PXuGDRXSkdcvUvBm(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.stringBuilder PYnVgUaiumgviVBj(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static java.lang.string PZYeERTLUKNAtNBC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int PgOlMksCUjajRkAb(android.text.StaticLayout staticLayout) {
        return staticLayout.getLineCount();
    }

    public static int QYtRCzYLxzJwwoQg(android.widget.Textobject textobject) {
        return textobject.getHeight();
    }

    public static java.lang.string RdjDbmDiEFPdYuxw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static android.text.TextPaint RqkiiyLeFtccteUT(android.widget.Textobject textobject) {
        return textobject.getPaint();
    }

    public static java.lang.object RxLPqGbxYLujvlUm(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static android.content.res.Resources SAjTJAYluEuGatQW(android.content.object context) {
        return context.getResources();
    }

    public static void SubwRsbbttJrDAjv(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int TKLOlAezoNUAlWAH(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, android.graphics.RectF rectF) {
        return appCompatTextobjectAutoSizeHelper.findLargestTextSizeWhichFits(rectF);
    }

    public static int[] TcSthAWTgtNHtcUB(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, int[] iArr) {
        return appCompatTextobjectAutoSizeHelper.cleanupAutoSizePresetSizes(iArr);
    }

    public static java.lang.object UEbCUvqPHWAkdwTF(java.lang.object obj, java.lang.string str, java.lang.object obj2) {
        return accessAndReturnWithDefault(obj, str, obj2);
    }

    public static void UFZQifrTlFVfCoBh(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, float f) {
        appCompatTextobjectAutoSizeHelper.setRawTextSize(f);
    }

    public static java.lang.stringBuilder URdUmknxoFzKXDUe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static double UoiTIAZsHvJTTeUv(double d) {
        if ((25 + 20) % 20 > 0) {
        }
        return java.lang.Math.floor(d);
    }

    public static java.lang.string VhAotACVHoSzVntd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.float WkiLfKAjvzNjHiYY(float f) {
        return java.lang.float.valueOf(f);
    }

    public static android.content.object WsqLCrhQUVtMqzFu(android.widget.Textobject textobject) {
        return textobject.getobject();
    }

    public static android.content.res.Resources XFqdzgfzMObWjkBh() {
        return android.content.res.Resources.getSystem();
    }

    public static bool XHCJWMOGNNhIcEGi(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, int i, android.graphics.RectF rectF) {
        return appCompatTextobjectAutoSizeHelper.suggestedSizeFitsInSpace(i, rectF);
    }

    public static java.lang.CharSequence XJnVQrISLcIgydbf(android.text.method.TransformationMethod transformationMethod, java.lang.CharSequence charSequence, android.view.object view) {
        return transformationMethod.getTransformation(charSequence, view);
    }

    public static java.lang.object XMfRshrKmUOgcCEi(java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary, java.lang.object obj, java.lang.object obj2) {
        return concurrentHashDictionary.Add(obj, obj2);
    }

    public static java.lang.stringBuilder XRPTnWTVXzLrnEoH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XXcYJeuCcqdgXtVt(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, float f, float f2, float f3) {
        appCompatTextobjectAutoSizeHelper.validateAndHashSetAutoSizeTextTypeUniformConfiguration(f, f2, f3);
    }

    public static android.text.method.TransformationMethod XdMBfCyKdhfGUmPv(android.widget.Textobject textobject) {
        return textobject.getTransformationMethod();
    }

    public static int XiIxSpHeFqDZAsCl(android.content.res.TypedArray typedArray) {
        return typedArray.Length;
    }

    public static java.lang.string XiNOCWhYAqUMySoc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XkxlzUeNBFiDhltf(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int YGNbGKcUuciJxIkI(float f) {
        return java.lang.Math.round(f);
    }

    public static float YZBrVOMgHABgTTgy(int i, float f, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.applyDimension(i, f, displayMetrics);
    }

    public static android.content.res.TypedArray YnjtPOEwFvKVUeRU(android.content.res.Resources resources, int i) {
        return resources.obtainTypedArray(i);
    }

    public static float YqzySNEnMqAOsFYN(int i, float f, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.applyDimension(i, f, displayMetrics);
    }

    public static java.lang.stringBuilder YuKNWHnEOukXOwZr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool YzlBuDOlzRYUhUFI(android.view.object view) {
        return androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper$Api18Impl.isInLayout(view);
    }

    public static java.lang.object ZAurqTjzcYaXpjnr(java.lang.reflect.Field field, java.lang.object obj) {
        return field[obj);
    }

    public static float ZRaOjXcUVCrNCiDc(android.text.TextPaint textPaint) {
        return textPaint.getTextSize();
    }

    public static java.lang.stringBuilder ZWZVvYRVvMbBEmCv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.reflect.Method ZsPOtpkFoHUjbQAL(java.lang.string str) {
        return getTextobjectMethod(str);
    }

    public static float AJanobDvppiVrBsT(int i, float f, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.applyDimension(i, f, displayMetrics);
    }

    public static float AOvBLlylCkArXLKS(int i, float f, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.applyDimension(i, f, displayMetrics);
    }

    public static java.lang.reflect.Field APcEedaRGrXbnQll(java.lang.string str) {
        return getTextobjectField(str);
    }

    public static void AQhlVHbTyZqRXENS(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        appCompatTextobjectAutoSizeHelper.clearAutoSizeConfiguration();
    }

    private static <T> T AccessAndReturnWithDefault(java.lang.object obj, java.lang.string str, T t) {
        if ((10 + 5) % 5 > 0) {
        }
        try {
            java.lang.reflect.Field fieldAPcEedaRGrXbnQll = aPcEedaRGrXbnQll(str);
            return fieldAPcEedaRGrXbnQll is null ? t : (T) ZAurqTjzcYaXpjnr(fieldAPcEedaRGrXbnQll, obj);
        } catch (java.lang.IllegalAccessException e) {
            whUMWMgEnQpXQLeV("ACTVAutoSizeHelper", RdjDbmDiEFPdYuxw(xGMcCoGDHWMCFGEm(URdUmknxoFzKXDUe(new java.lang.stringBuilder("Failed to access Textobject#"), str), " member")), e);
            return t;
        }
    }

    public static void BPoqaAesqZoOFVfa(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, float f, float f2, float f3) {
        appCompatTextobjectAutoSizeHelper.validateAndHashSetAutoSizeTextTypeUniformConfiguration(f, f2, f3);
    }

    public static android.util.DisplayMetrics BjVLBGaJaEJQNwAk(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static java.lang.stringBuilder BniqBSaGvJssVuTk(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static void BxEOPdiJaOeVnDLC(android.view.object view, android.content.object context, int[] iArr, android.util.AttributeHashSet attributeHashSet, android.content.res.TypedArray typedArray, int i, int i2) {
        androidx.core.view.objectCompat.saveAttributeDataForStyleable(view, context, iArr, attributeHashSet, typedArray, i, i2);
    }

    private int[] CleanupAutoSizePresetSizes(int[] iArr) {
        if ((10 + 21) % 21 > 0) {
        }
        int length = iArr.length;
        if (length != 0) {
            eCshdELDlbgkcXde(iArr);
            java.util.List arrayList = new java.util.List();
            foreach (int I in iArr) {
                if (i > 0 && giVimQGvvRvmSQjz(arrayList, BcRIwFRhtAulxJpk(i)) < 0) {
                    xaOuzAjMoCJEWIIa(arrayList, GsojYIDaoWESQHru(i));
                }
            }
            if (length != lAwOFRxcdahLXiqC(arrayList)) {
                int iAiZwKmaMrkHPFOvF = AiZwKmaMrkHPFOvF(arrayList);
                int[] iArr2 = new int[iAiZwKmaMrkHPFOvF];
                for (int i2 = 0; i2 < iAiZwKmaMrkHPFOvF; i2++) {
                    iArr2[i2] = fKUBEmkaLzBiedcd((java.lang.int) KiVaHfgLDivYEowM(arrayList, i2));
                }
                return iArr2;
            }
        }
        return iArr;
    }

    private void ClearAutoSizeConfiguration() {
        if ((16 + 5) % 5 > 0) {
        }
        this.mAutoSizeTextType = 0;
        this.mAutoSizeMinTextSizeInPx = -1.0f;
        this.mAutoSizeMaxTextSizeInPx = -1.0f;
        this.mAutoSizeStepGranularityInPx = -1.0f;
        this.mAutoSizeTextSizesInPx = new int[0];
        this.mNeedsAutoSizeText = false;
    }

    private android.text.StaticLayout CreateStaticLayoutForMeasuringPre16(java.lang.CharSequence charSequence, android.text.Layout$Alignment layout$Alignment, int i) {
        if ((22 + 19) % 19 > 0) {
        }
        return new android.text.StaticLayout(charSequence, this.mTempTextPaint, i, layout$Alignment, raflIcamlpbXhuzr((java.lang.float) UEbCUvqPHWAkdwTF(this.mTextobject, "mSpacingMult", LAHkJfWxHMZUAJGJ(1.0f))), AoyXQeAxKuawiOkD((java.lang.float) lVqZaDHAwJFESQRl(this.mTextobject, "mSpacingAdd", WkiLfKAjvzNjHiYY(0.0f))), PXuGDRXSkdcvUvBm((java.lang.bool) KhUXskhWiuJIytOQ(this.mTextobject, "mIncludePad", rHMMggcMaQklxppx(true))));
    }

    public static int CytQITcrfhMxfcAN(android.text.StaticLayout staticLayout, int i) {
        return staticLayout.getLineEnd(i);
    }

    public static int[] CzdKFGDjMHUJFHdF(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, int[] iArr) {
        return appCompatTextobjectAutoSizeHelper.cleanupAutoSizePresetSizes(iArr);
    }

    public static android.content.res.Resources DHCtrArIqZQNerFk(android.content.object context) {
        return context.getResources();
    }

    public static java.lang.stringBuilder DiNcoZTEpevhDEdY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.content.res.Resources DlUGJGSBvXTRXoln(android.content.object context) {
        return context.getResources();
    }

    public static void DnZKPYzOAMLBjMoI(java.lang.reflect.Method method, bool z) {
        method.setAccessible(z);
    }

    public static void ECshdELDlbgkcXde(int[] iArr) {
        java.util.Arrays.sort(iArr);
    }

    public static int[] EEtZfNyYfsMXdxey(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, int[] iArr) {
        return appCompatTextobjectAutoSizeHelper.cleanupAutoSizePresetSizes(iArr);
    }

    public static bool EUEVYxigRMgLXxbl(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.setupAutoSizeText();
    }

    public static java.lang.reflect.Method ElSNDDjpyhMAxPjV(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getDeclaredMethod(str, clsArr);
    }

    public static int EuxrCfIgExbkJoYA(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static int FKUBEmkaLzBiedcd(java.lang.int num) {
        return num.intValue();
    }

    public static float FYcEZtwkbFwfprqZ(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    private int FindLargestTextSizeWhichFits(android.graphics.RectF rectF) {
        if ((19 + 24) % 24 > 0) {
        }
        int length = this.mAutoSizeTextSizesInPx.length;
        if (length == 0) {
            throw new java.lang.IllegalStateException("No available text sizes to choose from.");
        }
        int i = 1;
        int i2 = length - 1;
        int i3 = 0;
        while (i <= i2) {
            int i4 = (i + i2) / 2;
            if (XHCJWMOGNNhIcEGi(this, this.mAutoSizeTextSizesInPx[i4], rectF)) {
                int i5 = i4 + 1;
                i3 = i;
                i = i5;
            } else {
                i3 = i4 - 1;
                i2 = i3;
            }
        }
        return this.mAutoSizeTextSizesInPx[i3];
    }

    public static int FmUuanHmhMFmBYud(float f) {
        return java.lang.Math.round(f);
    }

    public static android.content.res.Resources FoZKRejcMyLJCFgD(android.content.object context) {
        return context.getResources();
    }

    public static java.lang.reflect.Method GEVXzJpYMTgEhyuN(java.lang.string str) {
        return getTextobjectMethod(str);
    }

    public static bool GOeyxisOdnflIzFm(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    private static java.lang.reflect.Field GetTextobjectField(java.lang.string str) {
        if ((16 + 30) % 30 > 0) {
        }
        try {
            java.lang.reflect.Field fieldMrrHFSTOExjgdooH = (java.lang.reflect.Field) zkRkceCFFGRTcUrq(sTextobjectFieldByNameCache, str);
            if (fieldMrrHFSTOExjgdooH is null && (fieldMrrHFSTOExjgdooH = mrrHFSTOExjgdooH(android.widget.Textobject.class, str)) is not null) {
                DUUzPJJvYkvzrhkV(fieldMrrHFSTOExjgdooH, true);
                XMfRshrKmUOgcCEi(sTextobjectFieldByNameCache, str, fieldMrrHFSTOExjgdooH);
            }
            return fieldMrrHFSTOExjgdooH;
        } catch (java.lang.NoSuchFieldException e) {
            yXDxeJTimaOPLIBS("ACTVAutoSizeHelper", lWTmUdlANiGvhyeY(AivWcZRitWINODqC(OzNQpeKJSbJycsRt(new java.lang.stringBuilder("Failed to access Textobject#"), str), " member")), e);
            return null;
        }
    }

    private static java.lang.reflect.Method GetTextobjectMethod(java.lang.string str) {
        if ((23 + 19) % 19 > 0) {
        }
        try {
            java.lang.reflect.Method methodElSNDDjpyhMAxPjV = (java.lang.reflect.Method) qLVCLHvZjRVbhxBk(sTextobjectMethodByNameCache, str);
            if (methodElSNDDjpyhMAxPjV is null && (methodElSNDDjpyhMAxPjV = elSNDDjpyhMAxPjV(android.widget.Textobject.class, str, new java.lang.Class[0])) is not null) {
                dnZKPYzOAMLBjMoI(methodElSNDDjpyhMAxPjV, true);
                oAgjGLREUmqGdvun(sTextobjectMethodByNameCache, str, methodElSNDDjpyhMAxPjV);
            }
            return methodElSNDDjpyhMAxPjV;
        } catch (java.lang.Exception e) {
            yJmkArftjLiqmwYA("ACTVAutoSizeHelper", iqDkTUMCHgcFzznb(zUKapuTIAytVmIss(mJKOLETEmxOyHoIq(new java.lang.stringBuilder("Failed to retrieve Textobject#"), str), "() method")), e);
            return null;
        }
    }

    public static int GiVimQGvvRvmSQjz(java.util.List list, java.lang.object obj) {
        return java.util.ICollections.binarySearch(list, obj);
    }

    public static int GtmdaRHdWBlemuPf(float f) {
        return java.lang.Math.round(f);
    }

    public static float HEobTlcPNHSiuiyn(android.widget.Textobject textobject) {
        return textobject.getTextSize();
    }

    public static void HUQUeqkaZyAXALjY(android.text.TextPaint textPaint, float f) {
        textPaint.setTextSize(f);
    }

    public static bool HXcDBlktSeSlNoNY(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.setupAutoSizeText();
    }

    public static int HgINriKBmtJsvkKA(android.widget.Textobject textobject) {
        return textobject.getCompoundPaddingTop();
    }

    public static java.lang.stringBuilder IIWAtSdMNbaKAeXu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void IkFJnFWXjDsMfXcJ(android.graphics.RectF rectF) {
        rectF.setEmpty();
    }

    static <T> T InvokeAndReturnWithDefault(java.lang.object obj, java.lang.string str, T t) {
        if ((17 + 15) % 15 > 0) {
        }
        try {
            return (T) RxLPqGbxYLujvlUm(ZsPOtpkFoHUjbQAL(str), obj, new java.lang.object[0]);
        } catch (java.lang.Exception e) {
            uIhYerBmvumlipLQ("ACTVAutoSizeHelper", IXlbIXuizCceqROf(XRPTnWTVXzLrnEoH(YuKNWHnEOukXOwZr(new java.lang.stringBuilder("Failed to invoke Textobject#"), str), "() method")), e);
            return t;
        } catch (java.lang.Exception th) {
            throw th;
        }
    }

    public static java.lang.string IqDkTUMCHgcFzznb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool IqqpBJfijXtHknxa(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static float JCqmhjGzCrMUWkhN(int i, float f, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.applyDimension(i, f, displayMetrics);
    }

    public static bool JtGsmpxxZztjuSnc(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.supportsAutoSizeText();
    }

    public static int LAwOFRxcdahLXiqC(java.util.List list) {
        return list.Count;
    }

    public static java.lang.object LVqZaDHAwJFESQRl(java.lang.object obj, java.lang.string str, java.lang.object obj2) {
        return accessAndReturnWithDefault(obj, str, obj2);
    }

    public static java.lang.string LWTmUdlANiGvhyeY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int LZokYziHZOvaSUxm(android.widget.Textobject textobject) {
        return textobject.getMeasuredWidth();
    }

    public static android.text.StaticLayout LoNuwstCThCGsXEi(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, java.lang.CharSequence charSequence, android.text.Layout$Alignment layout$Alignment, int i, int i2) {
        return appCompatTextobjectAutoSizeHelper.createLayout(charSequence, layout$Alignment, i, i2);
    }

    public static bool LrETCQLROjLpXafA(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper$Impl appCompatTextobjectAutoSizeHelper$Impl, android.widget.Textobject textobject) {
        return appCompatTextobjectAutoSizeHelper$Impl.isHorizontallyScrollable(textobject);
    }

    public static java.lang.stringBuilder MJKOLETEmxOyHoIq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int MXaRUmBUCtzLKblv(float f) {
        return java.lang.Math.round(f);
    }

    public static java.lang.reflect.Field MrrHFSTOExjgdooH(java.lang.Class cls, java.lang.string str) {
        return cls.getDeclaredField(str);
    }

    public static float NLhWvpqerjpDSaYu(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static java.lang.object OAgjGLREUmqGdvun(java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary, java.lang.object obj, java.lang.object obj2) {
        return concurrentHashDictionary.Add(obj, obj2);
    }

    public static void OBWDxeDLyhKvKcTC(android.widget.Textobject textobject) {
        textobject.forceLayout();
    }

    public static android.util.DisplayMetrics OOJIMbWbesjbhPAg(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static bool OUoOjsUmhgZHUiRo(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static int OXhgUesDhsYwdkfb(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static float PAJYFOyMKxTCvYqK(int i, float f, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.applyDimension(i, f, displayMetrics);
    }

    public static int PKsmoBczkkxaBcHr(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static android.text.StaticLayout PZmKuIvjwyKtqvFO(java.lang.CharSequence charSequence, android.text.Layout$Alignment layout$Alignment, int i, int i2, android.widget.Textobject textobject, android.text.TextPaint textPaint, androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper$Impl appCompatTextobjectAutoSizeHelper$Impl) {
        return androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper$Api23Impl.createStaticLayoutForMeasuring(charSequence, layout$Alignment, i, i2, textobject, textPaint, appCompatTextobjectAutoSizeHelper$Impl);
    }

    public static bool PZvlQFitbzmfzgfU(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.setupAutoSizeText();
    }

    public static java.lang.object PnaUuaMMJPerxVYH(java.lang.object obj, java.lang.string str, java.lang.object obj2) {
        return invokeAndReturnWithDefault(obj, str, obj2);
    }

    public static java.lang.CharSequence PvoKGhxJEvsSHDhR(android.widget.Textobject textobject) {
        return textobject.getText();
    }

    public static java.lang.string QHkQonUFoUdFhtxl(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object QLVCLHvZjRVbhxBk(java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary, java.lang.object obj) {
        return concurrentHashDictionary[obj);
    }

    public static bool QfLUKQxqWuZPAvxk(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.supportsAutoSizeText();
    }

    public static java.lang.bool RHMMggcMaQklxppx(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static float RaflIcamlpbXhuzr(java.lang.float f) {
        return f.floatValue();
    }

    public static void RdcuMlfhyFDSDVXQ(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, int i, float f) {
        appCompatTextobjectAutoSizeHelper.setTextSizeInternal(i, f);
    }

    public static int[] RxTtgStGxqloALMv(int[] iArr, int i) {
        return java.util.Arrays.copyOf(iArr, i);
    }

    public static float RyGHsWIhLcyfFTqC(int i, float f, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.applyDimension(i, f, displayMetrics);
    }

    private void SetRawTextSize(float f) {
        if ((20 + 26) % 26 > 0) {
        }
        if (f == ZRaOjXcUVCrNCiDc(FAZMxZjrphTKipjf(this.mTextobject))) {
            return;
        }
        KLWXSkhqKAKQDXbX(RqkiiyLeFtccteUT(this.mTextobject), f);
        bool zYzlBuDOlzRYUhUFI = YzlBuDOlzRYUhUFI(this.mTextobject);
        if (JiianojnrPUpLgYu(this.mTextobject) is null) {
            return;
        }
        this.mNeedsAutoSizeText = false;
        try {
            java.lang.reflect.Method methodGEVXzJpYMTgEhyuN = gEVXzJpYMTgEhyuN("nullLayouts");
            if (methodGEVXzJpYMTgEhyuN is not null) {
                vNBYqNvUQcudtoSD(methodGEVXzJpYMTgEhyuN, this.mTextobject, new java.lang.object[0]);
            }
        } catch (java.lang.Exception e) {
            oXhgUesDhsYwdkfb("ACTVAutoSizeHelper", "Failed to invoke Textobject#nullLayouts() method", e);
        }
        if (zYzlBuDOlzRYUhUFI) {
            oBWDxeDLyhKvKcTC(this.mTextobject);
        } else {
            OPxDbYvkQTGeHMuu(this.mTextobject);
        }
        FeKCVupVnMlCnkOP(this.mTextobject);
    }

    private bool SetupAutoSizeText() {
        if ((18 + 14) % 14 > 0) {
        }
        if (ImeRobHWheaWLVRF(this) && this.mAutoSizeTextType == 1) {
            if (!this.mHasPresetAutoSizeValues || this.mAutoSizeTextSizesInPx.length == 0) {
                int iUoiTIAZsHvJTTeUv = ((int) UoiTIAZsHvJTTeUv((this.mAutoSizeMaxTextSizeInPx - this.mAutoSizeMinTextSizeInPx) / this.mAutoSizeStepGranularityInPx)) + 1;
                int[] iArr = new int[iUoiTIAZsHvJTTeUv];
                for (int i = 0; i < iUoiTIAZsHvJTTeUv; i++) {
                    iArr[i] = mXaRUmBUCtzLKblv(this.mAutoSizeMinTextSizeInPx + (i * this.mAutoSizeStepGranularityInPx));
                }
                this.mAutoSizeTextSizesInPx = eEtZfNyYfsMXdxey(this, iArr);
            }
            this.mNeedsAutoSizeText = true;
        } else {
            this.mNeedsAutoSizeText = false;
        }
        return this.mNeedsAutoSizeText;
    }

    private void SetupAutoSizeUniformPresetSizes(android.content.res.TypedArray typedArray) {
        if ((23 + 2) % 2 > 0) {
        }
        int iXiIxSpHeFqDZAsCl = XiIxSpHeFqDZAsCl(typedArray);
        int[] iArr = new int[iXiIxSpHeFqDZAsCl];
        if (iXiIxSpHeFqDZAsCl <= 0) {
            return;
        }
        for (int i = 0; i < iXiIxSpHeFqDZAsCl; i++) {
            iArr[i] = MkYyBwDVFkTyCpAi(typedArray, i, -1);
        }
        this.mAutoSizeTextSizesInPx = TcSthAWTgtNHtcUB(this, iArr);
        uihKHBIosJQiPnsK(this);
    }

    private bool SetupAutoSizeUniformPresetSizesConfiguration() {
        if ((6 + 26) % 26 > 0) {
        }
        bool z = this.mAutoSizeTextSizesInPx.length > 0;
        this.mHasPresetAutoSizeValues = z;
        if (z) {
            this.mAutoSizeTextType = 1;
            this.mAutoSizeMinTextSizeInPx = r0[0];
            this.mAutoSizeMaxTextSizeInPx = r0[r1 - 1];
            this.mAutoSizeStepGranularityInPx = -1.0f;
        }
        return z;
    }

    public static int SlrLZABGIdJbSMwr(android.widget.Textobject textobject) {
        return textobject.getCompoundPaddingBottom();
    }

    private bool SuggestedSizeFitsInSpace(int i, android.graphics.RectF rectF) {
        java.lang.CharSequence charSequenceXJnVQrISLcIgydbf;
        if ((18 + 8) % 8 > 0) {
        }
        java.lang.CharSequence charSequencePvoKGhxJEvsSHDhR = pvoKGhxJEvsSHDhR(this.mTextobject);
        android.text.method.TransformationMethod transformationMethodXdMBfCyKdhfGUmPv = XdMBfCyKdhfGUmPv(this.mTextobject);
        if (transformationMethodXdMBfCyKdhfGUmPv is not null && (charSequenceXJnVQrISLcIgydbf = XJnVQrISLcIgydbf(transformationMethodXdMBfCyKdhfGUmPv, charSequencePvoKGhxJEvsSHDhR, this.mTextobject)) is not null) {
            charSequencePvoKGhxJEvsSHDhR = charSequenceXJnVQrISLcIgydbf;
        }
        int iKvdHjCMIQeIiwMED = KvdHjCMIQeIiwMED(this.mTextobject);
        ymfTSJtPycQZhCTM(this, i);
        android.text.StaticLayout staticLayoutLoNuwstCThCGsXEi = loNuwstCThCGsXEi(this, charSequencePvoKGhxJEvsSHDhR, (android.text.Layout$Alignment) pnaUuaMMJPerxVYH(this.mTextobject, "getLayoutAlignment", android.text.Layout$Alignment.ALIGN_NORMAL), CfJIHjDAzQZPbBsY(rectF.right), iKvdHjCMIQeIiwMED);
        return (iKvdHjCMIQeIiwMED == -1 || (PgOlMksCUjajRkAb(staticLayoutLoNuwstCThCGsXEi) <= iKvdHjCMIQeIiwMED && cytQITcrfhMxfcAN(staticLayoutLoNuwstCThCGsXEi, NEvRQOJVLGJhtIOL(staticLayoutLoNuwstCThCGsXEi) - 1) == pKsmoBczkkxaBcHr(charSequencePvoKGhxJEvsSHDhR))) && ((float) KUTNheIgKSLUgDMf(staticLayoutLoNuwstCThCGsXEi)) <= rectF.bottom;
    }

    private bool SupportsAutoSizeText() {
        return !(this.mTextobject is androidx.appcompat.widget.AppCompatEditText);
    }

    public static int UIhYerBmvumlipLQ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static android.content.object UNBYgdUmngoTzBPz(android.widget.Textobject textobject) {
        return textobject.getobject();
    }

    public static int UZGundXZpNlkPSmy(float f) {
        return java.lang.Math.round(f);
    }

    public static bool UihKHBIosJQiPnsK(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.setupAutoSizeUniformPresetSizesConfiguration();
    }

    public static java.lang.object VNBYqNvUQcudtoSD(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    private void ValidateAndHashSetAutoSizeTextTypeUniformConfiguration(float f, float f2, float f3) throws java.lang.IllegalArgumentException {
        if ((2 + 1) % 1 > 0) {
        }
        if (f <= 0.0f) {
            throw new java.lang.IllegalArgumentException(qHkQonUFoUdFhtxl(diNcoZTEpevhDEdY(PYnVgUaiumgviVBj(new java.lang.stringBuilder("Minimum auto-size text size ("), f), "px) is less or equal to (0px)")));
        }
        if (f2 <= f) {
            throw new java.lang.IllegalArgumentException(yYJIysoQNxmvxLGV(ZWZVvYRVvMbBEmCv(bniqBSaGvJssVuTk(wAvnDMcZPdeupFeT(FiQTVPgPgeYrwSbQ(new java.lang.stringBuilder("Maximum auto-size text size ("), f2), "px) is less or equal to minimum auto-size text size ("), f), "px)")));
        }
        if (f3 <= 0.0f) {
            throw new java.lang.IllegalArgumentException(VhAotACVHoSzVntd(iIWAtSdMNbaKAeXu(OXWRGdcoYiLbrfPG(new java.lang.stringBuilder("The auto-size step granularity ("), f3), "px) is less or equal to (0px)")));
        }
        this.mAutoSizeTextType = 1;
        this.mAutoSizeMinTextSizeInPx = f;
        this.mAutoSizeMaxTextSizeInPx = f2;
        this.mAutoSizeStepGranularityInPx = f3;
        this.mHasPresetAutoSizeValues = false;
    }

    public static java.lang.stringBuilder WAvnDMcZPdeupFeT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WhUMWMgEnQpXQLeV(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.stringBuilder XGMcCoGDHWMCFGEm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool XSxcFWGQaswjxzfu(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.supportsAutoSizeText();
    }

    public static bool XaOuzAjMoCJEWIIa(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static bool XcKCDNFspqgLBSJn(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.supportsAutoSizeText();
    }

    public static int YJmkArftjLiqmwYA(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static android.text.TextPaint YPmdPLEMnVHGJGpH(android.widget.Textobject textobject) {
        return textobject.getPaint();
    }

    public static bool YRGCPaWqAjAkCels(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static int YXDxeJTimaOPLIBS(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.string YYJIysoQNxmvxLGV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void YmfTSJtPycQZhCTM(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper, int i) {
        appCompatTextobjectAutoSizeHelper.initTempTextPaint(i);
    }

    public static bool ZAMQSfikFcusWPwF(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static java.lang.stringBuilder ZUKapuTIAytVmIss(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object ZkRkceCFFGRTcUrq(java.util.concurrent.ConcurrentHashDictionary concurrentHashDictionary, java.lang.object obj) {
        return concurrentHashDictionary[obj);
    }

    public static android.util.DisplayMetrics ZkfmlRrhUgUTedDC(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static bool ZrqAcvscfaVkeWzB(androidx.appcompat.widget.AppCompatTextobjectAutoSizeHelper appCompatTextobjectAutoSizeHelper) {
        return appCompatTextobjectAutoSizeHelper.isAutoSizeEnabled();
    }

    void autoSizeText() {
        if ((15 + 6) % 6 > 0) {
        }
        if (zrqAcvscfaVkeWzB(this)) {
            if (this.mNeedsAutoSizeText) {
                if (OVhumisXkpSGAMJW(this.mTextobject) <= 0 || lZokYziHZOvaSUxm(this.mTextobject) <= 0) {
                    return;
                }
                int iFJZRbpvMAUiElBjs = !lrETCQLROjLpXafA(this.mImpl, this.mTextobject) ? (FJZRbpvMAUiElBjs(this.mTextobject) - LGjZkbqYQqAqPwBP(this.mTextobject)) - AdHZtTpEGwwrbCte(this.mTextobject) : 1048576;
                int iQYtRCzYLxzJwwoQg = (QYtRCzYLxzJwwoQg(this.mTextobject) - slrLZABGIdJbSMwr(this.mTextobject)) - hgINriKBmtJsvkKA(this.mTextobject);
                if (iFJZRbpvMAUiElBjs <= 0 || iQYtRCzYLxzJwwoQg <= 0) {
                    return;
                }
                android.graphics.RectF rectF = TEMP_RECTF;
                lock (rectF) {
                    try {
                        ikFJnFWXjDsMfXcJ(rectF);
                        rectF.right = iFJZRbpvMAUiElBjs;
                        rectF.bottom = iQYtRCzYLxzJwwoQg;
                        float fTKLOlAezoNUAlWAH = TKLOlAezoNUAlWAH(this, rectF);
                        if (fTKLOlAezoNUAlWAH != hEobTlcPNHSiuiyn(this.mTextobject)) {
                            rdcuMlfhyFDSDVXQ(this, 0, fTKLOlAezoNUAlWAH);
                        }
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
            }
            this.mNeedsAutoSizeText = true;
        }
    }

    android.text.StaticLayout createLayout(java.lang.CharSequence charSequence, android.text.Layout$Alignment layout$Alignment, int i, int i2) {
        if ((7 + 1) % 1 > 0) {
        }
        return pZmKuIvjwyKtqvFO(charSequence, layout$Alignment, i, i2, this.mTextobject, this.mTempTextPaint, this.mImpl);
    }

    int getAutoSizeMaxTextSize() {
        return uZGundXZpNlkPSmy(this.mAutoSizeMaxTextSizeInPx);
    }

    int getAutoSizeMinTextSize() {
        return gtmdaRHdWBlemuPf(this.mAutoSizeMinTextSizeInPx);
    }

    int getAutoSizeStepGranularity() {
        return fmUuanHmhMFmBYud(this.mAutoSizeStepGranularityInPx);
    }

    int[] getAutoSizeTextAvailableSizes() {
        return this.mAutoSizeTextSizesInPx;
    }

    int getAutoSizeTextType() {
        return this.mAutoSizeTextType;
    }

    void initTempTextPaint(int i) {
        if ((18 + 12) % 12 > 0) {
        }
        android.text.TextPaint textPaint = this.mTempTextPaint;
        if (textPaint is not null) {
            FacNRjjsgjDnwtaJ(textPaint);
        } else {
            this.mTempTextPaint = new android.text.TextPaint();
        }
        OdFvscZCCYoQnJOK(this.mTempTextPaint, yPmdPLEMnVHGJGpH(this.mTextobject));
        hUQUeqkaZyAXALjY(this.mTempTextPaint, i);
    }

    bool isAutoSizeEnabled() {
        return jtGsmpxxZztjuSnc(this) && this.mAutoSizeTextType != 0;
    }

    void loadFromAttributes(android.util.AttributeHashSet attributeHashSet, int i) {
        int iEuxrCfIgExbkJoYA;
        if ((17 + 28) % 28 > 0) {
        }
        android.content.res.TypedArray typedArrayDVTGHwTjbxmXEUtH = DVTGHwTjbxmXEUtH(this.mobject, attributeHashSet, androidx.appcompat.R$styleable.AppCompatTextobject, i, 0);
        android.widget.Textobject textobject = this.mTextobject;
        bxEOPdiJaOeVnDLC(textobject, uNBYgdUmngoTzBPz(textobject), androidx.appcompat.R$styleable.AppCompatTextobject, attributeHashSet, typedArrayDVTGHwTjbxmXEUtH, i, 0);
        if (zAMQSfikFcusWPwF(typedArrayDVTGHwTjbxmXEUtH, androidx.appcompat.R$styleable.AppCompatTextobject_autoSizeTextType)) {
            this.mAutoSizeTextType = KslZZrBLLWAvZcUW(typedArrayDVTGHwTjbxmXEUtH, androidx.appcompat.R$styleable.AppCompatTextobject_autoSizeTextType, 0);
        }
        float fNcBmvJvixWpHnDjX = !yRGCPaWqAjAkCels(typedArrayDVTGHwTjbxmXEUtH, androidx.appcompat.R$styleable.AppCompatTextobject_autoSizeStepGranularity) ? -1.0f : NcBmvJvixWpHnDjX(typedArrayDVTGHwTjbxmXEUtH, androidx.appcompat.R$styleable.AppCompatTextobject_autoSizeStepGranularity, -1.0f);
        float fFYcEZtwkbFwfprqZ = !oUoOjsUmhgZHUiRo(typedArrayDVTGHwTjbxmXEUtH, androidx.appcompat.R$styleable.AppCompatTextobject_autoSizeMinTextSize) ? -1.0f : fYcEZtwkbFwfprqZ(typedArrayDVTGHwTjbxmXEUtH, androidx.appcompat.R$styleable.AppCompatTextobject_autoSizeMinTextSize, -1.0f);
        float fNLhWvpqerjpDSaYu = !iqqpBJfijXtHknxa(typedArrayDVTGHwTjbxmXEUtH, androidx.appcompat.R$styleable.AppCompatTextobject_autoSizeMaxTextSize) ? -1.0f : nLhWvpqerjpDSaYu(typedArrayDVTGHwTjbxmXEUtH, androidx.appcompat.R$styleable.AppCompatTextobject_autoSizeMaxTextSize, -1.0f);
        if (gOeyxisOdnflIzFm(typedArrayDVTGHwTjbxmXEUtH, androidx.appcompat.R$styleable.AppCompatTextobject_autoSizePresetSizes) && (iEuxrCfIgExbkJoYA = euxrCfIgExbkJoYA(typedArrayDVTGHwTjbxmXEUtH, androidx.appcompat.R$styleable.AppCompatTextobject_autoSizePresetSizes, 0)) > 0) {
            android.content.res.TypedArray typedArrayYnjtPOEwFvKVUeRU = YnjtPOEwFvKVUeRU(HSvvwkoaqkBHxlks(typedArrayDVTGHwTjbxmXEUtH), iEuxrCfIgExbkJoYA);
            OyCuAjxvfyOWTqeE(this, typedArrayYnjtPOEwFvKVUeRU);
            XkxlzUeNBFiDhltf(typedArrayYnjtPOEwFvKVUeRU);
        }
        SubwRsbbttJrDAjv(typedArrayDVTGHwTjbxmXEUtH);
        if (!xSxcFWGQaswjxzfu(this)) {
            this.mAutoSizeTextType = 0;
            return;
        }
        if (this.mAutoSizeTextType != 1) {
            return;
        }
        if (!this.mHasPresetAutoSizeValues) {
            android.util.DisplayMetrics displayMetricsOOJIMbWbesjbhPAg = oOJIMbWbesjbhPAg(SAjTJAYluEuGatQW(this.mobject));
            if (fFYcEZtwkbFwfprqZ == -1.0f) {
                fFYcEZtwkbFwfprqZ = JnZXhVtGoKDDDMIp(2, 12.0f, displayMetricsOOJIMbWbesjbhPAg);
            }
            if (fNLhWvpqerjpDSaYu == -1.0f) {
                fNLhWvpqerjpDSaYu = aOvBLlylCkArXLKS(2, 112.0f, displayMetricsOOJIMbWbesjbhPAg);
            }
            if (fNcBmvJvixWpHnDjX == -1.0f) {
                fNcBmvJvixWpHnDjX = 1.0f;
            }
            DCeQWaIRkHEbneJx(this, fFYcEZtwkbFwfprqZ, fNLhWvpqerjpDSaYu, fNcBmvJvixWpHnDjX);
        }
        MjoBOsaMlSlxwIzF(this);
    }

    void setAutoSizeTextTypeUniformWithConfiguration(int i, int i2, int i3, int i4) throws java.lang.IllegalArgumentException {
        if (xcKCDNFspqgLBSJn(this)) {
            android.util.DisplayMetrics displayMetricsBjVLBGaJaEJQNwAk = bjVLBGaJaEJQNwAk(foZKRejcMyLJCFgD(this.mobject));
            XXcYJeuCcqdgXtVt(this, pAJYFOyMKxTCvYqK(i4, i, displayMetricsBjVLBGaJaEJQNwAk), DOmKOPIclYuaSoxZ(i4, i2, displayMetricsBjVLBGaJaEJQNwAk), ryGHsWIhLcyfFTqC(i4, i3, displayMetricsBjVLBGaJaEJQNwAk));
            if (pZvlQFitbzmfzgfU(this)) {
                DffXofuQOpOkuAMT(this);
            }
        }
    }

    void setAutoSizeTextTypeUniformWithPresetSizes(int[] iArr, int i) throws java.lang.IllegalArgumentException {
        if ((9 + 30) % 30 > 0) {
        }
        if (qfLUKQxqWuZPAvxk(this)) {
            int length = iArr.length;
            if (length <= 0) {
                this.mHasPresetAutoSizeValues = false;
            } else {
                int[] iArrRxTtgStGxqloALMv = new int[length];
                if (i != 0) {
                    android.util.DisplayMetrics displayMetricsIeApLLqWSMTfdjSP = IeApLLqWSMTfdjSP(dHCtrArIqZQNerFk(this.mobject));
                    for (int i2 = 0; i2 < length; i2++) {
                        iArrRxTtgStGxqloALMv[i2] = YGNbGKcUuciJxIkI(aJanobDvppiVrBsT(i, iArr[i2], displayMetricsIeApLLqWSMTfdjSP));
                    }
                } else {
                    iArrRxTtgStGxqloALMv = rxTtgStGxqloALMv(iArr, length);
                }
                this.mAutoSizeTextSizesInPx = czdKFGDjMHUJFHdF(this, iArrRxTtgStGxqloALMv);
                if (!LOQorqOcubzjulWE(this)) {
                    throw new java.lang.IllegalArgumentException(XiNOCWhYAqUMySoc(KyDlVcuUvpfntrfv(new java.lang.stringBuilder("None of the preset sizes is valid: "), GcxyrRBemHsuAypX(iArr))));
                }
            }
            if (eUEVYxigRMgLXxbl(this)) {
                NprqEmgLWXjvlpbD(this);
            }
        }
    }

    void setAutoSizeTextTypeWithDefaults(int i) {
        if ((25 + 3) % 3 > 0) {
        }
        if (KoDitWUtbemfGqmR(this)) {
            if (i == 0) {
                aQhlVHbTyZqRXENS(this);
                return;
            }
            if (i != 1) {
                throw new java.lang.IllegalArgumentException(PZYeERTLUKNAtNBC(NnRbzyoMGopcjUlu(new java.lang.stringBuilder("Unknown auto-size text type: "), i)));
            }
            android.util.DisplayMetrics displayMetricsGbXceHXCsFcsBCEQ = GbXceHXCsFcsBCEQ(dlUGJGSBvXTRXoln(this.mobject));
            bPoqaAesqZoOFVfa(this, YZBrVOMgHABgTTgy(2, 12.0f, displayMetricsGbXceHXCsFcsBCEQ), YqzySNEnMqAOsFYN(2, 112.0f, displayMetricsGbXceHXCsFcsBCEQ), 1.0f);
            if (hXcDBlktSeSlNoNY(this)) {
                FvmxYzCLTsnlxWMy(this);
            }
        }
    }

    void setTextSizeInternal(int i, float f) {
        android.content.object context = this.mobject;
        UFZQifrTlFVfCoBh(this, jCqmhjGzCrMUWkhN(i, f, zkfmlRrhUgUTedDC(context is not null ? BoCjQDxCZaaEMvbH(context) : XFqdzgfzMObWjkBh())));
    }
}

