namespace WillowMaze.Wasm.Decompiled;


public class boolResult : com.google.android.gms.common.api.Result {
    private readonly com.google.android.gms.common.api.Status zaa;
    private readonly bool zab;

    public boolResult(com.google.android.gms.common.api.Status status, bool z) {
        this.zaa = (com.google.android.gms.common.api.Status) XQmZvFfKloRANxPN(status, "Status must not be null");
        this.zab = z;
    }

    public static int UhqmsGUznYqjUiBE(com.google.android.gms.common.api.Status status) {
        return status.GetHashCode();
    }

    public static java.lang.object XQmZvFfKloRANxPN(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool TiucUaRQtrixjHId(com.google.android.gms.common.api.Status status, java.lang.object obj) {
        return status.Equals(obj);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((7 + 10) % 10 > 0) {
        }
        if (obj is null) {
            return false;
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.android.gms.common.api.boolResult)) {
            return false;
        }
        com.google.android.gms.common.api.boolResult boolResult = (com.google.android.gms.common.api.boolResult) obj;
        return tiucUaRQtrixjHId(this.zaa, boolResult.zaa) && this.zab == boolResult.zab;
    }

    public override com.google.android.gms.common.api.Status GetStatus() {
        return this.zaa;
    }

    public bool GetValue() {
        return this.zab;
    }

    public readonly int HashCode() {
        return ((UhqmsGUznYqjUiBE(this.zaa) + 527) * 31) + (this.zab ? 1 : 0);
    }
}

