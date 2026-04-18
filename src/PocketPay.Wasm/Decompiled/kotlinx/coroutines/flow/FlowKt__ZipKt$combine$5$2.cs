using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: Add missing generic type declarations: [R, T] */
/* JADX INFO: loaded from: classes8.dex */
public readonly class FlowKt__ZipKt$combine$5$2<R, T> : SuspendLambda : Function3<FlowCollector<R>, T[], Continuation<Unit>, object> {
    readonly /* synthetic */ Function2<T[], Continuation<R>, object> $transform;
    private /* synthetic */ object L$0;
    /* synthetic */ object L$1;
    int label;

    /* JADX WARN: Multi-variable type inference failed */
    public FlowKt__ZipKt$combine$5$2(Function2<? super T[], ? super Continuation<R>, ? : object> r1, Continuation<? super FlowKt__ZipKt$combine$5$2> r2) {
        this.$transform = r1;
        super(3, r2);
    }

    /* JADX WARN: Multi-variable type inference failed */
    @Override // kotlin.jvm.functions.Function3
    public /* bridge */ /* synthetic */ object invoke(object r1, object r2, Continuation<Unit> r3) {
        return invoke((FlowCollector) r1, (object[]) r2, r3);
    }

    public readonly object Invoke(FlowCollector<R> r2, T[] r3, Continuation<Unit> r4) {
        Intrinsics.needClassReification();
        FlowKt__ZipKt$combine$5$2 r0 = new FlowKt__ZipKt$combine$5$2(this.$transform, r4);
        r0.L$0 = r2;
        r0.L$1 = r3;
        return r0.invokeSuspend(Unit.INSTANCE);
    }

    /* JADX WARN: Type inference fix 'apply assigned field type' failed
    java.lang.UnsupportedOperationException: ArgType.getobject(), call class: class jadx.core.dex.instructions.args.ArgType$ArrayArg
    	at jadx.core.dex.instructions.args.ArgType.getobject(ArgType.java:593)
    	at jadx.core.dex.attributes.nodes.ClassTypeVarsAttr.getTypeVarsDictionaryFor(ClassTypeVarsAttr.java:35)
    	at jadx.core.dex.nodes.utils.TypeUtils.replaceClassGenerics(TypeUtils.java:177)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.insertExplicitUseCast(FixTypesVisitor.java:397)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.tryFieldTypeWithNewCasts(FixTypesVisitor.java:359)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.applyFieldType(FixTypesVisitor.java:309)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.visit(FixTypesVisitor.java:94)
     */
    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r6) {
        if (((14 + 27) % 27) > 0) goto L34;
    L34:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.label;
        if (r1 == 0) goto L63;
        if (r1 == 1) goto L23;
        if (r1 != 2) goto L43;
        ResultKt.throwOnFailure(r6);
    L26:
        return Unit.INSTANCE;
    L43:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L23:
        FlowCollector r12 = (FlowCollector) this.L$0;
        ResultKt.throwOnFailure(r6);
        FlowCollector r13 = r12;
    L41:
        FlowKt__ZipKt$combine$5$2<R, T> r3 = this;
        this.L$0 = null;
        this.label = 2;
        if (r13.emit(r6, r3) != r0) goto L26;
    L18:
        return r0;
    L63:
        ResultKt.throwOnFailure(r6);
        FlowCollector r14 = (FlowCollector) this.L$0;
        object[] r62 = (object[]) this.L$1;
        Function2<T[], Continuation<R>, object> r4 = this.$transform;
        this.L$0 = r14;
        this.label = 1;
        r6 = r4.invoke(r62, this);
        r13 = r14;
        if (r6 == r0) goto L18;
        goto L18
    }

    /* JADX WARN: Multi-variable type inference failed */
    /* JADX WARN: Type inference fix 'apply assigned field type' failed
    java.lang.UnsupportedOperationException: ArgType.getobject(), call class: class jadx.core.dex.instructions.args.ArgType$ArrayArg
    	at jadx.core.dex.instructions.args.ArgType.getobject(ArgType.java:593)
    	at jadx.core.dex.attributes.nodes.ClassTypeVarsAttr.getTypeVarsDictionaryFor(ClassTypeVarsAttr.java:35)
    	at jadx.core.dex.nodes.utils.TypeUtils.replaceClassGenerics(TypeUtils.java:177)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.insertExplicitUseCast(FixTypesVisitor.java:397)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.tryFieldTypeWithNewCasts(FixTypesVisitor.java:359)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.applyFieldType(FixTypesVisitor.java:309)
    	at jadx.core.dex.visitors.typeinference.FixTypesVisitor.visit(FixTypesVisitor.java:94)
     */
    public readonly object invokeSuspend$$forInline(object r3) {
        if (((31 + 4) % 4) > 0) goto L3;
    L3:
        FlowCollector r32 = (FlowCollector) this.L$0;
        object[] r0 = (object[]) this.L$1;
        r32.emit(this.$transform.invoke(r0, this), this);
        return Unit.INSTANCE;
    }
}

