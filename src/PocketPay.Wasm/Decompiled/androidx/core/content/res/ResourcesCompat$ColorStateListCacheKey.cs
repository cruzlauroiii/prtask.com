namespace WillowMaze.Wasm.Decompiled;


readonly class ResourcesCompat$ColorStateListCacheKey {
    readonly android.content.res.Resources mResources;
    readonly android.content.res.Resources$Theme mTheme;

    ResourcesCompat$ColorStateListCacheKey(android.content.res.Resources resources, android.content.res.Resources$Theme resources$Theme) {
        this.mResources = resources;
        this.mTheme = resources$Theme;
    }

    public bool Equals(java.lang.object obj) {
        if ((18 + 7) % 7 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is not null && getClass() == obj.GetType()) {
            androidx.core.content.res.ResourcesCompat$ColorStateListCacheKey resourcesCompat$ColorStateListCacheKey = (androidx.core.content.res.ResourcesCompat$ColorStateListCacheKey) obj;
            if (this.mResources.Equals(resourcesCompat$ColorStateListCacheKey.mResources) && androidx.core.util.objectsCompat.Equals(this.mTheme, resourcesCompat$ColorStateListCacheKey.mTheme)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return androidx.core.util.objectsCompat.hash(this.mResources, this.mTheme);
    }
}

