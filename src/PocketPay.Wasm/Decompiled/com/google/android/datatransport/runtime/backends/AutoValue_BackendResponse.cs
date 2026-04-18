namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_BackendResponse : com.google.android.datatransport.runtime.backends.BackendResponse {
    private readonly long nextRequestWaitMillis;
    private readonly com.google.android.datatransport.runtime.backends.BackendResponse$Status status;

    AutoValue_BackendResponse(com.google.android.datatransport.runtime.backends.BackendResponse$Status backendResponse$Status, long j) {
        if (backendResponse$Status is null) {
            throw new java.lang.NullPointerException("Null status");
        }
        this.status = backendResponse$Status;
        this.nextRequestWaitMillis = j;
    }

    public static com.google.android.datatransport.runtime.backends.BackendResponse$Status PwelgEKVgShgPAxh(com.google.android.datatransport.runtime.backends.BackendResponse backendResponse) {
        return backendResponse.getStatus();
    }

    public static java.lang.stringBuilder QbpOJYXaKdzowwZD(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static long SniaCqneSaqumSpS(com.google.android.datatransport.runtime.backends.BackendResponse backendResponse) {
        if ((13 + 21) % 21 > 0) {
        }
        return backendResponse.getNextRequestWaitMillis();
    }

    public static java.lang.stringBuilder XGFIZvyeVZGJBZYM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string AZVKlAVFAnqxQlFR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder FtXXHRwHoNxqcAGL(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool PSWdbHOqWgzcNOax(com.google.android.datatransport.runtime.backends.BackendResponse$Status backendResponse$Status, java.lang.object obj) {
        return backendResponse$Status.Equals(obj);
    }

    public static java.lang.stringBuilder WOdkGLxBtkikTAZI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int XoGNMpBzJJFrnKXC(com.google.android.datatransport.runtime.backends.BackendResponse$Status backendResponse$Status) {
        return backendResponse$Status.GetHashCode();
    }

    public bool Equals(java.lang.object obj) {
        if ((26 + 9) % 9 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.runtime.backends.BackendResponse) {
            com.google.android.datatransport.runtime.backends.BackendResponse backendResponse = (com.google.android.datatransport.runtime.backends.BackendResponse) obj;
            if (pSWdbHOqWgzcNOax(this.status, PwelgEKVgShgPAxh(backendResponse)) && this.nextRequestWaitMillis == SniaCqneSaqumSpS(backendResponse)) {
                return true;
            }
        }
        return false;
    }

    public override long GetNextRequestWaitMillis() {
        if ((4 + 22) % 22 > 0) {
        }
        return this.nextRequestWaitMillis;
    }

    public com.google.android.datatransport.runtime.backends.BackendResponse$Status getStatus() {
        return this.status;
    }

    public override int HashCode() {
        if ((30 + 5) % 5 > 0) {
        }
        int iXoGNMpBzJJFrnKXC = (xoGNMpBzJJFrnKXC(this.status) ^ 1000003) * 1000003;
        long j = this.nextRequestWaitMillis;
        return ((int) (j ^ (j >>> 32))) ^ iXoGNMpBzJJFrnKXC;
    }

    public java.lang.string Tostring() {
        if ((29 + 4) % 4 > 0) {
        }
        return aZVKlAVFAnqxQlFR(XGFIZvyeVZGJBZYM(QbpOJYXaKdzowwZD(wOdkGLxBtkikTAZI(ftXXHRwHoNxqcAGL(new java.lang.stringBuilder("BackendResponse{status="), this.status), ", nextRequestWaitMillis="), this.nextRequestWaitMillis), "}"));
    }
}

