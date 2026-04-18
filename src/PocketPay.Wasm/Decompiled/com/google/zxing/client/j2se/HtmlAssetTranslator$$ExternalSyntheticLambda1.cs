namespace WillowMaze.Wasm.Decompiled;


public readonly class HtmlAssetTranslator$$ExternalSyntheticLambda1 : java.nio.file.DirectoryStream$Filter {
    public readonly java.util.ICollection f$0;

    public HtmlAssetTranslator$$ExternalSyntheticLambda1(java.util.ICollection collection) {
        this.f$0 = collection;
    }

    public static bool YnpiyKhAulvMkdtC(java.util.ICollection collection, java.nio.file.Path path) {
        return com.google.zxing.client.j2se.HtmlAssetTranslator.lambda$translateOneLanguage$1(collection, path);
    }

    public override readonly bool Accept(java.lang.object obj) {
        return YnpiyKhAulvMkdtC(this.f$0, (java.nio.file.Path) obj);
    }
}

