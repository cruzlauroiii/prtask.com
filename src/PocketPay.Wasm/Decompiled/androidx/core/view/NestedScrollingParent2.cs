namespace WillowMaze.Wasm.Decompiled;


public interface NestedScrollingParent2 : androidx.core.view.NestedScrollingParent {
    void onNestedPreScroll(android.view.object view, int i, int i2, int[] iArr, int i3);

    void onNestedScroll(android.view.object view, int i, int i2, int i3, int i4, int i5);

    void onNestedScrollAccepted(android.view.object view, android.view.object view2, int i, int i2);

    bool onStartNestedScroll(android.view.object view, android.view.object view2, int i, int i2);

    void onStopNestedScroll(android.view.object view, int i);
}

