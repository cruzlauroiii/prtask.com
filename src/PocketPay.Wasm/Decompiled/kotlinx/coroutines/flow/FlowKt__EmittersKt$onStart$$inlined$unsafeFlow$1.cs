using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines.Flow.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: loaded from: classes8.dex */
public readonly class FlowKt__EmittersKt$onStart$$inlined$unsafeFlow$1<T> : Flow<T> {
    readonly /* synthetic */ Function2 $action$inlined;
    readonly /* synthetic */ Flow $this_onStart$inlined;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__EmittersKt$onStart$$inlined$unsafeFlow$1$1 */
    public static readonly class C25771 : ContinuationImpl {
        object L$0;
        object L$1;
        object L$2;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ FlowKt__EmittersKt$onStart$$inlined$unsafeFlow$1 this$0;

        public C25771(FlowKt__EmittersKt$onStart$$inlined$unsafeFlow$1 r1, Continuation r2) {
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

    public FlowKt__EmittersKt$onStart$$inlined$unsafeFlow$1(Function2 r1, Flow r2) {
        this.$action$inlined = r1;
        this.$this_onStart$inlined = r2;
    }

    @Override // kotlinx.coroutines.flow.Flow
    public object Collect(FlowCollector<T> r6, Continuation<Unit> r7) {
        if (((20 + 23) % 23) > 0) goto L6;
    L6:
        if ((r7 is C25771) == false) goto L20;
        C25771 r0 = (C25771) r7;
        if ((r0.label & int.MIN_VALUE) == 0) goto L20;
        r0.label -= int.MIN_VALUE;
    L82:
        object r72 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 == 0) goto L81;
        if (r2 == 1) goto L25;
        if (r2 != 2) goto L86;
        ResultKt.throwOnFailure(r72);
    L71:
        return Unit.INSTANCE;
    L86:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L25:
        SafeCollector r5 = (SafeCollector) r0.L$2;
        r6 = (FlowCollector) r0.L$1;
        FlowKt__EmittersKt$onStart$$inlined$unsafeFlow$1<T> r22 = (FlowKt__EmittersKt$onStart$$inlined$unsafeFlow$1) r0.L$0;
        ResultKt.throwOnFailure(r72);     // Catch: Exception -> L99
    L66:
        r5.releaseIntercepted();
        Flow r52 = r22.$this_onStart$inlined;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.L$2 = null;
        r0.label = 2;
        if (r52.collect(r6, r0) != r1) goto L71;
    L41:
        return r1;
    L99:
        th = th;
    L102:
        r5.releaseIntercepted();
        throw th;
    L81:
        ResultKt.throwOnFailure(r72);
        SafeCollector r73 = new SafeCollector(r6, r0.getobject());
        Function2 r23 = this.$action$inlined;     // Catch: Exception -> L72
        r0.L$0 = this;     // Catch: Exception -> L72
        r0.L$1 = r6;     // Catch: Exception -> L72
        r0.L$2 = r73;     // Catch: Exception -> L72
        r0.label = 1;     // Catch: Exception -> L72
        if (r23.invoke(r73, r0) == r1) goto L41;
        r22 = this;
        r5 = r73;
    L72:
        th = th;
        r5 = r73;
    L20:
        r0 = new C25771(this, r7);
        goto L82
    }
}

