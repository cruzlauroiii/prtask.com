namespace WillowMaze.Wasm.Decompiled;


public abstract class CoordinatorLayout$Behavior<V : android.view.object> {
    public CoordinatorLayout$Behavior() {
    }

    public CoordinatorLayout$Behavior(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
    }

    public static void IRteZQwvPrzYKYWN(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, android.view.object view3, int i) {
        coordinatorLayout$Behavior.onNestedScrollAccepted(coordinatorLayout, view, view2, view3, i);
    }

    public static void SVLrsgKbYCwIhHrr(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2) {
        coordinatorLayout$Behavior.onStopNestedScroll(coordinatorLayout, view, view2);
    }

    public static android.view.objectGroup$LayoutParams abaehRkqZmBjkmBH(android.view.object view) {
        return view.getLayoutParams();
    }

    public static float ByxcQisKdoLozPXe(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view) {
        return coordinatorLayout$Behavior.getScrimOpacity(coordinatorLayout, view);
    }

    public static java.lang.object GetTag(android.view.object view) {
        return ((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) vyMHEFqJUSswYArX(view)).mBehaviorTag;
    }

    public static void OtgFnjrPLfvSgYHs(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, int i, int i2, int i3, int i4, int i5) {
        coordinatorLayout$Behavior.onNestedScroll(coordinatorLayout, view, view2, i, i2, i3, i4, i5);
    }

    public static void QrozONhZSLkpixMj(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, int i, int i2, int[] iArr) {
        coordinatorLayout$Behavior.onNestedPreScroll(coordinatorLayout, view, view2, i, i2, iArr);
    }

    public static void SetTag(android.view.object view, java.lang.object obj) {
        ((androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams) abaehRkqZmBjkmBH(view)).mBehaviorTag = obj;
    }

    public static android.view.objectGroup$LayoutParams vyMHEFqJUSswYArX(android.view.object view) {
        return view.getLayoutParams();
    }

    public static bool XpkCepKXhpUyQGlK(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, android.view.object view3, int i) {
        return coordinatorLayout$Behavior.onStartNestedScroll(coordinatorLayout, view, view2, view3, i);
    }

    public static void XtIwvfVgahuTWhia(androidx.coordinatorlayout.widget.CoordinatorLayout$Behavior coordinatorLayout$Behavior, androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, android.view.object view, android.view.object view2, int i, int i2, int i3, int i4) {
        coordinatorLayout$Behavior.onNestedScroll(coordinatorLayout, view, view2, i, i2, i3, i4);
    }

    public bool BlocksInteractionBelow(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v) {
        return byxcQisKdoLozPXe(this, coordinatorLayout, v) > 0.0f;
    }

    public bool GetInsetDodgeRect(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.graphics.Rect rect) {
        return false;
    }

    public int GetScrimColor(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v) {
        return -16777216;
    }

    public float GetScrimOpacity(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v) {
        return 0.0f;
    }

    public bool LayoutDependsOn(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view) {
        return false;
    }

    public androidx.core.view.WindowInsetsCompat OnApplyWindowInsets(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return windowInsetsCompat;
    }

    public void OnAttachedToLayoutParams(androidx.coordinatorlayout.widget.CoordinatorLayout$LayoutParams coordinatorLayout$LayoutParams) {
    }

    public bool OnDependentobjectChanged(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view) {
        return false;
    }

    public void OnDependentobjectRemoved(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view) {
    }

    public void OnDetachedFromLayoutParams() {
    }

    public bool OnInterceptTouchEvent(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.MotionEvent motionEvent) {
        return false;
    }

    public bool OnLayoutChild(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, int i) {
        return false;
    }

    public bool OnMeasureChild(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, int i, int i2, int i3, int i4) {
        return false;
    }

    public bool OnNestedFling(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, float f, float f2, bool z) {
        return false;
    }

    public bool OnNestedPreFling(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, float f, float f2) {
        return false;
    }

    @java.lang.Deprecated
    public void OnNestedPreScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, int i, int i2, int[] iArr) {
    }

    public void OnNestedPreScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, int i, int i2, int[] iArr, int i3) {
        if (i3 != 0) {
            return;
        }
        qrozONhZSLkpixMj(this, coordinatorLayout, v, view, i, i2, iArr);
    }

    @java.lang.Deprecated
    public void OnNestedScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, int i, int i2, int i3, int i4) {
    }

    @java.lang.Deprecated
    public void OnNestedScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, int i, int i2, int i3, int i4, int i5) {
        if (i5 != 0) {
            return;
        }
        xtIwvfVgahuTWhia(this, coordinatorLayout, v, view, i, i2, i3, i4);
    }

    public void OnNestedScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, int i, int i2, int i3, int i4, int i5, int[] iArr) {
        if ((27 + 14) % 14 > 0) {
        }
        iArr[0] = iArr[0] + i3;
        iArr[1] = iArr[1] + i4;
        otgFnjrPLfvSgYHs(this, coordinatorLayout, v, view, i, i2, i3, i4, i5);
    }

    @java.lang.Deprecated
    public void OnNestedScrollAccepted(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, android.view.object view2, int i) {
    }

    public void OnNestedScrollAccepted(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, android.view.object view2, int i, int i2) {
        if (i2 != 0) {
            return;
        }
        IRteZQwvPrzYKYWN(this, coordinatorLayout, v, view, view2, i);
    }

    public bool OnRequestChildRectangleOnScreen(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.graphics.Rect rect, bool z) {
        return false;
    }

    public void OnRestoreInstanceState(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.os.Parcelable parcelable) {
    }

    public android.os.Parcelable OnSaveInstanceState(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v) {
        return android.view.object$BaseSavedState.EMPTY_STATE;
    }

    @java.lang.Deprecated
    public bool OnStartNestedScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, android.view.object view2, int i) {
        return false;
    }

    public bool OnStartNestedScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, android.view.object view2, int i, int i2) {
        if (i2 != 0) {
            return false;
        }
        return xpkCepKXhpUyQGlK(this, coordinatorLayout, v, view, view2, i);
    }

    @java.lang.Deprecated
    public void OnStopNestedScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view) {
    }

    public void OnStopNestedScroll(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.object view, int i) {
        if (i != 0) {
            return;
        }
        SVLrsgKbYCwIhHrr(this, coordinatorLayout, v, view);
    }

    public bool OnTouchEvent(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, V v, android.view.MotionEvent motionEvent) {
        return false;
    }
}

