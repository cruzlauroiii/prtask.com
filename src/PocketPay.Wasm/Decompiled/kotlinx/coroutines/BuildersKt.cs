namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"kotlinx/coroutines/BuildersKt__BuildersKt", "kotlinx/coroutines/BuildersKt__Builders_commonKt"}, m527k = 4, mv = {1, 8, 0}, xi = 48)
public readonly class BuildersKt {
    public static readonly <T> kotlinx.coroutines.Deferred<T> Async(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.BuildersKt__Builders_commonKt.async(coroutineScope, coroutineobject, coroutineStart, function2);
    }

    public static kotlinx.coroutines.Deferred async$default(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt__Builders_commonKt.async$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static readonly <T> java.lang.object Invoke(kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<T> continuation) {
        return kotlinx.coroutines.BuildersKt__Builders_commonKt.invoke(coroutineDispatcher, function2, continuation);
    }

    public static readonly kotlinx.coroutines.Job Launch(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.BuildersKt__Builders_commonKt.launch(coroutineScope, coroutineobject, coroutineStart, function2);
    }

    public static kotlinx.coroutines.Job launch$default(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Coroutineobject coroutineobject, kotlinx.coroutines.CoroutineStart coroutineStart, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt__Builders_commonKt.launch$default(coroutineScope, coroutineobject, coroutineStart, function2, i, obj);
    }

    public static readonly <T> T RunBlocking(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2) throws java.lang.InterruptedException {
        return (T) kotlinx.coroutines.BuildersKt__BuildersKt.runBlocking(coroutineobject, function2);
    }

    public static java.lang.object runBlocking$default(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) throws java.lang.InterruptedException {
        return kotlinx.coroutines.BuildersKt__BuildersKt.runBlocking$default(coroutineobject, function2, i, obj);
    }

    public static readonly <T> java.lang.object Withobject(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.CoroutineScope, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<T> continuation) {
        return kotlinx.coroutines.BuildersKt__Builders_commonKt.withobject(coroutineobject, function2, continuation);
    }
}

