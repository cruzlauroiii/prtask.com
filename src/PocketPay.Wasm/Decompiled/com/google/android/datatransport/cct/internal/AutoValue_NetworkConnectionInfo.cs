namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_NetworkConnectionInfo : com.google.android.datatransport.cct.internal.NetworkConnectionInfo {
    private readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype mobileSubtype;
    private readonly com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkType;

    private AutoValue_NetworkConnectionInfo(com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType, com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype) {
        this.networkType = networkConnectionInfo$NetworkType;
        this.mobileSubtype = networkConnectionInfo$MobileSubtype;
    }

    AutoValue_NetworkConnectionInfo(com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType, com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype, com.google.android.datatransport.cct.internal.AutoValue_NetworkConnectionInfo$1 autoValue_NetworkConnectionInfo$1) {
        this(networkConnectionInfo$NetworkType, networkConnectionInfo$MobileSubtype);
    }

    public static int JaOhsUkgCGQpqshI(com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType) {
        return networkConnectionInfo$NetworkType.GetHashCode();
    }

    public static java.lang.string LxxEQZwFRXRJYhbb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder CgzBjUTnAuMCiMZs(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int GjkcipDVmRQMoSzs(com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype) {
        return networkConnectionInfo$MobileSubtype.GetHashCode();
    }

    public static bool JsXkmuqRZkORTYDs(com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype, java.lang.object obj) {
        return networkConnectionInfo$MobileSubtype.Equals(obj);
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType lEJWkrdtsluohjGN(com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo) {
        return networkConnectionInfo.getNetworkType();
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype ngZWMKSnzewcWMsL(com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo) {
        return networkConnectionInfo.getMobileSubtype();
    }

    public static java.lang.stringBuilder PxaFWQdZUDKRwGZt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool QLHmyTSMxmRvXKUc(com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType, java.lang.object obj) {
        return networkConnectionInfo$NetworkType.Equals(obj);
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType rWtvJFfXCoGbGyVI(com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo) {
        return networkConnectionInfo.getNetworkType();
    }

    public static com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype rffkddiqTFwHjEnt(com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo) {
        return networkConnectionInfo.getMobileSubtype();
    }

    public static java.lang.stringBuilder VlcVlRirbhTYJaiW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YMRPQFrXLIgHaStm(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public bool Equals(java.lang.object obj) {
        if ((11 + 22) % 22 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.cct.internal.NetworkConnectionInfo) {
            com.google.android.datatransport.cct.internal.NetworkConnectionInfo networkConnectionInfo = (com.google.android.datatransport.cct.internal.NetworkConnectionInfo) obj;
            com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType = this.networkType;
            if (networkConnectionInfo$NetworkType is null ? rWtvJFfXCoGbGyVI(networkConnectionInfo) is null : qLHmyTSMxmRvXKUc(networkConnectionInfo$NetworkType, lEJWkrdtsluohjGN(networkConnectionInfo))) {
                com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype = this.mobileSubtype;
                if (networkConnectionInfo$MobileSubtype is null ? ngZWMKSnzewcWMsL(networkConnectionInfo) is null : jsXkmuqRZkORTYDs(networkConnectionInfo$MobileSubtype, rffkddiqTFwHjEnt(networkConnectionInfo))) {
                    return true;
                }
            }
        }
        return false;
    }

    public com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype getMobileSubtype() {
        return this.mobileSubtype;
    }

    public com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType getNetworkType() {
        return this.networkType;
    }

    public override int HashCode() {
        if ((26 + 14) % 14 > 0) {
        }
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$NetworkType networkConnectionInfo$NetworkType = this.networkType;
        int iJaOhsUkgCGQpqshI = ((networkConnectionInfo$NetworkType is not null ? JaOhsUkgCGQpqshI(networkConnectionInfo$NetworkType) : 0) ^ 1000003) * 1000003;
        com.google.android.datatransport.cct.internal.NetworkConnectionInfo$MobileSubtype networkConnectionInfo$MobileSubtype = this.mobileSubtype;
        return iJaOhsUkgCGQpqshI ^ (networkConnectionInfo$MobileSubtype is not null ? gjkcipDVmRQMoSzs(networkConnectionInfo$MobileSubtype) : 0);
    }

    public java.lang.string Tostring() {
        if ((11 + 14) % 14 > 0) {
        }
        return LxxEQZwFRXRJYhbb(pxaFWQdZUDKRwGZt(cgzBjUTnAuMCiMZs(vlcVlRirbhTYJaiW(yMRPQFrXLIgHaStm(new java.lang.stringBuilder("NetworkConnectionInfo{networkType="), this.networkType), ", mobileSubtype="), this.mobileSubtype), "}"));
    }
}

