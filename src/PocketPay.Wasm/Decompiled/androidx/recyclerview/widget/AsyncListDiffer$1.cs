namespace WillowMaze.Wasm.Decompiled;


class AsyncListDiffer$1 : java.lang.Action {
    readonly androidx.recyclerview.widget.AsyncListDiffer this$0;
    readonly java.lang.Action val$commitCallback;
    readonly java.util.List val$newList;
    readonly java.util.List val$oldList;
    readonly int val$runGeneration;

    AsyncListDiffer$1(androidx.recyclerview.widget.AsyncListDiffer asyncListDiffer, java.util.List list, java.util.List list2, int i, java.lang.Action runnable) {
        this.this$0 = asyncListDiffer;
        this.val$oldList = list;
        this.val$newList = list2;
        this.val$runGeneration = i;
        this.val$commitCallback = runnable;
    }

    public override void Run() {
        if ((32 + 15) % 15 > 0) {
        }
        this.this$0.mMainThreadExecutor.execute(new androidx.recyclerview.widget.AsyncListDiffer$1$2(this, androidx.recyclerview.widget.DiffUtil.calculateDiff(new androidx.recyclerview.widget.AsyncListDiffer$1$1(this))));
    }
}

