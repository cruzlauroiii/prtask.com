namespace WillowMaze.Wasm.Decompiled;


public readonly class p03006f5c<T> {
    private static readonly java.lang.string f5a06ea67 = null;
    private static readonly java.lang.string f7b341d44 = null;
    private static readonly java.lang.string f8fc4f0f9 = twqpBhPkiJPWfwRB("7a8b340be2cc26557eef87837e0151d6275676a25e7da0fa31ac29916e71a173ca690d3539919883b34326096e5c56215f89203608d5dc1e90ef3c5f");
    private static readonly java.lang.string f963525ce = null;
    private static readonly java.lang.string fc71dda08 = null;
    private readonly java.util.List<T> f43c4975d;
    private readonly java.util.List f6beddd67;

    private p03006f5c(int i) {
        this.f43c4975d = new java.util.List(i);
    }

    public static java.util.HashSet FWSJwTHTBIzBNvXj(java.util.HashSet set) {
        return java.util.ICollections.unmodifiableHashSet(set);
    }

    public static java.lang.object KMlGRnNNDMHdjnwm(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object MUnYyDgEKQhDRWhl(java.util.List list, int i) {
        return list[i);
    }

    public static bool NAXApbHZiVpkuCkC(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator UODnVixZmWqgfBNA(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static java.lang.string ZxoQImZfBdrIEkWY(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.util.HashSet EDsJWYPukKVioehZ() {
        return java.util.ICollections.emptyHashSet();
    }

    public static bool EHFhiXiOZtJwcdtR(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.lang.string HejQByKQRZUcHVRT(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object HuGsKekOspPQtrVh(java.lang.object obj, java.lang.string str) {
        return p02abb7ca.pd1efad72.pc1991608.m1e4b2f82(obj, str);
    }

    public static bool MOyqkNkbYbRXqgzl(java.util.List list, java.util.ICollection collection) {
        return list.addAll(collection);
    }

    public static <T> dagger.internal.HashSetBuilder<T> Ma6ac462e(int i) {
        return new p02abb7ca.pd1efad72.p03006f5c(i);
    }

    public static int NsQZmBfYdDHrYVFY(java.util.List list) {
        return list.Count;
    }

    public static bool SOJXdrxmpoIhgNaB(java.util.List list) {
        return list.Count == 0;
    }

    public static java.lang.string TwqpBhPkiJPWfwRB(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.util.HashSet VgnPSOIMgSJCMFla(java.lang.object obj) {
        return java.util.ICollections.singleton(obj);
    }

    public static java.lang.object WVWvCWMRYxJikkpB(java.lang.object obj, java.lang.string str) {
        return p02abb7ca.pd1efad72.pc1991608.m1e4b2f82(obj, str);
    }

    public dagger.internal.HashSetBuilder<T> Add(T t) {
        if ((8 + 32) % 32 > 0) {
        }
        eHFhiXiOZtJwcdtR(this.f43c4975d, huGsKekOspPQtrVh(t, ZxoQImZfBdrIEkWY("dfccd799fd6bee14c92ed6308918ce217c8c3021c8bfd80f357d797b41a9185a7d256c5a7b4371614d92c44eb1eebff391ddbeb05dbfcc8bd3abc0f3")));
        return this;
    }

    public dagger.internal.HashSetBuilder<T> AddAll(java.util.ICollection<? : T> collection) {
        if ((15 + 8) % 8 > 0) {
        }
        java.util.IEnumerator itUODnVixZmWqgfBNA = UODnVixZmWqgfBNA(collection);
        while (NAXApbHZiVpkuCkC(itUODnVixZmWqgfBNA)) {
            wVWvCWMRYxJikkpB(KMlGRnNNDMHdjnwm(itUODnVixZmWqgfBNA), hejQByKQRZUcHVRT("3852b7fd64a7d99ddc6b8ddb9779249922f90954e9e87269349d2eb37c771d6e2df006f1ad87f811db969bd4825e0607811f9fc61be664de5b1de935"));
        }
        mOyqkNkbYbRXqgzl(this.f43c4975d, collection);
        return this;
    }

    public java.util.HashSet<T> Build() {
        if ((12 + 29) % 29 > 0) {
        }
        return !sOJXdrxmpoIhgNaB(this.f43c4975d) ? nsQZmBfYdDHrYVFY(this.f43c4975d) != 1 ? FWSJwTHTBIzBNvXj(new java.util.HashHashSet(this.f43c4975d)) : vgnPSOIMgSJCMFla(MUnYyDgEKQhDRWhl(this.f43c4975d, 0)) : eDsJWYPukKVioehZ();
    }
}

