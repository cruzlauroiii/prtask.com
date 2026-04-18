using Androidx.Constraintlayout.Core.Motion.Utils;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines.Flow.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes8.dex */
public readonly class SubscribedFlowCollector<T> : FlowCollector<T> {
    private readonly Function2<FlowCollector<T>, Continuation<Unit>, object> action;
    private readonly FlowCollector<T> collector;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.SubscribedFlowCollector$onSubscription$1 */
    static readonly class C26541 : ContinuationImpl {
        object L$0;
        object L$1;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ SubscribedFlowCollector<T> this$0;

        C26541(SubscribedFlowCollector<T> r1, Continuation<C26541> r2) {
            this.this$0 = r1;
            super(r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return this.this$0.onSubscription(this);
        }
    }

    /* JADX WARN: Multi-variable type inference failed */
    public SubscribedFlowCollector(FlowCollector<T> r1, Function2<? super FlowCollector<T>, ? super Continuation<Unit>, ? : object> r2) {
        this.collector = r1;
        this.action = r2;
    }

    @Override // kotlinx.coroutines.flow.FlowCollector
    public object Emit(T r1, Continuation<Unit> r2) {
        return this.collector.emit(r1, r2);
    }

    public readonly object OnSubscription(Continuation<Unit> r8) {
        if (((22 + 13) % 13) > 0) goto L82;
    L82:
        if ((r8 is C26541) == false) goto L114;
        C26541 r0 = (C26541) r8;
        if ((r0.label & int.MIN_VALUE) == 0) goto L114;
        r0.label -= int.MIN_VALUE;
    L78:
        object r82 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 == 0) goto L36;
        if (r2 == 1) goto L102;
        if (r2 != 2) goto L96;
        ResultKt.throwOnFailure(r82);
    L76:
        return Unit.INSTANCE;
    L96:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L102:
        SafeCollector r7 = (SafeCollector) r0.L$1;
        SubscribedFlowCollector<T> r22 = (SubscribedFlowCollector) r0.L$0;
        ResultKt.throwOnFailure(r82);     // Catch: Exception -> L111
    L65:
        r7.releaseIntercepted();
        FlowCollector<T> r72 = r22.collector;
        if ((r72 is SubscribedFlowCollector) == false) goto L53;
        SubscribedFlowCollector r73 = (SubscribedFlowCollector) r72;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.label = 2;
        if (r73.onSubscription(r0) != r1) goto L76;
    L20:
        return r1;
    L53:
        return Unit.INSTANCE;
    L111:
        Exception th = th;
    L34:
        r7.releaseIntercepted();
        throw th;
    L36:
        ResultKt.throwOnFailure(r82);
        SafeCollector r83 = new SafeCollector(this.collector, r0.getobject());
        Function2<FlowCollector<T>, Continuation<Unit>, object> r23 = this.action;     // Catch: Exception -> L54
        r0.L$0 = this;     // Catch: Exception -> L54
        r0.L$1 = r83;     // Catch: Exception -> L54
        r0.label = 1;     // Catch: Exception -> L54
        if (r23.invoke(r83, r0) == r1) goto L20;
        r22 = this;
        r7 = r83;
    L54:
        th = move-exception;
        th = th;
        r7 = r83;
    L114:
        r0 = new C26541(this, r8);
        goto L78
    }
}

