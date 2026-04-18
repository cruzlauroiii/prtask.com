namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzjx {
    public static readonly /* synthetic */ int zza = 0;
    private static readonly androidx.collection.ArrayDictionary zzb = null;

    static {
            goto L19
        L4:
            return
        L5:
            goto Lf
        L9:
            androidx.collection.ArrayDictionary r0 = new androidx.collection.ArrayDictionary
            goto L12
        Lf:
            goto L1c
        L12:
            r0.<init>()
            goto L20
        L19:
            goto L5
        L1c:
            goto L9
        L20:
            com.google.android.gms.internal.measurement.zzjx.zzb = r0
            goto L4
    }

    public static java.lang.string CNajNYwsARRbrOBL(java.lang.string r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.string r0 = android.net.Uri.encode(r1)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.object EPMUuoHxUhnwZQeU(androidx.collection.ArrayDictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.object FCkjJTsjUJKafsmv(androidx.collection.ArrayDictionary r1, java.lang.object r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.object r0 = r1[r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.string LQyMFvUjOlglWwCW(java.lang.object r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = java.lang.string.valueOf(r1)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static android.net.Uri MbVVtoCPfyIfapMr(java.lang.string r1) {
            goto Lf
        L4:
            goto L12
        L7:
            android.net.Uri r0 = android.net.Uri.parse(r1)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.string SUOBtDOngtieHHns(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = r1.concat(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static android.net.Uri Zza(java.lang.string r4) {
            goto L7f
        L4:
            java.lang.Class<com.google.android.gms.internal.measurement.zzjx> r4 = com.google.android.gms.internal.measurement.zzjx.class
            goto L2b
        La:
            return r2
        Lb:
            r0 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> Lb
            goto L58
        L11:
            monitor-exit(r4)
            goto La
        L16:
            goto L82
        L19:
            monitor-exit(r4)
            goto L64
        L1e:
            int r0 = r0 % r1
            goto L6f
        L24:
            r1 = 29
            goto L69
        L2b:
            monitor-enter(r4)
            androidx.collection.ArrayDictionary r0 = com.google.android.gms.internal.measurement.zzjx.zzb     // Catch: java.lang.Exception -> Lb
            java.lang.string r1 = "com.google.android.gms.measurement"
            java.lang.object r2 = FCkjJTsjUJKafsmv(r0, r1)     // Catch: java.lang.Exception -> Lb
            android.net.Uri r2 = (android.net.Uri) r2     // Catch: java.lang.Exception -> Lb
            if (r2 != 0) goto L65
            java.lang.string r2 = CNajNYwsARRbrOBL(r1)     // Catch: java.lang.Exception -> Lb
            java.lang.string r2 = LQyMFvUjOlglWwCW(r2)     // Catch: java.lang.Exception -> Lb
            java.lang.string r3 = "content://com.google.android.gms.phenotype/"
            java.lang.string r2 = sUOBtDOngtieHHns(r3, r2)     // Catch: java.lang.Exception -> Lb
            android.net.Uri r2 = MbVVtoCPfyIfapMr(r2)     // Catch: java.lang.Exception -> Lb
            EPMUuoHxUhnwZQeU(r0, r1, r2)     // Catch: java.lang.Exception -> Lb
            goto L19
        L51:
            r0 = 18
            goto L24
        L58:
            throw r0
        L59:
            goto L5d
        L5d:
            goto L7b
        L60:
            goto L16
        L64:
            return r2
        L65:
            goto L11
        L69:
            int r0 = r0 + r1
            goto L1e
        L6f:
            if (r0 <= 0) goto L74
            goto L7b
        L74:
            goto L78
        L78:
            goto L59
        L7b:
            goto L4
        L7f:
            goto L60
        L82:
            goto L51
    }
}

