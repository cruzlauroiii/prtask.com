namespace WillowMaze.Wasm.Decompiled;


public class MaterialButtonToggleGroup : android.widget.LinearLayout {
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_MaterialButtonToggleGroup;
    private static readonly java.lang.string LOG_TAG = "MButtonToggleGroup";
    private java.util.HashSet<java.lang.int> checkedIds;
    private java.lang.int[] childOrder;
    private readonly java.util.Comparator<com.google.android.material.button.MaterialButton> childOrderComparator;
    private readonly int defaultCheckId;
    private readonly java.util.LinkedHashHashSet<com.google.android.material.button.MaterialButtonToggleGroup$OnButtonCheckedListener> onButtonCheckedListeners;
    private readonly java.util.List<com.google.android.material.button.MaterialButtonToggleGroup$CornerData> originalCornerData;
    private readonly com.google.android.material.button.MaterialButtonToggleGroup$PressedStateTracker pressedStateTracker;
    private bool selectionRequired;
    private bool singleSelection;
    private bool skipCheckedStateTracker;

    public MaterialButtonToggleGroup(android.content.object context) {
        this(context, null);
    }

    public MaterialButtonToggleGroup(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.materialButtonToggleGroupStyle);
    }

    public MaterialButtonToggleGroup(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((24 + 24) % 24 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(PPYzPqNaqaqFCRmo(context, attributeHashSet, i, i2), attributeHashSet, i);
        this.originalCornerData = new java.util.List();
        this.pressedStateTracker = new com.google.android.material.button.MaterialButtonToggleGroup$PressedStateTracker(this, null);
        this.onButtonCheckedListeners = new java.util.LinkedHashHashSet<>();
        this.childOrderComparator = new com.google.android.material.button.MaterialButtonToggleGroup$1(this);
        this.skipCheckedStateTracker = false;
        this.checkedIds = new java.util.HashHashSet();
        android.content.res.TypedArray typedArrayAFHFZFsHyfHIynFA = AFHFZFsHyfHIynFA(KzrbXwosmnIwQmwc(this), attributeHashSet, com.google.android.material.R$styleable.MaterialButtonToggleGroup, i, i2, new int[0]);
        aGeAZBrZTbtSedsf(this, ZIimrdXHVhrsHSTy(typedArrayAFHFZFsHyfHIynFA, com.google.android.material.R$styleable.MaterialButtonToggleGroup_singleSelection, false));
        this.defaultCheckId = ZXUlHLraSVVzihRo(typedArrayAFHFZFsHyfHIynFA, com.google.android.material.R$styleable.MaterialButtonToggleGroup_checkedButton, -1);
        this.selectionRequired = BPaDdweYfjcCtaeW(typedArrayAFHFZFsHyfHIynFA, com.google.android.material.R$styleable.MaterialButtonToggleGroup_selectionRequired, false);
        QCiFjoNAaFtPqepw(this, true);
        NtaIRKasWqZKWPsN(this, wXbWzTgdSHccCvJM(typedArrayAFHFZFsHyfHIynFA, com.google.android.material.R$styleable.MaterialButtonToggleGroup_android_enabled, true));
        zubRUPvysbMqGexc(typedArrayAFHFZFsHyfHIynFA);
        pZPEaOUfolvzbYtr(this, 1);
    }

    public static android.content.res.TypedArray AFHFZFsHyfHIynFA(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void AFHFZFsHyfHIynFA(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, char c, java.lang.string str, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AFHFZFsHyfHIynFA(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, char c, java.lang.string str, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void AFHFZFsHyfHIynFA(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, int i3, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int AHMNxpcECqvaUmSf(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getId();
    }

    public static void AHMNxpcECqvaUmSf(com.google.android.material.button.MaterialButton materialButton, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AHMNxpcECqvaUmSf(com.google.android.material.button.MaterialButton materialButton, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AHMNxpcECqvaUmSf(com.google.android.material.button.MaterialButton materialButton, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.button.MaterialButton ANymDXmemIVebVDH(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.getChildButton(i);
    }

    public static void ANymDXmemIVebVDH(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, float f, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ANymDXmemIVebVDH(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, float f, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ANymDXmemIVebVDH(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, short s, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BDWhqfIwxcYMTgxI(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj) {
        accessibilityNodeInfoCompat.setICollectionInfo(obj);
    }

    public static void BDWhqfIwxcYMTgxI(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BDWhqfIwxcYMTgxI(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BDWhqfIwxcYMTgxI(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BPaDdweYfjcCtaeW(android.content.res.TypedArray typedArray, int i, bool z, byte b, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BPaDdweYfjcCtaeW(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BPaDdweYfjcCtaeW(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BPaDdweYfjcCtaeW(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void BVgJFfEXZqIUzUsb(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BVgJFfEXZqIUzUsb(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BVgJFfEXZqIUzUsb(com.google.android.material.button.MaterialButton materialButton, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BVgJFfEXZqIUzUsb(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.isChecked();
    }

    public static void BhYfuaSSOraEuPpT(android.widget.LinearLayout linearLayout, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        super.addobject(view, i, viewGroup$LayoutParams);
    }

    public static void BhYfuaSSOraEuPpT(android.widget.LinearLayout linearLayout, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BhYfuaSSOraEuPpT(android.widget.LinearLayout linearLayout, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BhYfuaSSOraEuPpT(android.widget.LinearLayout linearLayout, android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.CornerSize CJYvtctwFwXCpPXh(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopLeftCornerSize();
    }

    public static void CJYvtctwFwXCpPXh(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CJYvtctwFwXCpPXh(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CJYvtctwFwXCpPXh(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int CKLmamqtCYBCeoiI(android.view.object view) {
        return view.getVisibility();
    }

    public static void CKLmamqtCYBCeoiI(android.view.object view, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CKLmamqtCYBCeoiI(android.view.object view, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CKLmamqtCYBCeoiI(android.view.object view, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CLUdgSGwzWcSryyQ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z) {
        materialButtonToggleGroup.setCheckedStateForobject(i, z);
    }

    public static void CLUdgSGwzWcSryyQ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, java.lang.string str, byte b, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CLUdgSGwzWcSryyQ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, java.lang.string str, float f, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void CLUdgSGwzWcSryyQ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, bool z2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.button.MaterialButton CTkbBLleHxuLpqFQ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.getChildButton(i);
    }

    public static void CTkbBLleHxuLpqFQ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CTkbBLleHxuLpqFQ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CTkbBLleHxuLpqFQ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CYkEMERcWfrmAbDh(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        materialButtonToggleGroup.adjustChildMarginsAndUpdateLayout();
    }

    public static void CYkEMERcWfrmAbDh(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CYkEMERcWfrmAbDh(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CYkEMERcWfrmAbDh(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CbqrHirdOokIIxBX(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        androidx.core.view.MarginLayoutParamsCompat.setMarginEnd(viewGroup$MarginLayoutParams, i);
    }

    public static void CbqrHirdOokIIxBX(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, byte b, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CbqrHirdOokIIxBX(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CbqrHirdOokIIxBX(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, bool z, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static int CmwPHflXEdYVHvRx(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view) {
        return materialButtonToggleGroup.indexOfChild(view);
    }

    public static void CmwPHflXEdYVHvRx(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CmwPHflXEdYVHvRx(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CmwPHflXEdYVHvRx(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CuJXSOfAZXpAtlya(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CuJXSOfAZXpAtlya(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CuJXSOfAZXpAtlya(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CuJXSOfAZXpAtlya(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.isEnabled();
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat CxDTbAQPdYhfiPaC(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrap(accessibilityNodeInfo);
    }

    public static void CxDTbAQPdYhfiPaC(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CxDTbAQPdYhfiPaC(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CxDTbAQPdYhfiPaC(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DVRuwjrzsfEmcWaX(com.google.android.material.button.MaterialButton materialButton, int i) {
        materialButton.setMaxLines(i);
    }

    public static void DVRuwjrzsfEmcWaX(com.google.android.material.button.MaterialButton materialButton, int i, byte b, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DVRuwjrzsfEmcWaX(com.google.android.material.button.MaterialButton materialButton, int i, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DVRuwjrzsfEmcWaX(com.google.android.material.button.MaterialButton materialButton, int i, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DYjxGlUDeepnNvNA(java.util.HashSet set, java.lang.object obj, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DYjxGlUDeepnNvNA(java.util.HashSet set, java.lang.object obj, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DYjxGlUDeepnNvNA(java.util.HashSet set, java.lang.object obj, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool DYjxGlUDeepnNvNA(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static int DZWCygPgcAdjoXtT(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getVisibility();
    }

    public static void DZWCygPgcAdjoXtT(com.google.android.material.button.MaterialButton materialButton, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DZWCygPgcAdjoXtT(com.google.android.material.button.MaterialButton materialButton, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DZWCygPgcAdjoXtT(com.google.android.material.button.MaterialButton materialButton, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel EPgJFsipSXoDntCw(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getShapeAppearanceModel();
    }

    public static void EPgJFsipSXoDntCw(com.google.android.material.button.MaterialButton materialButton, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EPgJFsipSXoDntCw(com.google.android.material.button.MaterialButton materialButton, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EPgJFsipSXoDntCw(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object EhCsOOuEJLoyGIPC(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.getChildAt(i);
    }

    public static void EhCsOOuEJLoyGIPC(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, byte b, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EhCsOOuEJLoyGIPC(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, float f, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EhCsOOuEJLoyGIPC(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, short s, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet FCXafjjJtPFCFIpX(java.lang.object obj) {
        return java.util.ICollections.singleton(obj);
    }

    public static void FCXafjjJtPFCFIpX(java.lang.object obj, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FCXafjjJtPFCFIpX(java.lang.object obj, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FCXafjjJtPFCFIpX(java.lang.object obj, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int FpotUQcljSdHvwby(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getOrientation();
    }

    public static void FpotUQcljSdHvwby(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FpotUQcljSdHvwby(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FpotUQcljSdHvwby(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GbNbUnQfeVHWImdD(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void GbNbUnQfeVHWImdD(java.lang.string str, java.lang.string str2, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GbNbUnQfeVHWImdD(java.lang.string str, java.lang.string str2, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GbNbUnQfeVHWImdD(java.lang.string str, java.lang.string str2, int i, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int GjbKTPsDQyusspwz(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getChildCount();
    }

    public static void GjbKTPsDQyusspwz(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GjbKTPsDQyusspwz(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GjbKTPsDQyusspwz(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.button.MaterialButtonToggleGroup$CornerData GoBsGpaPWpKysFQh(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData) {
        return com.google.android.material.button.MaterialButtonToggleGroup$CornerData.top(materialButtonToggleGroup$CornerData);
    }

    public static void GoBsGpaPWpKysFQh(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GoBsGpaPWpKysFQh(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GoBsGpaPWpKysFQh(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.button.MaterialButtonToggleGroup$CornerData GzPMrbosoQRAWCUf(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, android.view.object view) {
        return com.google.android.material.button.MaterialButtonToggleGroup$CornerData.start(materialButtonToggleGroup$CornerData, view);
    }

    public static void GzPMrbosoQRAWCUf(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, android.view.object view, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GzPMrbosoQRAWCUf(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, android.view.object view, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GzPMrbosoQRAWCUf(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, android.view.object view, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int HBkiMxDkwlzTtadH(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void HBkiMxDkwlzTtadH(int i, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HBkiMxDkwlzTtadH(int i, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HBkiMxDkwlzTtadH(int i, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder HTwYqAcosMzQvNPn(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomRightCornerSize(cornerSize);
    }

    public static void HTwYqAcosMzQvNPn(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HTwYqAcosMzQvNPn(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HTwYqAcosMzQvNPn(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IMGSvIpjTuzuKcDe(java.util.List list, java.lang.object obj, java.lang.string str, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IMGSvIpjTuzuKcDe(java.util.List list, java.lang.object obj, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IMGSvIpjTuzuKcDe(java.util.List list, java.lang.object obj, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool IMGSvIpjTuzuKcDe(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static int IfwWvAfgFEjxkjyK(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getStrokeWidth();
    }

    public static void IfwWvAfgFEjxkjyK(com.google.android.material.button.MaterialButton materialButton, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IfwWvAfgFEjxkjyK(com.google.android.material.button.MaterialButton materialButton, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IfwWvAfgFEjxkjyK(com.google.android.material.button.MaterialButton materialButton, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ImbSxcMuffKnItsV(android.widget.LinearLayout linearLayout, android.graphics.Canvas canvas) {
        super.dispatchDraw(canvas);
    }

    public static void ImbSxcMuffKnItsV(android.widget.LinearLayout linearLayout, android.graphics.Canvas canvas, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ImbSxcMuffKnItsV(android.widget.LinearLayout linearLayout, android.graphics.Canvas canvas, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ImbSxcMuffKnItsV(android.widget.LinearLayout linearLayout, android.graphics.Canvas canvas, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JGRHDQYfrHtFkPTB(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.util.HashSet set) {
        materialButtonToggleGroup.updateCheckedIds(set);
    }

    public static void JGRHDQYfrHtFkPTB(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.util.HashSet set, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JGRHDQYfrHtFkPTB(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.util.HashSet set, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JGRHDQYfrHtFkPTB(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.util.HashSet set, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int JPxwQOgumaUsgpYJ(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void JPxwQOgumaUsgpYJ(int i, int i2, byte b, int i3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JPxwQOgumaUsgpYJ(int i, int i2, int i3, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JPxwQOgumaUsgpYJ(int i, int i2, java.lang.string str, short s, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KJxbThzeOLQgqtIr(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getChildCount();
    }

    public static void KJxbThzeOLQgqtIr(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KJxbThzeOLQgqtIr(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KJxbThzeOLQgqtIr(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KpRaqnBfNLcImlre(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.setChecked(z);
    }

    public static void KpRaqnBfNLcImlre(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KpRaqnBfNLcImlre(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, bool z2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KpRaqnBfNLcImlre(com.google.android.material.button.MaterialButton materialButton, bool z, char c, byte b, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object KzrbXwosmnIwQmwc(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getobject();
    }

    public static void KzrbXwosmnIwQmwc(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, byte b, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KzrbXwosmnIwQmwc(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KzrbXwosmnIwQmwc(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LBvrlWBltMFQLBpm(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.setEnabled(z);
    }

    public static void LBvrlWBltMFQLBpm(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LBvrlWBltMFQLBpm(com.google.android.material.button.MaterialButton materialButton, bool z, short s, bool z2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LBvrlWBltMFQLBpm(com.google.android.material.button.MaterialButton materialButton, bool z, bool z2, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int LGkukldijJJGCdZJ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void LGkukldijJJGCdZJ(int i, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LGkukldijJJGCdZJ(int i, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LGkukldijJJGCdZJ(int i, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LIJGdJWTSIEpEQnE(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        materialButtonToggleGroup.updateChildShapes();
    }

    public static void LIJGdJWTSIEpEQnE(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LIJGdJWTSIEpEQnE(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LIJGdJWTSIEpEQnE(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LIVOllhMSwXNkTId(java.lang.int num) {
        return num.intValue();
    }

    public static void LIVOllhMSwXNkTId(java.lang.int num, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LIVOllhMSwXNkTId(java.lang.int num, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LIVOllhMSwXNkTId(java.lang.int num, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LXFHmeZLuXXfZSua(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.util.HashSet set) {
        materialButtonToggleGroup.updateCheckedIds(set);
    }

    public static void LXFHmeZLuXXfZSua(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.util.HashSet set, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LXFHmeZLuXXfZSua(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.util.HashSet set, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LXFHmeZLuXXfZSua(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.util.HashSet set, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int LsGhQTazFdDbSqYj(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getChildCount();
    }

    public static void LsGhQTazFdDbSqYj(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LsGhQTazFdDbSqYj(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LsGhQTazFdDbSqYj(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int MFGazTEypEsjirSr(java.util.HashSet set) {
        return set.Count;
    }

    public static void MFGazTEypEsjirSr(java.util.HashSet set, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MFGazTEypEsjirSr(java.util.HashSet set, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MFGazTEypEsjirSr(java.util.HashSet set, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MKtmzZwJvkUAUnSV(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        androidx.core.view.MarginLayoutParamsCompat.setMarginStart(viewGroup$MarginLayoutParams, i);
    }

    public static void MKtmzZwJvkUAUnSV(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MKtmzZwJvkUAUnSV(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MKtmzZwJvkUAUnSV(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NtaIRKasWqZKWPsN(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z) {
        materialButtonToggleGroup.setEnabled(z);
    }

    public static void NtaIRKasWqZKWPsN(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, float f, int i, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NtaIRKasWqZKWPsN(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, int i, float f, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NtaIRKasWqZKWPsN(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, int i, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat PNBDMbZNCiWfKUPY(int i, int i2, bool z, int i3) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat.obtain(i, i2, z, i3);
    }

    public static void PNBDMbZNCiWfKUPY(int i, int i2, bool z, int i3, int i4, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PNBDMbZNCiWfKUPY(int i, int i2, bool z, int i3, int i4, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PNBDMbZNCiWfKUPY(int i, int i2, bool z, int i3, java.lang.string str, int i4, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object PPYzPqNaqaqFCRmo(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void PPYzPqNaqaqFCRmo(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PPYzPqNaqaqFCRmo(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PPYzPqNaqaqFCRmo(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PxdPTOzVWkyXWDnY(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PxdPTOzVWkyXWDnY(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PxdPTOzVWkyXWDnY(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool PxdPTOzVWkyXWDnY(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Remove(obj);
    }

    public static com.google.android.material.button.MaterialButtonToggleGroup$CornerData PzFZyLebgLiOUCWO(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, android.view.object view) {
        return com.google.android.material.button.MaterialButtonToggleGroup$CornerData.end(materialButtonToggleGroup$CornerData, view);
    }

    public static void PzFZyLebgLiOUCWO(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, android.view.object view, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PzFZyLebgLiOUCWO(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, android.view.object view, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PzFZyLebgLiOUCWO(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, android.view.object view, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QCiFjoNAaFtPqepw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z) {
        materialButtonToggleGroup.setChildrenDrawingOrderEnabled(z);
    }

    public static void QCiFjoNAaFtPqepw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QCiFjoNAaFtPqepw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, float f, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QCiFjoNAaFtPqepw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QQGwsJgUhcIyHLEi(com.google.android.material.button.MaterialButton materialButton, int i) {
        materialButton.setId(i);
    }

    public static void QQGwsJgUhcIyHLEi(com.google.android.material.button.MaterialButton materialButton, int i, byte b, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QQGwsJgUhcIyHLEi(com.google.android.material.button.MaterialButton materialButton, int i, char c, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void QQGwsJgUhcIyHLEi(com.google.android.material.button.MaterialButton materialButton, int i, char c, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.widget.LinearLayout$LayoutParams QeNIjtBtkzuMcVqd(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view) {
        return materialButtonToggleGroup.buildLayoutParams(view);
    }

    public static void QeNIjtBtkzuMcVqd(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QeNIjtBtkzuMcVqd(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QeNIjtBtkzuMcVqd(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QhlRdHSPRBDoxAuw(java.util.HashSet set, java.lang.object obj, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QhlRdHSPRBDoxAuw(java.util.HashSet set, java.lang.object obj, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QhlRdHSPRBDoxAuw(java.util.HashSet set, java.lang.object obj, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool QhlRdHSPRBDoxAuw(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static void QwynNEcyfeciuzfe(android.content.res.Resources resources, int i, float f, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QwynNEcyfeciuzfe(android.content.res.Resources resources, int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QwynNEcyfeciuzfe(android.content.res.Resources resources, int i, bool z, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool QwynNEcyfeciuzfe(android.content.res.Resources resources, int i) {
        return resources.getbool(i);
    }

    public static int RQtwQNxFXbGfIYZT(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getId();
    }

    public static void RQtwQNxFXbGfIYZT(com.google.android.material.button.MaterialButton materialButton, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RQtwQNxFXbGfIYZT(com.google.android.material.button.MaterialButton materialButton, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RQtwQNxFXbGfIYZT(com.google.android.material.button.MaterialButton materialButton, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RqfBspTNndprCiHT(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z) {
        materialButtonToggleGroup.checkInternal(i, z);
    }

    public static void RqfBspTNndprCiHT(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, byte b, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RqfBspTNndprCiHT(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, char c, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RqfBspTNndprCiHT(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, int i2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int RyAhSTlKivjQKgKF(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void RyAhSTlKivjQKgKF(int i, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RyAhSTlKivjQKgKF(int i, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RyAhSTlKivjQKgKF(int i, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int SzUiTfsiQZtBSUns(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getFirstVisibleChildIndex();
    }

    public static void SzUiTfsiQZtBSUns(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SzUiTfsiQZtBSUns(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SzUiTfsiQZtBSUns(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TLURXSbrmhtMxtoG(java.util.List list, int i) {
        return list.Remove(i);
    }

    public static void TLURXSbrmhtMxtoG(java.util.List list, int i, int i2, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TLURXSbrmhtMxtoG(java.util.List list, int i, java.lang.string str, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TLURXSbrmhtMxtoG(java.util.List list, int i, java.lang.string str, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TNBiKEHOWCrLyVAB(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TNBiKEHOWCrLyVAB(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TNBiKEHOWCrLyVAB(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool TNBiKEHOWCrLyVAB(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.isChildVisible(i);
    }

    public static void TbkawFBbBGGtAnhn(com.google.android.material.button.MaterialButton materialButton, com.google.android.material.button.MaterialButton$OnPressedChangeListener materialButton$OnPressedChangeListener) {
        materialButton.setOnPressedChangeListenerInternal(materialButton$OnPressedChangeListener);
    }

    public static void TbkawFBbBGGtAnhn(com.google.android.material.button.MaterialButton materialButton, com.google.android.material.button.MaterialButton$OnPressedChangeListener materialButton$OnPressedChangeListener, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TbkawFBbBGGtAnhn(com.google.android.material.button.MaterialButton materialButton, com.google.android.material.button.MaterialButton$OnPressedChangeListener materialButton$OnPressedChangeListener, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TbkawFBbBGGtAnhn(com.google.android.material.button.MaterialButton materialButton, com.google.android.material.button.MaterialButton$OnPressedChangeListener materialButton$OnPressedChangeListener, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object ThmuiXHLfPbYJoqJ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.getChildAt(i);
    }

    public static void ThmuiXHLfPbYJoqJ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, float f, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ThmuiXHLfPbYJoqJ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ThmuiXHLfPbYJoqJ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TkkxuyfVlKarobxL(android.widget.LinearLayout linearLayout, android.view.object view) {
        super.onobjectRemoved(view);
    }

    public static void TkkxuyfVlKarobxL(android.widget.LinearLayout linearLayout, android.view.object view, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TkkxuyfVlKarobxL(android.widget.LinearLayout linearLayout, android.view.object view, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TkkxuyfVlKarobxL(android.widget.LinearLayout linearLayout, android.view.object view, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.ICollection TtMRCtkcujvdNopa(java.util.SortedDictionary sortedDictionary) {
        return sortedDictionary.Values;
    }

    public static void TtMRCtkcujvdNopa(java.util.SortedDictionary sortedDictionary, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TtMRCtkcujvdNopa(java.util.SortedDictionary sortedDictionary, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TtMRCtkcujvdNopa(java.util.SortedDictionary sortedDictionary, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void USOSoNOmqoJidSlO(java.util.HashSet set) {
        set.clear();
    }

    public static void USOSoNOmqoJidSlO(java.util.HashSet set, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void USOSoNOmqoJidSlO(java.util.HashSet set, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void USOSoNOmqoJidSlO(java.util.HashSet set, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int UTzCnXoWkffSouSq(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getId();
    }

    public static void UTzCnXoWkffSouSq(com.google.android.material.button.MaterialButton materialButton, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UTzCnXoWkffSouSq(com.google.android.material.button.MaterialButton materialButton, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UTzCnXoWkffSouSq(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder UZYQfuNhTjTWbeVv(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopRightCornerSize(cornerSize);
    }

    public static void UZYQfuNhTjTWbeVv(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UZYQfuNhTjTWbeVv(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UZYQfuNhTjTWbeVv(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UhTGWydILLyfMuuP(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z) {
        materialButtonToggleGroup.setSingleSelection(z);
    }

    public static void UhTGWydILLyfMuuP(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, short s, byte b, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void UhTGWydILLyfMuuP(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, short s, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UhTGWydILLyfMuuP(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, bool z2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VVcZqvZTepZRyLpa(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData) {
        updateBuilderWithCornerData(shapeAppearanceModel$Builder, materialButtonToggleGroup$CornerData);
    }

    public static void VVcZqvZTepZRyLpa(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VVcZqvZTepZRyLpa(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VVcZqvZTepZRyLpa(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VWCmaQOSArNlYJJB(com.google.android.material.button.MaterialButton materialButton, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        materialButton.setLayoutParams(viewGroup$LayoutParams);
    }

    public static void VWCmaQOSArNlYJJB(com.google.android.material.button.MaterialButton materialButton, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, byte b, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VWCmaQOSArNlYJJB(com.google.android.material.button.MaterialButton materialButton, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VWCmaQOSArNlYJJB(com.google.android.material.button.MaterialButton materialButton, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int VdoCajMNmnXPdKAe(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void VdoCajMNmnXPdKAe(int i, byte b, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VdoCajMNmnXPdKAe(int i, int i2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VdoCajMNmnXPdKAe(int i, int i2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int VlyOoLYYhhKviQMl(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void VlyOoLYYhhKviQMl(int i, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VlyOoLYYhhKviQMl(int i, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VlyOoLYYhhKviQMl(int i, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WMUnfGdqfkmlhFiy(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        materialButtonToggleGroup.invalidate();
    }

    public static void WMUnfGdqfkmlhFiy(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WMUnfGdqfkmlhFiy(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WMUnfGdqfkmlhFiy(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WOjbIwZdehqNGNcY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z) {
        materialButtonToggleGroup.checkInternal(i, z);
    }

    public static void WOjbIwZdehqNGNcY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, byte b, bool z2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WOjbIwZdehqNGNcY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, float f, byte b, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void WOjbIwZdehqNGNcY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, bool z2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WUSABoVhXXpmTbNP(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void WUSABoVhXXpmTbNP(java.lang.string str, java.lang.string str2, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WUSABoVhXXpmTbNP(java.lang.string str, java.lang.string str2, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WUSABoVhXXpmTbNP(java.lang.string str, java.lang.string str2, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int WbWEbhrzINDRyePb(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getId();
    }

    public static void WbWEbhrzINDRyePb(com.google.android.material.button.MaterialButton materialButton, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WbWEbhrzINDRyePb(com.google.android.material.button.MaterialButton materialButton, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WbWEbhrzINDRyePb(com.google.android.material.button.MaterialButton materialButton, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int XgscmSDNlXwcAmKE(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getChildCount();
    }

    public static void XgscmSDNlXwcAmKE(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XgscmSDNlXwcAmKE(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XgscmSDNlXwcAmKE(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XwVNgXIobOuHdcBJ(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        androidx.core.view.MarginLayoutParamsCompat.setMarginStart(viewGroup$MarginLayoutParams, i);
    }

    public static void XwVNgXIobOuHdcBJ(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XwVNgXIobOuHdcBJ(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, short s, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XwVNgXIobOuHdcBJ(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, short s, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.CornerSize YFsnFRDcvSlicGmf(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getTopRightCornerSize();
    }

    public static void YFsnFRDcvSlicGmf(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YFsnFRDcvSlicGmf(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YFsnFRDcvSlicGmf(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YYrlVjyHNkPLxxYE(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, com.google.android.material.button.MaterialButton materialButton) {
        materialButtonToggleGroup.setupButtonChild(materialButton);
    }

    public static void YYrlVjyHNkPLxxYE(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, com.google.android.material.button.MaterialButton materialButton, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YYrlVjyHNkPLxxYE(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, com.google.android.material.button.MaterialButton materialButton, int i, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YYrlVjyHNkPLxxYE(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, com.google.android.material.button.MaterialButton materialButton, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZIimrdXHVhrsHSTy(android.content.res.TypedArray typedArray, int i, bool z, float f, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZIimrdXHVhrsHSTy(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZIimrdXHVhrsHSTy(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool ZIimrdXHVhrsHSTy(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void ZLAOnhBpDSczatYQ(java.util.HashSet set, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZLAOnhBpDSczatYQ(java.util.HashSet set, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZLAOnhBpDSczatYQ(java.util.HashSet set, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ZLAOnhBpDSczatYQ(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static void ZQckWtYMoOHIVJca(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        androidx.core.view.MarginLayoutParamsCompat.setMarginStart(viewGroup$MarginLayoutParams, i);
    }

    public static void ZQckWtYMoOHIVJca(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, char c, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZQckWtYMoOHIVJca(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, char c, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZQckWtYMoOHIVJca(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.button.MaterialButton ZXBmeYLmwHGGzqeq(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.getChildButton(i);
    }

    public static void ZXBmeYLmwHGGzqeq(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, char c, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZXBmeYLmwHGGzqeq(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, char c, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZXBmeYLmwHGGzqeq(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, short s, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZXLASWcCxjHAHvuX(com.google.android.material.button.MaterialButton materialButton, com.google.android.material.button.MaterialButton$OnPressedChangeListener materialButton$OnPressedChangeListener) {
        materialButton.setOnPressedChangeListenerInternal(materialButton$OnPressedChangeListener);
    }

    public static void ZXLASWcCxjHAHvuX(com.google.android.material.button.MaterialButton materialButton, com.google.android.material.button.MaterialButton$OnPressedChangeListener materialButton$OnPressedChangeListener, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZXLASWcCxjHAHvuX(com.google.android.material.button.MaterialButton materialButton, com.google.android.material.button.MaterialButton$OnPressedChangeListener materialButton$OnPressedChangeListener, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZXLASWcCxjHAHvuX(com.google.android.material.button.MaterialButton materialButton, com.google.android.material.button.MaterialButton$OnPressedChangeListener materialButton$OnPressedChangeListener, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int ZXUlHLraSVVzihRo(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void ZXUlHLraSVVzihRo(android.content.res.TypedArray typedArray, int i, int i2, float f, int i3, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZXUlHLraSVVzihRo(android.content.res.TypedArray typedArray, int i, int i2, float f, bool z, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZXUlHLraSVVzihRo(android.content.res.TypedArray typedArray, int i, int i2, short s, int i3, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.CornerSize ZcmuoyFpZNxUiSsK(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomRightCornerSize();
    }

    public static void ZcmuoyFpZNxUiSsK(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZcmuoyFpZNxUiSsK(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZcmuoyFpZNxUiSsK(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZmLYySOsvRDcbXOa(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getOrientation();
    }

    public static void ZmLYySOsvRDcbXOa(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZmLYySOsvRDcbXOa(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZmLYySOsvRDcbXOa(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZtGgvhIZXkSvWTaT(java.lang.int num) {
        return num.intValue();
    }

    public static void ZtGgvhIZXkSvWTaT(java.lang.int num, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZtGgvhIZXkSvWTaT(java.lang.int num, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZtGgvhIZXkSvWTaT(java.lang.int num, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ADBRFJmtoVHDOqoI(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getFirstVisibleChildIndex();
    }

    public static void ADBRFJmtoVHDOqoI(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ADBRFJmtoVHDOqoI(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ADBRFJmtoVHDOqoI(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AGeAZBrZTbtSedsf(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z) {
        materialButtonToggleGroup.setSingleSelection(z);
    }

    public static void AGeAZBrZTbtSedsf(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, float f, java.lang.string str, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AGeAZBrZTbtSedsf(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, java.lang.string str, bool z2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AGeAZBrZTbtSedsf(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, bool z2, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int AMTGNgMEaTySHXSw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getOrientation();
    }

    public static void AMTGNgMEaTySHXSw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AMTGNgMEaTySHXSw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AMTGNgMEaTySHXSw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ARSaxsZxFQLfGSYE(java.util.HashSet set, java.lang.object obj, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ARSaxsZxFQLfGSYE(java.util.HashSet set, java.lang.object obj, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ARSaxsZxFQLfGSYE(java.util.HashSet set, java.lang.object obj, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ARSaxsZxFQLfGSYE(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static int AaAIKPRskFMuoKAy() {
        return androidx.core.view.objectCompat.generateobjectId();
    }

    public static void AaAIKPRskFMuoKAy(byte b, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AaAIKPRskFMuoKAy(byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AaAIKPRskFMuoKAy(java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static int access$100(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view) {
        return ztwJTJNuKIziqbLg(materialButtonToggleGroup, view);
    }

    static void access$100(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void AdjustChildMarginsAndUpdateLayout() {
        if ((21 + 19) % 19 > 0) {
        }
        int iADBRFJmtoVHDOqoI = aDBRFJmtoVHDOqoI(this);
        if (iADBRFJmtoVHDOqoI != -1) {
            for (int i = iADBRFJmtoVHDOqoI + 1; i < hRTiIdmUAinyqFaw(this); i++) {
                com.google.android.material.button.MaterialButton materialButtonFZuFTpaLPiJxCRXG = fZuFTpaLPiJxCRXG(this, i);
                int iJPxwQOgumaUsgpYJ = JPxwQOgumaUsgpYJ(IfwWvAfgFEjxkjyK(materialButtonFZuFTpaLPiJxCRXG), iInniNePESWQIRlA(bKkqKpqUNLuiGrwh(this, i - 1)));
                android.widget.LinearLayout$LayoutParams linearLayout$LayoutParamsQeNIjtBtkzuMcVqd = QeNIjtBtkzuMcVqd(this, materialButtonFZuFTpaLPiJxCRXG);
                if (FpotUQcljSdHvwby(this) != 0) {
                    linearLayout$LayoutParamsQeNIjtBtkzuMcVqd.bottomMargin = 0;
                    linearLayout$LayoutParamsQeNIjtBtkzuMcVqd.topMargin = -iJPxwQOgumaUsgpYJ;
                    XwVNgXIobOuHdcBJ(linearLayout$LayoutParamsQeNIjtBtkzuMcVqd, 0);
                } else {
                    CbqrHirdOokIIxBX(linearLayout$LayoutParamsQeNIjtBtkzuMcVqd, 0);
                    ZQckWtYMoOHIVJca(linearLayout$LayoutParamsQeNIjtBtkzuMcVqd, -iJPxwQOgumaUsgpYJ);
                    linearLayout$LayoutParamsQeNIjtBtkzuMcVqd.topMargin = 0;
                }
                VWCmaQOSArNlYJJB(materialButtonFZuFTpaLPiJxCRXG, linearLayout$LayoutParamsQeNIjtBtkzuMcVqd);
            }
            faKEUGScEcySWOBY(this, iADBRFJmtoVHDOqoI);
        }
    }

    private void AdjustChildMarginsAndUpdateLayout(int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void AdjustChildMarginsAndUpdateLayout(int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void AdjustChildMarginsAndUpdateLayout(java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int AxTlUCzhADDtgBEB(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void AxTlUCzhADDtgBEB(int i, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AxTlUCzhADDtgBEB(int i, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AxTlUCzhADDtgBEB(int i, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BHITAzepohkGvEcQ(java.util.HashSet set, java.lang.object obj, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BHITAzepohkGvEcQ(java.util.HashSet set, java.lang.object obj, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BHITAzepohkGvEcQ(java.util.HashSet set, java.lang.object obj, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool BHITAzepohkGvEcQ(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static com.google.android.material.button.MaterialButton BKkqKpqUNLuiGrwh(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.getChildButton(i);
    }

    public static void BKkqKpqUNLuiGrwh(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, byte b, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BKkqKpqUNLuiGrwh(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BKkqKpqUNLuiGrwh(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BnulZkYeCTZXKCbR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void BnulZkYeCTZXKCbR(java.lang.stringBuilder sb, int i, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BnulZkYeCTZXKCbR(java.lang.stringBuilder sb, int i, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BnulZkYeCTZXKCbR(java.lang.stringBuilder sb, int i, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BpqjXyuZshCLWlSi(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BpqjXyuZshCLWlSi(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, byte b, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BpqjXyuZshCLWlSi(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BpqjXyuZshCLWlSi(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.isChildVisible(i);
    }

    public static java.lang.object BryDwIRdAjAhcLHK(java.util.SortedDictionary sortedDictionary, java.lang.object obj, java.lang.object obj2) {
        return sortedDictionary.Add(obj, obj2);
    }

    public static void BryDwIRdAjAhcLHK(java.util.SortedDictionary sortedDictionary, java.lang.object obj, java.lang.object obj2, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BryDwIRdAjAhcLHK(java.util.SortedDictionary sortedDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BryDwIRdAjAhcLHK(java.util.SortedDictionary sortedDictionary, java.lang.object obj, java.lang.object obj2, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private android.widget.LinearLayout$LayoutParams buildLayoutParams(android.view.object view) {
        android.view.objectGroup$LayoutParams viewGroup$LayoutParamsNwHMNmyvBHnBiOgL = nwHMNmyvBHnBiOgL(view);
        return !(viewGroup$LayoutParamsNwHMNmyvBHnBiOgL is android.widget.LinearLayout$LayoutParams) ? new android.widget.LinearLayout$LayoutParams(viewGroup$LayoutParamsNwHMNmyvBHnBiOgL.width, viewGroup$LayoutParamsNwHMNmyvBHnBiOgL.height) : (android.widget.LinearLayout$LayoutParams) viewGroup$LayoutParamsNwHMNmyvBHnBiOgL;
    }

    private void BuildLayoutParams(android.view.object view, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void BuildLayoutParams(android.view.object view, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void BuildLayoutParams(android.view.object view, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CXdVKeOeiNURplbT(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getChildCount();
    }

    public static void CXdVKeOeiNURplbT(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CXdVKeOeiNURplbT(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CXdVKeOeiNURplbT(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void CheckInternal(int i, bool z) {
        if ((3 + 15) % 15 > 0) {
        }
        if (i == -1) {
            WUSABoVhXXpmTbNP("MButtonToggleGroup", fHpvbCsYfeMnmfJY(bnulZkYeCTZXKCbR(new java.lang.stringBuilder("Button ID is not valid: "), i)));
            return;
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet(this.checkedIds);
        if (z && !aRSaxsZxFQLfGSYE(hashHashSet, lpvBscSpNabGfvEC(i))) {
            if (this.singleSelection && !ZLAOnhBpDSczatYQ(hashHashSet)) {
                USOSoNOmqoJidSlO(hashHashSet);
            }
            vizJTqGeKwctGMJN(hashHashSet, rRiXXaSoInwDiCAj(i));
        } else {
            if (z || !QhlRdHSPRBDoxAuw(hashHashSet, VdoCajMNmnXPdKAe(i))) {
                return;
            }
            if (!this.selectionRequired || MFGazTEypEsjirSr(hashHashSet) > 1) {
                ojCXWoWBIxBIIMVp(hashHashSet, HBkiMxDkwlzTtadH(i));
            }
        }
        LXFHmeZLuXXfZSua(this, hashHashSet);
    }

    private void CheckInternal(int i, bool z, int i2, bool z2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CheckInternal(int i, bool z, short s, int i2, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void CheckInternal(int i, bool z, bool z2, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DAbDHyTjsHKVUSJV(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        materialButtonToggleGroup.clearChecked();
    }

    public static void DAbDHyTjsHKVUSJV(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DAbDHyTjsHKVUSJV(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DAbDHyTjsHKVUSJV(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DHyDrOwLhtvsoJmh(java.util.HashSet set, java.lang.object obj, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DHyDrOwLhtvsoJmh(java.util.HashSet set, java.lang.object obj, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DHyDrOwLhtvsoJmh(java.util.HashSet set, java.lang.object obj, bool z, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool DHyDrOwLhtvsoJmh(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static void DcdbiYHpmgygvPLw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        materialButtonToggleGroup.updateChildShapes();
    }

    public static void DcdbiYHpmgygvPLw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DcdbiYHpmgygvPLw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DcdbiYHpmgygvPLw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private void DispatchOnButtonChecked(int i, bool z) {
        if ((2 + 23) % 23 > 0) {
        }
        java.util.IEnumerator itEhZjliTIegpkGOeD = ehZjliTIegpkGOeD(this.onButtonCheckedListeners);
        while (vdzsHmFFSLcBHSii(itEhZjliTIegpkGOeD)) {
            iEEgOdNFtjUEIxrB((com.google.android.material.button.MaterialButtonToggleGroup$OnButtonCheckedListener) zoBhILbdflnOTsrD(itEhZjliTIegpkGOeD), this, i, z);
        }
    }

    private void DispatchOnButtonChecked(int i, bool z, float f, byte b, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void DispatchOnButtonChecked(int i, bool z, short s, float f, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void DispatchOnButtonChecked(int i, bool z, bool z2, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int DvxZcEsBRKHvpdfP(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void DvxZcEsBRKHvpdfP(int i, byte b, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DvxZcEsBRKHvpdfP(int i, int i2, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DvxZcEsBRKHvpdfP(int i, int i2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ETiDsrSfVfGGexIv(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, com.google.android.material.button.MaterialButton materialButton) {
        materialButtonToggleGroup.setGeneratedIdIfNeeded(materialButton);
    }

    public static void ETiDsrSfVfGGexIv(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, com.google.android.material.button.MaterialButton materialButton, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ETiDsrSfVfGGexIv(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, com.google.android.material.button.MaterialButton materialButton, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ETiDsrSfVfGGexIv(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, com.google.android.material.button.MaterialButton materialButton, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EcCYuMUGMzfxmogi(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i) {
        androidx.core.view.MarginLayoutParamsCompat.setMarginEnd(viewGroup$MarginLayoutParams, i);
    }

    public static void EcCYuMUGMzfxmogi(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, char c, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EcCYuMUGMzfxmogi(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EcCYuMUGMzfxmogi(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator EhZjliTIegpkGOeD(java.util.LinkedHashHashSet linkedHashHashSet) {
        return linkedHashHashSet.GetEnumerator();
    }

    public static void EhZjliTIegpkGOeD(java.util.LinkedHashHashSet linkedHashHashSet, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EhZjliTIegpkGOeD(java.util.LinkedHashHashSet linkedHashHashSet, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EhZjliTIegpkGOeD(java.util.LinkedHashHashSet linkedHashHashSet, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ElouKkftXkwhRxXu(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getVisibleButtonCount();
    }

    public static void ElouKkftXkwhRxXu(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ElouKkftXkwhRxXu(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ElouKkftXkwhRxXu(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EoJnaOxSaPONBduM(android.widget.LinearLayout linearLayout) {
        super.onFinishInflate();
    }

    public static void EoJnaOxSaPONBduM(android.widget.LinearLayout linearLayout, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EoJnaOxSaPONBduM(android.widget.LinearLayout linearLayout, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EoJnaOxSaPONBduM(android.widget.LinearLayout linearLayout, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EzpBdskFItkMAEWC(java.util.HashSet set, java.lang.object obj, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EzpBdskFItkMAEWC(java.util.HashSet set, java.lang.object obj, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EzpBdskFItkMAEWC(java.util.HashSet set, java.lang.object obj, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool EzpBdskFItkMAEWC(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.string FHpvbCsYfeMnmfJY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FHpvbCsYfeMnmfJY(java.lang.stringBuilder sb, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FHpvbCsYfeMnmfJY(java.lang.stringBuilder sb, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FHpvbCsYfeMnmfJY(java.lang.stringBuilder sb, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FKKoTDPcBNEwEudr(android.widget.LinearLayout linearLayout, int i, int i2) {
        super.onMeasure(i, i2);
    }

    public static void FKKoTDPcBNEwEudr(android.widget.LinearLayout linearLayout, int i, int i2, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FKKoTDPcBNEwEudr(android.widget.LinearLayout linearLayout, int i, int i2, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FKKoTDPcBNEwEudr(android.widget.LinearLayout linearLayout, int i, int i2, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FPhbbRaprbaQTMVO(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.setEnabled(z);
    }

    public static void FPhbbRaprbaQTMVO(com.google.android.material.button.MaterialButton materialButton, bool z, float f, java.lang.string str, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void FPhbbRaprbaQTMVO(com.google.android.material.button.MaterialButton materialButton, bool z, float f, java.lang.string str, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FPhbbRaprbaQTMVO(com.google.android.material.button.MaterialButton materialButton, bool z, float f, bool z2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.button.MaterialButton FZuFTpaLPiJxCRXG(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.getChildButton(i);
    }

    public static void FZuFTpaLPiJxCRXG(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, char c, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FZuFTpaLPiJxCRXG(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, int i2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FZuFTpaLPiJxCRXG(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, int i2, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FaKEUGScEcySWOBY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        materialButtonToggleGroup.resetChildMargins(i);
    }

    public static void FaKEUGScEcySWOBY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FaKEUGScEcySWOBY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FaKEUGScEcySWOBY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FbPaInqWzTEPmUrh(java.util.HashSet set, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FbPaInqWzTEPmUrh(java.util.HashSet set, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FbPaInqWzTEPmUrh(java.util.HashSet set, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool FbPaInqWzTEPmUrh(java.util.HashSet set) {
        return set.Count == 0;
    }

    public static void FniGVKfdghajNWbr(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FniGVKfdghajNWbr(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FniGVKfdghajNWbr(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj, int i, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool FniGVKfdghajNWbr(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.object obj) {
        return linkedHashHashSet.Add(obj);
    }

    public static void FuiOnUDHVLyjyOnA(com.google.android.material.button.MaterialButton materialButton, java.lang.string str) {
        materialButton.setA11yClassName(str);
    }

    public static void FuiOnUDHVLyjyOnA(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FuiOnUDHVLyjyOnA(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FuiOnUDHVLyjyOnA(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.button.MaterialButton GetChildButton(int i) {
        return (com.google.android.material.button.MaterialButton) ThmuiXHLfPbYJoqJ(this, i);
    }

    private void GetChildButton(int i, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetChildButton(int i, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetChildButton(int i, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private int GetFirstVisibleChildIndex() {
        if ((11 + 29) % 29 > 0) {
        }
        int iKPDCnTKMBMuXRwle = kPDCnTKMBMuXRwle(this);
        for (int i = 0; i < iKPDCnTKMBMuXRwle; i++) {
            if (uhwAxhJVDADboOUZ(this, i)) {
                return i;
            }
        }
        return -1;
    }

    private void GetFirstVisibleChildIndex(byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void GetFirstVisibleChildIndex(int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private void GetFirstVisibleChildIndex(short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private int GetIndexWithinVisibleButtons(android.view.object view) {
        if ((22 + 24) % 24 > 0) {
        }
        if (!(view is com.google.android.material.button.MaterialButton)) {
            return -1;
        }
        int i = 0;
        for (int i2 = 0; i2 < pIlzUTKBRZcWLfGk(this); i2++) {
            if (hOYccLzupgtvIgch(this, i2) == view) {
                return i;
            }
            if ((jDmtKovTJKAagdkp(this, i2) instanceof com.google.android.material.button.MaterialButton) && bpqjXyuZshCLWlSi(this, i2)) {
                i++;
            }
        }
        return -1;
    }

    private void GetIndexWithinVisibleButtons(android.view.object view, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetIndexWithinVisibleButtons(android.view.object view, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetIndexWithinVisibleButtons(android.view.object view, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    private int GetLastVisibleChildIndex() {
        if ((20 + 30) % 30 > 0) {
        }
        for (int iCXdVKeOeiNURplbT = cXdVKeOeiNURplbT(this) - 1; iCXdVKeOeiNURplbT >= 0; iCXdVKeOeiNURplbT--) {
            if (TNBiKEHOWCrLyVAB(this, iCXdVKeOeiNURplbT)) {
                return iCXdVKeOeiNURplbT;
            }
        }
        return -1;
    }

    private void GetLastVisibleChildIndex(float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetLastVisibleChildIndex(float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void GetLastVisibleChildIndex(bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.button.MaterialButtonToggleGroup$CornerData getNewCornerData(int i, int i2, int i3) {
        if ((4 + 30) % 30 > 0) {
        }
        com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData = (com.google.android.material.button.MaterialButtonToggleGroup$CornerData) hFugZVTynRZjafUG(this.originalCornerData, i);
        if (i2 == i3) {
            return materialButtonToggleGroup$CornerData;
        }
        bool z = aMTGNgMEaTySHXSw(this) == 0;
        if (i == i2) {
            return !z ? GoBsGpaPWpKysFQh(materialButtonToggleGroup$CornerData) : GzPMrbosoQRAWCUf(materialButtonToggleGroup$CornerData, this);
        }
        if (i != i3) {
            return null;
        }
        return !z ? wXIxcEwWWwuRGGib(materialButtonToggleGroup$CornerData) : PzFZyLebgLiOUCWO(materialButtonToggleGroup$CornerData, this);
    }

    private void GetNewCornerData(int i, int i2, int i3, byte b, int i4, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private void GetNewCornerData(int i, int i2, int i3, java.lang.string str, byte b, short s, int i4) {
        double d = (42 * 210) + 210;
    }

    private void GetNewCornerData(int i, int i2, int i3, short s, byte b, java.lang.string str, int i4) {
        double d = (42 * 210) + 210;
    }

    private int GetVisibleButtonCount() {
        if ((1 + 9) % 9 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < XgscmSDNlXwcAmKE(this); i2++) {
            if ((rbxvtEThvUFcqrcY(this, i2) instanceof com.google.android.material.button.MaterialButton) && xStMgThyJWRcgZbY(this, i2)) {
                i++;
            }
        }
        return i;
    }

    private void GetVisibleButtonCount(short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void GetVisibleButtonCount(short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void GetVisibleButtonCount(short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GylFjyZNTTKJerZc(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        materialButtonToggleGroup.updateChildOrder();
    }

    public static void GylFjyZNTTKJerZc(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.lang.string str, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GylFjyZNTTKJerZc(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GylFjyZNTTKJerZc(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int HAQCqqTnpXbQLXQN(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getChildCount();
    }

    public static void HAQCqqTnpXbQLXQN(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HAQCqqTnpXbQLXQN(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HAQCqqTnpXbQLXQN(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HFugZVTynRZjafUG(java.util.List list, int i) {
        return list[i);
    }

    public static void HFugZVTynRZjafUG(java.util.List list, int i, int i2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HFugZVTynRZjafUG(java.util.List list, int i, short s, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HFugZVTynRZjafUG(java.util.List list, int i, short s, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object HOYccLzupgtvIgch(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.getChildAt(i);
    }

    public static void HOYccLzupgtvIgch(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, int i2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HOYccLzupgtvIgch(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, int i2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HOYccLzupgtvIgch(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, short s, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams hQMlCZcfivSOjxGb(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getLayoutParams();
    }

    public static void HQMlCZcfivSOjxGb(com.google.android.material.button.MaterialButton materialButton, char c, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HQMlCZcfivSOjxGb(com.google.android.material.button.MaterialButton materialButton, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HQMlCZcfivSOjxGb(com.google.android.material.button.MaterialButton materialButton, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int HRTiIdmUAinyqFaw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getChildCount();
    }

    public static void HRTiIdmUAinyqFaw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HRTiIdmUAinyqFaw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HRTiIdmUAinyqFaw(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HgihqWEaOniGezBd(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z) {
        materialButtonToggleGroup.dispatchOnButtonChecked(i, z);
    }

    public static void HgihqWEaOniGezBd(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, java.lang.string str, char c, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HgihqWEaOniGezBd(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, java.lang.string str, float f, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HgihqWEaOniGezBd(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, bool z2, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HhkMzicYlXhLEsAf(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.setShouldDrawSurfaceColorStroke(z);
    }

    public static void HhkMzicYlXhLEsAf(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, float f, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HhkMzicYlXhLEsAf(com.google.android.material.button.MaterialButton materialButton, bool z, float f, byte b, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void HhkMzicYlXhLEsAf(com.google.android.material.button.MaterialButton materialButton, bool z, bool z2, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IEEgOdNFtjUEIxrB(com.google.android.material.button.MaterialButtonToggleGroup$OnButtonCheckedListener materialButtonToggleGroup$OnButtonCheckedListener, com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z) {
        materialButtonToggleGroup$OnButtonCheckedListener.onButtonChecked(materialButtonToggleGroup, i, z);
    }

    public static void IEEgOdNFtjUEIxrB(com.google.android.material.button.MaterialButtonToggleGroup$OnButtonCheckedListener materialButtonToggleGroup$OnButtonCheckedListener, com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, float f, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void IEEgOdNFtjUEIxrB(com.google.android.material.button.MaterialButtonToggleGroup$OnButtonCheckedListener materialButtonToggleGroup$OnButtonCheckedListener, com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, int i2, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IEEgOdNFtjUEIxrB(com.google.android.material.button.MaterialButtonToggleGroup$OnButtonCheckedListener materialButtonToggleGroup$OnButtonCheckedListener, com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, short s, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int IGPSKSrKinqayakq(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void IGPSKSrKinqayakq(java.lang.string str, java.lang.string str2, float f, java.lang.string str3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IGPSKSrKinqayakq(java.lang.string str, java.lang.string str2, float f, short s, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IGPSKSrKinqayakq(java.lang.string str, java.lang.string str2, short s, byte b, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static int IInniNePESWQIRlA(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getStrokeWidth();
    }

    public static void IInniNePESWQIRlA(com.google.android.material.button.MaterialButton materialButton, byte b, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IInniNePESWQIRlA(com.google.android.material.button.MaterialButton materialButton, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IInniNePESWQIRlA(com.google.android.material.button.MaterialButton materialButton, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static int IdPciPkdcckJqYpv(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getId();
    }

    public static void IdPciPkdcckJqYpv(com.google.android.material.button.MaterialButton materialButton, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IdPciPkdcckJqYpv(com.google.android.material.button.MaterialButton materialButton, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IdPciPkdcckJqYpv(com.google.android.material.button.MaterialButton materialButton, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void IsChildVisible(int i, int i2, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void IsChildVisible(int i, short s, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsChildVisible(int i, bool z, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    private bool IsChildVisible(int i) {
        return CKLmamqtCYBCeoiI(EhCsOOuEJLoyGIPC(this, i)) != 8;
    }

    public static android.view.object JDmtKovTJKAagdkp(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.getChildAt(i);
    }

    public static void JDmtKovTJKAagdkp(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, float f, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JDmtKovTJKAagdkp(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, float f, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JDmtKovTJKAagdkp(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel JEXdwHivBMoBLdQa(com.google.android.material.button.MaterialButton materialButton) {
        return materialButton.getShapeAppearanceModel();
    }

    public static void JEXdwHivBMoBLdQa(com.google.android.material.button.MaterialButton materialButton, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JEXdwHivBMoBLdQa(com.google.android.material.button.MaterialButton materialButton, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JEXdwHivBMoBLdQa(com.google.android.material.button.MaterialButton materialButton, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string JdhQgwIJEHspktRK(java.lang.Class cls) {
        return cls.getName();
    }

    public static void JdhQgwIJEHspktRK(java.lang.Class cls, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JdhQgwIJEHspktRK(java.lang.Class cls, short s, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JdhQgwIJEHspktRK(java.lang.Class cls, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int KPDCnTKMBMuXRwle(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getChildCount();
    }

    public static void KPDCnTKMBMuXRwle(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KPDCnTKMBMuXRwle(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KPDCnTKMBMuXRwle(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.button.MaterialButton KSpQSWmMUjMuUiBl(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.getChildButton(i);
    }

    public static void KSpQSWmMUjMuUiBl(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, byte b, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KSpQSWmMUjMuUiBl(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KSpQSWmMUjMuUiBl(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KnBFxYSXjPZlmqPk(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        materialButtonToggleGroup.adjustChildMarginsAndUpdateLayout();
    }

    public static void KnBFxYSXjPZlmqPk(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KnBFxYSXjPZlmqPk(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KnBFxYSXjPZlmqPk(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder lTjszpNSjHMnyVjf(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.toBuilder();
    }

    public static void LTjszpNSjHMnyVjf(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LTjszpNSjHMnyVjf(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LTjszpNSjHMnyVjf(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LhJragPoWJbWtmbb(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void LhJragPoWJbWtmbb(java.util.IEnumerator it, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LhJragPoWJbWtmbb(java.util.IEnumerator it, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LhJragPoWJbWtmbb(java.util.IEnumerator it, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel LhQxOMXHXhDwaKSd(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder) {
        return shapeAppearanceModel$Builder.build();
    }

    public static void LhQxOMXHXhDwaKSd(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LhQxOMXHXhDwaKSd(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LhQxOMXHXhDwaKSd(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int LpvBscSpNabGfvEC(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void LpvBscSpNabGfvEC(int i, byte b, short s, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LpvBscSpNabGfvEC(int i, int i2, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LpvBscSpNabGfvEC(int i, short s, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void LvJMuvarNMessgqM(java.util.List list, java.lang.object obj, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LvJMuvarNMessgqM(java.util.List list, java.lang.object obj, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LvJMuvarNMessgqM(java.util.List list, java.lang.object obj, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool LvJMuvarNMessgqM(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.android.material.button.MaterialButton MAQFigtZxMOJRMBa(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.getChildButton(i);
    }

    public static void MAQFigtZxMOJRMBa(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MAQFigtZxMOJRMBa(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MAQFigtZxMOJRMBa(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NGArvVrDMzrJKDTU(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        materialButtonToggleGroup.updateChildrenA11yClassName();
    }

    public static void NGArvVrDMzrJKDTU(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NGArvVrDMzrJKDTU(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NGArvVrDMzrJKDTU(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int NnJYfAuOSgahcGAv(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void NnJYfAuOSgahcGAv(int i, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NnJYfAuOSgahcGAv(int i, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NnJYfAuOSgahcGAv(int i, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$LayoutParams nwHMNmyvBHnBiOgL(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void NwHMNmyvBHnBiOgL(android.view.object view, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NwHMNmyvBHnBiOgL(android.view.object view, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NwHMNmyvBHnBiOgL(android.view.object view, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder oLIlZeISjvhZIUhd(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setTopLeftCornerSize(cornerSize);
    }

    public static void OLIlZeISjvhZIUhd(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OLIlZeISjvhZIUhd(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OLIlZeISjvhZIUhd(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OPIWhWhroFjQSQEi(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.util.HashSet set) {
        materialButtonToggleGroup.updateCheckedIds(set);
    }

    public static void OPIWhWhroFjQSQEi(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.util.HashSet set, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OPIWhWhroFjQSQEi(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.util.HashSet set, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OPIWhWhroFjQSQEi(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.util.HashSet set, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder oSdLhGhZCIjjcHft(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f) {
        return shapeAppearanceModel$Builder.setAllCornerSizes(f);
    }

    public static void OSdLhGhZCIjjcHft(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, char c, float f2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OSdLhGhZCIjjcHft(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, float f2, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OSdLhGhZCIjjcHft(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, float f, short s, int i, float f2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OjCXWoWBIxBIIMVp(java.util.HashSet set, java.lang.object obj, byte b, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OjCXWoWBIxBIIMVp(java.util.HashSet set, java.lang.object obj, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OjCXWoWBIxBIIMVp(java.util.HashSet set, java.lang.object obj, char c, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OjCXWoWBIxBIIMVp(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static int OuKKeuRSrOWSEDhp(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getChildCount();
    }

    public static void OuKKeuRSrOWSEDhp(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OuKKeuRSrOWSEDhp(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OuKKeuRSrOWSEDhp(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.ShapeAppearanceModel$Builder pAlKYHhmSNwjCYjL(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize) {
        return shapeAppearanceModel$Builder.setBottomLeftCornerSize(cornerSize);
    }

    public static void PAlKYHhmSNwjCYjL(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PAlKYHhmSNwjCYjL(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PAlKYHhmSNwjCYjL(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.shape.CornerSize cornerSize, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PIlzUTKBRZcWLfGk(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getChildCount();
    }

    public static void PIlzUTKBRZcWLfGk(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PIlzUTKBRZcWLfGk(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PIlzUTKBRZcWLfGk(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator PWumIwObGeLoqleN(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void PWumIwObGeLoqleN(java.util.HashSet set, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PWumIwObGeLoqleN(java.util.HashSet set, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PWumIwObGeLoqleN(java.util.HashSet set, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PZPEaOUfolvzbYtr(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void PZPEaOUfolvzbYtr(android.view.object view, int i, float f, int i2, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PZPEaOUfolvzbYtr(android.view.object view, int i, int i2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PZPEaOUfolvzbYtr(android.view.object view, int i, int i2, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.button.MaterialButton PpIupOjdxlydWCkt(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.getChildButton(i);
    }

    public static void PpIupOjdxlydWCkt(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, int i2, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PpIupOjdxlydWCkt(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, char c, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PpIupOjdxlydWCkt(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PztYIQJdpfPWIAtm(com.google.android.material.button.MaterialButton materialButton, android.text.TextUtils$TruncateAt textUtils$TruncateAt) {
        materialButton.setEllipsize(textUtils$TruncateAt);
    }

    public static void PztYIQJdpfPWIAtm(com.google.android.material.button.MaterialButton materialButton, android.text.TextUtils$TruncateAt textUtils$TruncateAt, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PztYIQJdpfPWIAtm(com.google.android.material.button.MaterialButton materialButton, android.text.TextUtils$TruncateAt textUtils$TruncateAt, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PztYIQJdpfPWIAtm(com.google.android.material.button.MaterialButton materialButton, android.text.TextUtils$TruncateAt textUtils$TruncateAt, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int RRiXXaSoInwDiCAj(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void RRiXXaSoInwDiCAj(int i, float f, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RRiXXaSoInwDiCAj(int i, short s, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RRiXXaSoInwDiCAj(int i, bool z, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RXJpwReFWIpjXLvA(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static void RXJpwReFWIpjXLvA(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RXJpwReFWIpjXLvA(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RXJpwReFWIpjXLvA(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object RbxvtEThvUFcqrcY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.getChildAt(i);
    }

    public static void RbxvtEThvUFcqrcY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, int i2, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RbxvtEThvUFcqrcY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RbxvtEThvUFcqrcY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ResetChildMargins(int i) {
        if ((13 + 3) % 3 > 0) {
        }
        if (LsGhQTazFdDbSqYj(this) == 0 || i == -1) {
            return;
        }
        android.widget.LinearLayout$LayoutParams linearLayout$LayoutParams = (android.widget.LinearLayout$LayoutParams) hQMlCZcfivSOjxGb(ZXBmeYLmwHGGzqeq(this, i));
        if (ZmLYySOsvRDcbXOa(this) == 1) {
            linearLayout$LayoutParams.topMargin = 0;
            linearLayout$LayoutParams.bottomMargin = 0;
        } else {
            ecCYuMUGMzfxmogi(linearLayout$LayoutParams, 0);
            MKtmzZwJvkUAUnSV(linearLayout$LayoutParams, 0);
            linearLayout$LayoutParams.leftMargin = 0;
            linearLayout$LayoutParams.rightMargin = 0;
        }
    }

    private void ResetChildMargins(int i, float f, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void ResetChildMargins(int i, float f, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    private void ResetChildMargins(int i, int i2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SFNixokMGyPdKEJI(com.google.android.material.button.MaterialButton materialButton, bool z) {
        materialButton.setCheckable(z);
    }

    public static void SFNixokMGyPdKEJI(com.google.android.material.button.MaterialButton materialButton, bool z, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SFNixokMGyPdKEJI(com.google.android.material.button.MaterialButton materialButton, bool z, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SFNixokMGyPdKEJI(com.google.android.material.button.MaterialButton materialButton, bool z, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void STFkdgeLlmOGcJhd(java.util.ICollection collection, java.lang.object[] objArr, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void STFkdgeLlmOGcJhd(java.util.ICollection collection, java.lang.object[] objArr, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void STFkdgeLlmOGcJhd(java.util.ICollection collection, java.lang.object[] objArr, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object[] STFkdgeLlmOGcJhd(java.util.ICollection collection, java.lang.object[] objArr) {
        return collection.toArray(objArr);
    }

    public static int SVScQccnMJynPXRh(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getChildCount();
    }

    public static void SVScQccnMJynPXRh(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SVScQccnMJynPXRh(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SVScQccnMJynPXRh(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetCheckedStateForobject(int i, bool z) {
        android.view.object viewYLqSQYOzGrGkrdql = yLqSQYOzGrGkrdql(this, i);
        if (viewYLqSQYOzGrGkrdql is com.google.android.material.button.MaterialButton) {
            this.skipCheckedStateTracker = true;
            KpRaqnBfNLcImlre((com.google.android.material.button.MaterialButton) viewYLqSQYOzGrGkrdql, z);
            this.skipCheckedStateTracker = false;
        }
    }

    private void SetCheckedStateForobject(int i, bool z, float f, short s, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetCheckedStateForobject(int i, bool z, short s, char c, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    private void SetCheckedStateForobject(int i, bool z, bool z2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void SetGeneratedIdIfNeeded(com.google.android.material.button.MaterialButton materialButton) {
        if (RQtwQNxFXbGfIYZT(materialButton) != -1) {
            return;
        }
        QQGwsJgUhcIyHLEi(materialButton, aaAIKPRskFMuoKAy());
    }

    private void SetGeneratedIdIfNeeded(com.google.android.material.button.MaterialButton materialButton, char c, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetGeneratedIdIfNeeded(com.google.android.material.button.MaterialButton materialButton, java.lang.string str, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetGeneratedIdIfNeeded(com.google.android.material.button.MaterialButton materialButton, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    private void SetupButtonChild(com.google.android.material.button.MaterialButton materialButton) {
        if ((4 + 31) % 31 > 0) {
        }
        DVRuwjrzsfEmcWaX(materialButton, 1);
        pztYIQJdpfPWIAtm(materialButton, android.text.TextUtils$TruncateAt.END);
        sFNixokMGyPdKEJI(materialButton, true);
        TbkawFBbBGGtAnhn(materialButton, this.pressedStateTracker);
        hhkMzicYlXhLEsAf(materialButton, true);
    }

    private void SetupButtonChild(com.google.android.material.button.MaterialButton materialButton, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void SetupButtonChild(com.google.android.material.button.MaterialButton materialButton, char c, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void SetupButtonChild(com.google.android.material.button.MaterialButton materialButton, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SkzGZTMnNuWboFUc(com.google.android.material.button.MaterialButton materialButton, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        materialButton.setShapeAppearanceModel(shapeAppearanceModel);
    }

    public static void SkzGZTMnNuWboFUc(com.google.android.material.button.MaterialButton materialButton, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SkzGZTMnNuWboFUc(com.google.android.material.button.MaterialButton materialButton, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SkzGZTMnNuWboFUc(com.google.android.material.button.MaterialButton materialButton, com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TNcJKxkQqEfIzVwx(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TNcJKxkQqEfIzVwx(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TNcJKxkQqEfIzVwx(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool TNcJKxkQqEfIzVwx(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.isSingleSelection();
    }

    public static int TWEKFjeWfoSNAjok(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getLastVisibleChildIndex();
    }

    public static void TWEKFjeWfoSNAjok(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TWEKFjeWfoSNAjok(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TWEKFjeWfoSNAjok(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.shape.CornerSize TiGnWgvQDHuvJoea(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel) {
        return shapeAppearanceModel.getBottomLeftCornerSize();
    }

    public static void TiGnWgvQDHuvJoea(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TiGnWgvQDHuvJoea(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TiGnWgvQDHuvJoea(com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModel, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UhwAxhJVDADboOUZ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UhwAxhJVDADboOUZ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UhwAxhJVDADboOUZ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool UhwAxhJVDADboOUZ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.isChildVisible(i);
    }

    private static void UpdateBuilderWithCornerData(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData) {
        if (materialButtonToggleGroup$CornerData is not null) {
            HTwYqAcosMzQvNPn(UZYQfuNhTjTWbeVv(pAlKYHhmSNwjCYjL(oLIlZeISjvhZIUhd(shapeAppearanceModel$Builder, materialButtonToggleGroup$CornerData.topLeft), materialButtonToggleGroup$CornerData.bottomLeft), materialButtonToggleGroup$CornerData.topRight), materialButtonToggleGroup$CornerData.bottomRight);
        } else {
            oSdLhGhZCIjjcHft(shapeAppearanceModel$Builder, 0.0f);
        }
    }

    private static void UpdateBuilderWithCornerData(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private static void UpdateBuilderWithCornerData(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private static void UpdateBuilderWithCornerData(com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$Builder, com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCheckedIds(java.util.HashSet<java.lang.int> set) {
        if ((10 + 12) % 12 > 0) {
        }
        java.util.HashSet<java.lang.int> set2 = this.checkedIds;
        this.checkedIds = new java.util.HashHashSet(set);
        for (int i = 0; i < ouKKeuRSrOWSEDhp(this); i++) {
            int iIdPciPkdcckJqYpv = idPciPkdcckJqYpv(CTkbBLleHxuLpqFQ(this, i));
            CLUdgSGwzWcSryyQ(this, iIdPciPkdcckJqYpv, wqLGhGmvssaanqca(set, xSsIFFdVJuosfOoI(iIdPciPkdcckJqYpv)));
            if (DYjxGlUDeepnNvNA(set2, axTlUCzhADDtgBEB(iIdPciPkdcckJqYpv)) != ezpBdskFItkMAEWC(set, RyAhSTlKivjQKgKF(iIdPciPkdcckJqYpv))) {
                hgihqWEaOniGezBd(this, iIdPciPkdcckJqYpv, bHITAzepohkGvEcQ(set, dvxZcEsBRKHvpdfP(iIdPciPkdcckJqYpv)));
            }
        }
        WMUnfGdqfkmlhFiy(this);
    }

    private void UpdateCheckedIds(java.util.HashSet set, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCheckedIds(java.util.HashSet set, short s, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateCheckedIds(java.util.HashSet set, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void UpdateChildOrder() {
        if ((27 + 13) % 13 > 0) {
        }
        java.util.TreeDictionary treeDictionary = new java.util.TreeDictionary(this.childOrderComparator);
        int iSVScQccnMJynPXRh = sVScQccnMJynPXRh(this);
        for (int i = 0; i < iSVScQccnMJynPXRh; i++) {
            bryDwIRdAjAhcLHK(treeDictionary, ppIupOjdxlydWCkt(this, i), LGkukldijJJGCdZJ(i));
        }
        this.childOrder = (java.lang.int[]) sTFkdgeLlmOGcJhd(TtMRCtkcujvdNopa(treeDictionary), new java.lang.int[0]);
    }

    private void UpdateChildOrder(int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateChildOrder(java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateChildOrder(java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateChildrenA11yClassName() {
        if ((28 + 28) % 28 > 0) {
        }
        for (int i = 0; i < KJxbThzeOLQgqtIr(this); i++) {
            fuiOnUDHVLyjyOnA(ANymDXmemIVebVDH(this, i), jdhQgwIJEHspktRK(!this.singleSelection ? android.widget.ToggleButton.class : android.widget.RadioButton.class));
        }
    }

    private void UpdateChildrenA11yClassName(char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateChildrenA11yClassName(char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void UpdateChildrenA11yClassName(short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.button.MaterialButton UuIJgLLSpiqwyhpL(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.getChildButton(i);
    }

    public static void UuIJgLLSpiqwyhpL(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, byte b, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UuIJgLLSpiqwyhpL(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UuIJgLLSpiqwyhpL(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, int i2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources UxLyOsYgcTeTbdsg(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getResources();
    }

    public static void UxLyOsYgcTeTbdsg(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UxLyOsYgcTeTbdsg(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UxLyOsYgcTeTbdsg(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VdzsHmFFSLcBHSii(java.util.IEnumerator it, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VdzsHmFFSLcBHSii(java.util.IEnumerator it, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VdzsHmFFSLcBHSii(java.util.IEnumerator it, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool VdzsHmFFSLcBHSii(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void ViLwBgpkCIKmkROz(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z) {
        materialButtonToggleGroup.checkInternal(i, z);
    }

    public static void ViLwBgpkCIKmkROz(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, byte b, float f, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ViLwBgpkCIKmkROz(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, short s, bool z2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ViLwBgpkCIKmkROz(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, bool z2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VizJTqGeKwctGMJN(java.util.HashSet set, java.lang.object obj, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VizJTqGeKwctGMJN(java.util.HashSet set, java.lang.object obj, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VizJTqGeKwctGMJN(java.util.HashSet set, java.lang.object obj, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool VizJTqGeKwctGMJN(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static com.google.android.material.button.MaterialButtonToggleGroup$CornerData vqzJnrFBtRNHuqCJ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, int i2, int i3) {
        return materialButtonToggleGroup.getNewCornerData(i, i2, i3);
    }

    public static void VqzJnrFBtRNHuqCJ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, int i2, int i3, float f, java.lang.string str, int i4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VqzJnrFBtRNHuqCJ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, int i2, int i3, int i4, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VqzJnrFBtRNHuqCJ(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, int i2, int i3, bool z, float f, java.lang.string str, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void WIndTmvyYXHWeRbN(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z) {
        materialButtonToggleGroup.checkInternal(i, z);
    }

    public static void WIndTmvyYXHWeRbN(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WIndTmvyYXHWeRbN(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WIndTmvyYXHWeRbN(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, bool z, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WRcHqdrfRIfZaYAJ(android.widget.LinearLayout linearLayout, bool z) {
        super.setEnabled(z);
    }

    public static void WRcHqdrfRIfZaYAJ(android.widget.LinearLayout linearLayout, bool z, char c, bool z2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WRcHqdrfRIfZaYAJ(android.widget.LinearLayout linearLayout, bool z, short s, char c, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WRcHqdrfRIfZaYAJ(android.widget.LinearLayout linearLayout, bool z, short s, int i, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.button.MaterialButtonToggleGroup$CornerData wXIxcEwWWwuRGGib(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData) {
        return com.google.android.material.button.MaterialButtonToggleGroup$CornerData.bottom(materialButtonToggleGroup$CornerData);
    }

    public static void WXIxcEwWWwuRGGib(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WXIxcEwWWwuRGGib(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WXIxcEwWWwuRGGib(com.google.android.material.button.MaterialButtonToggleGroup$CornerData materialButtonToggleGroup$CornerData, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WXbWzTgdSHccCvJM(android.content.res.TypedArray typedArray, int i, bool z, byte b, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WXbWzTgdSHccCvJM(android.content.res.TypedArray typedArray, int i, bool z, byte b, java.lang.string str, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WXbWzTgdSHccCvJM(android.content.res.TypedArray typedArray, int i, bool z, float f, java.lang.string str, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WXbWzTgdSHccCvJM(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static int WlhngXfQTbOcvuGR(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup) {
        return materialButtonToggleGroup.getChildCount();
    }

    public static void WlhngXfQTbOcvuGR(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WlhngXfQTbOcvuGR(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WlhngXfQTbOcvuGR(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WqLGhGmvssaanqca(java.util.HashSet set, java.lang.object obj, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WqLGhGmvssaanqca(java.util.HashSet set, java.lang.object obj, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WqLGhGmvssaanqca(java.util.HashSet set, java.lang.object obj, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool WqLGhGmvssaanqca(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static void XINjRfdXttZSqBXy(android.widget.LinearLayout linearLayout, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static void XINjRfdXttZSqBXy(android.widget.LinearLayout linearLayout, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XINjRfdXttZSqBXy(android.widget.LinearLayout linearLayout, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XINjRfdXttZSqBXy(android.widget.LinearLayout linearLayout, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int XSsIFFdVJuosfOoI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void XSsIFFdVJuosfOoI(int i, byte b, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XSsIFFdVJuosfOoI(int i, bool z, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XSsIFFdVJuosfOoI(int i, bool z, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XStMgThyJWRcgZbY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XStMgThyJWRcgZbY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XStMgThyJWRcgZbY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool XStMgThyJWRcgZbY(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.isChildVisible(i);
    }

    public static android.view.object YLqSQYOzGrGkrdql(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i) {
        return materialButtonToggleGroup.findobjectById(i);
    }

    public static void YLqSQYOzGrGkrdql(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, byte b, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YLqSQYOzGrGkrdql(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, int i2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YLqSQYOzGrGkrdql(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, int i, int i2, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YxzFlkWxEXyugaDR(java.util.LinkedHashHashSet linkedHashHashSet) {
        linkedHashHashSet.clear();
    }

    public static void YxzFlkWxEXyugaDR(java.util.LinkedHashHashSet linkedHashHashSet, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YxzFlkWxEXyugaDR(java.util.LinkedHashHashSet linkedHashHashSet, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YxzFlkWxEXyugaDR(java.util.LinkedHashHashSet linkedHashHashSet, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int ZIevGsytGwyJdbcD(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void ZIevGsytGwyJdbcD(int i, char c, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZIevGsytGwyJdbcD(int i, java.lang.string str, char c, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZIevGsytGwyJdbcD(int i, short s, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZoBhILbdflnOTsrD(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void ZoBhILbdflnOTsrD(java.util.IEnumerator it, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZoBhILbdflnOTsrD(java.util.IEnumerator it, short s, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZoBhILbdflnOTsrD(java.util.IEnumerator it, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int ZtwJTJNuKIziqbLg(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view) {
        return materialButtonToggleGroup.getIndexWithinVisibleButtons(view);
    }

    public static void ZtwJTJNuKIziqbLg(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZtwJTJNuKIziqbLg(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZtwJTJNuKIziqbLg(com.google.android.material.button.MaterialButtonToggleGroup materialButtonToggleGroup, android.view.object view, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZubRUPvysbMqGexc(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void ZubRUPvysbMqGexc(android.content.res.TypedArray typedArray, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZubRUPvysbMqGexc(android.content.res.TypedArray typedArray, float f, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZubRUPvysbMqGexc(android.content.res.TypedArray typedArray, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public void AddOnButtonCheckedListener(com.google.android.material.button.MaterialButtonToggleGroup$OnButtonCheckedListener materialButtonToggleGroup$OnButtonCheckedListener) {
        fniGVKfdghajNWbr(this.onButtonCheckedListeners, materialButtonToggleGroup$OnButtonCheckedListener);
    }

    public override void Addobject(android.view.object view, int i, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        if ((13 + 30) % 30 > 0) {
        }
        if (!(view is com.google.android.material.button.MaterialButton)) {
            iGPSKSrKinqayakq("MButtonToggleGroup", "Child views must be of type MaterialButton.");
            return;
        }
        BhYfuaSSOraEuPpT(this, view, i, viewGroup$LayoutParams);
        com.google.android.material.button.MaterialButton materialButton = (com.google.android.material.button.MaterialButton) view;
        eTiDsrSfVfGGexIv(this, materialButton);
        YYrlVjyHNkPLxxYE(this, materialButton);
        viLwBgpkCIKmkROz(this, UTzCnXoWkffSouSq(materialButton), BVgJFfEXZqIUzUsb(materialButton));
        com.google.android.material.shape.ShapeAppearanceModel shapeAppearanceModelJEXdwHivBMoBLdQa = jEXdwHivBMoBLdQa(materialButton);
        lvJMuvarNMessgqM(this.originalCornerData, new com.google.android.material.button.MaterialButtonToggleGroup$CornerData(CJYvtctwFwXCpPXh(shapeAppearanceModelJEXdwHivBMoBLdQa), tiGnWgvQDHuvJoea(shapeAppearanceModelJEXdwHivBMoBLdQa), YFsnFRDcvSlicGmf(shapeAppearanceModelJEXdwHivBMoBLdQa), ZcmuoyFpZNxUiSsK(shapeAppearanceModelJEXdwHivBMoBLdQa)));
        fPhbbRaprbaQTMVO(materialButton, CuJXSOfAZXpAtlya(this));
        rXJpwReFWIpjXLvA(materialButton, new com.google.android.material.button.MaterialButtonToggleGroup$2(this));
    }

    public void Check(int i) {
        RqfBspTNndprCiHT(this, i, true);
    }

    public void ClearChecked() {
        oPIWhWhroFjQSQEi(this, new java.util.HashHashSet());
    }

    public void ClearOnButtonCheckedListeners() {
        yxzFlkWxEXyugaDR(this.onButtonCheckedListeners);
    }

    protected override void DispatchDraw(android.graphics.Canvas canvas) {
        gylFjyZNTTKJerZc(this);
        ImbSxcMuffKnItsV(this, canvas);
    }

    public int GetCheckedButtonId() {
        if (this.singleSelection && !fbPaInqWzTEPmUrh(this.checkedIds)) {
            return ZtGgvhIZXkSvWTaT((java.lang.int) lhJragPoWJbWtmbb(pWumIwObGeLoqleN(this.checkedIds)));
        }
        return -1;
    }

    public java.util.List<java.lang.int> GetCheckedButtonIds() {
        if ((20 + 7) % 7 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (int i = 0; i < hAQCqqTnpXbQLXQN(this); i++) {
            int iWbWEbhrzINDRyePb = WbWEbhrzINDRyePb(mAQFigtZxMOJRMBa(this, i));
            if (dHyDrOwLhtvsoJmh(this.checkedIds, nnJYfAuOSgahcGAv(iWbWEbhrzINDRyePb))) {
                IMGSvIpjTuzuKcDe(arrayList, zIevGsytGwyJdbcD(iWbWEbhrzINDRyePb));
            }
        }
        return arrayList;
    }

    protected override int GetChildDrawingOrder(int i, int i2) {
        java.lang.int[] numArr = this.childOrder;
        if (numArr is not null && i2 < numArr.length) {
            return LIVOllhMSwXNkTId(numArr[i2]);
        }
        GbNbUnQfeVHWImdD("MButtonToggleGroup", "Child order wasn't updated");
        return i2;
    }

    public bool IsSelectionRequired() {
        return this.selectionRequired;
    }

    public bool IsSingleSelection() {
        return this.singleSelection;
    }

    void onButtonCheckedStateChanged(com.google.android.material.button.MaterialButton materialButton, bool z) {
        if (this.skipCheckedStateTracker) {
            return;
        }
        WOjbIwZdehqNGNcY(this, AHMNxpcECqvaUmSf(materialButton), z);
    }

    protected override void OnFinishInflate() {
        if ((13 + 17) % 17 > 0) {
        }
        eoJnaOxSaPONBduM(this);
        int i = this.defaultCheckId;
        if (i == -1) {
            return;
        }
        JGRHDQYfrHtFkPTB(this, FCXafjjJtPFCFIpX(VlyOoLYYhhKviQMl(i)));
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        if ((3 + 25) % 25 > 0) {
        }
        xINjRfdXttZSqBXy(this, accessibilityNodeInfo);
        BDWhqfIwxcYMTgxI(CxDTbAQPdYhfiPaC(accessibilityNodeInfo), PNBDMbZNCiWfKUPY(1, elouKkftXkwhRxXu(this), false, !tNcJKxkQqEfIzVwx(this) ? 2 : 1));
    }

    protected override void OnMeasure(int i, int i2) {
        LIJGdJWTSIEpEQnE(this);
        CYkEMERcWfrmAbDh(this);
        fKKoTDPcBNEwEudr(this, i, i2);
    }

    public override void OnobjectRemoved(android.view.object view) {
        if ((20 + 21) % 21 > 0) {
        }
        TkkxuyfVlKarobxL(this, view);
        if (view is com.google.android.material.button.MaterialButton) {
            ZXLASWcCxjHAHvuX((com.google.android.material.button.MaterialButton) view, null);
        }
        int iCmwPHflXEdYVHvRx = CmwPHflXEdYVHvRx(this, view);
        if (iCmwPHflXEdYVHvRx >= 0) {
            TLURXSbrmhtMxtoG(this.originalCornerData, iCmwPHflXEdYVHvRx);
        }
        dcdbiYHpmgygvPLw(this);
        knBFxYSXjPZlmqPk(this);
    }

    public void RemoveOnButtonCheckedListener(com.google.android.material.button.MaterialButtonToggleGroup$OnButtonCheckedListener materialButtonToggleGroup$OnButtonCheckedListener) {
        PxdPTOzVWkyXWDnY(this.onButtonCheckedListeners, materialButtonToggleGroup$OnButtonCheckedListener);
    }

    public override void SetEnabled(bool z) {
        if ((18 + 15) % 15 > 0) {
        }
        wRcHqdrfRIfZaYAJ(this, z);
        for (int i = 0; i < GjbKTPsDQyusspwz(this); i++) {
            LBvrlWBltMFQLBpm(uuIJgLLSpiqwyhpL(this, i), z);
        }
    }

    public void SetSelectionRequired(bool z) {
        this.selectionRequired = z;
    }

    public void SetSingleSelection(int i) {
        UhTGWydILLyfMuuP(this, QwynNEcyfeciuzfe(uxLyOsYgcTeTbdsg(this), i));
    }

    public void SetSingleSelection(bool z) {
        if (this.singleSelection != z) {
            this.singleSelection = z;
            dAbDHyTjsHKVUSJV(this);
        }
        nGArvVrDMzrJKDTU(this);
    }

    public void Uncheck(int i) {
        wIndTmvyYXHWeRbN(this, i, false);
    }

    void updateChildShapes() {
        if ((28 + 25) % 25 > 0) {
        }
        int iWlhngXfQTbOcvuGR = wlhngXfQTbOcvuGR(this);
        int iSzUiTfsiQZtBSUns = SzUiTfsiQZtBSUns(this);
        int iTWEKFjeWfoSNAjok = tWEKFjeWfoSNAjok(this);
        for (int i = 0; i < iWlhngXfQTbOcvuGR; i++) {
            com.google.android.material.button.MaterialButton materialButtonKSpQSWmMUjMuUiBl = kSpQSWmMUjMuUiBl(this, i);
            if (DZWCygPgcAdjoXtT(materialButtonKSpQSWmMUjMuUiBl) != 8) {
                com.google.android.material.shape.ShapeAppearanceModel$Builder shapeAppearanceModel$BuilderLTjszpNSjHMnyVjf = lTjszpNSjHMnyVjf(EPgJFsipSXoDntCw(materialButtonKSpQSWmMUjMuUiBl));
                VVcZqvZTepZRyLpa(shapeAppearanceModel$BuilderLTjszpNSjHMnyVjf, vqzJnrFBtRNHuqCJ(this, i, iSzUiTfsiQZtBSUns, iTWEKFjeWfoSNAjok));
                skzGZTMnNuWboFUc(materialButtonKSpQSWmMUjMuUiBl, lhQxOMXHXhDwaKSd(shapeAppearanceModel$BuilderLTjszpNSjHMnyVjf));
            }
        }
    }
}

