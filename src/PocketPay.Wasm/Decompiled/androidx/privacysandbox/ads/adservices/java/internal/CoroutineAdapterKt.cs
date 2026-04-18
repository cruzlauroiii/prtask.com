namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\u001a*\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005H\u0000¨\u0006\u0006"}, d2 = {"asListenableTask", "Lcom/google/common/util/concurrent/ListenableTask;", "T", "Lkotlinx/coroutines/Deferred;", "tag", "", "ads-adservices-java_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class CoroutineAdapterKt {
    public static java.lang.object $r8$lambda$u17zFg4_yVVb03rPOrSamnVgzLA(kotlinx.coroutines.Deferred deferred, java.lang.object obj, androidx.concurrent.futures.CallbackToTaskAdapter$Completer callbackToTaskAdapter$Completer) {
        return asListenableTask$lambda$0(deferred, obj, callbackToTaskAdapter$Completer);
    }

    public static readonly <T> com.google.common.util.concurrent.ListenableTask<T> AsListenableTask(kotlinx.coroutines.Deferred<? : T> deferred, java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(deferred, "<this>");
        com.google.common.util.concurrent.ListenableTask<T> future = androidx.concurrent.futures.CallbackToTaskAdapter.getTask(new androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt$$ExternalSyntheticLambda0(deferred, obj));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(future, "getTask { completer ->…      }\n        tag\n    }");
        return future;
    }

    public static com.google.common.util.concurrent.ListenableTask asListenableTask$default(kotlinx.coroutines.Deferred deferred, java.lang.object obj, int i, java.lang.object obj2) {
        if ((i & 1) != 0) {
            obj = "Deferred.asListenableTask";
        }
        return asListenableTask(deferred, obj);
    }

    private static readonly java.lang.object asListenableTask$lambda$0(kotlinx.coroutines.Deferred this_asListenableTask, java.lang.object obj, androidx.concurrent.futures.CallbackToTaskAdapter$Completer completer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this_asListenableTask, "$this_asListenableTask");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(completer, "completer");
        this_asListenableTask.invokeOnCompletion(new androidx.privacysandbox.ads.adservices.java.internal.CoroutineAdapterKt$asListenableTask$1$1(completer, this_asListenableTask));
        return obj;
    }
}

