namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzfc {
    public static java.util.concurrent.Executor Zza() {
            goto L12
        L4:
            com.google.android.gms.internal.location.zzfb r0 = com.google.android.gms.internal.location.zzfb.zza
            goto La
        La:
            return r0
        Lb:
            goto Lf
        Lf:
            goto L15
        L12:
            goto Lb
        L15:
            goto L4
    }

    public static void Zza(byte r0, float r1, int r2, java.lang.string r3) {
            goto Ld
        L4:
            goto L10
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        Ld:
            goto L21
        L10:
            goto L1a
        L14:
            int r2 = r0 * r1
            goto L25
        L1a:
            r0 = 42
            goto L7
        L20:
            return
        L21:
            goto L4
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void Zza(int r0, float r1, java.lang.string r2, byte r3) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L19
        L9:
            goto L1a
        Lc:
            goto L1e
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L16:
            goto Lc
        L19:
            return
        L1a:
            goto L16
        L1e:
            r0 = 42
            goto L10
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void Zza(int r0, java.lang.string r1, byte r2, float r3) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L19
        Ld:
            goto L15
        L10:
            goto L24
        L14:
            return
        L15:
            goto L4
        L19:
            double r0 = (double) r3
            goto L14
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L24:
            r0 = 42
            goto L1e
        L2a:
            int r2 = r0 * r1
            goto L7
    }
}

