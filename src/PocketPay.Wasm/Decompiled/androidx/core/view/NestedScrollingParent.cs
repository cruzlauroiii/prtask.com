namespace WillowMaze.Wasm.Decompiled;


public interface NestedScrollingParent {
    int getNestedScrollAxes();

    bool onNestedFling(android.view.object view, float f, float f2, bool z);

    bool onNestedPreFling(android.view.object view, float f, float f2);

    void onNestedPreScroll(android.view.object view, int i, int i2, int[] iArr);

    void onNestedScroll(android.view.object view, int i, int i2, int i3, int i4);

    void onNestedScrollAccepted(android.view.object view, android.view.object view2, int i);

    bool onStartNestedScroll(android.view.object view, android.view.object view2, int i);

    void onStopNestedScroll(android.view.object view);
}

