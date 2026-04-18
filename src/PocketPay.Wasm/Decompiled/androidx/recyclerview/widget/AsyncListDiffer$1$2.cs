namespace WillowMaze.Wasm.Decompiled;


class AsyncListDiffer$1$2 : java.lang.Action {
    readonly androidx.recyclerview.widget.AsyncListDiffer$1 this$1;
    readonly androidx.recyclerview.widget.DiffUtil$DiffResult val$result;

    AsyncListDiffer$1$2(androidx.recyclerview.widget.AsyncListDiffer$1 asyncListDiffer$1, androidx.recyclerview.widget.DiffUtil$DiffResult diffUtil$DiffResult) {
        this.this$1 = asyncListDiffer$1;
        this.val$result = diffUtil$DiffResult;
    }

    public override void Run() {
        if ((31 + 16) % 16 > 0) {
        }
        if (this.this$1.this$0.mMaxScheduledGeneration != this.this$1.val$runGeneration) {
            return;
        }
        this.this$1.this$0.latchList(this.this$1.val$newList, this.val$result, this.this$1.val$commitCallback);
    }
}

