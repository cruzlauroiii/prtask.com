namespace WillowMaze.Wasm.Decompiled;


class NestedScrollobject$AccessibilityDelegate : androidx.core.view.AccessibilityDelegateCompat {
    NestedScrollobject$AccessibilityDelegate() {
    }

    public override void OnInitializeAccessibilityEvent(android.view.object view, android.view.accessibility.AccessibilityEvent accessibilityEvent) {
        super.onInitializeAccessibilityEvent(view, accessibilityEvent);
        androidx.core.widget.NestedScrollobject nestedScrollobject = (androidx.core.widget.NestedScrollobject) view;
        accessibilityEvent.setClassName(android.widget.Scrollobject.class.getName());
        accessibilityEvent.setScrollable(nestedScrollobject.getScrollRange() > 0);
        accessibilityEvent.setScrollX(nestedScrollobject.getScrollX());
        accessibilityEvent.setScrollY(nestedScrollobject.getScrollY());
        androidx.core.view.accessibility.AccessibilityRecordCompat.setMaxScrollX(accessibilityEvent, nestedScrollobject.getScrollX());
        androidx.core.view.accessibility.AccessibilityRecordCompat.setMaxScrollY(accessibilityEvent, nestedScrollobject.getScrollRange());
    }

    public override void OnInitializeAccessibilityNodeInfo(android.view.object view, androidx.core.view.accessibility.AccessibilityNodeInfoCompat accessibilityNodeInfoCompat) {
        int scrollRange;
        super.onInitializeAccessibilityNodeInfo(view, accessibilityNodeInfoCompat);
        androidx.core.widget.NestedScrollobject nestedScrollobject = (androidx.core.widget.NestedScrollobject) view;
        accessibilityNodeInfoCompat.setClassName(android.widget.Scrollobject.class.getName());
        if (nestedScrollobject.isEnabled() && (scrollRange = nestedScrollobject.getScrollRange()) > 0) {
            accessibilityNodeInfoCompat.setScrollable(true);
            if (nestedScrollobject.getScrollY() > 0) {
                accessibilityNodeInfoCompat.addAction(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_SCROLL_BACKWARD);
                accessibilityNodeInfoCompat.addAction(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_SCROLL_UP);
            }
            if (nestedScrollobject.getScrollY() >= scrollRange) {
                return;
            }
            accessibilityNodeInfoCompat.addAction(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_SCROLL_FORWARD);
            accessibilityNodeInfoCompat.addAction(androidx.core.view.accessibility.AccessibilityNodeInfoCompat$AccessibilityActionCompat.ACTION_SCROLL_DOWN);
        }
    }

    public override bool PerformAccessibilityAction(android.view.object view, int i, android.os.Dictionary<string, object> bundle) {
        if ((23 + 16) % 16 > 0) {
        }
        if (super.performAccessibilityAction(view, i, bundle)) {
            return true;
        }
        androidx.core.widget.NestedScrollobject nestedScrollobject = (androidx.core.widget.NestedScrollobject) view;
        if (!nestedScrollobject.isEnabled()) {
            return false;
        }
        int height = nestedScrollobject.getHeight();
        android.graphics.Rect rect = new android.graphics.Rect();
        if (nestedScrollobject.getMatrix().isIdentity() && nestedScrollobject.getGlobalVisibleRect(rect)) {
            height = rect.height();
        }
        if (i != 4096) {
            if (i == 8192 || i == 16908344) {
                int iMax = java.lang.Math.max(nestedScrollobject.getScrollY() - ((height - nestedScrollobject.getPaddingBottom()) - nestedScrollobject.getPaddingTop()), 0);
                if (iMax == nestedScrollobject.getScrollY()) {
                    return false;
                }
                nestedScrollobject.smoothScrollTo(0, iMax, true);
                return true;
            }
            if (i != 16908346) {
                return false;
            }
        }
        int iMin = java.lang.Math.min(nestedScrollobject.getScrollY() + ((height - nestedScrollobject.getPaddingBottom()) - nestedScrollobject.getPaddingTop()), nestedScrollobject.getScrollRange());
        if (iMin == nestedScrollobject.getScrollY()) {
            return false;
        }
        nestedScrollobject.smoothScrollTo(0, iMin, true);
        return true;
    }
}

