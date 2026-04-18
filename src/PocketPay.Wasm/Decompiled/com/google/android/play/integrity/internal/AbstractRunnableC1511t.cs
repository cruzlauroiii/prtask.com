namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.android.play.integrity.internal.t */
/* JADX INFO: loaded from: classes26.dex */
public abstract class AbstractActionC1511t : java.lang.Action {

    /* JADX INFO: renamed from: a */
    private readonly com.google.android.gms.tasks.TaskCompletionSource f307a;

    AbstractActionC1511t() {
            r1 = this;
            goto Ld
        L4:
            goto L10
        L7:
            r1.f307a = r0
            goto L20
        Ld:
            goto L21
        L10:
            goto L14
        L14:
            r1.<init>()
            goto L1b
        L1b:
            r0 = 0
            goto L7
        L20:
            return
        L21:
            goto L4
    }

    public AbstractActionC1511t(com.google.android.gms.tasks.TaskCompletionSource r1) {
            r0 = this;
            goto L12
        L4:
            return
        L5:
            goto L9
        L9:
            goto L15
        Lc:
            r0.f307a = r1
            goto L4
        L12:
            goto L5
        L15:
            goto L19
        L19:
            r0.<init>()
            goto Lc
    }

    public static void GycwDaOdMbtWdtqZ(com.google.android.play.integrity.internal.AbstractActionC1511t r0, java.lang.Exception r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.mo204a(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void GgTsFFdfCTnWYdwB(com.google.android.play.integrity.internal.AbstractActionC1511t r0) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.mo205b()
            goto L7
    }

    public static bool HByslTJoWmorJrzh(com.google.android.gms.tasks.TaskCompletionSource r1, java.lang.Exception r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.tryHashSetException(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    /* JADX INFO: renamed from: a */
    public void Mo204a(java.lang.Exception r1) {
            r0 = this;
            goto L1a
        L4:
            if (r0 != 0) goto L9
            goto L16
        L9:
            goto L13
        Ld:
            com.google.android.gms.tasks.TaskCompletionSource r0 = r0.f307a
            goto L4
        L13:
            hByslTJoWmorJrzh(r0, r1)
        L16:
            goto L21
        L1a:
            goto L22
        L1d:
            goto Ld
        L21:
            return
        L22:
            goto L26
        L26:
            goto L1d
    }

    /* JADX INFO: renamed from: b */
    protected abstract void Mo205b();

    /* JADX INFO: renamed from: c */
    readonly com.google.android.gms.tasks.TaskCompletionSource m331c() {
            r0 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            com.google.android.gms.tasks.TaskCompletionSource r0 = r0.f307a
            goto L11
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto L7
    }

    @Override // java.lang.Action
    public readonly void Run() {
            r1 = this;
            goto L4
        L4:
            goto L1f
        L7:
            ggTsFFdfCTnWYdwB(r1)     // Catch: java.lang.Exception -> L12
            goto L11
        Le:
            goto L7
        L11:
            return
        L12:
            r0 = move-exception
            goto L17
        L17:
            GycwDaOdMbtWdtqZ(r1, r0)
            goto L1e
        L1e:
            return
        L1f:
            goto Le
    }
}

