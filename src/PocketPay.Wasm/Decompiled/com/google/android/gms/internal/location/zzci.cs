namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes22.dex */
public readonly class zzci : com.google.android.gms.common.api.GoogleApi : com.google.android.gms.location.FusedOrientationProviderClient {
    public static readonly /* synthetic */ int zza = 0;

    public zzci(android.app.object r4) {
            r3 = this;
            goto L2c
        L4:
            com.google.android.gms.common.api.Api r0 = com.google.android.gms.internal.location.zzbi.zzb
            goto L40
        La:
            r1 = 16
            goto L33
        L11:
            goto L28
        L14:
            goto L46
        L18:
            r0 = 5
            goto La
        L1f:
            int r0 = r0 % r1
            goto L49
        L25:
            goto L53
        L28:
            goto L4
        L2c:
            goto L14
        L2f:
            goto L18
        L33:
            int r0 = r0 + r1
            goto L1f
        L39:
            r3.<init>(r4, r0, r1, r2)
            goto L52
        L40:
            com.google.android.gms.common.api.Api$ApiOptions$NoOptions r1 = com.google.android.gms.common.api.Api.ApiOptions.NO_OPTIONS
            goto L57
        L46:
            goto L2f
        L49:
            if (r0 <= 0) goto L4e
            goto L28
        L4e:
            goto L25
        L52:
            return
        L53:
            goto L11
        L57:
            com.google.android.gms.common.api.GoogleApi$HashSettings r2 = com.google.android.gms.common.api.GoogleApi.HashSettings.DEFAULT_SETTINGS
            goto L39
    }

    public zzci(android.content.object r4) {
            r3 = this;
            goto L3d
        L4:
            if (r0 <= 0) goto L9
            goto L21
        L9:
            goto L1e
        Ld:
            goto L21
        L10:
            goto L14
        L14:
            goto L40
        L17:
            r1 = 19
            goto L25
        L1e:
            goto L32
        L21:
            goto L2b
        L25:
            int r0 = r0 + r1
            goto L57
        L2b:
            com.google.android.gms.common.api.Api r0 = com.google.android.gms.internal.location.zzbi.zzb
            goto L51
        L31:
            return
        L32:
            goto Ld
        L36:
            r3.<init>(r4, r0, r1, r2)
            goto L31
        L3d:
            goto L10
        L40:
            goto L4a
        L44:
            com.google.android.gms.common.api.GoogleApi$HashSettings r2 = com.google.android.gms.common.api.GoogleApi.HashSettings.DEFAULT_SETTINGS
            goto L36
        L4a:
            r0 = 9
            goto L17
        L51:
            com.google.android.gms.common.api.Api$ApiOptions$NoOptions r1 = com.google.android.gms.common.api.Api.ApiOptions.NO_OPTIONS
            goto L44
        L57:
            int r0 = r0 % r1
            goto L4
    }

    public static com.google.android.gms.common.api.internal.RegistrationMethods AjjOteBuqZYyNQYj(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r1) {
            goto L14
        L4:
            com.google.android.gms.common.api.internal.RegistrationMethods r0 = r1.build()
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

    public static void AjjOteBuqZYyNQYj(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, byte r1, bool r2, java.lang.string r3, short r4) {
            goto La
        L4:
            int r2 = r0 * r1
            goto L1f
        La:
            goto L2c
        Ld:
            goto L25
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L17:
            double r0 = (double) r3
            goto L2b
        L1c:
            goto Ld
        L1f:
            int r3 = r2 + r1
            goto L17
        L25:
            r0 = 42
            goto L11
        L2b:
            return
        L2c:
            goto L1c
    }

    public static void AjjOteBuqZYyNQYj(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, java.lang.string r1, bool r2, short r3, byte r4) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L18
        L9:
            r0 = 42
            goto L1d
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            goto L26
        L18:
            return
        L19:
            goto L15
        L1d:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L23:
            goto L19
        L26:
            goto L9
        L2a:
            int r2 = r0 * r1
            goto Lf
    }

    public static void AjjOteBuqZYyNQYj(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, short r1, java.lang.string r2, byte r3, bool r4) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1a
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L26
        L14:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1a:
            int r3 = r2 + r1
            goto La
        L20:
            r0 = 42
            goto L14
        L26:
            goto L2c
        L29:
            goto L10
        L2c:
            goto L20
    }

    public static com.google.android.gms.common.api.internal.RegistrationMethods.Builder DxhNgsdDudOrGqGB(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r1, com.google.android.gms.common.api.internal.RemoteCall r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.android.gms.common.api.internal.RegistrationMethods$Builder r0 = r1.unregister(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void DxhNgsdDudOrGqGB(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, float r2, short r3, int r4, java.lang.string r5) {
            goto Ld
        L4:
            goto L10
        L7:
            int r2 = r0 * r1
            goto L2a
        Ld:
            goto L15
        L10:
            goto L19
        L14:
            return
        L15:
            goto L4
        L19:
            r0 = 42
            goto L1f
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L25:
            double r0 = (double) r3
            goto L14
        L2a:
            int r3 = r2 + r1
            goto L25
    }

    public static void DxhNgsdDudOrGqGB(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, java.lang.string r2, float r3, short r4, int r5) {
            goto L26
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
        L10:
            int r2 = r0 * r1
            goto L20
        L16:
            return
        L17:
            goto L2d
        L1b:
            double r0 = (double) r3
            goto L16
        L20:
            int r3 = r2 + r1
            goto L1b
        L26:
            goto L17
        L29:
            goto L4
        L2d:
            goto L29
    }

    public static void DxhNgsdDudOrGqGB(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, short r2, java.lang.string r3, int r4, float r5) {
            goto L13
        L4:
            int r3 = r2 + r1
            goto L26
        La:
            goto L16
        Ld:
            r0 = 42
            goto L20
        L13:
            goto L2c
        L16:
            goto Ld
        L1a:
            int r2 = r0 * r1
            goto L4
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L26:
            double r0 = (double) r3
            goto L2b
        L2b:
            return
        L2c:
            goto La
    }

    public static com.google.android.gms.common.api.internal.RegistrationMethods.Builder JBzcSmXxxDuwQVkb(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r1, com.google.android.gms.common.api.internal.RemoteCall r2) {
            goto Lc
        L4:
            com.google.android.gms.common.api.internal.RegistrationMethods$Builder r0 = r1.register(r2)
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

    public static void JBzcSmXxxDuwQVkb(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, byte r2, float r3, bool r4, short r5) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L24
        Lb:
            return
        Lc:
            goto L1b
        L10:
            double r0 = (double) r3
            goto Lb
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1b:
            goto L7
        L1e:
            int r3 = r2 + r1
            goto L10
        L24:
            r0 = 42
            goto L15
        L2a:
            int r2 = r0 * r1
            goto L1e
    }

    public static void JBzcSmXxxDuwQVkb(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, byte r2, short r3, float r4, bool r5) {
            goto L24
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L10:
            goto L27
        L13:
            r0 = 42
            goto La
        L19:
            int r2 = r0 * r1
            goto L4
        L1f:
            return
        L20:
            goto L10
        L24:
            goto L20
        L27:
            goto L13
        L2b:
            double r0 = (double) r3
            goto L1f
    }

    public static void JBzcSmXxxDuwQVkb(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, com.google.android.gms.common.api.internal.RemoteCall r1, bool r2, float r3, short r4, byte r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L2c
        La:
            goto L1f
        Le:
            double r0 = (double) r3
            goto L2b
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto L25
        L19:
            int r3 = r2 + r1
            goto Le
        L1f:
            r0 = 42
            goto L13
        L25:
            int r2 = r0 * r1
            goto L19
        L2b:
            return
        L2c:
            goto L4
    }

    public static com.google.android.gms.tasks.Task QNJQGpbiKAHWzwUf(com.google.android.gms.internal.location.zzci r1, com.google.android.gms.common.api.internal.RegistrationMethods r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.gms.tasks.Task r0 = r1.doRegisterEventListener(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void QNJQGpbiKAHWzwUf(com.google.android.gms.internal.location.zzci r0, com.google.android.gms.common.api.internal.RegistrationMethods r1, int r2, float r3, java.lang.string r4, char r5) {
            goto Ld
        L4:
            int r3 = r2 + r1
            goto L1a
        La:
            goto L10
        Ld:
            goto L26
        L10:
            goto L1f
        L14:
            int r2 = r0 * r1
            goto L4
        L1a:
            double r0 = (double) r3
            goto L25
        L1f:
            r0 = 42
            goto L2a
        L25:
            return
        L26:
            goto La
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
    }

    public static void QNJQGpbiKAHWzwUf(com.google.android.gms.internal.location.zzci r0, com.google.android.gms.common.api.internal.RegistrationMethods r1, int r2, java.lang.string r3, float r4, char r5) {
            goto L29
        L4:
            return
        L5:
            goto L14
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L2c
        L17:
            r0 = 42
            goto L9
        L1d:
            int r3 = r2 + r1
            goto Lf
        L23:
            int r2 = r0 * r1
            goto L1d
        L29:
            goto L5
        L2c:
            goto L17
    }

    public static void QNJQGpbiKAHWzwUf(com.google.android.gms.internal.location.zzci r0, com.google.android.gms.common.api.internal.RegistrationMethods r1, java.lang.string r2, char r3, int r4, float r5) {
            goto L1e
        L4:
            goto L21
        L7:
            int r2 = r0 * r1
            goto L25
        Ld:
            return
        Le:
            goto L4
        L12:
            r0 = 42
            goto L18
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L7
        L1e:
            goto Le
        L21:
            goto L12
        L25:
            int r3 = r2 + r1
            goto L2b
        L2b:
            double r0 = (double) r3
            goto Ld
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey TACFVDjyOuvChZjw(java.lang.object r1, java.lang.string r2) {
            goto Lc
        L4:
            com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey r0 = com.google.android.gms.common.api.internal.ListenerHolders.createListenerKey(r1, r2)
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

    public static void TACFVDjyOuvChZjw(java.lang.object r0, java.lang.string r1, char r2, float r3, short r4, java.lang.string r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L27
        La:
            goto L14
        Le:
            int r3 = r2 + r1
            goto L2b
        L14:
            r0 = 42
            goto L20
        L1a:
            int r2 = r0 * r1
            goto Le
        L20:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
        L26:
            return
        L27:
            goto L4
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void TACFVDjyOuvChZjw(java.lang.object r0, java.lang.string r1, char r2, short r3, float r4, java.lang.string r5) {
            goto L21
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            r0 = 42
            goto L15
        Lf:
            int r3 = r2 + r1
            goto L4
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L1b:
            int r2 = r0 * r1
            goto Lf
        L21:
            goto L2c
        L24:
            goto L9
        L28:
            goto L24
        L2b:
            return
        L2c:
            goto L28
    }

    public static void TACFVDjyOuvChZjw(java.lang.object r0, java.lang.string r1, java.lang.string r2, short r3, float r4, char r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L19
        L9:
            goto L1a
        Lc:
            goto L1e
        L10:
            goto Lc
        L13:
            int r2 = r0 * r1
            goto L24
        L19:
            return
        L1a:
            goto L10
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
    }

    public static com.google.android.gms.tasks.Task UCLwpJfKZwcfRYlN(com.google.android.gms.internal.location.zzci r1, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r2, int r3) {
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
            com.google.android.gms.tasks.Task r0 = r1.doUnregisterEventListener(r2, r3)
            goto L4
    }

    public static void UCLwpJfKZwcfRYlN(com.google.android.gms.internal.location.zzci r0, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r1, int r2, char r3, bool r4, float r5, int r6) {
            goto L1e
        L4:
            return
        L5:
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L2b
        Lf:
            goto L21
        L12:
            int r2 = r0 * r1
            goto L9
        L18:
            r0 = 42
            goto L25
        L1e:
            goto L5
        L21:
            goto L18
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L12
        L2b:
            double r0 = (double) r3
            goto L4
    }

    public static void UCLwpJfKZwcfRYlN(com.google.android.gms.internal.location.zzci r0, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r1, int r2, float r3, bool r4, int r5, char r6) {
            goto L18
        L4:
            r0 = 42
            goto L2a
        La:
            int r2 = r0 * r1
            goto L1f
        L10:
            return
        L11:
            goto L15
        L15:
            goto L1b
        L18:
            goto L11
        L1b:
            goto L4
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L10
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
    }

    public static void UCLwpJfKZwcfRYlN(com.google.android.gms.internal.location.zzci r0, com.google.android.gms.common.api.internal.ListenerHolder.ListenerKey r1, int r2, bool r3, float r4, int r5, char r6) {
            goto L12
        L4:
            int r2 = r0 * r1
            goto L19
        La:
            goto L15
        Ld:
            double r0 = (double) r3
            goto L1f
        L12:
            goto L20
        L15:
            goto L24
        L19:
            int r3 = r2 + r1
            goto Ld
        L1f:
            return
        L20:
            goto La
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static com.google.android.gms.common.api.internal.RegistrationMethods.Builder UIRSTxMNrCeuCNOH() {
            goto L14
        L4:
            goto L17
        L7:
            com.google.android.gms.common.api.internal.RegistrationMethods$Builder r0 = com.google.android.gms.common.api.internal.RegistrationMethods.builder()
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

    public static void UIRSTxMNrCeuCNOH(char r0, java.lang.string r1, int r2, short r3) {
            goto Lf
        L4:
            int r2 = r0 * r1
            goto L21
        La:
            double r0 = (double) r3
            goto L16
        Lf:
            goto L17
        L12:
            goto L1b
        L16:
            return
        L17:
            goto L27
        L1b:
            r0 = 42
            goto L2a
        L21:
            int r3 = r2 + r1
            goto La
        L27:
            goto L12
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
    }

    public static void UIRSTxMNrCeuCNOH(java.lang.string r0, char r1, short r2, int r3) {
            goto L10
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L2a
        L10:
            goto L20
        L13:
            goto L24
        L17:
            double r0 = (double) r3
            goto L1f
        L1c:
            goto L13
        L1f:
            return
        L20:
            goto L1c
        L24:
            r0 = 42
            goto L4
        L2a:
            int r3 = r2 + r1
            goto L17
    }

    public static void UIRSTxMNrCeuCNOH(java.lang.string r0, int r1, short r2, char r3) {
            goto Lf
        L4:
            double r0 = (double) r3
            goto L1f
        L9:
            r0 = 42
            goto L19
        Lf:
            goto L20
        L12:
            goto L9
        L16:
            goto L12
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            return
        L20:
            goto L16
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static com.google.android.gms.common.api.internal.RegistrationMethods.Builder YCsMEixnRPdPyXoC(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r1, com.google.android.gms.common.api.internal.ListenerHolder r2) {
            goto L14
        L4:
            com.google.android.gms.common.api.internal.RegistrationMethods$Builder r0 = r1.withHolder(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static void YCsMEixnRPdPyXoC(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, com.google.android.gms.common.api.internal.ListenerHolder r1, int r2, java.lang.string r3, bool r4, char r5) {
            goto L4
        L4:
            goto L1d
        L7:
            goto L10
        Lb:
            double r0 = (double) r3
            goto L1c
        L10:
            r0 = 42
            goto L24
        L16:
            int r3 = r2 + r1
            goto Lb
        L1c:
            return
        L1d:
            goto L21
        L21:
            goto L7
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L16
    }

    public static void YCsMEixnRPdPyXoC(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, com.google.android.gms.common.api.internal.ListenerHolder r1, java.lang.string r2, int r3, char r4, bool r5) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L13
        L9:
            goto L14
        Lc:
            goto L1e
        L10:
            goto Lc
        L13:
            return
        L14:
            goto L10
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1e:
            r0 = 42
            goto L18
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    public static void YCsMEixnRPdPyXoC(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, com.google.android.gms.common.api.internal.ListenerHolder r1, bool r2, char r3, int r4, java.lang.string r5) {
            goto La
        L4:
            int r3 = r2 + r1
            goto L11
        La:
            goto L1d
        Ld:
            goto L16
        L11:
            double r0 = (double) r3
            goto L1c
        L16:
            r0 = 42
            goto L27
        L1c:
            return
        L1d:
            goto L2d
        L21:
            int r2 = r0 * r1
            goto L4
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L21
        L2d:
            goto Ld
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder FVxxgDBXrpUAPlWH(java.lang.object r1, java.util.concurrent.Executor r2, java.lang.string r3) {
            goto Lc
        L4:
            com.google.android.gms.common.api.internal.ListenerHolder r0 = com.google.android.gms.common.api.internal.ListenerHolders.createListenerHolder(r1, r2, r3)
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

    public static void FVxxgDBXrpUAPlWH(java.lang.object r0, java.util.concurrent.Executor r1, java.lang.string r2, char r3, int r4, java.lang.string r5, byte r6) {
            goto L18
        L4:
            return
        L5:
            goto L15
        L9:
            int r2 = r0 * r1
            goto Lf
        Lf:
            int r3 = r2 + r1
            goto L1f
        L15:
            goto L1b
        L18:
            goto L5
        L1b:
            goto L24
        L1f:
            double r0 = (double) r3
            goto L4
        L24:
            r0 = 42
            goto L2a
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
    }

    public static void FVxxgDBXrpUAPlWH(java.lang.object r0, java.util.concurrent.Executor r1, java.lang.string r2, char r3, java.lang.string r4, int r5, byte r6) {
            goto L4
        L4:
            goto L27
        L7:
            goto L11
        Lb:
            int r2 = r0 * r1
            goto L20
        L11:
            r0 = 42
            goto L17
        L17:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L1d:
            goto L7
        L20:
            int r3 = r2 + r1
            goto L2b
        L26:
            return
        L27:
            goto L1d
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void FVxxgDBXrpUAPlWH(java.lang.object r0, java.util.concurrent.Executor r1, java.lang.string r2, java.lang.string r3, int r4, char r5, byte r6) {
            goto L21
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        La:
            int r3 = r2 + r1
            goto L10
        L10:
            double r0 = (double) r3
            goto L28
        L15:
            int r2 = r0 * r1
            goto La
        L1b:
            r0 = 42
            goto L4
        L21:
            goto L29
        L24:
            goto L1b
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L24
    }

    public static com.google.android.gms.common.api.internal.RegistrationMethods.Builder IqkweJtSvJCiuChJ(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r1, int r2) {
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
            com.google.android.gms.common.api.internal.RegistrationMethods$Builder r0 = r1.setMethodKey(r2)
            goto L4
    }

    public static void IqkweJtSvJCiuChJ(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, int r1, byte r2, java.lang.string r3, int r4, bool r5) {
            goto L10
        L4:
            int r3 = r2 + r1
            goto L1c
        La:
            int r2 = r0 * r1
            goto L4
        L10:
            goto L18
        L13:
            goto L2a
        L17:
            return
        L18:
            goto L27
        L1c:
            double r0 = (double) r3
            goto L17
        L21:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L27:
            goto L13
        L2a:
            r0 = 42
            goto L21
    }

    public static void IqkweJtSvJCiuChJ(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, int r1, byte r2, bool r3, java.lang.string r4, int r5) {
            goto L17
        L4:
            double r0 = (double) r3
            goto Lc
        L9:
            goto L1a
        Lc:
            return
        Ld:
            goto L9
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        L17:
            goto Ld
        L1a:
            goto L2a
        L1e:
            int r2 = r0 * r1
            goto L24
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r0 = 42
            goto L11
    }

    public static void IqkweJtSvJCiuChJ(com.google.android.gms.common.api.internal.RegistrationMethods.Builder r0, int r1, bool r2, java.lang.string r3, int r4, byte r5) {
            goto L29
        L4:
            r0 = 42
            goto L18
        La:
            int r2 = r0 * r1
            goto L1e
        L10:
            double r0 = (double) r3
            goto L24
        L15:
            goto L2c
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        L1e:
            int r3 = r2 + r1
            goto L10
        L24:
            return
        L25:
            goto L15
        L29:
            goto L25
        L2c:
            goto L4
    }

    public static com.google.android.gms.tasks.Task PDvTgaqmIfchuMHD(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.Continuation r3) {
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
            com.google.android.gms.tasks.Task r0 = r1.continueWith(r2, r3)
            goto L4
        L18:
            goto Lc
    }

    public static void PDvTgaqmIfchuMHD(com.google.android.gms.tasks.Task r0, java.util.concurrent.Executor r1, com.google.android.gms.tasks.Continuation r2, float r3, java.lang.string r4, int r5, bool r6) {
            goto L13
        L4:
            r0 = 42
            goto La
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L20
        L10:
            goto L16
        L13:
            goto L27
        L16:
            goto L4
        L1a:
            int r3 = r2 + r1
            goto L2b
        L20:
            int r2 = r0 * r1
            goto L1a
        L26:
            return
        L27:
            goto L10
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void PDvTgaqmIfchuMHD(com.google.android.gms.tasks.Task r0, java.util.concurrent.Executor r1, com.google.android.gms.tasks.Continuation r2, float r3, bool r4, java.lang.string r5, int r6) {
            goto L24
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1e
        La:
            double r0 = (double) r3
            goto L2b
        Lf:
            r0 = 42
            goto L4
        L15:
            goto L27
        L18:
            int r3 = r2 + r1
            goto La
        L1e:
            int r2 = r0 * r1
            goto L18
        L24:
            goto L2c
        L27:
            goto Lf
        L2b:
            return
        L2c:
            goto L15
    }

    public static void PDvTgaqmIfchuMHD(com.google.android.gms.tasks.Task r0, java.util.concurrent.Executor r1, com.google.android.gms.tasks.Continuation r2, bool r3, float r4, java.lang.string r5, int r6) {
            goto L7
        L4:
            goto La
        L7:
            goto L14
        La:
            goto L1e
        Le:
            double r0 = (double) r3
            goto L13
        L13:
            return
        L14:
            goto L4
        L18:
            int r3 = r2 + r1
            goto Le
        L1e:
            r0 = 42
            goto L24
        L24:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L2a:
            int r2 = r0 * r1
            goto L18
    }

    @Override // com.google.android.gms.common.api.GoogleApi
    protected readonly java.lang.string GetApiFallbackAttributionTag(android.content.object r1) {
            r0 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L15
        L10:
            r0 = 0
            goto Lb
        L15:
            goto L7
    }

    @Override // com.google.android.gms.location.FusedOrientationProviderClient
    public readonly com.google.android.gms.tasks.Task<java.lang.void> RemoveOrientationUpdates(com.google.android.gms.location.DeviceOrientationListener r2) {
            r1 = this;
            goto L9
        L4:
            return r1
        L5:
            goto L22
        L9:
            goto L5
        Lc:
            goto L1c
        L10:
            com.google.android.gms.internal.location.zzck r0 = com.google.android.gms.internal.location.zzck.zza
            goto L2b
        L16:
            java.lang.string r0 = "DeviceOrientationListener"
            goto L41
        L1c:
            java.lang.Class<com.google.android.gms.location.DeviceOrientationListener> r0 = com.google.android.gms.location.DeviceOrientationListener.class
            goto L16
        L22:
            goto Lc
        L25:
            r0 = 2440(0x988, float:3.419E-42)
            goto L33
        L2b:
            com.google.android.gms.tasks.Task r1 = pDvTgaqmIfchuMHD(r1, r2, r0)
            goto L4
        L33:
            com.google.android.gms.tasks.Task r1 = UCLwpJfKZwcfRYlN(r1, r2, r0)
            goto L3b
        L3b:
            com.google.android.gms.internal.location.zzcm r2 = com.google.android.gms.internal.location.zzcm.zza
            goto L10
        L41:
            com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey r2 = TACFVDjyOuvChZjw(r2, r0)
            goto L25
    }

    @Override // com.google.android.gms.location.FusedOrientationProviderClient
    public readonly com.google.android.gms.tasks.Task<java.lang.void> RequestOrientationUpdates(com.google.android.gms.location.DeviceOrientationRequest r2, java.util.concurrent.Executor r3, com.google.android.gms.location.DeviceOrientationListener r4) {
            r1 = this;
            goto L38
        L4:
            java.lang.string r0 = "DeviceOrientationListener"
            goto L10
        La:
            java.lang.Class<com.google.android.gms.location.DeviceOrientationListener> r0 = com.google.android.gms.location.DeviceOrientationListener.class
            goto L4
        L10:
            com.google.android.gms.common.api.internal.ListenerHolder r3 = fVxxgDBXrpUAPlWH(r4, r3, r0)
            goto L28
        L18:
            com.google.android.gms.tasks.Task r1 = QNJQGpbiKAHWzwUf(r1, r2)
            goto L5b
        L20:
            com.google.android.gms.common.api.internal.RegistrationMethods r2 = AjjOteBuqZYyNQYj(r2)
            goto L18
        L28:
            com.google.android.gms.internal.location.zzcl r4 = new com.google.android.gms.internal.location.zzcl
            goto L70
        L2e:
            r2.<init>(r3)
            goto L77
        L35:
            goto L3b
        L38:
            goto L5c
        L3b:
            goto La
        L3f:
            r3 = 2434(0x982, float:3.411E-42)
            goto L45
        L45:
            com.google.android.gms.common.api.internal.RegistrationMethods$Builder r2 = iqkweJtSvJCiuChJ(r2, r3)
            goto L20
        L4d:
            com.google.android.gms.common.api.internal.RegistrationMethods$Builder r2 = YCsMEixnRPdPyXoC(r2, r3)
            goto L3f
        L55:
            com.google.android.gms.internal.location.zzcj r2 = new com.google.android.gms.internal.location.zzcj
            goto L2e
        L5b:
            return r1
        L5c:
            goto L35
        L60:
            com.google.android.gms.common.api.internal.RegistrationMethods$Builder r4 = JBzcSmXxxDuwQVkb(r0, r4)
            goto L68
        L68:
            com.google.android.gms.common.api.internal.RegistrationMethods$Builder r2 = DxhNgsdDudOrGqGB(r4, r2)
            goto L4d
        L70:
            r4.<init>(r3, r2)
            goto L55
        L77:
            com.google.android.gms.common.api.internal.RegistrationMethods$Builder r0 = UIRSTxMNrCeuCNOH()
            goto L60
    }
}

