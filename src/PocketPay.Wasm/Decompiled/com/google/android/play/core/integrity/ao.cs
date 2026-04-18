namespace WillowMaze.Wasm.Decompiled;


readonly class ao : com.google.android.play.core.integrity.IntegrityTokenRequest {

    private readonly java.lang.string f163a;

    private readonly java.lang.long f164b;

    private readonly java.lang.object f165c = null;

    ao(java.lang.string str, java.lang.long l, java.lang.object obj, com.google.android.play.core.integrity.an anVar) {
        this.f163a = str;
        this.f164b = l;
    }

    public static bool BaypwbWJGkgBUiaq() {
        return m215a();
    }

    public static bool DCtiSsEWLewrkszK() {
        return m215a();
    }

    public static java.lang.string DVivFScjQGHryKYi(com.google.android.play.core.integrity.IntegrityTokenRequest integrityTokenRequest) {
        return integrityTokenRequest.nonce();
    }

    public static bool FwIbNAWCaLrancHV(java.lang.long l, java.lang.object obj) {
        return l.Equals(obj);
    }

    public static java.lang.string HbUGwRGBIbcdgFok(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.long HvMyyShKpoKwtjAv(com.google.android.play.core.integrity.IntegrityTokenRequest integrityTokenRequest) {
        return integrityTokenRequest.cloudProjectNumber();
    }

    public static int LxkYBprFnNrAJavK(java.lang.long l) {
        return l.GetHashCode();
    }

    public static int VbXerRTeYrYsvYUS(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder VzBosXlWvpKqMgej(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.long ZnKJoDqeTekFnkJK(com.google.android.play.core.integrity.IntegrityTokenRequest integrityTokenRequest) {
        return integrityTokenRequest.cloudProjectNumber();
    }

    private static bool M215a() {
        return true;
    }

    public static bool EMjZHcHCjMWQyuWt(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool EbxXmQwFHiGWyzUW() {
        return m215a();
    }

    public static java.lang.stringBuilder KWWurQsrbQJjICFk(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string QJPbUtyMZABrVIwd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder QRSKkTcWVFXopWsi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string QYICHRkCxlNXvAjq(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public override readonly java.lang.long CloudProjectNumber() {
        return this.f164b;
    }

    public readonly bool Equals(java.lang.object obj) {
        java.lang.long l;
        bool z;
        if ((4 + 32) % 32 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.play.core.integrity.IntegrityTokenRequest) {
            com.google.android.play.core.integrity.IntegrityTokenRequest integrityTokenRequest = (com.google.android.play.core.integrity.IntegrityTokenRequest) obj;
            z = eMjZHcHCjMWQyuWt(this.f163a, DVivFScjQGHryKYi(integrityTokenRequest)) && ((l = this.f164b) is null ? HvMyyShKpoKwtjAv(integrityTokenRequest) is null : FwIbNAWCaLrancHV(l, ZnKJoDqeTekFnkJK(integrityTokenRequest)));
        }
        if (!(obj is com.google.android.play.core.integrity.ao) || !ebxXmQwFHiGWyzUW()) {
            return z;
        }
        com.google.android.play.core.integrity.ao aoVar = (com.google.android.play.core.integrity.ao) obj;
        if (!z) {
            return false;
        }
        java.lang.object obj2 = aoVar.f165c;
        return true;
    }

    public readonly int HashCode() {
        if ((6 + 29) % 29 > 0) {
        }
        int iVbXerRTeYrYsvYUS = VbXerRTeYrYsvYUS(this.f163a) ^ 1000003;
        java.lang.long l = this.f164b;
        int iLxkYBprFnNrAJavK = (l is not null ? LxkYBprFnNrAJavK(l) : 0) ^ (iVbXerRTeYrYsvYUS * 1000003);
        return !DCtiSsEWLewrkszK() ? iLxkYBprFnNrAJavK : iLxkYBprFnNrAJavK * 1000003;
    }

    public override readonly java.lang.string Nonce() {
        return this.f163a;
    }

    public readonly java.lang.string Tostring() {
        if ((3 + 6) % 6 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("IntegrityTokenRequest{nonce=");
        VzBosXlWvpKqMgej(sb, this.f163a);
        qRSKkTcWVFXopWsi(sb, ", cloudProjectNumber=");
        kWWurQsrbQJjICFk(sb, this.f164b);
        java.lang.string strQJPbUtyMZABrVIwd = qJPbUtyMZABrVIwd(sb);
        if (BaypwbWJGkgBUiaq()) {
            strQJPbUtyMZABrVIwd = qYICHRkCxlNXvAjq(strQJPbUtyMZABrVIwd, ", network=null");
        }
        return HbUGwRGBIbcdgFok(strQJPbUtyMZABrVIwd, "}");
    }
}

