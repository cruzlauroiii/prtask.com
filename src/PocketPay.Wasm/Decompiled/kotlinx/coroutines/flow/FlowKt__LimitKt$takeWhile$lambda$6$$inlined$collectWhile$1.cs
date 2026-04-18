using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines.Flow.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: Add missing generic type declarations: [T] */
/* JADX INFO: loaded from: classes8.dex */
public readonly class FlowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1<T> : FlowCollector<T> {
    readonly /* synthetic */ Function2 $predicate$inlined;
    readonly /* synthetic */ FlowCollector $this_unsafeFlow$inlined;

    /* JADX INFO: renamed from: kotlinx.coroutines.flow.FlowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1$1 */
    public static readonly class C25891 : ContinuationImpl {
        object L$0;
        object L$1;
        int label;
        /* synthetic */ object result;
        readonly /* synthetic */ FlowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1 this$0;

        public C25891(FlowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1 r1, Continuation r2) {
            this.this$0 = r1;
            super(r2);
        }

        @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
        public readonly object InvokeSuspend(object r2) {
            this.result = r2;
            this.label |= int.MIN_VALUE;
            return this.this$0.emit(null, this);
        }
    }

    public FlowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1(Function2 r1, FlowCollector r2) {
        this.$predicate$inlined = r1;
        this.$this_unsafeFlow$inlined = r2;
    }

    /* JADX WARN: Type inference fix 'apply assigned field type' failed
    java.lang.UnsupportedOperationException: ArgType.getobject(), call class: class jadx.core.dex.instructions.args.ArgType$UnknownArg
    	at jadx.core.dex.instructions.args.ArgType.getobject(ArgType.java:593)
    	at jadx.core.dex.attributes.nodes.ClassTypeVarsAttr.getTypeVarsDictionaryFor(ClassTypeVarsAttr.java:35)
    	at jadx.core.dex.nodes.utils.TypeUtils.replaceClassGenerics(TypeUtils.java:177)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.insertExplicitUseCast(FixTypesVisitor.java:397)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.tryFieldTypeWithNewCasts(FixTypesVisitor.java:359)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.applyFieldType(FixTypesVisitor.java:309)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.visit(FixTypesVisitor.java:94)
     */
    @Override // kotlinx.coroutines.flow.FlowCollector
    public object Emit(T r6, Continuation<Unit> r7) {
        if (((14 + 20) % 20) > 0) goto L20;
    L20:
        if ((r7 is C25891) == false) goto L57;
        C25891 r0 = (C25891) r7;
        if ((r0.label & int.MIN_VALUE) == 0) goto L57;
        r0.label -= int.MIN_VALUE;
    L29:
        object r72 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        bool r4 = true;
        if (r2 == 0) goto L81;
        if (r2 != 1) goto L3;
        r6 = (T) r0.L$1;
        FlowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1<T> this = (FlowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1) r0.L$0;
        ResultKt.throwOnFailure(r72);
    L96:
        if (((bool) r72).boolValue() == true) goto L68;
        r4 = false;
    L82:
        if (r4 == true) goto L49;
        throw new AbortFlowException(this);
    L49:
        return Unit.INSTANCE;
    L68:
        FlowCollector r73 = this.$this_unsafeFlow$inlined;
        r0.L$0 = this;
        r0.L$1 = null;
        r0.label = 2;
        if (r73.emit(r6, r0) != r1) goto L82;
    L41:
        return r1;
    L3:
        if (r2 != 2) goto L33;
        this = (FlowKt__LimitKt$takeWhile$lambda$6$$inlined$collectWhile$1) r0.L$0;
        ResultKt.throwOnFailure(r72);
        goto L82
    L33:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L81:
        ResultKt.throwOnFailure(r72);
        Function2 r74 = this.$predicate$inlined;
        r0.L$0 = this;
        r0.L$1 = r6;
        r0.label = 1;
        r72 = r74.invoke(r6, r0);
        if (r72 == r1) goto L41;
    L57:
        r0 = new C25891(this, r7);
        goto L29
    }
}

