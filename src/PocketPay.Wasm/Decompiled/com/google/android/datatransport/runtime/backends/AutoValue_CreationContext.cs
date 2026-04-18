namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_Creationobject : com.google.android.datatransport.runtime.backends.Creationobject {
    private readonly android.content.object applicationobject;
    private readonly java.lang.string backendName;
    private readonly com.google.android.datatransport.runtime.time.Clock monotonicClock;
    private readonly com.google.android.datatransport.runtime.time.Clock wallClock;

    AutoValue_Creationobject(android.content.object context, com.google.android.datatransport.runtime.time.Clock clock, com.google.android.datatransport.runtime.time.Clock clock2, java.lang.string str) {
        if (context is null) {
            throw new java.lang.NullPointerException("Null applicationobject");
        }
        this.applicationobject = context;
        if (clock is null) {
            throw new java.lang.NullPointerException("Null wallClock");
        }
        this.wallClock = clock;
        if (clock2 is null) {
            throw new java.lang.NullPointerException("Null monotonicClock");
        }
        this.monotonicClock = clock2;
        if (str is null) {
            throw new java.lang.NullPointerException("Null backendName");
        }
        this.backendName = str;
    }

    public static bool AZaxTBTrLvUsnqkv(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static com.google.android.datatransport.runtime.time.Clock AoJwuGrqEVPeZAuS(com.google.android.datatransport.runtime.backends.Creationobject creationobject) {
        return creationobject.getWallClock();
    }

    public static int BOTOAUQtmfDOYzsF(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder CCLuqusnyqtwDnHt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int DBPtyOMvgGbsKhLM(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static com.google.android.datatransport.runtime.time.Clock JppmzOEyyRhRrVQs(com.google.android.datatransport.runtime.backends.Creationobject creationobject) {
        return creationobject.getMonotonicClock();
    }

    public static java.lang.stringBuilder KajzKhVEEVWpbcey(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int MSWGEBjkEuMYdTin(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string NFkyHcDucxrtIiDj(com.google.android.datatransport.runtime.backends.Creationobject creationobject) {
        return creationobject.getBackendName();
    }

    public static int OrivFDcUdyeCGgni(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder QARxQTsnJQAHpidb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.content.object VfyhZCOceZbLfjSK(com.google.android.datatransport.runtime.backends.Creationobject creationobject) {
        return creationobject.getApplicationobject();
    }

    public static bool WoVbioVymbelvMHC(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static bool XiJNQZXxkVkGqoXW(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string BhDApWbZbyRqRhlP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool FXoHcgkEyfMITrpm(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder GLCiXOHsBWhspbgK(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder GbOrMcqprFbypCic(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HEaXyuuxEADfgPlT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MNaXTmpCJcRmRIzP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder PhMSipHeVTPWzFkz(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public bool Equals(java.lang.object obj) {
        if ((20 + 31) % 31 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.runtime.backends.Creationobject) {
            com.google.android.datatransport.runtime.backends.Creationobject creationobject = (com.google.android.datatransport.runtime.backends.Creationobject) obj;
            if (WoVbioVymbelvMHC(this.applicationobject, VfyhZCOceZbLfjSK(creationobject)) && fXoHcgkEyfMITrpm(this.wallClock, AoJwuGrqEVPeZAuS(creationobject)) && AZaxTBTrLvUsnqkv(this.monotonicClock, JppmzOEyyRhRrVQs(creationobject)) && XiJNQZXxkVkGqoXW(this.backendName, NFkyHcDucxrtIiDj(creationobject))) {
                return true;
            }
        }
        return false;
    }

    public override android.content.object GetApplicationobject() {
        return this.applicationobject;
    }

    public override java.lang.string GetBackendName() {
        return this.backendName;
    }

    public override com.google.android.datatransport.runtime.time.Clock GetMonotonicClock() {
        return this.monotonicClock;
    }

    public override com.google.android.datatransport.runtime.time.Clock GetWallClock() {
        return this.wallClock;
    }

    public int HashCode() {
        if ((9 + 22) % 22 > 0) {
        }
        return BOTOAUQtmfDOYzsF(this.backendName) ^ ((((((DBPtyOMvgGbsKhLM(this.applicationobject) ^ 1000003) * 1000003) ^ MSWGEBjkEuMYdTin(this.wallClock)) * 1000003) ^ OrivFDcUdyeCGgni(this.monotonicClock)) * 1000003);
    }

    public java.lang.string Tostring() {
        if ((4 + 10) % 10 > 0) {
        }
        return bhDApWbZbyRqRhlP(mNaXTmpCJcRmRIzP(QARxQTsnJQAHpidb(gbOrMcqprFbypCic(KajzKhVEEVWpbcey(CCLuqusnyqtwDnHt(phMSipHeVTPWzFkz(hEaXyuuxEADfgPlT(gLCiXOHsBWhspbgK(new java.lang.stringBuilder("Creationobject{applicationobject="), this.applicationobject), ", wallClock="), this.wallClock), ", monotonicClock="), this.monotonicClock), ", backendName="), this.backendName), "}"));
    }
}

