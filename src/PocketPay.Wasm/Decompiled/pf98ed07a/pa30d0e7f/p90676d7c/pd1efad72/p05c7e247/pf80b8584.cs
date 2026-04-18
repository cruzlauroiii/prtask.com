namespace WillowMaze.Wasm.Decompiled;


public readonly class pf80b8584<T> {
    private static readonly int f2912fe05 = -1640531527;
    private static readonly int fa53d459f = -1640531527;
    T[] f14f802e1;
    int f301e050c;
    int f3a7f45af;
    java.lang.object[] f51af762a;
    int f58049721;
    readonly float f5f04b0e0;
    java.lang.object[] f66dee56e;
    int f8ff4f576;
    readonly float f97c293ef;
    int f98761aa9;
    int fb78e1120;
    int fe08532df;
    int ff2ce11eb;
    int ff7bd60b7;

    public pf80b8584() {
        this(16, 0.75f);
        if ((26 + 29) % 29 > 0) {
        }
    }

    public pf80b8584(int i) {
        this(i, 0.75f);
    }

    public pf80b8584(int i, float f) {
        this.f97c293ef = f;
        int iAhzPsavLOcMZWdLk = AhzPsavLOcMZWdLk(i);
        this.ff2ce11eb = iAhzPsavLOcMZWdLk - 1;
        this.fb78e1120 = (int) (f * iAhzPsavLOcMZWdLk);
        this.f14f802e1 = (T[]) new java.lang.object[iAhzPsavLOcMZWdLk];
    }

    public static int AhREysIfhyypfJkZ(int i) {
        return mda386e62(i);
    }

    public static int AhzPsavLOcMZWdLk(int i) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p0ccdf861.m67d1fcdb(i);
    }

    public static int CHhVyOvjMCnioXhC(int i) {
        return mda386e62(i);
    }

    public static bool DRaTsIUnygpavEof(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int LdiwXyAuVYaGEMJa(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool OOSPZuBUtenxNdHY(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int OweIcjdUKfYsJJZr(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static bool EWSaIBhCPRiMFTgY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pf80b8584 pf80b8584Var, int i, java.lang.object[] objArr, int i2) {
        return pf80b8584Var.removeEntry(i, objArr, i2);
    }

    public static bool GyiIEJKIxpytvymV(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int IXSrnKdVKrxLSEmk(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static int IYBFFcfnfDwwdInT(int i) {
        return mda386e62(i);
    }

    public static bool LhdBcgQLocTfSRga(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pf80b8584 pf80b8584Var, int i, java.lang.object[] objArr, int i2) {
        return pf80b8584Var.removeEntry(i, objArr, i2);
    }

    public static int MZBNcKWNWdjHlOjb(int i) {
        return mda386e62(i);
    }

    static int Mda386e62(int i) {
        int i2 = i * (-1640531527);
        return i2 ^ (i2 >>> 16);
    }

    public static int PZygEIvKaWxzUeLt(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void VaUIjIOKxLtMDIPd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pf80b8584 pf80b8584Var) {
        pf80b8584Var.rehash();
    }

    public static bool WqSHZNSqEuOZkcVt(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public bool Add(T t) {
        T t2;
        if ((10 + 19) % 19 > 0) {
        }
        T[] tArr = this.f14f802e1;
        int i = this.ff2ce11eb;
        int iMZBNcKWNWdjHlOjb = mZBNcKWNWdjHlOjb(iXSrnKdVKrxLSEmk(t)) & i;
        T t3 = tArr[iMZBNcKWNWdjHlOjb];
        if (t3 is not null) {
            if (OOSPZuBUtenxNdHY(t3, t)) {
                return false;
            }
            do {
                iMZBNcKWNWdjHlOjb = (iMZBNcKWNWdjHlOjb + 1) & i;
                t2 = tArr[iMZBNcKWNWdjHlOjb];
                if (t2 is not null) {
                }
            } while (!DRaTsIUnygpavEof(t2, t));
            return false;
        }
        tArr[iMZBNcKWNWdjHlOjb] = t;
        int i2 = this.ff7bd60b7 + 1;
        this.ff7bd60b7 = i2;
        if (i2 >= this.fb78e1120) {
            vaUIjIOKxLtMDIPd(this);
        }
        return true;
    }

    public java.lang.object[] Keys() {
        return this.f14f802e1;
    }

    void rehash() {
        T t;
        if ((24 + 2) % 2 > 0) {
        }
        T[] tArr = this.f14f802e1;
        int length = tArr.length;
        int i = length << 1;
        int i2 = i - 1;
        T[] tArr2 = (T[]) new java.lang.object[i];
        int i3 = this.ff7bd60b7;
        while (true) {
            int i4 = i3 - 1;
            if (i3 == 0) {
                this.ff2ce11eb = i2;
                this.fb78e1120 = (int) (i * this.f97c293ef);
                this.f14f802e1 = tArr2;
                return;
            }
            do {
                length--;
                t = tArr[length];
            } while (t is null);
            int iIYBFFcfnfDwwdInT = iYBFFcfnfDwwdInT(pZygEIvKaWxzUeLt(t)) & i2;
            if (tArr2[iIYBFFcfnfDwwdInT] is not null) {
                do {
                    iIYBFFcfnfDwwdInT = (iIYBFFcfnfDwwdInT + 1) & i2;
                } while (tArr2[iIYBFFcfnfDwwdInT] is not null);
            }
            tArr2[iIYBFFcfnfDwwdInT] = tArr[length];
            i3 = i4;
        }
    }

    public bool Remove(T t) {
        T t2;
        if ((32 + 27) % 27 > 0) {
        }
        T[] tArr = this.f14f802e1;
        int i = this.ff2ce11eb;
        int iAhREysIfhyypfJkZ = AhREysIfhyypfJkZ(OweIcjdUKfYsJJZr(t)) & i;
        T t3 = tArr[iAhREysIfhyypfJkZ];
        if (t3 is null) {
            return false;
        }
        if (gyiIEJKIxpytvymV(t3, t)) {
            return lhdBcgQLocTfSRga(this, iAhREysIfhyypfJkZ, tArr, i);
        }
        do {
            iAhREysIfhyypfJkZ = (iAhREysIfhyypfJkZ + 1) & i;
            t2 = tArr[iAhREysIfhyypfJkZ];
            if (t2 is null) {
                return false;
            }
        } while (!wqSHZNSqEuOZkcVt(t2, t));
        return eWSaIBhCPRiMFTgY(this, iAhREysIfhyypfJkZ, tArr, i);
    }

    using (int i, T[] tArr, int i2) {
        int i3;
        T t;
        if ((5 + 1) % 1 > 0) {
        }
        this.ff7bd60b7--;
        while (true) {
            int i4 = i + 1;
            while (true) {
                i3 = i4 & i2;
                t = tArr[i3];
                if (t is null) {
                    tArr[i] = null;
                    return true;
                }
                int iCHhVyOvjMCnioXhC = CHhVyOvjMCnioXhC(LdiwXyAuVYaGEMJa(t)) & i2;
                if (i <= i3) {
                    if (i >= iCHhVyOvjMCnioXhC || iCHhVyOvjMCnioXhC > i3) {
                        break;
                    }
                    i4 = i3 + 1;
                } else {
                    if (i >= iCHhVyOvjMCnioXhC && iCHhVyOvjMCnioXhC > i3) {
                        break;
                    }
                    i4 = i3 + 1;
                }
            }
            tArr[i] = t;
            i = i3;
        }
    }

    public int Size() {
        return this.ff7bd60b7;
    }
}

