namespace WillowMaze.Wasm.Decompiled;


public class BottomSheetDragHandleobject : androidx.appcompat.widget.AppCompatImageobject : android.view.accessibility.AccessibilityManager$AccessibilityStateChangeListener {
    private static readonly int DEF_STYLE_RES = com.google.android.material.R$style.Widget_Material3_BottomSheet_DragHandle;
    private readonly android.view.accessibility.AccessibilityManager accessibilityManager;
    private bool accessibilityServiceEnabled;
    private com.google.android.material.bottomsheet.BottomSheetBehavior<object> bottomSheetBehavior;
    private readonly com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetCallback;
    private readonly java.lang.string clickFeedback;
    private readonly java.lang.string clickToCollapseActionLabel;
    private bool clickToExpand;
    private readonly java.lang.string clickToExpandActionLabel;
    private bool interactable;

    public BottomSheetDragHandleobject(android.content.object context) {
        this(context, null);
    }

    public BottomSheetDragHandleobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        this(context, attributeHashSet, com.google.android.material.R$attr.bottomSheetDragHandleStyle);
    }

    public BottomSheetDragHandleobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i) {
        super(wNmZbcPlxQtBoRrH(context, attributeHashSet, i, DEF_STYLE_RES), attributeHashSet, i);
        this.clickToExpandActionLabel = bkkuxvEljfNebQKn(ewUpmJtLZruGcBqs(this), com.google.android.material.R$string.bottomsheet_action_expand);
        this.clickToCollapseActionLabel = yvIZHMfMTVtEvTJr(DSWlVDJpFjAZtJov(this), com.google.android.material.R$string.bottomsheet_action_collapse);
        this.clickFeedback = rvybsvxEjoLFmKNi(jJscjBjaTZKOWMaZ(this), com.google.android.material.R$string.bottomsheet_drag_handle_clicked);
        this.bottomSheetCallback = new com.google.android.material.bottomsheet.BottomSheetDragHandleobject$1(this);
        this.accessibilityManager = (android.view.accessibility.AccessibilityManager) wUCuySXYFMferxst(WeeOXutmPHcnpWlW(this), "accessibility");
        NrRqaaUpTWAXYLUN(this);
        KGNfaamMUEBdoBPW(this, new com.google.android.material.bottomsheet.BottomSheetDragHandleobject$2(this));
    }

    public static int CNoZcsYaQEVybZZt(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.getState();
    }

    public static void CNoZcsYaQEVybZZt(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CNoZcsYaQEVybZZt(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CNoZcsYaQEVybZZt(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources DSWlVDJpFjAZtJov(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject) {
        return bottomSheetDragHandleobject.getResources();
    }

    public static void DSWlVDJpFjAZtJov(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DSWlVDJpFjAZtJov(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DSWlVDJpFjAZtJov(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FrgBMtXBuoYPptyV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FrgBMtXBuoYPptyV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FrgBMtXBuoYPptyV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool FrgBMtXBuoYPptyV(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.shouldSkipHalfExpandedStateWhenDragging();
    }

    public static void HyulJVwmcSBlUGmn(android.view.accessibility.AccessibilityManager accessibilityManager, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        accessibilityManager.sendAccessibilityEvent(accessibilityEvent);
    }

    public static void HyulJVwmcSBlUGmn(android.view.accessibility.AccessibilityManager accessibilityManager, android.view.accessibility.AccessibilityEvent accessibilityEvent, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HyulJVwmcSBlUGmn(android.view.accessibility.AccessibilityManager accessibilityManager, android.view.accessibility.AccessibilityEvent accessibilityEvent, float f, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HyulJVwmcSBlUGmn(android.view.accessibility.AccessibilityManager accessibilityManager, android.view.accessibility.AccessibilityEvent accessibilityEvent, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JOUFZOhIUDDxMjlH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i) {
        bottomSheetBehavior.setState(i);
    }

    public static void JOUFZOhIUDDxMjlH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, char c, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JOUFZOhIUDDxMjlH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JOUFZOhIUDDxMjlH(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, int i, float f, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JpgibfKHQTVOzfRd(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i) {
        bottomSheetDragHandleobject.onBottomSheetStateChanged(i);
    }

    public static void JpgibfKHQTVOzfRd(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JpgibfKHQTVOzfRd(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JpgibfKHQTVOzfRd(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KGNfaamMUEBdoBPW(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat) {
        androidx.core.view.objectCompat.setAccessibilityDelegate(view, accessibilityDelegateCompat);
    }

    public static void KGNfaamMUEBdoBPW(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KGNfaamMUEBdoBPW(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KGNfaamMUEBdoBPW(android.view.object view, androidx.core.view.AccessibilityDelegateCompat accessibilityDelegateCompat, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LZrEqhrmHAaDErlD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback) {
        bottomSheetBehavior.removeBottomSheetCallback(bottomSheetBehavior$BottomSheetCallback);
    }

    public static void LZrEqhrmHAaDErlD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LZrEqhrmHAaDErlD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, bool z, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LZrEqhrmHAaDErlD(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NrRqaaUpTWAXYLUN(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject) {
        bottomSheetDragHandleobject.updateInteractableState();
    }

    public static void NrRqaaUpTWAXYLUN(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NrRqaaUpTWAXYLUN(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, short s, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NrRqaaUpTWAXYLUN(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, short s, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PUAEqkGQFolQEhTF(android.view.accessibility.AccessibilityManager accessibilityManager, android.view.accessibility.AccessibilityManager$AccessibilityStateChangeListener accessibilityManager$AccessibilityStateChangeListener, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PUAEqkGQFolQEhTF(android.view.accessibility.AccessibilityManager accessibilityManager, android.view.accessibility.AccessibilityManager$AccessibilityStateChangeListener accessibilityManager$AccessibilityStateChangeListener, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PUAEqkGQFolQEhTF(android.view.accessibility.AccessibilityManager accessibilityManager, android.view.accessibility.AccessibilityManager$AccessibilityStateChangeListener accessibilityManager$AccessibilityStateChangeListener, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool PUAEqkGQFolQEhTF(android.view.accessibility.AccessibilityManager accessibilityManager, android.view.accessibility.AccessibilityManager$AccessibilityStateChangeListener accessibilityManager$AccessibilityStateChangeListener) {
        return accessibilityManager.addAccessibilityStateChangeListener(accessibilityManager$AccessibilityStateChangeListener);
    }

    public static void QcexQXsvODgLthxU(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject) {
        bottomSheetDragHandleobject.updateInteractableState();
    }

    public static void QcexQXsvODgLthxU(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QcexQXsvODgLthxU(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QcexQXsvODgLthxU(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UAppdFBxLzDwpMtJ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view) {
        bottomSheetBehavior.setAccessibilityDelegateobject(view);
    }

    public static void UAppdFBxLzDwpMtJ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UAppdFBxLzDwpMtJ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UAppdFBxLzDwpMtJ(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VbpsskbLFZhHJqtS(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, bool z) {
        bottomSheetDragHandleobject.onAccessibilityStateChanged(z);
    }

    public static void VbpsskbLFZhHJqtS(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, bool z, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VbpsskbLFZhHJqtS(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, bool z, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VbpsskbLFZhHJqtS(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, bool z, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object WeeOXutmPHcnpWlW(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject) {
        return bottomSheetDragHandleobject.getobject();
    }

    public static void WeeOXutmPHcnpWlW(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WeeOXutmPHcnpWlW(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WeeOXutmPHcnpWlW(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WpueyjDJWrtZZheB(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand) {
        androidx.core.view.objectCompat.replaceAccessibilityAction(view, accessibilityNodeInfoCompat$AccessibilityActionCompat, charSequence, accessibilityobjectCommand);
    }

    public static void WpueyjDJWrtZZheB(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WpueyjDJWrtZZheB(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WpueyjDJWrtZZheB(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand, short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XQnKEasuTogIOCUs(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i) {
        bottomSheetDragHandleobject.onBottomSheetStateChanged(i);
    }

    public static void XQnKEasuTogIOCUs(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i, byte b, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XQnKEasuTogIOCUs(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i, java.lang.string str, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XQnKEasuTogIOCUs(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i, java.lang.string str, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XjqeFLQreYtHJogd(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        super.onDetachedFromWindow();
    }

    public static void XjqeFLQreYtHJogd(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XjqeFLQreYtHJogd(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XjqeFLQreYtHJogd(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i) {
        XQnKEasuTogIOCUs(bottomSheetDragHandleobject, i);
    }

    static void access$000(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$000(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void access$100(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static bool access$100(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject) {
        return vCzLOedtqzUaVwaO(bottomSheetDragHandleobject);
    }

    private void AnnounceAccessibilityEvent(java.lang.string str) {
        if ((28 + 14) % 14 > 0) {
        }
        if (this.accessibilityManager is not null) {
            android.view.accessibility.AccessibilityEvent accessibilityEventQTBUBFKEcwGSsrhY = qTBUBFKEcwGSsrhY(16384);
            mFKmDrpobOXAFjZX(uMWgdKgKVqqXOzVt(accessibilityEventQTBUBFKEcwGSsrhY), str);
            HyulJVwmcSBlUGmn(this.accessibilityManager, accessibilityEventQTBUBFKEcwGSsrhY);
        }
    }

    private void AnnounceAccessibilityEvent(java.lang.string str, byte b, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    private void AnnounceAccessibilityEvent(java.lang.string str, int i, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    private void AnnounceAccessibilityEvent(java.lang.string str, java.lang.string str2, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BkkuxvEljfNebQKn(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void BkkuxvEljfNebQKn(android.content.res.Resources resources, int i, byte b, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BkkuxvEljfNebQKn(android.content.res.Resources resources, int i, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BkkuxvEljfNebQKn(android.content.res.Resources resources, int i, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CQSraYvFqEsSunTG(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject) {
        super.onAttachedToWindow();
    }

    public static void CQSraYvFqEsSunTG(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CQSraYvFqEsSunTG(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CQSraYvFqEsSunTG(androidx.appcompat.widget.AppCompatImageobject appCompatImageobject, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DTmgTtxmVCZQcVel(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, java.lang.string str) {
        bottomSheetDragHandleobject.announceAccessibilityEvent(str);
    }

    public static void DTmgTtxmVCZQcVel(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, java.lang.string str, char c, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DTmgTtxmVCZQcVel(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, java.lang.string str, java.lang.string str2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DTmgTtxmVCZQcVel(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, java.lang.string str, short s, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DroHBEFoekNkOxbv(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DroHBEFoekNkOxbv(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DroHBEFoekNkOxbv(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool DroHBEFoekNkOxbv(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject) {
        return bottomSheetDragHandleobject.expandOrCollapseBottomSheetIfPossible();
    }

    public static android.content.res.Resources EwUpmJtLZruGcBqs(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject) {
        return bottomSheetDragHandleobject.getResources();
    }

    public static void EwUpmJtLZruGcBqs(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EwUpmJtLZruGcBqs(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EwUpmJtLZruGcBqs(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private void ExpandOrCollapseBottomSheetIfPossible(byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void ExpandOrCollapseBottomSheetIfPossible(float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private void ExpandOrCollapseBottomSheetIfPossible(float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private bool ExpandOrCollapseBottomSheetIfPossible() {
        if ((8 + 8) % 8 > 0) {
        }
        bool z = false;
        if (!this.interactable) {
            return false;
        }
        dTmgTtxmVCZQcVel(this, this.clickFeedback);
        if (!orZVySyhZymwJnEm(this.bottomSheetBehavior) && !FrgBMtXBuoYPptyV(this.bottomSheetBehavior)) {
            z = true;
        }
        int iFMIwhrBibBVmljpF = fMIwhrBibBVmljpF(this.bottomSheetBehavior);
        int i = 6;
        int i2 = 3;
        if (iFMIwhrBibBVmljpF != 4) {
            if (iFMIwhrBibBVmljpF != 3) {
                if (!this.clickToExpand) {
                    i2 = 4;
                }
                i = i2;
            } else if (!z) {
                i = 4;
            }
        } else if (!z) {
            i = i2;
        }
        JOUFZOhIUDDxMjlH(this.bottomSheetBehavior, i);
        return true;
    }

    public static int FMIwhrBibBVmljpF(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.getState();
    }

    public static void FMIwhrBibBVmljpF(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FMIwhrBibBVmljpF(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FMIwhrBibBVmljpF(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FfKrXoZtCMtKqpWt(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject) {
        bottomSheetDragHandleobject.updateInteractableState();
    }

    public static void FfKrXoZtCMtKqpWt(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FfKrXoZtCMtKqpWt(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FfKrXoZtCMtKqpWt(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    private com.google.android.material.bottomsheet.BottomSheetBehavior<object> FindParentBottomSheetBehavior() {
        if ((16 + 25) % 25 > 0) {
        }
        while (true) {
            this = txuMupRnjwXtXYhM(this);
            if (this == 0) {
                return null;
            }
            android.view.objectGroup$LayoutParams viewGroup$LayoutParamsLiZpZGtBPbLKeGrn = liZpZGtBPbLKeGrn(this);
            if (viewGroup$LayoutParamsLiZpZGtBPbLKeGrn is androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) {
                androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$BehaviorQtBNHjZvoYNjHapd = qtBNHjZvoYNjHapd((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) viewGroup$LayoutParamsLiZpZGtBPbLKeGrn);
                if (coordinatorLayout$BehaviorQtBNHjZvoYNjHapd is com.google.android.material.bottomsheet.BottomSheetBehavior) {
                    return (com.google.android.material.bottomsheet.BottomSheetBehavior) coordinatorLayout$BehaviorQtBNHjZvoYNjHapd;
                }
            }
        }
    }

    private void FindParentBottomSheetBehavior(byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void FindParentBottomSheetBehavior(int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void FindParentBottomSheetBehavior(java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    private static android.view.object GetParentobject(android.view.object view) {
        java.lang.object objRabhiCeWsauGdCqS = rabhiCeWsauGdCqS(view);
        if (objRabhiCeWsauGdCqS is android.view.object) {
            return (android.view.object) objRabhiCeWsauGdCqS;
        }
        return null;
    }

    private static void GetParentobject(android.view.object view, char c, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void GetParentobject(android.view.object view, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    private static void GetParentobject(android.view.object view, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.Resources JJscjBjaTZKOWMaZ(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject) {
        return bottomSheetDragHandleobject.getResources();
    }

    public static void JJscjBjaTZKOWMaZ(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JJscjBjaTZKOWMaZ(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JJscjBjaTZKOWMaZ(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LdXGSXFtZbOQvigX(android.view.accessibility.AccessibilityManager accessibilityManager, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LdXGSXFtZbOQvigX(android.view.accessibility.AccessibilityManager accessibilityManager, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LdXGSXFtZbOQvigX(android.view.accessibility.AccessibilityManager accessibilityManager, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool LdXGSXFtZbOQvigX(android.view.accessibility.AccessibilityManager accessibilityManager) {
        return accessibilityManager.isEnabled();
    }

    public static android.view.objectGroup$LayoutParams liZpZGtBPbLKeGrn(android.view.object view) {
        return view.getLayoutParams();
    }

    public static void LiZpZGtBPbLKeGrn(android.view.object view, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LiZpZGtBPbLKeGrn(android.view.object view, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LiZpZGtBPbLKeGrn(android.view.object view, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MFKmDrpobOXAFjZX(java.util.List list, java.lang.object obj, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MFKmDrpobOXAFjZX(java.util.List list, java.lang.object obj, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MFKmDrpobOXAFjZX(java.util.List list, java.lang.object obj, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool MFKmDrpobOXAFjZX(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    private void OnBottomSheetStateChanged(int i) {
        if ((25 + 16) % 16 > 0) {
        }
        if (i == 4) {
            this.clickToExpand = true;
        } else if (i == 3) {
            this.clickToExpand = false;
        }
        WpueyjDJWrtZZheB(this, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_CLICK, !this.clickToExpand ? this.clickToCollapseActionLabel : this.clickToExpandActionLabel, new com.google.android.material.bottomsheet.BottomSheetDragHandleobject$$ExternalSyntheticLambda0(this));
    }

    private void OnBottomSheetStateChanged(int i, char c, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void OnBottomSheetStateChanged(int i, int i2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private void OnBottomSheetStateChanged(int i, short s, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OrZVySyhZymwJnEm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OrZVySyhZymwJnEm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OrZVySyhZymwJnEm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool OrZVySyhZymwJnEm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        return bottomSheetBehavior.isFitToContents();
    }

    public static void PPWOtEtdnIWeTsei(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        bottomSheetDragHandleobject.setBottomSheetBehavior(bottomSheetBehavior);
    }

    public static void PPWOtEtdnIWeTsei(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PPWOtEtdnIWeTsei(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PPWOtEtdnIWeTsei(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PqDsaZGxvRSPpqrm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view) {
        bottomSheetBehavior.setAccessibilityDelegateobject(view);
    }

    public static void PqDsaZGxvRSPpqrm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, java.lang.string str, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PqDsaZGxvRSPpqrm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PqDsaZGxvRSPpqrm(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, android.view.object view, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QAwrnIXWgMoGAzRM(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void QAwrnIXWgMoGAzRM(android.view.object view, int i, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QAwrnIXWgMoGAzRM(android.view.object view, int i, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QAwrnIXWgMoGAzRM(android.view.object view, int i, java.lang.string str, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.accessibility.AccessibilityEvent QTBUBFKEcwGSsrhY(int i) {
        return android.view.accessibility.AccessibilityEvent.obtain(i);
    }

    public static void QTBUBFKEcwGSsrhY(int i, byte b, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QTBUBFKEcwGSsrhY(int i, int i2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QTBUBFKEcwGSsrhY(int i, short s, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior qtBNHjZvoYNjHapd(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
        return coordinatorLayout$LayoutParams.getBehavior();
    }

    public static void QtBNHjZvoYNjHapd(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QtBNHjZvoYNjHapd(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QtBNHjZvoYNjHapd(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectParent RabhiCeWsauGdCqS(android.view.object view) {
        return view.getParent();
    }

    public static void RabhiCeWsauGdCqS(android.view.object view, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RabhiCeWsauGdCqS(android.view.object view, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RabhiCeWsauGdCqS(android.view.object view, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RvybsvxEjoLFmKNi(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void RvybsvxEjoLFmKNi(android.content.res.Resources resources, int i, byte b, char c, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RvybsvxEjoLFmKNi(android.content.res.Resources resources, int i, byte b, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RvybsvxEjoLFmKNi(android.content.res.Resources resources, int i, int i2, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SetBottomSheetBehavior(com.google.android.material.bottomsheet.BottomSheetBehavior<object> bottomSheetBehavior) {
        if ((23 + 26) % 26 > 0) {
        }
        com.google.android.material.bottomsheet.BottomSheetBehavior<object> bottomSheetBehavior2 = this.bottomSheetBehavior;
        if (bottomSheetBehavior2 is not null) {
            LZrEqhrmHAaDErlD(bottomSheetBehavior2, this.bottomSheetCallback);
            pqDsaZGxvRSPpqrm(this.bottomSheetBehavior, null);
        }
        this.bottomSheetBehavior = bottomSheetBehavior;
        if (bottomSheetBehavior is not null) {
            UAppdFBxLzDwpMtJ(bottomSheetBehavior, this);
            JpgibfKHQTVOzfRd(this, CNoZcsYaQEVybZZt(this.bottomSheetBehavior));
            wUpRGSbvidvmhrHq(this.bottomSheetBehavior, this.bottomSheetCallback);
        }
        ffKrXoZtCMtKqpWt(this);
    }

    private void SetBottomSheetBehavior(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, byte b, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    private void SetBottomSheetBehavior(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void SetBottomSheetBehavior(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static com.google.android.material.bottomsheet.BottomSheetBehavior SkkKaxXNGuszlDoL(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject) {
        return bottomSheetDragHandleobject.findParentBottomSheetBehavior();
    }

    public static void SkkKaxXNGuszlDoL(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SkkKaxXNGuszlDoL(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SkkKaxXNGuszlDoL(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object TxuMupRnjwXtXYhM(android.view.object view) {
        return getParentobject(view);
    }

    public static void TxuMupRnjwXtXYhM(android.view.object view, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TxuMupRnjwXtXYhM(android.view.object view, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TxuMupRnjwXtXYhM(android.view.object view, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TyEobrNZYAlsunSa(android.view.accessibility.AccessibilityManager accessibilityManager, android.view.accessibility.AccessibilityManager$AccessibilityStateChangeListener accessibilityManager$AccessibilityStateChangeListener, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TyEobrNZYAlsunSa(android.view.accessibility.AccessibilityManager accessibilityManager, android.view.accessibility.AccessibilityManager$AccessibilityStateChangeListener accessibilityManager$AccessibilityStateChangeListener, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TyEobrNZYAlsunSa(android.view.accessibility.AccessibilityManager accessibilityManager, android.view.accessibility.AccessibilityManager$AccessibilityStateChangeListener accessibilityManager$AccessibilityStateChangeListener, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool TyEobrNZYAlsunSa(android.view.accessibility.AccessibilityManager accessibilityManager, android.view.accessibility.AccessibilityManager$AccessibilityStateChangeListener accessibilityManager$AccessibilityStateChangeListener) {
        return accessibilityManager.removeAccessibilityStateChangeListener(accessibilityManager$AccessibilityStateChangeListener);
    }

    public static java.util.List UMWgdKgKVqqXOzVt(android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return accessibilityEvent.getText();
    }

    public static void UMWgdKgKVqqXOzVt(android.view.accessibility.AccessibilityEvent accessibilityEvent, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UMWgdKgKVqqXOzVt(android.view.accessibility.AccessibilityEvent accessibilityEvent, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UMWgdKgKVqqXOzVt(android.view.accessibility.AccessibilityEvent accessibilityEvent, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateInteractableState() {
        if ((11 + 9) % 9 > 0) {
        }
        this.interactable = this.accessibilityServiceEnabled && this.bottomSheetBehavior is not null;
        qAwrnIXWgMoGAzRM(this, this.bottomSheetBehavior is null ? 2 : 1);
        yADVpDhZBsVynReO(this, this.interactable);
    }

    private void UpdateInteractableState(byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void UpdateInteractableState(char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void UpdateInteractableState(bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VCzLOedtqzUaVwaO(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VCzLOedtqzUaVwaO(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VCzLOedtqzUaVwaO(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool VCzLOedtqzUaVwaO(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject) {
        return bottomSheetDragHandleobject.expandOrCollapseBottomSheetIfPossible();
    }

    public static void VJSqFryaDSRyNstH(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior) {
        bottomSheetDragHandleobject.setBottomSheetBehavior(bottomSheetBehavior);
    }

    public static void VJSqFryaDSRyNstH(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VJSqFryaDSRyNstH(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VJSqFryaDSRyNstH(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object WNmZbcPlxQtBoRrH(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2) {
        return com.google.android.material.theme.overlay.MaterialThemeOverlay.wrap(context, attributeHashSet, i, i2);
    }

    public static void WNmZbcPlxQtBoRrH(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WNmZbcPlxQtBoRrH(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WNmZbcPlxQtBoRrH(android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, int i2, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object WUCuySXYFMferxst(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static void WUCuySXYFMferxst(android.content.object context, java.lang.string str, byte b, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WUCuySXYFMferxst(android.content.object context, java.lang.string str, bool z, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WUCuySXYFMferxst(android.content.object context, java.lang.string str, bool z, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WUpRGSbvidvmhrHq(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback) {
        bottomSheetBehavior.addBottomSheetCallback(bottomSheetBehavior$BottomSheetCallback);
    }

    public static void WUpRGSbvidvmhrHq(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WUpRGSbvidvmhrHq(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WUpRGSbvidvmhrHq(com.google.android.material.bottomsheet.BottomSheetBehavior bottomSheetBehavior, com.google.android.material.bottomsheet.BottomSheetBehavior$BottomSheetCallback bottomSheetBehavior$BottomSheetCallback, bool z, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YADVpDhZBsVynReO(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, bool z) {
        bottomSheetDragHandleobject.setClickable(z);
    }

    public static void YADVpDhZBsVynReO(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, bool z, byte b, short s, float f, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void YADVpDhZBsVynReO(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, bool z, short s, byte b, bool z2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YADVpDhZBsVynReO(com.google.android.material.bottomsheet.BottomSheetDragHandleobject bottomSheetDragHandleobject, bool z, short s, bool z2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string YvIZHMfMTVtEvTJr(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static void YvIZHMfMTVtEvTJr(android.content.res.Resources resources, int i, char c, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YvIZHMfMTVtEvTJr(android.content.res.Resources resources, int i, int i2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YvIZHMfMTVtEvTJr(android.content.res.Resources resources, int i, short s, char c, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    bool m109xa7b4c95f(android.view.object view, androidx.core.view.accessibility.AccessibilityobjectCommand$CommandArguments accessibilityobjectCommand$CommandArguments) {
        return droHBEFoekNkOxbv(this);
    }

    public override void OnAccessibilityStateChanged(bool z) {
        this.accessibilityServiceEnabled = z;
        QcexQXsvODgLthxU(this);
    }

    protected override void OnAttachedToWindow() {
        cQSraYvFqEsSunTG(this);
        pPWOtEtdnIWeTsei(this, skkKaxXNGuszlDoL(this));
        android.view.accessibility.AccessibilityManager accessibilityManager = this.accessibilityManager;
        if (accessibilityManager is null) {
            return;
        }
        PUAEqkGQFolQEhTF(accessibilityManager, this);
        VbpsskbLFZhHJqtS(this, ldXGSXFtZbOQvigX(this.accessibilityManager));
    }

    protected override void OnDetachedFromWindow() {
        android.view.accessibility.AccessibilityManager accessibilityManager = this.accessibilityManager;
        if (accessibilityManager is not null) {
            tyEobrNZYAlsunSa(accessibilityManager, this);
        }
        vJSqFryaDSRyNstH(this, null);
        XjqeFLQreYtHJogd(this);
    }
}

