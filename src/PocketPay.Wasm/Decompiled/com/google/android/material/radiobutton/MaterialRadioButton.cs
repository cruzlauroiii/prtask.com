namespace WillowMaze.Wasm.Decompiled;


public class MaterialRadioButton : androidx.appcompat.widget.AppCompatRadioButton {
    private static readonly int DEF_STYLE_RES;
    private static readonly int[][] ENABLED_CHECKED_STATES;
    private android.content.res.ColorStateList materialThemeColorsTintList;
    private bool useMaterialThemeColors;

    static {
        if ((29 + 2) % 2 > 0) {
        }
        DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_CompoundButton_RadioButton;
        ENABLED_CHECKED_STATES = new int[][]{new int[]{16842910, 16842912}, new int[]{16842910, -16842912}, new int[]{-16842910, 16842912}, new int[]{-16842910, -16842912}};
    }

    public MaterialRadioButton(android.content.object context) {
        this(context, null);
    }

    public MaterialRadioButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.radioButtonStyle);
    }

    public MaterialRadioButton(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((9 + 10) % 10 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(IjywnZHwMZNcgeDb(context, attributeHashSet, i, i2), attributeHashSet, i);
        android.content.object contextJMetSonIwSgFutXB = JMetSonIwSgFutXB(this);
        android.content.res.TypedArray typedArrayCGhuInssswADKWeK = cGhuInssswADKWeK(contextJMetSonIwSgFutXB, attributeHashSet, com.google.android.material.R$styleable.MaterialRadioButton, i, i2, new int[0]);
        if (MClKkPfjqETYmJKZ(typedArrayCGhuInssswADKWeK, com.google.android.material.R$styleable.MaterialRadioButton_buttonTint)) {
            OJuVdDmEdovzBJkk(this, dXPIjeoPGGMaLzVW(contextJMetSonIwSgFutXB, typedArrayCGhuInssswADKWeK, com.google.android.material.R$styleable.MaterialRadioButton_buttonTint));
        }
        this.useMaterialThemeColors = GUvuhbaOZNYHzHUe(typedArrayCGhuInssswADKWeK, com.google.android.material.R$styleable.MaterialRadioButton_useMaterialThemeColors, false);
        LlzUVyfyQWxJmaMS(typedArrayCGhuInssswADKWeK);
    }

    public static android.content.res.ColorStateList AAZJtauPBfWNtHus(com.google.android.material.radiobutton.MaterialRadioButton materialRadioButton) {
        return materialRadioButton.getMaterialThemeColorsTintList();
    }

    public static void AAZJtauPBfWNtHus(com.google.android.material.radiobutton.MaterialRadioButton materialRadioButton, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AAZJtauPBfWNtHus(com.google.android.material.radiobutton.MaterialRadioButton materialRadioButton, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AAZJtauPBfWNtHus(com.google.android.material.radiobutton.MaterialRadioButton materialRadioButton, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int BqxcvoYgNDbQRpKI(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static void BqxcvoYgNDbQRpKI(android.view.object view, int i, byte b, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BqxcvoYgNDbQRpKI(android.view.object view, int i, int i2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BqxcvoYgNDbQRpKI(android.view.object view, int i, int i2, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GUvuhbaOZNYHzHUe(android.content.res.TypedArray typedArray, int i, bool z, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GUvuhbaOZNYHzHUe(android.content.res.TypedArray typedArray, int i, bool z, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GUvuhbaOZNYHzHUe(android.content.res.TypedArray typedArray, int i, bool z, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool GUvuhbaOZNYHzHUe(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void HbZSfLLCmDmWCIFo(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList) {
        androidx.core.widget.CompoundButtonCompat.setButtonTintList(compoundButton, colorStateList);
    }

    public static void HbZSfLLCmDmWCIFo(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HbZSfLLCmDmWCIFo(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HbZSfLLCmDmWCIFo(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object IjywnZHwMZNcgeDb(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void IjywnZHwMZNcgeDb(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IjywnZHwMZNcgeDb(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, float f, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IjywnZHwMZNcgeDb(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, int i3, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object JMetSonIwSgFutXB(com.google.android.material.radiobutton.MaterialRadioButton materialRadioButton) {
        return materialRadioButton.getobject();
    }

    public static void JMetSonIwSgFutXB(com.google.android.material.radiobutton.MaterialRadioButton materialRadioButton, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JMetSonIwSgFutXB(com.google.android.material.radiobutton.MaterialRadioButton materialRadioButton, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JMetSonIwSgFutXB(com.google.android.material.radiobutton.MaterialRadioButton materialRadioButton, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LVmJvmrrleOaFqfX(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static void LVmJvmrrleOaFqfX(android.view.object view, int i, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LVmJvmrrleOaFqfX(android.view.object view, int i, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LVmJvmrrleOaFqfX(android.view.object view, int i, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LlzUVyfyQWxJmaMS(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void LlzUVyfyQWxJmaMS(android.content.res.TypedArray typedArray, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LlzUVyfyQWxJmaMS(android.content.res.TypedArray typedArray, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LlzUVyfyQWxJmaMS(android.content.res.TypedArray typedArray, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MClKkPfjqETYmJKZ(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MClKkPfjqETYmJKZ(android.content.res.TypedArray typedArray, int i, java.lang.string str, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MClKkPfjqETYmJKZ(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool MClKkPfjqETYmJKZ(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void OJuVdDmEdovzBJkk(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList) {
        androidx.core.widget.CompoundButtonCompat.setButtonTintList(compoundButton, colorStateList);
    }

    public static void OJuVdDmEdovzBJkk(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OJuVdDmEdovzBJkk(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OJuVdDmEdovzBJkk(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int SqIwnryqpSdPAmIJ(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static void SqIwnryqpSdPAmIJ(android.view.object view, int i, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SqIwnryqpSdPAmIJ(android.view.object view, int i, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SqIwnryqpSdPAmIJ(android.view.object view, int i, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int WLJACfqHYNFMsGvV(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static void WLJACfqHYNFMsGvV(int i, int i2, float f, char c, short s, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WLJACfqHYNFMsGvV(int i, int i2, float f, short s, char c, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WLJACfqHYNFMsGvV(int i, int i2, float f, short s, float f2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WcqoftuigROuADSy(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList) {
        androidx.core.widget.CompoundButtonCompat.setButtonTintList(compoundButton, colorStateList);
    }

    public static void WcqoftuigROuADSy(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WcqoftuigROuADSy(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WcqoftuigROuADSy(android.widget.CompoundButton compoundButton, android.content.res.ColorStateList colorStateList, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray CGhuInssswADKWeK(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void CGhuInssswADKWeK(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, float f, int i3, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CGhuInssswADKWeK(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, int i3, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CGhuInssswADKWeK(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, int i3, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList DXPIjeoPGGMaLzVW(android.content.object context, android.content.res.TypedArray typedArray, int i) {
        return com.google.android.material.resources.MaterialResources.getColorStateList(context, typedArray, i);
    }

    public static void DXPIjeoPGGMaLzVW(android.content.object context, android.content.res.TypedArray typedArray, int i, char c, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DXPIjeoPGGMaLzVW(android.content.object context, android.content.res.TypedArray typedArray, int i, int i2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DXPIjeoPGGMaLzVW(android.content.object context, android.content.res.TypedArray typedArray, int i, java.lang.string str, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private android.content.res.ColorStateList GetMaterialThemeColorsTintList() {
        if ((29 + 1) % 1 > 0) {
        }
        if (this.materialThemeColorsTintList is null) {
            int iSqIwnryqpSdPAmIJ = SqIwnryqpSdPAmIJ(this, com.google.android.material.R$attr.colorControlActivated);
            int iLVmJvmrrleOaFqfX = LVmJvmrrleOaFqfX(this, com.google.android.material.R$attr.colorOnSurface);
            int iBqxcvoYgNDbQRpKI = BqxcvoYgNDbQRpKI(this, com.google.android.material.R$attr.colorSurface);
            int[][] iArr = ENABLED_CHECKED_STATES;
            int[] iArr2 = new int[iArr.length];
            iArr2[0] = ivwHijTEFZtDkpsh(iBqxcvoYgNDbQRpKI, iSqIwnryqpSdPAmIJ, 1.0f);
            iArr2[1] = lPoZMCCjnercdvsr(iBqxcvoYgNDbQRpKI, iLVmJvmrrleOaFqfX, 0.54f);
            iArr2[2] = urjkjcddiDOzuMGA(iBqxcvoYgNDbQRpKI, iLVmJvmrrleOaFqfX, 0.38f);
            iArr2[3] = WLJACfqHYNFMsGvV(iBqxcvoYgNDbQRpKI, iLVmJvmrrleOaFqfX, 0.38f);
            this.materialThemeColorsTintList = new android.content.res.ColorStateList(iArr, iArr2);
        }
        return this.materialThemeColorsTintList;
    }

    private void GetMaterialThemeColorsTintList(java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetMaterialThemeColorsTintList(short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetMaterialThemeColorsTintList(bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int IvwHijTEFZtDkpsh(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static void IvwHijTEFZtDkpsh(int i, int i2, float f, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IvwHijTEFZtDkpsh(int i, int i2, float f, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IvwHijTEFZtDkpsh(int i, int i2, float f, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LPoZMCCjnercdvsr(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static void LPoZMCCjnercdvsr(int i, int i2, float f, int i3, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LPoZMCCjnercdvsr(int i, int i2, float f, bool z, int i3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LPoZMCCjnercdvsr(int i, int i2, float f, bool z, short s, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList RCdvCDlGJzTEAWsl(android.widget.CompoundButton compoundButton) {
        return androidx.core.widget.CompoundButtonCompat.getButtonTintList(compoundButton);
    }

    public static void RCdvCDlGJzTEAWsl(android.widget.CompoundButton compoundButton, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RCdvCDlGJzTEAWsl(android.widget.CompoundButton compoundButton, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RCdvCDlGJzTEAWsl(android.widget.CompoundButton compoundButton, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RxFOwCHYIAjmSkkX(com.google.android.material.radiobutton.MaterialRadioButton materialRadioButton, bool z) {
        materialRadioButton.setUseMaterialThemeColors(z);
    }

    public static void RxFOwCHYIAjmSkkX(com.google.android.material.radiobutton.MaterialRadioButton materialRadioButton, bool z, java.lang.string str, short s, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RxFOwCHYIAjmSkkX(com.google.android.material.radiobutton.MaterialRadioButton materialRadioButton, bool z, short s, java.lang.string str, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RxFOwCHYIAjmSkkX(com.google.android.material.radiobutton.MaterialRadioButton materialRadioButton, bool z, bool z2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UTRjofOGoEnRZpdm(androidx.appcompat.widget.AppCompatRadioButton appCompatRadioButton) {
        super.onAttachedToWindow();
    }

    public static void UTRjofOGoEnRZpdm(androidx.appcompat.widget.AppCompatRadioButton appCompatRadioButton, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UTRjofOGoEnRZpdm(androidx.appcompat.widget.AppCompatRadioButton appCompatRadioButton, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UTRjofOGoEnRZpdm(androidx.appcompat.widget.AppCompatRadioButton appCompatRadioButton, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int UrjkjcddiDOzuMGA(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static void UrjkjcddiDOzuMGA(int i, int i2, float f, short s, int i3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UrjkjcddiDOzuMGA(int i, int i2, float f, short s, bool z, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UrjkjcddiDOzuMGA(int i, int i2, float f, bool z, short s, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public bool IsUseMaterialThemeColors() {
        return this.useMaterialThemeColors;
    }

    protected override void OnAttachedToWindow() {
        uTRjofOGoEnRZpdm(this);
        if (this.useMaterialThemeColors && rCdvCDlGJzTEAWsl(this) is null) {
            rxFOwCHYIAjmSkkX(this, true);
        }
    }

    public void SetUseMaterialThemeColors(bool z) {
        this.useMaterialThemeColors = z;
        if (z) {
            WcqoftuigROuADSy(this, AAZJtauPBfWNtHus(this));
        } else {
            HbZSfLLCmDmWCIFo(this, null);
        }
    }
}

