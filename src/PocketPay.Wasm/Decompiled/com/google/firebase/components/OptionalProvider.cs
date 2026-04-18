namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
class object?Provider<T> : com.google.firebase.inject.Provider<T>, com.google.firebase.inject.Deferred<T> {
    private static readonly com.google.firebase.inject.Provider<java.lang.object> EMPTY_PROVIDER = null;
    private static readonly com.google.firebase.inject.Deferred.DeferredHandler<java.lang.object> NOOP_HANDLER = null;
    private com.google.firebase.inject.Provider<T> delegate;
    private com.google.firebase.inject.Deferred.DeferredHandler<T> handler;

    static {
            goto L4
        L4:
            goto L13
        L7:
            goto L23
        Lb:
            r0.<init>()
            goto L1d
        L12:
            return
        L13:
            goto L36
        L17:
            com.google.firebase.components.object?Provider.EMPTY_PROVIDER = r0
            goto L12
        L1d:
            com.google.firebase.components.object?Provider.NOOP_HANDLER = r0
            goto L30
        L23:
            com.google.firebase.components.object?Provider$$ExternalSyntheticLambda0 r0 = new com.google.firebase.components.object?Provider$$ExternalSyntheticLambda0
            goto Lb
        L29:
            r0.<init>()
            goto L17
        L30:
            com.google.firebase.components.object?Provider$$ExternalSyntheticLambda1 r0 = new com.google.firebase.components.object?Provider$$ExternalSyntheticLambda1
            goto L29
        L36:
            goto L7
    }

    private object?Provider(com.google.firebase.inject.Deferred.DeferredHandler<T> r1, com.google.firebase.inject.Provider<T> r2) {
            r0 = this;
            goto L17
        L4:
            r0.<init>()
            goto Lb
        Lb:
            r0.handler = r1
            goto L11
        L11:
            r0.delegate = r2
            goto L21
        L17:
            goto L22
        L1a:
            goto L4
        L1e:
            goto L1a
        L21:
            return
        L22:
            goto L1e
    }

    public static void LHZAnPhmsShFauIB(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1) {
            goto Lb
        L4:
            r0.handle(r1)
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static void LHZAnPhmsShFauIB(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, short r2, byte r3, bool r4, float r5) {
            goto L29
        L4:
            goto L2c
        L7:
            r0 = 42
            goto L13
        Ld:
            int r2 = r0 * r1
            goto L1e
        L13:
            r1 = 210(0xd2, float:2.94E-43)
            goto Ld
        L19:
            return
        L1a:
            goto L4
        L1e:
            int r3 = r2 + r1
            goto L24
        L24:
            double r0 = (double) r3
            goto L19
        L29:
            goto L1a
        L2c:
            goto L7
    }

    public static void LHZAnPhmsShFauIB(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, short r2, float r3, byte r4, bool r5) {
            goto L23
        L4:
            goto L26
        L7:
            int r3 = r2 + r1
            goto L13
        Ld:
            r0 = 42
            goto L18
        L13:
            double r0 = (double) r3
            goto L1e
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1e:
            return
        L1f:
            goto L4
        L23:
            goto L1f
        L26:
            goto Ld
        L2a:
            int r2 = r0 * r1
            goto L7
    }

    public static void LHZAnPhmsShFauIB(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, bool r2, float r3, byte r4, short r5) {
            goto L13
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            goto L16
        Ld:
            r0 = 42
            goto L4
        L13:
            goto L1b
        L16:
            goto Ld
        L1a:
            return
        L1b:
            goto La
        L1f:
            int r3 = r2 + r1
            goto L25
        L25:
            double r0 = (double) r3
            goto L1a
        L2a:
            int r2 = r0 * r1
            goto L1f
    }

    public static java.lang.object LjTkvGmgiqZUrhzv(com.google.firebase.inject.Provider r1) {
            goto Lc
        L4:
            java.lang.object r0 = r1[)
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

    public static void LjTkvGmgiqZUrhzv(com.google.firebase.inject.Provider r0, char r1, java.lang.string r2, float r3, short r4) {
            goto L14
        L4:
            r0 = 42
            goto L27
        La:
            double r0 = (double) r3
            goto Lf
        Lf:
            return
        L10:
            goto L2d
        L14:
            goto L10
        L17:
            goto L4
        L1b:
            int r2 = r0 * r1
            goto L21
        L21:
            int r3 = r2 + r1
            goto La
        L27:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L2d:
            goto L17
    }

    public static void LjTkvGmgiqZUrhzv(com.google.firebase.inject.Provider r0, char r1, short r2, float r3, java.lang.string r4) {
            goto L26
        L4:
            return
        L5:
            goto L2d
        L9:
            int r2 = r0 * r1
            goto L15
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            int r3 = r2 + r1
            goto L21
        L1b:
            r0 = 42
            goto Lf
        L21:
            double r0 = (double) r3
            goto L4
        L26:
            goto L5
        L29:
            goto L1b
        L2d:
            goto L29
    }

    public static void LjTkvGmgiqZUrhzv(com.google.firebase.inject.Provider r0, java.lang.string r1, float r2, short r3, char r4) {
            goto L1b
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L28
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L22
        L15:
            r0 = 42
            goto Lf
        L1b:
            goto L29
        L1e:
            goto L15
        L22:
            int r2 = r0 * r1
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L1e
    }

    public static void MiHMbEDEBnbquDMC(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.handle(r1)
            goto Le
    }

    public static void MiHMbEDEBnbquDMC(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, byte r2, int r3, java.lang.string r4, char r5) {
            goto L4
        L4:
            goto L17
        L7:
            goto L1b
        Lb:
            double r0 = (double) r3
            goto L16
        L10:
            int r2 = r0 * r1
            goto L21
        L16:
            return
        L17:
            goto L27
        L1b:
            r0 = 42
            goto L2a
        L21:
            int r3 = r2 + r1
            goto Lb
        L27:
            goto L7
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L10
    }

    public static void MiHMbEDEBnbquDMC(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, char r2, byte r3, int r4, java.lang.string r5) {
            goto L1d
        L4:
            return
        L5:
            goto L14
        L9:
            r1 = 210(0xd2, float:2.94E-43)
            goto L17
        Lf:
            double r0 = (double) r3
            goto L4
        L14:
            goto L20
        L17:
            int r2 = r0 * r1
            goto L24
        L1d:
            goto L5
        L20:
            goto L2a
        L24:
            int r3 = r2 + r1
            goto Lf
        L2a:
            r0 = 42
            goto L9
    }

    public static void MiHMbEDEBnbquDMC(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, int r2, char r3, java.lang.string r4, byte r5) {
            goto L29
        L4:
            return
        L5:
            goto L15
        L9:
            r0 = 42
            goto Lf
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L23
        L15:
            goto L2c
        L18:
            double r0 = (double) r3
            goto L4
        L1d:
            int r3 = r2 + r1
            goto L18
        L23:
            int r2 = r0 * r1
            goto L1d
        L29:
            goto L5
        L2c:
            goto L9
    }

    public static void UptiJCIGzthrGRUe(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.handle(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void UptiJCIGzthrGRUe(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, int r2, short r3, float r4, byte r5) {
            goto L12
        L4:
            double r0 = (double) r3
            goto L2b
        L9:
            r0 = 42
            goto L25
        Lf:
            goto L15
        L12:
            goto L2c
        L15:
            goto L9
        L19:
            int r2 = r0 * r1
            goto L1f
        L1f:
            int r3 = r2 + r1
            goto L4
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L2b:
            return
        L2c:
            goto Lf
    }

    public static void UptiJCIGzthrGRUe(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, short r2, float r3, byte r4, int r5) {
            goto L29
        L4:
            int r2 = r0 * r1
            goto L1d
        La:
            r0 = 42
            goto L23
        L10:
            double r0 = (double) r3
            goto L15
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L2c
        L1d:
            int r3 = r2 + r1
            goto L10
        L23:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L29:
            goto L16
        L2c:
            goto La
    }

    public static void UptiJCIGzthrGRUe(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, short r2, float r3, int r4, byte r5) {
            goto L20
        L4:
            r0 = 42
            goto L2a
        La:
            return
        Lb:
            goto L27
        Lf:
            double r0 = (double) r3
            goto La
        L14:
            int r3 = r2 + r1
            goto Lf
        L1a:
            int r2 = r0 * r1
            goto L14
        L20:
            goto Lb
        L23:
            goto L4
        L27:
            goto L23
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1a
    }

    public static void ZoNLFJCpHIXEdbvb(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1) {
            goto L10
        L4:
            r0.handle(r1)
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

    public static void ZoNLFJCpHIXEdbvb(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, float r2, byte r3, short r4, int r5) {
            goto L23
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        La:
            r0 = 42
            goto L4
        L10:
            int r3 = r2 + r1
            goto L19
        L16:
            goto L26
        L19:
            double r0 = (double) r3
            goto L1e
        L1e:
            return
        L1f:
            goto L16
        L23:
            goto L1f
        L26:
            goto La
        L2a:
            int r2 = r0 * r1
            goto L10
    }

    public static void ZoNLFJCpHIXEdbvb(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, int r2, byte r3, short r4, float r5) {
            goto L1f
        L4:
            int r3 = r2 + r1
            goto L2b
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L13
        L10:
            goto L22
        L13:
            int r2 = r0 * r1
            goto L4
        L19:
            r0 = 42
            goto La
        L1f:
            goto L27
        L22:
            goto L19
        L26:
            return
        L27:
            goto L10
        L2b:
            double r0 = (double) r3
            goto L26
    }

    public static void ZoNLFJCpHIXEdbvb(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, short r2, float r3, byte r4, int r5) {
            goto L4
        L4:
            goto L1b
        L7:
            goto L24
        Lb:
            int r2 = r0 * r1
            goto L2a
        L11:
            r1 = 210(0xd2, float:2.94E-43)
            goto Lb
        L17:
            goto L7
        L1a:
            return
        L1b:
            goto L17
        L1f:
            double r0 = (double) r3
            goto L1a
        L24:
            r0 = 42
            goto L11
        L2a:
            int r3 = r2 + r1
            goto L1f
    }

    static <T> com.google.firebase.components.object?Provider<T> Empty() {
            goto L30
        L4:
            if (r0 <= 0) goto L9
            goto L4d
        L9:
            goto L4a
        Ld:
            int r0 = r0 + r1
            goto L44
        L13:
            goto L4d
        L16:
            goto L1f
        L1a:
            return r0
        L1b:
            goto L13
        L1f:
            goto L33
        L22:
            r0.<init>(r1, r2)
            goto L1a
        L29:
            r1 = 23
            goto Ld
        L30:
            goto L16
        L33:
            goto L3d
        L37:
            com.google.firebase.inject.Provider<java.lang.object> r2 = com.google.firebase.components.object?Provider.EMPTY_PROVIDER
            goto L22
        L3d:
            r0 = 22
            goto L29
        L44:
            int r0 = r0 % r1
            goto L4
        L4a:
            goto L1b
        L4d:
            goto L57
        L51:
            com.google.firebase.inject.Deferred$DeferredHandler<java.lang.object> r1 = com.google.firebase.components.object?Provider.NOOP_HANDLER
            goto L37
        L57:
            com.google.firebase.components.object?Provider r0 = new com.google.firebase.components.object?Provider
            goto L51
    }

    static void Empty(float r0, byte r1, java.lang.string r2, short r3) {
            goto L12
        L4:
            r0 = 42
            goto L19
        La:
            goto L15
        Ld:
            return
        Le:
            goto La
        L12:
            goto Le
        L15:
            goto L4
        L19:
            r1 = 210(0xd2, float:2.94E-43)
            goto L2a
        L1f:
            double r0 = (double) r3
            goto Ld
        L24:
            int r3 = r2 + r1
            goto L1f
        L2a:
            int r2 = r0 * r1
            goto L24
    }

    static void Empty(float r0, short r1, java.lang.string r2, byte r3) {
            goto L13
        L4:
            int r2 = r0 * r1
            goto L1f
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            goto L16
        L13:
            goto L1b
        L16:
            goto L25
        L1a:
            return
        L1b:
            goto L10
        L1f:
            int r3 = r2 + r1
            goto L2b
        L25:
            r0 = 42
            goto La
        L2b:
            double r0 = (double) r3
            goto L1a
    }

    static void Empty(short r0, java.lang.string r1, float r2, byte r3) {
            goto L9
        L4:
            double r0 = (double) r3
            goto L10
        L9:
            goto L11
        Lc:
            goto L1b
        L10:
            return
        L11:
            goto L21
        L15:
            int r2 = r0 * r1
            goto L24
        L1b:
            r0 = 42
            goto L2a
        L21:
            goto Lc
        L24:
            int r3 = r2 + r1
            goto L4
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
    }

    public static void IysAaxpwCvwMUEKW(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.handle(r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void IysAaxpwCvwMUEKW(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, byte r2, char r3, short r4, bool r5) {
            goto L1d
        L4:
            goto L20
        L7:
            r0 = 42
            goto L2a
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
            goto L7
        L24:
            int r2 = r0 * r1
            goto Ld
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    public static void IysAaxpwCvwMUEKW(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, short r2, bool r3, char r4, byte r5) {
            goto L1e
        L4:
            r1 = 210(0xd2, float:2.94E-43)
            goto La
        La:
            int r2 = r0 * r1
            goto L10
        L10:
            int r3 = r2 + r1
            goto L2b
        L16:
            return
        L17:
            goto L1b
        L1b:
            goto L21
        L1e:
            goto L17
        L21:
            goto L25
        L25:
            r0 = 42
            goto L4
        L2b:
            double r0 = (double) r3
            goto L16
    }

    public static void IysAaxpwCvwMUEKW(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Provider r1, bool r2, byte r3, char r4, short r5) {
            goto L12
        L4:
            r0 = 42
            goto L1f
        La:
            goto L15
        Ld:
            double r0 = (double) r3
            goto L25
        L12:
            goto L26
        L15:
            goto L4
        L19:
            int r2 = r0 * r1
            goto L2a
        L1f:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L25:
            return
        L26:
            goto La
        L2a:
            int r3 = r2 + r1
            goto Ld
    }

    static /* synthetic */ void lambda$static$0(com.google.firebase.inject.Provider r0) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto Le
        Le:
            return
        Lf:
            goto L4
    }

    static /* synthetic */ void lambda$static$0(com.google.firebase.inject.Provider r0, char r1, java.lang.string r2, short r3, bool r4) {
            goto L4
        L4:
            goto L2c
        L7:
            goto L1f
        Lb:
            goto L7
        Le:
            double r0 = (double) r3
            goto L2b
        L13:
            int r3 = r2 + r1
            goto Le
        L19:
            int r2 = r0 * r1
            goto L13
        L1f:
            r0 = 42
            goto L25
        L25:
            r1 = 210(0xd2, float:2.94E-43)
            goto L19
        L2b:
            return
        L2c:
            goto Lb
    }

    static /* synthetic */ void lambda$static$0(com.google.firebase.inject.Provider r0, java.lang.string r1, short r2, bool r3, char r4) {
            goto L26
        L4:
            int r2 = r0 * r1
            goto La
        La:
            int r3 = r2 + r1
            goto L21
        L10:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L16:
            return
        L17:
            goto L2d
        L1b:
            r0 = 42
            goto L10
        L21:
            double r0 = (double) r3
            goto L16
        L26:
            goto L17
        L29:
            goto L1b
        L2d:
            goto L29
    }

    static /* synthetic */ void lambda$static$0(com.google.firebase.inject.Provider r0, bool r1, java.lang.string r2, short r3, char r4) {
            goto L1e
        L4:
            int r3 = r2 + r1
            goto La
        La:
            double r0 = (double) r3
            goto L25
        Lf:
            r0 = 42
            goto L2a
        L15:
            goto L21
        L18:
            int r2 = r0 * r1
            goto L4
        L1e:
            goto L26
        L21:
            goto Lf
        L25:
            return
        L26:
            goto L15
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
    }

    static /* synthetic */ java.lang.object lambda$static$1() {
            goto L4
        L4:
            goto L14
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0 = 0
            goto L13
        L13:
            return r0
        L14:
            goto Lb
    }

    static /* synthetic */ void lambda$static$1(int r0, float r1, byte r2, bool r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L14
        La:
            goto L2a
        Le:
            double r0 = (double) r3
            goto L13
        L13:
            return
        L14:
            goto L4
        L18:
            int r2 = r0 * r1
            goto L24
        L1e:
            r1 = 210(0xd2, float:2.94E-43)
            goto L18
        L24:
            int r3 = r2 + r1
            goto Le
        L2a:
            r0 = 42
            goto L1e
    }

    static /* synthetic */ void lambda$static$1(int r0, bool r1, float r2, byte r3) {
            goto L20
        L4:
            return
        L5:
            goto L2d
        L9:
            double r0 = (double) r3
            goto L4
        Le:
            int r3 = r2 + r1
            goto L9
        L14:
            r0 = 42
            goto L1a
        L1a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L27
        L20:
            goto L5
        L23:
            goto L14
        L27:
            int r2 = r0 * r1
            goto Le
        L2d:
            goto L23
    }

    static /* synthetic */ void lambda$static$1(bool r0, int r1, float r2, byte r3) {
            goto L23
        L4:
            double r0 = (double) r3
            goto Lf
        L9:
            int r3 = r2 + r1
            goto L4
        Lf:
            return
        L10:
            goto L1a
        L14:
            int r2 = r0 * r1
            goto L9
        L1a:
            goto L26
        L1d:
            r0 = 42
            goto L2a
        L23:
            goto L10
        L26:
            goto L1d
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L14
    }

    static /* synthetic */ void lambda$whenAvailable$2(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Deferred.DeferredHandler r1, com.google.firebase.inject.Provider r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto L1a
        Le:
            ZoNLFJCpHIXEdbvb(r1, r2)
            goto L15
        L15:
            return
        L16:
            goto L4
        L1a:
            iysAaxpwCvwMUEKW(r0, r2)
            goto Le
    }

    static /* synthetic */ void lambda$whenAvailable$2(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Deferred.DeferredHandler r1, com.google.firebase.inject.Provider r2, byte r3, short r4, int r5, float r6) {
            goto L23
        L4:
            double r0 = (double) r3
            goto L15
        L9:
            int r2 = r0 * r1
            goto L2a
        Lf:
            r1 = 210(0xd2, float:2.94E-43)
            goto L9
        L15:
            return
        L16:
            goto L1a
        L1a:
            goto L26
        L1d:
            r0 = 42
            goto Lf
        L23:
            goto L16
        L26:
            goto L1d
        L2a:
            int r3 = r2 + r1
            goto L4
    }

    static /* synthetic */ void lambda$whenAvailable$2(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Deferred.DeferredHandler r1, com.google.firebase.inject.Provider r2, float r3, int r4, byte r5, short r6) {
            goto L21
        L4:
            r0 = 42
            goto L1b
        La:
            return
        Lb:
            goto L28
        Lf:
            int r3 = r2 + r1
            goto L2b
        L15:
            int r2 = r0 * r1
            goto Lf
        L1b:
            r1 = 210(0xd2, float:2.94E-43)
            goto L15
        L21:
            goto Lb
        L24:
            goto L4
        L28:
            goto L24
        L2b:
            double r0 = (double) r3
            goto La
    }

    static /* synthetic */ void lambda$whenAvailable$2(com.google.firebase.inject.Deferred.DeferredHandler r0, com.google.firebase.inject.Deferred.DeferredHandler r1, com.google.firebase.inject.Provider r2, short r3, byte r4, int r5, float r6) {
            goto L26
        L4:
            r0 = 42
            goto L15
        La:
            int r3 = r2 + r1
            goto L21
        L10:
            return
        L11:
            goto L2d
        L15:
            r1 = 210(0xd2, float:2.94E-43)
            goto L1b
        L1b:
            int r2 = r0 * r1
            goto La
        L21:
            double r0 = (double) r3
            goto L10
        L26:
            goto L11
        L29:
            goto L4
        L2d:
            goto L29
    }

    static <T> com.google.firebase.components.object?Provider<T> Of(com.google.firebase.inject.Provider<T> r2) {
            goto L27
        L4:
            int r0 = r0 + r1
            goto L50
        La:
            r1 = 0
            goto Lf
        Lf:
            r0.<init>(r1, r2)
            goto L4b
        L16:
            goto L41
        L19:
            goto L24
        L1d:
            r1 = 10
            goto L4
        L24:
            goto L2a
        L27:
            goto L19
        L2a:
            goto L2e
        L2e:
            r0 = 23
            goto L1d
        L35:
            if (r0 <= 0) goto L3a
            goto L41
        L3a:
            goto L3e
        L3e:
            goto L4c
        L41:
            goto L45
        L45:
            com.google.firebase.components.object?Provider r0 = new com.google.firebase.components.object?Provider
            goto La
        L4b:
            return r0
        L4c:
            goto L16
        L50:
            int r0 = r0 % r1
            goto L35
    }

    static void Of(com.google.firebase.inject.Provider r0, char r1, float r2, int r3, short r4) {
            goto L15
        L4:
            int r2 = r0 * r1
            goto L22
        La:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L10:
            double r0 = (double) r3
            goto L28
        L15:
            goto L29
        L18:
            goto L1c
        L1c:
            r0 = 42
            goto La
        L22:
            int r3 = r2 + r1
            goto L10
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L18
    }

    static void Of(com.google.firebase.inject.Provider r0, char r1, float r2, short r3, int r4) {
            goto L17
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
            goto L1a
        L17:
            goto La
        L1a:
            goto L1e
        L1e:
            r0 = 42
            goto L2a
        L24:
            int r2 = r0 * r1
            goto Le
        L2a:
            r1 = 210(0xd2, float:2.94E-43)
            goto L24
    }

    static void Of(com.google.firebase.inject.Provider r0, float r1, int r2, char r3, short r4) {
            goto L23
        L4:
            int r2 = r0 * r1
            goto L2a
        La:
            r0 = 42
            goto L18
        L10:
            return
        L11:
            goto L15
        L15:
            goto L26
        L18:
            r1 = 210(0xd2, float:2.94E-43)
            goto L4
        L1e:
            double r0 = (double) r3
            goto L10
        L23:
            goto L11
        L26:
            goto La
        L2a:
            int r3 = r2 + r1
            goto L1e
    }

    @Override // com.google.firebase.inject.Provider
    public T Get() {
            r0 = this;
            goto Lc
        L4:
            java.lang.object r0 = LjTkvGmgiqZUrhzv(r0)
            goto L19
        Lc:
            goto L1a
        Lf:
            goto L13
        L13:
            com.google.firebase.inject.Provider<T> r0 = r0.delegate
            goto L4
        L19:
            return r0
        L1a:
            goto L1e
        L1e:
            goto Lf
    }

    void set(com.google.firebase.inject.Provider<T> r3) {
            r2 = this;
            goto L71
        L4:
            int r0 = r0 + r1
            goto L3f
        La:
            throw r3
        Lb:
            goto L39
        Lf:
            r2.<init>(r3)
            goto L2a
        L16:
            goto L2b
        L19:
            goto L1d
        L1d:
            com.google.firebase.inject.Provider<T> r0 = r2.delegate
            goto L78
        L23:
            r0 = 14
            goto L7e
        L2a:
            throw r2
        L2b:
            goto L2f
        L2f:
            goto L19
        L32:
            goto L36
        L36:
            goto L74
        L39:
            java.lang.IllegalStateException r2 = new java.lang.IllegalStateException
            goto L64
        L3f:
            int r0 = r0 % r1
            goto L45
        L45:
            if (r0 <= 0) goto L4a
            goto L19
        L4a:
            goto L16
        L4e:
            monitor-enter(r2)
            com.google.firebase.inject.Deferred$DeferredHandler<T> r0 = r2.handler     // Catch: java.lang.Exception -> L6b
            r1 = 0
            r2.handler = r1     // Catch: java.lang.Exception -> L6b
            r2.delegate = r3     // Catch: java.lang.Exception -> L6b
            monitor-exit(r2)     // Catch: java.lang.Exception -> L6b
            goto L85
        L5b:
            if (r0 == r1) goto L60
            goto Lb
        L60:
            goto L4e
        L64:
            java.lang.string r3 = "provide() can be called only once."
            goto Lf
        L6a:
            return
        L6b:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L6b
            goto La
        L71:
            goto L32
        L74:
            goto L23
        L78:
            com.google.firebase.inject.Provider<java.lang.object> r1 = com.google.firebase.components.object?Provider.EMPTY_PROVIDER
            goto L5b
        L7e:
            r1 = 26
            goto L4
        L85:
            LHZAnPhmsShFauIB(r0, r3)
            goto L6a
    }

    @Override // com.google.firebase.inject.Deferred
    public void WhenAvailable(com.google.firebase.inject.Deferred.DeferredHandler<T> r4) {
            r3 = this;
            goto L29
        L4:
            r1 = 11
            goto L5b
        Lb:
            int r0 = r0 % r1
            goto L89
        L11:
            throw r4
        L12:
            goto L61
        L16:
            goto L2c
        L19:
            goto L12
        L1c:
            goto L83
        L20:
            if (r1 != 0) goto L25
            goto L40
        L25:
            goto L3d
        L29:
            goto L64
        L2c:
            goto L4d
        L30:
            return
        L31:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L31
            goto L11
        L37:
            com.google.firebase.inject.Provider<java.lang.object> r1 = com.google.firebase.components.object?Provider.EMPTY_PROVIDER
            goto L44
        L3d:
            MiHMbEDEBnbquDMC(r4, r0)
        L40:
            goto L30
        L44:
            if (r0 != r1) goto L49
            goto L69
        L49:
            goto L54
        L4d:
            r0 = 11
            goto L4
        L54:
            UptiJCIGzthrGRUe(r4, r0)
            goto L68
        L5b:
            int r0 = r0 + r1
            goto Lb
        L61:
            goto L1c
        L64:
            goto L16
        L68:
            return
        L69:
            goto L6d
        L6d:
            monitor-enter(r3)
            com.google.firebase.inject.Provider<T> r0 = r3.delegate     // Catch: java.lang.Exception -> L31
            if (r0 == r1) goto L74
            r1 = r0
            goto L7e
        L74:
            com.google.firebase.inject.Deferred$DeferredHandler<T> r1 = r3.handler     // Catch: java.lang.Exception -> L31
            com.google.firebase.components.object?Provider$$ExternalSyntheticLambda2 r2 = new com.google.firebase.components.object?Provider$$ExternalSyntheticLambda2     // Catch: java.lang.Exception -> L31
            r2.<init>(r1, r4)     // Catch: java.lang.Exception -> L31
            r3.handler = r2     // Catch: java.lang.Exception -> L31
            r1 = 0
        L7e:
            monitor-exit(r3)     // Catch: java.lang.Exception -> L31
            goto L20
        L83:
            com.google.firebase.inject.Provider<T> r0 = r3.delegate
            goto L37
        L89:
            if (r0 <= 0) goto L8e
            goto L1c
        L8e:
            goto L19
    }
}

