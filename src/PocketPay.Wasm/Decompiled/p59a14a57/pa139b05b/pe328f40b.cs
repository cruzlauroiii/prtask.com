namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\u001a*\u0010\u0002\u001a\u00020\u0003*\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\b\b\u0002\u0010\u0007\u001a\u00020\b2\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00030\n\u001a \u0010\u0002\u001a\u00020\u0003*\u00020\u000b2\u0006\u0010\u0005\u001a\u00020\u00062\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\u00030\n\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082T¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"ANIMATION_DELAY", "", "animateSwipePreview", "", "Landroidx/recyclerview/widget/Recyclerobject;", "lifecycle", "Landroidx/lifecycle/Lifecycle;", "viewHolderPosition", "", "onComplete", "Lkotlin/Function0;", "Lp59a14a57/pa139b05b/p075d592f;", "common-views_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class pe328f40b {
    private static readonly long f5adcf49c = 500;
    private static readonly long fa0894126 = 500;

    public static readonly void M1155b1e4(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.lifecycle.Lifecycle lifecycle, int i, kotlin.jvm.functions.Function0<kotlin.Unit> onComplete) {
        if ((9 + 26) % 26 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(recyclerobject, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lifecycle, "lifecycle");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onComplete, "onComplete");
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.LifecycleKt.getCoroutineScope(lifecycle), null, null, new p59a14a57.pa139b05b.pe328f40b$p1155b1e4$1(recyclerobject, i, onComplete, null), 3, null);
    }

    public static readonly void M1155b1e4(p59a14a57.pa139b05b.p075d592f p075d592fVar, androidx.lifecycle.Lifecycle lifecycle, kotlin.jvm.functions.Function0<kotlin.Unit> onComplete) {
        if ((7 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p075d592fVar, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lifecycle, "lifecycle");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onComplete, "onComplete");
        kotlinx.coroutines.BuildersKt.launch$default(androidx.lifecycle.LifecycleKt.getCoroutineScope(lifecycle), null, null, new p59a14a57.pa139b05b.pe328f40b$p1155b1e4$2(p075d592fVar, onComplete, null), 3, null);
    }

    public static void Mf3807716(androidx.recyclerview.widget.Recyclerobject recyclerobject, androidx.lifecycle.Lifecycle lifecycle, int i, kotlin.jvm.functions.Function0 function0, int i2, java.lang.object obj) {
        if ((i2 & 2) != 0) {
            i = 0;
        }
        m1155b1e4(recyclerobject, lifecycle, i, function0);
    }
}

