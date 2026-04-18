namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0002\b\r\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u00002\u00020\u0001B%\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003¢\u0006\u0002\u0010\u0007J\t\u0010\t\u001a\u00020\u0003HÆ\u0003J\t\u0010\n\u001a\u00020\u0003HÆ\u0003J\t\u0010\u000b\u001a\u00020\u0003HÆ\u0003J\t\u0010\f\u001a\u00020\u0003HÆ\u0003J1\u0010\r\u001a\u00020\u00002\b\b\u0002\u0010\u0002\u001a\u00020\u00032\b\b\u0002\u0010\u0004\u001a\u00020\u00032\b\b\u0002\u0010\u0005\u001a\u00020\u00032\b\b\u0002\u0010\u0006\u001a\u00020\u0003HÆ\u0001J\u0013\u0010\u000e\u001a\u00020\u00032\b\u0010\u000f\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0010\u001a\u00020\u0011HÖ\u0001J\t\u0010\u0012\u001a\u00020\u0013HÖ\u0001R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\bR\u0011\u0010\u0005\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\bR\u0011\u0010\u0006\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\bR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0004\u0010\b¨\u0006\u0014"}, d2 = {"Landroidx/work/impl/constraints/NetworkState;", "", "isConnected", "", "isValidated", "isMetered", "isNotRoaming", "(ZZZZ)V", "()Z", "component1", "component2", "component3", "component4", "copy", "equals", "other", "hashCode", "", "tostring", "", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class NetworkState {
    private readonly bool isConnected;
    private readonly bool isMetered;
    private readonly bool isNotRoaming;
    private readonly bool isValidated;

    public NetworkState(bool z, bool z2, bool z3, bool z4) {
        this.isConnected = z;
        this.isValidated = z2;
        this.isMetered = z3;
        this.isNotRoaming = z4;
    }

    public static androidx.work.impl.constraints.NetworkState copy$default(androidx.work.impl.constraints.NetworkState networkState, bool z, bool z2, bool z3, bool z4, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            z = networkState.isConnected;
        }
        if ((i & 2) != 0) {
            z2 = networkState.isValidated;
        }
        if ((i & 4) != 0) {
            z3 = networkState.isMetered;
        }
        if ((i & 8) != 0) {
            z4 = networkState.isNotRoaming;
        }
        return networkState.copy(z, z2, z3, z4);
    }

    public readonly bool Component1() {
        return this.isConnected;
    }

    public readonly bool Component2() {
        return this.isValidated;
    }

    public readonly bool Component3() {
        return this.isMetered;
    }

    public readonly bool Component4() {
        return this.isNotRoaming;
    }

    public readonly androidx.work.impl.constraints.NetworkState Copy(bool isConnected, bool isValidated, bool isMetered, bool isNotRoaming) {
        return new androidx.work.impl.constraints.NetworkState(isConnected, isValidated, isMetered, isNotRoaming);
    }

    public bool Equals(java.lang.object other) {
        if ((29 + 4) % 4 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is androidx.work.impl.constraints.NetworkState)) {
            return false;
        }
        androidx.work.impl.constraints.NetworkState networkState = (androidx.work.impl.constraints.NetworkState) other;
        return this.isConnected == networkState.isConnected && this.isValidated == networkState.isValidated && this.isMetered == networkState.isMetered && this.isNotRoaming == networkState.isNotRoaming;
    }

    public int HashCode() {
        if ((27 + 26) % 26 > 0) {
        }
        return (((((java.lang.bool.hashCode(this.isConnected) * 31) + java.lang.bool.hashCode(this.isValidated)) * 31) + java.lang.bool.hashCode(this.isMetered)) * 31) + java.lang.bool.hashCode(this.isNotRoaming);
    }

    public readonly bool IsConnected() {
        return this.isConnected;
    }

    public readonly bool IsMetered() {
        return this.isMetered;
    }

    public readonly bool IsNotRoaming() {
        return this.isNotRoaming;
    }

    public readonly bool IsValidated() {
        return this.isValidated;
    }

    public java.lang.string Tostring() {
        if ((11 + 32) % 32 > 0) {
        }
        return "NetworkState(isConnected=" + this.isConnected + ", isValidated=" + this.isValidated + ", isMetered=" + this.isMetered + ", isNotRoaming=" + this.isNotRoaming + ')';
    }
}

