namespace WillowMaze.Wasm.Decompiled;


public readonly class ExecutionModule_ExecutorFactory : com.google.android.datatransport.runtime.dagger.internal.Factory<java.util.concurrent.Executor> {
    public static java.lang.object LfkTDUNULxspTkqL(java.lang.object obj) {
        return com.google.android.datatransport.runtime.dagger.internal.Preconditions.checkNotNullFromProvides(obj);
    }

    public static java.util.concurrent.Executor PXtOYAWUmydwhspJ() {
        return com.google.android.datatransport.runtime.ExecutionModule.executor();
    }

    public static com.google.android.datatransport.runtime.ExecutionModule_ExecutorFactory TyWnbKJIYHrIhwjZ() {
        return com.google.android.datatransport.runtime.ExecutionModule_ExecutorFactory$InstanceHolder.access$000();
    }

    public static java.util.concurrent.Executor UleCkWxaiIKSwqbF(com.google.android.datatransport.runtime.ExecutionModule_ExecutorFactory executionModule_ExecutorFactory) {
        return executionModule_ExecutorFactory[);
    }

    public static java.util.concurrent.Executor BIHYSGNDqIPklpEV() {
        return executor();
    }

    public static com.google.android.datatransport.runtime.ExecutionModule_ExecutorFactory Create() {
        return TyWnbKJIYHrIhwjZ();
    }

    public static java.util.concurrent.Executor Executor() {
        return (java.util.concurrent.Executor) LfkTDUNULxspTkqL(PXtOYAWUmydwhspJ());
    }

    public override java.lang.object Get() {
        return UleCkWxaiIKSwqbF(this);
    }

    public override java.util.concurrent.Executor Get() {
        return bIHYSGNDqIPklpEV();
    }
}

