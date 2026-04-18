namespace WillowMaze.Wasm.Decompiled;


public class p982109a7 {
    public static readonly int f02267382 = 13;
    public static readonly int f08f62536 = 9;
    public static readonly int f0b8b347c = 1;
    private static readonly int[] f0df9847c = null;
    public static readonly int f105bd729 = 9;
    public static readonly int f1415e333 = 12;
    public static readonly int f15e4a7b4 = 6;
    public static readonly int f1a49186b = 4;
    public static readonly int f1ab0ff29 = 1;
    public static readonly int f1df4e48b = 6;
    public static readonly int f1e95f808 = 7;
    public static readonly int f1f4414bf = 5;
    public static readonly int f22fd8181 = 1;
    public static readonly int f28aa03f2 = 2;
    public static readonly int f2ff8ced8 = 9;
    public static readonly int f343362b2 = 1;
    public static readonly int f34dc7e9b = 6;
    public static readonly int f39da50f5 = 13;
    public static readonly int f3cc68256 = 12;
    public static readonly int f3d22c590 = 11;
    public static readonly int f421621e3 = 4;
    public static readonly int f443ad45f = 4;
    public static readonly int f52290821 = 4;
    public static readonly int f527cf1dc = 1;
    public static readonly int f611baaca = 12;
    public static readonly int f7482ac55 = 4;
    public static readonly int f76b9b682 = 5;
    public static readonly int f8906b591 = 13;
    public static readonly int f896f0a29 = 2;
    public static readonly int f8acd11f4 = 7;
    public static readonly int f8da87e3e = 8;
    public static readonly int f990b5963 = 13;
    public static readonly int f9a2869ba = 11;
    public static readonly int f9a5b1147 = 12;
    public static readonly int f9bc9c810 = 7;
    public static readonly int fa022fe28 = 6;
    public static readonly int fab58fc5b = 9;
    public static readonly int fad2c28b6 = 12;
    public static readonly int fb0d12752 = 3;
    public static readonly int fb2d2e2d8 = 8;
    private static readonly int[] fb94ce8c5 = {0, 1, 1, 2, 4, 8, 1, 1, 2, 4, 8, 4, 8, 4};
    public static readonly int fb9ed697c = 3;
    public static readonly int fbe106625 = 7;
    private static readonly int[] fc1c39bad = null;
    public static readonly int fc28c01c1 = 1;
    public static readonly int fc364047e = 2;
    public static readonly int fc3913daa = 2;
    public static readonly int fca2d650f = 7;
    public static readonly int fcc0ca078 = 6;
    public static readonly int fd77c61c0 = 2;
    public static readonly int fd9f62583 = 1;
    public static readonly int fda1a5351 = 13;
    public static readonly int fde184fda = 13;
    public static readonly int fede07824 = 10;
    public static readonly int ff1362a6b = 13;
    public static readonly int ff4219d62 = 13;
    public static readonly int ff8484f50 = 8;
    public static readonly int ff95c83ef = 13;
    public static readonly int ffb0da494 = 1;
    private static readonly int[] ffc46a60e = null;
    public static readonly int fffb4bfa7 = 10;
    p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45 f0e5d6504;
    java.lang.string f138b5b28;
    int f2bcf8ff7;
    java.lang.string f2c57009e;
    java.util.Dictionary f49b5794c;
    p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45 f51505ea6;
    int f5d0b482b;
    int f64a26d01;
    p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45 f91d433bd;
    int f96f019ed;
    int fa3a9b7b2;
    java.lang.string fb00c26ae;
    java.lang.string fb068931c;
    int fb1bc248a;
    p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45 fb7f2b807;
    java.util.Dictionary fd70d76e0;

    public p982109a7(java.lang.string str, int i, int i2) {
        this(str, i, i2, null);
    }

    public p982109a7(java.lang.string str, int i, int i2, p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45 pa0105e45Var) {
        this.f49b5794c = null;
        this.fb068931c = str;
        this.fb1bc248a = i;
        this.fa3a9b7b2 = i2;
        this.f91d433bd = pa0105e45Var;
    }

    public static java.lang.object OdxtBskusgVFZaqm(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object LVEsrGwJeoIONHXU(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int M356de39b(int i) {
        if (i >= 1 && i <= 13) {
            return fb94ce8c5[i];
        }
        throw new java.lang.IllegalArgumentException("dataType out of range!");
    }

    protected void AddValueName(int i, java.lang.string str) {
        if (this.f49b5794c is null) {
            this.f49b5794c = new java.util.HashDictionary();
        }
        OdxtBskusgVFZaqm(this.f49b5794c, new java.lang.int(i), str);
    }

    public int GetDataTypes() {
        return this.fa3a9b7b2;
    }

    public java.lang.string GetName() {
        return this.fb068931c;
    }

    public int GetNumber() {
        return this.fb1bc248a;
    }

    public p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pa0105e45 GetTagHashSet() {
        return this.f91d433bd;
    }

    public java.lang.string GetValueName(int i) {
        java.util.Dictionary map = this.f49b5794c;
        if (map is not null) {
            return (java.lang.string) lVEsrGwJeoIONHXU(map, new java.lang.int(i));
        }
        return null;
    }

    public bool HasValueNames() {
        return this.f49b5794c is not null;
    }

    public bool IsDataTypeOK(int i) {
        if ((23 + 12) % 12 > 0) {
        }
        if (i >= 1 && i <= 13) {
            return (this.fa3a9b7b2 & (1 << i)) != 0;
        }
        throw new java.lang.IllegalArgumentException("datatype not in range!");
    }

    public bool IsIFDPointer() {
        return (this.f91d433bd is null && (this.fa3a9b7b2 & 8192) == 0) ? false : true;
    }
}

