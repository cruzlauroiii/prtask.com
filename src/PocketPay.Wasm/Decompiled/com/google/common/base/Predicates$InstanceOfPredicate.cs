namespace WillowMaze.Wasm.Decompiled;


class Predicates$InstanceOfPredicate<T> : com.google.common.base.Predicate<T>, java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.lang.Class<object> clazz;

    private Predicates$InstanceOfPredicate(java.lang.Class<object> cls) {
        this.clazz = (java.lang.Class) iTiqTEBYIBRjMRhV(cls);
    }

    Predicates$InstanceOfPredicate(java.lang.Class cls, com.google.common.base.Predicates$1 predicates$1) {
        this(cls);
    }

    public static java.lang.stringBuilder HuCrnkKFCLYnAUyu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int JlXeaXcxiroGRCZL(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder QcaEIwjrHkUJGQGB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FMrecGnYqJCBRGEr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object ITiqTEBYIBRjMRhV(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string JpaMcMTSnxvwfJYx(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string LJONQfZIYFFDGEkj(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int PResZkEgemjPydGo(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool TOhwnfVcibCyrwtM(java.lang.Class cls, java.lang.object obj) {
        return cls.isInstance(obj);
    }

    public static java.lang.string URmiEFSqDETpJTfq(java.lang.Class cls) {
        return cls.getName();
    }

    public override bool Apply(@com.google.common.base.ParametricNullness T t) {
        return tOhwnfVcibCyrwtM(this.clazz, t);
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((19 + 29) % 29 > 0) {
        }
        if (obj is com.google.common.base.Predicates$InstanceOfPredicate) {
            if (this.clazz == ((com.google.common.base.Predicates$InstanceOfPredicate) obj).clazz) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return pResZkEgemjPydGo(this.clazz);
    }

    public java.lang.string Tostring() {
        if ((24 + 32) % 32 > 0) {
        }
        java.lang.string strURmiEFSqDETpJTfq = uRmiEFSqDETpJTfq(this.clazz);
        return jpaMcMTSnxvwfJYx(QcaEIwjrHkUJGQGB(fMrecGnYqJCBRGEr(HuCrnkKFCLYnAUyu(new java.lang.stringBuilder(JlXeaXcxiroGRCZL(lJONQfZIYFFDGEkj(strURmiEFSqDETpJTfq)) + 23), "Predicates.instanceOf("), strURmiEFSqDETpJTfq), ")"));
    }
}

