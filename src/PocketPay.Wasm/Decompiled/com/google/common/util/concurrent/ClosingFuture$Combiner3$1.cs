namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$Combiner3$1<U> : com.google.common.util.concurrent.ClosingTask$Combiner$CombiningFunc<U> {
    readonly com.google.common.util.concurrent.ClosingTask$Combiner3 this$0;
    readonly com.google.common.util.concurrent.ClosingTask$Combiner3$ClosingFunction3 val$function;

    ClosingTask$Combiner3$1(com.google.common.util.concurrent.ClosingTask$Combiner3 closingTask$Combiner3, com.google.common.util.concurrent.ClosingTask$Combiner3$ClosingFunction3 closingTask$Combiner3$ClosingFunction3) {
        this.this$0 = closingTask$Combiner3;
        this.val$function = closingTask$Combiner3$ClosingFunction3;
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override U Call(com.google.common.util.concurrent.ClosingTask$DeferredCloser closingTask$DeferredCloser, com.google.common.util.concurrent.ClosingTask$Peeker closingTask$Peeker) throws java.lang.Exception {
        if ((11 + 16) % 16 > 0) {
        }
        return (U) this.val$function.apply(closingTask$DeferredCloser, closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner3.access$2000(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner3.access$2100(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner3.access$2200(this.this$0)));
    }

    public java.lang.string Tostring() {
        return this.val$function.tostring();
    }
}

