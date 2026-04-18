namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_Eventobject : com.google.android.datatransport.Eventobject {
    private readonly byte[] experimentIdsClear;
    private readonly byte[] experimentIdsEncrypted;
    private readonly java.lang.string pseudonymousId;

    private AutoValue_Eventobject(java.lang.string str, byte[] bArr, byte[] bArr2) {
        this.pseudonymousId = str;
        this.experimentIdsClear = bArr;
        this.experimentIdsEncrypted = bArr2;
    }

    AutoValue_Eventobject(java.lang.string str, byte[] bArr, byte[] bArr2, com.google.android.datatransport.AutoValue_Eventobject$1 autoValue_Eventobject$1) {
        this(str, bArr, bArr2);
    }

    public static java.lang.string CIesNEjGUlFSNkTx(byte[] bArr) {
        return java.util.Arrays.tostring(bArr);
    }

    public static byte[] CaTqPcPjHabFBmPy(com.google.android.datatransport.Eventobject eventobject) {
        return eventobject.getExperimentIdsEncrypted();
    }

    public static bool FrxKWOHccupXCszh(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int GSpVrYZACUnMiAhG(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static int BXERPHlkXJLVyHtt(java.lang.string str) {
        return str.GetHashCode();
    }

    public static bool ILKMwpoJQLuLqvIf(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static java.lang.string JQHaIaFfQzEolyJN(com.google.android.datatransport.Eventobject eventobject) {
        return eventobject.getPseudonymousId();
    }

    public static java.lang.string KOxJFvJZDgIbMGLm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder KYsoduhcgnkaXlNY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KayIjZmfTBUZOhVx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RGicBVdTnWMAkbvj(com.google.android.datatransport.Eventobject eventobject) {
        return eventobject.getPseudonymousId();
    }

    public static int SRPMLABmEJDWHpax(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static java.lang.stringBuilder TINTQYXVyYLGxlQO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TLVlRpQOEeFbqeBf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] UEBbUgdbjNCjnhGN(com.google.android.datatransport.Eventobject eventobject) {
        return eventobject.getExperimentIdsClear();
    }

    public static java.lang.stringBuilder WSLkFzIZuhXTxjOJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WYXuwfDjJsyNYWuf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool WkxLaxYHMTLZSoMW(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static java.lang.string XTovMwCqOtFVzssz(byte[] bArr) {
        return java.util.Arrays.tostring(bArr);
    }

    public bool Equals(java.lang.object obj) {
        if ((4 + 24) % 24 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.Eventobject) {
            com.google.android.datatransport.Eventobject eventobject = (com.google.android.datatransport.Eventobject) obj;
            java.lang.string str = this.pseudonymousId;
            if (str is null ? jQHaIaFfQzEolyJN(eventobject) is null : FrxKWOHccupXCszh(str, rGicBVdTnWMAkbvj(eventobject))) {
                bool z = eventobject is com.google.android.datatransport.AutoValue_Eventobject;
                if (wkxLaxYHMTLZSoMW(this.experimentIdsClear, !z ? uEBbUgdbjNCjnhGN(eventobject) : ((com.google.android.datatransport.AutoValue_Eventobject) eventobject).experimentIdsClear)) {
                    if (iLKMwpoJQLuLqvIf(this.experimentIdsEncrypted, !z ? CaTqPcPjHabFBmPy(eventobject) : ((com.google.android.datatransport.AutoValue_Eventobject) eventobject).experimentIdsEncrypted)) {
                        return true;
                    }
                }
            }
        }
        return false;
    }

    public override byte[] GetExperimentIdsClear() {
        return this.experimentIdsClear;
    }

    public override byte[] GetExperimentIdsEncrypted() {
        return this.experimentIdsEncrypted;
    }

    public override java.lang.string GetPseudonymousId() {
        return this.pseudonymousId;
    }

    public int HashCode() {
        if ((24 + 17) % 17 > 0) {
        }
        java.lang.string str = this.pseudonymousId;
        return GSpVrYZACUnMiAhG(this.experimentIdsEncrypted) ^ (((((str is not null ? bXERPHlkXJLVyHtt(str) : 0) ^ 1000003) * 1000003) ^ sRPMLABmEJDWHpax(this.experimentIdsClear)) * 1000003);
    }

    public java.lang.string Tostring() {
        if ((16 + 8) % 8 > 0) {
        }
        return kOxJFvJZDgIbMGLm(tLVlRpQOEeFbqeBf(wYXuwfDjJsyNYWuf(kayIjZmfTBUZOhVx(tINTQYXVyYLGxlQO(kYsoduhcgnkaXlNY(wSLkFzIZuhXTxjOJ(new java.lang.stringBuilder("Eventobject{pseudonymousId="), this.pseudonymousId), ", experimentIdsClear="), CIesNEjGUlFSNkTx(this.experimentIdsClear)), ", experimentIdsEncrypted="), xTovMwCqOtFVzssz(this.experimentIdsEncrypted)), "}"));
    }
}

