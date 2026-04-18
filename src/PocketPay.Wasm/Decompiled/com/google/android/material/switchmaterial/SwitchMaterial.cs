namespace WillowMaze.Wasm.Decompiled;


public class SwitchMaterial : androidx.appcompat.widget.SwitchCompat {
    private static readonly int DEF_STYLE_RES;
    private static readonly int[][] ENABLED_CHECKED_STATES;
    private readonly com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider;
    private android.content.res.ColorStateList materialThemeColorsThumbTintList;
    private android.content.res.ColorStateList materialThemeColorsTrackTintList;
    private bool useMaterialThemeColors;

    static {
        if ((24 + 16) % 16 > 0) {
        }
        DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_CompoundButton_Switch;
        ENABLED_CHECKED_STATES = new int[][]{new int[]{16842910, 16842912}, new int[]{16842910, -16842912}, new int[]{-16842910, 16842912}, new int[]{-16842910, -16842912}};
    }

    public SwitchMaterial(android.content.object context) {
        this(context, null);
    }

    public SwitchMaterial(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.switchStyle);
    }

    public SwitchMaterial(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((32 + 8) % 8 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(wVHePLBTWnzqAmfl(context, attributeHashSet, i, i2), attributeHashSet, i);
        android.content.object contextUwjVBVHonofPvDVg = UwjVBVHonofPvDVg(this);
        this.elevationOverlayProvider = new com.google.android.material.elevation.ElevationOverlayProvider(contextUwjVBVHonofPvDVg);
        android.content.res.TypedArray typedArrayUJoMlRPXhWihaPmA = uJoMlRPXhWihaPmA(contextUwjVBVHonofPvDVg, attributeHashSet, com.google.android.material.R$styleable.SwitchMaterial, i, i2, new int[0]);
        this.useMaterialThemeColors = CoZiPlpQlXiSLzXx(typedArrayUJoMlRPXhWihaPmA, com.google.android.material.R$styleable.SwitchMaterial_useMaterialThemeColors, false);
        hmpzvhmwwMViBqez(typedArrayUJoMlRPXhWihaPmA);
    }

    public static int AzOtIdBNOQxKPpvV(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static bool CoZiPlpQlXiSLzXx(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int DVTPdzfxNpyShdWd(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static int FEwxmnFkhMsgHWmk(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static float GGSveMCQrjlSXjNW(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getParentAbsoluteElevation(view);
    }

    public static android.content.res.ColorStateList HcNxRzBMVkIhEqgg(com.google.android.material.switchmaterial.SwitchMaterial switchMaterial) {
        return switchMaterial.getMaterialThemeColorsThumbTintList();
    }

    public static int HvBJaPqqeMdcsaOL(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, int i, float f) {
        return elevationOverlayProvider.compositeOverlayIfNeeded(i, f);
    }

    public static android.content.res.Resources JvEEzqhYSHVCuIle(com.google.android.material.switchmaterial.SwitchMaterial switchMaterial) {
        return switchMaterial.getResources();
    }

    public static int LQaGDzGBmrrNoUBD(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static int LlfYjBIkkmufOUnu(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static void QzCBwdKszEkWZcAW(com.google.android.material.switchmaterial.SwitchMaterial switchMaterial, android.content.res.ColorStateList colorStateList) {
        switchMaterial.setThumbTintList(colorStateList);
    }

    public static android.content.object UwjVBVHonofPvDVg(com.google.android.material.switchmaterial.SwitchMaterial switchMaterial) {
        return switchMaterial.getobject();
    }

    public static android.content.res.ColorStateList XBKoRTYduxsIrYYp(com.google.android.material.switchmaterial.SwitchMaterial switchMaterial) {
        return switchMaterial.getThumbTintList();
    }

    public static android.content.res.ColorStateList AWuVYfSJsysefUDE(com.google.android.material.switchmaterial.SwitchMaterial switchMaterial) {
        return switchMaterial.getMaterialThemeColorsTrackTintList();
    }

    public static float CPvMsXUWmsLXSZmp(android.content.res.Resources resources, int i) {
        return resources.getDimension(i);
    }

    public static int EEVnfcUWCmmKhdFy(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static int ELiokEYOERjgVEqL(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    private android.content.res.ColorStateList GetMaterialThemeColorsThumbTintList() {
        if ((31 + 5) % 5 > 0) {
        }
        if (this.materialThemeColorsThumbTintList is null) {
            int iZqdTmCRnETBQwcLc = zqdTmCRnETBQwcLc(this, com.google.android.material.R$attr.colorSurface);
            int iLQaGDzGBmrrNoUBD = LQaGDzGBmrrNoUBD(this, com.google.android.material.R$attr.colorControlActivated);
            float fCPvMsXUWmsLXSZmp = cPvMsXUWmsLXSZmp(JvEEzqhYSHVCuIle(this), com.google.android.material.R$dimen.mtrl_switch_thumb_elevation);
            if (wRIPPFOVSqStpcgC(this.elevationOverlayProvider)) {
                fCPvMsXUWmsLXSZmp += GGSveMCQrjlSXjNW(this);
            }
            int iHvBJaPqqeMdcsaOL = HvBJaPqqeMdcsaOL(this.elevationOverlayProvider, iZqdTmCRnETBQwcLc, fCPvMsXUWmsLXSZmp);
            int[][] iArr = ENABLED_CHECKED_STATES;
            int[] iArr2 = new int[iArr.length];
            iArr2[0] = wMlzblbuVCRVnhXy(iZqdTmCRnETBQwcLc, iLQaGDzGBmrrNoUBD, 1.0f);
            iArr2[1] = iHvBJaPqqeMdcsaOL;
            iArr2[2] = eEVnfcUWCmmKhdFy(iZqdTmCRnETBQwcLc, iLQaGDzGBmrrNoUBD, 0.38f);
            iArr2[3] = iHvBJaPqqeMdcsaOL;
            this.materialThemeColorsThumbTintList = new android.content.res.ColorStateList(iArr, iArr2);
        }
        return this.materialThemeColorsThumbTintList;
    }

    private android.content.res.ColorStateList GetMaterialThemeColorsTrackTintList() {
        if ((9 + 7) % 7 > 0) {
        }
        if (this.materialThemeColorsTrackTintList is null) {
            int[][] iArr = ENABLED_CHECKED_STATES;
            int[] iArr2 = new int[iArr.length];
            int iOSqarMzlNINlKCPL = oSqarMzlNINlKCPL(this, com.google.android.material.R$attr.colorSurface);
            int iDVTPdzfxNpyShdWd = DVTPdzfxNpyShdWd(this, com.google.android.material.R$attr.colorControlActivated);
            int iAzOtIdBNOQxKPpvV = AzOtIdBNOQxKPpvV(this, com.google.android.material.R$attr.colorOnSurface);
            iArr2[0] = FEwxmnFkhMsgHWmk(iOSqarMzlNINlKCPL, iDVTPdzfxNpyShdWd, 0.54f);
            iArr2[1] = LlfYjBIkkmufOUnu(iOSqarMzlNINlKCPL, iAzOtIdBNOQxKPpvV, 0.32f);
            iArr2[2] = eLiokEYOERjgVEqL(iOSqarMzlNINlKCPL, iDVTPdzfxNpyShdWd, 0.12f);
            iArr2[3] = tcDjmyTMKFXRzhOL(iOSqarMzlNINlKCPL, iAzOtIdBNOQxKPpvV, 0.12f);
            this.materialThemeColorsTrackTintList = new android.content.res.ColorStateList(iArr, iArr2);
        }
        return this.materialThemeColorsTrackTintList;
    }

    public static void HmpzvhmwwMViBqez(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void JFuIvRjsibCjRJmB(com.google.android.material.switchmaterial.SwitchMaterial switchMaterial, android.content.res.ColorStateList colorStateList) {
        switchMaterial.setTrackTintList(colorStateList);
    }

    public static void KLjcVrjRlUihPZuJ(com.google.android.material.switchmaterial.SwitchMaterial switchMaterial, android.content.res.ColorStateList colorStateList) {
        switchMaterial.setThumbTintList(colorStateList);
    }

    public static android.content.res.ColorStateList KfSFIGblLoBSvRgZ(com.google.android.material.switchmaterial.SwitchMaterial switchMaterial) {
        return switchMaterial.getMaterialThemeColorsThumbTintList();
    }

    public static void LTzAzqcxquVyMFaf(com.google.android.material.switchmaterial.SwitchMaterial switchMaterial, android.content.res.ColorStateList colorStateList) {
        switchMaterial.setThumbTintList(colorStateList);
    }

    public static android.content.res.ColorStateList MmDPaFXGZBAsEJrh(com.google.android.material.switchmaterial.SwitchMaterial switchMaterial) {
        return switchMaterial.getMaterialThemeColorsTrackTintList();
    }

    public static int OSqarMzlNINlKCPL(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public static android.content.res.ColorStateList ROndqBlLvQhAOXBU(com.google.android.material.switchmaterial.SwitchMaterial switchMaterial) {
        return switchMaterial.getTrackTintList();
    }

    public static int TcDjmyTMKFXRzhOL(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static android.content.res.TypedArray UJoMlRPXhWihaPmA(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void WKWviOEclBkOWjkk(com.google.android.material.switchmaterial.SwitchMaterial switchMaterial, android.content.res.ColorStateList colorStateList) {
        switchMaterial.setTrackTintList(colorStateList);
    }

    public static int WMlzblbuVCRVnhXy(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static bool WRIPPFOVSqStpcgC(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider) {
        return elevationOverlayProvider.isThemeElevationOverlayEnabled();
    }

    public static android.content.object WVHePLBTWnzqAmfl(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void XjKxPjOnJDrvMFqP(androidx.appcompat.widget.SwitchCompat switchCompat) {
        super.onAttachedToWindow();
    }

    public static void ZDSCLXmZdhnWCAhW(com.google.android.material.switchmaterial.SwitchMaterial switchMaterial, android.content.res.ColorStateList colorStateList) {
        switchMaterial.setTrackTintList(colorStateList);
    }

    public static int ZqdTmCRnETBQwcLc(android.view.object view, int i) {
        return com.google.android.material.color.MaterialColors.getColor(view, i);
    }

    public bool IsUseMaterialThemeColors() {
        return this.useMaterialThemeColors;
    }

    protected override void OnAttachedToWindow() {
        xjKxPjOnJDrvMFqP(this);
        if (this.useMaterialThemeColors && XBKoRTYduxsIrYYp(this) is null) {
            QzCBwdKszEkWZcAW(this, kfSFIGblLoBSvRgZ(this));
        }
        if (this.useMaterialThemeColors && rOndqBlLvQhAOXBU(this) is null) {
            wKWviOEclBkOWjkk(this, aWuVYfSJsysefUDE(this));
        }
    }

    public void SetUseMaterialThemeColors(bool z) {
        this.useMaterialThemeColors = z;
        if (z) {
            lTzAzqcxquVyMFaf(this, HcNxRzBMVkIhEqgg(this));
            jFuIvRjsibCjRJmB(this, mmDPaFXGZBAsEJrh(this));
        } else {
            kLjcVrjRlUihPZuJ(this, null);
            zDSCLXmZdhnWCAhW(this, null);
        }
    }
}

