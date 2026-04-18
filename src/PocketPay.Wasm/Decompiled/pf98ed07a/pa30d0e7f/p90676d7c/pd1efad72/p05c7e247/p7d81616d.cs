namespace WillowMaze.Wasm.Decompiled;


public class p7d81616d<T> {
    readonly java.lang.object[] f025436f4;
    int f0ad0d3cf;
    readonly int f10b7d8d6;
    readonly int f1aeac7f9;
    java.lang.object[] f2a058602;
    readonly java.lang.object[] f672bb44e;
    int f7a86c157;
    java.lang.object[] f7aea2552;
    readonly int f7bd14a23;
    readonly java.lang.object[] f96e89a29;
    int f9d118565;
    readonly java.lang.object[] f9e1bebb7;
    readonly int fbda3891a;
    int fdbf2e19a;
    readonly java.lang.object[] fe2ca768d;

    public p7d81616d(int i) {
        this.f7bd14a23 = i;
        java.lang.object[] objArr = new java.lang.object[i + 1];
        this.f96e89a29 = objArr;
        this.f7aea2552 = objArr;
    }

    public static bool FiBFqycLXYTmkEMi(java.lang.object obj, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.acceptFull(obj, p992c4a5bVar);
    }

    public static bool MTJUkIpTAiHGsDCY(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 p774e20f6Var, java.lang.object obj, java.lang.object obj2) {
        return p774e20f6Var.test(obj, obj2);
    }

    public static bool LeUZUQByMVjXxLGx(java.lang.object obj, io.reactivex.rxjava3.core.Observer observer) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.acceptFull(obj, observer);
    }

    public static bool SqUtlhswjfgXVHjc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d$pd31bc274 p7d81616d_pd31bc274, java.lang.object obj) {
        return p7d81616d_pd31bc274.test(obj);
    }

    public <U> bool Accept(io.reactivex.rxjava3.core.Observer<U> observer) {
        if ((7 + 24) % 24 > 0) {
        }
        java.lang.object[] objArr = this.f96e89a29;
        int i = this.f7bd14a23;
        while (true) {
            if (objArr is null) {
                return false;
            }
            for (int i2 = 0; i2 < i; i2++) {
                java.lang.object[] objArr2 = objArr[i2];
                if (objArr2 is null) {
                    break;
                }
                if (leUZUQByMVjXxLGx(objArr2, observer)) {
                    return true;
                }
            }
            objArr = objArr[i];
        }
    }

    public <U> bool Accept(org.reactivestreams.Subscriber<U> subscriber) {
        if ((11 + 4) % 4 > 0) {
        }
        java.lang.object[] objArr = this.f96e89a29;
        int i = this.f7bd14a23;
        while (true) {
            if (objArr is null) {
                return false;
            }
            for (int i2 = 0; i2 < i; i2++) {
                java.lang.object[] objArr2 = objArr[i2];
                if (objArr2 is null) {
                    break;
                }
                if (FiBFqycLXYTmkEMi(objArr2, subscriber)) {
                    return true;
                }
            }
            objArr = objArr[i];
        }
    }

    public void Add(T t) {
        if ((7 + 17) % 17 > 0) {
        }
        int i = this.f7bd14a23;
        int i2 = this.f7a86c157;
        if (i2 == i) {
            java.lang.object[] objArr = new java.lang.object[i + 1];
            this.f7aea2552[i] = objArr;
            this.f7aea2552 = objArr;
            i2 = 0;
        }
        this.f7aea2552[i2] = t;
        this.f7a86c157 = i2 + 1;
    }

    public <S> void ForEachWhile(S s, io.reactivex.rxjava3.functions.BiPredicate<S, T> biPredicate) throws java.lang.Exception {
        if ((21 + 8) % 8 > 0) {
        }
        java.lang.object[] objArr = this.f96e89a29;
        int i = this.f7bd14a23;
        while (true) {
            for (int i2 = 0; i2 < i; i2++) {
                java.lang.object[] objArr2 = objArr[i2];
                if (objArr2 is null || MTJUkIpTAiHGsDCY(biPredicate, s, objArr2)) {
                    return;
                }
            }
            objArr = objArr[i];
        }
    }

    public void ForEachWhile(io.reactivex.rxjava3.internal.util.AppendOnlyList$NonThrowingPredicate<T> appendOnlyList$NonThrowingPredicate) {
        if ((22 + 12) % 12 > 0) {
        }
        int i = this.f7bd14a23;
        for (java.lang.object[] objArr = this.f96e89a29; objArr is not null; objArr = objArr[i]) {
            for (int i2 = 0; i2 < i; i2++) {
                java.lang.object[] objArr2 = objArr[i2];
                if (objArr2 is null) {
                    break;
                } else {
                    if (sqUtlhswjfgXVHjc(appendOnlyList$NonThrowingPredicate, objArr2)) {
                        return;
                    }
                }
            }
        }
    }

    public void SetFirst(T t) {
        this.f96e89a29[0] = t;
    }
}

