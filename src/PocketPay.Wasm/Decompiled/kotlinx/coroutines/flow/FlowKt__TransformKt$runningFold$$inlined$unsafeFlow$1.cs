using Android;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: Add missing generic type declarations: [R] */
/* JADX INFO: loaded from: classes8.dex */
public readonly class FlowKt__TransformKt$runningFold$$inlined$unsafeFlow$1<R> : Flow<R> {
    readonly /* synthetic */ object $initial$inlined;
    readonly /* synthetic */ Function3 $operation$inlined;
    readonly /* synthetic */ Flow $this_runningFold$inlined;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__TransformKt$runningFold$$inlined$unsafeFlow$1$1 */
    public static readonly class C26331 : ContinuationImpl {
        object L$0;
        object L$1;
        object L$2;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ FlowKt__TransformKt$runningFold$$inlined$unsafeFlow$1 this$0;

        public C26331(FlowKt__TransformKt$runningFold$$inlined$unsafeFlow$1 r1, Continuation r2) {
            this.this$0 = r1;
            super(r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return this.this$0.collect(null, this);
        }
    }

    public FlowKt__TransformKt$runningFold$$inlined$unsafeFlow$1(object r1, Flow r2, Function3 r3) {
        this.$initial$inlined = r1;
        this.$this_runningFold$inlined = r2;
        this.$operation$inlined = r3;
    }

    /* JADX WARN: Type inference failed for: r2v2, types: [T, java.lang.object] */
    @Override // kotlinx.coroutines.flow.Flow
    public object Collect(FlowCollector<R> r6, Continuation<Unit> r7) {
        if (((9 + 27) % 27) > 0) goto L91;
    L91:
        if ((r7 is C26331) == true) goto L8;
    L98:
        C26331 r0 = new C26331(this, r7);
    L85:
        object r72 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 == 0) goto L68;
        if (r2 == 1) goto L84;
        if (r2 != 2) goto L6;
        ResultKt.throwOnFailure(r72);
    L27:
        return Unit.INSTANCE;
    L6:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L84:
        Ref.objectRef r5 = (Ref.objectRef) r0.L$2;
        r6 = (FlowCollector) r0.L$1;
        FlowKt__TransformKt$runningFold$$inlined$unsafeFlow$1<R> r22 = (FlowKt__TransformKt$runningFold$$inlined$unsafeFlow$1) r0.L$0;
        ResultKt.throwOnFailure(r72);
        Ref.objectRef r73 = r5;
        FlowKt__TransformKt$runningFold$$inlined$unsafeFlow$1<R> this = r22;
    L47:
        Flow r23 = this.$this_runningFold$inlined;
        FlowKt__TransformKt$runningFold$1$1 r4 = new FlowKt__TransformKt$runningFold$1$1(r73, this.$operation$inlined, r6);
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.label = 2;
        if (r23.collect(r4, r0) != r1) goto L27;
    L76:
        return r1;
    L68:
        ResultKt.throwOnFailure(r72);
        r73 = new Ref.objectRef();
        r73.element = this.$initial$inlined;
        R.bool r24 = (object) r73.element;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.L$2 = r73;
        r0.label = 1;
        if (r6.emit(r24, r0) == r1) goto L76;
    L8:
        r0 = (C26331) r7;
        if ((r0.label & int.MIN_VALUE) == 0) goto L98;
        r0.label -= int.MIN_VALUE;
        goto L85
    }
}

