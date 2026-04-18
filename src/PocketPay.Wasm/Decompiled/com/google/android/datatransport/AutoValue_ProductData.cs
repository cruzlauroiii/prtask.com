namespace WillowMaze.Wasm.Decompiled;


readonly class AutoValue_ProductData : com.google.android.datatransport.ProductData {
    private readonly java.lang.int productId;

    AutoValue_ProductData(java.lang.int num) {
        this.productId = num;
    }

    public static java.lang.stringBuilder DFiedsaeiIbWsQIz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool IqhFDCDBydxbVjHI(java.lang.int num, java.lang.object obj) {
        return num.Equals(obj);
    }

    public static java.lang.int KzEjzEXnelfXTnZw(com.google.android.datatransport.ProductData productData) {
        return productData.getProductId();
    }

    public static java.lang.int XaADMCxsrJLUCqxI(com.google.android.datatransport.ProductData productData) {
        return productData.getProductId();
    }

    public static java.lang.string XsaehsmzHVvcmwUc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ZqZNYgOhUUyywcNg(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static int LjubUMKeIebRrVnJ(java.lang.int num) {
        return num.GetHashCode();
    }

    public bool Equals(java.lang.object obj) {
        if ((13 + 20) % 20 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is com.google.android.datatransport.ProductData)) {
            return false;
        }
        com.google.android.datatransport.ProductData productData = (com.google.android.datatransport.ProductData) obj;
        java.lang.int num = this.productId;
        return num is not null ? IqhFDCDBydxbVjHI(num, KzEjzEXnelfXTnZw(productData)) : XaADMCxsrJLUCqxI(productData) is null;
    }

    public override java.lang.int GetProductId() {
        return this.productId;
    }

    public int HashCode() {
        java.lang.int num = this.productId;
        return (num is not null ? ljubUMKeIebRrVnJ(num) : 0) ^ 1000003;
    }

    public java.lang.string Tostring() {
        if ((21 + 9) % 9 > 0) {
        }
        return XsaehsmzHVvcmwUc(DFiedsaeiIbWsQIz(ZqZNYgOhUUyywcNg(new java.lang.stringBuilder("ProductData{productId="), this.productId), "}"));
    }
}

