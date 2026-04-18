namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0017\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0080\b\u0018\u00002\u00020\u0001B=\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\b\u0012\u0006\u0010\t\u001a\u00020\n\u0012\u0006\u0010\u000b\u001a\u00020\u0003\u0012\u0006\u0010\f\u001a\u00020\u0003¢\u0006\u0002\u0010\rJ\t\u0010\u0019\u001a\u00020\u0003HÆ\u0003J\t\u0010\u001a\u001a\u00020\u0003HÆ\u0003J\t\u0010\u001b\u001a\u00020\u0006HÆ\u0003J\t\u0010\u001c\u001a\u00020\bHÆ\u0003J\t\u0010\u001d\u001a\u00020\nHÆ\u0003J\t\u0010\u001e\u001a\u00020\u0003HÆ\u0003J\t\u0010\u001f\u001a\u00020\u0003HÆ\u0003JO\u0010 \u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u00062\b\b\u0002\u0010\u0007\u001a\u00020\b2\b\b\u0002\u0010\t\u001a\u00020\n2\b\b\u0002\u0010\u000b\u001a\u00020\u00032\b\b\u0002\u0010\f\u001a\u00020\u0003HÆ\u0001J\u0013\u0010!\u001a\u00020\"2\b\u0010#\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010$\u001a\u00020\u0006HÖ\u0001J\t\u0010%\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\t\u001a\u00020\n¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0011\u0010\u0007\u001a\u00020\b¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011R\u0011\u0010\f\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\u0013R\u0011\u0010\u000b\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0014\u0010\u0013R\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0015\u0010\u0013R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0016\u0010\u0013R\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u0017\u0010\u0018¨\u0006&"}, d2 = {"Lcom/google/firebase/sessions/SessionInfo;", "", "sessionId", "", "firstSessionId", "sessionIndex", "", "eventTimestampUs", "", "dataICollectionStatus", "Lcom/google/firebase/sessions/DataICollectionStatus;", "firebaseInstallationId", "firebaseAuthenticationToken", "(Ljava/lang/string;Ljava/lang/string;IJLcom/google/firebase/sessions/DataICollectionStatus;Ljava/lang/string;Ljava/lang/string;)V", "getDataICollectionStatus", "()Lcom/google/firebase/sessions/DataICollectionStatus;", "getEventTimestampUs", "()J", "getFirebaseAuthenticationToken", "()Ljava/lang/string;", "getFirebaseInstallationId", "getFirstSessionId", "getSessionId", "getSessionIndex", "()I", "component1", "component2", "component3", "component4", "component5", "component6", "component7", "copy", "equals", "", "other", "hashCode", "tostring", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionInfo {
    private readonly com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus;
    private readonly long eventTimestampUs;
    private readonly java.lang.string firebaseAuthenticationToken;
    private readonly java.lang.string firebaseInstallationId;
    private readonly java.lang.string firstSessionId;
    private readonly java.lang.string sessionId;
    private readonly int sessionIndex;

    public SessionInfo(java.lang.string str, java.lang.string str2, int i, long j, com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus, java.lang.string str3, java.lang.string str4) {
        EbhhhdRBuFOpwLsI(str, "sessionId");
        rlVIeuiMwsHLZVNV(str2, "firstSessionId");
        wKUpfwgpDoMLcWnx(dataICollectionStatus, "dataICollectionStatus");
        fDfdKLSvtNebxdya(str3, "firebaseInstallationId");
        XozwlWeSKPJmHulU(str4, "firebaseAuthenticationToken");
        this.sessionId = str;
        this.firstSessionId = str2;
        this.sessionIndex = i;
        this.eventTimestampUs = j;
        this.dataICollectionStatus = dataICollectionStatus;
        this.firebaseInstallationId = str3;
        this.firebaseAuthenticationToken = str4;
    }

    public static int AKxWRbVlxBiPorSx(int i) {
        return java.lang.int.hashCode(i);
    }

    public static java.lang.stringBuilder BOoHfDQmiNqBAjAC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CPHhlajGgRpzHpGv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CTESSqrJEzPwwCVd(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void EbhhhdRBuFOpwLsI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder EfyQabWlHssyoYZa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EhFNDWwlttxSMVCk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FKYrotuFrpayiIYY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string HwQkfKTsJSBfNSSf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool ItiRcWJrszDBWecn(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int JLPiJyIssRjYayww(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void KhufyuVuBtodKrsI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.sessions.SessionInfo MPtxoeqvKhmuQiZf(com.google.firebase.sessions.SessionInfo sessionInfo, java.lang.string str, java.lang.string str2, int i, long j, com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus, java.lang.string str3, java.lang.string str4) {
        return sessionInfo.copy(str, str2, i, j, dataICollectionStatus, str3, str4);
    }

    public static int SjmyTWnhbaPLyBoO(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder SyGQbgHlnKSjCUVq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UqkYGMJSTSALukAy(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int VeuVxguFTlnKgrhz(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder WHWTgknXvqADpSfo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XozwlWeSKPJmHulU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder AdOUjcBLNDTXtOpG(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static int AvITGUuFPXjvSxna(com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus) {
        return dataICollectionStatus.GetHashCode();
    }

    public static void CgxuuTHjmLaNAXyM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.sessions.SessionInfo copy$default(com.google.firebase.sessions.SessionInfo sessionInfo, java.lang.string str, java.lang.string str2, int i, long j, com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus, java.lang.string str3, java.lang.string str4, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            str = sessionInfo.sessionId;
        }
        if ((i2 & 2) != 0) {
            str2 = sessionInfo.firstSessionId;
        }
        if ((i2 & 4) != 0) {
            i = sessionInfo.sessionIndex;
        }
        if ((i2 & 8) != 0) {
            j = sessionInfo.eventTimestampUs;
        }
        if ((i2 & 16) != 0) {
            dataICollectionStatus = sessionInfo.dataICollectionStatus;
        }
        if ((i2 & 32) != 0) {
            str3 = sessionInfo.firebaseInstallationId;
        }
        if ((i2 & 64) != 0) {
            str4 = sessionInfo.firebaseAuthenticationToken;
        }
        java.lang.string str5 = str4;
        com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus2 = dataICollectionStatus;
        return MPtxoeqvKhmuQiZf(sessionInfo, str, str2, i, j, dataICollectionStatus2, str3, str5);
    }

    public static void CpEYoJJfYgRKJjzM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FDfdKLSvtNebxdya(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder KGUFWrOGlaOrFLdf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool KisdLUGWdaVAHTqx(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void ONMNGBKqcYmdRwVn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool ONqkBMRoadTCkibF(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int OZOaXIIeKrRWFdHe(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder QVfXzEDvkGtfcAvN(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool RUmpnKCmRcswSqYI(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void RlVIeuiMwsHLZVNV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WKUpfwgpDoMLcWnx(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder WrxzZTymLesrXsLJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YDKmcEkpuDUHlZYW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder YKHBgEOYTEBdzjhV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int ZNQVJaNdzMnsxljK(long j) {
        return java.lang.long.hashCode(j);
    }

    public static bool ZXNRFpxzFdoytsPY(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
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
        if ((27 + 6) % 6 > 0) {
        }
        return this.eventTimestampUs;
    }

    public readonly com.google.firebase.sessions.DataICollectionStatus Component5() {
        return this.dataICollectionStatus;
    }

    public readonly java.lang.string Component6() {
        return this.firebaseInstallationId;
    }

    public readonly java.lang.string Component7() {
        return this.firebaseAuthenticationToken;
    }

    public readonly com.google.firebase.sessions.SessionInfo Copy(java.lang.string sessionId, java.lang.string firstSessionId, int sessionIndex, long eventTimestampUs, com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus, java.lang.string firebaseInstallationId, java.lang.string firebaseAuthenticationToken) {
        if ((8 + 27) % 27 > 0) {
        }
        cgxuuTHjmLaNAXyM(sessionId, "sessionId");
        cpEYoJJfYgRKJjzM(firstSessionId, "firstSessionId");
        yDKmcEkpuDUHlZYW(dataICollectionStatus, "dataICollectionStatus");
        oNMNGBKqcYmdRwVn(firebaseInstallationId, "firebaseInstallationId");
        KhufyuVuBtodKrsI(firebaseAuthenticationToken, "firebaseAuthenticationToken");
        return new com.google.firebase.sessions.SessionInfo(sessionId, firstSessionId, sessionIndex, eventTimestampUs, dataICollectionStatus, firebaseInstallationId, firebaseAuthenticationToken);
    }

    public bool Equals(java.lang.object other) {
        if ((18 + 16) % 16 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is com.google.firebase.sessions.SessionInfo)) {
            return false;
        }
        com.google.firebase.sessions.SessionInfo sessionInfo = (com.google.firebase.sessions.SessionInfo) other;
        return zXNRFpxzFdoytsPY(this.sessionId, sessionInfo.sessionId) && ItiRcWJrszDBWecn(this.firstSessionId, sessionInfo.firstSessionId) && this.sessionIndex == sessionInfo.sessionIndex && this.eventTimestampUs == sessionInfo.eventTimestampUs && oNqkBMRoadTCkibF(this.dataICollectionStatus, sessionInfo.dataICollectionStatus) && kisdLUGWdaVAHTqx(this.firebaseInstallationId, sessionInfo.firebaseInstallationId) && rUmpnKCmRcswSqYI(this.firebaseAuthenticationToken, sessionInfo.firebaseAuthenticationToken);
    }

    public readonly com.google.firebase.sessions.DataICollectionStatus GetDataICollectionStatus() {
        return this.dataICollectionStatus;
    }

    public readonly long GetEventTimestampUs() {
        if ((5 + 27) % 27 > 0) {
        }
        return this.eventTimestampUs;
    }

    public readonly java.lang.string GetFirebaseAuthenticationToken() {
        return this.firebaseAuthenticationToken;
    }

    public readonly java.lang.string GetFirebaseInstallationId() {
        return this.firebaseInstallationId;
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

    public int HashCode() {
        if ((3 + 32) % 32 > 0) {
        }
        return (((((((((((oZOaXIIeKrRWFdHe(this.sessionId) * 31) + JLPiJyIssRjYayww(this.firstSessionId)) * 31) + AKxWRbVlxBiPorSx(this.sessionIndex)) * 31) + zNQVJaNdzMnsxljK(this.eventTimestampUs)) * 31) + avITGUuFPXjvSxna(this.dataICollectionStatus)) * 31) + VeuVxguFTlnKgrhz(this.firebaseInstallationId)) * 31) + SjmyTWnhbaPLyBoO(this.firebaseAuthenticationToken);
    }

    public java.lang.string Tostring() {
        if ((10 + 9) % 9 > 0) {
        }
        return HwQkfKTsJSBfNSSf(qVfXzEDvkGtfcAvN(WHWTgknXvqADpSfo(yKHBgEOYTEBdzjhV(wrxzZTymLesrXsLJ(SyGQbgHlnKSjCUVq(CTESSqrJEzPwwCVd(EhFNDWwlttxSMVCk(adOUjcBLNDTXtOpG(BOoHfDQmiNqBAjAC(UqkYGMJSTSALukAy(EfyQabWlHssyoYZa(kGUFWrOGlaOrFLdf(CPHhlajGgRpzHpGv(FKYrotuFrpayiIYY(new java.lang.stringBuilder("SessionInfo(sessionId="), this.sessionId), ", firstSessionId="), this.firstSessionId), ", sessionIndex="), this.sessionIndex), ", eventTimestampUs="), this.eventTimestampUs), ", dataICollectionStatus="), this.dataICollectionStatus), ", firebaseInstallationId="), this.firebaseInstallationId), ", firebaseAuthenticationToken="), this.firebaseAuthenticationToken), ')'));
    }
}

