namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0086\b\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004J\t\u0010\u0007\u001a\u00020\u0003HÆ\u0003J\u0013\u0010\b\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\t\u001a\u00020\n2\b\u0010\u000b\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\f\u001a\u00020\rHÖ\u0001J\t\u0010\u000e\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006¨\u0006\u000f"}, d2 = {"Lcom/google/firebase/sessions/api/SessionSubscriber$SessionDetails;", "", "sessionId", "", "(Ljava/lang/string;)V", "getSessionId", "()Ljava/lang/string;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionSubscriber$SessionDetails {
    private readonly java.lang.string sessionId;

    public SessionSubscriber$SessionDetails(java.lang.string str) {
        DVnpOEDKaEjcKOVT(str, "sessionId");
        this.sessionId = str;
    }

    public static void DVnpOEDKaEjcKOVT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder PcxtNtaUVMDhmwnr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.firebase.sessions.api.SessionSubscriber$SessionDetails PiEyWElqRmSSvJmr(com.google.firebase.sessions.api.SessionSubscriber$SessionDetails sessionSubscriber$SessionDetails, java.lang.string str) {
        return sessionSubscriber$SessionDetails.copy(str);
    }

    public static java.lang.stringBuilder SJgJDeemtSmJzvZZ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void WzwHmJAmeRsMlVly(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string AlqCMClUQxWKsZuA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.firebase.sessions.api.SessionSubscriber$SessionDetails copy$default(com.google.firebase.sessions.api.SessionSubscriber$SessionDetails sessionSubscriber$SessionDetails, java.lang.string str, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = sessionSubscriber$SessionDetails.sessionId;
        }
        return PiEyWElqRmSSvJmr(sessionSubscriber$SessionDetails, str);
    }

    public static bool MbLZTVoDBSToHnnW(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int YCUkkogJakvKQGWB(java.lang.string str) {
        return str.GetHashCode();
    }

    public readonly java.lang.string Component1() {
        return this.sessionId;
    }

    public readonly com.google.firebase.sessions.api.SessionSubscriber$SessionDetails copy(java.lang.string sessionId) {
        WzwHmJAmeRsMlVly(sessionId, "sessionId");
        return new com.google.firebase.sessions.api.SessionSubscriber$SessionDetails(sessionId);
    }

    public bool Equals(java.lang.object other) {
        if ((13 + 26) % 26 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is com.google.firebase.sessions.api.SessionSubscriber$SessionDetails) {
            return mbLZTVoDBSToHnnW(this.sessionId, ((com.google.firebase.sessions.api.SessionSubscriber$SessionDetails) other).sessionId);
        }
        return false;
    }

    public readonly java.lang.string GetSessionId() {
        return this.sessionId;
    }

    public int HashCode() {
        return yCUkkogJakvKQGWB(this.sessionId);
    }

    public java.lang.string Tostring() {
        if ((27 + 9) % 9 > 0) {
        }
        return alqCMClUQxWKsZuA(SJgJDeemtSmJzvZZ(PcxtNtaUVMDhmwnr(new java.lang.stringBuilder("SessionDetails(sessionId="), this.sessionId), ')'));
    }
}

