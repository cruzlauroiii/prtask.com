namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes6.dex */
@java.lang.Deprecated
public readonly class CancellationSignal {
    private bool mCancelInProgress;
    private java.lang.object mCancellationSignalObj;
    private bool mIsCanceled;
    private androidx.core.os.CancellationSignal.OnCancelListener mOnCancelListener;

    public interface OnCancelListener {
        void onCancel();
    }

    public CancellationSignal() {
            r0 = this;
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.<init>()
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    private void WaitForCancelFinishedLocked() {
            r1 = this;
            goto L1e
        L4:
            goto L21
        L7:
            bool r0 = r1.mCancelInProgress
            goto Ld
        Ld:
            if (r0 != 0) goto L12
            goto L26
        L12:
            r1.wait()     // Catch: java.lang.InterruptedException -> L21
            goto L25
        L19:
            return
        L1a:
            goto L4
        L1e:
            goto L1a
        L21:
            goto L7
        L25:
            goto L21
        L26:
            goto L19
    }

    public void Cancel() {
            r3 = this;
            goto L91
        L4:
            r0 = 16
            goto L19
        Lb:
            monitor-enter(r3)
            r3.mCancelInProgress = r2     // Catch: java.lang.Exception -> L13
            r3.notifyAll()     // Catch: java.lang.Exception -> L13
            monitor-exit(r3)     // Catch: java.lang.Exception -> L13
            return
        L13:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L13
            goto L98
        L19:
            r1 = 18
            goto L7b
        L20:
            if (r0 <= 0) goto L25
            goto L4b
        L25:
            goto L48
        L29:
            goto L94
        L2c:
            monitor-enter(r3)
            bool r0 = r3.mIsCanceled     // Catch: java.lang.Exception -> L99
            if (r0 == 0) goto L33
            monitor-exit(r3)     // Catch: java.lang.Exception -> L99
            return
        L33:
            r0 = 1
            r3.mIsCanceled = r0     // Catch: java.lang.Exception -> L99
            r3.mCancelInProgress = r0     // Catch: java.lang.Exception -> L99
            androidx.core.os.CancellationSignal$OnCancelListener r0 = r3.mOnCancelListener     // Catch: java.lang.Exception -> L99
            java.lang.object r1 = r3.mCancellationSignalObj     // Catch: java.lang.Exception -> L99
            monitor-exit(r3)     // Catch: java.lang.Exception -> L99
            goto L81
        L41:
            goto L4b
        L44:
            goto L29
        L48:
            goto L77
        L4b:
            goto L2c
        L4f:
            goto L72
        L50:
            goto L86
        L54:
            throw r0
        L55:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L55
            goto L71
        L5b:
            if (r0 != 0) goto L60
            goto L66
        L60:
            r0.onCancel()     // Catch: java.lang.Exception -> L64
            goto L66
        L64:
            r0 = move-exception
            goto L50
        L66:
            if (r1 == 0) goto L72
            android.os.CancellationSignal r1 = (android.os.CancellationSignal) r1     // Catch: java.lang.Exception -> L64
            r1.cancel()     // Catch: java.lang.Exception -> L64
            goto L4f
        L71:
            throw r0
        L72:
            goto Lb
        L76:
            throw r0
        L77:
            goto L41
        L7b:
            int r0 = r0 + r1
            goto L9f
        L81:
            r2 = 0
            goto L5b
        L86:
            monitor-enter(r3)
            r3.mCancelInProgress = r2     // Catch: java.lang.Exception -> L55
            r3.notifyAll()     // Catch: java.lang.Exception -> L55
            monitor-exit(r3)     // Catch: java.lang.Exception -> L55
            goto L54
        L91:
            goto L44
        L94:
            goto L4
        L98:
            throw r0
        L99:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L99
            goto L76
        L9f:
            int r0 = r0 % r1
            goto L20
    }

    public java.lang.object GetCancellationSignalobject() {
            r2 = this;
            goto L4f
        L4:
            goto L52
        L7:
            r0 = 10
            goto L56
        Le:
            int r0 = r0 + r1
            goto L14
        L14:
            int r0 = r0 % r1
            goto L21
        L1a:
            goto L60
        L1d:
            goto L4
        L21:
            if (r0 <= 0) goto L26
            goto L60
        L26:
            goto L5d
        L2a:
            throw r0
        L2b:
            goto L1a
        L2f:
            monitor-enter(r2)
            java.lang.object r0 = r2.mCancellationSignalObj     // Catch: java.lang.Exception -> L49
            if (r0 != 0) goto L45
            android.os.CancellationSignal r0 = new android.os.CancellationSignal     // Catch: java.lang.Exception -> L49
            r0.<init>()     // Catch: java.lang.Exception -> L49
            r2.mCancellationSignalObj = r0     // Catch: java.lang.Exception -> L49
            bool r1 = r2.mIsCanceled     // Catch: java.lang.Exception -> L49
            if (r1 == 0) goto L45
            r1 = r0
            android.os.CancellationSignal r1 = (android.os.CancellationSignal) r1     // Catch: java.lang.Exception -> L49
            r0.cancel()     // Catch: java.lang.Exception -> L49
        L45:
            java.lang.object r0 = r2.mCancellationSignalObj     // Catch: java.lang.Exception -> L49
            monitor-exit(r2)     // Catch: java.lang.Exception -> L49
            return r0
        L49:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L49
            goto L2a
        L4f:
            goto L1d
        L52:
            goto L7
        L56:
            r1 = 23
            goto Le
        L5d:
            goto L2b
        L60:
            goto L2f
    }

    public bool IsCanceled() {
            r1 = this;
            goto Lf
        L4:
            monitor-enter(r1)
            bool r0 = r1.mIsCanceled     // Catch: java.lang.Exception -> L9
            monitor-exit(r1)     // Catch: java.lang.Exception -> L9
            return r0
        L9:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L9
            goto L19
        Lf:
            goto L1a
        L12:
            goto L4
        L16:
            goto L12
        L19:
            throw r0
        L1a:
            goto L16
    }

    public void SetOnCancelListener(androidx.core.os.CancellationSignal.OnCancelListener r2) {
            r1 = this;
            goto L34
        L4:
            return
        L5:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L7
            return
        L7:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L7
            goto L17
        Ld:
            goto L37
        L10:
            r2.onCancel()
            goto L4
        L17:
            throw r2
        L18:
            goto Ld
        L1c:
            monitor-enter(r1)
            r1.waitForCancelFinishedLocked()     // Catch: java.lang.Exception -> L7
            androidx.core.os.CancellationSignal$OnCancelListener r0 = r1.mOnCancelListener     // Catch: java.lang.Exception -> L7
            if (r0 != r2) goto L26
            monitor-exit(r1)     // Catch: java.lang.Exception -> L7
            return
        L26:
            r1.mOnCancelListener = r2     // Catch: java.lang.Exception -> L7
            bool r0 = r1.mIsCanceled     // Catch: java.lang.Exception -> L7
            if (r0 == 0) goto L5
            if (r2 != 0) goto L2f
            goto L5
        L2f:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L7
            goto L10
        L34:
            goto L18
        L37:
            goto L1c
    }

    public void ThrowIfCanceled() {
            r0 = this;
            goto Lb
        L4:
            r0.<init>()
            goto L2e
        Lb:
            goto L2f
        Le:
            goto L17
        L12:
            return
        L13:
            goto L1f
        L17:
            bool r0 = r0.isCanceled()
            goto L25
        L1f:
            androidx.core.os.OperationCanceledException r0 = new androidx.core.os.OperationCanceledException
            goto L4
        L25:
            if (r0 == 0) goto L2a
            goto L13
        L2a:
            goto L12
        L2e:
            throw r0
        L2f:
            goto L33
        L33:
            goto Le
    }
}

