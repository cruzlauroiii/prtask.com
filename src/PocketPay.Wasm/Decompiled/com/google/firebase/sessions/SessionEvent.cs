namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\f\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0081\b\u0018\u00002\u00020\u0001B\u001d\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0002\u0010\bJ\t\u0010\u000f\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0010\u001a\u00020\u0005HÆ\u0003J\t\u0010\u0011\u001a\u00020\u0007HÆ\u0003J'\u0010\u0012\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00052\b\b\u0002\u0010\u0006\u001a\u00020\u0007HÆ\u0001J\u0013\u0010\u0013\u001a\u00020\u00142\b\u0010\u0015\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0016\u001a\u00020\u0017HÖ\u0001J\t\u0010\u0018\u001a\u00020\u0019HÖ\u0001R\u0011\u0010\u0006\u001a\u00020\u0007¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\fR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000e¨\u0006\u001a"}, d2 = {"Lcom/google/firebase/sessions/SessionEvent;", "", "eventType", "Lcom/google/firebase/sessions/EventType;", "sessionData", "Lcom/google/firebase/sessions/SessionInfo;", "applicationInfo", "Lcom/google/firebase/sessions/ApplicationInfo;", "(Lcom/google/firebase/sessions/EventType;Lcom/google/firebase/sessions/SessionInfo;Lcom/google/firebase/sessions/ApplicationInfo;)V", "getApplicationInfo", "()Lcom/google/firebase/sessions/ApplicationInfo;", "getEventType", "()Lcom/google/firebase/sessions/EventType;", "getSessionData", "()Lcom/google/firebase/sessions/SessionInfo;", "component1", "component2", "component3", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
@com.google.firebase.encoders.annotations.Encodable
public readonly class SessionEvent {
    private readonly com.google.firebase.sessions.ApplicationInfo applicationInfo;
    private readonly com.google.firebase.sessions.EventType eventType;
    private readonly com.google.firebase.sessions.SessionInfo sessionData;

    public SessionEvent(com.google.firebase.sessions.EventType eventType, com.google.firebase.sessions.SessionInfo sessionInfo, com.google.firebase.sessions.ApplicationInfo applicationInfo) {
        xmxkuffenXvzXcil(eventType, "eventType");
        WYuAHvcDXwHtcTUS(sessionInfo, "sessionData");
        cSmuBolFAoRGMTZa(applicationInfo, "applicationInfo");
        this.eventType = eventType;
        this.sessionData = sessionInfo;
        this.applicationInfo = applicationInfo;
    }

    public static java.lang.stringBuilder DCvnpzmBCsAtOvHT(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.firebase.sessions.SessionEvent HIeZABVhvOaDaJYo(com.google.firebase.sessions.SessionEvent sessionEvent, com.google.firebase.sessions.EventType eventType, com.google.firebase.sessions.SessionInfo sessionInfo, com.google.firebase.sessions.ApplicationInfo applicationInfo) {
        return sessionEvent.copy(eventType, sessionInfo, applicationInfo);
    }

    public static bool HrSXtRBkuPrxbvlI(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void MsUhFzcFeqydlyny(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void QthQgkfLPEaEdyqB(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string RYVZxKOIMPraeqqf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder TutApiKDElGXSXeX(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void WYuAHvcDXwHtcTUS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WadcvMfnIhSkqaIN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void CSmuBolFAoRGMTZa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.sessions.SessionEvent copy$default(com.google.firebase.sessions.SessionEvent sessionEvent, com.google.firebase.sessions.EventType eventType, com.google.firebase.sessions.SessionInfo sessionInfo, com.google.firebase.sessions.ApplicationInfo applicationInfo, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            eventType = sessionEvent.eventType;
        }
        if ((i & 2) != 0) {
            sessionInfo = sessionEvent.sessionData;
        }
        if ((i & 4) != 0) {
            applicationInfo = sessionEvent.applicationInfo;
        }
        return HIeZABVhvOaDaJYo(sessionEvent, eventType, sessionInfo, applicationInfo);
    }

    public static int DrfkSsXJdApjeUKV(com.google.firebase.sessions.SessionInfo sessionInfo) {
        return sessionInfo.GetHashCode();
    }

    public static java.lang.stringBuilder HxqRwKkYwjLqluTS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IwbJnhcWEIafgIis(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MFlxlrqzifjRQAhN(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int MoISyNpISlZFtcLS(com.google.firebase.sessions.ApplicationInfo applicationInfo) {
        return applicationInfo.GetHashCode();
    }

    public static bool RymQSCHNjlfaBxha(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void XmxkuffenXvzXcil(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder YfMSGiJvfiBoeXst(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int ZoYAacOExALaOpSy(com.google.firebase.sessions.EventType eventType) {
        return eventType.GetHashCode();
    }

    public readonly com.google.firebase.sessions.EventType Component1() {
        return this.eventType;
    }

    public readonly com.google.firebase.sessions.SessionInfo Component2() {
        return this.sessionData;
    }

    public readonly com.google.firebase.sessions.ApplicationInfo Component3() {
        return this.applicationInfo;
    }

    public readonly com.google.firebase.sessions.SessionEvent Copy(com.google.firebase.sessions.EventType eventType, com.google.firebase.sessions.SessionInfo sessionData, com.google.firebase.sessions.ApplicationInfo applicationInfo) {
        MsUhFzcFeqydlyny(eventType, "eventType");
        QthQgkfLPEaEdyqB(sessionData, "sessionData");
        WadcvMfnIhSkqaIN(applicationInfo, "applicationInfo");
        return new com.google.firebase.sessions.SessionEvent(eventType, sessionData, applicationInfo);
    }

    public bool Equals(java.lang.object other) {
        if ((22 + 3) % 3 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is com.google.firebase.sessions.SessionEvent)) {
            return false;
        }
        com.google.firebase.sessions.SessionEvent sessionEvent = (com.google.firebase.sessions.SessionEvent) other;
        return this.eventType == sessionEvent.eventType && rymQSCHNjlfaBxha(this.sessionData, sessionEvent.sessionData) && HrSXtRBkuPrxbvlI(this.applicationInfo, sessionEvent.applicationInfo);
    }

    public readonly com.google.firebase.sessions.ApplicationInfo GetApplicationInfo() {
        return this.applicationInfo;
    }

    public readonly com.google.firebase.sessions.EventType GetEventType() {
        return this.eventType;
    }

    public readonly com.google.firebase.sessions.SessionInfo GetSessionData() {
        return this.sessionData;
    }

    public int HashCode() {
        if ((3 + 22) % 22 > 0) {
        }
        return (((zoYAacOExALaOpSy(this.eventType) * 31) + drfkSsXJdApjeUKV(this.sessionData)) * 31) + moISyNpISlZFtcLS(this.applicationInfo);
    }

    public java.lang.string Tostring() {
        if ((3 + 26) % 26 > 0) {
        }
        return RYVZxKOIMPraeqqf(DCvnpzmBCsAtOvHT(TutApiKDElGXSXeX(iwbJnhcWEIafgIis(mFlxlrqzifjRQAhN(hxqRwKkYwjLqluTS(yfMSGiJvfiBoeXst(new java.lang.stringBuilder("SessionEvent(eventType="), this.eventType), ", sessionData="), this.sessionData), ", applicationInfo="), this.applicationInfo), ')'));
    }
}

