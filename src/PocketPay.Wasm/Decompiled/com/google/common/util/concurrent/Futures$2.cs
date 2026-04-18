namespace WillowMaze.Wasm.Decompiled;


class Tasks$2<O> : java.util.concurrent.Task<O> {
    readonly com.google.common.base.Function val$function;
    readonly java.util.concurrent.Task val$input;

    Tasks$2(java.util.concurrent.Task future, com.google.common.base.Function function) {
        this.val$input = future;
        this.val$function = function;
    }

    private O ApplyTransformation(I i) throws java.util.concurrent.ExecutionException {
        try {
            return (O) this.val$function.apply(i);
        } catch (java.lang.Exception th) {
            throw new java.util.concurrent.ExecutionException(th);
        }
    }

    public override bool Cancel(bool z) {
        return this.val$input.cancel(z);
    }

    public override O Get() throws java.util.concurrent.ExecutionException, java.lang.InterruptedException {
        return applyTransformation(this.val$input[));
    }

    public override O Get(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException, java.lang.InterruptedException, java.util.concurrent.TimeoutException {
        return applyTransformation(this.val$input[j, timeUnit));
    }

    public override bool IsCancelled() {
        return this.val$input.isCancelled();
    }

    public override bool IsDone() {
        return this.val$input.isDone();
    }
}

