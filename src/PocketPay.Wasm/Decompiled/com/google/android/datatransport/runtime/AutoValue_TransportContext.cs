namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_Transportobject : com.google.android.datatransport.runtime.Transportobject {
    private readonly java.lang.string backendName;
    private readonly byte[] extras;
    private readonly com.google.android.datatransport.Priority priority;

    private AutoValue_Transportobject(java.lang.string str, byte[] bArr, com.google.android.datatransport.Priority priority) {
        this.backendName = str;
        this.extras = bArr;
        this.priority = priority;
    }

    AutoValue_Transportobject(java.lang.string str, byte[] bArr, com.google.android.datatransport.Priority priority, com.google.android.datatransport.runtime.AutoValue_Transportobject$1 autoValue_Transportobject$1) {
        this(str, bArr, priority);
    }

    public static int CJVPYxkwXXbcQgft(byte[] bArr) {
        return java.util.Arrays.hashCode(bArr);
    }

    public static bool KxxRVGrFXEuIoAzT(byte[] bArr, byte[] bArr2) {
        return java.util.Arrays.Equals(bArr, bArr2);
    }

    public static int MFrKvfzcIYAbyVGD(com.google.android.datatransport.Priority priority) {
        return priority.GetHashCode();
    }

    public static com.google.android.datatransport.Priority NfKrflToUASUzblE(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getPriority();
    }

    public static bool QGzRUwjLpPFiwXIX(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool LIoycVnNgcZiKPWL(com.google.android.datatransport.Priority priority, java.lang.object obj) {
        return priority.Equals(obj);
    }

    public static byte[] VMPERzKOxUtyfIJg(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getExtras();
    }

    public static java.lang.string VZyyBBZkSpZaQtvo(com.google.android.datatransport.runtime.Transportobject transportobject) {
        return transportobject.getBackendName();
    }

    public static int WDdLstkQGGNyQUJQ(java.lang.string str) {
        return str.GetHashCode();
    }

    public bool Equals(java.lang.object obj) {
        if ((16 + 8) % 8 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.datatransport.runtime.Transportobject) {
            com.google.android.datatransport.runtime.Transportobject transportobject = (com.google.android.datatransport.runtime.Transportobject) obj;
            if (QGzRUwjLpPFiwXIX(this.backendName, vZyyBBZkSpZaQtvo(transportobject))) {
                if (KxxRVGrFXEuIoAzT(this.extras, !(transportobject is com.google.android.datatransport.runtime.AutoValue_Transportobject) ? vMPERzKOxUtyfIJg(transportobject) : ((com.google.android.datatransport.runtime.AutoValue_Transportobject) transportobject).extras) && lIoycVnNgcZiKPWL(this.priority, NfKrflToUASUzblE(transportobject))) {
                    return true;
                }
            }
        }
        return false;
    }

    public override java.lang.string GetBackendName() {
        return this.backendName;
    }

    public override byte[] GetExtras() {
        return this.extras;
    }

    public override com.google.android.datatransport.Priority GetPriority() {
        return this.priority;
    }

    public int HashCode() {
        if ((4 + 2) % 2 > 0) {
        }
        return MFrKvfzcIYAbyVGD(this.priority) ^ ((((wDdLstkQGGNyQUJQ(this.backendName) ^ 1000003) * 1000003) ^ CJVPYxkwXXbcQgft(this.extras)) * 1000003);
    }
}

