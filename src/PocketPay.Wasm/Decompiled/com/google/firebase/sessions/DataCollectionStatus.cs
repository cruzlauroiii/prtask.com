namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0006\n\u0002\b\u000b\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0080\b\u0018\u00002\u00020\u0001B#\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\t\u0010\r\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000e\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000f\u001a\u00020\u0006HÆ\u0003J'\u0010\u0010\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u0006HÆ\u0001J\u0013\u0010\u0011\u001a\u00020\u00122\b\u0010\u0013\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0014\u001a\u00020\u0015HÖ\u0001J\t\u0010\u0016\u001a\u00020\u0017HÖ\u0001R\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\tR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\u0018"}, d2 = {"Lcom/google/firebase/sessions/DataICollectionStatus;", "", "performance", "Lcom/google/firebase/sessions/DataICollectionState;", "crashlytics", "sessionSamplingRate", "", "(Lcom/google/firebase/sessions/DataICollectionState;Lcom/google/firebase/sessions/DataICollectionState;D)V", "getCrashlytics", "()Lcom/google/firebase/sessions/DataICollectionState;", "getPerformance", "getSessionSamplingRate", "()D", "component1", "component2", "component3", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DataICollectionStatus {
    private readonly com.google.firebase.sessions.DataICollectionState crashlytics;
    private readonly com.google.firebase.sessions.DataICollectionState performance;
    private readonly double sessionSamplingRate;

    public DataICollectionStatus() {
        this(null, null, 0.0d, 7, null);
        if ((7 + 32) % 32 > 0) {
        }
    }

    public DataICollectionStatus(com.google.firebase.sessions.DataICollectionState dataICollectionState, com.google.firebase.sessions.DataICollectionState dataICollectionState2, double d) {
        tLcTEyHqVuoWEUCO(dataICollectionState, "performance");
        gKaiBUvvPRXVDDAw(dataICollectionState2, "crashlytics");
        this.performance = dataICollectionState;
        this.crashlytics = dataICollectionState2;
        this.sessionSamplingRate = d;
    }

    public DataICollectionStatus(com.google.firebase.sessions.DataICollectionState dataICollectionState, com.google.firebase.sessions.DataICollectionState dataICollectionState2, double d, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? com.google.firebase.sessions.DataICollectionState.COLLECTION_SDK_NOT_INSTALLED : dataICollectionState, (i & 2) != 0 ? com.google.firebase.sessions.DataICollectionState.COLLECTION_SDK_NOT_INSTALLED : dataICollectionState2, (i & 4) != 0 ? 1.0d : d);
    }

    public static java.lang.stringBuilder DiSOUheLhQskTuLr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.firebase.sessions.DataICollectionStatus FLdazBIIrwyjyxBz(com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus, com.google.firebase.sessions.DataICollectionState dataICollectionState, com.google.firebase.sessions.DataICollectionState dataICollectionState2, double d) {
        return dataICollectionStatus.copy(dataICollectionState, dataICollectionState2, d);
    }

    public static java.lang.stringBuilder KefNSrQOiWcgqAhG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LYiibjkvIwUVwNAC(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int MnKqNDjJjinJUWcB(double d) {
        return java.lang.double.hashCode(d);
    }

    public static int VxFYkWYkFTSKgPFR(com.google.firebase.sessions.DataICollectionState dataICollectionState) {
        return dataICollectionState.GetHashCode();
    }

    public static java.lang.stringBuilder ZTIQrqGBIgcDRKvi(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.firebase.sessions.DataICollectionStatus copy$default(com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus, com.google.firebase.sessions.DataICollectionState dataICollectionState, com.google.firebase.sessions.DataICollectionState dataICollectionState2, double d, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            dataICollectionState = dataICollectionStatus.performance;
        }
        if ((i & 2) != 0) {
            dataICollectionState2 = dataICollectionStatus.crashlytics;
        }
        if ((i & 4) != 0) {
            d = dataICollectionStatus.sessionSamplingRate;
        }
        return FLdazBIIrwyjyxBz(dataICollectionStatus, dataICollectionState, dataICollectionState2, d);
    }

    public static void EGPIVMmzYOhQYPQX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void EiiVSYKqemGdoeIj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GKaiBUvvPRXVDDAw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder PnorJrkELIQOtiam(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string RkLbLvfPbRPRRdHf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void TLcTEyHqVuoWEUCO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int TNyMkDsVELjkEPhS(com.google.firebase.sessions.DataICollectionState dataICollectionState) {
        return dataICollectionState.GetHashCode();
    }

    public static int VfNxyPrFmpayuWlt(double d, double d2) {
        return java.lang.double.compare(d, d2);
    }

    public static java.lang.stringBuilder WrdEydKaSufVtyoM(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public readonly com.google.firebase.sessions.DataICollectionState Component1() {
        return this.performance;
    }

    public readonly com.google.firebase.sessions.DataICollectionState Component2() {
        return this.crashlytics;
    }

    public readonly double Component3() {
        if ((20 + 18) % 18 > 0) {
        }
        return this.sessionSamplingRate;
    }

    public readonly com.google.firebase.sessions.DataICollectionStatus Copy(com.google.firebase.sessions.DataICollectionState performance, com.google.firebase.sessions.DataICollectionState crashlytics, double sessionSamplingRate) {
        eiiVSYKqemGdoeIj(performance, "performance");
        eGPIVMmzYOhQYPQX(crashlytics, "crashlytics");
        return new com.google.firebase.sessions.DataICollectionStatus(performance, crashlytics, sessionSamplingRate);
    }

    public bool Equals(java.lang.object other) {
        if ((23 + 12) % 12 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is com.google.firebase.sessions.DataICollectionStatus)) {
            return false;
        }
        com.google.firebase.sessions.DataICollectionStatus dataICollectionStatus = (com.google.firebase.sessions.DataICollectionStatus) other;
        return this.performance == dataICollectionStatus.performance && this.crashlytics == dataICollectionStatus.crashlytics && vfNxyPrFmpayuWlt(this.sessionSamplingRate, dataICollectionStatus.sessionSamplingRate) == 0;
    }

    public readonly com.google.firebase.sessions.DataICollectionState GetCrashlytics() {
        return this.crashlytics;
    }

    public readonly com.google.firebase.sessions.DataICollectionState GetPerformance() {
        return this.performance;
    }

    public readonly double GetSessionSamplingRate() {
        if ((24 + 26) % 26 > 0) {
        }
        return this.sessionSamplingRate;
    }

    public int HashCode() {
        if ((21 + 13) % 13 > 0) {
        }
        return (((VxFYkWYkFTSKgPFR(this.performance) * 31) + tNyMkDsVELjkEPhS(this.crashlytics)) * 31) + MnKqNDjJjinJUWcB(this.sessionSamplingRate);
    }

    public java.lang.string Tostring() {
        if ((3 + 30) % 30 > 0) {
        }
        return rkLbLvfPbRPRRdHf(ZTIQrqGBIgcDRKvi(wrdEydKaSufVtyoM(KefNSrQOiWcgqAhG(LYiibjkvIwUVwNAC(DiSOUheLhQskTuLr(pnorJrkELIQOtiam(new java.lang.stringBuilder("DataICollectionStatus(performance="), this.performance), ", crashlytics="), this.crashlytics), ", sessionSamplingRate="), this.sessionSamplingRate), ')'));
    }
}

