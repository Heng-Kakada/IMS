﻿using IMS_Services.EnumUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Services.Entities;

public class Supplier
{
    public byte ID { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public EnumPaymentMethod PaymentMethod { get; set; }
    public byte PaymentTerm { get; set; }
}