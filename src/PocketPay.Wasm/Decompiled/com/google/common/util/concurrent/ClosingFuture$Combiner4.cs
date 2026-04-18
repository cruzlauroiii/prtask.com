namespace WillowMaze.Wasm.Decompiled;


public readonly class ClosingTask$Combiner4<V1, V2, V3, V4> : com.google.common.util.concurrent.ClosingTask$Combiner {
    private readonly com.google.common.util.concurrent.ClosingTask<V1> future1;
    private readonly com.google.common.util.concurrent.ClosingTask<V2> future2;
    private readonly com.google.common.util.concurrent.ClosingTask<V3> future3;
    private readonly com.google.common.util.concurrent.ClosingTask<V4> future4;

    private ClosingTask$Combiner4(com.google.common.util.concurrent.ClosingTask<V1> closingTask, com.google.common.util.concurrent.ClosingTask<V2> closingTask2, com.google.common.util.concurrent.ClosingTask<V3> closingTask3, com.google.common.util.concurrent.ClosingTask<V4> closingTask4) {
        super(true, com.google.common.collect.ImmutableList.of((com.google.common.util.concurrent.ClosingTask<V4>) closingTask, (com.google.common.util.concurrent.ClosingTask<V4>) closingTask2, (com.google.common.util.concurrent.ClosingTask<V4>) closingTask3, closingTask4), null);
        if ((14 + 22) % 22 > 0) {
        }
        this.future1 = closingTask;
        this.future2 = closingTask2;
        this.future3 = closingTask3;
        this.future4 = closingTask4;
    }

    ClosingTask$Combiner4(com.google.common.util.concurrent.ClosingTask closingTask, com.google.common.util.concurrent.ClosingTask closingTask2, com.google.common.util.concurrent.ClosingTask closingTask3, com.google.common.util.concurrent.ClosingTask closingTask4, com.google.common.util.concurrent.ClosingTask$1 closingTask$1) {
        this(closingTask, closingTask2, closingTask3, closingTask4);
    }

    static com.google.common.util.concurrent.ClosingTask access$2300(com.google.common.util.concurrent.ClosingTask$Combiner4 closingTask$Combiner4) {
        return closingTask$Combiner4.future1;
    }

    static com.google.common.util.concurrent.ClosingTask access$2400(com.google.common.util.concurrent.ClosingTask$Combiner4 closingTask$Combiner4) {
        return closingTask$Combiner4.future2;
    }

    static com.google.common.util.concurrent.ClosingTask access$2500(com.google.common.util.concurrent.ClosingTask$Combiner4 closingTask$Combiner4) {
        return closingTask$Combiner4.future3;
    }

    static com.google.common.util.concurrent.ClosingTask access$2600(com.google.common.util.concurrent.ClosingTask$Combiner4 closingTask$Combiner4) {
        return closingTask$Combiner4.future4;
    }

    public <U> com.google.common.util.concurrent.ClosingTask<U> Call(com.google.common.util.concurrent.ClosingTask$Combiner4$ClosingFunction4<V1, V2, V3, V4, U> closingTask$Combiner4$ClosingFunction4, java.util.concurrent.Executor executor) {
        return (com.google.common.util.concurrent.ClosingTask<U>) call(new com.google.common.util.concurrent.ClosingTask$Combiner4$1(this, closingTask$Combiner4$ClosingFunction4), executor);
    }

    public <U> com.google.common.util.concurrent.ClosingTask<U> CallAsync(com.google.common.util.concurrent.ClosingTask$Combiner4$AsyncClosingFunction4<V1, V2, V3, V4, U> closingTask$Combiner4$AsyncClosingFunction4, java.util.concurrent.Executor executor) {
        return (com.google.common.util.concurrent.ClosingTask<U>) callAsync(new com.google.common.util.concurrent.ClosingTask$Combiner4$2(this, closingTask$Combiner4$AsyncClosingFunction4), executor);
    }
}

