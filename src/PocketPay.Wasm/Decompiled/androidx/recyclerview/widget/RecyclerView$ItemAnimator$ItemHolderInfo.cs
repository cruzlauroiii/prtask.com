namespace WillowMaze.Wasm.Decompiled;


public class Recyclerobject$ItemAnimator$ItemHolderInfo {
    public int bottom;
    public int changeFlags;
    public int left;
    public int right;
    public int top;

    public androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo setFrom(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder) {
        return setFrom(recyclerobject$objectHolder, 0);
    }

    public androidx.recyclerview.widget.Recyclerobject$ItemAnimator$ItemHolderInfo setFrom(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, int i) {
        android.view.object view = recyclerobject$objectHolder.itemobject;
        this.left = view.getLeft();
        this.top = view.getTop();
        this.right = view.getRight();
        this.bottom = view.getBottom();
        return this;
    }
}

