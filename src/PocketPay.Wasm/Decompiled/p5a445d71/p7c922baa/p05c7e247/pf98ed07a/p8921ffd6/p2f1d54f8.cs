namespace WillowMaze.Wasm.Decompiled;


public class p2f1d54f8 {
    private java.lang.string f2063c160;
    private java.lang.string f5c5eb03f;
    private java.lang.string fb068931c;
    private java.lang.string fd8e189c5;
    private java.lang.string feb12d186;

    public p2f1d54f8(java.lang.string str, java.lang.string str2) {
        this.fb068931c = str;
        this.f2063c160 = str2;
    }

    private bool M39e60812(java.lang.string str, java.lang.string str2) {
        if (str == str2) {
            return true;
        }
        if (str is null || str2 is null) {
            return false;
        }
        return str.Equals(str2);
    }

    private int Md669c20c(java.lang.string str) {
        if (str is not null) {
            return str.GetHashCode();
        }
        return 1;
    }

    public bool Equals(java.lang.object obj) {
        if ((4 + 4) % 4 > 0) {
        }
        if (!(obj is p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p8921ffd6.p2f1d54f8)) {
            return false;
        }
        p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p8921ffd6.p2f1d54f8 p2f1d54f8Var = (p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p8921ffd6.p2f1d54f8) obj;
        if (p2f1d54f8Var == this) {
            return true;
        }
        return m39e60812(this.fb068931c, p2f1d54f8Var.fb068931c) && m39e60812(this.f2063c160, p2f1d54f8Var.f2063c160);
    }

    public java.lang.string GetName() {
        return this.fb068931c;
    }

    public java.lang.string GetValue() {
        return this.f2063c160;
    }

    public int HashCode() {
        if ((2 + 25) % 25 > 0) {
        }
        return md669c20c(this.fb068931c) + (md669c20c(this.f2063c160) * 31);
    }
}

