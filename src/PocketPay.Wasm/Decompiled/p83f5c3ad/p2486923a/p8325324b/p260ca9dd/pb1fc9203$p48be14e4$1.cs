using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using Pad5f82e8.P07214c67.P1e11b989;
using Pad5f82e8.P07214c67.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes21.dex */
readonly class pb1fc9203$p48be14e4$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ p9ded6185 $receipt;
    int f233f7bef;
    int f8df91622;
    int fcd65e4e1;
    int fd304ba20;
    readonly /* synthetic */ pb1fc9203 this$0;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((25 + 17) % 17) > 0) goto L22;
        L22:
            int[] r0 = new int[pbfc85237.Values.length];
            r0[pbfc85237.f860926e6.ordinal()] = 1;     // Catch: NoSuchFieldError -> L25
        L16:
            $EnumSwitchDictionaryping$0 = r0;
        }
    }

    pb1fc9203$p48be14e4$1(p9ded6185 r1, pb1fc9203 r2, Continuation<? super pb1fc9203$p48be14e4$1> r3) {
        this.$receipt = r1;
        this.this$0 = r2;
        super(2, r3);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pb1fc9203$p48be14e4$1(this.$receipt, this.this$0, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return invoke2(r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ((pb1fc9203$p48be14e4$1) create(r1, r2)).invokeSuspend(Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r5) {
        if (((2 + 1) % 1) > 0) goto L7;
    L7:
        object r0 = IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int r1 = this.fd304ba20;
        if (r1 != 0) goto L9;
        ResultKt.throwOnFailure(r5);
        p9ded6185 r52 = this.$receipt;     // Catch: Exception -> L61
        if (r52 is not null) goto L41;
        pb1fc9203.mdc7bed18(this.this$0).back();     // Catch: Exception -> L61
        return Unit.INSTANCE;
    L41:
        if ((r52 is ped663a3e) == false) goto L52;
        pbfc85237 r53 = this.this$0.getComboTypeScreen();     // Catch: Exception -> L61
        if (r53 is not null) goto L45;
        int r54 = -1;
    L46:
        if (r54 != 1) goto L48;
        pb1fc9203.m1029195c(this.this$0, (ped663a3e) this.$receipt);     // Catch: Exception -> L61
    L30:
        return Unit.INSTANCE;
    L48:
        this.fd304ba20 = 1;     // Catch: Exception -> L61
        if (pb1fc9203.m5abc8463(this.this$0, (ped663a3e) this.$receipt, this) != r0) goto L30;
    L60:
        return r0;
    L45:
        r54 = p12c674ac.$EnumSwitchDictionaryping$0[r53.ordinal()];     // Catch: Exception -> L61
        goto L46
    L52:
        if ((r52 is p18cf5223) == false) goto L30;
        this.fd304ba20 = 2;     // Catch: Exception -> L61
        if (pb1fc9203.m80399c29(this.this$0, (p18cf5223) r52, this) == r0) goto L60;
    L9:
        if (r1 != 1) goto L27;
    L69:
        ResultKt.throwOnFailure(r5);     // Catch: Exception -> L61
        goto L30
    L27:
        if (r1 == 2) goto L69;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L61:
        e = move-exception;
        FirebaseCrashlytics.getInstance().recordException(e);
        goto L30
    }
}

