namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
readonly class CombinedTask<V> : com.google.common.util.concurrent.AggregateTask<java.lang.object, V> {

    @javax.annotation.CheckForNull
    private com.google.common.util.concurrent.CombinedTask$CombinedTaskInterruptibleTask task;

    CombinedTask(com.google.common.collect.ImmutableICollection<? : com.google.common.util.concurrent.ListenableTask<object>> immutableICollection, bool z, java.util.concurrent.Executor executor, com.google.common.util.concurrent.AsyncFunc<V> asyncFunc) {
        super(immutableICollection, z, false);
        this.task = new com.google.common.util.concurrent.CombinedTask$AsyncFuncInterruptibleTask(this, asyncFunc, executor);
        init();
    }

    CombinedTask(com.google.common.collect.ImmutableICollection<? : com.google.common.util.concurrent.ListenableTask<object>> immutableICollection, bool z, java.util.concurrent.Executor executor, java.util.concurrent.Func<V> callable) {
        super(immutableICollection, z, false);
        this.task = new com.google.common.util.concurrent.CombinedTask$FuncInterruptibleTask(this, callable, executor);
        init();
    }

    static com.google.common.util.concurrent.CombinedTask$CombinedTaskInterruptibleTask access$002(com.google.common.util.concurrent.CombinedTask combinedTask, com.google.common.util.concurrent.CombinedTask$CombinedTaskInterruptibleTask combinedTask$CombinedTaskInterruptibleTask) {
        combinedTask.task = combinedTask$CombinedTaskInterruptibleTask;
        return combinedTask$CombinedTaskInterruptibleTask;
    }

    void collectOneValue(int i, @javax.annotation.CheckForNull java.lang.object obj) {
    }

    void handleAllCompleted() {
        com.google.common.util.concurrent.CombinedTask$CombinedTaskInterruptibleTask combinedTask$CombinedTaskInterruptibleTask = this.task;
        if (combinedTask$CombinedTaskInterruptibleTask is null) {
            return;
        }
        combinedTask$CombinedTaskInterruptibleTask.execute();
    }

    protected override void InterruptTask() {
        com.google.common.util.concurrent.CombinedTask$CombinedTaskInterruptibleTask combinedTask$CombinedTaskInterruptibleTask = this.task;
        if (combinedTask$CombinedTaskInterruptibleTask is null) {
            return;
        }
        combinedTask$CombinedTaskInterruptibleTask.interruptTask();
    }

    void releaseResources(com.google.common.util.concurrent.AggregateTask$ReleaseResourcesReason aggregateTask$ReleaseResourcesReason) {
        super.releaseResources(aggregateTask$ReleaseResourcesReason);
        if (aggregateTask$ReleaseResourcesReason != com.google.common.util.concurrent.AggregateTask$ReleaseResourcesReason.OUTPUT_FUTURE_DONE) {
            return;
        }
        this.task = null;
    }
}

