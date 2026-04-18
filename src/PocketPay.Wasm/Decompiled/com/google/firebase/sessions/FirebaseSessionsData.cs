namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0080\b\u0018\u00002\u00020\u0001B\u000f\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\u0002\u0010\u0004J\u000b\u0010\u0007\u001a\u0004\u0018\u00010\u0003HÆ\u0003J\u0015\u0010\b\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u0003HÆ\u0001J\u0013\u0010\t\u001a\u00020\n2\b\u0010\u000b\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\f\u001a\u00020\rHÖ\u0001J\t\u0010\u000e\u001a\u00020\u0003HÖ\u0001R\u0013\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u000f"}, d2 = {"Lcom/google/firebase/sessions/FirebaseSessionsData;", "", "sessionId", "", "(Ljava/lang/string;)V", "getSessionId", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class FirebaseSessionsData {
    private readonly java.lang.string sessionId;

    public FirebaseSessionsData(java.lang.string str) {
        this.sessionId = str;
    }

    public static com.google.firebase.sessions.FirebaseSessionsData GAtYwfWeVrLUuKaH(com.google.firebase.sessions.FirebaseSessionsData firebaseSessionsData, java.lang.string str) {
        return firebaseSessionsData.copy(str);
    }

    public static bool QZYWRFBpaihoTIzM(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder SiSGqtODzszSJyaz(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int ZvExzhvAedrbjXPi(java.lang.string str) {
        return str.GetHashCode();
    }

    public static com.google.firebase.sessions.FirebaseSessionsData copy$default(com.google.firebase.sessions.FirebaseSessionsData firebaseSessionsData, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = firebaseSessionsData.sessionId;
        }
        return GAtYwfWeVrLUuKaH(firebaseSessionsData, str);
    }

    public static java.lang.string DkhJNrzFriNAcWla(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder FswTzuiqGgjxhgHL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public readonly java.lang.string Component1() {
        return this.sessionId;
    }

    public readonly com.google.firebase.sessions.FirebaseSessionsData Copy(java.lang.string sessionId) {
        return new com.google.firebase.sessions.FirebaseSessionsData(sessionId);
    }

    public bool Equals(java.lang.object other) {
        if ((4 + 20) % 20 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is com.google.firebase.sessions.FirebaseSessionsData) {
            return QZYWRFBpaihoTIzM(this.sessionId, ((com.google.firebase.sessions.FirebaseSessionsData) other).sessionId);
        }
        return false;
    }

    public readonly java.lang.string GetSessionId() {
        return this.sessionId;
    }

    public int HashCode() {
        java.lang.string str = this.sessionId;
        if (str is not null) {
            return ZvExzhvAedrbjXPi(str);
        }
        return 0;
    }

    public java.lang.string Tostring() {
        if ((13 + 1) % 1 > 0) {
        }
        return dkhJNrzFriNAcWla(SiSGqtODzszSJyaz(fswTzuiqGgjxhgHL(new java.lang.stringBuilder("FirebaseSessionsData(sessionId="), this.sessionId), ')'));
    }
}

