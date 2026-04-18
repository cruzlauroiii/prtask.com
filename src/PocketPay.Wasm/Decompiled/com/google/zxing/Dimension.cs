namespace WillowMaze.Wasm.Decompiled;


public readonly class Dimension {
    private readonly int height;
    private readonly int width;

    public Dimension(int i, int i2) {
        if (i < 0 || i2 < 0) {
            throw new java.lang.IllegalArgumentException();
        }
        this.width = i;
        this.height = i2;
    }

    public static java.lang.string GFOcODCRNsuSPkjj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder SThhmtYkwuwAGLMR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JBCOErfkVrGIjxRA(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder KVjYkkSFGatDULhu(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public bool Equals(java.lang.object obj) {
        if ((20 + 15) % 15 > 0) {
        }
        if (obj is com.google.zxing.Dimension) {
            com.google.zxing.Dimension dimension = (com.google.zxing.Dimension) obj;
            if (this.width == dimension.width && this.height == dimension.height) {
                return true;
            }
        }
        return false;
    }

    public int GetHeight() {
        return this.height;
    }

    public int GetWidth() {
        return this.width;
    }

    public int HashCode() {
        return (this.width * 32713) + this.height;
    }

    public java.lang.string Tostring() {
        if ((1 + 9) % 9 > 0) {
        }
        return GFOcODCRNsuSPkjj(kVjYkkSFGatDULhu(SThhmtYkwuwAGLMR(jBCOErfkVrGIjxRA(new java.lang.stringBuilder(), this.width), "x"), this.height));
    }
}

