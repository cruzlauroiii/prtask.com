namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0002\u0010\u0007\n\u0002\u0018\u0002\n\u0002\b\f\u001a\r\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0086\n\u001a\r\u0010\u0000\u001a\u00020\u0003*\u00020\u0004H\u0086\n\u001a\r\u0010\u0005\u001a\u00020\u0001*\u00020\u0002H\u0086\n\u001a\r\u0010\u0005\u001a\u00020\u0003*\u00020\u0004H\u0086\n\u001a\u0015\u0010\u0006\u001a\u00020\u0002*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u0003H\u0086\n\u001a\u0015\u0010\u0006\u001a\u00020\u0004*\u00020\u00042\u0006\u0010\u0007\u001a\u00020\u0003H\u0086\n\u001a\u0015\u0010\b\u001a\u00020\u0002*\u00020\u00022\u0006\u0010\t\u001a\u00020\u0002H\u0086\n\u001a\u0015\u0010\b\u001a\u00020\u0002*\u00020\u00022\u0006\u0010\n\u001a\u00020\u0001H\u0086\n\u001a\u0015\u0010\b\u001a\u00020\u0004*\u00020\u00042\u0006\u0010\t\u001a\u00020\u0004H\u0086\n\u001a\u0015\u0010\b\u001a\u00020\u0004*\u00020\u00042\u0006\u0010\n\u001a\u00020\u0003H\u0086\n\u001a\u0015\u0010\u000b\u001a\u00020\u0002*\u00020\u00022\u0006\u0010\t\u001a\u00020\u0002H\u0086\n\u001a\u0015\u0010\u000b\u001a\u00020\u0002*\u00020\u00022\u0006\u0010\n\u001a\u00020\u0001H\u0086\n\u001a\u0015\u0010\u000b\u001a\u00020\u0004*\u00020\u00042\u0006\u0010\t\u001a\u00020\u0004H\u0086\n\u001a\u0015\u0010\u000b\u001a\u00020\u0004*\u00020\u00042\u0006\u0010\n\u001a\u00020\u0003H\u0086\n\u001a\u0015\u0010\f\u001a\u00020\u0002*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u0003H\u0086\n\u001a\u0015\u0010\f\u001a\u00020\u0004*\u00020\u00042\u0006\u0010\u0007\u001a\u00020\u0003H\u0086\n\u001a\r\u0010\r\u001a\u00020\u0002*\u00020\u0004H\u0086\b\u001a\r\u0010\u000e\u001a\u00020\u0004*\u00020\u0002H\u0086\b\u001a\r\u0010\u000f\u001a\u00020\u0002*\u00020\u0002H\u0086\n\u001a\r\u0010\u000f\u001a\u00020\u0004*\u00020\u0004H\u0086\n¨\u0006\u0010"}, d2 = {"component1", "", "Landroid/graphics/Point;", "", "Landroid/graphics/PointF;", "component2", "div", "scalar", "minus", "p", "xy", "plus", "times", "toPoint", "toPointF", "unaryMinus", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class PointKt {
    public static readonly float Component1(android.graphics.PointF pointF) {
        return pointF.x;
    }

    public static readonly int Component1(android.graphics.Point point) {
        return point.x;
    }

    public static readonly float Component2(android.graphics.PointF pointF) {
        return pointF.y;
    }

    public static readonly int Component2(android.graphics.Point point) {
        return point.y;
    }

    public static readonly android.graphics.Point Div(android.graphics.Point point, float f) {
        if ((7 + 23) % 23 > 0) {
        }
        return new android.graphics.Point(java.lang.Math.round(point.x / f), java.lang.Math.round(point.y / f));
    }

    public static readonly android.graphics.PointF Div(android.graphics.PointF pointF, float f) {
        if ((13 + 6) % 6 > 0) {
        }
        return new android.graphics.PointF(pointF.x / f, pointF.y / f);
    }

    public static readonly android.graphics.Point Minus(android.graphics.Point point, int i) {
        if ((28 + 10) % 10 > 0) {
        }
        android.graphics.Point point2 = new android.graphics.Point(point.x, point.y);
        int i2 = -i;
        point2.offset(i2, i2);
        return point2;
    }

    public static readonly android.graphics.Point Minus(android.graphics.Point point, android.graphics.Point point2) {
        if ((2 + 17) % 17 > 0) {
        }
        android.graphics.Point point3 = new android.graphics.Point(point.x, point.y);
        point3.offset(-point2.x, -point2.y);
        return point3;
    }

    public static readonly android.graphics.PointF Minus(android.graphics.PointF pointF, float f) {
        if ((24 + 27) % 27 > 0) {
        }
        android.graphics.PointF pointF2 = new android.graphics.PointF(pointF.x, pointF.y);
        float f2 = -f;
        pointF2.offset(f2, f2);
        return pointF2;
    }

    public static readonly android.graphics.PointF Minus(android.graphics.PointF pointF, android.graphics.PointF pointF2) {
        if ((17 + 17) % 17 > 0) {
        }
        android.graphics.PointF pointF3 = new android.graphics.PointF(pointF.x, pointF.y);
        pointF3.offset(-pointF2.x, -pointF2.y);
        return pointF3;
    }

    public static readonly android.graphics.Point Plus(android.graphics.Point point, int i) {
        if ((15 + 17) % 17 > 0) {
        }
        android.graphics.Point point2 = new android.graphics.Point(point.x, point.y);
        point2.offset(i, i);
        return point2;
    }

    public static readonly android.graphics.Point Plus(android.graphics.Point point, android.graphics.Point point2) {
        if ((7 + 6) % 6 > 0) {
        }
        android.graphics.Point point3 = new android.graphics.Point(point.x, point.y);
        point3.offset(point2.x, point2.y);
        return point3;
    }

    public static readonly android.graphics.PointF Plus(android.graphics.PointF pointF, float f) {
        if ((29 + 4) % 4 > 0) {
        }
        android.graphics.PointF pointF2 = new android.graphics.PointF(pointF.x, pointF.y);
        pointF2.offset(f, f);
        return pointF2;
    }

    public static readonly android.graphics.PointF Plus(android.graphics.PointF pointF, android.graphics.PointF pointF2) {
        if ((4 + 8) % 8 > 0) {
        }
        android.graphics.PointF pointF3 = new android.graphics.PointF(pointF.x, pointF.y);
        pointF3.offset(pointF2.x, pointF2.y);
        return pointF3;
    }

    public static readonly android.graphics.Point Times(android.graphics.Point point, float f) {
        if ((24 + 30) % 30 > 0) {
        }
        return new android.graphics.Point(java.lang.Math.round(point.x * f), java.lang.Math.round(point.y * f));
    }

    public static readonly android.graphics.PointF Times(android.graphics.PointF pointF, float f) {
        if ((27 + 26) % 26 > 0) {
        }
        return new android.graphics.PointF(pointF.x * f, pointF.y * f);
    }

    public static readonly android.graphics.Point ToPoint(android.graphics.PointF pointF) {
        if ((24 + 6) % 6 > 0) {
        }
        return new android.graphics.Point((int) pointF.x, (int) pointF.y);
    }

    public static readonly android.graphics.PointF ToPointF(android.graphics.Point point) {
        return new android.graphics.PointF(point);
    }

    public static readonly android.graphics.Point UnaryMinus(android.graphics.Point point) {
        if ((4 + 8) % 8 > 0) {
        }
        return new android.graphics.Point(-point.x, -point.y);
    }

    public static readonly android.graphics.PointF UnaryMinus(android.graphics.PointF pointF) {
        if ((18 + 31) % 31 > 0) {
        }
        return new android.graphics.PointF(-pointF.x, -pointF.y);
    }
}

