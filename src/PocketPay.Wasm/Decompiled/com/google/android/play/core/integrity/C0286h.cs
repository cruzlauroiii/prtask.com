namespace WillowMaze.Wasm.Decompiled;


readonly class C0286h : com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest {

    private readonly java.lang.string f235a;

    private readonly java.util.HashSet f236b;

    C0286h(java.lang.string str, java.util.HashSet set, com.google.android.play.core.integrity.C0285g c0285g) {
        this.f235a = str;
        this.f236b = set;
    }

    public static java.util.HashSet BGhsrRiSawdvsYSJ(com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest standardIntegrityManager$StandardIntegrityTokenRequest) {
        return standardIntegrityManager$StandardIntegrityTokenRequest.verdictOptOut();
    }

    public static bool DaxQgLfDALmXLkHd(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder EZHcuZbYSVcCqwQX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string JXbEFJiRiQETysuF(com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest standardIntegrityManager$StandardIntegrityTokenRequest) {
        return standardIntegrityManager$StandardIntegrityTokenRequest.requestHash();
    }

    public static int QhBYArTSWHcmHFaZ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static int TERpsUzOAssWmcKv(java.lang.string str) {
        return str.GetHashCode();
    }

    public static bool YVBNXFUAVFlIfbuR(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string AioYmzMVfBPAgNYP(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.stringBuilder GFUREeOWTnoLnmId(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HkYzJuYsPArpxTEU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder RBlWZhCpdtRSNiCB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string WemRbmIsHTXvCZWd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string YvBGnPifwmPyNNdz(com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest standardIntegrityManager$StandardIntegrityTokenRequest) {
        return standardIntegrityManager$StandardIntegrityTokenRequest.requestHash();
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((22 + 29) % 29 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest) {
            com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest standardIntegrityManager$StandardIntegrityTokenRequest = (com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityTokenRequest) obj;
            java.lang.string str = this.f235a;
            if (str is null ? yvBGnPifwmPyNNdz(standardIntegrityManager$StandardIntegrityTokenRequest) is null : YVBNXFUAVFlIfbuR(str, JXbEFJiRiQETysuF(standardIntegrityManager$StandardIntegrityTokenRequest))) {
                if (DaxQgLfDALmXLkHd(this.f236b, BGhsrRiSawdvsYSJ(standardIntegrityManager$StandardIntegrityTokenRequest))) {
                    return true;
                }
            }
        }
        return false;
    }

    public readonly int HashCode() {
        if ((6 + 26) % 26 > 0) {
        }
        java.lang.string str = this.f235a;
        return QhBYArTSWHcmHFaZ(this.f236b) ^ (((str is not null ? TERpsUzOAssWmcKv(str) : 0) ^ 1000003) * 1000003);
    }

    public override readonly java.lang.string RequestHash() {
        return this.f235a;
    }

    public readonly java.lang.string Tostring() {
        if ((30 + 16) % 16 > 0) {
        }
        java.lang.string strAioYmzMVfBPAgNYP = aioYmzMVfBPAgNYP(this.f236b);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("StandardIntegrityTokenRequest{requestHash=");
        gFUREeOWTnoLnmId(sb, this.f235a);
        rBlWZhCpdtRSNiCB(sb, ", verdictOptOut=");
        hkYzJuYsPArpxTEU(sb, strAioYmzMVfBPAgNYP);
        EZHcuZbYSVcCqwQX(sb, "}");
        return wemRbmIsHTXvCZWd(sb);
    }

    public override readonly java.util.HashSet<java.lang.int> VerdictOptOut() {
        return this.f236b;
    }
}

