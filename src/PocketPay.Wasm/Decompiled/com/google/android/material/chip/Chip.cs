namespace WillowMaze.Wasm.Decompiled;


public class Chip : androidx.appcompat.widget.AppCompatCheckBox : com.google.android.material.chip.ChipDrawable$Delegate, com.google.android.material.shape.Shapeable, com.google.android.material.internal.MaterialCheckable<com.google.android.material.chip.Chip> {
    private static readonly java.lang.string BUTTON_ACCESSIBILITY_CLASS_NAME = "android.widget.Button";
    private static readonly int CHIP_BODY_VIRTUAL_ID = 0;
    private static readonly int CLOSE_ICON_VIRTUAL_ID = 1;
    private static readonly java.lang.string GENERIC_VIEW_ACCESSIBILITY_CLASS_NAME = "android.view.object";
    private static readonly int MIN_TOUCH_TARGET_DP = 48;
    private static readonly java.lang.string NAMESPACE_ANDROID = "http://schemas.android.com/apk/res/android";
    private static readonly java.lang.string RADIO_BUTTON_ACCESSIBILITY_CLASS_NAME = "android.widget.RadioButton";
    private static readonly java.lang.string TAG = "Chip";
    private java.lang.CharSequence accessibilityClassName;
    private com.google.android.material.chip.ChipDrawable chipDrawable;
    private bool closeIconFocused;
    private bool closeIconHovered;
    private bool closeIconPressed;
    private bool deferredCheckedValue;
    private bool ensureMinTouchTargetSize;
    private readonly com.google.android.material.resources.TextAppearanceFontCallback fontCallback;
    private android.graphics.drawable.InsetDrawable insetBackgroundDrawable;
    private int lastLayoutDirection;
    private int minTouchTargetSize;
    private android.widget.CompoundButton$OnCheckedChangeListener onCheckedChangeListener;
    private com.google.android.material.internal.MaterialCheckable$OnCheckedChangeListener<com.google.android.material.chip.Chip> onCheckedChangeListenerInternal;
    private android.view.object$OnClickListener onCloseIconClickListener;
    private readonly android.graphics.Rect rect;
    private readonly android.graphics.RectF rectF;
    private android.graphics.drawable.RippleDrawable ripple;
    private readonly com.google.android.material.chip.Chip$ChipTouchHelper touchHelper;
    private bool touchHelperEnabled;
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_Chip_Action;
    private static readonly android.graphics.Rect EMPTY_BOUNDS = new android.graphics.Rect();
    private static readonly int[] SELECTED_STATE = {16842913};
    private static readonly int[] CHECKABLE_STATE_SET = {16842911};

    public Chip(android.content.object context) {
        this(context, null);
    }

    public Chip(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.chipStyle);
    }

    public Chip(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((31 + 6) % 6 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(QoduPBzOhQwuCAak(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.rect = new android.graphics.Rect();
        this.rectF = new android.graphics.RectF();
        this.fontCallback = new com.google.android.material.chip.Chip$1(this);
        android.content.object contextQqMBXyNIufpzunWn = QqMBXyNIufpzunWn(this);
        uSECobLKIWjfRcys(this, attributeHashSet);
        com.google.android.material.chip.ChipDrawable chipDrawableTivPSZDIQqjUWCTi = tivPSZDIQqjUWCTi(contextQqMBXyNIufpzunWn, attributeHashSet, i, i2);
        EYTTOgegtFEvDeEq(this, contextQqMBXyNIufpzunWn, attributeHashSet, i);
        TJHNnMeprQaejMTH(this, chipDrawableTivPSZDIQqjUWCTi);
        DWHiOsCRIKWehPEX(chipDrawableTivPSZDIQqjUWCTi, cpzPUXafgjdiNAdH(this));
        android.content.res.TypedArray typedArrayVbTTlLxyDgSsXCST = vbTTlLxyDgSsXCST(contextQqMBXyNIufpzunWn, attributeHashSet, com.google.android.material.R$styleable.Chip, i, i2, new int[0]);
        bool zXnMQLEAfhFrglvSa = XnMQLEAfhFrglvSa(typedArrayVbTTlLxyDgSsXCST, com.google.android.material.R$styleable.Chip_shapeAppearance);
        OMpbZylgAnanPqVX(typedArrayVbTTlLxyDgSsXCST);
        this.touchHelper = new com.google.android.material.chip.Chip$ChipTouchHelper(this, this);
        lChKqQvVRzPBnbDo(this);
        if (!zXnMQLEAfhFrglvSa) {
            nngTmtFJURVuWHwM(this);
        }
        dBqJSCXsqDTyzwVO(this, this.deferredCheckedValue);
        fTsrmBpjiiOUueyv(this, MMucVaZxSdYifqPP(chipDrawableTivPSZDIQqjUWCTi));
        RtIsqjnluWbeGSDd(this, tPjLXOhKjevvuunW(chipDrawableTivPSZDIQqjUWCTi));
        ZKjLYYURPOhpBOhM(this);
        if (!FzrhvDfCIqmOVGVW(this.chipDrawable)) {
            CMnSHuoMSyQcsCwi(this, 1);
            jKxuVduhqXpRXKyh(this, true);
        }
        CdbtkboiburpJEeJ(this, 8388627);
        qTaYVtXCEcdHxGlj(this);
        if (DVlCVvDsRqCqCGXx(this)) {
            QyIblkHQTqErpuZI(this, this.minTouchTargetSize);
        }
        this.lastLayoutDirection = pmIUrmgAuNHnLPnC(this);
        UBJigrjyuZzoRJTT(this, new com.google.android.material.chip.Chip$$ExternalSyntheticLambda0(this));
    }

    public static void AGgvtZZByoBUdmdn(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable$Callback drawable$Callback) {
        chipDrawable.setCallback(drawable$Callback);
    }

    public static void AGgvtZZByoBUdmdn(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable$Callback drawable$Callback, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AGgvtZZByoBUdmdn(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AGgvtZZByoBUdmdn(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable$Callback drawable$Callback, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AHmfbrfXdynLyXwX(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setIconStartPadding(f);
    }

    public static void AHmfbrfXdynLyXwX(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AHmfbrfXdynLyXwX(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AHmfbrfXdynLyXwX(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ARbxqBIfcJdXEmDx(com.google.android.material.chip.Chip chip) {
        chip.updateFrameworkRippleBackground();
    }

    public static void ARbxqBIfcJdXEmDx(com.google.android.material.chip.Chip chip, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ARbxqBIfcJdXEmDx(com.google.android.material.chip.Chip chip, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ARbxqBIfcJdXEmDx(com.google.android.material.chip.Chip chip, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AaPmlkFtCwrfllnm(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence) {
        chipDrawable.setText(charSequence);
    }

    public static void AaPmlkFtCwrfllnm(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AaPmlkFtCwrfllnm(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AaPmlkFtCwrfllnm(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.resources.TextAppearance AbOfYldaNgpjZcZE(com.google.android.material.chip.Chip chip) {
        return chip.getTextAppearance();
    }

    public static void AbOfYldaNgpjZcZE(com.google.android.material.chip.Chip chip, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AbOfYldaNgpjZcZE(com.google.android.material.chip.Chip chip, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AbOfYldaNgpjZcZE(com.google.android.material.chip.Chip chip, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AmyWfAPyOcbdPNZS(com.google.android.material.chip.Chip chip, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AmyWfAPyOcbdPNZS(com.google.android.material.chip.Chip chip, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AmyWfAPyOcbdPNZS(com.google.android.material.chip.Chip chip, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AmyWfAPyOcbdPNZS(com.google.android.material.chip.Chip chip) {
        return chip.isClickable();
    }

    public static void BASvYqVYMzUbbPwC(com.google.android.material.chip.Chip chip) {
        chip.removeBackgroundInset();
    }

    public static void BASvYqVYMzUbbPwC(com.google.android.material.chip.Chip chip, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BASvYqVYMzUbbPwC(com.google.android.material.chip.Chip chip, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BASvYqVYMzUbbPwC(com.google.android.material.chip.Chip chip, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BCZJcaSoKTtiYCts(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipIconSize(f);
    }

    public static void BCZJcaSoKTtiYCts(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BCZJcaSoKTtiYCts(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BCZJcaSoKTtiYCts(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, float f2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable BEprHsEoHjqWlwNd(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipIcon();
    }

    public static void BEprHsEoHjqWlwNd(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BEprHsEoHjqWlwNd(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BEprHsEoHjqWlwNd(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int BLronmBJjYOQtexd(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void BLronmBJjYOQtexd(java.lang.string str, java.lang.string str2, byte b, bool z, char c, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void BLronmBJjYOQtexd(java.lang.string str, java.lang.string str2, java.lang.string str3, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BLronmBJjYOQtexd(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float BSWynHSIHPGibLNd(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipEndPadding();
    }

    public static void BSWynHSIHPGibLNd(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BSWynHSIHPGibLNd(com.google.android.material.chip.ChipDrawable chipDrawable, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BSWynHSIHPGibLNd(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BcvUgrApJUrihBsN(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BcvUgrApJUrihBsN(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BcvUgrApJUrihBsN(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool BcvUgrApJUrihBsN(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.isCheckable();
    }

    public static void BplMcgujJkrilUkX(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.RectF rectF) {
        chipDrawable.getCloseIconTouchBounds(rectF);
    }

    public static void BplMcgujJkrilUkX(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.RectF rectF, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BplMcgujJkrilUkX(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.RectF rectF, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BplMcgujJkrilUkX(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.RectF rectF, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ByiHcBbAoBHTHKpa(com.google.android.material.chip.Chip chip, bool z) {
        chip.setCloseIconPressed(z);
    }

    public static void ByiHcBbAoBHTHKpa(com.google.android.material.chip.Chip chip, bool z, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ByiHcBbAoBHTHKpa(com.google.android.material.chip.Chip chip, bool z, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ByiHcBbAoBHTHKpa(com.google.android.material.chip.Chip chip, bool z, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int CIZYWvGlMJORrSGp(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i) {
        return attributeHashSet.getAttributeIntValue(str, str2, i);
    }

    public static void CIZYWvGlMJORrSGp(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, float f, java.lang.string str3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CIZYWvGlMJORrSGp(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, java.lang.string str3, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CIZYWvGlMJORrSGp(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, bool z, char c, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static int CIogriBcgVGkCiba(com.google.android.material.chip.ChipGroup chipGroup, android.view.object view) {
        return chipGroup.getIndexOfChip(view);
    }

    public static void CIogriBcgVGkCiba(com.google.android.material.chip.ChipGroup chipGroup, android.view.object view, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CIogriBcgVGkCiba(com.google.android.material.chip.ChipGroup chipGroup, android.view.object view, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CIogriBcgVGkCiba(com.google.android.material.chip.ChipGroup chipGroup, android.view.object view, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CMUTPLggjqGsCShE(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static void CMUTPLggjqGsCShE(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CMUTPLggjqGsCShE(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CMUTPLggjqGsCShE(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CMnSHuoMSyQcsCwi(com.google.android.material.chip.Chip chip, int i) {
        chip.setLines(i);
    }

    public static void CMnSHuoMSyQcsCwi(com.google.android.material.chip.Chip chip, int i, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CMnSHuoMSyQcsCwi(com.google.android.material.chip.Chip chip, int i, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CMnSHuoMSyQcsCwi(com.google.android.material.chip.Chip chip, int i, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float CSDiZTVtPjLGxYoR(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipEndPadding();
    }

    public static void CSDiZTVtPjLGxYoR(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CSDiZTVtPjLGxYoR(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CSDiZTVtPjLGxYoR(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CZvDrgduUfwNwnfl(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setCloseIconVisible(z);
    }

    public static void CZvDrgduUfwNwnfl(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CZvDrgduUfwNwnfl(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CZvDrgduUfwNwnfl(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, char c, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CdbtkboiburpJEeJ(com.google.android.material.chip.Chip chip, int i) {
        chip.setGravity(i);
    }

    public static void CdbtkboiburpJEeJ(com.google.android.material.chip.Chip chip, int i, char c, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CdbtkboiburpJEeJ(com.google.android.material.chip.Chip chip, int i, int i2, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CdbtkboiburpJEeJ(com.google.android.material.chip.Chip chip, int i, bool z, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void CkfZsFKEShgakyxN(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CkfZsFKEShgakyxN(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CkfZsFKEShgakyxN(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CkfZsFKEShgakyxN(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.isCloseIconStateful();
    }

    public static android.graphics.RectF CnUOayXzFltyJanB(com.google.android.material.chip.Chip chip) {
        return chip.getCloseIconTouchBounds();
    }

    public static void CnUOayXzFltyJanB(com.google.android.material.chip.Chip chip, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CnUOayXzFltyJanB(com.google.android.material.chip.Chip chip, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CnUOayXzFltyJanB(com.google.android.material.chip.Chip chip, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CpIErxSKVitfUbIJ(com.google.android.material.chip.Chip chip) {
        chip.updateBackgroundDrawable();
    }

    public static void CpIErxSKVitfUbIJ(com.google.android.material.chip.Chip chip, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CpIErxSKVitfUbIJ(com.google.android.material.chip.Chip chip, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CpIErxSKVitfUbIJ(com.google.android.material.chip.Chip chip, java.lang.string str, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CqeYvLHNituiKYZR(java.lang.CharSequence charSequence, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CqeYvLHNituiKYZR(java.lang.CharSequence charSequence, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CqeYvLHNituiKYZR(java.lang.CharSequence charSequence, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool CqeYvLHNituiKYZR(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void CssKZDbcRHFmocQI(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        chipDrawable.setEllipsize(textUtils$TruncateAt);
    }

    public static void CssKZDbcRHFmocQI(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CssKZDbcRHFmocQI(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CssKZDbcRHFmocQI(com.google.android.material.chip.ChipDrawable chipDrawable, android.text.TextUtils$TruncateAt textUtils$TruncateAt, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DCXILNozCQgeBJTy(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, float f) {
        super.setElevation(f);
    }

    public static void DCXILNozCQgeBJTy(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, float f, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DCXILNozCQgeBJTy(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, float f, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DCXILNozCQgeBJTy(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, float f, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DLHVdCrAJDZnPDhA(com.google.android.material.chip.Chip chip) {
        chip.updateTextPaintDrawState();
    }

    public static void DLHVdCrAJDZnPDhA(com.google.android.material.chip.Chip chip, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DLHVdCrAJDZnPDhA(com.google.android.material.chip.Chip chip, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DLHVdCrAJDZnPDhA(com.google.android.material.chip.Chip chip, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList DMUFuNmGgJNuLsUr(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipIconTint();
    }

    public static void DMUFuNmGgJNuLsUr(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DMUFuNmGgJNuLsUr(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DMUFuNmGgJNuLsUr(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DSaptcybBwnWScOa(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setChipIconResource(i);
    }

    public static void DSaptcybBwnWScOa(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DSaptcybBwnWScOa(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DSaptcybBwnWScOa(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DVlCVvDsRqCqCGXx(com.google.android.material.chip.Chip chip, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DVlCVvDsRqCqCGXx(com.google.android.material.chip.Chip chip, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DVlCVvDsRqCqCGXx(com.google.android.material.chip.Chip chip, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool DVlCVvDsRqCqCGXx(com.google.android.material.chip.Chip chip) {
        return chip.shouldEnsureMinTouchTargetSize();
    }

    public static void DWHiOsCRIKWehPEX(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setElevation(f);
    }

    public static void DWHiOsCRIKWehPEX(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DWHiOsCRIKWehPEX(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DWHiOsCRIKWehPEX(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static float DYogWXHcwZYQfWjJ(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static void DYogWXHcwZYQfWjJ(android.view.MotionEvent motionEvent, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DYogWXHcwZYQfWjJ(android.view.MotionEvent motionEvent, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DYogWXHcwZYQfWjJ(android.view.MotionEvent motionEvent, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DcAhtDeRpUElTFHh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.KeyEvent keyEvent, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DcAhtDeRpUElTFHh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.KeyEvent keyEvent, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DcAhtDeRpUElTFHh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.KeyEvent keyEvent, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool DcAhtDeRpUElTFHh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.KeyEvent keyEvent) {
        return super.dispatchKeyEvent(keyEvent);
    }

    public static void DyqTFuuKFvFMKhyu(com.google.android.material.chip.Chip chip, bool z) {
        chip.setCheckedIconVisible(z);
    }

    public static void DyqTFuuKFvFMKhyu(com.google.android.material.chip.Chip chip, bool z, byte b, char c, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DyqTFuuKFvFMKhyu(com.google.android.material.chip.Chip chip, bool z, char c, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void DyqTFuuKFvFMKhyu(com.google.android.material.chip.Chip chip, bool z, java.lang.string str, byte b, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EVCnFXUlImtLrQRX(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setChipCornerRadiusResource(i);
    }

    public static void EVCnFXUlImtLrQRX(com.google.android.material.chip.ChipDrawable chipDrawable, int i, int i2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EVCnFXUlImtLrQRX(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EVCnFXUlImtLrQRX(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EYTTOgegtFEvDeEq(com.google.android.material.chip.Chip chip, android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        chip.initMinTouchTarget(context, attributeHashSet, i);
    }

    public static void EYTTOgegtFEvDeEq(com.google.android.material.chip.Chip chip, android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, byte b, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EYTTOgegtFEvDeEq(com.google.android.material.chip.Chip chip, android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EYTTOgegtFEvDeEq(com.google.android.material.chip.Chip chip, android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, java.lang.string str, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.view.PointerIcon EhtlLVRLBIvDSWpA(android.content.object context, int i) {
        return android.view.PointerIcon.getSystemIcon(context, i);
    }

    public static void EhtlLVRLBIvDSWpA(android.content.object context, int i, byte b, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EhtlLVRLBIvDSWpA(android.content.object context, int i, byte b, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EhtlLVRLBIvDSWpA(android.content.object context, int i, bool z, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int EquAkrhWVFOSmFLr(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static void EquAkrhWVFOSmFLr(android.view.MotionEvent motionEvent, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EquAkrhWVFOSmFLr(android.view.MotionEvent motionEvent, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EquAkrhWVFOSmFLr(android.view.MotionEvent motionEvent, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FAJLhMmlwRspkIdt(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setCloseIconEndPadding(f);
    }

    public static void FAJLhMmlwRspkIdt(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FAJLhMmlwRspkIdt(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, short s, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void FAJLhMmlwRspkIdt(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, float f2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FAwCdKTISRqhEaYi(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void FAwCdKTISRqhEaYi(android.view.object view, android.graphics.drawable.Drawable drawable, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FAwCdKTISRqhEaYi(android.view.object view, android.graphics.drawable.Drawable drawable, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FAwCdKTISRqhEaYi(android.view.object view, android.graphics.drawable.Drawable drawable, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList FHmpdXjMBBYKKtGy(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getRippleColor();
    }

    public static void FHmpdXjMBBYKKtGy(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FHmpdXjMBBYKKtGy(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FHmpdXjMBBYKKtGy(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FTqHQuzWMszijlDi(com.google.android.material.chip.Chip chip, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FTqHQuzWMszijlDi(com.google.android.material.chip.Chip chip, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FTqHQuzWMszijlDi(com.google.android.material.chip.Chip chip, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool FTqHQuzWMszijlDi(com.google.android.material.chip.Chip chip) {
        return chip.isChecked();
    }

    public static android.view.objectParent FlqmHWVbJGfVPGNX(com.google.android.material.chip.Chip chip) {
        return chip.getParent();
    }

    public static void FlqmHWVbJGfVPGNX(com.google.android.material.chip.Chip chip, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FlqmHWVbJGfVPGNX(com.google.android.material.chip.Chip chip, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FlqmHWVbJGfVPGNX(com.google.android.material.chip.Chip chip, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FzCTIZSPoQCcWIpR(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipEndPadding(f);
    }

    public static void FzCTIZSPoQCcWIpR(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, byte b, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void FzCTIZSPoQCcWIpR(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, int i, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void FzCTIZSPoQCcWIpR(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, int i, float f2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object FznqjaAhGVTVizzf(com.google.android.material.chip.Chip chip) {
        return chip.getobject();
    }

    public static void FznqjaAhGVTVizzf(com.google.android.material.chip.Chip chip, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FznqjaAhGVTVizzf(com.google.android.material.chip.Chip chip, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FznqjaAhGVTVizzf(com.google.android.material.chip.Chip chip, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FzrhvDfCIqmOVGVW(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FzrhvDfCIqmOVGVW(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FzrhvDfCIqmOVGVW(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool FzrhvDfCIqmOVGVW(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.shouldDrawText();
    }

    public static void GDltfdPftmhbjHns(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence) {
        chipDrawable.setCloseIconContentDescription(charSequence);
    }

    public static void GDltfdPftmhbjHns(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GDltfdPftmhbjHns(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GDltfdPftmhbjHns(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.CharSequence charSequence, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GSjdhLgagwjjwqNP(com.google.android.material.chip.Chip chip) {
        chip.updateTextPaintDrawState();
    }

    public static void GSjdhLgagwjjwqNP(com.google.android.material.chip.Chip chip, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GSjdhLgagwjjwqNP(com.google.android.material.chip.Chip chip, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GSjdhLgagwjjwqNP(com.google.android.material.chip.Chip chip, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextPaint GXcDdrPnxNBKhwWp(com.google.android.material.chip.Chip chip) {
        return chip.getPaint();
    }

    public static void GXcDdrPnxNBKhwWp(com.google.android.material.chip.Chip chip, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GXcDdrPnxNBKhwWp(com.google.android.material.chip.Chip chip, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GXcDdrPnxNBKhwWp(com.google.android.material.chip.Chip chip, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int GpajyONQiEvDfiQs(com.google.android.material.chip.Chip chip) {
        return chip.getMinWidth();
    }

    public static void GpajyONQiEvDfiQs(com.google.android.material.chip.Chip chip, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GpajyONQiEvDfiQs(com.google.android.material.chip.Chip chip, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GpajyONQiEvDfiQs(com.google.android.material.chip.Chip chip, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GqSycBJkRkLnBSsV(com.google.android.material.chip.Chip chip, int i, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GqSycBJkRkLnBSsV(com.google.android.material.chip.Chip chip, int i, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GqSycBJkRkLnBSsV(com.google.android.material.chip.Chip chip, int i, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool GqSycBJkRkLnBSsV(com.google.android.material.chip.Chip chip, int i) {
        return chip.ensureAccessibleTouchTarget(i);
    }

    public static void GsmbRJTioMZohayi(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void GsmbRJTioMZohayi(android.content.res.TypedArray typedArray, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GsmbRJTioMZohayi(android.content.res.TypedArray typedArray, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GsmbRJTioMZohayi(android.content.res.TypedArray typedArray, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HBpMBZkvmvMZgJsj(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.Rect rect) {
        super.getFocusedRect(rect);
    }

    public static void HBpMBZkvmvMZgJsj(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.Rect rect, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HBpMBZkvmvMZgJsj(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.Rect rect, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HBpMBZkvmvMZgJsj(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.Rect rect, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HFkXwGzpWYjCjadJ(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.chip.ChipDrawable$Delegate chipDrawable$Delegate) {
        chipDrawable.setDelegate(chipDrawable$Delegate);
    }

    public static void HFkXwGzpWYjCjadJ(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.chip.ChipDrawable$Delegate chipDrawable$Delegate, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HFkXwGzpWYjCjadJ(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.chip.ChipDrawable$Delegate chipDrawable$Delegate, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HFkXwGzpWYjCjadJ(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.chip.ChipDrawable$Delegate chipDrawable$Delegate, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HNWTkWfqBUUcfyDk(com.google.android.material.chip.Chip chip, android.content.object context, int i) {
        chip.setTextAppearance(context, i);
    }

    public static void HNWTkWfqBUUcfyDk(com.google.android.material.chip.Chip chip, android.content.object context, int i, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HNWTkWfqBUUcfyDk(com.google.android.material.chip.Chip chip, android.content.object context, int i, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HNWTkWfqBUUcfyDk(com.google.android.material.chip.Chip chip, android.content.object context, int i, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HXQYEmBCbDtkvIup(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static void HXQYEmBCbDtkvIup(android.view.MotionEvent motionEvent, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HXQYEmBCbDtkvIup(android.view.MotionEvent motionEvent, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HXQYEmBCbDtkvIup(android.view.MotionEvent motionEvent, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HgnucYZrBafXFUyt(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setCloseIconStartPadding(f);
    }

    public static void HgnucYZrBafXFUyt(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HgnucYZrBafXFUyt(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, char c, float f2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HgnucYZrBafXFUyt(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, char c, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void HjoJSsmdIynTDtFC(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable) {
        super.setBackground(drawable);
    }

    public static void HjoJSsmdIynTDtFC(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HjoJSsmdIynTDtFC(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HjoJSsmdIynTDtFC(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int HxYisQJwWZXqGwkW(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper) {
        return chip$ChipTouchHelper.getKeyboardFocusedVirtualobjectId();
    }

    public static void HxYisQJwWZXqGwkW(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HxYisQJwWZXqGwkW(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HxYisQJwWZXqGwkW(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IOQdoNXPUwWYKNMg(com.google.android.material.chip.Chip chip, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IOQdoNXPUwWYKNMg(com.google.android.material.chip.Chip chip, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IOQdoNXPUwWYKNMg(com.google.android.material.chip.Chip chip, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool IOQdoNXPUwWYKNMg(com.google.android.material.chip.Chip chip) {
        return chip.isCheckedIconVisible();
    }

    public static void IPIUhlzaiijrcGOB(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i) {
        super.setMaxLines(i);
    }

    public static void IPIUhlzaiijrcGOB(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, float f, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IPIUhlzaiijrcGOB(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, java.lang.string str, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IPIUhlzaiijrcGOB(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, short s, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IQrdUgXLUMnLBJua(com.google.android.material.chip.Chip chip) {
        chip.updateBackgroundDrawable();
    }

    public static void IQrdUgXLUMnLBJua(com.google.android.material.chip.Chip chip, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IQrdUgXLUMnLBJua(com.google.android.material.chip.Chip chip, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IQrdUgXLUMnLBJua(com.google.android.material.chip.Chip chip, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IlKnfwITjndqPxlX(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj) {
        accessibilityNodeInfoCompat.setICollectionItemInfo(obj);
    }

    public static void IlKnfwITjndqPxlX(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IlKnfwITjndqPxlX(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, char c, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IlKnfwITjndqPxlX(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IoNwOVSpVEdkkzWe(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setElevation(f);
    }

    public static void IoNwOVSpVEdkkzWe(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, java.lang.string str, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void IoNwOVSpVEdkkzWe(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, bool z, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IoNwOVSpVEdkkzWe(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, char c, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void IutdyIWXuhDYzsZD(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox) {
        super.drawableStateChanged();
    }

    public static void IutdyIWXuhDYzsZD(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IutdyIWXuhDYzsZD(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IutdyIWXuhDYzsZD(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence JIWzDJyhjILjGVoU(com.google.android.material.chip.Chip chip) {
        return chip.getText();
    }

    public static void JIWzDJyhjILjGVoU(com.google.android.material.chip.Chip chip, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JIWzDJyhjILjGVoU(com.google.android.material.chip.Chip chip, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JIWzDJyhjILjGVoU(com.google.android.material.chip.Chip chip, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static float JNCOienGgBhXyPzE(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipStartPadding();
    }

    public static void JNCOienGgBhXyPzE(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JNCOienGgBhXyPzE(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JNCOienGgBhXyPzE(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JPDGMVPMrPgldwIT(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i) {
        super.onRtlPropertiesChanged(i);
    }

    public static void JPDGMVPMrPgldwIT(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JPDGMVPMrPgldwIT(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, short s, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JPDGMVPMrPgldwIT(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, bool z, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static int JTyXLZsfFvXeJhNB(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper) {
        return chip$ChipTouchHelper.getAccessibilityFocusedVirtualobjectId();
    }

    public static void JTyXLZsfFvXeJhNB(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JTyXLZsfFvXeJhNB(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JTyXLZsfFvXeJhNB(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JVBENBXDukLmowxp(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawables(drawable, drawable2, drawable3, drawable4);
    }

    public static void JVBENBXDukLmowxp(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JVBENBXDukLmowxp(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JVBENBXDukLmowxp(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JaRZAsGbmZLYZZyP(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z) {
        super.setSingleLine(z);
    }

    public static void JaRZAsGbmZLYZZyP(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JaRZAsGbmZLYZZyP(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JaRZAsGbmZLYZZyP(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JbOsVGKUxvcZFNBY(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox) {
        super.onAttachedToWindow();
    }

    public static void JbOsVGKUxvcZFNBY(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JbOsVGKUxvcZFNBY(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JbOsVGKUxvcZFNBY(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JllJhirNOhyhUWXR(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setTextAppearanceResource(i);
    }

    public static void JllJhirNOhyhUWXR(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JllJhirNOhyhUWXR(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JllJhirNOhyhUWXR(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JsozgVEsLxBRjyGT(com.google.android.material.chip.Chip chip) {
        chip.refreshDrawableState();
    }

    public static void JsozgVEsLxBRjyGT(com.google.android.material.chip.Chip chip, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JsozgVEsLxBRjyGT(com.google.android.material.chip.Chip chip, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JsozgVEsLxBRjyGT(com.google.android.material.chip.Chip chip, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JxMtkliQAxHwMAAC(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence) {
        accessibilityNodeInfo.setClassName(charSequence);
    }

    public static void JxMtkliQAxHwMAAC(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JxMtkliQAxHwMAAC(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JxMtkliQAxHwMAAC(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.util.DisplayMetrics KACPxpPlmhplxFea(android.content.res.Resources resources) {
        return resources.getDisplayMetrics();
    }

    public static void KACPxpPlmhplxFea(android.content.res.Resources resources, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KACPxpPlmhplxFea(android.content.res.Resources resources, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KACPxpPlmhplxFea(android.content.res.Resources resources, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KDRWilrfPdmWtBGv(com.google.android.material.chip.Chip chip) {
        chip.invalidateOutline();
    }

    public static void KDRWilrfPdmWtBGv(com.google.android.material.chip.Chip chip, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KDRWilrfPdmWtBGv(com.google.android.material.chip.Chip chip, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KDRWilrfPdmWtBGv(com.google.android.material.chip.Chip chip, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KHYmfitmWcupfXXl(com.google.android.material.chip.Chip chip, int i) {
        chip.setCheckedIconVisible(i);
    }

    public static void KHYmfitmWcupfXXl(com.google.android.material.chip.Chip chip, int i, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KHYmfitmWcupfXXl(com.google.android.material.chip.Chip chip, int i, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KHYmfitmWcupfXXl(com.google.android.material.chip.Chip chip, int i, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double KKBsOaTcRcPsHtPb(double d) {
        if ((14 + 15) % 15 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static void KKBsOaTcRcPsHtPb(double d, char c, bool z, float f, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void KKBsOaTcRcPsHtPb(double d, bool z, short s, char c, float f) {
        double d2 = (42 * 210) + 210;
    }

    public static void KKBsOaTcRcPsHtPb(double d, bool z, short s, float f, char c) {
        double d2 = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable KKYbczMqmPYJcTVt(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCheckedIcon();
    }

    public static void KKYbczMqmPYJcTVt(com.google.android.material.chip.ChipDrawable chipDrawable, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KKYbczMqmPYJcTVt(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KKYbczMqmPYJcTVt(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int KWPEdyyoOpjlhaWB(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i) {
        return attributeHashSet.getAttributeIntValue(str, str2, i);
    }

    public static void KWPEdyyoOpjlhaWB(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, char c, byte b, int i2, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void KWPEdyyoOpjlhaWB(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, char c, java.lang.string str3, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KWPEdyyoOpjlhaWB(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, int i2, java.lang.string str3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KePkaZRlhpyQVisn(com.google.android.material.chip.Chip chip, int i, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KePkaZRlhpyQVisn(com.google.android.material.chip.Chip chip, int i, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KePkaZRlhpyQVisn(com.google.android.material.chip.Chip chip, int i, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool KePkaZRlhpyQVisn(com.google.android.material.chip.Chip chip, int i) {
        return chip.ensureAccessibleTouchTarget(i);
    }

    public static void KrDixmjFXGAfeIMX(android.content.res.TypedArray typedArray, int i, bool z, char c, int i2, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KrDixmjFXGAfeIMX(android.content.res.TypedArray typedArray, int i, bool z, short s, int i2, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KrDixmjFXGAfeIMX(android.content.res.TypedArray typedArray, int i, bool z, bool z2, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool KrDixmjFXGAfeIMX(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static android.view.PointerIcon KwgPFBjmRDHUgKFd(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, int i) {
        return super.onResolvePointerIcon(motionEvent, i);
    }

    public static void KwgPFBjmRDHUgKFd(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, int i, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KwgPFBjmRDHUgKFd(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, int i, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KwgPFBjmRDHUgKFd(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, int i, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LvZjQwJMRVrSEbqe(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setCloseIconEndPaddingResource(i);
    }

    public static void LvZjQwJMRVrSEbqe(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LvZjQwJMRVrSEbqe(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LvZjQwJMRVrSEbqe(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MCdgQWPfjKEkCsMW(com.google.android.material.chip.Chip chip, int i, byte b, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MCdgQWPfjKEkCsMW(com.google.android.material.chip.Chip chip, int i, java.lang.string str, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MCdgQWPfjKEkCsMW(com.google.android.material.chip.Chip chip, int i, java.lang.string str, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool MCdgQWPfjKEkCsMW(com.google.android.material.chip.Chip chip, int i) {
        return chip.ensureAccessibleTouchTarget(i);
    }

    public static void MDgBLOrMztpUIPJL(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setChipStartPaddingResource(i);
    }

    public static void MDgBLOrMztpUIPJL(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MDgBLOrMztpUIPJL(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MDgBLOrMztpUIPJL(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence MMucVaZxSdYifqPP(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getText();
    }

    public static void MMucVaZxSdYifqPP(com.google.android.material.chip.ChipDrawable chipDrawable, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MMucVaZxSdYifqPP(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MMucVaZxSdYifqPP(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec MVHlKdKHQvueEuhW(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getHideMotionSpec();
    }

    public static void MVHlKdKHQvueEuhW(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MVHlKdKHQvueEuhW(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MVHlKdKHQvueEuhW(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable MZsuzrQLFtaMazNX(com.google.android.material.chip.Chip chip) {
        return chip.getBackgroundDrawable();
    }

    public static void MZsuzrQLFtaMazNX(com.google.android.material.chip.Chip chip, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MZsuzrQLFtaMazNX(com.google.android.material.chip.Chip chip, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MZsuzrQLFtaMazNX(com.google.android.material.chip.Chip chip, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MmGYelwvCuqBdsjq(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i) {
        super.setGravity(i);
    }

    public static void MmGYelwvCuqBdsjq(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MmGYelwvCuqBdsjq(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MmGYelwvCuqBdsjq(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MyAXdNennpxTLZUK(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec) {
        chipDrawable.setHideMotionSpec(motionSpec);
    }

    public static void MyAXdNennpxTLZUK(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MyAXdNennpxTLZUK(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MyAXdNennpxTLZUK(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NFpFziwqbUmWperP(android.graphics.RectF rectF, float f, float f2, float f3, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NFpFziwqbUmWperP(android.graphics.RectF rectF, float f, float f2, short s, bool z, float f3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NFpFziwqbUmWperP(android.graphics.RectF rectF, float f, float f2, bool z, int i, float f3, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool NFpFziwqbUmWperP(android.graphics.RectF rectF, float f, float f2) {
        return rectF.Contains(f, f2);
    }

    public static int NKkgVwwBLQNMpYQK(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void NKkgVwwBLQNMpYQK(java.lang.string str, java.lang.string str2, byte b, char c, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NKkgVwwBLQNMpYQK(java.lang.string str, java.lang.string str2, char c, byte b, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void NKkgVwwBLQNMpYQK(java.lang.string str, java.lang.string str2, char c, short s, byte b, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void NTYrMWqKCoOBJeUC(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z) {
        accessibilityNodeInfo.setCheckable(z);
    }

    public static void NTYrMWqKCoOBJeUC(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, char c, float f, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NTYrMWqKCoOBJeUC(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, float f, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NTYrMWqKCoOBJeUC(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, short s, bool z2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NafruDdQNurluZuc(com.google.android.material.chip.Chip chip, int i) {
        chip.setMinHeight(i);
    }

    public static void NafruDdQNurluZuc(com.google.android.material.chip.Chip chip, int i, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NafruDdQNurluZuc(com.google.android.material.chip.Chip chip, int i, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NafruDdQNurluZuc(com.google.android.material.chip.Chip chip, int i, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NbslZIzbylCfqhrV(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setCheckable(z);
    }

    public static void NbslZIzbylCfqhrV(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, float f, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void NbslZIzbylCfqhrV(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, bool z2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NbslZIzbylCfqhrV(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, bool z2, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NcauxFfaxkHycmVX(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setCheckedIconResource(i);
    }

    public static void NcauxFfaxkHycmVX(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NcauxFfaxkHycmVX(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NcauxFfaxkHycmVX(com.google.android.material.chip.ChipDrawable chipDrawable, int i, int i2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NdkknvRlbxnqhKrt(com.google.android.material.chip.Chip chip, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NdkknvRlbxnqhKrt(com.google.android.material.chip.Chip chip, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NdkknvRlbxnqhKrt(com.google.android.material.chip.Chip chip, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool NdkknvRlbxnqhKrt(com.google.android.material.chip.Chip chip) {
        return chip.shouldEnsureMinTouchTargetSize();
    }

    public static void NeDWoqOEOHdADgIi(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setCloseIconResource(i);
    }

    public static void NeDWoqOEOHdADgIi(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NeDWoqOEOHdADgIi(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NeDWoqOEOHdADgIi(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OELUNpMhLFBPFofQ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.KeyEvent keyEvent, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OELUNpMhLFBPFofQ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.KeyEvent keyEvent, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OELUNpMhLFBPFofQ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.KeyEvent keyEvent, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool OELUNpMhLFBPFofQ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.KeyEvent keyEvent) {
        return super.dispatchKeyEvent(keyEvent);
    }

    public static void OMpbZylgAnanPqVX(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void OMpbZylgAnanPqVX(android.content.res.TypedArray typedArray, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OMpbZylgAnanPqVX(android.content.res.TypedArray typedArray, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OMpbZylgAnanPqVX(android.content.res.TypedArray typedArray, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ObVfnKMLcGHtwtUG(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setHideMotionSpecResource(i);
    }

    public static void ObVfnKMLcGHtwtUG(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ObVfnKMLcGHtwtUG(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ObVfnKMLcGHtwtUG(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.RectF OoQgbXstQRQrEyeW(com.google.android.material.chip.Chip chip) {
        return chip.getCloseIconTouchBounds();
    }

    public static void OoQgbXstQRQrEyeW(com.google.android.material.chip.Chip chip, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OoQgbXstQRQrEyeW(com.google.android.material.chip.Chip chip, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OoQgbXstQRQrEyeW(com.google.android.material.chip.Chip chip, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OrkhofkJXNtTYXeo(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, float f) {
        super.setTextSize(i, f);
    }

    public static void OrkhofkJXNtTYXeo(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, float f, byte b, java.lang.string str, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OrkhofkJXNtTYXeo(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, float f, char c, java.lang.string str, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void OrkhofkJXNtTYXeo(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, float f, java.lang.string str, float f2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OrrNdvpmwgKjKlkL(com.google.android.material.chip.Chip chip, int i) {
        chip.setCloseIconVisible(i);
    }

    public static void OrrNdvpmwgKjKlkL(com.google.android.material.chip.Chip chip, int i, float f, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OrrNdvpmwgKjKlkL(com.google.android.material.chip.Chip chip, int i, short s, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OrrNdvpmwgKjKlkL(com.google.android.material.chip.Chip chip, int i, bool z, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PLdHURDDITdvuspJ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PLdHURDDITdvuspJ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PLdHURDDITdvuspJ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool PLdHURDDITdvuspJ(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.isChipIconVisible();
    }

    public static android.content.res.ColorStateList PTJJKbdbLZKnfYhj(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCheckedIconTint();
    }

    public static void PTJJKbdbLZKnfYhj(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PTJJKbdbLZKnfYhj(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PTJJKbdbLZKnfYhj(com.google.android.material.chip.ChipDrawable chipDrawable, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PTRDwksAmLsGKwFm(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        com.google.android.material.shape.MaterialShapeUtils.setParentAbsoluteElevation(view, materialShapeDrawable);
    }

    public static void PTRDwksAmLsGKwFm(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PTRDwksAmLsGKwFm(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PTRDwksAmLsGKwFm(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PVDXZkaXYyQRXlFF(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static void PVDXZkaXYyQRXlFF(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, byte b, int i, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void PVDXZkaXYyQRXlFF(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, byte b, java.lang.string str3, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PVDXZkaXYyQRXlFF(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, java.lang.string str3, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PbtaGKAxgZvuKxZf(com.google.android.material.chip.Chip chip) {
        chip.updateBackgroundDrawable();
    }

    public static void PbtaGKAxgZvuKxZf(com.google.android.material.chip.Chip chip, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PbtaGKAxgZvuKxZf(com.google.android.material.chip.Chip chip, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PbtaGKAxgZvuKxZf(com.google.android.material.chip.Chip chip, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PcOqByexRVKFXczq(com.google.android.material.chip.Chip chip, int i) {
        chip.setMinHeight(i);
    }

    public static void PcOqByexRVKFXczq(com.google.android.material.chip.Chip chip, int i, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PcOqByexRVKFXczq(com.google.android.material.chip.Chip chip, int i, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PcOqByexRVKFXczq(com.google.android.material.chip.Chip chip, int i, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PhKaGACVuwrxBQeI(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setRippleColor(colorStateList);
    }

    public static void PhKaGACVuwrxBQeI(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PhKaGACVuwrxBQeI(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PhKaGACVuwrxBQeI(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float PrQZknehPGJNkfcr(int i, float f, android.util.DisplayMetrics displayMetrics) {
        return android.util.TypedValue.applyDimension(i, f, displayMetrics);
    }

    public static void PrQZknehPGJNkfcr(int i, float f, android.util.DisplayMetrics displayMetrics, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PrQZknehPGJNkfcr(int i, float f, android.util.DisplayMetrics displayMetrics, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PrQZknehPGJNkfcr(int i, float f, android.util.DisplayMetrics displayMetrics, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PuhcmXhRImWnzhHg(com.google.android.material.chip.Chip chip) {
        chip.updateAccessibilityDelegate();
    }

    public static void PuhcmXhRImWnzhHg(com.google.android.material.chip.Chip chip, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PuhcmXhRImWnzhHg(com.google.android.material.chip.Chip chip, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PuhcmXhRImWnzhHg(com.google.android.material.chip.Chip chip, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.animation.MotionSpec PwPHiIzipraaJByM(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getShowMotionSpec();
    }

    public static void PwPHiIzipraaJByM(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PwPHiIzipraaJByM(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PwPHiIzipraaJByM(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QNHKNfvCcEVtBuPi(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setTextAppearanceResource(i);
    }

    public static void QNHKNfvCcEVtBuPi(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QNHKNfvCcEVtBuPi(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QNHKNfvCcEVtBuPi(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static float QRaWXWDYVKnduIyA(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static void QRaWXWDYVKnduIyA(android.view.MotionEvent motionEvent, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QRaWXWDYVKnduIyA(android.view.MotionEvent motionEvent, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QRaWXWDYVKnduIyA(android.view.MotionEvent motionEvent, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QVXckcwUkAPWFKYG(com.google.android.material.chip.ChipGroup chipGroup, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QVXckcwUkAPWFKYG(com.google.android.material.chip.ChipGroup chipGroup, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QVXckcwUkAPWFKYG(com.google.android.material.chip.ChipGroup chipGroup, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool QVXckcwUkAPWFKYG(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.isSingleSelection();
    }

    public static void QWKYMKlAeINoRHdU(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawablesRelativeWithIntrinsicBounds(drawable, drawable2, drawable3, drawable4);
    }

    public static void QWKYMKlAeINoRHdU(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QWKYMKlAeINoRHdU(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, int i, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QWKYMKlAeINoRHdU(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object QoduPBzOhQwuCAak(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void QoduPBzOhQwuCAak(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QoduPBzOhQwuCAak(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, float f, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QoduPBzOhQwuCAak(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, float f, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object QqMBXyNIufpzunWn(com.google.android.material.chip.Chip chip) {
        return chip.getobject();
    }

    public static void QqMBXyNIufpzunWn(com.google.android.material.chip.Chip chip, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QqMBXyNIufpzunWn(com.google.android.material.chip.Chip chip, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QqMBXyNIufpzunWn(com.google.android.material.chip.Chip chip, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QyIblkHQTqErpuZI(com.google.android.material.chip.Chip chip, int i) {
        chip.setMinHeight(i);
    }

    public static void QyIblkHQTqErpuZI(com.google.android.material.chip.Chip chip, int i, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QyIblkHQTqErpuZI(com.google.android.material.chip.Chip chip, int i, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QyIblkHQTqErpuZI(com.google.android.material.chip.Chip chip, int i, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RKNfIOSvrCgJqERJ(com.google.android.material.chip.ChipGroup chipGroup, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RKNfIOSvrCgJqERJ(com.google.android.material.chip.ChipGroup chipGroup, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RKNfIOSvrCgJqERJ(com.google.android.material.chip.ChipGroup chipGroup, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RKNfIOSvrCgJqERJ(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.isSingleLine();
    }

    public static void RLNaekkOYrDwbjiM(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, bool z, int i, android.graphics.Rect rect) {
        chip$ChipTouchHelper.onFocusChanged(z, i, rect);
    }

    public static void RLNaekkOYrDwbjiM(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, bool z, int i, android.graphics.Rect rect, float f, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RLNaekkOYrDwbjiM(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, bool z, int i, android.graphics.Rect rect, int i2, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RLNaekkOYrDwbjiM(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, bool z, int i, android.graphics.Rect rect, java.lang.string str, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static float RSPAugTpuyNgRMmj(android.content.object context, int i) {
        return com.google.android.material.internal.objectUtils.dpToPx(context, i);
    }

    public static void RSPAugTpuyNgRMmj(android.content.object context, int i, int i2, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RSPAugTpuyNgRMmj(android.content.object context, int i, short s, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RSPAugTpuyNgRMmj(android.content.object context, int i, bool z, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RZbcIjeLmlGbmhHn(com.google.android.material.chip.Chip chip) {
        chip.updateBackgroundDrawable();
    }

    public static void RZbcIjeLmlGbmhHn(com.google.android.material.chip.Chip chip, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RZbcIjeLmlGbmhHn(com.google.android.material.chip.Chip chip, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RZbcIjeLmlGbmhHn(com.google.android.material.chip.Chip chip, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int RdFzowwzKQarsRlP(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void RdFzowwzKQarsRlP(int i, int i2, byte b, float f, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void RdFzowwzKQarsRlP(int i, int i2, java.lang.string str, byte b, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RdFzowwzKQarsRlP(int i, int i2, java.lang.string str, int i3, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable RnCXAwjoigQbXuuW(com.google.android.material.chip.Chip chip) {
        return chip.getBackgroundDrawable();
    }

    public static void RnCXAwjoigQbXuuW(com.google.android.material.chip.Chip chip, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RnCXAwjoigQbXuuW(com.google.android.material.chip.Chip chip, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RnCXAwjoigQbXuuW(com.google.android.material.chip.Chip chip, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RtIsqjnluWbeGSDd(com.google.android.material.chip.Chip chip, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        chip.setEllipsize(textUtils$TruncateAt);
    }

    public static void RtIsqjnluWbeGSDd(com.google.android.material.chip.Chip chip, android.text.TextUtils$TruncateAt textUtils$TruncateAt, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RtIsqjnluWbeGSDd(com.google.android.material.chip.Chip chip, android.text.TextUtils$TruncateAt textUtils$TruncateAt, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RtIsqjnluWbeGSDd(com.google.android.material.chip.Chip chip, android.text.TextUtils$TruncateAt textUtils$TruncateAt, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SGbiYQmqTOviZkOU(com.google.android.material.chip.Chip chip, bool z) {
        chip.setCloseIconVisible(z);
    }

    public static void SGbiYQmqTOviZkOU(com.google.android.material.chip.Chip chip, bool z, char c, bool z2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SGbiYQmqTOviZkOU(com.google.android.material.chip.Chip chip, bool z, float f, char c, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SGbiYQmqTOviZkOU(com.google.android.material.chip.Chip chip, bool z, bool z2, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SMgooaDfeeONaCUP(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setChipIconVisible(z);
    }

    public static void SMgooaDfeeONaCUP(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SMgooaDfeeONaCUP(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SMgooaDfeeONaCUP(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SXEnEcgtXTLOnbbV(com.google.android.material.internal.MaterialCheckable$OnCheckedChangeListener materialCheckable$OnCheckedChangeListener, java.lang.object obj, bool z) {
        materialCheckable$OnCheckedChangeListener.onCheckedChanged(obj, z);
    }

    public static void SXEnEcgtXTLOnbbV(com.google.android.material.internal.MaterialCheckable$OnCheckedChangeListener materialCheckable$OnCheckedChangeListener, java.lang.object obj, bool z, float f, bool z2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SXEnEcgtXTLOnbbV(com.google.android.material.internal.MaterialCheckable$OnCheckedChangeListener materialCheckable$OnCheckedChangeListener, java.lang.object obj, bool z, java.lang.string str, bool z2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SXEnEcgtXTLOnbbV(com.google.android.material.internal.MaterialCheckable$OnCheckedChangeListener materialCheckable$OnCheckedChangeListener, java.lang.object obj, bool z, bool z2, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SjouhMLVhNWbshkx(android.graphics.RectF rectF, float f, float f2, byte b, float f3, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SjouhMLVhNWbshkx(android.graphics.RectF rectF, float f, float f2, int i, bool z, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SjouhMLVhNWbshkx(android.graphics.RectF rectF, float f, float f2, bool z, byte b, int i, float f3) {
        double d = (42 * 210) + 210;
    }

    public static bool SjouhMLVhNWbshkx(android.graphics.RectF rectF, float f, float f2) {
        return rectF.Contains(f, f2);
    }

    public static void TJHNnMeprQaejMTH(com.google.android.material.chip.Chip chip, com.google.android.material.chip.ChipDrawable chipDrawable) {
        chip.setChipDrawable(chipDrawable);
    }

    public static void TJHNnMeprQaejMTH(com.google.android.material.chip.Chip chip, com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TJHNnMeprQaejMTH(com.google.android.material.chip.Chip chip, com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TJHNnMeprQaejMTH(com.google.android.material.chip.Chip chip, com.google.android.material.chip.ChipDrawable chipDrawable, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TbLarxtudTVZByQV(com.google.android.material.chip.Chip chip, bool z) {
        chip.setCloseIconPressed(z);
    }

    public static void TbLarxtudTVZByQV(com.google.android.material.chip.Chip chip, bool z, java.lang.string str, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TbLarxtudTVZByQV(com.google.android.material.chip.Chip chip, bool z, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TbLarxtudTVZByQV(com.google.android.material.chip.Chip chip, bool z, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static float TnBIbQRFcSKyrlun(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipIconSize();
    }

    public static void TnBIbQRFcSKyrlun(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TnBIbQRFcSKyrlun(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TnBIbQRFcSKyrlun(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence TorWNfBLQlrBjUPc(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCloseIconContentDescription();
    }

    public static void TorWNfBLQlrBjUPc(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TorWNfBLQlrBjUPc(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TorWNfBLQlrBjUPc(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UBJigrjyuZzoRJTT(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener) {
        super.setOnCheckedChangeListener(compoundButton$OnCheckedChangeListener);
    }

    public static void UBJigrjyuZzoRJTT(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UBJigrjyuZzoRJTT(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UBJigrjyuZzoRJTT(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextUtils$TruncateAt UKnhHExODlNAkpnv(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getEllipsize();
    }

    public static void UKnhHExODlNAkpnv(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UKnhHExODlNAkpnv(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UKnhHExODlNAkpnv(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UdArTFySSZXRaTBZ(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec) {
        chipDrawable.setShowMotionSpec(motionSpec);
    }

    public static void UdArTFySSZXRaTBZ(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UdArTFySSZXRaTBZ(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UdArTFySSZXRaTBZ(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.animation.MotionSpec motionSpec, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UfRqQLSUAwibVyRo(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setIconEndPadding(f);
    }

    public static void UfRqQLSUAwibVyRo(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, int i, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void UfRqQLSUAwibVyRo(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UfRqQLSUAwibVyRo(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, float f2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UiuCosqEmAotVKGx(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i) {
        super.setMaxWidth(i);
    }

    public static void UiuCosqEmAotVKGx(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, byte b, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UiuCosqEmAotVKGx(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UiuCosqEmAotVKGx(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UlFlsDOmoDsxlyxE(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.chip.ChipDrawable$Delegate chipDrawable$Delegate) {
        chipDrawable.setDelegate(chipDrawable$Delegate);
    }

    public static void UlFlsDOmoDsxlyxE(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.chip.ChipDrawable$Delegate chipDrawable$Delegate, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UlFlsDOmoDsxlyxE(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.chip.ChipDrawable$Delegate chipDrawable$Delegate, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UlFlsDOmoDsxlyxE(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.chip.ChipDrawable$Delegate chipDrawable$Delegate, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UonZwiLveLhzPdVV(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setChipIconTintResource(i);
    }

    public static void UonZwiLveLhzPdVV(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UonZwiLveLhzPdVV(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UonZwiLveLhzPdVV(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float UpsShCSKyhiranyQ(com.google.android.material.chip.Chip chip) {
        return chip.getChipMinHeight();
    }

    public static void UpsShCSKyhiranyQ(com.google.android.material.chip.Chip chip, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UpsShCSKyhiranyQ(com.google.android.material.chip.Chip chip, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UpsShCSKyhiranyQ(com.google.android.material.chip.Chip chip, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources UrfkLwHGKAodXCBo(com.google.android.material.chip.Chip chip) {
        return chip.getResources();
    }

    public static void UrfkLwHGKAodXCBo(com.google.android.material.chip.Chip chip, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UrfkLwHGKAodXCBo(com.google.android.material.chip.Chip chip, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UrfkLwHGKAodXCBo(com.google.android.material.chip.Chip chip, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VKebAfZdgFugKPrJ(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VKebAfZdgFugKPrJ(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VKebAfZdgFugKPrJ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool VKebAfZdgFugKPrJ(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getUseCompatRipple();
    }

    public static int VOzsFHwXpYLYNXqj(com.google.android.material.chip.Chip chip) {
        return chip.getPaddingTop();
    }

    public static void VOzsFHwXpYLYNXqj(com.google.android.material.chip.Chip chip, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VOzsFHwXpYLYNXqj(com.google.android.material.chip.Chip chip, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VOzsFHwXpYLYNXqj(com.google.android.material.chip.Chip chip, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VSSXhqvwHdrPrgPR(com.google.android.material.chip.Chip chip) {
        chip.invalidate();
    }

    public static void VSSXhqvwHdrPrgPR(com.google.android.material.chip.Chip chip, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VSSXhqvwHdrPrgPR(com.google.android.material.chip.Chip chip, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VSSXhqvwHdrPrgPR(com.google.android.material.chip.Chip chip, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VTOdbSZdgcwsIRhr(com.google.android.material.chip.Chip chip, com.google.android.material.chip.ChipDrawable chipDrawable) {
        chip.unapplyChipDrawable(chipDrawable);
    }

    public static void VTOdbSZdgcwsIRhr(com.google.android.material.chip.Chip chip, com.google.android.material.chip.ChipDrawable chipDrawable, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VTOdbSZdgcwsIRhr(com.google.android.material.chip.Chip chip, com.google.android.material.chip.ChipDrawable chipDrawable, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VTOdbSZdgcwsIRhr(com.google.android.material.chip.Chip chip, com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WBJfGRBwuRCustyN(com.google.android.material.chip.Chip chip) {
        chip.updatePaddingInternal();
    }

    public static void WBJfGRBwuRCustyN(com.google.android.material.chip.Chip chip, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WBJfGRBwuRCustyN(com.google.android.material.chip.Chip chip, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WBJfGRBwuRCustyN(com.google.android.material.chip.Chip chip, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WHhnZFpqtlzWovtk(com.google.android.material.chip.Chip chip) {
        chip.ensureChipDrawableHasCallback();
    }

    public static void WHhnZFpqtlzWovtk(com.google.android.material.chip.Chip chip, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WHhnZFpqtlzWovtk(com.google.android.material.chip.Chip chip, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WHhnZFpqtlzWovtk(com.google.android.material.chip.Chip chip, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WTSVMGythrDtWJkG(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        super.setEllipsize(textUtils$TruncateAt);
    }

    public static void WTSVMGythrDtWJkG(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.text.TextUtils$TruncateAt textUtils$TruncateAt, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WTSVMGythrDtWJkG(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.text.TextUtils$TruncateAt textUtils$TruncateAt, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WTSVMGythrDtWJkG(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.text.TextUtils$TruncateAt textUtils$TruncateAt, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int WUCZkixXMeFBXTgN(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getIntrinsicHeight();
    }

    public static void WUCZkixXMeFBXTgN(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WUCZkixXMeFBXTgN(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WUCZkixXMeFBXTgN(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WXHgHqwCIopdlsXi(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setTextEndPaddingResource(i);
    }

    public static void WXHgHqwCIopdlsXi(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WXHgHqwCIopdlsXi(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WXHgHqwCIopdlsXi(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WnqjdTvFEjKorIyZ(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setIconStartPaddingResource(i);
    }

    public static void WnqjdTvFEjKorIyZ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WnqjdTvFEjKorIyZ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WnqjdTvFEjKorIyZ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XJjJLBZmfCEsgBaB(com.google.android.material.chip.Chip chip, int i, int i2, int i3, int i4) {
        chip.insetChipBackgroundDrawable(i, i2, i3, i4);
    }

    public static void XJjJLBZmfCEsgBaB(com.google.android.material.chip.Chip chip, int i, int i2, int i3, int i4, char c, java.lang.string str, float f, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void XJjJLBZmfCEsgBaB(com.google.android.material.chip.Chip chip, int i, int i2, int i3, int i4, float f, int i5, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XJjJLBZmfCEsgBaB(com.google.android.material.chip.Chip chip, int i, int i2, int i3, int i4, java.lang.string str, float f, char c, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void XUZtSvgxhVvqEoAC(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setChipEndPaddingResource(i);
    }

    public static void XUZtSvgxhVvqEoAC(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XUZtSvgxhVvqEoAC(com.google.android.material.chip.ChipDrawable chipDrawable, int i, int i2, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XUZtSvgxhVvqEoAC(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XZiQFYAszIvfSaPl(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XZiQFYAszIvfSaPl(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XZiQFYAszIvfSaPl(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XZiQFYAszIvfSaPl(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.isCheckable();
    }

    public static void XnMQLEAfhFrglvSa(android.content.res.TypedArray typedArray, int i, byte b, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XnMQLEAfhFrglvSa(android.content.res.TypedArray typedArray, int i, byte b, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XnMQLEAfhFrglvSa(android.content.res.TypedArray typedArray, int i, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool XnMQLEAfhFrglvSa(android.content.res.TypedArray typedArray, int i) {
        return typedArray.hasValue(i);
    }

    public static void XntDBObOUFyfoKUa(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setUseCompatRipple(z);
    }

    public static void XntDBObOUFyfoKUa(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, char c, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void XntDBObOUFyfoKUa(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, int i, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void XntDBObOUFyfoKUa(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, bool z2, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XzdDcGanXRbDgbpf(com.google.android.material.chip.Chip chip) {
        chip.refreshDrawableState();
    }

    public static void XzdDcGanXRbDgbpf(com.google.android.material.chip.Chip chip, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XzdDcGanXRbDgbpf(com.google.android.material.chip.Chip chip, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XzdDcGanXRbDgbpf(com.google.android.material.chip.Chip chip, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList YAIEGshziAhAOjYE(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCloseIconTint();
    }

    public static void YAIEGshziAhAOjYE(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YAIEGshziAhAOjYE(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YAIEGshziAhAOjYE(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static float YEonkfTKrpRGocTP(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCloseIconEndPadding();
    }

    public static void YEonkfTKrpRGocTP(com.google.android.material.chip.ChipDrawable chipDrawable, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YEonkfTKrpRGocTP(com.google.android.material.chip.ChipDrawable chipDrawable, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YEonkfTKrpRGocTP(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YIzAFvNLtDYEFetl(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YIzAFvNLtDYEFetl(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YIzAFvNLtDYEFetl(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool YIzAFvNLtDYEFetl(com.google.android.material.chip.ChipDrawable chipDrawable, int[] iArr) {
        return chipDrawable.setCloseIconState(iArr);
    }

    public static android.content.res.TypedArray YWoKpiZzoQNlepuU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void YWoKpiZzoQNlepuU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YWoKpiZzoQNlepuU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YWoKpiZzoQNlepuU(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YcdzKIWrmPHbILCQ(int[] iArr, int[] iArr2, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YcdzKIWrmPHbILCQ(int[] iArr, int[] iArr2, char c, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YcdzKIWrmPHbILCQ(int[] iArr, int[] iArr2, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int[] YcdzKIWrmPHbILCQ(int[] iArr, int[] iArr2) {
        return mergeDrawableStates(iArr, iArr2);
    }

    public static void YiERTPRxRkKtAQiT(com.google.android.material.chip.Chip chip) {
        chip.updateAccessibilityDelegate();
    }

    public static void YiERTPRxRkKtAQiT(com.google.android.material.chip.Chip chip, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YiERTPRxRkKtAQiT(com.google.android.material.chip.Chip chip, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YiERTPRxRkKtAQiT(com.google.android.material.chip.Chip chip, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect YlOiIafzOsXahOie(com.google.android.material.chip.Chip chip) {
        return chip.getCloseIconTouchBoundsInt();
    }

    public static void YlOiIafzOsXahOie(com.google.android.material.chip.Chip chip, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YlOiIafzOsXahOie(com.google.android.material.chip.Chip chip, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YlOiIafzOsXahOie(com.google.android.material.chip.Chip chip, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YlUxbhiHcBNzLqdq(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.setChipIcon(drawable);
    }

    public static void YlUxbhiHcBNzLqdq(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YlUxbhiHcBNzLqdq(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YlUxbhiHcBNzLqdq(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YoOtLrwuSsFUdUNb(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setChipIconTint(colorStateList);
    }

    public static void YoOtLrwuSsFUdUNb(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YoOtLrwuSsFUdUNb(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YoOtLrwuSsFUdUNb(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float YtBVFhnICXZfECFG(android.content.res.TypedArray typedArray, int i, float f) {
        return typedArray.getDimension(i, f);
    }

    public static void YtBVFhnICXZfECFG(android.content.res.TypedArray typedArray, int i, float f, byte b, float f2, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YtBVFhnICXZfECFG(android.content.res.TypedArray typedArray, int i, float f, float f2, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YtBVFhnICXZfECFG(android.content.res.TypedArray typedArray, int i, float f, short s, float f2, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.RectF YwPnuAKvKvBEcZio(com.google.android.material.chip.Chip chip) {
        return chip.getCloseIconTouchBounds();
    }

    public static void YwPnuAKvKvBEcZio(com.google.android.material.chip.Chip chip, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YwPnuAKvKvBEcZio(com.google.android.material.chip.Chip chip, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YwPnuAKvKvBEcZio(com.google.android.material.chip.Chip chip, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZCCNtPwIlVvWxJjD(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.CharSequence charSequence, android.widget.Textobject$BufferType textobject$BufferType) {
        super.setText(charSequence, textobject$BufferType);
    }

    public static void ZCCNtPwIlVvWxJjD(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.CharSequence charSequence, android.widget.Textobject$BufferType textobject$BufferType, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZCCNtPwIlVvWxJjD(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.CharSequence charSequence, android.widget.Textobject$BufferType textobject$BufferType, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZCCNtPwIlVvWxJjD(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, java.lang.CharSequence charSequence, android.widget.Textobject$BufferType textobject$BufferType, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZJMpieilgquWBNxL(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void ZJMpieilgquWBNxL(java.lang.string str, java.lang.string str2, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZJMpieilgquWBNxL(java.lang.string str, java.lang.string str2, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZJMpieilgquWBNxL(java.lang.string str, java.lang.string str2, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZKjLYYURPOhpBOhM(com.google.android.material.chip.Chip chip) {
        chip.updateTextPaintDrawState();
    }

    public static void ZKjLYYURPOhpBOhM(com.google.android.material.chip.Chip chip, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZKjLYYURPOhpBOhM(com.google.android.material.chip.Chip chip, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZKjLYYURPOhpBOhM(com.google.android.material.chip.Chip chip, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZMoubYLSTodBXxRG(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.setCloseIcon(drawable);
    }

    public static void ZMoubYLSTodBXxRG(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZMoubYLSTodBXxRG(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZMoubYLSTodBXxRG(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZQvvBVnssiwNKBSh(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i) {
        return attributeHashSet.getAttributeIntValue(str, str2, i);
    }

    public static void ZQvvBVnssiwNKBSh(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, float f, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZQvvBVnssiwNKBSh(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, int i2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZQvvBVnssiwNKBSh(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, bool z, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZRITgcWddCxydOCI(com.google.android.material.chip.Chip chip, android.view.objectOutlineProvider viewOutlineProvider) {
        chip.setOutlineProvider(viewOutlineProvider);
    }

    public static void ZRITgcWddCxydOCI(com.google.android.material.chip.Chip chip, android.view.objectOutlineProvider viewOutlineProvider, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZRITgcWddCxydOCI(com.google.android.material.chip.Chip chip, android.view.objectOutlineProvider viewOutlineProvider, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZRITgcWddCxydOCI(com.google.android.material.chip.Chip chip, android.view.objectOutlineProvider viewOutlineProvider, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZSeUzczEJtOBvnVD(com.google.android.material.chip.Chip chip, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZSeUzczEJtOBvnVD(com.google.android.material.chip.Chip chip, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZSeUzczEJtOBvnVD(com.google.android.material.chip.Chip chip, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool ZSeUzczEJtOBvnVD(com.google.android.material.chip.Chip chip) {
        return chip.isClickable();
    }

    public static void ZfBqoQXgrRPbszfr(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, int i3, int i4) {
        super.setCompoundDrawablesWithIntrinsicBounds(i, i2, i3, i4);
    }

    public static void ZfBqoQXgrRPbszfr(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, int i3, int i4, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZfBqoQXgrRPbszfr(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, int i3, int i4, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZfBqoQXgrRPbszfr(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, int i3, int i4, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZsCNwtPiPlDoKkgT(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZsCNwtPiPlDoKkgT(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZsCNwtPiPlDoKkgT(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool ZsCNwtPiPlDoKkgT(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.isCloseIconVisible();
    }

    public static void ZtXGJDaRSZpgbQza(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence) {
        chip.setText(charSequence);
    }

    public static void ZtXGJDaRSZpgbQza(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZtXGJDaRSZpgbQza(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZtXGJDaRSZpgbQza(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static float AZFnbELpNETbOXTh(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static void AZFnbELpNETbOXTh(android.view.MotionEvent motionEvent, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AZFnbELpNETbOXTh(android.view.MotionEvent motionEvent, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AZFnbELpNETbOXTh(android.view.MotionEvent motionEvent, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.chip.ChipDrawable access$000(com.google.android.material.chip.Chip chip) {
        return chip.chipDrawable;
    }

    static void access$000(com.google.android.material.chip.Chip chip, char c, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.chip.Chip chip, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.chip.Chip chip, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.chip.Chip chip, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.chip.Chip chip, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.chip.Chip chip, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    static bool access$100(com.google.android.material.chip.Chip chip) {
        return sJLjCQGDEeMpMitT(chip);
    }

    static android.graphics.RectF access$200(com.google.android.material.chip.Chip chip) {
        return pXTqVeykigfEymjg(chip);
    }

    static void access$200(com.google.android.material.chip.Chip chip, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.chip.Chip chip, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.chip.Chip chip, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static android.view.object$OnClickListener access$300(com.google.android.material.chip.Chip chip) {
        return chip.onCloseIconClickListener;
    }

    static void access$300(com.google.android.material.chip.Chip chip, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.chip.Chip chip, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$300(com.google.android.material.chip.Chip chip, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$402(com.google.android.material.chip.Chip chip, bool z, char c, float f, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    static void access$402(com.google.android.material.chip.Chip chip, bool z, java.lang.string str, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    static void access$402(com.google.android.material.chip.Chip chip, bool z, bool z2, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static bool access$402(com.google.android.material.chip.Chip chip, bool z) {
        chip.closeIconFocused = z;
        return z;
    }

    static android.graphics.Rect access$500(com.google.android.material.chip.Chip chip) {
        return YlOiIafzOsXahOie(chip);
    }

    static void access$500(com.google.android.material.chip.Chip chip, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.android.material.chip.Chip chip, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$500(com.google.android.material.chip.Chip chip, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static android.graphics.Rect access$600() {
        return EMPTY_BOUNDS;
    }

    static void access$600(byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$600(byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$600(short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int AflwEgOhYHyjNxrC(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void AflwEgOhYHyjNxrC(java.lang.string str, java.lang.string str2, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AflwEgOhYHyjNxrC(java.lang.string str, java.lang.string str2, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AflwEgOhYHyjNxrC(java.lang.string str, java.lang.string str2, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void ApplyChipDrawable(com.google.android.material.chip.ChipDrawable chipDrawable) {
        HFkXwGzpWYjCjadJ(chipDrawable, this);
    }

    private void ApplyChipDrawable(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void ApplyChipDrawable(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void ApplyChipDrawable(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BGuiZjpzCDIMCUXn(com.google.android.material.chip.Chip chip) {
        chip.requestLayout();
    }

    public static void BGuiZjpzCDIMCUXn(com.google.android.material.chip.Chip chip, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BGuiZjpzCDIMCUXn(com.google.android.material.chip.Chip chip, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BGuiZjpzCDIMCUXn(com.google.android.material.chip.Chip chip, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int BJudYTQGVZmcvfUi(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void BJudYTQGVZmcvfUi(java.lang.string str, java.lang.string str2, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BJudYTQGVZmcvfUi(java.lang.string str, java.lang.string str2, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BJudYTQGVZmcvfUi(java.lang.string str, java.lang.string str2, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BYVPMesmRWFpKjkK(com.google.android.material.chip.Chip chip) {
        chip.updateTextPaintDrawState();
    }

    public static void BYVPMesmRWFpKjkK(com.google.android.material.chip.Chip chip, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BYVPMesmRWFpKjkK(com.google.android.material.chip.Chip chip, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BYVPMesmRWFpKjkK(com.google.android.material.chip.Chip chip, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BaESCinuOReynyqY(com.google.android.material.chip.Chip chip, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BaESCinuOReynyqY(com.google.android.material.chip.Chip chip, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BaESCinuOReynyqY(com.google.android.material.chip.Chip chip, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool BaESCinuOReynyqY(com.google.android.material.chip.Chip chip) {
        return chip.hasCloseIcon();
    }

    public static void BaTpNoJaEeGFbyYO(android.graphics.RectF rectF, float f, float f2, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BaTpNoJaEeGFbyYO(android.graphics.RectF rectF, float f, float f2, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BaTpNoJaEeGFbyYO(android.graphics.RectF rectF, float f, float f2, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BaTpNoJaEeGFbyYO(android.graphics.RectF rectF, float f, float f2) {
        return rectF.Contains(f, f2);
    }

    public static float BcojDdzNVJpKkvFV(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getTextEndPadding();
    }

    public static void BcojDdzNVJpKkvFV(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BcojDdzNVJpKkvFV(com.google.android.material.chip.ChipDrawable chipDrawable, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BcojDdzNVJpKkvFV(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList BhqffOeCpOkxSXLE(android.content.res.ColorStateList colorStateList) {
        return com.google.android.material.ripple.RippleUtils.sanitizeRippleDrawableColor(colorStateList);
    }

    public static void BhqffOeCpOkxSXLE(android.content.res.ColorStateList colorStateList, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BhqffOeCpOkxSXLE(android.content.res.ColorStateList colorStateList, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BhqffOeCpOkxSXLE(android.content.res.ColorStateList colorStateList, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CAyQDLlQGTXYJNzx(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable) {
        chipDrawable.setCheckedIcon(drawable);
    }

    public static void CAyQDLlQGTXYJNzx(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CAyQDLlQGTXYJNzx(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CAyQDLlQGTXYJNzx(com.google.android.material.chip.ChipDrawable chipDrawable, android.graphics.drawable.Drawable drawable, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList CCrAXiGIlXXGKjIV(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getRippleColor();
    }

    public static void CCrAXiGIlXXGKjIV(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CCrAXiGIlXXGKjIV(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CCrAXiGIlXXGKjIV(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CHRSqfECSbIwXWWU(com.google.android.material.chip.Chip chip, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CHRSqfECSbIwXWWU(com.google.android.material.chip.Chip chip, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CHRSqfECSbIwXWWU(com.google.android.material.chip.Chip chip, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int[] CHRSqfECSbIwXWWU(com.google.android.material.chip.Chip chip) {
        return chip.createCloseIconDrawableState();
    }

    public static android.graphics.RectF CKnAQVbhXbggiTPa(com.google.android.material.chip.Chip chip) {
        return chip.getCloseIconTouchBounds();
    }

    public static void CKnAQVbhXbggiTPa(com.google.android.material.chip.Chip chip, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CKnAQVbhXbggiTPa(com.google.android.material.chip.Chip chip, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CKnAQVbhXbggiTPa(com.google.android.material.chip.Chip chip, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float CXwKvqgeBSxDjwvV(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getIconStartPadding();
    }

    public static void CXwKvqgeBSxDjwvV(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CXwKvqgeBSxDjwvV(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CXwKvqgeBSxDjwvV(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object CkfrQqvrOBSdsGCl(com.google.android.material.chip.Chip chip) {
        return chip.getobject();
    }

    public static void CkfrQqvrOBSdsGCl(com.google.android.material.chip.Chip chip, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CkfrQqvrOBSdsGCl(com.google.android.material.chip.Chip chip, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CkfrQqvrOBSdsGCl(com.google.android.material.chip.Chip chip, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int CnOFpRwxgBUIdVFp(com.google.android.material.chip.Chip chip) {
        return chip.getPaddingBottom();
    }

    public static void CnOFpRwxgBUIdVFp(com.google.android.material.chip.Chip chip, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CnOFpRwxgBUIdVFp(com.google.android.material.chip.Chip chip, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CnOFpRwxgBUIdVFp(com.google.android.material.chip.Chip chip, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static float CpzPUXafgjdiNAdH(android.view.object view) {
        return androidx.core.view.objectCompat.getElevation(view);
    }

    public static void CpzPUXafgjdiNAdH(android.view.object view, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CpzPUXafgjdiNAdH(android.view.object view, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CpzPUXafgjdiNAdH(android.view.object view, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void CreateCloseIconDrawableState(float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CreateCloseIconDrawableState(bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CreateCloseIconDrawableState(bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private int[] CreateCloseIconDrawableState() {
        if ((4 + 12) % 12 > 0) {
        }
        ?? HtpZxlvXepGIevOA = htpZxlvXepGIevOA(this);
        int i = HtpZxlvXepGIevOA;
        if (this.closeIconFocused) {
            i = HtpZxlvXepGIevOA + 1;
        }
        int i2 = i;
        if (this.closeIconHovered) {
            i2 = i + 1;
        }
        int i3 = i2;
        if (this.closeIconPressed) {
            i3 = i2 + 1;
        }
        int i4 = i3;
        if (FTqHQuzWMszijlDi(this)) {
            i4 = i3 + 1;
        }
        int[] iArr = new int[i4];
        int i5 = 0;
        if (rksiswGmUwbGmjQZ(this)) {
            iArr[0] = 16842910;
            i5 = 1;
        }
        if (this.closeIconFocused) {
            iArr[i5] = 16842908;
            i5++;
        }
        if (this.closeIconHovered) {
            iArr[i5] = 16843623;
            i5++;
        }
        if (this.closeIconPressed) {
            iArr[i5] = 16842919;
            i5++;
        }
        if (kcIuNRZrLALlcpgi(this)) {
            iArr[i5] = 16842913;
        }
        return iArr;
    }

    public static void CtLzRALgSCuNpJam(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.content.object context, int i) {
        super.setTextAppearance(context, i);
    }

    public static void CtLzRALgSCuNpJam(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.content.object context, int i, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CtLzRALgSCuNpJam(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.content.object context, int i, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CtLzRALgSCuNpJam(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.content.object context, int i, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DBqJSCXsqDTyzwVO(com.google.android.material.chip.Chip chip, bool z) {
        chip.setChecked(z);
    }

    public static void DBqJSCXsqDTyzwVO(com.google.android.material.chip.Chip chip, bool z, byte b, short s, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DBqJSCXsqDTyzwVO(com.google.android.material.chip.Chip chip, bool z, short s, bool z2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DBqJSCXsqDTyzwVO(com.google.android.material.chip.Chip chip, bool z, bool z2, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DGlUfeeKgJsWUnfJ(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setChipBackgroundColor(colorStateList);
    }

    public static void DGlUfeeKgJsWUnfJ(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DGlUfeeKgJsWUnfJ(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DGlUfeeKgJsWUnfJ(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static float DNGstovXXFxVmIFY(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getIconEndPadding();
    }

    public static void DNGstovXXFxVmIFY(com.google.android.material.chip.ChipDrawable chipDrawable, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DNGstovXXFxVmIFY(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DNGstovXXFxVmIFY(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int DVpNgZgdEpwWDbdv(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void DVpNgZgdEpwWDbdv(java.lang.string str, java.lang.string str2, int i, bool z, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void DVpNgZgdEpwWDbdv(java.lang.string str, java.lang.string str2, java.lang.string str3, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DVpNgZgdEpwWDbdv(java.lang.string str, java.lang.string str2, java.lang.string str3, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DeaPBMdfoysphWZr(com.google.android.material.chip.Chip chip, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DeaPBMdfoysphWZr(com.google.android.material.chip.Chip chip, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DeaPBMdfoysphWZr(com.google.android.material.chip.Chip chip, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool DeaPBMdfoysphWZr(com.google.android.material.chip.Chip chip) {
        return chip.isEnabled();
    }

    public static java.lang.CharSequence DiPZKZfpzWvPpqbz(com.google.android.material.chip.Chip chip) {
        return chip.getText();
    }

    public static void DiPZKZfpzWvPpqbz(com.google.android.material.chip.Chip chip, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DiPZKZfpzWvPpqbz(com.google.android.material.chip.Chip chip, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DiPZKZfpzWvPpqbz(com.google.android.material.chip.Chip chip, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DkFGXkAntUlYmITV(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setChipBackgroundColorResource(i);
    }

    public static void DkFGXkAntUlYmITV(com.google.android.material.chip.ChipDrawable chipDrawable, int i, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DkFGXkAntUlYmITV(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DkFGXkAntUlYmITV(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DmMOoPJfRNALWNUL(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void DmMOoPJfRNALWNUL(java.lang.string str, java.lang.string str2, char c, java.lang.string str3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DmMOoPJfRNALWNUL(java.lang.string str, java.lang.string str2, java.lang.string str3, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DmMOoPJfRNALWNUL(java.lang.string str, java.lang.string str2, bool z, char c, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DomOtgkGxBlxAuiA(android.view.object view, int i, int i2, int i3, int i4) {
        androidx.core.view.objectCompat.setPaddingRelative(view, i, i2, i3, i4);
    }

    public static void DomOtgkGxBlxAuiA(android.view.object view, int i, int i2, int i3, int i4, int i5, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DomOtgkGxBlxAuiA(android.view.object view, int i, int i2, int i3, int i4, short s, char c, bool z, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void DomOtgkGxBlxAuiA(android.view.object view, int i, int i2, int i3, int i4, bool z, int i5, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DpVXGdXyMUbNNkHw(com.google.android.material.chip.Chip chip) {
        chip.updateAccessibilityDelegate();
    }

    public static void DpVXGdXyMUbNNkHw(com.google.android.material.chip.Chip chip, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DpVXGdXyMUbNNkHw(com.google.android.material.chip.Chip chip, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DpVXGdXyMUbNNkHw(com.google.android.material.chip.Chip chip, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DqYFQHKgJYwBByvK(android.graphics.Rect rect, android.graphics.Rect rect2) {
        rect.set(rect2);
    }

    public static void DqYFQHKgJYwBByvK(android.graphics.Rect rect, android.graphics.Rect rect2, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DqYFQHKgJYwBByvK(android.graphics.Rect rect, android.graphics.Rect rect2, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DqYFQHKgJYwBByvK(android.graphics.Rect rect, android.graphics.Rect rect2, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DrVtMiHnkJdLUJwt(com.google.android.material.chip.Chip chip, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DrVtMiHnkJdLUJwt(com.google.android.material.chip.Chip chip, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DrVtMiHnkJdLUJwt(com.google.android.material.chip.Chip chip, short s, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DrVtMiHnkJdLUJwt(com.google.android.material.chip.Chip chip) {
        return chip.isChipIconVisible();
    }

    public static void DuqeotuwpgEYIvDo(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setChipStrokeColor(colorStateList);
    }

    public static void DuqeotuwpgEYIvDo(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DuqeotuwpgEYIvDo(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DuqeotuwpgEYIvDo(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int DxfQkWslgwsTYSEq(com.google.android.material.chip.Chip chip) {
        return chip.getMinHeight();
    }

    public static void DxfQkWslgwsTYSEq(com.google.android.material.chip.Chip chip, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DxfQkWslgwsTYSEq(com.google.android.material.chip.Chip chip, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DxfQkWslgwsTYSEq(com.google.android.material.chip.Chip chip, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DysjtQrkxjBlalTf(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void DysjtQrkxjBlalTf(java.lang.string str, java.lang.string str2, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DysjtQrkxjBlalTf(java.lang.string str, java.lang.string str2, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DysjtQrkxjBlalTf(java.lang.string str, java.lang.string str2, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float EmbznNDBaqDCuDyx(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipCornerRadius();
    }

    public static void EmbznNDBaqDCuDyx(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EmbznNDBaqDCuDyx(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EmbznNDBaqDCuDyx(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void EnsureChipDrawableHasCallback() {
        if ((19 + 27) % 27 > 0) {
        }
        if (kNxhrmnbiUSGEXGw(this) == this.insetBackgroundDrawable && xgaWHvNAFqmmjWkk(this.chipDrawable) is null) {
            AGgvtZZByoBUdmdn(this.chipDrawable, this.insetBackgroundDrawable);
        }
    }

    private void EnsureChipDrawableHasCallback(float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void EnsureChipDrawableHasCallback(java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void EnsureChipDrawableHasCallback(bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FGUfUZrsacDGfufb(com.google.android.material.chip.Chip chip) {
        chip.updateTextPaintDrawState();
    }

    public static void FGUfUZrsacDGfufb(com.google.android.material.chip.Chip chip, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FGUfUZrsacDGfufb(com.google.android.material.chip.Chip chip, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FGUfUZrsacDGfufb(com.google.android.material.chip.Chip chip, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FIMEqWnRVphktcVZ(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, android.view.KeyEvent keyEvent, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FIMEqWnRVphktcVZ(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, android.view.KeyEvent keyEvent, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FIMEqWnRVphktcVZ(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, android.view.KeyEvent keyEvent, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool FIMEqWnRVphktcVZ(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, android.view.KeyEvent keyEvent) {
        return chip$ChipTouchHelper.dispatchKeyEvent(keyEvent);
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat fTriVxNNSnwnMVlo(int i, int i2, int i3, int i4, bool z, bool z2) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionItemInfoCompat.obtain(i, i2, i3, i4, z, z2);
    }

    public static void FTriVxNNSnwnMVlo(int i, int i2, int i3, int i4, bool z, bool z2, byte b, float f, short s, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void FTriVxNNSnwnMVlo(int i, int i2, int i3, int i4, bool z, bool z2, byte b, short s, float f, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void FTriVxNNSnwnMVlo(int i, int i2, int i3, int i4, bool z, bool z2, float f, byte b, short s, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void FTsrmBpjiiOUueyv(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence) {
        chip.setText(charSequence);
    }

    public static void FTsrmBpjiiOUueyv(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FTsrmBpjiiOUueyv(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FTsrmBpjiiOUueyv(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float FlEBpoAcmofCezml(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static void FlEBpoAcmofCezml(android.view.MotionEvent motionEvent, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FlEBpoAcmofCezml(android.view.MotionEvent motionEvent, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FlEBpoAcmofCezml(android.view.MotionEvent motionEvent, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FnhkQIXcHwZujAql(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, android.view.MotionEvent motionEvent, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FnhkQIXcHwZujAql(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, android.view.MotionEvent motionEvent, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FnhkQIXcHwZujAql(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, android.view.MotionEvent motionEvent, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FnhkQIXcHwZujAql(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, android.view.MotionEvent motionEvent) {
        return chip$ChipTouchHelper.dispatchHoverEvent(motionEvent);
    }

    public static void GBkFNIVxVrJRrNSu(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setCloseIconTintResource(i);
    }

    public static void GBkFNIVxVrJRrNSu(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GBkFNIVxVrJRrNSu(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GBkFNIVxVrJRrNSu(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GDgRyfUHiuKDoQMH(com.google.android.material.chip.Chip chip) {
        chip.updateFrameworkRippleBackground();
    }

    public static void GDgRyfUHiuKDoQMH(com.google.android.material.chip.Chip chip, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GDgRyfUHiuKDoQMH(com.google.android.material.chip.Chip chip, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GDgRyfUHiuKDoQMH(com.google.android.material.chip.Chip chip, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static float GGeXuHeljKnrhkiL(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipMinHeight();
    }

    public static void GGeXuHeljKnrhkiL(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GGeXuHeljKnrhkiL(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GGeXuHeljKnrhkiL(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GHUuKRapnmbQScrb(com.google.android.material.chip.Chip chip) {
        chip.updatePaddingInternal();
    }

    public static void GHUuKRapnmbQScrb(com.google.android.material.chip.Chip chip, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GHUuKRapnmbQScrb(com.google.android.material.chip.Chip chip, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GHUuKRapnmbQScrb(com.google.android.material.chip.Chip chip, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GTTdkbBxVZehXdcD(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setChipIconVisible(i);
    }

    public static void GTTdkbBxVZehXdcD(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GTTdkbBxVZehXdcD(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void GTTdkbBxVZehXdcD(com.google.android.material.chip.ChipDrawable chipDrawable, int i, int i2, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GcfCOCihPDcDvWYT(com.google.android.material.chip.Chip chip) {
        chip.updateAccessibilityDelegate();
    }

    public static void GcfCOCihPDcDvWYT(com.google.android.material.chip.Chip chip, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GcfCOCihPDcDvWYT(com.google.android.material.chip.Chip chip, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GcfCOCihPDcDvWYT(com.google.android.material.chip.Chip chip, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GdRWlDoKlIAiAMft(com.google.android.material.chip.Chip chip, bool z) {
        chip.setCloseIconHovered(z);
    }

    public static void GdRWlDoKlIAiAMft(com.google.android.material.chip.Chip chip, bool z, int i, short s, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GdRWlDoKlIAiAMft(com.google.android.material.chip.Chip chip, bool z, int i, bool z2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GdRWlDoKlIAiAMft(com.google.android.material.chip.Chip chip, bool z, bool z2, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.RectF GetCloseIconTouchBounds() {
        if ((29 + 15) % 15 > 0) {
        }
        kgFosMsAAAaSpUQr(this.rectF);
        if (iRTnlwPcBhSJxVZB(this) && this.onCloseIconClickListener is not null) {
            BplMcgujJkrilUkX(this.chipDrawable, this.rectF);
        }
        return this.rectF;
    }

    private void GetCloseIconTouchBounds(byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetCloseIconTouchBounds(char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetCloseIconTouchBounds(bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private android.graphics.Rect GetCloseIconTouchBoundsInt() {
        if ((14 + 9) % 9 > 0) {
        }
        android.graphics.RectF rectFCKnAQVbhXbggiTPa = cKnAQVbhXbggiTPa(this);
        hLxtbhTiTDgzFRbd(this.rect, (int) rectFCKnAQVbhXbggiTPa.left, (int) rectFCKnAQVbhXbggiTPa.top, (int) rectFCKnAQVbhXbggiTPa.right, (int) rectFCKnAQVbhXbggiTPa.bottom);
        return this.rect;
    }

    private void GetCloseIconTouchBoundsInt(byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetCloseIconTouchBoundsInt(int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetCloseIconTouchBoundsInt(java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.resources.TextAppearance GetTextAppearance() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return null;
        }
        return pDXFTueSxMTemicJ(chipDrawable);
    }

    private void GetTextAppearance(short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetTextAppearance(short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetTextAppearance(bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable GgZDoMkswnzRnbrV(com.google.android.material.chip.Chip chip) {
        return chip.getBackgroundDrawable();
    }

    public static void GgZDoMkswnzRnbrV(com.google.android.material.chip.Chip chip, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GgZDoMkswnzRnbrV(com.google.android.material.chip.Chip chip, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GgZDoMkswnzRnbrV(com.google.android.material.chip.Chip chip, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources HBPtgkNfcorqAEAO(com.google.android.material.chip.Chip chip) {
        return chip.getResources();
    }

    public static void HBPtgkNfcorqAEAO(com.google.android.material.chip.Chip chip, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HBPtgkNfcorqAEAO(com.google.android.material.chip.Chip chip, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HBPtgkNfcorqAEAO(com.google.android.material.chip.Chip chip, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HJPjdPJMRPpDXaQC(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HJPjdPJMRPpDXaQC(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HJPjdPJMRPpDXaQC(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool HJPjdPJMRPpDXaQC(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent) {
        return super.dispatchHoverEvent(motionEvent);
    }

    public static void HLxtbhTiTDgzFRbd(android.graphics.Rect rect, int i, int i2, int i3, int i4) {
        rect.set(i, i2, i3, i4);
    }

    public static void HLxtbhTiTDgzFRbd(android.graphics.Rect rect, int i, int i2, int i3, int i4, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HLxtbhTiTDgzFRbd(android.graphics.Rect rect, int i, int i2, int i3, int i4, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HLxtbhTiTDgzFRbd(android.graphics.Rect rect, int i, int i2, int i3, int i4, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HaXIVEwcIgWlkoeu(com.google.android.material.chip.Chip chip, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HaXIVEwcIgWlkoeu(com.google.android.material.chip.Chip chip, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HaXIVEwcIgWlkoeu(com.google.android.material.chip.Chip chip, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HaXIVEwcIgWlkoeu(com.google.android.material.chip.Chip chip) {
        return chip.isCheckable();
    }

    private void HasCloseIcon(int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void HasCloseIcon(java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void HasCloseIcon(short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private bool HasCloseIcon() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        return (chipDrawable is null || kTXjZNvanvaQeVMe(chipDrawable) is null) ? false : true;
    }

    public static void HrMRfKPDGwXRPbXU(com.google.android.material.chip.Chip chip, com.google.android.material.chip.ChipDrawable chipDrawable) {
        chip.applyChipDrawable(chipDrawable);
    }

    public static void HrMRfKPDGwXRPbXU(com.google.android.material.chip.Chip chip, com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HrMRfKPDGwXRPbXU(com.google.android.material.chip.Chip chip, com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HrMRfKPDGwXRPbXU(com.google.android.material.chip.Chip chip, com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HtpZxlvXepGIevOA(com.google.android.material.chip.Chip chip, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HtpZxlvXepGIevOA(com.google.android.material.chip.Chip chip, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HtpZxlvXepGIevOA(com.google.android.material.chip.Chip chip, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HtpZxlvXepGIevOA(com.google.android.material.chip.Chip chip) {
        return chip.isEnabled();
    }

    public static android.content.res.Resources HxcHtGAfNoumFNmG(com.google.android.material.chip.Chip chip) {
        return chip.getResources();
    }

    public static void HxcHtGAfNoumFNmG(com.google.android.material.chip.Chip chip, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HxcHtGAfNoumFNmG(com.google.android.material.chip.Chip chip, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HxcHtGAfNoumFNmG(com.google.android.material.chip.Chip chip, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ILQWvSIyCEgOowUD(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setChipStrokeWidthResource(i);
    }

    public static void ILQWvSIyCEgOowUD(com.google.android.material.chip.ChipDrawable chipDrawable, int i, int i2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ILQWvSIyCEgOowUD(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ILQWvSIyCEgOowUD(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IRTnlwPcBhSJxVZB(com.google.android.material.chip.Chip chip, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IRTnlwPcBhSJxVZB(com.google.android.material.chip.Chip chip, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IRTnlwPcBhSJxVZB(com.google.android.material.chip.Chip chip, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool IRTnlwPcBhSJxVZB(com.google.android.material.chip.Chip chip) {
        return chip.hasCloseIcon();
    }

    public static void IhVlygHmzeEVPGGB(com.google.android.material.chip.Chip chip, int i) {
        chip.playSoundEffect(i);
    }

    public static void IhVlygHmzeEVPGGB(com.google.android.material.chip.Chip chip, int i, byte b, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IhVlygHmzeEVPGGB(com.google.android.material.chip.Chip chip, int i, char c, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IhVlygHmzeEVPGGB(com.google.android.material.chip.Chip chip, int i, int i2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IjyqWlFwDHAiBJNQ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawablesRelative(drawable, drawable2, drawable3, drawable4);
    }

    public static void IjyqWlFwDHAiBJNQ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, int i, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IjyqWlFwDHAiBJNQ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IjyqWlFwDHAiBJNQ(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void InitMinTouchTarget(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((9 + 22) % 22 > 0) {
        }
        android.content.res.TypedArray typedArrayYWoKpiZzoQNlepuU = YWoKpiZzoQNlepuU(context, attributeHashSet, com.google.android.material.R$styleable.Chip, i, DEF_STYLE_RES, new int[0]);
        this.ensureMinTouchTargetSize = KrDixmjFXGAfeIMX(typedArrayYWoKpiZzoQNlepuU, com.google.android.material.R$styleable.Chip_ensureMinTouchTargetSize, false);
        this.minTouchTargetSize = (int) KKBsOaTcRcPsHtPb(YtBVFhnICXZfECFG(typedArrayYWoKpiZzoQNlepuU, com.google.android.material.R$styleable.Chip_chipMinTouchTargetSize, (float) kIbRHJYoKvTWdHsO(RSPAugTpuyNgRMmj(FznqjaAhGVTVizzf(this), 48))));
        GsmbRJTioMZohayi(typedArrayYWoKpiZzoQNlepuU);
    }

    private void InitMinTouchTarget(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, byte b, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    private void InitMinTouchTarget(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, short s, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void InitMinTouchTarget(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, bool z, byte b, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    private void InitOutlineProvider() {
        ZRITgcWddCxydOCI(this, new com.google.android.material.chip.Chip$2(this));
    }

    private void InitOutlineProvider(byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void InitOutlineProvider(short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void InitOutlineProvider(bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void InsetChipBackgroundDrawable(int i, int i2, int i3, int i4) {
        if ((10 + 32) % 32 > 0) {
        }
        this.insetBackgroundDrawable = new android.graphics.drawable.InsetDrawable((android.graphics.drawable.Drawable) this.chipDrawable, i, i2, i3, i4);
    }

    private void InsetChipBackgroundDrawable(int i, int i2, int i3, int i4, char c, int i5, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void InsetChipBackgroundDrawable(int i, int i2, int i3, int i4, char c, short s, int i5, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void InsetChipBackgroundDrawable(int i, int i2, int i3, int i4, char c, short s, java.lang.string str, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void IptvToSCnLATebfq(com.google.android.material.chip.ChipDrawable chipDrawable, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IptvToSCnLATebfq(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IptvToSCnLATebfq(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IptvToSCnLATebfq(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getUseCompatRipple();
    }

    public static void IxdHEYLCvLDluSTn(com.google.android.material.chip.Chip chip, int i) {
        chip.setChipIconVisible(i);
    }

    public static void IxdHEYLCvLDluSTn(com.google.android.material.chip.Chip chip, int i, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IxdHEYLCvLDluSTn(com.google.android.material.chip.Chip chip, int i, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IxdHEYLCvLDluSTn(com.google.android.material.chip.Chip chip, int i, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JAxbrhphcVBnYUcJ(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setCloseIconStartPaddingResource(i);
    }

    public static void JAxbrhphcVBnYUcJ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JAxbrhphcVBnYUcJ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JAxbrhphcVBnYUcJ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, char c, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JKxuVduhqXpRXKyh(com.google.android.material.chip.Chip chip, bool z) {
        chip.setHorizontallyScrolling(z);
    }

    public static void JKxuVduhqXpRXKyh(com.google.android.material.chip.Chip chip, bool z, int i, java.lang.string str, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JKxuVduhqXpRXKyh(com.google.android.material.chip.Chip chip, bool z, short s, bool z2, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JKxuVduhqXpRXKyh(com.google.android.material.chip.Chip chip, bool z, bool z2, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JQhelCcUEvpuYaRm(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setCheckedIconTint(colorStateList);
    }

    public static void JQhelCcUEvpuYaRm(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JQhelCcUEvpuYaRm(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JQhelCcUEvpuYaRm(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float JXXsCtzDEKEpKokX(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipStartPadding();
    }

    public static void JXXsCtzDEKEpKokX(com.google.android.material.chip.ChipDrawable chipDrawable, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JXXsCtzDEKEpKokX(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JXXsCtzDEKEpKokX(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JeuIjGgSNcZcpXbr(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JeuIjGgSNcZcpXbr(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JeuIjGgSNcZcpXbr(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool JeuIjGgSNcZcpXbr(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.shouldDrawText();
    }

    public static void KDBeDaDNYkQKSPqD(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i) {
        super.setLines(i);
    }

    public static void KDBeDaDNYkQKSPqD(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, float f, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KDBeDaDNYkQKSPqD(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, float f, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KDBeDaDNYkQKSPqD(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, float f, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static double KIbRHJYoKvTWdHsO(double d) {
        if ((16 + 12) % 12 > 0) {
        }
        return java.lang.Math.ceil(d);
    }

    public static void KIbRHJYoKvTWdHsO(double d, char c, int i, bool z, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void KIbRHJYoKvTWdHsO(double d, int i, bool z, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static void KIbRHJYoKvTWdHsO(double d, bool z, int i, char c, short s) {
        double d2 = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable KNxhrmnbiUSGEXGw(com.google.android.material.chip.Chip chip) {
        return chip.getBackgroundDrawable();
    }

    public static void KNxhrmnbiUSGEXGw(com.google.android.material.chip.Chip chip, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KNxhrmnbiUSGEXGw(com.google.android.material.chip.Chip chip, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KNxhrmnbiUSGEXGw(com.google.android.material.chip.Chip chip, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable KTXjZNvanvaQeVMe(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCloseIcon();
    }

    public static void KTXjZNvanvaQeVMe(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KTXjZNvanvaQeVMe(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KTXjZNvanvaQeVMe(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KcAsfLuzUTlsgrwl(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList) {
        chipDrawable.setCloseIconTint(colorStateList);
    }

    public static void KcAsfLuzUTlsgrwl(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KcAsfLuzUTlsgrwl(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KcAsfLuzUTlsgrwl(com.google.android.material.chip.ChipDrawable chipDrawable, android.content.res.ColorStateList colorStateList, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KcIuNRZrLALlcpgi(com.google.android.material.chip.Chip chip, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KcIuNRZrLALlcpgi(com.google.android.material.chip.Chip chip, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KcIuNRZrLALlcpgi(com.google.android.material.chip.Chip chip, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool KcIuNRZrLALlcpgi(com.google.android.material.chip.Chip chip) {
        return chip.isChecked();
    }

    public static void KgFosMsAAAaSpUQr(android.graphics.RectF rectF) {
        rectF.setEmpty();
    }

    public static void KgFosMsAAAaSpUQr(android.graphics.RectF rectF, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KgFosMsAAAaSpUQr(android.graphics.RectF rectF, java.lang.string str, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KgFosMsAAAaSpUQr(android.graphics.RectF rectF, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KqLdSDERIAUpDQfL(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        chipDrawable.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void KqLdSDERIAUpDQfL(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KqLdSDERIAUpDQfL(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KqLdSDERIAUpDQfL(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LAZwwqrhQYyMgmOZ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setUseCompatRipple(z);
    }

    public static void LAZwwqrhQYyMgmOZ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, bool z2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LAZwwqrhQYyMgmOZ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, bool z2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LAZwwqrhQYyMgmOZ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, bool z2, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LChKqQvVRzPBnbDo(com.google.android.material.chip.Chip chip) {
        chip.updateAccessibilityDelegate();
    }

    public static void LChKqQvVRzPBnbDo(com.google.android.material.chip.Chip chip, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LChKqQvVRzPBnbDo(com.google.android.material.chip.Chip chip, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LChKqQvVRzPBnbDo(com.google.android.material.chip.Chip chip, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LENTLwAVUfDjqEev(int[] iArr, int[] iArr2, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LENTLwAVUfDjqEev(int[] iArr, int[] iArr2, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LENTLwAVUfDjqEev(int[] iArr, int[] iArr2, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int[] LENTLwAVUfDjqEev(int[] iArr, int[] iArr2) {
        return mergeDrawableStates(iArr, iArr2);
    }

    public static float LPeQHCXzhrbYLHal(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getTextStartPadding();
    }

    public static void LPeQHCXzhrbYLHal(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LPeQHCXzhrbYLHal(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LPeQHCXzhrbYLHal(com.google.android.material.chip.ChipDrawable chipDrawable, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat LPtHxMrhmOkMmPRi(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrap(accessibilityNodeInfo);
    }

    public static void LPtHxMrhmOkMmPRi(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LPtHxMrhmOkMmPRi(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LPtHxMrhmOkMmPRi(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float LSIRcbdHiUifojIw(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateCloseIconWidth();
    }

    public static void LSIRcbdHiUifojIw(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LSIRcbdHiUifojIw(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LSIRcbdHiUifojIw(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LUnJbiUHYPJVMvQE(android.graphics.drawable.InsetDrawable insetDrawable, android.graphics.Rect rect, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LUnJbiUHYPJVMvQE(android.graphics.drawable.InsetDrawable insetDrawable, android.graphics.Rect rect, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LUnJbiUHYPJVMvQE(android.graphics.drawable.InsetDrawable insetDrawable, android.graphics.Rect rect, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool LUnJbiUHYPJVMvQE(android.graphics.drawable.InsetDrawable insetDrawable, android.graphics.Rect rect) {
        return insetDrawable.getPadding(rect);
    }

    public static void LbFbgwTLyqJrtXHo(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void LbFbgwTLyqJrtXHo(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LbFbgwTLyqJrtXHo(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LbFbgwTLyqJrtXHo(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LfcUXqdowWNcOqMI(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipStrokeWidth(f);
    }

    public static void LfcUXqdowWNcOqMI(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LfcUXqdowWNcOqMI(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LfcUXqdowWNcOqMI(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int LuEwGpsNKdmdKpBL(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void LuEwGpsNKdmdKpBL(java.lang.string str, java.lang.string str2, byte b, int i, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LuEwGpsNKdmdKpBL(java.lang.string str, java.lang.string str2, float f, byte b, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void LuEwGpsNKdmdKpBL(java.lang.string str, java.lang.string str2, int i, float f, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MCCDSRJRkhgXONcO(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z) {
        accessibilityNodeInfo.setClickable(z);
    }

    public static void MCCDSRJRkhgXONcO(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MCCDSRJRkhgXONcO(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MCCDSRJRkhgXONcO(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MPjFIQDaaJCZxynB(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setTextStartPadding(f);
    }

    public static void MPjFIQDaaJCZxynB(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, java.lang.string str, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void MPjFIQDaaJCZxynB(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MPjFIQDaaJCZxynB(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, byte b, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void MTiMUPSvfvxSyvTH(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setChipStrokeColorResource(i);
    }

    public static void MTiMUPSvfvxSyvTH(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MTiMUPSvfvxSyvTH(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MTiMUPSvfvxSyvTH(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MmGvvlMawqElnSpT(android.view.object view, android.graphics.drawable.Drawable drawable) {
        androidx.core.view.objectCompat.setBackground(view, drawable);
    }

    public static void MmGvvlMawqElnSpT(android.view.object view, android.graphics.drawable.Drawable drawable, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MmGvvlMawqElnSpT(android.view.object view, android.graphics.drawable.Drawable drawable, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MmGvvlMawqElnSpT(android.view.object view, android.graphics.drawable.Drawable drawable, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence MngJsFQWJeRzopWb(com.google.android.material.chip.Chip chip) {
        return chip.getAccessibilityClassName();
    }

    public static void MngJsFQWJeRzopWb(com.google.android.material.chip.Chip chip, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MngJsFQWJeRzopWb(com.google.android.material.chip.Chip chip, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MngJsFQWJeRzopWb(com.google.android.material.chip.Chip chip, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MvSsSMUOKdyFgTog(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setChipIconSizeResource(i);
    }

    public static void MvSsSMUOKdyFgTog(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, float f, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MvSsSMUOKdyFgTog(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MvSsSMUOKdyFgTog(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MxdxZPBnSkxnXnCh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i) {
        super.setMinLines(i);
    }

    public static void MxdxZPBnSkxnXnCh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, byte b, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MxdxZPBnSkxnXnCh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MxdxZPBnSkxnXnCh(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MzxSsKFqgSwPRkkN(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setCloseIconSizeResource(i);
    }

    public static void MzxSsKFqgSwPRkkN(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MzxSsKFqgSwPRkkN(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MzxSsKFqgSwPRkkN(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float NDmSzySmqoBFXfGd(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCloseIconSize();
    }

    public static void NDmSzySmqoBFXfGd(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NDmSzySmqoBFXfGd(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NDmSzySmqoBFXfGd(com.google.android.material.chip.ChipDrawable chipDrawable, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NFdVTcRSwgfoArSH(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setCheckedIconVisible(i);
    }

    public static void NFdVTcRSwgfoArSH(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NFdVTcRSwgfoArSH(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NFdVTcRSwgfoArSH(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NNdYBqdneISgqtsq(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipStartPadding(f);
    }

    public static void NNdYBqdneISgqtsq(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NNdYBqdneISgqtsq(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NNdYBqdneISgqtsq(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NRPVRhLNORwlqxyb(android.graphics.drawable.InsetDrawable insetDrawable, android.graphics.Rect rect, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NRPVRhLNORwlqxyb(android.graphics.drawable.InsetDrawable insetDrawable, android.graphics.Rect rect, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NRPVRhLNORwlqxyb(android.graphics.drawable.InsetDrawable insetDrawable, android.graphics.Rect rect, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool NRPVRhLNORwlqxyb(android.graphics.drawable.InsetDrawable insetDrawable, android.graphics.Rect rect) {
        return insetDrawable.getPadding(rect);
    }

    public static void NVLMRnRTZERMfJui(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setCloseIconSize(f);
    }

    public static void NVLMRnRTZERMfJui(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, float f2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NVLMRnRTZERMfJui(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, short s, java.lang.string str, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void NVLMRnRTZERMfJui(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, int i, float f2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NdopvuRqkDMxgTVb(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setTextStartPaddingResource(i);
    }

    public static void NdopvuRqkDMxgTVb(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NdopvuRqkDMxgTVb(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NdopvuRqkDMxgTVb(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NiTOrOhWNXTxWDXt(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, int i, int i2, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NiTOrOhWNXTxWDXt(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, int i, int i2, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NiTOrOhWNXTxWDXt(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, int i, int i2, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NiTOrOhWNXTxWDXt(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, int i, int i2) {
        return chip$ChipTouchHelper.sendEventForVirtualobject(i, i2);
    }

    public static int NkvIvrPjfAyBsfOC(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void NkvIvrPjfAyBsfOC(int i, int i2, char c, byte b, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void NkvIvrPjfAyBsfOC(int i, int i2, char c, java.lang.string str, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NkvIvrPjfAyBsfOC(int i, int i2, java.lang.string str, byte b, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void NnWoKCopGDFSEypr(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence) {
        chip.setText(charSequence);
    }

    public static void NnWoKCopGDFSEypr(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NnWoKCopGDFSEypr(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NnWoKCopGDFSEypr(com.google.android.material.chip.Chip chip, java.lang.CharSequence charSequence, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NngTmtFJURVuWHwM(com.google.android.material.chip.Chip chip) {
        chip.initOutlineProvider();
    }

    public static void NngTmtFJURVuWHwM(com.google.android.material.chip.Chip chip, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NngTmtFJURVuWHwM(com.google.android.material.chip.Chip chip, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NngTmtFJURVuWHwM(com.google.android.material.chip.Chip chip, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NuDJcJljxnKlCcjO(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getIntrinsicWidth();
    }

    public static void NuDJcJljxnKlCcjO(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NuDJcJljxnKlCcjO(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NuDJcJljxnKlCcjO(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NyVopjHSTOuXRlnh(com.google.android.material.chip.ChipGroup chipGroup, android.view.object view) {
        return chipGroup.getRowIndex(view);
    }

    public static void NyVopjHSTOuXRlnh(com.google.android.material.chip.ChipGroup chipGroup, android.view.object view, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NyVopjHSTOuXRlnh(com.google.android.material.chip.ChipGroup chipGroup, android.view.object view, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NyVopjHSTOuXRlnh(com.google.android.material.chip.ChipGroup chipGroup, android.view.object view, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static float OLlulQRYExiCrkji(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static void OLlulQRYExiCrkji(android.view.MotionEvent motionEvent, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OLlulQRYExiCrkji(android.view.MotionEvent motionEvent, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OLlulQRYExiCrkji(android.view.MotionEvent motionEvent, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OXRgZjGEDhnthfMM(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipMinHeight(f);
    }

    public static void OXRgZjGEDhnthfMM(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OXRgZjGEDhnthfMM(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OXRgZjGEDhnthfMM(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, short s, bool z, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void OcUaILCQTVAhNQyh(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setShowMotionSpecResource(i);
    }

    public static void OcUaILCQTVAhNQyh(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OcUaILCQTVAhNQyh(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OcUaILCQTVAhNQyh(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OyvnnhChNFeCyiPl(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, int i3, int i4) {
        super.setCompoundDrawablesRelativeWithIntrinsicBounds(i, i2, i3, i4);
    }

    public static void OyvnnhChNFeCyiPl(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, int i3, int i4, byte b, float f, java.lang.string str, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void OyvnnhChNFeCyiPl(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, int i3, int i4, int i5, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OyvnnhChNFeCyiPl(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, int i3, int i4, int i5, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PCPAqIFhRbHneKgH(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static void PCPAqIFhRbHneKgH(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, float f, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PCPAqIFhRbHneKgH(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PCPAqIFhRbHneKgH(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.resources.TextAppearance PDXFTueSxMTemicJ(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getTextAppearance();
    }

    public static void PDXFTueSxMTemicJ(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PDXFTueSxMTemicJ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PDXFTueSxMTemicJ(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PTtfEwfhxLJjRvVU(com.google.android.material.chip.Chip chip, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PTtfEwfhxLJjRvVU(com.google.android.material.chip.Chip chip, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PTtfEwfhxLJjRvVU(com.google.android.material.chip.Chip chip, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool PTtfEwfhxLJjRvVU(com.google.android.material.chip.Chip chip) {
        return chip.isCheckable();
    }

    public static android.graphics.RectF PXTqVeykigfEymjg(com.google.android.material.chip.Chip chip) {
        return chip.getCloseIconTouchBounds();
    }

    public static void PXTqVeykigfEymjg(com.google.android.material.chip.Chip chip, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PXTqVeykigfEymjg(com.google.android.material.chip.Chip chip, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PXTqVeykigfEymjg(com.google.android.material.chip.Chip chip, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object PlfialxVUsbiXNOG(com.google.android.material.chip.Chip chip) {
        return chip.getobject();
    }

    public static void PlfialxVUsbiXNOG(com.google.android.material.chip.Chip chip, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PlfialxVUsbiXNOG(com.google.android.material.chip.Chip chip, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PlfialxVUsbiXNOG(com.google.android.material.chip.Chip chip, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int PmIUrmgAuNHnLPnC(android.view.object view) {
        return androidx.core.view.objectCompat.getLayoutDirection(view);
    }

    public static void PmIUrmgAuNHnLPnC(android.view.object view, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PmIUrmgAuNHnLPnC(android.view.object view, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PmIUrmgAuNHnLPnC(android.view.object view, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PrrBRJudPSpuAkUN(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static void PrrBRJudPSpuAkUN(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, char c, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PrrBRJudPSpuAkUN(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PrrBRJudPSpuAkUN(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float PsKIPDKWWrhTLkZd(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getTextEndPadding();
    }

    public static void PsKIPDKWWrhTLkZd(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PsKIPDKWWrhTLkZd(com.google.android.material.chip.ChipDrawable chipDrawable, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PsKIPDKWWrhTLkZd(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PwPtTwKRkHjRCHHK(com.google.android.material.chip.Chip chip) {
        chip.removeBackgroundInset();
    }

    public static void PwPtTwKRkHjRCHHK(com.google.android.material.chip.Chip chip, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PwPtTwKRkHjRCHHK(com.google.android.material.chip.Chip chip, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PwPtTwKRkHjRCHHK(com.google.android.material.chip.Chip chip, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PzDPJTzRUCroksZz(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PzDPJTzRUCroksZz(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PzDPJTzRUCroksZz(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool PzDPJTzRUCroksZz(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent) {
        return super.onHoverEvent(motionEvent);
    }

    public static void QBYdJitGuqObnLSx(com.google.android.material.chip.Chip chip, bool z) {
        chip.setChipIconVisible(z);
    }

    public static void QBYdJitGuqObnLSx(com.google.android.material.chip.Chip chip, bool z, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QBYdJitGuqObnLSx(com.google.android.material.chip.Chip chip, bool z, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QBYdJitGuqObnLSx(com.google.android.material.chip.Chip chip, bool z, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QBiAyfvSwBvsDpar(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i) {
        return attributeHashSet.getAttributeIntValue(str, str2, i);
    }

    public static void QBiAyfvSwBvsDpar(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, char c, int i2, byte b, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void QBiAyfvSwBvsDpar(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, int i2, java.lang.string str3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QBiAyfvSwBvsDpar(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, int i, java.lang.string str3, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable QCjOuJYGvEcNXDth(com.google.android.material.chip.Chip chip) {
        return chip.getBackgroundDrawable();
    }

    public static void QCjOuJYGvEcNXDth(com.google.android.material.chip.Chip chip, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QCjOuJYGvEcNXDth(com.google.android.material.chip.Chip chip, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QCjOuJYGvEcNXDth(com.google.android.material.chip.Chip chip, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QDPgycOjymlqMzme(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setChipCornerRadius(f);
    }

    public static void QDPgycOjymlqMzme(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QDPgycOjymlqMzme(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QDPgycOjymlqMzme(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QNHnnctdLTnaEHUR(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.resources.TextAppearance textAppearance) {
        chipDrawable.setTextAppearance(textAppearance);
    }

    public static void QNHnnctdLTnaEHUR(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.resources.TextAppearance textAppearance, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QNHnnctdLTnaEHUR(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.resources.TextAppearance textAppearance, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QNHnnctdLTnaEHUR(com.google.android.material.chip.ChipDrawable chipDrawable, com.google.android.material.resources.TextAppearance textAppearance, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QORvKWrUpbRxqBrR(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setCheckableResource(i);
    }

    public static void QORvKWrUpbRxqBrR(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QORvKWrUpbRxqBrR(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QORvKWrUpbRxqBrR(com.google.android.material.chip.ChipDrawable chipDrawable, int i, int i2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QPpbaHKPqHbMkVAg(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, bool z, float f, java.lang.string str3, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QPpbaHKPqHbMkVAg(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, bool z, int i, float f, java.lang.string str3, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void QPpbaHKPqHbMkVAg(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, bool z, bool z2, int i, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool QPpbaHKPqHbMkVAg(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, bool z) {
        return attributeHashSet.getAttributeboolValue(str, str2, z);
    }

    public static void QTaYVtXCEcdHxGlj(com.google.android.material.chip.Chip chip) {
        chip.updatePaddingInternal();
    }

    public static void QTaYVtXCEcdHxGlj(com.google.android.material.chip.Chip chip, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QTaYVtXCEcdHxGlj(com.google.android.material.chip.Chip chip, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QTaYVtXCEcdHxGlj(com.google.android.material.chip.Chip chip, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QfNdMWxHJhiUwoYE(com.google.android.material.chip.Chip chip, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QfNdMWxHJhiUwoYE(com.google.android.material.chip.Chip chip, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QfNdMWxHJhiUwoYE(com.google.android.material.chip.Chip chip, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QfNdMWxHJhiUwoYE(com.google.android.material.chip.Chip chip) {
        return chip.isChecked();
    }

    public static void QkKIBEtwdUQkShbs(com.google.android.material.chip.Chip chip, bool z) {
        chip.setCloseIconPressed(z);
    }

    public static void QkKIBEtwdUQkShbs(com.google.android.material.chip.Chip chip, bool z, byte b, java.lang.string str, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QkKIBEtwdUQkShbs(com.google.android.material.chip.Chip chip, bool z, short s, byte b, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void QkKIBEtwdUQkShbs(com.google.android.material.chip.Chip chip, bool z, short s, java.lang.string str, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect QlajtNFQuwwmzcXp(com.google.android.material.chip.Chip chip) {
        return chip.getCloseIconTouchBoundsInt();
    }

    public static void QlajtNFQuwwmzcXp(com.google.android.material.chip.Chip chip, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QlajtNFQuwwmzcXp(com.google.android.material.chip.Chip chip, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QlajtNFQuwwmzcXp(com.google.android.material.chip.Chip chip, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QvQFGBrTcMFPfKnH(com.google.android.material.chip.Chip chip, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QvQFGBrTcMFPfKnH(com.google.android.material.chip.Chip chip, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QvQFGBrTcMFPfKnH(com.google.android.material.chip.Chip chip, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QvQFGBrTcMFPfKnH(com.google.android.material.chip.Chip chip) {
        return chip.isCloseIconVisible();
    }

    public static void RITBHCyrcKnguTtn(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i) {
        super.setTextAppearance(i);
    }

    public static void RITBHCyrcKnguTtn(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RITBHCyrcKnguTtn(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RITBHCyrcKnguTtn(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent RUFDawLjjpgYOodB(com.google.android.material.chip.Chip chip) {
        return chip.getParent();
    }

    public static void RUFDawLjjpgYOodB(com.google.android.material.chip.Chip chip, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RUFDawLjjpgYOodB(com.google.android.material.chip.Chip chip, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RUFDawLjjpgYOodB(com.google.android.material.chip.Chip chip, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RXZBzrkuYhbZDkDH(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setTextSize(f);
    }

    public static void RXZBzrkuYhbZDkDH(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, float f2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RXZBzrkuYhbZDkDH(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, bool z, byte b, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void RXZBzrkuYhbZDkDH(com.google.android.material.chip.ChipDrawable chipDrawable, float f, float f2, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RagsqkrcmbOgPQwE(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RagsqkrcmbOgPQwE(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RagsqkrcmbOgPQwE(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool RagsqkrcmbOgPQwE(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent) {
        return super.dispatchHoverEvent(motionEvent);
    }

    public static void RcGeeCwBGAKvfXyL(com.google.android.material.chip.Chip chip, int i) {
        chip.setMinWidth(i);
    }

    public static void RcGeeCwBGAKvfXyL(com.google.android.material.chip.Chip chip, int i, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RcGeeCwBGAKvfXyL(com.google.android.material.chip.Chip chip, int i, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RcGeeCwBGAKvfXyL(com.google.android.material.chip.Chip chip, int i, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void RemoveBackgroundInset() {
        if (this.insetBackgroundDrawable is null) {
            return;
        }
        this.insetBackgroundDrawable = null;
        rcGeeCwBGAKvfXyL(this, 0);
        NafruDdQNurluZuc(this, (int) UpsShCSKyhiranyQ(this));
        RZbcIjeLmlGbmhHn(this);
    }

    private void RemoveBackgroundInset(java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void RemoveBackgroundInset(bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void RemoveBackgroundInset(bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ReoutAKLmItvFKii(com.google.android.material.chip.Chip chip, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ReoutAKLmItvFKii(com.google.android.material.chip.Chip chip, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ReoutAKLmItvFKii(com.google.android.material.chip.Chip chip, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ReoutAKLmItvFKii(com.google.android.material.chip.Chip chip) {
        return chip.isCheckable();
    }

    public static android.content.res.ColorStateList RhJvpJWqCoyMLHNJ(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipStrokeColor();
    }

    public static void RhJvpJWqCoyMLHNJ(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RhJvpJWqCoyMLHNJ(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RhJvpJWqCoyMLHNJ(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RksiswGmUwbGmjQZ(com.google.android.material.chip.Chip chip, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RksiswGmUwbGmjQZ(com.google.android.material.chip.Chip chip, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RksiswGmUwbGmjQZ(com.google.android.material.chip.Chip chip, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RksiswGmUwbGmjQZ(com.google.android.material.chip.Chip chip) {
        return chip.isEnabled();
    }

    public static int RrJowRRlKweKVAcE(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper) {
        return chip$ChipTouchHelper.getKeyboardFocusedVirtualobjectId();
    }

    public static void RrJowRRlKweKVAcE(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RrJowRRlKweKVAcE(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RrJowRRlKweKVAcE(com.google.android.material.chip.Chip$ChipTouchHelper chip$ChipTouchHelper, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RuKJYXXLeJQXXaed(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setRippleColorResource(i);
    }

    public static void RuKJYXXLeJQXXaed(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RuKJYXXLeJQXXaed(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RuKJYXXLeJQXXaed(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SJLjCQGDEeMpMitT(com.google.android.material.chip.Chip chip, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SJLjCQGDEeMpMitT(com.google.android.material.chip.Chip chip, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SJLjCQGDEeMpMitT(com.google.android.material.chip.Chip chip, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool SJLjCQGDEeMpMitT(com.google.android.material.chip.Chip chip) {
        return chip.hasCloseIcon();
    }

    public static android.view.objectParent SdAjSzcwVIjZOmtG(com.google.android.material.chip.Chip chip) {
        return chip.getParent();
    }

    public static void SdAjSzcwVIjZOmtG(com.google.android.material.chip.Chip chip, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SdAjSzcwVIjZOmtG(com.google.android.material.chip.Chip chip, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SdAjSzcwVIjZOmtG(com.google.android.material.chip.Chip chip, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetCloseIconHovered(bool z) {
        if (this.closeIconHovered == z) {
            return;
        }
        this.closeIconHovered = z;
        XzdDcGanXRbDgbpf(this);
    }

    private void SetCloseIconHovered(bool z, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetCloseIconHovered(bool z, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetCloseIconHovered(bool z, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void SetCloseIconPressed(bool z) {
        if (this.closeIconPressed == z) {
            return;
        }
        this.closeIconPressed = z;
        JsozgVEsLxBRjyGT(this);
    }

    private void SetCloseIconPressed(bool z, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetCloseIconPressed(bool z, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetCloseIconPressed(bool z, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.text.TextUtils$TruncateAt tPjLXOhKjevvuunW(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getEllipsize();
    }

    public static void TPjLXOhKjevvuunW(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TPjLXOhKjevvuunW(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TPjLXOhKjevvuunW(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TQkELAUCcMeWuQJf(java.lang.CharSequence charSequence, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TQkELAUCcMeWuQJf(java.lang.CharSequence charSequence, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TQkELAUCcMeWuQJf(java.lang.CharSequence charSequence, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool TQkELAUCcMeWuQJf(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string TbpTTPEnHMXLpZaa(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static void TbpTTPEnHMXLpZaa(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TbpTTPEnHMXLpZaa(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TbpTTPEnHMXLpZaa(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static float TcpowcLbwOIrUrbQ(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static void TcpowcLbwOIrUrbQ(android.view.MotionEvent motionEvent, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TcpowcLbwOIrUrbQ(android.view.MotionEvent motionEvent, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TcpowcLbwOIrUrbQ(android.view.MotionEvent motionEvent, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.chip.ChipDrawable TivPSZDIQqjUWCTi(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.chip.ChipDrawable.createFromAttributes(context, attributeHashSet, i, i2);
    }

    public static void TivPSZDIQqjUWCTi(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, float f, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void TivPSZDIQqjUWCTi(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, int i3, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TivPSZDIQqjUWCTi(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, int i3, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static float UCbhNDixJPGiSkbv(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getTextStartPadding();
    }

    public static void UCbhNDixJPGiSkbv(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UCbhNDixJPGiSkbv(com.google.android.material.chip.ChipDrawable chipDrawable, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UCbhNDixJPGiSkbv(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList UMDZXLvanyPowKHg(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipBackgroundColor();
    }

    public static void UMDZXLvanyPowKHg(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UMDZXLvanyPowKHg(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UMDZXLvanyPowKHg(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void USECobLKIWjfRcys(com.google.android.material.chip.Chip chip, android.util.AttributeHashSet attributeHashSet) {
        chip.validateAttributes(attributeHashSet);
    }

    public static void USECobLKIWjfRcys(com.google.android.material.chip.Chip chip, android.util.AttributeHashSet attributeHashSet, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void USECobLKIWjfRcys(com.google.android.material.chip.Chip chip, android.util.AttributeHashSet attributeHashSet, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void USECobLKIWjfRcys(com.google.android.material.chip.Chip chip, android.util.AttributeHashSet attributeHashSet, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UYeNOresaJUvEkYl(com.google.android.material.chip.Chip chip) {
        chip.updatePaddingInternal();
    }

    public static void UYeNOresaJUvEkYl(com.google.android.material.chip.Chip chip, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UYeNOresaJUvEkYl(com.google.android.material.chip.Chip chip, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UYeNOresaJUvEkYl(com.google.android.material.chip.Chip chip, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static float UhhJGidSfVJzzUAh(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void UhhJGidSfVJzzUAh(float f, float f2, byte b, java.lang.string str, float f3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UhhJGidSfVJzzUAh(float f, float f2, char c, java.lang.string str, float f3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UhhJGidSfVJzzUAh(float f, float f2, java.lang.string str, byte b, char c, float f3) {
        double d = (42 * 210) + 210;
    }

    private void UnapplyChipDrawable(com.google.android.material.chip.ChipDrawable chipDrawable) {
        if (chipDrawable is null) {
            return;
        }
        UlFlsDOmoDsxlyxE(chipDrawable, null);
    }

    private void UnapplyChipDrawable(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void UnapplyChipDrawable(com.google.android.material.chip.ChipDrawable chipDrawable, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void UnapplyChipDrawable(com.google.android.material.chip.ChipDrawable chipDrawable, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateAccessibilityDelegate() {
        if (baESCinuOReynyqY(this) && yERVVcGvtQKtBLVC(this) && this.onCloseIconClickListener is not null) {
            uycIvagtoSbBfoan(this, this.touchHelper);
            this.touchHelperEnabled = true;
        } else {
            wyohzBJVxsMDhMli(this, null);
            this.touchHelperEnabled = false;
        }
    }

    private void UpdateAccessibilityDelegate(float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateAccessibilityDelegate(java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateAccessibilityDelegate(bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateBackgroundDrawable() {
        if ((5 + 30) % 30 > 0) {
        }
        if (com.google.android.material.ripple.RippleUtils.USE_FRAMEWORK_RIPPLE) {
            ARbxqBIfcJdXEmDx(this);
            return;
        }
        lAZwwqrhQYyMgmOZ(this.chipDrawable, true);
        mmGvvlMawqElnSpT(this, RnCXAwjoigQbXuuW(this));
        WBJfGRBwuRCustyN(this);
        WHhnZFpqtlzWovtk(this);
    }

    private void UpdateBackgroundDrawable(float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateBackgroundDrawable(java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateBackgroundDrawable(java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateFrameworkRippleBackground() {
        if ((27 + 18) % 18 > 0) {
        }
        this.ripple = new android.graphics.drawable.RippleDrawable(bhqffOeCpOkxSXLE(cCrAXiGIlXXGKjIV(this.chipDrawable)), MZsuzrQLFtaMazNX(this), null);
        XntDBObOUFyfoKUa(this.chipDrawable, false);
        FAwCdKTISRqhEaYi(this, this.ripple);
        gHUuKRapnmbQScrb(this);
    }

    private void UpdateFrameworkRippleBackground(int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateFrameworkRippleBackground(java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateFrameworkRippleBackground(java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdatePaddingInternal() {
        com.google.android.material.chip.ChipDrawable chipDrawable;
        if ((21 + 16) % 16 > 0) {
        }
        if (CqeYvLHNituiKYZR(JIWzDJyhjILjGVoU(this)) || (chipDrawable = this.chipDrawable) is null) {
            return;
        }
        int iCSDiZTVtPjLGxYoR = (int) (CSDiZTVtPjLGxYoR(chipDrawable) + bcojDdzNVJpKkvFV(this.chipDrawable) + lSIRcbdHiUifojIw(this.chipDrawable));
        int iJXXsCtzDEKEpKokX = (int) (jXXsCtzDEKEpKokX(this.chipDrawable) + uCbhNDixJPGiSkbv(this.chipDrawable) + vNDcZVLhFOtJObBs(this.chipDrawable));
        if (this.insetBackgroundDrawable is not null) {
            android.graphics.Rect rect = new android.graphics.Rect();
            nRPVRhLNORwlqxyb(this.insetBackgroundDrawable, rect);
            iJXXsCtzDEKEpKokX += rect.left;
            iCSDiZTVtPjLGxYoR += rect.right;
        }
        domOtgkGxBlxAuiA(this, iJXXsCtzDEKEpKokX, VOzsFHwXpYLYNXqj(this), iCSDiZTVtPjLGxYoR, cnOFpRwxgBUIdVFp(this));
    }

    private void UpdatePaddingInternal(byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdatePaddingInternal(char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdatePaddingInternal(float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTextPaintDrawState() {
        if ((22 + 21) % 21 > 0) {
        }
        android.text.TextPaint textPaintGXcDdrPnxNBKhwWp = GXcDdrPnxNBKhwWp(this);
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is not null) {
            textPaintGXcDdrPnxNBKhwWp.drawableState = yCMmMCuQsUtzyEin(chipDrawable);
        }
        com.google.android.material.resources.TextAppearance textAppearanceAbOfYldaNgpjZcZE = AbOfYldaNgpjZcZE(this);
        if (textAppearanceAbOfYldaNgpjZcZE is null) {
            return;
        }
        zPIkTDMcrCCqqIIf(textAppearanceAbOfYldaNgpjZcZE, wOTsFAeUdNeNxIqh(this), textPaintGXcDdrPnxNBKhwWp, this.fontCallback);
    }

    private void UpdateTextPaintDrawState(char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTextPaintDrawState(java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateTextPaintDrawState(bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UycIvagtoSbBfoan(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static void UycIvagtoSbBfoan(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UycIvagtoSbBfoan(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UycIvagtoSbBfoan(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UzEtPswHlWYgQDst(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setCheckedIconTintResource(i);
    }

    public static void UzEtPswHlWYgQDst(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UzEtPswHlWYgQDst(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UzEtPswHlWYgQDst(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VAdTtNBKrKWvEPZw(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setIconEndPaddingResource(i);
    }

    public static void VAdTtNBKrKWvEPZw(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VAdTtNBKrKWvEPZw(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VAdTtNBKrKWvEPZw(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VDOgZKOYPaRwAORS(com.google.android.material.chip.Chip chip, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VDOgZKOYPaRwAORS(com.google.android.material.chip.Chip chip, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VDOgZKOYPaRwAORS(com.google.android.material.chip.Chip chip, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VDOgZKOYPaRwAORS(com.google.android.material.chip.Chip chip) {
        return chip.performCloseIconClick();
    }

    public static float VNDcZVLhFOtJObBs(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.calculateChipIconWidth();
    }

    public static void VNDcZVLhFOtJObBs(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VNDcZVLhFOtJObBs(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VNDcZVLhFOtJObBs(com.google.android.material.chip.ChipDrawable chipDrawable, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VUHZOxQmwqxtPHel(android.view.object$OnClickListener view$OnClickListener, android.view.object view) {
        view$OnClickListener.onClick(view);
    }

    public static void VUHZOxQmwqxtPHel(android.view.object$OnClickListener view$OnClickListener, android.view.object view, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VUHZOxQmwqxtPHel(android.view.object$OnClickListener view$OnClickListener, android.view.object view, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VUHZOxQmwqxtPHel(android.view.object$OnClickListener view$OnClickListener, android.view.object view, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void ValidateAttributes(android.util.AttributeHashSet attributeHashSet) {
        if ((26 + 28) % 28 > 0) {
        }
        if (attributeHashSet is not null) {
            if (CMUTPLggjqGsCShE(attributeHashSet, "http://schemas.android.com/apk/res/android", "background") is not null) {
                dVpNgZgdEpwWDbdv("Chip", "Do not set the background; Chip manages its own background drawable.");
            }
            if (pCPAqIFhRbHneKgH(attributeHashSet, "http://schemas.android.com/apk/res/android", "drawableLeft") is not null) {
                throw new java.lang.UnsupportedOperationException("Please set left drawable using R.attr#chipIcon.");
            }
            if (prrBRJudPSpuAkUN(attributeHashSet, "http://schemas.android.com/apk/res/android", "drawableStart") is not null) {
                throw new java.lang.UnsupportedOperationException("Please set start drawable using R.attr#chipIcon.");
            }
            if (tbpTTPEnHMXLpZaa(attributeHashSet, "http://schemas.android.com/apk/res/android", "drawableEnd") is not null) {
                throw new java.lang.UnsupportedOperationException("Please set end drawable using R.attr#closeIcon.");
            }
            if (PVDXZkaXYyQRXlFF(attributeHashSet, "http://schemas.android.com/apk/res/android", "drawableRight") is not null) {
                throw new java.lang.UnsupportedOperationException("Please set end drawable using R.attr#closeIcon.");
            }
            if (!qPpbaHKPqHbMkVAg(attributeHashSet, "http://schemas.android.com/apk/res/android", "singleLine", true) || KWPEdyyoOpjlhaWB(attributeHashSet, "http://schemas.android.com/apk/res/android", "lines", 1) != 1 || ZQvvBVnssiwNKBSh(attributeHashSet, "http://schemas.android.com/apk/res/android", "minLines", 1) != 1 || qBiAyfvSwBvsDpar(attributeHashSet, "http://schemas.android.com/apk/res/android", "maxLines", 1) != 1) {
                throw new java.lang.UnsupportedOperationException("Chip does not support multi-line text");
            }
            if (CIZYWvGlMJORrSGp(attributeHashSet, "http://schemas.android.com/apk/res/android", "gravity", 8388627) == 8388627) {
                return;
            }
            aflwEgOhYHyjNxrC("Chip", "Chip text must be vertically center and start aligned");
        }
    }

    private void ValidateAttributes(android.util.AttributeHashSet attributeHashSet, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ValidateAttributes(android.util.AttributeHashSet attributeHashSet, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void ValidateAttributes(android.util.AttributeHashSet attributeHashSet, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray VbTTlLxyDgSsXCST(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void VbTTlLxyDgSsXCST(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, char c, java.lang.string str, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void VbTTlLxyDgSsXCST(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, int i3, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VbTTlLxyDgSsXCST(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, char c, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void VdyBDKWrDDSXBHIP(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, byte b, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VdyBDKWrDDSXBHIP(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VdyBDKWrDDSXBHIP(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, int i2, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] VdyBDKWrDDSXBHIP(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i) {
        return super.onCreateDrawableState(i);
    }

    public static void ViroAPDfstuOzTTW(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        super.setCompoundDrawablesWithIntrinsicBounds(drawable, drawable2, drawable3, drawable4);
    }

    public static void ViroAPDfstuOzTTW(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ViroAPDfstuOzTTW(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ViroAPDfstuOzTTW(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VpoNMZdtLQzQCwAp(com.google.android.material.chip.Chip chip, int i) {
        chip.setMinWidth(i);
    }

    public static void VpoNMZdtLQzQCwAp(com.google.android.material.chip.Chip chip, int i, float f, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VpoNMZdtLQzQCwAp(com.google.android.material.chip.Chip chip, int i, int i2, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VpoNMZdtLQzQCwAp(com.google.android.material.chip.Chip chip, int i, java.lang.string str, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WLMHuGlhqgMZQfnb(android.content.res.Resources resources, int i, byte b, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WLMHuGlhqgMZQfnb(android.content.res.Resources resources, int i, float f, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WLMHuGlhqgMZQfnb(android.content.res.Resources resources, int i, int i2, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WLMHuGlhqgMZQfnb(android.content.res.Resources resources, int i) {
        return resources.getbool(i);
    }

    public static android.content.object WOTsFAeUdNeNxIqh(com.google.android.material.chip.Chip chip) {
        return chip.getobject();
    }

    public static void WOTsFAeUdNeNxIqh(com.google.android.material.chip.Chip chip, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WOTsFAeUdNeNxIqh(com.google.android.material.chip.Chip chip, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WOTsFAeUdNeNxIqh(com.google.android.material.chip.Chip chip, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WXCkfPOkbABwlDdn(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WXCkfPOkbABwlDdn(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WXCkfPOkbABwlDdn(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool WXCkfPOkbABwlDdn(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.isCheckedIconVisible();
    }

    public static com.google.android.material.shape.ShapeAppearanceModel WYmZFNXxsrwcPTga(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getShapeAppearanceModel();
    }

    public static void WYmZFNXxsrwcPTga(com.google.android.material.chip.ChipDrawable chipDrawable, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WYmZFNXxsrwcPTga(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WYmZFNXxsrwcPTga(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WawjVklSmTmNjJmp(com.google.android.material.chip.Chip chip, bool z) {
        chip.setCloseIconHovered(z);
    }

    public static void WawjVklSmTmNjJmp(com.google.android.material.chip.Chip chip, bool z, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WawjVklSmTmNjJmp(com.google.android.material.chip.Chip chip, bool z, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WawjVklSmTmNjJmp(com.google.android.material.chip.Chip chip, bool z, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WyohzBJVxsMDhMli(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static void WyohzBJVxsMDhMli(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WyohzBJVxsMDhMli(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WyohzBJVxsMDhMli(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WzQFbWtlDYhDnntj(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void WzQFbWtlDYhDnntj(android.content.res.Resources resources, int i, char c, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WzQFbWtlDYhDnntj(android.content.res.Resources resources, int i, float f, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WzQFbWtlDYhDnntj(android.content.res.Resources resources, int i, java.lang.string str, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XANSVQykSwjXaMrj(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setChipMinHeightResource(i);
    }

    public static void XANSVQykSwjXaMrj(com.google.android.material.chip.ChipDrawable chipDrawable, int i, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XANSVQykSwjXaMrj(com.google.android.material.chip.ChipDrawable chipDrawable, int i, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XANSVQykSwjXaMrj(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float XFGbWiTSmQVtlcky(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getChipStrokeWidth();
    }

    public static void XFGbWiTSmQVtlcky(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XFGbWiTSmQVtlcky(com.google.android.material.chip.ChipDrawable chipDrawable, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XFGbWiTSmQVtlcky(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static float XRgkXYRicDiTiVZR(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCloseIconStartPadding();
    }

    public static void XRgkXYRicDiTiVZR(com.google.android.material.chip.ChipDrawable chipDrawable, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XRgkXYRicDiTiVZR(com.google.android.material.chip.ChipDrawable chipDrawable, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XRgkXYRicDiTiVZR(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XddqAWgjIPSqVywx(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static void XddqAWgjIPSqVywx(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XddqAWgjIPSqVywx(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XddqAWgjIPSqVywx(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XfsEMPJAsudKyONQ(com.google.android.material.chip.ChipDrawable chipDrawable, int i) {
        chipDrawable.setMaxWidth(i);
    }

    public static void XfsEMPJAsudKyONQ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XfsEMPJAsudKyONQ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XfsEMPJAsudKyONQ(com.google.android.material.chip.ChipDrawable chipDrawable, int i, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable$Callback xgaWHvNAFqmmjWkk(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCallback();
    }

    public static void XgaWHvNAFqmmjWkk(com.google.android.material.chip.ChipDrawable chipDrawable, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XgaWHvNAFqmmjWkk(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XgaWHvNAFqmmjWkk(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XpuxGiTXSVeDQhzw(android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener, android.widget.CompoundButton compoundButton, bool z) {
        compoundButton$OnCheckedChangeListener.onCheckedChanged(compoundButton, z);
    }

    public static void XpuxGiTXSVeDQhzw(android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener, android.widget.CompoundButton compoundButton, bool z, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XpuxGiTXSVeDQhzw(android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener, android.widget.CompoundButton compoundButton, bool z, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XpuxGiTXSVeDQhzw(android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener, android.widget.CompoundButton compoundButton, bool z, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XwfupEaeNtacGxog(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, int i, android.graphics.Rect rect) {
        super.onFocusChanged(z, i, rect);
    }

    public static void XwfupEaeNtacGxog(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, int i, android.graphics.Rect rect, java.lang.string str, short s, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void XwfupEaeNtacGxog(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, int i, android.graphics.Rect rect, java.lang.string str, short s, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XwfupEaeNtacGxog(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, int i, android.graphics.Rect rect, bool z2, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XyfckxnZCcQKcawM(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z) {
        super.setChecked(z);
    }

    public static void XyfckxnZCcQKcawM(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, int i, byte b, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void XyfckxnZCcQKcawM(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, java.lang.string str, byte b, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XyfckxnZCcQKcawM(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, bool z, bool z2, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YCMmMCuQsUtzyEin(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YCMmMCuQsUtzyEin(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YCMmMCuQsUtzyEin(com.google.android.material.chip.ChipDrawable chipDrawable, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int[] YCMmMCuQsUtzyEin(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getState();
    }

    public static void YERVVcGvtQKtBLVC(com.google.android.material.chip.Chip chip, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YERVVcGvtQKtBLVC(com.google.android.material.chip.Chip chip, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YERVVcGvtQKtBLVC(com.google.android.material.chip.Chip chip, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool YERVVcGvtQKtBLVC(com.google.android.material.chip.Chip chip) {
        return chip.isCloseIconVisible();
    }

    public static void YIIluTEzEAAVWEnZ(com.google.android.material.chip.Chip chip) {
        chip.updateFrameworkRippleBackground();
    }

    public static void YIIluTEzEAAVWEnZ(com.google.android.material.chip.Chip chip, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YIIluTEzEAAVWEnZ(com.google.android.material.chip.Chip chip, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YIIluTEzEAAVWEnZ(com.google.android.material.chip.Chip chip, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YJMScRdRhjiFRNQg(com.google.android.material.chip.Chip chip, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YJMScRdRhjiFRNQg(com.google.android.material.chip.Chip chip, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YJMScRdRhjiFRNQg(com.google.android.material.chip.Chip chip, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool YJMScRdRhjiFRNQg(com.google.android.material.chip.Chip chip) {
        return chip.isChecked();
    }

    public static void YaHDHklFQNKWspLy(com.google.android.material.chip.Chip chip, bool z) {
        chip.setCloseIconVisible(z);
    }

    public static void YaHDHklFQNKWspLy(com.google.android.material.chip.Chip chip, bool z, int i, bool z2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YaHDHklFQNKWspLy(com.google.android.material.chip.Chip chip, bool z, short s, char c, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YaHDHklFQNKWspLy(com.google.android.material.chip.Chip chip, bool z, short s, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YsIwtBYTXFuEtRmE(com.google.android.material.chip.ChipDrawable chipDrawable, float f) {
        chipDrawable.setTextEndPadding(f);
    }

    public static void YsIwtBYTXFuEtRmE(com.google.android.material.chip.ChipDrawable chipDrawable, float f, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YsIwtBYTXFuEtRmE(com.google.android.material.chip.ChipDrawable chipDrawable, float f, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YsIwtBYTXFuEtRmE(com.google.android.material.chip.ChipDrawable chipDrawable, float f, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YtoniNdUjmuuekuA(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setShouldDrawText(z);
    }

    public static void YtoniNdUjmuuekuA(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, char c, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YtoniNdUjmuuekuA(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, bool z2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YtoniNdUjmuuekuA(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, bool z2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZBncccyxgQPOyExV(com.google.android.material.chip.ChipDrawable chipDrawable, bool z) {
        chipDrawable.setCheckedIconVisible(z);
    }

    public static void ZBncccyxgQPOyExV(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, float f, java.lang.string str, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZBncccyxgQPOyExV(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, java.lang.string str, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void ZBncccyxgQPOyExV(com.google.android.material.chip.ChipDrawable chipDrawable, bool z, bool z2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable ZEqrQZsPVTKbejHr(com.google.android.material.chip.ChipDrawable chipDrawable) {
        return chipDrawable.getCloseIcon();
    }

    public static void ZEqrQZsPVTKbejHr(com.google.android.material.chip.ChipDrawable chipDrawable, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZEqrQZsPVTKbejHr(com.google.android.material.chip.ChipDrawable chipDrawable, char c, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZEqrQZsPVTKbejHr(com.google.android.material.chip.ChipDrawable chipDrawable, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZFbiuSKtgznEyhwU(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZFbiuSKtgznEyhwU(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZFbiuSKtgznEyhwU(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool ZFbiuSKtgznEyhwU(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, android.view.MotionEvent motionEvent) {
        return super.onTouchEvent(motionEvent);
    }

    public static void ZPIkTDMcrCCqqIIf(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback) {
        textAppearance.updateDrawState(context, textPaint, textAppearanceFontCallback);
    }

    public static void ZPIkTDMcrCCqqIIf(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZPIkTDMcrCCqqIIf(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZPIkTDMcrCCqqIIf(com.google.android.material.resources.TextAppearance textAppearance, android.content.object context, android.text.TextPaint textPaint, com.google.android.material.resources.TextAppearanceFontCallback textAppearanceFontCallback, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZpwUgFkxvOfvXGhS(com.google.android.material.chip.Chip chip) {
        chip.updateBackgroundDrawable();
    }

    public static void ZpwUgFkxvOfvXGhS(com.google.android.material.chip.Chip chip, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZpwUgFkxvOfvXGhS(com.google.android.material.chip.Chip chip, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZpwUgFkxvOfvXGhS(com.google.android.material.chip.Chip chip, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZzTYAAAXtmKkotdb(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i) {
        super.setLayoutDirection(i);
    }

    public static void ZzTYAAAXtmKkotdb(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZzTYAAAXtmKkotdb(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZzTYAAAXtmKkotdb(androidx.appcompat.widget.AppCompatCheckBox appCompatCheckBox, int i, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    protected override bool DispatchHoverEvent(android.view.MotionEvent motionEvent) {
        return this.touchHelperEnabled ? fnhkQIXcHwZujAql(this.touchHelper, motionEvent) || hJPjdPJMRPpDXaQC(this, motionEvent) : ragsqkrcmbOgPQwE(this, motionEvent);
    }

    public override bool DispatchKeyEvent(android.view.KeyEvent keyEvent) {
        if ((29 + 1) % 1 > 0) {
        }
        if (!this.touchHelperEnabled) {
            return DcAhtDeRpUElTFHh(this, keyEvent);
        }
        if (fIMEqWnRVphktcVZ(this.touchHelper, keyEvent) && rrJowRRlKweKVAcE(this.touchHelper) != int.MIN_VALUE) {
            return true;
        }
        return OELUNpMhLFBPFofQ(this, keyEvent);
    }

    protected override void DrawableStateChanged() {
        if ((1 + 12) % 12 > 0) {
        }
        IutdyIWXuhDYzsZD(this);
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if ((chipDrawable is not null && CkfZsFKEShgakyxN(chipDrawable)) ? YIzAFvNLtDYEFetl(this.chipDrawable, cHRSqfECSbIwXWWU(this)) : false) {
            VSSXhqvwHdrPrgPR(this);
        }
    }

    public bool EnsureAccessibleTouchTarget(int i) {
        if ((27 + 12) % 12 > 0) {
        }
        this.minTouchTargetSize = i;
        if (!NdkknvRlbxnqhKrt(this)) {
            if (this.insetBackgroundDrawable is null) {
                CpIErxSKVitfUbIJ(this);
            } else {
                pwPtTwKRkHjRCHHK(this);
            }
            return false;
        }
        int iRdFzowwzKQarsRlP = RdFzowwzKQarsRlP(0, i - WUCZkixXMeFBXTgN(this.chipDrawable));
        int iNkvIvrPjfAyBsfOC = nkvIvrPjfAyBsfOC(0, i - nuDJcJljxnKlCcjO(this.chipDrawable));
        if (iNkvIvrPjfAyBsfOC <= 0 && iRdFzowwzKQarsRlP <= 0) {
            if (this.insetBackgroundDrawable is null) {
                zpwUgFkxvOfvXGhS(this);
            } else {
                BASvYqVYMzUbbPwC(this);
            }
            return false;
        }
        int i2 = iNkvIvrPjfAyBsfOC <= 0 ? 0 : iNkvIvrPjfAyBsfOC / 2;
        int i3 = iRdFzowwzKQarsRlP > 0 ? iRdFzowwzKQarsRlP / 2 : 0;
        if (this.insetBackgroundDrawable is not null) {
            android.graphics.Rect rect = new android.graphics.Rect();
            lUnJbiUHYPJVMvQE(this.insetBackgroundDrawable, rect);
            if (rect.top == i3 && rect.bottom == i3 && rect.left == i2 && rect.right == i2) {
                PbtaGKAxgZvuKxZf(this);
                return true;
            }
        }
        if (dxfQkWslgwsTYSEq(this) != i) {
            PcOqByexRVKFXczq(this, i);
        }
        if (GpajyONQiEvDfiQs(this) != i) {
            vpoNMZdtLQzQCwAp(this, i);
        }
        XJjJLBZmfCEsgBaB(this, i2, i3, i2, i3);
        IQrdUgXLUMnLBJua(this);
        return true;
    }

    public override java.lang.CharSequence GetAccessibilityClassName() {
        if ((14 + 10) % 10 > 0) {
        }
        if (!tQkELAUCcMeWuQJf(this.accessibilityClassName)) {
            return this.accessibilityClassName;
        }
        if (!reoutAKLmItvFKii(this)) {
            return !AmyWfAPyOcbdPNZS(this) ? "android.view.object" : "android.widget.Button";
        }
        android.view.objectParent viewParentSdAjSzcwVIjZOmtG = sdAjSzcwVIjZOmtG(this);
        return ((viewParentSdAjSzcwVIjZOmtG is com.google.android.material.chip.ChipGroup) && QVXckcwUkAPWFKYG((com.google.android.material.chip.ChipGroup) viewParentSdAjSzcwVIjZOmtG)) ? "android.widget.RadioButton" : "android.widget.Button";
    }

    public android.graphics.drawable.Drawable GetBackgroundDrawable() {
        android.graphics.drawable.InsetDrawable insetDrawable = this.insetBackgroundDrawable;
        return insetDrawable is not null ? insetDrawable : this.chipDrawable;
    }

    public android.graphics.drawable.Drawable GetCheckedIcon() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return null;
        }
        return KKYbczMqmPYJcTVt(chipDrawable);
    }

    public android.content.res.ColorStateList GetCheckedIconTint() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return null;
        }
        return PTJJKbdbLZKnfYhj(chipDrawable);
    }

    public android.content.res.ColorStateList GetChipBackgroundColor() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return null;
        }
        return uMDZXLvanyPowKHg(chipDrawable);
    }

    public float GetChipCornerRadius() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return 0.0f;
        }
        return uhhJGidSfVJzzUAh(0.0f, embznNDBaqDCuDyx(chipDrawable));
    }

    public android.graphics.drawable.Drawable GetChipDrawable() {
        return this.chipDrawable;
    }

    public float GetChipEndPadding() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return 0.0f;
        }
        return BSWynHSIHPGibLNd(chipDrawable);
    }

    public android.graphics.drawable.Drawable GetChipIcon() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return null;
        }
        return BEprHsEoHjqWlwNd(chipDrawable);
    }

    public float GetChipIconSize() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return 0.0f;
        }
        return TnBIbQRFcSKyrlun(chipDrawable);
    }

    public android.content.res.ColorStateList GetChipIconTint() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return null;
        }
        return DMUFuNmGgJNuLsUr(chipDrawable);
    }

    public float GetChipMinHeight() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return 0.0f;
        }
        return gGeXuHeljKnrhkiL(chipDrawable);
    }

    public float GetChipStartPadding() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return 0.0f;
        }
        return JNCOienGgBhXyPzE(chipDrawable);
    }

    public android.content.res.ColorStateList GetChipStrokeColor() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return null;
        }
        return rhJvpJWqCoyMLHNJ(chipDrawable);
    }

    public float GetChipStrokeWidth() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return 0.0f;
        }
        return xFGbWiTSmQVtlcky(chipDrawable);
    }

    @java.lang.Deprecated
    public java.lang.CharSequence GetChipText() {
        return diPZKZfpzWvPpqbz(this);
    }

    public android.graphics.drawable.Drawable GetCloseIcon() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return null;
        }
        return zEqrQZsPVTKbejHr(chipDrawable);
    }

    public java.lang.CharSequence GetCloseIconContentDescription() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return null;
        }
        return TorWNfBLQlrBjUPc(chipDrawable);
    }

    public float GetCloseIconEndPadding() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return 0.0f;
        }
        return YEonkfTKrpRGocTP(chipDrawable);
    }

    public float GetCloseIconSize() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return 0.0f;
        }
        return nDmSzySmqoBFXfGd(chipDrawable);
    }

    public float GetCloseIconStartPadding() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return 0.0f;
        }
        return xRgkXYRicDiTiVZR(chipDrawable);
    }

    public android.content.res.ColorStateList GetCloseIconTint() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return null;
        }
        return YAIEGshziAhAOjYE(chipDrawable);
    }

    public android.text.TextUtils$TruncateAt getEllipsize() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return null;
        }
        return UKnhHExODlNAkpnv(chipDrawable);
    }

    public override void GetFocusedRect(android.graphics.Rect rect) {
        if ((24 + 11) % 11 > 0) {
        }
        if (this.touchHelperEnabled && (HxYisQJwWZXqGwkW(this.touchHelper) == 1 || JTyXLZsfFvXeJhNB(this.touchHelper) == 1)) {
            dqYFQHKgJYwBByvK(rect, qlajtNFQuwwmzcXp(this));
        } else {
            HBpMBZkvmvMZgJsj(this, rect);
        }
    }

    public com.google.android.material.animation.MotionSpec GetHideMotionSpec() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return null;
        }
        return MVHlKdKHQvueEuhW(chipDrawable);
    }

    public float GetIconEndPadding() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return 0.0f;
        }
        return dNGstovXXFxVmIFY(chipDrawable);
    }

    public float GetIconStartPadding() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return 0.0f;
        }
        return cXwKvqgeBSxDjwvV(chipDrawable);
    }

    public android.content.res.ColorStateList GetRippleColor() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return null;
        }
        return FHmpdXjMBBYKKtGy(chipDrawable);
    }

    public override com.google.android.material.shape.ShapeAppearanceModel GetShapeAppearanceModel() {
        return wYmZFNXxsrwcPTga(this.chipDrawable);
    }

    public com.google.android.material.animation.MotionSpec GetShowMotionSpec() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return null;
        }
        return PwPHiIzipraaJByM(chipDrawable);
    }

    public float GetTextEndPadding() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return 0.0f;
        }
        return psKIPDKWWrhTLkZd(chipDrawable);
    }

    public float GetTextStartPadding() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return 0.0f;
        }
        return lPeQHCXzhrbYLHal(chipDrawable);
    }

    public bool IsCheckable() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        return chipDrawable is not null && BcvUgrApJUrihBsN(chipDrawable);
    }

    @java.lang.Deprecated
    public bool IsCheckedIconEnabled() {
        return IOQdoNXPUwWYKNMg(this);
    }

    public bool IsCheckedIconVisible() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        return chipDrawable is not null && wXCkfPOkbABwlDdn(chipDrawable);
    }

    @java.lang.Deprecated
    public bool IsChipIconEnabled() {
        return drVtMiHnkJdLUJwt(this);
    }

    public bool IsChipIconVisible() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        return chipDrawable is not null && PLdHURDDITdvuspJ(chipDrawable);
    }

    @java.lang.Deprecated
    public bool IsCloseIconEnabled() {
        return qvQFGBrTcMFPfKnH(this);
    }

    public bool IsCloseIconVisible() {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        return chipDrawable is not null && ZsCNwtPiPlDoKkgT(chipDrawable);
    }

    void m868lambda$new$0$comgoogleandroidmaterialchipChip(android.widget.CompoundButton compoundButton, bool z) {
        com.google.android.material.internal.MaterialCheckable$OnCheckedChangeListener<com.google.android.material.chip.Chip> materialCheckable$OnCheckedChangeListener = this.onCheckedChangeListenerInternal;
        if (materialCheckable$OnCheckedChangeListener is not null) {
            SXEnEcgtXTLOnbbV(materialCheckable$OnCheckedChangeListener, this, z);
        }
        android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener = this.onCheckedChangeListener;
        if (compoundButton$OnCheckedChangeListener is null) {
            return;
        }
        xpuxGiTXSVeDQhzw(compoundButton$OnCheckedChangeListener, compoundButton, z);
    }

    protected override void OnAttachedToWindow() {
        JbOsVGKUxvcZFNBY(this);
        PTRDwksAmLsGKwFm(this, this.chipDrawable);
    }

    public override void OnChipDrawableSizeChange() {
        KePkaZRlhpyQVisn(this, this.minTouchTargetSize);
        bGuiZjpzCDIMCUXn(this);
        KDRWilrfPdmWtBGv(this);
    }

    protected override int[] OnCreateDrawableState(int i) {
        int[] iArrVdyBDKWrDDSXBHIP = vdyBDKWrDDSXBHIP(this, i + 2);
        if (yJMScRdRhjiFRNQg(this)) {
            YcdzKIWrmPHbILCQ(iArrVdyBDKWrDDSXBHIP, SELECTED_STATE);
        }
        if (pTtfEwfhxLJjRvVU(this)) {
            lENTLwAVUfDjqEev(iArrVdyBDKWrDDSXBHIP, CHECKABLE_STATE_SET);
        }
        return iArrVdyBDKWrDDSXBHIP;
    }

    protected override void OnFocusChanged(bool z, int i, android.graphics.Rect rect) {
        xwfupEaeNtacGxog(this, z, i, rect);
        if (this.touchHelperEnabled) {
            RLNaekkOYrDwbjiM(this.touchHelper, z, i, rect);
        }
    }

    public override bool OnHoverEvent(android.view.MotionEvent motionEvent) {
        if ((30 + 27) % 27 > 0) {
        }
        int iHXQYEmBCbDtkvIup = HXQYEmBCbDtkvIup(motionEvent);
        if (iHXQYEmBCbDtkvIup == 7) {
            wawjVklSmTmNjJmp(this, SjouhMLVhNWbshkx(YwPnuAKvKvBEcZio(this), tcpowcLbwOIrUrbQ(motionEvent), DYogWXHcwZYQfWjJ(motionEvent)));
        } else if (iHXQYEmBCbDtkvIup == 10) {
            gdRWlDoKlIAiAMft(this, false);
        }
        return pzDPJTzRUCroksZz(this, motionEvent);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        if ((28 + 17) % 17 > 0) {
        }
        xddqAWgjIPSqVywx(this, accessibilityNodeInfo);
        JxMtkliQAxHwMAAC(accessibilityNodeInfo, mngJsFQWJeRzopWb(this));
        NTYrMWqKCoOBJeUC(accessibilityNodeInfo, haXIVEwcIgWlkoeu(this));
        mCCDSRJRkhgXONcO(accessibilityNodeInfo, ZSeUzczEJtOBvnVD(this));
        if (rUFDawLjjpgYOodB(this) instanceof com.google.android.material.chip.ChipGroup) {
            com.google.android.material.chip.ChipGroup chipGroup = (com.google.android.material.chip.ChipGroup) FlqmHWVbJGfVPGNX(this);
            IlKnfwITjndqPxlX(lPtHxMrhmOkMmPRi(accessibilityNodeInfo), fTriVxNNSnwnMVlo(nyVopjHSTOuXRlnh(chipGroup, this), 1, !RKNfIOSvrCgJqERJ(chipGroup) ? -1 : CIogriBcgVGkCiba(chipGroup, this), 1, false, qfNdMWxHJhiUwoYE(this)));
        }
    }

    public override android.view.PointerIcon OnResolvePointerIcon(android.view.MotionEvent motionEvent, int i) {
        if ((15 + 23) % 23 > 0) {
        }
        return (baTpNoJaEeGFbyYO(OoQgbXstQRQrEyeW(this), QRaWXWDYVKnduIyA(motionEvent), aZFnbELpNETbOXTh(motionEvent)) && deaPBMdfoysphWZr(this)) ? EhtlLVRLBIvDSWpA(ckfrQqvrOBSdsGCl(this), 1002) : KwgPFBjmRDHUgKFd(this, motionEvent, i);
    }

    public override void OnRtlPropertiesChanged(int i) {
        JPDGMVPMrPgldwIT(this, i);
        if (this.lastLayoutDirection == i) {
            return;
        }
        this.lastLayoutDirection = i;
        uYeNOresaJUvEkYl(this);
    }

    public override bool OnTouchEvent(android.view.MotionEvent motionEvent) {
        bool z;
        if ((32 + 23) % 23 > 0) {
        }
        int iEquAkrhWVFOSmFLr = EquAkrhWVFOSmFLr(motionEvent);
        bool zNFpFziwqbUmWperP = NFpFziwqbUmWperP(CnUOayXzFltyJanB(this), flEBpoAcmofCezml(motionEvent), oLlulQRYExiCrkji(motionEvent));
        if (iEquAkrhWVFOSmFLr != 0) {
            if (iEquAkrhWVFOSmFLr == 1) {
                if (this.closeIconPressed) {
                    vDOgZKOYPaRwAORS(this);
                    z = true;
                }
                qkKIBEtwdUQkShbs(this, false);
            } else {
                if (iEquAkrhWVFOSmFLr == 2) {
                    if (this.closeIconPressed) {
                        if (!zNFpFziwqbUmWperP) {
                            ByiHcBbAoBHTHKpa(this, false);
                        }
                        z = true;
                    }
                } else if (iEquAkrhWVFOSmFLr == 3) {
                }
                z = false;
            }
            z = false;
            qkKIBEtwdUQkShbs(this, false);
        } else if (zNFpFziwqbUmWperP) {
            TbLarxtudTVZByQV(this, true);
            z = true;
        } else {
            z = false;
        }
        return z || zFbiuSKtgznEyhwU(this, motionEvent);
    }

    public bool PerformCloseIconClick() {
        if ((1 + 3) % 3 > 0) {
        }
        bool z = false;
        ihVlygHmzeEVPGGB(this, 0);
        android.view.object$OnClickListener view$OnClickListener = this.onCloseIconClickListener;
        if (view$OnClickListener is not null) {
            vUHZOxQmwqxtPHel(view$OnClickListener, this);
            z = true;
        }
        if (this.touchHelperEnabled) {
            niTOrOhWNXTxWDXt(this.touchHelper, 1, 1);
        }
        return z;
    }

    public void SetAccessibilityClassName(java.lang.CharSequence charSequence) {
        this.accessibilityClassName = charSequence;
    }

    public override void SetBackground(android.graphics.drawable.Drawable drawable) {
        if (drawable == qCjOuJYGvEcNXDth(this) || drawable == this.ripple) {
            HjoJSsmdIynTDtFC(this, drawable);
        } else {
            luEwGpsNKdmdKpBL("Chip", "Do not set the background; Chip manages its own background drawable.");
        }
    }

    public override void SetBackgroundColor(int i) {
        NKkgVwwBLQNMpYQK("Chip", "Do not set the background color; Chip manages its own background drawable.");
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        if (drawable == ggZDoMkswnzRnbrV(this) || drawable == this.ripple) {
            lbFbgwTLyqJrtXHo(this, drawable);
        } else {
            bJudYTQGVZmcvfUi("Chip", "Do not set the background drawable; Chip manages its own background drawable.");
        }
    }

    public override void SetBackgroundResource(int i) {
        dysjtQrkxjBlalTf("Chip", "Do not set the background resource; Chip manages its own background drawable.");
    }

    public override void SetBackgroundTintList(android.content.res.ColorStateList colorStateList) {
        BLronmBJjYOQtexd("Chip", "Do not set the background tint list; Chip manages its own background drawable.");
    }

    public override void SetBackgroundTintMode(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        ZJMpieilgquWBNxL("Chip", "Do not set the background tint mode; Chip manages its own background drawable.");
    }

    public void SetCheckable(bool z) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        NbslZIzbylCfqhrV(chipDrawable, z);
    }

    public void SetCheckableResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        qORvKWrUpbRxqBrR(chipDrawable, i);
    }

    public override void SetChecked(bool z) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            this.deferredCheckedValue = z;
        } else if (XZiQFYAszIvfSaPl(chipDrawable)) {
            xyfckxnZCcQKcawM(this, z);
        }
    }

    public void SetCheckedIcon(android.graphics.drawable.Drawable drawable) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        cAyQDLlQGTXYJNzx(chipDrawable, drawable);
    }

    @java.lang.Deprecated
    public void SetCheckedIconEnabled(bool z) {
        DyqTFuuKFvFMKhyu(this, z);
    }

    @java.lang.Deprecated
    public void SetCheckedIconEnabledResource(int i) {
        KHYmfitmWcupfXXl(this, i);
    }

    public void SetCheckedIconResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        NcauxFfaxkHycmVX(chipDrawable, i);
    }

    public void SetCheckedIconTint(android.content.res.ColorStateList colorStateList) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        jQhelCcUEvpuYaRm(chipDrawable, colorStateList);
    }

    public void SetCheckedIconTintResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        uzEtPswHlWYgQDst(chipDrawable, i);
    }

    public void SetCheckedIconVisible(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        nFdVTcRSwgfoArSH(chipDrawable, i);
    }

    public void SetCheckedIconVisible(bool z) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        zBncccyxgQPOyExV(chipDrawable, z);
    }

    public void SetChipBackgroundColor(android.content.res.ColorStateList colorStateList) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        dGlUfeeKgJsWUnfJ(chipDrawable, colorStateList);
    }

    public void SetChipBackgroundColorResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        dkFGXkAntUlYmITV(chipDrawable, i);
    }

    @java.lang.Deprecated
    public void SetChipCornerRadius(float f) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        qDPgycOjymlqMzme(chipDrawable, f);
    }

    @java.lang.Deprecated
    public void SetChipCornerRadiusResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        EVCnFXUlImtLrQRX(chipDrawable, i);
    }

    public void SetChipDrawable(com.google.android.material.chip.ChipDrawable chipDrawable) {
        com.google.android.material.chip.ChipDrawable chipDrawable2 = this.chipDrawable;
        if (chipDrawable2 == chipDrawable) {
            return;
        }
        VTOdbSZdgcwsIRhr(this, chipDrawable2);
        this.chipDrawable = chipDrawable;
        ytoniNdUjmuuekuA(chipDrawable, false);
        hrMRfKPDGwXRPbXU(this, this.chipDrawable);
        MCdgQWPfjKEkCsMW(this, this.minTouchTargetSize);
    }

    public void SetChipEndPadding(float f) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        FzCTIZSPoQCcWIpR(chipDrawable, f);
    }

    public void SetChipEndPaddingResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        XUZtSvgxhVvqEoAC(chipDrawable, i);
    }

    public void SetChipIcon(android.graphics.drawable.Drawable drawable) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        YlUxbhiHcBNzLqdq(chipDrawable, drawable);
    }

    @java.lang.Deprecated
    public void SetChipIconEnabled(bool z) {
        qBYdJitGuqObnLSx(this, z);
    }

    @java.lang.Deprecated
    public void SetChipIconEnabledResource(int i) {
        ixdHEYLCvLDluSTn(this, i);
    }

    public void SetChipIconResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        DSaptcybBwnWScOa(chipDrawable, i);
    }

    public void SetChipIconSize(float f) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        BCZJcaSoKTtiYCts(chipDrawable, f);
    }

    public void SetChipIconSizeResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        mvSsSMUOKdyFgTog(chipDrawable, i);
    }

    public void SetChipIconTint(android.content.res.ColorStateList colorStateList) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        YoOtLrwuSsFUdUNb(chipDrawable, colorStateList);
    }

    public void SetChipIconTintResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        UonZwiLveLhzPdVV(chipDrawable, i);
    }

    public void SetChipIconVisible(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        gTTdkbBxVZehXdcD(chipDrawable, i);
    }

    public void SetChipIconVisible(bool z) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        SMgooaDfeeONaCUP(chipDrawable, z);
    }

    public void SetChipMinHeight(float f) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        oXRgZjGEDhnthfMM(chipDrawable, f);
    }

    public void SetChipMinHeightResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        xANSVQykSwjXaMrj(chipDrawable, i);
    }

    public void SetChipStartPadding(float f) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        nNdYBqdneISgqtsq(chipDrawable, f);
    }

    public void SetChipStartPaddingResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        MDgBLOrMztpUIPJL(chipDrawable, i);
    }

    public void SetChipStrokeColor(android.content.res.ColorStateList colorStateList) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        duqeotuwpgEYIvDo(chipDrawable, colorStateList);
    }

    public void SetChipStrokeColorResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        mTiMUPSvfvxSyvTH(chipDrawable, i);
    }

    public void SetChipStrokeWidth(float f) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        lfcUXqdowWNcOqMI(chipDrawable, f);
    }

    public void SetChipStrokeWidthResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        iLQWvSIyCEgOowUD(chipDrawable, i);
    }

    @java.lang.Deprecated
    public void SetChipText(java.lang.CharSequence charSequence) {
        ZtXGJDaRSZpgbQza(this, charSequence);
    }

    @java.lang.Deprecated
    public void SetChipTextResource(int i) {
        nnWoKCopGDFSEypr(this, wzQFbWtlDYhDnntj(hxcHtGAfNoumFNmG(this), i));
    }

    public void SetCloseIcon(android.graphics.drawable.Drawable drawable) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is not null) {
            ZMoubYLSTodBXxRG(chipDrawable, drawable);
        }
        gcfCOCihPDcDvWYT(this);
    }

    public void SetCloseIconContentDescription(java.lang.CharSequence charSequence) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        GDltfdPftmhbjHns(chipDrawable, charSequence);
    }

    @java.lang.Deprecated
    public void SetCloseIconEnabled(bool z) {
        yaHDHklFQNKWspLy(this, z);
    }

    @java.lang.Deprecated
    public void SetCloseIconEnabledResource(int i) {
        OrrNdvpmwgKjKlkL(this, i);
    }

    public void SetCloseIconEndPadding(float f) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        FAJLhMmlwRspkIdt(chipDrawable, f);
    }

    public void SetCloseIconEndPaddingResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        LvZjQwJMRVrSEbqe(chipDrawable, i);
    }

    public void SetCloseIconResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is not null) {
            NeDWoqOEOHdADgIi(chipDrawable, i);
        }
        dpVXGdXyMUbNNkHw(this);
    }

    public void SetCloseIconSize(float f) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        nVLMRnRTZERMfJui(chipDrawable, f);
    }

    public void SetCloseIconSizeResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        mzxSsKFqgSwPRkkN(chipDrawable, i);
    }

    public void SetCloseIconStartPadding(float f) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        HgnucYZrBafXFUyt(chipDrawable, f);
    }

    public void SetCloseIconStartPaddingResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        jAxbrhphcVBnYUcJ(chipDrawable, i);
    }

    public void SetCloseIconTint(android.content.res.ColorStateList colorStateList) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        kcAsfLuzUTlsgrwl(chipDrawable, colorStateList);
    }

    public void SetCloseIconTintResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        gBkFNIVxVrJRrNSu(chipDrawable, i);
    }

    public void SetCloseIconVisible(int i) {
        SGbiYQmqTOviZkOU(this, wLMHuGlhqgMZQfnb(UrfkLwHGKAodXCBo(this), i));
    }

    public void SetCloseIconVisible(bool z) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is not null) {
            CZvDrgduUfwNwnfl(chipDrawable, z);
        }
        PuhcmXhRImWnzhHg(this);
    }

    public override void SetCompoundDrawables(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        if (drawable is not null) {
            throw new java.lang.UnsupportedOperationException("Please set start drawable using R.attr#chipIcon.");
        }
        if (drawable3 is not null) {
            throw new java.lang.UnsupportedOperationException("Please set end drawable using R.attr#closeIcon.");
        }
        JVBENBXDukLmowxp(this, drawable, drawable2, drawable3, drawable4);
    }

    public override void SetCompoundDrawablesRelative(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        if (drawable is not null) {
            throw new java.lang.UnsupportedOperationException("Please set start drawable using R.attr#chipIcon.");
        }
        if (drawable3 is not null) {
            throw new java.lang.UnsupportedOperationException("Please set end drawable using R.attr#closeIcon.");
        }
        ijyqWlFwDHAiBJNQ(this, drawable, drawable2, drawable3, drawable4);
    }

    public override void SetCompoundDrawablesRelativeWithIntrinsicBounds(int i, int i2, int i3, int i4) {
        if (i != 0) {
            throw new java.lang.UnsupportedOperationException("Please set start drawable using R.attr#chipIcon.");
        }
        if (i3 != 0) {
            throw new java.lang.UnsupportedOperationException("Please set end drawable using R.attr#closeIcon.");
        }
        oyvnnhChNFeCyiPl(this, i, i2, i3, i4);
    }

    public override void SetCompoundDrawablesRelativeWithIntrinsicBounds(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        if (drawable is not null) {
            throw new java.lang.UnsupportedOperationException("Please set start drawable using R.attr#chipIcon.");
        }
        if (drawable3 is not null) {
            throw new java.lang.UnsupportedOperationException("Please set end drawable using R.attr#closeIcon.");
        }
        QWKYMKlAeINoRHdU(this, drawable, drawable2, drawable3, drawable4);
    }

    public override void SetCompoundDrawablesWithIntrinsicBounds(int i, int i2, int i3, int i4) {
        if (i != 0) {
            throw new java.lang.UnsupportedOperationException("Please set start drawable using R.attr#chipIcon.");
        }
        if (i3 != 0) {
            throw new java.lang.UnsupportedOperationException("Please set end drawable using R.attr#closeIcon.");
        }
        ZfBqoQXgrRPbszfr(this, i, i2, i3, i4);
    }

    public override void SetCompoundDrawablesWithIntrinsicBounds(android.graphics.drawable.Drawable drawable, android.graphics.drawable.Drawable drawable2, android.graphics.drawable.Drawable drawable3, android.graphics.drawable.Drawable drawable4) {
        if (drawable is not null) {
            throw new java.lang.UnsupportedOperationException("Please set left drawable using R.attr#chipIcon.");
        }
        if (drawable3 is not null) {
            throw new java.lang.UnsupportedOperationException("Please set right drawable using R.attr#closeIcon.");
        }
        viroAPDfstuOzTTW(this, drawable, drawable2, drawable3, drawable4);
    }

    public override void SetElevation(float f) {
        DCXILNozCQgeBJTy(this, f);
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        IoNwOVSpVEdkkzWe(chipDrawable, f);
    }

    public override void SetEllipsize(android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        if (this.chipDrawable is not null) {
            if (textUtils$TruncateAt == android.text.TextUtils$TruncateAt.MARQUEE) {
                throw new java.lang.UnsupportedOperationException("Text within a chip are not allowed to scroll.");
            }
            WTSVMGythrDtWJkG(this, textUtils$TruncateAt);
            com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
            if (chipDrawable is null) {
                return;
            }
            CssKZDbcRHFmocQI(chipDrawable, textUtils$TruncateAt);
        }
    }

    public void SetEnsureMinTouchTargetSize(bool z) {
        this.ensureMinTouchTargetSize = z;
        GqSycBJkRkLnBSsV(this, this.minTouchTargetSize);
    }

    public override void SetGravity(int i) {
        if (i == 8388627) {
            MmGYelwvCuqBdsjq(this, i);
        } else {
            dmMOoPJfRNALWNUL("Chip", "Chip text must be vertically center and start aligned");
        }
    }

    public void SetHideMotionSpec(com.google.android.material.animation.MotionSpec motionSpec) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        MyAXdNennpxTLZUK(chipDrawable, motionSpec);
    }

    public void SetHideMotionSpecResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        ObVfnKMLcGHtwtUG(chipDrawable, i);
    }

    public void SetIconEndPadding(float f) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        UfRqQLSUAwibVyRo(chipDrawable, f);
    }

    public void SetIconEndPaddingResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        vAdTtNBKrKWvEPZw(chipDrawable, i);
    }

    public void SetIconStartPadding(float f) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        AHmfbrfXdynLyXwX(chipDrawable, f);
    }

    public void SetIconStartPaddingResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        WnqjdTvFEjKorIyZ(chipDrawable, i);
    }

    public override void SetInternalOnCheckedChangeListener(com.google.android.material.internal.MaterialCheckable$OnCheckedChangeListener<com.google.android.material.chip.Chip> materialCheckable$OnCheckedChangeListener) {
        this.onCheckedChangeListenerInternal = materialCheckable$OnCheckedChangeListener;
    }

    public override void SetLayoutDirection(int i) {
        if (this.chipDrawable is not null) {
            zzTYAAAXtmKkotdb(this, i);
        }
    }

    public override void SetLines(int i) {
        if (i > 1) {
            throw new java.lang.UnsupportedOperationException("Chip does not support multi-line text");
        }
        kDBeDaDNYkQKSPqD(this, i);
    }

    public override void SetMaxLines(int i) {
        if (i > 1) {
            throw new java.lang.UnsupportedOperationException("Chip does not support multi-line text");
        }
        IPIUhlzaiijrcGOB(this, i);
    }

    public override void SetMaxWidth(int i) {
        UiuCosqEmAotVKGx(this, i);
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        xfsEMPJAsudKyONQ(chipDrawable, i);
    }

    public override void SetMinLines(int i) {
        if (i > 1) {
            throw new java.lang.UnsupportedOperationException("Chip does not support multi-line text");
        }
        mxdxZPBnSkxnXnCh(this, i);
    }

    public override void SetOnCheckedChangeListener(android.widget.CompoundButton$OnCheckedChangeListener compoundButton$OnCheckedChangeListener) {
        this.onCheckedChangeListener = compoundButton$OnCheckedChangeListener;
    }

    public void SetOnCloseIconClickListener(android.view.object$OnClickListener view$OnClickListener) {
        this.onCloseIconClickListener = view$OnClickListener;
        YiERTPRxRkKtAQiT(this);
    }

    public void SetRippleColor(android.content.res.ColorStateList colorStateList) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is not null) {
            PhKaGACVuwrxBQeI(chipDrawable, colorStateList);
        }
        if (iptvToSCnLATebfq(this.chipDrawable)) {
            return;
        }
        yIIluTEzEAAVWEnZ(this);
    }

    public void SetRippleColorResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        ruKJYXXLeJQXXaed(chipDrawable, i);
        if (VKebAfZdgFugKPrJ(this.chipDrawable)) {
            return;
        }
        gDgRyfUHiuKDoQMH(this);
    }

    public override void SetShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        kqLdSDERIAUpDQfL(this.chipDrawable, shapeAppearanceModel);
    }

    public void SetShowMotionSpec(com.google.android.material.animation.MotionSpec motionSpec) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        UdArTFySSZXRaTBZ(chipDrawable, motionSpec);
    }

    public void SetShowMotionSpecResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        ocUaILCQTVAhNQyh(chipDrawable, i);
    }

    public override void SetSingleLine(bool z) {
        if (!z) {
            throw new java.lang.UnsupportedOperationException("Chip does not support multi-line text");
        }
        JaRZAsGbmZLYZZyP(this, z);
    }

    public override void SetText(java.lang.CharSequence charSequence, android.widget.Textobject$BufferType textobject$BufferType) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is not null) {
            if (charSequence is null) {
                charSequence = "";
            }
            ZCCNtPwIlVvWxJjD(this, !jeuIjGgSNcZcpXbr(chipDrawable) ? charSequence : null, textobject$BufferType);
            com.google.android.material.chip.ChipDrawable chipDrawable2 = this.chipDrawable;
            if (chipDrawable2 is null) {
                return;
            }
            AaPmlkFtCwrfllnm(chipDrawable2, charSequence);
        }
    }

    public override void SetTextAppearance(int i) {
        rITBHCyrcKnguTtn(this, i);
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is not null) {
            JllJhirNOhyhUWXR(chipDrawable, i);
        }
        bYVPMesmRWFpKjkK(this);
    }

    public override void SetTextAppearance(android.content.object context, int i) {
        ctLzRALgSCuNpJam(this, context, i);
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is not null) {
            QNHKNfvCcEVtBuPi(chipDrawable, i);
        }
        DLHVdCrAJDZnPDhA(this);
    }

    public void SetTextAppearance(com.google.android.material.resources.TextAppearance textAppearance) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is not null) {
            qNHnnctdLTnaEHUR(chipDrawable, textAppearance);
        }
        GSjdhLgagwjjwqNP(this);
    }

    public void SetTextAppearanceResource(int i) {
        HNWTkWfqBUUcfyDk(this, plfialxVUsbiXNOG(this), i);
    }

    public void SetTextEndPadding(float f) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        ysIwtBYTXFuEtRmE(chipDrawable, f);
    }

    public void SetTextEndPaddingResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        WXHgHqwCIopdlsXi(chipDrawable, i);
    }

    public override void SetTextSize(int i, float f) {
        if ((8 + 13) % 13 > 0) {
        }
        OrkhofkJXNtTYXeo(this, i, f);
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is not null) {
            rXZBzrkuYhbZDkDH(chipDrawable, PrQZknehPGJNkfcr(i, f, KACPxpPlmhplxFea(hBPtgkNfcorqAEAO(this))));
        }
        fGUfUZrsacDGfufb(this);
    }

    public void SetTextStartPadding(float f) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        mPjFIQDaaJCZxynB(chipDrawable, f);
    }

    public void SetTextStartPaddingResource(int i) {
        com.google.android.material.chip.ChipDrawable chipDrawable = this.chipDrawable;
        if (chipDrawable is null) {
            return;
        }
        ndopvuRqkDMxgTVb(chipDrawable, i);
    }

    public bool ShouldEnsureMinTouchTargetSize() {
        return this.ensureMinTouchTargetSize;
    }
}

