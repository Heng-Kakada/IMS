using IMS_Services.Entities;
using InventoryManagementSystem.Controller;
using InventoryManagementSystem.Convertion;

namespace InventoryManagementSystem.Utils;

public static class CreatorEntities
{
    public static Staff CreateStaff(Control[] controls)
    {

        return new Staff()
        {
            StaffName = Convertor.ConvertToString(controls[1]),
            Gender = Convertor.ConvertToEnumGender(controls[2]),
            BirthDate = Convertor.ConvertToDateTime(controls[3]),
            StaffPosition = Convertor.ConvertToStringFromCbo(controls[4]),
            Address = Convertor.ConvertToString(controls[5]),
            WorkNumber = Convertor.ConvertToString(controls[6]),
            PersonalNumber = Convertor.ConvertToString(controls[7]),
            HiredDate = Convertor.ConvertToDateTime(controls[8]),
            Salary = Convertor.ConvertToDecimal(controls[9]),
            StoppedWork = Convertor.ConvertToBooleanFromCheckBox(controls[10]),
        };
        
    }

    public static Product CreateProduct(Control[] controls)
    {
        return new Product()
        {
            Name = Convertor.ConvertToString(controls[1]),
            Barcode = Convertor.ConvertToString(controls[2]),
            SalePrice = Convertor.ConvertToDecimal(controls[3]),
            UOM = Convertor.ConvertToEnumUOM(controls[4]),
            TotalStock = Convertor.ConvertToShort(controls[5]),
            CategoryID = Convertor.ConvertToCategoryID(controls[6]),
        };
    }
    public static Inventory CreateInventory(Control[] controls)
    {
        return new Inventory()
        {
            Note = Convertor.ConvertToString(controls[0]),
            UnitCost = Convertor.ConvertToDecimal(controls[1]),
            InitialQty = Convertor.ConvertToShort(controls[2]),
            CurrentStock = Convertor.ConvertToShort(controls[3]),
            ExpirationDate = Convertor.ConvertToDateTime(controls[4]),
            ProductID = Convertor.ConvertToProductID(controls[5]),
            LastUpdate = DateTime.Now,
        };
    }

}
