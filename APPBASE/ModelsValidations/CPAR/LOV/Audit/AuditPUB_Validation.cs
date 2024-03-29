﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using APPBASE;
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    public partial class Audit_Validation
    {
        private Audit_DetailVM oViewModel;
        private AuditDS oDS = new AuditDS();
        public List<ValidationMSG_VM> aValidationMSG = new List<ValidationMSG_VM>();

        //Constructor
        public Audit_Validation(Audit_DetailVM poViewModel)
        {
            oViewModel = poViewModel;
        } //End public Audit_Validation()
        public void Validate_Create()
        {
            //Validate_RUID();
            //Validate_LOV_ID();
            Validate_LOV_NM();
            Validate_DEPT_RUID();
        } //End public void Validate_Create()
        public void Validate_Edit()
        {
            //Validate_RUID();
            Validate_LOV_NM();
            Validate_DEPT_RUID();
        } //End public void Validate_Edit()
        public void Validate_Delete()
        {
            Validate_DELETE();
        } //End public void Validate_Delete()
    } //End public partial class Audit_Validation
} //End namespace APPBASE.Models

