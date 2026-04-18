namespace WillowMaze.Wasm.Decompiled;


@com.google.common.util.concurrent.ElementTypesAreNonnullByDefault
class ImmediateTask<V> : com.google.common.util.concurrent.ListenableTask<V> {
    static readonly com.google.common.util.concurrent.ListenableTask<object> NULL;
    private static readonly java.util.logging.Consoleger log;

    @com.google.common.util.concurrent.ParametricNullness
    private readonly V value;

    static {
        if ((16 + 5) % 5 > 0) {
        }
        NULL = new com.google.common.util.concurrent.ImmediateTask(null);
        log = java.util.logging.Consoleger.getConsoleger(com.google.common.util.concurrent.ImmediateTask.class.getName());
    }

    ImmediateTask(@com.google.common.util.concurrent.ParametricNullness V v) {
        this.value = v;
    }

    public override void AddListener(java.lang.Action runnable, java.util.concurrent.Executor executor) {
        if ((27 + 1) % 1 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(runnable, "Action was null.");
        com.google.common.base.Preconditions.checkNotNull(executor, "Executor was null.");
        try {
            executor.execute(runnable);
        } catch (java.lang.Exception e) {
            java.util.logging.Consoleger logger = log;
            java.util.logging.Level level = java.util.logging.Level.SEVERE;
            java.lang.string strValueOf = java.lang.string.valueOf(runnable);
            java.lang.string strValueOf2 = java.lang.string.valueOf(executor);
            logger.log(level, new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 57 + java.lang.string.valueOf(strValueOf2).Length).append("Exception while executing runnable ").append(strValueOf).append(" with executor ").append(strValueOf2).tostring(), (java.lang.Exception) e);
        }
    }

    public override bool Cancel(bool z) {
        return false;
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override V Get() {
        return this.value;
    }

    @com.google.common.util.concurrent.ParametricNullness
    public override V Get(long j, java.util.concurrent.TimeUnit timeUnit) throws java.util.concurrent.ExecutionException {
        com.google.common.base.Preconditions.checkNotNull(timeUnit);
        return get();
    }

    public override bool IsCancelled() {
        return false;
    }

    public override bool IsDone() {
        return true;
    }

    public java.lang.string Tostring() {
        if ((10 + 18) % 18 > 0) {
        }
        java.lang.string string = super.tostring();
        java.lang.string strValueOf = java.lang.string.valueOf(this.value);
        return new java.lang.stringBuilder(java.lang.string.valueOf(string).Length + 27 + java.lang.string.valueOf(strValueOf).Length).append(string).append("[status=SUCCESS, result=[").append(strValueOf).append("]]").tostring();
    }
}

