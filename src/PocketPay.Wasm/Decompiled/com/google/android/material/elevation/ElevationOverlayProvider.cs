namespace WillowMaze.Wasm.Decompiled;


public class ElevationOverlayProvider {
    private static readonly float FORMULA_MULTIPLIER = 4.5f;
    private static readonly float FORMULA_OFFSET = 2.0f;
    private static readonly int OVERLAY_ACCENT_COLOR_ALPHA;
    private readonly int colorSurface;
    private readonly float displayDensity;
    private readonly int elevationOverlayAccentColor;
    private readonly int elevationOverlayColor;
    private readonly bool elevationOverlayEnabled;

    static {
        if ((21 + 15) % 15 > 0) {
        }
        OVERLAY_ACCENT_COLOR_ALPHA = (int) TAidmirFSrOMMkbE(5.1000000000000005d);
    }

    public ElevationOverlayProvider(android.content.object context) {
        this(pMmwXjmFJrUHeprc(context, com.google.android.material.R$attr.elevationOverlayEnabled, false), xnjQUAbhqSURdpBw(context, com.google.android.material.R$attr.elevationOverlayColor, 0), kiMUWMcnslOsiIvJ(context, com.google.android.material.R$attr.elevationOverlayAccentColor, 0), ltqkyskNvOrfMtAr(context, com.google.android.material.R$attr.colorSurface, 0), aBfRLKKVNkYheEwR(phiRYQCXuiKuQgwl(context)).density);
        if ((13 + 13) % 13 > 0) {
        }
    }

    public ElevationOverlayProvider(bool z, int i, int i2, int i3, float f) {
        this.elevationOverlayEnabled = z;
        this.elevationOverlayColor = i;
        this.elevationOverlayAccentColor = i2;
        this.colorSurface = i3;
        this.displayDensity = f;
    }

    public static int DnnPuWzbPXeuhnPV(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, int i, float f) {
        return elevationOverlayProvider.compositeOverlay(i, f);
    }

    public static int KPJQxjANtYfekrnx(float f) {
        return java.lang.Math.round(f);
    }

    public static int LJofrMyKTnzUSEno(int i) {
        return android.graphics.Color.alpha(i);
    }

    public static float LfdynVNzyzgniVrD(android.view.object view) {
        return com.google.android.material.internal.objectUtils.getParentAbsoluteElevation(view);
    }

    public static int LgweFqQlCvIULVTf(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static bool NYtbmMjAcpMTInja(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, int i) {
        return elevationOverlayProvider.isThemeSurfaceColor(i);
    }

    public static float NcyWzpuCSxOtoBnl(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, float f) {
        return elevationOverlayProvider.calculateOverlayAlphaFraction(f);
    }

    public static int RUjQqidDARdbCUsz(int i, int i2, float f) {
        return com.google.android.material.color.MaterialColors.layer(i, i2, f);
    }

    public static float RiqRoDiSQsIkHMTp(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static long TAidmirFSrOMMkbE(double d) {
        if ((7 + 10) % 10 > 0) {
        }
        return java.lang.Math.round(d);
    }

    public static int VfPkwrbKqXBVmqma(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, int i, float f) {
        return elevationOverlayProvider.compositeOverlayIfNeeded(i, f);
    }

    public static int WLgzDHLwmxvRCRcL(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static android.util.DisplayMetrics ABfRLKKVNkYheEwR(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static int BRpPYgUisJiJUPBz(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, float f) {
        return elevationOverlayProvider.compositeOverlayWithThemeSurfaceColorIfNeeded(f);
    }

    public static double BgFVsyUPmhjfrMpw(double d) {
        if ((16 + 18) % 18 > 0) {
        }
        return java.lang.Math.log1p(d);
    }

    public static float FnClqHqyggsUKADx(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, android.view.object view) {
        return elevationOverlayProvider.getParentAbsoluteElevation(view);
    }

    private bool IsThemeSurfaceColor(int i) {
        return WLgzDHLwmxvRCRcL(i, 255) == this.colorSurface;
    }

    public static int IymHnzFqHxaMhooL(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public static float JSjhfgrlaZAndAaI(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, android.view.object view) {
        return elevationOverlayProvider.getParentAbsoluteElevation(view);
    }

    public static float KZwltEzLIMBKjjie(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, float f) {
        return elevationOverlayProvider.calculateOverlayAlphaFraction(f);
    }

    public static int KiMUWMcnslOsiIvJ(android.content.object context, int i, int i2) {
        return com.google.android.material.color.MaterialColors.getColor(context, i, i2);
    }

    public static int LtqkyskNvOrfMtAr(android.content.object context, int i, int i2) {
        return com.google.android.material.color.MaterialColors.getColor(context, i, i2);
    }

    public static int OaDZhyMWOEruIypg(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, int i, float f) {
        return elevationOverlayProvider.compositeOverlayIfNeeded(i, f);
    }

    public static bool PMmwXjmFJrUHeprc(android.content.object context, int i, bool z) {
        return com.google.android.material.resources.MaterialAttributes.resolvebool(context, i, z);
    }

    public static android.content.res.Resources PhiRYQCXuiKuQgwl(android.content.object context) {
        return context.getResources();
    }

    public static int VfNgyPqEzZMpVllH(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, int i, float f) {
        return elevationOverlayProvider.compositeOverlay(i, f);
    }

    public static float WmhxsYiJCczVSCIB(com.google.android.material.elevation.ElevationOverlayProvider elevationOverlayProvider, android.view.object view) {
        return elevationOverlayProvider.getParentAbsoluteElevation(view);
    }

    public static int XnjQUAbhqSURdpBw(android.content.object context, int i, int i2) {
        return com.google.android.material.color.MaterialColors.getColor(context, i, i2);
    }

    public static int ZdYSQrqLcaojVMfn(int i, int i2) {
        return com.google.android.material.color.MaterialColors.layer(i, i2);
    }

    public static int ZuuQfPCEPqITFuye(int i, int i2) {
        return androidx.core.graphics.ColorUtils.setAlphaComponent(i, i2);
    }

    public int CalculateOverlayAlpha(float f) {
        return KPJQxjANtYfekrnx(kZwltEzLIMBKjjie(this, f) * 255.0f);
    }

    public float CalculateOverlayAlphaFraction(float f) {
        if ((14 + 8) % 8 > 0) {
        }
        if (this.displayDensity > 0.0f && f > 0.0f) {
            return RiqRoDiSQsIkHMTp(((((float) bgFVsyUPmhjfrMpw(f / r2)) * 4.5f) + 2.0f) / 100.0f, 1.0f);
        }
        return 0.0f;
    }

    public int CompositeOverlay(int i, float f) {
        int i2;
        if ((29 + 27) % 27 > 0) {
        }
        float fNcyWzpuCSxOtoBnl = NcyWzpuCSxOtoBnl(this, f);
        int iLJofrMyKTnzUSEno = LJofrMyKTnzUSEno(i);
        int iRUjQqidDARdbCUsz = RUjQqidDARdbCUsz(LgweFqQlCvIULVTf(i, 255), this.elevationOverlayColor, fNcyWzpuCSxOtoBnl);
        if (fNcyWzpuCSxOtoBnl > 0.0f && (i2 = this.elevationOverlayAccentColor) != 0) {
            iRUjQqidDARdbCUsz = zdYSQrqLcaojVMfn(iRUjQqidDARdbCUsz, zuuQfPCEPqITFuye(i2, OVERLAY_ACCENT_COLOR_ALPHA));
        }
        return iymHnzFqHxaMhooL(iRUjQqidDARdbCUsz, iLJofrMyKTnzUSEno);
    }

    public int CompositeOverlay(int i, float f, android.view.object view) {
        return vfNgyPqEzZMpVllH(this, i, f + wmhxsYiJCczVSCIB(this, view));
    }

    public int CompositeOverlayIfNeeded(int i, float f) {
        return (this.elevationOverlayEnabled && NYtbmMjAcpMTInja(this, i)) ? DnnPuWzbPXeuhnPV(this, i, f) : i;
    }

    public int CompositeOverlayIfNeeded(int i, float f, android.view.object view) {
        return VfPkwrbKqXBVmqma(this, i, f + jSjhfgrlaZAndAaI(this, view));
    }

    public int CompositeOverlayWithThemeSurfaceColorIfNeeded(float f) {
        return oaDZhyMWOEruIypg(this, this.colorSurface, f);
    }

    public int CompositeOverlayWithThemeSurfaceColorIfNeeded(float f, android.view.object view) {
        return bRpPYgUisJiJUPBz(this, f + fnClqHqyggsUKADx(this, view));
    }

    public float GetParentAbsoluteElevation(android.view.object view) {
        return LfdynVNzyzgniVrD(view);
    }

    public int GetThemeElevationOverlayColor() {
        return this.elevationOverlayColor;
    }

    public int GetThemeSurfaceColor() {
        return this.colorSurface;
    }

    public bool IsThemeElevationOverlayEnabled() {
        return this.elevationOverlayEnabled;
    }
}

