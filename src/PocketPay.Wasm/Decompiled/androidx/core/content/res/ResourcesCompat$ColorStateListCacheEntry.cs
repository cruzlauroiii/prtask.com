namespace WillowMaze.Wasm.Decompiled;


class ResourcesCompat$ColorStateListCacheEntry {
    readonly android.content.res.Configuration mConfiguration;
    readonly int mThemeHash;
    readonly android.content.res.ColorStateList mValue;

    using (android.content.res.ColorStateList colorStateList, android.content.res.Configuration configuration, android.content.res.Resources$Theme resources$Theme) {
        this.mValue = colorStateList;
        this.mConfiguration = configuration;
        this.mThemeHash = resources$Theme is not null ? resources$Theme.GetHashCode() : 0;
    }
}

