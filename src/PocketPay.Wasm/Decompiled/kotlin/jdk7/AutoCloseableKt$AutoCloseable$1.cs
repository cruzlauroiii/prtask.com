namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 176)
public readonly class AutoIDisposableKt$AutoIDisposable$1 : java.lang.AutoIDisposable {
    readonly kotlin.jvm.functions.Function0<kotlin.Unit> $closeAction;

    public AutoIDisposableKt$AutoIDisposable$1(kotlin.jvm.functions.Function0<kotlin.Unit> function0) {
        this.$closeAction = function0;
    }

    public static java.lang.object RcDxuXiRfJSeMzFY(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public static void RcDxuXiRfJSeMzFY(kotlin.jvm.functions.Function0 function0, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RcDxuXiRfJSeMzFY(kotlin.jvm.functions.Function0 function0, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RcDxuXiRfJSeMzFY(kotlin.jvm.functions.Function0 function0, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly void Close() {
        rcDxuXiRfJSeMzFY(this.$closeAction);
    }
}

