using Com.Google.Firebase.Crashlytics;
using Kotlin;
using Kotlin.Coroutines;
using Kotlin.Coroutines.Intrinsics;
using Kotlin.Coroutines.Jvm.Internal;
using Kotlin.Jvm.Functions;
using Kotlinx.Coroutines;
using P7a1eabc3.P07214c67.P20f35e63;
using Pad5f82e8.P07214c67.Pfd9160bb;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes3.dex */
readonly class pfef1f419$p089af635$1 : SuspendLambda : Function2<CoroutineScope, Continuation<Unit>, object> {
    readonly /* synthetic */ p4cc9492b.pca87b160 $commodity;
    int f8afcd79f;
    int fd304ba20;
    int fe6e26a8b;
    readonly /* synthetic */ pfef1f419 this$0;

    public /* synthetic */ class p12c674ac {
        public static readonly /* synthetic */ int[] $EnumSwitchDictionaryping$0 = null;

        static {
            if (((28 + 27) % 27) > 0) goto L5;
        L5:
            int[] r0 = new int[hmHohiVLXEnXkBXp().length];
            r0[iNmuxhUfFfcKgTEi(p17096304.f790ba751)] = 1;     // Catch: NoSuchFieldError -> L29
        L38:
            r0[WAMTnMGXbdDwJuzp(p17096304.faf38244a)] = 2;     // Catch: NoSuchFieldError -> L30
        L36:
            r0[VUMCUiFJVyiBSMHM(p17096304.f70474f2d)] = 3;     // Catch: NoSuchFieldError -> L31
        L40:
            r0[CNwcskwQLHhZEJpL(p17096304.f78d79da2)] = 4;     // Catch: NoSuchFieldError -> L32
        L42:
            r0[qFJpSpsEplVzKadN(p17096304.f435df858)] = 5;     // Catch: NoSuchFieldError -> L33
        L19:
            $EnumSwitchDictionaryping$0 = r0;
        }

        public static int CNwcskwQLHhZEJpL(p17096304 r1) {
            return r1.ordinal();
        }

        public static int VUMCUiFJVyiBSMHM(p17096304 r1) {
            return r1.ordinal();
        }

        public static int WAMTnMGXbdDwJuzp(p17096304 r1) {
            return r1.ordinal();
        }

        public static p17096304[] HmHohiVLXEnXkBXp() {
            return p17096304.Values;
        }

        public static int INmuxhUfFfcKgTEi(p17096304 r1) {
            return r1.ordinal();
        }

        public static int QFJpSpsEplVzKadN(p17096304 r1) {
            return r1.ordinal();
        }
    }

    pfef1f419$p089af635$1(pfef1f419 r1, p4cc9492b.pca87b160 r2, Continuation<? super pfef1f419$p089af635$1> r3) {
        this.this$0 = r1;
        this.$commodity = r2;
        super(2, r3);
    }

    public static object AspcQbHTbccDLiMx(pfef1f419 r1, p4cc9492b.pca87b160 r2, Continuation r3) {
        return pfef1f419.m0ee84eff(r1, r2, r3);
    }

    public static p17096304 DDJTbzHQAWSWaasR(pfef1f419 r1) {
        return r1.getStartInventoryRoute();
    }

    public static Continuation DgvIMqaSyMPyyZlr(pfef1f419$p089af635$1 r1, object r2, Continuation r3) {
        return r1.create(r2, r3);
    }

    public static FirebaseCrashlytics EBAhJXRMCYbPxmfD() {
        return FirebaseCrashlytics.getInstance();
    }

    public static void FaIYoZgdHyPqECDf(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static object KqAjOEQlgiAkvtKQ(pfef1f419$p089af635$1 r1, CoroutineScope r2, Continuation r3) {
        return r1.invoke2(r2, r3);
    }

    public static object XZUbnVmBUIuKkIEm() {
        return IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static object FoGvQrXBjJdZHBmP(pfef1f419 r1, p4cc9492b.pca87b160 r2, Continuation r3) {
        return pfef1f419.m2ac5c805(r1, r2, r3);
    }

    public static int IykOmjVRYAVjNvIB(p17096304 r1) {
        return r1.ordinal();
    }

    public static void OFvIBNLuJsVlxgzY(object r0) {
        ResultKt.throwOnFailure(r0);
    }

    public static void OZRccmyumOKuRcQS(FirebaseCrashlytics r0, Exception r1) {
        r0.recordException(r1);
    }

    public static object OoLykWXpoxlNBPQM(pfef1f419$p089af635$1 r1, object r2) {
        return r1.invokeSuspend(r2);
    }

    public static object QSqhYgUipqGQkSaZ(pfef1f419 r1, p4cc9492b.pca87b160 r2, Continuation r3) {
        return pfef1f419.m833c5768(r1, r2, r3);
    }

    public static object XvhuaLcQPysWnNQi(pfef1f419 r1, p4cc9492b.pca87b160 r2, Continuation r3) {
        return pfef1f419.m6ada175b(r1, r2, r3);
    }

    public static void YkvySDynHnYSGQBL(pfef1f419 r0, p4cc9492b.pca87b160 r1) {
        pfef1f419.m3b1d7c7f(r0, r1);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly Continuation<Unit> Create(object r2, Continuation<object> r3) {
        return new pfef1f419$p089af635$1(this.this$0, this.$commodity, r3);
    }

    @Override // kotlin.jvm.functions.Function2
    public /* bridge */ /* synthetic */ object invoke(CoroutineScope r1, Continuation<Unit> r2) {
        return KqAjOEQlgiAkvtKQ(this, r1, r2);
    }

    /* JADX INFO: renamed from: invoke, reason: avoid collision after fix types in other method */
    public readonly object Invoke2(CoroutineScope r1, Continuation<Unit> r2) {
        return ooLykWXpoxlNBPQM((pfef1f419$p089af635$1) DgvIMqaSyMPyyZlr(this, r1, r2), Unit.INSTANCE);
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly object InvokeSuspend(object r7) {
        if (((8 + 20) % 20) > 0) goto L59;
    L59:
        object r0 = XZUbnVmBUIuKkIEm();
        int r1 = this.fd304ba20;
        if (r1 == 0) goto L19;
        if (r1 != 1) goto L80;
    L5:
        FaIYoZgdHyPqECDf(r7);     // Catch: Exception -> L54
    L11:
        return Unit.INSTANCE;
    L80:
        if (r1 == 2) goto L5;
        if (r1 == 3) goto L5;
        if (r1 == 4) goto L5;
        throw new IllegalStateException("call to 'resume' before 'invoke' with coroutine");
    L19:
        oFvIBNLuJsVlxgzY(r7);
        p17096304 r72 = DDJTbzHQAWSWaasR(this.this$0);     // Catch: Exception -> L54
        if (r72 is not null) goto L23;
        int r73 = -1;
    L24:
        if (r73 == 1) goto L44;
        if (r73 == 2) goto L41;
        if (r73 == 3) goto L38;
        if (r73 != 4) goto L29;
        this.fd304ba20 = 3;     // Catch: Exception -> L54
        if (AspcQbHTbccDLiMx(this.this$0, this.$commodity, this) != r0) goto L11;
    L43:
        return r0;
    L29:
        if (r73 != 5) goto L31;
        this.fd304ba20 = 4;     // Catch: Exception -> L54
        if (foGvQrXBjJdZHBmP(this.this$0, this.$commodity, this) != r0) goto L11;
    L31:
        return Unit.INSTANCE;
    L38:
        this.fd304ba20 = 2;     // Catch: Exception -> L54
        if (qSqhYgUipqGQkSaZ(this.this$0, this.$commodity, this) != r0) goto L11;
    L41:
        this.fd304ba20 = 1;     // Catch: Exception -> L54
        if (xvhuaLcQPysWnNQi(this.this$0, this.$commodity, this) != r0) goto L11;
    L44:
        ykvySDynHnYSGQBL(this.this$0, this.$commodity);     // Catch: Exception -> L54
        goto L11
    L23:
        r73 = p12c674ac.$EnumSwitchDictionaryping$0[iykOmjVRYAVjNvIB(r72)];     // Catch: Exception -> L54
    L54:
        e = move-exception;
        oZRccmyumOKuRcQS(EBAhJXRMCYbPxmfD(), e);
        goto L11
    }
}

