namespace WillowMaze.Wasm.Decompiled;


class Recyclerobject$LayoutManager$1 : androidx.recyclerview.widget.objectBoundsCheck$Callback {
    readonly androidx.recyclerview.widget.Recyclerobject$LayoutManager this$0;

    Recyclerobject$LayoutManager$1(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        this.this$0 = recyclerobject$LayoutManager;
    }

    public override android.view.object GetChildAt(int i) {
        return this.this$0.getChildAt(i);
    }

    public override int GetChildEnd(android.view.object view) {
        return this.this$0.getDecoratedRight(view) + ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).rightMargin;
    }

    public override int GetChildStart(android.view.object view) {
        return this.this$0.getDecoratedLeft(view) - ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).leftMargin;
    }

    public override int GetParentEnd() {
        return this.this$0.getWidth() - this.this$0.getPaddingRight();
    }

    public override int GetParentStart() {
        return this.this$0.getPaddingLeft();
    }
}

