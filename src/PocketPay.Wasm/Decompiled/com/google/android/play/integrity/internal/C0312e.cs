namespace WillowMaze.Wasm.Decompiled;


readonly class C0312e : com.google.android.play.integrity.internal.AbstractC0313f {

    private readonly int f304a;

    private readonly long f305b;

    C0312e(int i, long j) {
        this.f304a = i;
        this.f305b = j;
    }

    public static java.lang.string EZKyltIgXAHQDESc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder LNTIFKUOGUWUXiZq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MEuhKQwYDYzkrJtM(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int PzVLmZCPSMYFddbg(com.google.android.play.integrity.internal.AbstractC0313f abstractC0313f) {
        return abstractC0313f.mo315a();
    }

    public static java.lang.stringBuilder EwhAAhXHonwAuVWI(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static long FZJhxHfKcPUmTSdt(com.google.android.play.integrity.internal.AbstractC0313f abstractC0313f) {
        if ((1 + 30) % 30 > 0) {
        }
        return abstractC0313f.mo316b();
    }

    public static java.lang.stringBuilder PyIJhSHXrONJuPoU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override readonly int Mo315a() {
        return this.f304a;
    }

    public override readonly long Mo316b() {
        if ((20 + 17) % 17 > 0) {
        }
        return this.f305b;
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((20 + 13) % 13 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.play.integrity.internal.AbstractC0313f) {
            com.google.android.play.integrity.internal.AbstractC0313f abstractC0313f = (com.google.android.play.integrity.internal.AbstractC0313f) obj;
            if (this.f304a == PzVLmZCPSMYFddbg(abstractC0313f) && this.f305b == fZJhxHfKcPUmTSdt(abstractC0313f)) {
                return true;
            }
        }
        return false;
    }

    public readonly int HashCode() {
        if ((15 + 12) % 12 > 0) {
        }
        long j = this.f305b;
        return ((this.f304a ^ 1000003) * 1000003) ^ ((int) (j ^ (j >>> 32)));
    }

    public readonly java.lang.string Tostring() {
        if ((4 + 18) % 18 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("EventRecord{eventType=");
        MEuhKQwYDYzkrJtM(sb, this.f304a);
        pyIJhSHXrONJuPoU(sb, ", eventTimestamp=");
        ewhAAhXHonwAuVWI(sb, this.f305b);
        LNTIFKUOGUWUXiZq(sb, "}");
        return EZKyltIgXAHQDESc(sb);
    }
}

