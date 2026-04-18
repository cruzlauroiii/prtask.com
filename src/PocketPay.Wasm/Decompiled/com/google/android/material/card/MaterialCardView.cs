namespace WillowMaze.Wasm.Decompiled;


public class MaterialCardobject : androidx.cardview.widget.Cardobject : android.widget.Checkable, com.google.android.material.shape.Shapeable {
    private static readonly java.lang.string ACCESSIBILITY_CLASS_NAME = "androidx.cardview.widget.Cardobject";
    public static readonly int CHECKED_ICON_GRAVITY_BOTTOM_END = 8388693;
    public static readonly int CHECKED_ICON_GRAVITY_BOTTOM_START = 8388691;
    public static readonly int CHECKED_ICON_GRAVITY_TOP_END = 8388661;
    public static readonly int CHECKED_ICON_GRAVITY_TOP_START = 8388659;
    private static readonly java.lang.string LOG_TAG = "MaterialCardobject";
    private readonly com.google.android.material.card.MaterialCardobjectHelper cardobjectHelper;
    private bool checked;
    private bool dragged;
    private bool isParentCardobjectDoneInitializing;
    private com.google.android.material.card.MaterialCardobject$OnCheckedChangeListener onCheckedChangeListener;
    private static readonly int[] CHECKABLE_STATE_SET = {16842911};
    private static readonly int[] CHECKED_STATE_SET = {16842912};
    private static readonly int[] DRAGGED_STATE_SET = {com.google.android.material.R$attr.state_dragged};
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_Cardobject;

    public MaterialCardobject(android.content.object context) {
        this(context, null);
    }

    public MaterialCardobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.materialCardobjectStyle);
    }

    public MaterialCardobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((24 + 26) % 26 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(GBHwVRKzywBtrqyk(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.checked = false;
        this.dragged = false;
        this.isParentCardobjectDoneInitializing = true;
        android.content.res.TypedArray typedArrayMuQgecLzROzCGqeB = MuQgecLzROzCGqeB(YSngPZkRMtNmLKWl(this), attributeHashSet, com.google.android.material.R$styleable.MaterialCardobject, i, i2, new int[0]);
        com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper = new com.google.android.material.card.MaterialCardobjectHelper(this, attributeHashSet, i, i2);
        this.cardobjectHelper = materialCardobjectHelper;
        yXbhaybQlVFZayce(materialCardobjectHelper, JPVzTTximSwvJWWA(this));
        CvDHQoIGYalknpHk(materialCardobjectHelper, ARsDjwLXaNKzawVF(this), fKrfFPUOCXxfpoWD(this), VQtaIEiYFXPBayXs(this), fHOdchKJdJTVtiaV(this));
        eKDgpwSLmAbMYcUr(materialCardobjectHelper, typedArrayMuQgecLzROzCGqeB);
        bRycnMmoSzDdQGOV(typedArrayMuQgecLzROzCGqeB);
    }

    public static int ARsDjwLXaNKzawVF(androidx.cardview.widget.Cardobject cardobject) {
        return super.getContentPaddingLeft();
    }

    public static void ARsDjwLXaNKzawVF(androidx.cardview.widget.Cardobject cardobject, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ARsDjwLXaNKzawVF(androidx.cardview.widget.Cardobject cardobject, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ARsDjwLXaNKzawVF(androidx.cardview.widget.Cardobject cardobject, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ASgWJHWhLbhNTtap(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ASgWJHWhLbhNTtap(com.google.android.material.card.MaterialCardobject materialCardobject, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ASgWJHWhLbhNTtap(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ASgWJHWhLbhNTtap(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.isClickable();
    }

    public static float AXKACNOAxMkdZuCJ(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return access$001(materialCardobject);
    }

    public static void AXKACNOAxMkdZuCJ(com.google.android.material.card.MaterialCardobject materialCardobject, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AXKACNOAxMkdZuCJ(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AXKACNOAxMkdZuCJ(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int AxjVmrMVXCTIevGo(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void AxjVmrMVXCTIevGo(android.content.res.Resources resources, int i, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AxjVmrMVXCTIevGo(android.content.res.Resources resources, int i, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AxjVmrMVXCTIevGo(android.content.res.Resources resources, int i, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BRrRsEIEVGrprPGQ(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z) {
        accessibilityNodeInfo.setCheckable(z);
    }

    public static void BRrRsEIEVGrprPGQ(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, char c, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void BRrRsEIEVGrprPGQ(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, short s, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BRrRsEIEVGrprPGQ(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, bool z2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BkAvsZuHHLVKHmDx(com.google.android.material.card.MaterialCardobject materialCardobject) {
        materialCardobject.invalidate();
    }

    public static void BkAvsZuHHLVKHmDx(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BkAvsZuHHLVKHmDx(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BkAvsZuHHLVKHmDx(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CqWdzkVgaMcmbUTR(androidx.cardview.widget.Cardobject cardobject, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static void CqWdzkVgaMcmbUTR(androidx.cardview.widget.Cardobject cardobject, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CqWdzkVgaMcmbUTR(androidx.cardview.widget.Cardobject cardobject, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CqWdzkVgaMcmbUTR(androidx.cardview.widget.Cardobject cardobject, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CvDHQoIGYalknpHk(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, int i3, int i4) {
        materialCardobjectHelper.setUserContentPadding(i, i2, i3, i4);
    }

    public static void CvDHQoIGYalknpHk(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, int i3, int i4, char c, java.lang.string str, short s, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void CvDHQoIGYalknpHk(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, int i3, int i4, char c, short s, java.lang.string str, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void CvDHQoIGYalknpHk(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, int i3, int i4, int i5, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DSvZvVoeBuYAGmZn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2) {
        materialCardobjectHelper.recalculateCheckedIconPosition(i, i2);
    }

    public static void DSvZvVoeBuYAGmZn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DSvZvVoeBuYAGmZn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DSvZvVoeBuYAGmZn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DhWhUJDaflDdHoTM(androidx.cardview.widget.Cardobject cardobject, bool z) {
        super.setClickable(z);
    }

    public static void DhWhUJDaflDdHoTM(androidx.cardview.widget.Cardobject cardobject, bool z, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DhWhUJDaflDdHoTM(androidx.cardview.widget.Cardobject cardobject, bool z, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DhWhUJDaflDdHoTM(androidx.cardview.widget.Cardobject cardobject, bool z, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList DiMOJEhpcWKTKQeb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getCardForegroundColor();
    }

    public static void DiMOJEhpcWKTKQeb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DiMOJEhpcWKTKQeb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DiMOJEhpcWKTKQeb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DuYXNKpoHuwfuCgQ(androidx.cardview.widget.Cardobject cardobject, int i, int i2, int i3, int i4) {
        super.setContentPadding(i, i2, i3, i4);
    }

    public static void DuYXNKpoHuwfuCgQ(androidx.cardview.widget.Cardobject cardobject, int i, int i2, int i3, int i4, int i5, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DuYXNKpoHuwfuCgQ(androidx.cardview.widget.Cardobject cardobject, int i, int i2, int i3, int i4, short s, int i5, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DuYXNKpoHuwfuCgQ(androidx.cardview.widget.Cardobject cardobject, int i, int i2, int i3, int i4, bool z, int i5, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList EePuxfHBawLDdfrb(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void EePuxfHBawLDdfrb(int i, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EePuxfHBawLDdfrb(int i, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EePuxfHBawLDdfrb(int i, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EmdaAOmIzYwqcLYb(android.graphics.RectF rectF, android.graphics.Rect rect) {
        rectF.set(rect);
    }

    public static void EmdaAOmIzYwqcLYb(android.graphics.RectF rectF, android.graphics.Rect rect, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EmdaAOmIzYwqcLYb(android.graphics.RectF rectF, android.graphics.Rect rect, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EmdaAOmIzYwqcLYb(android.graphics.RectF rectF, android.graphics.Rect rect, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList FESKZYIAGXyIhxIS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getRippleColor();
    }

    public static void FESKZYIAGXyIhxIS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FESKZYIAGXyIhxIS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FESKZYIAGXyIhxIS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object GBHwVRKzywBtrqyk(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void GBHwVRKzywBtrqyk(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GBHwVRKzywBtrqyk(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, int i3, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GBHwVRKzywBtrqyk(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, byte b, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void GGUzpobglAjGZKTN(com.google.android.material.card.MaterialCardobject materialCardobject, android.content.res.ColorStateList colorStateList) {
        materialCardobject.setStrokeColor(colorStateList);
    }

    public static void GGUzpobglAjGZKTN(com.google.android.material.card.MaterialCardobject materialCardobject, android.content.res.ColorStateList colorStateList, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GGUzpobglAjGZKTN(com.google.android.material.card.MaterialCardobject materialCardobject, android.content.res.ColorStateList colorStateList, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GGUzpobglAjGZKTN(com.google.android.material.card.MaterialCardobject materialCardobject, android.content.res.ColorStateList colorStateList, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GVirOkeTyfWzdkIS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, int i3, int i4) {
        materialCardobjectHelper.setUserContentPadding(i, i2, i3, i4);
    }

    public static void GVirOkeTyfWzdkIS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, int i3, int i4, java.lang.string str, byte b, short s, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void GVirOkeTyfWzdkIS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, int i3, int i4, java.lang.string str, int i5, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GVirOkeTyfWzdkIS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, int i3, int i4, short s, java.lang.string str, byte b, int i5) {
        double d = (42 * 210) + 210;
    }

    public static void GdFfXDaTdlCkwOzG(android.view.accessibility.AccessibilityEvent accessibilityEvent, java.lang.CharSequence charSequence) {
        accessibilityEvent.setClassName(charSequence);
    }

    public static void GdFfXDaTdlCkwOzG(android.view.accessibility.AccessibilityEvent accessibilityEvent, java.lang.CharSequence charSequence, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GdFfXDaTdlCkwOzG(android.view.accessibility.AccessibilityEvent accessibilityEvent, java.lang.CharSequence charSequence, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GdFfXDaTdlCkwOzG(android.view.accessibility.AccessibilityEvent accessibilityEvent, java.lang.CharSequence charSequence, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GtBYEmkICCJssBQQ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList) {
        materialCardobjectHelper.setStrokeColor(colorStateList);
    }

    public static void GtBYEmkICCJssBQQ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GtBYEmkICCJssBQQ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GtBYEmkICCJssBQQ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GwEBceLNjVjcCenx(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getCheckedIconGravity();
    }

    public static void GwEBceLNjVjcCenx(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GwEBceLNjVjcCenx(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GwEBceLNjVjcCenx(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect HpZOIliSmxYjbMvj(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getUserContentPadding();
    }

    public static void HpZOIliSmxYjbMvj(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HpZOIliSmxYjbMvj(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HpZOIliSmxYjbMvj(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HvKCFjEAqoAeQRcD(com.google.android.material.card.MaterialCardobject materialCardobject, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HvKCFjEAqoAeQRcD(com.google.android.material.card.MaterialCardobject materialCardobject, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HvKCFjEAqoAeQRcD(com.google.android.material.card.MaterialCardobject materialCardobject, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HvKCFjEAqoAeQRcD(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.isDragged();
    }

    public static void IBsMkNaOqVMHRdHQ(com.google.android.material.card.MaterialCardobject materialCardobject, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IBsMkNaOqVMHRdHQ(com.google.android.material.card.MaterialCardobject materialCardobject, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IBsMkNaOqVMHRdHQ(com.google.android.material.card.MaterialCardobject materialCardobject, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool IBsMkNaOqVMHRdHQ(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.isChecked();
    }

    public static void IZvCbOUAFaJnUGaC(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i) {
        materialCardobjectHelper.setCheckedIconMargin(i);
    }

    public static void IZvCbOUAFaJnUGaC(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, char c, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IZvCbOUAFaJnUGaC(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IZvCbOUAFaJnUGaC(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, bool z, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList JPVzTTximSwvJWWA(androidx.cardview.widget.Cardobject cardobject) {
        return super.getCardBackgroundColor();
    }

    public static void JPVzTTximSwvJWWA(androidx.cardview.widget.Cardobject cardobject, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JPVzTTximSwvJWWA(androidx.cardview.widget.Cardobject cardobject, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JPVzTTximSwvJWWA(androidx.cardview.widget.Cardobject cardobject, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KBZsFwUDKYcbEsxM(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateElevation();
    }

    public static void KBZsFwUDKYcbEsxM(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KBZsFwUDKYcbEsxM(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KBZsFwUDKYcbEsxM(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KIHBSzMTeHcMYmPE(com.google.android.material.card.MaterialCardobject materialCardobject) {
        materialCardobject.refreshDrawableState();
    }

    public static void KIHBSzMTeHcMYmPE(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KIHBSzMTeHcMYmPE(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KIHBSzMTeHcMYmPE(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KJzXwCDROIlIVuwk(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KJzXwCDROIlIVuwk(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KJzXwCDROIlIVuwk(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool KJzXwCDROIlIVuwk(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.isCheckable();
    }

    public static void KemlZUPtYRJwQnbv(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i) {
        materialCardobjectHelper.setCheckedIconSize(i);
    }

    public static void KemlZUPtYRJwQnbv(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KemlZUPtYRJwQnbv(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, float f, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void KemlZUPtYRJwQnbv(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable KxWpEVOKUUgfZXFh(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getBackground();
    }

    public static void KxWpEVOKUUgfZXFh(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KxWpEVOKUUgfZXFh(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KxWpEVOKUUgfZXFh(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LXUdEplIzLZTkgYi(com.google.android.material.card.MaterialCardobject$OnCheckedChangeListener materialCardobject$OnCheckedChangeListener, com.google.android.material.card.MaterialCardobject materialCardobject, bool z) {
        materialCardobject$OnCheckedChangeListener.onCheckedChanged(materialCardobject, z);
    }

    public static void LXUdEplIzLZTkgYi(com.google.android.material.card.MaterialCardobject$OnCheckedChangeListener materialCardobject$OnCheckedChangeListener, com.google.android.material.card.MaterialCardobject materialCardobject, bool z, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LXUdEplIzLZTkgYi(com.google.android.material.card.MaterialCardobject$OnCheckedChangeListener materialCardobject$OnCheckedChangeListener, com.google.android.material.card.MaterialCardobject materialCardobject, bool z, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LXUdEplIzLZTkgYi(com.google.android.material.card.MaterialCardobject$OnCheckedChangeListener materialCardobject$OnCheckedChangeListener, com.google.android.material.card.MaterialCardobject materialCardobject, bool z, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LxklwvdQcolggSQv(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, bool z2) {
        materialCardobjectHelper.setChecked(z, z2);
    }

    public static void LxklwvdQcolggSQv(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, bool z2, byte b, float f, short s, bool z3) {
        double d = (42 * 210) + 210;
    }

    public static void LxklwvdQcolggSQv(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, bool z2, short s, byte b, bool z3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LxklwvdQcolggSQv(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, bool z2, bool z3, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MtttnjjNucetwBcv(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MtttnjjNucetwBcv(com.google.android.material.card.MaterialCardobject materialCardobject, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MtttnjjNucetwBcv(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool MtttnjjNucetwBcv(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.isEnabled();
    }

    public static android.content.res.TypedArray MuQgecLzROzCGqeB(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void MuQgecLzROzCGqeB(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, int i3, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MuQgecLzROzCGqeB(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, float f, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void MuQgecLzROzCGqeB(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, bool z, short s, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel NHwShziKirnIUwGm(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getShapeAppearanceModel();
    }

    public static void NHwShziKirnIUwGm(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NHwShziKirnIUwGm(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NHwShziKirnIUwGm(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float NcUBUBZPLEepURcs(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getCornerRadius();
    }

    public static void NcUBUBZPLEepURcs(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NcUBUBZPLEepURcs(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NcUBUBZPLEepURcs(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NiYGPNUxlgpcOwrc(androidx.cardview.widget.Cardobject cardobject, bool z) {
        super.setUseCompatPadding(z);
    }

    public static void NiYGPNUxlgpcOwrc(androidx.cardview.widget.Cardobject cardobject, bool z, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NiYGPNUxlgpcOwrc(androidx.cardview.widget.Cardobject cardobject, bool z, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NiYGPNUxlgpcOwrc(androidx.cardview.widget.Cardobject cardobject, bool z, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NnrzEAesdwysgrFY(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getCheckedIconGravity();
    }

    public static void NnrzEAesdwysgrFY(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NnrzEAesdwysgrFY(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NnrzEAesdwysgrFY(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.MaterialShapeDrawable OPIfJRwYzHlxkiSt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getBackground();
    }

    public static void OPIfJRwYzHlxkiSt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OPIfJRwYzHlxkiSt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OPIfJRwYzHlxkiSt(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect OyrrbUatISGdhfuk(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getUserContentPadding();
    }

    public static void OyrrbUatISGdhfuk(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OyrrbUatISGdhfuk(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OyrrbUatISGdhfuk(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OzbRQqgSZwNEauIV(com.google.android.material.card.MaterialCardobject materialCardobject) {
        materialCardobject.invalidate();
    }

    public static void OzbRQqgSZwNEauIV(com.google.android.material.card.MaterialCardobject materialCardobject, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OzbRQqgSZwNEauIV(com.google.android.material.card.MaterialCardobject materialCardobject, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OzbRQqgSZwNEauIV(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int RKcbXXJyknwIazlk(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void RKcbXXJyknwIazlk(java.lang.string str, java.lang.string str2, int i, java.lang.string str3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RKcbXXJyknwIazlk(java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RKcbXXJyknwIazlk(java.lang.string str, java.lang.string str2, bool z, java.lang.string str3, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RRqFrdlTaNYStVWw(int[] iArr, int[] iArr2, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RRqFrdlTaNYStVWw(int[] iArr, int[] iArr2, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RRqFrdlTaNYStVWw(int[] iArr, int[] iArr2, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int[] RRqFrdlTaNYStVWw(int[] iArr, int[] iArr2) {
        return mergeDrawableStates(iArr, iArr2);
    }

    public static void RUNgsqoPfvsqqGdq(androidx.cardview.widget.Cardobject cardobject) {
        super.onAttachedToWindow();
    }

    public static void RUNgsqoPfvsqqGdq(androidx.cardview.widget.Cardobject cardobject, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RUNgsqoPfvsqqGdq(androidx.cardview.widget.Cardobject cardobject, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RUNgsqoPfvsqqGdq(androidx.cardview.widget.Cardobject cardobject, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int SSKOsksPzXDhKIvb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getCheckedIconSize();
    }

    public static void SSKOsksPzXDhKIvb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SSKOsksPzXDhKIvb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SSKOsksPzXDhKIvb(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SxKbkKWkgTXMtjwJ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList) {
        materialCardobjectHelper.setCardBackgroundColor(colorStateList);
    }

    public static void SxKbkKWkgTXMtjwJ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SxKbkKWkgTXMtjwJ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SxKbkKWkgTXMtjwJ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TDsXQrmuXwtGfgrw(androidx.cardview.widget.Cardobject cardobject, float f) {
        super.setRadius(f);
    }

    public static void TDsXQrmuXwtGfgrw(androidx.cardview.widget.Cardobject cardobject, float f, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TDsXQrmuXwtGfgrw(androidx.cardview.widget.Cardobject cardobject, float f, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TDsXQrmuXwtGfgrw(androidx.cardview.widget.Cardobject cardobject, float f, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ThNfoWjhRKueOrEr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable) {
        materialCardobjectHelper.setCheckedIcon(drawable);
    }

    public static void ThNfoWjhRKueOrEr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ThNfoWjhRKueOrEr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ThNfoWjhRKueOrEr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UGwdrhqbqdWyxebT(androidx.cardview.widget.Cardobject cardobject, bool z) {
        super.setPreventCornerOverlap(z);
    }

    public static void UGwdrhqbqdWyxebT(androidx.cardview.widget.Cardobject cardobject, bool z, int i, bool z2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UGwdrhqbqdWyxebT(androidx.cardview.widget.Cardobject cardobject, bool z, java.lang.string str, bool z2, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UGwdrhqbqdWyxebT(androidx.cardview.widget.Cardobject cardobject, bool z, bool z2, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect UTNWYIlVSoRCsIle(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        return materialShapeDrawable.getBounds();
    }

    public static void UTNWYIlVSoRCsIle(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UTNWYIlVSoRCsIle(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UTNWYIlVSoRCsIle(com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int UeMtfTdLPDZYIYqS(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getMeasuredWidth();
    }

    public static void UeMtfTdLPDZYIYqS(com.google.android.material.card.MaterialCardobject materialCardobject, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UeMtfTdLPDZYIYqS(com.google.android.material.card.MaterialCardobject materialCardobject, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UeMtfTdLPDZYIYqS(com.google.android.material.card.MaterialCardobject materialCardobject, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UxIhljkZeQQaxLsb(androidx.cardview.widget.Cardobject cardobject, float f) {
        super.setCardElevation(f);
    }

    public static void UxIhljkZeQQaxLsb(androidx.cardview.widget.Cardobject cardobject, float f, byte b, float f2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UxIhljkZeQQaxLsb(androidx.cardview.widget.Cardobject cardobject, float f, float f2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UxIhljkZeQQaxLsb(androidx.cardview.widget.Cardobject cardobject, float f, float f2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VQtaIEiYFXPBayXs(androidx.cardview.widget.Cardobject cardobject) {
        return super.getContentPaddingRight();
    }

    public static void VQtaIEiYFXPBayXs(androidx.cardview.widget.Cardobject cardobject, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VQtaIEiYFXPBayXs(androidx.cardview.widget.Cardobject cardobject, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VQtaIEiYFXPBayXs(androidx.cardview.widget.Cardobject cardobject, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object ViGtjTBdKKpBkdSb(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getobject();
    }

    public static void ViGtjTBdKKpBkdSb(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ViGtjTBdKKpBkdSb(com.google.android.material.card.MaterialCardobject materialCardobject, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ViGtjTBdKKpBkdSb(com.google.android.material.card.MaterialCardobject materialCardobject, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static float WKIGFlkzuTdWGpyn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getProgress();
    }

    public static void WKIGFlkzuTdWGpyn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WKIGFlkzuTdWGpyn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WKIGFlkzuTdWGpyn(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WLGiDBBbtuDQFqlG(com.google.android.material.card.MaterialCardobject materialCardobject) {
        materialCardobject.forceRippleRedrawIfNeeded();
    }

    public static void WLGiDBBbtuDQFqlG(com.google.android.material.card.MaterialCardobject materialCardobject, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WLGiDBBbtuDQFqlG(com.google.android.material.card.MaterialCardobject materialCardobject, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WLGiDBBbtuDQFqlG(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources WpyPFPmoshgMGWuj(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getResources();
    }

    public static void WpyPFPmoshgMGWuj(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WpyPFPmoshgMGWuj(com.google.android.material.card.MaterialCardobject materialCardobject, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WpyPFPmoshgMGWuj(com.google.android.material.card.MaterialCardobject materialCardobject, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int WzbZDVFCjzYlarII(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelSize(i);
    }

    public static void WzbZDVFCjzYlarII(android.content.res.Resources resources, int i, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WzbZDVFCjzYlarII(android.content.res.Resources resources, int i, java.lang.string str, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WzbZDVFCjzYlarII(android.content.res.Resources resources, int i, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XAlSYEaYTtLtywSK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z) {
        materialCardobjectHelper.setBackgroundOverwritten(z);
    }

    public static void XAlSYEaYTtLtywSK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XAlSYEaYTtLtywSK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XAlSYEaYTtLtywSK(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XjSeQltjoaDpMOQy(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i) {
        materialCardobjectHelper.setCheckedIconMargin(i);
    }

    public static void XjSeQltjoaDpMOQy(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, byte b, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XjSeQltjoaDpMOQy(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, float f, byte b, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XjSeQltjoaDpMOQy(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, java.lang.string str, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object YSngPZkRMtNmLKWl(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getobject();
    }

    public static void YSngPZkRMtNmLKWl(com.google.android.material.card.MaterialCardobject materialCardobject, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YSngPZkRMtNmLKWl(com.google.android.material.card.MaterialCardobject materialCardobject, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YSngPZkRMtNmLKWl(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YmSoQTnqQxlTJjqM(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i) {
        materialCardobjectHelper.setStrokeWidth(i);
    }

    public static void YmSoQTnqQxlTJjqM(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YmSoQTnqQxlTJjqM(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YmSoQTnqQxlTJjqM(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.RectF ZoxgRhNjdufFqAsw(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getBoundsAsRectF();
    }

    public static void ZoxgRhNjdufFqAsw(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZoxgRhNjdufFqAsw(com.google.android.material.card.MaterialCardobject materialCardobject, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZoxgRhNjdufFqAsw(com.google.android.material.card.MaterialCardobject materialCardobject, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static float access$001(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return diZgwYzIGPgUyuQi(materialCardobject);
    }

    static void access$001(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$001(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$001(com.google.android.material.card.MaterialCardobject materialCardobject, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BRrTkagzGpZAYchF(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BRrTkagzGpZAYchF(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BRrTkagzGpZAYchF(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool BRrTkagzGpZAYchF(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.isChecked();
    }

    public static void BRycnMmoSzDdQGOV(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void BRycnMmoSzDdQGOV(android.content.res.TypedArray typedArray, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BRycnMmoSzDdQGOV(android.content.res.TypedArray typedArray, char c, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BRycnMmoSzDdQGOV(android.content.res.TypedArray typedArray, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BZJEfXtaCDEwZGJo(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateContentPadding();
    }

    public static void BZJEfXtaCDEwZGJo(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BZJEfXtaCDEwZGJo(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BZJEfXtaCDEwZGJo(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources BaFsRHAUwwZOEZXz(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getResources();
    }

    public static void BaFsRHAUwwZOEZXz(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BaFsRHAUwwZOEZXz(com.google.android.material.card.MaterialCardobject materialCardobject, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BaFsRHAUwwZOEZXz(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BiKTgSCzFKgvQbmH(com.google.android.material.card.MaterialCardobject materialCardobject) {
        materialCardobject.invalidate();
    }

    public static void BiKTgSCzFKgvQbmH(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BiKTgSCzFKgvQbmH(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BiKTgSCzFKgvQbmH(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BzHGhmkJNFHwWHwz(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList) {
        materialCardobjectHelper.setCheckedIconTint(colorStateList);
    }

    public static void BzHGhmkJNFHwWHwz(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BzHGhmkJNFHwWHwz(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BzHGhmkJNFHwWHwz(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CnWilOlliZbPRLgq(int[] iArr, int[] iArr2, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CnWilOlliZbPRLgq(int[] iArr, int[] iArr2, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CnWilOlliZbPRLgq(int[] iArr, int[] iArr2, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int[] CnWilOlliZbPRLgq(int[] iArr, int[] iArr2) {
        return mergeDrawableStates(iArr, iArr2);
    }

    public static void DDbqKroGOoUeAhNV(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i) {
        materialCardobjectHelper.setCheckedIconGravity(i);
    }

    public static void DDbqKroGOoUeAhNV(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, byte b, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DDbqKroGOoUeAhNV(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, byte b, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DDbqKroGOoUeAhNV(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, bool z, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static float DiZgwYzIGPgUyuQi(androidx.cardview.widget.Cardobject cardobject) {
        return super.getRadius();
    }

    public static void DiZgwYzIGPgUyuQi(androidx.cardview.widget.Cardobject cardobject, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DiZgwYzIGPgUyuQi(androidx.cardview.widget.Cardobject cardobject, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DiZgwYzIGPgUyuQi(androidx.cardview.widget.Cardobject cardobject, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList EDihpawdIbtMcFXe(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getStrokeColorStateList();
    }

    public static void EDihpawdIbtMcFXe(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EDihpawdIbtMcFXe(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EDihpawdIbtMcFXe(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EKDgpwSLmAbMYcUr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.TypedArray typedArray) {
        materialCardobjectHelper.loadFromAttributes(typedArray);
    }

    public static void EKDgpwSLmAbMYcUr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.TypedArray typedArray, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EKDgpwSLmAbMYcUr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.TypedArray typedArray, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EKDgpwSLmAbMYcUr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.TypedArray typedArray, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int EbjhpXpQuDBWPCtf(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getStrokeColor();
    }

    public static void EbjhpXpQuDBWPCtf(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EbjhpXpQuDBWPCtf(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EbjhpXpQuDBWPCtf(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FHOdchKJdJTVtiaV(androidx.cardview.widget.Cardobject cardobject) {
        return super.getContentPaddingBottom();
    }

    public static void FHOdchKJdJTVtiaV(androidx.cardview.widget.Cardobject cardobject, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FHOdchKJdJTVtiaV(androidx.cardview.widget.Cardobject cardobject, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FHOdchKJdJTVtiaV(androidx.cardview.widget.Cardobject cardobject, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int FKrfFPUOCXxfpoWD(androidx.cardview.widget.Cardobject cardobject) {
        return super.getContentPaddingTop();
    }

    public static void FKrfFPUOCXxfpoWD(androidx.cardview.widget.Cardobject cardobject, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FKrfFPUOCXxfpoWD(androidx.cardview.widget.Cardobject cardobject, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FKrfFPUOCXxfpoWD(androidx.cardview.widget.Cardobject cardobject, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int FLoCGnBrchTDaTjk(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getMeasuredHeight();
    }

    public static void FLoCGnBrchTDaTjk(com.google.android.material.card.MaterialCardobject materialCardobject, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FLoCGnBrchTDaTjk(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FLoCGnBrchTDaTjk(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void ForceRippleRedrawIfNeeded() {
        inJhUImXSUxyYXpZ(this.cardobjectHelper);
    }

    private void ForceRippleRedrawIfNeeded(float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void ForceRippleRedrawIfNeeded(java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ForceRippleRedrawIfNeeded(java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList FpeVheXkjmxEmPbx(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getColorStateList(context, i);
    }

    public static void FpeVheXkjmxEmPbx(android.content.object context, int i, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FpeVheXkjmxEmPbx(android.content.object context, int i, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FpeVheXkjmxEmPbx(android.content.object context, int i, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GANyKwBXhzLGGxyd(com.google.android.material.card.MaterialCardobject materialCardobject) {
        materialCardobject.toggle();
    }

    public static void GANyKwBXhzLGGxyd(com.google.android.material.card.MaterialCardobject materialCardobject, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GANyKwBXhzLGGxyd(com.google.android.material.card.MaterialCardobject materialCardobject, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GANyKwBXhzLGGxyd(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GRwDrPYtStylSGAK(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GRwDrPYtStylSGAK(com.google.android.material.card.MaterialCardobject materialCardobject, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GRwDrPYtStylSGAK(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool GRwDrPYtStylSGAK(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.isChecked();
    }

    private android.graphics.RectF GetBoundsAsRectF() {
        android.graphics.RectF rectF = new android.graphics.RectF();
        EmdaAOmIzYwqcLYb(rectF, UTNWYIlVSoRCsIle(OPIfJRwYzHlxkiSt(this.cardobjectHelper)));
        return rectF;
    }

    private void GetBoundsAsRectF(byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetBoundsAsRectF(short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetBoundsAsRectF(short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable HEZVehRhgpMtMRvp(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getCheckedIcon();
    }

    public static void HEZVehRhgpMtMRvp(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HEZVehRhgpMtMRvp(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HEZVehRhgpMtMRvp(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HIdqVLghVbhXbRlv(int[] iArr, int[] iArr2, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HIdqVLghVbhXbRlv(int[] iArr, int[] iArr2, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HIdqVLghVbhXbRlv(int[] iArr, int[] iArr2, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int[] HIdqVLghVbhXbRlv(int[] iArr, int[] iArr2) {
        return mergeDrawableStates(iArr, iArr2);
    }

    public static void HomyQSBJREXxDvqX(com.google.android.material.card.MaterialCardobject materialCardobject, bool z) {
        materialCardobject.setClipToOutline(z);
    }

    public static void HomyQSBJREXxDvqX(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, char c, float f, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HomyQSBJREXxDvqX(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, char c, float f, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HomyQSBJREXxDvqX(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, char c, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void InJhUImXSUxyYXpZ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.forceRippleRedraw();
    }

    public static void InJhUImXSUxyYXpZ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void InJhUImXSUxyYXpZ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void InJhUImXSUxyYXpZ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JBABxKQLkoisdrhg(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z) {
        accessibilityNodeInfo.setClickable(z);
    }

    public static void JBABxKQLkoisdrhg(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, float f, short s, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JBABxKQLkoisdrhg(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, float f, bool z2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JBABxKQLkoisdrhg(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, short s, float f, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void JuuBTjLHzNDoIvFr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateInsets();
    }

    public static void JuuBTjLHzNDoIvFr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JuuBTjLHzNDoIvFr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JuuBTjLHzNDoIvFr(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect JxiyJcwZyXTMmWuc(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getUserContentPadding();
    }

    public static void JxiyJcwZyXTMmWuc(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JxiyJcwZyXTMmWuc(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JxiyJcwZyXTMmWuc(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KdqnYWGYViVkKRsg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList) {
        materialCardobjectHelper.setCardForegroundColor(colorStateList);
    }

    public static void KdqnYWGYViVkKRsg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KdqnYWGYViVkKRsg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KdqnYWGYViVkKRsg(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KnmfCGikQxUBNQdj(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable) {
        com.google.android.material.shape.MaterialShapeUtils.setParentAbsoluteElevation(view, materialShapeDrawable);
    }

    public static void KnmfCGikQxUBNQdj(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KnmfCGikQxUBNQdj(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KnmfCGikQxUBNQdj(android.view.object view, com.google.android.material.shape.MaterialShapeDrawable materialShapeDrawable, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KoLIabGfdJczKava(com.google.android.material.card.MaterialCardobject materialCardobject) {
        materialCardobject.forceRippleRedrawIfNeeded();
    }

    public static void KoLIabGfdJczKava(com.google.android.material.card.MaterialCardobject materialCardobject, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KoLIabGfdJczKava(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KoLIabGfdJczKava(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.Rect LJxyjCcUBfqjUmOH(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getUserContentPadding();
    }

    public static void LJxyjCcUBfqjUmOH(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LJxyjCcUBfqjUmOH(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LJxyjCcUBfqjUmOH(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LMkXyWyoPvzQpkrp(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i) {
        materialCardobjectHelper.setCheckedIconSize(i);
    }

    public static void LMkXyWyoPvzQpkrp(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LMkXyWyoPvzQpkrp(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LMkXyWyoPvzQpkrp(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.graphics.drawable.Drawable LNiANGKxgFhoYvTy(android.content.object context, int i) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(context, i);
    }

    public static void LNiANGKxgFhoYvTy(android.content.object context, int i, java.lang.string str, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LNiANGKxgFhoYvTy(android.content.object context, int i, short s, bool z, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LNiANGKxgFhoYvTy(android.content.object context, int i, bool z, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LeSGqSCXhDDtiJuH(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z) {
        materialCardobjectHelper.setCheckable(z);
    }

    public static void LeSGqSCXhDDtiJuH(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, byte b, bool z2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LeSGqSCXhDDtiJuH(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, float f, int i, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LeSGqSCXhDDtiJuH(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, int i, byte b, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList LjkxxEWYErPJjnKd(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getCheckedIconTint();
    }

    public static void LjkxxEWYErPJjnKd(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LjkxxEWYErPJjnKd(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LjkxxEWYErPJjnKd(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LmFeGCEjLlqkcnUr(androidx.cardview.widget.Cardobject cardobject, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void LmFeGCEjLlqkcnUr(androidx.cardview.widget.Cardobject cardobject, int i, int i2, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LmFeGCEjLlqkcnUr(androidx.cardview.widget.Cardobject cardobject, int i, int i2, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LmFeGCEjLlqkcnUr(androidx.cardview.widget.Cardobject cardobject, int i, int i2, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MAWKLzpGPrzWZbfV(androidx.cardview.widget.Cardobject cardobject, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(accessibilityEvent);
    }

    public static void MAWKLzpGPrzWZbfV(androidx.cardview.widget.Cardobject cardobject, android.view.accessibility.AccessibilityEvent accessibilityEvent, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MAWKLzpGPrzWZbfV(androidx.cardview.widget.Cardobject cardobject, android.view.accessibility.AccessibilityEvent accessibilityEvent, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MAWKLzpGPrzWZbfV(androidx.cardview.widget.Cardobject cardobject, android.view.accessibility.AccessibilityEvent accessibilityEvent, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MBaxFUWUXpROVxXl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MBaxFUWUXpROVxXl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MBaxFUWUXpROVxXl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool MBaxFUWUXpROVxXl(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.isCheckable();
    }

    public static android.content.object MZYHQbnKvrXauFfR(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.getobject();
    }

    public static void MZYHQbnKvrXauFfR(com.google.android.material.card.MaterialCardobject materialCardobject, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MZYHQbnKvrXauFfR(com.google.android.material.card.MaterialCardobject materialCardobject, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MZYHQbnKvrXauFfR(com.google.android.material.card.MaterialCardobject materialCardobject, int i, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NISrkmUykpUcbSnQ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateContentPadding();
    }

    public static void NISrkmUykpUcbSnQ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NISrkmUykpUcbSnQ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NISrkmUykpUcbSnQ(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NZnUsvgAxyJsWNjy(androidx.cardview.widget.Cardobject cardobject, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void NZnUsvgAxyJsWNjy(androidx.cardview.widget.Cardobject cardobject, android.graphics.drawable.Drawable drawable, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NZnUsvgAxyJsWNjy(androidx.cardview.widget.Cardobject cardobject, android.graphics.drawable.Drawable drawable, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NZnUsvgAxyJsWNjy(androidx.cardview.widget.Cardobject cardobject, android.graphics.drawable.Drawable drawable, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OQlZkOlhbYcaeJuc(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList) {
        materialCardobjectHelper.setCardBackgroundColor(colorStateList);
    }

    public static void OQlZkOlhbYcaeJuc(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OQlZkOlhbYcaeJuc(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OQlZkOlhbYcaeJuc(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int OScNldUTpvvxdcVG(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getCheckedIconMargin();
    }

    public static void OScNldUTpvvxdcVG(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OScNldUTpvvxdcVG(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OScNldUTpvvxdcVG(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PEleeiZkMiyamaso(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateInsets();
    }

    public static void PEleeiZkMiyamaso(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PEleeiZkMiyamaso(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PEleeiZkMiyamaso(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PKpogzfSmIhRMJDS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList) {
        materialCardobjectHelper.setRippleColor(colorStateList);
    }

    public static void PKpogzfSmIhRMJDS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PKpogzfSmIhRMJDS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PKpogzfSmIhRMJDS(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QNthyQjiVMYqspvF(com.google.android.material.card.MaterialCardobject materialCardobject) {
        materialCardobject.refreshDrawableState();
    }

    public static void QNthyQjiVMYqspvF(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QNthyQjiVMYqspvF(com.google.android.material.card.MaterialCardobject materialCardobject, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QNthyQjiVMYqspvF(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QQBJdfEQhMULkukz(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateClickable();
    }

    public static void QQBJdfEQhMULkukz(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QQBJdfEQhMULkukz(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QQBJdfEQhMULkukz(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int QXOhUxJztSNeDrdh(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getStrokeWidth();
    }

    public static void QXOhUxJztSNeDrdh(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QXOhUxJztSNeDrdh(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QXOhUxJztSNeDrdh(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RLPoXftHKrPJDBdO(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList) {
        materialCardobjectHelper.setRippleColor(colorStateList);
    }

    public static void RLPoXftHKrPJDBdO(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, char c, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RLPoXftHKrPJDBdO(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RLPoXftHKrPJDBdO(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RWRQaAnvHxVoHdvm(androidx.cardview.widget.Cardobject cardobject, android.graphics.drawable.Drawable drawable) {
        super.setBackgroundDrawable(drawable);
    }

    public static void RWRQaAnvHxVoHdvm(androidx.cardview.widget.Cardobject cardobject, android.graphics.drawable.Drawable drawable, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RWRQaAnvHxVoHdvm(androidx.cardview.widget.Cardobject cardobject, android.graphics.drawable.Drawable drawable, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RWRQaAnvHxVoHdvm(androidx.cardview.widget.Cardobject cardobject, android.graphics.drawable.Drawable drawable, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SNTfdNNOkkhJbKcB(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialCardobjectHelper.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void SNTfdNNOkkhJbKcB(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SNTfdNNOkkhJbKcB(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SNTfdNNOkkhJbKcB(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SYvKemqzskCtfWnX(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateInsets();
    }

    public static void SYvKemqzskCtfWnX(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SYvKemqzskCtfWnX(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SYvKemqzskCtfWnX(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TFPjmhmeqjSlLcys(androidx.cardview.widget.Cardobject cardobject, int i, char c, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TFPjmhmeqjSlLcys(androidx.cardview.widget.Cardobject cardobject, int i, char c, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TFPjmhmeqjSlLcys(androidx.cardview.widget.Cardobject cardobject, int i, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int[] TFPjmhmeqjSlLcys(androidx.cardview.widget.Cardobject cardobject, int i) {
        return super.onCreateDrawableState(i);
    }

    public static void UACvPsKeAjxWPaFd(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable) {
        materialCardobject.setBackgroundDrawable(drawable);
    }

    public static void UACvPsKeAjxWPaFd(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UACvPsKeAjxWPaFd(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UACvPsKeAjxWPaFd(com.google.android.material.card.MaterialCardobject materialCardobject, android.graphics.drawable.Drawable drawable, short s, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UMtzhufOVUPpaLUK(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence) {
        accessibilityNodeInfo.setClassName(charSequence);
    }

    public static void UMtzhufOVUPpaLUK(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UMtzhufOVUPpaLUK(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UMtzhufOVUPpaLUK(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.CharSequence charSequence, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UyZlhqUdnkfKQaxn(android.view.accessibility.AccessibilityEvent accessibilityEvent, bool z) {
        accessibilityEvent.setChecked(z);
    }

    public static void UyZlhqUdnkfKQaxn(android.view.accessibility.AccessibilityEvent accessibilityEvent, bool z, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UyZlhqUdnkfKQaxn(android.view.accessibility.AccessibilityEvent accessibilityEvent, bool z, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UyZlhqUdnkfKQaxn(android.view.accessibility.AccessibilityEvent accessibilityEvent, bool z, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList VVlUmhcPFmMLWlKO(int i) {
        return android.content.res.ColorStateList.valueOf(i);
    }

    public static void VVlUmhcPFmMLWlKO(int i, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VVlUmhcPFmMLWlKO(int i, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VVlUmhcPFmMLWlKO(int i, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VlyIJTscEvBqoBIw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        materialCardobjectHelper.updateClickable();
    }

    public static void VlyIJTscEvBqoBIw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VlyIJTscEvBqoBIw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VlyIJTscEvBqoBIw(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WEklvwiwQPJzcBbr(com.google.android.material.card.MaterialCardobject materialCardobject, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WEklvwiwQPJzcBbr(com.google.android.material.card.MaterialCardobject materialCardobject, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WEklvwiwQPJzcBbr(com.google.android.material.card.MaterialCardobject materialCardobject, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool WEklvwiwQPJzcBbr(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.isCheckable();
    }

    public static void WZApGGENFBMxLctD(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WZApGGENFBMxLctD(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WZApGGENFBMxLctD(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool WZApGGENFBMxLctD(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, android.graphics.RectF rectF) {
        return shapeAppearanceModel.isRoundRect(rectF);
    }

    public static void XXKeVSiEjMrSiITz(com.google.android.material.card.MaterialCardobject materialCardobject, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XXKeVSiEjMrSiITz(com.google.android.material.card.MaterialCardobject materialCardobject, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XXKeVSiEjMrSiITz(com.google.android.material.card.MaterialCardobject materialCardobject, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XXKeVSiEjMrSiITz(com.google.android.material.card.MaterialCardobject materialCardobject) {
        return materialCardobject.isCheckable();
    }

    public static void YURqzXRhBDatBnqi(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YURqzXRhBDatBnqi(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YURqzXRhBDatBnqi(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool YURqzXRhBDatBnqi(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.isBackgroundOverwritten();
    }

    public static void YXbhaybQlVFZayce(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList) {
        materialCardobjectHelper.setCardBackgroundColor(colorStateList);
    }

    public static void YXbhaybQlVFZayce(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YXbhaybQlVFZayce(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YXbhaybQlVFZayce(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.content.res.ColorStateList colorStateList, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YksyzldwcEOtTYBS(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z) {
        accessibilityNodeInfo.setChecked(z);
    }

    public static void YksyzldwcEOtTYBS(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, float f, java.lang.string str, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YksyzldwcEOtTYBS(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, float f, bool z2, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YksyzldwcEOtTYBS(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, bool z, java.lang.string str, int i, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.ColorStateList YsbMuJFxLhliGqnV(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper) {
        return materialCardobjectHelper.getCardBackgroundColor();
    }

    public static void YsbMuJFxLhliGqnV(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YsbMuJFxLhliGqnV(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YsbMuJFxLhliGqnV(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZVPCWJNDdwXSPByR(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f) {
        materialCardobjectHelper.setCornerRadius(f);
    }

    public static void ZVPCWJNDdwXSPByR(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZVPCWJNDdwXSPByR(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZVPCWJNDdwXSPByR(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZsNkcXoYldojrrrA(androidx.cardview.widget.Cardobject cardobject, float f) {
        super.setMaxCardElevation(f);
    }

    public static void ZsNkcXoYldojrrrA(androidx.cardview.widget.Cardobject cardobject, float f, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZsNkcXoYldojrrrA(androidx.cardview.widget.Cardobject cardobject, float f, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZsNkcXoYldojrrrA(androidx.cardview.widget.Cardobject cardobject, float f, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZvJZGloYiAqXzwJW(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable) {
        materialCardobjectHelper.setCheckedIcon(drawable);
    }

    public static void ZvJZGloYiAqXzwJW(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZvJZGloYiAqXzwJW(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZvJZGloYiAqXzwJW(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, android.graphics.drawable.Drawable drawable, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZzKrAFEQYFNwwJmu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f) {
        materialCardobjectHelper.setProgress(f);
    }

    public static void ZzKrAFEQYFNwwJmu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, float f2, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZzKrAFEQYFNwwJmu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, short s, bool z, char c, float f2) {
        double d = (42 * 210) + 210;
    }

    public static void ZzKrAFEQYFNwwJmu(com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper, float f, short s, bool z, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public override android.content.res.ColorStateList GetCardBackgroundColor() {
        return ysbMuJFxLhliGqnV(this.cardobjectHelper);
    }

    public android.content.res.ColorStateList GetCardForegroundColor() {
        return DiMOJEhpcWKTKQeb(this.cardobjectHelper);
    }

    float getCardobjectRadius() {
        return AXKACNOAxMkdZuCJ(this);
    }

    public android.graphics.drawable.Drawable GetCheckedIcon() {
        return hEZVehRhgpMtMRvp(this.cardobjectHelper);
    }

    public int GetCheckedIconGravity() {
        return GwEBceLNjVjcCenx(this.cardobjectHelper);
    }

    public int GetCheckedIconMargin() {
        return oScNldUTpvvxdcVG(this.cardobjectHelper);
    }

    public int GetCheckedIconSize() {
        return SSKOsksPzXDhKIvb(this.cardobjectHelper);
    }

    public android.content.res.ColorStateList GetCheckedIconTint() {
        return ljkxxEWYErPJjnKd(this.cardobjectHelper);
    }

    public override int GetContentPaddingBottom() {
        return OyrrbUatISGdhfuk(this.cardobjectHelper).bottom;
    }

    public override int GetContentPaddingLeft() {
        return HpZOIliSmxYjbMvj(this.cardobjectHelper).left;
    }

    public override int GetContentPaddingRight() {
        return jxiyJcwZyXTMmWuc(this.cardobjectHelper).right;
    }

    public override int GetContentPaddingTop() {
        return lJxyjCcUBfqjUmOH(this.cardobjectHelper).top;
    }

    public float GetProgress() {
        return WKIGFlkzuTdWGpyn(this.cardobjectHelper);
    }

    public override float GetRadius() {
        return NcUBUBZPLEepURcs(this.cardobjectHelper);
    }

    public android.content.res.ColorStateList GetRippleColor() {
        return FESKZYIAGXyIhxIS(this.cardobjectHelper);
    }

    public override com.google.android.material.shape.ShapeAppearanceModel GetShapeAppearanceModel() {
        return NHwShziKirnIUwGm(this.cardobjectHelper);
    }

    @java.lang.Deprecated
    public int GetStrokeColor() {
        return ebjhpXpQuDBWPCtf(this.cardobjectHelper);
    }

    public android.content.res.ColorStateList GetStrokeColorStateList() {
        return eDihpawdIbtMcFXe(this.cardobjectHelper);
    }

    public int GetStrokeWidth() {
        return qXOhUxJztSNeDrdh(this.cardobjectHelper);
    }

    public bool IsCheckable() {
        com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper = this.cardobjectHelper;
        return materialCardobjectHelper is not null && mBaxFUWUXpROVxXl(materialCardobjectHelper);
    }

    public override bool IsChecked() {
        return this.checked;
    }

    public bool IsDragged() {
        return this.dragged;
    }

    protected override void OnAttachedToWindow() {
        RUNgsqoPfvsqqGdq(this);
        qQBJdfEQhMULkukz(this.cardobjectHelper);
        knmfCGikQxUBNQdj(this, KxWpEVOKUUgfZXFh(this.cardobjectHelper));
    }

    protected override int[] OnCreateDrawableState(int i) {
        int[] iArrTFPjmhmeqjSlLcys = tFPjmhmeqjSlLcys(this, i + 3);
        if (xXKeVSiEjMrSiITz(this)) {
            cnWilOlliZbPRLgq(iArrTFPjmhmeqjSlLcys, CHECKABLE_STATE_SET);
        }
        if (gRwDrPYtStylSGAK(this)) {
            hIdqVLghVbhXbRlv(iArrTFPjmhmeqjSlLcys, CHECKED_STATE_SET);
        }
        if (HvKCFjEAqoAeQRcD(this)) {
            RRqFrdlTaNYStVWw(iArrTFPjmhmeqjSlLcys, DRAGGED_STATE_SET);
        }
        return iArrTFPjmhmeqjSlLcys;
    }

    public override void OnInitializeAccessibilityEvent(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        mAWKLzpGPrzWZbfV(this, accessibilityEvent);
        GdFfXDaTdlCkwOzG(accessibilityEvent, "androidx.cardview.widget.Cardobject");
        uyZlhqUdnkfKQaxn(accessibilityEvent, bRrTkagzGpZAYchF(this));
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        CqWdzkVgaMcmbUTR(this, accessibilityNodeInfo);
        uMtzhufOVUPpaLUK(accessibilityNodeInfo, "androidx.cardview.widget.Cardobject");
        BRrRsEIEVGrprPGQ(accessibilityNodeInfo, wEklvwiwQPJzcBbr(this));
        jBABxKQLkoisdrhg(accessibilityNodeInfo, ASgWJHWhLbhNTtap(this));
        yksyzldwcEOtTYBS(accessibilityNodeInfo, IBsMkNaOqVMHRdHQ(this));
    }

    protected override void OnMeasure(int i, int i2) {
        lmFeGCEjLlqkcnUr(this, i, i2);
        DSvZvVoeBuYAGmZn(this.cardobjectHelper, UeMtfTdLPDZYIYqS(this), fLoCGnBrchTDaTjk(this));
    }

    void setAncestorContentPadding(int i, int i2, int i3, int i4) {
        DuYXNKpoHuwfuCgQ(this, i, i2, i3, i4);
    }

    public override void SetBackground(android.graphics.drawable.Drawable drawable) {
        uACvPsKeAjxWPaFd(this, drawable);
    }

    public override void SetBackgroundDrawable(android.graphics.drawable.Drawable drawable) {
        if ((20 + 8) % 8 > 0) {
        }
        if (this.isParentCardobjectDoneInitializing) {
            if (!yURqzXRhBDatBnqi(this.cardobjectHelper)) {
                RKcbXXJyknwIazlk("MaterialCardobject", "HashSetting a custom background is not supported.");
                XAlSYEaYTtLtywSK(this.cardobjectHelper, true);
            }
            rWRQaAnvHxVoHdvm(this, drawable);
        }
    }

    void setBackgroundInternal(android.graphics.drawable.Drawable drawable) {
        nZnUsvgAxyJsWNjy(this, drawable);
    }

    public override void SetCardBackgroundColor(int i) {
        SxKbkKWkgTXMtjwJ(this.cardobjectHelper, vVlUmhcPFmMLWlKO(i));
    }

    public override void SetCardBackgroundColor(android.content.res.ColorStateList colorStateList) {
        oQlZkOlhbYcaeJuc(this.cardobjectHelper, colorStateList);
    }

    public override void SetCardElevation(float f) {
        UxIhljkZeQQaxLsb(this, f);
        KBZsFwUDKYcbEsxM(this.cardobjectHelper);
    }

    public void SetCardForegroundColor(android.content.res.ColorStateList colorStateList) {
        kdqnYWGYViVkKRsg(this.cardobjectHelper, colorStateList);
    }

    public void SetCheckable(bool z) {
        leSGqSCXhDDtiJuH(this.cardobjectHelper, z);
    }

    public override void SetChecked(bool z) {
        if (this.checked == z) {
            return;
        }
        gANyKwBXhzLGGxyd(this);
    }

    public void SetCheckedIcon(android.graphics.drawable.Drawable drawable) {
        ThNfoWjhRKueOrEr(this.cardobjectHelper, drawable);
    }

    public void SetCheckedIconGravity(int i) {
        if (NnrzEAesdwysgrFY(this.cardobjectHelper) == i) {
            return;
        }
        dDbqKroGOoUeAhNV(this.cardobjectHelper, i);
    }

    public void SetCheckedIconMargin(int i) {
        XjSeQltjoaDpMOQy(this.cardobjectHelper, i);
    }

    public void SetCheckedIconMarginResource(int i) {
        if (i == -1) {
            return;
        }
        IZvCbOUAFaJnUGaC(this.cardobjectHelper, AxjVmrMVXCTIevGo(baFsRHAUwwZOEZXz(this), i));
    }

    public void SetCheckedIconResource(int i) {
        zvJZGloYiAqXzwJW(this.cardobjectHelper, lNiANGKxgFhoYvTy(mZYHQbnKvrXauFfR(this), i));
    }

    public void SetCheckedIconSize(int i) {
        KemlZUPtYRJwQnbv(this.cardobjectHelper, i);
    }

    public void SetCheckedIconSizeResource(int i) {
        if (i == 0) {
            return;
        }
        lMkXyWyoPvzQpkrp(this.cardobjectHelper, WzbZDVFCjzYlarII(WpyPFPmoshgMGWuj(this), i));
    }

    public void SetCheckedIconTint(android.content.res.ColorStateList colorStateList) {
        bzHGhmkJNFHwWHwz(this.cardobjectHelper, colorStateList);
    }

    public override void SetClickable(bool z) {
        DhWhUJDaflDdHoTM(this, z);
        com.google.android.material.card.MaterialCardobjectHelper materialCardobjectHelper = this.cardobjectHelper;
        if (materialCardobjectHelper is null) {
            return;
        }
        vlyIJTscEvBqoBIw(materialCardobjectHelper);
    }

    public override void SetContentPadding(int i, int i2, int i3, int i4) {
        GVirOkeTyfWzdkIS(this.cardobjectHelper, i, i2, i3, i4);
    }

    public void SetDragged(bool z) {
        if (this.dragged == z) {
            return;
        }
        this.dragged = z;
        qNthyQjiVMYqspvF(this);
        WLGiDBBbtuDQFqlG(this);
        OzbRQqgSZwNEauIV(this);
    }

    public override void SetMaxCardElevation(float f) {
        zsNkcXoYldojrrrA(this, f);
        juuBTjLHzNDoIvFr(this.cardobjectHelper);
    }

    public void SetOnCheckedChangeListener(com.google.android.material.card.MaterialCardobject$OnCheckedChangeListener materialCardobject$OnCheckedChangeListener) {
        this.onCheckedChangeListener = materialCardobject$OnCheckedChangeListener;
    }

    public override void SetPreventCornerOverlap(bool z) {
        UGwdrhqbqdWyxebT(this, z);
        sYvKemqzskCtfWnX(this.cardobjectHelper);
        bZJEfXtaCDEwZGJo(this.cardobjectHelper);
    }

    public void SetProgress(float f) {
        zzKrAFEQYFNwwJmu(this.cardobjectHelper, f);
    }

    public override void SetRadius(float f) {
        TDsXQrmuXwtGfgrw(this, f);
        zVPCWJNDdwXSPByR(this.cardobjectHelper, f);
    }

    public void SetRippleColor(android.content.res.ColorStateList colorStateList) {
        rLPoXftHKrPJDBdO(this.cardobjectHelper, colorStateList);
    }

    public void SetRippleColorResource(int i) {
        pKpogzfSmIhRMJDS(this.cardobjectHelper, fpeVheXkjmxEmPbx(ViGtjTBdKKpBkdSb(this), i));
    }

    public override void SetShapeAppearanceModel(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        homyQSBJREXxDvqX(this, wZApGGENFBMxLctD(shapeAppearanceModel, ZoxgRhNjdufFqAsw(this)));
        sNTfdNNOkkhJbKcB(this.cardobjectHelper, shapeAppearanceModel);
    }

    public void SetStrokeColor(int i) {
        GGUzpobglAjGZKTN(this, EePuxfHBawLDdfrb(i));
    }

    public void SetStrokeColor(android.content.res.ColorStateList colorStateList) {
        GtBYEmkICCJssBQQ(this.cardobjectHelper, colorStateList);
        BkAvsZuHHLVKHmDx(this);
    }

    public void SetStrokeWidth(int i) {
        YmSoQTnqQxlTJjqM(this.cardobjectHelper, i);
        biKTgSCzFKgvQbmH(this);
    }

    public override void SetUseCompatPadding(bool z) {
        NiYGPNUxlgpcOwrc(this, z);
        pEleeiZkMiyamaso(this.cardobjectHelper);
        nISrkmUykpUcbSnQ(this.cardobjectHelper);
    }

    public override void Toggle() {
        if ((6 + 16) % 16 > 0) {
        }
        if (KJzXwCDROIlIVuwk(this) && MtttnjjNucetwBcv(this)) {
            this.checked = !this.checked;
            KIHBSzMTeHcMYmPE(this);
            koLIabGfdJczKava(this);
            LxklwvdQcolggSQv(this.cardobjectHelper, this.checked, true);
            com.google.android.material.card.MaterialCardobject$OnCheckedChangeListener materialCardobject$OnCheckedChangeListener = this.onCheckedChangeListener;
            if (materialCardobject$OnCheckedChangeListener is null) {
                return;
            }
            LXUdEplIzLZTkgYi(materialCardobject$OnCheckedChangeListener, this, this.checked);
        }
    }
}

