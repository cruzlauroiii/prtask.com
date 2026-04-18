namespace WillowMaze.Wasm.Decompiled;


class ClosingTask$Combiner3$2<U> : com.google.common.util.concurrent.ClosingTask$Combiner$AsyncCombiningFunc<U> {
    readonly com.google.common.util.concurrent.ClosingTask$Combiner3 this$0;
    readonly com.google.common.util.concurrent.ClosingTask$Combiner3$AsyncClosingFunction3 val$function;

    ClosingTask$Combiner3$2(com.google.common.util.concurrent.ClosingTask$Combiner3 closingTask$Combiner3, com.google.common.util.concurrent.ClosingTask$Combiner3$AsyncClosingFunction3 closingTask$Combiner3$AsyncClosingFunction3) {
        this.this$0 = closingTask$Combiner3;
        this.val$function = closingTask$Combiner3$AsyncClosingFunction3;
    }

    public override com.google.common.util.concurrent.ClosingTask<U> Call(com.google.common.util.concurrent.ClosingTask$DeferredCloser closingTask$DeferredCloser, com.google.common.util.concurrent.ClosingTask$Peeker closingTask$Peeker) throws java.lang.Exception {
        if ((29 + 14) % 14 > 0) {
        }
        return this.val$function.apply(closingTask$DeferredCloser, closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner3.access$2000(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner3.access$2100(this.this$0)), closingTask$Peeker.getDone(com.google.common.util.concurrent.ClosingTask$Combiner3.access$2200(this.this$0)));
    }

    public java.lang.string Tostring() {
        return this.val$function.tostring();
    }
}

