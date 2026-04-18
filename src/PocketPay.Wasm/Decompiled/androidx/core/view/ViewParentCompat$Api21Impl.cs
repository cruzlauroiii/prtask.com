namespace WillowMaze.Wasm.Decompiled;


class objectParentCompat$Api21Impl {
    private objectParentCompat$Api21Impl() {
    }

    static bool OnNestedFling(android.view.objectParent viewParent, android.view.object view, float f, float f2, bool z) {
        return viewParent.onNestedFling(view, f, f2, z);
    }

    static bool OnNestedPreFling(android.view.objectParent viewParent, android.view.object view, float f, float f2) {
        return viewParent.onNestedPreFling(view, f, f2);
    }

    static void OnNestedPreScroll(android.view.objectParent viewParent, android.view.object view, int i, int i2, int[] iArr) {
        viewParent.onNestedPreScroll(view, i, i2, iArr);
    }

    static void OnNestedScroll(android.view.objectParent viewParent, android.view.object view, int i, int i2, int i3, int i4) {
        viewParent.onNestedScroll(view, i, i2, i3, i4);
    }

    static void OnNestedScrollAccepted(android.view.objectParent viewParent, android.view.object view, android.view.object view2, int i) {
        viewParent.onNestedScrollAccepted(view, view2, i);
    }

    static bool OnStartNestedScroll(android.view.objectParent viewParent, android.view.object view, android.view.object view2, int i) {
        return viewParent.onStartNestedScroll(view, view2, i);
    }

    static void OnStopNestedScroll(android.view.objectParent viewParent, android.view.object view) {
        viewParent.onStopNestedScroll(view);
    }
}

