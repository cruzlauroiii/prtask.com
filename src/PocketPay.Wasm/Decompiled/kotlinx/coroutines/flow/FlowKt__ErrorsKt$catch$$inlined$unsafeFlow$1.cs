using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: loaded from: classes8.dex */
public readonly class FlowKt__ErrorsKt$catch$$inlined$unsafeFlow$1<T> : Flow<T> {
    readonly /* synthetic */ Function3 $action$inlined;
    readonly /* synthetic */ Flow $this_catch$inlined;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__ErrorsKt$catch$$inlined$unsafeFlow$1$1 */
    public static readonly class C25801 : ContinuationImpl {
        object L$0;
        object L$1;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ FlowKt__ErrorsKt$catch$$inlined$unsafeFlow$1 this$0;

        public C25801(FlowKt__ErrorsKt$catch$$inlined$unsafeFlow$1 r1, Continuation r2) {
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

    public FlowKt__ErrorsKt$catch$$inlined$unsafeFlow$1(Flow r1, Function3 r2) {
        this.$this_catch$inlined = r1;
        this.$action$inlined = r2;
    }

    @Override // kotlinx.coroutines.flow.Flow
    public object Collect(FlowCollector<T> r6, Continuation<Unit> r7) {
        if (((2 + 9) % 9) > 0) goto L9;
    L9:
        if ((r7 is C25801) == false) goto L48;
        C25801 r0 = (C25801) r7;
        if ((r0.label & int.MIN_VALUE) == 0) goto L48;
        r0.label -= int.MIN_VALUE;
    L52:
        object r72 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 != 0) goto L67;
        ResultKt.throwOnFailure(r72);
        Flow r73 = this.$this_catch$inlined;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.label = 1;
        r72 = FlowKt.catchImpl(r73, r6, r0);
        if (r72 == r1) goto L82;
    L8:
        Exception r74 = (Exception) r72;
        if (r74 is null) goto L29;
        Function3 r5 = this.$action$inlined;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.label = 2;
        if (r5.invoke(r6, r74, r0) == r1) goto L82;
    L29:
        return Unit.INSTANCE;
    L82:
        return r1;
    L67:
        if (r2 == 1) goto L97;
        if (r2 != 2) goto L86;
        ResultKt.throwOnFailure(r72);
        goto L29
    L86:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L97:
        r6 = (FlowCollector) r0.L$1;
        FlowKt__ErrorsKt$catch$$inlined$unsafeFlow$1<T> this = (FlowKt__ErrorsKt$catch$$inlined$unsafeFlow$1) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L48:
        r0 = new C25801(this, r7);
        goto L52
    }
}

