namespace WillowMaze.Wasm.Decompiled;


public class ChipGroup : com.google.android.material.internal.FlowLayout {
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_MaterialComponents_ChipGroup;
    private readonly com.google.android.material.internal.CheckableGroup<com.google.android.material.chip.Chip> checkableGroup;
    private int chipSpacingHorizontal;
    private int chipSpacingVertical;
    private readonly int defaultCheckedId;
    private com.google.android.material.chip.ChipGroup$OnCheckedStateChangeListener onCheckedStateChangeListener;
    private readonly com.google.android.material.chip.ChipGroup$PassThroughHierarchyChangeListener passThroughListener;

    public ChipGroup(android.content.object context) {
        this(context, null);
    }

    public ChipGroup(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.chipGroupStyle);
    }

    public ChipGroup(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        if ((5 + 31) % 31 > 0) {
        }
        int i2 = DEF_STYLE_RES;
        super(HucHbhZsPpBOWcyb(context, attributeHashSet, i, i2), attributeHashSet, i);
        com.google.android.material.internal.CheckableGroup<com.google.android.material.chip.Chip> checkableGroup = new com.google.android.material.internal.CheckableGroup<>();
        this.checkableGroup = checkableGroup;
        com.google.android.material.chip.ChipGroup$PassThroughHierarchyChangeListener chipGroup$PassThroughHierarchyChangeListener = new com.google.android.material.chip.ChipGroup$PassThroughHierarchyChangeListener(this, null);
        this.passThroughListener = chipGroup$PassThroughHierarchyChangeListener;
        android.content.res.TypedArray typedArrayYIYMycIuZJqlycGf = yIYMycIuZJqlycGf(mHxjlBArkdCGxbRP(this), attributeHashSet, com.google.android.material.R$styleable.ChipGroup, i, i2, new int[0]);
        int iKaVEetGhzVcCVXBO = kaVEetGhzVcCVXBO(typedArrayYIYMycIuZJqlycGf, com.google.android.material.R$styleable.ChipGroup_chipSpacing, 0);
        uGoSezBCqmhkEskG(this, TSXdWKeRATybraSb(typedArrayYIYMycIuZJqlycGf, com.google.android.material.R$styleable.ChipGroup_chipSpacingHorizontal, iKaVEetGhzVcCVXBO));
        wAdBHiaYhyxUwAAE(this, mWOJgxJZFfDaWuSy(typedArrayYIYMycIuZJqlycGf, com.google.android.material.R$styleable.ChipGroup_chipSpacingVertical, iKaVEetGhzVcCVXBO));
        jFSACfrgbPjVRLwM(this, vnXhVBfNlldeBvLg(typedArrayYIYMycIuZJqlycGf, com.google.android.material.R$styleable.ChipGroup_singleLine, false));
        rMJwmsRaFwsaTGnM(this, odwioixGCiNaHwlG(typedArrayYIYMycIuZJqlycGf, com.google.android.material.R$styleable.ChipGroup_singleSelection, false));
        YIayUPsNiztMLKms(this, HghZhqcGTngOvhly(typedArrayYIYMycIuZJqlycGf, com.google.android.material.R$styleable.ChipGroup_selectionRequired, false));
        this.defaultCheckedId = hAvtbeWFizOPmXpo(typedArrayYIYMycIuZJqlycGf, com.google.android.material.R$styleable.ChipGroup_checkedChip, -1);
        PNHXEbSnNsynzXkY(typedArrayYIYMycIuZJqlycGf);
        rIMDoTvfJwvRCHIa(checkableGroup, new com.google.android.material.chip.ChipGroup$1(this));
        hNFCEcRmHiyZjmfV(this, chipGroup$PassThroughHierarchyChangeListener);
        OIAHmVsOWfjinqgR(this, 1);
    }

    public static int AePpEMztCFAMJXQv(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.getChildCount();
    }

    public static void AePpEMztCFAMJXQv(com.google.android.material.chip.ChipGroup chipGroup, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AePpEMztCFAMJXQv(com.google.android.material.chip.ChipGroup chipGroup, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AePpEMztCFAMJXQv(com.google.android.material.chip.ChipGroup chipGroup, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources BLsWugWbasyXvBCj(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.getResources();
    }

    public static void BLsWugWbasyXvBCj(com.google.android.material.chip.ChipGroup chipGroup, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BLsWugWbasyXvBCj(com.google.android.material.chip.ChipGroup chipGroup, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BLsWugWbasyXvBCj(com.google.android.material.chip.ChipGroup chipGroup, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int EYnymdJJLGFXmCJB(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static void EYnymdJJLGFXmCJB(android.content.res.Resources resources, int i, char c, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void EYnymdJJLGFXmCJB(android.content.res.Resources resources, int i, java.lang.string str, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EYnymdJJLGFXmCJB(android.content.res.Resources resources, int i, java.lang.string str, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources EzacrejKfdoghoGt(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.getResources();
    }

    public static void EzacrejKfdoghoGt(com.google.android.material.chip.ChipGroup chipGroup, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EzacrejKfdoghoGt(com.google.android.material.chip.ChipGroup chipGroup, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EzacrejKfdoghoGt(com.google.android.material.chip.ChipGroup chipGroup, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FdbvNQAHSmONrPUy(com.google.android.material.internal.FlowLayout flowLayout, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FdbvNQAHSmONrPUy(com.google.android.material.internal.FlowLayout flowLayout, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FdbvNQAHSmONrPUy(com.google.android.material.internal.FlowLayout flowLayout, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool FdbvNQAHSmONrPUy(com.google.android.material.internal.FlowLayout flowLayout) {
        return super.isSingleLine();
    }

    public static void GdryfoHMewqjaZNX(com.google.android.material.internal.CheckableGroup checkableGroup, int i) {
        checkableGroup.check(i);
    }

    public static void GdryfoHMewqjaZNX(com.google.android.material.internal.CheckableGroup checkableGroup, int i, char c, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GdryfoHMewqjaZNX(com.google.android.material.internal.CheckableGroup checkableGroup, int i, int i2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GdryfoHMewqjaZNX(com.google.android.material.internal.CheckableGroup checkableGroup, int i, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GjjQtvUnBEuBJAsl(com.google.android.material.chip.ChipGroup chipGroup, com.google.android.material.chip.ChipGroup$OnCheckedStateChangeListener chipGroup$OnCheckedStateChangeListener) {
        chipGroup.setOnCheckedStateChangeListener(chipGroup$OnCheckedStateChangeListener);
    }

    public static void GjjQtvUnBEuBJAsl(com.google.android.material.chip.ChipGroup chipGroup, com.google.android.material.chip.ChipGroup$OnCheckedStateChangeListener chipGroup$OnCheckedStateChangeListener, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GjjQtvUnBEuBJAsl(com.google.android.material.chip.ChipGroup chipGroup, com.google.android.material.chip.ChipGroup$OnCheckedStateChangeListener chipGroup$OnCheckedStateChangeListener, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GjjQtvUnBEuBJAsl(com.google.android.material.chip.ChipGroup chipGroup, com.google.android.material.chip.ChipGroup$OnCheckedStateChangeListener chipGroup$OnCheckedStateChangeListener, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HghZhqcGTngOvhly(android.content.res.TypedArray typedArray, int i, bool z, int i2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HghZhqcGTngOvhly(android.content.res.TypedArray typedArray, int i, bool z, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HghZhqcGTngOvhly(android.content.res.TypedArray typedArray, int i, bool z, short s, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool HghZhqcGTngOvhly(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static android.content.object HucHbhZsPpBOWcyb(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void HucHbhZsPpBOWcyb(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HucHbhZsPpBOWcyb(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HucHbhZsPpBOWcyb(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources IEUJIaEgsUwWCqDy(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.getResources();
    }

    public static void IEUJIaEgsUwWCqDy(com.google.android.material.chip.ChipGroup chipGroup, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IEUJIaEgsUwWCqDy(com.google.android.material.chip.ChipGroup chipGroup, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IEUJIaEgsUwWCqDy(com.google.android.material.chip.ChipGroup chipGroup, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KZVURlLsqqOYhNVn(com.google.android.material.chip.ChipGroup chipGroup, bool z) {
        chipGroup.setSingleLine(z);
    }

    public static void KZVURlLsqqOYhNVn(com.google.android.material.chip.ChipGroup chipGroup, bool z, char c, java.lang.string str, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KZVURlLsqqOYhNVn(com.google.android.material.chip.ChipGroup chipGroup, bool z, int i, char c, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KZVURlLsqqOYhNVn(com.google.android.material.chip.ChipGroup chipGroup, bool z, int i, java.lang.string str, char c, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void MDqIcAppKrrsIEbp(com.google.android.material.chip.ChipGroup chipGroup, int i) {
        chipGroup.setChipSpacing(i);
    }

    public static void MDqIcAppKrrsIEbp(com.google.android.material.chip.ChipGroup chipGroup, int i, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MDqIcAppKrrsIEbp(com.google.android.material.chip.ChipGroup chipGroup, int i, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MDqIcAppKrrsIEbp(com.google.android.material.chip.ChipGroup chipGroup, int i, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MizkMLbRJvWNjhzU(com.google.android.material.chip.ChipGroup chipGroup, int i, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MizkMLbRJvWNjhzU(com.google.android.material.chip.ChipGroup chipGroup, int i, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MizkMLbRJvWNjhzU(com.google.android.material.chip.ChipGroup chipGroup, int i, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MizkMLbRJvWNjhzU(com.google.android.material.chip.ChipGroup chipGroup, int i) {
        return chipGroup.isChildVisible(i);
    }

    public static android.view.object MpddDBkANnFYKiwG(com.google.android.material.chip.ChipGroup chipGroup, int i) {
        return chipGroup.getChildAt(i);
    }

    public static void MpddDBkANnFYKiwG(com.google.android.material.chip.ChipGroup chipGroup, int i, char c, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MpddDBkANnFYKiwG(com.google.android.material.chip.ChipGroup chipGroup, int i, char c, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void MpddDBkANnFYKiwG(com.google.android.material.chip.ChipGroup chipGroup, int i, int i2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OIAHmVsOWfjinqgR(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void OIAHmVsOWfjinqgR(android.view.object view, int i, byte b, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OIAHmVsOWfjinqgR(android.view.object view, int i, float f, int i2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OIAHmVsOWfjinqgR(android.view.object view, int i, float f, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OIdQxjHgwhszTrGg(com.google.android.material.chip.ChipGroup chipGroup, bool z) {
        chipGroup.setSingleSelection(z);
    }

    public static void OIdQxjHgwhszTrGg(com.google.android.material.chip.ChipGroup chipGroup, bool z, char c, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OIdQxjHgwhszTrGg(com.google.android.material.chip.ChipGroup chipGroup, bool z, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OIdQxjHgwhszTrGg(com.google.android.material.chip.ChipGroup chipGroup, bool z, java.lang.string str, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PNHXEbSnNsynzXkY(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void PNHXEbSnNsynzXkY(android.content.res.TypedArray typedArray, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PNHXEbSnNsynzXkY(android.content.res.TypedArray typedArray, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PNHXEbSnNsynzXkY(android.content.res.TypedArray typedArray, java.lang.string str, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PZAMLtURTeJPUZcF(com.google.android.material.chip.ChipGroup chipGroup, int i) {
        chipGroup.setChipSpacingHorizontal(i);
    }

    public static void PZAMLtURTeJPUZcF(com.google.android.material.chip.ChipGroup chipGroup, int i, char c, java.lang.string str, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PZAMLtURTeJPUZcF(com.google.android.material.chip.ChipGroup chipGroup, int i, int i2, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PZAMLtURTeJPUZcF(com.google.android.material.chip.ChipGroup chipGroup, int i, short s, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object PjEIJEMAyzNlXxSh(com.google.android.material.chip.ChipGroup chipGroup, int i) {
        return chipGroup.getChildAt(i);
    }

    public static void PjEIJEMAyzNlXxSh(com.google.android.material.chip.ChipGroup chipGroup, int i, byte b, int i2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PjEIJEMAyzNlXxSh(com.google.android.material.chip.ChipGroup chipGroup, int i, int i2, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PjEIJEMAyzNlXxSh(com.google.android.material.chip.ChipGroup chipGroup, int i, short s, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int QHPbWClDTdClgJgO(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.getRowCount();
    }

    public static void QHPbWClDTdClgJgO(com.google.android.material.chip.ChipGroup chipGroup, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QHPbWClDTdClgJgO(com.google.android.material.chip.ChipGroup chipGroup, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QHPbWClDTdClgJgO(com.google.android.material.chip.ChipGroup chipGroup, bool z, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QodbThoXdzWrXPER(com.google.android.material.chip.ChipGroup chipGroup, int i) {
        chipGroup.setChipSpacingHorizontal(i);
    }

    public static void QodbThoXdzWrXPER(com.google.android.material.chip.ChipGroup chipGroup, int i, byte b, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QodbThoXdzWrXPER(com.google.android.material.chip.ChipGroup chipGroup, int i, char c, byte b, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QodbThoXdzWrXPER(com.google.android.material.chip.ChipGroup chipGroup, int i, bool z, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QxEUjwJzuKKbaUaS(com.google.android.material.chip.ChipGroup chipGroup, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QxEUjwJzuKKbaUaS(com.google.android.material.chip.ChipGroup chipGroup, float f, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QxEUjwJzuKKbaUaS(com.google.android.material.chip.ChipGroup chipGroup, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool QxEUjwJzuKKbaUaS(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.isSingleSelection();
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat RMqTjDcPMLxfkzbU(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat.wrap(accessibilityNodeInfo);
    }

    public static void RMqTjDcPMLxfkzbU(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RMqTjDcPMLxfkzbU(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RMqTjDcPMLxfkzbU(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int RrzgHoubPcZtzaXS(com.google.android.material.internal.CheckableGroup checkableGroup) {
        return checkableGroup.getSingleCheckedId();
    }

    public static void RrzgHoubPcZtzaXS(com.google.android.material.internal.CheckableGroup checkableGroup, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RrzgHoubPcZtzaXS(com.google.android.material.internal.CheckableGroup checkableGroup, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RrzgHoubPcZtzaXS(com.google.android.material.internal.CheckableGroup checkableGroup, bool z, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RuAYJEuATmavtAlD(com.google.android.material.internal.FlowLayout flowLayout, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        super.onInitializeAccessibilityNodeInfo(accessibilityNodeInfo);
    }

    public static void RuAYJEuATmavtAlD(com.google.android.material.internal.FlowLayout flowLayout, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RuAYJEuATmavtAlD(com.google.android.material.internal.FlowLayout flowLayout, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RuAYJEuATmavtAlD(com.google.android.material.internal.FlowLayout flowLayout, android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SCHKUzcXUmRNyunF(com.google.android.material.internal.FlowLayout flowLayout, bool z) {
        super.setSingleLine(z);
    }

    public static void SCHKUzcXUmRNyunF(com.google.android.material.internal.FlowLayout flowLayout, bool z, java.lang.string str, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SCHKUzcXUmRNyunF(com.google.android.material.internal.FlowLayout flowLayout, bool z, short s, char c, java.lang.string str, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void SCHKUzcXUmRNyunF(com.google.android.material.internal.FlowLayout flowLayout, bool z, bool z2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List SJLYxSFsgtyQyjqF(com.google.android.material.internal.CheckableGroup checkableGroup, android.view.objectGroup viewGroup) {
        return checkableGroup.getCheckedIdsSortedByChildOrder(viewGroup);
    }

    public static void SJLYxSFsgtyQyjqF(com.google.android.material.internal.CheckableGroup checkableGroup, android.view.objectGroup viewGroup, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SJLYxSFsgtyQyjqF(com.google.android.material.internal.CheckableGroup checkableGroup, android.view.objectGroup viewGroup, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SJLYxSFsgtyQyjqF(com.google.android.material.internal.CheckableGroup checkableGroup, android.view.objectGroup viewGroup, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int TSXdWKeRATybraSb(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void TSXdWKeRATybraSb(android.content.res.TypedArray typedArray, int i, int i2, char c, bool z, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TSXdWKeRATybraSb(android.content.res.TypedArray typedArray, int i, int i2, int i3, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TSXdWKeRATybraSb(android.content.res.TypedArray typedArray, int i, int i2, bool z, byte b, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources TTZYavIewdFkgPnw(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.getResources();
    }

    public static void TTZYavIewdFkgPnw(com.google.android.material.chip.ChipGroup chipGroup, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TTZYavIewdFkgPnw(com.google.android.material.chip.ChipGroup chipGroup, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TTZYavIewdFkgPnw(com.google.android.material.chip.ChipGroup chipGroup, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TfJRlUeNWSoXpgVn(com.google.android.material.chip.ChipGroup chipGroup, int i) {
        chipGroup.setChipSpacingVertical(i);
    }

    public static void TfJRlUeNWSoXpgVn(com.google.android.material.chip.ChipGroup chipGroup, int i, char c, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TfJRlUeNWSoXpgVn(com.google.android.material.chip.ChipGroup chipGroup, int i, char c, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TfJRlUeNWSoXpgVn(com.google.android.material.chip.ChipGroup chipGroup, int i, float f, int i2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UsuGfZvhDBQVTGXg(com.google.android.material.internal.CheckableGroup checkableGroup, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UsuGfZvhDBQVTGXg(com.google.android.material.internal.CheckableGroup checkableGroup, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UsuGfZvhDBQVTGXg(com.google.android.material.internal.CheckableGroup checkableGroup, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool UsuGfZvhDBQVTGXg(com.google.android.material.internal.CheckableGroup checkableGroup) {
        return checkableGroup.isSingleSelection();
    }

    public static void YIayUPsNiztMLKms(com.google.android.material.chip.ChipGroup chipGroup, bool z) {
        chipGroup.setSelectionRequired(z);
    }

    public static void YIayUPsNiztMLKms(com.google.android.material.chip.ChipGroup chipGroup, bool z, char c, float f, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YIayUPsNiztMLKms(com.google.android.material.chip.ChipGroup chipGroup, bool z, float f, char c, bool z2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YIayUPsNiztMLKms(com.google.android.material.chip.ChipGroup chipGroup, bool z, float f, bool z2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat YfiSYPWLbOqgfOfo(int i, int i2, bool z, int i3) {
        return androidx.core.view.accessibility.AccessibilityNodeInfoCompat$ICollectionInfoCompat.obtain(i, i2, z, i3);
    }

    public static void YfiSYPWLbOqgfOfo(int i, int i2, bool z, int i3, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YfiSYPWLbOqgfOfo(int i, int i2, bool z, int i3, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YfiSYPWLbOqgfOfo(int i, int i2, bool z, int i3, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YwuERkDTEioLclAM(android.content.res.Resources resources, int i, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YwuERkDTEioLclAM(android.content.res.Resources resources, int i, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YwuERkDTEioLclAM(android.content.res.Resources resources, int i, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool YwuERkDTEioLclAM(android.content.res.Resources resources, int i) {
        return resources.getbool(i);
    }

    static com.google.android.material.chip.ChipGroup$OnCheckedStateChangeListener access$100(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.onCheckedStateChangeListener;
    }

    static void access$100(com.google.android.material.chip.ChipGroup chipGroup, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.chip.ChipGroup chipGroup, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.chip.ChipGroup chipGroup, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    static com.google.android.material.internal.CheckableGroup access$200(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.checkableGroup;
    }

    static void access$200(com.google.android.material.chip.ChipGroup chipGroup, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.chip.ChipGroup chipGroup, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$200(com.google.android.material.chip.ChipGroup chipGroup, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DNjqqAMhVUsgxqqc(com.google.android.material.chip.ChipGroup chipGroup, int i) {
        chipGroup.setLineSpacing(i);
    }

    public static void DNjqqAMhVUsgxqqc(com.google.android.material.chip.ChipGroup chipGroup, int i, int i2, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DNjqqAMhVUsgxqqc(com.google.android.material.chip.ChipGroup chipGroup, int i, short s, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DNjqqAMhVUsgxqqc(com.google.android.material.chip.ChipGroup chipGroup, int i, short s, int i2, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DOVdIcAjLhTHqjMV(com.google.android.material.chip.ChipGroup chipGroup, int i) {
        chipGroup.setItemSpacing(i);
    }

    public static void DOVdIcAjLhTHqjMV(com.google.android.material.chip.ChipGroup chipGroup, int i, byte b, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DOVdIcAjLhTHqjMV(com.google.android.material.chip.ChipGroup chipGroup, int i, float f, byte b, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void DOVdIcAjLhTHqjMV(com.google.android.material.chip.ChipGroup chipGroup, int i, int i2, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DUyMOOUPVbqxhfZs(com.google.android.material.chip.ChipGroup chipGroup) {
        chipGroup.requestLayout();
    }

    public static void DUyMOOUPVbqxhfZs(com.google.android.material.chip.ChipGroup chipGroup, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DUyMOOUPVbqxhfZs(com.google.android.material.chip.ChipGroup chipGroup, int i, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DUyMOOUPVbqxhfZs(com.google.android.material.chip.ChipGroup chipGroup, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int DncDklnIQSAuaGFk(android.view.object view) {
        return view.getVisibility();
    }

    public static void DncDklnIQSAuaGFk(android.view.object view, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DncDklnIQSAuaGFk(android.view.object view, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DncDklnIQSAuaGFk(android.view.object view, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources EXysEWggegyppRxU(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.getResources();
    }

    public static void EXysEWggegyppRxU(com.google.android.material.chip.ChipGroup chipGroup, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EXysEWggegyppRxU(com.google.android.material.chip.ChipGroup chipGroup, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EXysEWggegyppRxU(com.google.android.material.chip.ChipGroup chipGroup, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EcFEtZOxTcJVjrvP(com.google.android.material.internal.CheckableGroup checkableGroup, int i) {
        checkableGroup.check(i);
    }

    public static void EcFEtZOxTcJVjrvP(com.google.android.material.internal.CheckableGroup checkableGroup, int i, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EcFEtZOxTcJVjrvP(com.google.android.material.internal.CheckableGroup checkableGroup, int i, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EcFEtZOxTcJVjrvP(com.google.android.material.internal.CheckableGroup checkableGroup, int i, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ElABKrDmNVcRsRXr(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.getVisibleChipCount();
    }

    public static void ElABKrDmNVcRsRXr(com.google.android.material.chip.ChipGroup chipGroup, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ElABKrDmNVcRsRXr(com.google.android.material.chip.ChipGroup chipGroup, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ElABKrDmNVcRsRXr(com.google.android.material.chip.ChipGroup chipGroup, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FLjnvWILoUxLhCqS(com.google.android.material.chip.ChipGroup chipGroup, com.google.android.material.chip.ChipGroup$OnCheckedStateChangeListener chipGroup$OnCheckedStateChangeListener) {
        chipGroup.setOnCheckedStateChangeListener(chipGroup$OnCheckedStateChangeListener);
    }

    public static void FLjnvWILoUxLhCqS(com.google.android.material.chip.ChipGroup chipGroup, com.google.android.material.chip.ChipGroup$OnCheckedStateChangeListener chipGroup$OnCheckedStateChangeListener, short s, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FLjnvWILoUxLhCqS(com.google.android.material.chip.ChipGroup chipGroup, com.google.android.material.chip.ChipGroup$OnCheckedStateChangeListener chipGroup$OnCheckedStateChangeListener, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FLjnvWILoUxLhCqS(com.google.android.material.chip.ChipGroup chipGroup, com.google.android.material.chip.ChipGroup$OnCheckedStateChangeListener chipGroup$OnCheckedStateChangeListener, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GQIqDgBppYMcTBIu(com.google.android.material.chip.ChipGroup chipGroup) {
        chipGroup.requestLayout();
    }

    public static void GQIqDgBppYMcTBIu(com.google.android.material.chip.ChipGroup chipGroup, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GQIqDgBppYMcTBIu(com.google.android.material.chip.ChipGroup chipGroup, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GQIqDgBppYMcTBIu(com.google.android.material.chip.ChipGroup chipGroup, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    private int GetVisibleChipCount() {
        if ((20 + 31) % 31 > 0) {
        }
        int i = 0;
        for (int i2 = 0; i2 < AePpEMztCFAMJXQv(this); i2++) {
            if ((mRdGnxYPaqLqHfhg(this, i2) instanceof com.google.android.material.chip.Chip) && MizkMLbRJvWNjhzU(this, i2)) {
                i++;
            }
        }
        return i;
    }

    private void GetVisibleChipCount(byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetVisibleChipCount(int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void GetVisibleChipCount(int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int HAvtbeWFizOPmXpo(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void HAvtbeWFizOPmXpo(android.content.res.TypedArray typedArray, int i, int i2, char c, short s, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HAvtbeWFizOPmXpo(android.content.res.TypedArray typedArray, int i, int i2, float f, char c, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void HAvtbeWFizOPmXpo(android.content.res.TypedArray typedArray, int i, int i2, short s, char c, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static int HNCHdJxEGMeNlPbY(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static void HNCHdJxEGMeNlPbY(android.content.res.Resources resources, int i, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HNCHdJxEGMeNlPbY(android.content.res.Resources resources, int i, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HNCHdJxEGMeNlPbY(android.content.res.Resources resources, int i, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HNFCEcRmHiyZjmfV(com.google.android.material.internal.FlowLayout flowLayout, android.view.objectGroup$OnHierarchyChangeListener viewGroup$OnHierarchyChangeListener) {
        super.setOnHierarchyChangeListener(viewGroup$OnHierarchyChangeListener);
    }

    public static void HNFCEcRmHiyZjmfV(com.google.android.material.internal.FlowLayout flowLayout, android.view.objectGroup$OnHierarchyChangeListener viewGroup$OnHierarchyChangeListener, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HNFCEcRmHiyZjmfV(com.google.android.material.internal.FlowLayout flowLayout, android.view.objectGroup$OnHierarchyChangeListener viewGroup$OnHierarchyChangeListener, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HNFCEcRmHiyZjmfV(com.google.android.material.internal.FlowLayout flowLayout, android.view.objectGroup$OnHierarchyChangeListener viewGroup$OnHierarchyChangeListener, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private void IsChildVisible(int i, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private void IsChildVisible(int i, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void IsChildVisible(int i, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private bool IsChildVisible(int i) {
        return dncDklnIQSAuaGFk(MpddDBkANnFYKiwG(this, i)) == 0;
    }

    public static void JFSACfrgbPjVRLwM(com.google.android.material.chip.ChipGroup chipGroup, bool z) {
        chipGroup.setSingleLine(z);
    }

    public static void JFSACfrgbPjVRLwM(com.google.android.material.chip.ChipGroup chipGroup, bool z, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JFSACfrgbPjVRLwM(com.google.android.material.chip.ChipGroup chipGroup, bool z, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JFSACfrgbPjVRLwM(com.google.android.material.chip.ChipGroup chipGroup, bool z, short s, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JfzLyjHWsGDtIhbt(com.google.android.material.internal.CheckableGroup checkableGroup, bool z) {
        checkableGroup.setSingleSelection(z);
    }

    public static void JfzLyjHWsGDtIhbt(com.google.android.material.internal.CheckableGroup checkableGroup, bool z, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JfzLyjHWsGDtIhbt(com.google.android.material.internal.CheckableGroup checkableGroup, bool z, java.lang.string str, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JfzLyjHWsGDtIhbt(com.google.android.material.internal.CheckableGroup checkableGroup, bool z, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int KaVEetGhzVcCVXBO(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void KaVEetGhzVcCVXBO(android.content.res.TypedArray typedArray, int i, int i2, byte b, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KaVEetGhzVcCVXBO(android.content.res.TypedArray typedArray, int i, int i2, int i3, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KaVEetGhzVcCVXBO(android.content.res.TypedArray typedArray, int i, int i2, short s, byte b, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void LaDDJtFUMFPAnyQs(com.google.android.material.internal.CheckableGroup checkableGroup, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LaDDJtFUMFPAnyQs(com.google.android.material.internal.CheckableGroup checkableGroup, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LaDDJtFUMFPAnyQs(com.google.android.material.internal.CheckableGroup checkableGroup, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool LaDDJtFUMFPAnyQs(com.google.android.material.internal.CheckableGroup checkableGroup) {
        return checkableGroup.isSelectionRequired();
    }

    public static int MBeppuoyLNSPhRtT(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.getChildCount();
    }

    public static void MBeppuoyLNSPhRtT(com.google.android.material.chip.ChipGroup chipGroup, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MBeppuoyLNSPhRtT(com.google.android.material.chip.ChipGroup chipGroup, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MBeppuoyLNSPhRtT(com.google.android.material.chip.ChipGroup chipGroup, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object MHxjlBArkdCGxbRP(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.getobject();
    }

    public static void MHxjlBArkdCGxbRP(com.google.android.material.chip.ChipGroup chipGroup, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MHxjlBArkdCGxbRP(com.google.android.material.chip.ChipGroup chipGroup, int i, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MHxjlBArkdCGxbRP(com.google.android.material.chip.ChipGroup chipGroup, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object MRdGnxYPaqLqHfhg(com.google.android.material.chip.ChipGroup chipGroup, int i) {
        return chipGroup.getChildAt(i);
    }

    public static void MRdGnxYPaqLqHfhg(com.google.android.material.chip.ChipGroup chipGroup, int i, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MRdGnxYPaqLqHfhg(com.google.android.material.chip.ChipGroup chipGroup, int i, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MRdGnxYPaqLqHfhg(com.google.android.material.chip.ChipGroup chipGroup, int i, bool z, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static int MWOJgxJZFfDaWuSy(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getDimensionPixelOffset(i, i2);
    }

    public static void MWOJgxJZFfDaWuSy(android.content.res.TypedArray typedArray, int i, int i2, byte b, int i3, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MWOJgxJZFfDaWuSy(android.content.res.TypedArray typedArray, int i, int i2, byte b, java.lang.string str, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MWOJgxJZFfDaWuSy(android.content.res.TypedArray typedArray, int i, int i2, bool z, java.lang.string str, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OdwioixGCiNaHwlG(android.content.res.TypedArray typedArray, int i, bool z, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OdwioixGCiNaHwlG(android.content.res.TypedArray typedArray, int i, bool z, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OdwioixGCiNaHwlG(android.content.res.TypedArray typedArray, int i, bool z, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool OdwioixGCiNaHwlG(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void PKDbLWxwylbsCAgO(com.google.android.material.internal.CheckableGroup checkableGroup) {
        checkableGroup.clearCheck();
    }

    public static void PKDbLWxwylbsCAgO(com.google.android.material.internal.CheckableGroup checkableGroup, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PKDbLWxwylbsCAgO(com.google.android.material.internal.CheckableGroup checkableGroup, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PKDbLWxwylbsCAgO(com.google.android.material.internal.CheckableGroup checkableGroup, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QHxFIyNAPnyAIArl(android.content.res.Resources resources, int i) {
        return resources.getDimensionPixelOffset(i);
    }

    public static void QHxFIyNAPnyAIArl(android.content.res.Resources resources, int i, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QHxFIyNAPnyAIArl(android.content.res.Resources resources, int i, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QHxFIyNAPnyAIArl(android.content.res.Resources resources, int i, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QStCIdqMzEGcsHUY(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj) {
        accessibilityNodeInfoCompat.setICollectionInfo(obj);
    }

    public static void QStCIdqMzEGcsHUY(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QStCIdqMzEGcsHUY(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QStCIdqMzEGcsHUY(androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat, java.lang.object obj, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RIMDoTvfJwvRCHIa(com.google.android.material.internal.CheckableGroup checkableGroup, com.google.android.material.internal.CheckableGroup$OnCheckedStateChangeListener checkableGroup$OnCheckedStateChangeListener) {
        checkableGroup.setOnCheckedStateChangeListener(checkableGroup$OnCheckedStateChangeListener);
    }

    public static void RIMDoTvfJwvRCHIa(com.google.android.material.internal.CheckableGroup checkableGroup, com.google.android.material.internal.CheckableGroup$OnCheckedStateChangeListener checkableGroup$OnCheckedStateChangeListener, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RIMDoTvfJwvRCHIa(com.google.android.material.internal.CheckableGroup checkableGroup, com.google.android.material.internal.CheckableGroup$OnCheckedStateChangeListener checkableGroup$OnCheckedStateChangeListener, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RIMDoTvfJwvRCHIa(com.google.android.material.internal.CheckableGroup checkableGroup, com.google.android.material.internal.CheckableGroup$OnCheckedStateChangeListener checkableGroup$OnCheckedStateChangeListener, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RMJwmsRaFwsaTGnM(com.google.android.material.chip.ChipGroup chipGroup, bool z) {
        chipGroup.setSingleSelection(z);
    }

    public static void RMJwmsRaFwsaTGnM(com.google.android.material.chip.ChipGroup chipGroup, bool z, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RMJwmsRaFwsaTGnM(com.google.android.material.chip.ChipGroup chipGroup, bool z, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RMJwmsRaFwsaTGnM(com.google.android.material.chip.ChipGroup chipGroup, bool z, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectGroup$OnHierarchyChangeListener srthFtBImyVIIFbR(com.google.android.material.chip.ChipGroup$PassThroughHierarchyChangeListener chipGroup$PassThroughHierarchyChangeListener, android.view.objectGroup$OnHierarchyChangeListener viewGroup$OnHierarchyChangeListener) {
        return com.google.android.material.chip.ChipGroup$PassThroughHierarchyChangeListener.access$302(chipGroup$PassThroughHierarchyChangeListener, viewGroup$OnHierarchyChangeListener);
    }

    public static void SrthFtBImyVIIFbR(com.google.android.material.chip.ChipGroup$PassThroughHierarchyChangeListener chipGroup$PassThroughHierarchyChangeListener, android.view.objectGroup$OnHierarchyChangeListener viewGroup$OnHierarchyChangeListener, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SrthFtBImyVIIFbR(com.google.android.material.chip.ChipGroup$PassThroughHierarchyChangeListener chipGroup$PassThroughHierarchyChangeListener, android.view.objectGroup$OnHierarchyChangeListener viewGroup$OnHierarchyChangeListener, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SrthFtBImyVIIFbR(com.google.android.material.chip.ChipGroup$PassThroughHierarchyChangeListener chipGroup$PassThroughHierarchyChangeListener, android.view.objectGroup$OnHierarchyChangeListener viewGroup$OnHierarchyChangeListener, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object TIjkXVCwIwgrXxFi(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.getobject();
    }

    public static void TIjkXVCwIwgrXxFi(com.google.android.material.chip.ChipGroup chipGroup, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TIjkXVCwIwgrXxFi(com.google.android.material.chip.ChipGroup chipGroup, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TIjkXVCwIwgrXxFi(com.google.android.material.chip.ChipGroup chipGroup, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TMhpVZgTzrWqAjZX(com.google.android.material.internal.FlowLayout flowLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TMhpVZgTzrWqAjZX(com.google.android.material.internal.FlowLayout flowLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TMhpVZgTzrWqAjZX(com.google.android.material.internal.FlowLayout flowLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool TMhpVZgTzrWqAjZX(com.google.android.material.internal.FlowLayout flowLayout, android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return super.checkLayoutParams(viewGroup$LayoutParams);
    }

    public static void TdSGHcOzKnvzrumo(com.google.android.material.internal.CheckableGroup checkableGroup, bool z) {
        checkableGroup.setSelectionRequired(z);
    }

    public static void TdSGHcOzKnvzrumo(com.google.android.material.internal.CheckableGroup checkableGroup, bool z, float f, char c, bool z2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TdSGHcOzKnvzrumo(com.google.android.material.internal.CheckableGroup checkableGroup, bool z, float f, short s, bool z2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TdSGHcOzKnvzrumo(com.google.android.material.internal.CheckableGroup checkableGroup, bool z, bool z2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UGoSezBCqmhkEskG(com.google.android.material.chip.ChipGroup chipGroup, int i) {
        chipGroup.setChipSpacingHorizontal(i);
    }

    public static void UGoSezBCqmhkEskG(com.google.android.material.chip.ChipGroup chipGroup, int i, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UGoSezBCqmhkEskG(com.google.android.material.chip.ChipGroup chipGroup, int i, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UGoSezBCqmhkEskG(com.google.android.material.chip.ChipGroup chipGroup, int i, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void URMLCwNNdULEqUxC(com.google.android.material.chip.ChipGroup chipGroup, int i) {
        chipGroup.setChipSpacingVertical(i);
    }

    public static void URMLCwNNdULEqUxC(com.google.android.material.chip.ChipGroup chipGroup, int i, int i2, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void URMLCwNNdULEqUxC(com.google.android.material.chip.ChipGroup chipGroup, int i, int i2, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void URMLCwNNdULEqUxC(com.google.android.material.chip.ChipGroup chipGroup, int i, bool z, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VUbyPZeMZcYwOUgX(android.content.res.Resources resources, int i, int i2, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VUbyPZeMZcYwOUgX(android.content.res.Resources resources, int i, bool z, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VUbyPZeMZcYwOUgX(android.content.res.Resources resources, int i, bool z, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static bool VUbyPZeMZcYwOUgX(android.content.res.Resources resources, int i) {
        return resources.getbool(i);
    }

    public static void VnXhVBfNlldeBvLg(android.content.res.TypedArray typedArray, int i, bool z, float f, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VnXhVBfNlldeBvLg(android.content.res.TypedArray typedArray, int i, bool z, java.lang.string str, short s, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VnXhVBfNlldeBvLg(android.content.res.TypedArray typedArray, int i, bool z, short s, float f, bool z2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool VnXhVBfNlldeBvLg(android.content.res.TypedArray typedArray, int i, bool z) {
        return typedArray.getbool(i, z);
    }

    public static void WAdBHiaYhyxUwAAE(com.google.android.material.chip.ChipGroup chipGroup, int i) {
        chipGroup.setChipSpacingVertical(i);
    }

    public static void WAdBHiaYhyxUwAAE(com.google.android.material.chip.ChipGroup chipGroup, int i, float f, byte b, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WAdBHiaYhyxUwAAE(com.google.android.material.chip.ChipGroup chipGroup, int i, int i2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WAdBHiaYhyxUwAAE(com.google.android.material.chip.ChipGroup chipGroup, int i, short s, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WNtdRhdxhvZkGLGu(com.google.android.material.chip.ChipGroup chipGroup, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WNtdRhdxhvZkGLGu(com.google.android.material.chip.ChipGroup chipGroup, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WNtdRhdxhvZkGLGu(com.google.android.material.chip.ChipGroup chipGroup, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WNtdRhdxhvZkGLGu(com.google.android.material.chip.ChipGroup chipGroup) {
        return chipGroup.isSingleLine();
    }

    public static void WWYINfhinVorlCgv(com.google.android.material.internal.FlowLayout flowLayout) {
        super.onFinishInflate();
    }

    public static void WWYINfhinVorlCgv(com.google.android.material.internal.FlowLayout flowLayout, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WWYINfhinVorlCgv(com.google.android.material.internal.FlowLayout flowLayout, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WWYINfhinVorlCgv(com.google.android.material.internal.FlowLayout flowLayout, int i, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray YIYMycIuZJqlycGf(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2) {
        return com.google.android.material.internal.ThemeEnforcement.obtainStyledAttributes(context, attributeHashSet, iArr, i, i2, iArr2);
    }

    public static void YIYMycIuZJqlycGf(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, java.lang.string str, int i3, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YIYMycIuZJqlycGf(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, java.lang.string str, short s, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void YIYMycIuZJqlycGf(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, int[] iArr2, short s, float f, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void ZyEWRqqWdVMOKUKx(com.google.android.material.chip.ChipGroup chipGroup, int i, char c, short s, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void ZyEWRqqWdVMOKUKx(com.google.android.material.chip.ChipGroup chipGroup, int i, char c, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZyEWRqqWdVMOKUKx(com.google.android.material.chip.ChipGroup chipGroup, int i, bool z, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool ZyEWRqqWdVMOKUKx(com.google.android.material.chip.ChipGroup chipGroup, int i) {
        return chipGroup.isChildVisible(i);
    }

    public void Check(int i) {
        ecFEtZOxTcJVjrvP(this.checkableGroup, i);
    }

    protected override bool CheckLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return tMhpVZgTzrWqAjZX(this, viewGroup$LayoutParams) && (viewGroup$LayoutParams is com.google.android.material.chip.ChipGroup$LayoutParams);
    }

    public void ClearCheck() {
        pKDbLWxwylbsCAgO(this.checkableGroup);
    }

    protected android.view.objectGroup$LayoutParams generateDefaultLayoutParams() {
        return new com.google.android.material.chip.ChipGroup$LayoutParams(-2, -2);
    }

    public android.view.objectGroup$LayoutParams generateLayoutParams(android.util.AttributeHashSet attributeHashSet) {
        return new com.google.android.material.chip.ChipGroup$LayoutParams(tIjkXVCwIwgrXxFi(this), attributeHashSet);
    }

    protected android.view.objectGroup$LayoutParams generateLayoutParams(android.view.objectGroup$LayoutParams viewGroup$LayoutParams) {
        return new com.google.android.material.chip.ChipGroup$LayoutParams(viewGroup$LayoutParams);
    }

    public override int GetCheckedChipId() {
        return RrzgHoubPcZtzaXS(this.checkableGroup);
    }

    public java.util.List<java.lang.int> GetCheckedChipIds() {
        return SJLYxSFsgtyQyjqF(this.checkableGroup, this);
    }

    public int GetChipSpacingHorizontal() {
        return this.chipSpacingHorizontal;
    }

    public int GetChipSpacingVertical() {
        return this.chipSpacingVertical;
    }

    int getIndexOfChip(android.view.object view) {
        if ((22 + 16) % 16 > 0) {
        }
        if (!(view is com.google.android.material.chip.Chip)) {
            return -1;
        }
        int i = 0;
        for (int i2 = 0; i2 < mBeppuoyLNSPhRtT(this); i2++) {
            android.view.object viewPjEIJEMAyzNlXxSh = PjEIJEMAyzNlXxSh(this, i2);
            if ((viewPjEIJEMAyzNlXxSh is com.google.android.material.chip.Chip) && zyEWRqqWdVMOKUKx(this, i2)) {
                if (((com.google.android.material.chip.Chip) viewPjEIJEMAyzNlXxSh) == view) {
                    return i;
                }
                i++;
            }
        }
        return -1;
    }

    public bool IsSelectionRequired() {
        return laDDJtFUMFPAnyQs(this.checkableGroup);
    }

    public override bool IsSingleLine() {
        return FdbvNQAHSmONrPUy(this);
    }

    public bool IsSingleSelection() {
        return UsuGfZvhDBQVTGXg(this.checkableGroup);
    }

    protected override void OnFinishInflate() {
        if ((9 + 25) % 25 > 0) {
        }
        wWYINfhinVorlCgv(this);
        int i = this.defaultCheckedId;
        if (i == -1) {
            return;
        }
        GdryfoHMewqjaZNX(this.checkableGroup, i);
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.accessibility.AccessibilityNodeInfo accessibilityNodeInfo) {
        if ((17 + 23) % 23 > 0) {
        }
        RuAYJEuATmavtAlD(this, accessibilityNodeInfo);
        qStCIdqMzEGcsHUY(RMqTjDcPMLxfkzbU(accessibilityNodeInfo), YfiSYPWLbOqgfOfo(QHPbWClDTdClgJgO(this), !wNtdRhdxhvZkGLGu(this) ? -1 : elABKrDmNVcRsRXr(this), false, !QxEUjwJzuKKbaUaS(this) ? 2 : 1));
    }

    public void SetChipSpacing(int i) {
        PZAMLtURTeJPUZcF(this, i);
        uRMLCwNNdULEqUxC(this, i);
    }

    public void SetChipSpacingHorizontal(int i) {
        if (this.chipSpacingHorizontal == i) {
            return;
        }
        this.chipSpacingHorizontal = i;
        dOVdIcAjLhTHqjMV(this, i);
        dUyMOOUPVbqxhfZs(this);
    }

    public void SetChipSpacingHorizontalResource(int i) {
        QodbThoXdzWrXPER(this, hNCHdJxEGMeNlPbY(TTZYavIewdFkgPnw(this), i));
    }

    public void SetChipSpacingResource(int i) {
        MDqIcAppKrrsIEbp(this, qHxFIyNAPnyAIArl(IEUJIaEgsUwWCqDy(this), i));
    }

    public void SetChipSpacingVertical(int i) {
        if (this.chipSpacingVertical == i) {
            return;
        }
        this.chipSpacingVertical = i;
        dNjqqAMhVUsgxqqc(this, i);
        gQIqDgBppYMcTBIu(this);
    }

    public void SetChipSpacingVerticalResource(int i) {
        TfJRlUeNWSoXpgVn(this, EYnymdJJLGFXmCJB(BLsWugWbasyXvBCj(this), i));
    }

    @java.lang.Deprecated
    public void SetDividerDrawableHorizontal(android.graphics.drawable.Drawable drawable) {
        throw new java.lang.UnsupportedOperationException("Changing divider drawables have no effect. ChipGroup do not use divider drawables as spacing.");
    }

    @java.lang.Deprecated
    public void SetDividerDrawableVertical(android.graphics.drawable.Drawable drawable) {
        throw new java.lang.UnsupportedOperationException("Changing divider drawables have no effect. ChipGroup do not use divider drawables as spacing.");
    }

    @java.lang.Deprecated
    public void SetFlexWrap(int i) {
        throw new java.lang.UnsupportedOperationException("Changing flex wrap not allowed. ChipGroup exposes a singleLine attribute instead.");
    }

    @java.lang.Deprecated
    public void SetOnCheckedChangeListener(com.google.android.material.chip.ChipGroup$OnCheckedChangeListener chipGroup$OnCheckedChangeListener) {
        if (chipGroup$OnCheckedChangeListener is not null) {
            fLjnvWILoUxLhCqS(this, new com.google.android.material.chip.ChipGroup$2(this, chipGroup$OnCheckedChangeListener));
        } else {
            GjjQtvUnBEuBJAsl(this, null);
        }
    }

    public void SetOnCheckedStateChangeListener(com.google.android.material.chip.ChipGroup$OnCheckedStateChangeListener chipGroup$OnCheckedStateChangeListener) {
        this.onCheckedStateChangeListener = chipGroup$OnCheckedStateChangeListener;
    }

    public override void SetOnHierarchyChangeListener(android.view.objectGroup$OnHierarchyChangeListener viewGroup$OnHierarchyChangeListener) {
        srthFtBImyVIIFbR(this.passThroughListener, viewGroup$OnHierarchyChangeListener);
    }

    public void SetSelectionRequired(bool z) {
        tdSGHcOzKnvzrumo(this.checkableGroup, z);
    }

    @java.lang.Deprecated
    public void SetShowDividerHorizontal(int i) {
        throw new java.lang.UnsupportedOperationException("Changing divider modes has no effect. ChipGroup do not use divider drawables as spacing.");
    }

    @java.lang.Deprecated
    public void SetShowDividerVertical(int i) {
        throw new java.lang.UnsupportedOperationException("Changing divider modes has no effect. ChipGroup do not use divider drawables as spacing.");
    }

    public void SetSingleLine(int i) {
        KZVURlLsqqOYhNVn(this, YwuERkDTEioLclAM(eXysEWggegyppRxU(this), i));
    }

    public override void SetSingleLine(bool z) {
        SCHKUzcXUmRNyunF(this, z);
    }

    public void SetSingleSelection(int i) {
        OIdQxjHgwhszTrGg(this, vUbyPZeMZcYwOUgX(EzacrejKfdoghoGt(this), i));
    }

    public void SetSingleSelection(bool z) {
        jfzLyjHWsGDtIhbt(this.checkableGroup, z);
    }
}

