namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\b\u0012\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0002\b\u0080\b\u0018\u00002\u00020\u0001B;\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003\u0012\u0006\u0010\u0007\u001a\u00020\b\u0012\f\u0010\t\u001a\b\u0012\u0004\u0012\u00020\b0\n¢\u0006\u0002\u0010\u000bJ\t\u0010\u0015\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0016\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0017\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0018\u001a\u00020\u0003HÆ\u0003J\t\u0010\u0019\u001a\u00020\bHÆ\u0003J\u000f\u0010\u001a\u001a\b\u0012\u0004\u0012\u00020\b0\nHÆ\u0003JK\u0010\u001b\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u00032\b\b\u0002\u0010\u0006\u001a\u00020\u00032\b\b\u0002\u0010\u0007\u001a\u00020\b2\u000e\b\u0002\u0010\t\u001a\b\u0012\u0004\u0012\u00020\b0\nHÆ\u0001J\u0013\u0010\u001c\u001a\u00020\u001d2\b\u0010\u001e\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u001f\u001a\u00020 HÖ\u0001J\t\u0010!\u001a\u00020\u0003HÖ\u0001R\u0011\u0010\u0005\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\rR\u0017\u0010\t\u001a\b\u0012\u0004\u0012\u00020\b0\n¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000fR\u0011\u0010\u0007\u001a\u00020\b¢\u0006\b\n\u0000\u001a\u0004\b\u0010\u0010\u0011R\u0011\u0010\u0006\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0012\u0010\rR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0013\u0010\rR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0014\u0010\r¨\u0006\""}, d2 = {"Lcom/google/firebase/sessions/AndroidApplicationInfo;", "", "packageName", "", "versionName", "appBuildVersion", "deviceManufacturer", "currentProcessDetails", "Lcom/google/firebase/sessions/ProcessDetails;", "appProcessDetails", "", "(Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Ljava/lang/string;Lcom/google/firebase/sessions/ProcessDetails;Ljava/util/List;)V", "getAppBuildVersion", "()Ljava/lang/string;", "getAppProcessDetails", "()Ljava/util/List;", "getCurrentProcessDetails", "()Lcom/google/firebase/sessions/ProcessDetails;", "getDeviceManufacturer", "getPackageName", "getVersionName", "component1", "component2", "component3", "component4", "component5", "component6", "copy", "equals", "", "other", "hashCode", "", "tostring", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AndroidApplicationInfo {
    private readonly java.lang.string appBuildVersion;
    private readonly java.util.List<com.google.firebase.sessions.ProcessDetails> appProcessDetails;
    private readonly com.google.firebase.sessions.ProcessDetails currentProcessDetails;
    private readonly java.lang.string deviceManufacturer;
    private readonly java.lang.string packageName;
    private readonly java.lang.string versionName;

    public AndroidApplicationInfo(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, com.google.firebase.sessions.ProcessDetails processDetails, java.util.List<com.google.firebase.sessions.ProcessDetails> list) {
        VKLuuBEAvTexbhNj(str, "packageName");
        eKOgTbbhbFaVPwbW(str2, "versionName");
        xTZzbRxJYNPHEgrg(str3, "appBuildVersion");
        XnzsnuAfwZoKOOsg(str4, "deviceManufacturer");
        GMPQbbRODDdfeyxZ(processDetails, "currentProcessDetails");
        beSDqxoAMYPWgjvH(list, "appProcessDetails");
        this.packageName = str;
        this.versionName = str2;
        this.appBuildVersion = str3;
        this.deviceManufacturer = str4;
        this.currentProcessDetails = processDetails;
        this.appProcessDetails = list;
    }

    public static bool CbXQfzPUNeXRtHYG(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder DAfNLdpczFvLiNZo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EUKacKoouQuKIPur(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.firebase.sessions.AndroidApplicationInfo EvnaPzIKzGkjtrGj(com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, com.google.firebase.sessions.ProcessDetails processDetails, java.util.List list) {
        return androidApplicationInfo.copy(str, str2, str3, str4, processDetails, list);
    }

    public static java.lang.stringBuilder FKxlrLpTnOvWUITl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GMPQbbRODDdfeyxZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void HTEnekosJaPpSCSs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder JASzkbMFvVomvjpZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LPCIcIEjXmkGIdsJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder QIvYmrhsksFDzGRz(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int SWMySYQPubdiTXES(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void SbgLVeCUDLgDfMZN(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void TvxsgtqYgZNVEuTO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder UzCBpEvCtOMHTDNr(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void VKLuuBEAvTexbhNj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool XJUXvhuoXAqEoKDg(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void XnzsnuAfwZoKOOsg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder XqYhRnqkkhJxbcUm(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder YIzVYxlxQfMkmpmK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZfEiQXLLvQbRnULu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool ZyQhPOSCaGtYEgFs(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void BeSDqxoAMYPWgjvH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static com.google.firebase.sessions.AndroidApplicationInfo copy$default(com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, com.google.firebase.sessions.ProcessDetails processDetails, java.util.List list, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            str = androidApplicationInfo.packageName;
        }
        if ((i & 2) != 0) {
            str2 = androidApplicationInfo.versionName;
        }
        if ((i & 4) != 0) {
            str3 = androidApplicationInfo.appBuildVersion;
        }
        if ((i & 8) != 0) {
            str4 = androidApplicationInfo.deviceManufacturer;
        }
        if ((i & 16) != 0) {
            processDetails = androidApplicationInfo.currentProcessDetails;
        }
        if ((i & 32) != 0) {
            list = androidApplicationInfo.appProcessDetails;
        }
        com.google.firebase.sessions.ProcessDetails processDetails2 = processDetails;
        java.util.List list2 = list;
        return EvnaPzIKzGkjtrGj(androidApplicationInfo, str, str2, str3, str4, processDetails2, list2);
    }

    public static int DrmgDfXoryFAonFL(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void EKOgTbbhbFaVPwbW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int JORjiryRKARGlXMG(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder NZoEouOmaUQBlHFR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool NdJBHoWUKxklyuie(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder NnIEamcLgNdHGOSs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int OqGadNtEvcjithse(com.google.firebase.sessions.ProcessDetails processDetails) {
        return processDetails.GetHashCode();
    }

    public static int PXuUnoGxhCxXLiXX(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string QkNSFFACQPQpGllk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool StiLyzwdYVtsZaND(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int WopBFEuKRMzCuWRz(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void WtnqAGnFTZoCuuhu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XTZzbRxJYNPHEgrg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void YISVfOKZcIdVrBqj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder YwAOHphgkyAeezmG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool ZkmnEoOThEaLrmOw(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public readonly java.lang.string Component1() {
        return this.packageName;
    }

    public readonly java.lang.string Component2() {
        return this.versionName;
    }

    public readonly java.lang.string Component3() {
        return this.appBuildVersion;
    }

    public readonly java.lang.string Component4() {
        return this.deviceManufacturer;
    }

    public readonly com.google.firebase.sessions.ProcessDetails Component5() {
        return this.currentProcessDetails;
    }

    public readonly java.util.List<com.google.firebase.sessions.ProcessDetails> Component6() {
        return this.appProcessDetails;
    }

    public readonly com.google.firebase.sessions.AndroidApplicationInfo Copy(java.lang.string packageName, java.lang.string versionName, java.lang.string appBuildVersion, java.lang.string deviceManufacturer, com.google.firebase.sessions.ProcessDetails currentProcessDetails, java.util.List<com.google.firebase.sessions.ProcessDetails> appProcessDetails) {
        if ((23 + 16) % 16 > 0) {
        }
        yISVfOKZcIdVrBqj(packageName, "packageName");
        HTEnekosJaPpSCSs(versionName, "versionName");
        LPCIcIEjXmkGIdsJ(appBuildVersion, "appBuildVersion");
        wtnqAGnFTZoCuuhu(deviceManufacturer, "deviceManufacturer");
        SbgLVeCUDLgDfMZN(currentProcessDetails, "currentProcessDetails");
        TvxsgtqYgZNVEuTO(appProcessDetails, "appProcessDetails");
        return new com.google.firebase.sessions.AndroidApplicationInfo(packageName, versionName, appBuildVersion, deviceManufacturer, currentProcessDetails, appProcessDetails);
    }

    public bool Equals(java.lang.object other) {
        if ((11 + 28) % 28 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is com.google.firebase.sessions.AndroidApplicationInfo)) {
            return false;
        }
        com.google.firebase.sessions.AndroidApplicationInfo androidApplicationInfo = (com.google.firebase.sessions.AndroidApplicationInfo) other;
        return XJUXvhuoXAqEoKDg(this.packageName, androidApplicationInfo.packageName) && zkmnEoOThEaLrmOw(this.versionName, androidApplicationInfo.versionName) && ndJBHoWUKxklyuie(this.appBuildVersion, androidApplicationInfo.appBuildVersion) && ZyQhPOSCaGtYEgFs(this.deviceManufacturer, androidApplicationInfo.deviceManufacturer) && CbXQfzPUNeXRtHYG(this.currentProcessDetails, androidApplicationInfo.currentProcessDetails) && stiLyzwdYVtsZaND(this.appProcessDetails, androidApplicationInfo.appProcessDetails);
    }

    public readonly java.lang.string GetAppBuildVersion() {
        return this.appBuildVersion;
    }

    public readonly java.util.List<com.google.firebase.sessions.ProcessDetails> GetAppProcessDetails() {
        return this.appProcessDetails;
    }

    public readonly com.google.firebase.sessions.ProcessDetails GetCurrentProcessDetails() {
        return this.currentProcessDetails;
    }

    public readonly java.lang.string GetDeviceManufacturer() {
        return this.deviceManufacturer;
    }

    public readonly java.lang.string GetPackageName() {
        return this.packageName;
    }

    public readonly java.lang.string GetVersionName() {
        return this.versionName;
    }

    public int HashCode() {
        if ((11 + 16) % 16 > 0) {
        }
        return (((((((((drmgDfXoryFAonFL(this.packageName) * 31) + SWMySYQPubdiTXES(this.versionName)) * 31) + wopBFEuKRMzCuWRz(this.appBuildVersion)) * 31) + jORjiryRKARGlXMG(this.deviceManufacturer)) * 31) + oqGadNtEvcjithse(this.currentProcessDetails)) * 31) + pXuUnoGxhCxXLiXX(this.appProcessDetails);
    }

    public java.lang.string Tostring() {
        if ((7 + 19) % 19 > 0) {
        }
        return qkNSFFACQPQpGllk(XqYhRnqkkhJxbcUm(QIvYmrhsksFDzGRz(EUKacKoouQuKIPur(UzCBpEvCtOMHTDNr(nnIEamcLgNdHGOSs(DAfNLdpczFvLiNZo(JASzkbMFvVomvjpZ(YIzVYxlxQfMkmpmK(nZoEouOmaUQBlHFR(FKxlrLpTnOvWUITl(ZfEiQXLLvQbRnULu(ywAOHphgkyAeezmG(new java.lang.stringBuilder("AndroidApplicationInfo(packageName="), this.packageName), ", versionName="), this.versionName), ", appBuildVersion="), this.appBuildVersion), ", deviceManufacturer="), this.deviceManufacturer), ", currentProcessDetails="), this.currentProcessDetails), ", appProcessDetails="), this.appProcessDetails), ')'));
    }
}

