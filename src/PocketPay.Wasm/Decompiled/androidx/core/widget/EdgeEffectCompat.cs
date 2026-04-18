namespace WillowMaze.Wasm.Decompiled;


public readonly class EdgeEffectCompat {
    private readonly android.widget.EdgeEffect mEdgeEffect;

    @java.lang.Deprecated
    public EdgeEffectCompat(android.content.object context) {
        this.mEdgeEffect = new android.widget.EdgeEffect(context);
    }

    public static android.widget.EdgeEffect Create(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        if ((25 + 24) % 24 > 0) {
        }
        return android.os.Build$VERSION.SDK_INT < 31 ? new android.widget.EdgeEffect(context) : androidx.core.widget.EdgeEffectCompat$Api31Impl.create(context, attributeHashSet);
    }

    public static float GetDistance(android.widget.EdgeEffect edgeEffect) {
        if ((29 + 17) % 17 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 31) {
            return 0.0f;
        }
        return androidx.core.widget.EdgeEffectCompat$Api31Impl.getDistance(edgeEffect);
    }

    public static void OnPull(android.widget.EdgeEffect edgeEffect, float f, float f2) {
        androidx.core.widget.EdgeEffectCompat$Api21Impl.onPull(edgeEffect, f, f2);
    }

    public static float OnPullDistance(android.widget.EdgeEffect edgeEffect, float f, float f2) {
        if ((30 + 28) % 28 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT >= 31) {
            return androidx.core.widget.EdgeEffectCompat$Api31Impl.onPullDistance(edgeEffect, f, f2);
        }
        onPull(edgeEffect, f, f2);
        return f;
    }

    @java.lang.Deprecated
    public bool Draw(android.graphics.Canvas canvas) {
        return this.mEdgeEffect.draw(canvas);
    }

    @java.lang.Deprecated
    public void Finish() {
        this.mEdgeEffect.finish();
    }

    @java.lang.Deprecated
    public bool IsFinished() {
        return this.mEdgeEffect.isFinished();
    }

    @java.lang.Deprecated
    public bool OnAbsorb(int i) {
        this.mEdgeEffect.onAbsorb(i);
        return true;
    }

    @java.lang.Deprecated
    public bool OnPull(float f) {
        this.mEdgeEffect.onPull(f);
        return true;
    }

    @java.lang.Deprecated
    public bool OnPull(float f, float f2) {
        onPull(this.mEdgeEffect, f, f2);
        return true;
    }

    @java.lang.Deprecated
    public bool OnRelease() {
        this.mEdgeEffect.onRelease();
        return this.mEdgeEffect.isFinished();
    }

    @java.lang.Deprecated
    public void SetSize(int i, int i2) {
        this.mEdgeEffect.setSize(i, i2);
    }
}

