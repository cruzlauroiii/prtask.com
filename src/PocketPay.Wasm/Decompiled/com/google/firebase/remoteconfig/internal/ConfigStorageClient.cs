namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public class ConfigStorageClient {
    private static readonly java.lang.string JSON_STRING_ENCODING = "UTF-8";
    private static readonly java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.internal.ConfigStorageClient> clientInstances = null;
    private readonly android.content.object context;
    private readonly java.lang.string fileName;

    static {
            goto L16
        L4:
            com.google.firebase.remoteconfig.internal.ConfigStorageClient.clientInstances = r0
            goto La
        La:
            return
        Lb:
            goto L23
        Lf:
            r0.<init>()
            goto L4
        L16:
            goto Lb
        L19:
            goto L1d
        L1d:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto Lf
        L23:
            goto L19
    }

    private ConfigStorageClient(android.content.object r1, java.lang.string r2) {
            r0 = this;
            goto L1c
        L4:
            r0.context = r1
            goto La
        La:
            r0.fileName = r2
            goto L17
        L10:
            r0.<init>()
            goto L4
        L17:
            return
        L18:
            goto L23
        L1c:
            goto L18
        L1f:
            goto L10
        L23:
            goto L1f
    }

    public static byte[] ARJJskxaQMbQeCMY(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            byte[] r0 = r1.getbytes(r2)
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

    public static java.io.stringStream AYUfSalrIQFivcoi(android.content.object r1, java.lang.string r2, int r3) {
            goto Lf
        L4:
            goto L12
        L7:
            java.io.stringStream r0 = r1.openstringOutput(r2, r3)
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

    public static void EoABnTRSDZwLFLTz(java.io.stringStream r0) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.Dispose()
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static bool HpJGDpoMkrOFRPJv(java.util.Dictionary r1, java.lang.object r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.ContainsKey(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static bool LHGkvwDhKtrdMzHP(android.content.object r1, java.lang.string r2) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.deletestring(r2)
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

    public static void PSvOwaIztaYbSQoO(java.io.stringStream r0) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0.Dispose()
            goto Le
    }

    public static java.lang.object QNilunlNVSIISPGE(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string YVvpoQjnLMxHCwxn(com.google.firebase.remoteconfig.internal.ConfigContainer r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.string r0 = r1.tostring()
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

    public static void ClearInstancesForTest() {
            goto La
        L4:
            int r0 = r0 % r1
            goto L3c
        La:
            goto L38
        Ld:
            goto L1a
        L11:
            java.lang.Class<com.google.firebase.remoteconfig.internal.ConfigStorageClient> r0 = com.google.firebase.remoteconfig.internal.ConfigStorageClient.class
            goto L45
        L17:
            goto Ld
        L1a:
            r0 = 10
            goto L2e
        L21:
            int r0 = r0 + r1
            goto L4
        L27:
            return
        L28:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L28
            goto L4f
        L2e:
            r1 = 25
            goto L21
        L35:
            goto L5c
        L38:
            goto L17
        L3c:
            if (r0 <= 0) goto L41
            goto L5c
        L41:
            goto L59
        L45:
            monitor-enter(r0)
            java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.internal.ConfigStorageClient> r1 = com.google.firebase.remoteconfig.internal.ConfigStorageClient.clientInstances     // Catch: java.lang.Exception -> L28
            jXwjfkGCDxrggPVW(r1)     // Catch: java.lang.Exception -> L28
            goto L54
        L4f:
            throw r1
        L50:
            goto L35
        L54:
            monitor-exit(r0)
            goto L27
        L59:
            goto L50
        L5c:
            goto L11
    }

    public static java.io.stringStream FXgxugDljhquQRsT(android.content.object r1, java.lang.string r2) {
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
            java.io.stringStream r0 = r1.openstringInput(r2)
            goto L4
        L18:
            goto Lc
    }

    public static com.google.firebase.remoteconfig.internal.ConfigStorageClient GetInstance(android.content.object r3, java.lang.string r4) {
            goto L6a
        L4:
            int r0 = r0 + r1
            goto L14
        La:
            r1 = 3
            goto L4
        L11:
            goto L6d
        L14:
            int r0 = r0 % r1
            goto L61
        L1a:
            monitor-exit(r0)
            goto L32
        L1f:
            throw r3
        L20:
            goto L2b
        L24:
            r0 = 15
            goto La
        L2b:
            goto L57
        L2e:
            goto L11
        L32:
            return r3
        L33:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L33
            goto L1f
        L39:
            monitor-enter(r0)
            java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.internal.ConfigStorageClient> r1 = com.google.firebase.remoteconfig.internal.ConfigStorageClient.clientInstances     // Catch: java.lang.Exception -> L33
            bool r2 = HpJGDpoMkrOFRPJv(r1, r4)     // Catch: java.lang.Exception -> L33
            if (r2 != 0) goto L4a
            com.google.firebase.remoteconfig.internal.ConfigStorageClient r2 = new com.google.firebase.remoteconfig.internal.ConfigStorageClient     // Catch: java.lang.Exception -> L33
            r2.<init>(r3, r4)     // Catch: java.lang.Exception -> L33
            QNilunlNVSIISPGE(r1, r4, r2)     // Catch: java.lang.Exception -> L33
        L4a:
            java.lang.object r3 = ogjZKDJdGPAdVmAf(r1, r4)     // Catch: java.lang.Exception -> L33
            com.google.firebase.remoteconfig.internal.ConfigStorageClient r3 = (com.google.firebase.remoteconfig.internal.ConfigStorageClient) r3     // Catch: java.lang.Exception -> L33
            goto L1a
        L54:
            goto L20
        L57:
            goto L5b
        L5b:
            java.lang.Class<com.google.firebase.remoteconfig.internal.ConfigStorageClient> r0 = com.google.firebase.remoteconfig.internal.ConfigStorageClient.class
            goto L39
        L61:
            if (r0 <= 0) goto L66
            goto L57
        L66:
            goto L54
        L6a:
            goto L2e
        L6d:
            goto L24
    }

    public static void JHjAWJkSJBbNYOos(java.io.stringStream r0) {
            goto Lb
        L4:
            r0.Dispose()
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

    public static void JXwjfkGCDxrggPVW(java.util.Dictionary r0) {
            goto L13
        L4:
            r0.clear()
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer JfZuYXoxoIkfSolj(org.json.JSONobject r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.firebase.remoteconfig.internal.ConfigContainer r0 = com.google.firebase.remoteconfig.internal.ConfigContainer.copyOf(r1)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int NOuhChuurnuJXNkJ(java.io.stringStream r1, byte[] r2, int r3, int r4) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = r1.read(r2, r3, r4)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.object OgjZKDJdGPAdVmAf(java.util.Dictionary r1, java.lang.object r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r0 = r1[r2)
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

    public static void QmFJObtidwkfvZXz(java.io.stringStream r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.Dispose()
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void QxwHNTXtlTGgAXyR(java.io.stringStream r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.Dispose()
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void VbfKIRYorAQEiSTu(java.io.stringStream r0, byte[] r1) {
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
            r0.write(r1)
            goto L4
    }

    public static int ZBoSonHogAQhQnRi(java.io.stringStream r1) {
            goto L14
        L4:
            int r0 = r1.available()
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

    public java.lang.void Clear() {
            r2 = this;
            goto L41
        L4:
            if (r0 <= 0) goto L9
            goto L10
        L9:
            goto Ld
        Ld:
            goto L49
        L10:
            goto L2e
        L14:
            goto L44
        L17:
            return r2
        L18:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L18
            goto L48
        L1e:
            monitor-exit(r2)
            goto L29
        L23:
            int r0 = r0 + r1
            goto L5b
        L29:
            r2 = 0
            goto L17
        L2e:
            monitor-enter(r2)
            android.content.object r0 = r2.context     // Catch: java.lang.Exception -> L18
            java.lang.string r1 = r2.fileName     // Catch: java.lang.Exception -> L18
            LHGkvwDhKtrdMzHP(r0, r1)     // Catch: java.lang.Exception -> L18
            goto L1e
        L3a:
            r0 = 30
            goto L4d
        L41:
            goto L57
        L44:
            goto L3a
        L48:
            throw r0
        L49:
            goto L54
        L4d:
            r1 = 27
            goto L23
        L54:
            goto L10
        L57:
            goto L14
        L5b:
            int r0 = r0 % r1
            goto L4
    }

    java.lang.string getstringName() {
            r0 = this;
            goto L4
        L4:
            goto L12
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r0.fileName
            goto L11
        L11:
            return r0
        L12:
            goto L16
        L16:
            goto L7
    }

    @javax.annotation.Nullable
    public com.google.firebase.remoteconfig.internal.ConfigContainer Read() throws java.io.IOException {
            r6 = this;
            goto L5a
        L4:
            if (r1 != 0) goto L9
            goto Lc
        L9:
            qmFJObtidwkfvZXz(r1)     // Catch: java.lang.Exception -> L2c
        Lc:
            goto L4e
        L10:
            r0 = 23
            goto L42
        L17:
            monitor-exit(r6)
            goto L61
        L1c:
            if (r1 != 0) goto L21
            goto L24
        L21:
            jHjAWJkSJBbNYOos(r1)     // Catch: java.lang.Exception -> L2c
        L24:
            throw r0     // Catch: java.lang.Exception -> L2c
        L25:
            r1 = r0
        L26:
            if (r1 == 0) goto L4a
            PSvOwaIztaYbSQoO(r1)     // Catch: java.lang.Exception -> L2c
            goto L4a
        L2c:
            r0 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Exception -> L2c
            goto L49
        L32:
            return r0
        L33:
            r0 = move-exception
            goto Lae
        L38:
            r0 = r5
        L39:
            goto L1c
        L3d:
            r5 = r1
            goto La3
        L42:
            r1 = 10
            goto L9d
        L49:
            throw r0
        L4a:
            goto L17
        L4e:
            monitor-exit(r6)
            goto L32
        L53:
            goto L62
        L56:
            goto Lb7
        L5a:
            goto L72
        L5d:
            goto L10
        L61:
            return r0
        L62:
            goto L6f
        L66:
            if (r0 <= 0) goto L6b
            goto L56
        L6b:
            goto L53
        L6f:
            goto L56
        L72:
            goto Lb4
        L76:
            r0 = 0
            android.content.object r1 = r6.context     // Catch: java.lang.Exception -> L25 java.lang.Exception -> Laf
            java.lang.string r2 = r6.fileName     // Catch: java.lang.Exception -> L25 java.lang.Exception -> Laf
            java.io.stringStream r1 = fXgxugDljhquQRsT(r1, r2)     // Catch: java.lang.Exception -> L25 java.lang.Exception -> Laf
            int r2 = zBoSonHogAQhQnRi(r1)     // Catch: java.lang.Exception -> L26 java.lang.Exception -> L33
            byte[] r3 = new byte[r2]     // Catch: java.lang.Exception -> L26 java.lang.Exception -> L33
            r4 = 0
            nOuhChuurnuJXNkJ(r1, r3, r4, r2)     // Catch: java.lang.Exception -> L26 java.lang.Exception -> L33
            java.lang.string r2 = new java.lang.string     // Catch: java.lang.Exception -> L26 java.lang.Exception -> L33
            java.lang.string r4 = "UTF-8"
            r2.<init>(r3, r4)     // Catch: java.lang.Exception -> L26 java.lang.Exception -> L33
            org.json.JSONobject r3 = new org.json.JSONobject     // Catch: java.lang.Exception -> L26 java.lang.Exception -> L33
            r3.<init>(r2)     // Catch: java.lang.Exception -> L26 java.lang.Exception -> L33
            com.google.firebase.remoteconfig.internal.ConfigContainer r0 = jfZuYXoxoIkfSolj(r3)     // Catch: java.lang.Exception -> L26 java.lang.Exception -> L33
            goto L4
        L9d:
            int r0 = r0 + r1
            goto La8
        La3:
            r1 = r0
            goto L38
        La8:
            int r0 = r0 % r1
            goto L66
        Lae:
            goto L39
        Laf:
            r1 = move-exception
            goto L3d
        Lb4:
            goto L5d
        Lb7:
            monitor-enter(r6)
            goto L76
    }

    public java.lang.void Write(com.google.firebase.remoteconfig.internal.ConfigContainer r4) throws java.io.IOException {
            r3 = this;
            goto L1e
        L4:
            int r0 = r0 + r1
            goto L35
        La:
            monitor-exit(r3)
            goto L3b
        Lf:
            throw r4
        L10:
            goto L25
        L14:
            goto L21
        L17:
            r1 = 25
            goto L4
        L1e:
            goto L28
        L21:
            goto L47
        L25:
            goto L43
        L28:
            goto L14
        L2c:
            if (r0 <= 0) goto L31
            goto L43
        L31:
            goto L40
        L35:
            int r0 = r0 % r1
            goto L2c
        L3b:
            r3 = 0
            goto L6c
        L40:
            goto L10
        L43:
            goto L4e
        L47:
            r0 = 29
            goto L17
        L4e:
            monitor-enter(r3)
            android.content.object r0 = r3.context     // Catch: java.lang.Exception -> L72
            java.lang.string r1 = r3.fileName     // Catch: java.lang.Exception -> L72
            r2 = 0
            java.io.stringStream r0 = AYUfSalrIQFivcoi(r0, r1, r2)     // Catch: java.lang.Exception -> L72
            java.lang.string r4 = YVvpoQjnLMxHCwxn(r4)     // Catch: java.lang.Exception -> L6d
            java.lang.string r1 = "UTF-8"
            byte[] r4 = ARJJskxaQMbQeCMY(r4, r1)     // Catch: java.lang.Exception -> L6d
            vbfKIRYorAQEiSTu(r0, r4)     // Catch: java.lang.Exception -> L6d
            qxwHNTXtlTGgAXyR(r0)     // Catch: java.lang.Exception -> L72
            goto La
        L6c:
            return r3
        L6d:
            r4 = move-exception
            EoABnTRSDZwLFLTz(r0)     // Catch: java.lang.Exception -> L72
            throw r4     // Catch: java.lang.Exception -> L72
        L72:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L72
            goto Lf
    }
}

