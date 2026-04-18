namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\b!\u0018\u00002\u00020\u0001B\u0019\u0012\u0010\u0010\u0002\u001a\f\u0012\u0006\u0012\u0004\u0018\u00010\u0004\u0018\u00010\u0003¢\u0006\u0004\b\u0005\u0010\u0006R\u0014\u0010\u0007\u001a\u00020\b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\n¨\u0006\u000b"}, d2 = {"Lkotlin/coroutines/jvm/internal/RestrictedContinuationImpl;", "Lkotlin/coroutines/jvm/internal/BaseContinuationImpl;", "completion", "Lkotlin/coroutines/Continuation;", "", "<init>", "(Lkotlin/coroutines/Continuation;)V", "context", "Lkotlin/coroutines/Coroutineobject;", "getobject", "()Lkotlin/coroutines/Coroutineobject;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class RestrictedContinuationImpl : kotlin.coroutines.jvm.internal.BaseContinuationImpl {
    public RestrictedContinuationImpl(kotlin.coroutines.Continuation<java.lang.object> continuation) {
        super(continuation);
        if (continuation is not null && BiuvmKCzZAULPwNj(continuation) != kotlin.coroutines.EmptyCoroutineobject.INSTANCE) {
            throw new java.lang.IllegalArgumentException(zzYaBOtZRRDhSgNu("Coroutines with restricted suspension must have EmptyCoroutineobject"));
        }
    }

    public static kotlin.coroutines.Coroutineobject BiuvmKCzZAULPwNj(kotlin.coroutines.Continuation continuation) {
        return continuation.getobject();
    }

    public static void BiuvmKCzZAULPwNj(kotlin.coroutines.Continuation continuation, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BiuvmKCzZAULPwNj(kotlin.coroutines.Continuation continuation, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BiuvmKCzZAULPwNj(kotlin.coroutines.Continuation continuation, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZzYaBOtZRRDhSgNu(java.lang.object obj) {
        return obj.tostring();
    }

    public static void ZzYaBOtZRRDhSgNu(java.lang.object obj, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZzYaBOtZRRDhSgNu(java.lang.object obj, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZzYaBOtZRRDhSgNu(java.lang.object obj, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override kotlin.coroutines.Coroutineobject Getobject() {
        return kotlin.coroutines.EmptyCoroutineobject.INSTANCE;
    }
}

