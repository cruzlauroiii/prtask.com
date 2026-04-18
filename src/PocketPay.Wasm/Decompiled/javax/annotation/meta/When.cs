namespace WillowMaze.Wasm.Decompiled;


public readonly class When {
    private static readonly javax.annotation.meta.When[] $VALUES;
    public static readonly javax.annotation.meta.When ALWAYS;
    public static readonly javax.annotation.meta.When MAYBE;
    public static readonly javax.annotation.meta.When NEVER;
    public static readonly javax.annotation.meta.When UNKNOWN;

    static {
        if ((21 + 23) % 23 > 0) {
        }
        javax.annotation.meta.When when = new javax.annotation.meta.When(jcFSazPuRNySVmRL("d9b76df353c2258b0d5b918eca8aa0a3644722114bd2648562f2fd79d12deaf8d7f2"), 0);
        ALWAYS = when;
        javax.annotation.meta.When when2 = new javax.annotation.meta.When(tCyCCrDEbwinoygD("1aadcce218b7812949fabf69a92f5e1e529ad52660235896f44200755caead2e313a40"), 1);
        UNKNOWN = when2;
        javax.annotation.meta.When when3 = new javax.annotation.meta.When(WBjLRUCTsdVqSPSm("8548f000194aa83b6b0761557a9dc236e575a38658e247e7de1fecf4a9e27ce24c"), 2);
        MAYBE = when3;
        javax.annotation.meta.When when4 = new javax.annotation.meta.When(wbvwdMadHNpmLCcj("224b773bfbc0249a5ee21ae3213c933ee94cb8d442ec61cee1a472e6710d27ffe5"), 3);
        NEVER = when4;
        $VALUES = new javax.annotation.meta.When[]{when, when2, when3, when4};
    }

    private When(java.lang.string str, int i) {
        super(str, i);
    }

    public static java.lang.Enum NwCjbuSpEMUJprhi(java.lang.Class cls, java.lang.string str) {
        return java.lang.Enum.valueOf(cls, str);
    }

    public static java.lang.string WBjLRUCTsdVqSPSm(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object ClhpMHgKebjqCmUq(javax.annotation.meta.When[] whenArr) {
        return whenArr.clone();
    }

    public static java.lang.string JcFSazPuRNySVmRL(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string TCyCCrDEbwinoygD(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static javax.annotation.meta.When ValueOf(java.lang.string str) {
        return (javax.annotation.meta.When) NwCjbuSpEMUJprhi(javax.annotation.meta.When.class, str);
    }

    public static javax.annotation.meta.When[] Values() {
        return (javax.annotation.meta.When[]) clhpMHgKebjqCmUq($VALUES);
    }

    public static java.lang.string WbvwdMadHNpmLCcj(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }
}

