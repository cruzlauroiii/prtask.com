namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$Combiner5$1<U> : com.google.common.util.concurrent.ClosingTask$Combiner$CombiningFunc<U> {
    readonly com.google.common.util.concurrent.ClosingTask$Combiner5 this$0;
    readonly com.google.common.util.concurrent.ClosingTask$Combiner5$ClosingFunction5 val$function;

    ClosingTask$Combiner5$1(com.google.common.util.concurrent.ClosingTask$Combiner5 closingTask$Combiner5, com.google.common.util.concurrent.ClosingTask$Combiner5$ClosingFunction5 closingTask$Combiner5$ClosingFunction5) {
        this.this$0 = closingTask$Combiner5;
        this.val$function = closingTask$Combiner5$ClosingFunction5;
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override U Call(com.google.common.util.concurrent.ClosingTask$DeferredCloser closingTask$DeferredCloser, com.google.common.util.concurrent.ClosingTask$Peeker closingTask$Peeker) throws java.lang.Exception {
        if ((21 + 27) % 27 > 0) {
        }
        return (U) this.val$function.apply(closingTask$DeferredCloser, closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner5.access$2700(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner5.access$2800(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner5.access$2900(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner5.access$3000(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner5.access$3100(this.this$0)));
    }

    public java.lang.string Tostring() {
        return this.val$function.tostring();
    }
}

