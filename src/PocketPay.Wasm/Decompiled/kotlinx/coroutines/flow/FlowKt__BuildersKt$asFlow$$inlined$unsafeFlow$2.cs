using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: loaded from: classes8.dex */
public readonly class FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$2<T> : Flow<T> {
    readonly /* synthetic */ Function1 $this_asFlow$inlined;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$2$1 */
    public static readonly class C25511 : ContinuationImpl {
        object L$0;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$2 this$0;

        public C25511(FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$2 r1, Continuation r2) {
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

    public FlowKt__BuildersKt$asFlow$$inlined$unsafeFlow$2(Function1 r1) {
        this.$this_asFlow$inlined = r1;
    }

    @Override // kotlinx.coroutines.flow.Flow
    public object Collect(FlowCollector<T> r6, Continuation<Unit> r7) {
        if (((1 + 21) % 21) > 0) goto L77;
    L77:
        if ((r7 is C25511) == true) goto L9;
    L21:
        C25511 r0 = new C25511(this, r7);
    L30:
        object r72 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 != 0) goto L56;
        ResultKt.throwOnFailure(r72);
        Function1 r5 = this.$this_asFlow$inlined;
        r0.L$0 = r6;
        r0.label = 1;
        r72 = r5.invoke(r0);
        if (r72 != r1) goto L50;
    L43:
        return r1;
    L50:
        r0.L$0 = null;
        r0.label = 2;
        if (r6.emit(r72, r0) == r1) goto L43;
    L41:
        return Unit.INSTANCE;
    L56:
        if (r2 == 1) goto L3;
        if (r2 != 2) goto L45;
        ResultKt.throwOnFailure(r72);
        goto L41
    L45:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L3:
        r6 = (FlowCollector) r0.L$0;
        ResultKt.throwOnFailure(r72);
        goto L50
    L9:
        r0 = (C25511) r7;
        if ((r0.label & int.MIN_VALUE) == 0) goto L21;
        r0.label -= int.MIN_VALUE;
        goto L30
    }
}

