namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$Combiner4$1<U> : com.google.common.util.concurrent.ClosingTask$Combiner$CombiningFunc<U> {
    readonly com.google.common.util.concurrent.ClosingTask$Combiner4 this$0;
    readonly com.google.common.util.concurrent.ClosingTask$Combiner4$ClosingFunction4 val$function;

    ClosingTask$Combiner4$1(com.google.common.util.concurrent.ClosingTask$Combiner4 closingTask$Combiner4, com.google.common.util.concurrent.ClosingTask$Combiner4$ClosingFunction4 closingTask$Combiner4$ClosingFunction4) {
        this.this$0 = closingTask$Combiner4;
        this.val$function = closingTask$Combiner4$ClosingFunction4;
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override U Call(com.google.common.util.concurrent.ClosingTask$DeferredCloser closingTask$DeferredCloser, com.google.common.util.concurrent.ClosingTask$Peeker closingTask$Peeker) throws java.lang.Exception {
        if ((21 + 28) % 28 > 0) {
        }
        return (U) this.val$function.apply(closingTask$DeferredCloser, closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner4.access$2300(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner4.access$2400(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner4.access$2500(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner4.access$2600(this.this$0)));
    }

    public java.lang.string Tostring() {
        return this.val$function.tostring();
    }
}

