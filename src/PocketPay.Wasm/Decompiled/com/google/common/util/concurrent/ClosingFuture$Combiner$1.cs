namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$Combiner$1<V> : java.util.concurrent.Func<V> {
    readonly com.google.common.util.concurrent.ClosingTask$Combiner this$0;
    readonly com.google.common.util.concurrent.ClosingTask$Combiner$CombiningFunc val$combiningFunc;

    ClosingTask$Combiner$1(com.google.common.util.concurrent.ClosingTask$Combiner closingTask$Combiner, com.google.common.util.concurrent.ClosingTask$Combiner$CombiningFunc closingTask$Combiner$CombiningFunc) {
        this.this$0 = closingTask$Combiner;
        this.val$combiningFunc = closingTask$Combiner$CombiningFunc;
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override V Call() throws java.lang.Exception {
        if ((21 + 30) % 30 > 0) {
        }
        return (V) com.google.common.util.concurrent.ClosingTask$Peeker.access$1500(new com.google.common.util.concurrent.ClosingTask$Peeker(this.this$0.inputs, null), this.val$combiningFunc, com.google.common.util.concurrent.ClosingTask$Combiner.access$1300(this.this$0));
    }

    public java.lang.string Tostring() {
        return this.val$combiningFunc.tostring();
    }
}

