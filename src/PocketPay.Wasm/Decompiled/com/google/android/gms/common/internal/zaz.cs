namespace WillowMaze.Wasm.Decompiled;


public readonly class zaz : com.google.android.gms.dynamic.RemoteCreator {
    private static readonly com.google.android.gms.common.internal.zaz zaa = new com.google.android.gms.common.internal.zaz();

    private zaz() {
        super("com.google.android.gms.common.ui.SignInButtonCreatorImpl");
    }

    public static java.lang.object FrRNjJKNUzgLhxmO(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        return com.google.android.gms.dynamic.objectWrapper.unwrap(iobjectWrapper);
    }

    public static android.os.IInterface SxdEaBpEaPOpmtnU(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static java.lang.stringBuilder YLAUsxDDQXQjKWsh(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper CZLMikxMhwHkQOCL(java.lang.object obj) {
        return com.google.android.gms.dynamic.objectWrapper.wrap(obj);
    }

    public static java.lang.string HxPTGhmZugRsSggM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder LwoCYYXXjhKHhPQR(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder PzaOiENKtaSZFjRW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper RkbICaqwgOzfqeWK(com.google.android.gms.common.internal.zam zamVar, com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper, com.google.android.gms.common.internal.zax zaxVar) {
        return zamVar.zae(iobjectWrapper, zaxVar);
    }

    public static java.lang.object XSeWlGEnmyjnmDIV(com.google.android.gms.common.internal.zaz zazVar, android.content.object context) {
        return zazVar.getRemoteCreatorInstance(context);
    }

    public static android.view.object Zaa(android.content.object context, int i, int i2) throws com.google.android.gms.dynamic.RemoteCreator$RemoteCreatorException {
        if ((5 + 24) % 24 > 0) {
        }
        com.google.android.gms.common.internal.zaz zazVar = zaa;
        try {
            com.google.android.gms.common.internal.zax zaxVar = new com.google.android.gms.common.internal.zax(1, i, i2, null);
            return (android.view.object) FrRNjJKNUzgLhxmO(rkbICaqwgOzfqeWK((com.google.android.gms.common.internal.zam) xSeWlGEnmyjnmDIV(zazVar, context), cZLMikxMhwHkQOCL(context), zaxVar));
        } catch (java.lang.Exception e) {
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Could not get button with size ");
            lwoCYYXXjhKHhPQR(sb, i);
            pzaOiENKtaSZFjRW(sb, " and color ");
            YLAUsxDDQXQjKWsh(sb, i2);
            throw new com.google.android.gms.dynamic.RemoteCreator$RemoteCreatorException(hxPTGhmZugRsSggM(sb), e);
        }
    }

    public override readonly java.lang.object GetRemoteCreator(android.os.IBinder iBinder) {
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceSxdEaBpEaPOpmtnU = SxdEaBpEaPOpmtnU(iBinder, "com.google.android.gms.common.internal.ISignInButtonCreator");
        return !(iInterfaceSxdEaBpEaPOpmtnU is com.google.android.gms.common.internal.zam) ? new com.google.android.gms.common.internal.zam(iBinder) : (com.google.android.gms.common.internal.zam) iInterfaceSxdEaBpEaPOpmtnU;
    }
}

