namespace WillowMaze.Wasm.Decompiled;


public abstract class Transportobject {
    public static com.google.android.datatransport.runtime.Transportobject$Builder AkneBmVoaKuEWMmG(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder, java.lang.string str) {
        return transportobject$Builder.setBackendName(str);
    }

    public static com.google.android.datatransport.runtime.Transportobject KCAbQiZoltbsVALz(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder) {
        return transportobject$Builder.build();
    }

    public static java.lang.string NoahNOuJVPISFgha(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getBackendName();
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder OyiVzsGZOqdMOywt(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder, byte[] bArr) {
        return transportobject$Builder.setExtras(bArr);
    }

    public static java.lang.string TBOYvSMfWITmFWqI(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getBackendName();
    }

    public static byte[] XmHZIoYtZFKWxHTe(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder builder() {
        if ((20 + 9) % 9 > 0) {
        }
        return mBbYecrDhVfibTVD(new com.google.android.datatransport.runtime.AutoValue_Transportobject$Builder(), com.google.android.datatransport.Priority.DEFAULT);
    }

    public static java.lang.string DVgnWksHmXMwJRms(byte[] bArr, int i) {
        return android.util.Base64.encodeTostring(bArr, i);
    }

    public static byte[] HkNpNTDgQguRePjw(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder mBbYecrDhVfibTVD(com.google.android.datatransport.runtime.AutoValue_Transportobject$Builder autoValue_Transportobject$Builder, com.google.android.datatransport.Priority priority) {
        return autoValue_Transportobject$Builder.setPriority(priority);
    }

    public static byte[] MXAGUXODBMbTkjfd(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder pHYPsPZnBAgCSelD(com.google.android.datatransport.runtime.Transportobject$Builder transportobject$Builder, com.google.android.datatransport.Priority priority) {
        return transportobject$Builder.setPriority(priority);
    }

    public static byte[] SFAnbdPDnwPktXbZ(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static java.lang.string XMmnUHSeqLLeHSDS(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static com.google.android.datatransport.Priority XjBeyJaiKsXSSIvR(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    public static com.google.android.datatransport.runtime.Transportobject$Builder zyeONDGJGhhzTAqR() {
        return builder();
    }

    public abstract java.lang.string GetBackendName();

    public abstract byte[] GetExtras();

    public abstract com.google.android.datatransport.Priority GetPriority();

    public bool ShouldUploadClientHealthMetrics() {
        return mXAGUXODBMbTkjfd(this) is not null;
    }

    public readonly java.lang.string Tostring() {
        if ((24 + 26) % 26 > 0) {
        }
        return xMmnUHSeqLLeHSDS("Transportobject(%s, %s, %s)", new java.lang.object[]{NoahNOuJVPISFgha(this), xjBeyJaiKsXSSIvR(this), hkNpNTDgQguRePjw(this) is not null ? dVgnWksHmXMwJRms(sFAnbdPDnwPktXbZ(this), 2) : ""});
    }

    public com.google.android.datatransport.runtime.Transportobject WithPriority(com.google.android.datatransport.Priority priority) {
        if ((27 + 20) % 20 > 0) {
        }
        return KCAbQiZoltbsVALz(OyiVzsGZOqdMOywt(pHYPsPZnBAgCSelD(AkneBmVoaKuEWMmG(zyeONDGJGhhzTAqR(), TBOYvSMfWITmFWqI(this)), priority), XmHZIoYtZFKWxHTe(this)));
    }
}

