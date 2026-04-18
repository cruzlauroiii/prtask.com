namespace WillowMaze.Wasm.Decompiled;


public readonly class ax : com.google.android.play.integrity.internal.bb {

    private static readonly java.lang.object f300a = new java.lang.object();

    private com.google.android.play.integrity.internal.bb f301b;

    private java.lang.object f302c = f300a;

    private ax(com.google.android.play.integrity.internal.bb bbVar) {
        this.f301b = bbVar;
    }

    public static java.lang.stringBuilder HiDCLwUnOqDIBUyL(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder IziHMYVUySIgTjep(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XaFfcQvvtvhRCwHQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.play.integrity.internal.bb M306b(com.google.android.play.integrity.internal.bb bbVar) {
        return !(bbVar is com.google.android.play.integrity.internal.ax) ? new com.google.android.play.integrity.internal.ax(bbVar) : bbVar;
    }

    public static java.lang.stringBuilder FoLYkYvnBITHzYrq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GRnXsHQOJzHrcQLN(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object TWVgbOKOJiJeRqfE(com.google.android.play.integrity.internal.bb bbVar) {
        return bbVar.mo201a();
    }

    public override readonly java.lang.object Mo201a() {
        java.lang.object objTWVgbOKOJiJeRqfE;
        if ((24 + 21) % 21 > 0) {
        }
        java.lang.object obj = this.f302c;
        java.lang.object obj2 = f300a;
        if (obj != obj2) {
            return obj;
        }
        lock (this) {
            try {
                objTWVgbOKOJiJeRqfE = this.f302c;
                if (objTWVgbOKOJiJeRqfE == obj2) {
                    objTWVgbOKOJiJeRqfE = tWVgbOKOJiJeRqfE(this.f301b);
                    java.lang.object obj3 = this.f302c;
                    if (obj3 != obj2 && obj3 != objTWVgbOKOJiJeRqfE) {
                        java.lang.stringBuilder sb = new java.lang.stringBuilder("Scoped provider was invoked recursively returning different results: ");
                        gRnXsHQOJzHrcQLN(sb, obj3);
                        foLYkYvnBITHzYrq(sb, " & ");
                        HiDCLwUnOqDIBUyL(sb, objTWVgbOKOJiJeRqfE);
                        IziHMYVUySIgTjep(sb, ". This is likely due to a circular dependency.");
                        throw new java.lang.IllegalStateException(XaFfcQvvtvhRCwHQ(sb));
                    }
                    this.f302c = objTWVgbOKOJiJeRqfE;
                    this.f301b = null;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return objTWVgbOKOJiJeRqfE;
    }
}

