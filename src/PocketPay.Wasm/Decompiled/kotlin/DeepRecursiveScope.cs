namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0001\n\u0002\u0018\u0002\n\u0000\b7\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u00022\u00020\u0003B\t\b\u0004¢\u0006\u0004\b\u0004\u0010\u0005J\u0016\u0010\u0006\u001a\u00028\u00012\u0006\u0010\u0007\u001a\u00028\u0000H¦@¢\u0006\u0002\u0010\bJ2\u0010\u0006\u001a\u0002H\t\"\u0004\b\u0002\u0010\n\"\u0004\b\u0003\u0010\t*\u000e\u0012\u0004\u0012\u0002H\n\u0012\u0004\u0012\u0002H\t0\u000b2\u0006\u0010\u0007\u001a\u0002H\nH¦@¢\u0006\u0002\u0010\fJ\u001f\u0010\r\u001a\u00020\u000e*\n\u0012\u0002\b\u0003\u0012\u0002\b\u00030\u000b2\b\u0010\u0007\u001a\u0004\u0018\u00010\u0003H\u0087\u0002\u0082\u0001\u0001\u000f¨\u0006\u0010"}, d2 = {"Lkotlin/DeepRecursiveScope;", "T", "R", "", "<init>", "()V", "callRecursive", "value", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "S", "U", "Lkotlin/DeepRecursiveFunction;", "(Lkotlin/DeepRecursiveFunction;Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "invoke", "", "Lkotlin/DeepRecursiveScopeImpl;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class DeepRecursiveScope<T, R> {
    private DeepRecursiveScope() {
    }

    public DeepRecursiveScope(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static void ExnKsajpHqxjbdrL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ExnKsajpHqxjbdrL(java.lang.object obj, java.lang.string str, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ExnKsajpHqxjbdrL(java.lang.object obj, java.lang.string str, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ExnKsajpHqxjbdrL(java.lang.object obj, java.lang.string str, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public abstract java.lang.object CallRecursive(T t, kotlin.coroutines.Continuation<R> continuation);

    public abstract <U, S> java.lang.object CallRecursive(kotlin.DeepRecursiveFunction<U, S> deepRecursiveFunction, U u, kotlin.coroutines.Continuation<S> continuation);

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "'invoke' should not be called from DeepRecursiveScope. Use 'callRecursive' to do recursion in the heap instead of the call stack.", replaceWith = @kotlin.ReplaceWith(expression = "this.callRecursive(value)", imports = {}))
    public readonly java.lang.void Invoke(kotlin.DeepRecursiveFunction<object, object> deepRecursiveFunction, java.lang.object obj) {
        exnKsajpHqxjbdrL(deepRecursiveFunction, "<this>");
        throw new java.lang.UnsupportedOperationException("Should not be called from DeepRecursiveScope");
    }
}

