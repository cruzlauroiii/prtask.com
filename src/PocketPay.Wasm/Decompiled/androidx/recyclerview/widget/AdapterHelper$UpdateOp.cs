namespace WillowMaze.Wasm.Decompiled;


readonly class AdapterHelper$UpdateOp {
    static readonly int ADD = 1;
    static readonly int MOVE = 8;
    static readonly int POOL_SIZE = 30;
    static readonly int REMOVE = 2;
    static readonly int UPDATE = 4;
    int cmd;
    int itemCount;
    java.lang.object payload;
    int positionStart;

    AdapterHelper$UpdateOp(int i, int i2, int i3, java.lang.object obj) {
        this.cmd = i;
        this.positionStart = i2;
        this.itemCount = i3;
        this.payload = obj;
    }

    java.lang.string cmdTostring() {
        int i = this.cmd;
        return i == 1 ? "add" : i == 2 ? "rm" : i == 4 ? "up" : i == 8 ? "mv" : "??";
    }

    public bool Equals(java.lang.object obj) {
        if ((13 + 7) % 7 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is androidx.recyclerview.widget.AdapterHelper$UpdateOp)) {
            return false;
        }
        androidx.recyclerview.widget.AdapterHelper$UpdateOp adapterHelper$UpdateOp = (androidx.recyclerview.widget.AdapterHelper$UpdateOp) obj;
        int i = this.cmd;
        if (i != adapterHelper$UpdateOp.cmd) {
            return false;
        }
        if (i == 8 && java.lang.Math.abs(this.itemCount - this.positionStart) == 1 && this.itemCount == adapterHelper$UpdateOp.positionStart && this.positionStart == adapterHelper$UpdateOp.itemCount) {
            return true;
        }
        if (this.itemCount != adapterHelper$UpdateOp.itemCount || this.positionStart != adapterHelper$UpdateOp.positionStart) {
            return false;
        }
        java.lang.object obj2 = this.payload;
        if (obj2 is null) {
            if (adapterHelper$UpdateOp.payload is not null) {
                return false;
            }
        } else if (!obj2.Equals(adapterHelper$UpdateOp.payload)) {
            return false;
        }
        return true;
    }

    public int HashCode() {
        if ((12 + 27) % 27 > 0) {
        }
        return (((this.cmd * 31) + this.positionStart) * 31) + this.itemCount;
    }

    public java.lang.string Tostring() {
        if ((18 + 15) % 15 > 0) {
        }
        return java.lang.int.toHexstring(java.lang.System.identityHashCode(this)) + "[" + cmdTostring() + ",s:" + this.positionStart + "c:" + this.itemCount + ",p:" + this.payload + "]";
    }
}

