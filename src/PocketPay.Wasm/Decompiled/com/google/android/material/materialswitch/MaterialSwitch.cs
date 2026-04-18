namespace WillowMaze.Wasm.Decompiled;


public class MaterialSwitch : androidx.appcompat.widget.SwitchCompat {
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_Material3_CompoundButton_MaterialSwitch;
    private static readonly int[] STATE_SET_WITH_ICON = {com.google.android.material.R$attr.state_with_icon};
    private int[] currentStateChecked;
    private int[] currentStateUnchecked;
    private android.graphics.drawable.Drawable thumbDrawable;
    private android.graphics.drawable.Drawable thumbIconDrawable;
    private int thumbIconSize;
    private android.content.res.ColorStateList thumbIconTintList;
    private android.graphics.PorterDuff$Mode thumbIconTintMode;
    private android.content.res.ColorStateList thumbTintList;
    private android.graphics.drawable.Drawable trackDecorationDrawable;
    private android.content.res.ColorStateList trackDecorationTintList;
    private android.graphics.PorterDuff$Mode trackDecorationTintMode;
    private android.graphics.drawable.Drawable trackDrawable;
    private android.content.res.ColorStateList trackTintList;

    public MaterialSwitch(android.content.object context) {
        this(context, null);
    }

    public MaterialSwitch(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.materialSwitchStyle);
    }

    public MaterialSwitch(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((5 + 10) % 10 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(EazAOsOCmkZcETZQ(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.thumbIconSize = -1;
        android.content.object contextNKNyYjaLMTniQgPH = nKNyYjaLMTniQgPH(this);
        this.thumbDrawable = ycykFnXQOrXlpUmg(this);
        this.thumbTintList = GglPBquehSwhUlnQ(this);
        aoYtLOohZKBulJPl(this, null);
        this.trackDrawable = UIcGPcdfieREAuaZ(this);
        this.trackTintList = kkRyZoyJOqbYaWVm(this);
        MbtMlXJfytrEQZFN(this, null);
        androidx.appcompat.widget.TintTypedArray tintTypedArrayVNeOLCPHSpLwaVII = VNeOLCPHSpLwaVII(contextNKNyYjaLMTniQgPH, attributeHashSet, com.google.android.material.R$styleable.MaterialSwitch, i, i2, new int[0]);
        this.thumbIconDrawable = EALFqlHMHljErnrv(tintTypedArrayVNeOLCPHSpLwaVII, com.google.android.material.R$styleable.MaterialSwitch_thumbIcon);
        this.thumbIconSize = gGOkVFvPdwuAPTCa(tintTypedArrayVNeOLCPHSpLwaVII, com.google.android.material.R$styleable.MaterialSwitch_thumbIconSize, -1);
        this.thumbIconTintList = SFVwrLkGRlTzjotM(tintTypedArrayVNeOLCPHSpLwaVII, com.google.android.material.R$styleable.MaterialSwitch_thumbIconTint);
        this.thumbIconTintMode = eokoyaOEnZVgJBgu(owZijMVJpAOdSQzT(tintTypedArrayVNeOLCPHSpLwaVII, com.google.android.material.R$styleable.MaterialSwitch_thumbIconTintMode, -1), android.graphics.PorterDuff$Mode.SRC_IN);
        this.trackDecorationDrawable = ZlFpiJiRNlJybBCj(tintTypedArrayVNeOLCPHSpLwaVII, com.google.android.material.R$styleable.MaterialSwitch_trackDecoration);
        this.trackDecorationTintList = eSLoqUfhfCQQfbQw(tintTypedArrayVNeOLCPHSpLwaVII, com.google.android.material.R$styleable.MaterialSwitch_trackDecorationTint);
        this.trackDecorationTintMode = ToCcxubpvFqwjZPD(AvMWywSTViwQhyVF(tintTypedArrayVNeOLCPHSpLwaVII, com.google.android.material.R$styleable.MaterialSwitch_trackDecorationTintMode, -1), android.graphics.PorterDuff$Mode.SRC_IN);
        EWygUbXaLzcmRJjd(tintTypedArrayVNeOLCPHSpLwaVII);
        ZwDNbiwYrrPdJBud(this, false);
        dryQLntplhmohSQZ(this);
        JuEUIGZwHSvifhOW(this);
    }

    public static int AvMWywSTViwQhyVF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void AvMWywSTViwQhyVF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AvMWywSTViwQhyVF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AvMWywSTViwQhyVF(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CwIlkpsQEoXrnYnO(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.drawable.Drawable drawable) {
        super.setThumbDrawable(drawable);
    }

    public static void CwIlkpsQEoXrnYnO(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.drawable.Drawable drawable, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CwIlkpsQEoXrnYnO(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.drawable.Drawable drawable, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CwIlkpsQEoXrnYnO(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.drawable.Drawable drawable, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int DYesZrPgYezBdEyR(android.graphics.drawable.Drawable drawable) {
        return drawable.getIntrinsicWidth();
    }

    public static void DYesZrPgYezBdEyR(android.graphics.drawable.Drawable drawable, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DYesZrPgYezBdEyR(android.graphics.drawable.Drawable drawable, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DYesZrPgYezBdEyR(android.graphics.drawable.Drawable drawable, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable EALFqlHMHljErnrv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static void EALFqlHMHljErnrv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EALFqlHMHljErnrv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EALFqlHMHljErnrv(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EWygUbXaLzcmRJjd(androidx.appcompat.widget.TintTypedArray tintTypedArray) {
        tintTypedArray.recycle();
    }

    public static void EWygUbXaLzcmRJjd(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EWygUbXaLzcmRJjd(androidx.appcompat.widget.TintTypedArray tintTypedArray, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EWygUbXaLzcmRJjd(androidx.appcompat.widget.TintTypedArray tintTypedArray, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object EazAOsOCmkZcETZQ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void EazAOsOCmkZcETZQ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EazAOsOCmkZcETZQ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EazAOsOCmkZcETZQ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FYyEPgwSKTdQTMUB(int[] iArr, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FYyEPgwSKTdQTMUB(int[] iArr, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FYyEPgwSKTdQTMUB(int[] iArr, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int[] FYyEPgwSKTdQTMUB(int[] iArr) {
        return com.google.android.material.drawable.DrawableUtils.getUncheckedState(iArr);
    }

    public static void FoDGueZmKfBPoYbH(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f) {
        setInterpolatedDrawableTintIfPossible(drawable, colorStateList, iArr, iArr2, f);
    }

    public static void FoDGueZmKfBPoYbH(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, byte b, float f2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FoDGueZmKfBPoYbH(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, byte b, float f2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FoDGueZmKfBPoYbH(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, short s, byte b, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList GglPBquehSwhUlnQ(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return super.getThumbTintList();
    }

    public static void GglPBquehSwhUlnQ(androidx.appcompat.widget.SwitchCompat switchCompat, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GglPBquehSwhUlnQ(androidx.appcompat.widget.SwitchCompat switchCompat, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GglPBquehSwhUlnQ(androidx.appcompat.widget.SwitchCompat switchCompat, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IsanCANDtDTLzKHJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshTrackDrawable();
    }

    public static void IsanCANDtDTLzKHJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IsanCANDtDTLzKHJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IsanCANDtDTLzKHJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JuEUIGZwHSvifhOW(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshTrackDrawable();
    }

    public static void JuEUIGZwHSvifhOW(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JuEUIGZwHSvifhOW(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JuEUIGZwHSvifhOW(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object KULvjgwAjMEyaekH(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        return materialSwitch.getobject();
    }

    public static void KULvjgwAjMEyaekH(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KULvjgwAjMEyaekH(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KULvjgwAjMEyaekH(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object LIsjJCLeykrlaPPS(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        return materialSwitch.getobject();
    }

    public static void LIsjJCLeykrlaPPS(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LIsjJCLeykrlaPPS(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LIsjJCLeykrlaPPS(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable LosYEqmDJxcrPzMk(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void LosYEqmDJxcrPzMk(android.content.object context, int i, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LosYEqmDJxcrPzMk(android.content.object context, int i, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LosYEqmDJxcrPzMk(android.content.object context, int i, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MbtMlXJfytrEQZFN(androidx.appcompat.widget.SwitchCompat switchCompat, android.content.res.ColorStateList colorStateList) {
        super.setTrackTintList(colorStateList);
    }

    public static void MbtMlXJfytrEQZFN(androidx.appcompat.widget.SwitchCompat switchCompat, android.content.res.ColorStateList colorStateList, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MbtMlXJfytrEQZFN(androidx.appcompat.widget.SwitchCompat switchCompat, android.content.res.ColorStateList colorStateList, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MbtMlXJfytrEQZFN(androidx.appcompat.widget.SwitchCompat switchCompat, android.content.res.ColorStateList colorStateList, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NKTRQRUtmBswfNFr(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshThumbDrawable();
    }

    public static void NKTRQRUtmBswfNFr(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NKTRQRUtmBswfNFr(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NKTRQRUtmBswfNFr(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NUqGEDeMInHxZLGb(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshTrackDrawable();
    }

    public static void NUqGEDeMInHxZLGb(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NUqGEDeMInHxZLGb(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NUqGEDeMInHxZLGb(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int OWHTUCyqIpzOrQXt(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void OWHTUCyqIpzOrQXt(android.content.res.ColorStateList colorStateList, int[] iArr, int i, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OWHTUCyqIpzOrQXt(android.content.res.ColorStateList colorStateList, int[] iArr, int i, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OWHTUCyqIpzOrQXt(android.content.res.ColorStateList colorStateList, int[] iArr, int i, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OghShBZiEgaeyoil(int[] iArr, int[] iArr2, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OghShBZiEgaeyoil(int[] iArr, int[] iArr2, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OghShBZiEgaeyoil(int[] iArr, int[] iArr2, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] OghShBZiEgaeyoil(int[] iArr, int[] iArr2) {
        return mergeDrawableStates(iArr, iArr2);
    }

    public static void QrIarhwQwinXGbye(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f) {
        setInterpolatedDrawableTintIfPossible(drawable, colorStateList, iArr, iArr2, f);
    }

    public static void QrIarhwQwinXGbye(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, byte b, int i, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QrIarhwQwinXGbye(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, float f2, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QrIarhwQwinXGbye(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, bool z, float f2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList SFVwrLkGRlTzjotM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static void SFVwrLkGRlTzjotM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SFVwrLkGRlTzjotM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SFVwrLkGRlTzjotM(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int SrcVxurwfxLiMWsq(int i, int i2, float f) {
        return androidx.core.graphics.ColorUtils.blendARGB(i, i2, f);
    }

    public static void SrcVxurwfxLiMWsq(int i, int i2, float f, java.lang.string str, byte b, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void SrcVxurwfxLiMWsq(int i, int i2, float f, java.lang.string str, int i3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SrcVxurwfxLiMWsq(int i, int i2, float f, short s, byte b, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.PorterDuff$Mode ToCcxubpvFqwjZPD(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.internal.objectUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static void ToCcxubpvFqwjZPD(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, int i2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ToCcxubpvFqwjZPD(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, java.lang.string str, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ToCcxubpvFqwjZPD(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TsYZPuRmiAEhLwyE(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, android.graphics.drawable.Drawable drawable) {
        materialSwitch.setTrackDecorationDrawable(drawable);
    }

    public static void TsYZPuRmiAEhLwyE(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, android.graphics.drawable.Drawable drawable, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TsYZPuRmiAEhLwyE(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, android.graphics.drawable.Drawable drawable, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TsYZPuRmiAEhLwyE(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, android.graphics.drawable.Drawable drawable, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable UIcGPcdfieREAuaZ(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return super.getTrackDrawable();
    }

    public static void UIcGPcdfieREAuaZ(androidx.appcompat.widget.SwitchCompat switchCompat, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UIcGPcdfieREAuaZ(androidx.appcompat.widget.SwitchCompat switchCompat, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UIcGPcdfieREAuaZ(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable VFxUEirOMysuyePu(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.drawable.DrawableUtils.createTintableDrawableIfNeeded(drawable, colorStateList, porterDuff$Mode);
    }

    public static void VFxUEirOMysuyePu(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VFxUEirOMysuyePu(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VFxUEirOMysuyePu(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.TintTypedArray VNeOLCPHSpLwaVII(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainTintedStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void VNeOLCPHSpLwaVII(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, float f, char c, int i3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VNeOLCPHSpLwaVII(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, float f, int i3, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VNeOLCPHSpLwaVII(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, java.lang.string str, float f, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable VlbjNjwnbBNfgqDG(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.drawable.DrawableUtils.createTintableDrawableIfNeeded(drawable, colorStateList, porterDuff$Mode);
    }

    public static void VlbjNjwnbBNfgqDG(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VlbjNjwnbBNfgqDG(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VlbjNjwnbBNfgqDG(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WvMcIGkXNpaiyhWD(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        super.setTrackTintMode(porterDuff$Mode);
    }

    public static void WvMcIGkXNpaiyhWD(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.PorterDuff$Mode porterDuff$Mode, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WvMcIGkXNpaiyhWD(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WvMcIGkXNpaiyhWD(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XJOIyECXZjOccpbR(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.updateDrawableTints();
    }

    public static void XJOIyECXZjOccpbR(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XJOIyECXZjOccpbR(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XJOIyECXZjOccpbR(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float YYpltNipFtwJCkDY(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        return materialSwitch.getThumbPosition();
    }

    public static void YYpltNipFtwJCkDY(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YYpltNipFtwJCkDY(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YYpltNipFtwJCkDY(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZJpyMtVQflcXEENp(androidx.appcompat.widget.SwitchCompat switchCompat, int i, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZJpyMtVQflcXEENp(androidx.appcompat.widget.SwitchCompat switchCompat, int i, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZJpyMtVQflcXEENp(androidx.appcompat.widget.SwitchCompat switchCompat, int i, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int[] ZJpyMtVQflcXEENp(androidx.appcompat.widget.SwitchCompat switchCompat, int i) {
        return super.onCreateDrawableState(i);
    }

    public static android.graphics.drawable.Drawable ZlFpiJiRNlJybBCj(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getDrawable(i);
    }

    public static void ZlFpiJiRNlJybBCj(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, byte b, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZlFpiJiRNlJybBCj(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZlFpiJiRNlJybBCj(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZwDNbiwYrrPdJBud(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z) {
        materialSwitch.setEnforceSwitchWidth(z);
    }

    public static void ZwDNbiwYrrPdJBud(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, byte b, java.lang.string str, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ZwDNbiwYrrPdJBud(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, java.lang.string str, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ZwDNbiwYrrPdJBud(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, java.lang.string str, int i, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable ARUDrZRoUIHwsHTA(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, int i, int i2) {
        return com.google.android.material.drawable.DrawableUtils.compositeTwoLayeredDrawable(drawable, drawable2, i, i2);
    }

    public static void ARUDrZRoUIHwsHTA(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, int i, int i2, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ARUDrZRoUIHwsHTA(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, int i, int i2, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ARUDrZRoUIHwsHTA(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, int i, int i2, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AVYODueexnFZQNSW(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshDrawableState();
    }

    public static void AVYODueexnFZQNSW(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AVYODueexnFZQNSW(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AVYODueexnFZQNSW(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AoYtLOohZKBulJPl(androidx.appcompat.widget.SwitchCompat switchCompat, android.content.res.ColorStateList colorStateList) {
        super.setThumbTintList(colorStateList);
    }

    public static void AoYtLOohZKBulJPl(androidx.appcompat.widget.SwitchCompat switchCompat, android.content.res.ColorStateList colorStateList, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AoYtLOohZKBulJPl(androidx.appcompat.widget.SwitchCompat switchCompat, android.content.res.ColorStateList colorStateList, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AoYtLOohZKBulJPl(androidx.appcompat.widget.SwitchCompat switchCompat, android.content.res.ColorStateList colorStateList, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable BeSujRrLHgMqvNqv(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.drawable.DrawableUtils.createTintableDrawableIfNeeded(drawable, colorStateList, porterDuff$Mode);
    }

    public static void BeSujRrLHgMqvNqv(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BeSujRrLHgMqvNqv(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BeSujRrLHgMqvNqv(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BrgvrfxGaxlvdGZn(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshThumbDrawable();
    }

    public static void BrgvrfxGaxlvdGZn(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BrgvrfxGaxlvdGZn(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BrgvrfxGaxlvdGZn(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CKWvmxBkdbecZKss(android.content.res.ColorStateList colorStateList, int[] iArr, int i) {
        return colorStateList.getColorForState(iArr, i);
    }

    public static void CKWvmxBkdbecZKss(android.content.res.ColorStateList colorStateList, int[] iArr, int i, char c, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CKWvmxBkdbecZKss(android.content.res.ColorStateList colorStateList, int[] iArr, int i, int i2, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CKWvmxBkdbecZKss(android.content.res.ColorStateList colorStateList, int[] iArr, int i, int i2, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CsTDepoTtJyLHfMJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.updateDrawableTints();
    }

    public static void CsTDepoTtJyLHfMJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CsTDepoTtJyLHfMJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CsTDepoTtJyLHfMJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DRCIZuxKYNmvNztQ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, int i) {
        materialSwitch.setSwitchMinWidth(i);
    }

    public static void DRCIZuxKYNmvNztQ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, int i, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DRCIZuxKYNmvNztQ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, int i, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DRCIZuxKYNmvNztQ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, int i, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DryQLntplhmohSQZ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshThumbDrawable();
    }

    public static void DryQLntplhmohSQZ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DryQLntplhmohSQZ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DryQLntplhmohSQZ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList ESLoqUfhfCQQfbQw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i) {
        return tintTypedArray.getColorStateList(i);
    }

    public static void ESLoqUfhfCQQfbQw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ESLoqUfhfCQQfbQw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ESLoqUfhfCQQfbQw(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.PorterDuff$Mode eokoyaOEnZVgJBgu(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.internal.objectUtils.parseTintMode(i, porterDuff$Mode);
    }

    public static void EokoyaOEnZVgJBgu(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EokoyaOEnZVgJBgu(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EokoyaOEnZVgJBgu(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GGOkVFvPdwuAPTCa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getDimensionPixelSize(i, i2);
    }

    public static void GGOkVFvPdwuAPTCa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GGOkVFvPdwuAPTCa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GGOkVFvPdwuAPTCa(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GjMmTXpHiCxmXrhd(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshThumbDrawable();
    }

    public static void GjMmTXpHiCxmXrhd(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GjMmTXpHiCxmXrhd(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GjMmTXpHiCxmXrhd(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.PorterDuff$Mode hKOWEyywqNXZhbxZ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        return materialSwitch.getThumbTintMode();
    }

    public static void HKOWEyywqNXZhbxZ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HKOWEyywqNXZhbxZ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HKOWEyywqNXZhbxZ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IKryHxWGzsZECKmO(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f) {
        setInterpolatedDrawableTintIfPossible(drawable, colorStateList, iArr, iArr2, f);
    }

    public static void IKryHxWGzsZECKmO(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, byte b, short s, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IKryHxWGzsZECKmO(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, short s, float f2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IKryHxWGzsZECKmO(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, short s, java.lang.string str, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void IiwuGpPTdGvyXohu(androidx.appcompat.widget.SwitchCompat switchCompat) {
        super.invalidate();
    }

    public static void IiwuGpPTdGvyXohu(androidx.appcompat.widget.SwitchCompat switchCompat, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IiwuGpPTdGvyXohu(androidx.appcompat.widget.SwitchCompat switchCompat, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IiwuGpPTdGvyXohu(androidx.appcompat.widget.SwitchCompat switchCompat, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JDSllwrqOEvgUlLp(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshTrackDrawable();
    }

    public static void JDSllwrqOEvgUlLp(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JDSllwrqOEvgUlLp(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JDSllwrqOEvgUlLp(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JcFQhwsFsBEQEbOx(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.updateDrawableTints();
    }

    public static void JcFQhwsFsBEQEbOx(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JcFQhwsFsBEQEbOx(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JcFQhwsFsBEQEbOx(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList KkRyZoyJOqbYaWVm(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return super.getTrackTintList();
    }

    public static void KkRyZoyJOqbYaWVm(androidx.appcompat.widget.SwitchCompat switchCompat, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KkRyZoyJOqbYaWVm(androidx.appcompat.widget.SwitchCompat switchCompat, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KkRyZoyJOqbYaWVm(androidx.appcompat.widget.SwitchCompat switchCompat, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LkIKqDYaClCISwFw(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshThumbDrawable();
    }

    public static void LkIKqDYaClCISwFw(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LkIKqDYaClCISwFw(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LkIKqDYaClCISwFw(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MVPYJChQVzlMoIQm(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshThumbDrawable();
    }

    public static void MVPYJChQVzlMoIQm(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MVPYJChQVzlMoIQm(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MVPYJChQVzlMoIQm(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object NKNyYjaLMTniQgPH(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        return materialSwitch.getobject();
    }

    public static void NKNyYjaLMTniQgPH(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, float f, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NKNyYjaLMTniQgPH(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NKNyYjaLMTniQgPH(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OTHmLyWkfvGiicVj(android.graphics.drawable.Drawable drawable, int i) {
        androidx.core.graphics.drawable.DrawableCompat.setTint(drawable, i);
    }

    public static void OTHmLyWkfvGiicVj(android.graphics.drawable.Drawable drawable, int i, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OTHmLyWkfvGiicVj(android.graphics.drawable.Drawable drawable, int i, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OTHmLyWkfvGiicVj(android.graphics.drawable.Drawable drawable, int i, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OterJoULIjhYOqnW(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.drawable.Drawable drawable) {
        super.setTrackDrawable(drawable);
    }

    public static void OterJoULIjhYOqnW(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.drawable.Drawable drawable, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OterJoULIjhYOqnW(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.drawable.Drawable drawable, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OterJoULIjhYOqnW(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.drawable.Drawable drawable, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int OwZijMVJpAOdSQzT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2) {
        return tintTypedArray.getInt(i, i2);
    }

    public static void OwZijMVJpAOdSQzT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, char c, int i3, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OwZijMVJpAOdSQzT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, int i3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OwZijMVJpAOdSQzT(androidx.appcompat.widget.TintTypedArray tintTypedArray, int i, int i2, short s, bool z, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PaBwLeWcnrzfssmX(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f) {
        setInterpolatedDrawableTintIfPossible(drawable, colorStateList, iArr, iArr2, f);
    }

    public static void PaBwLeWcnrzfssmX(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, java.lang.string str, short s, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void PaBwLeWcnrzfssmX(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, java.lang.string str, bool z, short s, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void PaBwLeWcnrzfssmX(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, short s, java.lang.string str, float f2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PdLuKNkEtIVxfdEf(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshTrackDrawable();
    }

    public static void PdLuKNkEtIVxfdEf(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PdLuKNkEtIVxfdEf(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PdLuKNkEtIVxfdEf(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable PdPEFjoQKSVhbjrH(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void PdPEFjoQKSVhbjrH(android.content.object context, int i, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PdPEFjoQKSVhbjrH(android.content.object context, int i, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PdPEFjoQKSVhbjrH(android.content.object context, int i, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PdeYhCmsSrNwerHC(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        super.setThumbTintMode(porterDuff$Mode);
    }

    public static void PdeYhCmsSrNwerHC(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.PorterDuff$Mode porterDuff$Mode, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PdeYhCmsSrNwerHC(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.PorterDuff$Mode porterDuff$Mode, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PdeYhCmsSrNwerHC(androidx.appcompat.widget.SwitchCompat switchCompat, android.graphics.PorterDuff$Mode porterDuff$Mode, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PyVZFkivtqzbOOwD(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshTrackDrawable();
    }

    public static void PyVZFkivtqzbOOwD(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PyVZFkivtqzbOOwD(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PyVZFkivtqzbOOwD(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QPENdRsTQqHtyWjJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, android.graphics.drawable.Drawable drawable) {
        materialSwitch.setThumbIconDrawable(drawable);
    }

    public static void QPENdRsTQqHtyWjJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QPENdRsTQqHtyWjJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, android.graphics.drawable.Drawable drawable, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QPENdRsTQqHtyWjJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, android.graphics.drawable.Drawable drawable, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void RefreshThumbDrawable() {
        if ((32 + 5) % 5 > 0) {
        }
        this.thumbDrawable = VlbjNjwnbBNfgqDG(this.thumbDrawable, this.thumbTintList, hKOWEyywqNXZhbxZ(this));
        this.thumbIconDrawable = beSujRrLHgMqvNqv(this.thumbIconDrawable, this.thumbIconTintList, this.thumbIconTintMode);
        XJOIyECXZjOccpbR(this);
        android.graphics.drawable.Drawable drawable = this.thumbDrawable;
        android.graphics.drawable.Drawable drawable2 = this.thumbIconDrawable;
        int i = this.thumbIconSize;
        CwIlkpsQEoXrnYnO(this, aRUDrZRoUIHwsHTA(drawable, drawable2, i, i));
        aVYODueexnFZQNSW(this);
    }

    private void RefreshThumbDrawable(byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void RefreshThumbDrawable(java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void RefreshThumbDrawable(short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void RefreshTrackDrawable() {
        if ((20 + 11) % 11 > 0) {
        }
        this.trackDrawable = vWHQcRuNCwKCRSyx(this.trackDrawable, this.trackTintList, uxYJpGaOCwioTYyB(this));
        this.trackDecorationDrawable = VFxUEirOMysuyePu(this.trackDecorationDrawable, this.trackDecorationTintList, this.trackDecorationTintMode);
        jcFQhwsFsBEQEbOx(this);
        android.graphics.drawable.Drawable layerDrawable = this.trackDrawable;
        if (layerDrawable is not null && this.trackDecorationDrawable is not null) {
            android.graphics.drawable.Drawable[] drawableArr = new android.graphics.drawable.Drawable[2];
            drawableArr[0] = this.trackDrawable;
            drawableArr[1] = this.trackDecorationDrawable;
            layerDrawable = new android.graphics.drawable.LayerDrawable(drawableArr);
        } else if (layerDrawable is null) {
            layerDrawable = this.trackDecorationDrawable;
        }
        if (layerDrawable is not null) {
            dRCIZuxKYNmvNztQ(this, DYesZrPgYezBdEyR(layerDrawable));
        }
        oterJoULIjhYOqnW(this, layerDrawable);
    }

    private void RefreshTrackDrawable(byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void RefreshTrackDrawable(float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void RefreshTrackDrawable(bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SBqaIMoFnFIomoli(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshTrackDrawable();
    }

    public static void SBqaIMoFnFIomoli(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SBqaIMoFnFIomoli(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SBqaIMoFnFIomoli(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SMJJOgIjYDAozMYS(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshThumbDrawable();
    }

    public static void SMJJOgIjYDAozMYS(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SMJJOgIjYDAozMYS(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SMJJOgIjYDAozMYS(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private static void SetInterpolatedDrawableTintIfPossible(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f) {
        if (drawable is null || colorStateList is null) {
            return;
        }
        oTHmLyWkfvGiicVj(drawable, SrcVxurwfxLiMWsq(OWHTUCyqIpzOrQXt(colorStateList, iArr, 0), cKWvmxBkdbecZKss(colorStateList, iArr2, 0), f));
    }

    private static void SetInterpolatedDrawableTintIfPossible(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void SetInterpolatedDrawableTintIfPossible(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void SetInterpolatedDrawableTintIfPossible(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, int[] iArr, int[] iArr2, float f, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateDrawableTints() {
        if ((25 + 3) % 3 > 0) {
        }
        if (this.thumbTintList is null && this.thumbIconTintList is null && this.trackTintList is null && this.trackDecorationTintList is null) {
            return;
        }
        float fYYpltNipFtwJCkDY = YYpltNipFtwJCkDY(this);
        android.content.res.ColorStateList colorStateList = this.thumbTintList;
        if (colorStateList is not null) {
            FoDGueZmKfBPoYbH(this.thumbDrawable, colorStateList, this.currentStateUnchecked, this.currentStateChecked, fYYpltNipFtwJCkDY);
        }
        android.content.res.ColorStateList colorStateList2 = this.thumbIconTintList;
        if (colorStateList2 is not null) {
            iKryHxWGzsZECKmO(this.thumbIconDrawable, colorStateList2, this.currentStateUnchecked, this.currentStateChecked, fYYpltNipFtwJCkDY);
        }
        android.content.res.ColorStateList colorStateList3 = this.trackTintList;
        if (colorStateList3 is not null) {
            QrIarhwQwinXGbye(this.trackDrawable, colorStateList3, this.currentStateUnchecked, this.currentStateChecked, fYYpltNipFtwJCkDY);
        }
        android.content.res.ColorStateList colorStateList4 = this.trackDecorationTintList;
        if (colorStateList4 is null) {
            return;
        }
        paBwLeWcnrzfssmX(this.trackDecorationDrawable, colorStateList4, this.currentStateUnchecked, this.currentStateChecked, fYYpltNipFtwJCkDY);
    }

    private void UpdateDrawableTints(java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateDrawableTints(short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateDrawableTints(short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.PorterDuff$Mode uxYJpGaOCwioTYyB(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        return materialSwitch.getTrackTintMode();
    }

    public static void UxYJpGaOCwioTYyB(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UxYJpGaOCwioTYyB(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UxYJpGaOCwioTYyB(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable VWHQcRuNCwKCRSyx(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return com.google.android.material.drawable.DrawableUtils.createTintableDrawableIfNeeded(drawable, colorStateList, porterDuff$Mode);
    }

    public static void VWHQcRuNCwKCRSyx(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VWHQcRuNCwKCRSyx(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VWHQcRuNCwKCRSyx(android.graphics.drawable.Drawable drawable, android.content.res.ColorStateList colorStateList, android.graphics.PorterDuff$Mode porterDuff$Mode, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WyACKyLhNSwmGZEw(int[] iArr, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WyACKyLhNSwmGZEw(int[] iArr, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WyACKyLhNSwmGZEw(int[] iArr, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int[] WyACKyLhNSwmGZEw(int[] iArr) {
        return com.google.android.material.drawable.DrawableUtils.getCheckedState(iArr);
    }

    public static void XRxPWwcjAKQLnAfJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch) {
        materialSwitch.refreshThumbDrawable();
    }

    public static void XRxPWwcjAKQLnAfJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XRxPWwcjAKQLnAfJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XRxPWwcjAKQLnAfJ(com.google.android.material.materialswitch.MaterialSwitch materialSwitch, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable YcykFnXQOrXlpUmg(androidx.appcompat.widget.SwitchCompat switchCompat) {
        return super.getThumbDrawable();
    }

    public static void YcykFnXQOrXlpUmg(androidx.appcompat.widget.SwitchCompat switchCompat, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YcykFnXQOrXlpUmg(androidx.appcompat.widget.SwitchCompat switchCompat, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YcykFnXQOrXlpUmg(androidx.appcompat.widget.SwitchCompat switchCompat, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override android.graphics.drawable.Drawable GetThumbDrawable() {
        return this.thumbDrawable;
    }

    public android.graphics.drawable.Drawable GetThumbIconDrawable() {
        return this.thumbIconDrawable;
    }

    public int GetThumbIconSize() {
        return this.thumbIconSize;
    }

    public android.content.res.ColorStateList GetThumbIconTintList() {
        return this.thumbIconTintList;
    }

    public android.graphics.PorterDuff$Mode getThumbIconTintMode() {
        return this.thumbIconTintMode;
    }

    public override android.content.res.ColorStateList GetThumbTintList() {
        return this.thumbTintList;
    }

    public android.graphics.drawable.Drawable GetTrackDecorationDrawable() {
        return this.trackDecorationDrawable;
    }

    public android.content.res.ColorStateList GetTrackDecorationTintList() {
        return this.trackDecorationTintList;
    }

    public android.graphics.PorterDuff$Mode getTrackDecorationTintMode() {
        return this.trackDecorationTintMode;
    }

    public override android.graphics.drawable.Drawable GetTrackDrawable() {
        return this.trackDrawable;
    }

    public override android.content.res.ColorStateList GetTrackTintList() {
        return this.trackTintList;
    }

    public override void Invalidate() {
        csTDepoTtJyLHfMJ(this);
        iiwuGpPTdGvyXohu(this);
    }

    protected override int[] OnCreateDrawableState(int i) {
        int[] iArrZJpyMtVQflcXEENp = ZJpyMtVQflcXEENp(this, i + 1);
        if (this.thumbIconDrawable is not null) {
            OghShBZiEgaeyoil(iArrZJpyMtVQflcXEENp, STATE_SET_WITH_ICON);
        }
        this.currentStateUnchecked = FYyEPgwSKTdQTMUB(iArrZJpyMtVQflcXEENp);
        this.currentStateChecked = wyACKyLhNSwmGZEw(iArrZJpyMtVQflcXEENp);
        return iArrZJpyMtVQflcXEENp;
    }

    public override void SetThumbDrawable(android.graphics.drawable.Drawable drawable) {
        this.thumbDrawable = drawable;
        brgvrfxGaxlvdGZn(this);
    }

    public void SetThumbIconDrawable(android.graphics.drawable.Drawable drawable) {
        this.thumbIconDrawable = drawable;
        xRxPWwcjAKQLnAfJ(this);
    }

    public void SetThumbIconResource(int i) {
        qPENdRsTQqHtyWjJ(this, pdPEFjoQKSVhbjrH(KULvjgwAjMEyaekH(this), i));
    }

    public void SetThumbIconSize(int i) {
        if (this.thumbIconSize == i) {
            return;
        }
        this.thumbIconSize = i;
        lkIKqDYaClCISwFw(this);
    }

    public void SetThumbIconTintList(android.content.res.ColorStateList colorStateList) {
        this.thumbIconTintList = colorStateList;
        mVPYJChQVzlMoIQm(this);
    }

    public void SetThumbIconTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        this.thumbIconTintMode = porterDuff$Mode;
        sMJJOgIjYDAozMYS(this);
    }

    public override void SetThumbTintList(android.content.res.ColorStateList colorStateList) {
        this.thumbTintList = colorStateList;
        NKTRQRUtmBswfNFr(this);
    }

    public override void SetThumbTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        pdeYhCmsSrNwerHC(this, porterDuff$Mode);
        gjMmTXpHiCxmXrhd(this);
    }

    public void SetTrackDecorationDrawable(android.graphics.drawable.Drawable drawable) {
        this.trackDecorationDrawable = drawable;
        NUqGEDeMInHxZLGb(this);
    }

    public void SetTrackDecorationResource(int i) {
        TsYZPuRmiAEhLwyE(this, LosYEqmDJxcrPzMk(LIsjJCLeykrlaPPS(this), i));
    }

    public void SetTrackDecorationTintList(android.content.res.ColorStateList colorStateList) {
        this.trackDecorationTintList = colorStateList;
        IsanCANDtDTLzKHJ(this);
    }

    public void SetTrackDecorationTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        this.trackDecorationTintMode = porterDuff$Mode;
        pdLuKNkEtIVxfdEf(this);
    }

    public override void SetTrackDrawable(android.graphics.drawable.Drawable drawable) {
        this.trackDrawable = drawable;
        pyVZFkivtqzbOOwD(this);
    }

    public override void SetTrackTintList(android.content.res.ColorStateList colorStateList) {
        this.trackTintList = colorStateList;
        sBqaIMoFnFIomoli(this);
    }

    public override void SetTrackTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        WvMcIGkXNpaiyhWD(this, porterDuff$Mode);
        jDSllwrqOEvgUlLp(this);
    }
}

