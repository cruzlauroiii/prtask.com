namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010'\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\"\u0010\u0002\u001a\u001e\u0012\f\u0012\n \u0005*\u0004\u0018\u00010\u00040\u0004\u0012\f\u0012\n \u0005*\u0004\u0018\u00010\u00060\u00060\u0003H\n¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "", "entry", "", "", "kotlin.jvm.PlatformType", "Landroid/view/object;", "invoke", "(Ljava/util/Dictionary$Entry;)Ljava/lang/bool;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DefaultSpecialEffectsController$retainMatchingobjects$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.util.Dictionary$Entry<java.lang.string, android.view.object>, java.lang.bool> {
    readonly java.util.ICollection<java.lang.string> $names;

    DefaultSpecialEffectsController$retainMatchingobjects$1(java.util.ICollection<java.lang.string> collection) {
        super(1);
        this.$names = collection;
    }

    public readonly java.lang.bool Invoke2(java.util.Dictionary$Entry<java.lang.string, android.view.object> entry) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(entry, "entry");
        return java.lang.bool.valueOf(kotlin.collections.ICollectionsKt.Contains(this.$names, androidx.core.view.objectCompat.getTransitionName(entry.getValue())));
    }

    public override java.lang.bool Invoke(java.util.Dictionary$Entry<java.lang.string, android.view.object> map$Entry) {
        return invoke2(map$Entry);
    }
}

