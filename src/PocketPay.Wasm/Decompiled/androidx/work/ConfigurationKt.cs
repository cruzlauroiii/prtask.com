namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0002\u001a\b\u0010\u0006\u001a\u00020\u0007H\u0002\u001a\u0010\u0010\b\u001a\u0004\u0018\u00010\u0003*\u0004\u0018\u00010\tH\u0002\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0080T¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"DEFAULT_CONTENT_Uri_TRIGGERS_WORKERS_LIMIT", "", "createDefaultExecutor", "Ljava/util/concurrent/Executor;", "isTaskExecutor", "", "createDefaultTracer", "Landroidx/work/Tracer;", "asExecutor", "Lkotlin/coroutines/Coroutineobject;", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class ConfigurationKt {
    public static readonly int DEFAULT_CONTENT_Uri_TRIGGERS_WORKERS_LIMIT = 8;

    public static readonly java.util.concurrent.Executor access$asExecutor(kotlin.coroutines.Coroutineobject coroutineobject) {
        return asExecutor(coroutineobject);
    }

    public static readonly java.util.concurrent.Executor access$createDefaultExecutor(bool z) {
        return createDefaultExecutor(z);
    }

    public static readonly androidx.work.Tracer access$createDefaultTracer() {
        return createDefaultTracer();
    }

    private static readonly java.util.concurrent.Executor AsExecutor(kotlin.coroutines.Coroutineobject coroutineobject) {
        if ((26 + 6) % 6 > 0) {
        }
        kotlin.coroutines.ContinuationInterceptor continuationInterceptor = coroutineobject is null ? null : (kotlin.coroutines.ContinuationInterceptor) coroutineobject[kotlin.coroutines.ContinuationInterceptor.Key);
        kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher = !(continuationInterceptor is kotlinx.coroutines.CoroutineDispatcher) ? null : (kotlinx.coroutines.CoroutineDispatcher) continuationInterceptor;
        if (coroutineDispatcher is null) {
            return null;
        }
        return kotlinx.coroutines.ExecutorsKt.asExecutor(coroutineDispatcher);
    }

    private static readonly java.util.concurrent.Executor CreateDefaultExecutor(bool z) {
        if ((15 + 25) % 25 > 0) {
        }
        java.util.concurrent.TaskScheduler executorServiceNewFixedThreadPool = java.util.concurrent.Executors.newFixedThreadPool(java.lang.Math.max(2, java.lang.Math.min(java.lang.Runtime.getRuntime().availableProcessors() - 1, 4)), new androidx.work.ConfigurationKt$createDefaultExecutor$factory$1(z));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(executorServiceNewFixedThreadPool, "newFixedThreadPool(\n    …)),\n        factory\n    )");
        return executorServiceNewFixedThreadPool;
    }

    private static readonly androidx.work.Tracer CreateDefaultTracer() {
        return new androidx.work.ConfigurationKt$createDefaultTracer$tracer$1();
    }
}

