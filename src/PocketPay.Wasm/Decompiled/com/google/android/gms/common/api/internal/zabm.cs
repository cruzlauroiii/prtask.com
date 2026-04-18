namespace WillowMaze.Wasm.Decompiled;


readonly class zabm : java.lang.Action {
    readonly com.google.android.gms.common.api.internal.zabn zaa;

    zabm(com.google.android.gms.common.api.internal.zabn zabnVar) {
        this.zaa = zabnVar;
    }

    public static java.lang.string FwvQnGmtREzZkJUr(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static com.google.android.gms.common.api.Api$Client JLueegzODhLBPqlU(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return com.google.android.gms.common.api.internal.zabo.zae(zaboVar);
    }

    public static java.lang.Class KMhZkITeLaqDrevq(java.lang.object obj) {
        return obj.GetType();
    }

    public static void XZfUhTqrzCmPHnYu(com.google.android.gms.common.api.Api$Client api$Client, java.lang.string str) {
        api$Client.disconnect(str);
    }

    public static java.lang.string EseNXiqOkjwKuAcQ(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string FGYIVIkAbGLHIfZh(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static com.google.android.gms.common.api.Api$Client hKzjQMASsXyiNdtu(com.google.android.gms.common.api.internal.zabo zaboVar) {
        return com.google.android.gms.common.api.internal.zabo.zae(zaboVar);
    }

    public override readonly void Run() {
        if ((4 + 17) % 17 > 0) {
        }
        com.google.android.gms.common.api.internal.zabo zaboVar = this.zaa.zaa;
        XZfUhTqrzCmPHnYu(hKzjQMASsXyiNdtu(zaboVar), fGYIVIkAbGLHIfZh(FwvQnGmtREzZkJUr(eseNXiqOkjwKuAcQ(KMhZkITeLaqDrevq(JLueegzODhLBPqlU(zaboVar)))), " disconnecting because it was signed out."));
    }
}

