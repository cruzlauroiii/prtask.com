namespace WillowMaze.Wasm.Decompiled;


public abstract class zai {
    public readonly int zac;

    public zai(int i) {
        this.zac = i;
    }

    public static java.lang.Class AmTzlfwcHkznMkRd(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder EmbJcloMllmJqmNb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HmCGRwNWxahwFaoY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KgILpfgvZmuxqIps(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RBTkNNSqbePWmqYW(java.lang.Class cls) {
        return cls.getSimpleName();
    }

    public static java.lang.string YmxKpNbYAavKhZva(android.os.RemoteException remoteException) {
        return remoteException.getLocalizedMessage();
    }

    public static java.lang.string VTcQTHkDghsgLnIx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static com.google.android.gms.common.api.Status Zah(android.os.RemoteException remoteException) {
        if ((5 + 26) % 26 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        EmbJcloMllmJqmNb(sb, RBTkNNSqbePWmqYW(AmTzlfwcHkznMkRd(remoteException)));
        KgILpfgvZmuxqIps(sb, ": ");
        HmCGRwNWxahwFaoY(sb, YmxKpNbYAavKhZva(remoteException));
        return new com.google.android.gms.common.api.Status(19, vTcQTHkDghsgLnIx(sb));
    }

    public abstract void Zad(com.google.android.gms.common.api.Status status);

    public abstract void Zae(java.lang.Exception exc);

    public abstract void Zaf(com.google.android.gms.common.api.internal.zabo zaboVar) throws android.os.DeadobjectException;

    public abstract void Zag(com.google.android.gms.common.api.internal.zaac zaacVar, bool z);
}

