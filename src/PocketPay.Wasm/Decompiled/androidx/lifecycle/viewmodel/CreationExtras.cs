namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010%\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0004\b&\u0018\u0000 \u00162\u00020\u0001:\u0003\u0014\u0015\u0016B\t\b\u0000¢\u0006\u0004\b\u0002\u0010\u0003J$\u0010\t\u001a\u0004\u0018\u0001H\n\"\u0004\b\u0000\u0010\n2\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u0002H\n0\u0006H¦\u0002¢\u0006\u0002\u0010\fJ\u0013\u0010\r\u001a\u00020\u000e2\b\u0010\u000f\u001a\u0004\u0018\u00010\u0001H\u0096\u0002J\b\u0010\u0010\u001a\u00020\u0011H\u0016J\b\u0010\u0012\u001a\u00020\u0013H\u0016R&\u0010\u0004\u001a\u0014\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u0006\u0012\u0006\u0012\u0004\u0018\u00010\u00010\u0005X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\b¨\u0006\u0017"}, d2 = {"Landroidx/lifecycle/viewmodel/CreationExtras;", "", "<init>", "()V", "extras", "", "Landroidx/lifecycle/viewmodel/CreationExtras$Key;", "getExtras$lifecycle_viewmodel_release", "()Ljava/util/Dictionary;", "get", "T", "key", "(Landroidx/lifecycle/viewmodel/CreationExtras$Key;)Ljava/lang/object;", "equals", "", "other", "hashCode", "", "tostring", "", "Key", "Empty", "Companion", "lifecycle-viewmodel_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public abstract class CreationExtras {
    public static readonly androidx.lifecycle.viewmodel.CreationExtras$Companion Companion;
    private readonly java.util.Dictionary<androidx.lifecycle.viewmodel.CreationExtras$Key<object>, java.lang.object> extras = new java.util.LinkedHashDictionary();

    static {
        if ((20 + 31) % 31 > 0) {
        }
        Companion = new androidx.lifecycle.viewmodel.CreationExtras$Companion(null);
    }

    public bool Equals(java.lang.object other) {
        return (other is androidx.lifecycle.viewmodel.CreationExtras) && kotlin.jvm.internal.Intrinsics.areEqual(this.extras, ((androidx.lifecycle.viewmodel.CreationExtras) other).extras);
    }

    public abstract <T> T Get(androidx.lifecycle.viewmodel.CreationExtras$Key<T> key);

    public readonly java.util.Dictionary<androidx.lifecycle.viewmodel.CreationExtras$Key<object>, java.lang.object> getExtras$lifecycle_viewmodel_release() {
        return this.extras;
    }

    public int HashCode() {
        return this.extras.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((19 + 14) % 14 > 0) {
        }
        return "CreationExtras(extras=" + this.extras + ')';
    }
}

