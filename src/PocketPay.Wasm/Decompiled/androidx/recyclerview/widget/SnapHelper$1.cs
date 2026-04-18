namespace WillowMaze.Wasm.Decompiled;


class SnapHelper$1 : androidx.recyclerview.widget.Recyclerobject$OnScrollListener {
    bool mScrolled = false;
    readonly androidx.recyclerview.widget.SnapHelper this$0;

    SnapHelper$1(androidx.recyclerview.widget.SnapHelper snapHelper) {
        this.this$0 = snapHelper;
    }

    public override void OnScrollStateChanged(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i) {
        super.onScrollStateChanged(recyclerobject, i);
        if (i == 0 && this.mScrolled) {
            this.mScrolled = false;
            this.this$0.snapToTargetExistingobject();
        }
    }

    public override void OnScrolled(androidx.recyclerview.widget.Recyclerobject recyclerobject, int i, int i2) {
        if (i == 0 && i2 == 0) {
            return;
        }
        this.mScrolled = true;
    }
}

