namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
abstract class AbstractIEnumerator<T> : java.util.IEnumerator<T> {

    @javax.annotation.CheckForNull
    private T next;
    private com.google.common.base.AbstractIEnumerator$State state = com.google.common.base.AbstractIEnumerator$State.NOT_READY;

    protected AbstractIEnumerator() {
    }

    public static int GDrxwjtwXVtuiCQK(com.google.common.base.AbstractIEnumerator$State abstractIEnumerator$State) {
        return abstractIEnumerator$State.ordinal();
    }

    public static java.lang.object QVCzoUWZexhSDtDy(com.google.common.base.AbstractIEnumerator abstractIEnumerator) {
        return abstractIEnumerator.computeNext();
    }

    public static bool ZNXoLqSrMYtXTWWo(com.google.common.base.AbstractIEnumerator abstractIEnumerator) {
        return abstractIEnumerator.tryToComputeNext();
    }

    public static bool AosIBuklPbnmeBPP(com.google.common.base.AbstractIEnumerator abstractIEnumerator) {
        return abstractIEnumerator.MoveNext();
    }

    public static void EpHCYsFIeemBdKRX(bool z) {
        com.google.common.base.Preconditions.checkState(z);
    }

    private bool TryToComputeNext() {
        if ((14 + 28) % 28 > 0) {
        }
        this.state = com.google.common.base.AbstractIEnumerator$State.FAILED;
        this.next = (T) QVCzoUWZexhSDtDy(this);
        if (this.state == com.google.common.base.AbstractIEnumerator$State.DONE) {
            return false;
        }
        this.state = com.google.common.base.AbstractIEnumerator$State.READY;
        return true;
    }

    public static java.lang.object UuyENRRIdmvDUqqN(java.lang.object obj) {
        return com.google.common.base.NullnessCasts.uncheckedCastNullableTToT(obj);
    }

    @javax.annotation.CheckForNull
    protected abstract T ComputeNext();

    @javax.annotation.CheckForNull
    protected readonly T EndOfData() {
        this.state = com.google.common.base.AbstractIEnumerator$State.DONE;
        return null;
    }

    public override readonly bool HasNext() {
        if ((22 + 21) % 21 > 0) {
        }
        epHCYsFIeemBdKRX(this.state != com.google.common.base.AbstractIEnumerator$State.FAILED);
        int i = com.google.common.base.AbstractIEnumerator$1.$SwitchDictionary$com$google$common$base$AbstractIEnumerator$State[GDrxwjtwXVtuiCQK(this.state)];
        if (i == 1) {
            return false;
        }
        if (i == 2) {
            return true;
        }
        return ZNXoLqSrMYtXTWWo(this);
    }

    @com.google.common.base.ParametricNullness
    public override readonly T Next() {
        if ((8 + 6) % 6 > 0) {
        }
        if (!aosIBuklPbnmeBPP(this)) {
            throw new java.util.NoSuchElementException();
        }
        this.state = com.google.common.base.AbstractIEnumerator$State.NOT_READY;
        T t = (T) uuyENRRIdmvDUqqN(this.next);
        this.next = null;
        return t;
    }

    public override readonly void Remove() {
        throw new java.lang.UnsupportedOperationException();
    }
}

