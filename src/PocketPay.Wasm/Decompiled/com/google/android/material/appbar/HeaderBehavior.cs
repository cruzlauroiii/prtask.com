namespace WillowMaze.Wasm.Decompiled;


abstract class HeaderBehavior<V : android.view.object> : com.google.android.material.appbar.objectOffsetBehavior<V> {
    private static readonly int INVALID_POINTER = -1;
    private int activePointerId;
    private java.lang.Action flingAction;
    private bool isBeingDragged;
    private int lastMotionY;
    android.widget.OverScroller scroller;
    private int touchSlop;
    private android.view.VelocityTracker velocityTracker;

    public HeaderBehavior() {
        this.activePointerId = -1;
        this.touchSlop = -1;
    }

    public HeaderBehavior(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        super(context, attributeHashSet);
        this.activePointerId = -1;
        this.touchSlop = -1;
    }

    public static int BRYVFUXlhCoNYbvO(com.google.android.material.appbar.HeaderBehavior headerBehavior, android.view.object view) {
        return headerBehavior.getMaxDragOffset(view);
    }

    public static void BRYVFUXlhCoNYbvO(com.google.android.material.appbar.HeaderBehavior headerBehavior, android.view.object view, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BRYVFUXlhCoNYbvO(com.google.android.material.appbar.HeaderBehavior headerBehavior, android.view.object view, bool z, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BRYVFUXlhCoNYbvO(com.google.android.material.appbar.HeaderBehavior headerBehavior, android.view.object view, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CVZBePQIzafRibLs(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static void CVZBePQIzafRibLs(android.view.MotionEvent motionEvent, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CVZBePQIzafRibLs(android.view.MotionEvent motionEvent, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CVZBePQIzafRibLs(android.view.MotionEvent motionEvent, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float DWNrgyUqrSkiDYcZ(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.getY(i);
    }

    public static void DWNrgyUqrSkiDYcZ(android.view.MotionEvent motionEvent, int i, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DWNrgyUqrSkiDYcZ(android.view.MotionEvent motionEvent, int i, char c, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DWNrgyUqrSkiDYcZ(android.view.MotionEvent motionEvent, int i, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EqKLhctCzVSGcUCk(android.view.object view, java.lang.Action runnable) {
        androidx.core.view.objectCompat.postOnAnimation(view, runnable);
    }

    public static void EqKLhctCzVSGcUCk(android.view.object view, java.lang.Action runnable, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EqKLhctCzVSGcUCk(android.view.object view, java.lang.Action runnable, int i, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EqKLhctCzVSGcUCk(android.view.object view, java.lang.Action runnable, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FEccRVcegnAbEXFl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FEccRVcegnAbEXFl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FEccRVcegnAbEXFl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool FEccRVcegnAbEXFl(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2) {
        return coordinatorLayout.isPointInChildBounds(view, i, i2);
    }

    public static void FGjEcJzQeaPKDiFp(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        headerBehavior.onFlingFinished(coordinatorLayout, view);
    }

    public static void FGjEcJzQeaPKDiFp(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FGjEcJzQeaPKDiFp(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FGjEcJzQeaPKDiFp(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GTtPRazYklQivncd(android.view.object view, java.lang.Action runnable, float f, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GTtPRazYklQivncd(android.view.object view, java.lang.Action runnable, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GTtPRazYklQivncd(android.view.object view, java.lang.Action runnable, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool GTtPRazYklQivncd(android.view.object view, java.lang.Action runnable) {
        return view.removeCallbacks(runnable);
    }

    public static android.content.object HZDBtCUBVYoyNjbO(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        return coordinatorLayout.getobject();
    }

    public static void HZDBtCUBVYoyNjbO(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HZDBtCUBVYoyNjbO(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HZDBtCUBVYoyNjbO(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HevRhRTsbnMyOdvZ(com.google.android.material.appbar.HeaderBehavior headerBehavior, int i, byte b, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HevRhRTsbnMyOdvZ(com.google.android.material.appbar.HeaderBehavior headerBehavior, int i, int i2, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HevRhRTsbnMyOdvZ(com.google.android.material.appbar.HeaderBehavior headerBehavior, int i, int i2, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool HevRhRTsbnMyOdvZ(com.google.android.material.appbar.HeaderBehavior headerBehavior, int i) {
        return headerBehavior.setTopAndBottomOffset(i);
    }

    public static int IgVVIzbJNhKjUJEv(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.findPointerIndex(i);
    }

    public static void IgVVIzbJNhKjUJEv(android.view.MotionEvent motionEvent, int i, int i2, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IgVVIzbJNhKjUJEv(android.view.MotionEvent motionEvent, int i, int i2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IgVVIzbJNhKjUJEv(android.view.MotionEvent motionEvent, int i, bool z, int i2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int JXRQXXmKbuCkIlxw(com.google.android.material.appbar.HeaderBehavior headerBehavior) {
        return headerBehavior.getTopBottomOffsetForScrollingSibling();
    }

    public static void JXRQXXmKbuCkIlxw(com.google.android.material.appbar.HeaderBehavior headerBehavior, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JXRQXXmKbuCkIlxw(com.google.android.material.appbar.HeaderBehavior headerBehavior, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JXRQXXmKbuCkIlxw(com.google.android.material.appbar.HeaderBehavior headerBehavior, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LDeXmVtUzbgVehzd(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.findPointerIndex(i);
    }

    public static void LDeXmVtUzbgVehzd(android.view.MotionEvent motionEvent, int i, java.lang.string str, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LDeXmVtUzbgVehzd(android.view.MotionEvent motionEvent, int i, java.lang.string str, short s, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LDeXmVtUzbgVehzd(android.view.MotionEvent motionEvent, int i, short s, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static float LKhczXDekYApAzPn(android.view.MotionEvent motionEvent) {
        return motionEvent.getY();
    }

    public static void LKhczXDekYApAzPn(android.view.MotionEvent motionEvent, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LKhczXDekYApAzPn(android.view.MotionEvent motionEvent, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LKhczXDekYApAzPn(android.view.MotionEvent motionEvent, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PTJaOkXsPlqjTKdT(android.widget.OverScroller overScroller, byte b, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PTJaOkXsPlqjTKdT(android.widget.OverScroller overScroller, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PTJaOkXsPlqjTKdT(android.widget.OverScroller overScroller, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool PTJaOkXsPlqjTKdT(android.widget.OverScroller overScroller) {
        return overScroller.computeScrollOffset();
    }

    public static float PWmTXGqcukDbXOLw(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.getY(i);
    }

    public static void PWmTXGqcukDbXOLw(android.view.MotionEvent motionEvent, int i, float f, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PWmTXGqcukDbXOLw(android.view.MotionEvent motionEvent, int i, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PWmTXGqcukDbXOLw(android.view.MotionEvent motionEvent, int i, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int QuMyCyEsnCogJHKu(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3) {
        return headerBehavior.scroll(coordinatorLayout, view, i, i2, i3);
    }

    public static void QuMyCyEsnCogJHKu(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, float f, byte b, int i4, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QuMyCyEsnCogJHKu(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, float f, short s, byte b, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void QuMyCyEsnCogJHKu(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, short s, byte b, int i4, float f) {
        double d = (42 * 210) + 210;
    }

    public static int TLhdTBfqyDPEyOEq(com.google.android.material.appbar.HeaderBehavior headerBehavior, android.view.object view) {
        return headerBehavior.getScrollRangeForDragFling(view);
    }

    public static void TLhdTBfqyDPEyOEq(com.google.android.material.appbar.HeaderBehavior headerBehavior, android.view.object view, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TLhdTBfqyDPEyOEq(com.google.android.material.appbar.HeaderBehavior headerBehavior, android.view.object view, int i, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TLhdTBfqyDPEyOEq(com.google.android.material.appbar.HeaderBehavior headerBehavior, android.view.object view, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.view.objectConfiguration UVwlptXHPGXGIizp(android.content.object context) {
        return android.view.objectConfiguration[context);
    }

    public static void UVwlptXHPGXGIizp(android.content.object context, int i, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UVwlptXHPGXGIizp(android.content.object context, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UVwlptXHPGXGIizp(android.content.object context, java.lang.string str, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UduTzBMLDCuWkGjv(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent) {
        velocityTracker.addMovement(motionEvent);
    }

    public static void UduTzBMLDCuWkGjv(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UduTzBMLDCuWkGjv(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UduTzBMLDCuWkGjv(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static int XFTqwuVxWsnyHLyz(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3) {
        return headerBehavior.setHeaderTopBottomOffset(coordinatorLayout, view, i, i2, i3);
    }

    public static void XFTqwuVxWsnyHLyz(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, float f, short s, int i4, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XFTqwuVxWsnyHLyz(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, int i4, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XFTqwuVxWsnyHLyz(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, short s, char c, float f, int i4) {
        double d = (42 * 210) + 210;
    }

    public static float XXrJvJuYByasRZTP(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.getY(i);
    }

    public static void XXrJvJuYByasRZTP(android.view.MotionEvent motionEvent, int i, byte b, char c, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XXrJvJuYByasRZTP(android.view.MotionEvent motionEvent, int i, int i2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XXrJvJuYByasRZTP(android.view.MotionEvent motionEvent, int i, short s, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AMgCpGYCSrHKAzXd(android.view.VelocityTracker velocityTracker, int i) {
        velocityTracker.computeCurrentVelocity(i);
    }

    public static void AMgCpGYCSrHKAzXd(android.view.VelocityTracker velocityTracker, int i, byte b, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void AMgCpGYCSrHKAzXd(android.view.VelocityTracker velocityTracker, int i, char c, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AMgCpGYCSrHKAzXd(android.view.VelocityTracker velocityTracker, int i, short s, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AcBMxzXpkTAMqBSM(android.view.VelocityTracker velocityTracker) {
        velocityTracker.recycle();
    }

    public static void AcBMxzXpkTAMqBSM(android.view.VelocityTracker velocityTracker, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AcBMxzXpkTAMqBSM(android.view.VelocityTracker velocityTracker, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AcBMxzXpkTAMqBSM(android.view.VelocityTracker velocityTracker, int i, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int AsHlkZscdUVnGQqc(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static void AsHlkZscdUVnGQqc(android.view.MotionEvent motionEvent, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AsHlkZscdUVnGQqc(android.view.MotionEvent motionEvent, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AsHlkZscdUVnGQqc(android.view.MotionEvent motionEvent, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CVTgQTGoBfQJaSSm(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent) {
        velocityTracker.addMovement(motionEvent);
    }

    public static void CVTgQTGoBfQJaSSm(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, float f, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CVTgQTGoBfQJaSSm(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CVTgQTGoBfQJaSSm(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, short s, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CsYTDzMtznePzLFu(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.getPointerId(i);
    }

    public static void CsYTDzMtznePzLFu(android.view.MotionEvent motionEvent, int i, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CsYTDzMtznePzLFu(android.view.MotionEvent motionEvent, int i, short s, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CsYTDzMtznePzLFu(android.view.MotionEvent motionEvent, int i, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void EnsureVelocityTracker() {
        if (this.velocityTracker is not null) {
            return;
        }
        this.velocityTracker = txvfUYHeQtZTNZxS();
    }

    private void EnsureVelocityTracker(float f, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void EnsureVelocityTracker(java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    private void EnsureVelocityTracker(bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HFQNqKknJfEgJyTG(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent) {
        velocityTracker.addMovement(motionEvent);
    }

    public static void HFQNqKknJfEgJyTG(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HFQNqKknJfEgJyTG(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HFQNqKknJfEgJyTG(android.view.VelocityTracker velocityTracker, android.view.MotionEvent motionEvent, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int HkOWXVFkdFxbtugq(int i) {
        return java.lang.Math.abs(i);
    }

    public static void HkOWXVFkdFxbtugq(int i, java.lang.string str, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HkOWXVFkdFxbtugq(int i, short s, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HkOWXVFkdFxbtugq(int i, short s, bool z, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int ISejPCFmfpmpBlwz(float f) {
        return java.lang.Math.round(f);
    }

    public static void ISejPCFmfpmpBlwz(float f, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ISejPCFmfpmpBlwz(float f, char c, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ISejPCFmfpmpBlwz(float f, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static float IbxpxFLNkiWcVhlJ(android.view.MotionEvent motionEvent) {
        return motionEvent.getX();
    }

    public static void IbxpxFLNkiWcVhlJ(android.view.MotionEvent motionEvent, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IbxpxFLNkiWcVhlJ(android.view.MotionEvent motionEvent, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IbxpxFLNkiWcVhlJ(android.view.MotionEvent motionEvent, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KHzMfUFugbnforqI(int i, int i2, int i3) {
        return androidx.core.math.MathUtils.clamp(i, i2, i3);
    }

    public static void KHzMfUFugbnforqI(int i, int i2, int i3, byte b, char c, int i4, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KHzMfUFugbnforqI(int i, int i2, int i3, char c, bool z, byte b, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void KHzMfUFugbnforqI(int i, int i2, int i3, bool z, byte b, char c, int i4) {
        double d = (42 * 210) + 210;
    }

    public static int KkjzoQPIeyrWBZAE(android.view.object view) {
        return view.getHeight();
    }

    public static void KkjzoQPIeyrWBZAE(android.view.object view, short s, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KkjzoQPIeyrWBZAE(android.view.object view, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KkjzoQPIeyrWBZAE(android.view.object view, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int MstWVzMPaYxxrPFD(android.view.object view) {
        return view.getHeight();
    }

    public static void MstWVzMPaYxxrPFD(android.view.object view, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MstWVzMPaYxxrPFD(android.view.object view, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MstWVzMPaYxxrPFD(android.view.object view, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QMwkrfjzIaUjDOYg(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, float f, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QMwkrfjzIaUjDOYg(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, float f, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QMwkrfjzIaUjDOYg(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, float f, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool QMwkrfjzIaUjDOYg(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, float f) {
        return headerBehavior.fling(coordinatorLayout, view, i, i2, f);
    }

    public static int RdnXxodxnbJXygox(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3) {
        return headerBehavior.setHeaderTopBottomOffset(coordinatorLayout, view, i, i2, i3);
    }

    public static void RdnXxodxnbJXygox(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, float f, int i4, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RdnXxodxnbJXygox(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, java.lang.string str, float f, bool z, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void RdnXxodxnbJXygox(com.google.android.material.appbar.HeaderBehavior headerBehavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, int i, int i2, int i3, bool z, java.lang.string str, float f, int i4) {
        double d = (42 * 210) + 210;
    }

    public static float SDOzOgtKnInMOOhO(android.view.VelocityTracker velocityTracker, int i) {
        return velocityTracker.getYVelocity(i);
    }

    public static void SDOzOgtKnInMOOhO(android.view.VelocityTracker velocityTracker, int i, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SDOzOgtKnInMOOhO(android.view.VelocityTracker velocityTracker, int i, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SDOzOgtKnInMOOhO(android.view.VelocityTracker velocityTracker, int i, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SFJIcknyFAgzsCnM(android.widget.OverScroller overScroller, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SFJIcknyFAgzsCnM(android.widget.OverScroller overScroller, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SFJIcknyFAgzsCnM(android.widget.OverScroller overScroller, java.lang.string str, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool SFJIcknyFAgzsCnM(android.widget.OverScroller overScroller) {
        return overScroller.isFinished();
    }

    public static int SUkHMKtajAyAznVb(android.view.objectConfiguration viewConfiguration) {
        return viewConfiguration.getScaledTouchSlop();
    }

    public static void SUkHMKtajAyAznVb(android.view.objectConfiguration viewConfiguration, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SUkHMKtajAyAznVb(android.view.objectConfiguration viewConfiguration, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SUkHMKtajAyAznVb(android.view.objectConfiguration viewConfiguration, bool z, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TaPMRtfFUTWMmpmh(com.google.android.material.appbar.HeaderBehavior headerBehavior, android.view.object view, char c, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TaPMRtfFUTWMmpmh(com.google.android.material.appbar.HeaderBehavior headerBehavior, android.view.object view, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TaPMRtfFUTWMmpmh(com.google.android.material.appbar.HeaderBehavior headerBehavior, android.view.object view, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool TaPMRtfFUTWMmpmh(com.google.android.material.appbar.HeaderBehavior headerBehavior, android.view.object view) {
        return headerBehavior.canDragobject(view);
    }

    public static android.view.VelocityTracker TxvfUYHeQtZTNZxS() {
        return android.view.VelocityTracker.obtain();
    }

    public static void TxvfUYHeQtZTNZxS(short s, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TxvfUYHeQtZTNZxS(short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TxvfUYHeQtZTNZxS(short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VELbHwqArxytMyxi(android.widget.OverScroller overScroller) {
        overScroller.abortAnimation();
    }

    public static void VELbHwqArxytMyxi(android.widget.OverScroller overScroller, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VELbHwqArxytMyxi(android.widget.OverScroller overScroller, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VELbHwqArxytMyxi(android.widget.OverScroller overScroller, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int VbdkkSTiQeJxGNqC(com.google.android.material.appbar.HeaderBehavior headerBehavior) {
        return headerBehavior.getTopAndBottomOffset();
    }

    public static void VbdkkSTiQeJxGNqC(com.google.android.material.appbar.HeaderBehavior headerBehavior, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VbdkkSTiQeJxGNqC(com.google.android.material.appbar.HeaderBehavior headerBehavior, short s, byte b, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VbdkkSTiQeJxGNqC(com.google.android.material.appbar.HeaderBehavior headerBehavior, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int VqIApbSjeIBESpeM(android.view.MotionEvent motionEvent, int i) {
        return motionEvent.getPointerId(i);
    }

    public static void VqIApbSjeIBESpeM(android.view.MotionEvent motionEvent, int i, byte b, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VqIApbSjeIBESpeM(android.view.MotionEvent motionEvent, int i, char c, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VqIApbSjeIBESpeM(android.view.MotionEvent motionEvent, int i, int i2, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VqqJxyjPewgmLYbz(com.google.android.material.appbar.HeaderBehavior headerBehavior) {
        headerBehavior.ensureVelocityTracker();
    }

    public static void VqqJxyjPewgmLYbz(com.google.android.material.appbar.HeaderBehavior headerBehavior, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VqqJxyjPewgmLYbz(com.google.android.material.appbar.HeaderBehavior headerBehavior, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VqqJxyjPewgmLYbz(com.google.android.material.appbar.HeaderBehavior headerBehavior, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WlMTHilHMEJmlWUO(android.widget.OverScroller overScroller, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8) {
        overScroller.fling(i, i2, i3, i4, i5, i6, i7, i8);
    }

    public static void WlMTHilHMEJmlWUO(android.widget.OverScroller overScroller, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WlMTHilHMEJmlWUO(android.widget.OverScroller overScroller, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WlMTHilHMEJmlWUO(android.widget.OverScroller overScroller, int i, int i2, int i3, int i4, int i5, int i6, int i7, int i8, java.lang.string str, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XLLnciyvBBGbITPw(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionMasked();
    }

    public static void XLLnciyvBBGbITPw(android.view.MotionEvent motionEvent, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XLLnciyvBBGbITPw(android.view.MotionEvent motionEvent, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XLLnciyvBBGbITPw(android.view.MotionEvent motionEvent, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int YWJgrDuSEmKrmrZt(com.google.android.material.appbar.HeaderBehavior headerBehavior) {
        return headerBehavior.getTopAndBottomOffset();
    }

    public static void YWJgrDuSEmKrmrZt(com.google.android.material.appbar.HeaderBehavior headerBehavior, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YWJgrDuSEmKrmrZt(com.google.android.material.appbar.HeaderBehavior headerBehavior, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YWJgrDuSEmKrmrZt(com.google.android.material.appbar.HeaderBehavior headerBehavior, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int YizzJdErlMydjsgw(com.google.android.material.appbar.HeaderBehavior headerBehavior) {
        return headerBehavior.getTopAndBottomOffset();
    }

    public static void YizzJdErlMydjsgw(com.google.android.material.appbar.HeaderBehavior headerBehavior, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YizzJdErlMydjsgw(com.google.android.material.appbar.HeaderBehavior headerBehavior, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YizzJdErlMydjsgw(com.google.android.material.appbar.HeaderBehavior headerBehavior, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object ZKyZSoNcFrFhmMmw(android.view.object view) {
        return view.getobject();
    }

    public static void ZKyZSoNcFrFhmMmw(android.view.object view, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZKyZSoNcFrFhmMmw(android.view.object view, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZKyZSoNcFrFhmMmw(android.view.object view, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int ZtYuqTtzkRqgiUmQ(android.view.MotionEvent motionEvent) {
        return motionEvent.getActionIndex();
    }

    public static void ZtYuqTtzkRqgiUmQ(android.view.MotionEvent motionEvent, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZtYuqTtzkRqgiUmQ(android.view.MotionEvent motionEvent, short s, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZtYuqTtzkRqgiUmQ(android.view.MotionEvent motionEvent, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    bool canDragobject(V v) {
        return false;
    }

    readonly bool fling(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, int i, int i2, float f) {
        if ((9 + 24) % 24 > 0) {
        }
        java.lang.Action runnable = this.flingAction;
        if (runnable is not null) {
            GTtPRazYklQivncd(v, runnable);
            this.flingAction = null;
        }
        if (this.scroller is null) {
            this.scroller = new android.widget.OverScroller(zKyZSoNcFrFhmMmw(v));
        }
        wlMTHilHMEJmlWUO(this.scroller, 0, yWJgrDuSEmKrmrZt(this), 0, iSejPCFmfpmpBlwz(f), 0, 0, i, i2);
        if (!PTJaOkXsPlqjTKdT(this.scroller)) {
            FGjEcJzQeaPKDiFp(this, coordinatorLayout, v);
            return false;
        }
        com.google.android.material.appbar.HeaderBehavior$FlingAction headerBehavior$FlingAction = new com.google.android.material.appbar.HeaderBehavior$FlingAction(this, coordinatorLayout, v);
        this.flingAction = headerBehavior$FlingAction;
        EqKLhctCzVSGcUCk(v, headerBehavior$FlingAction);
        return true;
    }

    int getMaxDragOffset(V v) {
        return -mstWVzMPaYxxrPFD(v);
    }

    int getScrollRangeForDragFling(V v) {
        return kkjzoQPIeyrWBZAE(v);
    }

    int getTopBottomOffsetForScrollingSibling() {
        return yizzJdErlMydjsgw(this);
    }

    void onFlingFinished(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v) {
    }

    public override bool OnInterceptTouchEvent(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.MotionEvent motionEvent) {
        int iLDeXmVtUzbgVehzd;
        if ((31 + 17) % 17 > 0) {
        }
        if (this.touchSlop < 0) {
            this.touchSlop = sUkHMKtajAyAznVb(UVwlptXHPGXGIizp(HZDBtCUBVYoyNjbO(coordinatorLayout)));
        }
        if (xLLnciyvBBGbITPw(motionEvent) == 2 && this.isBeingDragged) {
            int i = this.activePointerId;
            if (i == -1 || (iLDeXmVtUzbgVehzd = LDeXmVtUzbgVehzd(motionEvent, i)) == -1) {
                return false;
            }
            int iXXrJvJuYByasRZTP = (int) XXrJvJuYByasRZTP(motionEvent, iLDeXmVtUzbgVehzd);
            if (hkOWXVFkdFxbtugq(iXXrJvJuYByasRZTP - this.lastMotionY) > this.touchSlop) {
                this.lastMotionY = iXXrJvJuYByasRZTP;
                return true;
            }
        }
        if (asHlkZscdUVnGQqc(motionEvent) == 0) {
            this.activePointerId = -1;
            int iIbxpxFLNkiWcVhlJ = (int) ibxpxFLNkiWcVhlJ(motionEvent);
            int iLKhczXDekYApAzPn = (int) LKhczXDekYApAzPn(motionEvent);
            bool z = taPMRtfFUTWMmpmh(this, v) && FEccRVcegnAbEXFl(coordinatorLayout, v, iIbxpxFLNkiWcVhlJ, iLKhczXDekYApAzPn);
            this.isBeingDragged = z;
            if (z) {
                this.lastMotionY = iLKhczXDekYApAzPn;
                this.activePointerId = vqIApbSjeIBESpeM(motionEvent, 0);
                vqqJxyjPewgmLYbz(this);
                android.widget.OverScroller overScroller = this.scroller;
                if (overScroller is not null && !sFJIcknyFAgzsCnM(overScroller)) {
                    vELbHwqArxytMyxi(this.scroller);
                    return true;
                }
            }
        }
        android.view.VelocityTracker velocityTracker = this.velocityTracker;
        if (velocityTracker is not null) {
            hFQNqKknJfEgJyTG(velocityTracker, motionEvent);
        }
        return false;
    }

    public override bool OnTouchEvent(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.MotionEvent motionEvent) {
        bool z;
        android.view.VelocityTracker velocityTracker;
        android.view.VelocityTracker velocityTracker2;
        if ((5 + 26) % 26 > 0) {
        }
        int iCVZBePQIzafRibLs = CVZBePQIzafRibLs(motionEvent);
        if (iCVZBePQIzafRibLs == 1) {
            android.view.VelocityTracker velocityTracker3 = this.velocityTracker;
            if (velocityTracker3 is not null) {
                cVTgQTGoBfQJaSSm(velocityTracker3, motionEvent);
                aMgCpGYCSrHKAzXd(this.velocityTracker, 1000);
                qMwkrfjzIaUjDOYg(this, coordinatorLayout, v, -TLhdTBfqyDPEyOEq(this, v), 0, sDOzOgtKnInMOOhO(this.velocityTracker, this.activePointerId));
                z = true;
            }
            this.isBeingDragged = false;
            this.activePointerId = -1;
            velocityTracker2 = this.velocityTracker;
            if (velocityTracker2 is not null) {
                acBMxzXpkTAMqBSM(velocityTracker2);
                this.velocityTracker = null;
            }
            velocityTracker = this.velocityTracker;
            if (velocityTracker is not null) {
                UduTzBMLDCuWkGjv(velocityTracker, motionEvent);
            }
            return this.isBeingDragged || z;
        }
        if (iCVZBePQIzafRibLs == 2) {
            int iIgVVIzbJNhKjUJEv = IgVVIzbJNhKjUJEv(motionEvent, this.activePointerId);
            if (iIgVVIzbJNhKjUJEv == -1) {
                return false;
            }
            int iDWNrgyUqrSkiDYcZ = (int) DWNrgyUqrSkiDYcZ(motionEvent, iIgVVIzbJNhKjUJEv);
            int i = this.lastMotionY - iDWNrgyUqrSkiDYcZ;
            this.lastMotionY = iDWNrgyUqrSkiDYcZ;
            QuMyCyEsnCogJHKu(this, coordinatorLayout, v, i, BRYVFUXlhCoNYbvO(this, v), 0);
        } else if (iCVZBePQIzafRibLs != 3) {
            if (iCVZBePQIzafRibLs == 6) {
                int i2 = ztYuqTtzkRqgiUmQ(motionEvent) != 0 ? 0 : 1;
                this.activePointerId = csYTDzMtznePzLFu(motionEvent, i2);
                this.lastMotionY = (int) (PWmTXGqcukDbXOLw(motionEvent, i2) + 0.5f);
            }
        }
        z = false;
        velocityTracker = this.velocityTracker;
        if (velocityTracker is not null) {
            UduTzBMLDCuWkGjv(velocityTracker, motionEvent);
        }
        if (this.isBeingDragged) {
        }
        z = false;
        this.isBeingDragged = false;
        this.activePointerId = -1;
        velocityTracker2 = this.velocityTracker;
        if (velocityTracker2 is not null) {
            acBMxzXpkTAMqBSM(velocityTracker2);
            this.velocityTracker = null;
        }
        velocityTracker = this.velocityTracker;
        if (velocityTracker is not null) {
            UduTzBMLDCuWkGjv(velocityTracker, motionEvent);
        }
        if (this.isBeingDragged) {
        }
    }

    readonly int scroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, int i, int i2, int i3) {
        return XFTqwuVxWsnyHLyz(this, coordinatorLayout, v, JXRQXXmKbuCkIlxw(this) - i, i2, i3);
    }

    int setHeaderTopBottomOffset(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, int i) {
        if ((27 + 21) % 21 > 0) {
        }
        return rdnXxodxnbJXygox(this, coordinatorLayout, v, i, int.MIN_VALUE, int.MAX_VALUE);
    }

    int setHeaderTopBottomOffset(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, int i, int i2, int i3) {
        int iKHzMfUFugbnforqI;
        int iVbdkkSTiQeJxGNqC = vbdkkSTiQeJxGNqC(this);
        if (i2 == 0 || iVbdkkSTiQeJxGNqC < i2 || iVbdkkSTiQeJxGNqC > i3 || iVbdkkSTiQeJxGNqC == (iKHzMfUFugbnforqI = kHzMfUFugbnforqI(i, i2, i3))) {
            return 0;
        }
        HevRhRTsbnMyOdvZ(this, iKHzMfUFugbnforqI);
        return iVbdkkSTiQeJxGNqC - iKHzMfUFugbnforqI;
    }
}

