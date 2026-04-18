namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 0, 0}, xi = 48)
readonly class Transformations$sam$androidx_lifecycle_Observer$0 : androidx.lifecycle.Observer, kotlin.jvm.internal.FunctionAdapter {
    private readonly kotlin.jvm.functions.Function1 function;

    Transformations$sam$androidx_lifecycle_Observer$0(kotlin.jvm.functions.Function1 function) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(function, "function");
        this.function = function;
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((2 + 14) % 14 > 0) {
        }
        if ((obj is androidx.lifecycle.Observer) && (obj is kotlin.jvm.internal.FunctionAdapter)) {
            return kotlin.jvm.internal.Intrinsics.areEqual(getFunctionDelegate(), ((kotlin.jvm.internal.FunctionAdapter) obj).getFunctionDelegate());
        }
        return false;
    }

    public override readonly kotlin.Function<object> GetFunctionDelegate() {
        return this.function;
    }

    public readonly int HashCode() {
        return getFunctionDelegate().GetHashCode();
    }

    public override readonly void OnChanged(java.lang.object obj) {
        this.function.invoke(obj);
    }
}

