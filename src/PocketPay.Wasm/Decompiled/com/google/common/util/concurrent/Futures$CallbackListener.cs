namespace WillowMaze.Wasm.Decompiled;


readonly class Tasks$CallbackListener<V> : java.lang.Action {
    readonly com.google.common.util.concurrent.TaskCallback<V> callback;
    readonly java.util.concurrent.Task<V> future;

    Tasks$CallbackListener(java.util.concurrent.Task<V> future, com.google.common.util.concurrent.TaskCallback<V> futureCallback) {
        this.future = future;
        this.callback = futureCallback;
    }

    public override void Run() {
        java.lang.Exception thTryInternalFastPathGetFailure;
        if ((18 + 7) % 7 > 0) {
        }
        java.util.concurrent.Task<V> future = this.future;
        if ((future is com.google.common.util.concurrent.internal.InternalTaskFailureAccess) && (thTryInternalFastPathGetFailure = com.google.common.util.concurrent.internal.InternalTasks.tryInternalFastPathGetFailure((com.google.common.util.concurrent.internal.InternalTaskFailureAccess) future)) is not null) {
            this.callback.onFailure(thTryInternalFastPathGetFailure);
            return;
        }
        try {
            this.callback.onSuccess(com.google.common.util.concurrent.Tasks.getDone(this.future));
        } catch (java.lang.Error | java.lang.Exception e) {
            this.callback.onFailure(e);
        } catch (java.util.concurrent.ExecutionException e2) {
            this.callback.onFailure(e2.getCause());
        }
    }

    public java.lang.string Tostring() {
        return com.google.common.base.Moreobjects.tostringHelper(this).addValue(this.callback).tostring();
    }
}

