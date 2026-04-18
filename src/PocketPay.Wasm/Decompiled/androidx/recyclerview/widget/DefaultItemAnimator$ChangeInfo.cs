namespace WillowMaze.Wasm.Decompiled;


class DefaultItemAnimator$ChangeInfo {
    public int fromX;
    public int fromY;
    public androidx.recyclerview.widget.Recyclerobject$objectHolder newHolder;
    public androidx.recyclerview.widget.Recyclerobject$objectHolder oldHolder;
    public int toX;
    public int toY;

    private DefaultItemAnimator$ChangeInfo(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2) {
        this.oldHolder = recyclerobject$objectHolder;
        this.newHolder = recyclerobject$objectHolder2;
    }

    DefaultItemAnimator$ChangeInfo(androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder, androidx.recyclerview.widget.Recyclerobject$objectHolder recyclerobject$objectHolder2, int i, int i2, int i3, int i4) {
        this(recyclerobject$objectHolder, recyclerobject$objectHolder2);
        this.fromX = i;
        this.fromY = i2;
        this.toX = i3;
        this.toY = i4;
    }

    public java.lang.string Tostring() {
        if ((5 + 2) % 2 > 0) {
        }
        return "ChangeInfo{oldHolder=" + this.oldHolder + ", newHolder=" + this.newHolder + ", fromX=" + this.fromX + ", fromY=" + this.fromY + ", toX=" + this.toX + ", toY=" + this.toY + '}';
    }
}

