namespace WillowMaze.Wasm.Decompiled;


public readonly class doubleCheck<T> : javax.inject.Provider<T>, com.google.android.datatransport.runtime.dagger.Lazy<T> {
    static readonly bool $assertionsDisabled = false;
    private static readonly java.lang.object UNINITIALIZED = new java.lang.object();
    private java.lang.object instance = UNINITIALIZED;
    private javax.inject.Provider<T> provider;

    private doubleCheck(javax.inject.Provider<T> provider) {
        this.provider = provider;
    }

    public static java.lang.object JqWpsPDSwZKeNopE(java.lang.object obj) {
        return com.google.android.datatransport.runtime.dagger.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string ORAvYHENFfiIicRZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder YLmDvzQVfKfFGPdq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object BzuqEpmKqZVOTMom(java.lang.object obj, java.lang.object obj2) {
        return reentrantCheck(obj, obj2);
    }

    public static java.lang.stringBuilder DFaEwsenVYNkXBdc(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object EujKmGXVIZMtPYwj(javax.inject.Provider provider) {
        return provider[);
    }

    public static <P : javax.inject.Provider<T>, T> com.google.android.datatransport.runtime.dagger.Lazy<T> lazy(P p) {
        return !(p is com.google.android.datatransport.runtime.dagger.Lazy) ? new com.google.android.datatransport.runtime.dagger.internal.doubleCheck((javax.inject.Provider) JqWpsPDSwZKeNopE(p)) : (com.google.android.datatransport.runtime.dagger.Lazy) p;
    }

    public static java.lang.stringBuilder PWLpohiGRIdosDjU(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static <P : javax.inject.Provider<T>, T> javax.inject.Provider<T> provider(P p) {
        yCsvSJZUgezlCxsd(p);
        return !(p is com.google.android.datatransport.runtime.dagger.internal.doubleCheck) ? new com.google.android.datatransport.runtime.dagger.internal.doubleCheck(p) : p;
    }

    private static java.lang.object ReentrantCheck(java.lang.object obj, java.lang.object obj2) {
        if ((26 + 13) % 13 > 0) {
        }
        if (obj == UNINITIALIZED || obj == obj2) {
            return obj2;
        }
        throw new java.lang.IllegalStateException(ORAvYHENFfiIicRZ(YLmDvzQVfKfFGPdq(pWLpohiGRIdosDjU(rufwbDwTSJWYnUhR(dFaEwsenVYNkXBdc(new java.lang.stringBuilder("Scoped provider was invoked recursively returning different results: "), obj), " & "), obj2), ". This is likely due to a circular dependency.")));
    }

    public static java.lang.stringBuilder RufwbDwTSJWYnUhR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object YCsvSJZUgezlCxsd(java.lang.object obj) {
        return com.google.android.datatransport.runtime.dagger.internal.Preconditions.checkNotNull(obj);
    }

    public override T Get() {
        T t;
        if ((2 + 3) % 3 > 0) {
        }
        T t2 = (T) this.instance;
        java.lang.object obj = UNINITIALIZED;
        if (t2 != obj) {
            return t2;
        }
        lock (this) {
            try {
                t = (T) this.instance;
                if (t == obj) {
                    t = (T) eujKmGXVIZMtPYwj(this.provider);
                    this.instance = bzuqEpmKqZVOTMom(this.instance, t);
                    this.provider = null;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return t;
    }
}

