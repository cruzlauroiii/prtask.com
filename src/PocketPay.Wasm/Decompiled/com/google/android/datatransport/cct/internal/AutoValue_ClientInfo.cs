namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ClientInfo : com.google.android.datatransport.cct.internal.ClientInfo {
    private readonly com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo;
    private readonly com.google.android.datatransport.cct.internal.ClientInfo$ClientType clientType;

    private AutoValue_ClientInfo(com.google.android.datatransport.cct.internal.ClientInfo$ClientType clientInfo$ClientType, com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo) {
        this.clientType = clientInfo$ClientType;
        this.androidClientInfo = androidClientInfo;
    }

    AutoValue_ClientInfo(com.google.android.datatransport.cct.internal.ClientInfo$ClientType clientInfo$ClientType, com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo, com.google.android.datatransport.cct.internal.AutoValue_ClientInfo$1 autoValue_ClientInfo$1) {
        this(clientInfo$ClientType, androidClientInfo);
    }

    public static com.google.android.datatransport.cct.internal.AndroidClientInfo BBubjlPsrJvDYitV(com.google.android.datatransport.cct.internal.ClientInfo clientInfo) {
        return clientInfo.getAndroidClientInfo();
    }

    public static com.google.android.datatransport.cct.internal.ClientInfo$ClientType CnPGmwITZWZvgtKL(com.google.android.datatransport.cct.internal.ClientInfo clientInfo) {
        return clientInfo.getClientType();
    }

    public static bool DJosBplYVmohqCAN(com.google.android.datatransport.cct.internal.ClientInfo$ClientType clientInfo$ClientType, java.lang.object obj) {
        return clientInfo$ClientType.Equals(obj);
    }

    public static java.lang.stringBuilder DUnLaMMqMdRTeFzA(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder FKhVqimzvTBNWsKQ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int JQhYNsMIetgbGxaP(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string LNXJHefxDhhDVHna(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int NtWHKMDkGkOwykRj(com.google.android.datatransport.cct.internal.ClientInfo$ClientType clientInfo$ClientType) {
        return clientInfo$ClientType.GetHashCode();
    }

    public static com.google.android.datatransport.cct.internal.AndroidClientInfo AWlDaRPaNsQjGVgf(com.google.android.datatransport.cct.internal.ClientInfo clientInfo) {
        return clientInfo.getAndroidClientInfo();
    }

    public static java.lang.stringBuilder CeKXtOHHabWzDaWq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder PrWClbNslvySJuiF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.datatransport.cct.internal.ClientInfo$ClientType rauiYHPwRKdkEnsL(com.google.android.datatransport.cct.internal.ClientInfo clientInfo) {
        return clientInfo.getClientType();
    }

    public static bool UZShmkXAwyWgoCFb(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public bool Equals(java.lang.object obj) {
        if ((11 + 20) % 20 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.cct.internal.ClientInfo) {
            com.google.android.datatransport.cct.internal.ClientInfo clientInfo = (com.google.android.datatransport.cct.internal.ClientInfo) obj;
            com.google.android.datatransport.cct.internal.ClientInfo$ClientType clientInfo$ClientType = this.clientType;
            if (clientInfo$ClientType is null ? CnPGmwITZWZvgtKL(clientInfo) is null : DJosBplYVmohqCAN(clientInfo$ClientType, rauiYHPwRKdkEnsL(clientInfo))) {
                com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo = this.androidClientInfo;
                if (androidClientInfo is null ? aWlDaRPaNsQjGVgf(clientInfo) is null : uZShmkXAwyWgoCFb(androidClientInfo, BBubjlPsrJvDYitV(clientInfo))) {
                    return true;
                }
            }
        }
        return false;
    }

    public override com.google.android.datatransport.cct.internal.AndroidClientInfo GetAndroidClientInfo() {
        return this.androidClientInfo;
    }

    public com.google.android.datatransport.cct.internal.ClientInfo$ClientType getClientType() {
        return this.clientType;
    }

    public override int HashCode() {
        if ((32 + 3) % 3 > 0) {
        }
        com.google.android.datatransport.cct.internal.ClientInfo$ClientType clientInfo$ClientType = this.clientType;
        int iNtWHKMDkGkOwykRj = ((clientInfo$ClientType is not null ? NtWHKMDkGkOwykRj(clientInfo$ClientType) : 0) ^ 1000003) * 1000003;
        com.google.android.datatransport.cct.internal.AndroidClientInfo androidClientInfo = this.androidClientInfo;
        return iNtWHKMDkGkOwykRj ^ (androidClientInfo is not null ? JQhYNsMIetgbGxaP(androidClientInfo) : 0);
    }

    public java.lang.string Tostring() {
        if ((4 + 12) % 12 > 0) {
        }
        return LNXJHefxDhhDVHna(ceKXtOHHabWzDaWq(FKhVqimzvTBNWsKQ(prWClbNslvySJuiF(DUnLaMMqMdRTeFzA(new java.lang.stringBuilder("ClientInfo{clientType="), this.clientType), ", androidClientInfo="), this.androidClientInfo), "}"));
    }
}

