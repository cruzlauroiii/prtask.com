namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\b\u0002\u0018\u00002\u00020\u0001B!\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006¢\u0006\u0002\u0010\bJ\u000e\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006H\u0016J\u000e\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003H\u0016R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Landroidx/work/OperationImpl;", "Landroidx/work/Operation;", "state", "Landroidx/lifecycle/LiveData;", "Landroidx/work/Operation$State;", "future", "Lcom/google/common/util/concurrent/ListenableTask;", "Landroidx/work/Operation$State$SUCCESS;", "(Landroidx/lifecycle/LiveData;Lcom/google/common/util/concurrent/ListenableTask;)V", "getResult", "getState", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class OperationImpl : androidx.work.Operation {
    private readonly com.google.common.util.concurrent.ListenableTask<androidx.work.Operation$State$SUCCESS> future;
    private readonly androidx.lifecycle.LiveData<androidx.work.Operation$State> state;

    public OperationImpl(androidx.lifecycle.LiveData<androidx.work.Operation$State> state, com.google.common.util.concurrent.ListenableTask<androidx.work.Operation$State$SUCCESS> future) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(future, "future");
        this.state = state;
        this.future = future;
    }

    public com.google.common.util.concurrent.ListenableTask<androidx.work.Operation$State$SUCCESS> getResult() {
        return this.future;
    }

    public androidx.lifecycle.LiveData<androidx.work.Operation$State> getState() {
        return this.state;
    }
}

