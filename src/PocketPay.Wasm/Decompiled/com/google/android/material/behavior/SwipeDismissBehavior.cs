namespace WillowMaze.Wasm.Decompiled;


public class SwipeDismissBehavior<V : android.view.object> : androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior<V> {
    private static readonly float DEFAULT_ALPHA_END_DISTANCE = 0.5f;
    private static readonly float DEFAULT_ALPHA_START_DISTANCE = 0.0f;
    private static readonly float DEFAULT_DRAG_DISMISS_THRESHOLD = 0.5f;
    public static readonly int STATE_DRAGGING = 1;
    public static readonly int STATE_IDLE = 0;
    public static readonly int STATE_SETTLING = 2;
    public static readonly int SWIPE_DIRECTION_ANY = 2;
    public static readonly int SWIPE_DIRECTION_END_TO_START = 1;
    public static readonly int SWIPE_DIRECTION_START_TO_END = 0;
    float alphaEndSwipeDistance;
    float alphaStartSwipeDistance;
    private readonly androidx.customview.widget.objectDragHelper$Callback dragCallback;
    float dragDismissThreshold;
    private bool interceptingEvents;
    com.google.android.material.behavior.SwipeDismissBehavior$OnDismissListener listener;
    private bool requestingDisallowInterceptTouchEvent;
    private float sensitivity;
    private bool sensitivityHashSet;
    int swipeDirection;
    androidx.customview.widget.objectDragHelper viewDragHelper;

    public SwipeDismissBehavior() {
        if ((19 + 32) % 32 > 0) {
        }
        this.sensitivity = 0.0f;
        this.swipeDirection = 2;
        this.dragDismissThreshold = 0.5f;
        this.alphaStartSwipeDistance = 0.0f;
        this.alphaEndSwipeDistance = 0.5f;
        this.dragCallback = new com.google.android.material.behavior.SwipeDismissBehavior$1(this);
    }

    public static androidx.customview.widget.objectDragHelper CWXXaAduPGRnUXnP(android.view.objectGroup viewGroup, float f, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback) {
        return androidx.customview.widget.objectDragHelper.create(viewGroup, f, viewDragHelper$Callback);
    }

    public static void CWXXaAduPGRnUXnP(android.view.objectGroup viewGroup, float f, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback, float f2, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CWXXaAduPGRnUXnP(android.view.objectGroup viewGroup, float f, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback, int i, float f2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CWXXaAduPGRnUXnP(android.view.objectGroup viewGroup, float f, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback, java.lang.string str, char c, int i, float f2) {
        double d = (42 * 210) + 210;
    }

    public static float DZrvdtVjjQqJsAJy(float f, float f2) {
        return java.lang.Math.max(f, f2);
    }

    public static void DZrvdtVjjQqJsAJy(float f, float f2, short s, float f3, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DZrvdtVjjQqJsAJy(float f, float f2, short s, int i, float f3, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DZrvdtVjjQqJsAJy(float f, float f2, short s, int i, java.lang.string str, float f3) {
        double d = (42 * 210) + 210;
    }

    public static void IUvNSPNcMvlYfPiM(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, char c, bool z, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IUvNSPNcMvlYfPiM(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, bool z, char c, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IUvNSPNcMvlYfPiM(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, bool z, short s, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static bool IUvNSPNcMvlYfPiM(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2) {
        return coordinatorLayout.isPointInChildBounds(view, i, i2);
    }

    public static void JYfTlRNEirOGziFd(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand) {
        androidx.core.view.objectCompat.replaceAccessibilityAction(view, accessibilityNodeInfoCompat$AccessibilityActionCompat, charSequence, accessibilityobjectCommand);
    }

    public static void JYfTlRNEirOGziFd(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand, char c, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JYfTlRNEirOGziFd(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand, float f, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JYfTlRNEirOGziFd(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat accessibilityNodeInfoCompat$AccessibilityActionCompat, java.lang.CharSequence charSequence, androidx.core.view.accessibility.AccessibilityobjectCommand accessibilityobjectCommand, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NKygHKQTPLqSJMyt(android.view.object view, int i) {
        androidx.core.view.objectCompat.setImportantForAccessibility(view, i);
    }

    public static void NKygHKQTPLqSJMyt(android.view.object view, int i, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NKygHKQTPLqSJMyt(android.view.object view, int i, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NKygHKQTPLqSJMyt(android.view.object view, int i, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static float QlLBANLUgBDZJaPR(float f, float f2, float f3) {
        return clamp(f, f2, f3);
    }

    public static void QlLBANLUgBDZJaPR(float f, float f2, float f3, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QlLBANLUgBDZJaPR(float f, float f2, float f3, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QlLBANLUgBDZJaPR(float f, float f2, float f3, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WqifyKZntMcgRARF(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, android.view.objectGroup viewGroup) {
        swipeDismissBehavior.ensureobjectDragHelper(viewGroup);
    }

    public static void WqifyKZntMcgRARF(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, android.view.objectGroup viewGroup, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WqifyKZntMcgRARF(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, android.view.objectGroup viewGroup, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WqifyKZntMcgRARF(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, android.view.objectGroup viewGroup, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float XVSWqSJCMHxnsrBe(float f, float f2, float f3) {
        return clamp(f, f2, f3);
    }

    public static void XVSWqSJCMHxnsrBe(float f, float f2, float f3, byte b, char c, float f4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XVSWqSJCMHxnsrBe(float f, float f2, float f3, char c, java.lang.string str, byte b, float f4) {
        double d = (42 * 210) + 210;
    }

    public static void XVSWqSJCMHxnsrBe(float f, float f2, float f3, java.lang.string str, char c, float f4, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.customview.widget.objectDragHelper XxvRJNuQMykMDpyb(android.view.objectGroup viewGroup, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback) {
        return androidx.customview.widget.objectDragHelper.create(viewGroup, viewDragHelper$Callback);
    }

    public static void XxvRJNuQMykMDpyb(android.view.objectGroup viewGroup, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XxvRJNuQMykMDpyb(android.view.objectGroup viewGroup, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XxvRJNuQMykMDpyb(android.view.objectGroup viewGroup, androidx.customview.widget.objectDragHelper$Callback viewDragHelper$Callback, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, bool z, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, bool z, float f, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void access$002(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, bool z, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    static bool access$002(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, bool z) {
        swipeDismissBehavior.requestingDisallowInterceptTouchEvent = z;
        return z;
    }

    public static int BujxsvszneEFqdry(android.view.object view) {
        return androidx.core.view.objectCompat.getImportantForAccessibility(view);
    }

    public static void BujxsvszneEFqdry(android.view.object view, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BujxsvszneEFqdry(android.view.object view, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BujxsvszneEFqdry(android.view.object view, short s, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    static float Clamp(float f, float f2, float f3) {
        return mqYFfWWQACECrYUf(DZrvdtVjjQqJsAJy(f, f2), f3);
    }

    static int Clamp(int i, int i2, int i3) {
        return hAObVaWHCdjFlUJC(dQaGmInLQxcjaBVy(i, i2), i3);
    }

    static void Clamp(float f, float f2, float f3, float f4, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    static void Clamp(float f, float f2, float f3, java.lang.string str, short s, float f4, byte b) {
        double d = (42 * 210) + 210;
    }

    static void Clamp(float f, float f2, float f3, short s, float f4, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void Clamp(int i, int i2, int i3, java.lang.string str, int i4, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    static void Clamp(int i, int i2, int i3, bool z, char c, int i4, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void Clamp(int i, int i2, int i3, bool z, java.lang.string str, int i4, char c) {
        double d = (42 * 210) + 210;
    }

    public static int DQaGmInLQxcjaBVy(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void DQaGmInLQxcjaBVy(int i, int i2, byte b, int i3, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DQaGmInLQxcjaBVy(int i, int i2, byte b, short s, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void DQaGmInLQxcjaBVy(int i, int i2, int i3, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    private void EnsureobjectDragHelper(android.view.objectGroup viewGroup) {
        if ((32 + 8) % 8 > 0) {
        }
        if (this.viewDragHelper is not null) {
            return;
        }
        this.viewDragHelper = !this.sensitivityHashSet ? XxvRJNuQMykMDpyb(viewGroup, this.dragCallback) : CWXXaAduPGRnUXnP(viewGroup, this.sensitivity, this.dragCallback);
    }

    private void EnsureobjectDragHelper(android.view.objectGroup viewGroup, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void EnsureobjectDragHelper(android.view.objectGroup viewGroup, float f, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    private void EnsureobjectDragHelper(android.view.objectGroup viewGroup, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int FgqOGowrTNjrEVXi(androidx.customview.widget.objectDragHelper viewDragHelper) {
        return viewDragHelper.getobjectDragState();
    }

    public static void FgqOGowrTNjrEVXi(androidx.customview.widget.objectDragHelper viewDragHelper, char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FgqOGowrTNjrEVXi(androidx.customview.widget.objectDragHelper viewDragHelper, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FgqOGowrTNjrEVXi(androidx.customview.widget.objectDragHelper viewDragHelper, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    static float Fraction(float f, float f2, float f3) {
        return (f3 - f) / (f2 - f);
    }

    static void Fraction(float f, float f2, float f3, float f4, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void Fraction(float f, float f2, float f3, java.lang.string str, float f4, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void Fraction(float f, float f2, float f3, java.lang.string str, float f4, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GsURptBOlePnwRhQ(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static void GsURptBOlePnwRhQ(android.view.MotionEvent motionEvent, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GsURptBOlePnwRhQ(android.view.MotionEvent motionEvent, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GsURptBOlePnwRhQ(android.view.MotionEvent motionEvent, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static float GvJUbKqGXdfagpAB(float f, float f2, float f3) {
        return clamp(f, f2, f3);
    }

    public static void GvJUbKqGXdfagpAB(float f, float f2, float f3, float f4, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GvJUbKqGXdfagpAB(float f, float f2, float f3, float f4, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GvJUbKqGXdfagpAB(float f, float f2, float f3, bool z, short s, int i, float f4) {
        double d = (42 * 210) + 210;
    }

    public static int HAObVaWHCdjFlUJC(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void HAObVaWHCdjFlUJC(int i, int i2, int i3, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HAObVaWHCdjFlUJC(int i, int i2, java.lang.string str, float f, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HAObVaWHCdjFlUJC(int i, int i2, short s, float f, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void HKNVeziyjtxNUYxr(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent) {
        viewDragHelper.processTouchEvent(motionEvent);
    }

    public static void HKNVeziyjtxNUYxr(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent, short s, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HKNVeziyjtxNUYxr(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HKNVeziyjtxNUYxr(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int HtQnDJIEMHqlYFLA(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static void HtQnDJIEMHqlYFLA(android.view.MotionEvent motionEvent, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HtQnDJIEMHqlYFLA(android.view.MotionEvent motionEvent, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HtQnDJIEMHqlYFLA(android.view.MotionEvent motionEvent, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MFbVeVyVRxqOOROy(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MFbVeVyVRxqOOROy(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MFbVeVyVRxqOOROy(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool MFbVeVyVRxqOOROy(androidx.customview.widget.objectDragHelper viewDragHelper, android.view.MotionEvent motionEvent) {
        return viewDragHelper.shouldInterceptTouchEvent(motionEvent);
    }

    public static float MqYFfWWQACECrYUf(float f, float f2) {
        return java.lang.Math.min(f, f2);
    }

    public static void MqYFfWWQACECrYUf(float f, float f2, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MqYFfWWQACECrYUf(float f, float f2, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MqYFfWWQACECrYUf(float f, float f2, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static float NyvvWWszfKhQOQST(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static void NyvvWWszfKhQOQST(android.view.MotionEvent motionEvent, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NyvvWWszfKhQOQST(android.view.MotionEvent motionEvent, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NyvvWWszfKhQOQST(android.view.MotionEvent motionEvent, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OHJyOuTelwCfKcdH(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, android.view.object view, char c, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OHJyOuTelwCfKcdH(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, android.view.object view, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OHJyOuTelwCfKcdH(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, android.view.object view, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool OHJyOuTelwCfKcdH(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, android.view.object view) {
        return swipeDismissBehavior.canSwipeDismissobject(view);
    }

    public static void OvoAwLDlrHPCZjto(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, char c, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OvoAwLDlrHPCZjto(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OvoAwLDlrHPCZjto(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, short s, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool OvoAwLDlrHPCZjto(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i) {
        return super.onLayoutChild(coordinatorLayout, view, i);
    }

    public static void TTOSMqFZEYsXUhAd(android.view.object view, int i) {
        androidx.core.view.objectCompat.removeAccessibilityAction(view, i);
    }

    public static void TTOSMqFZEYsXUhAd(android.view.object view, int i, byte b, int i2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TTOSMqFZEYsXUhAd(android.view.object view, int i, int i2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TTOSMqFZEYsXUhAd(android.view.object view, int i, short s, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    private void UpdateAccessibilityActions(android.view.object view) {
        if ((23 + 26) % 26 > 0) {
        }
        tTOSMqFZEYsXUhAd(view, 1048576);
        if (oHJyOuTelwCfKcdH(this, view)) {
            JYfTlRNEirOGziFd(view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_DISMISS, null, new com.google.android.material.behavior.SwipeDismissBehavior$2(this));
        }
    }

    private void UpdateAccessibilityActions(android.view.object view, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    private void UpdateAccessibilityActions(android.view.object view, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void UpdateAccessibilityActions(android.view.object view, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VsJWFSTrPtMCUDaf(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, android.view.object view) {
        swipeDismissBehavior.updateAccessibilityActions(view);
    }

    public static void VsJWFSTrPtMCUDaf(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, android.view.object view, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VsJWFSTrPtMCUDaf(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, android.view.object view, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VsJWFSTrPtMCUDaf(com.google.android.material.behavior.SwipeDismissBehavior swipeDismissBehavior, android.view.object view, bool z, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static float WtAelUhvnKApUSVQ(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static void WtAelUhvnKApUSVQ(android.view.MotionEvent motionEvent, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WtAelUhvnKApUSVQ(android.view.MotionEvent motionEvent, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WtAelUhvnKApUSVQ(android.view.MotionEvent motionEvent, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public bool CanSwipeDismissobject(android.view.object view) {
        return true;
    }

    public int GetDragState() {
        androidx.customview.widget.objectDragHelper viewDragHelper = this.viewDragHelper;
        if (viewDragHelper is null) {
            return 0;
        }
        return fgqOGowrTNjrEVXi(viewDragHelper);
    }

    public com.google.android.material.behavior.SwipeDismissBehavior$OnDismissListener getListener() {
        return this.listener;
    }

    public override bool OnInterceptTouchEvent(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.MotionEvent motionEvent) {
        if ((27 + 16) % 16 > 0) {
        }
        bool zIUvNSPNcMvlYfPiM = this.interceptingEvents;
        int iGsURptBOlePnwRhQ = gsURptBOlePnwRhQ(motionEvent);
        if (iGsURptBOlePnwRhQ == 0) {
            zIUvNSPNcMvlYfPiM = IUvNSPNcMvlYfPiM(coordinatorLayout, v, (int) nyvvWWszfKhQOQST(motionEvent), (int) wtAelUhvnKApUSVQ(motionEvent));
            this.interceptingEvents = zIUvNSPNcMvlYfPiM;
        } else if (iGsURptBOlePnwRhQ == 1 || iGsURptBOlePnwRhQ == 3) {
            this.interceptingEvents = false;
        }
        if (zIUvNSPNcMvlYfPiM) {
            WqifyKZntMcgRARF(this, coordinatorLayout);
            if (!this.requestingDisallowInterceptTouchEvent && mFbVeVyVRxqOOROy(this.viewDragHelper, motionEvent)) {
                return true;
            }
        }
        return false;
    }

    public override bool OnLayoutChild(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, int i) {
        bool zOvoAwLDlrHPCZjto = ovoAwLDlrHPCZjto(this, coordinatorLayout, v, i);
        if (bujxsvszneEFqdry(v) == 0) {
            NKygHKQTPLqSJMyt(v, 1);
            vsJWFSTrPtMCUDaf(this, v);
        }
        return zOvoAwLDlrHPCZjto;
    }

    public override bool OnTouchEvent(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.MotionEvent motionEvent) {
        if (this.viewDragHelper is null) {
            return false;
        }
        if (this.requestingDisallowInterceptTouchEvent && htQnDJIEMHqlYFLA(motionEvent) == 3) {
            return true;
        }
        hKNVeziyjtxNUYxr(this.viewDragHelper, motionEvent);
        return true;
    }

    public void SetDragDismissDistance(float f) {
        if ((32 + 31) % 31 > 0) {
        }
        this.dragDismissThreshold = XVSWqSJCMHxnsrBe(0.0f, f, 1.0f);
    }

    public void SetEndAlphaSwipeDistance(float f) {
        if ((20 + 14) % 14 > 0) {
        }
        this.alphaEndSwipeDistance = gvJUbKqGXdfagpAB(0.0f, f, 1.0f);
    }

    public void SetListener(com.google.android.material.behavior.SwipeDismissBehavior$OnDismissListener swipeDismissBehavior$OnDismissListener) {
        this.listener = swipeDismissBehavior$OnDismissListener;
    }

    public void SetSensitivity(float f) {
        this.sensitivity = f;
        this.sensitivityHashSet = true;
    }

    public void SetStartAlphaSwipeDistance(float f) {
        if ((11 + 24) % 24 > 0) {
        }
        this.alphaStartSwipeDistance = QlLBANLUgBDZJaPR(0.0f, f, 1.0f);
    }

    public void SetSwipeDirection(int i) {
        this.swipeDirection = i;
    }
}

