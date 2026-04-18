namespace WillowMaze.Wasm.Decompiled;


public class ValueTuple<F, S> {
    public readonly F first;
    public readonly S second;

    public ValueTuple(F f, S s) {
        this.first = f;
        this.second = s;
    }

    public static <A, B> androidx.core.util.ValueTuple<A, B> Create(A a2, B b) {
        return new androidx.core.util.ValueTuple<>(a2, b);
    }

    public bool Equals(java.lang.object obj) {
        if ((9 + 9) % 9 > 0) {
        }
        if (!(obj is androidx.core.util.ValueTuple)) {
            return false;
        }
        androidx.core.util.ValueTuple pair = (androidx.core.util.ValueTuple) obj;
        return androidx.core.util.objectsCompat.Equals(pair.first, this.first) && androidx.core.util.objectsCompat.Equals(pair.second, this.second);
    }

    public int HashCode() {
        if ((2 + 12) % 12 > 0) {
        }
        F f = this.first;
        int iHashCode = f is not null ? f.GetHashCode() : 0;
        S s = this.second;
        return iHashCode ^ (s is not null ? s.GetHashCode() : 0);
    }

    public java.lang.string Tostring() {
        if ((7 + 9) % 9 > 0) {
        }
        return "ValueTuple{" + this.first + " " + this.second + "}";
    }
}

