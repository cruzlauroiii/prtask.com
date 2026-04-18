namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u000b\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0082\b\u0018\u00002\u00020\u0001B\u0019\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\u0002\u0010\u0006J\t\u0010\r\u001a\u00020\u0003HÆ\u0003J\u000b\u0010\u000e\u001a\u0004\u0018\u00010\u0005HÆ\u0003J\u001f\u0010\u000f\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0005HÆ\u0001J\u0013\u0010\u0010\u001a\u00020\u00112\b\u0010\u0012\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0013\u001a\u00020\u0014HÖ\u0001J\t\u0010\u0015\u001a\u00020\u0016HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u001c\u0010\u0004\u001a\u0004\u0018\u00010\u0005X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\t\u0010\n\"\u0004\b\u000b\u0010\f¨\u0006\u0017"}, d2 = {"Lcom/google/firebase/sessions/api/FirebaseSessionsDependencies$Dependency;", "", "mutex", "Lkotlinx/coroutines/sync/Mutex;", "subscriber", "Lcom/google/firebase/sessions/api/SessionSubscriber;", "(Lkotlinx/coroutines/sync/Mutex;Lcom/google/firebase/sessions/api/SessionSubscriber;)V", "getMutex", "()Lkotlinx/coroutines/sync/Mutex;", "getSubscriber", "()Lcom/google/firebase/sessions/api/SessionSubscriber;", "setSubscriber", "(Lcom/google/firebase/sessions/api/SessionSubscriber;)V", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class FirebaseSessionsDependencies$Dependency {
    private readonly kotlinx.coroutines.sync.Mutex mutex;
    private com.google.firebase.sessions.api.SessionSubscriber subscriber;

    public FirebaseSessionsDependencies$Dependency(kotlinx.coroutines.sync.Mutex mutex, com.google.firebase.sessions.api.SessionSubscriber sessionSubscriber) {
        imifOxcilLLCwLPj(mutex, "mutex");
        this.mutex = mutex;
        this.subscriber = sessionSubscriber;
    }

    public FirebaseSessionsDependencies$Dependency(kotlinx.coroutines.sync.Mutex mutex, com.google.firebase.sessions.api.SessionSubscriber sessionSubscriber, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(mutex, (i & 2) != 0 ? null : sessionSubscriber);
    }

    public static int PkLejtNkovjstDDH(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder TjsSEFyGfcfTXJmX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VRfmgnTMyqvsLUEg(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency copy$default(com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency firebaseSessionsDependencies$Dependency, kotlinx.coroutines.sync.Mutex mutex, com.google.firebase.sessions.api.SessionSubscriber sessionSubscriber, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            mutex = firebaseSessionsDependencies$Dependency.mutex;
        }
        if ((i & 2) != 0) {
            sessionSubscriber = firebaseSessionsDependencies$Dependency.subscriber;
        }
        return oOahFiaNuvLLSwIY(firebaseSessionsDependencies$Dependency, mutex, sessionSubscriber);
    }

    public static int HwyDQAOWmdWttXJS(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder IVDqQpakPrPGlmRO(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void ImifOxcilLLCwLPj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string MrPvrywqRuGfJjbA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool NuxCAEZgqVHRwJCp(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency oOahFiaNuvLLSwIY(com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency firebaseSessionsDependencies$Dependency, kotlinx.coroutines.sync.Mutex mutex, com.google.firebase.sessions.api.SessionSubscriber sessionSubscriber) {
        return firebaseSessionsDependencies$Dependency.copy(mutex, sessionSubscriber);
    }

    public static void PFOcSudXIpWrYWak(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool TpUntlRGQOhWnpgC(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder WbtdHuBDOzTbUDiR(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public readonly kotlinx.coroutines.sync.Mutex Component1() {
        return this.mutex;
    }

    public readonly com.google.firebase.sessions.api.SessionSubscriber Component2() {
        return this.subscriber;
    }

    public readonly com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency copy(kotlinx.coroutines.sync.Mutex mutex, com.google.firebase.sessions.api.SessionSubscriber subscriber) {
        pFOcSudXIpWrYWak(mutex, "mutex");
        return new com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency(mutex, subscriber);
    }

    public bool Equals(java.lang.object other) {
        if ((26 + 21) % 21 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency)) {
            return false;
        }
        com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency firebaseSessionsDependencies$Dependency = (com.google.firebase.sessions.api.FirebaseSessionsDependencies$Dependency) other;
        return tpUntlRGQOhWnpgC(this.mutex, firebaseSessionsDependencies$Dependency.mutex) && nuxCAEZgqVHRwJCp(this.subscriber, firebaseSessionsDependencies$Dependency.subscriber);
    }

    public readonly kotlinx.coroutines.sync.Mutex GetMutex() {
        return this.mutex;
    }

    public readonly com.google.firebase.sessions.api.SessionSubscriber GetSubscriber() {
        return this.subscriber;
    }

    public int HashCode() {
        int iPkLejtNkovjstDDH = PkLejtNkovjstDDH(this.mutex) * 31;
        com.google.firebase.sessions.api.SessionSubscriber sessionSubscriber = this.subscriber;
        return iPkLejtNkovjstDDH + (sessionSubscriber is not null ? hwyDQAOWmdWttXJS(sessionSubscriber) : 0);
    }

    public readonly void SetSubscriber(com.google.firebase.sessions.api.SessionSubscriber sessionSubscriber) {
        this.subscriber = sessionSubscriber;
    }

    public java.lang.string Tostring() {
        if ((17 + 24) % 24 > 0) {
        }
        return mrPvrywqRuGfJjbA(wbtdHuBDOzTbUDiR(VRfmgnTMyqvsLUEg(TjsSEFyGfcfTXJmX(iVDqQpakPrPGlmRO(new java.lang.stringBuilder("Dependency(mutex="), this.mutex), ", subscriber="), this.subscriber), ')'));
    }
}

