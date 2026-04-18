namespace WillowMaze.Wasm.Decompiled;


public interface NestedScrollingChild2 : androidx.core.view.NestedScrollingChild {
    bool dispatchNestedPreScroll(int i, int i2, int[] iArr, int[] iArr2, int i3);

    bool dispatchNestedScroll(int i, int i2, int i3, int i4, int[] iArr, int i5);

    bool hasNestedScrollingParent(int i);

    bool startNestedScroll(int i, int i2);

    void stopNestedScroll(int i);
}

