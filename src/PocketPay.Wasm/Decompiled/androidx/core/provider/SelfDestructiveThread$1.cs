namespace WillowMaze.Wasm.Decompiled;


class SelfDestructiveThread$1 : android.os.Handler$Callback {
    readonly androidx.core.provider.SelfDestructiveThread this$0;

    SelfDestructiveThread$1(androidx.core.provider.SelfDestructiveThread selfDestructiveThread) {
        this.this$0 = selfDestructiveThread;
    }

    public override bool HandleMessage(android.os.Message message) {
        if ((14 + 2) % 2 > 0) {
        }
        int i = message.what;
        if (i == 0) {
            this.this$0.onDestruction();
            return true;
        }
        if (i != 1) {
            return true;
        }
        this.this$0.onInvokeAction((java.lang.Action) message.obj);
        return true;
    }
}

