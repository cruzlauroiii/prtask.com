namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0006\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\t\n\u0002\b\u0019\n\u0002\u0010\u000e\n\u0000\b\u0080\b\u0018\u00002\u00020\u0001B7\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0005\u0012\b\u0010\u0006\u001a\u0004\u0018\u00010\u0007\u0012\b\u0010\b\u001a\u0004\u0018\u00010\u0007\u0012\b\u0010\t\u001a\u0004\u0018\u00010\n¢\u0006\u0002\u0010\u000bJ\u0010\u0010\u0019\u001a\u0004\u0018\u00010\u0003HÆ\u0003¢\u0006\u0002\u0010\u0013J\u0010\u0010\u001a\u001a\u0004\u0018\u00010\u0005HÆ\u0003¢\u0006\u0002\u0010\u0017J\u0010\u0010\u001b\u001a\u0004\u0018\u00010\u0007HÆ\u0003¢\u0006\u0002\u0010\rJ\u0010\u0010\u001c\u001a\u0004\u0018\u00010\u0007HÆ\u0003¢\u0006\u0002\u0010\rJ\u0010\u0010\u001d\u001a\u0004\u0018\u00010\nHÆ\u0003¢\u0006\u0002\u0010\u0010JJ\u0010\u001e\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u00052\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00010\u00072\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\u00072\n\b\u0002\u0010\t\u001a\u0004\u0018\u00010\nHÆ\u0001¢\u0006\u0002\u0010\u001fJ\u0013\u0010 \u001a\u00020\u00032\b\u0010!\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\"\u001a\u00020\u0007HÖ\u0001J\t\u0010#\u001a\u00020$HÖ\u0001R\u0015\u0010\b\u001a\u0004\u0018\u00010\u0007¢\u0006\n\n\u0002\u0010\u000e\u001a\u0004\b\f\u0010\rR\u0015\u0010\t\u001a\u0004\u0018\u00010\n¢\u0006\n\n\u0002\u0010\u0011\u001a\u0004\b\u000f\u0010\u0010R\u0015\u0010\u0002\u001a\u0004\u0018\u00010\u0003¢\u0006\n\n\u0002\u0010\u0014\u001a\u0004\b\u0012\u0010\u0013R\u0015\u0010\u0006\u001a\u0004\u0018\u00010\u0007¢\u0006\n\n\u0002\u0010\u000e\u001a\u0004\b\u0015\u0010\rR\u0015\u0010\u0004\u001a\u0004\u0018\u00010\u0005¢\u0006\n\n\u0002\u0010\u0018\u001a\u0004\b\u0016\u0010\u0017¨\u0006%"}, d2 = {"Lcom/google/firebase/sessions/settings/SessionConfigs;", "", "sessionEnabled", "", "sessionSamplingRate", "", "sessionRestartTimeout", "", "cacheDuration", "cacheUpdatedTime", "", "(Ljava/lang/bool;Ljava/lang/double;Ljava/lang/int;Ljava/lang/int;Ljava/lang/long;)V", "getCacheDuration", "()Ljava/lang/int;", "Ljava/lang/int;", "getCacheUpdatedTime", "()Ljava/lang/long;", "Ljava/lang/long;", "getSessionEnabled", "()Ljava/lang/bool;", "Ljava/lang/bool;", "getSessionRestartTimeout", "getSessionSamplingRate", "()Ljava/lang/double;", "Ljava/lang/double;", "component1", "component2", "component3", "component4", "component5", "copy", "(Ljava/lang/bool;Ljava/lang/double;Ljava/lang/int;Ljava/lang/int;Ljava/lang/long;)Lcom/google/firebase/sessions/settings/SessionConfigs;", "equals", "other", "hashCode", "tostring", "", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class SessionConfigs {
    private readonly java.lang.int cacheDuration;
    private readonly java.lang.long cacheUpdatedTime;
    private readonly java.lang.bool sessionEnabled;
    private readonly java.lang.int sessionRestartTimeout;
    private readonly java.lang.double sessionSamplingRate;

    public SessionConfigs(java.lang.bool bool, java.lang.double d, java.lang.int num, java.lang.int num2, java.lang.long l) {
        this.sessionEnabled = bool;
        this.sessionSamplingRate = d;
        this.sessionRestartTimeout = num;
        this.cacheDuration = num2;
        this.cacheUpdatedTime = l;
    }

    public static bool HHXWDpUGxLNXTVVf(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int KZmbzbAwFenVrffH(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder KoBAutbyoTEnogND(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LltRSGUemIZrlouw(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int MvbYsfMXqdHxcfEm(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool NlqsmltqJJsAosrx(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int RIrPVftKJGFZbhsm(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder ANPdFYbrSYCrDfso(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder AcDsEllGWIWTlNle(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BFMMXttFmxWhmpQi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.firebase.sessions.settings.SessionConfigs copy$default(com.google.firebase.sessions.settings.SessionConfigs sessionConfigs, java.lang.bool bool, java.lang.double d, java.lang.int num, java.lang.int num2, java.lang.long l, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            bool = sessionConfigs.sessionEnabled;
        }
        if ((i & 2) != 0) {
            d = sessionConfigs.sessionSamplingRate;
        }
        if ((i & 4) != 0) {
            num = sessionConfigs.sessionRestartTimeout;
        }
        if ((i & 8) != 0) {
            num2 = sessionConfigs.cacheDuration;
        }
        if ((i & 16) != 0) {
            l = sessionConfigs.cacheUpdatedTime;
        }
        java.lang.long l2 = l;
        return uAmOsLmWiCtaHpHM(sessionConfigs, bool, d, num, num2, l2);
    }

    public static java.lang.stringBuilder GbXuNrbyXMNfzfRh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HDmSXZdyXFqHfeDo(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder HKPhiObrfhbAEzAU(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder HdJUdbXDhLFNLORz(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool IkpRhyBFrwSITOOv(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static bool MpAANFWYyEMmSjMa(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder NDwzUJoxVkTxULyE(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int NHpanQlRvQOzVeFn(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder PAxckDjLECfihfhE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int TnIWOZEXZcUGbvNL(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static com.google.firebase.sessions.settings.SessionConfigs UAmOsLmWiCtaHpHM(com.google.firebase.sessions.settings.SessionConfigs sessionConfigs, java.lang.bool bool, java.lang.double d, java.lang.int num, java.lang.int num2, java.lang.long l) {
        return sessionConfigs.copy(bool, d, num, num2, l);
    }

    public static java.lang.stringBuilder YVlSYRmBAVkKXkAb(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public readonly java.lang.bool Component1() {
        return this.sessionEnabled;
    }

    public readonly java.lang.double Component2() {
        return this.sessionSamplingRate;
    }

    public readonly java.lang.int Component3() {
        return this.sessionRestartTimeout;
    }

    public readonly java.lang.int Component4() {
        return this.cacheDuration;
    }

    public readonly java.lang.long Component5() {
        return this.cacheUpdatedTime;
    }

    public readonly com.google.firebase.sessions.settings.SessionConfigs Copy(java.lang.bool sessionEnabled, java.lang.double sessionSamplingRate, java.lang.int sessionRestartTimeout, java.lang.int cacheDuration, java.lang.long cacheUpdatedTime) {
        return new com.google.firebase.sessions.settings.SessionConfigs(sessionEnabled, sessionSamplingRate, sessionRestartTimeout, cacheDuration, cacheUpdatedTime);
    }

    public bool Equals(java.lang.object other) {
        if ((28 + 12) % 12 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is com.google.firebase.sessions.settings.SessionConfigs)) {
            return false;
        }
        com.google.firebase.sessions.settings.SessionConfigs sessionConfigs = (com.google.firebase.sessions.settings.SessionConfigs) other;
        return NlqsmltqJJsAosrx(this.sessionEnabled, sessionConfigs.sessionEnabled) && hDmSXZdyXFqHfeDo(this.sessionSamplingRate, sessionConfigs.sessionSamplingRate) && HHXWDpUGxLNXTVVf(this.sessionRestartTimeout, sessionConfigs.sessionRestartTimeout) && mpAANFWYyEMmSjMa(this.cacheDuration, sessionConfigs.cacheDuration) && ikpRhyBFrwSITOOv(this.cacheUpdatedTime, sessionConfigs.cacheUpdatedTime);
    }

    public readonly java.lang.int GetCacheDuration() {
        return this.cacheDuration;
    }

    public readonly java.lang.long GetCacheUpdatedTime() {
        return this.cacheUpdatedTime;
    }

    public readonly java.lang.bool GetSessionEnabled() {
        return this.sessionEnabled;
    }

    public readonly java.lang.int GetSessionRestartTimeout() {
        return this.sessionRestartTimeout;
    }

    public readonly java.lang.double GetSessionSamplingRate() {
        return this.sessionSamplingRate;
    }

    public int HashCode() {
        if ((31 + 2) % 2 > 0) {
        }
        java.lang.bool bool = this.sessionEnabled;
        int iMvbYsfMXqdHxcfEm = (bool is not null ? MvbYsfMXqdHxcfEm(bool) : 0) * 31;
        java.lang.double d = this.sessionSamplingRate;
        int iRIrPVftKJGFZbhsm = (iMvbYsfMXqdHxcfEm + (d is not null ? RIrPVftKJGFZbhsm(d) : 0)) * 31;
        java.lang.int num = this.sessionRestartTimeout;
        int iTnIWOZEXZcUGbvNL = (iRIrPVftKJGFZbhsm + (num is not null ? tnIWOZEXZcUGbvNL(num) : 0)) * 31;
        java.lang.int num2 = this.cacheDuration;
        int iNHpanQlRvQOzVeFn = (iTnIWOZEXZcUGbvNL + (num2 is not null ? nHpanQlRvQOzVeFn(num2) : 0)) * 31;
        java.lang.long l = this.cacheUpdatedTime;
        return iNHpanQlRvQOzVeFn + (l is not null ? KZmbzbAwFenVrffH(l) : 0);
    }

    public java.lang.string Tostring() {
        if ((5 + 13) % 13 > 0) {
        }
        return bFMMXttFmxWhmpQi(hdJUdbXDhLFNLORz(yVlSYRmBAVkKXkAb(pAxckDjLECfihfhE(aNPdFYbrSYCrDfso(KoBAutbyoTEnogND(LltRSGUemIZrlouw(acDsEllGWIWTlNle(nDwzUJoxVkTxULyE(gbXuNrbyXMNfzfRh(hKPhiObrfhbAEzAU(new java.lang.stringBuilder("SessionConfigs(sessionEnabled="), this.sessionEnabled), ", sessionSamplingRate="), this.sessionSamplingRate), ", sessionRestartTimeout="), this.sessionRestartTimeout), ", cacheDuration="), this.cacheDuration), ", cacheUpdatedTime="), this.cacheUpdatedTime), ')'));
    }
}

