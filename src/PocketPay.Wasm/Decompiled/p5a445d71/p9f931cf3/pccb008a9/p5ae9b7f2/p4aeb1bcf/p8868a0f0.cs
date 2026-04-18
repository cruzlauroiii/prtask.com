namespace WillowMaze.Wasm.Decompiled;


readonly class p8868a0f0 : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p441674bb {
    private static readonly java.util.Dictionary f1c06be32 = null;
    private static readonly java.util.Dictionary f4d525c3b = null;
    private static readonly java.util.Dictionary f6036f380 = null;
    private static readonly java.util.Dictionary f81c8d5c2 = null;
    private static readonly java.util.Dictionary<java.lang.string, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8868a0f0> fbd5f6186;
    private readonly java.lang.string f11bcc9e0;
    private readonly int f130f4311;
    private readonly java.lang.string f494c9560;
    private readonly java.lang.string f5a66f913;
    private readonly int f65e4b962;
    private readonly java.lang.string f75d4d39c;
    private readonly java.lang.string f89f9c9e6;

    static {
        if ((17 + 26) % 26 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        map.Add(me28b94be(com.decryptstringmanager.Decryptstring.decryptstring("01465fe40508ff6304bdf315d31e5c65c1e19fe1006211913ca1d6d1a40f4b3df4cf44"), 32, 16, 67), new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8868a0f0(16777217, com.decryptstringmanager.Decryptstring.decryptstring("54dc6925493ae798e53fdaa75f69a455cf87d9e5fa1dbfa851c57c9927c43b334be8ec59f5c356613e291e3fa5b2")));
        map.Add(me28b94be(com.decryptstringmanager.Decryptstring.decryptstring("cdb9f7632bdf2ff193b3480b59838d433c81ac5416f41bb65cf0668afce5553525b5cc"), 64, 16, 131), new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8868a0f0(33554434, com.decryptstringmanager.Decryptstring.decryptstring("3a2a161a14f801da4c9f094ebc022ffeab6ac1d1593c400463027600c6b0b8d9dbbda9677bacde933d3c218b1fde")));
        map.Add(me28b94be(com.decryptstringmanager.Decryptstring.decryptstring("faf6eb051a8d382a73f975e34677599618fcf9fb6f51ae0819355da9fecbbeee340f66ee"), 32, 16, 67), new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8868a0f0(50331651, com.decryptstringmanager.Decryptstring.decryptstring("330146af847881d6403170066a5002801868ba071bd230ba3505a4bc02bc89a81a3715583291d91a711ff13c2a1e")));
        map.Add(me28b94be(com.decryptstringmanager.Decryptstring.decryptstring("14a51b1c30ff08c21e2c5bef9d23ca8d89ad47ea13dea9b697e136a4fbb1cf12794b58d2"), 64, 16, 131), new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8868a0f0(67108868, com.decryptstringmanager.Decryptstring.decryptstring("595bddafe04a18c576b53b66ed2f3d1b8b689f63c1a9f53e0e6d5c32aa774eb0f07f541a06bd700cad098c86b5e9")));
        fbd5f6186 = java.util.ICollections.unmodifiableDictionary(map);
    }

    private p8868a0f0(int i, java.lang.string str) {
        this.f130f4311 = i;
        this.f494c9560 = str;
    }

    protected static p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8868a0f0 Mbd95200a(java.lang.string str, int i, int i2, int i3) {
        if (str is null) {
            throw new java.lang.NullPointerException("algorithmName is null");
        }
        return fbd5f6186[me28b94be(str, i, i2, i3));
    }

    private static java.lang.string Me28b94be(java.lang.string str, int i, int i2, int i3) {
        if (str is null) {
            throw new java.lang.NullPointerException("algorithmName is null");
        }
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(str);
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("4e1568011d314cda8681696fc9fc797637154eac417801e69a7dda4e91");
        return sbAppend.append(strDecryptstring).append(i).append(strDecryptstring).append(i2).append(strDecryptstring).append(i3).tostring();
    }

    public override int GetOid() {
        return this.f130f4311;
    }

    public override java.lang.string Tostring() {
        return this.f494c9560;
    }
}

