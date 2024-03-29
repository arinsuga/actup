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
using APPBASE.Helpers;
using APPBASE.Models;
using APPBASE.Svcbiz;

namespace APPBASE.Models
{
    [Table("VWCPAR01PROJ_INFO")]
    public class Project_info
    {
        public string ADTRL_WKS { get; set; }
        public string ADTRL_IP { get; set; }
        public string ADTRL_USR { get; set; }
        public string ADTRL_PRG { get; set; }
        public DateTime? ADTRL_DT { get; set; }
        public int? RSEQNO { get; set; }
        [Key]
        public string RUID { get; set; }
        public string DTA_STS { get; set; }
        public string PROJ_ID { get; set; }
        public string PROJ_NM { get; set; }
        public string PROJ_STS { get; set; }
        public string PROJ_STS_ID { get; set; }
        public string PROJ_STS_NM { get; set; }
        public string CLIENT_RUID { get; set; }
        public string ISUSEDBY_COMPLAIN { get; set; }
    } //End public class Project_info
} //End namespace APPBASE.Models