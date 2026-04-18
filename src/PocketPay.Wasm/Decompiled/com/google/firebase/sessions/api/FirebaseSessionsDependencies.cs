namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010%\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010$\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\n\bÆ\u0002\u0018\u00002\u00020\u0001:\u0001\u0019B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u0007H\u0007J\u0010\u0010\u000e\u001a\u00020\t2\u0006\u0010\r\u001a\u00020\u0007H\u0002J\u001f\u0010\u000f\u001a\u000e\u0012\u0004\u0012\u00020\u0007\u0012\u0004\u0012\u00020\u00100\nH\u0080@ø\u0001\u0000¢\u0006\u0004\b\u0011\u0010\u0012J\u0015\u0010\u0013\u001a\u00020\u00102\u0006\u0010\r\u001a\u00020\u0007H\u0001¢\u0006\u0002\b\u0014J\u0010\u0010\u0015\u001a\u00020\f2\u0006\u0010\u0016\u001a\u00020\u0010H\u0007J\r\u0010\u0017\u001a\u00020\fH\u0001¢\u0006\u0002\b\u0018R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082T¢\u0006\u0002\n\u0000RN\u0010\u0005\u001aB\u0012\f\u0012\n \b*\u0004\u0018\u00010\u00070\u0007\u0012\f\u0012\n \b*\u0004\u0018\u00010\t0\t \b* \u0012\f\u0012\n \b*\u0004\u0018\u00010\u00070\u0007\u0012\f\u0012\n \b*\u0004\u0018\u00010\t0\t\u0018\u00010\n0\u0006X\u0082\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u001a"}, d2 = {"Lcom/google/firebase/sessions/api/FirebaseSessionsDependencies;", "", "()V", "TAG", "", "dependencies", "", "Lcom/google/firebase/sessions/api/SessionSubscriber$Name;", "kotlin.jvm.PlatformType", "Lcom/google/firebase/sessions/api/FirebaseSessionsDependencies$Dependency;", "", "addDependency", "", "subscriberName", "getDependency", "getRegisteredSubscribers", "Lcom/google/firebase/sessions/api/SessionSubscriber;", "getRegisteredSubscribers$com_google_firebase_firebase_sessions", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getSubscriber", "getSubscriber$com_google_firebase_firebase_sessions", "register", "subscriber", "reset", "reset$com_google_firebase_firebase_sessions", "Dependency", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FirebaseSessionsDependencies {
    public static readonly com.google.firebase.sessions.api.FirebaseSessionsDependencies INSTANCE = null;
    private static readonly java.lang.string TAG = "SessionsDependencies";
    private static readonly java.util.Dictionary<com.google.firebase.sessions.api.SessionSubscriber.Name, com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency> dependencies = null;

    @kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u000b\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0082\b\u0018\u00002\u00020\u0001B\u0019\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0002\u0010\u0006J\t\u0010\r\u001a\u00020\u0003HÆ\u0003J\u000b\u0010\u000e\u001a\u0004\u0018\u00010\u0005HÆ\u0003J\u001f\u0010\u000f\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005HÆ\u0001J\u0013\u0010\u0010\u001a\u00020\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0013\u001a\u00020\u0014HÖ\u0001J\t\u0010\u0015\u001a\u00020\u0016HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u001c\u0010\u0004\u001a\u0004\u0018\u00010\u0005X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\t\u0010\n\"\u0004\b\u000b\u0010\f¨\u0006\u0017"}, d2 = {"Lcom/google/firebase/sessions/api/FirebaseSessionsDependencies$Dependency;", "", "mutex", "Lkotlinx/coroutines/sync/Mutex;", "subscriber", "Lcom/google/firebase/sessions/api/SessionSubscriber;", "(Lkotlinx/coroutines/sync/Mutex;Lcom/google/firebase/sessions/api/SessionSubscriber;)V", "getMutex", "()Lkotlinx/coroutines/sync/Mutex;", "getSubscriber", "()Lcom/google/firebase/sessions/api/SessionSubscriber;", "setSubscriber", "(Lcom/google/firebase/sessions/api/SessionSubscriber;)V", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
    private static readonly class Dependency {
        private readonly kotlinx.coroutines.sync.Mutex mutex;
        private com.google.firebase.sessions.api.SessionSubscriber subscriber;

        public Dependency(kotlinx.coroutines.sync.Mutex r2, com.google.firebase.sessions.api.SessionSubscriber r3) {
                r1 = this;
                goto L11
            L4:
                java.lang.string r0 = "mutex"
                goto La
            La:
                imifOxcilLLCwLPj(r2, r0)
                goto L2c
            L11:
                goto L19
            L14:
                goto L4
            L18:
                return
            L19:
                goto L1d
            L1d:
                goto L14
            L20:
                r1.mutex = r2
                goto L26
            L26:
                r1.subscriber = r3
                goto L18
            L2c:
                r1.<init>()
                goto L20
        }

        public /* synthetic */ Dependency(kotlinx.coroutines.sync.Mutex r1, com.google.firebase.sessions.api.SessionSubscriber r2, int r3, kotlin.jvm.internal.DefaultConstructorMarker r4) {
                r0 = this;
                goto L22
            L4:
                if (r3 != 0) goto L9
                goto L1e
            L9:
                goto L1d
            Ld:
                r0.<init>(r1, r2)
                goto L29
            L14:
                r3 = r3 & 2
                goto L4
            L1a:
                goto L25
            L1d:
                r2 = 0
            L1e:
                goto Ld
            L22:
                goto L2a
            L25:
                goto L14
            L29:
                return
            L2a:
                goto L1a
        }

        public static int PkLejtNkovjstDDH(java.lang.object r1) {
                goto L4
            L4:
                goto L17
            L7:
                goto Le
            Lb:
                goto L7
            Le:
                int r0 = r1.GetHashCode()
                goto L16
            L16:
                return r0
            L17:
                goto Lb
        }

        public static java.lang.stringBuilder TjsSEFyGfcfTXJmX(java.lang.stringBuilder r1, java.lang.string r2) {
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
                java.lang.stringBuilder r0 = r1.append(r2)
                goto L4
            L18:
                goto Lc
        }

        public static java.lang.stringBuilder VRfmgnTMyqvsLUEg(java.lang.stringBuilder r1, java.lang.object r2) {
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
                java.lang.stringBuilder r0 = r1.append(r2)
                goto Lb
            L18:
                goto L7
        }

        public static /* synthetic */ com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency copy$default(com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency r0, kotlinx.coroutines.sync.Mutex r1, com.google.firebase.sessions.api.SessionSubscriber r2, int r3, java.lang.object r4) {
                goto L33
            L4:
                if (r3 != 0) goto L9
                goto L3c
            L9:
                goto L3a
            Ld:
                r3 = r3 & 2
                goto L4
            L13:
                com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency r0 = oOahFiaNuvLLSwIY(r0, r1, r2)
                goto L40
            L1b:
                if (r4 != 0) goto L20
                goto L29
            L20:
                goto L27
            L24:
                goto L36
            L27:
                kotlinx.coroutines.sync.Mutex r1 = r0.mutex
            L29:
                goto Ld
            L2d:
                r4 = r3 & 1
                goto L1b
            L33:
                goto L41
            L36:
                goto L2d
            L3a:
                com.google.firebase.sessions.api.SessionSubscriber r2 = r0.subscriber
            L3c:
                goto L13
            L40:
                return r0
            L41:
                goto L24
        }

        public static int HwyDQAOWmdWttXJS(java.lang.object r1) {
                goto L7
            L4:
                goto La
            L7:
                goto L17
            La:
                goto Le
            Le:
                int r0 = r1.GetHashCode()
                goto L16
            L16:
                return r0
            L17:
                goto L4
        }

        public static java.lang.stringBuilder IVDqQpakPrPGlmRO(java.lang.stringBuilder r1, java.lang.object r2) {
                goto L14
            L4:
                java.lang.stringBuilder r0 = r1.append(r2)
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

        public static void ImifOxcilLLCwLPj(java.lang.object r0, java.lang.string r1) {
                goto L10
            L4:
                return
            L5:
                goto L17
            L9:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r0, r1)
                goto L4
            L10:
                goto L5
            L13:
                goto L9
            L17:
                goto L13
        }

        public static java.lang.string MrPvrywqRuGfJjbA(java.lang.stringBuilder r1) {
                goto Lc
            L4:
                java.lang.string r0 = r1.tostring()
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

        public static bool NuxCAEZgqVHRwJCp(java.lang.object r1, java.lang.object r2) {
                goto L14
            L4:
                return r0
            L5:
                goto L11
            L9:
                bool r0 = kotlin.jvm.internal.Intrinsics.areEqual(r1, r2)
                goto L4
            L11:
                goto L17
            L14:
                goto L5
            L17:
                goto L9
        }

        public static com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency OOahFiaNuvLLSwIY(com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency r1, kotlinx.coroutines.sync.Mutex r2, com.google.firebase.sessions.api.SessionSubscriber r3) {
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
                com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency r0 = r1.copy(r2, r3)
                goto L4
            L18:
                goto Lc
        }

        public static void PFOcSudXIpWrYWak(java.lang.object r0, java.lang.string r1) {
                goto L13
            L4:
                kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r0, r1)
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

        public static bool TpUntlRGQOhWnpgC(java.lang.object r1, java.lang.object r2) {
                goto L14
            L4:
                return r0
            L5:
                goto L9
            L9:
                goto L17
            Lc:
                bool r0 = kotlin.jvm.internal.Intrinsics.areEqual(r1, r2)
                goto L4
            L14:
                goto L5
            L17:
                goto Lc
        }

        public static java.lang.stringBuilder WbtdHuBDOzTbUDiR(java.lang.stringBuilder r1, char r2) {
                goto L11
            L4:
                java.lang.stringBuilder r0 = r1.append(r2)
                goto Lc
            Lc:
                return r0
            Ld:
                goto L18
            L11:
                goto Ld
            L14:
                goto L4
            L18:
                goto L14
        }

        public readonly kotlinx.coroutines.sync.Mutex Component1() {
                r0 = this;
                goto L4
            L4:
                goto L15
            L7:
                goto Le
            Lb:
                goto L7
            Le:
                kotlinx.coroutines.sync.Mutex r0 = r0.mutex
                goto L14
            L14:
                return r0
            L15:
                goto Lb
        }

        public readonly com.google.firebase.sessions.api.SessionSubscriber Component2() {
                r0 = this;
                goto Lc
            L4:
                return r0
            L5:
                goto L9
            L9:
                goto Lf
            Lc:
                goto L5
            Lf:
                goto L13
            L13:
                com.google.firebase.sessions.api.SessionSubscriber r0 = r0.subscriber
                goto L4
        }

        public readonly com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency Copy(kotlinx.coroutines.sync.Mutex r1, com.google.firebase.sessions.api.SessionSubscriber r2) {
                r0 = this;
                goto L26
            L4:
                com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency r0 = new com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency
                goto L13
            La:
                java.lang.string r0 = "mutex"
                goto L1f
            L10:
                goto L29
            L13:
                r0.<init>(r1, r2)
                goto L1a
            L1a:
                return r0
            L1b:
                goto L10
            L1f:
                pFOcSudXIpWrYWak(r1, r0)
                goto L4
            L26:
                goto L1b
            L29:
                goto La
        }

        public bool Equals(java.lang.object r5) {
                r4 = this;
                goto L4d
            L4:
                r0 = 1
                goto L39
            L9:
                if (r0 <= 0) goto Le
                goto L71
            Le:
                goto L6e
            L12:
                com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency r5 = (com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency) r5
                goto La9
            L18:
                com.google.firebase.sessions.api.SessionSubscriber r4 = r4.subscriber
                goto L29
            L1e:
                r2 = 0
                goto L8c
            L23:
                kotlinx.coroutines.sync.Mutex r3 = r5.mutex
                goto L95
            L29:
                com.google.firebase.sessions.api.SessionSubscriber r5 = r5.subscriber
                goto L66
            L2f:
                goto L71
            L32:
                goto L36
            L36:
                goto L50
            L39:
                if (r4 == r5) goto L3e
                goto L62
            L3e:
                goto L61
            L42:
                int r0 = r0 % r1
                goto L9
            L48:
                return r2
            L49:
                goto L18
            L4d:
                goto L32
            L50:
                goto L9d
            L54:
                int r0 = r0 + r1
                goto L42
            L5a:
                r1 = 21
                goto L54
            L61:
                return r0
            L62:
                goto Laf
            L66:
                bool r4 = nuxCAEZgqVHRwJCp(r4, r5)
                goto L83
            L6e:
                goto Lb6
            L71:
                goto L4
            L75:
                return r2
            L76:
                goto Lb5
            L7a:
                if (r1 == 0) goto L7f
                goto L49
            L7f:
                goto L48
            L83:
                if (r4 == 0) goto L88
                goto L76
            L88:
                goto L75
            L8c:
                if (r1 == 0) goto L91
                goto La5
            L91:
                goto La4
            L95:
                bool r1 = tpUntlRGQOhWnpgC(r1, r3)
                goto L7a
            L9d:
                r0 = 26
                goto L5a
            La4:
                return r2
            La5:
                goto L12
            La9:
                kotlinx.coroutines.sync.Mutex r1 = r4.mutex
                goto L23
            Laf:
                bool r1 = r5 is com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency
                goto L1e
            Lb5:
                return r0
            Lb6:
                goto L2f
        }

        public readonly kotlinx.coroutines.sync.Mutex GetMutex() {
                r0 = this;
                goto L4
            L4:
                goto L15
            L7:
                goto Le
            Lb:
                goto L7
            Le:
                kotlinx.coroutines.sync.Mutex r0 = r0.mutex
                goto L14
            L14:
                return r0
            L15:
                goto Lb
        }

        public readonly com.google.firebase.sessions.api.SessionSubscriber GetSubscriber() {
                r0 = this;
                goto L12
            L4:
                com.google.firebase.sessions.api.SessionSubscriber r0 = r0.subscriber
                goto Ld
            La:
                goto L15
            Ld:
                return r0
            Le:
                goto La
            L12:
                goto Le
            L15:
                goto L4
        }

        public int HashCode() {
                r1 = this;
                goto L4
            L4:
                goto L28
            L7:
                goto L17
            Lb:
                int r0 = r0 * 31
                goto L11
            L11:
                com.google.firebase.sessions.api.SessionSubscriber r1 = r1.subscriber
                goto L41
            L17:
                kotlinx.coroutines.sync.Mutex r0 = r1.mutex
                goto L31
            L1d:
                r1 = 0
                goto L22
            L22:
                goto L3d
            L23:
                goto L39
            L27:
                return r0
            L28:
                goto L4a
            L2c:
                int r0 = r0 + r1
                goto L27
            L31:
                int r0 = PkLejtNkovjstDDH(r0)
                goto Lb
            L39:
                int r1 = hwyDQAOWmdWttXJS(r1)
            L3d:
                goto L2c
            L41:
                if (r1 == 0) goto L46
                goto L23
            L46:
                goto L1d
            L4a:
                goto L7
        }

        public readonly void SetSubscriber(com.google.firebase.sessions.api.SessionSubscriber r1) {
                r0 = this;
                goto L12
            L4:
                goto L15
            L7:
                r0.subscriber = r1
                goto Ld
            Ld:
                return
            Le:
                goto L4
            L12:
                goto Le
            L15:
                goto L7
        }

        public java.lang.string Tostring() {
                r2 = this;
                goto L52
            L4:
                r0 = 41
                goto L10
            La:
                java.lang.string r1 = "Dependency(mutex="
                goto L26
            L10:
                java.lang.stringBuilder r2 = wbtdHuBDOzTbUDiR(r2, r0)
                goto L3a
            L18:
                java.lang.stringBuilder r0 = TjsSEFyGfcfTXJmX(r0, r1)
                goto L91
            L20:
                kotlinx.coroutines.sync.Mutex r1 = r2.mutex
                goto L65
            L26:
                r0.<init>(r1)
                goto L20
            L2d:
                int r0 = r0 + r1
                goto L59
            L33:
                goto L8a
            L36:
                goto L5f
            L3a:
                java.lang.string r2 = mrPvrywqRuGfJjbA(r2)
                goto L89
            L42:
                r0 = 17
                goto L6d
            L49:
                if (r0 <= 0) goto L4e
                goto L36
            L4e:
                goto L33
            L52:
                goto L85
            L55:
                goto L42
            L59:
                int r0 = r0 % r1
                goto L49
            L5f:
                java.lang.stringBuilder r0 = new java.lang.stringBuilder
                goto La
            L65:
                java.lang.stringBuilder r0 = iVDqQpakPrPGlmRO(r0, r1)
                goto L7c
            L6d:
                r1 = 24
                goto L2d
            L74:
                java.lang.stringBuilder r2 = VRfmgnTMyqvsLUEg(r0, r2)
                goto L4
            L7c:
                java.lang.string r1 = ", subscriber="
                goto L18
            L82:
                goto L36
            L85:
                goto L8e
            L89:
                return r2
            L8a:
                goto L82
            L8e:
                goto L55
            L91:
                com.google.firebase.sessions.api.SessionSubscriber r2 = r2.subscriber
                goto L74
        }
    }

    static {
            goto L13
        L4:
            r0.<init>()
            goto L35
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L2f
        L1a:
            java.util.Dictionary r0 = hYnNjnXJfYiLAZWo(r0)
            goto L22
        L22:
            com.google.firebase.sessions.api.FirebaseSessionsDependencies.dependencies = r0
            goto Le
        L28:
            r0.<init>()
            goto L41
        L2f:
            com.google.firebase.sessions.api.FirebaseSessionsDependencies r0 = new com.google.firebase.sessions.api.FirebaseSessionsDependencies
            goto L4
        L35:
            com.google.firebase.sessions.api.FirebaseSessionsDependencies.INSTANCE = r0
            goto L3b
        L3b:
            java.util.LinkedHashDictionary r0 = new java.util.LinkedHashDictionary
            goto L28
        L41:
            java.util.Dictionary r0 = (java.util.Dictionary) r0
            goto L1a
    }

    private FirebaseSessionsDependencies() {
            r0 = this;
            goto Lb
        L4:
            r0.<init>()
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

    public static java.lang.stringBuilder AHxqkmFybJMXbHtH(java.lang.stringBuilder r1, java.lang.object r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static java.lang.object AiPxLSvDLSxMNFfs(kotlinx.coroutines.sync.Mutex r1, java.lang.object r2, kotlin.coroutines.Continuation r3) {
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
            java.lang.object r0 = r1.lock(r2, r3)
            goto Le
    }

    public static void BBLuBjnEdQdndMZg(java.lang.object r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            kotlin.ResultKt.throwOnFailure(r0)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static java.lang.stringBuilder DBGEuPjzneTdjqtl(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static com.google.firebase.sessions.api.SessionSubscriber ESMLQjtBXOUHsugX(com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency r1) {
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
            com.google.firebase.sessions.api.SessionSubscriber r0 = r1.getSubscriber()
            goto L7
    }

    public static java.lang.object FWoABNUpLBfzbcfR(java.util.Dictionary r1, java.lang.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r1[r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void GKhjbrgPSIoEvEzx(java.lang.object r0) {
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
            kotlin.ResultKt.throwOnFailure(r0)
            goto L4
    }

    public static java.lang.string HcAGXMQTTcQjRAeM(java.lang.stringBuilder r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = r1.tostring()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.stringBuilder HryVCLhKipAIRlEa(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void KHrOGiMinGmlpHiT(java.lang.object r0, java.lang.string r1) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(r0, r1)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static java.lang.string KTxJmXyrSncKYsgA(java.lang.stringBuilder r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = r1.tostring()
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

    public static com.google.firebase.sessions.api.SessionSubscriber NUSFDDrduDHWvFRv(com.google.firebase.sessions.api.FirebaseSessionsDependencies r1, com.google.firebase.sessions.api.SessionSubscriber.Name r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            com.google.firebase.sessions.api.SessionSubscriber r0 = r1.getSubscriber$com_google_firebase_firebase_sessions(r2)
            goto L4
    }

    public static java.lang.stringBuilder NzJkKKIZIUlSksyn(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.stringBuilder ORgpjWRkKbHYpEbv(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lb
    }

    public static java.lang.stringBuilder OykbEfDfDEPUYLwC(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
    }

    public static kotlinx.coroutines.sync.Mutex QGpcDNscBczdtbPg(com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency r1) {
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
            kotlinx.coroutines.sync.Mutex r0 = r1.getMutex()
            goto L4
    }

    public static java.lang.stringBuilder RzKkOOCvAXgzpPhw(java.lang.stringBuilder r1, java.lang.object r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static java.lang.object TQkSHMeQYPaRXYmC(java.util.Dictionary.Entry r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1.getKey()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static int TdTvIQiuPRWkFvIZ(int r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = kotlin.collections.DictionarysKt.mapCapacity(r1)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool VWbulcDazzXgFdaJ(java.util.IEnumerator r1) {
            goto Lf
        L4:
            bool r0 = r1.MoveNext()
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

    public static int XHFzkIHtUnfekBki(java.lang.string r1, java.lang.string r2) {
            goto L11
        L4:
            int r0 = android.util.Console.d(r1, r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static kotlinx.coroutines.sync.Mutex XIlXVDYaBFbQcUUm(com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            kotlinx.coroutines.sync.Mutex r0 = r1.getMutex()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.object XcLlHjqqPjHzFlTQ(java.util.Dictionary.Entry r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1.getKey()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency XgwgNpElQmrcLEtB(com.google.firebase.sessions.api.FirebaseSessionsDependencies r1, com.google.firebase.sessions.api.SessionSubscriber.Name r2) {
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
            com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency r0 = r1.getDependency(r2)
            goto Lb
    }

    public static int XiviakzSObnVHITB(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            int r0 = android.util.Console.d(r1, r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static bool YvrcIBPAoTuYEroH(java.util.Dictionary r1, java.lang.object r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            bool r0 = r1.ContainsKey(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.object AILRVAYriBgMwsmG(java.util.IEnumerator r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r1.Current
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void AagnxNMmuOMgjFPM(java.lang.object r0, java.lang.string r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(r0, r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    @kotlin.jvm.JvmStatic
    public static readonly void AddDependency(com.google.firebase.sessions.api.SessionSubscriber.Name r6) {
            goto L18
        L4:
            java.lang.string r0 = "Incompatible versions of Firebase Perf and Firebase Sessions.\nA safe combination would be:\n  firebase-sessions:1.1.0\n  firebase-crashlytics:18.5.0\n  firebase-perf:20.5.0\nFor more information contact Firebase Support."
            goto L11
        La:
            r0.<init>(r1)
            goto L4e
        L11:
            r6.<init>(r0)
            goto La9
        L18:
            goto Lf2
        L1b:
            goto L107
        L1f:
            kotlinx.coroutines.sync.Mutex r3 = xMCjRrenlbIAmQKw(r3)
            goto L121
        L27:
            goto L1b
        L2a:
            int r0 = r0 + r1
            goto Lfb
        L30:
            java.lang.stringBuilder r6 = ORgpjWRkKbHYpEbv(r6, r0)
            goto Lc7
        L38:
            java.lang.stringBuilder r6 = DBGEuPjzneTdjqtl(r6, r0)
            goto L56
        L40:
            diasZeyXyrfMtrwL(r2, r6)
            goto L64
        L47:
            r1 = 15
            goto L2a
        L4e:
            java.lang.stringBuilder r6 = HryVCLhKipAIRlEa(r0, r6)
            goto L101
        L56:
            java.lang.string r6 = KTxJmXyrSncKYsgA(r6)
            goto L135
        L5e:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto Lc1
        L64:
            return
        L65:
            goto L13c
        L69:
            r5 = 0
            goto Le8
        L6e:
            hymyPTMAUTYUkILO(r6, r0)
            goto Ldc
        L75:
            if (r6 != r0) goto L7a
            goto L65
        L7a:
            goto Ld6
        L7e:
            if (r1 != 0) goto L83
            goto Lf7
        L83:
            goto L115
        L87:
            r3 = 1
            goto L1f
        L8c:
            java.lang.string r0 = "subscriberName"
            goto L6e
        L92:
            java.lang.stringBuilder r6 = veVnPvoqWyUsGkiv(r0, r6)
            goto Le2
        L9a:
            goto Laa
        L9d:
            goto L8c
        La1:
            bool r1 = YvrcIBPAoTuYEroH(r0, r6)
            goto L12f
        La9:
            throw r6
        Laa:
            goto Lef
        Lae:
            jaFqPXFDfBJxogFH(r0, r6, r1)
            goto L5e
        Lb5:
            java.lang.string r1 = "dependencies"
            goto L10e
        Lbb:
            java.lang.string r1 = "Dependency "
            goto La
        Lc1:
            java.lang.string r1 = "Dependency to "
            goto Lcf
        Lc7:
            java.lang.string r6 = sfxJwtCkcaTXcEow(r6)
            goto L40
        Lcf:
            r0.<init>(r1)
            goto L92
        Ld6:
            java.util.Dictionary<com.google.firebase.sessions.api.SessionSubscriber$Name, com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency> r0 = com.google.firebase.sessions.api.FirebaseSessionsDependencies.dependencies
            goto La1
        Ldc:
            com.google.firebase.sessions.api.SessionSubscriber$Name r0 = com.google.firebase.sessions.api.SessionSubscriber.Name.PERFORMANCE
            goto L75
        Le2:
            java.lang.string r0 = " added."
            goto L30
        Le8:
            r1.<init>(r3, r5, r4, r5)
            goto Lae
        Lef:
            goto L9d
        Lf2:
            goto L27
        Lf6:
            return
        Lf7:
            goto Lb5
        Lfb:
            int r0 = r0 % r1
            goto L126
        L101:
            java.lang.string r0 = " already added."
            goto L38
        L107:
            r0 = 7
            goto L47
        L10e:
            gcfnmLjRHaxVzJLx(r0, r1)
            goto L11b
        L115:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto Lbb
        L11b:
            com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency r1 = new com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency
            goto L87
        L121:
            r4 = 2
            goto L69
        L126:
            if (r0 <= 0) goto L12b
            goto L9d
        L12b:
            goto L9a
        L12f:
            java.lang.string r2 = "SessionsDependencies"
            goto L7e
        L135:
            XiviakzSObnVHITB(r2, r6)
            goto Lf6
        L13c:
            java.lang.IllegalArgumentException r6 = new java.lang.IllegalArgumentException
            goto L4
    }

    public static java.util.IEnumerator BAASIOdqCQRjrDiO(java.lang.IEnumerable r1) {
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
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto Lb
    }

    public static java.lang.object CLvbbNpcvyNUpiFC() {
            goto L14
        L4:
            java.lang.object r0 = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED()
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

    public static java.lang.object DTNPWuZcFWFwYhle(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.object r0 = r1.Add(r2, r3)
            goto Le
    }

    public static int DiasZeyXyrfMtrwL(java.lang.string r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = android.util.Console.d(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.firebase.sessions.api.SessionSubscriber.Name EDKPmnbWkuSaCJxJ(com.google.firebase.sessions.api.SessionSubscriber r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            com.google.firebase.sessions.api.SessionSubscriber$Name r0 = r1.getSessionSubscriberName()
            goto Le
    }

    public static void EZGlnDeTlbbpLnkW(kotlinx.coroutines.sync.Mutex r0, java.lang.object r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.unlock(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static java.lang.stringBuilder EtOfCtttrmPiIWtS(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L11
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static int FJGDXRzRtZYYcHkZ(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.d(r1, r2)
            goto Lb
        L18:
            goto L7
    }

    public static void GMZSgChSsiYBkqkQ(java.lang.object r0, java.lang.string r1) {
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
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r0, r1)
            goto L4
    }

    public static void GcfnmLjRHaxVzJLx(java.lang.object r0, java.lang.string r1) {
            goto L13
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(r0, r1)
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

    private readonly com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency GetDependency(com.google.firebase.sessions.api.SessionSubscriber.Name r3) {
            r2 = this;
            goto L86
        L4:
            java.lang.string r0 = ". Dependencies should be added at class load time."
            goto L18
        La:
            r2.<init>(r3)
            goto L81
        L11:
            goto Lb5
        L14:
            goto L99
        L18:
            java.lang.stringBuilder r3 = ioTITXHVuymOEKre(r3, r0)
            goto L9c
        L20:
            java.lang.object r2 = FWoABNUpLBfzbcfR(r2, r3)
            goto L34
        L28:
            com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency r2 = (com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency) r2
            goto Lb9
        L2e:
            java.lang.IllegalStateException r2 = new java.lang.IllegalStateException
            goto L75
        L34:
            if (r2 != 0) goto L39
            goto Lba
        L39:
            goto L8d
        L3d:
            r1 = 24
            goto L93
        L44:
            java.lang.string r1 = "Cannot get dependency "
            goto Lab
        L4a:
            java.lang.string r0 = "dependencies"
            goto L50
        L50:
            aagnxNMmuOMgjFPM(r2, r0)
            goto L20
        L57:
            if (r0 <= 0) goto L5c
            goto Lb5
        L5c:
            goto Lb2
        L60:
            java.util.Dictionary<com.google.firebase.sessions.api.SessionSubscriber$Name, com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency> r2 = com.google.firebase.sessions.api.FirebaseSessionsDependencies.dependencies
            goto L4a
        L66:
            xIDChSGyGGvujzMi(r2, r3)
            goto L28
        L6d:
            java.lang.stringBuilder r3 = AHxqkmFybJMXbHtH(r0, r3)
            goto L4
        L75:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L44
        L7b:
            int r0 = r0 % r1
            goto L57
        L81:
            throw r2
        L82:
            goto L11
        L86:
            goto L14
        L89:
            goto La4
        L8d:
            java.lang.string r3 = "dependencies.getOrElse(s…load time.\"\n      )\n    }"
            goto L66
        L93:
            int r0 = r0 + r1
            goto L7b
        L99:
            goto L89
        L9c:
            java.lang.string r3 = iNwjidQfGbxBnPUG(r3)
            goto La
        La4:
            r0 = 29
            goto L3d
        Lab:
            r0.<init>(r1)
            goto L6d
        Lb2:
            goto L82
        Lb5:
            goto L60
        Lb9:
            return r2
        Lba:
            goto L2e
    }

    public static java.util.Dictionary HYnNjnXJfYiLAZWo(java.util.Dictionary r1) {
            goto L14
        L4:
            java.util.Dictionary r0 = java.util.ICollections.synchronizedDictionary(r1)
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

    public static void HymyPTMAUTYUkILO(java.lang.object r0, java.lang.string r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r0, r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static java.lang.string INwjidQfGbxBnPUG(java.lang.stringBuilder r1) {
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

    public static java.lang.stringBuilder IoTITXHVuymOEKre(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.object JaFqPXFDfBJxogFH(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L11
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static java.lang.string JgPbpTtgnCGWXFPo(java.lang.stringBuilder r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.tostring()
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

    public static java.util.HashSet OGxSmYvMIIoTuCPp(java.util.Dictionary r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.util.HashSet r0 = r1.entryHashSet()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency PFUzRFOZwnIpnIOi(com.google.firebase.sessions.api.FirebaseSessionsDependencies r1, com.google.firebase.sessions.api.SessionSubscriber.Name r2) {
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
            com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency r0 = r1.getDependency(r2)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.stringBuilder PuBXWGkuomaGMLSn(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static void QgQFcTFaXNCoEtRx(kotlinx.coroutines.sync.Mutex r0, java.lang.object r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.unlock(r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static int QqkYmaWBySfWVZvR(java.util.Dictionary r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = r1.Count
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void RAXmIjIEsLhHlVvT(kotlinx.coroutines.sync.Mutex r0, java.lang.object r1, int r2, java.lang.object r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            kotlinx.coroutines.sync.Mutex.DefaultImpls.unlock$default(r0, r1, r2, r3)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    @kotlin.jvm.JvmStatic
    public static readonly void Register(com.google.firebase.sessions.api.SessionSubscriber r5) {
            goto L60
        L4:
            r0 = 14
            goto L17
        Lb:
            java.lang.stringBuilder r5 = new java.lang.stringBuilder
            goto Lde
        L11:
            java.lang.string r0 = " already registered."
            goto L35
        L17:
            r1 = 24
            goto Lb1
        L1e:
            java.lang.stringBuilder r5 = NzJkKKIZIUlSksyn(r5, r0)
            goto L8a
        L26:
            java.lang.string r5 = jgPbpTtgnCGWXFPo(r5)
            goto Lff
        L2e:
            zhFFbCmqaMuqJGRL(r5, r0)
            goto L52
        L35:
            java.lang.stringBuilder r5 = OykbEfDfDEPUYLwC(r5, r0)
            goto L26
        L3d:
            return
        L3e:
            goto Lf8
        L42:
            goto L93
        L45:
            goto La0
        L49:
            if (r2 != 0) goto L4e
            goto L3e
        L4e:
            goto Lf2
        L52:
            com.google.firebase.sessions.api.SessionSubscriber$Name r0 = eDKPmnbWkuSaCJxJ(r5)
            goto Lb7
        L5a:
            java.lang.string r3 = "Subscriber "
            goto Lbd
        L60:
            goto Ld2
        L63:
            goto L4
        L67:
            rAXmIjIEsLhHlVvT(r5, r1, r0, r1)
            goto L92
        L6e:
            java.lang.stringBuilder r5 = etOfCtttrmPiIWtS(r5, r0)
            goto L11
        L76:
            java.lang.string r0 = " registered."
            goto L1e
        L7c:
            int r0 = r0 % r1
            goto L97
        L82:
            kotlinx.coroutines.sync.Mutex r5 = QGpcDNscBczdtbPg(r1)
            goto Le5
        L8a:
            java.lang.string r5 = xkLlSAEaqiXAFyCQ(r5)
            goto Lc8
        L92:
            return
        L93:
            goto Lcf
        L97:
            if (r0 <= 0) goto L9c
            goto L45
        L9c:
            goto L42
        La0:
            java.lang.string r0 = "subscriber"
            goto L2e
        La6:
            goto L63
        La9:
            java.lang.stringBuilder r5 = xPWhqTsiyCxZIoIk(r5, r0)
            goto L76
        Lb1:
            int r0 = r0 + r1
            goto L7c
        Lb7:
            com.google.firebase.sessions.api.FirebaseSessionsDependencies r1 = com.google.firebase.sessions.api.FirebaseSessionsDependencies.INSTANCE
            goto Ld6
        Lbd:
            java.lang.string r4 = "SessionsDependencies"
            goto L49
        Lc3:
            r1 = 0
            goto L67
        Lc8:
            XHFzkIHtUnfekBki(r4, r5)
            goto L82
        Lcf:
            goto L45
        Ld2:
            goto La6
        Ld6:
            com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency r1 = pFUzRFOZwnIpnIOi(r1, r0)
            goto Lea
        Lde:
            r5.<init>(r3)
            goto La9
        Le5:
            r0 = 1
            goto Lc3
        Lea:
            com.google.firebase.sessions.api.SessionSubscriber r2 = ESMLQjtBXOUHsugX(r1)
            goto L5a
        Lf2:
            java.lang.stringBuilder r5 = new java.lang.stringBuilder
            goto L106
        Lf8:
            xPxBqveEJSKaNTdV(r1, r5)
            goto Lb
        Lff:
            fJGDXRzRtZYYcHkZ(r4, r5)
            goto L3d
        L106:
            r5.<init>(r3)
            goto L6e
    }

    public static void RlxTTiIrzmitgJkd(java.util.Dictionary r0) {
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
            r0.clear()
            goto L4
    }

    public static java.lang.string SfxJwtCkcaTXcEow(java.lang.stringBuilder r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            java.lang.string r0 = r1.tostring()
            goto Le
    }

    public static com.google.firebase.sessions.api.SessionSubscriber TPmnMSJQsTGGvXoc(com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.firebase.sessions.api.SessionSubscriber r0 = r1.getSubscriber()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.stringBuilder VeVnPvoqWyUsGkiv(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void XIDChSGyGGvujzMi(java.lang.object r0, java.lang.string r1) {
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
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(r0, r1)
            goto Le
    }

    public static kotlinx.coroutines.sync.Mutex XMCjRrenlbIAmQKw(bool r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            kotlinx.coroutines.sync.Mutex r0 = kotlinx.coroutines.sync.MutexKt.Mutex(r1)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.stringBuilder XPWhqTsiyCxZIoIk(java.lang.stringBuilder r1, java.lang.object r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static void XPxBqveEJSKaNTdV(com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency r0, com.google.firebase.sessions.api.SessionSubscriber r1) {
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
            r0.setSubscriber(r1)
            goto L4
    }

    public static java.lang.object XfnNEISDOPsjzxui(java.util.Dictionary.Entry r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r1.getValue()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.string XkLlSAEaqiXAFyCQ(java.lang.stringBuilder r1) {
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
            java.lang.string r0 = r1.tostring()
            goto Lb
        L18:
            goto L7
    }

    public static void ZhFFbCmqaMuqJGRL(java.lang.object r0, java.lang.string r1) {
            goto L13
        L4:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r0, r1)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public readonly java.lang.object getRegisteredSubscribers$com_google_firebase_firebase_sessions(kotlin.coroutines.Continuation<? super java.util.Dictionary<com.google.firebase.sessions.api.SessionSubscriber.Name, ? : com.google.firebase.sessions.api.SessionSubscriber>> r10) {
            r9 = this;
            goto L114
        L4:
            int r1 = r0.label
            goto L72
        La:
            java.lang.object r7 = r0.L$1
            goto L1e7
        L10:
            kotlinx.coroutines.sync.Mutex r5 = XIlXVDYaBFbQcUUm(r9)
            goto L53
        L18:
            int r1 = r0.label
            goto L7e
        L1e:
            r0.L$4 = r4
            goto Lec
        L24:
            if (r1 != 0) goto L29
            goto L227
        L29:
            goto L39
        L2d:
            goto L43
        L2e:
            r9 = move-exception
            goto L47
        L33:
            java.lang.object r9 = r0.result
            goto L1ed
        L39:
            if (r1 == r3) goto L3e
            goto Le2
        L3e:
            goto L18d
        L42:
            r4 = r1
        L43:
            goto L176
        L47:
            qgQFcTFaXNCoEtRx(r5, r2)
            goto Lbc
        L4e:
            return r4
        L4f:
            goto L105
        L53:
            r0.L$0 = r4
            goto L1b9
        L59:
            com.google.firebase.sessions.api.SessionSubscriber$Name r6 = (com.google.firebase.sessions.api.SessionSubscriber.Name) r6
            goto L121
        L5f:
            java.util.Dictionary r4 = (java.util.Dictionary) r4
            goto L99
        L65:
            java.util.Dictionary<com.google.firebase.sessions.api.SessionSubscriber$Name, com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency> r9 = com.google.firebase.sessions.api.FirebaseSessionsDependencies.dependencies
            goto L152
        L6b:
            r0 = 29
            goto Ld1
        L72:
            r2 = -2147483648(0xffffffff80000000, float:-0.0)
            goto L1a8
        L78:
            java.util.LinkedHashDictionary r1 = new java.util.LinkedHashDictionary
            goto L8b
        L7e:
            r2 = 0
            goto Lfa
        L83:
            java.util.IEnumerator r9 = bAASIOdqCQRjrDiO(r9)
            goto L1b4
        L8b:
            int r4 = qqkYmaWBySfWVZvR(r9)
            goto L247
        L93:
            r0.label = r3
            goto Lc9
        L99:
            java.lang.object r5 = r0.L$3
            goto L170
        L9f:
            java.lang.object r6 = r0.L$2
            goto Lb0
        La5:
            r4 = r8
            goto L2d
        Laa:
            com.google.firebase.sessions.api.FirebaseSessionsDependencies$getRegisteredSubscribers$1 r0 = new com.google.firebase.sessions.api.FirebaseSessionsDependencies$getRegisteredSubscribers$1
            goto L1f5
        Lb0:
            com.google.firebase.sessions.api.SessionSubscriber$Name r6 = (com.google.firebase.sessions.api.SessionSubscriber.Name) r6
            goto La
        Lb6:
            com.google.firebase.sessions.api.FirebaseSessionsDependencies$getRegisteredSubscribers$1 r0 = (com.google.firebase.sessions.api.FirebaseSessionsDependencies$getRegisteredSubscribers$1) r0
            goto L4
        Lbc:
            throw r9
        Lbd:
            goto L4e
        Lc1:
            java.lang.object r1 = XcLlHjqqPjHzFlTQ(r9)
            goto L137
        Lc9:
            java.lang.object r9 = AiPxLSvDLSxMNFfs(r5, r2, r0)
            goto L20b
        Ld1:
            r1 = 8
            goto L214
        Ld8:
            if (r1 != 0) goto Ldd
            goto Le8
        Ldd:
            goto L1fc
        Le1:
            goto L12a
        Le2:
            goto L187
        Le6:
            goto L1f8
        Le8:
            goto Laa
        Lec:
            r0.L$5 = r1
            goto L93
        Lf2:
            java.lang.object r9 = aILRVAYriBgMwsmG(r7)
            goto L241
        Lfa:
            r3 = 1
            goto L24
        Lff:
            java.util.Dictionary r8 = (java.util.Dictionary) r8
            goto L14b
        L105:
            goto L167
        L108:
            goto L134
        L10c:
            java.util.HashSet r9 = oGxSmYvMIIoTuCPp(r9)
            goto L21a
        L114:
            goto L108
        L117:
            goto L6b
        L11b:
            java.lang.object r8 = r0.L$0
            goto Lff
        L121:
            java.lang.object r9 = xfnNEISDOPsjzxui(r9)
            goto L1d5
        L129:
            r8 = r4
        L12a:
            com.google.firebase.sessions.api.FirebaseSessionsDependencies r9 = com.google.firebase.sessions.api.FirebaseSessionsDependencies.INSTANCE     // Catch: java.lang.Exception -> L2e
            com.google.firebase.sessions.api.SessionSubscriber r9 = NUSFDDrduDHWvFRv(r9, r6)     // Catch: java.lang.Exception -> L2e
            goto L193
        L134:
            goto L117
        L137:
            java.lang.object r5 = TQkSHMeQYPaRXYmC(r9)
            goto L1e2
        L13f:
            java.lang.object r4 = r0.L$4
            goto L5f
        L145:
            java.lang.string r10 = "call to 'resume' before 'invoke' with coroutine"
            goto L1ce
        L14b:
            BBLuBjnEdQdndMZg(r9)
            goto Le1
        L152:
            java.lang.string r1 = "dependencies"
            goto L1ad
        L158:
            r0.label = r9
            goto Le6
        L15e:
            r0.L$2 = r6
            goto L1bf
        L164:
            goto L4f
        L167:
            goto L23b
        L16b:
            r0 = r10
            goto Lb6
        L170:
            kotlinx.coroutines.sync.Mutex r5 = (kotlinx.coroutines.sync.Mutex) r5
            goto L9f
        L176:
            bool r9 = VWbulcDazzXgFdaJ(r7)
            goto L1c5
        L17e:
            if (r0 <= 0) goto L183
            goto L167
        L183:
            goto L164
        L187:
            java.lang.IllegalStateException r9 = new java.lang.IllegalStateException
            goto L145
        L18d:
            java.lang.object r1 = r0.L$5
            goto L13f
        L193:
            eZGlnDeTlbbpLnkW(r5, r2)
            goto L1db
        L19a:
            r1.<init>(r4)
            goto L220
        L1a1:
            GKhjbrgPSIoEvEzx(r9)
            goto L65
        L1a8:
            r1 = r1 & r2
            goto Ld8
        L1ad:
            KHrOGiMinGmlpHiT(r9, r1)
            goto L78
        L1b4:
            r7 = r9
            goto L42
        L1b9:
            r0.L$1 = r7
            goto L15e
        L1bf:
            r0.L$3 = r5
            goto L1e
        L1c5:
            if (r9 != 0) goto L1ca
            goto Lbd
        L1ca:
            goto Lf2
        L1ce:
            r9.<init>(r10)
            goto L226
        L1d5:
            com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency r9 = (com.google.firebase.sessions.api.FirebaseSessionsDependencies.Dependency) r9
            goto L10
        L1db:
            dTNPWuZcFWFwYhle(r4, r1, r9)
            goto La5
        L1e2:
            r6 = r5
            goto L59
        L1e7:
            java.util.IEnumerator r7 = (java.util.IEnumerator) r7
            goto L11b
        L1ed:
            java.lang.object r10 = cLvbbNpcvyNUpiFC()
            goto L18
        L1f5:
            r0.<init>(r9, r10)
        L1f8:
            goto L33
        L1fc:
            int r9 = r0.label
            goto L236
        L202:
            if (r0 != 0) goto L207
            goto Le8
        L207:
            goto L16b
        L20b:
            if (r9 == r10) goto L210
            goto L232
        L210:
            goto L231
        L214:
            int r0 = r0 + r1
            goto L22b
        L21a:
            java.lang.IEnumerable r9 = (java.lang.IEnumerable) r9
            goto L83
        L220:
            java.util.Dictionary r1 = (java.util.Dictionary) r1
            goto L10c
        L226:
            throw r9
        L227:
            goto L1a1
        L22b:
            int r0 = r0 % r1
            goto L17e
        L231:
            return r10
        L232:
            goto L129
        L236:
            int r9 = r9 - r2
            goto L158
        L23b:
            bool r0 = r10 is com.google.firebase.sessions.api.FirebaseSessionsDependencies$getRegisteredSubscribers$1
            goto L202
        L241:
            java.util.Dictionary$Entry r9 = (java.util.Dictionary.Entry) r9
            goto Lc1
        L247:
            int r4 = TdTvIQiuPRWkFvIZ(r4)
            goto L19a
    }

    public readonly com.google.firebase.sessions.api.SessionSubscriber getSubscriber$com_google_firebase_firebase_sessions(com.google.firebase.sessions.api.SessionSubscriber.Name r3) {
            r2 = this;
            goto L3f
        L4:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L91
        La:
            goto L42
        Ld:
            java.lang.string r3 = HcAGXMQTTcQjRAeM(r3)
            goto L8a
        L15:
            r0 = 20
            goto L67
        L1c:
            goto L98
        L1f:
            goto L29
        L23:
            java.lang.IllegalStateException r2 = new java.lang.IllegalStateException
            goto L4
        L29:
            java.lang.string r0 = "subscriberName"
            goto L74
        L2f:
            com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency r2 = XgwgNpElQmrcLEtB(r2, r3)
            goto L7b
        L37:
            java.lang.stringBuilder r3 = RzKkOOCvAXgzpPhw(r0, r3)
            goto L6e
        L3f:
            goto L86
        L42:
            goto L15
        L46:
            r0.<init>(r1)
            goto L37
        L4d:
            int r0 = r0 % r1
            goto La4
        L53:
            int r0 = r0 + r1
            goto L4d
        L59:
            if (r2 != 0) goto L5e
            goto L63
        L5e:
            goto L62
        L62:
            return r2
        L63:
            goto L23
        L67:
            r1 = 1
            goto L53
        L6e:
            java.lang.string r0 = " has not been registered."
            goto L9c
        L74:
            gMZSgChSsiYBkqkQ(r3, r0)
            goto L2f
        L7b:
            com.google.firebase.sessions.api.SessionSubscriber r2 = tPmnMSJQsTGGvXoc(r2)
            goto L59
        L83:
            goto L1f
        L86:
            goto La
        L8a:
            r2.<init>(r3)
            goto L97
        L91:
            java.lang.string r1 = "Subscriber "
            goto L46
        L97:
            throw r2
        L98:
            goto L83
        L9c:
            java.lang.stringBuilder r3 = puBXWGkuomaGMLSn(r3, r0)
            goto Ld
        La4:
            if (r0 <= 0) goto La9
            goto L1f
        La9:
            goto L1c
    }

    public readonly void reset$com_google_firebase_firebase_sessions() {
            r0 = this;
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
            java.util.Dictionary<com.google.firebase.sessions.api.SessionSubscriber$Name, com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency> r0 = com.google.firebase.sessions.api.FirebaseSessionsDependencies.dependencies
            goto L19
        L19:
            rlxTTiIrzmitgJkd(r0)
            goto Le
    }
}

