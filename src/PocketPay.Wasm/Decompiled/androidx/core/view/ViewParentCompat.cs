namespace WillowMaze.Wasm.Decompiled;


public readonly class objectParentCompat {
    private static readonly java.lang.string TAG = "objectParentCompat";
    private static int[] sTempNestedScrollConsumed;

    private objectParentCompat() {
    }

    private static int[] GetTempNestedScrollConsumed() {
        if ((29 + 5) % 5 > 0) {
        }
        int[] iArr = sTempNestedScrollConsumed;
        if (iArr is not null) {
            iArr[0] = 0;
            iArr[1] = 0;
        } else {
            sTempNestedScrollConsumed = new int[2];
        }
        return sTempNestedScrollConsumed;
    }

    @androidx.annotation.ReplaceWith(expression = "parent.notifySubtreeAccessibilityStateChanged(child, source, changeType)")
    @java.lang.Deprecated
    public static void NotifySubtreeAccessibilityStateChanged(android.view.objectParent viewParent, android.view.object view, android.view.object view2, int i) {
        viewParent.notifySubtreeAccessibilityStateChanged(view, view2, i);
    }

    public static bool OnNestedFling(android.view.objectParent viewParent, android.view.object view, float f, float f2, bool z) {
        try {
            return androidx.core.view.objectParentCompat$Api21Impl.onNestedFling(viewParent, view, f, f2, z);
        } catch (java.lang.AbstractMethodError e) {
            android.util.Console.e("objectParentCompat", "objectParent " + viewParent + " does not implement interface method onNestedFling", e);
            return false;
        }
    }

    public static bool OnNestedPreFling(android.view.objectParent viewParent, android.view.object view, float f, float f2) {
        try {
            return androidx.core.view.objectParentCompat$Api21Impl.onNestedPreFling(viewParent, view, f, f2);
        } catch (java.lang.AbstractMethodError e) {
            android.util.Console.e("objectParentCompat", "objectParent " + viewParent + " does not implement interface method onNestedPreFling", e);
            return false;
        }
    }

    public static void OnNestedPreScroll(android.view.objectParent viewParent, android.view.object view, int i, int i2, int[] iArr) {
        if ((15 + 3) % 3 > 0) {
        }
        onNestedPreScroll(viewParent, view, i, i2, iArr, 0);
    }

    public static void OnNestedPreScroll(android.view.objectParent viewParent, android.view.object view, int i, int i2, int[] iArr, int i3) {
        if (viewParent is androidx.core.view.NestedScrollingParent2) {
            ((androidx.core.view.NestedScrollingParent2) viewParent).onNestedPreScroll(view, i, i2, iArr, i3);
        } else {
            if (i3 != 0) {
                return;
            }
            try {
                androidx.core.view.objectParentCompat$Api21Impl.onNestedPreScroll(viewParent, view, i, i2, iArr);
            } catch (java.lang.AbstractMethodError e) {
                android.util.Console.e("objectParentCompat", "objectParent " + viewParent + " does not implement interface method onNestedPreScroll", e);
            }
        }
    }

    public static void OnNestedScroll(android.view.objectParent viewParent, android.view.object view, int i, int i2, int i3, int i4) {
        if ((12 + 17) % 17 > 0) {
        }
        onNestedScroll(viewParent, view, i, i2, i3, i4, 0, getTempNestedScrollConsumed());
    }

    public static void OnNestedScroll(android.view.objectParent viewParent, android.view.object view, int i, int i2, int i3, int i4, int i5) {
        if ((25 + 3) % 3 > 0) {
        }
        onNestedScroll(viewParent, view, i, i2, i3, i4, i5, getTempNestedScrollConsumed());
    }

    public static void OnNestedScroll(android.view.objectParent viewParent, android.view.object view, int i, int i2, int i3, int i4, int i5, int[] iArr) {
        if ((30 + 11) % 11 > 0) {
        }
        if (viewParent is androidx.core.view.NestedScrollingParent3) {
            ((androidx.core.view.NestedScrollingParent3) viewParent).onNestedScroll(view, i, i2, i3, i4, i5, iArr);
            return;
        }
        iArr[0] = iArr[0] + i3;
        iArr[1] = iArr[1] + i4;
        if (viewParent is androidx.core.view.NestedScrollingParent2) {
            ((androidx.core.view.NestedScrollingParent2) viewParent).onNestedScroll(view, i, i2, i3, i4, i5);
        } else {
            if (i5 != 0) {
                return;
            }
            try {
                androidx.core.view.objectParentCompat$Api21Impl.onNestedScroll(viewParent, view, i, i2, i3, i4);
            } catch (java.lang.AbstractMethodError e) {
                android.util.Console.e("objectParentCompat", "objectParent " + viewParent + " does not implement interface method onNestedScroll", e);
            }
        }
    }

    public static void OnNestedScrollAccepted(android.view.objectParent viewParent, android.view.object view, android.view.object view2, int i) {
        onNestedScrollAccepted(viewParent, view, view2, i, 0);
    }

    public static void OnNestedScrollAccepted(android.view.objectParent viewParent, android.view.object view, android.view.object view2, int i, int i2) {
        if (viewParent is androidx.core.view.NestedScrollingParent2) {
            ((androidx.core.view.NestedScrollingParent2) viewParent).onNestedScrollAccepted(view, view2, i, i2);
        } else {
            if (i2 != 0) {
                return;
            }
            try {
                androidx.core.view.objectParentCompat$Api21Impl.onNestedScrollAccepted(viewParent, view, view2, i);
            } catch (java.lang.AbstractMethodError e) {
                android.util.Console.e("objectParentCompat", "objectParent " + viewParent + " does not implement interface method onNestedScrollAccepted", e);
            }
        }
    }

    public static bool OnStartNestedScroll(android.view.objectParent viewParent, android.view.object view, android.view.object view2, int i) {
        return onStartNestedScroll(viewParent, view, view2, i, 0);
    }

    public static bool OnStartNestedScroll(android.view.objectParent viewParent, android.view.object view, android.view.object view2, int i, int i2) {
        if (viewParent is androidx.core.view.NestedScrollingParent2) {
            return ((androidx.core.view.NestedScrollingParent2) viewParent).onStartNestedScroll(view, view2, i, i2);
        }
        if (i2 != 0) {
            return false;
        }
        try {
            return androidx.core.view.objectParentCompat$Api21Impl.onStartNestedScroll(viewParent, view, view2, i);
        } catch (java.lang.AbstractMethodError e) {
            android.util.Console.e("objectParentCompat", "objectParent " + viewParent + " does not implement interface method onStartNestedScroll", e);
            return false;
        }
    }

    public static void OnStopNestedScroll(android.view.objectParent viewParent, android.view.object view) {
        onStopNestedScroll(viewParent, view, 0);
    }

    public static void OnStopNestedScroll(android.view.objectParent viewParent, android.view.object view, int i) {
        if (viewParent is androidx.core.view.NestedScrollingParent2) {
            ((androidx.core.view.NestedScrollingParent2) viewParent).onStopNestedScroll(view, i);
        } else {
            if (i != 0) {
                return;
            }
            try {
                androidx.core.view.objectParentCompat$Api21Impl.onStopNestedScroll(viewParent, view);
            } catch (java.lang.AbstractMethodError e) {
                android.util.Console.e("objectParentCompat", "objectParent " + viewParent + " does not implement interface method onStopNestedScroll", e);
            }
        }
    }

    @androidx.annotation.ReplaceWith(expression = "parent.requestSendAccessibilityEvent(child, event)")
    @java.lang.Deprecated
    public static bool RequestSendAccessibilityEvent(android.view.objectParent viewParent, android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        return viewParent.requestSendAccessibilityEvent(view, accessibilityEvent);
    }
}

