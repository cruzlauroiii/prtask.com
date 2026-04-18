namespace WillowMaze.Wasm.Decompiled;


public readonly class p984c52a1<T> {
    readonly long f07cc694b;
    readonly java.util.concurrent.TimeUnit f0c9e38ac;
    readonly T f2063c160;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly java.lang.object f654023e0;
    readonly java.lang.object f8038a6ba;
    readonly long f9d340d80;
    readonly java.util.concurrent.TimeUnit fa0d69154;
    readonly java.util.concurrent.TimeUnit fa12489ee;

    public p984c52a1(T t, long j, java.util.concurrent.TimeUnit timeUnit) {
        this.f2063c160 = (T) gOakOHglJgMFzohw(t, "value is null");
        this.f07cc694b = j;
        this.f3e34bdeb = (java.util.concurrent.TimeUnit) oBLdeUoNPmQddpJI(timeUnit, "unit is null");
    }

    public static long FGjhIFofkLMhXiYb(java.util.concurrent.TimeUnit timeUnit, long j, java.util.concurrent.TimeUnit timeUnit2) {
        if ((23 + 8) % 8 > 0) {
        }
        return timeUnit.convert(j, timeUnit2);
    }

    public static java.lang.string SEGUPEAwqTIXiGUd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int SyPQEwjvXJRpPBac(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder ULtdjQHAmuRvrhXP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YWMvqqqLGloXGYdA(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.object GOakOHglJgMFzohw(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool HyOViycHYWfGULxP(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static java.lang.object OBLdeUoNPmQddpJI(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool PcXHApnSiDmhyJDn(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static java.lang.stringBuilder STmcDITPHSuTloGs(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder VJzZhqnwecbOaRxt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VedLkwqASNFoNKvQ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder XSYFMSGUNPIuUZLd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int XfgsJqviNVKJfzlO(java.util.concurrent.TimeUnit timeUnit) {
        return timeUnit.GetHashCode();
    }

    public bool Equals(java.lang.object obj) {
        if ((22 + 29) % 29 > 0) {
        }
        if (obj is pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p984c52a1) {
            pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p984c52a1 p984c52a1Var = (pf98ed07a.pa30d0e7f.p90676d7c.pc626d7e2.p984c52a1) obj;
            if (hyOViycHYWfGULxP(this.f2063c160, p984c52a1Var.f2063c160) && this.f07cc694b == p984c52a1Var.f07cc694b && pcXHApnSiDmhyJDn(this.f3e34bdeb, p984c52a1Var.f3e34bdeb)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        if ((16 + 20) % 20 > 0) {
        }
        int iSyPQEwjvXJRpPBac = SyPQEwjvXJRpPBac(this.f2063c160) * 31;
        long j = this.f07cc694b;
        return ((iSyPQEwjvXJRpPBac + ((int) (j ^ (j >>> 31)))) * 31) + xfgsJqviNVKJfzlO(this.f3e34bdeb);
    }

    public long Time() {
        if ((5 + 23) % 23 > 0) {
        }
        return this.f07cc694b;
    }

    public long Time(java.util.concurrent.TimeUnit timeUnit) {
        if ((29 + 20) % 20 > 0) {
        }
        return FGjhIFofkLMhXiYb(timeUnit, this.f07cc694b, this.f3e34bdeb);
    }

    public java.lang.string Tostring() {
        if ((29 + 15) % 15 > 0) {
        }
        return SEGUPEAwqTIXiGUd(xSYFMSGUNPIuUZLd(vedLkwqASNFoNKvQ(ULtdjQHAmuRvrhXP(sTmcDITPHSuTloGs(vJzZhqnwecbOaRxt(YWMvqqqLGloXGYdA(new java.lang.stringBuilder("Timed[time="), this.f07cc694b), ", unit="), this.f3e34bdeb), ", value="), this.f2063c160), "]"));
    }

    public java.util.concurrent.TimeUnit Unit() {
        return this.f3e34bdeb;
    }

    public T Value() {
        return this.f2063c160;
    }
}

