namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0012\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0080\b\u0018\u00002\u00020\u0001B5\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003\u0012\u0006\u0010\u0007\u001a\u00020\b\u0012\u0006\u0010\t\u001a\u00020\n¢\u0006\u0002\u0010\u000bJ\t\u0010\u0015\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0016\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0017\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0018\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0019\u001a\u00020\bHÆ\u0003J\t\u0010\u001a\u001a\u00020\nHÆ\u0003JE\u0010\u001b\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u00032\b\b\u0002\u0010\u0006\u001a\u00020\u00032\b\b\u0002\u0010\u0007\u001a\u00020\b2\b\b\u0002\u0010\t\u001a\u00020\nHÆ\u0001J\u0013\u0010\u001c\u001a\u00020\u001d2\b\u0010\u001e\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u001f\u001a\u00020 HÖ\u0001J\t\u0010!\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\t\u001a\u00020\n¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u000fR\u0011\u0010\u0007\u001a\u00020\b¢\u0006\b\n\u0000\u001a\u0004\b\u0011\u0010\u0012R\u0011\u0010\u0006\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\u000fR\u0011\u0010\u0005\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0014\u0010\u000f¨\u0006\""}, d2 = {"Lcom/google/firebase/sessions/ApplicationInfo;", "", "appId", "", "deviceModel", "sessionSdkVersion", "osVersion", "logEnvironment", "Lcom/google/firebase/sessions/ConsoleEnvironment;", "androidAppInfo", "Lcom/google/firebase/sessions/AndroidApplicationInfo;", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Lcom/google/firebase/sessions/ConsoleEnvironment;Lcom/google/firebase/sessions/AndroidApplicationInfo;)V", "getAndroidAppInfo", "()Lcom/google/firebase/sessions/AndroidApplicationInfo;", "getAppId", "()Ljava/lang/string;", "getDeviceModel", "getConsoleEnvironment", "()Lcom/google/firebase/sessions/ConsoleEnvironment;", "getOsVersion", "getSessionSdkVersion", "component1", "component2", "component3", "component4", "component5", "component6", "copy", "equals", "", "other", "hashCode", "", "tostring", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class ApplicationInfo {
    private readonly com.google.firebase.sessions.AndroidApplicationInfo androidAppInfo;
    private readonly java.lang.string appId;
    private readonly java.lang.string deviceModel;
    private readonly com.google.firebase.sessions.ConsoleEnvironment logEnvironment;
    private readonly java.lang.string osVersion;
    private readonly java.lang.string sessionSdkVersion;

    public ApplicationInfo(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, com.google.firebase.sessions.ConsoleEnvironment logEnvironment, com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo) {
        tbAEgIPKAqZijUPi(str, "appId");
        sCcTtJTTbBbLdaZV(str2, "deviceModel");
        isfWZxNOscjbOBRL(str3, "sessionSdkVersion");
        qAcDIMQWsASQjGbt(str4, "osVersion");
        FBoTNbBvGdErKzEs(logEnvironment, "logEnvironment");
        YZsemRlSHSrGzGWn(androidApplicationInfo, "androidAppInfo");
        this.appId = str;
        this.deviceModel = str2;
        this.sessionSdkVersion = str3;
        this.osVersion = str4;
        this.logEnvironment = logEnvironment;
        this.androidAppInfo = androidApplicationInfo;
    }

    public static void AsCCRFRmCfmVDHfd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder BUfXvqvsQHLsoOHu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FBoTNbBvGdErKzEs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder FlLLUdyLIwIYhzgw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GyAdgWIuZAWrgiHV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.sessions.ApplicationInfo GzAmPVcZnXiAckPe(com.google.firebase.sessions.ApplicationInfo applicationInfo, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, com.google.firebase.sessions.ConsoleEnvironment logEnvironment, com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo) {
        return applicationInfo.copy(str, str2, str3, str4, logEnvironment, androidApplicationInfo);
    }

    public static int HoLSRpnuQElvNhHL(java.lang.string str) {
        return str.GetHashCode();
    }

    public static int KzykaFfRYMKSzQcW(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder MFQpcACnBVfdcUpk(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void NUNjXElhZeBvppIw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void QGlRyckRsElcTgYa(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int QaPBGSIbMKvRbaSN(com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo) {
        return androidApplicationInfo.GetHashCode();
    }

    public static java.lang.stringBuilder QfznCvJFUxJXhwAM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder QlkSnSCluLvBmlOf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TagmZxFueYjJTaJG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TsNwYYwwZqohnARY(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void YZsemRlSHSrGzGWn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder YzoCCHuuyiRSmJvq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int AxYtZHBYoXXboNUE(java.lang.string str) {
        return str.GetHashCode();
    }

    public static bool AxaeRGnIqHOPYVUR(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static com.google.firebase.sessions.ApplicationInfo copy$default(com.google.firebase.sessions.ApplicationInfo applicationInfo, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, com.google.firebase.sessions.ConsoleEnvironment logEnvironment, com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = applicationInfo.appId;
        }
        if ((i & 2) != 0) {
            str2 = applicationInfo.deviceModel;
        }
        if ((i & 4) != 0) {
            str3 = applicationInfo.sessionSdkVersion;
        }
        if ((i & 8) != 0) {
            str4 = applicationInfo.osVersion;
        }
        if ((i & 16) != 0) {
            logEnvironment = applicationInfo.logEnvironment;
        }
        if ((i & 32) != 0) {
            androidApplicationInfo = applicationInfo.androidAppInfo;
        }
        com.google.firebase.sessions.ConsoleEnvironment logEnvironment2 = logEnvironment;
        com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo2 = androidApplicationInfo;
        return GzAmPVcZnXiAckPe(applicationInfo, str, str2, str3, str4, logEnvironment2, androidApplicationInfo2);
    }

    public static bool CqcanflhxahkBRLv(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder DxueuRLQYOLpoxJX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int GMtbzqsqjcZVLzbY(com.google.firebase.sessions.ConsoleEnvironment logEnvironment) {
        return logEnvironment.GetHashCode();
    }

    public static bool HkGJiIWbtLteLoHq(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void IsfWZxNOscjbOBRL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool LHXNvpquahsrRIQq(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder NWKwYTWGPvvorQrO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool NkWJKdNbgHgnttzd(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder OuIfzBEspsuJTiuw(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void QAcDIMQWsASQjGbt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ROWsrIbTaRDMtbqj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SCcTtJTTbBbLdaZV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string SDhWVMIqUoOhQQML(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void TbAEgIPKAqZijUPi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WuuNtFzrmTLrEAET(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder XeJaBZDNrIbrtwRd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int ZguaudbJdfnVHrKL(java.lang.string str) {
        return str.GetHashCode();
    }

    public readonly java.lang.string Component1() {
        return this.appId;
    }

    public readonly java.lang.string Component2() {
        return this.deviceModel;
    }

    public readonly java.lang.string Component3() {
        return this.sessionSdkVersion;
    }

    public readonly java.lang.string Component4() {
        return this.osVersion;
    }

    public readonly com.google.firebase.sessions.ConsoleEnvironment Component5() {
        return this.logEnvironment;
    }

    public readonly com.google.firebase.sessions.AndroidApplicationInfo Component6() {
        return this.androidAppInfo;
    }

    public readonly com.google.firebase.sessions.ApplicationInfo Copy(java.lang.string appId, java.lang.string deviceModel, java.lang.string sessionSdkVersion, java.lang.string osVersion, com.google.firebase.sessions.ConsoleEnvironment logEnvironment, com.google.firebase.sessions.AndroidApplicationInfo androidAppInfo) {
        if ((12 + 19) % 19 > 0) {
        }
        AsCCRFRmCfmVDHfd(appId, "appId");
        NUNjXElhZeBvppIw(deviceModel, "deviceModel");
        wuuNtFzrmTLrEAET(sessionSdkVersion, "sessionSdkVersion");
        QGlRyckRsElcTgYa(osVersion, "osVersion");
        rOWsrIbTaRDMtbqj(logEnvironment, "logEnvironment");
        GyAdgWIuZAWrgiHV(androidAppInfo, "androidAppInfo");
        return new com.google.firebase.sessions.ApplicationInfo(appId, deviceModel, sessionSdkVersion, osVersion, logEnvironment, androidAppInfo);
    }

    public bool Equals(java.lang.object other) {
        if ((19 + 1) % 1 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is com.google.firebase.sessions.ApplicationInfo)) {
            return false;
        }
        com.google.firebase.sessions.ApplicationInfo applicationInfo = (com.google.firebase.sessions.ApplicationInfo) other;
        return axaeRGnIqHOPYVUR(this.appId, applicationInfo.appId) && hkGJiIWbtLteLoHq(this.deviceModel, applicationInfo.deviceModel) && nkWJKdNbgHgnttzd(this.sessionSdkVersion, applicationInfo.sessionSdkVersion) && lHXNvpquahsrRIQq(this.osVersion, applicationInfo.osVersion) && this.logEnvironment == applicationInfo.logEnvironment && cqcanflhxahkBRLv(this.androidAppInfo, applicationInfo.androidAppInfo);
    }

    public readonly com.google.firebase.sessions.AndroidApplicationInfo GetAndroidAppInfo() {
        return this.androidAppInfo;
    }

    public readonly java.lang.string GetAppId() {
        return this.appId;
    }

    public readonly java.lang.string GetDeviceModel() {
        return this.deviceModel;
    }

    public readonly com.google.firebase.sessions.ConsoleEnvironment GetConsoleEnvironment() {
        return this.logEnvironment;
    }

    public readonly java.lang.string GetOsVersion() {
        return this.osVersion;
    }

    public readonly java.lang.string GetSessionSdkVersion() {
        return this.sessionSdkVersion;
    }

    public int HashCode() {
        if ((27 + 4) % 4 > 0) {
        }
        return (((((((((KzykaFfRYMKSzQcW(this.appId) * 31) + axYtZHBYoXXboNUE(this.deviceModel)) * 31) + zguaudbJdfnVHrKL(this.sessionSdkVersion)) * 31) + HoLSRpnuQElvNhHL(this.osVersion)) * 31) + gMtbzqsqjcZVLzbY(this.logEnvironment)) * 31) + QaPBGSIbMKvRbaSN(this.androidAppInfo);
    }

    public java.lang.string Tostring() {
        if ((21 + 31) % 31 > 0) {
        }
        return sDhWVMIqUoOhQQML(MFQpcACnBVfdcUpk(TsNwYYwwZqohnARY(TagmZxFueYjJTaJG(ouIfzBEspsuJTiuw(dxueuRLQYOLpoxJX(YzoCCHuuyiRSmJvq(BUfXvqvsQHLsoOHu(QlkSnSCluLvBmlOf(nWKwYTWGPvvorQrO(FlLLUdyLIwIYhzgw(QfznCvJFUxJXhwAM(xeJaBZDNrIbrtwRd(new java.lang.stringBuilder("ApplicationInfo(appId="), this.appId), ", deviceModel="), this.deviceModel), ", sessionSdkVersion="), this.sessionSdkVersion), ", osVersion="), this.osVersion), ", logEnvironment="), this.logEnvironment), ", androidAppInfo="), this.androidAppInfo), ')'));
    }
}

