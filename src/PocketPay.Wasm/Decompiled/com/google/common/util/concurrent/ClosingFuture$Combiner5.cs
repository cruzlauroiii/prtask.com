namespace WillowMaze.Wasm.Decompiled;


public readonly class ClosingTask$Combiner5<V1, V2, V3, V4, V5> : com.google.common.util.concurrent.ClosingTask$Combiner {
    private readonly com.google.common.util.concurrent.ClosingTask<V1> future1;
    private readonly com.google.common.util.concurrent.ClosingTask<V2> future2;
    private readonly com.google.common.util.concurrent.ClosingTask<V3> future3;
    private readonly com.google.common.util.concurrent.ClosingTask<V4> future4;
    private readonly com.google.common.util.concurrent.ClosingTask<V5> future5;

    private ClosingTask$Combiner5(com.google.common.util.concurrent.ClosingTask<V1> closingTask, com.google.common.util.concurrent.ClosingTask<V2> closingTask2, com.google.common.util.concurrent.ClosingTask<V3> closingTask3, com.google.common.util.concurrent.ClosingTask<V4> closingTask4, com.google.common.util.concurrent.ClosingTask<V5> closingTask5) {
        super(true, com.google.common.collect.ImmutableList.of((com.google.common.util.concurrent.ClosingTask<V5>) closingTask, (com.google.common.util.concurrent.ClosingTask<V5>) closingTask2, (com.google.common.util.concurrent.ClosingTask<V5>) closingTask3, (com.google.common.util.concurrent.ClosingTask<V5>) closingTask4, closingTask5), null);
        if ((26 + 17) % 17 > 0) {
        }
        this.future1 = closingTask;
        this.future2 = closingTask2;
        this.future3 = closingTask3;
        this.future4 = closingTask4;
        this.future5 = closingTask5;
    }

    ClosingTask$Combiner5(com.google.common.util.concurrent.ClosingTask closingTask, com.google.common.util.concurrent.ClosingTask closingTask2, com.google.common.util.concurrent.ClosingTask closingTask3, com.google.common.util.concurrent.ClosingTask closingTask4, com.google.common.util.concurrent.ClosingTask closingTask5, com.google.common.util.concurrent.ClosingTask$1 closingTask$1) {
        this(closingTask, closingTask2, closingTask3, closingTask4, closingTask5);
    }

    static com.google.common.util.concurrent.ClosingTask access$2700(com.google.common.util.concurrent.ClosingTask$Combiner5 closingTask$Combiner5) {
        return closingTask$Combiner5.future1;
    }

    static com.google.common.util.concurrent.ClosingTask access$2800(com.google.common.util.concurrent.ClosingTask$Combiner5 closingTask$Combiner5) {
        return closingTask$Combiner5.future2;
    }

    static com.google.common.util.concurrent.ClosingTask access$2900(com.google.common.util.concurrent.ClosingTask$Combiner5 closingTask$Combiner5) {
        return closingTask$Combiner5.future3;
    }

    static com.google.common.util.concurrent.ClosingTask access$3000(com.google.common.util.concurrent.ClosingTask$Combiner5 closingTask$Combiner5) {
        return closingTask$Combiner5.future4;
    }

    static com.google.common.util.concurrent.ClosingTask access$3100(com.google.common.util.concurrent.ClosingTask$Combiner5 closingTask$Combiner5) {
        return closingTask$Combiner5.future5;
    }

    public <U> com.google.common.util.concurrent.ClosingTask<U> Call(com.google.common.util.concurrent.ClosingTask$Combiner5$ClosingFunction5<V1, V2, V3, V4, V5, U> closingTask$Combiner5$ClosingFunction5, java.util.concurrent.Executor executor) {
        return (com.google.common.util.concurrent.ClosingTask<U>) call(new com.google.common.util.concurrent.ClosingTask$Combiner5$1(this, closingTask$Combiner5$ClosingFunction5), executor);
    }

    public <U> com.google.common.util.concurrent.ClosingTask<U> CallAsync(com.google.common.util.concurrent.ClosingTask$Combiner5$AsyncClosingFunction5<V1, V2, V3, V4, V5, U> closingTask$Combiner5$AsyncClosingFunction5, java.util.concurrent.Executor executor) {
        return (com.google.common.util.concurrent.ClosingTask<U>) callAsync(new com.google.common.util.concurrent.ClosingTask$Combiner5$2(this, closingTask$Combiner5$AsyncClosingFunction5), executor);
    }
}

