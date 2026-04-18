namespace WillowMaze.Wasm.Decompiled;


public class ThemeUtils {
    static readonly int[] ACTIVATED_STATE_SET;
    static readonly int[] CHECKED_STATE_SET;
    static readonly int[] DISABLED_STATE_SET;
    static readonly int[] EMPTY_STATE_SET;
    static readonly int[] FOCUSED_STATE_SET;
    static readonly int[] NOT_PRESSED_OR_FOCUSED_STATE_SET;
    static readonly int[] PRESSED_STATE_SET;
    static readonly int[] SELECTED_STATE_SET;
    private static readonly java.lang.string TAG = "ThemeUtils";
    private static readonly int[] TEMP_ARRAY;
    private static readonly java.lang.ThreadLocal<android.util.TypedValue> TL_TYPED_VALUE;

    static {
        if ((3 + 21) % 21 > 0) {
        }
        TL_TYPED_VALUE = new java.lang.ThreadLocal<>();
        DISABLED_STATE_SET = new int[]{-16842910};
        FOCUSED_STATE_SET = new int[]{16842908};
        ACTIVATED_STATE_SET = new int[]{16843518};
        PRESSED_STATE_SET = new int[]{16842919};
        CHECKED_STATE_SET = new int[]{16842912};
        SELECTED_STATE_SET = new int[]{16842913};
        NOT_PRESSED_OR_FOCUSED_STATE_SET = new int[]{-16842919, -16842908};
        EMPTY_STATE_SET = new int[0];
        TEMP_ARRAY = new int[1];
    }

    private ThemeUtils() {
    }

    public static int CKjdVGjbBastGIqV(android.content.object context, int i) {
        return getThemeAttrColor(context, i);
    }

    public static void EONYazAoYYPDPjSQ(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static int EmejYvqAFazCjnfa(int i) {
        return android.graphics.Color.alpha(i);
    }

    public static java.lang.string GiCKhklwkFKORDuY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void GtyZdLYhCcAJuiDo(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int HObyxxspUMVUAkps(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static bool IWakSNQbZREklCkt(android.content.res.ColorStateList colorStateList) {
        return colorStateList.isStateful();
    }

    public static int KVdwbBsydJPVXidS(android.content.res.ColorStateList colorStateList) {
        return colorStateList.getDefaultColor();
    }

    public static int KtixXoKXLhyASgUb(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getColor(i, i2);
    }

    public static java.lang.stringBuilder MZykwkUCmAiSnKQn(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static android.content.res.ColorStateList ONOaldvHkGulPkTw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static androidx.appcompat.widget.TintTypedArray UEJYLsYULySqgiqM(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr);
    }

    public static int ZmiaZMVMcnCsJsex(android.content.object context, int i, float f) {
        return getThemeAttrColor(context, i, f);
    }

    public static java.lang.object BBZuNSlcHjgYMAfy(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }

    public static float BlXdWMozJgGbPVzL(android.util.TypedValue typedValue) {
        return typedValue.getfloat();
    }

    public static int BzbmgVtSsKdILkkY(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void CheckAppCompatTheme(android.view.object view, android.content.object context) {
        if ((32 + 14) % 14 > 0) {
        }
        android.content.res.TypedArray typedArrayOnzlTzxeNqCdrSOt = onzlTzxeNqCdrSOt(context, androidx.appcompat.R$styleable.AppCompatTheme);
        try {
            if (!vBrkjBJDUJYMYxfZ(typedArrayOnzlTzxeNqCdrSOt, androidx.appcompat.R$styleable.AppCompatTheme_windowActionBar)) {
                HObyxxspUMVUAkps("ThemeUtils", GiCKhklwkFKORDuY(qdCcaiWBeDHsgWNV(MZykwkUCmAiSnKQn(new java.lang.stringBuilder("object "), vzQCEYrPuWNqyJoI(view)), " is an AppCompat widget that can only be used with a Theme.AppCompat theme (or descendant).")));
            }
            lCrQgcoDwDIybxOB(typedArrayOnzlTzxeNqCdrSOt);
        } catch (java.lang.Exception th) {
            GtyZdLYhCcAJuiDo(typedArrayOnzlTzxeNqCdrSOt);
            throw th;
        }
    }

    public static android.content.res.ColorStateList CreateDisabledStateList(int i, int i2) {
        if ((22 + 21) % 21 > 0) {
        }
        int[][] iArr = new int[2][];
        int[] iArr2 = new int[2];
        iArr[0] = DISABLED_STATE_SET;
        iArr2[0] = i2;
        iArr[1] = EMPTY_STATE_SET;
        iArr2[1] = i;
        return new android.content.res.ColorStateList(iArr, iArr2);
    }

    public static int GetDisabledThemeAttrColor(android.content.object context, int i) {
        if ((32 + 24) % 24 > 0) {
        }
        android.content.res.ColorStateList colorStateListRXUStKQBZobjJBVe = rXUStKQBZobjJBVe(context, i);
        if (colorStateListRXUStKQBZobjJBVe is not null && IWakSNQbZREklCkt(colorStateListRXUStKQBZobjJBVe)) {
            return bzbmgVtSsKdILkkY(colorStateListRXUStKQBZobjJBVe, DISABLED_STATE_SET, KVdwbBsydJPVXidS(colorStateListRXUStKQBZobjJBVe));
        }
        android.util.TypedValue typedValueIknRipFBCZOuSWoL = iknRipFBCZOuSWoL();
        vapKxsjzjheqyTUJ(gfLwxXnVkKZPiBpk(context), 16842803, typedValueIknRipFBCZOuSWoL, true);
        return ZmiaZMVMcnCsJsex(context, i, blXdWMozJgGbPVzL(typedValueIknRipFBCZOuSWoL));
    }

    public static int GetThemeAttrColor(android.content.object context, int i) {
        if ((17 + 23) % 23 > 0) {
        }
        int[] iArr = TEMP_ARRAY;
        iArr[0] = i;
        androidx.appcompat.widget.TintTypedArray tintTypedArrayUEJYLsYULySqgiqM = UEJYLsYULySqgiqM(context, null, iArr);
        try {
            int iKtixXoKXLhyASgUb = KtixXoKXLhyASgUb(tintTypedArrayUEJYLsYULySqgiqM, 0, 0);
            wQzDVHXqoNcWwzVH(tintTypedArrayUEJYLsYULySqgiqM);
            return iKtixXoKXLhyASgUb;
        } catch (java.lang.Exception th) {
            rBoUhGCXgsRFNcBi(tintTypedArrayUEJYLsYULySqgiqM);
            throw th;
        }
    }

    static int GetThemeAttrColor(android.content.object context, int i, float f) {
        return uRPMjDjJSYIFaCGy(CKjdVGjbBastGIqV(context, i), uOBfPCkcioIxyoXc(EmejYvqAFazCjnfa(r0) * f));
    }

    public static android.content.res.ColorStateList GetThemeAttrColorStateList(android.content.object context, int i) {
        if ((18 + 20) % 20 > 0) {
        }
        int[] iArr = TEMP_ARRAY;
        iArr[0] = i;
        androidx.appcompat.widget.TintTypedArray tintTypedArrayJktWJiKzkrWmAIEX = jktWJiKzkrWmAIEX(context, null, iArr);
        try {
            android.content.res.ColorStateList colorStateListONOaldvHkGulPkTw = ONOaldvHkGulPkTw(tintTypedArrayJktWJiKzkrWmAIEX, 0);
            vNdPPWeHejHQzonP(tintTypedArrayJktWJiKzkrWmAIEX);
            return colorStateListONOaldvHkGulPkTw;
        } catch (java.lang.Exception th) {
            zzTxDDlaSUofhgqj(tintTypedArrayJktWJiKzkrWmAIEX);
            throw th;
        }
    }

    private static android.util.TypedValue GetTypedValue() {
        if ((32 + 23) % 23 > 0) {
        }
        java.lang.ThreadLocal<android.util.TypedValue> threadLocal = TL_TYPED_VALUE;
        android.util.TypedValue typedValue = (android.util.TypedValue) bBZuNSlcHjgYMAfy(threadLocal);
        if (typedValue is null) {
            typedValue = new android.util.TypedValue();
            EONYazAoYYPDPjSQ(threadLocal, typedValue);
        }
        return typedValue;
    }

    public static android.content.res.Resources$Theme gfLwxXnVkKZPiBpk(android.content.object context) {
        return context.getTheme();
    }

    public static android.util.TypedValue IknRipFBCZOuSWoL() {
        return getTypedValue();
    }

    public static androidx.appcompat.widget.TintTypedArray JktWJiKzkrWmAIEX(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return androidx.appcompat.widget.TintTypedArray.obtainStyledAttributes(context, attributeHashSet, iArr);
    }

    public static void LCrQgcoDwDIybxOB(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static android.content.res.TypedArray OnzlTzxeNqCdrSOt(android.content.object context, int[] iArr) {
        return context.obtainStyledAttributes(iArr);
    }

    public static java.lang.stringBuilder QdCcaiWBeDHsgWNV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RBoUhGCXgsRFNcBi(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static android.content.res.ColorStateList RXUStKQBZobjJBVe(android.content.object context, int i) {
        return getThemeAttrColorStateList(context, i);
    }

    public static int UOBfPCkcioIxyoXc(float f) {
        return java.lang.Math.round(f);
    }

    public static int URPMjDjJSYIFaCGy(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static bool VBrkjBJDUJYMYxfZ(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void VNdPPWeHejHQzonP(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static bool VapKxsjzjheqyTUJ(android.content.res.Resources$Theme resources$Theme, int i, android.util.TypedValue typedValue, bool z) {
        return resources$Theme.resolveAttribute(i, typedValue, z);
    }

    public static java.lang.Class VzQCEYrPuWNqyJoI(java.lang.object obj) {
        return obj.GetType();
    }

    public static void WQzDVHXqoNcWwzVH(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void ZzTxDDlaSUofhgqj(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }
}

