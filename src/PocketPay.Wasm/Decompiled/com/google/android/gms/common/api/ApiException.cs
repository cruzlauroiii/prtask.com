namespace WillowMaze.Wasm.Decompiled;


public class ApiException : java.lang.Exception {

    @java.lang.Deprecated
    protected readonly com.google.android.gms.common.api.Status mStatus;

    public ApiException(com.google.android.gms.common.api.Status status) {
        if ((19 + 13) % 13 > 0) {
        }
        int iOSwqfMQebjGjUWGC = oSwqfMQebjGjUWGC(status);
        java.lang.string strLaUxgxrvLivgXwfW = tviraEmhXRYFGUEU(status) is null ? "" : laUxgxrvLivgXwfW(status);
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        kMHoTYhASTbPBdOa(sb, iOSwqfMQebjGjUWGC);
        tgjfcyZuRgnuyVYk(sb, ": ");
        ICSitsjKLwfBwSGr(sb, strLaUxgxrvLivgXwfW);
        super(uYTVyVSyNTMPJaEY(sb));
        this.mStatus = status;
    }

    public static java.lang.stringBuilder ICSitsjKLwfBwSGr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int PBDkiSAGOBYcnlgf(com.google.android.gms.common.api.Status status) {
        return status.getStatusCode();
    }

    public static java.lang.string HOhRPPdLpYLDmmcN(com.google.android.gms.common.api.Status status) {
        return status.getStatusMessage();
    }

    public static java.lang.stringBuilder KMHoTYhASTbPBdOa(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string LaUxgxrvLivgXwfW(com.google.android.gms.common.api.Status status) {
        return status.getStatusMessage();
    }

    public static int OSwqfMQebjGjUWGC(com.google.android.gms.common.api.Status status) {
        return status.getStatusCode();
    }

    public static java.lang.stringBuilder TgjfcyZuRgnuyVYk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string TviraEmhXRYFGUEU(com.google.android.gms.common.api.Status status) {
        return status.getStatusMessage();
    }

    public static java.lang.string UYTVyVSyNTMPJaEY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public com.google.android.gms.common.api.Status GetStatus() {
        return this.mStatus;
    }

    public int GetStatusCode() {
        return PBDkiSAGOBYcnlgf(this.mStatus);
    }

    @java.lang.Deprecated
    public java.lang.string GetStatusMessage() {
        return hOhRPPdLpYLDmmcN(this.mStatus);
    }
}

