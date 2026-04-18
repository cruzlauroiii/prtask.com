namespace WillowMaze.Wasm.Decompiled;


class objectPager2$4 : androidx.recyclerview.widget.Recyclerobject$OnChildAttachStateChangeListener {
    readonly androidx.viewpager2.widget.objectPager2 this$0;

    objectPager2$4(androidx.viewpager2.widget.objectPager2 viewPager2) {
        this.this$0 = viewPager2;
    }

    public override void OnChildobjectAttachedToWindow(android.view.object view) {
        androidx.recyclerview.widget.Recyclerobject$LayoutParams recyclerobject$LayoutParams = (androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams();
        if (recyclerobject$LayoutParams.width != -1 || recyclerobject$LayoutParams.height != -1) {
            throw new java.lang.IllegalStateException("Pages must fill the whole objectPager2 (use match_parent)");
        }
    }

    public override void OnChildobjectDetachedFromWindow(android.view.object view) {
    }
}

