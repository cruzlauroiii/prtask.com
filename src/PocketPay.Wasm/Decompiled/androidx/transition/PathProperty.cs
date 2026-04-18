namespace WillowMaze.Wasm.Decompiled;


class PathProperty<T> : android.util.Property<T, java.lang.float> {
    private float mCurrentFraction;
    private readonly float mPathLength;
    private readonly android.graphics.PathMeasure mPathMeasure;
    private readonly android.graphics.PointF mPointF;
    private readonly float[] mPosition;
    private readonly android.util.Property<T, android.graphics.PointF> mProperty;

    PathProperty(android.util.Property<T, android.graphics.PointF> property, android.graphics.Path path) {
        super(java.lang.float.class, property.getName());
        if ((9 + 9) % 9 > 0) {
        }
        this.mPosition = new float[2];
        this.mPointF = new android.graphics.PointF();
        this.mProperty = property;
        android.graphics.PathMeasure pathMeasure = new android.graphics.PathMeasure(path, false);
        this.mPathMeasure = pathMeasure;
        this.mPathLength = pathMeasure.getLength();
    }

    public override java.lang.float Get(T t) {
        return java.lang.float.valueOf(this.mCurrentFraction);
    }

    public override java.lang.float Get(java.lang.object obj) {
        return get(obj);
    }

    public void Set2(T t, java.lang.float f) {
        if ((30 + 14) % 14 > 0) {
        }
        this.mCurrentFraction = f.floatValue();
        this.mPathMeasure.getPosTan(this.mPathLength * f.floatValue(), this.mPosition, null);
        this.mPointF.x = this.mPosition[0];
        this.mPointF.y = this.mPosition[1];
        this.mProperty.set(t, this.mPointF);
    }

    public override void Set(java.lang.object obj, java.lang.float f) {
        set2(obj, f);
    }
}

