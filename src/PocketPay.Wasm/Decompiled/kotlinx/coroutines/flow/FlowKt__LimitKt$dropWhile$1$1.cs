using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes8.dex */
readonly class FlowKt__LimitKt$dropWhile$1$1<T> : FlowCollector {
    readonly /* synthetic */ Ref.boolRef $matched;
    readonly /* synthetic */ Function2<T, Continuation<bool>, object> $predicate;
    readonly /* synthetic */ FlowCollector<T> $this_unsafeFlow;

    /* JADX WARN: Multi-variable type inference failed */
    FlowKt__LimitKt$dropWhile$1$1(Ref.boolRef r1, FlowCollector<T> r2, Function2<? super T, ? super Continuation<bool>, ? : object> r3) {
        this.$matched = r1;
        this.$this_unsafeFlow = r2;
        this.$predicate = r3;
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
    public readonly object Emit(T r7, Continuation<Unit> r8) {
        if (((1 + 7) % 7) > 0) goto L61;
    L61:
        if ((r8 is FlowKt__LimitKt$dropWhile$1$1$emit$1) == true) goto L32;
    L30:
        FlowKt__LimitKt$dropWhile$1$1$emit$1 r0 = new FlowKt__LimitKt$dropWhile$1$1$emit$1(this, r8);
    L89:
        object r82 = r0.result;
        object r1 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r2 = r0.label;
        if (r2 != 0) goto L112;
        ResultKt.throwOnFailure(r82);
        if (this.$matched.element == true) goto L42;
        Function2<T, Continuation<bool>, object> r83 = this.$predicate;
        r0.L$0 = this;
        r0.L$1 = r7;
        r0.label = 2;
        r82 = r83.invoke(r7, r0);
        if (r82 != r1) goto L36;
    L80:
        return r1;
    L36:
        if (((bool) r82).boolValue() == true) goto L46;
        this.$matched.element = true;
        FlowCollector<T> r6 = this.$this_unsafeFlow;
        r0.L$0 = null;
        r0.L$1 = null;
        r0.label = 3;
        if (r6.emit(r7, r0) == r1) goto L80;
    L48:
        return Unit.INSTANCE;
    L46:
        return Unit.INSTANCE;
    L42:
        FlowCollector<T> r62 = this.$this_unsafeFlow;
        r0.label = 1;
        if (r62.emit(r7, r0) == r1) goto L80;
    L13:
        return Unit.INSTANCE;
    L112:
        if (r2 != 1) goto L43;
        ResultKt.throwOnFailure(r82);
        goto L13
    L43:
        if (r2 != 2) goto L55;
        r7 = (T) r0.L$1;
        FlowKt__LimitKt$dropWhile$1$1<T> this = (FlowKt__LimitKt$dropWhile$1$1) r0.L$0;
        ResultKt.throwOnFailure(r82);
        goto L36
    L55:
        if (r2 != 3) goto L40;
        ResultKt.throwOnFailure(r82);
        goto L48
    L40:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L32:
        r0 = (FlowKt__LimitKt$dropWhile$1$1$emit$1) r8;
        if ((r0.label & int.MIN_VALUE) == 0) goto L30;
        r0.label -= int.MIN_VALUE;
        goto L89
    }
}

