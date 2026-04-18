namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: renamed from: com.google.firebase.sessions.FirebaseSessionsComponent_MainModule_Companion_SessionGeneratorFactory */
/* JADX INFO: loaded from: classes2.dex */
public readonly class C2078x537e19e6 : com.google.firebase.sessions.dagger.internal.Factory<com.google.firebase.sessions.SessionGenerator> {

    /* JADX INFO: renamed from: com.google.firebase.sessions.FirebaseSessionsComponent_MainModule_Companion_SessionGeneratorFactory$InstanceHolder */
    private static readonly class InstanceHolder {
        private static readonly com.google.firebase.sessions.C2078x537e19e6 INSTANCE = null;

        static {
                goto L9
            L4:
                return
            L5:
                goto L17
            L9:
                goto L5
            Lc:
                goto L1a
            L10:
                r0.<init>()
                goto L20
            L17:
                goto Lc
            L1a:
                com.google.firebase.sessions.FirebaseSessionsComponent_MainModule_Companion_SessionGeneratorFactory r0 = new com.google.firebase.sessions.FirebaseSessionsComponent_MainModule_Companion_SessionGeneratorFactory
                goto L10
            L20:
                com.google.firebase.sessions.C2078x537e19e6.InstanceHolder.INSTANCE = r0
                goto L4
        }

        private InstanceHolder() {
                r0 = this;
                goto L13
            L4:
                return
            L5:
                goto L9
            L9:
                goto L16
            Lc:
                r0.<init>()
                goto L4
            L13:
                goto L5
            L16:
                goto Lc
        }

        static /* synthetic */ com.google.firebase.sessions.C2078x537e19e6 access$000() {
                goto La
            L4:
                com.google.firebase.sessions.FirebaseSessionsComponent_MainModule_Companion_SessionGeneratorFactory r0 = com.google.firebase.sessions.C2078x537e19e6.InstanceHolder.INSTANCE
                goto L14
            La:
                goto L15
            Ld:
                goto L4
            L11:
                goto Ld
            L14:
                return r0
            L15:
                goto L11
        }
    }

    public C2078x537e19e6() {
            r0 = this;
            goto Le
        L4:
            r0.<init>()
            goto L15
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
    }

    public static java.lang.object AABoTnsPdpCeAxVj(java.lang.object r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.object r0 = com.google.firebase.sessions.dagger.internal.Preconditions.checkNotNullFromProvides(r1)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.firebase.sessions.SessionGenerator ABnvamYbYXrlNqNB(com.google.firebase.sessions.C2078x537e19e6 r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.firebase.sessions.SessionGenerator r0 = r1[)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static com.google.firebase.sessions.C2078x537e19e6 SokhVHYpzgBGTwFF() {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.firebase.sessions.FirebaseSessionsComponent_MainModule_Companion_SessionGeneratorFactory r0 = com.google.firebase.sessions.C2078x537e19e6.InstanceHolder.access$000()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.firebase.sessions.C2078x537e19e6 Create() {
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
            com.google.firebase.sessions.FirebaseSessionsComponent_MainModule_Companion_SessionGeneratorFactory r0 = SokhVHYpzgBGTwFF()
            goto L7
    }

    public static com.google.firebase.sessions.SessionGenerator PCkWyokzgmDRIoTL(com.google.firebase.sessions.FirebaseSessionsComponent.MainModule.Companion r1) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.firebase.sessions.SessionGenerator r0 = r1.sessionGenerator()
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

    public static com.google.firebase.sessions.SessionGenerator SessionGenerator() {
            goto L22
        L4:
            java.lang.object r0 = AABoTnsPdpCeAxVj(r0)
            goto L19
        Lc:
            return r0
        Ld:
            goto L1f
        L11:
            com.google.firebase.sessions.SessionGenerator r0 = pCkWyokzgmDRIoTL(r0)
            goto L4
        L19:
            com.google.firebase.sessions.SessionGenerator r0 = (com.google.firebase.sessions.SessionGenerator) r0
            goto Lc
        L1f:
            goto L25
        L22:
            goto Ld
        L25:
            goto L29
        L29:
            com.google.firebase.sessions.FirebaseSessionsComponent$MainModule$Companion r0 = com.google.firebase.sessions.FirebaseSessionsComponent.MainModule.Companion
            goto L11
    }

    public static com.google.firebase.sessions.SessionGenerator VTezhZmDITSEUjRk() {
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
            com.google.firebase.sessions.SessionGenerator r0 = sessionGenerator()
            goto L4
    }

    @Override // javax.inject.Provider
    public com.google.firebase.sessions.SessionGenerator Get() {
            r0 = this;
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.firebase.sessions.SessionGenerator r0 = vTezhZmDITSEUjRk()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    @Override // javax.inject.Provider
    public /* bridge */ /* synthetic */ java.lang.object get() {
            r0 = this;
            goto Lf
        L4:
            goto L12
        L7:
            com.google.firebase.sessions.SessionGenerator r0 = ABnvamYbYXrlNqNB(r0)
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
}

