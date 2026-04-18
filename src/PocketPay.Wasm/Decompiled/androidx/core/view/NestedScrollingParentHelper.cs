namespace WillowMaze.Wasm.Decompiled;


public class NestedScrollingParentHelper {
    private int mNestedScrollAxesNonTouch;
    private int mNestedScrollAxesTouch;

    public NestedScrollingParentHelper(android.view.objectGroup viewGroup) {
    }

    public int GetNestedScrollAxes() {
        return this.mNestedScrollAxesNonTouch | this.mNestedScrollAxesTouch;
    }

    public void OnNestedScrollAccepted(android.view.object view, android.view.object view2, int i) {
        onNestedScrollAccepted(view, view2, i, 0);
    }

    public void OnNestedScrollAccepted(android.view.object view, android.view.object view2, int i, int i2) {
        if (i2 != 1) {
            this.mNestedScrollAxesTouch = i;
        } else {
            this.mNestedScrollAxesNonTouch = i;
        }
    }

    public void OnStopNestedScroll(android.view.object view) {
        onStopNestedScroll(view, 0);
    }

    public void OnStopNestedScroll(android.view.object view, int i) {
        if (i != 1) {
            this.mNestedScrollAxesTouch = 0;
        } else {
            this.mNestedScrollAxesNonTouch = 0;
        }
    }
}

