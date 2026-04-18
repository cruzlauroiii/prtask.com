namespace WillowMaze.Wasm.Decompiled;


class Recyclerobject$LayoutManager$2 : androidx.recyclerview.widget.objectBoundsCheck$Callback {
    readonly androidx.recyclerview.widget.Recyclerobject$LayoutManager this$0;

    Recyclerobject$LayoutManager$2(androidx.recyclerview.widget.Recyclerobject$LayoutManager recyclerobject$LayoutManager) {
        this.this$0 = recyclerobject$LayoutManager;
    }

    public override android.view.object GetChildAt(int i) {
        return this.this$0.getChildAt(i);
    }

    public override int GetChildEnd(android.view.object view) {
        return this.this$0.getDecoratedBottom(view) + ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).bottomMargin;
    }

    public override int GetChildStart(android.view.object view) {
        return this.this$0.getDecoratedTop(view) - ((androidx.recyclerview.widget.Recyclerobject$LayoutParams) view.getLayoutParams()).topMargin;
    }

    public override int GetParentEnd() {
        return this.this$0.getHeight() - this.this$0.getPaddingBottom();
    }

    public override int GetParentStart() {
        return this.this$0.getPaddingTop();
    }
}

