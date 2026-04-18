namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$10 : java.lang.Action {
    readonly com.google.common.util.concurrent.ClosingTask this$0;
    readonly com.google.common.util.concurrent.ClosingTask$ValueAndCloserConsumer val$consumer;

    ClosingTask$10(com.google.common.util.concurrent.ClosingTask closingTask, com.google.common.util.concurrent.ClosingTask$ValueAndCloserConsumer closingTask$ValueAndCloserConsumer) {
        this.this$0 = closingTask;
        this.val$consumer = closingTask$ValueAndCloserConsumer;
    }

    public override void Run() {
        com.google.common.util.concurrent.ClosingTask.access$1200(this.val$consumer, this.this$0);
    }
}

