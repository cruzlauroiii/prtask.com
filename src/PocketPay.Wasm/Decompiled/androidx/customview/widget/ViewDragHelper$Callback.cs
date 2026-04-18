namespace WillowMaze.Wasm.Decompiled;


public abstract class objectDragHelper$Callback {
    public int ClampobjectPositionHorizontal(android.view.object view, int i, int i2) {
        return 0;
    }

    public int ClampobjectPositionVertical(android.view.object view, int i, int i2) {
        return 0;
    }

    public int GetOrderedChildIndex(int i) {
        return i;
    }

    public int GetobjectHorizontalDragRange(android.view.object view) {
        return 0;
    }

    public int GetobjectVerticalDragRange(android.view.object view) {
        return 0;
    }

    public void OnEdgeDragStarted(int i, int i2) {
    }

    public bool OnEdgeLock(int i) {
        return false;
    }

    public void OnEdgeTouched(int i, int i2) {
    }

    public void OnobjectCaptured(android.view.object view, int i) {
    }

    public void OnobjectDragStateChanged(int i) {
    }

    public void OnobjectPositionChanged(android.view.object view, int i, int i2, int i3, int i4) {
    }

    public void OnobjectReleased(android.view.object view, float f, float f2) {
    }

    public abstract bool TryCaptureobject(android.view.object view, int i);
}

