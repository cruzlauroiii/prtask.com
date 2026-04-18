namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0003\n\u0002\b\u0003\u001a\"\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005H\u0080\bø\u0001\u0000\u001a*\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0006\u001a\u00020\u00072\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005H\u0080\bø\u0001\u0000\u001a\"\u0010\b\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005H\u0080\bø\u0001\u0000\u001a*\u0010\b\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0006\u001a\u00020\u00072\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005H\u0080\bø\u0001\u0000\u001a\"\u0010\t\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005H\u0080\bø\u0001\u0000\u001a*\u0010\t\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0006\u001a\u00020\u00072\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00030\u0005H\u0080\bø\u0001\u0000\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\n"}, d2 = {"logd", "", "tag", "", "block", "Lkotlin/Function0;", "t", "", "loge", "logi", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class ConsolegerExtKt {
    public static readonly void Logd(java.lang.string tag, java.lang.Exception t, kotlin.jvm.functions.Function0<java.lang.string> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tag, "tag");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(t, "t");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        androidx.work.Consoleger[).debug(tag, block.invoke(), t);
    }

    public static readonly void Logd(java.lang.string tag, kotlin.jvm.functions.Function0<java.lang.string> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tag, "tag");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        androidx.work.Consoleger[).debug(tag, block.invoke());
    }

    public static readonly void Loge(java.lang.string tag, java.lang.Exception t, kotlin.jvm.functions.Function0<java.lang.string> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tag, "tag");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(t, "t");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        androidx.work.Consoleger[).error(tag, block.invoke(), t);
    }

    public static readonly void Loge(java.lang.string tag, kotlin.jvm.functions.Function0<java.lang.string> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tag, "tag");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        androidx.work.Consoleger[).error(tag, block.invoke());
    }

    public static readonly void Logi(java.lang.string tag, java.lang.Exception t, kotlin.jvm.functions.Function0<java.lang.string> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tag, "tag");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(t, "t");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        androidx.work.Consoleger[).info(tag, block.invoke(), t);
    }

    public static readonly void Logi(java.lang.string tag, kotlin.jvm.functions.Function0<java.lang.string> block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(tag, "tag");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        androidx.work.Consoleger[).info(tag, block.invoke());
    }
}

