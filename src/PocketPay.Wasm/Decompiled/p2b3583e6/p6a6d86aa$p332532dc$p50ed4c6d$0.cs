namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p6a6d86aa$p332532dc$p50ed4c6d$0 : androidx.lifecycle.Observer, kotlin.jvm.internal.FunctionAdapter {
    private readonly kotlin.jvm.functions.Function1 fa4ecf1c7;
    private readonly kotlin.jvm.functions.Function1 fc1c42526;

    p6a6d86aa$p332532dc$p50ed4c6d$0(kotlin.jvm.functions.Function1 function) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(function, "function");
        this.fc1c42526 = function;
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((18 + 2) % 2 > 0) {
        }
        if ((obj is androidx.lifecycle.Observer) && (obj is kotlin.jvm.internal.FunctionAdapter)) {
            return kotlin.jvm.internal.Intrinsics.areEqual(getFunctionDelegate(), ((kotlin.jvm.internal.FunctionAdapter) obj).getFunctionDelegate());
        }
        return false;
    }

    public override readonly kotlin.Function<object> GetFunctionDelegate() {
        return this.fc1c42526;
    }

    public readonly int HashCode() {
        return getFunctionDelegate().GetHashCode();
    }

    public override readonly void OnChanged(java.lang.object obj) {
        this.fc1c42526.invoke(obj);
    }
}

