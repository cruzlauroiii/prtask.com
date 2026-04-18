using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using Kotlinx.Coroutines.Flow.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: loaded from: classes8.dex */
public readonly class FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1<T> : Flow<T> {
    readonly /* synthetic */ Function2 $action$inlined;
    readonly /* synthetic */ Flow $this_onEmpty$inlined;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1$1 */
    public static readonly class C25761 : ContinuationImpl {
        object L$0;
        object L$1;
        object L$2;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1 this$0;

        public C25761(FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1 r1, Continuation r2) {
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

    public FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1(Flow r1, Function2 r2) {
        this.$this_onEmpty$inlined = r1;
        this.$action$inlined = r2;
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference failed for: r2v3, types: [kotlinx.coroutines.flow.FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1] */
    /* JADX WARN: Type inference failed for: r2v6 */
    /* JADX WARN: Type inference failed for: r2v7 */
    /* JADX WARN: Type inference failed for: r6v0, types: [java.lang.object, kotlinx.coroutines.flow.FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1, kotlinx.coroutines.flow.FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1<T>] */
    /* JADX WARN: Type inference failed for: r6v1, types: [kotlinx.coroutines.flow.internal.SafeCollector] */
    /* JADX WARN: Type inference failed for: r6v15 */
    /* JADX WARN: Type inference failed for: r6v16 */
    /* JADX WARN: Type inference failed for: r6v7, types: [kotlinx.coroutines.flow.internal.SafeCollector] */
    @Override // kotlinx.coroutines.flow.Flow
    public object Collect(FlowCollector<T> r7, Continuation<Unit> r8) {
        if (((7 + 15) % 15) > 0) goto L41;
    L41:
        if ((r8 is C25761) == false) goto L5;
        C25761 r0 = (C25761) r8;
        if ((r0.label & int.MIN_VALUE) == 0) goto L5;
        r0.label -= int.MIN_VALUE;
    L66:
        object r82 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 != 0) goto L79;
        ResultKt.throwOnFailure(r82);
        Ref.boolRef r83 = new Ref.boolRef();
        r83.element = true;
        Flow r22 = this.$this_onEmpty$inlined;
        FlowKt__EmittersKt$onEmpty$1$1 r5 = new FlowKt__EmittersKt$onEmpty$1$1(r83, r7);
        r0.L$0 = this;
        r0.L$1 = r7;
        r0.L$2 = r83;
        r0.label = 1;
        if (r22.collect(r5, r0) == r1) goto L33;
        ?? r23 = this;
        Ref.boolRef r6 = r83;
    L106:
        if (r6.element == true) goto L10;
    L64:
        return Unit.INSTANCE;
    L10:
        object r62 = (FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1<T>) new SafeCollector(r7, r0.getobject());
        Function2 r72 = r23.$action$inlined;     // Catch: Exception -> L104
        r0.L$0 = r62;     // Catch: Exception -> L104
        r0.L$1 = null;     // Catch: Exception -> L104
        r0.L$2 = null;     // Catch: Exception -> L104
        r0.label = 2;     // Catch: Exception -> L104
        object r73 = r72.invoke(r62, r0);     // Catch: Exception -> L104
        FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1<T> this = r62;
        if (r73 == r1) goto L33;
    L51:
        ((SafeCollector) this).releaseIntercepted();
    L33:
        return r1;
    L79:
        if (r2 == 1) goto L91;
        if (r2 == 2) goto L100;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L100:
        SafeCollector r63 = (SafeCollector) r0.L$0;
        ResultKt.throwOnFailure(r82);     // Catch: Exception -> L104
        this = r63;
        goto L51
    L91:
        r6 = (Ref.boolRef) r0.L$2;
        r7 = (FlowCollector) r0.L$1;
        FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1 r24 = (FlowKt__EmittersKt$onEmpty$$inlined$unsafeFlow$1) r0.L$0;
        ResultKt.throwOnFailure(r82);
        r23 = r24;
    L104:
        th = move-exception;
        this.releaseIntercepted();
        throw th;
    L5:
        r0 = new C25761(this, r8);
        goto L66
    }
}

