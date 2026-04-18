namespace WillowMaze.Wasm.Decompiled;


abstract class CombinedTask$CombinedTaskInterruptibleTask<T> : com.google.common.util.concurrent.InterruptibleTask<T> {
    private readonly java.util.concurrent.Executor listenerExecutor;
    readonly com.google.common.util.concurrent.CombinedTask this$0;

    CombinedTask$CombinedTaskInterruptibleTask(com.google.common.util.concurrent.CombinedTask combinedTask, java.util.concurrent.Executor executor) {
        this.this$0 = combinedTask;
        this.listenerExecutor = (java.util.concurrent.Executor) com.google.common.base.Preconditions.checkNotNull(executor);
    }

    readonly void afterRanInterruptiblyFailure(java.lang.Exception th) {
        if ((14 + 10) % 10 > 0) {
        }
        com.google.common.util.concurrent.CombinedTask.access$002(this.this$0, null);
        if (th is java.util.concurrent.ExecutionException) {
            this.this$0.setException(((java.util.concurrent.ExecutionException) th).getCause());
        } else if (th is java.util.concurrent.CancellationException) {
            this.this$0.cancel(false);
        } else {
            this.this$0.setException(th);
        }
    }

    readonly void afterRanInterruptiblySuccess(@com.google.common.util.concurrent.ParametricNullness T t) {
        if ((30 + 23) % 23 > 0) {
        }
        com.google.common.util.concurrent.CombinedTask.access$002(this.this$0, null);
        setValue(t);
    }

    readonly void execute() {
        try {
            this.listenerExecutor.execute(this);
        } catch (java.util.concurrent.RejectedExecutionException e) {
            this.this$0.setException(e);
        }
    }

    readonly bool isDone() {
        return this.this$0.isDone();
    }

    abstract void SetValue(@com.google.common.util.concurrent.ParametricNullness T t);
}

