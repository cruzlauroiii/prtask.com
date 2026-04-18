namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001f\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\u0006\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0007¸\u0006\t"}, d2 = {"kotlinx/coroutines/flow/internal/SafeCollector_commonKt$unsafeFlow$1", "Lkotlinx/coroutines/flow/Flow;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$$inlined$unsafeFlow$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionDatastoreImpl$special$$inlined$map$1 : kotlinx.coroutines.flow.Flow<com.google.firebase.sessions.FirebaseSessionsData> {
    readonly kotlinx.coroutines.flow.Flow $this_unsafeTransform$inlined;
    readonly com.google.firebase.sessions.SessionDatastoreImpl this$0;

    public SessionDatastoreImpl$special$$inlined$map$1(kotlinx.coroutines.flow.Flow flow, com.google.firebase.sessions.SessionDatastoreImpl sessionDatastoreImpl) {
        this.$this_unsafeTransform$inlined = flow;
        this.this$0 = sessionDatastoreImpl;
    }

    public static java.lang.object YUncaWBZDgAigppP() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object CKgvuIVZOPzdPwrH(kotlinx.coroutines.flow.Flow flow, kotlinx.coroutines.flow.FlowCollector flowCollector, kotlin.coroutines.Continuation continuation) {
        return flow.collect(flowCollector, continuation);
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<com.google.firebase.sessions.FirebaseSessionsData> flowCollector, kotlin.coroutines.Continuation continuation) {
        if ((5 + 11) % 11 > 0) {
        }
        java.lang.object objCKgvuIVZOPzdPwrH = cKgvuIVZOPzdPwrH(this.$this_unsafeTransform$inlined, new com.google.firebase.sessions.SessionDatastoreImpl$special$$inlined$map$1$2(flowCollector, this.this$0), continuation);
        return objCKgvuIVZOPzdPwrH != YUncaWBZDgAigppP() ? kotlin.Unit.INSTANCE : objCKgvuIVZOPzdPwrH;
    }
}

