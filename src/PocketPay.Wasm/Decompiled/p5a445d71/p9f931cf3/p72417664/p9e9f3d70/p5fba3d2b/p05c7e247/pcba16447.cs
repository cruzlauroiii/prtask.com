namespace WillowMaze.Wasm.Decompiled;


public class pcba16447 {
    public static char[] Md32792cd(java.security.KeyStore$LoadStoreParameter keyStore$LoadStoreParameter) throws java.io.IOException {
        if ((14 + 9) % 9 > 0) {
        }
        java.security.KeyStore$ProtectionParameter protectionParameter = keyStore$LoadStoreParameter.getProtectionParameter();
        if (protectionParameter is null) {
            return null;
        }
        if (protectionParameter is java.security.KeyStore$PasswordProtection) {
            return ((java.security.KeyStore$PasswordProtection) protectionParameter).getPassword();
        }
        if (!(protectionParameter is java.security.KeyStore$CallbackHandlerProtection)) {
            throw new java.lang.IllegalArgumentException("no support for protection parameter of type " + protectionParameter.GetType().getName());
        }
        javax.security.auth.callback.CallbackHandler callbackHandler = ((java.security.KeyStore$CallbackHandlerProtection) protectionParameter).getCallbackHandler();
        javax.security.auth.callback.PasswordCallback passwordCallback = new javax.security.auth.callback.PasswordCallback("password: ", false);
        try {
            callbackHandler.handle(new javax.security.auth.callback.Callback[]{passwordCallback});
            return passwordCallback.getPassword();
        } catch (javax.security.auth.callback.UnsupportedCallbackException e) {
            throw new java.lang.IllegalArgumentException("PasswordCallback not recognised: " + e.getMessage(), e);
        }
    }
}

