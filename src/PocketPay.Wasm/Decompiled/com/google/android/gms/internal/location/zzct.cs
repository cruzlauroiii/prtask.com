namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzct : com.google.android.gms.common.api.GoogleApi : com.google.android.gms.location.GeofencingClient {
    public static readonly /* synthetic */ int zza = 0;

    public zzct(android.app.object r4) {
            r3 = this;
            goto L1f
        L4:
            r1 = 7
            goto L51
        Lb:
            com.google.android.gms.common.api.Api r0 = com.google.android.gms.internal.location.zzbi.zzb
            goto L57
        L11:
            goto L4d
        L14:
            goto L2b
        L18:
            r3.<init>(r4, r0, r1, r2)
            goto L26
        L1f:
            goto L14
        L22:
            goto L2e
        L26:
            return
        L27:
            goto L11
        L2b:
            goto L22
        L2e:
            r0 = 32
            goto L4
        L35:
            int r0 = r0 % r1
            goto L41
        L3b:
            com.google.android.gms.common.api.GoogleApi$HashSettings r2 = com.google.android.gms.common.api.GoogleApi.HashSettings.DEFAULT_SETTINGS
            goto L18
        L41:
            if (r0 <= 0) goto L46
            goto L4d
        L46:
            goto L4a
        L4a:
            goto L27
        L4d:
            goto Lb
        L51:
            int r0 = r0 + r1
            goto L35
        L57:
            com.google.android.gms.common.api.Api$ApiOptions$NoOptions r1 = com.google.android.gms.common.api.Api.ApiOptions.NO_OPTIONS
            goto L3b
    }

    public zzct(android.content.object r4) {
            r3 = this;
            goto L3d
        L4:
            if (r0 <= 0) goto L9
            goto L59
        L9:
            goto L56
        Ld:
            r3.<init>(r4, r0, r1, r2)
            goto L51
        L14:
            r1 = 6
            goto L37
        L1b:
            com.google.android.gms.common.api.Api r0 = com.google.android.gms.internal.location.zzbi.zzb
            goto L31
        L21:
            int r0 = r0 % r1
            goto L4
        L27:
            goto L40
        L2a:
            r0 = 6
            goto L14
        L31:
            com.google.android.gms.common.api.Api$ApiOptions$NoOptions r1 = com.google.android.gms.common.api.Api.ApiOptions.NO_OPTIONS
            goto L44
        L37:
            int r0 = r0 + r1
            goto L21
        L3d:
            goto L4d
        L40:
            goto L2a
        L44:
            com.google.android.gms.common.api.GoogleApi$HashSettings r2 = com.google.android.gms.common.api.GoogleApi.HashSettings.DEFAULT_SETTINGS
            goto Ld
        L4a:
            goto L59
        L4d:
            goto L27
        L51:
            return
        L52:
            goto L4a
        L56:
            goto L52
        L59:
            goto L1b
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder BSRzqeExvuvxXeID(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1, com.google.android.gms.common.api.internal.RemoteCall r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = r1.run(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void BSRzqeExvuvxXeID(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, byte r2, float r3, char r4, int r5) {
            goto L1a
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        Lf:
            return
        L10:
            goto L2d
        L14:
            r0 = 42
            goto L9
        L1a:
            goto L10
        L1d:
            goto L14
        L21:
            int r3 = r2 + r1
            goto L4
        L27:
            int r2 = r0 * r1
            goto L21
        L2d:
            goto L1d
    }

    public static void BSRzqeExvuvxXeID(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, float r2, char r3, int r4, byte r5) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            r0 = 42
            goto L24
        L11:
            double r0 = (double) r3
            goto L16
        L16:
            return
        L17:
            goto L21
        L1b:
            int r3 = r2 + r1
            goto L11
        L21:
            goto L7
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L1b
    }

    public static void BSRzqeExvuvxXeID(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, int r2, byte r3, char r4, float r5) {
            goto L4
        L4:
            goto L12
        L7:
            goto L2a
        Lb:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L11:
            return
        L12:
            goto L16
        L16:
            goto L7
        L19:
            double r0 = (double) r3
            goto L11
        L1e:
            int r3 = r2 + r1
            goto L19
        L24:
            int r2 = r0 * r1
            goto L1e
        L2a:
            r0 = 42
            goto Lb
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall CAqKrmszXygxbIld(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1) {
            goto Lf
        L4:
            com.google.android.gms.common.api.internal.TaskApiCall r0 = r1.build()
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

    public static void CAqKrmszXygxbIld(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, char r1, byte r2, java.lang.string r3, int r4) {
            goto L24
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r0 = 42
            goto L19
        L10:
            int r3 = r2 + r1
            goto L2b
        L16:
            goto L27
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1f:
            return
        L20:
            goto L16
        L24:
            goto L20
        L27:
            goto La
        L2b:
            double r0 = (double) r3
            goto L1f
    }

    public static void CAqKrmszXygxbIld(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, char r2, byte r3, java.lang.string r4) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L26
        L12:
            goto L2a
        L16:
            int r2 = r0 * r1
            goto L9
        L1c:
            goto L12
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L25:
            return
        L26:
            goto L1c
        L2a:
            r0 = 42
            goto L1f
    }

    public static void CAqKrmszXygxbIld(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, java.lang.string r1, int r2, char r3, byte r4) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        La:
            goto L21
        Ld:
            return
        Le:
            goto La
        L12:
            int r2 = r0 * r1
            goto L25
        L18:
            r0 = 42
            goto L4
        L1e:
            goto Le
        L21:
            goto L18
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder NuUvnkbgzjxsCCgE(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1, com.google.android.gms.common.api.internal.RemoteCall r2) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = r1.run(r2)
            goto Lb
    }

    public static void NuUvnkbgzjxsCCgE(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, float r2, java.lang.string r3, short r4, char r5) {
            goto L23
        L4:
            int r3 = r2 + r1
            goto L1e
        La:
            return
        Lb:
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L4
        L15:
            r0 = 42
            goto L2a
        L1b:
            goto L26
        L1e:
            double r0 = (double) r3
            goto La
        L23:
            goto Lb
        L26:
            goto L15
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void NuUvnkbgzjxsCCgE(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, short r2, char r3, java.lang.string r4, float r5) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L10:
            double r0 = (double) r3
            goto L22
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            goto L23
        L1e:
            goto L27
        L22:
            return
        L23:
            goto L2d
        L27:
            r0 = 42
            goto La
        L2d:
            goto L1e
    }

    public static void NuUvnkbgzjxsCCgE(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, short r2, float r3, java.lang.string r4, char r5) {
            goto La
        L4:
            r0 = 42
            goto L25
        La:
            goto L21
        Ld:
            goto L4
        L11:
            int r2 = r0 * r1
            goto L1a
        L17:
            goto Ld
        L1a:
            int r3 = r2 + r1
            goto L2b
        L20:
            return
        L21:
            goto L17
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder QPdQsjcjimnepngd(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1, int r2) {
            goto L14
        L4:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = r1.setMethodKey(r2)
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

    public static void QPdQsjcjimnepngd(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, char r2, byte r3, int r4, float r5) {
            goto L14
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L21
        Le:
            r0 = 42
            goto L24
        L14:
            goto La
        L17:
            goto Le
        L1b:
            int r2 = r0 * r1
            goto L2a
        L21:
            goto L17
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    public static void QPdQsjcjimnepngd(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, char r2, int r3, float r4, byte r5) {
            goto L18
        L4:
            r0 = 42
            goto Lf
        La:
            return
        Lb:
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L15:
            goto L1b
        L18:
            goto Lb
        L1b:
            goto L4
        L1f:
            int r2 = r0 * r1
            goto L2a
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void QPdQsjcjimnepngd(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, float r2, byte r3, int r4, char r5) {
            goto L4
        L4:
            goto L20
        L7:
            goto L24
        Lb:
            int r2 = r0 * r1
            goto L14
        L11:
            goto L7
        L14:
            int r3 = r2 + r1
            goto L1a
        L1a:
            double r0 = (double) r3
            goto L1f
        L1f:
            return
        L20:
            goto L11
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder RvdiQmTdeJZUqaPb() {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = com.google.android.gms.common.api.internal.TaskApiCall.builder()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void RvdiQmTdeJZUqaPb(int r0, bool r1, short r2, java.lang.string r3) {
            goto Ld
        L4:
            r0 = 42
            goto L19
        La:
            goto L10
        Ld:
            goto L26
        L10:
            goto L4
        L14:
            double r0 = (double) r3
            goto L25
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            int r3 = r2 + r1
            goto L14
        L25:
            return
        L26:
            goto La
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static void RvdiQmTdeJZUqaPb(short r0, java.lang.string r1, int r2, bool r3) {
            goto L1e
        L4:
            r0 = 42
            goto Lf
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L15:
            int r3 = r2 + r1
            goto La
        L1b:
            goto L21
        L1e:
            goto L2c
        L21:
            goto L4
        L25:
            int r2 = r0 * r1
            goto L15
        L2b:
            return
        L2c:
            goto L1b
    }

    public static void RvdiQmTdeJZUqaPb(short r0, bool r1, java.lang.string r2, int r3) {
            goto Ld
        L4:
            goto L10
        L7:
            int r3 = r2 + r1
            goto L14
        Ld:
            goto L1a
        L10:
            goto L24
        L14:
            double r0 = (double) r3
            goto L19
        L19:
            return
        L1a:
            goto L4
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

    public static com.google.android.gms.tasks.Task ALgOPmcMWmMJgmMd(com.google.android.gms.internal.location.zzct r1, com.google.android.gms.common.api.internal.TaskApiCall r2) {
            goto L14
        L4:
            goto L17
        L7:
            com.google.android.gms.tasks.Task r0 = r1.doWrite(r2)
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

    public static void ALgOPmcMWmMJgmMd(com.google.android.gms.internal.location.zzct r0, com.google.android.gms.common.api.internal.TaskApiCall r1, int r2, short r3, bool r4, java.lang.string r5) {
            goto L21
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            return
        Lb:
            goto L28
        Lf:
            int r2 = r0 * r1
            goto L15
        L15:
            int r3 = r2 + r1
            goto L2b
        L1b:
            r0 = 42
            goto L4
        L21:
            goto Lb
        L24:
            goto L1b
        L28:
            goto L24
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void ALgOPmcMWmMJgmMd(com.google.android.gms.internal.location.zzct r0, com.google.android.gms.common.api.internal.TaskApiCall r1, java.lang.string r2, int r3, short r4, bool r5) {
            goto L10
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L10:
            goto L2c
        L13:
            goto L4
        L17:
            double r0 = (double) r3
            goto L2b
        L1c:
            int r3 = r2 + r1
            goto L17
        L22:
            goto L13
        L25:
            int r2 = r0 * r1
            goto L1c
        L2b:
            return
        L2c:
            goto L22
    }

    public static void ALgOPmcMWmMJgmMd(com.google.android.gms.internal.location.zzct r0, com.google.android.gms.common.api.internal.TaskApiCall r1, bool r2, short r3, java.lang.string r4, int r5) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L10:
            double r0 = (double) r3
            goto L22
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            goto L23
        L1e:
            goto L2a
        L22:
            return
        L23:
            goto L27
        L27:
            goto L1e
        L2a:
            r0 = 42
            goto La
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder DLSFgfQQtYEhLCzq(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1, com.google.android.gms.common.api.internal.RemoteCall r2) {
            goto Lc
        L4:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = r1.run(r2)
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

    public static void DLSFgfQQtYEhLCzq(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, float r2, short r3, int r4, bool r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L2c
        Lc:
            goto L10
        L10:
            r0 = 42
            goto L25
        L16:
            int r3 = r2 + r1
            goto L4
        L1c:
            goto Lc
        L1f:
            int r2 = r0 * r1
            goto L16
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void DLSFgfQQtYEhLCzq(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, int r2, float r3, bool r4, short r5) {
            goto L16
        L4:
            int r2 = r0 * r1
            goto L10
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            int r3 = r2 + r1
            goto L28
        L16:
            goto L1e
        L19:
            goto L22
        L1d:
            return
        L1e:
            goto L2d
        L22:
            r0 = 42
            goto La
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto L19
    }

    public static void DLSFgfQQtYEhLCzq(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, int r2, short r3, bool r4, float r5) {
            goto L1b
        L4:
            r0 = 42
            goto L25
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            return
        L17:
            goto L22
        L1b:
            goto L17
        L1e:
            goto L4
        L22:
            goto L1e
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L2b:
            double r0 = (double) r3
            goto L16
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder DyiQihBSbXJAWXcn(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1, int r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = r1.setMethodKey(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void DyiQihBSbXJAWXcn(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, char r2, float r3, java.lang.string r4, bool r5) {
            goto L18
        L4:
            int r2 = r0 * r1
            goto L1f
        La:
            r0 = 42
            goto L2a
        L10:
            goto L1b
        L13:
            double r0 = (double) r3
            goto L25
        L18:
            goto L26
        L1b:
            goto La
        L1f:
            int r3 = r2 + r1
            goto L13
        L25:
            return
        L26:
            goto L10
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void DyiQihBSbXJAWXcn(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, java.lang.string r2, float r3, bool r4, char r5) {
            goto L23
        L4:
            r0 = 42
            goto L2a
        La:
            return
        Lb:
            goto L1a
        Lf:
            int r2 = r0 * r1
            goto L1d
        L15:
            double r0 = (double) r3
            goto La
        L1a:
            goto L26
        L1d:
            int r3 = r2 + r1
            goto L15
        L23:
            goto Lb
        L26:
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
    }

    public static void DyiQihBSbXJAWXcn(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, bool r2, float r3, java.lang.string r4, char r5) {
            goto L24
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            goto L27
        Lc:
            r0 = 42
            goto L1e
        L12:
            int r3 = r2 + r1
            goto L4
        L18:
            int r2 = r0 * r1
            goto L12
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L24:
            goto L2c
        L27:
            goto Lc
        L2b:
            return
        L2c:
            goto L9
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder LuivzATPejpJkGym() {
            goto Lc
        L4:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = com.google.android.gms.common.api.internal.TaskApiCall.builder()
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

    public static void LuivzATPejpJkGym(byte r0, float r1, int r2, java.lang.string r3) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            r0 = 42
            goto L1f
        L10:
            goto L2c
        L13:
            goto La
        L17:
            double r0 = (double) r3
            goto L2b
        L1c:
            goto L13
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L25:
            int r3 = r2 + r1
            goto L17
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void LuivzATPejpJkGym(byte r0, float r1, java.lang.string r2, int r3) {
            goto L1b
        L4:
            int r2 = r0 * r1
            goto L15
        La:
            return
        Lb:
            goto L22
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            int r3 = r2 + r1
            goto L2b
        L1b:
            goto Lb
        L1e:
            goto L25
        L22:
            goto L1e
        L25:
            r0 = 42
            goto Lf
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static void LuivzATPejpJkGym(byte r0, int r1, float r2, java.lang.string r3) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        La:
            int r3 = r2 + r1
            goto L2b
        L10:
            int r2 = r0 * r1
            goto La
        L16:
            return
        L17:
            goto L21
        L1b:
            r0 = 42
            goto L4
        L21:
            goto L27
        L24:
            goto L17
        L27:
            goto L1b
        L2b:
            double r0 = (double) r3
            goto L16
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder NDjMYQRYjoKfepFi() {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = com.google.android.gms.common.api.internal.TaskApiCall.builder()
            goto Le
    }

    public static void NDjMYQRYjoKfepFi(char r0, bool r1, short r2, int r3) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L18
        La:
            return
        Lb:
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L15:
            goto L21
        L18:
            int r3 = r2 + r1
            goto L25
        L1e:
            goto Lb
        L21:
            goto L2a
        L25:
            double r0 = (double) r3
            goto La
        L2a:
            r0 = 42
            goto Lf
    }

    public static void NDjMYQRYjoKfepFi(int r0, short r1, char r2, bool r3) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L1e
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            int r2 = r0 * r1
            goto L2a
        L19:
            double r0 = (double) r3
            goto Le
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L2a:
            int r3 = r2 + r1
            goto L19
    }

    public static void NDjMYQRYjoKfepFi(int r0, short r1, bool r2, char r3) {
            goto L4
        L4:
            goto L1b
        L7:
            goto L24
        Lb:
            int r3 = r2 + r1
            goto L1f
        L11:
            goto L7
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1a:
            return
        L1b:
            goto L11
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            r0 = 42
            goto L14
        L2a:
            int r2 = r0 * r1
            goto Lb
    }

    public static com.google.android.gms.tasks.Task NUyzdtRmijGNbqYN(com.google.android.gms.internal.location.zzct r1, com.google.android.gms.common.api.internal.TaskApiCall r2) {
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
            com.google.android.gms.tasks.Task r0 = r1.doWrite(r2)
            goto L4
    }

    public static void NUyzdtRmijGNbqYN(com.google.android.gms.internal.location.zzct r0, com.google.android.gms.common.api.internal.TaskApiCall r1, char r2, java.lang.string r3, short r4, int r5) {
            goto L4
        L4:
            goto L2c
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0 = 42
            goto L25
        L14:
            double r0 = (double) r3
            goto L2b
        L19:
            int r3 = r2 + r1
            goto L14
        L1f:
            int r2 = r0 * r1
            goto L19
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L2b:
            return
        L2c:
            goto Lb
    }

    public static void NUyzdtRmijGNbqYN(com.google.android.gms.internal.location.zzct r0, com.google.android.gms.common.api.internal.TaskApiCall r1, int r2, short r3, char r4, java.lang.string r5) {
            goto L1e
        L4:
            int r2 = r0 * r1
            goto L13
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L21
        L13:
            int r3 = r2 + r1
            goto L2b
        L19:
            return
        L1a:
            goto L10
        L1e:
            goto L1a
        L21:
            goto L25
        L25:
            r0 = 42
            goto La
        L2b:
            double r0 = (double) r3
            goto L19
    }

    public static void NUyzdtRmijGNbqYN(com.google.android.gms.internal.location.zzct r0, com.google.android.gms.common.api.internal.TaskApiCall r1, short r2, int r3, char r4, java.lang.string r5) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L25
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            goto L26
        L12:
            goto L2a
        L16:
            goto L12
        L19:
            int r2 = r0 * r1
            goto L9
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            return
        L26:
            goto L16
        L2a:
            r0 = 42
            goto L1f
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall OeUlTdYAQlxTEumR(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.android.gms.common.api.internal.TaskApiCall r0 = r1.build()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void OeUlTdYAQlxTEumR(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, byte r1, short r2, java.lang.string r3, float r4) {
            goto L1d
        L4:
            goto L20
        L7:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        Ld:
            int r3 = r2 + r1
            goto L18
        L13:
            return
        L14:
            goto L4
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            goto L14
        L20:
            goto L2a
        L24:
            int r2 = r0 * r1
            goto Ld
        L2a:
            r0 = 42
            goto L7
    }

    public static void OeUlTdYAQlxTEumR(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, short r1, float r2, java.lang.string r3, byte r4) {
            goto L14
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L1b
        Le:
            r0 = 42
            goto L24
        L14:
            goto La
        L17:
            goto Le
        L1b:
            goto L17
        L1e:
            int r3 = r2 + r1
            goto L4
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static void OeUlTdYAQlxTEumR(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, short r1, java.lang.string r2, byte r3, float r4) {
            goto Ld
        L4:
            goto L10
        L7:
            r0 = 42
            goto L24
        Ld:
            goto L1b
        L10:
            goto L7
        L14:
            int r2 = r0 * r1
            goto L2a
        L1a:
            return
        L1b:
            goto L4
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder RvpzNOkdkEpvKxbw(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1, int r2) {
            goto Lc
        L4:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = r1.setMethodKey(r2)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static void RvpzNOkdkEpvKxbw(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, char r2, bool r3, java.lang.string r4, int r5) {
            goto L29
        L4:
            goto L2c
        L7:
            r0 = 42
            goto L23
        Ld:
            return
        Le:
            goto L4
        L12:
            int r2 = r0 * r1
            goto L18
        L18:
            int r3 = r2 + r1
            goto L1e
        L1e:
            double r0 = (double) r3
            goto Ld
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L29:
            goto Le
        L2c:
            goto L7
    }

    public static void RvpzNOkdkEpvKxbw(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, int r2, java.lang.string r3, bool r4, char r5) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            return
        Lb:
            goto L2d
        Lf:
            int r2 = r0 * r1
            goto L27
        L15:
            goto Lb
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto L4
        L22:
            double r0 = (double) r3
            goto La
        L27:
            int r3 = r2 + r1
            goto L22
        L2d:
            goto L18
    }

    public static void RvpzNOkdkEpvKxbw(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, int r2, bool r3, char r4, java.lang.string r5) {
            goto L29
        L4:
            return
        L5:
            goto L9
        L9:
            goto L2c
        Lc:
            int r2 = r0 * r1
            goto L1d
        L12:
            double r0 = (double) r3
            goto L4
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
        L1d:
            int r3 = r2 + r1
            goto L12
        L23:
            r0 = 42
            goto L17
        L29:
            goto L5
        L2c:
            goto L23
    }

    public static com.google.android.gms.tasks.Task TpKXXGBhWSBGSlNO(com.google.android.gms.internal.location.zzct r1, com.google.android.gms.common.api.internal.TaskApiCall r2) {
            goto Lc
        L4:
            com.google.android.gms.tasks.Task r0 = r1.doWrite(r2)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static void TpKXXGBhWSBGSlNO(com.google.android.gms.internal.location.zzct r0, com.google.android.gms.common.api.internal.TaskApiCall r1, byte r2, short r3, char r4, bool r5) {
            goto L1d
        L4:
            int r2 = r0 * r1
            goto L24
        La:
            return
        Lb:
            goto Lf
        Lf:
            goto L20
        L12:
            r0 = 42
            goto L2a
        L18:
            double r0 = (double) r3
            goto La
        L1d:
            goto Lb
        L20:
            goto L12
        L24:
            int r3 = r2 + r1
            goto L18
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void TpKXXGBhWSBGSlNO(com.google.android.gms.internal.location.zzct r0, com.google.android.gms.common.api.internal.TaskApiCall r1, short r2, char r3, byte r4, bool r5) {
            goto L10
        L4:
            int r2 = r0 * r1
            goto L25
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L21
        L13:
            goto L17
        L17:
            r0 = 42
            goto La
        L1d:
            goto L13
        L20:
            return
        L21:
            goto L1d
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto L20
    }

    public static void TpKXXGBhWSBGSlNO(com.google.android.gms.internal.location.zzct r0, com.google.android.gms.common.api.internal.TaskApiCall r1, short r2, char r3, bool r4, byte r5) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L18
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            double r0 = (double) r3
            goto Le
        L18:
            r0 = 42
            goto L2a
        L1e:
            int r3 = r2 + r1
            goto L13
        L24:
            int r2 = r0 * r1
            goto L1e
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall YyEapDXLjVTWFWQV(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.android.gms.common.api.internal.TaskApiCall r0 = r1.build()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void YyEapDXLjVTWFWQV(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, byte r1, short r2, int r3, bool r4) {
            goto L1d
        L4:
            return
        L5:
            goto L14
        L9:
            int r3 = r2 + r1
            goto Lf
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L20
        L17:
            int r2 = r0 * r1
            goto L9
        L1d:
            goto L5
        L20:
            goto L2a
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L2a:
            r0 = 42
            goto L24
    }

    public static void YyEapDXLjVTWFWQV(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, byte r1, short r2, bool r3, int r4) {
            goto L15
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        La:
            r0 = 42
            goto L4
        L10:
            double r0 = (double) r3
            goto L1c
        L15:
            goto L1d
        L18:
            goto La
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r2 = r0 * r1
            goto L27
        L27:
            int r3 = r2 + r1
            goto L10
        L2d:
            goto L18
    }

    public static void YyEapDXLjVTWFWQV(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, byte r2, short r3, bool r4) {
            goto L14
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L21
        Le:
            r0 = 42
            goto L2a
        L14:
            goto La
        L17:
            goto Le
        L1b:
            int r2 = r0 * r1
            goto L24
        L21:
            goto L17
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
    }

    @Override // com.google.android.gms.location.GeofencingClient
    public readonly com.google.android.gms.tasks.Task<java.lang.void> AddGeofences(com.google.android.gms.location.GeofencingRequest r3, android.app.Pendingobject r4) {
            r2 = this;
            goto L12
        L4:
            r1.<init>(r3, r4)
            goto L71
        Lb:
            r0 = 15
            goto L55
        L12:
            goto L51
        L15:
            goto Lb
        L19:
            com.google.android.gms.tasks.Task r2 = tpKXXGBhWSBGSlNO(r2, r3)
            goto L64
        L21:
            if (r0 <= 0) goto L26
            goto L35
        L26:
            goto L32
        L2a:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r3 = rvpzNOkdkEpvKxbw(r3, r4)
            goto L5c
        L32:
            goto L65
        L35:
            goto L69
        L39:
            int r0 = r0 % r1
            goto L21
        L3f:
            goto L15
        L42:
            com.google.android.gms.internal.location.zzcw r1 = new com.google.android.gms.internal.location.zzcw
            goto L4
        L48:
            int r0 = r0 + r1
            goto L39
        L4e:
            goto L35
        L51:
            goto L3f
        L55:
            r1 = 27
            goto L48
        L5c:
            com.google.android.gms.common.api.internal.TaskApiCall r3 = oeUlTdYAQlxTEumR(r3)
            goto L19
        L64:
            return r2
        L65:
            goto L4e
        L69:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = RvdiQmTdeJZUqaPb()
            goto L42
        L71:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r3 = NuUvnkbgzjxsCCgE(r0, r1)
            goto L79
        L79:
            r4 = 2424(0x978, float:3.397E-42)
            goto L2a
    }

    @Override // com.google.android.gms.location.GeofencingClient
    public readonly com.google.android.gms.tasks.Task<java.lang.void> RemoveGeofences(android.app.Pendingobject r3) {
            r2 = this;
            goto L5b
        L4:
            r1 = 30
            goto L2c
        Lb:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r3 = dyiQihBSbXJAWXcn(r3, r0)
            goto L16
        L13:
            goto L5e
        L16:
            com.google.android.gms.common.api.internal.TaskApiCall r3 = CAqKrmszXygxbIld(r3)
            goto L3e
        L1e:
            goto L57
        L21:
            goto L13
        L25:
            r0 = 6
            goto L4
        L2c:
            int r0 = r0 + r1
            goto L38
        L32:
            r0 = 2425(0x979, float:3.398E-42)
            goto Lb
        L38:
            int r0 = r0 % r1
            goto L6f
        L3e:
            com.google.android.gms.tasks.Task r2 = aLgOPmcMWmMJgmMd(r2, r3)
            goto L6a
        L46:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = luivzATPejpJkGym()
            goto L4e
        L4e:
            com.google.android.gms.internal.location.zzcu r1 = new com.google.android.gms.internal.location.zzcu
            goto L78
        L54:
            goto L6b
        L57:
            goto L46
        L5b:
            goto L21
        L5e:
            goto L25
        L62:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r3 = dLSFgfQQtYEhLCzq(r0, r1)
            goto L32
        L6a:
            return r2
        L6b:
            goto L1e
        L6f:
            if (r0 <= 0) goto L74
            goto L57
        L74:
            goto L54
        L78:
            r1.<init>(r3)
            goto L62
    }

    @Override // com.google.android.gms.location.GeofencingClient
    public readonly com.google.android.gms.tasks.Task<java.lang.void> RemoveGeofences(java.util.List<java.lang.string> r3) {
            r2 = this;
            goto L1d
        L4:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r3 = BSRzqeExvuvxXeID(r0, r1)
            goto L24
        Lc:
            goto L20
        Lf:
            r1 = 2
            goto L52
        L16:
            goto L66
        L19:
            goto L43
        L1d:
            goto L7b
        L20:
            goto L58
        L24:
            r0 = 2425(0x979, float:3.398E-42)
            goto L2a
        L2a:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r3 = QPdQsjcjimnepngd(r3, r0)
            goto L70
        L32:
            com.google.android.gms.tasks.Task r2 = nUyzdtRmijGNbqYN(r2, r3)
            goto L65
        L3a:
            if (r0 <= 0) goto L3f
            goto L19
        L3f:
            goto L16
        L43:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = nDjMYQRYjoKfepFi()
            goto L6a
        L4b:
            r1.<init>(r3)
            goto L4
        L52:
            int r0 = r0 + r1
            goto L5f
        L58:
            r0 = 5
            goto Lf
        L5f:
            int r0 = r0 % r1
            goto L3a
        L65:
            return r2
        L66:
            goto L78
        L6a:
            com.google.android.gms.internal.location.zzcv r1 = new com.google.android.gms.internal.location.zzcv
            goto L4b
        L70:
            com.google.android.gms.common.api.internal.TaskApiCall r3 = yyEapDXLjVTWFWQV(r3)
            goto L32
        L78:
            goto L19
        L7b:
            goto Lc
    }
}

