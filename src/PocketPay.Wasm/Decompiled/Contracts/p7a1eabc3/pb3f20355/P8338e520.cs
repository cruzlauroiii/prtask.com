namespace WillowMaze.Wasm.Decompiled;

public interface P8338e520
{
    object ClearInventories(object P0);
    object EditCommodity(p4cc9492b$pca87b160 P0, object P1);
    object EditCommodityGroup(p0ded097a P0, object P1);
    object GetAllCommodities(object P0);
    object GetAllCommoditiesByQuery(string P0, object P1);
    object GetCommoditiesByParentId(string P0, object P1);
    object GetCommodityById(string P0, object P1);
    object GetCommodityGroupById(string P0, object P1);
    object GetCommodityGroups(object P0);
    object GetCommodityGroupsByParentId(string P0, object P1);
    void LoadInventories();
    object RemoveCommodity(p4cc9492b$pca87b160 P0, object P1);
    object RemoveCommodityGroup(string P0, object P1);
    object ReplaceCommoditiesQuantity(List<object> P0, object P1);
    object UpdateCommoditiesQuantity(List<object> P0, object P1);
    object UpdateCommoditiesQuantityAndPrice(List<object> P0, object P1);
}
