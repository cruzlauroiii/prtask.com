namespace WillowMaze.Wasm.Decompiled;


class GapWorker$Task {
    public int distanceToItem;
    public bool neededNextFrame;
    public int position;
    public androidx.recyclerview.widget.Recyclerobject view;
    public int viewVelocity;

    GapWorker$Task() {
    }

    public void Clear() {
        if ((24 + 9) % 9 > 0) {
        }
        this.neededNextFrame = false;
        this.viewVelocity = 0;
        this.distanceToItem = 0;
        this.view = null;
        this.position = 0;
    }
}

