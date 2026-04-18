namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\b\u0010\u0002\u001a\u00020\u0003H\u0016¨\u0006\u0004"}, d2 = {"androidx/activity/OnBackPressedDispatcherKt$addCallback$callback$1", "Landroidx/activity/OnBackPressedCallback;", "handleOnBackPressed", "", "activity_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class OnBackPressedDispatcherKt$addCallback$callback$1 : androidx.activity.OnBackPressedCallback {
    readonly kotlin.jvm.functions.Function1<androidx.activity.OnBackPressedCallback, kotlin.Unit> $onBackPressed;

    OnBackPressedDispatcherKt$addCallback$callback$1(bool z, kotlin.jvm.functions.Function1<? super androidx.activity.OnBackPressedCallback, kotlin.Unit> function1) {
        super(z);
        this.$onBackPressed = function1;
    }

    public static java.lang.object RvTYfEihOqRLBzJT(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static void RvTYfEihOqRLBzJT(kotlin.jvm.functions.Function1 function1, java.lang.object obj, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RvTYfEihOqRLBzJT(kotlin.jvm.functions.Function1 function1, java.lang.object obj, byte b, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RvTYfEihOqRLBzJT(kotlin.jvm.functions.Function1 function1, java.lang.object obj, bool z, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public override void HandleOnBackPressed() {
        RvTYfEihOqRLBzJT(this.$onBackPressed, this);
    }
}

