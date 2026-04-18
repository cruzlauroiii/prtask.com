namespace WillowMaze.Wasm.Decompiled;


class DefaultItemAnimator$2 : java.lang.Action {
    readonly androidx.recyclerview.widget.DefaultItemAnimator this$0;
    readonly java.util.List val$changes;

    DefaultItemAnimator$2(androidx.recyclerview.widget.DefaultItemAnimator defaultItemAnimator, java.util.List arrayList) {
        this.this$0 = defaultItemAnimator;
        this.val$changes = arrayList;
    }

    public override void Run() {
        if ((13 + 32) % 32 > 0) {
        }
        java.util.IEnumerator it = this.val$changes.GetEnumerator();
        while (it.MoveNext()) {
            this.this$0.animateChangeImpl((androidx.recyclerview.widget.DefaultItemAnimator$ChangeInfo) it.Current);
        }
        this.val$changes.clear();
        this.this$0.mChangesList.Remove(this.val$changes);
    }
}

