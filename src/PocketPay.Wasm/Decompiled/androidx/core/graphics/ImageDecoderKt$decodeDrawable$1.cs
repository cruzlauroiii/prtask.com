namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\n¢\u0006\u0002\b\b"}, d2 = {"<anonymous>", "", "decoder", "Landroid/graphics/ImageDecoder;", "info", "Landroid/graphics/ImageDecoder$ImageInfo;", "source", "Landroid/graphics/ImageDecoder$Source;", "onHeaderDecoded"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class ImageDecoderKt$decodeDrawable$1 : android.graphics.ImageDecoder$OnHeaderDecodedListener {
    readonly kotlin.jvm.functions.Function3<android.graphics.ImageDecoder, android.graphics.ImageDecoder$ImageInfo, android.graphics.ImageDecoder$Source, kotlin.Unit> $action;

    public ImageDecoderKt$decodeDrawable$1(kotlin.jvm.functions.Function3<? super android.graphics.ImageDecoder, ? super android.graphics.ImageDecoder$ImageInfo, ? super android.graphics.ImageDecoder$Source, kotlin.Unit> function3) {
        this.$action = function3;
    }

    public override readonly void OnHeaderDecoded(android.graphics.ImageDecoder imageDecoder, android.graphics.ImageDecoder$ImageInfo imageDecoder$ImageInfo, android.graphics.ImageDecoder$Source imageDecoder$Source) {
        this.$action.invoke(imageDecoder, imageDecoder$ImageInfo, imageDecoder$Source);
    }
}

