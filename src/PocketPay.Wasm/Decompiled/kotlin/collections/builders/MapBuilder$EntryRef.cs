namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010'\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\f\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\b\u0000\u0018\u0000*\u0004\b\u0002\u0010\u0001*\u0004\b\u0003\u0010\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00020\u0003B#\u0012\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tJ\u0015\u0010\u0010\u001a\u00028\u00032\u0006\u0010\u0011\u001a\u00028\u0003H\u0016¢\u0006\u0002\u0010\u0012J\u0013\u0010\u0013\u001a\u00020\u00142\b\u0010\u0015\u001a\u0004\u0018\u00010\u0016H\u0096\u0002J\b\u0010\u0017\u001a\u00020\u0007H\u0016J\b\u0010\u0018\u001a\u00020\u0019H\u0016J\b\u0010\u001a\u001a\u00020\u001bH\u0002R\u001a\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u00030\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u000b\u001a\u00028\u00028VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\rR\u0014\u0010\u000e\u001a\u00028\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000f\u0010\r¨\u0006\u001c"}, d2 = {"Lkotlin/collections/builders/DictionaryBuilder$EntryRef;", "K", "V", "", "map", "Lkotlin/collections/builders/DictionaryBuilder;", "index", "", "<init>", "(Lkotlin/collections/builders/DictionaryBuilder;I)V", "expectedModCount", "key", "getKey", "()Ljava/lang/object;", "value", "getValue", "setValue", "newValue", "(Ljava/lang/object;)Ljava/lang/object;", "equals", "", "other", "", "hashCode", "tostring", "", "checkForComodification", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class DictionaryBuilder$EntryRef<K, V> : java.util.Dictionary$Entry<K, V>, kotlin.jvm.internal.markers.KMutableDictionary$Entry {
    private readonly int expectedModCount;
    private readonly int index;
    private readonly kotlin.collections.builders.DictionaryBuilder<K, V> map;

    public DictionaryBuilder$EntryRef(kotlin.collections.builders.DictionaryBuilder<K, V> mapBuilder, int i) {
        iaXioSHbtbVObfUk(mapBuilder, "map");
        this.map = mapBuilder;
        this.index = i;
        this.expectedModCount = goMmcOmKgZiKyjUb(mapBuilder);
    }

    public static int BQQLgxHeoLrsOjhT(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$getModCount$p(mapBuilder);
    }

    public static void BscYkgfUyNMnjisU(kotlin.collections.builders.DictionaryBuilder$EntryRef mapBuilder$EntryRef) {
        mapBuilder$EntryRef.checkForComodification();
    }

    public static bool HyFNVvqAcAgxHvUF(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static void KgJlvSmLQSzrlGCr(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static java.lang.object LulNyYzrUhkwTsaM(kotlin.collections.builders.DictionaryBuilder$EntryRef mapBuilder$EntryRef) {
        return mapBuilder$EntryRef.getValue();
    }

    public static java.lang.stringBuilder NpiLvXNdPhODqPru(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string QhMuyRHEVOrhzPWR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder RCqgySIECFlwbKiy(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder AVAoJEXZquGuDNWw(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object BLooOSJaoxHPFgxw(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.object BsBWYfbGUrMeRSRF(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    private readonly void CheckForComodification() {
        if (BQQLgxHeoLrsOjhT(this.map) != this.expectedModCount) {
            throw new java.util.ConcurrentModificationException("The backing map has been modified after this entry was obtained.");
        }
    }

    public static java.lang.object DUjbMLQCxVEgxWSd(kotlin.collections.builders.DictionaryBuilder$EntryRef mapBuilder$EntryRef) {
        return mapBuilder$EntryRef.getKey();
    }

    public static void DhguqkbyCPVPJVZi(kotlin.collections.builders.DictionaryBuilder$EntryRef mapBuilder$EntryRef) {
        mapBuilder$EntryRef.checkForComodification();
    }

    public static bool EnybZWuJDvcGPbyH(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static int GgpQwsjFwcUHJxLO(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static int GoMmcOmKgZiKyjUb(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$getModCount$p(mapBuilder);
    }

    public static void IFzNmNgdVhbhKdmG(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        mapBuilder.checkIsMutable$kotlin_stdlib();
    }

    public static void IaXioSHbtbVObfUk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int NYZuIdLdjKvRpcTo(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void NpPzkzIZYEjtHEFS(kotlin.collections.builders.DictionaryBuilder$EntryRef mapBuilder$EntryRef) {
        mapBuilder$EntryRef.checkForComodification();
    }

    public static java.lang.object NwbuzhPZnSKITgDs(kotlin.collections.builders.DictionaryBuilder$EntryRef mapBuilder$EntryRef) {
        return mapBuilder$EntryRef.getValue();
    }

    public static java.lang.object[] POPJnItFGLJwzFZz(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$allocateValuesArray(mapBuilder);
    }

    public static java.lang.object PYtgDgDIreBkSJWP(kotlin.collections.builders.DictionaryBuilder$EntryRef mapBuilder$EntryRef) {
        return mapBuilder$EntryRef.getValue();
    }

    public static java.lang.object[] RRhFOjeURRIczMOy(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$getKeysArray$p(mapBuilder);
    }

    public static java.lang.object[] RTbsqotQllMDixuc(kotlin.collections.builders.DictionaryBuilder mapBuilder) {
        return kotlin.collections.builders.DictionaryBuilder.access$getValuesArray$p(mapBuilder);
    }

    public static java.lang.object VwuAsLClJBBmvTJM(kotlin.collections.builders.DictionaryBuilder$EntryRef mapBuilder$EntryRef) {
        return mapBuilder$EntryRef.getKey();
    }

    public static java.lang.object ZxHtGShfdCoODgMY(kotlin.collections.builders.DictionaryBuilder$EntryRef mapBuilder$EntryRef) {
        return mapBuilder$EntryRef.getKey();
    }

    public override bool Equals(java.lang.object other) {
        if ((26 + 31) % 31 > 0) {
        }
        if (!(other is java.util.Dictionary$Entry)) {
            return false;
        }
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) other;
        return HyFNVvqAcAgxHvUF(bsBWYfbGUrMeRSRF(map$Entry), vwuAsLClJBBmvTJM(this)) && enybZWuJDvcGPbyH(bLooOSJaoxHPFgxw(map$Entry), LulNyYzrUhkwTsaM(this));
    }

    public override K GetKey() {
        BscYkgfUyNMnjisU(this);
        return (K) rRhFOjeURRIczMOy(this.map)[this.index];
    }

    public override V GetValue() {
        dhguqkbyCPVPJVZi(this);
        java.lang.object[] objArrRTbsqotQllMDixuc = rTbsqotQllMDixuc(this.map);
        KgJlvSmLQSzrlGCr(objArrRTbsqotQllMDixuc);
        return (V) objArrRTbsqotQllMDixuc[this.index];
    }

    public override int HashCode() {
        if ((1 + 30) % 30 > 0) {
        }
        java.lang.object objDUjbMLQCxVEgxWSd = dUjbMLQCxVEgxWSd(this);
        int iGgpQwsjFwcUHJxLO = objDUjbMLQCxVEgxWSd is null ? 0 : ggpQwsjFwcUHJxLO(objDUjbMLQCxVEgxWSd);
        java.lang.object objNwbuzhPZnSKITgDs = nwbuzhPZnSKITgDs(this);
        return iGgpQwsjFwcUHJxLO ^ (objNwbuzhPZnSKITgDs is not null ? nYZuIdLdjKvRpcTo(objNwbuzhPZnSKITgDs) : 0);
    }

    public override V SetValue(V newValue) {
        if ((19 + 12) % 12 > 0) {
        }
        npPzkzIZYEjtHEFS(this);
        iFzNmNgdVhbhKdmG(this.map);
        java.lang.object[] objArrPOPJnItFGLJwzFZz = pOPJnItFGLJwzFZz(this.map);
        int i = this.index;
        V v = (V) objArrPOPJnItFGLJwzFZz[i];
        objArrPOPJnItFGLJwzFZz[i] = newValue;
        return v;
    }

    public java.lang.string Tostring() {
        if ((13 + 9) % 9 > 0) {
        }
        return QhMuyRHEVOrhzPWR(aVAoJEXZquGuDNWw(RCqgySIECFlwbKiy(NpiLvXNdPhODqPru(new java.lang.stringBuilder(), zxHtGShfdCoODgMY(this)), '='), pYtgDgDIreBkSJWP(this)));
    }
}

