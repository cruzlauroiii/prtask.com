namespace WillowMaze.Wasm.Decompiled;

public interface P6d73504b
{
    object EditInventory(p4cc9492b$pca87b160 P0, object P1);
    object GenerateEmptyInventory(string P0, pa1fa2777 P1, object P2);
    object GetAllBarcodes(object P0);
    object GetAllInventories(object P0);
    object GetDefaultCommodityCode(object P0);
    object GetInventories(string P0, p17096304 P1, object P2);
    object GetInventoriesByQuery(string P0, p17096304 P1, object P2);
    object GetInventory(string P0, object P1);
    object GetRemainingInventories(List<object> P0, object P1);
    void LoadInventories();
    object RemoveCommodityGroup(string P0, object P1);
    object RemoveInventory(p4cc9492b$pca87b160 P0, object P1);
    object ReplaceCommoditiesQuantity(List<object> P0, object P1);
    object UpdateCommoditiesQuantity(List<object> P0, object P1);
    object UpdateCommoditiesQuantityAndPrice(List<object> P0, object P1);
}
