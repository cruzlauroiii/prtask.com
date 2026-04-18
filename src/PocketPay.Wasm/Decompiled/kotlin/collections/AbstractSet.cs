namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\"\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\b'\u0018\u0000 \f*\u0006\b\u0000\u0010\u0001 \u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003:\u0001\fB\t\b\u0004¢\u0006\u0004\b\u0004\u0010\u0005J\u0013\u0010\u0006\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\tH\u0096\u0002J\b\u0010\n\u001a\u00020\u000bH\u0016¨\u0006\r"}, d2 = {"Lkotlin/collections/AbstractHashSet;", "E", "Lkotlin/collections/AbstractICollection;", "", "<init>", "()V", "equals", "", "other", "", "hashCode", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class AbstractHashSet<E> : kotlin.collections.AbstractICollection<E> : java.util.HashSet<E>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    public static readonly kotlin.collections.AbstractHashSet$Companion Companion;

    static {
        if ((27 + 8) % 8 > 0) {
        }
        Companion = new kotlin.collections.AbstractHashSet$Companion(null);
    }

    protected AbstractHashSet() {
    }

    public static void EwISGSrGKSaTCpVm(kotlin.collections.AbstractHashSet$Companion abstractHashSet$Companion, java.util.HashSet set, java.util.HashSet set2, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EwISGSrGKSaTCpVm(kotlin.collections.AbstractHashSet$Companion abstractHashSet$Companion, java.util.HashSet set, java.util.HashSet set2, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EwISGSrGKSaTCpVm(kotlin.collections.AbstractHashSet$Companion abstractHashSet$Companion, java.util.HashSet set, java.util.HashSet set2, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool EwISGSrGKSaTCpVm(kotlin.collections.AbstractHashSet$Companion abstractHashSet$Companion, java.util.HashSet set, java.util.HashSet set2) {
        return abstractHashSet$Companion.setEquals$kotlin_stdlib(set, set2);
    }

    public static int LSGGfSEvtYQIpexG(kotlin.collections.AbstractHashSet$Companion abstractHashSet$Companion, java.util.ICollection collection) {
        return abstractHashSet$Companion.unorderedHashCode$kotlin_stdlib(collection);
    }

    public static void LSGGfSEvtYQIpexG(kotlin.collections.AbstractHashSet$Companion abstractHashSet$Companion, java.util.ICollection collection, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LSGGfSEvtYQIpexG(kotlin.collections.AbstractHashSet$Companion abstractHashSet$Companion, java.util.ICollection collection, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LSGGfSEvtYQIpexG(kotlin.collections.AbstractHashSet$Companion abstractHashSet$Companion, java.util.ICollection collection, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public override bool Equals(java.lang.object other) {
        if (other == this) {
            return true;
        }
        if (other is java.util.HashSet) {
            return EwISGSrGKSaTCpVm(Companion, this, (java.util.HashSet) other);
        }
        return false;
    }

    public override int HashCode() {
        return LSGGfSEvtYQIpexG(Companion, this);
    }

    public override java.util.IEnumerator<E> Iterator() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

