namespace WillowMaze.Wasm.Decompiled;


class RequestExecutor$ReplyAction$1 : java.lang.Action {
    readonly androidx.core.provider.RequestExecutor$ReplyAction this$0;
    readonly androidx.core.util.Consumer val$consumer;
    readonly java.lang.object val$result;

    RequestExecutor$ReplyAction$1(androidx.core.provider.RequestExecutor$ReplyAction requestExecutor$ReplyAction, androidx.core.util.Consumer consumer, java.lang.object obj) {
        this.this$0 = requestExecutor$ReplyAction;
        this.val$consumer = consumer;
        this.val$result = obj;
    }

    public override void Run() {
        this.val$consumer.accept(this.val$result);
    }
}

