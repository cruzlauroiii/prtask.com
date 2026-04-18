namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000b\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "hasUnfinishedWork", ""}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.work.impl.UnfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$2", m533f = "UnfinishedWorkListener.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class UnfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<java.lang.bool, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly android.content.object $appobject;
    bool Z$0;
    int label;

    UnfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$2(android.content.object context, kotlin.coroutines.Continuation<? super androidx.work.impl.UnfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$2> continuation) {
        super(2, continuation);
        this.$appobject = context;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        androidx.work.impl.UnfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$2 unfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$2 = new androidx.work.impl.UnfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$2(this.$appobject, continuation);
        unfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$2.Z$0 = ((java.lang.bool) obj).boolValue();
        return unfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$2;
    }

    public override java.lang.object Invoke(java.lang.bool bool, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke(bool.boolValue(), continuation);
    }

    public readonly java.lang.object Invoke(bool z, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.work.impl.UnfinishedWorkListenerKt$maybeLaunchUnfinishedWorkListener$2) create(java.lang.bool.valueOf(z), continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.work.impl.utils.PackageManagerHelper.setComponentEnabled(this.$appobject, androidx.work.impl.background.systemalarm.RescheduleReceiver.class, this.Z$0);
        return kotlin.Unit.INSTANCE;
    }
}

