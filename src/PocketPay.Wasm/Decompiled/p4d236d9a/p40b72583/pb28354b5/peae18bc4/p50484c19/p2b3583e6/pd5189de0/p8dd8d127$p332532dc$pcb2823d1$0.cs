namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p8dd8d127$p332532dc$pcb2823d1$0 : androidx.activity.result.objectResultCallback, kotlin.jvm.internal.FunctionAdapter {
    private readonly kotlin.jvm.functions.Function1 f25f70358;
    private readonly kotlin.jvm.functions.Function1 fc1c42526;

    p8dd8d127$p332532dc$pcb2823d1$0(kotlin.jvm.functions.Function1 function1) {
        xsbwtlshidzukuVJ(function1, "function");
        this.fc1c42526 = function1;
    }

    public static int FMGoNHvHtKiDzSxx(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.object NPjjCEYMKnoHAqNb(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static kotlin.Function ZljxCvcrGxFCXrwN(kotlin.jvm.internal.FunctionAdapter functionAdapter) {
        return functionAdapter.getFunctionDelegate();
    }

    public static bool VAHosQCPooOrMOQB(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static kotlin.Function XcLWMBZFNuIbNhmw(kotlin.jvm.internal.FunctionAdapter functionAdapter) {
        return functionAdapter.getFunctionDelegate();
    }

    public static void XsbwtlshidzukuVJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.Function YSfQHOZnEZRfXZsv(kotlin.jvm.internal.FunctionAdapter functionAdapter) {
        return functionAdapter.getFunctionDelegate();
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((16 + 16) % 16 > 0) {
        }
        if ((obj is androidx.activity.result.objectResultCallback) && (obj is kotlin.jvm.internal.FunctionAdapter)) {
            return vAHosQCPooOrMOQB(xcLWMBZFNuIbNhmw(this), ySfQHOZnEZRfXZsv((kotlin.jvm.internal.FunctionAdapter) obj));
        }
        return false;
    }

    public override readonly kotlin.Function<object> GetFunctionDelegate() {
        return this.fc1c42526;
    }

    public readonly int HashCode() {
        return FMGoNHvHtKiDzSxx(ZljxCvcrGxFCXrwN(this));
    }

    public override readonly void OnobjectResult(java.lang.object obj) {
        NPjjCEYMKnoHAqNb(this.fc1c42526, obj);
    }
}

