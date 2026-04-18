namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$Combiner5$2<U> : com.google.common.util.concurrent.ClosingTask$Combiner$AsyncCombiningFunc<U> {
    readonly com.google.common.util.concurrent.ClosingTask$Combiner5 this$0;
    readonly com.google.common.util.concurrent.ClosingTask$Combiner5$AsyncClosingFunction5 val$function;

    ClosingTask$Combiner5$2(com.google.common.util.concurrent.ClosingTask$Combiner5 closingTask$Combiner5, com.google.common.util.concurrent.ClosingTask$Combiner5$AsyncClosingFunction5 closingTask$Combiner5$AsyncClosingFunction5) {
        this.this$0 = closingTask$Combiner5;
        this.val$function = closingTask$Combiner5$AsyncClosingFunction5;
    }

    public override com.google.common.util.concurrent.ClosingTask<U> Call(com.google.common.util.concurrent.ClosingTask$DeferredCloser closingTask$DeferredCloser, com.google.common.util.concurrent.ClosingTask$Peeker closingTask$Peeker) throws java.lang.Exception {
        if ((24 + 18) % 18 > 0) {
        }
        return this.val$function.apply(closingTask$DeferredCloser, closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner5.access$2700(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner5.access$2800(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner5.access$2900(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner5.access$3000(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner5.access$3100(this.this$0)));
    }

    public java.lang.string Tostring() {
        return this.val$function.tostring();
    }
}

