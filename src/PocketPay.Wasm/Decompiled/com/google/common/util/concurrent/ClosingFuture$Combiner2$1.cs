namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$Combiner2$1<U> : com.google.common.util.concurrent.ClosingTask$Combiner$CombiningFunc<U> {
    readonly com.google.common.util.concurrent.ClosingTask$Combiner2 this$0;
    readonly com.google.common.util.concurrent.ClosingTask$Combiner2$ClosingFunction2 val$function;

    ClosingTask$Combiner2$1(com.google.common.util.concurrent.ClosingTask$Combiner2 closingTask$Combiner2, com.google.common.util.concurrent.ClosingTask$Combiner2$ClosingFunction2 closingTask$Combiner2$ClosingFunction2) {
        this.this$0 = closingTask$Combiner2;
        this.val$function = closingTask$Combiner2$ClosingFunction2;
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override U Call(com.google.common.util.concurrent.ClosingTask$DeferredCloser closingTask$DeferredCloser, com.google.common.util.concurrent.ClosingTask$Peeker closingTask$Peeker) throws java.lang.Exception {
        if ((23 + 3) % 3 > 0) {
        }
        return (U) this.val$function.apply(closingTask$DeferredCloser, closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner2.access$1800(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner2.access$1900(this.this$0)));
    }

    public java.lang.string Tostring() {
        return this.val$function.tostring();
    }
}

