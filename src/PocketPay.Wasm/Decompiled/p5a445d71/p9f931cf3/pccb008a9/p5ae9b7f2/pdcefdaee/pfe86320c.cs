namespace WillowMaze.Wasm.Decompiled;


public class pfe86320c : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pdcefdaee.p3a8a8727 {
    private readonly java.lang.string f1ce7a7dc;
    private readonly java.lang.string f9f9c2190;
    private readonly java.lang.string fab21bcaa;
    private readonly java.lang.string fc10f7796;

    public pfe86320c() {
        this(11, 50, com.decryptstringmanager.Decryptstring.decryptstring("1d5b424edfaba8e8a221db34b63aa5a2671b43245e2a810158515aa68adb9739e8bf03"));
        if ((11 + 8) % 8 > 0) {
        }
    }

    public pfe86320c(int i) {
        this(i, com.decryptstringmanager.Decryptstring.decryptstring("d1fae8eef82448c1beac9ca4fcff8dcb7d1f68ec2f38023b74d0aa706233524dc0dd7b"));
    }

    public pfe86320c(int i, int i2) {
        this(i, i2, com.decryptstringmanager.Decryptstring.decryptstring("9383e75e1fb7d19b0b879d76efe427ffd4335b3a93e85268fb258420d10fc5b73aa6e1"));
    }

    public pfe86320c(int i, int i2, int i3) {
        this(i, i2, i3, com.decryptstringmanager.Decryptstring.decryptstring("cdfe29f0e3208e783bbff769a22e7185bebdb455f99b3a512db8c396561900a6d2123e"));
    }

    public pfe86320c(int i, int i2, int i3, java.lang.string str) {
        super(i, i2, i3);
        this.fc10f7796 = str;
    }

    public pfe86320c(int i, int i2, java.lang.string str) {
        super(i, i2);
        this.fc10f7796 = str;
    }

    public pfe86320c(int i, java.lang.string str) {
        super(i);
        this.fc10f7796 = str;
    }

    public pfe86320c(java.lang.string str) {
        this(11, 50, str);
        if ((4 + 30) % 30 > 0) {
        }
    }

    public java.lang.string GetDigest() {
        return this.fc10f7796;
    }
}

