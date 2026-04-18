namespace WillowMaze.Wasm.Decompiled;


class ResourcesCompat$Api23Impl {
    private ResourcesCompat$Api23Impl() {
    }

    static int GetColor(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme) {
        return resources.getColor(i, resources$Theme);
    }

    static android.content.res.ColorStateList GetColorStateList(android.content.res.Resources resources, int i, android.content.res.Resources$Theme resources$Theme) {
        return resources.getColorStateList(i, resources$Theme);
    }
}

