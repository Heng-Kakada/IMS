﻿using IMS_Services.EnumUtils;
using InventoryManagementSystem.Utils;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InventoryManagementSystem.Convertion;

public static class Convertor
{
    public static string ConvertToString(Control control)
    {
        return control.Text.Trim();
    }
    public static int ConvertToInt(Control control)
    {
        if (int.TryParse(control.Text.Trim(), out int data))
        {
            return data;
        }
        throw new Exception("Problem While Converting ...");
    }
    public static decimal ConvertToDecimal(Control control)
    {
        if (decimal.TryParse(control.Text.Trim(), out decimal data))
        {
            return data;
        }
        throw new Exception("Problem While Converting ...");
    }
    public static short ConvertToShort(Control control)
    {
        if (short.TryParse(control.Text.Trim(), out short data))
        {
            return data;
        }
        throw new Exception("Problem While Converting ...");
    }
    public static EnumGender ConvertToEnumGender(Control control)
    {
        return (EnumGender)Casting.CastCombobox(control).SelectedIndex;
    }
    public static string? ConvertToStringFromCbo(Control control)
    {
        if (control is ComboBox) {
            ComboBox castCbo = (ComboBox)control;
            return castCbo.SelectedItem!.ToString();
        }
        throw new Exception("Problem While Converting To String From Combo Box ....");
    }

    public static DateTime ConvertToDateTime(Control control)
    {
        return Casting.CastDateTimePicker(control).Value;
    }

    public static bool ConvertToBooleanFromCheckBox(Control control) {
         return Casting.CastCheckbox(control).Checked;
    }

}
