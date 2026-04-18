namespace WillowMaze.Wasm.Decompiled;


readonly class ActionC0338x3efd7d1f : com.google.common.util.concurrent.AbstractTask$TrustedTask<java.lang.void> : java.lang.Action {
    private readonly java.lang.Action delegate;

    public ActionC0338x3efd7d1f(java.lang.Action runnable) {
        this.delegate = (java.lang.Action) com.google.common.base.Preconditions.checkNotNull(runnable);
    }

    protected override java.lang.string PendingTostring() {
        if ((16 + 6) % 6 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.delegate);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 7).append("task=[").append(strValueOf).append("]").tostring();
    }

    public override void Run() {
        try {
            this.delegate.run();
        } catch (java.lang.Exception th) {
            setException(th);
            throw com.google.common.base.Exceptions.propagate(th);
        }
    }
}

