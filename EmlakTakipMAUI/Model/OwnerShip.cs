namespace EmlakTakipMAUI.Model;

public class OwnerShip
{
    public int id { get; set; }
    public string title { get; set; }
    public string contents { get; set; }
    public int cityId { get; set; }
    public int townId { get; set; }
    public int neighbourhoodId { get; set; }
    public string squareFeet { get; set; }
    public string? roomCount { get; set; }
    public string? bathCount { get; set; }
    public string? buildAge { get; set; }
    public bool? rentOrSale { get; set; }
    public string? floorLocation { get; set; }
    public string? totalFloor { get; set; }
    public bool? exchange { get; set; }
    public string? ada { get; set; }
    public string? parsel { get; set; }
    public string price { get; set; }
    public int customerId { get; set; }
    public bool status { get; set; }
    public int categoryId { get; set; }
}

