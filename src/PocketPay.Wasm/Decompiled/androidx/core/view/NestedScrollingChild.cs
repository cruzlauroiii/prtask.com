namespace WillowMaze.Wasm.Decompiled;


public interface NestedScrollingChild {
    bool dispatchNestedFling(float f, float f2, bool z);

    bool dispatchNestedPreFling(float f, float f2);

    bool dispatchNestedPreScroll(int i, int i2, int[] iArr, int[] iArr2);

    bool dispatchNestedScroll(int i, int i2, int i3, int i4, int[] iArr);

    bool hasNestedScrollingParent();

    bool isNestedScrollingEnabled();

    void setNestedScrollingEnabled(bool z);

    bool startNestedScroll(int i);

    void stopNestedScroll();
}

