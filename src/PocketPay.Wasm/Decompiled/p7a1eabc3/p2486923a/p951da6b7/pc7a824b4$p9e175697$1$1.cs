using Androidx.Lifecycle;
using Com.Google.Firebase.Crashlytics;
using Domain.Entities;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlin.Jvm.Internal;
using P7a1eabc3.P07214c67.P20f35e63;
using P7a1eabc3.Pac143fb7;
using Pad5f82e8.P07214c67;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes3.dex */
readonly class pc7a824b4$p9e175697$1$1 : SuspendLambda : Function2<LiveDataScope<Event<? : p4cc9492b.pca87b160>>, Continuation<Unit>, object> {
    readonly /* synthetic */ string $id;
    private /* synthetic */ object L$0;
    int f27c7dbf6;
    int f77c54489;
    int f9dbe3af7;
    int fd304ba20;
    readonly /* synthetic */ pc7a824b4 this$0;

    pc7a824b4$p9e175697$1$1(pc7a824b4 r1, string r2, Continuation<? super pc7a824b4$p9e175697$1$1> r3) {
        this.this$0 = r1;
        this.$id = r2;
        super(2, r3);
    }

    public static object ENeiYNQxsSQAyGZg(pc7a824b4$p9e175697$1$1 r1, LiveDataScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static p6d73504b GwTdZYlAvfNCTzEX(pc7a824b4 r1) {
        return pc7a824b4.m0234406d(r1);
    }

    public static void HuOMKTxLqSCZWVSn(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object IberNXOegciPzFpo() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static Continuation IoaQqJoHlobpvHeX(pc7a824b4$p9e175697$1$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static void IvwgSwLDAGHDGyQi(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static object JSUVbmXirGokhWNN(p6d73504b r1, string r2, Continuation r3) {
        return r1.getInventory(r2, r3);
    }

    public static void KnzSHTTgbEJuIqyE(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static FirebaseCrashlytics LfiIrxvpqDaAmeID() {
        return FirebaseCrashlytics.getInstance();
    }

    public static pa4ecfc70 MJzUktPUjnaYOsup(pa4ecfc70.p910eef8c r1, object r2) {
        return r1.success(r2);
    }

    public static object MPkifObjqGimNjnm(LiveDataScope r1, object r2, Continuation r3) {
        return r1.emit(r2, r3);
    }

    public static object SeBpilGQGUCFkKjT(pc7a824b4$p9e175697$1$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static object SnzQvRzWbAaqscls(LiveDataScope r1, object r2, Continuation r3) {
        return r1.emit(r2, r3);
    }

    public static void YdCmsOecUSliKuco(object r0) {
        Intrinsics.checkNotNull(r0);
    }

    public static pa4ecfc70 IqpkdwXbQhfYfTUf(pa4ecfc70.p910eef8c r1, Exception r2) {
        return r1.error(r2);
    }

    public static object JcdZQExdrSfwarip(LiveDataScope r1, object r2, Continuation r3) {
        return r1.emit(r2, r3);
    }

    public static void KfLEVSocQkjimUSX(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static pa4ecfc70 TbQRidQSdRTHeHQW(pa4ecfc70.p910eef8c r1) {
        return r1.loading();
    }

    public static void VndJLbxpEdTvploT(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void YfQaHKtitNTqBYHn(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r3, Continuation<object> r4) {
        if (((25 + 7) % 7) > 0) goto L13;
    L13:
        pc7a824b4$p9e175697$1$1 r0 = new pc7a824b4$p9e175697$1$1(this.this$0, this.$id, r4);
        r0.L$0 = r3;
        return r0;
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(LiveDataScope<Event<p4cc9492b.pca87b160>> r1, Continuation<Unit> r2) {
        return SeBpilGQGUCFkKjT((pc7a824b4$p9e175697$1$1) IoaQqJoHlobpvHeX(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(LiveDataScope<Event<? : p4cc9492b.pca87b160>> r1, Continuation<Unit> r2) {
        return ENeiYNQxsSQAyGZg(this, r1, r2);
    }

    /* JADX WARN: Type inference failed for: r1v1, types: [androidx.lifecycle.LiveDataScope, int] */
    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r8) {
        if (((21 + 17) % 17) > 0) goto L8;
    L8:
        object r0 = IberNXOegciPzFpo();
        ?? r1 = this.fd304ba20;
        if (r1 == 0) goto L61;
        if (r1 == 1) goto L59;
        if (r1 == 2) goto L62;
        if (r1 == 3) goto L12;
        if (r1 == 4) goto L107;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L107:
        Exception r7 = (Exception) this.L$0;
        HuOMKTxLqSCZWVSn(r8);
    L41:
        IvwgSwLDAGHDGyQi(LfiIrxvpqDaAmeID(), r7);
    L105:
        return Unit.INSTANCE;
    L12:
        LiveDataScope r12 = (LiveDataScope) this.L$0;
        yfQaHKtitNTqBYHn(r8);     // Catch: Exception -> L25
        goto L105
    L62:
        LiveDataScope r13 = (LiveDataScope) this.L$0;
        KnzSHTTgbEJuIqyE(r8);     // Catch: Exception -> L25
    L93:
        pa4ecfc70.p910eef8c r4 = pa4ecfc70.f910eef8c;     // Catch: Exception -> L25
        this.L$0 = r13;     // Catch: Exception -> L25
        this.fd304ba20 = 3;     // Catch: Exception -> L25
        if (SnzQvRzWbAaqscls(r13, MJzUktPUjnaYOsup(r4, (p4cc9492b.pca87b160) r8), this) != r0) goto L105;
    L50:
        return r0;
    L59:
        r13 = (LiveDataScope) this.L$0;
        kfLEVSocQkjimUSX(r8);
    L90:
        p6d73504b r82 = GwTdZYlAvfNCTzEX(this.this$0);     // Catch: Exception -> L25
        string r5 = this.$id;     // Catch: Exception -> L25
        YdCmsOecUSliKuco(r5);     // Catch: Exception -> L25
        this.L$0 = r13;     // Catch: Exception -> L25
        this.fd304ba20 = 2;     // Catch: Exception -> L25
        r8 = JSUVbmXirGokhWNN(r82, r5, this);     // Catch: Exception -> L25
        if (r8 != r0) goto L93;
    L61:
        vndJLbxpEdTvploT(r8);
        LiveDataScope r83 = (LiveDataScope) this.L$0;
        pa4ecfc70 r14 = tbQRidQSdRTHeHQW(pa4ecfc70.f910eef8c);
        pc7a824b4$p9e175697$1$1 r6 = this;
        this.L$0 = r83;
        this.fd304ba20 = 1;
        if (jcdZQExdrSfwarip(r83, r14, r6) == r0) goto L50;
        r13 = r83;
    L25:
        e = move-exception;
        pa4ecfc70 r3 = iqpkdwXbQhfYfTUf(pa4ecfc70.f910eef8c, e);
        pc7a824b4$p9e175697$1$1 r42 = this;
        this.L$0 = e;
        this.fd304ba20 = 4;
        if (MPkifObjqGimNjnm(r1, r3, r42) == r0) goto L50;
        r7 = e;
        goto L41
    }
}

