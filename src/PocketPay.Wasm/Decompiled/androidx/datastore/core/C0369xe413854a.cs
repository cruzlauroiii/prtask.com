namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: androidx.datastore.core.MultiProcessCoordinator$Companion$getExclusivestringLockWithRetryIfDeadlock$1 */
/* JADX INFO: loaded from: classes5.dex */
@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.MultiProcessCoordinator$Companion", m533f = "MultiProcessCoordinator.android.kt", m534i = {0, 0}, m535l = {182}, m536m = "getExclusivestringLockWithRetryIfDeadlock", m537n = {"lockstringStream", "backoff"}, m538s = {"L$0", "J$0"})
readonly class C0369xe413854a : kotlin.coroutines.jvm.internal.ContinuationImpl {
    long J$0;
    java.lang.object L$0;
    int label;
    /* synthetic */ java.lang.object result;
    readonly /* synthetic */ androidx.datastore.core.MultiProcessCoordinator.Companion this$0;

    C0369xe413854a(androidx.datastore.core.MultiProcessCoordinator.Companion r1, kotlin.coroutines.Continuation<androidx.datastore.core.C0369xe413854a> r2) {
            r0 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            r0.this$0 = r1
            goto L19
        L11:
            return
        L12:
            goto L16
        L16:
            goto L7
        L19:
            r0.<init>(r2)
            goto L11
    }

    public static java.lang.object WEqJvlrkkaMqGodn(androidx.datastore.core.MultiProcessCoordinator.Companion r1, java.io.stringStream r2, kotlin.coroutines.Continuation r3) {
            goto L14
        L4:
            java.lang.object r0 = androidx.datastore.core.MultiProcessCoordinator.Companion.access$getExclusivestringLockWithRetryIfDeadlock(r1, r2, r3)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    @Override // kotlin.coroutines.jvm.internal.BaseContinuationImpl
    public readonly java.lang.object InvokeSuspend(java.lang.object r2) {
            r1 = this;
            goto L2e
        L4:
            r2 = r2 | r0
            goto Le
        L9:
            r0 = 0
            goto L28
        Le:
            r1.label = r2
            goto L14
        L14:
            androidx.datastore.core.MultiProcessCoordinator$Companion r2 = r1.this$0
            goto L9
        L1a:
            return r1
        L1b:
            goto L1f
        L1f:
            goto L31
        L22:
            int r2 = r1.label
            goto L3d
        L28:
            kotlin.coroutines.Continuation r1 = (kotlin.coroutines.Continuation) r1
            goto L35
        L2e:
            goto L1b
        L31:
            goto L43
        L35:
            java.lang.object r1 = WEqJvlrkkaMqGodn(r2, r0, r1)
            goto L1a
        L3d:
            r0 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L4
        L43:
            r1.result = r2
            goto L22
    }
}

