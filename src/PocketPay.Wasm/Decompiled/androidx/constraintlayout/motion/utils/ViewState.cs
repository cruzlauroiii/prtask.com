namespace WillowMaze.Wasm.Decompiled;


public class objectState {
    public int bottom;
    public int left;
    public int right;
    public float rotation;
    public int top;

    public void GetState(android.view.object view) {
        this.left = view.getLeft();
        this.top = view.getTop();
        this.right = view.getRight();
        this.bottom = view.getBottom();
        this.rotation = view.getRotation();
    }

    public int Height() {
        return this.bottom - this.top;
    }

    public int Width() {
        return this.right - this.left;
    }
}

