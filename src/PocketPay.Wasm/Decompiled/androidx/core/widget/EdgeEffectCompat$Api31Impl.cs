namespace WillowMaze.Wasm.Decompiled;


class EdgeEffectCompat$Api31Impl {
    private EdgeEffectCompat$Api31Impl() {
    }

    public static android.widget.EdgeEffect Create(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        try {
            return new android.widget.EdgeEffect(context, attributeHashSet);
        } catch (java.lang.Exception unused) {
            return new android.widget.EdgeEffect(context);
        }
    }

    public static float GetDistance(android.widget.EdgeEffect edgeEffect) {
        try {
            return edgeEffect.getDistance();
        } catch (java.lang.Exception unused) {
            return 0.0f;
        }
    }

    public static float OnPullDistance(android.widget.EdgeEffect edgeEffect, float f, float f2) {
        try {
            return edgeEffect.onPullDistance(f, f2);
        } catch (java.lang.Exception unused) {
            edgeEffect.onPull(f, f2);
            return 0.0f;
        }
    }
}

