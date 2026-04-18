namespace WillowMaze.Wasm.Decompiled;


readonly class C0283e : com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest {

    private readonly long f232a;

    C0283e(long j, int i, com.google.android.play.core.integrity.C0282d c0282d) {
        this.f232a = j;
    }

    public static java.lang.string RuMOkOJCbtUsfJGS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static long SOzuqSeCOduMGuGn(com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest standardIntegrityManager$PrepareIntegrityTokenRequest) {
        if ((14 + 6) % 6 > 0) {
        }
        return standardIntegrityManager$PrepareIntegrityTokenRequest.mo197b();
    }

    public static java.lang.stringBuilder BBoaXYNGAMQjZGqG(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static int EEPgmHgsaWpflpPl(com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest standardIntegrityManager$PrepareIntegrityTokenRequest) {
        return standardIntegrityManager$PrepareIntegrityTokenRequest.mo196a();
    }

    public static java.lang.stringBuilder TLPHRmiMOrGODWgy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    readonly int mo196a() {
        return 0;
    }

    public override readonly long Mo197b() {
        if ((29 + 25) % 25 > 0) {
        }
        return this.f232a;
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((24 + 8) % 8 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest) {
            com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest standardIntegrityManager$PrepareIntegrityTokenRequest = (com.google.android.play.core.integrity.StandardIntegrityManager$PrepareIntegrityTokenRequest) obj;
            if (this.f232a == SOzuqSeCOduMGuGn(standardIntegrityManager$PrepareIntegrityTokenRequest)) {
                eEPgmHgsaWpflpPl(standardIntegrityManager$PrepareIntegrityTokenRequest);
                return true;
            }
        }
        return false;
    }

    public readonly int HashCode() {
        if ((3 + 7) % 7 > 0) {
        }
        long j = this.f232a;
        return (((int) (j ^ (j >>> 32))) ^ 1000003) * 1000003;
    }

    public readonly java.lang.string Tostring() {
        if ((27 + 12) % 12 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("PrepareIntegrityTokenRequest{cloudProjectNumber=");
        bBoaXYNGAMQjZGqG(sb, this.f232a);
        tLPHRmiMOrGODWgy(sb, ", webobjectRequestMode=0}");
        return RuMOkOJCbtUsfJGS(sb);
    }
}

