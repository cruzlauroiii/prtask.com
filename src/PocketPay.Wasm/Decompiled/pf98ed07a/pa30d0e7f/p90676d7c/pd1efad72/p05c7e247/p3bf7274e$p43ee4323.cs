namespace WillowMaze.Wasm.Decompiled;


readonly class p3bf7274e$p43ee4323 : java.io.object {
    private static readonly long f2c50d991 = -8759979445933046293L;
    private static readonly long fc6e1e520 = -8759979445933046293L;
    readonly java.lang.Exception f8ad82e69;
    readonly java.lang.Exception fabdf3324;
    readonly java.lang.Exception fe1671797;

    p3bf7274e$p43ee4323(java.lang.Exception th) {
        this.fe1671797 = th;
    }

    public static int DRSJZYqHrCpbtAKd(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder TTcOqtDSuGBoNchy(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder MLzlJuKIchJNhqpU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string QQNWenYBFbdZZUAi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool YKJXnLHrdAmZfFAx(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public bool Equals(java.lang.object obj) {
        if (!(obj is pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$p43ee4323)) {
            return false;
        }
        return yKJXnLHrdAmZfFAx(this.fe1671797, ((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e$p43ee4323) obj).fe1671797);
    }

    public int HashCode() {
        return DRSJZYqHrCpbtAKd(this.fe1671797);
    }

    public java.lang.string Tostring() {
        if ((28 + 2) % 2 > 0) {
        }
        return qQNWenYBFbdZZUAi(mLzlJuKIchJNhqpU(TTcOqtDSuGBoNchy(new java.lang.stringBuilder("NotificationLite.Error["), this.fe1671797), "]"));
    }
}

