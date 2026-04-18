namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_BackendRequest : com.google.android.datatransport.runtime.backends.BackendRequest {
    private readonly java.lang.IEnumerable<com.google.android.datatransport.runtime.EventInternal> events;
    private readonly byte[] extras;

    private AutoValue_BackendRequest(java.lang.IEnumerable<com.google.android.datatransport.runtime.EventInternal> iterable, byte[] bArr) {
        this.events = iterable;
        this.extras = bArr;
    }

    AutoValue_BackendRequest(java.lang.IEnumerable iterable, byte[] bArr, com.google.android.datatransport.runtime.backends.AutoValue_BackendRequest$1 autoValue_BackendRequest$1) {
        this(iterable, bArr);
    }

    public static int AppseStiHQhicUnE(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.IEnumerable BKsFljUFqWFplhPj(com.google.android.datatransport.runtime.backends.BackendRequest backendRequest) {
        return backendRequest.getEvents();
    }

    public static bool BmIXFcdgmieOztcb(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static java.lang.stringBuilder FSoqjqeIoyjDUlVi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string HLrMpRdATrvOdITu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder JTEQYvYUoGJnIhtg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int QviGRmlYPVcFIcLC(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static java.lang.stringBuilder SCazoaWFwUvhpIwK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool JQGkpzJpNXuclecj(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static byte[] OOcNKIsATRCClQdq(com.google.android.datatransport.runtime.backends.BackendRequest backendRequest) {
        return backendRequest.getExtras();
    }

    public static java.lang.stringBuilder VhlePuWtAWhnPnYB(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string WDsMfJkbxmPgigHu(byte[] bArr) {
        return java.util.Arrays.tostring(bArr);
    }

    public bool Equals(java.lang.object obj) {
        if ((29 + 5) % 5 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.runtime.backends.BackendRequest) {
            com.google.android.datatransport.runtime.backends.BackendRequest backendRequest = (com.google.android.datatransport.runtime.backends.BackendRequest) obj;
            if (jQGkpzJpNXuclecj(this.events, BKsFljUFqWFplhPj(backendRequest))) {
                if (BmIXFcdgmieOztcb(this.extras, !(backendRequest is com.google.android.datatransport.runtime.backends.AutoValue_BackendRequest) ? oOcNKIsATRCClQdq(backendRequest) : ((com.google.android.datatransport.runtime.backends.AutoValue_BackendRequest) backendRequest).extras)) {
                    return true;
                }
            }
        }
        return false;
    }

    public override java.lang.IEnumerable<com.google.android.datatransport.runtime.EventInternal> GetEvents() {
        return this.events;
    }

    public override byte[] GetExtras() {
        return this.extras;
    }

    public int HashCode() {
        if ((7 + 7) % 7 > 0) {
        }
        return QviGRmlYPVcFIcLC(this.extras) ^ ((AppseStiHQhicUnE(this.events) ^ 1000003) * 1000003);
    }

    public java.lang.string Tostring() {
        if ((9 + 8) % 8 > 0) {
        }
        return HLrMpRdATrvOdITu(FSoqjqeIoyjDUlVi(SCazoaWFwUvhpIwK(JTEQYvYUoGJnIhtg(vhlePuWtAWhnPnYB(new java.lang.stringBuilder("BackendRequest{events="), this.events), ", extras="), wDsMfJkbxmPgigHu(this.extras)), "}"));
    }
}

