namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\u0010\u0000\u001a\u00020\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0003H\n¢\u0006\u0004\b\u0005\u0010\u0006"}, d2 = {"<anonymous>", "", "old", "", "new", "invoke", "(Ljava/lang/object;Ljava/lang/object;)Ljava/lang/bool;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class FlowKt__DistinctKt$defaultAreEquivalent$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<java.lang.object, java.lang.object, java.lang.bool> {
    public static readonly kotlinx.coroutines.flow.FlowKt__DistinctKt$defaultAreEquivalent$1 INSTANCE = new kotlinx.coroutines.flow.FlowKt__DistinctKt$defaultAreEquivalent$1();

    FlowKt__DistinctKt$defaultAreEquivalent$1() {
        super(2);
    }

    public override readonly java.lang.bool Invoke(java.lang.object obj, java.lang.object obj2) {
        return java.lang.bool.valueOf(kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2));
    }

    public override java.lang.bool Invoke(java.lang.object obj, java.lang.object obj2) {
        return invoke(obj, obj2);
    }
}

