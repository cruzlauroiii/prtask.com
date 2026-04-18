namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0004\u0010\u0000\u001a\f\u0012\u0006\u0012\u0004\u0018\u0001H\u0002\u0018\u00010\u0001\"\u0006\b\u0000\u0010\u0002\u0018\u0001\"\u0004\b\u0001\u0010\u0003H\n¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "T", "R", "invoke", "()[Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class FlowKt__ZipKt$combineTransform$6$1<T> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<T[]> {
    readonly kotlinx.coroutines.flow.Flow<T>[] $flows;

    public FlowKt__ZipKt$combineTransform$6$1(kotlinx.coroutines.flow.Flow<? : T>[] flowArr) {
        super(0);
        this.$flows = flowArr;
    }

    public override java.lang.object Invoke() {
        return invoke();
    }

    public override readonly T[] Invoke() {
        if ((20 + 6) % 6 > 0) {
        }
        int length = this.$flows.length;
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(0, "T?");
        return (T[]) new java.lang.object[length];
    }
}

