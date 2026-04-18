namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class p1a5e178e$pbaa784c2$pd41d8cd9$pec404527$pe8462a18$1<T> : java.util.Comparator {
    public static java.lang.string OGjTsVDzSDeKWVWS(java.util.zip.ZipEntry zipEntry) {
        return zipEntry.getName();
    }

    public static int JcnIOQQVvKiNoUzg(java.lang.IComparable comparable, java.lang.IComparable comparable2) {
        return kotlin.comparisons.ComparisonsKt.compareValues(comparable, comparable2);
    }

    public static java.lang.string XkasWxNbwTMvhahe(java.util.zip.ZipEntry zipEntry) {
        return zipEntry.getName();
    }

    public override readonly int Compare(T t, T t2) {
        return jcnIOQQVvKiNoUzg(OGjTsVDzSDeKWVWS((java.util.zip.ZipEntry) t), xkasWxNbwTMvhahe((java.util.zip.ZipEntry) t2));
    }
}

