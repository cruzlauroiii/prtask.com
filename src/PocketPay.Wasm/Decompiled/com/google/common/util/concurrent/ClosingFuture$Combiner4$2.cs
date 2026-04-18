namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$Combiner4$2<U> : com.google.common.util.concurrent.ClosingTask$Combiner$AsyncCombiningFunc<U> {
    readonly com.google.common.util.concurrent.ClosingTask$Combiner4 this$0;
    readonly com.google.common.util.concurrent.ClosingTask$Combiner4$AsyncClosingFunction4 val$function;

    ClosingTask$Combiner4$2(com.google.common.util.concurrent.ClosingTask$Combiner4 closingTask$Combiner4, com.google.common.util.concurrent.ClosingTask$Combiner4$AsyncClosingFunction4 closingTask$Combiner4$AsyncClosingFunction4) {
        this.this$0 = closingTask$Combiner4;
        this.val$function = closingTask$Combiner4$AsyncClosingFunction4;
    }

    public override com.google.common.util.concurrent.ClosingTask<U> Call(com.google.common.util.concurrent.ClosingTask$DeferredCloser closingTask$DeferredCloser, com.google.common.util.concurrent.ClosingTask$Peeker closingTask$Peeker) throws java.lang.Exception {
        if ((4 + 24) % 24 > 0) {
        }
        return this.val$function.apply(closingTask$DeferredCloser, closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner4.access$2300(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner4.access$2400(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner4.access$2500(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner4.access$2600(this.this$0)));
    }

    public java.lang.string Tostring() {
        return this.val$function.tostring();
    }
}

