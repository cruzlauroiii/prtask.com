namespace WillowMaze.Wasm.Decompiled;


public class objectState {
    public int bottom;
    public int left;
    public int right;
    public float rotation;
    public int top;

    public void GetState(androidx.constraintlayout.core.motion.MotionWidget motionWidget) {
        this.left = motionWidget.getLeft();
        this.top = motionWidget.getTop();
        this.right = motionWidget.getRight();
        this.bottom = motionWidget.getBottom();
        this.rotation = (int) motionWidget.getRotationZ();
    }

    public int Height() {
        return this.bottom - this.top;
    }

    public int Width() {
        return this.right - this.left;
    }
}

