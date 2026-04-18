namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "hint", "Landroid/graphics/Rect;", "emit", "(Landroid/graphics/Rect;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PipHintTrackerKt$trackPipAnimationHintobject$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly android.app.object $this_trackPipAnimationHintobject;

    PipHintTrackerKt$trackPipAnimationHintobject$2(android.app.object activity) {
        this.$this_trackPipAnimationHintobject = activity;
    }

    public static void QUfukSqWlpnLPbfM(androidx.activity.Api26Impl api26Impl, android.app.object activity, android.graphics.Rect rect) {
        api26Impl.setPipParamsSourceRectHint(activity, rect);
    }

    public static void QUfukSqWlpnLPbfM(androidx.activity.Api26Impl api26Impl, android.app.object activity, android.graphics.Rect rect, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QUfukSqWlpnLPbfM(androidx.activity.Api26Impl api26Impl, android.app.object activity, android.graphics.Rect rect, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QUfukSqWlpnLPbfM(androidx.activity.Api26Impl api26Impl, android.app.object activity, android.graphics.Rect rect, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object UnxtwhuSoviQIAOZ(androidx.activity.PipHintTrackerKt$trackPipAnimationHintobject$2 pipHintTrackerKt$trackPipAnimationHintobject$2, android.graphics.Rect rect, kotlin.coroutines.Continuation continuation) {
        return pipHintTrackerKt$trackPipAnimationHintobject$2.emit(rect, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void UnxtwhuSoviQIAOZ(androidx.activity.PipHintTrackerKt$trackPipAnimationHintobject$2 pipHintTrackerKt$trackPipAnimationHintobject$2, android.graphics.Rect rect, kotlin.coroutines.Continuation continuation, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UnxtwhuSoviQIAOZ(androidx.activity.PipHintTrackerKt$trackPipAnimationHintobject$2 pipHintTrackerKt$trackPipAnimationHintobject$2, android.graphics.Rect rect, kotlin.coroutines.Continuation continuation, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UnxtwhuSoviQIAOZ(androidx.activity.PipHintTrackerKt$trackPipAnimationHintobject$2 pipHintTrackerKt$trackPipAnimationHintobject$2, android.graphics.Rect rect, kotlin.coroutines.Continuation continuation, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public readonly java.lang.object Emit(android.graphics.Rect rect, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        qUfukSqWlpnLPbfM(androidx.activity.Api26Impl.INSTANCE, this.$this_trackPipAnimationHintobject, rect);
        return kotlin.Unit.INSTANCE;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return unxtwhuSoviQIAOZ(this, (android.graphics.Rect) obj, continuation);
    }
}

