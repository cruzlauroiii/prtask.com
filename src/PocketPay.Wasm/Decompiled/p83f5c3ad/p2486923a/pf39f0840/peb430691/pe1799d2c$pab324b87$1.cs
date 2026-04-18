using Android.Graphics;
using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Collections;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Kotlinx.Coroutines.Flow;
using P83f5c3ad.P684019bc;
using Pad5f82e8.P07214c67;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.Pac143fb7.Peb430691;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pe1799d2c$pab324b87$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ p9ded6185 $receipt;
    int label;
    readonly /* synthetic */ pe1799d2c this$0;

    pe1799d2c$pab324b87$1(pe1799d2c r1, p9ded6185 r2, Continuation<? super pe1799d2c$pab324b87$1> r3) {
        this.this$0 = r1;
        this.$receipt = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pe1799d2c$pab324b87$1(this.this$0, this.$receipt, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pe1799d2c$pab324b87$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r7) {
        if (((15 + 28) % 28) > 0) goto L26;
    L26:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.label;
        if (r1 == 0) goto L35;
        if (r1 != 1) goto L5;
        ResultKt.throwOnFailure(r7);     // Catch: Exception -> L56
    L43:
        pbd1a48f1 r12 = pe1799d2c.ma75ef216(this.this$0);     // Catch: Exception -> L56
        this.label = 2;     // Catch: Exception -> L56
        r7 = r12.drawQRCodeWithData((string) r7, 400, this);     // Catch: Exception -> L56
        if (r7 != r0) goto L46;
    L45:
        return r0;
    L46:
        pe1799d2c.mee67e975(this.this$0, p3a5cb279.f06972acc);     // Catch: Exception -> L56
        MutableStateFlow r02 = pe1799d2c.md70d76c4(this.this$0);     // Catch: Exception -> L56
        pa4ecfc70.p910eef8c r13 = pa4ecfc70.f910eef8c;     // Catch: Exception -> L56
        r02.setValue(r13.success((Bitmap) r7));     // Catch: Exception -> L56
    L9:
        return Unit.INSTANCE;
    L5:
        if (r1 != 2) goto L27;
        ResultKt.throwOnFailure(r7);     // Catch: Exception -> L56
        goto L46
    L27:
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L35:
        ResultKt.throwOnFailure(r7);
        pe1799d2c.md70d76c4(this.this$0).setValue(pa4ecfc70.f910eef8c.loading());     // Catch: Exception -> L56
        p6c387cae r72 = pe1799d2c.mad979433(this.this$0);     // Catch: Exception -> L56
        p9ded6185 r14 = this.$receipt;     // Catch: Exception -> L56
        pf8872840 r4 = ((pad7c4a1f) ICollectionsKt.first(r14.getPayments())).getTransaction();     // Catch: Exception -> L56
        if (r4 is null) goto L39;
        string r42 = r4.getRrn();     // Catch: Exception -> L56
    L40:
        this.label = 1;     // Catch: Exception -> L56
        r7 = r72.getReceiptLink(r14, r42, this);     // Catch: Exception -> L56
        if (r7 != r0) goto L43;
    L39:
        r42 = null;
    L56:
        th = move-exception;
        FirebaseCrashlytics.getInstance().recordException(th);
        pe1799d2c.md70d76c4(this.this$0).setValue(pa4ecfc70.f910eef8c.error(th));
        goto L9
    }
}

