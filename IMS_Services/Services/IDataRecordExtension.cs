using IMS_Services.Entities;
using IMS_Services.EnumUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Services.Services;

public static class IDataRecordExtension
{
    public static Staff ToStaff(this IDataRecord record)
    {
        int index = record.GetOrdinal("StaffID");
        short id = record.GetInt16(index);

        index = record.GetOrdinal("StaffName");
        string staffName = record.GetString(index);

        index = record.GetOrdinal("Gender");
        EnumGender gender = (EnumGender)record.GetByte(index);

        index = record.GetOrdinal("BirthDate");
        DateTime birthDate = record.GetDateTime(index);

        index = record.GetOrdinal("StaffPosition");
        string staffPos = record.GetString(index);

        index = record.GetOrdinal("Address");
        string adddress = record.GetString(index);

        index = record.GetOrdinal("WorkNumber");
        string workNum = record.GetString(index);

        index = record.GetOrdinal("PersonalNumber");
        string personalNum = record.GetString(index);

        index = record.GetOrdinal("HiredDate");
        DateTime hiredDate = record.GetDateTime(index);

        index = record.GetOrdinal("Salary");
        decimal salary = record.GetDecimal(index);

        index = record.GetOrdinal("StoppedWork");
        bool stoppedWork = record.GetBoolean(index);

        return new Staff()
        {
            StaffId = id,
            StaffName = staffName,
            Gender = gender,
            BirthDate = birthDate,
            StaffPosition = staffPos,
            Address = adddress,
            WorkNumber = workNum,
            PersonalNumber = personalNum,
            HiredDate = hiredDate,
            Salary = salary,
            StoppedWork = stoppedWork,
        };
    }
    public static Inventory ToInventory(this IDataRecord record)
    {
        int index = record.GetOrdinal("InvID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("UnitCost");
        decimal unitCost = record.GetDecimal(index);

        index = record.GetOrdinal("ExpirationDate");
        DateTime expDate = record.GetDateTime(index);

        index = record.GetOrdinal("CurrentStock");
        short curStock = record.GetInt16(index);

        index = record.GetOrdinal("InitialQty");
        short initQty = record.GetInt16(index);

        index = record.GetOrdinal("ProductID");
        int proID = record.GetInt32(index);

        index = record.GetOrdinal("ImportID");
        int impID = record.GetInt32(index);

        index = record.GetOrdinal("Note");
        string note = record.GetString(index);

        index = record.GetOrdinal("LastUpdate");
        DateTime lUpdate = record.GetDateTime(index);

        return new Inventory()
        {
            ID = id,
            UnitCost = unitCost,
            ExpirationDate = expDate,
            CurrentStock = curStock,
            InitialQty = initQty,
            ProductID = proID,
            ImportID = impID,
            Note = note,
            LastUpdate = lUpdate,
        };
    }
    public static Product ToProduct(this IDataRecord record)
    {
        int index = record.GetOrdinal("ProductID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("ProductName");
        string name = record.GetString(index);

        index = record.GetOrdinal("Barcode");
        string barcode = record.GetString(index);

        index = record.GetOrdinal("SalePrice");
        decimal price = record.GetDecimal(index);

        index = record.GetOrdinal("UOM");
        EnumUOM uom = (EnumUOM)record.GetByte(index);

        index = record.GetOrdinal("TotalStock");
        short totalStock = record.GetInt16(index);

        index = record.GetOrdinal("CategoryID");
        byte cateID = record.GetByte(index);

        return new Product()
        {
            ID = id,
            Name = name,
            Barcode = barcode,
            SalePrice = price,
            UOM = uom,
            TotalStock = totalStock,
            CategoryID = cateID,
        };
    }
}

