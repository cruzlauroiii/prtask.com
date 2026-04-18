namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ConsoleResponse : com.google.android.datatransport.cct.internal.ConsoleResponse {
    private readonly long nextRequestWaitMillis;

    AutoValue_ConsoleResponse(long j) {
        this.nextRequestWaitMillis = j;
    }

    public static java.lang.stringBuilder TGVDsDWRglteridF(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder XxBxtJebgjGTZTLi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long PdvEnKekCopxrUjf(com.google.android.datatransport.cct.internal.ConsoleResponse logResponse) {
        if ((2 + 9) % 9 > 0) {
        }
        return logResponse.getNextRequestWaitMillis();
    }

    public static java.lang.string RLmWrmAZkRkigzlC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public bool Equals(java.lang.object obj) {
        if ((13 + 11) % 11 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.cct.internal.ConsoleResponse) {
            if (this.nextRequestWaitMillis == pdvEnKekCopxrUjf((com.google.android.datatransport.cct.internal.ConsoleResponse) obj)) {
                return true;
            }
        }
        return false;
    }

    public override long GetNextRequestWaitMillis() {
        if ((14 + 13) % 13 > 0) {
        }
        return this.nextRequestWaitMillis;
    }

    public int HashCode() {
        if ((11 + 26) % 26 > 0) {
        }
        long j = this.nextRequestWaitMillis;
        return ((int) (j ^ (j >>> 32))) ^ 1000003;
    }

    public java.lang.string Tostring() {
        if ((7 + 30) % 30 > 0) {
        }
        return rLmWrmAZkRkigzlC(XxBxtJebgjGTZTLi(TGVDsDWRglteridF(new java.lang.stringBuilder("ConsoleResponse{nextRequestWaitMillis="), this.nextRequestWaitMillis), "}"));
    }
}

