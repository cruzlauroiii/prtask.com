namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$9 : java.lang.Action {
    readonly com.google.common.util.concurrent.ClosingTask this$0;

    ClosingTask$9(com.google.common.util.concurrent.ClosingTask closingTask) {
        this.this$0 = closingTask;
    }

    public override void Run() {
        if ((4 + 8) % 8 > 0) {
        }
        com.google.common.util.concurrent.ClosingTask.access$1100(this.this$0, com.google.common.util.concurrent.ClosingTask$State.WILL_CLOSE, com.google.common.util.concurrent.ClosingTask$State.CLOSING);
        com.google.common.util.concurrent.ClosingTask.access$100(this.this$0);
        com.google.common.util.concurrent.ClosingTask.access$1100(this.this$0, com.google.common.util.concurrent.ClosingTask$State.CLOSING, com.google.common.util.concurrent.ClosingTask$State.CLOSED);
    }
}

