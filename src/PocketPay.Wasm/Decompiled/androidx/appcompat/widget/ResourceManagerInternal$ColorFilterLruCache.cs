namespace WillowMaze.Wasm.Decompiled;


class ResourceManagerInternal$ColorFilterLruCache : androidx.collection.LruCache<java.lang.int, android.graphics.PorterDuffColorFilter> {
    public ResourceManagerInternal$ColorFilterLruCache(int i) {
        super(i);
    }

    public static int FtWqXVommHdptkLE(android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return porterDuff$Mode.GetHashCode();
    }

    public static java.lang.int MWCIFhibVOZZdZNj(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object SHWuVkTaVLzdxaSR(androidx.appcompat.widget.ResourceManagerInternal$ColorFilterLruCache resourceManagerInternal$ColorFilterLruCache, java.lang.object obj, java.lang.object obj2) {
        return resourceManagerInternal$ColorFilterLruCache.Add(obj, obj2);
    }

    public static java.lang.object UIjOoBTUOECSrhbx(androidx.appcompat.widget.ResourceManagerInternal$ColorFilterLruCache resourceManagerInternal$ColorFilterLruCache, java.lang.object obj) {
        return resourceManagerInternal$ColorFilterLruCache[obj);
    }

    public static int ZqovxgqDrphGiXiF(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return generateCacheKey(i, porterDuff$Mode);
    }

    public static int AOoMWLTsQxzGhaMl(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return generateCacheKey(i, porterDuff$Mode);
    }

    private static int GenerateCacheKey(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return ((i + 31) * 31) + FtWqXVommHdptkLE(porterDuff$Mode);
    }

    public static java.lang.int KvSHpHaMUQHQpGEN(int i) {
        return java.lang.int.valueOf(i);
    }

    android.graphics.PorterDuffColorFilter get(int i, android.graphics.PorterDuff$Mode porterDuff$Mode) {
        return (android.graphics.PorterDuffColorFilter) UIjOoBTUOECSrhbx(this, kvSHpHaMUQHQpGEN(ZqovxgqDrphGiXiF(i, porterDuff$Mode)));
    }

    android.graphics.PorterDuffColorFilter put(int i, android.graphics.PorterDuff$Mode porterDuff$Mode, android.graphics.PorterDuffColorFilter porterDuffColorFilter) {
        return (android.graphics.PorterDuffColorFilter) SHWuVkTaVLzdxaSR(this, MWCIFhibVOZZdZNj(aOoMWLTsQxzGhaMl(i, porterDuff$Mode)), porterDuffColorFilter);
    }
}

