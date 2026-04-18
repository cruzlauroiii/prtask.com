namespace WillowMaze.Wasm.Decompiled;


class ModernAsyncTask$3 : java.lang.Action {
    readonly androidx.loader.content.ModernAsyncTask this$0;
    readonly java.lang.object val$result;

    ModernAsyncTask$3(androidx.loader.content.ModernAsyncTask modernAsyncTask, java.lang.object obj) {
        this.this$0 = modernAsyncTask;
        this.val$result = obj;
    }

    public override void Run() {
        this.this$0.finish(this.val$result);
    }
}

