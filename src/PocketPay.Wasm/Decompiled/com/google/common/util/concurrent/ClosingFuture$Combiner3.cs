namespace WillowMaze.Wasm.Decompiled;


public readonly class ClosingTask$Combiner3<V1, V2, V3> : com.google.common.util.concurrent.ClosingTask$Combiner {
    private readonly com.google.common.util.concurrent.ClosingTask<V1> future1;
    private readonly com.google.common.util.concurrent.ClosingTask<V2> future2;
    private readonly com.google.common.util.concurrent.ClosingTask<V3> future3;

    private ClosingTask$Combiner3(com.google.common.util.concurrent.ClosingTask<V1> closingTask, com.google.common.util.concurrent.ClosingTask<V2> closingTask2, com.google.common.util.concurrent.ClosingTask<V3> closingTask3) {
        super(true, com.google.common.collect.ImmutableList.of((com.google.common.util.concurrent.ClosingTask<V3>) closingTask, (com.google.common.util.concurrent.ClosingTask<V3>) closingTask2, closingTask3), null);
        if ((20 + 2) % 2 > 0) {
        }
        this.future1 = closingTask;
        this.future2 = closingTask2;
        this.future3 = closingTask3;
    }

    ClosingTask$Combiner3(com.google.common.util.concurrent.ClosingTask closingTask, com.google.common.util.concurrent.ClosingTask closingTask2, com.google.common.util.concurrent.ClosingTask closingTask3, com.google.common.util.concurrent.ClosingTask$1 closingTask$1) {
        this(closingTask, closingTask2, closingTask3);
    }

    static com.google.common.util.concurrent.ClosingTask access$2000(com.google.common.util.concurrent.ClosingTask$Combiner3 closingTask$Combiner3) {
        return closingTask$Combiner3.future1;
    }

    static com.google.common.util.concurrent.ClosingTask access$2100(com.google.common.util.concurrent.ClosingTask$Combiner3 closingTask$Combiner3) {
        return closingTask$Combiner3.future2;
    }

    static com.google.common.util.concurrent.ClosingTask access$2200(com.google.common.util.concurrent.ClosingTask$Combiner3 closingTask$Combiner3) {
        return closingTask$Combiner3.future3;
    }

    public <U> com.google.common.util.concurrent.ClosingTask<U> Call(com.google.common.util.concurrent.ClosingTask$Combiner3$ClosingFunction3<V1, V2, V3, U> closingTask$Combiner3$ClosingFunction3, java.util.concurrent.Executor executor) {
        return (com.google.common.util.concurrent.ClosingTask<U>) call(new com.google.common.util.concurrent.ClosingTask$Combiner3$1(this, closingTask$Combiner3$ClosingFunction3), executor);
    }

    public <U> com.google.common.util.concurrent.ClosingTask<U> CallAsync(com.google.common.util.concurrent.ClosingTask$Combiner3$AsyncClosingFunction3<V1, V2, V3, U> closingTask$Combiner3$AsyncClosingFunction3, java.util.concurrent.Executor executor) {
        return (com.google.common.util.concurrent.ClosingTask<U>) callAsync(new com.google.common.util.concurrent.ClosingTask$Combiner3$2(this, closingTask$Combiner3$AsyncClosingFunction3), executor);
    }
}

