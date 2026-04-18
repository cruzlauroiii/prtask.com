namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.mastercard.terminalsdk.internal.l */
/* JADX INFO: loaded from: classes2.dex */
public class C2207l {
    /* JADX INFO: renamed from: a */
    public static int M467a(int r0, int r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            int r0 = r0 % r1
            goto L7
    }

    /* JADX INFO: renamed from: c */
    public static int M468c(int r0, int r1) {
            goto L4
        L4:
            goto L12
        L7:
            goto L1e
        Lb:
            int r0 = r0 + (-1)
            goto L19
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto L7
        L19:
            int r0 = r0 % r1
            goto L11
        L1e:
            int r0 = r0 + r1
            goto Lb
    }

    /* JADX INFO: renamed from: d */
    public static int M469d(int r0, int r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = r0 / r1
            goto L13
        L10:
            goto L7
        L13:
            return r0
        L14:
            goto L10
    }

    /* JADX INFO: renamed from: e */
    public static int M470e(int r0, int r1, int r2) {
            goto L11
        L4:
            goto L14
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = r0 + r1
            goto L7
        L11:
            goto L8
        L14:
            goto L18
        L18:
            int r0 = r0 * r2
            goto Lc
    }
}

