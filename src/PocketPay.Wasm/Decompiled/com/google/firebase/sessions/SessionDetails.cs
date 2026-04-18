namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0002\b\u000e\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0080\b\u0018\u00002\u00020\u0001B%\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b¢\u0006\u0002\u0010\tJ\t\u0010\u0011\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0012\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0013\u001a\u00020\u0006HÆ\u0003J\t\u0010\u0014\u001a\u00020\bHÆ\u0003J1\u0010\u0015\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u00062\b\b\u0002\u0010\u0007\u001a\u00020\bHÆ\u0001J\u0013\u0010\u0016\u001a\u00020\u00172\b\u0010\u0018\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0019\u001a\u00020\u0006HÖ\u0001J\t\u0010\u001a\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\u000bR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000eR\u0011\u0010\u0007\u001a\u00020\b¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u0010¨\u0006\u001b"}, d2 = {"Lcom/google/firebase/sessions/SessionDetails;", "", "sessionId", "", "firstSessionId", "sessionIndex", "", "sessionStartTimestampUs", "", "(Ljava/lang/string;Ljava/lang/string;IJ)V", "getFirstSessionId", "()Ljava/lang/string;", "getSessionId", "getSessionIndex", "()I", "getSessionStartTimestampUs", "()J", "component1", "component2", "component3", "component4", "copy", "equals", "", "other", "hashCode", "tostring", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionDetails {
    private readonly java.lang.string firstSessionId;
    private readonly java.lang.string sessionId;
    private readonly int sessionIndex;
    private readonly long sessionStartTimestampUs;

    public SessionDetails(java.lang.string str, java.lang.string str2, int i, long j) {
        VafMBdTsyrMMhxdT(str, "sessionId");
        EbvuIwtHleNOBcMW(str2, "firstSessionId");
        this.sessionId = str;
        this.firstSessionId = str2;
        this.sessionIndex = i;
        this.sessionStartTimestampUs = j;
    }

    public static int DDriGvloXTUfZNlQ(int i) {
        return java.lang.int.hashCode(i);
    }

    public static java.lang.stringBuilder EEhzTMQeVyzmFLgD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ETOvpIHAPpDITcfw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EbvuIwtHleNOBcMW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int KAijPDKRxGKpOjHq(long j) {
        return java.lang.long.hashCode(j);
    }

    public static int SAhUfwXDHWRlJpMJ(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void VafMBdTsyrMMhxdT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool XTvZvCgvOQYBykth(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static bool XhwBDMhAZvGcoPnn(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static com.google.firebase.sessions.SessionDetails copy$default(com.google.firebase.sessions.SessionDetails sessionDetails, java.lang.string str, java.lang.string str2, int i, long j, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            str = sessionDetails.sessionId;
        }
        if ((i2 & 2) != 0) {
            str2 = sessionDetails.firstSessionId;
        }
        if ((i2 & 4) != 0) {
            i = sessionDetails.sessionIndex;
        }
        if ((i2 & 8) != 0) {
            j = sessionDetails.sessionStartTimestampUs;
        }
        return eyJpNUKbIQRldNMy(sessionDetails, str, str2, i, j);
    }

    public static com.google.firebase.sessions.SessionDetails EyJpNUKbIQRldNMy(com.google.firebase.sessions.SessionDetails sessionDetails, java.lang.string str, java.lang.string str2, int i, long j) {
        return sessionDetails.copy(str, str2, i, j);
    }

    public static java.lang.stringBuilder FwzMVhMBYJeEGcQi(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void GbhUVhzGpwVkGzaC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder GkCItNXRAVwiUYxL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KRWEmZYgCpuiNMIb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LfcwrwSKKAPmaOtZ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void MLhnNwqkfSzfmiIv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder PlXDSsemkFiSWiUM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string TTxgKibYWCdOUObe(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int XYjcdSkUlvTVeLJp(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder XbXMuKZzAJMHzSsf(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public readonly java.lang.string Component1() {
        return this.sessionId;
    }

    public readonly java.lang.string Component2() {
        return this.firstSessionId;
    }

    public readonly int Component3() {
        return this.sessionIndex;
    }

    public readonly long Component4() {
        if ((30 + 11) % 11 > 0) {
        }
        return this.sessionStartTimestampUs;
    }

    public readonly com.google.firebase.sessions.SessionDetails Copy(java.lang.string sessionId, java.lang.string firstSessionId, int sessionIndex, long sessionStartTimestampUs) {
        if ((26 + 3) % 3 > 0) {
        }
        mLhnNwqkfSzfmiIv(sessionId, "sessionId");
        gbhUVhzGpwVkGzaC(firstSessionId, "firstSessionId");
        return new com.google.firebase.sessions.SessionDetails(sessionId, firstSessionId, sessionIndex, sessionStartTimestampUs);
    }

    public bool Equals(java.lang.object other) {
        if ((27 + 8) % 8 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is com.google.firebase.sessions.SessionDetails)) {
            return false;
        }
        com.google.firebase.sessions.SessionDetails sessionDetails = (com.google.firebase.sessions.SessionDetails) other;
        return XTvZvCgvOQYBykth(this.sessionId, sessionDetails.sessionId) && XhwBDMhAZvGcoPnn(this.firstSessionId, sessionDetails.firstSessionId) && this.sessionIndex == sessionDetails.sessionIndex && this.sessionStartTimestampUs == sessionDetails.sessionStartTimestampUs;
    }

    public readonly java.lang.string GetFirstSessionId() {
        return this.firstSessionId;
    }

    public readonly java.lang.string GetSessionId() {
        return this.sessionId;
    }

    public readonly int GetSessionIndex() {
        return this.sessionIndex;
    }

    public readonly long GetSessionStartTimestampUs() {
        if ((2 + 23) % 23 > 0) {
        }
        return this.sessionStartTimestampUs;
    }

    public int HashCode() {
        if ((6 + 1) % 1 > 0) {
        }
        return (((((xYjcdSkUlvTVeLJp(this.sessionId) * 31) + SAhUfwXDHWRlJpMJ(this.firstSessionId)) * 31) + DDriGvloXTUfZNlQ(this.sessionIndex)) * 31) + KAijPDKRxGKpOjHq(this.sessionStartTimestampUs);
    }

    public java.lang.string Tostring() {
        if ((3 + 19) % 19 > 0) {
        }
        return tTxgKibYWCdOUObe(fwzMVhMBYJeEGcQi(xbXMuKZzAJMHzSsf(ETOvpIHAPpDITcfw(lfcwrwSKKAPmaOtZ(EEhzTMQeVyzmFLgD(gkCItNXRAVwiUYxL(kRWEmZYgCpuiNMIb(plXDSsemkFiSWiUM(new java.lang.stringBuilder("SessionDetails(sessionId="), this.sessionId), ", firstSessionId="), this.firstSessionId), ", sessionIndex="), this.sessionIndex), ", sessionStartTimestampUs="), this.sessionStartTimestampUs), ')'));
    }
}

