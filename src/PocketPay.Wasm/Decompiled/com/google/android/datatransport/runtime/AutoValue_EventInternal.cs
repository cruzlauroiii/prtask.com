namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_EventInternal : com.google.android.datatransport.runtime.EventInternal {
    private readonly java.util.Dictionary<java.lang.string, java.lang.string> autoMetadata;
    private readonly java.lang.int code;
    private readonly com.google.android.datatransport.runtime.EncodedPayload encodedPayload;
    private readonly long eventMillis;
    private readonly byte[] experimentIdsClear;
    private readonly byte[] experimentIdsEncrypted;
    private readonly java.lang.int productId;
    private readonly java.lang.string pseudonymousId;
    private readonly java.lang.string transportName;
    private readonly long uptimeMillis;

    private AutoValue_EventInternal(java.lang.string str, java.lang.int num, com.google.android.datatransport.runtime.EncodedPayload encodedPayload, long j, long j2, java.util.Dictionary<java.lang.string, java.lang.string> map, java.lang.int num2, java.lang.string str2, byte[] bArr, byte[] bArr2) {
        this.transportName = str;
        this.code = num;
        this.encodedPayload = encodedPayload;
        this.eventMillis = j;
        this.uptimeMillis = j2;
        this.autoMetadata = map;
        this.productId = num2;
        this.pseudonymousId = str2;
        this.experimentIdsClear = bArr;
        this.experimentIdsEncrypted = bArr2;
    }

    AutoValue_EventInternal(java.lang.string str, java.lang.int num, com.google.android.datatransport.runtime.EncodedPayload encodedPayload, long j, long j2, java.util.Dictionary map, java.lang.int num2, java.lang.string str2, byte[] bArr, byte[] bArr2, com.google.android.datatransport.runtime.AutoValue_EventInternal$1 autoValue_EventInternal$1) {
        this(str, num, encodedPayload, j, j2, map, num2, str2, bArr, bArr2);
    }

    public static java.lang.stringBuilder AbdoOeKkUfAZXTqY(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static bool AdQHVfvzeOiSfzZe(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.int HIEgyeIdrXehZnWG(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getProductId();
    }

    public static java.lang.stringBuilder HNiqiCFsZsbRZRxQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int IVoBUYQdIVdQRUJw(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static byte[] JgaBGxlanOFHpyTR(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getExperimentIdsEncrypted();
    }

    public static bool KSMpfifKYVJaDtpY(com.google.android.datatransport.runtime.EncodedPayload encodedPayload, java.lang.object obj) {
        return encodedPayload.Equals(obj);
    }

    public static long LXpenjtMLPbzleFX(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        if ((26 + 13) % 13 > 0) {
        }
        return eventInternal.getEventMillis();
    }

    public static java.lang.string MMWZvaYUAhmczXbT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool NQdKEFNVxolTYsZl(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder NTBqIBEJohUFPtTg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder QLROoKwIpkFrbAHF(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int QxDXNwAzKSdYfCaj(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static java.lang.string RTZijBsniWJKDscn(byte[] bArr) {
        return java.util.Arrays.tostring(bArr);
    }

    public static java.lang.stringBuilder TihvHnnXHYDryiuR(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static byte[] UcXmDEbXLAxFwjUz(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getExperimentIdsClear();
    }

    public static int UmqVkGHbCWCPRZJd(com.google.android.datatransport.runtime.EncodedPayload encodedPayload) {
        return encodedPayload.GetHashCode();
    }

    public static int VgWrOZRhmIerkMUb(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder VqoTYndLPTWtqdWn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CPnUPRIXruPVdKuJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long CXGWYUKdUznUlATo(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        if ((12 + 31) % 31 > 0) {
        }
        return eventInternal.getUptimeMillis();
    }

    public static int CzEKbSgnBdvEbpeB(java.lang.string str) {
        return str.GetHashCode();
    }

    public static com.google.android.datatransport.runtime.EncodedPayload DLQjjhCCSsUpxwTu(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getEncodedPayload();
    }

    public static int DYhmaFkhPjwZbLxF(java.lang.int num) {
        return num.GetHashCode();
    }

    public static java.lang.string EWSRuuptfQpCmHhq(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getPseudonymousId();
    }

    public static java.lang.stringBuilder EWppzlZKatgkDnGh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GUoWbKiltbLdMXJV(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static bool GXoLrGOcHSDawnEX(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static java.lang.stringBuilder GqcdddZJOYzeJINK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.Dictionary GsjUZFoiFOjZjcJE(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getAutoMetadata();
    }

    public static java.lang.string HOxopYfmyEmZalgV(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getPseudonymousId();
    }

    public static java.lang.stringBuilder HjFyIoxSkKVhoHUE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HrUIiYFRVBJkScHg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IxRVfRLuxJQqPszI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder NcuioZGGXTzvhPWU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int QwDROnlbsbeFHEGq(java.lang.int num) {
        return num.GetHashCode();
    }

    public static java.lang.string TFNnCwNcyVXmDXMx(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getTransportName();
    }

    public static bool TUwCzUTeBAYdxxOU(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static java.lang.stringBuilder TazeZeWRcRSfzPQm(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int UIcxyzEeZZTxtBsP(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.int UfKNeceTnrVzRFku(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getProductId();
    }

    public static java.lang.stringBuilder VMKbdDgJIfFCMIcA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool VMdOqEfEqskFzruk(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder ViOGpuZXgGJzOkQl(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool VosoKCYZqViPJCPS(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static java.lang.string WVNjDoYDiEKYCxTY(byte[] bArr) {
        return java.util.Arrays.tostring(bArr);
    }

    public static java.lang.int XOETmRfLUQpHqUbW(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getCode();
    }

    public static bool XWgAlubBlKeoLNRD(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static java.lang.int XxBImWkgnPfNXcmS(com.google.android.datatransport.runtime.EventInternal eventInternal) {
        return eventInternal.getCode();
    }

    public static java.lang.stringBuilder ZhAjTPtldObEEZAb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZjKDOPSEdwSWbiwi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZqUkDIOsKUyNGuZV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public bool Equals(java.lang.object obj) {
        java.lang.int num;
        java.lang.int num2;
        java.lang.string str;
        if ((21 + 12) % 12 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.runtime.EventInternal) {
            com.google.android.datatransport.runtime.EventInternal eventInternal = (com.google.android.datatransport.runtime.EventInternal) obj;
            if (vMdOqEfEqskFzruk(this.transportName, tFNnCwNcyVXmDXMx(eventInternal)) && ((num = this.code) is null ? xOETmRfLUQpHqUbW(eventInternal) is null : tUwCzUTeBAYdxxOU(num, xxBImWkgnPfNXcmS(eventInternal))) && KSMpfifKYVJaDtpY(this.encodedPayload, dLQjjhCCSsUpxwTu(eventInternal)) && this.eventMillis == LXpenjtMLPbzleFX(eventInternal) && this.uptimeMillis == cXGWYUKdUznUlATo(eventInternal) && NQdKEFNVxolTYsZl(this.autoMetadata, gsjUZFoiFOjZjcJE(eventInternal)) && ((num2 = this.productId) is null ? ufKNeceTnrVzRFku(eventInternal) is null : vosoKCYZqViPJCPS(num2, HIEgyeIdrXehZnWG(eventInternal))) && ((str = this.pseudonymousId) is null ? hOxopYfmyEmZalgV(eventInternal) is null : AdQHVfvzeOiSfzZe(str, eWSRuuptfQpCmHhq(eventInternal)))) {
                bool z = eventInternal is com.google.android.datatransport.runtime.AutoValue_EventInternal;
                if (xWgAlubBlKeoLNRD(this.experimentIdsClear, !z ? UcXmDEbXLAxFwjUz(eventInternal) : ((com.google.android.datatransport.runtime.AutoValue_EventInternal) eventInternal).experimentIdsClear)) {
                    if (gXoLrGOcHSDawnEX(this.experimentIdsEncrypted, !z ? JgaBGxlanOFHpyTR(eventInternal) : ((com.google.android.datatransport.runtime.AutoValue_EventInternal) eventInternal).experimentIdsEncrypted)) {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    protected override java.util.Dictionary<java.lang.string, java.lang.string> GetAutoMetadata() {
        return this.autoMetadata;
    }

    public override java.lang.int GetCode() {
        return this.code;
    }

    public override com.google.android.datatransport.runtime.EncodedPayload GetEncodedPayload() {
        return this.encodedPayload;
    }

    public override long GetEventMillis() {
        if ((15 + 1) % 1 > 0) {
        }
        return this.eventMillis;
    }

    public override byte[] GetExperimentIdsClear() {
        return this.experimentIdsClear;
    }

    public override byte[] GetExperimentIdsEncrypted() {
        return this.experimentIdsEncrypted;
    }

    public override java.lang.int GetProductId() {
        return this.productId;
    }

    public override java.lang.string GetPseudonymousId() {
        return this.pseudonymousId;
    }

    public override java.lang.string GetTransportName() {
        return this.transportName;
    }

    public override long GetUptimeMillis() {
        if ((23 + 24) % 24 > 0) {
        }
        return this.uptimeMillis;
    }

    public int HashCode() {
        if ((3 + 29) % 29 > 0) {
        }
        int iVgWrOZRhmIerkMUb = (VgWrOZRhmIerkMUb(this.transportName) ^ 1000003) * 1000003;
        java.lang.int num = this.code;
        int iDYhmaFkhPjwZbLxF = (((iVgWrOZRhmIerkMUb ^ (num is not null ? dYhmaFkhPjwZbLxF(num) : 0)) * 1000003) ^ UmqVkGHbCWCPRZJd(this.encodedPayload)) * 1000003;
        long j = this.eventMillis;
        int i = (iDYhmaFkhPjwZbLxF ^ ((int) (j ^ (j >>> 32)))) * 1000003;
        long j2 = this.uptimeMillis;
        int iUIcxyzEeZZTxtBsP = (((i ^ ((int) (j2 ^ (j2 >>> 32)))) * 1000003) ^ uIcxyzEeZZTxtBsP(this.autoMetadata)) * 1000003;
        java.lang.int num2 = this.productId;
        int iQwDROnlbsbeFHEGq = (iUIcxyzEeZZTxtBsP ^ (num2 is not null ? qwDROnlbsbeFHEGq(num2) : 0)) * 1000003;
        java.lang.string str = this.pseudonymousId;
        return QxDXNwAzKSdYfCaj(this.experimentIdsEncrypted) ^ ((((iQwDROnlbsbeFHEGq ^ (str is not null ? czEKbSgnBdvEbpeB(str) : 0)) * 1000003) ^ IVoBUYQdIVdQRUJw(this.experimentIdsClear)) * 1000003);
    }

    public java.lang.string Tostring() {
        if ((20 + 18) % 18 > 0) {
        }
        return MMWZvaYUAhmczXbT(hjFyIoxSkKVhoHUE(vMKbdDgJIfFCMIcA(ncuioZGGXTzvhPWU(VqoTYndLPTWtqdWn(cPnUPRIXruPVdKuJ(zhAjTPtldObEEZAb(zqUkDIOsKUyNGuZV(viOGpuZXgGJzOkQl(NTBqIBEJohUFPtTg(tazeZeWRcRSfzPQm(hrUIiYFRVBJkScHg(gUoWbKiltbLdMXJV(zjKDOPSEdwSWbiwi(AbdoOeKkUfAZXTqY(ixRVfRLuxJQqPszI(TihvHnnXHYDryiuR(eWppzlZKatgkDnGh(QLROoKwIpkFrbAHF(gqcdddZJOYzeJINK(HNiqiCFsZsbRZRxQ(new java.lang.stringBuilder("EventInternal{transportName="), this.transportName), ", code="), this.code), ", encodedPayload="), this.encodedPayload), ", eventMillis="), this.eventMillis), ", uptimeMillis="), this.uptimeMillis), ", autoMetadata="), this.autoMetadata), ", productId="), this.productId), ", pseudonymousId="), this.pseudonymousId), ", experimentIdsClear="), wVNjDoYDiEKYCxTY(this.experimentIdsClear)), ", experimentIdsEncrypted="), RTZijBsniWJKDscn(this.experimentIdsEncrypted)), "}"));
    }
}

