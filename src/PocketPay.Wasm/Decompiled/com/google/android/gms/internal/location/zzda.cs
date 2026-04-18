namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzda : com.google.android.gms.common.api.GoogleApi : com.google.android.gms.location.HashSettingsClient {
    public static readonly /* synthetic */ int zza = 0;

    public zzda(android.app.object r4) {
            r3 = this;
            goto L3f
        L4:
            goto L50
        L7:
            goto L16
        Lb:
            int r0 = r0 % r1
            goto L54
        L11:
            return
        L12:
            goto L4
        L16:
            goto L42
        L19:
            com.google.android.gms.common.api.Api$ApiOptions$NoOptions r1 = com.google.android.gms.common.api.Api.ApiOptions.NO_OPTIONS
            goto L26
        L1f:
            r1 = 17
            goto L33
        L26:
            com.google.android.gms.common.api.GoogleApi$HashSettings r2 = com.google.android.gms.common.api.GoogleApi.HashSettings.DEFAULT_SETTINGS
            goto L46
        L2c:
            r0 = 8
            goto L1f
        L33:
            int r0 = r0 + r1
            goto Lb
        L39:
            com.google.android.gms.common.api.Api r0 = com.google.android.gms.internal.location.zzbi.zzb
            goto L19
        L3f:
            goto L7
        L42:
            goto L2c
        L46:
            r3.<init>(r4, r0, r1, r2)
            goto L11
        L4d:
            goto L12
        L50:
            goto L39
        L54:
            if (r0 <= 0) goto L59
            goto L50
        L59:
            goto L4d
    }

    public zzda(android.content.object r4) {
            r3 = this;
            goto L4
        L4:
            goto L1b
        L7:
            goto L11
        Lb:
            com.google.android.gms.common.api.Api$ApiOptions$NoOptions r1 = com.google.android.gms.common.api.Api.ApiOptions.NO_OPTIONS
            goto L43
        L11:
            r0 = 21
            goto L56
        L18:
            goto L4c
        L1b:
            goto L26
        L1f:
            r3.<init>(r4, r0, r1, r2)
            goto L29
        L26:
            goto L7
        L29:
            return
        L2a:
            goto L18
        L2e:
            int r0 = r0 % r1
            goto L3a
        L34:
            int r0 = r0 + r1
            goto L2e
        L3a:
            if (r0 <= 0) goto L3f
            goto L4c
        L3f:
            goto L49
        L43:
            com.google.android.gms.common.api.GoogleApi$HashSettings r2 = com.google.android.gms.common.api.GoogleApi.HashSettings.DEFAULT_SETTINGS
            goto L1f
        L49:
            goto L2a
        L4c:
            goto L50
        L50:
            com.google.android.gms.common.api.Api r0 = com.google.android.gms.internal.location.zzbi.zzb
            goto Lb
        L56:
            r1 = 8
            goto L34
    }

    public static com.google.android.gms.tasks.Task PfSUsHikibKHwXNB(com.google.android.gms.internal.location.zzda r1, com.google.android.gms.common.api.internal.TaskApiCall r2) {
            goto Lc
        L4:
            com.google.android.gms.tasks.Task r0 = r1.doRead(r2)
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

    public static void PfSUsHikibKHwXNB(com.google.android.gms.internal.location.zzda r0, com.google.android.gms.common.api.internal.TaskApiCall r1, byte r2, float r3, int r4, short r5) {
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
            goto L19
        L13:
            int r3 = r2 + r1
            goto L25
        L19:
            r0 = 42
            goto L2a
        L1f:
            int r2 = r0 * r1
            goto L13
        L25:
            double r0 = (double) r3
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
    }

    public static void PfSUsHikibKHwXNB(com.google.android.gms.internal.location.zzda r0, com.google.android.gms.common.api.internal.TaskApiCall r1, float r2, byte r3, int r4, short r5) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L1c
        L10:
            goto L18
        L13:
            goto L2a
        L17:
            return
        L18:
            goto L27
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto L17
        L27:
            goto L13
        L2a:
            r0 = 42
            goto L4
    }

    public static void PfSUsHikibKHwXNB(com.google.android.gms.internal.location.zzda r0, com.google.android.gms.common.api.internal.TaskApiCall r1, int r2, float r3, short r4, byte r5) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            return
        Lb:
            goto L15
        Lf:
            int r2 = r0 * r1
            goto L1e
        L15:
            goto L27
        L18:
            r0 = 42
            goto L4
        L1e:
            int r3 = r2 + r1
            goto L2b
        L24:
            goto Lb
        L27:
            goto L18
        L2b:
            double r0 = (double) r3
            goto La
    }

    public static com.google.android.gms.tasks.Task STrUpQFezMTVnSem(com.google.android.gms.internal.location.zzda r1, com.google.android.gms.common.api.internal.TaskApiCall r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.android.gms.tasks.Task r0 = r1.doRead(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void STrUpQFezMTVnSem(com.google.android.gms.internal.location.zzda r0, com.google.android.gms.common.api.internal.TaskApiCall r1, byte r2, float r3, char r4, short r5) {
            goto L29
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lf
        La:
            return
        Lb:
            goto L1b
        Lf:
            int r2 = r0 * r1
            goto L23
        L15:
            r0 = 42
            goto L4
        L1b:
            goto L2c
        L1e:
            double r0 = (double) r3
            goto La
        L23:
            int r3 = r2 + r1
            goto L1e
        L29:
            goto Lb
        L2c:
            goto L15
    }

    public static void STrUpQFezMTVnSem(com.google.android.gms.internal.location.zzda r0, com.google.android.gms.common.api.internal.TaskApiCall r1, float r2, short r3, char r4, byte r5) {
            goto L1a
        L4:
            return
        L5:
            goto L21
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
        L14:
            int r2 = r0 * r1
            goto L2a
        L1a:
            goto L5
        L1d:
            goto L24
        L21:
            goto L1d
        L24:
            r0 = 42
            goto Le
        L2a:
            int r3 = r2 + r1
            goto L9
    }

    public static void STrUpQFezMTVnSem(com.google.android.gms.internal.location.zzda r0, com.google.android.gms.common.api.internal.TaskApiCall r1, short r2, char r3, byte r4, float r5) {
            goto L26
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        La:
            r0 = 42
            goto L4
        L10:
            return
        L11:
            goto L2d
        L15:
            int r3 = r2 + r1
            goto L1b
        L1b:
            double r0 = (double) r3
            goto L10
        L20:
            int r2 = r0 * r1
            goto L15
        L26:
            goto L11
        L29:
            goto La
        L2d:
            goto L29
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall SnvrTNmFjGZtOqrs(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1) {
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

    public static void SnvrTNmFjGZtOqrs(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, byte r1, float r2, java.lang.string r3, short r4) {
            goto L1a
        L4:
            return
        L5:
            goto L21
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L15:
            double r0 = (double) r3
            goto L4
        L1a:
            goto L5
        L1d:
            goto L9
        L21:
            goto L1d
        L24:
            int r3 = r2 + r1
            goto L15
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void SnvrTNmFjGZtOqrs(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, java.lang.string r1, byte r2, float r3, short r4) {
            goto L29
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L20
        L14:
            r0 = 42
            goto L1a
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L20:
            goto L2c
        L23:
            int r2 = r0 * r1
            goto L9
        L29:
            goto L10
        L2c:
            goto L14
    }

    public static void SnvrTNmFjGZtOqrs(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, short r1, byte r2, java.lang.string r3, float r4) {
            goto Lf
        L4:
            return
        L5:
            goto L28
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        Lf:
            goto L5
        L12:
            goto L16
        L16:
            r0 = 42
            goto L9
        L1c:
            int r2 = r0 * r1
            goto L22
        L22:
            int r3 = r2 + r1
            goto L2b
        L28:
            goto L12
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder BqbpYfsPUqmzZrAG(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1, int r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = r1.setMethodKey(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void BqbpYfsPUqmzZrAG(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, char r2, byte r3, float r4, short r5) {
            goto L13
        L4:
            goto L16
        L7:
            int r3 = r2 + r1
            goto L20
        Ld:
            int r2 = r0 * r1
            goto L7
        L13:
            goto L2c
        L16:
            goto L25
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L20:
            double r0 = (double) r3
            goto L2b
        L25:
            r0 = 42
            goto L1a
        L2b:
            return
        L2c:
            goto L4
    }

    public static void BqbpYfsPUqmzZrAG(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, short r2, byte r3, char r4, float r5) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        La:
            goto L27
        Ld:
            int r2 = r0 * r1
            goto L18
        L13:
            return
        L14:
            goto La
        L18:
            int r3 = r2 + r1
            goto L2b
        L1e:
            r0 = 42
            goto L4
        L24:
            goto L14
        L27:
            goto L1e
        L2b:
            double r0 = (double) r3
            goto L13
    }

    public static void BqbpYfsPUqmzZrAG(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, short r2, float r3, char r4, byte r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L22
        L9:
            goto L23
        Lc:
            goto L2a
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1c
        L16:
            int r3 = r2 + r1
            goto L4
        L1c:
            int r2 = r0 * r1
            goto L16
        L22:
            return
        L23:
            goto L27
        L27:
            goto Lc
        L2a:
            r0 = 42
            goto L10
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall CAkFxjxtBnlhXFlT(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.gms.common.api.internal.TaskApiCall r0 = r1.build()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void CAkFxjxtBnlhXFlT(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, float r2, java.lang.string r3, bool r4) {
            goto L23
        L4:
            goto L26
        L7:
            int r2 = r0 * r1
            goto L1d
        Ld:
            return
        Le:
            goto L4
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L18:
            double r0 = (double) r3
            goto Ld
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            goto Le
        L26:
            goto L2a
        L2a:
            r0 = 42
            goto L12
    }

    public static void CAkFxjxtBnlhXFlT(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, bool r2, float r3, java.lang.string r4) {
            goto L4
        L4:
            goto L1e
        L7:
            goto L11
        Lb:
            int r3 = r2 + r1
            goto L28
        L11:
            r0 = 42
            goto L22
        L17:
            int r2 = r0 * r1
            goto Lb
        L1d:
            return
        L1e:
            goto L2d
        L22:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        L28:
            double r0 = (double) r3
            goto L1d
        L2d:
            goto L7
    }

    public static void CAkFxjxtBnlhXFlT(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, bool r1, float r2, java.lang.string r3, int r4) {
            goto L12
        L4:
            goto L15
        L7:
            return
        L8:
            goto L4
        Lc:
            int r2 = r0 * r1
            goto L19
        L12:
            goto L8
        L15:
            goto L24
        L19:
            int r3 = r2 + r1
            goto L1f
        L1f:
            double r0 = (double) r3
            goto L7
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lc
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder DsTcZnYpycVHknbZ(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1, int r2) {
            goto Lc
        L4:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = r1.setMethodKey(r2)
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

    public static void DsTcZnYpycVHknbZ(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, char r2, int r3, short r4, bool r5) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L10:
            goto L18
        L13:
            goto L1f
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto L13
        L1f:
            r0 = 42
            goto La
        L25:
            int r2 = r0 * r1
            goto L4
        L2b:
            double r0 = (double) r3
            goto L17
    }

    public static void DsTcZnYpycVHknbZ(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, int r2, char r3, bool r4, short r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L1b
        Lb:
            return
        Lc:
            goto L2d
        L10:
            double r0 = (double) r3
            goto Lb
        L15:
            int r3 = r2 + r1
            goto L10
        L1b:
            r0 = 42
            goto L21
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L27:
            int r2 = r0 * r1
            goto L15
        L2d:
            goto L7
    }

    public static void DsTcZnYpycVHknbZ(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, int r1, short r2, char r3, bool r4, int r5) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            int r2 = r0 * r1
            goto L24
        Lf:
            goto L20
        L12:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L18:
            return
        L19:
            goto Lf
        L1d:
            goto L19
        L20:
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r0 = 42
            goto L12
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder GODYURRcHpIQcZwd(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1, com.google.android.gms.common.api.internal.RemoteCall r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = r1.run(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void GODYURRcHpIQcZwd(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, byte r2, java.lang.string r3, float r4, short r5) {
            goto L4
        L4:
            goto L26
        L7:
            goto L2a
        Lb:
            int r3 = r2 + r1
            goto L1a
        L11:
            goto L7
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1f
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            int r2 = r0 * r1
            goto Lb
        L25:
            return
        L26:
            goto L11
        L2a:
            r0 = 42
            goto L14
    }

    public static void GODYURRcHpIQcZwd(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, byte r2, java.lang.string r3, short r4, float r5) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L1e
        L10:
            goto Lc
        L13:
            int r3 = r2 + r1
            goto L19
        L19:
            double r0 = (double) r3
            goto L4
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r2 = r0 * r1
            goto L13
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void GODYURRcHpIQcZwd(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, float r2, java.lang.string r3, byte r4, short r5) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1c
        L9:
            r0 = 42
            goto L2a
        Lf:
            goto L1d
        L12:
            goto L9
        L16:
            int r2 = r0 * r1
            goto L21
        L1c:
            return
        L1d:
            goto L27
        L21:
            int r3 = r2 + r1
            goto L4
        L27:
            goto L12
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder GPrvfZChfoSuWmpf() {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = com.google.android.gms.common.api.internal.TaskApiCall.builder()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void GPrvfZChfoSuWmpf(byte r0, java.lang.string r1, bool r2, float r3) {
            goto L1d
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            goto L20
        Ld:
            r0 = 42
            goto L24
        L13:
            return
        L14:
            goto La
        L18:
            double r0 = (double) r3
            goto L13
        L1d:
            goto L14
        L20:
            goto Ld
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L18
    }

    public static void GPrvfZChfoSuWmpf(byte r0, bool r1, float r2, java.lang.string r3) {
            goto L26
        L4:
            int r3 = r2 + r1
            goto L1b
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L10:
            return
        L11:
            goto L2d
        L15:
            int r2 = r0 * r1
            goto L4
        L1b:
            double r0 = (double) r3
            goto L10
        L20:
            r0 = 42
            goto La
        L26:
            goto L11
        L29:
            goto L20
        L2d:
            goto L29
    }

    public static void GPrvfZChfoSuWmpf(float r0, byte r1, java.lang.string r2, bool r3) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            goto L27
        L12:
            r0 = 42
            goto L4
        L18:
            int r2 = r0 * r1
            goto L1e
        L1e:
            int r3 = r2 + r1
            goto La
        L24:
            goto L2c
        L27:
            goto L12
        L2b:
            return
        L2c:
            goto Lf
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder HSKijirROSJMqrxo(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1, com.google.android.gms.common.Feature[] r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = r1.setFeatures(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void HSKijirROSJMqrxo(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.Feature[] r1, byte r2, float r3, int r4, bool r5) {
            goto L17
        L4:
            goto L1a
        L7:
            double r0 = (double) r3
            goto L12
        Lc:
            r0 = 42
            goto L1e
        L12:
            return
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            goto Lc
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
        L24:
            int r2 = r0 * r1
            goto L2a
        L2a:
            int r3 = r2 + r1
            goto L7
    }

    public static void HSKijirROSJMqrxo(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.Feature[] r1, int r2, bool r3, float r4, byte r5) {
            goto L29
        L4:
            double r0 = (double) r3
            goto L9
        L9:
            return
        La:
            goto L14
        Le:
            int r3 = r2 + r1
            goto L4
        L14:
            goto L2c
        L17:
            r0 = 42
            goto L23
        L1d:
            int r2 = r0 * r1
            goto Le
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1d
        L29:
            goto La
        L2c:
            goto L17
    }

    public static void HSKijirROSJMqrxo(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.Feature[] r1, bool r2, int r3, byte r4, float r5) {
            goto L10
        L4:
            r0 = 42
            goto L27
        La:
            int r2 = r0 * r1
            goto L1c
        L10:
            goto L18
        L13:
            goto L4
        L17:
            return
        L18:
            goto L2d
        L1c:
            int r3 = r2 + r1
            goto L22
        L22:
            double r0 = (double) r3
            goto L17
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L2d:
            goto L13
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder PPXqkvRyOcLrIpzT() {
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
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = com.google.android.gms.common.api.internal.TaskApiCall.builder()
            goto Lb
        L18:
            goto L7
    }

    public static void PPXqkvRyOcLrIpzT(float r0, bool r1, char r2, short r3) {
            goto L17
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L14
        L14:
            goto L1a
        L17:
            goto L10
        L1a:
            goto L24
        L1e:
            int r2 = r0 * r1
            goto L9
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
    }

    public static void PPXqkvRyOcLrIpzT(short r0, bool r1, float r2, char r3) {
            goto L1d
        L4:
            double r0 = (double) r3
            goto L12
        L9:
            goto L20
        Lc:
            r0 = 42
            goto L17
        L12:
            return
        L13:
            goto L9
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1d:
            goto L13
        L20:
            goto Lc
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void PPXqkvRyOcLrIpzT(bool r0, short r1, char r2, float r3) {
            goto L18
        L4:
            goto L1b
        L7:
            int r2 = r0 * r1
            goto Ld
        Ld:
            int r3 = r2 + r1
            goto L2b
        L13:
            return
        L14:
            goto L4
        L18:
            goto L14
        L1b:
            goto L1f
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L2b:
            double r0 = (double) r3
            goto L13
    }

    public static com.google.android.gms.common.api.internal.TaskApiCall.Builder UvkNIoFhWomhrtqm(com.google.android.gms.common.api.internal.TaskApiCall.Builder r1, com.google.android.gms.common.api.internal.RemoteCall r2) {
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
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = r1.run(r2)
            goto Le
    }

    public static void UvkNIoFhWomhrtqm(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, float r2, int r3, char r4, short r5) {
            goto L12
        L4:
            goto L15
        L7:
            return
        L8:
            goto L4
        Lc:
            int r3 = r2 + r1
            goto L25
        L12:
            goto L8
        L15:
            goto L2a
        L19:
            int r2 = r0 * r1
            goto Lc
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            double r0 = (double) r3
            goto L7
        L2a:
            r0 = 42
            goto L1f
    }

    public static void UvkNIoFhWomhrtqm(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, int r2, float r3, short r4, char r5) {
            goto La
        L4:
            r0 = 42
            goto L1f
        La:
            goto L18
        Ld:
            goto L4
        L11:
            int r2 = r0 * r1
            goto L2a
        L17:
            return
        L18:
            goto L1c
        L1c:
            goto Ld
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L11
        L25:
            double r0 = (double) r3
            goto L17
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void UvkNIoFhWomhrtqm(com.google.android.gms.common.api.internal.TaskApiCall.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, int r2, short r3, char r4, float r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L24
        Lb:
            return
        Lc:
            goto L1c
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L16
        L16:
            int r2 = r0 * r1
            goto L2a
        L1c:
            goto L7
        L1f:
            double r0 = (double) r3
            goto Lb
        L24:
            r0 = 42
            goto L10
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    @Override // com.google.android.gms.location.HashSettingsClient
    public readonly com.google.android.gms.tasks.Task<com.google.android.gms.location.LocationHashSettingsResponse> CheckLocationHashSettings(com.google.android.gms.location.LocationHashSettingsRequest r3) {
            r2 = this;
            goto L72
        L4:
            r1.<init>(r3)
            goto L6a
        Lb:
            goto L24
        Le:
            goto L52
        L12:
            int r0 = r0 % r1
            goto L18
        L18:
            if (r0 <= 0) goto L1d
            goto L24
        L1d:
            goto L21
        L21:
            goto L5e
        L24:
            goto L62
        L28:
            int r0 = r0 + r1
            goto L12
        L2e:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r3 = bqbpYfsPUqmzZrAG(r3, r0)
            goto L3d
        L36:
            r0 = 14
            goto L4b
        L3d:
            com.google.android.gms.common.api.internal.TaskApiCall r3 = SnvrTNmFjGZtOqrs(r3)
            goto L55
        L45:
            com.google.android.gms.internal.location.zzdb r1 = new com.google.android.gms.internal.location.zzdb
            goto L4
        L4b:
            r1 = 32
            goto L28
        L52:
            goto L75
        L55:
            com.google.android.gms.tasks.Task r2 = STrUpQFezMTVnSem(r2, r3)
            goto L5d
        L5d:
            return r2
        L5e:
            goto Lb
        L62:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = pPXqkvRyOcLrIpzT()
            goto L45
        L6a:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r3 = gODYURRcHpIQcZwd(r0, r1)
            goto L79
        L72:
            goto Le
        L75:
            goto L36
        L79:
            r0 = 2426(0x97a, float:3.4E-42)
            goto L2e
    }

    @Override // com.google.android.gms.location.HashSettingsClient
    public readonly com.google.android.gms.tasks.Task<java.lang.bool> IsGoogleLocationAccuracyEnabled() {
            r4 = this;
            goto L92
        L4:
            r1 = 2444(0x98c, float:3.425E-42)
            goto L19
        La:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = hSKijirROSJMqrxo(r0, r1)
            goto L31
        L12:
            r1 = 6
            goto L39
        L19:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = dsTcZnYpycVHknbZ(r0, r1)
            goto L67
        L21:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = gPrvfZChfoSuWmpf()
            goto L61
        L29:
            com.google.android.gms.common.api.internal.TaskApiCall$Builder r0 = uvkNIoFhWomhrtqm(r0, r1)
            goto L4
        L31:
            com.google.android.gms.common.api.internal.TaskApiCall r0 = cAkFxjxtBnlhXFlT(r0)
            goto L4d
        L39:
            int r0 = r0 + r1
            goto L55
        L3f:
            return r4
        L40:
            goto L78
        L44:
            if (r0 <= 0) goto L49
            goto L82
        L49:
            goto L7f
        L4d:
            com.google.android.gms.tasks.Task r4 = PfSUsHikibKHwXNB(r4, r0)
            goto L3f
        L55:
            int r0 = r0 % r1
            goto L44
        L5b:
            com.google.android.gms.common.Feature[] r1 = new com.google.android.gms.common.Feature[r1]
            goto L6c
        L61:
            com.google.android.gms.internal.location.zzdc r1 = com.google.android.gms.internal.location.zzdc.zza
            goto L29
        L67:
            r1 = 1
            goto L5b
        L6c:
            r2 = 0
            goto L86
        L71:
            r0 = 9
            goto L12
        L78:
            goto L82
        L7b:
            goto L99
        L7f:
            goto L40
        L82:
            goto L21
        L86:
            com.google.android.gms.common.Feature r3 = com.google.android.gms.location.zzo.zzm
            goto L8c
        L8c:
            r1[r2] = r3
            goto La
        L92:
            goto L7b
        L95:
            goto L71
        L99:
            goto L95
    }
}

