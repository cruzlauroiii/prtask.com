namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes26.dex */
public abstract class zzl {
    protected readonly com.google.android.play.core.appupdate.internal.zzm zza;
    protected readonly java.util.HashSet zzb;
    private readonly android.content.objectFilter zzc;
    private readonly android.content.object zzd;
    private com.google.android.play.core.appupdate.internal.zzk zze;
    private bool zzf;

    protected zzl(com.google.android.play.core.appupdate.internal.zzm r2, android.content.objectFilter r3, android.content.object r4) {
            r1 = this;
            goto L39
        L4:
            r1.zzc = r3
            goto La
        La:
            android.content.object r2 = dREWfTBEfzmqIwvO(r4)
            goto L40
        L12:
            goto L3c
        L15:
            r1.zzf = r0
            goto L52
        L1b:
            r1.zze = r0
            goto L58
        L21:
            r1.zzb = r0
            goto L27
        L27:
            r0 = 0
            goto L1b
        L2c:
            r1.<init>()
            goto L33
        L33:
            java.util.HashHashSet r0 = new java.util.HashHashSet
            goto L4b
        L39:
            goto L47
        L3c:
            goto L2c
        L40:
            r1.zzd = r2
            goto L46
        L46:
            return
        L47:
            goto L12
        L4b:
            r0.<init>()
            goto L21
        L52:
            r1.zza = r2
            goto L4
        L58:
            r0 = 0
            goto L15
    }

    public static bool DNcyECtxwbZnLnYD(java.util.HashSet r1, java.lang.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.Remove(r2)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static void FMcnosLiXztsDNwU(com.google.android.play.core.appupdate.internal.zzl r0) {
            goto Le
        L4:
            goto L11
        L7:
            r0.zze()
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static android.content.object KZYZSGjuXgHFAwJx(android.content.object r1, android.content.BroadcastReceiver r2, android.content.objectFilter r3, int r4) {
            goto L14
        L4:
            android.content.object r0 = r1.registerReceiver(r2, r3, r4)
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void KbJjIlcpuUNCruLQ(com.google.android.play.core.listener.StateUpdatedListener r0, java.lang.object r1) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            r0.onStateUpdate(r1)
            goto L4
    }

    public static bool KsvNkiKIUcRcXBpZ(java.util.HashSet r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.Count == 0
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void TsiSvgrHPDMopMcc(com.google.android.play.core.appupdate.internal.zzl r0) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.zze()
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static android.content.object YNFxmmnqKQBzBPwR(android.content.object r1, android.content.BroadcastReceiver r2, android.content.objectFilter r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            android.content.object r0 = r1.registerReceiver(r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.util.IEnumerator ZMJeRAMmbwqiSlxb(java.util.HashHashSet r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
        L18:
            goto Lc
    }

    public static bool ZjaRtHWoLmzvHXZn(java.util.IEnumerator r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            bool r0 = r1.MoveNext()
            goto L4
    }

    public static android.content.object DREWfTBEfzmqIwvO(android.content.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            android.content.object r0 = com.google.android.play.core.appupdate.internal.zzz.zza(r1)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static java.lang.object FRgOiESFAfsuUXwJ(java.lang.object r1, java.lang.object r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.object r0 = com.google.android.play.core.appupdate.internal.zzac.zza(r1, r2)
            goto L4
    }

    public static bool FWCRuGmWZHdVrzIK(java.util.HashSet r1) {
            goto Lc
        L4:
            bool r0 = r1.Count == 0
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static int GEdUsMTKypLlQFSM(com.google.android.play.core.appupdate.internal.zzm r1, java.lang.string r2, java.lang.object[] r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = r1.zzd(r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.object GhyZLDxoPcqBZUTe(java.lang.object r1, java.lang.object r2) {
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
            java.lang.object r0 = com.google.android.play.core.appupdate.internal.zzac.zza(r1, r2)
            goto L7
    }

    public static bool KJZteCIKbxrrnBtm(java.util.HashSet r1, java.lang.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = r1.Add(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.object NNoDqtGSHXfJshdO(java.util.IEnumerator r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.object r0 = r1.Current
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void ZWYUCsLRRlGgwDGk(android.content.object r0, android.content.BroadcastReceiver r1) {
            goto L10
        L4:
            r0.unregisterReceiver(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static int ZwfXrUtyjnFYxPlh(com.google.android.play.core.appupdate.internal.zzm r1, java.lang.string r2, java.lang.object[] r3) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = r1.zzd(r2, r3)
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

    private readonly void Zze() {
            r5 = this;
            goto L8a
        L4:
            r1 = 22
            goto L44
        Lb:
            r2 = 33
            goto Ld3
        L11:
            if (r0 == 0) goto L16
            goto L40
        L16:
            goto Lcd
        L1a:
            bool r0 = fWCRuGmWZHdVrzIK(r0)
            goto L2f
        L22:
            android.content.objectFilter r3 = r5.zzc
            goto L3d
        L28:
            KZYZSGjuXgHFAwJx(r0, r2, r3, r4)
            goto Lc2
        L2f:
            if (r0 != 0) goto L34
            goto La8
        L34:
            goto Le3
        L38:
            r4 = 2
            goto L28
        L3d:
            YNFxmmnqKQBzBPwR(r0, r2, r3)
        L40:
            goto L64
        L44:
            int r0 = r0 + r1
            goto Lac
        L4a:
            r0.<init>(r5, r1)
            goto L5e
        L51:
            java.util.HashSet r0 = r5.zzb
            goto L82
        L57:
            zWYUCsLRRlGgwDGk(r2, r0)
            goto La6
        L5e:
            r5.zze = r0
            goto L6a
        L64:
            java.util.HashSet r0 = r5.zzb
            goto L1a
        L6a:
            int r0 = android.os.Build.VERSION.SDK_INT
            goto Lb
        L70:
            com.google.android.play.core.appupdate.internal.zzk r0 = new com.google.android.play.core.appupdate.internal.zzk
            goto L4a
        L76:
            android.content.object r0 = r5.zzd
            goto L7c
        L7c:
            com.google.android.play.core.appupdate.internal.zzk r2 = r5.zze
            goto Lef
        L82:
            bool r0 = KsvNkiKIUcRcXBpZ(r0)
            goto L91
        L8a:
            goto Lbe
        L8d:
            goto Ldc
        L91:
            r1 = 0
            goto L11
        L96:
            android.content.object r0 = r5.zzd
            goto Le9
        L9c:
            goto Lc9
        L9f:
            goto L51
        La3:
            goto L8d
        La6:
            r5.zze = r1
        La8:
            goto Lc8
        Lac:
            int r0 = r0 % r1
            goto Lf5
        Lb2:
            if (r0 == 0) goto Lb7
            goto L40
        Lb7:
            goto L70
        Lbb:
            goto L9f
        Lbe:
            goto La3
        Lc2:
            goto L40
        Lc4:
            goto L96
        Lc8:
            return
        Lc9:
            goto Lbb
        Lcd:
            com.google.android.play.core.appupdate.internal.zzk r0 = r5.zze
            goto Lb2
        Ld3:
            if (r0 >= r2) goto Ld8
            goto Lc4
        Ld8:
            goto L76
        Ldc:
            r0 = 4
            goto L4
        Le3:
            com.google.android.play.core.appupdate.internal.zzk r0 = r5.zze
            goto L104
        Le9:
            com.google.android.play.core.appupdate.internal.zzk r2 = r5.zze
            goto L22
        Lef:
            android.content.objectFilter r3 = r5.zzc
            goto L38
        Lf5:
            if (r0 <= 0) goto Lfa
            goto L9f
        Lfa:
            goto L9c
        Lfe:
            android.content.object r2 = r5.zzd
            goto L57
        L104:
            if (r0 != 0) goto L109
            goto La8
        L109:
            goto Lfe
    }

    protected abstract void Zza(android.content.object r1, android.content.object r2);

    public readonly void Zzb(com.google.android.play.core.listener.StateUpdatedListener r4) {
            r3 = this;
            goto Lb
        L4:
            goto L40
        L7:
            goto L33
        Lb:
            goto L7
        Le:
            goto L65
        L12:
            throw r4
        L13:
            goto L4
        L17:
            if (r0 <= 0) goto L1c
            goto L40
        L1c:
            goto L3d
        L20:
            int r0 = r0 % r1
            goto L17
        L26:
            int r0 = r0 + r1
            goto L20
        L2c:
            r1 = 15
            goto L26
        L33:
            goto Le
        L36:
            return
        L37:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L37
            goto L12
        L3d:
            goto L13
        L40:
            goto L49
        L44:
            monitor-exit(r3)
            goto L36
        L49:
            monitor-enter(r3)
            com.google.android.play.core.appupdate.internal.zzm r0 = r3.zza     // Catch: java.lang.Exception -> L37
            java.lang.string r1 = "registerListener"
            r2 = 0
            java.lang.object[] r2 = new java.lang.object[r2]     // Catch: java.lang.Exception -> L37
            zwfXrUtyjnFYxPlh(r0, r1, r2)     // Catch: java.lang.Exception -> L37
            java.lang.string r0 = "Registered Play Core listener should not be null."
            fRgOiESFAfsuUXwJ(r4, r0)     // Catch: java.lang.Exception -> L37
            java.util.HashSet r0 = r3.zzb     // Catch: java.lang.Exception -> L37
            kJZteCIKbxrrnBtm(r0, r4)     // Catch: java.lang.Exception -> L37
            FMcnosLiXztsDNwU(r3)     // Catch: java.lang.Exception -> L37
            goto L44
        L65:
            r0 = 7
            goto L2c
    }

    public readonly void Zzc(com.google.android.play.core.listener.StateUpdatedListener r4) {
            r3 = this;
            goto L65
        L4:
            goto L24
        L7:
            goto L2f
        Lb:
            int r0 = r0 + r1
            goto L11
        L11:
            int r0 = r0 % r1
            goto L4b
        L17:
            r1 = 30
            goto Lb
        L1e:
            monitor-exit(r3)
            goto L28
        L23:
            throw r4
        L24:
            goto L54
        L28:
            return
        L29:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L29
            goto L23
        L2f:
            monitor-enter(r3)
            com.google.android.play.core.appupdate.internal.zzm r0 = r3.zza     // Catch: java.lang.Exception -> L29
            java.lang.string r1 = "unregisterListener"
            r2 = 0
            java.lang.object[] r2 = new java.lang.object[r2]     // Catch: java.lang.Exception -> L29
            gEdUsMTKypLlQFSM(r0, r1, r2)     // Catch: java.lang.Exception -> L29
            java.lang.string r0 = "Unregistered Play Core listener should not be null."
            ghyZLDxoPcqBZUTe(r4, r0)     // Catch: java.lang.Exception -> L29
            java.util.HashSet r0 = r3.zzb     // Catch: java.lang.Exception -> L29
            DNcyECtxwbZnLnYD(r0, r4)     // Catch: java.lang.Exception -> L29
            TsiSvgrHPDMopMcc(r3)     // Catch: java.lang.Exception -> L29
            goto L1e
        L4b:
            if (r0 <= 0) goto L50
            goto L7
        L50:
            goto L4
        L54:
            goto L7
        L57:
            goto L5b
        L5b:
            goto L68
        L5e:
            r0 = 11
            goto L17
        L65:
            goto L57
        L68:
            goto L5e
    }

    public readonly void Zzd(java.lang.object r3) {
            r2 = this;
            goto L52
        L4:
            throw r3
        L5:
            goto L59
        L9:
            if (r0 <= 0) goto Le
            goto L1c
        Le:
            goto L19
        L12:
            r0 = 22
            goto L60
        L19:
            goto L5
        L1c:
            goto L2d
        L20:
            goto L55
        L23:
            goto L39
        L24:
            goto L28
        L28:
            monitor-exit(r2)
            goto L67
        L2d:
            monitor-enter(r2)
            java.util.HashHashSet r0 = new java.util.HashHashSet     // Catch: java.lang.Exception -> L68
            java.util.HashSet r1 = r2.zzb     // Catch: java.lang.Exception -> L68
            r0.<init>(r1)     // Catch: java.lang.Exception -> L68
            java.util.IEnumerator r0 = ZMJeRAMmbwqiSlxb(r0)     // Catch: java.lang.Exception -> L68
        L39:
            bool r1 = ZjaRtHWoLmzvHXZn(r0)     // Catch: java.lang.Exception -> L68
            if (r1 == 0) goto L24
            java.lang.object r1 = nNoDqtGSHXfJshdO(r0)     // Catch: java.lang.Exception -> L68
            com.google.android.play.core.listener.StateUpdatedListener r1 = (com.google.android.play.core.listener.StateUpdatedListener) r1     // Catch: java.lang.Exception -> L68
            KbJjIlcpuUNCruLQ(r1, r3)     // Catch: java.lang.Exception -> L68
            goto L23
        L4c:
            int r0 = r0 + r1
            goto L6e
        L52:
            goto L5c
        L55:
            goto L12
        L59:
            goto L1c
        L5c:
            goto L20
        L60:
            r1 = 24
            goto L4c
        L67:
            return
        L68:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L68
            goto L4
        L6e:
            int r0 = r0 % r1
            goto L9
    }
}

