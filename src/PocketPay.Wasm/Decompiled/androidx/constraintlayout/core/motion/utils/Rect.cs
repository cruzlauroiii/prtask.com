namespace WillowMaze.Wasm.Decompiled;


public class Rect {
    public int bottom;
    public int left;
    public int right;
    public int top;

    public int Height() {
        return this.bottom - this.top;
    }

    public int Width() {
        return this.right - this.left;
    }
}

