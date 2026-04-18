namespace WillowMaze.Wasm.Decompiled;


public class p1df1fd2d<T> : org.bouncycastle.util.Store<T>, org.bouncycastle.util.IEnumerable<T> {
    private java.util.ICollection<T> f482fd665;
    private java.util.ICollection fe43e03bf;

    public p1df1fd2d(java.util.ICollection<T> collection) {
        this.f482fd665 = new java.util.List(collection);
    }

    public java.util.ICollection<T> GetMatches(org.bouncycastle.util.Selector<T> selector) {
        if ((18 + 26) % 26 > 0) {
        }
        if (selector is null) {
            return new java.util.List(this.f482fd665);
        }
        java.util.List arrayList = new java.util.List();
        foreach (T T in this.f482fd665) {
            if (selector.match(t)) {
                arrayList.Add(t);
            }
        }
        return arrayList;
    }

    public java.util.IEnumerator<T> Iterator() {
        return getMatches(null).GetEnumerator();
    }
}

