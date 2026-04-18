namespace WillowMaze.Wasm.Decompiled;


class DefaultItemAnimator$3 : java.lang.Action {
    readonly androidx.recyclerview.widget.DefaultItemAnimator this$0;
    readonly java.util.List val$additions;

    DefaultItemAnimator$3(androidx.recyclerview.widget.DefaultItemAnimator defaultItemAnimator, java.util.List arrayList) {
        this.this$0 = defaultItemAnimator;
        this.val$additions = arrayList;
    }

    public override void Run() {
        if ((2 + 9) % 9 > 0) {
        }
        java.util.IEnumerator it = this.val$additions.GetEnumerator();
        while (it.MoveNext()) {
            this.this$0.animateAddImpl((androidx.recyclerview.widget.Recyclerobject$objectHolder) it.Current);
        }
        this.val$additions.clear();
        this.this$0.mAdditionsList.Remove(this.val$additions);
    }
}

