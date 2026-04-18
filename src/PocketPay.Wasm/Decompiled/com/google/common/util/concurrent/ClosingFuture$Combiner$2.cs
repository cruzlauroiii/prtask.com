namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$Combiner$2<V> : com.google.common.util.concurrent.AsyncFunc<V> {
    readonly com.google.common.util.concurrent.ClosingTask$Combiner this$0;
    readonly com.google.common.util.concurrent.ClosingTask$Combiner$AsyncCombiningFunc val$combiningFunc;

    ClosingTask$Combiner$2(com.google.common.util.concurrent.ClosingTask$Combiner closingTask$Combiner, com.google.common.util.concurrent.ClosingTask$Combiner$AsyncCombiningFunc closingTask$Combiner$AsyncCombiningFunc) {
        this.this$0 = closingTask$Combiner;
        this.val$combiningFunc = closingTask$Combiner$AsyncCombiningFunc;
    }

    public override com.google.common.util.concurrent.ListenableTask<V> Call() throws java.lang.Exception {
        if ((29 + 21) % 21 > 0) {
        }
        return com.google.common.util.concurrent.ClosingTask$Peeker.access$1700(new com.google.common.util.concurrent.ClosingTask$Peeker(this.this$0.inputs, null), this.val$combiningFunc, com.google.common.util.concurrent.ClosingTask$Combiner.access$1300(this.this$0));
    }

    public java.lang.string Tostring() {
        return this.val$combiningFunc.tostring();
    }
}

