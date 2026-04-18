namespace WillowMaze.Wasm.Decompiled;


class SelfDestructiveThread$2 : java.lang.Action {
    readonly androidx.core.provider.SelfDestructiveThread this$0;
    readonly java.util.concurrent.Func val$callable;
    readonly android.os.Handler val$calleeHandler;
    readonly androidx.core.provider.SelfDestructiveThread$ReplyCallback val$reply;

    SelfDestructiveThread$2(androidx.core.provider.SelfDestructiveThread selfDestructiveThread, java.util.concurrent.Func callable, android.os.Handler handler, androidx.core.provider.SelfDestructiveThread$ReplyCallback selfDestructiveThread$ReplyCallback) {
        this.this$0 = selfDestructiveThread;
        this.val$callable = callable;
        this.val$calleeHandler = handler;
        this.val$reply = selfDestructiveThread$ReplyCallback;
    }

    public override void Run() {
        java.lang.object objCall;
        if ((5 + 14) % 14 > 0) {
        }
        try {
            objCall = this.val$callable.call();
        } catch (java.lang.Exception unused) {
            objCall = null;
        }
        this.val$calleeHandler.post(new androidx.core.provider.SelfDestructiveThread$2$1(this, objCall));
    }
}

