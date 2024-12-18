﻿using IMS_Services.Entities;
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
}
