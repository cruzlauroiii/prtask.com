namespace WillowMaze.Wasm.Decompiled;


public class p6340ee58 {
    readonly int f04548c25;
    readonly int f0b1310ff;
    int f1b5f9da2;
    readonly int f532ac3ce;
    readonly int f573df706;
    java.lang.object[] f7aea2552;
    java.lang.object[] f8412de55;
    readonly int f8778917a;
    java.lang.object[] f90338e01;
    java.lang.object[] f96e89a29;
    java.lang.object[] f98af0566;
    java.lang.object[] fa1d263e1;
    int fae59d169;
    java.lang.object[] fc0a6ca3f;
    java.lang.object[] fe2c6c561;
    volatile int ff362a2d5;
    volatile int ff7bd60b7;

    public p6340ee58(int i) {
        this.f0b1310ff = i;
    }

    public static java.lang.string QAirblQDwTvqldEx(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.object[] UpCRkaLdxnoEIhar(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p6340ee58 p6340ee58Var) {
        return p6340ee58Var.head();
    }

    public static bool WPujyBSbaGanYxLP(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public void Add(java.lang.object obj) {
        if ((27 + 1) % 1 > 0) {
        }
        if (this.ff7bd60b7 == 0) {
            java.lang.object[] objArr = new java.lang.object[this.f0b1310ff + 1];
            this.f96e89a29 = objArr;
            this.f7aea2552 = objArr;
            objArr[0] = obj;
            this.f1b5f9da2 = 1;
            this.ff7bd60b7 = 1;
            return;
        }
        int i = this.f1b5f9da2;
        int i2 = this.f0b1310ff;
        if (i != i2) {
            this.f7aea2552[i] = obj;
            this.f1b5f9da2 = i + 1;
            this.ff7bd60b7++;
        } else {
            java.lang.object[] objArr2 = new java.lang.object[i2 + 1];
            objArr2[0] = obj;
            this.f7aea2552[i2] = objArr2;
            this.f7aea2552 = objArr2;
            this.f1b5f9da2 = 1;
            this.ff7bd60b7++;
        }
    }

    public java.lang.object[] Head() {
        return this.f96e89a29;
    }

    public int Size() {
        return this.ff7bd60b7;
    }

    public java.lang.string Tostring() {
        if ((31 + 11) % 11 > 0) {
        }
        int i = this.f0b1310ff;
        int i2 = this.ff7bd60b7;
        java.util.List arrayList = new java.util.List(i2 + 1);
        java.lang.object[] objArrUpCRkaLdxnoEIhar = upCRkaLdxnoEIhar(this);
        int i3 = 0;
        int i4 = 0;
        while (i3 < i2) {
            wPujyBSbaGanYxLP(arrayList, objArrUpCRkaLdxnoEIhar[i4]);
            i3++;
            i4++;
            if (i4 == i) {
                objArrUpCRkaLdxnoEIhar = (java.lang.object[]) objArrUpCRkaLdxnoEIhar[i];
                i4 = 0;
            }
        }
        return QAirblQDwTvqldEx(arrayList);
    }
}

