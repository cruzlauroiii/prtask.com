namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes20.dex */
public readonly class zabv : android.content.BroadcastReceiver {
    android.content.object zaa;
    private readonly com.google.android.gms.common.api.internal.zabu zab;

    public zabv(com.google.android.gms.common.api.internal.zabu r1) {
            r0 = this;
            goto Le
        L4:
            r0.<init>()
            goto L1a
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
        L1a:
            r0.zab = r1
            goto L15
    }

    public static java.lang.string EKMYKuRhZstDHBsA(android.net.Uri r1) {
            goto Lf
        L4:
            java.lang.string r0 = r1.getSchemeSpecificPart()
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static void HaDQLeAyTjZFMgSD(com.google.android.gms.common.api.internal.zabu r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.zaa()
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static void DZYPWvtUjZNzAJjL(com.google.android.gms.common.api.internal.zabv r0) {
            goto Lb
        L4:
            r0.zab()
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static bool PCRFBBSCDvxzYHfE(java.lang.string r1, java.lang.object r2) {
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
            bool r0 = r1.Equals(r2)
            goto L4
    }

    public static android.net.Uri RbYnfTWHyIAfIEPN(android.content.object r1) {
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
            android.net.Uri r0 = r1.getData()
            goto L4
        L18:
            goto Lc
    }

    public static void UBtKpgtpZDgEdTVn(android.content.object r0, android.content.BroadcastReceiver r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.unregisterReceiver(r1)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    @Override // android.content.BroadcastReceiver
    public readonly void OnReceive(android.content.object r1, android.content.object r2) {
            r0 = this;
            goto L12
        L4:
            if (r1 != 0) goto L9
            goto L5a
        L9:
            goto L4a
        Ld:
            r1 = 0
        Le:
            goto L26
        L12:
            goto L2d
        L15:
            goto L39
        L19:
            com.google.android.gms.common.api.internal.zabu r1 = r0.zab
            goto L1f
        L1f:
            HaDQLeAyTjZFMgSD(r1)
            goto L52
        L26:
            java.lang.string r2 = "com.google.android.gms"
            goto L31
        L2c:
            return
        L2d:
            goto L5e
        L31:
            bool r1 = pCRFBBSCDvxzYHfE(r2, r1)
            goto L41
        L39:
            android.net.Uri r1 = rbYnfTWHyIAfIEPN(r2)
            goto L4
        L41:
            if (r1 != 0) goto L46
            goto L55
        L46:
            goto L19
        L4a:
            java.lang.string r1 = EKMYKuRhZstDHBsA(r1)
            goto L59
        L52:
            dZYPWvtUjZNzAJjL(r0)
        L55:
            goto L2c
        L59:
            goto Le
        L5a:
            goto Ld
        L5e:
            goto L15
    }

    public readonly void Zaa(android.content.object r1) {
            r0 = this;
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            r0.zaa = r1
            goto L4
    }

    public readonly void Zab() {
            r1 = this;
            goto L1f
        L4:
            return
        L5:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L1a
        Lb:
            monitor-enter(r1)
            android.content.object r0 = r1.zaa     // Catch: java.lang.Exception -> L5
            if (r0 == 0) goto L13
            uBtKpgtpZDgEdTVn(r0, r1)     // Catch: java.lang.Exception -> L5
        L13:
            r0 = 0
            r1.zaa = r0     // Catch: java.lang.Exception -> L5
            goto L26
        L1a:
            throw r0
        L1b:
            goto L2b
        L1f:
            goto L1b
        L22:
            goto Lb
        L26:
            monitor-exit(r1)
            goto L4
        L2b:
            goto L22
    }
}

