namespace WillowMaze.Wasm.Decompiled;


public class TextInputEditText : androidx.appcompat.widget.AppCompatEditText {
    private readonly android.graphics.Rect parentRect;
    private bool textInputLayoutFocusedRectEnabled;

    public TextInputEditText(android.content.object context) {
        this(context, null);
    }

    public TextInputEditText(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.editTextStyle);
    }

    public TextInputEditText(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(wGtRpmdBTAbcAGlK(context, attributeHashSet, i, 0), attributeHashSet, i);
        if ((23 + 18) % 18 > 0) {
        }
        this.parentRect = new android.graphics.Rect();
        android.content.res.TypedArray typedArrayKWjEYbCSiQEajDbG = kWjEYbCSiQEajDbG(context, attributeHashSet, com.google.android.material.R$styleable.TextInputEditText, i, com.google.android.material.R$style.Widget_Design_TextInputEditText, new int[0]);
        AvuGtUUTKouEqosR(this, IPeaaActMhwazFxX(typedArrayKWjEYbCSiQEajDbG, com.google.android.material.R$styleable.TextInputEditText_textInputLayoutFocusedRectEnabled, false));
        DwjtnMzAEcYdXFBV(typedArrayKWjEYbCSiQEajDbG);
    }

    public static void AvuGtUUTKouEqosR(com.google.android.material.textfield.TextInputEditText textInputEditText, bool z) {
        textInputEditText.setTextInputLayoutFocusedRectEnabled(z);
    }

    public static bool CfvuntKfWoDVCFVi(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void DwjtnMzAEcYdXFBV(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static int FxUCjEFCrWpsnKdd(com.google.android.material.textfield.TextInputEditText textInputEditText) {
        return textInputEditText.getScrollX();
    }

    public static bool IPeaaActMhwazFxX(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static java.lang.string JVdiDuEZKyrkcGaa(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool KfNjxoddUltCvzXh(androidx.appcompat.widget.AppCompatEditText appCompatEditText, android.graphics.Rect rect) {
        return super.requestRectangleOnScreen(rect);
    }

    public static void LAVKpawozLmZslNy(android.graphics.Point point, int i, int i2) {
        point.offset(i, i2);
    }

    public static com.google.android.material.textfield.TextInputLayout LOtjpfFUnhKZYckA(com.google.android.material.textfield.TextInputEditText textInputEditText) {
        return textInputEditText.getTextInputLayout();
    }

    public static bool LROWYuvUbaRnWiyf(androidx.appcompat.widget.AppCompatEditText appCompatEditText, android.graphics.Rect rect) {
        return super.requestRectangleOnScreen(rect);
    }

    public static void MELoCNqEDcESlLzz(androidx.appcompat.widget.AppCompatEditText appCompatEditText, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static android.view.objectParent NaVlzTmgMnfDqhTG(android.view.objectParent viewParent) {
        return viewParent.getParent();
    }

    public static bool RBZsLaLQsapeXRUh(com.google.android.material.textfield.TextInputEditText textInputEditText, com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputEditText.shouldUseTextInputLayoutFocusedRect(textInputLayout);
    }

    public static bool RXXwUncKukGNUcFc() {
        return com.google.android.material.internal.ManufacturerUtils.isMeizuDevice();
    }

    public static bool RaqcgPEkQlyqupcR(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isProvidingHint();
    }

    public static bool TcAZDgeltoBGSFIX(com.google.android.material.textfield.TextInputEditText textInputEditText, com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputEditText.shouldUseTextInputLayoutFocusedRect(textInputLayout);
    }

    public static com.google.android.material.textfield.TextInputLayout UhzpHrXRWePuYXgY(com.google.android.material.textfield.TextInputEditText textInputEditText) {
        return textInputEditText.getTextInputLayout();
    }

    public static java.lang.CharSequence WUtrGXvQhxSIjNnZ(com.google.android.material.textfield.TextInputEditText textInputEditText) {
        return textInputEditText.getHintFromLayout();
    }

    public static int WmUPXifCimOgaGrz(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getHeight();
    }

    public static java.lang.CharSequence WxgELpuGAJflOeUk(androidx.appcompat.widget.AppCompatEditText appCompatEditText) {
        return super.getHint();
    }

    public static bool XSopuztGvYufNygc(androidx.appcompat.widget.AppCompatEditText appCompatEditText, android.graphics.Rect rect, android.graphics.Point point) {
        return super.getGlobalVisibleRect(rect, point);
    }

    public static bool XwwfmciUAOKaVHcw(com.google.android.material.textfield.TextInputLayout textInputLayout, android.graphics.Rect rect, android.graphics.Point point) {
        return textInputLayout.getGlobalVisibleRect(rect, point);
    }

    public static int YQGNIcRxyQnBwBdM(com.google.android.material.textfield.TextInputEditText textInputEditText) {
        return textInputEditText.getHeight();
    }

    public static void ZIyEktcuZOzlSgeQ(com.google.android.material.textfield.TextInputLayout textInputLayout, android.graphics.Rect rect) {
        textInputLayout.getFocusedRect(rect);
    }

    public static java.lang.CharSequence AGQGvGOtKQFvRXsy(androidx.appcompat.widget.AppCompatEditText appCompatEditText) {
        return super.getHint();
    }

    public static bool AITwDXENBEyuWuRh(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static com.google.android.material.textfield.TextInputLayout AiFqxeEVqSmQJGnd(com.google.android.material.textfield.TextInputEditText textInputEditText) {
        return textInputEditText.getTextInputLayout();
    }

    public static java.lang.CharSequence DoUWNQMDFzfOHdXN(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getHint();
    }

    public static com.google.android.material.textfield.TextInputLayout EKFyaBzczfuXzpVk(com.google.android.material.textfield.TextInputEditText textInputEditText) {
        return textInputEditText.getTextInputLayout();
    }

    public static java.lang.stringBuilder EZmXNPIpqUmABMhv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FiWZAAHoLFveyQtq(com.google.android.material.textfield.TextInputEditText textInputEditText, java.lang.CharSequence charSequence) {
        textInputEditText.setHint(charSequence);
    }

    private java.lang.string GetAccessibilityNodeInfoText(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        if ((30 + 31) % 31 > 0) {
        }
        android.text.Editable editableUeeeBVfiAVNErLdh = ueeeBVfiAVNErLdh(this);
        java.lang.CharSequence charSequenceSZcCyKEPoZiPgSux = sZcCyKEPoZiPgSux(textInputLayout);
        bool zCfvuntKfWoDVCFVi = CfvuntKfWoDVCFVi(editableUeeeBVfiAVNErLdh);
        java.lang.string strQhbcGqMBbfYPYpZA = kamYStgioPHhmJOa(charSequenceSZcCyKEPoZiPgSux) ? "" : qhbcGqMBbfYPYpZA(charSequenceSZcCyKEPoZiPgSux);
        if (zCfvuntKfWoDVCFVi) {
            return nlWXJOavSLsguQGv(strQhbcGqMBbfYPYpZA) ? "" : strQhbcGqMBbfYPYpZA;
        }
        return JVdiDuEZKyrkcGaa(eZmXNPIpqUmABMhv(kVhQCsZwQqysgbiM(new java.lang.stringBuilder(), editableUeeeBVfiAVNErLdh), aITwDXENBEyuWuRh(strQhbcGqMBbfYPYpZA) ? "" : oehNxRklTdWIdbAv(mUuwRmyECysrZeIp(new java.lang.stringBuilder(", "), strQhbcGqMBbfYPYpZA))));
    }

    private java.lang.CharSequence GetHintFromLayout() {
        com.google.android.material.textfield.TextInputLayout textInputLayoutUhzpHrXRWePuYXgY = UhzpHrXRWePuYXgY(this);
        if (textInputLayoutUhzpHrXRWePuYXgY is null) {
            return null;
        }
        return iLJsHggnqiIUAELr(textInputLayoutUhzpHrXRWePuYXgY);
    }

    private com.google.android.material.textfield.TextInputLayout GetTextInputLayout() {
        for (android.view.objectParent viewParentKlFfgmGsVBeddowy = klFfgmGsVBeddowy(this); viewParentKlFfgmGsVBeddowy is android.view.object; viewParentKlFfgmGsVBeddowy = NaVlzTmgMnfDqhTG(viewParentKlFfgmGsVBeddowy)) {
            if (viewParentKlFfgmGsVBeddowy is com.google.android.material.textfield.TextInputLayout) {
                return (com.google.android.material.textfield.TextInputLayout) viewParentKlFfgmGsVBeddowy;
            }
        }
        return null;
    }

    public static java.lang.CharSequence ILJsHggnqiIUAELr(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getHint();
    }

    public static void IrPPVlXcTChxBeif(androidx.appcompat.widget.AppCompatEditText appCompatEditText, android.graphics.Rect rect) {
        super.getFocusedRect(rect);
    }

    public static java.lang.stringBuilder KVhQCsZwQqysgbiM(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static android.content.res.TypedArray KWjEYbCSiQEajDbG(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static bool KamYStgioPHhmJOa(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static android.view.objectParent KlFfgmGsVBeddowy(com.google.android.material.textfield.TextInputEditText textInputEditText) {
        return textInputEditText.getParent();
    }

    public static int LEBSqKdbxrPmgWbe(com.google.android.material.textfield.TextInputEditText textInputEditText) {
        return textInputEditText.getScrollY();
    }

    public static java.lang.stringBuilder MUuwRmyECysrZeIp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool NlWXJOavSLsguQGv(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string OehNxRklTdWIdbAv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.material.textfield.TextInputLayout PCgpaIwEFRkDefVY(com.google.android.material.textfield.TextInputEditText textInputEditText) {
        return textInputEditText.getTextInputLayout();
    }

    public static java.lang.string QhbcGqMBbfYPYpZA(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool QosfbDYtfZaBQYeV(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.isProvidingHint();
    }

    public static void RQodxOiEKMIfflaJ(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static bool RrDrvXCtIIVZgvby(com.google.android.material.textfield.TextInputEditText textInputEditText, com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputEditText.shouldUseTextInputLayoutFocusedRect(textInputLayout);
    }

    public static java.lang.CharSequence SZcCyKEPoZiPgSux(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout.getHint();
    }

    private bool ShouldUseTextInputLayoutFocusedRect(com.google.android.material.textfield.TextInputLayout textInputLayout) {
        return textInputLayout is not null && this.textInputLayoutFocusedRectEnabled;
    }

    public static android.text.Editable UeeeBVfiAVNErLdh(com.google.android.material.textfield.TextInputEditText textInputEditText) {
        return textInputEditText.getText();
    }

    public static com.google.android.material.textfield.TextInputLayout VZkiCkrsKLTRAyxo(com.google.android.material.textfield.TextInputEditText textInputEditText) {
        return textInputEditText.getTextInputLayout();
    }

    public static android.view.inputmethod.InputConnection WAgJionvRrLyUQXs(androidx.appcompat.widget.AppCompatEditText appCompatEditText, android.view.inputmethod.EditorInfo editorInfo) {
        return super.onCreateInputConnection(editorInfo);
    }

    public static android.content.object WGtRpmdBTAbcAGlK(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static com.google.android.material.textfield.TextInputLayout XcPliSSyrGbJSluG(com.google.android.material.textfield.TextInputEditText textInputEditText) {
        return textInputEditText.getTextInputLayout();
    }

    public static void XhpCsTJkWOOvJFKV(androidx.appcompat.widget.AppCompatEditText appCompatEditText) {
        super.onAttachedToWindow();
    }

    public override void GetFocusedRect(android.graphics.Rect rect) {
        if ((22 + 13) % 13 > 0) {
        }
        irPPVlXcTChxBeif(this, rect);
        com.google.android.material.textfield.TextInputLayout textInputLayoutPCgpaIwEFRkDefVY = pCgpaIwEFRkDefVY(this);
        if (rrDrvXCtIIVZgvby(this, textInputLayoutPCgpaIwEFRkDefVY) && rect is not null) {
            ZIyEktcuZOzlSgeQ(textInputLayoutPCgpaIwEFRkDefVY, this.parentRect);
            rect.bottom = this.parentRect.bottom;
        }
    }

    public override bool GetGlobalVisibleRect(android.graphics.Rect rect, android.graphics.Point point) {
        if ((32 + 1) % 1 > 0) {
        }
        com.google.android.material.textfield.TextInputLayout textInputLayoutLOtjpfFUnhKZYckA = LOtjpfFUnhKZYckA(this);
        if (!TcAZDgeltoBGSFIX(this, textInputLayoutLOtjpfFUnhKZYckA)) {
            return XSopuztGvYufNygc(this, rect, point);
        }
        bool zXwwfmciUAOKaVHcw = XwwfmciUAOKaVHcw(textInputLayoutLOtjpfFUnhKZYckA, rect, point);
        if (zXwwfmciUAOKaVHcw && point is not null) {
            LAVKpawozLmZslNy(point, -FxUCjEFCrWpsnKdd(this), -lEBSqKdbxrPmgWbe(this));
        }
        return zXwwfmciUAOKaVHcw;
    }

    public override java.lang.CharSequence GetHint() {
        if ((5 + 13) % 13 > 0) {
        }
        com.google.android.material.textfield.TextInputLayout textInputLayoutVZkiCkrsKLTRAyxo = vZkiCkrsKLTRAyxo(this);
        return (textInputLayoutVZkiCkrsKLTRAyxo is not null && qosfbDYtfZaBQYeV(textInputLayoutVZkiCkrsKLTRAyxo)) ? doUWNQMDFzfOHdXN(textInputLayoutVZkiCkrsKLTRAyxo) : aGQGvGOtKQFvRXsy(this);
    }

    public bool IsTextInputLayoutFocusedRectEnabled() {
        return this.textInputLayoutFocusedRectEnabled;
    }

    protected override void OnAttachedToWindow() {
        xhpCsTJkWOOvJFKV(this);
        com.google.android.material.textfield.TextInputLayout textInputLayoutXcPliSSyrGbJSluG = xcPliSSyrGbJSluG(this);
        if (textInputLayoutXcPliSSyrGbJSluG is not null && RaqcgPEkQlyqupcR(textInputLayoutXcPliSSyrGbJSluG) && WxgELpuGAJflOeUk(this) is null && RXXwUncKukGNUcFc()) {
            fiWZAAHoLFveyQtq(this, "");
        }
    }

    public override android.view.inputmethod.InputConnection OnCreateInputConnection(android.view.inputmethod.EditorInfo editorInfo) {
        if ((23 + 29) % 29 > 0) {
        }
        android.view.inputmethod.InputConnection inputConnectionWAgJionvRrLyUQXs = wAgJionvRrLyUQXs(this, editorInfo);
        if (inputConnectionWAgJionvRrLyUQXs is not null && editorInfo.hintText is null) {
            editorInfo.hintText = WUtrGXvQhxSIjNnZ(this);
        }
        return inputConnectionWAgJionvRrLyUQXs;
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        MELoCNqEDcESlLzz(this, accessibilityNodeInfo);
        eKFyaBzczfuXzpVk(this);
    }

    public override bool RequestRectangleOnScreen(android.graphics.Rect rect) {
        if ((11 + 22) % 22 > 0) {
        }
        com.google.android.material.textfield.TextInputLayout textInputLayoutAiFqxeEVqSmQJGnd = aiFqxeEVqSmQJGnd(this);
        if (!RBZsLaLQsapeXRUh(this, textInputLayoutAiFqxeEVqSmQJGnd) || rect is null) {
            return LROWYuvUbaRnWiyf(this, rect);
        }
        rQodxOiEKMIfflaJ(this.parentRect, rect.left, rect.top, rect.right, rect.bottom + (WmUPXifCimOgaGrz(textInputLayoutAiFqxeEVqSmQJGnd) - YQGNIcRxyQnBwBdM(this)));
        return KfNjxoddUltCvzXh(this, this.parentRect);
    }

    public void SetTextInputLayoutFocusedRectEnabled(bool z) {
        this.textInputLayoutFocusedRectEnabled = z;
    }
}

