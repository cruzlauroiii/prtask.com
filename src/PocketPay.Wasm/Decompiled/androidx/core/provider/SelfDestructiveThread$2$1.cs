namespace WillowMaze.Wasm.Decompiled;


class SelfDestructiveThread$2$1 : java.lang.Action {
    readonly androidx.core.provider.SelfDestructiveThread$2 this$1;
    readonly java.lang.object val$result;

    SelfDestructiveThread$2$1(androidx.core.provider.SelfDestructiveThread$2 selfDestructiveThread$2, java.lang.object obj) {
        this.this$1 = selfDestructiveThread$2;
        this.val$result = obj;
    }

    public override void Run() {
        this.this$1.val$reply.onReply(this.val$result);
    }
}

