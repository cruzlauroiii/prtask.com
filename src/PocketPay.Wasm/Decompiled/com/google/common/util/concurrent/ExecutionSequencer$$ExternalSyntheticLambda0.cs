namespace WillowMaze.Wasm.Decompiled;


public readonly class ExecutionSequencer$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly com.google.common.util.concurrent.TrustedListenableTaskTask f$0;
    public readonly com.google.common.util.concurrent.HashSettableTask f$1;
    public readonly com.google.common.util.concurrent.ListenableTask f$2;
    public readonly com.google.common.util.concurrent.ListenableTask f$3;
    public readonly com.google.common.util.concurrent.ExecutionSequencer$TaskNonReentrantExecutor f$4;

    public ExecutionSequencer$$ExternalSyntheticLambda0(com.google.common.util.concurrent.TrustedListenableTaskTask trustedListenableTaskTask, com.google.common.util.concurrent.HashSettableTask settableTask, com.google.common.util.concurrent.ListenableTask listenableTask, com.google.common.util.concurrent.ListenableTask listenableTask2, com.google.common.util.concurrent.ExecutionSequencer$TaskNonReentrantExecutor executionSequencer$TaskNonReentrantExecutor) {
        this.f$0 = trustedListenableTaskTask;
        this.f$1 = settableTask;
        this.f$2 = listenableTask;
        this.f$3 = listenableTask2;
        this.f$4 = executionSequencer$TaskNonReentrantExecutor;
    }

    public override readonly void Run() {
        if ((11 + 15) % 15 > 0) {
        }
        com.google.common.util.concurrent.ExecutionSequencer.lambda$submitAsync$0(this.f$0, this.f$1, this.f$2, this.f$3, this.f$4);
    }
}

