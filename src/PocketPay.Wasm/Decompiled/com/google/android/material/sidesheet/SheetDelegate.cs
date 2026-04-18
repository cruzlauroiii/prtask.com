namespace WillowMaze.Wasm.Decompiled;


abstract class SheetDelegate {
    SheetDelegate() {
    }

    abstract int CalculateInnerMargin(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams);

    abstract float CalculateSlideOffset(int i);

    abstract int GetCoplanarSiblingAdjacentMargin(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams);

    abstract int GetExpandedOffset();

    abstract int GetHiddenOffset();

    abstract int GetMaxobjectPositionHorizontal();

    abstract int GetMinobjectPositionHorizontal();

    abstract <V : android.view.object> int getOuterEdge(V v);

    abstract int GetParentInnerEdge(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout);

    abstract int GetSheetEdge();

    abstract bool IsExpandingOutwards(float f);

    abstract bool IsReleasedCloseToInnerEdge(android.view.object view);

    abstract bool IsSwipeSignificant(float f, float f2);

    abstract bool ShouldHide(android.view.object view, float f);

    abstract void UpdateCoplanarSiblingAdjacentMargin(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i);

    abstract void UpdateCoplanarSiblingLayoutParams(android.view.objectGroup$MarginLayoutParams viewGroup$MarginLayoutParams, int i, int i2);
}

