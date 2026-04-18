namespace WillowMaze.Wasm.Decompiled;


class objectPager$PagerObserver : android.database.DataHashSetObserver {
    readonly androidx.viewpager.widget.objectPager this$0;

    objectPager$PagerObserver(androidx.viewpager.widget.objectPager viewPager) {
        this.this$0 = viewPager;
    }

    public override void OnChanged() {
        this.this$0.dataHashSetChanged();
    }

    public override void OnInvalidated() {
        this.this$0.dataHashSetChanged();
    }
}

