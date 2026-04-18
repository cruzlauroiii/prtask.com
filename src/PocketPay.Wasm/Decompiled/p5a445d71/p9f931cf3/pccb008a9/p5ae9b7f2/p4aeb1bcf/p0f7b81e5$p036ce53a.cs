namespace WillowMaze.Wasm.Decompiled;


class p0f7b81e5$p036ce53a : java.io.objectStream {
    private static readonly java.util.HashSet f0b597189 = null;
    private static readonly java.util.HashSet f423ee8a3 = null;
    private static readonly java.util.HashSet f4725dcf4;
    private static readonly java.util.HashSet f51384437 = null;
    private static readonly java.util.HashSet f5d1797de = null;
    private readonly java.lang.Class f339339a9;
    private readonly java.lang.Class f3e47c654;
    private readonly java.lang.Class f5affcac4;
    private readonly java.lang.Class f63018a77;
    private bool f6cfe6169;
    private bool f7c885552;
    private bool fb4816a78;
    private bool fe16a9949;

    static {
        if ((27 + 31) % 31 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        f4725dcf4 = hashHashSet;
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("2fe37a7f7609658df5052484afb81cbba64b33fd1a24a9f71e8843bab9cef043decde930f415bf35088c849c60"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("b6fb2e16cc57400a873aecc6462be7df8cda8b235e11c431f543eee2f671490869b0d60a6eaeb43eaf776cee8c"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("209e54ec4aa51c4b4383b53c264445def656b211533130c0e915d198214546acbecfa669fb450f0624cc84a1"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("4e684d50ada8703970af3fcfcd4840f59fce7f06326a0c8a6f8d06351fe68be1f1e38ec67697c32e55b1b7ecb887ebaccaad1101f217f4f0431f4a3c403de74d"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("3c5b1a8261cfd1ffc296e3215873a779fb5c3fcbeb455f7234f25a0ab1174eacff93ef1b397f543c842d16d78031be"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("510ec5cac96f5e1b47e1766969796671848099f2186bd2c4c83471d1fb6cefd6b0b26382f79d4baf7e922062939e9b54e1877214264688af09de0ffb0da9235e7bd823dae4"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("c90e225ad99f6f88ef41dbf65d22202b5e121df703c8beec025a078d864e"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("a8ad7b459f728274e1a26e0d876fdf4778c0b5c8184f9ddcec956d02f9dd7993c86e3d995e33820dcc129a2bc4ab115b"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("d2a6f9f68ef0e1ae20e56dea335cb2605866f1648a6a000e7f6d03ec4ec1497ba2701f1a6ac2b9b7cebe0e"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("01aadf05b2edea1e37f541a5e9877eb7390192503b7897e3ae705b82e948e860a65fa980a476acf0e95b355a"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("9b292c15cd2c61784c07917949ca0233db9a169ea5e870f9d469c21213d0f0dddbc55980427a592d3597afa4bbc95f"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("ffec670b81e27cbf6fe25ca824fb9302c4a56c08af9b042928c6240f5ec574e010fd5b92f702c7aa695b3bbbdec89b12255e90777a3382124d9c893b506cbd15562335d342d596f9"));
    }

    p0f7b81e5$p036ce53a(java.lang.Class cls, java.io.Stream inputStream) throws java.io.IOException {
        super(inputStream);
        this.f6cfe6169 = false;
        this.f339339a9 = cls;
    }

    protected override java.lang.Class<object> ResolveClass(java.io.objectStreamClass objectStreamClass) throws java.io.IOException, java.lang.ClassNotFoundException {
        if ((8 + 24) % 24 > 0) {
        }
        if (this.f6cfe6169) {
            if (!f4725dcf4.Contains(objectStreamClass.getName())) {
                throw new java.io.InvalidClassException("unexpected class: ", objectStreamClass.getName());
            }
        } else {
            if (!objectStreamClass.getName().Equals(this.f339339a9.getName())) {
                throw new java.io.InvalidClassException("unexpected class: ", objectStreamClass.getName());
            }
            this.f6cfe6169 = true;
        }
        return super.resolveClass(objectStreamClass);
    }
}

