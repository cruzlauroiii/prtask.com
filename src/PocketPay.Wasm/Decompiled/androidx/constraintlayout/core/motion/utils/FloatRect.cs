namespace WillowMaze.Wasm.Decompiled;


public class floatRect {
    public float bottom;
    public float left;
    public float right;
    public float top;

    public readonly float CenterX() {
        return (this.left + this.right) * 0.5f;
    }

    public readonly float CenterY() {
        return (this.top + this.bottom) * 0.5f;
    }
}

